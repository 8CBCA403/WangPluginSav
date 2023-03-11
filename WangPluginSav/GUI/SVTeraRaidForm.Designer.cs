namespace WangPluginSav.GUI
{
    partial class SVTeraRaidForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SVTeraRaidForm));
            CopyAll_BTN = new Button();
            ModSeedText = new TextBox();
            RaidTypeBox = new ComboBox();
            ImportSeed_BTN = new Button();
            MutiSeedBox = new RichTextBox();
            LoopBox = new CheckBox();
            ModSav_BTN = new Button();
            CloseAll_BTN = new Button();
            ImportDIS_BTN = new Button();
            groupBox2 = new GroupBox();
            ShinyCar_BTN = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // CopyAll_BTN
            // 
            CopyAll_BTN.Location = new Point(12, 69);
            CopyAll_BTN.Margin = new Padding(3, 4, 3, 4);
            CopyAll_BTN.Name = "CopyAll_BTN";
            CopyAll_BTN.Size = new Size(94, 34);
            CopyAll_BTN.TabIndex = 72;
            CopyAll_BTN.Text = "CopyAll";
            CopyAll_BTN.UseVisualStyleBackColor = true;
            CopyAll_BTN.Click += ModifySav_Click;
            // 
            // ModSeedText
            // 
            ModSeedText.Location = new Point(12, 31);
            ModSeedText.Margin = new Padding(3, 4, 3, 4);
            ModSeedText.Multiline = true;
            ModSeedText.Name = "ModSeedText";
            ModSeedText.Size = new Size(94, 30);
            ModSeedText.TabIndex = 73;
            ModSeedText.Text = "0";
            // 
            // RaidTypeBox
            // 
            RaidTypeBox.FormattingEnabled = true;
            RaidTypeBox.Location = new Point(112, 30);
            RaidTypeBox.Margin = new Padding(3, 4, 3, 4);
            RaidTypeBox.Name = "RaidTypeBox";
            RaidTypeBox.Size = new Size(109, 28);
            RaidTypeBox.TabIndex = 74;
            // 
            // ImportSeed_BTN
            // 
            ImportSeed_BTN.Location = new Point(112, 69);
            ImportSeed_BTN.Margin = new Padding(3, 4, 3, 4);
            ImportSeed_BTN.Name = "ImportSeed_BTN";
            ImportSeed_BTN.Size = new Size(109, 34);
            ImportSeed_BTN.TabIndex = 75;
            ImportSeed_BTN.Text = "ImportSeed";
            ImportSeed_BTN.UseVisualStyleBackColor = true;
            ImportSeed_BTN.Click += ImportSeed_BTN_Click;
            // 
            // MutiSeedBox
            // 
            MutiSeedBox.Location = new Point(12, 220);
            MutiSeedBox.Margin = new Padding(3, 4, 3, 4);
            MutiSeedBox.Name = "MutiSeedBox";
            MutiSeedBox.Size = new Size(209, 210);
            MutiSeedBox.TabIndex = 76;
            MutiSeedBox.Text = "";
            // 
            // LoopBox
            // 
            LoopBox.AutoSize = true;
            LoopBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LoopBox.Location = new Point(12, 141);
            LoopBox.Margin = new Padding(3, 4, 3, 4);
            LoopBox.Name = "LoopBox";
            LoopBox.Size = new Size(65, 24);
            LoopBox.TabIndex = 77;
            LoopBox.Text = "Loop";
            LoopBox.UseVisualStyleBackColor = true;
            // 
            // ModSav_BTN
            // 
            ModSav_BTN.Location = new Point(112, 140);
            ModSav_BTN.Margin = new Padding(3, 4, 3, 4);
            ModSav_BTN.Name = "ModSav_BTN";
            ModSav_BTN.Size = new Size(109, 34);
            ModSav_BTN.TabIndex = 78;
            ModSav_BTN.Text = "ModifySav";
            ModSav_BTN.UseVisualStyleBackColor = true;
            ModSav_BTN.Click += ModSav_BTN_Click;
            // 
            // CloseAll_BTN
            // 
            CloseAll_BTN.Location = new Point(12, 105);
            CloseAll_BTN.Margin = new Padding(3, 4, 3, 4);
            CloseAll_BTN.Name = "CloseAll_BTN";
            CloseAll_BTN.Size = new Size(94, 34);
            CloseAll_BTN.TabIndex = 79;
            CloseAll_BTN.Text = "CloseAll";
            CloseAll_BTN.UseVisualStyleBackColor = true;
            CloseAll_BTN.Click += CloseAll_BTN_Click;
            // 
            // ImportDIS_BTN
            // 
            ImportDIS_BTN.Location = new Point(112, 105);
            ImportDIS_BTN.Margin = new Padding(3, 4, 3, 4);
            ImportDIS_BTN.Name = "ImportDIS_BTN";
            ImportDIS_BTN.Size = new Size(109, 34);
            ImportDIS_BTN.TabIndex = 89;
            ImportDIS_BTN.Text = "ImportDis";
            ImportDIS_BTN.UseVisualStyleBackColor = true;
            ImportDIS_BTN.Click += ImportDIS_BTN_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ShinyCar_BTN);
            groupBox2.Controls.Add(ImportDIS_BTN);
            groupBox2.Controls.Add(CloseAll_BTN);
            groupBox2.Controls.Add(ModSav_BTN);
            groupBox2.Controls.Add(LoopBox);
            groupBox2.Controls.Add(MutiSeedBox);
            groupBox2.Controls.Add(ImportSeed_BTN);
            groupBox2.Controls.Add(RaidTypeBox);
            groupBox2.Controls.Add(ModSeedText);
            groupBox2.Controls.Add(CopyAll_BTN);
            groupBox2.Location = new Point(12, 13);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(233, 438);
            groupBox2.TabIndex = 91;
            groupBox2.TabStop = false;
            groupBox2.Text = "Editor";
            // 
            // ShinyCar_BTN
            // 
            ShinyCar_BTN.Location = new Point(12, 182);
            ShinyCar_BTN.Margin = new Padding(3, 4, 3, 4);
            ShinyCar_BTN.Name = "ShinyCar_BTN";
            ShinyCar_BTN.Size = new Size(209, 34);
            ShinyCar_BTN.TabIndex = 90;
            ShinyCar_BTN.Text = "一键随机闪车";
            ShinyCar_BTN.UseVisualStyleBackColor = true;
            ShinyCar_BTN.Click += ShinyCar_BTN_Click;
            // 
            // SVTeraRaidSeedCalcForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(256, 464);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "SVTeraRaidSeedCalcForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SVTeraRaidSeedCalcForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button CopyAll_BTN;
        private TextBox ModSeedText;
        private ComboBox RaidTypeBox;
        private Button ImportSeed_BTN;
        private RichTextBox MutiSeedBox;
        private CheckBox LoopBox;
        private Button ModSav_BTN;
        private Button CloseAll_BTN;
        private Button ImportDIS_BTN;
        private GroupBox groupBox2;
        private Button ShinyCar_BTN;
    }
}