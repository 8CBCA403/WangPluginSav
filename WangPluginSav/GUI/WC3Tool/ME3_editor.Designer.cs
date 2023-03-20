using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
   partial class ME3_editor
    {
        private System.ComponentModel.IContainer components = null;
        private Button load_me3_but;

        private Button save_me3_but;

        private TextBox me3_path;

        private Button export_script_but;

        private Button import_script_but;

        private Label label1;

        private Label label2;

        private Label label3;

        private ComboBox itembox;

        private NumericUpDown amountbox;

        private NumericUpDown counterbox;

        private CheckBox custom_script;

        private Button removescript_but;

        private CheckBox script_check;

        private GroupBox groupBox1;

        private RadioButton radio_E;

        private RadioButton radio_RS;

        private NumericUpDown map_bank;

        private NumericUpDown map_num;

        private NumericUpDown map_npc;

        private Label label4;

        private Label label5;

        private Label label6;

        private GroupBox groupBox2;

        private Button help_npc;

        private Button counter_help;

        private Button amount_help;

        private Button item_help;

        private Button xse_help;

        private Button xse_import;

        private Button xse_export;
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
            this.load_me3_but = new System.Windows.Forms.Button();
            this.save_me3_but = new System.Windows.Forms.Button();
            this.me3_path = new System.Windows.Forms.TextBox();
            this.export_script_but = new System.Windows.Forms.Button();
            this.import_script_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itembox = new System.Windows.Forms.ComboBox();
            this.amountbox = new System.Windows.Forms.NumericUpDown();
            this.counterbox = new System.Windows.Forms.NumericUpDown();
            this.custom_script = new System.Windows.Forms.CheckBox();
            this.script_check = new System.Windows.Forms.CheckBox();
            this.removescript_but = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_E = new System.Windows.Forms.RadioButton();
            this.radio_RS = new System.Windows.Forms.RadioButton();
            this.map_bank = new System.Windows.Forms.NumericUpDown();
            this.map_num = new System.Windows.Forms.NumericUpDown();
            this.map_npc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.help_npc = new System.Windows.Forms.Button();
            this.counter_help = new System.Windows.Forms.Button();
            this.amount_help = new System.Windows.Forms.Button();
            this.item_help = new System.Windows.Forms.Button();
            this.xse_help = new System.Windows.Forms.Button();
            this.xse_import = new System.Windows.Forms.Button();
            this.xse_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.amountbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.counterbox).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.map_bank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.map_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.map_npc).BeginInit();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.load_me3_but.Location = new System.Drawing.Point(12, 12);
            this.load_me3_but.Name = "load_me3_but";
            this.load_me3_but.Size = new System.Drawing.Size(75, 23);
            this.load_me3_but.TabIndex = 0;
            this.load_me3_but.Text = "Load ME3";
            this.load_me3_but.UseVisualStyleBackColor = true;
            this.load_me3_but.Click += new System.EventHandler(Load_me3_butClick);
            this.save_me3_but.Enabled = false;
            this.save_me3_but.Location = new System.Drawing.Point(93, 12);
            this.save_me3_but.Name = "save_me3_but";
            this.save_me3_but.Size = new System.Drawing.Size(75, 23);
            this.save_me3_but.TabIndex = 1;
            this.save_me3_but.Text = "Save ME3";
            this.save_me3_but.UseVisualStyleBackColor = true;
            this.save_me3_but.Click += new System.EventHandler(Save_me3_butClick);
            this.me3_path.Location = new System.Drawing.Point(12, 41);
            this.me3_path.Name = "me3_path";
            this.me3_path.ReadOnly = true;
            this.me3_path.Size = new System.Drawing.Size(309, 20);
            this.me3_path.TabIndex = 2;
            this.export_script_but.Enabled = false;
            this.export_script_but.Location = new System.Drawing.Point(12, 213);
            this.export_script_but.Name = "export_script_but";
            this.export_script_but.Size = new System.Drawing.Size(75, 23);
            this.export_script_but.TabIndex = 3;
            this.export_script_but.Text = "Export Script";
            this.export_script_but.UseVisualStyleBackColor = true;
            this.export_script_but.Click += new System.EventHandler(Export_script_butClick);
            this.import_script_but.Enabled = false;
            this.import_script_but.Location = new System.Drawing.Point(93, 213);
            this.import_script_but.Name = "import_script_but";
            this.import_script_but.Size = new System.Drawing.Size(75, 23);
            this.import_script_but.TabIndex = 4;
            this.import_script_but.Text = "Import Script";
            this.import_script_but.UseVisualStyleBackColor = true;
            this.import_script_but.Click += new System.EventHandler(Import_script_butClick);
            this.label1.Location = new System.Drawing.Point(26, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item";
            this.label2.Location = new System.Drawing.Point(26, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total amount ?";
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Distribution counter";
            this.itembox.FormattingEnabled = true;
            this.itembox.Items.AddRange(new object[377]
            {
            "Nothing", "Master Ball", "Ultra Ball", "Great Ball", "Poké Ball", "Safari Ball", "Net Ball", "Dive Ball", "Nest Ball", "Repeat Ball",
            "Timer Ball", "Luxury Ball", "Premier Ball", "Potion", "Antidote", "Burn Heal", "Ice Heal", "Awakening", "Parlyz Heal", "Full Restore",
            "Max Potion", "Hyper Potion", "Super Potion", "Full Heal", "Revive", "Max Revive", "Fresh Water", "Soda Pop", "Lemonade", "Moomoo Milk",
            "EnergyPowder", "Energy Root", "Heal Powder", "Revival Herb", "Ether", "Max Ether", "Elixir", "Max Elixir", "Lava Cookie", "Blue Flute",
            "Yellow Flute", "Red Flute", "Black Flute", "White Flute", "Berry Juice", "Sacred Ash", "Shoal Salt", "Shoal Shell", "Red Shard", "Blue Shard",
            "Yellow Shard", "Green Shard", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown",
            "unknown", "unknown", "unknown", "HP Up", "Protein", "Iron", "Carbos", "Calcium", "Rare Candy", "PP Up",
            "Zinc", "PP Max", "unknown", "Guard Spec.", "Dire Hit", "X Attack", "X Defend", "X Speed", "X Accuracy", "X Special",
            "Poké Doll", "Fluffy Tail", "unknown", "Super Repel", "Max Repel", "Escape Rope", "Repel", "unknown", "unknown", "unknown",
            "unknown", "unknown", "unknown", "Sun Stone", "Moon Stone", "Fire Stone", "Thunder Stone", "Water Stone", "Leaf Stone", "unknown",
            "unknown", "unknown", "unknown", "TinyMushroom", "Big Mushroom", "unknown", "Pearl", "Big Pearl", "Stardust", "Star Piece",
            "Nugget", "Heart Scale", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown",
            "unknown", "Orange Mail", "Harbor Mail", "Glitter Mail", "Mech Mail", "Wood Mail", "Wave Mail", "Bead Mail", "Shadow Mail", "Tropic Mail",
            "Dream Mail", "Fab Mail", "Retro Mail", "Cheri Berry", "Chesto Berry", "Pecha Berry", "Rawst Berry", "Aspear Berry", "Leppa Berry", "Oran Berry",
            "Persim Berry", "Lum Berry", "Sitrus Berry", "Figy Berry", "Wiki Berry", "Mago Berry", "Aguav Berry", "Iapapa Berry", "Razz Berry", "Bluk Berry",
            "Nanab Berry", "Wepear Berry", "Pinap Berry", "Pomeg Berry", "Kelpsy Berry", "Qualot Berry", "Hondew Berry", "Grepa Berry", "Tamato Berry", "Cornn Berry",
            "Magost Berry", "Rabuta Berry", "Nomel Berry", "Spelon Berry", "Pamtre Berry", "Watmel Berry", "Durin Berry", "Belue Berry", "Liechi Berry", "Ganlon Berry",
            "Salac Berry", "Petaya Berry", "Apicot Berry", "Lansat Berry", "Starf Berry", "Enigma Berry", "unknown", "unknown", "unknown", "BrightPowder",
            "White Herb", "Macho Brace", "Exp. Share", "Quick Claw", "Soothe Bell", "Mental Herb", "Choice Band", "King's Rock", "SilverPowder", "Amulet Coin",
            "Cleanse Tag", "Soul Dew", "DeepSeaTooth", "DeepSeaScale", "Smoke Ball", "Everstone", "Focus Band", "Lucky Egg", "Scope Lens", "Metal Coat",
            "Leftovers", "Dragon Scale", "Light Ball", "Soft Sand", "Hard Stone", "Miracle Seed", "BlackGlasses", "Black Belt", "Magnet", "Mystic Water",
            "Sharp Beak", "Poison Barb", "NeverMeltIce", "Spell Tag", "TwistedSpoon", "Charcoal", "Dragon Fang", "Silk Scarf", "Up-Grade", "Shell Bell",
            "Sea Incense", "Lax Incense", "Lucky Punch", "Metal Powder", "Thick Club", "Stick", "unknown", "unknown", "unknown", "unknown",
            "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown",
            "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown", "unknown",
            "unknown", "unknown", "unknown", "unknown", "Red Scarf", "Blue Scarf", "Pink Scarf", "Green Scarf", "Yellow Scarf", "Mach Bike",
            "Coin Case", "Itemfinder", "Old Rod", "Good Rod", "Super Rod", "S.S. Ticket", "Contest Pass", "unknown", "Wailmer Pail", "Devon Goods",
            "Soot Sack", "Basement Key", "Acro Bike", "Pokéblock Case", "Letter", "Eon Ticket", "Red Orb", "Blue Orb", "Scanner", "Go-Goggles",
            "Meteorite", "Rm. 1 Key", "Rm. 2 Key", "Rm. 4 Key", "Rm. 6 Key", "Storage Key", "Root Fossil", "Claw Fossil", "Devon Scope", "TM01",
            "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11",
            "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21",
            "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31",
            "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41",
            "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "HM01",
            "HM02", "HM03", "HM04", "HM05", "HM06", "HM07", "HM08", "unknown", "unknown", "Oak's Parcel* (Emerald only)",
            "Poké Flute* (Emerald only)", "Secret Key* (Emerald only)", "Bike Voucher* (Emerald only)", "Gold Teeth* (Emerald only)", "Old Amber* (Emerald only)", "Card Key* (Emerald only)", "Lift Key* (Emerald only)", "Helix Fossil* (Emerald only)", "Dome Fossil* (Emerald only)", "Silph Scope* (Emerald only)",
            "Bicycle* (Emerald only)", "Town Map* (Emerald only)", "Vs. Seeker* (Emerald only)", "Fame Checker* (Emerald only)", "TM Case* (Emerald only)", "Berry Pouch* (Emerald only)", "Teachy TV* (Emerald only)", "Tri-Pass* (Emerald only)", "Rainbow Pass* (Emerald only)", "Tea* (Emerald only)",
            "MysticTicket* (Emerald only)", "AuroraTicket* (Emerald only)", "Powder Jar* (Emerald only)", "Ruby* (Emerald only)", "Sapphire* (Emerald only)", "Magma Emblem* (Emerald only)", "Old Sea Map* (Emerald only)"
            });
            this.itembox.Location = new System.Drawing.Point(132, 85);
            this.itembox.Name = "itembox";
            this.itembox.Size = new System.Drawing.Size(189, 21);
            this.itembox.TabIndex = 8;
            this.itembox.SelectedIndexChanged += new System.EventHandler(ItemboxSelectedIndexChanged);
            this.amountbox.Location = new System.Drawing.Point(132, 112);
            this.amountbox.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(189, 20);
            this.amountbox.TabIndex = 9;
            this.counterbox.Location = new System.Drawing.Point(132, 138);
            this.counterbox.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.counterbox.Name = "counterbox";
            this.counterbox.Size = new System.Drawing.Size(189, 20);
            this.counterbox.TabIndex = 10;
            this.counterbox.ValueChanged += new System.EventHandler(CounterboxValueChanged);
            this.custom_script.AutoCheck = false;
            this.custom_script.Location = new System.Drawing.Point(204, 213);
            this.custom_script.Name = "custom_script";
            this.custom_script.Size = new System.Drawing.Size(104, 24);
            this.custom_script.TabIndex = 11;
            this.custom_script.Text = "Custom Script";
            this.custom_script.UseVisualStyleBackColor = true;
            this.script_check.AutoCheck = false;
            this.script_check.Location = new System.Drawing.Point(204, 183);
            this.script_check.Name = "script_check";
            this.script_check.Size = new System.Drawing.Size(104, 24);
            this.script_check.TabIndex = 12;
            this.script_check.Text = "Script present";
            this.script_check.UseVisualStyleBackColor = true;
            this.removescript_but.Enabled = false;
            this.removescript_but.Location = new System.Drawing.Point(33, 184);
            this.removescript_but.Name = "removescript_but";
            this.removescript_but.Size = new System.Drawing.Size(114, 23);
            this.removescript_but.TabIndex = 13;
            this.removescript_but.Text = "Remove script";
            this.removescript_but.UseVisualStyleBackColor = true;
            this.removescript_but.Click += new System.EventHandler(Removescript_butClick);
            this.groupBox1.Controls.Add(this.radio_E);
            this.groupBox1.Controls.Add(this.radio_RS);
            this.groupBox1.Location = new System.Drawing.Point(20, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 93);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            this.radio_E.Location = new System.Drawing.Point(6, 54);
            this.radio_E.Name = "radio_E";
            this.radio_E.Size = new System.Drawing.Size(104, 24);
            this.radio_E.TabIndex = 1;
            this.radio_E.TabStop = true;
            this.radio_E.Text = "Emerald";
            this.radio_E.UseVisualStyleBackColor = true;
            this.radio_RS.Location = new System.Drawing.Point(6, 24);
            this.radio_RS.Name = "radio_RS";
            this.radio_RS.Size = new System.Drawing.Size(104, 24);
            this.radio_RS.TabIndex = 0;
            this.radio_RS.TabStop = true;
            this.radio_RS.Text = "Ruby / Sapphire";
            this.radio_RS.UseVisualStyleBackColor = true;
            this.map_bank.Location = new System.Drawing.Point(82, 14);
            this.map_bank.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.map_bank.Name = "map_bank";
            this.map_bank.Size = new System.Drawing.Size(71, 20);
            this.map_bank.TabIndex = 15;
            this.map_num.Location = new System.Drawing.Point(82, 40);
            this.map_num.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.map_num.Name = "map_num";
            this.map_num.Size = new System.Drawing.Size(71, 20);
            this.map_num.TabIndex = 16;
            this.map_npc.Location = new System.Drawing.Point(82, 66);
            this.map_npc.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.map_npc.Name = "map_npc";
            this.map_npc.Size = new System.Drawing.Size(71, 20);
            this.map_npc.TabIndex = 17;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Map Bank";
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Map #";
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Map NPC";
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.map_bank);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.map_num);
            this.groupBox2.Controls.Add(this.map_npc);
            this.groupBox2.Location = new System.Drawing.Point(155, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 93);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Script NPC";
            this.help_npc.Location = new System.Drawing.Point(327, 283);
            this.help_npc.Name = "help_npc";
            this.help_npc.Size = new System.Drawing.Size(17, 21);
            this.help_npc.TabIndex = 22;
            this.help_npc.Text = "?";
            this.help_npc.UseVisualStyleBackColor = true;
            this.help_npc.Click += new System.EventHandler(Help_npcClick);
            this.counter_help.Location = new System.Drawing.Point(327, 136);
            this.counter_help.Name = "counter_help";
            this.counter_help.Size = new System.Drawing.Size(17, 21);
            this.counter_help.TabIndex = 23;
            this.counter_help.Text = "?";
            this.counter_help.UseVisualStyleBackColor = true;
            this.counter_help.Click += new System.EventHandler(Counter_helpClick);
            this.amount_help.Location = new System.Drawing.Point(327, 110);
            this.amount_help.Name = "amount_help";
            this.amount_help.Size = new System.Drawing.Size(17, 21);
            this.amount_help.TabIndex = 24;
            this.amount_help.Text = "?";
            this.amount_help.UseVisualStyleBackColor = true;
            this.amount_help.Click += new System.EventHandler(Amount_helpClick);
            this.item_help.Location = new System.Drawing.Point(327, 84);
            this.item_help.Name = "item_help";
            this.item_help.Size = new System.Drawing.Size(17, 21);
            this.item_help.TabIndex = 25;
            this.item_help.Text = "?";
            this.item_help.UseVisualStyleBackColor = true;
            this.item_help.Click += new System.EventHandler(Item_helpClick);
            this.xse_help.Location = new System.Drawing.Point(174, 244);
            this.xse_help.Name = "xse_help";
            this.xse_help.Size = new System.Drawing.Size(21, 22);
            this.xse_help.TabIndex = 35;
            this.xse_help.Text = "?";
            this.xse_help.UseVisualStyleBackColor = true;
            this.xse_help.Click += new System.EventHandler(Xse_helpClick);
            this.xse_import.Location = new System.Drawing.Point(93, 242);
            this.xse_import.Name = "xse_import";
            this.xse_import.Size = new System.Drawing.Size(75, 23);
            this.xse_import.TabIndex = 37;
            this.xse_import.Text = "XSE Import";
            this.xse_import.UseVisualStyleBackColor = true;
            this.xse_import.Click += new System.EventHandler(Xse_importClick);
            this.xse_export.Location = new System.Drawing.Point(12, 242);
            this.xse_export.Name = "xse_export";
            this.xse_export.Size = new System.Drawing.Size(75, 23);
            this.xse_export.TabIndex = 36;
            this.xse_export.Text = "XSE Export";
            this.xse_export.UseVisualStyleBackColor = true;
            this.xse_export.Click += new System.EventHandler(Xse_exportClick);
            this.AllowDrop = true;
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(354, 371);
            base.Controls.Add(this.xse_help);
            base.Controls.Add(this.xse_import);
            base.Controls.Add(this.xse_export);
            base.Controls.Add(this.item_help);
            base.Controls.Add(this.amount_help);
            base.Controls.Add(this.counter_help);
            base.Controls.Add(this.help_npc);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.removescript_but);
            base.Controls.Add(this.script_check);
            base.Controls.Add(this.custom_script);
            base.Controls.Add(this.counterbox);
            base.Controls.Add(this.amountbox);
            base.Controls.Add(this.itembox);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.import_script_but);
            base.Controls.Add(this.export_script_but);
            base.Controls.Add(this.me3_path);
            base.Controls.Add(this.save_me3_but);
            base.Controls.Add(this.load_me3_but);
            base.Name = "ME3_editor";
            this.Text = "ME3 Editor";
            base.DragDrop += new System.Windows.Forms.DragEventHandler(ME3_editorDragDrop);
            base.DragEnter += new System.Windows.Forms.DragEventHandler(ME3_editorDragEnter);
            ((System.ComponentModel.ISupportInitialize)this.amountbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.counterbox).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.map_bank).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.map_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.map_npc).EndInit();
            this.groupBox2.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}
