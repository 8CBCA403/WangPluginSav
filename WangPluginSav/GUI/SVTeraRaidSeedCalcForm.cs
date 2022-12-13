using PKHeX.Core;
using System.ComponentModel;
using System.Net;
using Newtonsoft.Json;
using WangPluginSav.WangDataBase;
using PKHeX.Drawing;
using PKHeX.Drawing.PokeSprite;
using System.Reflection;
using WangPluginSav.WangUtil;

namespace WangPluginSav.GUI
{
    public partial class SVTeraRaidSeedCalcForm : Form
    {
        private ISaveFileProvider SAV { get; }
        public IPKMView PKMEditor { get; }
        private CancellationTokenSource tokenSource = new();
        private Raid Raidinfo = new();
        private const string SeedFilter = "Trainer Info |*.txt|All Files|*.*";
        private const string DisFilter = "Trainer Info |*.DIS|All Files|*.*";
        private static Image map = Image.FromStream(new MemoryStream(Utils.GetBinaryResource("paldea.png")));
        private string[]? lines;
        private TeraRaidDisplayType[] a = new TeraRaidDisplayType[72];
        private byte[] b = new byte[72];
        private const uint KUnlockedRaidDifficulty3 = 0xEC95D8EF; // FSYS_RAID_DIFFICTLTY3_RELEASE
        private const uint KUnlockedRaidDifficulty4 = 0xA9428DFE; // FSYS_RAID_DIFFICTLTY4_RELEASE
        private const uint KUnlockedRaidDifficulty5 = 0x9535F471; // FSYS_RAID_DIFFICTLTY5_RELEASE
        private const uint KUnlockedRaidDifficulty6 = 0x6E7F8220; // FSYS_RAID_DIFFICTLTY6_RELEASE
        private const uint KUnlockedTeraRaidBattles = 0x27025EBF; // FSYS_RAID_SCENARIO_00
        private static Dictionary<string, double[]>? den_locations= Area.A();
        public static readonly GameStrings strings = GameInfo.GetStrings("zh");
        private List<RaidFixedRewards>? BaseFixedRewards = new();
        private List<RaidLotteryRewards>? BaseLotteryRewards = new();
        private static List<DeliveryRaidFixedRewardItem>? DeliveryRaidFixedRewards = new();
        private static List<DeliveryRaidLotteryRewardItem>? DeliveryRaidLotteryRewards = new();
        public SVTeraRaidSeedCalcForm(ISaveFileProvider sav, IPKMView edit)
        {
            SAV = sav;
            PKMEditor = edit;
            Raid.GemTeraRaids = TeraEncounter.GetAllEncounters("encounter_gem_paldea.pkl");
            Raid.DistTeraRaids = TeraDistribution.GetAllEncounters("raid_enemy_array");
            Raid.Game = "Violet";
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName1 = assembly.GetManifestResourceNames().Single(str => str.EndsWith("1.txt"));
            string resourceName2 = assembly.GetManifestResourceNames().Single(str => str.EndsWith("2.txt"));
            var text1 = GetFromResources(resourceName1);
            var text2= GetFromResources(resourceName2);
            BaseLotteryRewards = JsonConvert.DeserializeObject<List<RaidLotteryRewards>>(text1 ?? "[]");
            BaseFixedRewards = JsonConvert.DeserializeObject<List<RaidFixedRewards>>(text2 ?? "[]");
            DeliveryRaidFixedRewards = FlatbufferDumper.DumpFixedRewards("fixed_reward_item_array");
            DeliveryRaidLotteryRewards = FlatbufferDumper.DumpLotteryRewards("lottery_reward_item_array");

            SpriteBuilder.ShowTeraThicknessStripe = 0x4;
            SpriteBuilder.ShowTeraOpacityStripe = 0xAF;
            SpriteBuilder.ShowTeraOpacityBackground = 0xFF;
            InitializeComponent();
            BindingData();
        }
        static string GetFromResources(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return result;
            }
        }
        public void BindingData()
        {
            RaidTypeBox.DataSource = Enum.GetValues(typeof(TeraRaidContentType));
            RaidTypeBox.SelectedIndex= 0;
            SPcomboBox.DataSource = Enum.GetValues(typeof(TeraSpecies));
            SPcomboBox.DisplayMember = "Name";
            TeracomboBox.DataSource = Enum.GetValues(typeof(MoveType));
            TeracomboBox.SelectedIndex = 18;
            NaturecomboBox.DataSource=Enum.GetValues(typeof(Nature));
            NaturecomboBox.SelectedIndex = 25;
            EventProgress.DataSource = Enum.GetValues(typeof(EV));
            EventProgress.SelectedIndex = 3;
            Game.DataSource = Enum.GetValues(typeof(GameN));
            Game.DisplayMember = "Name";
            StarcomboBox.DataSource = Enum.GetValues(typeof(star));
            StarcomboBox.SelectedIndex = 4;
            StepcomboBox.DataSource = Enum.GetValues(typeof(Step));
            RewardBoostBox.DataSource= Enum.GetValues(typeof(Boost));
            RewardBoostBox.SelectedIndex = 0;
            GencomboBox.DataSource = Enum.GetValues(typeof(Gend));
            GencomboBox.DisplayMember = "Name";
            GencomboBox.SelectedIndex = 3;
            ProgressBox.DisplayMember = "Description";
            ProgressBox.ValueMember = "Value";
            ProgressBox.DataSource = Enum.GetValues(typeof(NV))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            ProgressBox.SelectedIndex = 4;
        }
        private void GeneratorIsRunning(bool running)
        {
            RUN_BTN.Enabled = false;
        }
        private void GeneratorIsNotRunning(bool running)
        {
            RUN_BTN.Enabled = true;
        }
        private void Game_SelectedIndexChanged(object sender, EventArgs e)
        {
            Raid.Game = Game.Text;
        }
        private void Perfect_BTN_Click(object sender, EventArgs e)
        {
            var str = SeedBox.Text;
            var seed = Convert.ToUInt32(str, 16);
            displayRiad(seed);
        }
        private static string IVsString(int[] ivs)
        {
            string s = string.Empty;
            for (int i = 0; i < ivs.Length; i++)
            {
                s += $"{ivs[i]:D2}";
                if (i < 5)
                    s += "/";
            }
            return s;
        }

