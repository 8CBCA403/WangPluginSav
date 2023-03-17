/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 08/03/2016
 * Time: 13:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
    partial class KeySystem
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox icebergkeybox;
        private System.Windows.Forms.CheckBox easykeybox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ironkeybox;
        private System.Windows.Forms.CheckBox challengekeybox;
        private System.Windows.Forms.CheckBox citykeybox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox challengemodebox;
        private System.Windows.Forms.CheckBox easymodebox;
        private System.Windows.Forms.CheckBox icebergbox;
        private System.Windows.Forms.CheckBox ironbox;
        private System.Windows.Forms.CheckBox citybox;
        private System.Windows.Forms.RadioButton cfg_chamber_ice;
        private System.Windows.Forms.RadioButton cfg_chamber_iron;
        private System.Windows.Forms.RadioButton cfg_chamber_rock;
        private System.Windows.Forms.RadioButton cfg_chamber_def;
        private System.Windows.Forms.RadioButton cfg_city_foreing;
        private System.Windows.Forms.RadioButton cfg_city_game;
        private System.Windows.Forms.RadioButton cfg_city_def;
        private System.Windows.Forms.RadioButton cfg_mode_3;
        private System.Windows.Forms.RadioButton cfg_mode_2;
        private System.Windows.Forms.RadioButton cfg_mode_1;
        private System.Windows.Forms.RadioButton cfg_mode_def;
        private System.Windows.Forms.Button Saveexit_but;
        private System.Windows.Forms.Button Exit_but;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeySystem));
            groupBox1 = new GroupBox();
            icebergkeybox = new CheckBox();
            easykeybox = new CheckBox();
            groupBox2 = new GroupBox();
            ironkeybox = new CheckBox();
            challengekeybox = new CheckBox();
            citykeybox = new CheckBox();
            groupBox3 = new GroupBox();
            icebergbox = new CheckBox();
            ironbox = new CheckBox();
            citybox = new CheckBox();
            challengemodebox = new CheckBox();
            easymodebox = new CheckBox();
            Saveexit_but = new Button();
            Exit_but = new Button();
            cfg_mode_def = new RadioButton();
            cfg_mode_1 = new RadioButton();
            cfg_mode_2 = new RadioButton();
            cfg_mode_3 = new RadioButton();
            cfg_city_def = new RadioButton();
            cfg_city_game = new RadioButton();
            cfg_city_foreing = new RadioButton();
            cfg_chamber_def = new RadioButton();
            cfg_chamber_rock = new RadioButton();
            cfg_chamber_iron = new RadioButton();
            cfg_chamber_ice = new RadioButton();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(icebergkeybox);
            groupBox1.Controls.Add(easykeybox);
            groupBox1.Location = new Point(31, 14);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(280, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "白2钥匙";
            // 
            // icebergkeybox
            // 
            icebergkeybox.Location = new Point(8, 50);
            icebergkeybox.Margin = new Padding(4, 4, 4, 4);
            icebergkeybox.Name = "icebergkeybox";
            icebergkeybox.Size = new Size(188, 28);
            icebergkeybox.TabIndex = 1;
            icebergkeybox.Text = "冰山钥匙";
            icebergkeybox.UseVisualStyleBackColor = true;
            // 
            // easykeybox
            // 
            easykeybox.Location = new Point(8, 22);
            easykeybox.Margin = new Padding(4, 4, 4, 4);
            easykeybox.Name = "easykeybox";
            easykeybox.Size = new Size(139, 28);
            easykeybox.TabIndex = 0;
            easykeybox.Text = "助手钥匙";
            easykeybox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ironkeybox);
            groupBox2.Controls.Add(challengekeybox);
            groupBox2.Location = new Point(319, 14);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(280, 88);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "黑2钥匙";
            // 
            // ironkeybox
            // 
            ironkeybox.Location = new Point(8, 50);
            ironkeybox.Margin = new Padding(4, 4, 4, 4);
            ironkeybox.Name = "ironkeybox";
            ironkeybox.Size = new Size(188, 28);
            ironkeybox.TabIndex = 2;
            ironkeybox.Text = "黑金钥匙";
            ironkeybox.UseVisualStyleBackColor = true;
            // 
            // challengekeybox
            // 
            challengekeybox.Location = new Point(8, 22);
            challengekeybox.Margin = new Padding(4, 4, 4, 4);
            challengekeybox.Name = "challengekeybox";
            challengekeybox.Size = new Size(139, 28);
            challengekeybox.TabIndex = 1;
            challengekeybox.Text = "挑战钥匙";
            challengekeybox.UseVisualStyleBackColor = true;
            // 
            // citykeybox
            // 
            citykeybox.Location = new Point(219, 110);
            citykeybox.Margin = new Padding(4, 4, 4, 4);
            citykeybox.Name = "citykeybox";
            citykeybox.Size = new Size(184, 28);
            citykeybox.TabIndex = 2;
            citykeybox.Text = "摩天楼钥匙/树洞钥匙";
            citykeybox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(icebergbox);
            groupBox3.Controls.Add(ironbox);
            groupBox3.Controls.Add(citybox);
            groupBox3.Controls.Add(challengemodebox);
            groupBox3.Controls.Add(easymodebox);
            groupBox3.Location = new Point(39, 144);
            groupBox3.Margin = new Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(564, 92);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "已解锁";
            // 
            // icebergbox
            // 
            icebergbox.Location = new Point(388, 49);
            icebergbox.Margin = new Padding(4, 4, 4, 4);
            icebergbox.Name = "icebergbox";
            icebergbox.Size = new Size(153, 28);
            icebergbox.TabIndex = 6;
            icebergbox.Text = "冰山之间";
            icebergbox.UseVisualStyleBackColor = true;
            // 
            // ironbox
            // 
            ironbox.Location = new Point(388, 22);
            ironbox.Margin = new Padding(4, 4, 4, 4);
            ironbox.Name = "ironbox";
            ironbox.Size = new Size(139, 28);
            ironbox.TabIndex = 5;
            ironbox.Text = "黑金之间";
            ironbox.UseVisualStyleBackColor = true;
            // 
            // citybox
            // 
            citybox.Location = new Point(185, 22);
            citybox.Margin = new Padding(4, 4, 4, 4);
            citybox.Name = "citybox";
            citybox.Size = new Size(195, 28);
            citybox.TabIndex = 4;
            citybox.Text = "黑色市/白森林";
            citybox.UseVisualStyleBackColor = true;
            // 
            // challengemodebox
            // 
            challengemodebox.Location = new Point(8, 49);
            challengemodebox.Margin = new Padding(4, 4, 4, 4);
            challengemodebox.Name = "challengemodebox";
            challengemodebox.Size = new Size(139, 28);
            challengemodebox.TabIndex = 3;
            challengemodebox.Text = "挑战模式";
            challengemodebox.UseVisualStyleBackColor = true;
            // 
            // easymodebox
            // 
            easymodebox.Location = new Point(8, 22);
            easymodebox.Margin = new Padding(4, 4, 4, 4);
            easymodebox.Name = "easymodebox";
            easymodebox.Size = new Size(139, 28);
            easymodebox.TabIndex = 2;
            easymodebox.Text = "助手模式";
            easymodebox.UseVisualStyleBackColor = true;
            // 
            // Saveexit_but
            // 
            Saveexit_but.Location = new Point(467, 385);
            Saveexit_but.Margin = new Padding(4, 4, 4, 4);
            Saveexit_but.Name = "Saveexit_but";
            Saveexit_but.Size = new Size(136, 26);
            Saveexit_but.TabIndex = 5;
            Saveexit_but.Text = "保存并退出";
            Saveexit_but.UseVisualStyleBackColor = true;
            Saveexit_but.Click += Saveexit_butClick;
            // 
            // Exit_but
            // 
            Exit_but.Location = new Point(39, 385);
            Exit_but.Margin = new Padding(4, 4, 4, 4);
            Exit_but.Name = "Exit_but";
            Exit_but.Size = new Size(136, 26);
            Exit_but.TabIndex = 6;
            Exit_but.Text = "退出";
            Exit_but.UseVisualStyleBackColor = true;
            Exit_but.Click += Exit_butClick;
            // 
            // cfg_mode_def
            // 
            cfg_mode_def.Enabled = false;
            cfg_mode_def.Location = new Point(8, 19);
            cfg_mode_def.Margin = new Padding(4, 4, 4, 4);
            cfg_mode_def.Name = "cfg_mode_def";
            cfg_mode_def.Size = new Size(139, 28);
            cfg_mode_def.TabIndex = 0;
            cfg_mode_def.TabStop = true;
            cfg_mode_def.Text = "默认";
            cfg_mode_def.UseVisualStyleBackColor = true;
            // 
            // cfg_mode_1
            // 
            cfg_mode_1.Enabled = false;
            cfg_mode_1.Location = new Point(8, 46);
            cfg_mode_1.Margin = new Padding(4, 4, 4, 4);
            cfg_mode_1.Name = "cfg_mode_1";
            cfg_mode_1.Size = new Size(139, 28);
            cfg_mode_1.TabIndex = 1;
            cfg_mode_1.TabStop = true;
            cfg_mode_1.Text = "助手模式";
            cfg_mode_1.UseVisualStyleBackColor = true;
            // 
            // cfg_mode_2
            // 
            cfg_mode_2.Enabled = false;
            cfg_mode_2.Location = new Point(8, 73);
            cfg_mode_2.Margin = new Padding(4, 4, 4, 4);
            cfg_mode_2.Name = "cfg_mode_2";
            cfg_mode_2.Size = new Size(139, 28);
            cfg_mode_2.TabIndex = 2;
            cfg_mode_2.TabStop = true;
            cfg_mode_2.Text = "普通模式";
            cfg_mode_2.UseVisualStyleBackColor = true;
            // 
            // cfg_mode_3
            // 
            cfg_mode_3.Enabled = false;
            cfg_mode_3.Location = new Point(8, 99);
            cfg_mode_3.Margin = new Padding(4, 4, 4, 4);
            cfg_mode_3.Name = "cfg_mode_3";
            cfg_mode_3.Size = new Size(139, 28);
            cfg_mode_3.TabIndex = 3;
            cfg_mode_3.TabStop = true;
            cfg_mode_3.Text = "挑战模式";
            cfg_mode_3.UseVisualStyleBackColor = true;
            // 
            // cfg_city_def
            // 
            cfg_city_def.Enabled = false;
            cfg_city_def.Location = new Point(17, 20);
            cfg_city_def.Margin = new Padding(4, 4, 4, 4);
            cfg_city_def.Name = "cfg_city_def";
            cfg_city_def.Size = new Size(139, 26);
            cfg_city_def.TabIndex = 4;
            cfg_city_def.TabStop = true;
            cfg_city_def.Text = "默认";
            cfg_city_def.UseVisualStyleBackColor = true;
            // 
            // cfg_city_game
            // 
            cfg_city_game.Enabled = false;
            cfg_city_game.Location = new Point(17, 62);
            cfg_city_game.Margin = new Padding(4, 4, 4, 4);
            cfg_city_game.Name = "cfg_city_game";
            cfg_city_game.Size = new Size(139, 22);
            cfg_city_game.TabIndex = 5;
            cfg_city_game.TabStop = true;
            cfg_city_game.Text = "黑色市";
            cfg_city_game.UseVisualStyleBackColor = true;
            // 
            // cfg_city_foreing
            // 
            cfg_city_foreing.Enabled = false;
            cfg_city_foreing.Location = new Point(17, 100);
            cfg_city_foreing.Margin = new Padding(4, 4, 4, 4);
            cfg_city_foreing.Name = "cfg_city_foreing";
            cfg_city_foreing.Size = new Size(139, 25);
            cfg_city_foreing.TabIndex = 6;
            cfg_city_foreing.TabStop = true;
            cfg_city_foreing.Text = "白森林";
            cfg_city_foreing.UseVisualStyleBackColor = true;
            // 
            // cfg_chamber_def
            // 
            cfg_chamber_def.Enabled = false;
            cfg_chamber_def.Location = new Point(29, 19);
            cfg_chamber_def.Margin = new Padding(4, 4, 4, 4);
            cfg_chamber_def.Name = "cfg_chamber_def";
            cfg_chamber_def.Size = new Size(139, 28);
            cfg_chamber_def.TabIndex = 7;
            cfg_chamber_def.TabStop = true;
            cfg_chamber_def.Text = "默认";
            cfg_chamber_def.UseVisualStyleBackColor = true;
            // 
            // cfg_chamber_rock
            // 
            cfg_chamber_rock.Enabled = false;
            cfg_chamber_rock.Location = new Point(29, 45);
            cfg_chamber_rock.Margin = new Padding(4, 4, 4, 4);
            cfg_chamber_rock.Name = "cfg_chamber_rock";
            cfg_chamber_rock.Size = new Size(139, 28);
            cfg_chamber_rock.TabIndex = 8;
            cfg_chamber_rock.TabStop = true;
            cfg_chamber_rock.Text = "岩山之间";
            cfg_chamber_rock.UseVisualStyleBackColor = true;
            // 
            // cfg_chamber_iron
            // 
            cfg_chamber_iron.Enabled = false;
            cfg_chamber_iron.Location = new Point(29, 74);
            cfg_chamber_iron.Margin = new Padding(4, 4, 4, 4);
            cfg_chamber_iron.Name = "cfg_chamber_iron";
            cfg_chamber_iron.Size = new Size(139, 28);
            cfg_chamber_iron.TabIndex = 9;
            cfg_chamber_iron.TabStop = true;
            cfg_chamber_iron.Text = "黑金之间";
            cfg_chamber_iron.UseVisualStyleBackColor = true;
            // 
            // cfg_chamber_ice
            // 
            cfg_chamber_ice.Enabled = false;
            cfg_chamber_ice.Location = new Point(29, 101);
            cfg_chamber_ice.Margin = new Padding(4, 4, 4, 4);
            cfg_chamber_ice.Name = "cfg_chamber_ice";
            cfg_chamber_ice.Size = new Size(153, 28);
            cfg_chamber_ice.TabIndex = 10;
            cfg_chamber_ice.TabStop = true;
            cfg_chamber_ice.Text = "冰山之间";
            cfg_chamber_ice.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cfg_mode_3);
            groupBox4.Controls.Add(cfg_mode_2);
            groupBox4.Controls.Add(cfg_mode_def);
            groupBox4.Controls.Add(cfg_mode_1);
            groupBox4.Location = new Point(39, 246);
            groupBox4.Margin = new Padding(4, 4, 4, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 4, 4, 4);
            groupBox4.Size = new Size(155, 131);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "难度设置：";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cfg_city_foreing);
            groupBox5.Controls.Add(cfg_city_game);
            groupBox5.Controls.Add(cfg_city_def);
            groupBox5.Location = new Point(201, 246);
            groupBox5.Margin = new Padding(4, 4, 4, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 4, 4, 4);
            groupBox5.Size = new Size(181, 131);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "城市设置：";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cfg_chamber_iron);
            groupBox6.Controls.Add(cfg_chamber_rock);
            groupBox6.Controls.Add(cfg_chamber_def);
            groupBox6.Controls.Add(cfg_chamber_ice);
            groupBox6.Location = new Point(391, 246);
            groupBox6.Margin = new Padding(4, 4, 4, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 4, 4, 4);
            groupBox6.Size = new Size(212, 131);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            groupBox6.Text = "不可思议的门设置：";
            // 
            // KeySystem
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 426);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(Exit_but);
            Controls.Add(Saveexit_but);
            Controls.Add(groupBox3);
            Controls.Add(citykeybox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "KeySystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "钥匙系统";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
