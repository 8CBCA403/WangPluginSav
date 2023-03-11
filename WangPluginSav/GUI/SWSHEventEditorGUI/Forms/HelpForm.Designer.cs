namespace WangPluginSav
{
    partial class HelpForm
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
            this.versionLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpyclip2_BTN = new System.Windows.Forms.Button();
            this.cpyclip1_BTN = new System.Windows.Forms.Button();
            this.projpok_BTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.github_BTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // versionLBL
            // 
            this.versionLBL.AutoSize = true;
            this.versionLBL.Location = new System.Drawing.Point(6, 243);
            this.versionLBL.Name = "versionLBL";
            this.versionLBL.Size = new System.Drawing.Size(45, 13);
            this.versionLBL.TabIndex = 0;
            this.versionLBL.Text = "Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pokémon Sword/Shield Save Block Editor\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "aaa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cpyclip2_BTN);
            this.groupBox2.Controls.Add(this.versionLBL);
            this.groupBox2.Controls.Add(this.cpyclip1_BTN);
            this.groupBox2.Controls.Add(this.projpok_BTN);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.github_BTN);
            this.groupBox2.Location = new System.Drawing.Point(15, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bug Report";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 173);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Darthfiggy#9205";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "RadixComet#3669";
            // 
            // cpyclip2_BTN
            // 
            this.cpyclip2_BTN.BackgroundImage = global::WangPluginSav.Properties.Resources.clipboard;
            this.cpyclip2_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cpyclip2_BTN.Location = new System.Drawing.Point(9, 167);
            this.cpyclip2_BTN.Name = "cpyclip2_BTN";
            this.cpyclip2_BTN.Size = new System.Drawing.Size(25, 25);
            this.cpyclip2_BTN.TabIndex = 5;
            this.cpyclip2_BTN.UseVisualStyleBackColor = true;
            this.cpyclip2_BTN.Click += new System.EventHandler(this.cpyclip2_BTN_Click);
            // 
            // cpyclip1_BTN
            // 
            this.cpyclip1_BTN.BackgroundImage = global::WangPluginSav.Properties.Resources.clipboard;
            this.cpyclip1_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cpyclip1_BTN.Location = new System.Drawing.Point(9, 136);
            this.cpyclip1_BTN.Name = "cpyclip1_BTN";
            this.cpyclip1_BTN.Size = new System.Drawing.Size(25, 25);
            this.cpyclip1_BTN.TabIndex = 4;
            this.cpyclip1_BTN.UseVisualStyleBackColor = true;
            this.cpyclip1_BTN.Click += new System.EventHandler(this.cpyclip1_BTN_Click);
            // 
            // projpok_BTN
            // 
            this.projpok_BTN.BackgroundImage = global::WangPluginSav.Properties.Resources.pp;
            this.projpok_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.projpok_BTN.Location = new System.Drawing.Point(153, 198);
            this.projpok_BTN.Name = "projpok_BTN";
            this.projpok_BTN.Size = new System.Drawing.Size(112, 42);
            this.projpok_BTN.TabIndex = 5;
            this.projpok_BTN.UseVisualStyleBackColor = true;
            this.projpok_BTN.Click += new System.EventHandler(this.projpok_BTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "aaa";
            // 
            // github_BTN
            // 
            this.github_BTN.BackgroundImage = global::WangPluginSav.Properties.Resources.github;
            this.github_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.github_BTN.Location = new System.Drawing.Point(9, 198);
            this.github_BTN.Name = "github_BTN";
            this.github_BTN.Size = new System.Drawing.Size(112, 42);
            this.github_BTN.TabIndex = 4;
            this.github_BTN.UseVisualStyleBackColor = true;
            this.github_BTN.Click += new System.EventHandler(this.github_BTN_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HelpForm";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label versionLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button github_BTN;
        private System.Windows.Forms.Button projpok_BTN;
        private System.Windows.Forms.Button cpyclip1_BTN;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cpyclip2_BTN;
    }
}