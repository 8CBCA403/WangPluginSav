using PKHeX.Core;
using System.Media;
using System.Text.RegularExpressions;
//using Test.Properties;

namespace BerryPlot;

partial class BerryPlotForm : Form
{
    private readonly SaveFile sav;

    private ulong Seed;

    private int SeedOffset;

    private readonly int SeedOffset2;

    private readonly Panel[] Marker = new Panel[6];
    public BerryPlotForm(SaveFile sav)
    {
        this.sav = sav;
        InitializeComponent();
        for (int i = 0; i < Marker.Length; i++)
        {
            Marker[i] = new Panel();
        }
        switch (sav.Version)
        {
            case GameVersion.RS:
                SeedOffset2 = 5648;
                break;
            case GameVersion.E:
                SeedOffset2 = 5796;
                break;
        }
        if (sav is SAV3 s)
        {
            BerryPlotLocale.SelectedIndex = 0;
            UpdateEntries(s);
        }
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (!(sav is SAV3 sAV))
        {
            return;
        }
        sAV.Large[SeedOffset] = Convert.ToByte((uint)BerryTypeBox.SelectedIndex);
        int selectedIndex = GrowthStageBox.SelectedIndex;
        int num = selectedIndex;
        if (num >= 6)
        {
            if (num == 6)
            {
                sAV.Large[SeedOffset + 1] = 5;
            }
        }
        else
        {
            sAV.Large[SeedOffset + 1] = Convert.ToByte((uint)GrowthStageBox.SelectedIndex);
        }
        if (SparklingCheck.Checked)
        {
            sAV.Large[SeedOffset + 1] = Convert.ToByte((uint)(sAV.Large[SeedOffset + 1] + 128));
        }
        if (string.IsNullOrEmpty(MinutesToNextStageBox.Text))
        {
            MinutesToNextStageBox.Text = "0";
        }
        if (!int.TryParse(MinutesToNextStageBox.Text, out var result))
        {
            MinutesToNextStageBox.Text = "0";
        }
        BitConverter.GetBytes(Convert.ToUInt16(MinutesToNextStageBox.Text)).CopyTo(sAV.Large, SeedOffset + 2);
        if (string.IsNullOrEmpty(BerryAmountBox.Text))
        {
            BerryAmountBox.Text = "0";
        }
        if (!int.TryParse(BerryAmountBox.Text, out result))
        {
            BerryAmountBox.Text = "0";
        }
        sAV.Large[SeedOffset + 4] = Convert.ToByte(Convert.ToUInt16(BerryAmountBox.Text) & 0xFFu);
        if (string.IsNullOrEmpty(RegrowthBox.Text))
        {
            RegrowthBox.Text = "0";
        }
        if (!int.TryParse(RegrowthBox.Text, out result))
        {
            RegrowthBox.Text = "0";
        }
        sAV.Large[SeedOffset + 5] = Convert.ToByte(Convert.ToUInt16(RegrowthBox.Text) & 0xFu);
        if (Watered1Check.Checked)
        {
            sAV.Large[SeedOffset + 5] = Convert.ToByte((uint)(sAV.Large[SeedOffset + 5] + 16));
        }
        if (Watered2Check.Checked)
        {
            sAV.Large[SeedOffset + 5] = Convert.ToByte((uint)(sAV.Large[SeedOffset + 5] + 32));
        }
        if (Watered3Check.Checked)
        {
            sAV.Large[SeedOffset + 5] = Convert.ToByte((uint)(sAV.Large[SeedOffset + 5] + 64));
        }
        if (Watered4Check.Checked)
        {
            sAV.Large[SeedOffset + 5] = Convert.ToByte((uint)(sAV.Large[SeedOffset + 5] + 128));
        }
    }

