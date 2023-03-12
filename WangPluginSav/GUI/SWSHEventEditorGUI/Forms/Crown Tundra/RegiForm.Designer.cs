namespace WangPluginSav
{
    partial class RegiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegiForm));
            groupBox12 = new GroupBox();
            regieleki_RBTN = new RadioButton();
            regidrago_RBTN = new RadioButton();
            regi_clistbox = new CheckedListBox();
            reginone_RBTN = new RadioButton();
            groupBox1 = new GroupBox();
            regiother_patrBTN = new RadioButton();
            label1 = new Label();
            regipatternNUD = new NumericUpDown();
            regieleki_patrBTN = new RadioButton();
            reginone_patrBTN = new RadioButton();
            regidrago_patrBTN = new RadioButton();
            legailty_CB = new CheckBox();
            label2 = new Label();
            applyBTN = new Button();
            legalLBL = new Label();
            groupBox12.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)regipatternNUD).BeginInit();
            SuspendLayout();
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(regieleki_RBTN);
            groupBox12.Controls.Add(regidrago_RBTN);
            groupBox12.Controls.Add(regi_clistbox);
            groupBox12.Controls.Add(reginone_RBTN);
            groupBox12.Location = new Point(16, 14);
            groupBox12.Margin = new Padding(4);
            groupBox12.Name = "groupBox12";
            groupBox12.Padding = new Padding(4);
            groupBox12.Size = new Size(176, 208);
            groupBox12.TabIndex = 53;
            groupBox12.TabStop = false;
            groupBox12.Text = "捕捉";
            // 
            // regieleki_RBTN
            // 
            regieleki_RBTN.AutoSize = true;
            regieleki_RBTN.Location = new Point(8, 156);
            regieleki_RBTN.Margin = new Padding(4);
            regieleki_RBTN.Name = "regieleki_RBTN";
            regieleki_RBTN.Size = new Size(108, 19);
            regieleki_RBTN.TabIndex = 54;
            regieleki_RBTN.Text = "雷吉艾勒奇";
            regieleki_RBTN.UseVisualStyleBackColor = true;
            regieleki_RBTN.CheckedChanged += regieleki_RBTN_CheckedChanged;
            // 
            // regidrago_RBTN
            // 
            regidrago_RBTN.AutoSize = true;
            regidrago_RBTN.Location = new Point(8, 129);
            regidrago_RBTN.Margin = new Padding(4);
            regidrago_RBTN.Name = "regidrago_RBTN";
            regidrago_RBTN.Size = new Size(108, 19);
            regidrago_RBTN.TabIndex = 53;
            regidrago_RBTN.Text = "雷吉铎拉戈";
            regidrago_RBTN.UseVisualStyleBackColor = true;
            regidrago_RBTN.CheckedChanged += regidrago_RBTN_CheckedChanged;
            // 
            // regi_clistbox
            // 
            regi_clistbox.FormattingEnabled = true;
            regi_clistbox.Items.AddRange(new object[] { "雷吉洛克", "雷吉艾斯", "雷吉斯奇鲁", "雷吉奇卡斯" });
            regi_clistbox.Location = new Point(8, 22);
            regi_clistbox.Margin = new Padding(4);
            regi_clistbox.Name = "regi_clistbox";
            regi_clistbox.Size = new Size(159, 64);
            regi_clistbox.TabIndex = 50;
            // 
            // reginone_RBTN
            // 
            reginone_RBTN.AutoSize = true;
            reginone_RBTN.Checked = true;
            reginone_RBTN.Location = new Point(8, 103);
            reginone_RBTN.Margin = new Padding(4);
            reginone_RBTN.Name = "reginone_RBTN";
            reginone_RBTN.Size = new Size(92, 19);
            reginone_RBTN.TabIndex = 52;
            reginone_RBTN.TabStop = true;
            reginone_RBTN.Text = "两者都不";
            reginone_RBTN.UseVisualStyleBackColor = true;
            reginone_RBTN.CheckedChanged += reginone_RBTN_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(regiother_patrBTN);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(regipatternNUD);
            groupBox1.Controls.Add(regieleki_patrBTN);
            groupBox1.Controls.Add(reginone_patrBTN);
            groupBox1.Controls.Add(regidrago_patrBTN);
            groupBox1.Location = new Point(200, 14);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(187, 208);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = " 雷吉图案";
            // 
            // regiother_patrBTN
            // 
            regiother_patrBTN.AutoSize = true;
            regiother_patrBTN.Location = new Point(8, 101);
            regiother_patrBTN.Margin = new Padding(4);
            regiother_patrBTN.Name = "regiother_patrBTN";
            regiother_patrBTN.Size = new Size(60, 19);
            regiother_patrBTN.TabIndex = 57;
            regiother_patrBTN.Text = "其他";
            regiother_patrBTN.UseVisualStyleBackColor = true;
            regiother_patrBTN.CheckedChanged += regiother_patrBTN_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 160);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 55;
            label1.Text = "原始图案值";
            // 
            // regipatternNUD
            // 
            regipatternNUD.Enabled = false;
            regipatternNUD.Location = new Point(12, 178);
            regipatternNUD.Margin = new Padding(4);
            regipatternNUD.Name = "regipatternNUD";
            regipatternNUD.Size = new Size(124, 25);
            regipatternNUD.TabIndex = 55;
            regipatternNUD.ValueChanged += regipatternNUD_ValueChanged;
            // 
            // regieleki_patrBTN
            // 
            regieleki_patrBTN.AutoSize = true;
            regieleki_patrBTN.Location = new Point(8, 75);
            regieleki_patrBTN.Margin = new Padding(4);
            regieleki_patrBTN.Name = "regieleki_patrBTN";
            regieleki_patrBTN.Size = new Size(108, 19);
            regieleki_patrBTN.TabIndex = 57;
            regieleki_patrBTN.Text = "雷吉艾勒奇";
            regieleki_patrBTN.UseVisualStyleBackColor = true;
            regieleki_patrBTN.CheckedChanged += regieleki_patrBTN_CheckedChanged;
            // 
            // reginone_patrBTN
            // 
            reginone_patrBTN.AutoSize = true;
            reginone_patrBTN.Checked = true;
            reginone_patrBTN.Location = new Point(8, 22);
            reginone_patrBTN.Margin = new Padding(4);
            reginone_patrBTN.Name = "reginone_patrBTN";
            reginone_patrBTN.Size = new Size(92, 19);
            reginone_patrBTN.TabIndex = 55;
            reginone_patrBTN.TabStop = true;
            reginone_patrBTN.Text = "两者都不";
            reginone_patrBTN.UseVisualStyleBackColor = true;
            reginone_patrBTN.CheckedChanged += reginone_patrBTN_CheckedChanged;
            // 
            // regidrago_patrBTN
            // 
            regidrago_patrBTN.AutoSize = true;
            regidrago_patrBTN.Location = new Point(8, 49);
            regidrago_patrBTN.Margin = new Padding(4);
            regidrago_patrBTN.Name = "regidrago_patrBTN";
            regidrago_patrBTN.Size = new Size(108, 19);
            regidrago_patrBTN.TabIndex = 56;
            regidrago_patrBTN.Text = "雷吉铎拉戈";
            regidrago_patrBTN.UseVisualStyleBackColor = true;
            regidrago_patrBTN.CheckedChanged += regidrago_patrBTN_CheckedChanged;
            // 
            // legailty_CB
            // 
            legailty_CB.AutoSize = true;
            legailty_CB.Location = new Point(200, 248);
            legailty_CB.Margin = new Padding(4);
            legailty_CB.Name = "legailty_CB";
            legailty_CB.Size = new Size(141, 19);
            legailty_CB.TabIndex = 57;
            legailty_CB.Text = "强制合法性纠正";
            legailty_CB.UseVisualStyleBackColor = true;
            legailty_CB.CheckedChanged += forcematchCB_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 242);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 56;
            // 
            // applyBTN
            // 
            applyBTN.Location = new Point(16, 230);
            applyBTN.Margin = new Padding(4);
            applyBTN.Name = "applyBTN";
            applyBTN.Size = new Size(172, 56);
            applyBTN.TabIndex = 57;
            applyBTN.Text = "应用所选内容";
            applyBTN.UseVisualStyleBackColor = true;
            applyBTN.Click += applyBTN_Click;
            // 
            // legalLBL
            // 
            legalLBL.AutoSize = true;
            legalLBL.Location = new Point(196, 230);
            legalLBL.Margin = new Padding(4, 0, 4, 0);
            legalLBL.Name = "legalLBL";
            legalLBL.Size = new Size(119, 15);
            legalLBL.TabIndex = 58;
            legalLBL.Text = "合法性: 不适用";
            // 
            // RegiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 296);
            Controls.Add(legalLBL);
            Controls.Add(legailty_CB);
            Controls.Add(applyBTN);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox12);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "RegiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "雷吉形态编辑器";
            Load += RegiForm_Load;
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)regipatternNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton regieleki_RBTN;
        private System.Windows.Forms.RadioButton regidrago_RBTN;
        private System.Windows.Forms.RadioButton reginone_RBTN;
        private System.Windows.Forms.CheckedListBox regi_clistbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox legailty_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown regipatternNUD;
        private System.Windows.Forms.RadioButton regieleki_patrBTN;
        private System.Windows.Forms.RadioButton reginone_patrBTN;
        private System.Windows.Forms.RadioButton regidrago_patrBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton regiother_patrBTN;
        private System.Windows.Forms.Button applyBTN;
        private System.Windows.Forms.Label legalLBL;
    }
}