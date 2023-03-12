namespace WangPluginSav
{
    partial class SOJForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SOJForm));
            groupBox6 = new GroupBox();
            virizion_CB = new CheckBox();
            terrakion_CB = new CheckBox();
            cobalion_CB = new CheckBox();
            keldeo_CB = new CheckBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            vfootper_NUD = new NumericUpDown();
            tfootper_NUD = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            cfootper_NUD = new NumericUpDown();
            label1 = new Label();
            apply_BTN = new Button();
            legality_CB = new CheckBox();
            legality_LBL = new Label();
            groupBox6.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vfootper_NUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tfootper_NUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cfootper_NUD).BeginInit();
            SuspendLayout();
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(virizion_CB);
            groupBox6.Controls.Add(terrakion_CB);
            groupBox6.Controls.Add(cobalion_CB);
            groupBox6.Controls.Add(keldeo_CB);
            groupBox6.Location = new Point(16, 14);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(176, 133);
            groupBox6.TabIndex = 45;
            groupBox6.TabStop = false;
            groupBox6.Text = "捕获";
            // 
            // virizion_CB
            // 
            virizion_CB.AutoSize = true;
            virizion_CB.Enabled = false;
            virizion_CB.Location = new Point(8, 79);
            virizion_CB.Margin = new Padding(4);
            virizion_CB.Name = "virizion_CB";
            virizion_CB.Size = new Size(93, 19);
            virizion_CB.TabIndex = 51;
            virizion_CB.Text = "毕力吉翁";
            virizion_CB.UseVisualStyleBackColor = true;
            virizion_CB.CheckedChanged += virizion_CB_CheckedChanged;
            // 
            // terrakion_CB
            // 
            terrakion_CB.AutoSize = true;
            terrakion_CB.Enabled = false;
            terrakion_CB.Location = new Point(8, 52);
            terrakion_CB.Margin = new Padding(4);
            terrakion_CB.Name = "terrakion_CB";
            terrakion_CB.Size = new Size(93, 19);
            terrakion_CB.TabIndex = 50;
            terrakion_CB.Text = "代拉基翁";
            terrakion_CB.UseVisualStyleBackColor = true;
            terrakion_CB.CheckedChanged += terrakion_CB_CheckedChanged;
            // 
            // cobalion_CB
            // 
            cobalion_CB.AutoSize = true;
            cobalion_CB.Enabled = false;
            cobalion_CB.Location = new Point(8, 26);
            cobalion_CB.Margin = new Padding(4);
            cobalion_CB.Name = "cobalion_CB";
            cobalion_CB.Size = new Size(93, 19);
            cobalion_CB.TabIndex = 49;
            cobalion_CB.Text = "勾帕路翁";
            cobalion_CB.UseVisualStyleBackColor = true;
            cobalion_CB.CheckedChanged += cobalion_CB_CheckedChanged;
            // 
            // keldeo_CB
            // 
            keldeo_CB.AutoSize = true;
            keldeo_CB.Enabled = false;
            keldeo_CB.Location = new Point(8, 105);
            keldeo_CB.Margin = new Padding(4);
            keldeo_CB.Name = "keldeo_CB";
            keldeo_CB.Size = new Size(93, 19);
            keldeo_CB.TabIndex = 48;
            keldeo_CB.Text = "凯路迪欧";
            keldeo_CB.UseVisualStyleBackColor = true;
            keldeo_CB.CheckedChanged += keldeo_CB_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(vfootper_NUD);
            groupBox1.Controls.Add(tfootper_NUD);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cfootper_NUD);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(200, 14);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(196, 133);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "足迹百分比";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 24);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 52;
            label6.Text = "%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 54);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 51;
            label5.Text = "%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 84);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 50;
            label4.Text = "%";
            // 
            // vfootper_NUD
            // 
            vfootper_NUD.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            vfootper_NUD.Location = new Point(92, 82);
            vfootper_NUD.Margin = new Padding(4);
            vfootper_NUD.Name = "vfootper_NUD";
            vfootper_NUD.Size = new Size(67, 25);
            vfootper_NUD.TabIndex = 51;
            vfootper_NUD.ValueChanged += vfootper_NUD_ValueChanged;
            // 
            // tfootper_NUD
            // 
            tfootper_NUD.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            tfootper_NUD.Location = new Point(92, 52);
            tfootper_NUD.Margin = new Padding(4);
            tfootper_NUD.Name = "tfootper_NUD";
            tfootper_NUD.Size = new Size(67, 25);
            tfootper_NUD.TabIndex = 50;
            tfootper_NUD.ValueChanged += tfootper_NUD_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 84);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 49;
            label3.Text = "毕力吉翁";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 48;
            label2.Text = "代拉基翁";
            // 
            // cfootper_NUD
            // 
            cfootper_NUD.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            cfootper_NUD.Location = new Point(92, 22);
            cfootper_NUD.Margin = new Padding(4);
            cfootper_NUD.Name = "cfootper_NUD";
            cfootper_NUD.Size = new Size(67, 25);
            cfootper_NUD.TabIndex = 48;
            cfootper_NUD.ValueChanged += cfootper_NUD_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 47;
            label1.Text = "勾帕路翁";
            // 
            // apply_BTN
            // 
            apply_BTN.Location = new Point(16, 154);
            apply_BTN.Margin = new Padding(4);
            apply_BTN.Name = "apply_BTN";
            apply_BTN.Size = new Size(176, 56);
            apply_BTN.TabIndex = 47;
            apply_BTN.Text = "应用所选内容";
            apply_BTN.UseVisualStyleBackColor = true;
            apply_BTN.Click += apply_BTN_Click;
            // 
            // legality_CB
            // 
            legality_CB.AutoSize = true;
            legality_CB.Checked = true;
            legality_CB.CheckState = CheckState.Checked;
            legality_CB.Location = new Point(200, 173);
            legality_CB.Margin = new Padding(4);
            legality_CB.Name = "legality_CB";
            legality_CB.Size = new Size(141, 19);
            legality_CB.TabIndex = 53;
            legality_CB.Text = "强制合法性纠正";
            legality_CB.UseVisualStyleBackColor = true;
            legality_CB.CheckedChanged += legality_CB_CheckedChanged;
            // 
            // legality_LBL
            // 
            legality_LBL.AutoSize = true;
            legality_LBL.Location = new Point(200, 154);
            legality_LBL.Margin = new Padding(4, 0, 4, 0);
            legality_LBL.Name = "legality_LBL";
            legality_LBL.Size = new Size(63, 15);
            legality_LBL.TabIndex = 54;
            legality_LBL.Text = "合法性:";
            // 
            // SOJForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 220);
            Controls.Add(legality_LBL);
            Controls.Add(legality_CB);
            Controls.Add(apply_BTN);
            Controls.Add(groupBox1);
            Controls.Add(groupBox6);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SOJForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "四剑客编辑器";
            Load += SOJForm_Load;
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vfootper_NUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)tfootper_NUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)cfootper_NUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox keldeo_CB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown vfootper_NUD;
        private System.Windows.Forms.NumericUpDown tfootper_NUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cfootper_NUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apply_BTN;
        private System.Windows.Forms.CheckBox virizion_CB;
        private System.Windows.Forms.CheckBox terrakion_CB;
        private System.Windows.Forms.CheckBox cobalion_CB;
        private System.Windows.Forms.CheckBox legality_CB;
        private System.Windows.Forms.Label legality_LBL;
    }
}