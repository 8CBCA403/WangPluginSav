using PKHeX.Core;
using System.ComponentModel;
using System.Windows.Forms;
namespace WangPluginSav.GUI
{
    public partial class SVTeraRaidSeedCalcForm : Form
    {
        private ISaveFileProvider SAV { get; }
        private CancellationTokenSource tokenSource = new();
        private Raid Raidinfo = new();
     
        public SVTeraRaidSeedCalcForm(ISaveFileProvider sav)
        {
            SAV = sav;
            Raid.GemTeraRaids = TeraEncounter.GetAllEncounters("encounter_gem_paldea.pkl");
            Raid.DistTeraRaids = TeraDistribution.GetAllEncounters();
            Raid.Game = "Violet";
            InitializeComponent();
            BindingData();
        }
        public enum NV
        {
            [Description("进度1")]
            one,
            [Description("进度2")]
            two,
            [Description("进度3")]
            three,
            [Description("进度4")]
            four,
            [Description("进度5")]
            five,
        }
        public enum EV
        {
            [Description("进度1")]
            one,
            [Description("进度2")]
            two,
            [Description("进度3")]
            three,
            [Description("进度4")]
            four,
        }
        public enum GameN
        {
            Scarlet,
            Violet,
        }
        public enum star
        {
            one,
            two,
            three,
            four,
            five,
            six,
        }
        public void BindingData()
        {
            SPcomboBox.DataSource = Enum.GetNames(typeof(Species));
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
            GencomboBox.DataSource = Enum.GetValues(typeof(Gender)).Cast<Gender>().Where(z => z != Gender.Random).ToArray();
            GencomboBox.DisplayMember = "Name";
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
            //ConditionBox.Text = "正在找...";

        }
        private void GeneratorIsNotRunning(bool running)
        {
            RUN_BTN.Enabled = true;
            //ConditionBox.Text = "无事可做";

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
        private void displayRiad(uint seed)
        {
            string r;
            int StarCount;
            Raidinfo.Seed = seed;
            SeedBox.Text = $"{Raidinfo.Seed:X8}";
            ECBox.Text = $"{Raidinfo.EC:X8}";
            PIDBox.Text = $"{Raidinfo.PID:X8}";
            Raidinfo.IsEvent = IsEvent.Checked;
            Raidinfo.IsC = IsC.Checked;
            Raidinfo.IsBlack = IsBlackBox.Checked;
            var progress = EventProgress.SelectedIndex ;
            ITeraRaid? encounter = Raidinfo.Encounter(progress);
            var teratype = GetTeraType(encounter, Raidinfo);
            TeraBox.Text = $"{Raid.strings.types[teratype]} ({teratype})";
            StarCount =  encounter.Stars ;
            DiffBox.Text =  string.Concat(Enumerable.Repeat("☆", StarCount)) ;
            if (encounter != null)
            {
                var param = GetParam(encounter);
                var blank = new PK9();
                blank.Species = encounter.Species;
                blank.Form = encounter.Form;
                Encounter9RNG.GenerateData(blank, param, EncounterCriteria.Unrestricted, Raidinfo.Seed);
                SpeciesTextBox.Text = $"{Raid.strings.Species[encounter.Species]} ({encounter.Species})";
                switch ((Gender)blank.Gender)
                {
                    case Gender.Male:
                        GenderBox.Text = $"公";
                        break;
                    case Gender.Female:
                        GenderBox.Text = "母";
                        break;
                    case Gender.Genderless:
                        GenderBox.Text = "无性别";
                        break;
                }
                var nature = blank.Nature;
                NatureBox.Text = $"{Raid.strings.Natures[nature]}";
                AbilityBox.Text = $"{Raid.strings.Ability[blank.Ability]}";
                Move1Box.Text = Raid.strings.Move[encounter.Move1];
                Move2Box.Text = Raid.strings.Move[encounter.Move2];
                Move3Box.Text = Raid.strings.Move[encounter.Move3];
                Move4Box.Text = Raid.strings.Move[encounter.Move4];
                IVBOX.Text = IVsString(ToSpeedLast(blank.IVs));
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
            if (Raidinfo.IsShiny)
            {
                PIDBox.BackColor = Color.Gold;
                PIDBox.Text += " (☆)";
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
            r = $"\nSeed:{Raidinfo.Seed:X8} 种类: {SpeciesTextBox.Text} IV:{IVsString(Raidinfo.GetIVs(Raidinfo.Seed, StarCount - 1))}" +
                $" 太晶属性:{TeraBox.Text} 技能:{Move1Box.Text},{Move2Box.Text},{Move3Box.Text},{Move4Box.Text}";
            ResultBox.Text += "\n" + r;
        }

        private void Search_BTN_Click(object sender, EventArgs e)
        {
            GeneratorIsRunning(true);
            tokenSource = new();
            uint seed =0;
            RaidFilters r = new()
            {
                Species = (Species)SPcomboBox.SelectedIndex,
                Nature = (Nature)NaturecomboBox.SelectedIndex,
                Gender=(Gender)GencomboBox.SelectedIndex,
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
                   while (true)
                   {
                       if (tokenSource.IsCancellationRequested)
                       {
                           return;
                       }
                       seed = Util.Rand32();
                       SeedBox.Text = $"{seed:X}";
                       Raidinfo.Seed = seed;
                       Raidinfo.IsBlack = IsBlackBox.Checked;
                       if (r.FilterSatisfied(Raidinfo, ProgressBox.SelectedIndex))
                       {
                           this.Invoke(() =>
                           {
                               SeedBox.Text = $"{seed:X}";
                               displayRiad(seed);
                               
                           });
                           break;
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
                return Raidinfo.TeranType;
            if (encounter is TeraDistribution td && td.Entity is EncounterMight9 em)
                return (int)em.TeraType > 1 ? (int)em.TeraType - 2 : Raidinfo.TeranType;
            return Raidinfo.TeranType;
        }

    }
}
