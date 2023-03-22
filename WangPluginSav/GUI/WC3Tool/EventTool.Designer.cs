using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
    partial class EventTool
    {
        private Button load_save_but;

        private TextBox sav3_path;

        private Button region_but;

        private ComboBox game_box;

        private ComboBox language_box;

        private Label region_lab;

        private Button inject_sav;

        private RadioButton jap_eon;

        private RadioButton jap_aurora;

        private GroupBox JAP_group;

        private RadioButton jap_old;

        private RadioButton jap_mystic;

        private GroupBox USA_group;

        private RadioButton usa_eon_italy;

        private RadioButton usa_mystic;

        private RadioButton usa_aurora;

        private RadioButton usa_eon_ecard;

        private GroupBox EUR_group;

        private RadioButton eur_eon;

        private RadioButton eur_aurora;

        private Label label1;

        private Label label3;

        private Label label4;

        private Label label5;

        private Label label6;
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventTool));
            load_save_but = new Button();
            sav3_path = new TextBox();
            region_but = new Button();
            game_box = new ComboBox();
            language_box = new ComboBox();
            region_lab = new Label();
            inject_sav = new Button();
            jap_eon = new RadioButton();
            jap_aurora = new RadioButton();
            JAP_group = new GroupBox();
            jap_old = new RadioButton();
            jap_mystic = new RadioButton();
            USA_group = new GroupBox();
            usa_eon_italy = new RadioButton();
            usa_mystic = new RadioButton();
            usa_aurora = new RadioButton();
            usa_eon_ecard = new RadioButton();
            EUR_group = new GroupBox();
            eur_eon = new RadioButton();
            eur_aurora = new RadioButton();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            JAP_group.SuspendLayout();
            USA_group.SuspendLayout();
            EUR_group.SuspendLayout();
            SuspendLayout();
            // 
            // load_save_but
            // 
            load_save_but.Location = new Point(17, 11);
            load_save_but.Margin = new Padding(4, 4, 4, 4);
            load_save_but.Name = "load_save_but";
            load_save_but.Size = new Size(121, 26);
            load_save_but.TabIndex = 1;
            load_save_but.Text = "读取存档";
            load_save_but.UseVisualStyleBackColor = true;
            load_save_but.Click += Load_save_butClick;
            // 
            // sav3_path
            // 
            sav3_path.Location = new Point(17, 45);
            sav3_path.Margin = new Padding(4, 4, 4, 4);
            sav3_path.Name = "sav3_path";
            sav3_path.ReadOnly = true;
            sav3_path.Size = new Size(783, 25);
            sav3_path.TabIndex = 5;
            // 
            // region_but
            // 
            region_but.Enabled = false;
            region_but.Location = new Point(613, 11);
            region_but.Margin = new Padding(4, 4, 4, 4);
            region_but.Name = "region_but";
            region_but.Size = new Size(123, 26);
            region_but.TabIndex = 15;
            region_but.Text = "强制更改信息";
            region_but.UseVisualStyleBackColor = true;
            region_but.Click += Region_butClick;
            // 
            // game_box
            // 
            game_box.Enabled = false;
            game_box.FormattingEnabled = true;
            game_box.Items.AddRange(new object[] { "红宝石/蓝宝石", "绿宝石", "火红/叶绿" });
            game_box.Location = new Point(147, 14);
            game_box.Margin = new Padding(4, 4, 4, 4);
            game_box.Name = "game_box";
            game_box.Size = new Size(197, 23);
            game_box.TabIndex = 21;
            game_box.SelectedIndexChanged += Game_boxSelectedIndexChanged;
            // 
            // language_box
            // 
            language_box.Enabled = false;
            language_box.FormattingEnabled = true;
            language_box.Items.AddRange(new object[] { "日语", "英语", "法语", "意大利语", "德语", "韩语（未使用）", "西班牙语" });
            language_box.Location = new Point(352, 14);
            language_box.Margin = new Padding(4, 4, 4, 4);
            language_box.Name = "language_box";
            language_box.Size = new Size(160, 23);
            language_box.TabIndex = 22;
            language_box.SelectedIndexChanged += Language_boxSelectedIndexChanged;
            // 
            // region_lab
            // 
            region_lab.Location = new Point(521, 17);
            region_lab.Margin = new Padding(4, 0, 4, 0);
            region_lab.Name = "region_lab";
            region_lab.Size = new Size(84, 21);
            region_lab.TabIndex = 23;
            region_lab.Text = "区域";
            // 
            // inject_sav
            // 
            inject_sav.Location = new Point(588, 214);
            inject_sav.Margin = new Padding(4, 4, 4, 4);
            inject_sav.Name = "inject_sav";
            inject_sav.Size = new Size(192, 26);
            inject_sav.TabIndex = 28;
            inject_sav.Text = "配信并写入记录";
            inject_sav.UseVisualStyleBackColor = true;
            inject_sav.Click += Inject_savClick;
            // 
            // jap_eon
            // 
            jap_eon.Location = new Point(8, 22);
            jap_eon.Margin = new Padding(4, 4, 4, 4);
            jap_eon.Name = "jap_eon";
            jap_eon.Size = new Size(192, 28);
            jap_eon.TabIndex = 29;
            jap_eon.TabStop = true;
            jap_eon.Text = "无限船票(R/S/E)";
            jap_eon.UseVisualStyleBackColor = true;
            // 
            // jap_aurora
            // 
            jap_aurora.Location = new Point(8, 56);
            jap_aurora.Margin = new Padding(4, 4, 4, 4);
            jap_aurora.Name = "jap_aurora";
            jap_aurora.Size = new Size(227, 28);
            jap_aurora.TabIndex = 30;
            jap_aurora.TabStop = true;
            jap_aurora.Text = "极光船票2004(FR/LG)";
            jap_aurora.UseVisualStyleBackColor = true;
            // 
            // JAP_group
            // 
            JAP_group.Controls.Add(jap_old);
            JAP_group.Controls.Add(jap_mystic);
            JAP_group.Controls.Add(jap_aurora);
            JAP_group.Controls.Add(jap_eon);
            JAP_group.Enabled = false;
            JAP_group.Location = new Point(17, 75);
            JAP_group.Margin = new Padding(4, 4, 4, 4);
            JAP_group.Name = "JAP_group";
            JAP_group.Padding = new Padding(4, 4, 4, 4);
            JAP_group.Size = new Size(256, 165);
            JAP_group.TabIndex = 31;
            JAP_group.TabStop = false;
            JAP_group.Text = "日版";
            // 
            // jap_old
            // 
            jap_old.Location = new Point(8, 126);
            jap_old.Margin = new Padding(4, 4, 4, 4);
            jap_old.Name = "jap_old";
            jap_old.Size = new Size(227, 28);
            jap_old.TabIndex = 32;
            jap_old.TabStop = true;
            jap_old.Text = "古航海图(E)";
            jap_old.UseVisualStyleBackColor = true;
            // 
            // jap_mystic
            // 
            jap_mystic.Location = new Point(8, 92);
            jap_mystic.Margin = new Padding(4, 4, 4, 4);
            jap_mystic.Name = "jap_mystic";
            jap_mystic.Size = new Size(227, 28);
            jap_mystic.TabIndex = 31;
            jap_mystic.TabStop = true;
            jap_mystic.Text = "神秘船票2005(FR/LG/E)";
            jap_mystic.UseVisualStyleBackColor = true;
            // 
            // USA_group
            // 
            USA_group.Controls.Add(usa_eon_italy);
            USA_group.Controls.Add(usa_mystic);
            USA_group.Controls.Add(usa_aurora);
            USA_group.Controls.Add(usa_eon_ecard);
            USA_group.Enabled = false;
            USA_group.Location = new Point(281, 75);
            USA_group.Margin = new Padding(4, 4, 4, 4);
            USA_group.Name = "USA_group";
            USA_group.Padding = new Padding(4, 4, 4, 4);
            USA_group.Size = new Size(256, 165);
            USA_group.TabIndex = 33;
            USA_group.TabStop = false;
            USA_group.Text = "美版/欧版英文";
            // 
            // usa_eon_italy
            // 
            usa_eon_italy.Location = new Point(8, 56);
            usa_eon_italy.Margin = new Padding(4, 4, 4, 4);
            usa_eon_italy.Name = "usa_eon_italy";
            usa_eon_italy.Size = new Size(240, 28);
            usa_eon_italy.TabIndex = 32;
            usa_eon_italy.TabStop = true;
            usa_eon_italy.Text = "无限船票(R/S)\r(意大利任天堂）";
            usa_eon_italy.UseVisualStyleBackColor = true;
            // 
            // usa_mystic
            // 
            usa_mystic.Location = new Point(8, 126);
            usa_mystic.Margin = new Padding(4, 4, 4, 4);
            usa_mystic.Name = "usa_mystic";
            usa_mystic.Size = new Size(227, 28);
            usa_mystic.TabIndex = 31;
            usa_mystic.TabStop = true;
            usa_mystic.Text = "神秘船票(FR/LG/E)";
            usa_mystic.UseVisualStyleBackColor = true;
            // 
            // usa_aurora
            // 
            usa_aurora.Location = new Point(8, 92);
            usa_aurora.Margin = new Padding(4, 4, 4, 4);
            usa_aurora.Name = "usa_aurora";
            usa_aurora.Size = new Size(227, 28);
            usa_aurora.TabIndex = 30;
            usa_aurora.TabStop = true;
            usa_aurora.Text = "极光船票(FR/LG/E)";
            usa_aurora.UseVisualStyleBackColor = true;
            // 
            // usa_eon_ecard
            // 
            usa_eon_ecard.Location = new Point(8, 22);
            usa_eon_ecard.Margin = new Padding(4, 4, 4, 4);
            usa_eon_ecard.Name = "usa_eon_ecard";
            usa_eon_ecard.Size = new Size(224, 28);
            usa_eon_ecard.TabIndex = 29;
            usa_eon_ecard.TabStop = true;
            usa_eon_ecard.Text = "无限船票(R/S)(e卡)";
            usa_eon_ecard.UseVisualStyleBackColor = true;
            // 
            // EUR_group
            // 
            EUR_group.Controls.Add(eur_eon);
            EUR_group.Controls.Add(eur_aurora);
            EUR_group.Enabled = false;
            EUR_group.Location = new Point(545, 75);
            EUR_group.Margin = new Padding(4, 4, 4, 4);
            EUR_group.Name = "EUR_group";
            EUR_group.Padding = new Padding(4, 4, 4, 4);
            EUR_group.Size = new Size(256, 118);
            EUR_group.TabIndex = 34;
            EUR_group.TabStop = false;
            EUR_group.Text = "欧版非英文";
            // 
            // eur_eon
            // 
            eur_eon.Location = new Point(8, 22);
            eur_eon.Margin = new Padding(4, 4, 4, 4);
            eur_eon.Name = "eur_eon";
            eur_eon.Size = new Size(240, 28);
            eur_eon.TabIndex = 32;
            eur_eon.TabStop = true;
            eur_eon.Text = "无限船票(R/S)\r(意大利任天堂)";
            eur_eon.UseVisualStyleBackColor = true;
            // 
            // eur_aurora
            // 
            eur_aurora.Location = new Point(8, 56);
            eur_aurora.Margin = new Padding(4, 4, 4, 4);
            eur_aurora.Name = "eur_aurora";
            eur_aurora.Size = new Size(227, 28);
            eur_aurora.TabIndex = 30;
            eur_aurora.TabStop = true;
            eur_aurora.Text = "极光船票(FR/LG/E)";
            eur_aurora.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(17, 250);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(784, 22);
            label1.TabIndex = 35;
            label1.Text = "注：以下配信活动数据仍缺失：:";
            // 
            // label3
            // 
            label3.Location = new Point(44, 272);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(659, 21);
            label3.TabIndex = 37;
            label3.Text = "- \"神秘船票\" TCG WORLD CHAMPIONSHIPS 2005 （美版/欧版英文）(FR/LG)";
            // 
            // label4
            // 
            label4.Location = new Point(44, 291);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(592, 26);
            label4.TabIndex = 38;
            label4.Text = "- \"神秘船票\" POKÉMON ROCKS AMERICA 2005（美版/欧版英文）(FR/LG/E)";
            // 
            // label5
            // 
            label5.Location = new Point(44, 308);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(561, 26);
            label5.TabIndex = 39;
            label5.Text = "-  所有神秘卡片配信的宝可梦蛋(FR/LG/E)";
            // 
            // label6
            // 
            label6.Location = new Point(17, 334);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(736, 36);
            label6.TabIndex = 40;
            label6.Text = "如果您拥有这些活动中的任何一个并希望为该项目做出贡献，请在 projectpokemon.org 论坛上联系 Sabresite、suloku 或 ajxpkm 或发送电子邮件至 sabresite@projectpokemon.org";
            // 
            // EventTool
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 376);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(EUR_group);
            Controls.Add(USA_group);
            Controls.Add(JAP_group);
            Controls.Add(inject_sav);
            Controls.Add(region_lab);
            Controls.Add(language_box);
            Controls.Add(game_box);
            Controls.Add(region_but);
            Controls.Add(sav3_path);
            Controls.Add(load_save_but);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "EventTool";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gen3 Event Tool 0.1f by Sabresite";
            DragDrop += EventToolDragDrop;
            DragEnter += EventToolDragEnter;
            JAP_group.ResumeLayout(false);
            USA_group.ResumeLayout(false);
            EUR_group.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