        private PKM displayRiad(uint seed)
        {
            var rand = new Xoroshiro128Plus(seed);
            string r;
            int StarCount;
            Raidinfo.Seed = seed;
            SeedBox.Text = $"{Raidinfo.Seed:X8}";
            ECBox.Text = $"{Raidinfo.EC:X8}";
            PIDBox.Text = $"{Raidinfo.PID:X8}";
            Raidinfo.IsEvent = IsEvent.Checked;
         //   Raidinfo.IsC = IsC.Checked;
            if(StarcomboBox.SelectedIndex==5)
                Raidinfo.IsBlack =true;
            else
                Raidinfo.IsBlack = false;
            var progress = Raidinfo.IsEvent ? EventProgress.SelectedIndex : ProgressBox.SelectedIndex;
            ITeraRaid? encounter = Raidinfo.Encounter(progress);
            var teratype = GetTeraType(encounter, Raidinfo);
            TeraBox.Text = $"{Raid.strings.types[teratype]}";
            StarCount = encounter is TeraDistribution ? encounter.Stars : Raid.GetStarCount(Raidinfo.Difficulty, ProgressBox.SelectedIndex, Raidinfo.IsBlack);
            DiffBox.Text = Raidinfo.IsEvent ? string.Concat(Enumerable.Repeat("☆", StarCount)) : string.Concat(Enumerable.Repeat("☆", StarCount)) + $" ({Raidinfo.Difficulty})";
            if (encounter != null)
            {
                var param = GetParam(encounter);
                var blank = new PK9();
                blank.Species = encounter.Species;
                blank.Form = encounter.Form;
                blank.TeraTypeOriginal =(MoveType)teratype;
                Encounter9RNG.GenerateData(blank, param, EncounterCriteria.Unrestricted, Raidinfo.Seed);
                SpeciesTextBox.Text = $"{Raid.strings.Species[encounter.Species]} ({encounter.Species})";
                switch ((Gend)blank.Gender)
                {
                    case Gend.Male:
                        GenderBox.Text = $"公";
                        break;
                    case Gend.Female:
                        GenderBox.Text = "母";
                        break;
                    case Gend.Genderless:
                        GenderBox.Text = "无性别";
                        break;
                }
                var nature = blank.Nature;
                FormBox.Text = $"{blank.Form}";
                NatureBox.Text = $"{Raid.strings.Natures[nature]}";
                AbilityBox.Text = $"{Raid.strings.Ability[blank.Ability]}";
                Move1Box.Text = Raid.strings.Move[encounter.Move1];
                Move2Box.Text = Raid.strings.Move[encounter.Move2];
                Move3Box.Text = Raid.strings.Move[encounter.Move3];
                Move4Box.Text = Raid.strings.Move[encounter.Move4];
                IVBOX.Text = IVsString(ToSpeedLast(blank.IVs));
                HeightBox.Text = $"{blank.HeightScalar}";
                WeightBox.Text = $"{blank.WeightScalar}";
                ScaleBox.Text = $"{blank.Scale}";
                r = $"\nSeed:{Raidinfo.Seed:X8} 星级：{DiffBox.Text} 种类: {SpeciesTextBox.Text} 性别: {GenderBox.Text} 性格:{NatureBox.Text} 特性:{AbilityBox.Text} IV:{IVsString(ToSpeedLast(blank.IVs))}" +
             $" 太晶: {Raid.strings.types[teratype]} ({teratype})";
                ResultBox.Text += "\n" + r;
                if (Raidinfo.IsShiny)
                {
                    PIDBox.BackColor = Color.Gold;

                }
                else
                {
                    PIDBox.BackColor = Color.Gray;
                }

                if (IVBOX.Text is "31/31/31/31/31/31")
                {
                    IVBOX.BackColor = Color.YellowGreen;
                }
                else
                {
                    IVBOX.BackColor = Color.Gray;
                }
                return blank;
            }
          
            else
            {
                GenderBox.Text = string.Empty;
                NatureBox.Text = string.Empty;
                AbilityBox.Text = string.Empty;
                Move1Box.Text = string.Empty;
                Move2Box.Text = string.Empty;
                Move3Box.Text = string.Empty;
                Move4Box.Text = string.Empty;
            }
           
            return PKMEditor.Data;
        }

