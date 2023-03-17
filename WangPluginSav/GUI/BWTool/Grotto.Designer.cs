/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 17/10/2015
 * Time: 16:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
    partial class Grotto
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox Grotto_route;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox normalgrottobox;
        private System.Windows.Forms.ComboBox fungrottobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox normalgrottogroupbox;
        private System.Windows.Forms.ComboBox fungrottogroupbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox normalgrottoavailable;
        private System.Windows.Forms.CheckBox fungrottoavailable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ComboBox swarmbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lastgrottobox;
        private System.Windows.Forms.Button lastvisitedhelp;
        private System.Windows.Forms.Button fungrottohelp;
        private System.Windows.Forms.NumericUpDown unknowngrottobox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gender5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gender10;
        private System.Windows.Forms.TextBox gender30;
        private System.Windows.Forms.TextBox gender60;
        private System.Windows.Forms.Button forceMale_but;
        private System.Windows.Forms.Button forceFemale_but;
        private System.Windows.Forms.Button note_but;
        private System.Windows.Forms.Button grotto_help;
        private System.Windows.Forms.Button table_but;
        private System.Windows.Forms.Button exit_but;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grotto));
            Grotto_route = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            normalgrottobox = new ComboBox();
            fungrottobox = new ComboBox();
            label4 = new Label();
            normalgrottogroupbox = new ComboBox();
            fungrottogroupbox = new ComboBox();
            label5 = new Label();
            normalgrottoavailable = new CheckBox();
            fungrottoavailable = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            fungrottohelp = new Button();
            note_but = new Button();
            save_button = new Button();
            swarmbox = new ComboBox();
            groupBox3 = new GroupBox();
            grotto_help = new Button();
            table_but = new Button();
            forceMale_but = new Button();
            groupBox5 = new GroupBox();
            label9 = new Label();
            label6 = new Label();
            label8 = new Label();
            gender5 = new TextBox();
            label7 = new Label();
            gender10 = new TextBox();
            gender60 = new TextBox();
            gender30 = new TextBox();
            forceFemale_but = new Button();
            lastvisitedhelp = new Button();
            label1 = new Label();
            lastgrottobox = new ComboBox();
            unknowngrottobox = new NumericUpDown();
            groupBox4 = new GroupBox();
            exit_but = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)unknowngrottobox).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // Grotto_route
            // 
            Grotto_route.FormattingEnabled = true;
            Grotto_route.Items.AddRange(new object[] { "算木牧场 (10-15)", "５号道路 (20-25)", "迷幻森林 (20-25)", "６号道路 [野外] (25-30)", "６号道路 [洞穴] (25-30)", "７号道路 (30-35)", "１３号道路 [楼梯左侧] (35-40)", "１３号道路 [楼梯下侧] (35-40)", "９号道路 (35-40)", "巨人洞窟 (45-50)", "２２号道路 (40-45)", "２３号道路 (50-55)", "丰饶之祠 [野外] (35-40)", "丰饶之祠 [冲浪] (35-40)", "矢车森林 [内部] (55-60)", "矢车森林 [外部] (55-60)", "３号道路 [培育屋] (55-60)", "３号道路 [冲浪] (55-60)", "２号道路 (55-60)", "１８号道路 (55-60)" });
            Grotto_route.Location = new Point(31, 35);
            Grotto_route.Margin = new Padding(4, 4, 4, 4);
            Grotto_route.Name = "Grotto_route";
            Grotto_route.Size = new Size(261, 23);
            Grotto_route.TabIndex = 6;
            Grotto_route.SelectedIndexChanged += Grotto_routeSelectedIndexChanged;
            // 
            // label2
            // 
            label2.Location = new Point(91, 21);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 26);
            label2.TabIndex = 8;
            label2.Text = "槽位";
            // 
            // label3
            // 
            label3.Location = new Point(91, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 26);
            label3.TabIndex = 9;
            label3.Text = "槽位";
            // 
            // normalgrottobox
            // 
            normalgrottobox.FormattingEnabled = true;
            normalgrottobox.Items.AddRange(new object[] { "宝可梦 1", "宝可梦 2", "宝可梦 3", "道具 1", "道具 2", "道具 3", "道具 4", "隐藏道具 1", "隐藏道具 2", "隐藏道具 3", "隐藏道具 4", "未知/未使用/漏洞 1", "未知/未使用/漏洞 2", "未知/未使用/漏洞 3", "未知/未使用/漏洞 4", "未知/未使用/漏洞 5" });
            normalgrottobox.Location = new Point(91, 39);
            normalgrottobox.Margin = new Padding(4, 4, 4, 4);
            normalgrottobox.Name = "normalgrottobox";
            normalgrottobox.Size = new Size(160, 23);
            normalgrottobox.TabIndex = 10;
            // 
            // fungrottobox
            // 
            fungrottobox.FormattingEnabled = true;
            fungrottobox.Items.AddRange(new object[] { "宝可梦 1", "宝可梦 2", "宝可梦 3 - A组 雌性 5% ^^^^", "道具 1", "道具 2 - A组 雌性 10% ^^^^", "道具 3", "道具 4", "隐藏道具 1", "隐藏道具 2", "隐藏道具 3", "隐藏道具 4", "未知/未使用/漏洞 1", "未知/未使用/漏洞 2", "未知 - B组 雌性 60% ^^^^", "未知 - A组 雌性 30% ^^^^", "未知/未使用/漏洞 5" });
            fungrottobox.Location = new Point(91, 38);
            fungrottobox.Margin = new Padding(4, 4, 4, 4);
            fungrottobox.Name = "fungrottobox";
            fungrottobox.Size = new Size(271, 23);
            fungrottobox.TabIndex = 11;
            fungrottobox.SelectedIndexChanged += FungrottoboxSelectedIndexChanged;
            // 
            // label4
            // 
            label4.Location = new Point(19, 21);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 26);
            label4.TabIndex = 12;
            label4.Text = "组";
            // 
            // normalgrottogroupbox
            // 
            normalgrottogroupbox.FormattingEnabled = true;
            normalgrottogroupbox.Items.AddRange(new object[] { "A", "B", "C", "D" });
            normalgrottogroupbox.Location = new Point(19, 39);
            normalgrottogroupbox.Margin = new Padding(4, 4, 4, 4);
            normalgrottogroupbox.Name = "normalgrottogroupbox";
            normalgrottogroupbox.Size = new Size(63, 23);
            normalgrottogroupbox.TabIndex = 13;
            // 
            // fungrottogroupbox
            // 
            fungrottogroupbox.FormattingEnabled = true;
            fungrottogroupbox.Items.AddRange(new object[] { "A", "B", "C", "D" });
            fungrottogroupbox.Location = new Point(19, 38);
            fungrottogroupbox.Margin = new Padding(4, 4, 4, 4);
            fungrottogroupbox.Name = "fungrottogroupbox";
            fungrottogroupbox.Size = new Size(63, 23);
            fungrottogroupbox.TabIndex = 15;
            fungrottogroupbox.SelectedIndexChanged += FungrottogroupboxSelectedIndexChanged;
            // 
            // label5
            // 
            label5.Location = new Point(19, 20);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 26);
            label5.TabIndex = 14;
            label5.Text = "组";
            // 
            // normalgrottoavailable
            // 
            normalgrottoavailable.Location = new Point(91, 70);
            normalgrottoavailable.Margin = new Padding(4, 4, 4, 4);
            normalgrottoavailable.Name = "normalgrottoavailable";
            normalgrottoavailable.Size = new Size(139, 28);
            normalgrottoavailable.TabIndex = 16;
            normalgrottoavailable.Text = "可用";
            normalgrottoavailable.UseVisualStyleBackColor = true;
            // 
            // fungrottoavailable
            // 
            fungrottoavailable.Location = new Point(91, 69);
            fungrottoavailable.Margin = new Padding(4, 4, 4, 4);
            fungrottoavailable.Name = "fungrottoavailable";
            fungrottoavailable.Size = new Size(139, 28);
            fungrottoavailable.TabIndex = 17;
            fungrottoavailable.Text = "可用";
            fungrottoavailable.UseVisualStyleBackColor = true;
            fungrottoavailable.CheckedChanged += FungrottoavailableCheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(normalgrottoavailable);
            groupBox1.Controls.Add(normalgrottogroupbox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(normalgrottobox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(31, 76);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(260, 112);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "普通洞穴";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(fungrottohelp);
            groupBox2.Controls.Add(fungrottoavailable);
            groupBox2.Controls.Add(fungrottogroupbox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(fungrottobox);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(299, 77);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(371, 112);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "庆典任务洞穴?";
            // 
            // fungrottohelp
            // 
            fungrottohelp.Location = new Point(341, 0);
            fungrottohelp.Margin = new Padding(4, 4, 4, 4);
            fungrottohelp.Name = "fungrottohelp";
            fungrottohelp.Size = new Size(29, 26);
            fungrottohelp.TabIndex = 23;
            fungrottohelp.Text = "?";
            fungrottohelp.UseVisualStyleBackColor = true;
            fungrottohelp.Click += FungrottohelpClick;
            // 
            // note_but
            // 
            note_but.Location = new Point(31, 196);
            note_but.Margin = new Padding(4, 4, 4, 4);
            note_but.Name = "note_but";
            note_but.Size = new Size(100, 26);
            note_but.TabIndex = 24;
            note_but.Text = "注";
            note_but.UseVisualStyleBackColor = true;
            note_but.Click += Note_butClick;
            // 
            // save_button
            // 
            save_button.Location = new Point(716, 275);
            save_button.Margin = new Padding(4, 4, 4, 4);
            save_button.Name = "save_button";
            save_button.Size = new Size(216, 26);
            save_button.TabIndex = 20;
            save_button.Text = "保存并退出";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += Save_buttonClick;
            // 
            // swarmbox
            // 
            swarmbox.FormattingEnabled = true;
            swarmbox.Items.AddRange(new object[] { "１号道路", "梦的遗址", "６号道路", "３号道路", "９号道路", "荒野名胜区", "５号道路", "７号道路", "１２号道路", "８号道路", "１１号道路", "１３号道路", "丰饶之祠", "１５号道路", "１６号道路", "１８号道路", "反转山", "２０号道路", "２２号道路" });
            swarmbox.Location = new Point(8, 35);
            swarmbox.Margin = new Padding(4, 4, 4, 4);
            swarmbox.Name = "swarmbox";
            swarmbox.Size = new Size(213, 23);
            swarmbox.TabIndex = 22;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grotto_help);
            groupBox3.Controls.Add(table_but);
            groupBox3.Controls.Add(note_but);
            groupBox3.Controls.Add(forceMale_but);
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(forceFemale_but);
            groupBox3.Controls.Add(lastvisitedhelp);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(lastgrottobox);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(Grotto_route);
            groupBox3.Location = new Point(17, 8);
            groupBox3.Margin = new Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(677, 292);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "隐藏洞穴";
            // 
            // grotto_help
            // 
            grotto_help.Location = new Point(409, 35);
            grotto_help.Margin = new Padding(4, 4, 4, 4);
            grotto_help.Name = "grotto_help";
            grotto_help.Size = new Size(24, 26);
            grotto_help.TabIndex = 25;
            grotto_help.Text = "?";
            grotto_help.UseVisualStyleBackColor = true;
            grotto_help.Click += Grotto_helpClick;
            // 
            // table_but
            // 
            table_but.Enabled = false;
            table_but.Location = new Point(301, 35);
            table_but.Margin = new Padding(4, 4, 4, 4);
            table_but.Name = "table_but";
            table_but.Size = new Size(100, 26);
            table_but.TabIndex = 25;
            table_but.Text = "洞穴情况表";
            table_but.UseVisualStyleBackColor = true;
            table_but.Click += Black2table_butClick;
            // 
            // forceMale_but
            // 
            forceMale_but.Location = new Point(487, 50);
            forceMale_but.Margin = new Padding(4, 4, 4, 4);
            forceMale_but.Name = "forceMale_but";
            forceMale_but.Size = new Size(137, 26);
            forceMale_but.TabIndex = 26;
            forceMale_but.Text = "强制雄性";
            forceMale_but.UseVisualStyleBackColor = true;
            forceMale_but.Click += ForceMale_butClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(gender5);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(gender10);
            groupBox5.Controls.Add(gender60);
            groupBox5.Controls.Add(gender30);
            groupBox5.Location = new Point(491, 196);
            groupBox5.Margin = new Padding(4, 4, 4, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 4, 4, 4);
            groupBox5.Size = new Size(179, 88);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "性别";
            // 
            // label9
            // 
            label9.Location = new Point(84, 52);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(36, 26);
            label9.TabIndex = 31;
            label9.Text = "60%";
            // 
            // label6
            // 
            label6.Location = new Point(8, 25);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 26);
            label6.TabIndex = 28;
            label6.Text = "5%";
            // 
            // label8
            // 
            label8.Location = new Point(3, 52);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 26);
            label8.TabIndex = 30;
            label8.Text = "30%";
            // 
            // gender5
            // 
            gender5.Enabled = false;
            gender5.Location = new Point(47, 25);
            gender5.Margin = new Padding(4, 4, 4, 4);
            gender5.Name = "gender5";
            gender5.Size = new Size(28, 25);
            gender5.TabIndex = 24;
            // 
            // label7
            // 
            label7.Location = new Point(87, 22);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 26);
            label7.TabIndex = 29;
            label7.Text = "10%";
            // 
            // gender10
            // 
            gender10.Enabled = false;
            gender10.Location = new Point(128, 22);
            gender10.Margin = new Padding(4, 4, 4, 4);
            gender10.Name = "gender10";
            gender10.Size = new Size(28, 25);
            gender10.TabIndex = 25;
            // 
            // gender60
            // 
            gender60.Enabled = false;
            gender60.Location = new Point(128, 52);
            gender60.Margin = new Padding(4, 4, 4, 4);
            gender60.Name = "gender60";
            gender60.Size = new Size(28, 25);
            gender60.TabIndex = 27;
            // 
            // gender30
            // 
            gender30.Enabled = false;
            gender30.Location = new Point(47, 52);
            gender30.Margin = new Padding(4, 4, 4, 4);
            gender30.Name = "gender30";
            gender30.Size = new Size(28, 25);
            gender30.TabIndex = 26;
            // 
            // forceFemale_but
            // 
            forceFemale_but.Location = new Point(487, 16);
            forceFemale_but.Margin = new Padding(4, 4, 4, 4);
            forceFemale_but.Name = "forceFemale_but";
            forceFemale_but.Size = new Size(137, 26);
            forceFemale_but.TabIndex = 25;
            forceFemale_but.Text = "强制雌性";
            forceFemale_but.UseVisualStyleBackColor = true;
            forceFemale_but.Click += ForceFemale_butClick;
            // 
            // lastvisitedhelp
            // 
            lastvisitedhelp.Location = new Point(431, 232);
            lastvisitedhelp.Margin = new Padding(4, 4, 4, 4);
            lastvisitedhelp.Name = "lastvisitedhelp";
            lastvisitedhelp.Size = new Size(29, 26);
            lastvisitedhelp.TabIndex = 22;
            lastvisitedhelp.Text = "?";
            lastvisitedhelp.UseVisualStyleBackColor = true;
            lastvisitedhelp.Click += LastvisitedhelpClick;
            // 
            // label1
            // 
            label1.Location = new Point(27, 235);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 40);
            label1.TabIndex = 21;
            label1.Text = "上一次拜访的隐藏洞穴";
            // 
            // lastgrottobox
            // 
            lastgrottobox.FormattingEnabled = true;
            lastgrottobox.Items.AddRange(new object[] { "算木牧场 (10-15)", "５号道路 (20-25)", "迷幻森林 (20-25)", "６号道路 [野外] (25-30)", "６号道路 [洞穴] (25-30)", "７号道路 (30-35)", "１３号道路 [楼梯左侧] (35-40)", "１３号道路 [楼梯下侧] (35-40)", "９号道路 (35-40)", "巨人洞窟 (45-50)", "２２号道路 (40-45)", "２３号道路 (50-55)", "丰饶之祠 [野外] (35-40)", "丰饶之祠 [冲浪] (35-40)", "矢车森林 [内部] (55-60)", "矢车森林 [外部] (55-60)", "３号道路 [培育屋] (55-60)", "３号道路 [冲浪] (55-60)", "２号道路 (55-60)", "１８号道路 (55-60)" });
            lastgrottobox.Location = new Point(160, 232);
            lastgrottobox.Margin = new Padding(4, 4, 4, 4);
            lastgrottobox.Name = "lastgrottobox";
            lastgrottobox.Size = new Size(261, 23);
            lastgrottobox.TabIndex = 20;
            // 
            // unknowngrottobox
            // 
            unknowngrottobox.Location = new Point(717, 103);
            unknowngrottobox.Margin = new Padding(4, 4, 4, 4);
            unknowngrottobox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            unknowngrottobox.Name = "unknowngrottobox";
            unknowngrottobox.Size = new Size(69, 25);
            unknowngrottobox.TabIndex = 23;
            unknowngrottobox.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(swarmbox);
            groupBox4.Location = new Point(709, 8);
            groupBox4.Margin = new Padding(4, 4, 4, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 4, 4, 4);
            groupBox4.Size = new Size(233, 75);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "当前大量出现";
            // 
            // exit_but
            // 
            exit_but.Location = new Point(716, 244);
            exit_but.Margin = new Padding(4, 4, 4, 4);
            exit_but.Name = "exit_but";
            exit_but.Size = new Size(216, 26);
            exit_but.TabIndex = 25;
            exit_but.Text = "退出";
            exit_but.UseVisualStyleBackColor = true;
            exit_but.Click += Exit_butClick;
            // 
            // Grotto
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 311);
            Controls.Add(exit_but);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(save_button);
            Controls.Add(unknowngrottobox);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "Grotto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BW2 隐藏洞穴和大量出现工具 0.1 by suloku";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)unknowngrottobox).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
