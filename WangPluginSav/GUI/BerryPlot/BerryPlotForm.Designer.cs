using System.ComponentModel;
namespace BerryPlot
{
    partial class BerryPlotForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            LocationLabel.Location = new Point(12, 10);
            LocationLabel.Margin = new Padding(4, 0, 4, 0);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(0, 15);
            LocationLabel.TabIndex = 3;
            // 
            // BerryTypeLabel
            // 
            BerryTypeLabel.AutoSize = true;
            BerryTypeLabel.Location = new Point(347, 51);
            BerryTypeLabel.Margin = new Padding(4, 0, 4, 0);
            BerryTypeLabel.Name = "BerryTypeLabel";
            BerryTypeLabel.Size = new Size(71, 15);
            BerryTypeLabel.TabIndex = 2;
            BerryTypeLabel.Text = "树果类型";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(624, 6);
            SaveButton.Margin = new Padding(4, 4, 4, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(100, 30);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // GrowthStageLabel
            // 
            GrowthStageLabel.AutoSize = true;
            GrowthStageLabel.Location = new Point(347, 83);
            GrowthStageLabel.Margin = new Padding(4, 0, 4, 0);
            GrowthStageLabel.Name = "GrowthStageLabel";
            GrowthStageLabel.Size = new Size(71, 15);
            GrowthStageLabel.TabIndex = 7;
            GrowthStageLabel.Text = "生长阶段";
            // 
            // BerryTypeBox
            // 
            BerryTypeBox.AllowDrop = true;
            BerryTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BerryTypeBox.FormattingEnabled = true;
            BerryTypeBox.Items.AddRange(new object[] { "无", "樱子果", "零余果", "桃桃果", "莓莓果", "利木果", "苹野果", "橙橙果", "柿仔果", "木子果", "文柚果", "勿花果", "异奇果", "芒芒果", "乐芭果", "芭亚果", "蔓莓果", "墨莓果", "蕉香果", "西梨果", "凰梨果", "榴石果", "藻根果", "比巴果", "哈密果", "萄葡果", "茄番果", "玉黍果", "岳竹果", "茸丹果", "檬柠果", "刺角果", "椰木果", "瓜西果", "金枕果", "靛莓果", "枝荔果", "龙睛果", "沙鳞果", "龙火果", "杏仔果", "兰萨果", "星桃果", "谜芝果" });
            BerryTypeBox.Location = new Point(439, 47);
            BerryTypeBox.Margin = new Padding(4, 4, 4, 4);
            BerryTypeBox.Name = "BerryTypeBox";
            BerryTypeBox.Size = new Size(139, 23);
            BerryTypeBox.TabIndex = 2;
            // 
            // GrowthStageBox
            // 
            GrowthStageBox.AllowDrop = true;
            GrowthStageBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GrowthStageBox.FormattingEnabled = true;
            GrowthStageBox.Items.AddRange(new object[] { "未种植", "果树种植", "果树发芽", "果树长高", "果树开花", "树果成熟", "未知的" });
            GrowthStageBox.Location = new Point(439, 80);
            GrowthStageBox.Margin = new Padding(4, 4, 4, 4);
            GrowthStageBox.Name = "GrowthStageBox";
            GrowthStageBox.Size = new Size(139, 23);
            GrowthStageBox.TabIndex = 3;
            // 
            // BerryAmoutLabel
            // 
            BerryAmoutLabel.AutoSize = true;
            BerryAmoutLabel.Location = new Point(347, 144);
            BerryAmoutLabel.Margin = new Padding(4, 0, 4, 0);
            BerryAmoutLabel.Name = "BerryAmoutLabel";
            BerryAmoutLabel.Size = new Size(39, 15);
            BerryAmoutLabel.TabIndex = 15;
            BerryAmoutLabel.Text = "数量";
            // 
            // BerryAmountBox
            // 
            BerryAmountBox.Location = new Point(439, 141);
            BerryAmountBox.Margin = new Padding(4, 4, 4, 4);
            BerryAmountBox.MaxLength = 3;
            BerryAmountBox.Name = "BerryAmountBox";
            BerryAmountBox.Size = new Size(139, 25);
            BerryAmountBox.TabIndex = 5;
            BerryAmountBox.TextChanged += BerryAmountBox_TextChanged;
            // 
            // BerryPlotLocale
            // 
            BerryPlotLocale.AllowDrop = true;
            BerryPlotLocale.DropDownStyle = ComboBoxStyle.DropDownList;
            BerryPlotLocale.FormattingEnabled = true;
            BerryPlotLocale.Items.AddRange(new object[] { "102道路_桃桃果", "102道路_橙橙果", "104道路_松软土壤_1", "104道路_橙橙果_1", "103道路_樱子果_1", "103道路_苹野果", "103道路_樱子果_2", "104道路_樱子果_1", "104道路_松软土壤_2", "104道路_苹野果", "104道路_橙橙果_2", "104道路_松软土壤_3", "104道路_桃桃果", "123道路_比巴果_1", "123道路_榴石果_1", "110道路_蕉香果_1", "110道路_蕉香果_2", "110道路_蕉香果_3", "111道路_蔓莓果_1", "111道路_蔓莓果_2", "112道路_莓莓果_1", "112道路_桃桃果_1", "112道路_桃桃果_2", "112道路_莓莓果_2", "116道路_凰梨果_1", "116道路_零余果_1", "117道路_西梨果_1", "117道路_西梨果_2", "117道路_西梨果_3", "123道路_榴石果_2", "118道路_文柚果_1", "118道路_松软土壤", "118道路_文柚果_2", "119道路_榴石果_1", "119道路_榴石果_2", "119道路_榴石果_3", "120道路_利木果_1", "120道路_利木果_2", "120道路_利木果_3", "120道路_桃桃果_1", "120道路_桃桃果_2", "120道路_桃桃果_3", "120道路_蔓莓果", "120道路_蕉香果", "120道路_凰梨果", "120道路_西梨果", "121道路_柿仔果", "121道路_利木果", "121道路_莓莓果", "121道路_零余果", "121道路_松软土壤_1", "121道路_蕉香果_1", "121道路_蕉香果_2", "121道路_松软土壤_2", "115道路_墨莓果_1", "115道路_墨莓果_2", "空", "123道路_榴石果_3", "123道路_榴石果_4", "123道路_萄葡果_1", "123道路_萄葡果_2", "123道路_苹野果_1", "123道路_松软土壤", "123道路_苹野果_2", "123道路_萄葡果_3", "116道路_零余果_2", "116道路_凰梨果_2", "114道路_柿仔果_1", "115道路_藻根果_1", "115道路_藻根果_2", "115道路_藻根果_3", "123道路_萄葡果_4", "123道路_比巴果_2", "123道路_比巴果_3", "104道路_松软土壤_4", "104道路_樱子果_2", "114道路_柿仔果_2", "114道路_柿仔果_3", "123道路_比巴果_4", "111道路_橙橙果_1", "111道路_橙橙果_2", "幻影岛_枝荔果", "119道路_哈密果_1", "119道路_哈密果_2", "119道路_文柚果", "119道路_苹野果", "123道路_桃桃果", "123道路_文柚果", "123道路_莓莓果" });
            BerryPlotLocale.Location = new Point(351, 10);
            BerryPlotLocale.Margin = new Padding(4, 4, 4, 4);
            BerryPlotLocale.Name = "BerryPlotLocale";
            BerryPlotLocale.Size = new Size(227, 23);
            BerryPlotLocale.TabIndex = 1;
            BerryPlotLocale.SelectedIndexChanged += BerryPlotLocale_SelectedIndexChanged;
            // 
            // SparklingCheck
            // 
            SparklingCheck.AutoSize = true;
            SparklingCheck.Enabled = false;
            SparklingCheck.Location = new Point(593, 50);
            SparklingCheck.Margin = new Padding(4, 4, 4, 4);
            SparklingCheck.Name = "SparklingCheck";
            SparklingCheck.Size = new Size(85, 19);
            SparklingCheck.TabIndex = 7;
            SparklingCheck.Text = "闪亮的?";
            SparklingCheck.UseVisualStyleBackColor = true;
            // 
            // MinutesToNextStageLabel
            // 
            MinutesToNextStageLabel.AutoSize = true;
            MinutesToNextStageLabel.Location = new Point(347, 107);
            MinutesToNextStageLabel.Margin = new Padding(4, 0, 4, 0);
            MinutesToNextStageLabel.Name = "MinutesToNextStageLabel";
            MinutesToNextStageLabel.Size = new Size(71, 30);
            MinutesToNextStageLabel.TabIndex = 19;
            MinutesToNextStageLabel.Text = "几分钟后\r\n下一阶段";
            // 
            // MinutesToNextStageBox
            // 
            MinutesToNextStageBox.Location = new Point(439, 111);
            MinutesToNextStageBox.Margin = new Padding(4, 4, 4, 4);
            MinutesToNextStageBox.MaxLength = 5;
            MinutesToNextStageBox.Name = "MinutesToNextStageBox";
            MinutesToNextStageBox.Size = new Size(139, 25);
            MinutesToNextStageBox.TabIndex = 4;
            MinutesToNextStageBox.TextChanged += MinutesToNextStageBox_TextChanged;
            // 
            // RegrowthBox
            // 
            RegrowthBox.Location = new Point(439, 171);
            RegrowthBox.Margin = new Padding(4, 4, 4, 4);
            RegrowthBox.MaxLength = 2;
            RegrowthBox.Name = "RegrowthBox";
            RegrowthBox.Size = new Size(139, 25);
            RegrowthBox.TabIndex = 6;
            RegrowthBox.TextChanged += RegrowthBox_TextChanged;
            // 
            // RegrowthLabel
            // 
            RegrowthLabel.AutoSize = true;
            RegrowthLabel.Location = new Point(347, 166);
            RegrowthLabel.Margin = new Padding(4, 0, 4, 0);
            RegrowthLabel.Name = "RegrowthLabel";
            RegrowthLabel.Size = new Size(71, 30);
            RegrowthLabel.TabIndex = 22;
            RegrowthLabel.Text = "树果再生\r\n计数";
            // 
            // Watered1Check
            // 
            Watered1Check.AutoSize = true;
            Watered1Check.Location = new Point(593, 94);
            Watered1Check.Margin = new Padding(4, 4, 4, 4);
            Watered1Check.Name = "Watered1Check";
            Watered1Check.Size = new Size(109, 19);
            Watered1Check.TabIndex = 8;
            Watered1Check.Text = "果树种下了";
            Watered1Check.UseVisualStyleBackColor = true;
            // 
            // Watered2Check
            // 
            Watered2Check.AutoSize = true;
            Watered2Check.Location = new Point(593, 120);
            Watered2Check.Margin = new Padding(4, 4, 4, 4);
            Watered2Check.Name = "Watered2Check";
            Watered2Check.Size = new Size(93, 19);
            Watered2Check.TabIndex = 9;
            Watered2Check.Text = "果树发芽";
            Watered2Check.UseVisualStyleBackColor = true;
            // 
            // Watered3Check
            // 
            Watered3Check.AutoSize = true;
            Watered3Check.Location = new Point(593, 146);
            Watered3Check.Margin = new Padding(4, 4, 4, 4);
            Watered3Check.Name = "Watered3Check";
            Watered3Check.Size = new Size(93, 19);
            Watered3Check.TabIndex = 10;
            Watered3Check.Text = "果树长高";
            Watered3Check.UseVisualStyleBackColor = true;
            // 
            // Watered4Check
            // 
            Watered4Check.AutoSize = true;
            Watered4Check.Location = new Point(593, 173);
            Watered4Check.Margin = new Padding(4, 4, 4, 4);
            Watered4Check.Name = "Watered4Check";
            Watered4Check.Size = new Size(93, 19);
            Watered4Check.TabIndex = 11;
            Watered4Check.Text = "果树开花";
            Watered4Check.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(589, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 24;
            label1.Text = "浇水:";
            // 
            // protagbox
            // 
            protagbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            protagbox.BackColor = Color.Transparent;
            protagbox.BackgroundImageLayout = ImageLayout.None;
            protagbox.InitialImage = null;
            protagbox.Location = new Point(151, 76);
            protagbox.Margin = new Padding(4, 4, 4, 4);
            protagbox.Name = "protagbox";
            protagbox.Size = new Size(19, 24);
            protagbox.TabIndex = 25;
            protagbox.TabStop = false;
            protagbox.Visible = false;
            // 
            // BerryPicture
            // 
            BerryPicture.Location = new Point(16, 9);
            BerryPicture.Margin = new Padding(4, 4, 4, 4);
            BerryPicture.Name = "BerryPicture";
            BerryPicture.Size = new Size(320, 184);
            BerryPicture.TabIndex = 23;
            BerryPicture.TabStop = false;
            // 
            // BerryPlotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 204);
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
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "BerryPlotForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "树果种植";
            Load += BerryPlotForm_Load;
            ((ISupportInitialize)protagbox).EndInit();
            ((ISupportInitialize)BerryPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

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
    }
}
