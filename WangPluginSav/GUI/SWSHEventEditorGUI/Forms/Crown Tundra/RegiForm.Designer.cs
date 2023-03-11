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
            groupBox12.Location = new Point(16, 18);
            groupBox12.Margin = new Padding(4, 5, 4, 5);
            groupBox12.Name = "groupBox12";
            groupBox12.Padding = new Padding(4, 5, 4, 5);
            groupBox12.Size = new Size(176, 278);
            groupBox12.TabIndex = 53;
            groupBox12.TabStop = false;
            groupBox12.Text = "Caught";
            // 
            // regieleki_RBTN
            // 
            regieleki_RBTN.AutoSize = true;
            regieleki_RBTN.Location = new Point(8, 208);
            regieleki_RBTN.Margin = new Padding(4, 5, 4, 5);
            regieleki_RBTN.Name = "regieleki_RBTN";
            regieleki_RBTN.Size = new Size(91, 24);
            regieleki_RBTN.TabIndex = 54;
            regieleki_RBTN.Text = "Regieleki";
            regieleki_RBTN.UseVisualStyleBackColor = true;
            regieleki_RBTN.CheckedChanged += regieleki_RBTN_CheckedChanged;
            // 
            // regidrago_RBTN
            // 
            regidrago_RBTN.AutoSize = true;
            regidrago_RBTN.Location = new Point(8, 172);
            regidrago_RBTN.Margin = new Padding(4, 5, 4, 5);
            regidrago_RBTN.Name = "regidrago_RBTN";
            regidrago_RBTN.Size = new Size(100, 24);
            regidrago_RBTN.TabIndex = 53;
            regidrago_RBTN.Text = "Regidrago";
            regidrago_RBTN.UseVisualStyleBackColor = true;
            regidrago_RBTN.CheckedChanged += regidrago_RBTN_CheckedChanged;
            // 
            // regi_clistbox
            // 
            regi_clistbox.FormattingEnabled = true;
            regi_clistbox.Items.AddRange(new object[] { "Regirock", "Regice", "Registeel", "Regigigas" });
            regi_clistbox.Location = new Point(8, 29);
            regi_clistbox.Margin = new Padding(4, 5, 4, 5);
            regi_clistbox.Name = "regi_clistbox";
            regi_clistbox.Size = new Size(159, 92);
            regi_clistbox.TabIndex = 50;
            // 
            // reginone_RBTN
            // 
            reginone_RBTN.AutoSize = true;
            reginone_RBTN.Checked = true;
            reginone_RBTN.Location = new Point(8, 137);
            reginone_RBTN.Margin = new Padding(4, 5, 4, 5);
            reginone_RBTN.Name = "reginone_RBTN";
            reginone_RBTN.Size = new Size(79, 24);
            reginone_RBTN.TabIndex = 52;
            reginone_RBTN.TabStop = true;
            reginone_RBTN.Text = "Neither";
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
            groupBox1.Location = new Point(200, 18);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(187, 278);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = " Regi Pattern";
            // 
            // regiother_patrBTN
            // 
            regiother_patrBTN.AutoSize = true;
            regiother_patrBTN.Location = new Point(8, 135);
            regiother_patrBTN.Margin = new Padding(4, 5, 4, 5);
            regiother_patrBTN.Name = "regiother_patrBTN";
            regiother_patrBTN.Size = new Size(67, 24);
            regiother_patrBTN.TabIndex = 57;
            regiother_patrBTN.Text = "Other";
            regiother_patrBTN.UseVisualStyleBackColor = true;
            regiother_patrBTN.CheckedChanged += regiother_patrBTN_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 214);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 55;
            label1.Text = "Raw Pattern Value";
            // 
            // regipatternNUD
            // 
            regipatternNUD.Enabled = false;
            regipatternNUD.Location = new Point(12, 238);
            regipatternNUD.Margin = new Padding(4, 5, 4, 5);
            regipatternNUD.Name = "regipatternNUD";
            regipatternNUD.Size = new Size(124, 27);
            regipatternNUD.TabIndex = 55;
            regipatternNUD.ValueChanged += regipatternNUD_ValueChanged;
            // 
            // regieleki_patrBTN
            // 
            regieleki_patrBTN.AutoSize = true;
            regieleki_patrBTN.Location = new Point(8, 100);
            regieleki_patrBTN.Margin = new Padding(4, 5, 4, 5);
            regieleki_patrBTN.Name = "regieleki_patrBTN";
            regieleki_patrBTN.Size = new Size(91, 24);
            regieleki_patrBTN.TabIndex = 57;
            regieleki_patrBTN.Text = "Regieleki";
            regieleki_patrBTN.UseVisualStyleBackColor = true;
            regieleki_patrBTN.CheckedChanged += regieleki_patrBTN_CheckedChanged;
            // 
            // reginone_patrBTN
            // 
            reginone_patrBTN.AutoSize = true;
            reginone_patrBTN.Checked = true;
            reginone_patrBTN.Location = new Point(8, 29);
            reginone_patrBTN.Margin = new Padding(4, 5, 4, 5);
            reginone_patrBTN.Name = "reginone_patrBTN";
            reginone_patrBTN.Size = new Size(79, 24);
            reginone_patrBTN.TabIndex = 55;
            reginone_patrBTN.TabStop = true;
            reginone_patrBTN.Text = "Neither";
            reginone_patrBTN.UseVisualStyleBackColor = true;
            reginone_patrBTN.CheckedChanged += reginone_patrBTN_CheckedChanged;
            // 
            // regidrago_patrBTN
            // 
            regidrago_patrBTN.AutoSize = true;
            regidrago_patrBTN.Location = new Point(8, 65);
            regidrago_patrBTN.Margin = new Padding(4, 5, 4, 5);
            regidrago_patrBTN.Name = "regidrago_patrBTN";
            regidrago_patrBTN.Size = new Size(100, 24);
            regidrago_patrBTN.TabIndex = 56;
            regidrago_patrBTN.Text = "Regidrago";
            regidrago_patrBTN.UseVisualStyleBackColor = true;
            regidrago_patrBTN.CheckedChanged += regidrago_patrBTN_CheckedChanged;
            // 
            // legailty_CB
            // 
            legailty_CB.AutoSize = true;
            legailty_CB.Location = new Point(200, 331);
            legailty_CB.Margin = new Padding(4, 5, 4, 5);
            legailty_CB.Name = "legailty_CB";
            legailty_CB.Size = new Size(197, 24);
            legailty_CB.TabIndex = 57;
            legailty_CB.Text = "Force legality corrections";
            legailty_CB.UseVisualStyleBackColor = true;
            legailty_CB.CheckedChanged += forcematchCB_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 323);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 56;
            // 
            // applyBTN
            // 
            applyBTN.Location = new Point(16, 306);
            applyBTN.Margin = new Padding(4, 5, 4, 5);
            applyBTN.Name = "applyBTN";
            applyBTN.Size = new Size(172, 74);
            applyBTN.TabIndex = 57;
            applyBTN.Text = "Apply Selection";
            applyBTN.UseVisualStyleBackColor = true;
            applyBTN.Click += applyBTN_Click;
            // 
            // legalLBL
            // 
            legalLBL.AutoSize = true;
            legalLBL.Location = new Point(196, 306);
            legalLBL.Margin = new Padding(4, 0, 4, 0);
            legalLBL.Name = "legalLBL";
            legalLBL.Size = new Size(123, 20);
            legalLBL.TabIndex = 58;
            legalLBL.Text = "Legal Status: N/A";
            // 
            // RegiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 394);
            Controls.Add(legalLBL);
            Controls.Add(legailty_CB);
            Controls.Add(applyBTN);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox12);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegiForm Editor";
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