        private void Search_BTN_Click(object sender, EventArgs e)
        {
            GeneratorIsRunning(true);
            tokenSource = new();
            var str = SeedBox.Text;
            var seed = Convert.ToUInt32(str, 16);
            float i = 0;
            
            RaidFilters r = new()
            {
                Species =(Species)((int)SPcomboBox.SelectedValue),
                Nature = (Nature)NaturecomboBox.SelectedIndex,
                Gender=(Gend)GencomboBox.SelectedIndex,
                Tera=(MoveType)TeracomboBox.SelectedIndex,
                Shiny =ShinyBox.Checked,
                Stars = StarcomboBox.SelectedIndex+1,
                minHP=Convert.ToInt16(HP_MIN.Text),
                maxHP= Convert.ToInt16(HP_MAX.Text),
                minAtk= Convert.ToInt16(ATK_MIN.Text),
                maxAtk= Convert.ToInt16(ATK_MAX.Text),
                minDef= Convert.ToInt16(DEF_MIN.Text),
                maxDef= Convert.ToInt16(DEF_MAX.Text),
                minSpA= Convert.ToInt16(SPA_MIN.Text),
                maxSpA= Convert.ToInt16(SPA_MAX.Text),
                minSpD= Convert.ToInt16(SPD_MIN.Text),
                maxSpD= Convert.ToInt16(SPD_MAX.Text),
                minSpe= Convert.ToInt16(SPE_MIN.Text),
                maxSpe= Convert.ToInt16(SPE_MAX.Text),
             };
 
            Task.Factory.StartNew(
               () =>
               {
                   while (i< 4294967295)
                   {
                       i++;
                       if (tokenSource.IsCancellationRequested)
                       {
                           return;
                       }
                       if(StepcomboBox.SelectedIndex==0)
                       {
                           seed++;
                       }
                       else
                       {
                           seed = Util.Rand32();
                       }
                       SeedBox.Text = $"{seed:X}";
                       Raidinfo.Seed = seed;
                       if (StarcomboBox.SelectedIndex == 5)
                           Raidinfo.IsBlack = true;
                       else
                           Raidinfo.IsBlack = false;
                       if (r.FilterSatisfied(Raidinfo, ProgressBox.SelectedIndex,EventProgress.SelectedIndex))
                       {
                           this.Invoke(() =>
                           {
                               SeedBox.Text = $"{seed:X}";
                               displayRiad(seed);
                               
                           });
                           if (StepcomboBox.SelectedIndex == 1)
                           {
                               break;
                           }
                        }
                   }
            this.Invoke(() =>
            {
                GeneratorIsNotRunning(true);

            });
        },
                tokenSource.Token);
        }

