using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
    partial class ECB_editor
    {
        private System.ComponentModel.IContainer components = null;
        private Button load_ecb_but;

        private Button save_ecb_but;

        private TextBox ecb_path;

        private Label label1;

        private TextBox name;

        private ComboBox firm_box;

        private Label label2;

        private NumericUpDown size;

        private Label label3;

        private Label label4;

        private Label label5;

        private NumericUpDown yield_max;

        private NumericUpDown yield_min;

        private Label label6;

        private NumericUpDown growth;

        private Label label7;

        private Label label8;

        private Label label9;

        private Label label10;

        private Label label11;

        private NumericUpDown spicy;

        private NumericUpDown dry;

        private NumericUpDown sweet;

        private NumericUpDown bitter;

        private NumericUpDown sour;

        private NumericUpDown smooth;

        private Label label12;

        private TextBox desc1;

        private TextBox desc2;

        private Label label13;

        private NumericUpDown held;

        private Button held_help;

        private Button sprite_export_but;

        private Button sprite_import_but;

        private Button palette_export_but;

        private Button palette_import_but;

        private Button sprite_help;

        private CheckBox jap_encoding;

        private CheckBox heal_inf;

        private CheckBox heal_sleep;

        private CheckBox heal_poison;

        private CheckBox heal_burn;

        private CheckBox heal_ice;

        private CheckBox heal_para;

        private CheckBox heal_confu;

        private CheckBox guard;

        private CheckBox lvlup;

        private CheckBox firstpoke;

        private Label label15;

        private Label label16;

        private Label label17;

        private Label label18;

        private Label label19;

        private Label label20;

        private NumericUpDown direhit;

        private NumericUpDown atkup;

        private NumericUpDown defup;

        private NumericUpDown speedup;

        private NumericUpDown spatkup;

        private NumericUpDown accurup;

        private CheckBox ev_hp;

        private CheckBox ev_atk;

        private CheckBox ev_def;

        private CheckBox ev_speed;

        private CheckBox ev_speatk;

        private CheckBox ev_spedef;

        private NumericUpDown tr6_val;

        private CheckBox heal_hp;

        private CheckBox heal_pp;

        private CheckBox selectedatk;

        private CheckBox maxppUP;

        private CheckBox revive;

        private CheckBox stone;

        private CheckBox happy200;

        private CheckBox happy100;

        private CheckBox happy0;

        private NumericUpDown hap200;

        private NumericUpDown hap100;

        private NumericUpDown happ0;

        private CheckBox ppup;

        private GroupBox groupBox1;

        private Label label14;

        private Button pphelp;

        private Button modifier_help;

        private Button note;

        private GroupBox groupBox6;

        private GroupBox groupBox5;

        private GroupBox groupBox4;

        private GroupBox groupBox3;

        private GroupBox groupBox2;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECB_editor));
            load_ecb_but = new Button();
            save_ecb_but = new Button();
            ecb_path = new TextBox();
            label1 = new Label();
            name = new TextBox();
            firm_box = new ComboBox();
            label2 = new Label();
            size = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            yield_max = new NumericUpDown();
            yield_min = new NumericUpDown();
            label6 = new Label();
            growth = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            spicy = new NumericUpDown();
            dry = new NumericUpDown();
            sweet = new NumericUpDown();
            bitter = new NumericUpDown();
            sour = new NumericUpDown();
            smooth = new NumericUpDown();
            label12 = new Label();
            desc1 = new TextBox();
            desc2 = new TextBox();
            label13 = new Label();
            held = new NumericUpDown();
            held_help = new Button();
            sprite_export_but = new Button();
            sprite_import_but = new Button();
            palette_export_but = new Button();
            palette_import_but = new Button();
            sprite_help = new Button();
            jap_encoding = new CheckBox();
            heal_inf = new CheckBox();
            heal_sleep = new CheckBox();
            heal_poison = new CheckBox();
            heal_burn = new CheckBox();
            heal_ice = new CheckBox();
            heal_para = new CheckBox();
            heal_confu = new CheckBox();
            guard = new CheckBox();
            lvlup = new CheckBox();
            firstpoke = new CheckBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            direhit = new NumericUpDown();
            atkup = new NumericUpDown();
            defup = new NumericUpDown();
            speedup = new NumericUpDown();
            spatkup = new NumericUpDown();
            accurup = new NumericUpDown();
            ev_hp = new CheckBox();
            ev_atk = new CheckBox();
            ev_def = new CheckBox();
            ev_speed = new CheckBox();
            ev_speatk = new CheckBox();
            ev_spedef = new CheckBox();
            tr6_val = new NumericUpDown();
            heal_hp = new CheckBox();
            heal_pp = new CheckBox();
            selectedatk = new CheckBox();
            maxppUP = new CheckBox();
            revive = new CheckBox();
            stone = new CheckBox();
            happy200 = new CheckBox();
            happy100 = new CheckBox();
            happy0 = new CheckBox();
            hap200 = new NumericUpDown();
            hap100 = new NumericUpDown();
            happ0 = new NumericUpDown();
            ppup = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            pphelp = new Button();
            groupBox5 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            note = new Button();
            modifier_help = new Button();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yield_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yield_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)growth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spicy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sweet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)smooth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)held).BeginInit();
            ((System.ComponentModel.ISupportInitialize)direhit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atkup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)defup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)speedup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spatkup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accurup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tr6_val).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hap200).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hap100).BeginInit();
            ((System.ComponentModel.ISupportInitialize)happ0).BeginInit();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // load_ecb_but
            // 
            load_ecb_but.Location = new Point(12, 13);
            load_ecb_but.Margin = new Padding(4);
            load_ecb_but.Name = "load_ecb_but";
            load_ecb_but.Size = new Size(176, 28);
            load_ecb_but.TabIndex = 0;
            load_ecb_but.Text = "读取e卡树果文件";
            load_ecb_but.UseVisualStyleBackColor = true;
            load_ecb_but.Click += Load_ecb_butClick;
            // 
            // save_ecb_but
            // 
            save_ecb_but.Enabled = false;
            save_ecb_but.Location = new Point(12, 49);
            save_ecb_but.Margin = new Padding(4);
            save_ecb_but.Name = "save_ecb_but";
            save_ecb_but.Size = new Size(176, 28);
            save_ecb_but.TabIndex = 1;
            save_ecb_but.Text = "保存e卡树果文件";
            save_ecb_but.UseVisualStyleBackColor = true;
            save_ecb_but.Click += Save_ecb_butClick;
            // 
            // ecb_path
            // 
            ecb_path.Location = new Point(196, 49);
            ecb_path.Margin = new Padding(4);
            ecb_path.Multiline = true;
            ecb_path.Name = "ecb_path";
            ecb_path.Size = new Size(674, 28);
            ecb_path.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(13, 117);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 3;
            label1.Text = "名字：";
            // 
            // name
            // 
            name.Location = new Point(121, 111);
            name.Margin = new Padding(4);
            name.MaxLength = 6;
            name.Name = "name";
            name.Size = new Size(335, 25);
            name.TabIndex = 4;
            // 
            // firm_box
            // 
            firm_box.FormattingEnabled = true;
            firm_box.Items.AddRange(new object[] { "很柔软", "柔软", "坚硬", "很坚硬", "非常坚硬" });
            firm_box.Location = new Point(121, 214);
            firm_box.Margin = new Padding(4);
            firm_box.Name = "firm_box";
            firm_box.Size = new Size(159, 23);
            firm_box.TabIndex = 5;
            // 
            // label2
            // 
            label2.Location = new Point(13, 218);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 6;
            label2.Text = "硬度：";
            // 
            // size
            // 
            size.Location = new Point(121, 246);
            size.Margin = new Padding(4);
            size.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            size.Name = "size";
            size.Size = new Size(160, 25);
            size.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(13, 249);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 22);
            label3.TabIndex = 8;
            label3.Text = "尺寸：";
            // 
            // label4
            // 
            label4.Location = new Point(13, 281);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 9;
            label4.Text = "最大产量：";
            // 
            // label5
            // 
            label5.Location = new Point(13, 314);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 28);
            label5.TabIndex = 10;
            label5.Text = "最小产量:";
            // 
            // yield_max
            // 
            yield_max.Location = new Point(121, 279);
            yield_max.Margin = new Padding(4);
            yield_max.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            yield_max.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            yield_max.Name = "yield_max";
            yield_max.Size = new Size(160, 25);
            yield_max.TabIndex = 11;
            yield_max.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // yield_min
            // 
            yield_min.Location = new Point(121, 311);
            yield_min.Margin = new Padding(4);
            yield_min.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            yield_min.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            yield_min.Name = "yield_min";
            yield_min.Size = new Size(160, 25);
            yield_min.TabIndex = 12;
            yield_min.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.Location = new Point(13, 342);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 43);
            label6.TabIndex = 13;
            label6.Text = "每阶段生长所需小时：";
            // 
            // growth
            // 
            growth.Location = new Point(121, 344);
            growth.Margin = new Padding(4);
            growth.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            growth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            growth.Name = "growth";
            growth.Size = new Size(160, 25);
            growth.TabIndex = 14;
            growth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.Location = new Point(289, 218);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 15;
            label7.Text = "辣：";
            // 
            // label8
            // 
            label8.Location = new Point(289, 249);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(133, 28);
            label8.TabIndex = 16;
            label8.Text = "涩：";
            // 
            // label9
            // 
            label9.Location = new Point(289, 281);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 28);
            label9.TabIndex = 17;
            label9.Text = "甜：";
            // 
            // label10
            // 
            label10.Location = new Point(289, 314);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(133, 28);
            label10.TabIndex = 18;
            label10.Text = "苦：";
            // 
            // label11
            // 
            label11.Location = new Point(289, 346);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(133, 28);
            label11.TabIndex = 19;
            label11.Text = "酸：";
            // 
            // spicy
            // 
            spicy.Location = new Point(381, 215);
            spicy.Margin = new Padding(4);
            spicy.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            spicy.Name = "spicy";
            spicy.Size = new Size(104, 25);
            spicy.TabIndex = 20;
            // 
            // dry
            // 
            dry.Location = new Point(381, 246);
            dry.Margin = new Padding(4);
            dry.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            dry.Name = "dry";
            dry.Size = new Size(104, 25);
            dry.TabIndex = 21;
            // 
            // sweet
            // 
            sweet.Location = new Point(381, 279);
            sweet.Margin = new Padding(4);
            sweet.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            sweet.Name = "sweet";
            sweet.Size = new Size(104, 25);
            sweet.TabIndex = 22;
            // 
            // bitter
            // 
            bitter.Location = new Point(381, 311);
            bitter.Margin = new Padding(4);
            bitter.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            bitter.Name = "bitter";
            bitter.Size = new Size(104, 25);
            bitter.TabIndex = 23;
            // 
            // sour
            // 
            sour.Location = new Point(381, 344);
            sour.Margin = new Padding(4);
            sour.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            sour.Name = "sour";
            sour.Size = new Size(104, 25);
            sour.TabIndex = 24;
            // 
            // smooth
            // 
            smooth.Location = new Point(381, 376);
            smooth.Margin = new Padding(4);
            smooth.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            smooth.Name = "smooth";
            smooth.Size = new Size(104, 25);
            smooth.TabIndex = 25;
            // 
            // label12
            // 
            label12.Location = new Point(289, 378);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(84, 28);
            label12.TabIndex = 26;
            label12.Text = "细腻度：";
            // 
            // desc1
            // 
            desc1.Location = new Point(53, 143);
            desc1.Margin = new Padding(4);
            desc1.MaxLength = 44;
            desc1.Name = "desc1";
            desc1.Size = new Size(403, 25);
            desc1.TabIndex = 27;
            // 
            // desc2
            // 
            desc2.Location = new Point(53, 175);
            desc2.Margin = new Padding(4);
            desc2.MaxLength = 44;
            desc2.Name = "desc2";
            desc2.Size = new Size(403, 25);
            desc2.TabIndex = 28;
            // 
            // label13
            // 
            label13.Location = new Point(12, 381);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(136, 22);
            label13.TabIndex = 29;
            label13.Text = "携带时使用";
            // 
            // held
            // 
            held.Location = new Point(156, 379);
            held.Margin = new Padding(4);
            held.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            held.Name = "held";
            held.Size = new Size(79, 25);
            held.TabIndex = 30;
            // 
            // held_help
            // 
            held_help.Location = new Point(243, 379);
            held_help.Margin = new Padding(4);
            held_help.Name = "held_help";
            held_help.Size = new Size(20, 25);
            held_help.TabIndex = 31;
            held_help.Text = "?";
            held_help.UseVisualStyleBackColor = true;
            held_help.Click += Held_helpClick;
            // 
            // sprite_export_but
            // 
            sprite_export_but.Enabled = false;
            sprite_export_but.Location = new Point(880, 49);
            sprite_export_but.Margin = new Padding(4);
            sprite_export_but.Name = "sprite_export_but";
            sprite_export_but.Size = new Size(114, 28);
            sprite_export_but.TabIndex = 33;
            sprite_export_but.Text = "导出sprite";
            sprite_export_but.UseVisualStyleBackColor = true;
            sprite_export_but.Click += Sprite_export_butClick;
            // 
            // sprite_import_but
            // 
            sprite_import_but.Enabled = false;
            sprite_import_but.Location = new Point(1002, 49);
            sprite_import_but.Margin = new Padding(4);
            sprite_import_but.Name = "sprite_import_but";
            sprite_import_but.Size = new Size(115, 28);
            sprite_import_but.TabIndex = 34;
            sprite_import_but.Text = "导入sprite";
            sprite_import_but.UseVisualStyleBackColor = true;
            sprite_import_but.Click += Sprite_import_butClick;
            // 
            // palette_export_but
            // 
            palette_export_but.Enabled = false;
            palette_export_but.Location = new Point(632, 13);
            palette_export_but.Margin = new Padding(4);
            palette_export_but.Name = "palette_export_but";
            palette_export_but.Size = new Size(115, 28);
            palette_export_but.TabIndex = 35;
            palette_export_but.Text = "导出调色盘";
            palette_export_but.UseVisualStyleBackColor = true;
            palette_export_but.Visible = false;
            palette_export_but.Click += Palette_export_butClick;
            // 
            // palette_import_but
            // 
            palette_import_but.Enabled = false;
            palette_import_but.Location = new Point(755, 13);
            palette_import_but.Margin = new Padding(4);
            palette_import_but.Name = "palette_import_but";
            palette_import_but.Size = new Size(115, 28);
            palette_import_but.TabIndex = 36;
            palette_import_but.Text = "导入调色盘";
            palette_import_but.UseVisualStyleBackColor = true;
            palette_import_but.Visible = false;
            palette_import_but.Click += Palette_import_butClick;
            // 
            // sprite_help
            // 
            sprite_help.Location = new Point(1125, 49);
            sprite_help.Margin = new Padding(4);
            sprite_help.Name = "sprite_help";
            sprite_help.Size = new Size(34, 27);
            sprite_help.TabIndex = 37;
            sprite_help.Text = "?";
            sprite_help.UseVisualStyleBackColor = true;
            sprite_help.Click += Sprite_helpClick;
            // 
            // jap_encoding
            // 
            jap_encoding.Location = new Point(121, 83);
            jap_encoding.Margin = new Padding(4);
            jap_encoding.Name = "jap_encoding";
            jap_encoding.Size = new Size(179, 28);
            jap_encoding.TabIndex = 38;
            jap_encoding.Text = "日文解码";
            jap_encoding.UseVisualStyleBackColor = true;
            jap_encoding.CheckedChanged += Jap_encodingCheckedChanged;
            // 
            // heal_inf
            // 
            heal_inf.Location = new Point(8, 24);
            heal_inf.Margin = new Padding(4);
            heal_inf.Name = "heal_inf";
            heal_inf.Size = new Size(139, 22);
            heal_inf.TabIndex = 39;
            heal_inf.Text = "治愈着迷";
            heal_inf.UseVisualStyleBackColor = true;
            // 
            // heal_sleep
            // 
            heal_sleep.Location = new Point(8, 50);
            heal_sleep.Margin = new Padding(4);
            heal_sleep.Name = "heal_sleep";
            heal_sleep.Size = new Size(139, 22);
            heal_sleep.TabIndex = 40;
            heal_sleep.Text = "治愈睡眠";
            heal_sleep.UseVisualStyleBackColor = true;
            // 
            // heal_poison
            // 
            heal_poison.Location = new Point(8, 73);
            heal_poison.Margin = new Padding(4);
            heal_poison.Name = "heal_poison";
            heal_poison.Size = new Size(139, 22);
            heal_poison.TabIndex = 41;
            heal_poison.Text = "治愈中毒";
            heal_poison.UseVisualStyleBackColor = true;
            // 
            // heal_burn
            // 
            heal_burn.Location = new Point(8, 95);
            heal_burn.Margin = new Padding(4);
            heal_burn.Name = "heal_burn";
            heal_burn.Size = new Size(139, 22);
            heal_burn.TabIndex = 42;
            heal_burn.Text = "治愈灼伤";
            heal_burn.UseVisualStyleBackColor = true;
            // 
            // heal_ice
            // 
            heal_ice.Location = new Point(8, 116);
            heal_ice.Margin = new Padding(4);
            heal_ice.Name = "heal_ice";
            heal_ice.Size = new Size(139, 22);
            heal_ice.TabIndex = 43;
            heal_ice.Text = "治愈冰冻";
            heal_ice.UseVisualStyleBackColor = true;
            // 
            // heal_para
            // 
            heal_para.Location = new Point(8, 139);
            heal_para.Margin = new Padding(4);
            heal_para.Name = "heal_para";
            heal_para.Size = new Size(139, 22);
            heal_para.TabIndex = 44;
            heal_para.Text = "治愈麻痹";
            heal_para.UseVisualStyleBackColor = true;
            // 
            // heal_confu
            // 
            heal_confu.Location = new Point(8, 161);
            heal_confu.Margin = new Padding(4);
            heal_confu.Name = "heal_confu";
            heal_confu.Size = new Size(139, 22);
            heal_confu.TabIndex = 45;
            heal_confu.Text = "治愈混乱";
            heal_confu.UseVisualStyleBackColor = true;
            // 
            // guard
            // 
            guard.Location = new Point(8, 179);
            guard.Margin = new Padding(4);
            guard.Name = "guard";
            guard.Size = new Size(121, 20);
            guard.TabIndex = 46;
            guard.Text = "能力防守";
            guard.UseVisualStyleBackColor = true;
            // 
            // lvlup
            // 
            lvlup.Location = new Point(281, 266);
            lvlup.Margin = new Padding(4);
            lvlup.Name = "lvlup";
            lvlup.Size = new Size(117, 26);
            lvlup.TabIndex = 47;
            lvlup.Text = "等级提升";
            lvlup.UseVisualStyleBackColor = true;
            // 
            // firstpoke
            // 
            firstpoke.Location = new Point(281, 227);
            firstpoke.Margin = new Padding(4);
            firstpoke.Name = "firstpoke";
            firstpoke.Size = new Size(161, 46);
            firstpoke.TabIndex = 48;
            firstpoke.Text = "对首位宝可梦应用";
            firstpoke.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.Location = new Point(23, 22);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(73, 16);
            label15.TabIndex = 49;
            label15.Text = "要害攻击";
            // 
            // label16
            // 
            label16.Location = new Point(23, 49);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(133, 16);
            label16.TabIndex = 50;
            label16.Text = "攻击强化";
            // 
            // label17
            // 
            label17.Location = new Point(23, 75);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(133, 16);
            label17.TabIndex = 51;
            label17.Text = "防御强化";
            // 
            // label18
            // 
            label18.Location = new Point(23, 101);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(133, 16);
            label18.TabIndex = 52;
            label18.Text = "速度强化";
            // 
            // label19
            // 
            label19.Location = new Point(23, 128);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(133, 16);
            label19.TabIndex = 53;
            label19.Text = "特攻强化";
            // 
            // label20
            // 
            label20.Location = new Point(23, 154);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(133, 16);
            label20.TabIndex = 54;
            label20.Text = "命中强化";
            // 
            // direhit
            // 
            direhit.Location = new Point(104, 20);
            direhit.Margin = new Padding(4);
            direhit.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            direhit.Name = "direhit";
            direhit.Size = new Size(52, 25);
            direhit.TabIndex = 56;
            // 
            // atkup
            // 
            atkup.Location = new Point(104, 46);
            atkup.Margin = new Padding(4);
            atkup.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            atkup.Name = "atkup";
            atkup.Size = new Size(52, 25);
            atkup.TabIndex = 57;
            // 
            // defup
            // 
            defup.Location = new Point(104, 73);
            defup.Margin = new Padding(4);
            defup.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            defup.Name = "defup";
            defup.Size = new Size(52, 25);
            defup.TabIndex = 58;
            // 
            // speedup
            // 
            speedup.Location = new Point(104, 99);
            speedup.Margin = new Padding(4);
            speedup.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            speedup.Name = "speedup";
            speedup.Size = new Size(52, 25);
            speedup.TabIndex = 59;
            // 
            // spatkup
            // 
            spatkup.Location = new Point(104, 125);
            spatkup.Margin = new Padding(4);
            spatkup.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            spatkup.Name = "spatkup";
            spatkup.Size = new Size(52, 25);
            spatkup.TabIndex = 60;
            // 
            // accurup
            // 
            accurup.Location = new Point(104, 152);
            accurup.Margin = new Padding(4);
            accurup.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            accurup.Name = "accurup";
            accurup.Size = new Size(52, 25);
            accurup.TabIndex = 61;
            // 
            // ev_hp
            // 
            ev_hp.Location = new Point(17, 21);
            ev_hp.Margin = new Padding(4);
            ev_hp.Name = "ev_hp";
            ev_hp.Size = new Size(87, 22);
            ev_hp.TabIndex = 62;
            ev_hp.Text = "HP";
            ev_hp.UseVisualStyleBackColor = true;
            // 
            // ev_atk
            // 
            ev_atk.Location = new Point(17, 47);
            ev_atk.Margin = new Padding(4);
            ev_atk.Name = "ev_atk";
            ev_atk.Size = new Size(87, 22);
            ev_atk.TabIndex = 63;
            ev_atk.Text = "攻击";
            ev_atk.UseVisualStyleBackColor = true;
            // 
            // ev_def
            // 
            ev_def.Location = new Point(17, 70);
            ev_def.Margin = new Padding(4);
            ev_def.Name = "ev_def";
            ev_def.Size = new Size(100, 22);
            ev_def.TabIndex = 65;
            ev_def.Text = "防御";
            ev_def.UseVisualStyleBackColor = true;
            // 
            // ev_speed
            // 
            ev_speed.Location = new Point(17, 92);
            ev_speed.Margin = new Padding(4);
            ev_speed.Name = "ev_speed";
            ev_speed.Size = new Size(100, 22);
            ev_speed.TabIndex = 66;
            ev_speed.Text = "速度";
            ev_speed.UseVisualStyleBackColor = true;
            // 
            // ev_speatk
            // 
            ev_speatk.Location = new Point(17, 114);
            ev_speatk.Margin = new Padding(4);
            ev_speatk.Name = "ev_speatk";
            ev_speatk.Size = new Size(100, 22);
            ev_speatk.TabIndex = 67;
            ev_speatk.Text = "特攻";
            ev_speatk.UseVisualStyleBackColor = true;
            // 
            // ev_spedef
            // 
            ev_spedef.Location = new Point(17, 136);
            ev_spedef.Margin = new Padding(4);
            ev_spedef.Name = "ev_spedef";
            ev_spedef.Size = new Size(100, 22);
            ev_spedef.TabIndex = 68;
            ev_spedef.Text = "特防";
            ev_spedef.UseVisualStyleBackColor = true;
            // 
            // tr6_val
            // 
            tr6_val.Location = new Point(609, 235);
            tr6_val.Margin = new Padding(4);
            tr6_val.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
            tr6_val.Name = "tr6_val";
            tr6_val.Size = new Size(72, 25);
            tr6_val.TabIndex = 69;
            // 
            // heal_hp
            // 
            heal_hp.Location = new Point(8, 26);
            heal_hp.Margin = new Padding(4);
            heal_hp.Name = "heal_hp";
            heal_hp.Size = new Size(139, 22);
            heal_hp.TabIndex = 70;
            heal_hp.Text = "回复HP";
            heal_hp.UseVisualStyleBackColor = true;
            // 
            // heal_pp
            // 
            heal_pp.Location = new Point(8, 49);
            heal_pp.Margin = new Padding(4);
            heal_pp.Name = "heal_pp";
            heal_pp.Size = new Size(139, 22);
            heal_pp.TabIndex = 71;
            heal_pp.Text = "回复PP";
            heal_pp.UseVisualStyleBackColor = true;
            // 
            // selectedatk
            // 
            selectedatk.Location = new Point(8, 71);
            selectedatk.Margin = new Padding(4);
            selectedatk.Name = "selectedatk";
            selectedatk.Size = new Size(185, 22);
            selectedatk.TabIndex = 73;
            selectedatk.Text = "只针对选定的攻击";
            selectedatk.UseVisualStyleBackColor = true;
            // 
            // maxppUP
            // 
            maxppUP.Location = new Point(8, 98);
            maxppUP.Margin = new Padding(4);
            maxppUP.Name = "maxppUP";
            maxppUP.Size = new Size(145, 22);
            maxppUP.TabIndex = 74;
            maxppUP.Text = "提升PP极限值";
            maxppUP.UseVisualStyleBackColor = true;
            // 
            // revive
            // 
            revive.Location = new Point(8, 118);
            revive.Margin = new Padding(4);
            revive.Name = "revive";
            revive.Size = new Size(139, 22);
            revive.TabIndex = 75;
            revive.Text = "脱离濒死并治愈";
            revive.UseVisualStyleBackColor = true;
            // 
            // stone
            // 
            stone.Location = new Point(8, 178);
            stone.Margin = new Padding(4);
            stone.Name = "stone";
            stone.Size = new Size(139, 22);
            stone.TabIndex = 76;
            stone.Text = "进化石";
            stone.UseVisualStyleBackColor = true;
            // 
            // happy200
            // 
            happy200.Location = new Point(16, 20);
            happy200.Margin = new Padding(4);
            happy200.Name = "happy200";
            happy200.Size = new Size(139, 22);
            happy200.TabIndex = 77;
            happy200.Text = "亲密度>200";
            happy200.UseVisualStyleBackColor = true;
            // 
            // happy100
            // 
            happy100.Location = new Point(16, 52);
            happy100.Margin = new Padding(4);
            happy100.Name = "happy100";
            happy100.Size = new Size(139, 22);
            happy100.TabIndex = 78;
            happy100.Text = "亲密度>100";
            happy100.UseVisualStyleBackColor = true;
            // 
            // happy0
            // 
            happy0.Location = new Point(16, 85);
            happy0.Margin = new Padding(4);
            happy0.Name = "happy0";
            happy0.Size = new Size(145, 22);
            happy0.TabIndex = 79;
            happy0.Text = "亲密度<100";
            happy0.UseVisualStyleBackColor = true;
            // 
            // hap200
            // 
            hap200.Location = new Point(156, 20);
            hap200.Margin = new Padding(4);
            hap200.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
            hap200.Name = "hap200";
            hap200.Size = new Size(76, 25);
            hap200.TabIndex = 80;
            // 
            // hap100
            // 
            hap100.Location = new Point(156, 52);
            hap100.Margin = new Padding(4);
            hap100.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
            hap100.Name = "hap100";
            hap100.Size = new Size(76, 25);
            hap100.TabIndex = 81;
            // 
            // happ0
            // 
            happ0.Location = new Point(156, 85);
            happ0.Margin = new Padding(4);
            happ0.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
            happ0.Name = "happ0";
            happ0.Size = new Size(76, 25);
            happ0.TabIndex = 82;
            // 
            // ppup
            // 
            ppup.Location = new Point(8, 139);
            ppup.Margin = new Padding(4);
            ppup.Name = "ppup";
            ppup.Size = new Size(165, 38);
            ppup.TabIndex = 83;
            ppup.Text = "将选定攻击的PP增加到最大值";
            ppup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvlup);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(note);
            groupBox1.Controls.Add(modifier_help);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(tr6_val);
            groupBox1.Controls.Add(firstpoke);
            groupBox1.Location = new Point(493, 87);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(700, 360);
            groupBox1.TabIndex = 84;
            groupBox1.TabStop = false;
            groupBox1.Text = "训练家主动使用";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(pphelp);
            groupBox6.Controls.Add(ppup);
            groupBox6.Controls.Add(stone);
            groupBox6.Controls.Add(revive);
            groupBox6.Controls.Add(maxppUP);
            groupBox6.Controls.Add(heal_pp);
            groupBox6.Controls.Add(heal_hp);
            groupBox6.Controls.Add(selectedatk);
            groupBox6.Location = new Point(493, 16);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(192, 206);
            groupBox6.TabIndex = 92;
            groupBox6.TabStop = false;
            groupBox6.Text = "HP/PP";
            // 
            // pphelp
            // 
            pphelp.Location = new Point(139, 17);
            pphelp.Margin = new Padding(4);
            pphelp.Name = "pphelp";
            pphelp.Size = new Size(34, 24);
            pphelp.TabIndex = 85;
            pphelp.Text = "?";
            pphelp.UseVisualStyleBackColor = true;
            pphelp.Click += PphelpClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(happ0);
            groupBox5.Controls.Add(hap100);
            groupBox5.Controls.Add(hap200);
            groupBox5.Controls.Add(happy0);
            groupBox5.Controls.Add(happy100);
            groupBox5.Controls.Add(happy200);
            groupBox5.Location = new Point(8, 218);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(265, 122);
            groupBox5.TabIndex = 91;
            groupBox5.TabStop = false;
            groupBox5.Text = "亲密度";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(heal_confu);
            groupBox4.Controls.Add(heal_para);
            groupBox4.Controls.Add(heal_ice);
            groupBox4.Controls.Add(heal_burn);
            groupBox4.Controls.Add(heal_poison);
            groupBox4.Controls.Add(heal_sleep);
            groupBox4.Controls.Add(heal_inf);
            groupBox4.Location = new Point(8, 20);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(161, 190);
            groupBox4.TabIndex = 90;
            groupBox4.TabStop = false;
            groupBox4.Text = "状态";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(accurup);
            groupBox3.Controls.Add(spatkup);
            groupBox3.Controls.Add(speedup);
            groupBox3.Controls.Add(defup);
            groupBox3.Controls.Add(atkup);
            groupBox3.Controls.Add(direhit);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(guard);
            groupBox3.Controls.Add(label15);
            groupBox3.Location = new Point(177, 16);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(176, 203);
            groupBox3.TabIndex = 89;
            groupBox3.TabStop = false;
            groupBox3.Text = "对战";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ev_spedef);
            groupBox2.Controls.Add(ev_speatk);
            groupBox2.Controls.Add(ev_speed);
            groupBox2.Controls.Add(ev_def);
            groupBox2.Controls.Add(ev_atk);
            groupBox2.Controls.Add(ev_hp);
            groupBox2.Location = new Point(361, 20);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(124, 197);
            groupBox2.TabIndex = 88;
            groupBox2.TabStop = false;
            groupBox2.Text = "基础点数";
            // 
            // note
            // 
            note.Location = new Point(402, 267);
            note.Margin = new Padding(4);
            note.Name = "note";
            note.Size = new Size(100, 26);
            note.TabIndex = 87;
            note.Text = "注意";
            note.UseVisualStyleBackColor = true;
            note.Click += NoteClick;
            // 
            // modifier_help
            // 
            modifier_help.Location = new Point(633, 267);
            modifier_help.Margin = new Padding(4);
            modifier_help.Name = "modifier_help";
            modifier_help.Size = new Size(33, 24);
            modifier_help.TabIndex = 86;
            modifier_help.Text = "?";
            modifier_help.UseVisualStyleBackColor = true;
            modifier_help.Click += Modifier_helpClick;
            // 
            // label14
            // 
            label14.Location = new Point(450, 240);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(151, 22);
            label14.TabIndex = 84;
            label14.Text = "HP/PP/基础点数修饰符：";
            // 
            // ECB_editor
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 453);
            Controls.Add(groupBox1);
            Controls.Add(jap_encoding);
            Controls.Add(sprite_help);
            Controls.Add(palette_import_but);
            Controls.Add(palette_export_but);
            Controls.Add(sprite_import_but);
            Controls.Add(sprite_export_but);
            Controls.Add(held_help);
            Controls.Add(held);
            Controls.Add(label13);
            Controls.Add(desc2);
            Controls.Add(desc1);
            Controls.Add(label12);
            Controls.Add(smooth);
            Controls.Add(sour);
            Controls.Add(bitter);
            Controls.Add(sweet);
            Controls.Add(dry);
            Controls.Add(spicy);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(growth);
            Controls.Add(label6);
            Controls.Add(yield_min);
            Controls.Add(yield_max);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(size);
            Controls.Add(label2);
            Controls.Add(firm_box);
            Controls.Add(name);
            Controls.Add(label1);
            Controls.Add(ecb_path);
            Controls.Add(save_ecb_but);
            Controls.Add(load_ecb_but);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ECB_editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECB Editor";
            DragDrop += ECB_editorDragDrop;
            DragEnter += ECB_editorDragEnter;
            ((System.ComponentModel.ISupportInitialize)size).EndInit();
            ((System.ComponentModel.ISupportInitialize)yield_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)yield_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)growth).EndInit();
            ((System.ComponentModel.ISupportInitialize)spicy).EndInit();
            ((System.ComponentModel.ISupportInitialize)dry).EndInit();
            ((System.ComponentModel.ISupportInitialize)sweet).EndInit();
            ((System.ComponentModel.ISupportInitialize)bitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)sour).EndInit();
            ((System.ComponentModel.ISupportInitialize)smooth).EndInit();
            ((System.ComponentModel.ISupportInitialize)held).EndInit();
            ((System.ComponentModel.ISupportInitialize)direhit).EndInit();
            ((System.ComponentModel.ISupportInitialize)atkup).EndInit();
            ((System.ComponentModel.ISupportInitialize)defup).EndInit();
            ((System.ComponentModel.ISupportInitialize)speedup).EndInit();
            ((System.ComponentModel.ISupportInitialize)spatkup).EndInit();
            ((System.ComponentModel.ISupportInitialize)accurup).EndInit();
            ((System.ComponentModel.ISupportInitialize)tr6_val).EndInit();
            ((System.ComponentModel.ISupportInitialize)hap200).EndInit();
            ((System.ComponentModel.ISupportInitialize)hap100).EndInit();
            ((System.ComponentModel.ISupportInitialize)happ0).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
