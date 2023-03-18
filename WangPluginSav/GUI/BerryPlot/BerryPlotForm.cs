using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PKHeX.Core;
//using Test.Properties;

namespace BerryPlot;

public class BerryPlotForm : Form
{
    private readonly SaveFile sav;

    private ulong Seed;

    private int SeedOffset;

    private readonly int SeedOffset2;

    private readonly Panel[] Marker = new Panel[6];

    private IContainer components = null;

    private Label LocationLabel;

    private Label BerryTypeLabel;

    private Button SaveButton;

    private Label GrowthStageLabel;

    private ComboBox BerryTypeBox;

    private ComboBox GrowthStageBox;

    private Label BerryAmoutLabel;

    private TextBox BerryAmountBox;

    private ComboBox BerryPlotLocale;

    private CheckBox SparklingCheck;

    private Label MinutesToNextStageLabel;

    private TextBox MinutesToNextStageBox;

    private TextBox RegrowthBox;

    private Label RegrowthLabel;

    private CheckBox Watered1Check;

    private CheckBox Watered2Check;

    private CheckBox Watered3Check;

    private CheckBox Watered4Check;

    private PictureBox BerryPicture;

    private Label label1;

    private PictureBox protagbox;

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

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(BerryPlotForm));
        LocationLabel = new Label();
        BerryTypeLabel = new Label();
        SaveButton = new Button();
        GrowthStageLabel = new Label();
        BerryTypeBox = new ComboBox();
        GrowthStageBox = new ComboBox();
        BerryAmoutLabel = new Label();
        BerryAmountBox = new TextBox();
        BerryPlotLocale = new ComboBox();
        SparklingCheck = new CheckBox();
        MinutesToNextStageLabel = new Label();
        MinutesToNextStageBox = new TextBox();
        RegrowthBox = new TextBox();
        RegrowthLabel = new Label();
        Watered1Check = new CheckBox();
        Watered2Check = new CheckBox();
        Watered3Check = new CheckBox();
        Watered4Check = new CheckBox();
        label1 = new Label();
        protagbox = new PictureBox();
        BerryPicture = new PictureBox();
        ((ISupportInitialize)protagbox).BeginInit();
        ((ISupportInitialize)BerryPicture).BeginInit();
        SuspendLayout();
        // 
        // LocationLabel
        // 
        LocationLabel.AutoSize = true;
        LocationLabel.Location = new Point(12, 14);
        LocationLabel.Margin = new Padding(4, 0, 4, 0);
        LocationLabel.Name = "LocationLabel";
        LocationLabel.Size = new Size(0, 20);
        LocationLabel.TabIndex = 3;
        // 
        // BerryTypeLabel
        // 
        BerryTypeLabel.AutoSize = true;
        BerryTypeLabel.Location = new Point(347, 68);
        BerryTypeLabel.Margin = new Padding(4, 0, 4, 0);
        BerryTypeLabel.Name = "BerryTypeLabel";
        BerryTypeLabel.Size = new Size(78, 20);
        BerryTypeLabel.TabIndex = 2;
        BerryTypeLabel.Text = "树果类型";
        // 
        // SaveButton
        // 
        SaveButton.Location = new Point(624, 8);
        SaveButton.Margin = new Padding(4, 5, 4, 5);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(100, 40);
        SaveButton.TabIndex = 12;
        SaveButton.Text = "编辑此图";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // GrowthStageLabel
        // 
        GrowthStageLabel.AutoSize = true;
        GrowthStageLabel.Location = new Point(347, 111);
        GrowthStageLabel.Margin = new Padding(4, 0, 4, 0);
        GrowthStageLabel.Name = "GrowthStageLabel";
        GrowthStageLabel.Size = new Size(99, 20);
        GrowthStageLabel.TabIndex = 7;
        GrowthStageLabel.Text = "生长阶段";
        // 
        // BerryTypeBox
        // 
        BerryTypeBox.AllowDrop = true;
        BerryTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
        BerryTypeBox.FormattingEnabled = true;
        BerryTypeBox.Items.AddRange(new object[] { "无", "樱子果", "零余果", "桃桃果", "莓莓果", "利木果", "苹野果", "橙橙果", "柿仔果", "木子果", "文柚果", "勿花果", "异奇果", "芒芒果", "乐芭果", "芭亚果", "蔓莓果", "墨莓果", "蕉香果", "西梨果", "凰梨果", "榴石果", "藻根果", "比巴果", "哈密果", "萄葡果", "茄番果", "玉黍果", "岳竹果", "茸丹果", "檬柠果", "刺角果", "椰木果", "瓜西果", "金枕果", "靛莓果", "枝荔果", "龙睛果", "沙鳞果", "龙火果", "杏仔果", "兰萨果", "星桃果", "谜芝果" });
        BerryTypeBox.Location = new Point(439, 63);
        BerryTypeBox.Margin = new Padding(4, 5, 4, 5);
        BerryTypeBox.Name = "BerryTypeBox";
        BerryTypeBox.Size = new Size(139, 28);
        BerryTypeBox.TabIndex = 2;
        // 
        // GrowthStageBox
        // 
        GrowthStageBox.AllowDrop = true;
        GrowthStageBox.DropDownStyle = ComboBoxStyle.DropDownList;
        GrowthStageBox.FormattingEnabled = true;
        GrowthStageBox.Items.AddRange(new object[] { "未种植", "果树种植", "果树发芽", "果树长高", "果树开花", "树果成熟", "未知的" });
        GrowthStageBox.Location = new Point(439, 106);
        GrowthStageBox.Margin = new Padding(4, 5, 4, 5);
        GrowthStageBox.Name = "GrowthStageBox";
        GrowthStageBox.Size = new Size(139, 28);
        GrowthStageBox.TabIndex = 3;
        // 
        // BerryAmoutLabel
        // 
        BerryAmoutLabel.AutoSize = true;
        BerryAmoutLabel.Location = new Point(351, 192);
        BerryAmoutLabel.Margin = new Padding(4, 0, 4, 0);
        BerryAmoutLabel.Name = "BerryAmoutLabel";
        BerryAmoutLabel.Size = new Size(62, 20);
        BerryAmoutLabel.TabIndex = 15;
        BerryAmoutLabel.Text = "数量";
        // 
        // BerryAmountBox
        // 
        BerryAmountBox.Location = new Point(439, 188);
        BerryAmountBox.Margin = new Padding(4, 5, 4, 5);
        BerryAmountBox.MaxLength = 3;
        BerryAmountBox.Name = "BerryAmountBox";
        BerryAmountBox.Size = new Size(139, 27);
        BerryAmountBox.TabIndex = 5;
        BerryAmountBox.TextChanged += BerryAmountBox_TextChanged;
        // 
        // BerryPlotLocale
        // 
        BerryPlotLocale.AllowDrop = true;
        BerryPlotLocale.DropDownStyle = ComboBoxStyle.DropDownList;
        BerryPlotLocale.FormattingEnabled = true;
        BerryPlotLocale.Items.AddRange(new object[] { "102道路_桃桃果", "102道路_橙橙果", "104道路_松软土壤_1", "104道路_橙橙果_1", "103道路_樱子果_1", "103道路_苹野果", "103道路_樱子果_2", "104道路_樱子果_1", "104道路_松软土壤_2", "104道路_苹野果", "104道路_橙橙果_2", "104道路_松软土壤_3", "104道路_桃桃果", "123道路_比巴果_1", "123道路_榴石果_1", "110道路_蕉香果_1", "110道路_蕉香果_2", "110道路_蕉香果_3", "111道路_蔓莓果_1", "111道路_蔓莓果_2", "112道路_莓莓果_1", "112道路_桃桃果_1", "112道路_桃桃果_2", "112道路_莓莓果_2", "116道路_凰梨果_1", "116道路_零余果_1", "117道路_西梨果_1", "117道路_西梨果_2", "117道路_西梨果_3", "123道路_榴石果_2", "118道路_文柚果_1", "118道路_松软土壤", "118道路_文柚果_2", "119道路_榴石果_1", "119道路_榴石果_2", "119道路_榴石果_3", "120道路_利木果_1", "120道路_利木果_2", "120道路_利木果_3", "120道路_桃桃果_1", "120道路_桃桃果_2", "120道路_桃桃果_3", "120道路_蔓莓果", "120道路_蕉香果", "120道路_凰梨果", "120道路_西梨果", "121道路_柿仔果", "121道路_利木果", "121道路_莓莓果", "121道路_零余果", "121道路_松软土壤_1", "121道路_蕉香果_1", "121道路_蕉香果_2", "121道路_松软土壤_2", "115道路_墨莓果_1", "115道路_墨莓果_2", "空", "123道路_榴石果_3", "123道路_榴石果_4", "123道路_萄葡果_1", "123道路_萄葡果_2", "123道路_苹野果_1", "123道路_松软土壤", "123道路_苹野果_2", "123道路_萄葡果_3", "116道路_零余果_2", "116道路_凰梨果_2", "114道路_柿仔果_1", "115道路_藻根果_1", "115道路_藻根果_2", "115道路_藻根果_3", "123道路_萄葡果_4", "123道路_比巴果_2", "123道路_比巴果_3", "104道路_松软土壤_4", "104道路_樱子果_2", "114道路_柿仔果_2", "114道路_柿仔果_3", "123道路_比巴果_4", "111道路_橙橙果_1", "111道路_橙橙果_2", "幻影岛_枝荔果", "119道路_哈密果_1", "119道路_哈密果_2", "119道路_文柚果", "119道路_苹野果", "123道路_桃桃果", "123道路_文柚果", "123道路_莓莓果" });
        BerryPlotLocale.Location = new Point(351, 14);
        BerryPlotLocale.Margin = new Padding(4, 5, 4, 5);
        BerryPlotLocale.Name = "BerryPlotLocale";
        BerryPlotLocale.Size = new Size(227, 28);
        BerryPlotLocale.TabIndex = 1;
        BerryPlotLocale.SelectedIndexChanged += BerryPlotLocale_SelectedIndexChanged;
        // 
        // SparklingCheck
        // 
        SparklingCheck.AutoSize = true;
        SparklingCheck.Enabled = false;
        SparklingCheck.Location = new Point(593, 66);
        SparklingCheck.Margin = new Padding(4, 5, 4, 5);
        SparklingCheck.Name = "SparklingCheck";
        SparklingCheck.Size = new Size(100, 24);
        SparklingCheck.TabIndex = 7;
        SparklingCheck.Text = "闪亮的?";
        SparklingCheck.UseVisualStyleBackColor = true;
        // 
        // MinutesToNextStageLabel
        // 
        MinutesToNextStageLabel.AutoSize = true;
        MinutesToNextStageLabel.Location = new Point(347, 143);
        MinutesToNextStageLabel.Margin = new Padding(4, 0, 4, 0);
        MinutesToNextStageLabel.Name = "MinutesToNextStageLabel";
        MinutesToNextStageLabel.Size = new Size(82, 40);
        MinutesToNextStageLabel.TabIndex = 19;
        MinutesToNextStageLabel.Text = "几分钟后\r\n下一阶段";
        // 
        // MinutesToNextStageBox
        // 
        MinutesToNextStageBox.Location = new Point(439, 148);
        MinutesToNextStageBox.Margin = new Padding(4, 5, 4, 5);
        MinutesToNextStageBox.MaxLength = 5;
        MinutesToNextStageBox.Name = "MinutesToNextStageBox";
        MinutesToNextStageBox.Size = new Size(139, 27);
        MinutesToNextStageBox.TabIndex = 4;
        MinutesToNextStageBox.TextChanged += MinutesToNextStageBox_TextChanged;
        // 
        // RegrowthBox
        // 
        RegrowthBox.Location = new Point(439, 228);
        RegrowthBox.Margin = new Padding(4, 5, 4, 5);
        RegrowthBox.MaxLength = 2;
        RegrowthBox.Name = "RegrowthBox";
        RegrowthBox.Size = new Size(139, 27);
        RegrowthBox.TabIndex = 6;
        RegrowthBox.TextChanged += RegrowthBox_TextChanged;
        // 
        // RegrowthLabel
        // 
        RegrowthLabel.AutoSize = true;
        RegrowthLabel.Location = new Point(351, 222);
        RegrowthLabel.Margin = new Padding(4, 0, 4, 0);
        RegrowthLabel.Name = "RegrowthLabel";
        RegrowthLabel.Size = new Size(73, 40);
        RegrowthLabel.TabIndex = 22;
        RegrowthLabel.Text = "树果再生\r\n计数";
        // 
        // Watered1Check
        // 
        Watered1Check.AutoSize = true;
        Watered1Check.Location = new Point(593, 125);
        Watered1Check.Margin = new Padding(4, 5, 4, 5);
        Watered1Check.Name = "Watered1Check";
        Watered1Check.Size = new Size(119, 24);
        Watered1Check.TabIndex = 8;
        Watered1Check.Text = "果树种植";
        Watered1Check.UseVisualStyleBackColor = true;
        // 
        // Watered2Check
        // 
        Watered2Check.AutoSize = true;
        Watered2Check.Location = new Point(593, 160);
        Watered2Check.Margin = new Padding(4, 5, 4, 5);
        Watered2Check.Name = "Watered2Check";
        Watered2Check.Size = new Size(130, 24);
        Watered2Check.TabIndex = 9;
        Watered2Check.Text = "果树发芽";
        Watered2Check.UseVisualStyleBackColor = true;
        // 
        // Watered3Check
        // 
        Watered3Check.AutoSize = true;
        Watered3Check.Location = new Point(593, 195);
        Watered3Check.Margin = new Padding(4, 5, 4, 5);
        Watered3Check.Name = "Watered3Check";
        Watered3Check.Size = new Size(104, 24);
        Watered3Check.TabIndex = 10;
        Watered3Check.Text = "果树长高";
        Watered3Check.UseVisualStyleBackColor = true;
        // 
        // Watered4Check
        // 
        Watered4Check.AutoSize = true;
        Watered4Check.Location = new Point(593, 231);
        Watered4Check.Margin = new Padding(4, 5, 4, 5);
        Watered4Check.Name = "Watered4Check";
        Watered4Check.Size = new Size(134, 24);
        Watered4Check.TabIndex = 11;
        Watered4Check.Text = "果树开花";
        Watered4Check.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(589, 100);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(68, 20);
        label1.TabIndex = 24;
        label1.Text = "浇水:";
        // 
        // protagbox
        // 
        protagbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        protagbox.BackColor = Color.Transparent;
        protagbox.BackgroundImageLayout = ImageLayout.None;
        protagbox.InitialImage = null;
        protagbox.Location = new Point(151, 102);
        protagbox.Margin = new Padding(4, 5, 4, 5);
        protagbox.Name = "protagbox";
        protagbox.Size = new Size(19, 32);
        protagbox.TabIndex = 25;
        protagbox.TabStop = false;
        protagbox.Visible = false;
        // 
        // BerryPicture
        // 
        BerryPicture.Location = new Point(16, 12);
        BerryPicture.Margin = new Padding(4, 5, 4, 5);
        BerryPicture.Name = "BerryPicture";
        BerryPicture.Size = new Size(320, 246);
        BerryPicture.TabIndex = 23;
        BerryPicture.TabStop = false;
        // 
        // BerryPlotForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(733, 272);
        Controls.Add(protagbox);
        Controls.Add(label1);
        Controls.Add(BerryPicture);
        Controls.Add(Watered4Check);
        Controls.Add(Watered3Check);
        Controls.Add(Watered2Check);
        Controls.Add(Watered1Check);
        Controls.Add(RegrowthLabel);
        Controls.Add(RegrowthBox);
        Controls.Add(MinutesToNextStageBox);
        Controls.Add(MinutesToNextStageLabel);
        Controls.Add(SparklingCheck);
        Controls.Add(SaveButton);
        Controls.Add(BerryPlotLocale);
        Controls.Add(BerryAmoutLabel);
        Controls.Add(BerryAmountBox);
        Controls.Add(GrowthStageBox);
        Controls.Add(BerryTypeBox);
        Controls.Add(GrowthStageLabel);
        Controls.Add(BerryTypeLabel);
        Controls.Add(LocationLabel);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 5, 4, 5);
        MaximizeBox = false;
        Name = "BerryPlotForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "树果地图";
        Load += BerryPlotForm_Load;
        ((ISupportInitialize)protagbox).EndInit();
        ((ISupportInitialize)BerryPicture).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