    private void BerryPlotLocale_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (sav is SAV3 s)
        {
            UpdateEntries(s);
        }
    }

    private void UpdateEntries(SAV3 s3)
    {
        SeedOffset = SeedOffset2 + BerryPlotLocale.SelectedIndex * 8;
        Seed = s3.Large[SeedOffset];
        uint num = (ushort)(s3.Large[SeedOffset + 1] & 0x7Fu);
        uint num2 = s3.Large[SeedOffset + 4];
        bool flag = Convert.ToBoolean((ushort)((uint)(s3.Large[SeedOffset + 1] >> 7) & 1u));
        ushort num3 = BitConverter.ToUInt16(s3.Large, SeedOffset + 2);
        uint num4 = (ushort)(s3.Large[SeedOffset + 5] & 0xFu);
        bool flag2 = Convert.ToBoolean((ushort)((uint)(s3.Large[SeedOffset + 5] >> 4) & 1u));
        bool flag3 = Convert.ToBoolean((ushort)((uint)(s3.Large[SeedOffset + 5] >> 5) & 1u));
        bool flag4 = Convert.ToBoolean((ushort)((uint)(s3.Large[SeedOffset + 5] >> 6) & 1u));
        bool flag5 = Convert.ToBoolean((ushort)((uint)(s3.Large[SeedOffset + 5] >> 7) & 1u));
        if (Seed > 43)
        {
            BerryTypeBox.SelectedIndex = Convert.ToInt16(Seed % 43uL);
        }
        else
        {
            BerryTypeBox.SelectedIndex = Convert.ToInt16(Seed);
        }
        uint num5 = num;
        uint num6 = num5;
        if (num6 < 6)
        {
            GrowthStageBox.SelectedIndex = Convert.ToInt16(num);
        }
        else
        {
            GrowthStageBox.SelectedIndex = 6;
        }
        if (flag)
        {
            SparklingCheck.Checked = true;
        }
        else
        {
            SparklingCheck.Checked = false;
        }
        MinutesToNextStageBox.Text = num3.ToString();
        BerryAmountBox.Text = num2.ToString();
        RegrowthBox.Text = num4.ToString();
        Watered1Check.Checked = false;
        Watered2Check.Checked = false;
        Watered3Check.Checked = false;
        Watered4Check.Checked = false;
        if (flag2)
        {
            Watered1Check.Checked = true;
        }
        if (flag3)
        {
            Watered2Check.Checked = true;
        }
        if (flag4)
        {
            Watered3Check.Checked = true;
        }
        if (flag5)
        {
            Watered4Check.Checked = true;
        }
        string name = "_" + BerryPlotLocale.SelectedIndex;
        try
        {
            BerryPicture.Image = (Image)WangPluginSav.Properties.Resources.ResourceManager.GetObject(name);
        }
        catch (Exception)
        {
            BerryPicture.Image = null;
        }
    }

    private void MinutesToNextStageBox_TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(MinutesToNextStageBox.Text))
        {
            if (Regex.IsMatch(MinutesToNextStageBox.Text, "[^0-9]"))
            {
                SystemSounds.Asterisk.Play();
                MinutesToNextStageBox.Text = MinutesToNextStageBox.Text.Remove(MinutesToNextStageBox.Text.Length - 1);
            }
            else if (Convert.ToUInt16(MinutesToNextStageBox.Text) > ushort.MaxValue)
            {
                MinutesToNextStageBox.Text = "65535";
            }
        }
    }

    private void BerryAmountBox_TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(BerryAmountBox.Text))
        {
            if (Regex.IsMatch(BerryAmountBox.Text, "[^0-9]"))
            {
                SystemSounds.Asterisk.Play();
                BerryAmountBox.Text = BerryAmountBox.Text.Remove(BerryAmountBox.Text.Length - 1);
            }
            else if (Convert.ToUInt16(BerryAmountBox.Text) > 255)
            {
                BerryAmountBox.Text = "255";
            }
        }
    }

    private void RegrowthBox_TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(RegrowthBox.Text))
        {
            if (Regex.IsMatch(RegrowthBox.Text, "[^0-9]"))
            {
                SystemSounds.Asterisk.Play();
                RegrowthBox.Text = RegrowthBox.Text.Remove(RegrowthBox.Text.Length - 1);
            }
            else if (Convert.ToUInt16(RegrowthBox.Text) > 255)
            {
                RegrowthBox.Text = "255";
            }
        }
    }

    private void BerryPlotForm_Load(object sender, EventArgs e)
    {
        protagbox.SendToBack();
        protagbox.Parent = BerryPicture;
    }




}
