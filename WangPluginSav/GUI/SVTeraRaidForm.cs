using PKHeX.Core;
using System.Media;

namespace WangPluginSav.GUI
{
    public partial class SVTeraRaidForm : Form
    {
        private ISaveFileProvider SAV { get; }
        public IPKMView PKMEditor { get; }
        private const string SeedFilter = "Trainer Info |*.txt|All Files|*.*";
        private const string DisFilter = "Trainer Info |*.DIS|All Files|*.*";
        private string[]? lines;
        private TeraRaidDisplayType[] a = new TeraRaidDisplayType[72];
        private byte[] b = new byte[72];
        private static Random random = new Random();
  

        public static readonly GameStrings strings = GameInfo.GetStrings("zh");
       
        public SVTeraRaidForm(ISaveFileProvider sav, IPKMView edit)
        {
            SAV = sav;
            PKMEditor = edit;
            InitializeComponent();
            BindingData();
        }
       
        public void BindingData()
        {
            RaidTypeBox.DataSource = Enum.GetValues(typeof(TeraRaidContentType));
            RaidTypeBox.SelectedIndex = 0;
           
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
                MutiSeedBox.Text += line + '\n';
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
            int n = 0;
            if (lines != null)
            {
                n = lines.Count();
            }
            else
            {
                MessageBox.Show("没导入有效Seed");
                return;
            }
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
                    for (int i = 0; i < r; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            var r1 = raid.GetRaid(i * n + j);
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
                a[i] = r1.DisplayType;
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
                r1.DisplayType = TeraRaidDisplayType.None;
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
                    else if (b[i] == 2)
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

       
        private static int Raidshiny(uint Seed)
        {
            Xoroshiro128Plus xoroshiro128Plus = new Xoroshiro128Plus(Seed);
            uint num = (uint)xoroshiro128Plus.NextInt(4294967295uL);
            uint num2 = (uint)xoroshiro128Plus.NextInt(4294967295uL);
            uint num3 = (uint)xoroshiro128Plus.NextInt(4294967295uL);
            return (((num3 >> 16) ^ (num3 & 0xFFFF)) >> 4 == ((num2 >> 16) ^ (num2 & 0xFFFF)) >> 4) ? 1 : 0;
        }
        private void ShinyCar_BTN_Click(object sender, EventArgs e)
        {
            if (SAV.SAV is SAV9SV sv)
            {
                TeraRaidDetail[] allRaids = sv.Raid.GetAllRaids();

                foreach (TeraRaidDetail teraRaidDetail in allRaids)
                {
                    if (teraRaidDetail.AreaID != 0 && (teraRaidDetail.Content == TeraRaidContentType.Base05 || teraRaidDetail.Content == TeraRaidContentType.Black6))
                    {
                        teraRaidDetail.IsEnabled = true;
                        uint seed;
                        do
                        {
                            seed = (uint)random.Next();
                        }
                        while (Raidshiny(seed) == 0);
                        teraRaidDetail.Seed = seed;
                        teraRaidDetail.IsClaimedLeaguePoints = false;
                    }
                }
                MessageBox.Show("全地图非活动坑随机闪车已生成");
                SystemSounds.Asterisk.Play();
            }
        }
    }
}
