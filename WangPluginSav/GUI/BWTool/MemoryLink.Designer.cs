/*
 * Created by SharpDevelop.
 * User: LAURA
 * Date: 19/06/2016
 * Time: 10:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
    partial class MemoryLink
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button Exit_but;
        private System.Windows.Forms.Button Saveexit_but;
        private System.Windows.Forms.Button b1_export;
        private System.Windows.Forms.Button b1m_export;
        private System.Windows.Forms.Button b2_export;
        private System.Windows.Forms.Button b2_import;
        private System.Windows.Forms.Button b1m_import;
        private System.Windows.Forms.Button b1_import;
        private System.Windows.Forms.Button memory_export;
        private System.Windows.Forms.Button memory_import;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sid;
        private System.Windows.Forms.NumericUpDown tid;
        private System.Windows.Forms.CheckBox flag8;
        private System.Windows.Forms.CheckBox flag7;
        private System.Windows.Forms.CheckBox flag6;
        private System.Windows.Forms.CheckBox flag5;
        private System.Windows.Forms.CheckBox flag4;
        private System.Windows.Forms.CheckBox flag3;
        private System.Windows.Forms.CheckBox flag2;
        private System.Windows.Forms.CheckBox flag1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button import_bw1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryLink));
            Exit_but = new Button();
            Saveexit_but = new Button();
            b1_export = new Button();
            b1m_export = new Button();
            b2_export = new Button();
            b2_import = new Button();
            b1m_import = new Button();
            b1_import = new Button();
            memory_export = new Button();
            memory_import = new Button();
            groupBox1 = new GroupBox();
            PROP = new Label();
            label11 = new Label();
            name = new TextBox();
            sid = new NumericUpDown();
            tid = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flag8 = new CheckBox();
            flag7 = new CheckBox();
            flag6 = new CheckBox();
            flag5 = new CheckBox();
            flag4 = new CheckBox();
            flag3 = new CheckBox();
            flag2 = new CheckBox();
            flag1 = new CheckBox();
            label4 = new Label();
            import_bw1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            starter = new ComboBox();
            label10 = new Label();
            PropUnlockBut = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tid).BeginInit();
            SuspendLayout();
            // 
            // Exit_but
            // 
            Exit_but.Location = new Point(40, 325);
            Exit_but.Margin = new Padding(4, 4, 4, 4);
            Exit_but.Name = "Exit_but";
            Exit_but.Size = new Size(136, 26);
            Exit_but.TabIndex = 21;
            Exit_but.Text = "退出";
            Exit_but.UseVisualStyleBackColor = true;
            Exit_but.Click += Exit_butClick;
            // 
            // Saveexit_but
            // 
            Saveexit_but.Location = new Point(183, 325);
            Saveexit_but.Margin = new Padding(4, 4, 4, 4);
            Saveexit_but.Name = "Saveexit_but";
            Saveexit_but.Size = new Size(136, 26);
            Saveexit_but.TabIndex = 20;
            Saveexit_but.Text = "保存并退出";
            Saveexit_but.UseVisualStyleBackColor = true;
            Saveexit_but.Click += Saveexit_butClick;
            // 
            // b1_export
            // 
            b1_export.Location = new Point(8, 22);
            b1_export.Margin = new Padding(4, 4, 4, 4);
            b1_export.Name = "b1_export";
            b1_export.Size = new Size(159, 43);
            b1_export.TabIndex = 22;
            b1_export.Text = "导出区块1\r\n(解密)";
            b1_export.UseVisualStyleBackColor = true;
            b1_export.Click += B1_exportClick;
            // 
            // b1m_export
            // 
            b1m_export.Location = new Point(8, 71);
            b1m_export.Margin = new Padding(4, 4, 4, 4);
            b1m_export.Name = "b1m_export";
            b1m_export.Size = new Size(159, 43);
            b1m_export.TabIndex = 23;
            b1m_export.Text = "导出区块1镜像\r\n(解密)";
            b1m_export.UseVisualStyleBackColor = true;
            b1m_export.Click += B1m_exportClick;
            // 
            // b2_export
            // 
            b2_export.Location = new Point(8, 122);
            b2_export.Margin = new Padding(4, 4, 4, 4);
            b2_export.Name = "b2_export";
            b2_export.Size = new Size(159, 43);
            b2_export.TabIndex = 24;
            b2_export.Text = "导出区块2";
            b2_export.UseVisualStyleBackColor = true;
            b2_export.Click += B2_exportClick;
            // 
            // b2_import
            // 
            b2_import.Location = new Point(175, 122);
            b2_import.Margin = new Padding(4, 4, 4, 4);
            b2_import.Name = "b2_import";
            b2_import.Size = new Size(159, 43);
            b2_import.TabIndex = 27;
            b2_import.Text = "导入区块2";
            b2_import.UseVisualStyleBackColor = true;
            b2_import.Click += B2_importClick;
            // 
            // b1m_import
            // 
            b1m_import.Location = new Point(175, 71);
            b1m_import.Margin = new Padding(4, 4, 4, 4);
            b1m_import.Name = "b1m_import";
            b1m_import.Size = new Size(159, 43);
            b1m_import.TabIndex = 26;
            b1m_import.Text = "导入区块1镜像\r\n(解密)";
            b1m_import.UseVisualStyleBackColor = true;
            b1m_import.Click += B1m_importClick;
            // 
            // b1_import
            // 
            b1_import.Location = new Point(175, 22);
            b1_import.Margin = new Padding(4, 4, 4, 4);
            b1_import.Name = "b1_import";
            b1_import.Size = new Size(159, 43);
            b1_import.TabIndex = 25;
            b1_import.Text = "导入区块1\r\n(解密)";
            b1_import.UseVisualStyleBackColor = true;
            b1_import.Click += B1_importClick;
            // 
            // memory_export
            // 
            memory_export.Location = new Point(16, 14);
            memory_export.Margin = new Padding(4, 4, 4, 4);
            memory_export.Name = "memory_export";
            memory_export.Size = new Size(159, 43);
            memory_export.TabIndex = 29;
            memory_export.Text = "导出记忆";
            memory_export.UseVisualStyleBackColor = true;
            memory_export.Click += Memory_exportClick;
            // 
            // memory_import
            // 
            memory_import.Location = new Point(183, 14);
            memory_import.Margin = new Padding(4, 4, 4, 4);
            memory_import.Name = "memory_import";
            memory_import.Size = new Size(159, 43);
            memory_import.TabIndex = 28;
            memory_import.Text = "导入记忆";
            memory_import.UseVisualStyleBackColor = true;
            memory_import.Click += Memory_importClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PROP);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(b2_import);
            groupBox1.Controls.Add(b1m_import);
            groupBox1.Controls.Add(b1_import);
            groupBox1.Controls.Add(b2_export);
            groupBox1.Controls.Add(b1m_export);
            groupBox1.Controls.Add(b1_export);
            groupBox1.Location = new Point(531, 161);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(332, 190);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "研究用";
            // 
            // PROP
            // 
            PROP.Location = new Point(73, 164);
            PROP.Margin = new Padding(4, 0, 4, 0);
            PROP.Name = "PROP";
            PROP.Size = new Size(260, 22);
            PROP.TabIndex = 55;
            PROP.Text = "0";
            // 
            // label11
            // 
            label11.Location = new Point(8, 164);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(89, 22);
            label11.TabIndex = 54;
            label11.Text = "物品箱: 0x";
            // 
            // name
            // 
            name.Location = new Point(155, 85);
            name.Margin = new Padding(4, 4, 4, 4);
            name.MaxLength = 8;
            name.Name = "name";
            name.Size = new Size(159, 25);
            name.TabIndex = 36;
            // 
            // sid
            // 
            sid.Location = new Point(156, 145);
            sid.Margin = new Padding(4, 4, 4, 4);
            sid.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            sid.Name = "sid";
            sid.Size = new Size(160, 25);
            sid.TabIndex = 35;
            // 
            // tid
            // 
            tid.Location = new Point(156, 115);
            tid.Margin = new Padding(4, 4, 4, 4);
            tid.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            tid.Name = "tid";
            tid.Size = new Size(160, 25);
            tid.TabIndex = 34;
            // 
            // label3
            // 
            label3.Location = new Point(45, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 26);
            label3.TabIndex = 33;
            label3.Text = "SID";
            // 
            // label2
            // 
            label2.Location = new Point(45, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 26);
            label2.TabIndex = 32;
            label2.Text = "TID";
            // 
            // label1
            // 
            label1.Location = new Point(45, 88);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 26);
            label1.TabIndex = 31;
            label1.Text = "名字";
            // 
            // flag8
            // 
            flag8.Location = new Point(273, 285);
            flag8.Margin = new Padding(4, 4, 4, 4);
            flag8.Name = "flag8";
            flag8.Size = new Size(219, 34);
            flag8.TabIndex = 44;
            flag8.Text = "与好友相遇和告别";
            flag8.UseVisualStyleBackColor = true;
            // 
            // flag7
            // 
            flag7.Location = new Point(273, 255);
            flag7.Margin = new Padding(4, 4, 4, 4);
            flag7.Name = "flag7";
            flag7.Size = new Size(204, 34);
            flag7.TabIndex = 43;
            flag7.Text = "再见了，心爱的明星";
            flag7.UseVisualStyleBackColor = true;
            // 
            // flag6
            // 
            flag6.Location = new Point(273, 225);
            flag6.Margin = new Padding(4, 4, 4, 4);
            flag6.Name = "flag6";
            flag6.Size = new Size(167, 34);
            flag6.TabIndex = 42;
            flag6.Text = "白与黑";
            flag6.UseVisualStyleBackColor = true;
            // 
            // flag5
            // 
            flag5.Location = new Point(273, 195);
            flag5.Margin = new Padding(4, 4, 4, 4);
            flag5.Name = "flag5";
            flag5.Size = new Size(167, 34);
            flag5.TabIndex = 41;
            flag5.Text = "追求精致！！";
            flag5.UseVisualStyleBackColor = true;
            // 
            // flag4
            // 
            flag4.Location = new Point(71, 285);
            flag4.Margin = new Padding(4, 4, 4, 4);
            flag4.Name = "flag4";
            flag4.Size = new Size(167, 34);
            flag4.TabIndex = 40;
            flag4.Text = "崭新光芒";
            flag4.UseVisualStyleBackColor = true;
            // 
            // flag3
            // 
            flag3.Location = new Point(71, 255);
            flag3.Margin = new Padding(4, 4, 4, 4);
            flag3.Name = "flag3";
            flag3.Size = new Size(167, 34);
            flag3.TabIndex = 39;
            flag3.Text = "追寻之心";
            flag3.UseVisualStyleBackColor = true;
            // 
            // flag2
            // 
            flag2.Location = new Point(71, 225);
            flag2.Margin = new Padding(4, 4, 4, 4);
            flag2.Name = "flag2";
            flag2.Size = new Size(167, 34);
            flag2.TabIndex = 38;
            flag2.Text = "各自的骨头与梦想";
            flag2.UseVisualStyleBackColor = true;
            // 
            // flag1
            // 
            flag1.Location = new Point(71, 195);
            flag1.Margin = new Padding(4, 4, 4, 4);
            flag1.Name = "flag1";
            flag1.Size = new Size(167, 34);
            flag1.TabIndex = 37;
            flag1.Text = "三人聚焦";
            flag1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(16, 174);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(408, 22);
            label4.TabIndex = 45;
            label4.Text = "已解锁的记忆：(仍在研究中，最好不要改动)";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // import_bw1
            // 
            import_bw1.Location = new Point(364, 14);
            import_bw1.Margin = new Padding(4, 4, 4, 4);
            import_bw1.Name = "import_bw1";
            import_bw1.Size = new Size(159, 43);
            import_bw1.TabIndex = 46;
            import_bw1.Text = "从BW1导入数据";
            import_bw1.UseVisualStyleBackColor = true;
            import_bw1.Click += Import_bw1Click;
            // 
            // label5
            // 
            label5.Location = new Point(528, 32);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(196, 43);
            label5.TabIndex = 47;
            label5.Text = "将会导入：";
            // 
            // label6
            // 
            label6.Location = new Point(617, 6);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(176, 26);
            label6.TabIndex = 48;
            label6.Text = "- 训练家名字, TID, SID";
            // 
            // label7
            // 
            label7.Location = new Point(617, 22);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(176, 26);
            label7.TabIndex = 49;
            label7.Text = "- 名人堂";
            // 
            // label8
            // 
            label8.Location = new Point(617, 39);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(176, 26);
            label8.TabIndex = 50;
            label8.Text = "- 初始宝可梦";
            // 
            // label9
            // 
            label9.Location = new Point(331, 84);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 39);
            label9.TabIndex = 51;
            label9.Text = "初始御三家";
            // 
            // starter
            // 
            starter.FormattingEnabled = true;
            starter.Items.AddRange(new object[] { "藤藤蛇", "暖暖猪", "水水獭" });
            starter.Location = new Point(389, 85);
            starter.Margin = new Padding(4, 4, 4, 4);
            starter.Name = "starter";
            starter.Size = new Size(160, 23);
            starter.TabIndex = 52;
            // 
            // label10
            // 
            label10.Location = new Point(617, 55);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(176, 26);
            label10.TabIndex = 53;
            label10.Text = "- 物品箱";
            // 
            // PropUnlockBut
            // 
            PropUnlockBut.Location = new Point(389, 118);
            PropUnlockBut.Margin = new Padding(4, 4, 4, 4);
            PropUnlockBut.Name = "PropUnlockBut";
            PropUnlockBut.Size = new Size(161, 26);
            PropUnlockBut.TabIndex = 54;
            PropUnlockBut.Text = "解锁所有饰品";
            PropUnlockBut.UseVisualStyleBackColor = true;
            PropUnlockBut.Click += PropUnlockButClick;
            // 
            // MemoryLink
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 366);
            Controls.Add(PropUnlockBut);
            Controls.Add(label10);
            Controls.Add(starter);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(import_bw1);
            Controls.Add(label4);
            Controls.Add(flag8);
            Controls.Add(flag7);
            Controls.Add(flag6);
            Controls.Add(flag5);
            Controls.Add(flag4);
            Controls.Add(flag3);
            Controls.Add(flag2);
            Controls.Add(flag1);
            Controls.Add(name);
            Controls.Add(sid);
            Controls.Add(tid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(memory_export);
            Controls.Add(memory_import);
            Controls.Add(Exit_but);
            Controls.Add(Saveexit_but);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "MemoryLink";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "记忆连接编辑器";
            Load += MemoryLinkLoad;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sid).EndInit();
            ((System.ComponentModel.ISupportInitialize)tid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button PropUnlockBut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label PROP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox starter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
