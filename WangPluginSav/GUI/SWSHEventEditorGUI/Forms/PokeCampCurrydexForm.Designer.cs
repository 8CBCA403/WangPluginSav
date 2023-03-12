namespace WangPluginSav.Forms
{
    partial class PokeCampCurrydexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokeCampCurrydexForm));
            type_CLB = new CheckedListBox();
            mainingredient_CLB = new CheckedListBox();
            toolStrip1 = new ToolStrip();
            ts_applyBTN = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            camp_has_golden_CB = new CheckBox();
            camp_use_golden_CB = new CheckBox();
            groupBox2 = new GroupBox();
            camp_type_CMB = new ComboBox();
            camp_type_PB = new PictureBox();
            groupBox1 = new GroupBox();
            camp_ball_champion_CB = new CheckBox();
            camp_ball_mirror_CB = new CheckBox();
            camp_ball_tympole_CB = new CheckBox();
            camp_ball_soothe_CB = new CheckBox();
            camp_ball_weighted_CB = new CheckBox();
            camp_ball_fresh_CB = new CheckBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)camp_type_PB).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // type_CLB
            // 
            type_CLB.FormattingEnabled = true;
            type_CLB.Items.AddRange(new object[] { "一般", "辣味", "涩味", "甜味", "苦味", "酸味" });
            type_CLB.Location = new Point(155, 7);
            type_CLB.Margin = new Padding(4);
            type_CLB.Name = "type_CLB";
            type_CLB.Size = new Size(91, 84);
            type_CLB.TabIndex = 0;
            // 
            // mainingredient_CLB
            // 
            mainingredient_CLB.FormattingEnabled = true;
            mainingredient_CLB.Items.AddRange(new object[] { "无", "粗绞肉香肠", "饱伯罐头", "巴哈罐头", "豆子罐头", "吐司面包", "通心粉", "袋装蕈菇", "烟熏尾巴", "粗枝大葱", "特选苹果", "细骨", "袋装土豆", "水边香草", "袋装蔬菜", "炸物拼盘", "水煮蛋", "袋装果实", "哞哞乳酪", "香料组合", "鲜鲜奶油", "即食咖喱", "椰奶", "即食面", "即食肉排" });
            mainingredient_CLB.Location = new Point(8, 7);
            mainingredient_CLB.Margin = new Padding(4);
            mainingredient_CLB.Name = "mainingredient_CLB";
            mainingredient_CLB.Size = new Size(139, 424);
            mainingredient_CLB.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ts_applyBTN });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(264, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // ts_applyBTN
            // 
            ts_applyBTN.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ts_applyBTN.Image = (Image)resources.GetObject("ts_applyBTN.Image");
            ts_applyBTN.ImageTransparentColor = Color.Magenta;
            ts_applyBTN.Name = "ts_applyBTN";
            ts_applyBTN.Size = new Size(107, 22);
            ts_applyBTN.Text = "应用所选内容";
            ts_applyBTN.Click += ts_applyBTN_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(93, 22);
            toolStripButton1.Text = "应用所选内容";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 25);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(264, 473);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(type_CLB);
            tabPage1.Controls.Add(mainingredient_CLB);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(256, 444);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "咖喱图鉴";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(295, 461);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "宝可梦野营";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(camp_has_golden_CB);
            groupBox3.Controls.Add(camp_use_golden_CB);
            groupBox3.Location = new Point(11, 73);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(267, 69);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "烹饪";
            // 
            // camp_has_golden_CB
            // 
            camp_has_golden_CB.AutoSize = true;
            camp_has_golden_CB.Location = new Point(8, 17);
            camp_has_golden_CB.Margin = new Padding(4);
            camp_has_golden_CB.Name = "camp_has_golden_CB";
            camp_has_golden_CB.Size = new Size(197, 19);
            camp_has_golden_CB.TabIndex = 3;
            camp_has_golden_CB.Text = "拥有金色厨具/暴鲤龙扇";
            camp_has_golden_CB.UseVisualStyleBackColor = true;
            // 
            // camp_use_golden_CB
            // 
            camp_use_golden_CB.AutoSize = true;
            camp_use_golden_CB.Location = new Point(8, 44);
            camp_use_golden_CB.Margin = new Padding(4);
            camp_use_golden_CB.Name = "camp_use_golden_CB";
            camp_use_golden_CB.Size = new Size(197, 19);
            camp_use_golden_CB.TabIndex = 4;
            camp_use_golden_CB.Text = "使用金色厨具/暴鲤龙扇";
            camp_use_golden_CB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(camp_type_CMB);
            groupBox2.Controls.Add(camp_type_PB);
            groupBox2.Location = new Point(11, 7);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(267, 58);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "帐篷颜色";
            // 
            // camp_type_CMB
            // 
            camp_type_CMB.DropDownStyle = ComboBoxStyle.DropDownList;
            camp_type_CMB.FormattingEnabled = true;
            camp_type_CMB.Items.AddRange(new object[] { "一般", "格斗", "飞行", "毒", "地面", "岩石", "虫", "幽灵", "钢", "火", "水", "草", "电", "超能力", "冰", "龙", "恶", "妖精" });
            camp_type_CMB.Location = new Point(8, 22);
            camp_type_CMB.Margin = new Padding(4);
            camp_type_CMB.Name = "camp_type_CMB";
            camp_type_CMB.Size = new Size(108, 23);
            camp_type_CMB.TabIndex = 5;
            camp_type_CMB.SelectedIndexChanged += camp_type_CMB_SelectedIndexChanged;
            // 
            // camp_type_PB
            // 
            camp_type_PB.Location = new Point(125, 22);
            camp_type_PB.Margin = new Padding(4);
            camp_type_PB.Name = "camp_type_PB";
            camp_type_PB.Size = new Size(112, 21);
            camp_type_PB.TabIndex = 5;
            camp_type_PB.TabStop = false;
            camp_type_PB.Paint += camp_type_PB_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(camp_ball_champion_CB);
            groupBox1.Controls.Add(camp_ball_mirror_CB);
            groupBox1.Controls.Add(camp_ball_tympole_CB);
            groupBox1.Controls.Add(camp_ball_soothe_CB);
            groupBox1.Controls.Add(camp_ball_weighted_CB);
            groupBox1.Controls.Add(camp_ball_fresh_CB);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(11, 148);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(267, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "球/玩具";
            // 
            // camp_ball_champion_CB
            // 
            camp_ball_champion_CB.AutoSize = true;
            camp_ball_champion_CB.Location = new Point(59, 242);
            camp_ball_champion_CB.Margin = new Padding(4);
            camp_ball_champion_CB.Name = "camp_ball_champion_CB";
            camp_ball_champion_CB.Size = new Size(77, 19);
            camp_ball_champion_CB.TabIndex = 8;
            camp_ball_champion_CB.Text = "冠军球";
            camp_ball_champion_CB.UseVisualStyleBackColor = true;
            // 
            // camp_ball_mirror_CB
            // 
            camp_ball_mirror_CB.AutoSize = true;
            camp_ball_mirror_CB.Location = new Point(59, 154);
            camp_ball_mirror_CB.Margin = new Padding(4);
            camp_ball_mirror_CB.Name = "camp_ball_mirror_CB";
            camp_ball_mirror_CB.Size = new Size(77, 19);
            camp_ball_mirror_CB.TabIndex = 7;
            camp_ball_mirror_CB.Text = "镜面球";
            camp_ball_mirror_CB.UseVisualStyleBackColor = true;
            // 
            // camp_ball_tympole_CB
            // 
            camp_ball_tympole_CB.AutoSize = true;
            camp_ball_tympole_CB.Location = new Point(59, 197);
            camp_ball_tympole_CB.Margin = new Padding(4);
            camp_ball_tympole_CB.Name = "camp_ball_tympole_CB";
            camp_ball_tympole_CB.Size = new Size(77, 19);
            camp_ball_tympole_CB.TabIndex = 7;
            camp_ball_tympole_CB.Text = "蝌蚪球";
            camp_ball_tympole_CB.UseVisualStyleBackColor = true;
            // 
            // camp_ball_soothe_CB
            // 
            camp_ball_soothe_CB.AutoSize = true;
            camp_ball_soothe_CB.Location = new Point(59, 110);
            camp_ball_soothe_CB.Margin = new Padding(4);
            camp_ball_soothe_CB.Name = "camp_ball_soothe_CB";
            camp_ball_soothe_CB.Size = new Size(77, 19);
            camp_ball_soothe_CB.TabIndex = 6;
            camp_ball_soothe_CB.Text = "静心球";
            camp_ball_soothe_CB.UseVisualStyleBackColor = true;
            // 
            // camp_ball_weighted_CB
            // 
            camp_ball_weighted_CB.AutoSize = true;
            camp_ball_weighted_CB.Location = new Point(59, 66);
            camp_ball_weighted_CB.Margin = new Padding(4);
            camp_ball_weighted_CB.Name = "camp_ball_weighted_CB";
            camp_ball_weighted_CB.Size = new Size(77, 19);
            camp_ball_weighted_CB.TabIndex = 3;
            camp_ball_weighted_CB.Text = "重沉球";
            camp_ball_weighted_CB.UseVisualStyleBackColor = true;
            // 
            // camp_ball_fresh_CB
            // 
            camp_ball_fresh_CB.AutoSize = true;
            camp_ball_fresh_CB.Location = new Point(59, 22);
            camp_ball_fresh_CB.Margin = new Padding(4);
            camp_ball_fresh_CB.Name = "camp_ball_fresh_CB";
            camp_ball_fresh_CB.Size = new Size(77, 19);
            camp_ball_fresh_CB.TabIndex = 2;
            camp_ball_fresh_CB.Text = "瓜西球";
            camp_ball_fresh_CB.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.ball_champion;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(8, 242);
            pictureBox6.Margin = new Padding(4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 37);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.ball_Tympole;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(8, 197);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 37);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.ball_mirror;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(8, 154);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 37);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.ball_soothe;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(8, 110);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 37);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.ball_weighted;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(8, 66);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 37);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ball_fresh;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(8, 22);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 37);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PokeCampCurrydexForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 498);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "PokeCampCurrydexForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "宝可梦野营/咖喱图鉴";
            Load += CurrdexForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)camp_type_PB).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckedListBox type_CLB;
        private System.Windows.Forms.CheckedListBox mainingredient_CLB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox camp_ball_champion_CB;
        private System.Windows.Forms.CheckBox camp_ball_mirror_CB;
        private System.Windows.Forms.CheckBox camp_ball_tympole_CB;
        private System.Windows.Forms.CheckBox camp_ball_soothe_CB;
        private System.Windows.Forms.CheckBox camp_ball_weighted_CB;
        private System.Windows.Forms.CheckBox camp_ball_fresh_CB;
        private System.Windows.Forms.CheckBox camp_has_golden_CB;
        private System.Windows.Forms.CheckBox camp_use_golden_CB;
        private System.Windows.Forms.PictureBox camp_type_PB;
        private System.Windows.Forms.ComboBox camp_type_CMB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripButton ts_applyBTN;
    }
}