        private void Stop_BTN_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            GeneratorIsNotRunning(true);
        }
        private static uint ReverseSeed(uint EC) => EC - (uint)(Xoroshiro.XOROSHIRO_CONST & 0xFFFFFFFF);
        private static byte GetGender(ITeraRaid enc)
        {
            if (enc is not TeraDistribution td || td.Entity is EncounterDist9)
                return (byte)PersonalTable.SV.GetFormEntry(enc.Species, enc.Form).Gender;
            if (td.Entity is EncounterMight9 em)
                return em.Gender switch
                {
                    0 => PersonalInfo.RatioMagicMale,
                    1 => PersonalInfo.RatioMagicFemale,
                    2 => PersonalInfo.RatioMagicGenderless,
                    _ => (byte)PersonalTable.SV.GetFormEntry(enc.Species, enc.Form).Gender,
                };
            return (byte)PersonalTable.SV.GetFormEntry(enc.Species, enc.Form).Gender;
        }

        private static GenerateParam9 GetParam(ITeraRaid encounter)
        {
            var gender = GetGender(encounter);
            if (encounter is TeraDistribution td && td.Entity is EncounterMight9 em)
                return new GenerateParam9(gender, em.FlawlessIVCount, 1, 0, 0, em.Scale, em.Ability, em.Shiny, em.Nature, em.IVs);
            return new GenerateParam9(gender, encounter.FlawlessIVCount, 1, 0, 0, 0, encounter.Ability, encounter.Shiny);
        }

        private static int[] ToSpeedLast(int[] ivs)
        {
            var res = new int[6];
            res[0] = ivs[0];
            res[1] = ivs[1];
            res[2] = ivs[2];
            res[3] = ivs[4];
            res[4] = ivs[5];
            res[5] = ivs[3];
            return res;
        }

        private int GetTeraType(ITeraRaid? encounter, Raid raid)
        {
            if (encounter == null)
                return raid.TeranType;
            if (encounter is TeraDistribution td && td.Entity is ITeraRaid9 gem)
                return (int)gem.TeraType > 1 ? (int)gem.TeraType - 2 : raid.TeranType;
            return raid.TeranType;
        }

        private void Shiny_Fix_BTN_Click(object sender, EventArgs e)
        {
            getblock();
        }
        public void getblock()
        {
            if (SAV.SAV is ISCBlockArray w1)
            { 
                SCBlockAccessor blockinfo = w1.Accessor;
                var p1=blockinfo.GetBlock(KUnlockedTeraRaidBattles).Type;
                if (p1 == SCTypeCode.Bool1)
                   Progress1Box.Checked=false;
                else
                    Progress1Box.Checked = true;
                var p2 = blockinfo.GetBlock(KUnlockedRaidDifficulty3).Type;
                if (p2 == SCTypeCode.Bool1)
                    Progress2Box.Checked = false;
                else
                    Progress2Box.Checked = true;
                var p3 = blockinfo.GetBlock(KUnlockedRaidDifficulty4).Type;
                if (p3 == SCTypeCode.Bool1)
                    Progress3Box.Checked = false;
                else
                    Progress3Box.Checked = true;
                var p4 = blockinfo.GetBlock(KUnlockedRaidDifficulty5).Type;
                if (p4 == SCTypeCode.Bool1)
                    Progress4Box.Checked = false;
                else
                    Progress4Box.Checked = true;
                var p5 = blockinfo.GetBlock(KUnlockedRaidDifficulty6).Type;
                if (p5 == SCTypeCode.Bool1)
                    Progress5Box.Checked = false;
                else
                    Progress5Box.Checked = true;
            }         
            
        }
        private static uint GetShinyPID( int tid,  int sid,  uint pid)
        {
            return (uint)(((tid ^ sid ^ (pid & 0xFFFF) ^ 1) << 16) | (pid & 0xFFFF));
        }

        private void ModifySav_Click(object sender, EventArgs e)
        {
            if (SAV.SAV is SAV9SV sv)
            {
                SAV_Raid9(sv, sv.Raid);
            }
        }

        private void ImportSeed_BTN_Click(object sender, EventArgs e)
        {
            using var sfd = new OpenFileDialog
            {
                Filter = SeedFilter,
                FilterIndex = 0,
                RestoreDirectory = true,
            };
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            string path = sfd.FileName;
            lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                MutiSeedBox.Text += line+'\n'; 
            }
        }
        private void ModSav_BTN_Click(object sender, EventArgs e)
        {
            if (SAV.SAV is SAV9SV sv)
            {
                SetRaid9(sv.Raid);
                
            }
        }
        public void SetRaid9(RaidSpawnList9 raid)
        {
            var n = lines.Count();
            var r = 69 / n;
            var s = 69 % n;
            if (n != 0)
            {
                if (!LoopBox.Checked)
                {
                    for (int i = 0; i < n; i++)
                    {
                        var r1 = raid.GetRaid(i);
                        r1.IsEnabled = true;
                        r1.Seed = Convert.ToUInt32(lines[i], 16);
                        r1.Content = (TeraRaidContentType)RaidTypeBox.SelectedIndex;
                        if (b[0] != 4)
                        {
                            if (b[i] == 0)
                                a[i] = TeraRaidDisplayType.None;
                            else if (b[i] == 1)
                                a[i] = TeraRaidDisplayType.Unrestricted;
                            else if (b[i] == 2)
                                a[i] = TeraRaidDisplayType.RequiresRide;
                            r1.DisplayType = a[i];
                        }
                    }
                }
                else
                {
                    for(int i=0;i<r;i++)
                    {
                        for(int j=0;j<n;j++)
                        {
                            var r1 = raid.GetRaid(i*n+j);
                            r1.IsEnabled = true;
                            r1.Seed = Convert.ToUInt32(lines[j], 16);
                            r1.Content = (TeraRaidContentType)RaidTypeBox.SelectedIndex;
                            if (b[0] != 4)
                            {
                                if (b[i * n + j] == 0)
                                    a[i * n + j] = TeraRaidDisplayType.None;
                                else if (b[i * n + j] == 1)
                                    a[i * n + j] = TeraRaidDisplayType.Unrestricted;
                                else if (b[i * n + j] == 2)
                                    a[i * n + j] = TeraRaidDisplayType.RequiresRide;
                                r1.DisplayType = a[i];
                            }
                        }
                    }
                }
            }
            Validate();

        }
        public void CloseAllRaid(RaidSpawnList9 raid)
        {
            for (int i = 0; i < 69; i++)
            {
                var r1 = raid.GetRaid(i);
                a[i]=r1.DisplayType;
                if (a[i] == TeraRaidDisplayType.None)
                    b[i] = 0;
                else if (a[i] == TeraRaidDisplayType.Unrestricted)
                    b[i] = 1;
                else if (a[i] == TeraRaidDisplayType.RequiresRide)
                    b[i] = 2;
            }
            using var sfd = new SaveFileDialog
            {
                FileName = "DisplayBackup",
                Filter = DisFilter,
                FilterIndex = 0,
                RestoreDirectory = true,
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            File.WriteAllBytes(sfd.FileName, b);
            for (int i = 0; i < 69; i++)
            {
                var r1 = raid.GetRaid(i);
                r1.IsEnabled = false;
                r1.Seed = 0;
                r1.IsClaimedLeaguePoints = false;
                r1.DisplayType=TeraRaidDisplayType.None;
                r1.Content = TeraRaidContentType.Base05;
            }
            Validate();

        }
        public void SAV_Raid9(SaveFile sav, RaidSpawnList9 raid)
        {
            var R = raid.CountUsed;
            for (int i = 0; i < R; i++)
            {
                var r1 = raid.GetRaid(i);
                r1.IsEnabled = true;
                r1.Seed = Convert.ToUInt32(ModSeedText.Text, 16);
                r1.Content = (TeraRaidContentType)RaidTypeBox.SelectedIndex;
                if (b[0] != 4)
                {
                    if (b[i] == 0)
                        a[i] = TeraRaidDisplayType.None;
                    else if (b[i] == 1)
                        a[i] = TeraRaidDisplayType.Unrestricted;
                    else if (b[i] ==2)
                        a[i] = TeraRaidDisplayType.RequiresRide;
                    r1.DisplayType = a[i];
                }

            }
            Validate();

        }
        private void CloseAll_BTN_Click(object sender, EventArgs e)
        {
            if (SAV.SAV is SAV9SV sv)
            {
                CloseAllRaid(sv.Raid);
            }
        }
        private void ImportDIS_BTN_Click(object sender, EventArgs e)
        {
            using var sfd = new OpenFileDialog
            {
                Filter = DisFilter,
                FilterIndex = 0,
                RestoreDirectory = true,
            };
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            string path = sfd.FileName;
            b = File.ReadAllBytes(path);
        }

        private void ConnectBTN_Click(object sender, EventArgs e)
        {
            HttpWebRequest req =(HttpWebRequest)HttpWebRequest.Create($"{SeedUrlBox.Text}");
            string result = "";
            req.Method = "POST";   
            req.ContentType = "application/json";
            string shp = null;
            string satk = null;
            string sdef = null;
            string sspa = null;
            string sspd = null;
            string sspe = null;
            if (HP_MAX.Text != "0")
                shp = HP_MIN.Text;
            if (ATK_MAX.Text != "0")
                satk = ATK_MIN.Text;
            if (DEF_MAX.Text != "0")
                sdef = DEF_MIN.Text;
            if (SPA_MAX.Text != "0")
                sspa = SPA_MIN.Text;
            if (SPD_MAX.Text != "0")
                sspd = SPD_MIN.Text;
            if (SPE_MAX.Text != "0")
                sspe = SPE_MIN.Text;
            using (var streamWriter = new StreamWriter(req.GetRequestStream()))
              {

                  string json = JsonConvert.SerializeObject(
                  new { 
                      version="朱",
                      speciesNumber= $"{(int)SPcomboBox.SelectedValue}",
                      sex=$"{GanderCN()}",
                    //  nature=$"{strings.Natures[NaturecomboBox.SelectedIndex]}",
                      page=1,limit=1,
                      level="5",
                      hp=shp,
                      atk=satk,
                      def=sdef,
                      spa=sspa,
                      spd=sspd,
                      spe=sspe,
                      difficulty="☆☆☆☆",
                      remark = $"朱5{(int)SPcomboBox.SelectedValue}{GanderCN()}11"
                  });

                  streamWriter.Write(json);
                  streamWriter.Flush();
              }
       
            var httpResponse = (HttpWebResponse)req.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
                
            }
            var s1=result.Split(new string[] { ",\"id\":\"" }, StringSplitOptions.None);
            var s2 = s1[1].Split(new string[] { "\",\"seed" }, StringSplitOptions.None);
            var s3 = s2[0];
            IDBox.Text = s3;
            Random rnd = new();
            var key = Util.Rand64(rnd);
            key = key + Xoroshiro.XOROSHIRO_CONST;
            
            KeyBox.Text = $"{key:X8}";

        }

        private void OrderBTN_Click(object sender, EventArgs e)
        {
            
            HttpWebRequest po = (HttpWebRequest)HttpWebRequest.Create($"{OrderUrlBox.Text}");
            po.Method = "POST";
            po.ContentType = "application/json";
            using (var streamWriter = new StreamWriter(po.GetRequestStream()))
            {
                string json = "[{\"order\":\""+$"{KeyBox.Text}" +"\"," +
                              "\"seedid\":\""+$"{IDBox.Text}"+"\"," +
                              "\"level\":\"5\"," +
                              "\"version\":\"朱\"}]";

                streamWriter.Write(json);
            }
          
            var httpResponse = (HttpWebResponse)po.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                ResultBox.Text = result;
            }
        }
        private string GanderCN()
        {
            string r = "公";
            switch ((Gend)GencomboBox.SelectedIndex)
            {
                case Gend.Male:
                    r = $"公";
                    break;
                case Gend.Female:
                    r = "母";
                    break;
                case Gend.Genderless:
                    r = "无性别";
                    break;
            }
            return r;
        }

        private void FixPID_BTN_Click(object sender, EventArgs e)
        {
            var p = GetShinyPID(Convert.ToInt32(TIDBox.Text), Convert.ToInt32(SIDBox.Text), Convert.ToUInt32(PIDBox.Text, 16));
            PIDBox.Text = $"{p:X}";
        }

        private void ToPKM_BTN_Click(object sender, EventArgs e)
        {
            var pk= (PK9)displayRiad(Convert.ToUInt32(SeedBox.Text, 16));
            var p=(PK9)PKMEditor.Data;
            p.Species = pk.Species;
            p.Gender = pk.Gender;
            p.Ability = pk.Ability;
            p.AbilityNumber = pk.AbilityNumber;
            p.HeightScalar = pk.HeightScalar;
            p.Scale = pk.Scale;
            p.WeightScalar = pk.WeightScalar;
            p.Nature = pk.Nature;
            p.TeraTypeOriginal = pk.GetTeraType();
            p.IVs = pk.IVs;
            p.EncryptionConstant = pk.EncryptionConstant;
            p.TID = pk.TID;
            p.SID = pk.SID;
            p.PID = pk.PID;
            p.Form = pk.Form;
            PKMEditor.PopulateFields(p);
            
        }
        private static Image? GenerateMap(Image map1,int teratype,TeraRaidDetail r1)
        {
            var original = PKHeX.Drawing.Misc.TypeSpriteUtil.GetTypeSpriteGem((byte)teratype);
            var gem = (Image)new Bitmap(original, new Size(30, 30));
            if (den_locations.Count == 0)
                MessageBox.Show("1");
            var x = (den_locations[$"{r1.AreaID}-{r1.SpawnPointID}"][0] + 2.072021484) * 512 / 5000;
            var y = (den_locations[$"{r1.AreaID}-{r1.SpawnPointID}"][2] + 5255.240018) * 512 / 5000;
            return ImageUtil.LayerImage(map1, gem, (int)x, (int)y);
        }
        private void DisplayMap_BTN_Click(object sender, EventArgs e)
        {
            if (SAV.SAV is SAV9SV sv)
            {
                var raid = sv.Raid;
                var a = raid.GetRaid(0);
                Raidinfo.Seed = a.Seed;
                var progress = Raidinfo.IsEvent ? EventProgress.SelectedIndex : ProgressBox.SelectedIndex;
                ITeraRaid? encounter = Raidinfo.Encounter(progress);
                var teratype = GetTeraType(encounter, Raidinfo);
                map = GenerateMap(map, teratype, a);
                for (int i = 1; i < 69; i++)
                {
                    a = raid.GetRaid(i);
                    Raidinfo.Seed = a.Seed;
                    progress = Raidinfo.IsEvent ? EventProgress.SelectedIndex : ProgressBox.SelectedIndex;
                    encounter = Raidinfo.Encounter(progress);
                    teratype = GetTeraType(encounter, Raidinfo);
                    map = GenerateMap(map, teratype, a);
                   
                }
                if (map == null)
                {
                    MessageBox.Show("Error generating map.");
                    return;
                }
                var form = new TeraMapView(map);
                form.Show();
            }
        }

        private void Show_Rewards_Click(object sender, EventArgs e)
        {
           
                Raidinfo.Seed = Convert.ToUInt32(SeedBox.Text, 16);
                var progress = Raidinfo.IsEvent ? EventProgress.SelectedIndex : ProgressBox.SelectedIndex;
                ITeraRaid? encounter = Raidinfo.Encounter(progress);

                var rewards = encounter switch
                {
                    TeraDistribution => TeraDistribution.GetRewards((TeraDistribution)encounter, Raidinfo.Seed, DeliveryRaidFixedRewards, DeliveryRaidLotteryRewards, RewardBoostBox.SelectedIndex),
                    TeraEncounter => TeraEncounter.GetRewards((TeraEncounter)encounter, Raidinfo.Seed, BaseFixedRewards, BaseLotteryRewards, RewardBoostBox.SelectedIndex),
                    _ => null,
                };

                if (rewards == null)
                {
                    MessageBox.Show("Error while displaying rewards.");
                    return;
                }

                var form = new RewardsView(rewards);
                form.Show();
            
        }
    }
}
