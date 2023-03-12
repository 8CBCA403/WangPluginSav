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
            CopyAll_BTN.Location = new Point(12, 52);
            CopyAll_BTN.Name = "CopyAll_BTN";
            CopyAll_BTN.Size = new Size(94, 26);
            CopyAll_BTN.TabIndex = 72;
            CopyAll_BTN.Text = "CopyAll";
            CopyAll_BTN.UseVisualStyleBackColor = true;
            CopyAll_BTN.Click += ModifySav_Click;
            // 
            // ModSeedText
            // 
            ModSeedText.Location = new Point(12, 23);
            ModSeedText.Multiline = true;
            ModSeedText.Name = "ModSeedText";
            ModSeedText.Size = new Size(94, 24);
            ModSeedText.TabIndex = 73;
            ModSeedText.Text = "0";
            // 
            // RaidTypeBox
            // 
            RaidTypeBox.FormattingEnabled = true;
            RaidTypeBox.Location = new Point(112, 22);
            RaidTypeBox.Name = "RaidTypeBox";
            RaidTypeBox.Size = new Size(109, 23);
            RaidTypeBox.TabIndex = 74;
            // 
            // ImportSeed_BTN
            // 
            ImportSeed_BTN.Location = new Point(112, 52);
            ImportSeed_BTN.Name = "ImportSeed_BTN";
            ImportSeed_BTN.Size = new Size(109, 26);
            ImportSeed_BTN.TabIndex = 75;
            ImportSeed_BTN.Text = "ImportSeed";
            ImportSeed_BTN.UseVisualStyleBackColor = true;
            ImportSeed_BTN.Click += ImportSeed_BTN_Click;
            // 
            // MutiSeedBox
            // 
            MutiSeedBox.Location = new Point(12, 165);
            MutiSeedBox.Name = "MutiSeedBox";
            MutiSeedBox.Size = new Size(209, 158);
            MutiSeedBox.TabIndex = 76;
            MutiSeedBox.Text = "";
            // 
            // LoopBox
            // 
            LoopBox.AutoSize = true;
            LoopBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LoopBox.Location = new Point(12, 106);
            LoopBox.Name = "LoopBox";
            LoopBox.Size = new Size(65, 24);
            LoopBox.TabIndex = 77;
            LoopBox.Text = "Loop";
            LoopBox.UseVisualStyleBackColor = true;
            // 
            // ModSav_BTN
            // 
            ModSav_BTN.Location = new Point(112, 105);
            ModSav_BTN.Name = "ModSav_BTN";
            ModSav_BTN.Size = new Size(109, 26);
            ModSav_BTN.TabIndex = 78;
            ModSav_BTN.Text = "ModifySav";
            ModSav_BTN.UseVisualStyleBackColor = true;
            ModSav_BTN.Click += ModSav_BTN_Click;
            // 
            // CloseAll_BTN
            // 
            CloseAll_BTN.Location = new Point(12, 79);
            CloseAll_BTN.Name = "CloseAll_BTN";
            CloseAll_BTN.Size = new Size(94, 26);
            CloseAll_BTN.TabIndex = 79;
            CloseAll_BTN.Text = "CloseAll";
            CloseAll_BTN.UseVisualStyleBackColor = true;
            CloseAll_BTN.Click += CloseAll_BTN_Click;
            // 
            // ImportDIS_BTN
            // 
            ImportDIS_BTN.Location = new Point(112, 79);
            ImportDIS_BTN.Name = "ImportDIS_BTN";
            ImportDIS_BTN.Size = new Size(109, 26);
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
            groupBox2.Location = new Point(12, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(233, 328);
            groupBox2.TabIndex = 91;
            groupBox2.TabStop = false;
            groupBox2.Text = "Editor";
            // 
            // ShinyCar_BTN
            // 
            ShinyCar_BTN.Location = new Point(12, 136);
            ShinyCar_BTN.Name = "ShinyCar_BTN";
            ShinyCar_BTN.Size = new Size(209, 26);
            ShinyCar_BTN.TabIndex = 90;
            ShinyCar_BTN.Text = "一键随机闪车";
            ShinyCar_BTN.UseVisualStyleBackColor = true;
            ShinyCar_BTN.Click += ShinyCar_BTN_Click;
            // 
            // SVTeraRaidForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(256, 348);
            Controls.Add(groupBox2);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SVTeraRaidForm";
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