/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 01/03/2016
 * Time: 20:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
    partial class BWToolMainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button loadsave_but;
        private System.Windows.Forms.TextBox savegamename;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.Label versiontext;
        private System.Windows.Forms.Button dumper_but;
        private System.Windows.Forms.Button chk_but;
        private System.Windows.Forms.Button chk_updt_but;
        private System.Windows.Forms.Button grotto_but;
        private System.Windows.Forms.Button trainer_records_but;
        private System.Windows.Forms.Button medal_but;
        private System.Windows.Forms.Button forest_but;
        private System.Windows.Forms.Button key_but;
        private System.Windows.Forms.Button join_but;
        private System.Windows.Forms.Button trainer_but;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button memory_but;
        private System.Windows.Forms.Button dlc_but;
        private System.Windows.Forms.Button dr_but;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BWToolMainForm));
            loadsave_but = new Button();
            savegamename = new TextBox();
            save_but = new Button();
            versiontext = new Label();
            dumper_but = new Button();
            chk_but = new Button();
            chk_updt_but = new Button();
            grotto_but = new Button();
            trainer_records_but = new Button();
            medal_but = new Button();
            forest_but = new Button();
            key_but = new Button();
            join_but = new Button();
            trainer_but = new Button();
            about = new Button();
            memory_but = new Button();
            dlc_but = new Button();
            dr_but = new Button();
            prop_but = new Button();
            SuspendLayout();
            // 
            // loadsave_but
            // 
            loadsave_but.Location = new Point(16, 14);
            loadsave_but.Margin = new Padding(4);
            loadsave_but.Name = "loadsave_but";
            loadsave_but.Size = new Size(176, 26);
            loadsave_but.TabIndex = 0;
            loadsave_but.Text = "读取存档";
            loadsave_but.UseVisualStyleBackColor = true;
            loadsave_but.Click += Loadsave_butClick;
            // 
            // savegamename
            // 
            savegamename.Location = new Point(16, 47);
            savegamename.Margin = new Padding(4);
            savegamename.Name = "savegamename";
            savegamename.Size = new Size(644, 25);
            savegamename.TabIndex = 1;
            // 
            // save_but
            // 
            save_but.Enabled = false;
            save_but.Location = new Point(561, 77);
            save_but.Margin = new Padding(4);
            save_but.Name = "save_but";
            save_but.Size = new Size(100, 26);
            save_but.TabIndex = 2;
            save_but.Text = "保存";
            save_but.UseVisualStyleBackColor = true;
            save_but.Click += Save_butClick;
            // 
            // versiontext
            // 
            versiontext.Location = new Point(200, 20);
            versiontext.Margin = new Padding(4, 0, 4, 0);
            versiontext.Name = "versiontext";
            versiontext.Size = new Size(133, 21);
            versiontext.TabIndex = 3;
            // 
            // dumper_but
            // 
            dumper_but.Enabled = false;
            dumper_but.Location = new Point(431, 77);
            dumper_but.Margin = new Padding(4);
            dumper_but.Name = "dumper_but";
            dumper_but.Size = new Size(123, 26);
            dumper_but.TabIndex = 4;
            dumper_but.Text = "存档块导出";
            dumper_but.UseVisualStyleBackColor = true;
            dumper_but.Click += Dumper_butClick;
            // 
            // chk_but
            // 
            chk_but.Enabled = false;
            chk_but.Location = new Point(365, 14);
            chk_but.Margin = new Padding(4);
            chk_but.Name = "chk_but";
            chk_but.Size = new Size(132, 26);
            chk_but.TabIndex = 5;
            chk_but.Text = "确认校验值";
            chk_but.UseVisualStyleBackColor = true;
            chk_but.Click += Chk_butClick;
            // 
            // chk_updt_but
            // 
            chk_updt_but.Enabled = false;
            chk_updt_but.Location = new Point(505, 14);
            chk_updt_but.Margin = new Padding(4);
            chk_updt_but.Name = "chk_updt_but";
            chk_updt_but.Size = new Size(156, 26);
            chk_updt_but.TabIndex = 6;
            chk_updt_but.Text = "更新校验值";
            chk_updt_but.UseVisualStyleBackColor = true;
            chk_updt_but.Click += Chk_updt_butClick;
            // 
            // grotto_but
            // 
            grotto_but.Enabled = false;
            grotto_but.Location = new Point(16, 90);
            grotto_but.Margin = new Padding(4);
            grotto_but.Name = "grotto_but";
            grotto_but.Size = new Size(187, 26);
            grotto_but.TabIndex = 7;
            grotto_but.Text = "隐藏洞穴和大量出现";
            grotto_but.UseVisualStyleBackColor = true;
            grotto_but.Click += Grotto_butClick;
            // 
            // trainer_records_but
            // 
            trainer_records_but.Enabled = false;
            trainer_records_but.Location = new Point(405, 124);
            trainer_records_but.Margin = new Padding(4);
            trainer_records_but.Name = "trainer_records_but";
            trainer_records_but.Size = new Size(187, 26);
            trainer_records_but.TabIndex = 8;
            trainer_records_but.Text = "训练家记录";
            trainer_records_but.UseVisualStyleBackColor = true;
            trainer_records_but.Visible = false;
            trainer_records_but.Click += Trainer_records_butClick;
            // 
            // medal_but
            // 
            medal_but.Enabled = false;
            medal_but.Location = new Point(16, 190);
            medal_but.Margin = new Padding(4);
            medal_but.Name = "medal_but";
            medal_but.Size = new Size(187, 26);
            medal_but.TabIndex = 9;
            medal_but.Text = "奖牌";
            medal_but.UseVisualStyleBackColor = true;
            medal_but.Click += Medal_butClick;
            // 
            // forest_but
            // 
            forest_but.Enabled = false;
            forest_but.Location = new Point(211, 90);
            forest_but.Margin = new Padding(4);
            forest_but.Name = "forest_but";
            forest_but.Size = new Size(187, 26);
            forest_but.TabIndex = 10;
            forest_but.Text = "连入之森";
            forest_but.UseVisualStyleBackColor = true;
            forest_but.Click += Forest_butClick;
            // 
            // key_but
            // 
            key_but.Enabled = false;
            key_but.Location = new Point(211, 157);
            key_but.Margin = new Padding(4);
            key_but.Name = "key_but";
            key_but.Size = new Size(187, 26);
            key_but.TabIndex = 11;
            key_but.Text = "钥匙系统";
            key_but.UseVisualStyleBackColor = true;
            key_but.Click += Key_butClick;
            // 
            // join_but
            // 
            join_but.Enabled = false;
            join_but.Location = new Point(16, 157);
            join_but.Margin = new Padding(4);
            join_but.Name = "join_but";
            join_but.Size = new Size(187, 26);
            join_but.TabIndex = 12;
            join_but.Text = "汇合大道";
            join_but.UseVisualStyleBackColor = true;
            join_but.Click += Join_butClick;
            // 
            // trainer_but
            // 
            trainer_but.Enabled = false;
            trainer_but.Location = new Point(211, 124);
            trainer_but.Margin = new Padding(4);
            trainer_but.Name = "trainer_but";
            trainer_but.Size = new Size(187, 26);
            trainer_but.TabIndex = 13;
            trainer_but.Text = "训练家信息";
            trainer_but.UseVisualStyleBackColor = true;
            trainer_but.Click += Trainer_butClick;
            // 
            // about
            // 
            about.Location = new Point(639, 191);
            about.Margin = new Padding(4);
            about.Name = "about";
            about.Size = new Size(23, 26);
            about.TabIndex = 14;
            about.Text = "?";
            about.UseVisualStyleBackColor = true;
            about.Click += AboutClick;
            // 
            // memory_but
            // 
            memory_but.Enabled = false;
            memory_but.Location = new Point(211, 190);
            memory_but.Margin = new Padding(4);
            memory_but.Name = "memory_but";
            memory_but.Size = new Size(187, 26);
            memory_but.TabIndex = 15;
            memory_but.Text = "记忆连接";
            memory_but.UseVisualStyleBackColor = true;
            memory_but.Click += Memory_butClick;
            // 
            // dlc_but
            // 
            dlc_but.Location = new Point(211, 224);
            dlc_but.Margin = new Padding(4);
            dlc_but.Name = "dlc_but";
            dlc_but.Size = new Size(187, 26);
            dlc_but.TabIndex = 16;
            dlc_but.Text = "DLC";
            dlc_but.UseVisualStyleBackColor = true;
            dlc_but.Click += Dlc_butClick;
            // 
            // dr_but
            // 
            dr_but.Enabled = false;
            dr_but.Location = new Point(16, 224);
            dr_but.Margin = new Padding(4);
            dr_but.Name = "dr_but";
            dr_but.Size = new Size(187, 26);
            dr_but.TabIndex = 17;
            dr_but.Text = "3DS连接(AR搜寻器)";
            dr_but.UseVisualStyleBackColor = true;
            dr_but.Click += Dr_butClick;
            // 
            // prop_but
            // 
            prop_but.Enabled = false;
            prop_but.Location = new Point(16, 124);
            prop_but.Margin = new Padding(4);
            prop_but.Name = "prop_but";
            prop_but.Size = new Size(187, 26);
            prop_but.TabIndex = 18;
            prop_but.Text = "物品箱";
            prop_but.UseVisualStyleBackColor = true;
            prop_but.Click += Prop_butClick;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 276);
            Controls.Add(prop_but);
            Controls.Add(dr_but);
            Controls.Add(dlc_but);
            Controls.Add(memory_but);
            Controls.Add(about);
            Controls.Add(trainer_but);
            Controls.Add(join_but);
            Controls.Add(key_but);
            Controls.Add(forest_but);
            Controls.Add(medal_but);
            Controls.Add(trainer_records_but);
            Controls.Add(grotto_but);
            Controls.Add(chk_updt_but);
            Controls.Add(chk_but);
            Controls.Add(dumper_but);
            Controls.Add(versiontext);
            Controls.Add(save_but);
            Controls.Add(savegamename);
            Controls.Add(loadsave_but);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BWTool";
          
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button prop_but;
    }
}
