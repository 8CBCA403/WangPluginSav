using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
    partial class WC3ToolMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button wc3_editor_but;

        private Button load_save_but;

        private Button inject_wc3_but;

        private Button export_wc3but;

        private TextBox sav3_path;

        private MenuStrip menuStrip1;

        private ToolStripMenuItem menuToolStripMenuItem;

        private ToolStripMenuItem exportSortedSavefileToolStripMenuItem;

        private Button export_wcn;

        private Button inject_wcn;

        private Button wcn_edit_but;

        private Button export_me3_but;

        private Button inject_me3_but;

        private Button me3_editor_but;

        private Button eon_em_but;

        private ToolStripMenuItem extraToolStripMenuItem;

        private ToolStripMenuItem enableMysteryGiftMainScreenStripMenuItem;

        private Button region_but;

        private ToolStripMenuItem fixSectionChecksumsToolStripMenuItem;

        private Button decor_but;

        private Button ect_edit_but;

        private Button export_ect_but;

        private Button inject_ect_but;

        private ComboBox game_box;

        private ComboBox language_box;

        private Label region_lab;

        private ToolStripMenuItem exportOldSaveToolStripMenuItem;

        private ToolStripMenuItem toolStripMenuItem1;

        private ToolStripMenuItem clearEggEventFlagToolStripMenuItem;

        private Button export_eberry;

        private Button inject_eberry;

        private Button ecb_edit_but;

        private Button tvswarm_but;

        private GroupBox groupBox1;

        private GroupBox groupBox2;

        private GroupBox groupBox3;

        private GroupBox groupBox4;

        private Button events_distro_but;
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(WC3ToolMainForm));
            wc3_editor_but = new Button();
            load_save_but = new Button();
            inject_wc3_but = new Button();
            export_wc3but = new Button();
            sav3_path = new TextBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            exportSortedSavefileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exportOldSaveToolStripMenuItem = new ToolStripMenuItem();
            fixSectionChecksumsToolStripMenuItem = new ToolStripMenuItem();
            extraToolStripMenuItem = new ToolStripMenuItem();
            enableMysteryGiftMainScreenStripMenuItem = new ToolStripMenuItem();
            clearEggEventFlagToolStripMenuItem = new ToolStripMenuItem();
            export_wcn = new Button();
            inject_wcn = new Button();
            wcn_edit_but = new Button();
            export_me3_but = new Button();
            inject_me3_but = new Button();
            me3_editor_but = new Button();
            eon_em_but = new Button();
            region_but = new Button();
            decor_but = new Button();
            ect_edit_but = new Button();
            export_ect_but = new Button();
            inject_ect_but = new Button();
            game_box = new ComboBox();
            language_box = new ComboBox();
            region_lab = new Label();
            export_eberry = new Button();
            inject_eberry = new Button();
            ecb_edit_but = new Button();
            tvswarm_but = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            events_distro_but = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // wc3_editor_but
            // 
            wc3_editor_but.Location = new Point(176, 38);
            wc3_editor_but.Margin = new Padding(4, 4, 4, 4);
            wc3_editor_but.Name = "wc3_editor_but";
            wc3_editor_but.Size = new Size(100, 26);
            wc3_editor_but.TabIndex = 0;
            wc3_editor_but.Text = "WC3 Editor";
            wc3_editor_but.UseVisualStyleBackColor = true;
            wc3_editor_but.Click += Button1Click;
            // 
            // load_save_but
            // 
            load_save_but.Location = new Point(16, 43);
            load_save_but.Margin = new Padding(4, 4, 4, 4);
            load_save_but.Name = "load_save_but";
            load_save_but.Size = new Size(121, 26);
            load_save_but.TabIndex = 1;
            load_save_but.Text = "Load Save File";
            load_save_but.UseVisualStyleBackColor = true;
            load_save_but.Click += Load_save_butClick;
            // 
            // inject_wc3_but
            // 
            inject_wc3_but.Enabled = false;
            inject_wc3_but.Location = new Point(8, 56);
            inject_wc3_but.Margin = new Padding(4, 4, 4, 4);
            inject_wc3_but.Name = "inject_wc3_but";
            inject_wc3_but.Size = new Size(160, 26);
            inject_wc3_but.TabIndex = 2;
            inject_wc3_but.Text = "Inject WC3";
            inject_wc3_but.UseVisualStyleBackColor = true;
            inject_wc3_but.Click += Inject_wc3_butClick;
            // 
            // export_wc3but
            // 
            export_wc3but.Enabled = false;
            export_wc3but.Location = new Point(8, 23);
            export_wc3but.Margin = new Padding(4, 4, 4, 4);
            export_wc3but.Name = "export_wc3but";
            export_wc3but.Size = new Size(160, 26);
            export_wc3but.TabIndex = 4;
            export_wc3but.Text = "Export WC3";
            export_wc3but.UseVisualStyleBackColor = true;
            export_wc3but.Click += Export_wc3butClick;
            // 
            // sav3_path
            // 
            sav3_path.Location = new Point(16, 76);
            sav3_path.Margin = new Padding(4, 4, 4, 4);
            sav3_path.Name = "sav3_path";
            sav3_path.ReadOnly = true;
            sav3_path.Size = new Size(885, 25);
            sav3_path.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, extraToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(916, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportSortedSavefileToolStripMenuItem, fixSectionChecksumsToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // exportSortedSavefileToolStripMenuItem
            // 
            exportSortedSavefileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, exportOldSaveToolStripMenuItem });
            exportSortedSavefileToolStripMenuItem.Name = "exportSortedSavefileToolStripMenuItem";
            exportSortedSavefileToolStripMenuItem.Size = new Size(295, 26);
            exportSortedSavefileToolStripMenuItem.Text = "Export sorted savefile (current)";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(218, 26);
            toolStripMenuItem1.Text = "Export current save";
            toolStripMenuItem1.Click += ToolStripMenuItem1Click;
            // 
            // exportOldSaveToolStripMenuItem
            // 
            exportOldSaveToolStripMenuItem.Enabled = false;
            exportOldSaveToolStripMenuItem.Name = "exportOldSaveToolStripMenuItem";
            exportOldSaveToolStripMenuItem.Size = new Size(218, 26);
            exportOldSaveToolStripMenuItem.Text = "Export old save";
            exportOldSaveToolStripMenuItem.Click += ExportOldSaveToolStripMenuItemClick;
            // 
            // fixSectionChecksumsToolStripMenuItem
            // 
            fixSectionChecksumsToolStripMenuItem.Enabled = false;
            fixSectionChecksumsToolStripMenuItem.Name = "fixSectionChecksumsToolStripMenuItem";
            fixSectionChecksumsToolStripMenuItem.Size = new Size(295, 26);
            fixSectionChecksumsToolStripMenuItem.Text = "Fix Section Checksums";
            fixSectionChecksumsToolStripMenuItem.Click += FixSectionChecksumsToolStripMenuItemClick;
            // 
            // extraToolStripMenuItem
            // 
            extraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enableMysteryGiftMainScreenStripMenuItem, clearEggEventFlagToolStripMenuItem });
            extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            extraToolStripMenuItem.Size = new Size(56, 24);
            extraToolStripMenuItem.Text = "Extra";
            // 
            // enableMysteryGiftMainScreenStripMenuItem
            // 
            enableMysteryGiftMainScreenStripMenuItem.Enabled = false;
            enableMysteryGiftMainScreenStripMenuItem.Name = "enableMysteryGiftMainScreenStripMenuItem";
            enableMysteryGiftMainScreenStripMenuItem.Size = new Size(262, 26);
            enableMysteryGiftMainScreenStripMenuItem.Text = "Enable Mystery Gift/Event";
            enableMysteryGiftMainScreenStripMenuItem.Click += EnableMysteryGiftMainScreenStripMenuItemClick;
            // 
            // clearEggEventFlagToolStripMenuItem
            // 
            clearEggEventFlagToolStripMenuItem.Enabled = false;
            clearEggEventFlagToolStripMenuItem.Name = "clearEggEventFlagToolStripMenuItem";
            clearEggEventFlagToolStripMenuItem.Size = new Size(262, 26);
            clearEggEventFlagToolStripMenuItem.Text = "Clear Egg Event Flag";
            clearEggEventFlagToolStripMenuItem.Click += ClearEggEventFlagToolStripMenuItemClick;
            // 
            // export_wcn
            // 
            export_wcn.Enabled = false;
            export_wcn.Location = new Point(8, 90);
            export_wcn.Margin = new Padding(4, 4, 4, 4);
            export_wcn.Name = "export_wcn";
            export_wcn.Size = new Size(160, 26);
            export_wcn.TabIndex = 7;
            export_wcn.Text = "Export Wonder News";
            export_wcn.UseVisualStyleBackColor = true;
            export_wcn.Click += Export_wcnClick;
            // 
            // inject_wcn
            // 
            inject_wcn.Enabled = false;
            inject_wcn.Location = new Point(8, 124);
            inject_wcn.Margin = new Padding(4, 4, 4, 4);
            inject_wcn.Name = "inject_wcn";
            inject_wcn.Size = new Size(160, 26);
            inject_wcn.TabIndex = 8;
            inject_wcn.Text = "Inject Wonder News";
            inject_wcn.UseVisualStyleBackColor = true;
            inject_wcn.Click += Inject_wcnClick;
            // 
            // wcn_edit_but
            // 
            wcn_edit_but.Location = new Point(176, 105);
            wcn_edit_but.Margin = new Padding(4, 4, 4, 4);
            wcn_edit_but.Name = "wcn_edit_but";
            wcn_edit_but.Size = new Size(100, 26);
            wcn_edit_but.TabIndex = 9;
            wcn_edit_but.Text = "WN3 Editor";
            wcn_edit_but.UseVisualStyleBackColor = true;
            wcn_edit_but.Click += Wcn_edit_butClick;
            // 
            // export_me3_but
            // 
            export_me3_but.Enabled = false;
            export_me3_but.Location = new Point(8, 38);
            export_me3_but.Margin = new Padding(4, 4, 4, 4);
            export_me3_but.Name = "export_me3_but";
            export_me3_but.Size = new Size(160, 26);
            export_me3_but.TabIndex = 10;
            export_me3_but.Text = "Export ME3";
            export_me3_but.UseVisualStyleBackColor = true;
            export_me3_but.Click += Export_me3_butClick;
            // 
            // inject_me3_but
            // 
            inject_me3_but.Enabled = false;
            inject_me3_but.Location = new Point(8, 71);
            inject_me3_but.Margin = new Padding(4, 4, 4, 4);
            inject_me3_but.Name = "inject_me3_but";
            inject_me3_but.Size = new Size(160, 26);
            inject_me3_but.TabIndex = 11;
            inject_me3_but.Text = "Inject ME3";
            inject_me3_but.UseVisualStyleBackColor = true;
            inject_me3_but.Click += Inject_me3_butClick;
            // 
            // me3_editor_but
            // 
            me3_editor_but.Location = new Point(176, 71);
            me3_editor_but.Margin = new Padding(4, 4, 4, 4);
            me3_editor_but.Name = "me3_editor_but";
            me3_editor_but.Size = new Size(100, 26);
            me3_editor_but.TabIndex = 12;
            me3_editor_but.Text = "ME3 Editor";
            me3_editor_but.UseVisualStyleBackColor = true;
            me3_editor_but.Click += Me3_editor_butClick;
            // 
            // eon_em_but
            // 
            eon_em_but.Enabled = false;
            eon_em_but.Location = new Point(8, 105);
            eon_em_but.Margin = new Padding(4, 4, 4, 4);
            eon_em_but.Name = "eon_em_but";
            eon_em_but.Size = new Size(160, 26);
            eon_em_but.TabIndex = 13;
            eon_em_but.Text = "EON Ticket (Emerald)";
            eon_em_but.UseVisualStyleBackColor = true;
            eon_em_but.Click += Eon_em_butClick;
            // 
            // region_but
            // 
            region_but.Enabled = false;
            region_but.Location = new Point(612, 43);
            region_but.Margin = new Padding(4, 4, 4, 4);
            region_but.Name = "region_but";
            region_but.Size = new Size(123, 26);
            region_but.TabIndex = 15;
            region_but.Text = "Override Region";
            region_but.UseVisualStyleBackColor = true;
            region_but.Click += Region_butClick;
            // 
            // decor_but
            // 
            decor_but.Enabled = false;
            decor_but.Location = new Point(8, 22);
            decor_but.Margin = new Padding(4, 4, 4, 4);
            decor_but.Name = "decor_but";
            decor_but.Size = new Size(160, 26);
            decor_but.TabIndex = 16;
            decor_but.Text = "Decoration Editor";
            decor_but.UseVisualStyleBackColor = true;
            decor_but.Click += Decor_butClick;
            // 
            // ect_edit_but
            // 
            ect_edit_but.Location = new Point(176, 34);
            ect_edit_but.Margin = new Padding(4, 4, 4, 4);
            ect_edit_but.Name = "ect_edit_but";
            ect_edit_but.Size = new Size(100, 26);
            ect_edit_but.TabIndex = 17;
            ect_edit_but.Text = "ECT Editor";
            ect_edit_but.UseVisualStyleBackColor = true;
            ect_edit_but.Click += Ect_edit_butClick;
            // 
            // export_ect_but
            // 
            export_ect_but.Enabled = false;
            export_ect_but.Location = new Point(8, 20);
            export_ect_but.Margin = new Padding(4, 4, 4, 4);
            export_ect_but.Name = "export_ect_but";
            export_ect_but.Size = new Size(160, 26);
            export_ect_but.TabIndex = 18;
            export_ect_but.Text = "Export ECT";
            export_ect_but.UseVisualStyleBackColor = true;
            export_ect_but.Click += Export_ect_butClick;
            // 
            // inject_ect_but
            // 
            inject_ect_but.Enabled = false;
            inject_ect_but.Location = new Point(8, 53);
            inject_ect_but.Margin = new Padding(4, 4, 4, 4);
            inject_ect_but.Name = "inject_ect_but";
            inject_ect_but.Size = new Size(160, 26);
            inject_ect_but.TabIndex = 19;
            inject_ect_but.Text = "Inject ECT";
            inject_ect_but.UseVisualStyleBackColor = true;
            inject_ect_but.Click += Inject_ect_butClick;
            // 
            // game_box
            // 
            game_box.Enabled = false;
            game_box.FormattingEnabled = true;
            game_box.Items.AddRange(new object[] { "Ruby/Saphire", "Emerald", "Fire Red/Leaf Green" });
            game_box.Location = new Point(145, 45);
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
            language_box.Items.AddRange(new object[] { "Japanese", "English", "French", "Italian", "German", "Korean (not used)", "Spanish" });
            language_box.Location = new Point(351, 45);
            language_box.Margin = new Padding(4, 4, 4, 4);
            language_box.Name = "language_box";
            language_box.Size = new Size(160, 23);
            language_box.TabIndex = 22;
            language_box.SelectedIndexChanged += Language_boxSelectedIndexChanged;
            // 
            // region_lab
            // 
            region_lab.Location = new Point(520, 49);
            region_lab.Margin = new Padding(4, 0, 4, 0);
            region_lab.Name = "region_lab";
            region_lab.Size = new Size(84, 21);
            region_lab.TabIndex = 23;
            region_lab.Text = "Region";
            // 
            // export_eberry
            // 
            export_eberry.Enabled = false;
            export_eberry.Location = new Point(8, 86);
            export_eberry.Margin = new Padding(4, 4, 4, 4);
            export_eberry.Name = "export_eberry";
            export_eberry.Size = new Size(160, 26);
            export_eberry.TabIndex = 24;
            export_eberry.Text = "Export e-berry";
            export_eberry.UseVisualStyleBackColor = true;
            export_eberry.Click += Export_eberryClick;
            // 
            // inject_eberry
            // 
            inject_eberry.Enabled = false;
            inject_eberry.Location = new Point(8, 120);
            inject_eberry.Margin = new Padding(4, 4, 4, 4);
            inject_eberry.Name = "inject_eberry";
            inject_eberry.Size = new Size(160, 26);
            inject_eberry.TabIndex = 25;
            inject_eberry.Text = "Inject e-berry";
            inject_eberry.UseVisualStyleBackColor = true;
            inject_eberry.Click += Inject_eberryClick;
            // 
            // ecb_edit_but
            // 
            ecb_edit_but.Location = new Point(176, 101);
            ecb_edit_but.Margin = new Padding(4, 4, 4, 4);
            ecb_edit_but.Name = "ecb_edit_but";
            ecb_edit_but.Size = new Size(100, 26);
            ecb_edit_but.TabIndex = 26;
            ecb_edit_but.Text = "ECB Editor";
            ecb_edit_but.UseVisualStyleBackColor = true;
            ecb_edit_but.Click += Ecb_edit_butClick;
            // 
            // tvswarm_but
            // 
            tvswarm_but.Enabled = false;
            tvswarm_but.Location = new Point(8, 56);
            tvswarm_but.Margin = new Padding(4, 4, 4, 4);
            tvswarm_but.Name = "tvswarm_but";
            tvswarm_but.Size = new Size(160, 26);
            tvswarm_but.TabIndex = 27;
            tvswarm_but.Text = "TV and Swarm";
            tvswarm_but.UseVisualStyleBackColor = true;
            tvswarm_but.Click += Tvswarm_butClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(wcn_edit_but);
            groupBox1.Controls.Add(inject_wcn);
            groupBox1.Controls.Add(export_wcn);
            groupBox1.Controls.Add(export_wc3but);
            groupBox1.Controls.Add(inject_wc3_but);
            groupBox1.Controls.Add(wc3_editor_but);
            groupBox1.Location = new Point(16, 106);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(292, 157);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mystery Gift";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(export_me3_but);
            groupBox2.Controls.Add(inject_me3_but);
            groupBox2.Controls.Add(me3_editor_but);
            groupBox2.Controls.Add(eon_em_but);
            groupBox2.Location = new Point(317, 106);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(287, 157);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mystery Event";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ecb_edit_but);
            groupBox3.Controls.Add(inject_eberry);
            groupBox3.Controls.Add(export_eberry);
            groupBox3.Controls.Add(inject_ect_but);
            groupBox3.Controls.Add(export_ect_but);
            groupBox3.Controls.Add(ect_edit_but);
            groupBox3.Location = new Point(612, 106);
            groupBox3.Margin = new Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(289, 157);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "e-Trainer and e-Berry";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tvswarm_but);
            groupBox4.Controls.Add(decor_but);
            groupBox4.Location = new Point(16, 270);
            groupBox4.Margin = new Padding(4, 4, 4, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 4, 4, 4);
            groupBox4.Size = new Size(188, 92);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            groupBox4.Text = "Other";
            // 
            // events_distro_but
            // 
            events_distro_but.Location = new Point(645, 292);
            events_distro_but.Margin = new Padding(4, 4, 4, 4);
            events_distro_but.Name = "events_distro_but";
            events_distro_but.Size = new Size(243, 58);
            events_distro_but.TabIndex = 32;
            events_distro_but.Text = "Official Event Distributor";
            events_distro_but.UseVisualStyleBackColor = true;
            events_distro_but.Click += Events_distro_butClick;
            // 
            // MainScreen
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 379);
            Controls.Add(events_distro_but);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(region_lab);
            Controls.Add(language_box);
            Controls.Add(game_box);
            Controls.Add(region_but);
            Controls.Add(sav3_path);
            Controls.Add(load_save_but);
            Controls.Add(menuStrip1);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mystery Gift Tool";
            DragDrop += MainScreenDragDrop;
            DragEnter += MainScreenDragEnter;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
