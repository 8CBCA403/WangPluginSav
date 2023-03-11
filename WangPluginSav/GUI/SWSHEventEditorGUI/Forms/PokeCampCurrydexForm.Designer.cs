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
            type_CLB.Items.AddRange(new object[] { "Normal", "Spicy", "Dry", "Sweet", "Bitter", "Sour" });
            type_CLB.Location = new Point(197, 9);
            type_CLB.Margin = new Padding(4, 5, 4, 5);
            type_CLB.Name = "type_CLB";
            type_CLB.Size = new Size(80, 136);
            type_CLB.TabIndex = 0;
            // 
            // mainingredient_CLB
            // 
            mainingredient_CLB.FormattingEnabled = true;
            mainingredient_CLB.Items.AddRange(new object[] { "None", "Sausage", "Bob's Tin Food", "Bach's Tin Food", "Tin of Beans", "Bread", "Pasta", "Mixed Mushrooms", "Smoke-Poke Tail", "Large Leek", "Fancy Apple", "Brittle Bones", "Pack of Potatoes", "Pungent Root", "Salad Mix", "Fried Food", "Boiled Egg", "Fruit Bunch", "Moomoo Cheese", "Spice Mix", "Fresh Cream", "Packaged Curry", "Coconut Milk", "Instant Noodles", "Precooked Burger" });
            mainingredient_CLB.Location = new Point(8, 9);
            mainingredient_CLB.Margin = new Padding(4, 5, 4, 5);
            mainingredient_CLB.Name = "mainingredient_CLB";
            mainingredient_CLB.Size = new Size(180, 576);
            mainingredient_CLB.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ts_applyBTN });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(303, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // ts_applyBTN
            // 
            ts_applyBTN.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ts_applyBTN.Image = (Image)resources.GetObject("ts_applyBTN.Image");
            ts_applyBTN.ImageTransparentColor = Color.Magenta;
            ts_applyBTN.Name = "ts_applyBTN";
            ts_applyBTN.Size = new Size(117, 24);
            ts_applyBTN.Text = "Apply Selection";
            ts_applyBTN.Click += ts_applyBTN_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(93, 22);
            toolStripButton1.Text = "Apply Selection";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 27);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(303, 665);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(type_CLB);
            tabPage1.Controls.Add(mainingredient_CLB);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(295, 632);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Curry Dex";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(295, 632);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pokecamp";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(camp_has_golden_CB);
            groupBox3.Controls.Add(camp_use_golden_CB);
            groupBox3.Location = new Point(11, 97);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(267, 92);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cooking";
            // 
            // camp_has_golden_CB
            // 
            camp_has_golden_CB.AutoSize = true;
            camp_has_golden_CB.Location = new Point(8, 23);
            camp_has_golden_CB.Margin = new Padding(4, 5, 4, 5);
            camp_has_golden_CB.Name = "camp_has_golden_CB";
            camp_has_golden_CB.Size = new Size(193, 24);
            camp_has_golden_CB.TabIndex = 3;
            camp_has_golden_CB.Text = "Has Golden Kitchenware";
            camp_has_golden_CB.UseVisualStyleBackColor = true;
            // 
            // camp_use_golden_CB
            // 
            camp_use_golden_CB.AutoSize = true;
            camp_use_golden_CB.Location = new Point(8, 58);
            camp_use_golden_CB.Margin = new Padding(4, 5, 4, 5);
            camp_use_golden_CB.Name = "camp_use_golden_CB";
            camp_use_golden_CB.Size = new Size(192, 24);
            camp_use_golden_CB.TabIndex = 4;
            camp_use_golden_CB.Text = "Use Golden Kitchenware";
            camp_use_golden_CB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(camp_type_CMB);
            groupBox2.Controls.Add(camp_type_PB);
            groupBox2.Location = new Point(11, 9);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(267, 78);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tent Colour";
            // 
            // camp_type_CMB
            // 
            camp_type_CMB.DropDownStyle = ComboBoxStyle.DropDownList;
            camp_type_CMB.FormattingEnabled = true;
            camp_type_CMB.Items.AddRange(new object[] { "Normal", "Fighting", "Flying", "Poison", "Ground", "Rock", "Bug", "Ghost", "Steel", "Fire", "Water", "Grass", "Electric", "Pyschic", "Ice", "Dragon", "Dark", "Fairy" });
            camp_type_CMB.Location = new Point(8, 29);
            camp_type_CMB.Margin = new Padding(4, 5, 4, 5);
            camp_type_CMB.Name = "camp_type_CMB";
            camp_type_CMB.Size = new Size(108, 28);
            camp_type_CMB.TabIndex = 5;
            camp_type_CMB.SelectedIndexChanged += camp_type_CMB_SelectedIndexChanged;
            // 
            // camp_type_PB
            // 
            camp_type_PB.Location = new Point(125, 29);
            camp_type_PB.Margin = new Padding(4, 5, 4, 5);
            camp_type_PB.Name = "camp_type_PB";
            camp_type_PB.Size = new Size(112, 28);
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
            groupBox1.Location = new Point(11, 198);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(267, 385);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Balls/Toys";
            // 
            // camp_ball_champion_CB
            // 
            camp_ball_champion_CB.AutoSize = true;
            camp_ball_champion_CB.Location = new Point(59, 322);
            camp_ball_champion_CB.Margin = new Padding(4, 5, 4, 5);
            camp_ball_champion_CB.Name = "camp_ball_champion_CB";
            camp_ball_champion_CB.Size = new Size(128, 24);
            camp_ball_champion_CB.TabIndex = 8;
            camp_ball_champion_CB.Text = "Champion Ball";
            camp_ball_champion_CB.UseVisualStyleBackColor = true;
            // 
            // camp_ball_mirror_CB
            // 
            camp_ball_mirror_CB.AutoSize = true;
            camp_ball_mirror_CB.Location = new Point(59, 205);
            camp_ball_mirror_CB.Margin = new Padding(4, 5, 4, 5);
            camp_ball_mirror_CB.Name = "camp_ball_mirror_CB";
            camp_ball_mirror_CB.Size = new Size(101, 24);
            camp_ball_mirror_CB.TabIndex = 7;
            camp_ball_mirror_CB.Text = "Mirror Ball";
            camp_ball_mirror_CB.UseVisualStyleBackColor = true;
            // 
            // camp_ball_tympole_CB
            // 
            camp_ball_tympole_CB.AutoSize = true;
            camp_ball_tympole_CB.Location = new Point(59, 263);
            camp_ball_tympole_CB.Margin = new Padding(4, 5, 4, 5);
            camp_ball_tympole_CB.Name = "camp_ball_tympole_CB";
            camp_ball_tympole_CB.Size = new Size(117, 24);
            camp_ball_tympole_CB.TabIndex = 7;
            camp_ball_tympole_CB.Text = "Tympole Ball";
            camp_ball_tympole_CB.UseVisualStyleBackColor = true;
            // 
            // camp_ball_soothe_CB
            // 
            camp_ball_soothe_CB.AutoSize = true;
            camp_ball_soothe_CB.Location = new Point(59, 146);
            camp_ball_soothe_CB.Margin = new Padding(4, 5, 4, 5);
            camp_ball_soothe_CB.Name = "camp_ball_soothe_CB";
            camp_ball_soothe_CB.Size = new Size(107, 24);
            camp_ball_soothe_CB.TabIndex = 6;
            camp_ball_soothe_CB.Text = "Soothe Ball";
            camp_ball_soothe_CB.UseVisualStyleBackColor = true;
            // 
            // camp_ball_weighted_CB
            // 
            camp_ball_weighted_CB.AutoSize = true;
            camp_ball_weighted_CB.Location = new Point(59, 88);
            camp_ball_weighted_CB.Margin = new Padding(4, 5, 4, 5);
            camp_ball_weighted_CB.Name = "camp_ball_weighted_CB";
            camp_ball_weighted_CB.Size = new Size(124, 24);
            camp_ball_weighted_CB.TabIndex = 3;
            camp_ball_weighted_CB.Text = "Weighted Ball";
            camp_ball_weighted_CB.UseVisualStyleBackColor = true;
            // 
            // camp_ball_fresh_CB
            // 
            camp_ball_fresh_CB.AutoSize = true;
            camp_ball_fresh_CB.Location = new Point(59, 29);
            camp_ball_fresh_CB.Margin = new Padding(4, 5, 4, 5);
            camp_ball_fresh_CB.Name = "camp_ball_fresh_CB";
            camp_ball_fresh_CB.Size = new Size(94, 24);
            camp_ball_fresh_CB.TabIndex = 2;
            camp_ball_fresh_CB.Text = "Fresh Ball";
            camp_ball_fresh_CB.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.ball_champion;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(8, 322);
            pictureBox6.Margin = new Padding(4, 5, 4, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 49);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.ball_Tympole;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(8, 263);
            pictureBox5.Margin = new Padding(4, 5, 4, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 49);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.ball_mirror;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(8, 205);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 49);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.ball_soothe;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(8, 146);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 49);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.ball_weighted;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(8, 88);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 49);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ball_fresh;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(8, 29);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 49);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PokeCampCurrydexForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 692);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "PokeCampCurrydexForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pokemon Camp/Currydex Form";
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