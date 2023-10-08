namespace WangPluginSav
{
    partial class WorldEventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldEventsForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            WonderCard_BTN = new Button();
            CurryDex_BTN = new Button();
            groupBox5 = new GroupBox();
            main_gift_gcharmander_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            main_gift_typenull_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            main_gift_toxel_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            groupBox4 = new GroupBox();
            main_eevee_save_data_CB = new CheckBox();
            main_letsgo_forcelegal_CB = new CheckBox();
            main_geevee_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            main_pikachu_save_data_CB = new CheckBox();
            main_gpikachu_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            armor_gift_squirtle_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            armor_gift_bulbasaur_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            tabPage3 = new TabPage();
            SOJForm_BTN = new Button();
            RegiForm_BTN = new Button();
            Dynamax_BTN = new Button();
            ct_gift_poipole_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            groupBox3 = new GroupBox();
            ct_spiritomb_forcelegal_CB = new CheckBox();
            label1 = new Label();
            ct_spiritomb_players_NUD = new NumericUpDown();
            ct_spiritomb_visible_CB = new CheckBox();
            ct_spiritomb_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            groupBox1 = new GroupBox();
            ct_gmoltres_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            ct_birds_uncaughtBTN = new Button();
            ct_birds_caughtBTN = new Button();
            ct_gzapdos_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            ct_garticuno_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            ct_giftcosmog_PB = new GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC();
            toolStrip1 = new ToolStrip();
            ts_applyBTN = new ToolStripButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ct_spiritomb_players_NUD).BeginInit();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 25);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(867, 397);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(WonderCard_BTN);
            tabPage1.Controls.Add(CurryDex_BTN);
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(main_gift_toxel_PB);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(859, 368);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "主游戏";
            // 
            // WonderCard_BTN
            // 
            WonderCard_BTN.Location = new Point(585, 192);
            WonderCard_BTN.Margin = new Padding(3, 2, 3, 2);
            WonderCard_BTN.Name = "WonderCard_BTN";
            WonderCard_BTN.Size = new Size(154, 30);
            WonderCard_BTN.TabIndex = 27;
            WonderCard_BTN.Text = "神秘礼物转换器";
            WonderCard_BTN.UseVisualStyleBackColor = true;
            WonderCard_BTN.Click += WonderCard_BTN_Click;
            // 
            // CurryDex_BTN
            // 
            CurryDex_BTN.Location = new Point(585, 142);
            CurryDex_BTN.Margin = new Padding(3, 2, 3, 2);
            CurryDex_BTN.Name = "CurryDex_BTN";
            CurryDex_BTN.Size = new Size(155, 30);
            CurryDex_BTN.TabIndex = 26;
            CurryDex_BTN.Text = "咖喱图鉴";
            CurryDex_BTN.UseVisualStyleBackColor = true;
            CurryDex_BTN.Click += CurryDex_BTN_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(main_gift_gcharmander_PB);
            groupBox5.Controls.Add(main_gift_typenull_PB);
            groupBox5.Location = new Point(363, 7);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(212, 264);
            groupBox5.TabIndex = 25;
            groupBox5.TabStop = false;
            groupBox5.Text = "冠军礼物";
            // 
            // main_gift_gcharmander_PB
            // 
            main_gift_gcharmander_PB.Caught = false;
            main_gift_gcharmander_PB.DrawDynaxMaxIcon = true;
            main_gift_gcharmander_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            main_gift_gcharmander_PB.Location = new Point(8, 22);
            main_gift_gcharmander_PB.Margin = new Padding(5, 6, 5, 6);
            main_gift_gcharmander_PB.MaximumSize = new Size(180, 83);
            main_gift_gcharmander_PB.MinimumSize = new Size(180, 83);
            main_gift_gcharmander_PB.Name = "main_gift_gcharmander_PB";
            main_gift_gcharmander_PB.Pokemon = 4;
            main_gift_gcharmander_PB.PokemonName = "超极巨小火龙礼物";
            main_gift_gcharmander_PB.PokemonSubform = "";
            main_gift_gcharmander_PB.Size = new Size(180, 83);
            main_gift_gcharmander_PB.TabIndex = 21;
            main_gift_gcharmander_PB.ToolTip = "Player must be champion";
            // 
            // main_gift_typenull_PB
            // 
            main_gift_typenull_PB.Caught = false;
            main_gift_typenull_PB.DrawDynaxMaxIcon = false;
            main_gift_typenull_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            main_gift_typenull_PB.Location = new Point(8, 112);
            main_gift_typenull_PB.Margin = new Padding(5, 6, 5, 6);
            main_gift_typenull_PB.MaximumSize = new Size(173, 83);
            main_gift_typenull_PB.MinimumSize = new Size(173, 83);
            main_gift_typenull_PB.Name = "main_gift_typenull_PB";
            main_gift_typenull_PB.Pokemon = 772;
            main_gift_typenull_PB.PokemonName = "属性：空礼物";
            main_gift_typenull_PB.PokemonSubform = "";
            main_gift_typenull_PB.Size = new Size(173, 83);
            main_gift_typenull_PB.TabIndex = 23;
            main_gift_typenull_PB.ToolTip = "Player must be champion";
            // 
            // main_gift_toxel_PB
            // 
            main_gift_toxel_PB.Caught = false;
            main_gift_toxel_PB.DrawDynaxMaxIcon = false;
            main_gift_toxel_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            main_gift_toxel_PB.Location = new Point(585, 10);
            main_gift_toxel_PB.Margin = new Padding(5, 6, 5, 6);
            main_gift_toxel_PB.MaximumSize = new Size(173, 83);
            main_gift_toxel_PB.MinimumSize = new Size(173, 83);
            main_gift_toxel_PB.Name = "main_gift_toxel_PB";
            main_gift_toxel_PB.Pokemon = 848;
            main_gift_toxel_PB.PokemonName = "毒电婴礼物";
            main_gift_toxel_PB.PokemonSubform = "";
            main_gift_toxel_PB.Size = new Size(173, 83);
            main_gift_toxel_PB.TabIndex = 24;
            main_gift_toxel_PB.ToolTip = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(main_eevee_save_data_CB);
            groupBox4.Controls.Add(main_letsgo_forcelegal_CB);
            groupBox4.Controls.Add(main_geevee_PB);
            groupBox4.Controls.Add(main_pikachu_save_data_CB);
            groupBox4.Controls.Add(main_gpikachu_PB);
            groupBox4.Location = new Point(11, 7);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(344, 264);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Let's Go 礼物";
            // 
            // main_eevee_save_data_CB
            // 
            main_eevee_save_data_CB.AutoSize = true;
            main_eevee_save_data_CB.Location = new Point(100, 176);
            main_eevee_save_data_CB.Margin = new Padding(4);
            main_eevee_save_data_CB.Name = "main_eevee_save_data_CB";
            main_eevee_save_data_CB.Size = new Size(189, 19);
            main_eevee_save_data_CB.TabIndex = 17;
            main_eevee_save_data_CB.Text = "Let's Go伊布保存数据";
            main_eevee_save_data_CB.UseVisualStyleBackColor = true;
            main_eevee_save_data_CB.CheckedChanged += main_eevee_save_data_CB_CheckedChanged;
            // 
            // main_letsgo_forcelegal_CB
            // 
            main_letsgo_forcelegal_CB.AutoSize = true;
            main_letsgo_forcelegal_CB.Location = new Point(8, 237);
            main_letsgo_forcelegal_CB.Margin = new Padding(4);
            main_letsgo_forcelegal_CB.Name = "main_letsgo_forcelegal_CB";
            main_letsgo_forcelegal_CB.Size = new Size(125, 19);
            main_letsgo_forcelegal_CB.TabIndex = 18;
            main_letsgo_forcelegal_CB.Text = "显示合法纠正";
            main_letsgo_forcelegal_CB.UseVisualStyleBackColor = true;
            main_letsgo_forcelegal_CB.CheckedChanged += main_letsgo_forcelegal_CB_CheckedChanged;
            // 
            // main_geevee_PB
            // 
            main_geevee_PB.Caught = false;
            main_geevee_PB.DrawDynaxMaxIcon = false;
            main_geevee_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            main_geevee_PB.Location = new Point(8, 112);
            main_geevee_PB.Margin = new Padding(5, 6, 5, 6);
            main_geevee_PB.MaximumSize = new Size(173, 83);
            main_geevee_PB.MinimumSize = new Size(173, 83);
            main_geevee_PB.Name = "main_geevee_PB";
            main_geevee_PB.Pokemon = 133;
            main_geevee_PB.PokemonName = "超极巨伊布礼物";
            main_geevee_PB.PokemonSubform = "0";
            main_geevee_PB.Size = new Size(173, 83);
            main_geevee_PB.TabIndex = 15;
            main_geevee_PB.ToolTip = "";
            main_geevee_PB.LegaliltyCheck_OnClick += main_geevee_PB_LegaliltyCheck_OnClick;
            main_geevee_PB.Caught_OnClick += main_geevee_PB_Caught_OnClick;
            // 
            // main_pikachu_save_data_CB
            // 
            main_pikachu_save_data_CB.AutoSize = true;
            main_pikachu_save_data_CB.Location = new Point(100, 86);
            main_pikachu_save_data_CB.Margin = new Padding(4);
            main_pikachu_save_data_CB.Name = "main_pikachu_save_data_CB";
            main_pikachu_save_data_CB.Size = new Size(205, 19);
            main_pikachu_save_data_CB.TabIndex = 16;
            main_pikachu_save_data_CB.Text = "Let's Go皮卡丘保存数据";
            main_pikachu_save_data_CB.UseVisualStyleBackColor = true;
            main_pikachu_save_data_CB.CheckedChanged += main_pikachu_save_data_CB_CheckedChanged;
            // 
            // main_gpikachu_PB
            // 
            main_gpikachu_PB.Caught = false;
            main_gpikachu_PB.DrawDynaxMaxIcon = false;
            main_gpikachu_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            main_gpikachu_PB.Location = new Point(8, 22);
            main_gpikachu_PB.Margin = new Padding(5, 6, 5, 6);
            main_gpikachu_PB.MaximumSize = new Size(173, 83);
            main_gpikachu_PB.MinimumSize = new Size(173, 83);
            main_gpikachu_PB.Name = "main_gpikachu_PB";
            main_gpikachu_PB.Pokemon = 25;
            main_gpikachu_PB.PokemonName = "超极巨皮卡丘礼物";
            main_gpikachu_PB.PokemonSubform = "0";
            main_gpikachu_PB.Size = new Size(173, 83);
            main_gpikachu_PB.TabIndex = 14;
            main_gpikachu_PB.ToolTip = "";
            main_gpikachu_PB.LegaliltyCheck_OnClick += main_gpikachu_PB_LegaliltyCheck_OnClick;
            main_gpikachu_PB.Caught_OnClick += main_gpikachu_PB_Caught_OnClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(859, 364);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "铠之孤岛";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(armor_gift_squirtle_PB);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(armor_gift_bulbasaur_PB);
            groupBox2.Location = new Point(11, 7);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(360, 283);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "武馆";
            // 
            // armor_gift_squirtle_PB
            // 
            armor_gift_squirtle_PB.Caught = false;
            armor_gift_squirtle_PB.DrawDynaxMaxIcon = true;
            armor_gift_squirtle_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal;
            armor_gift_squirtle_PB.Location = new Point(8, 143);
            armor_gift_squirtle_PB.Margin = new Padding(5, 6, 5, 6);
            armor_gift_squirtle_PB.MaximumSize = new Size(173, 83);
            armor_gift_squirtle_PB.MinimumSize = new Size(173, 83);
            armor_gift_squirtle_PB.Name = "armor_gift_squirtle_PB";
            armor_gift_squirtle_PB.Pokemon = 7;
            armor_gift_squirtle_PB.PokemonName = "超级巨杰尼龟礼物";
            armor_gift_squirtle_PB.PokemonSubform = "";
            armor_gift_squirtle_PB.Size = new Size(173, 83);
            armor_gift_squirtle_PB.TabIndex = 24;
            armor_gift_squirtle_PB.ToolTip = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 11;
            label2.Text = "瓦特捐赠";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(193, 40);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(148, 25);
            numericUpDown1.TabIndex = 12;
            // 
            // armor_gift_bulbasaur_PB
            // 
            armor_gift_bulbasaur_PB.Caught = false;
            armor_gift_bulbasaur_PB.DrawDynaxMaxIcon = true;
            armor_gift_bulbasaur_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Illegal;
            armor_gift_bulbasaur_PB.Location = new Point(8, 22);
            armor_gift_bulbasaur_PB.Margin = new Padding(5, 6, 5, 6);
            armor_gift_bulbasaur_PB.MaximumSize = new Size(173, 83);
            armor_gift_bulbasaur_PB.MinimumSize = new Size(173, 83);
            armor_gift_bulbasaur_PB.Name = "armor_gift_bulbasaur_PB";
            armor_gift_bulbasaur_PB.Pokemon = 1;
            armor_gift_bulbasaur_PB.PokemonName = "超极巨妙蛙种子礼物";
            armor_gift_bulbasaur_PB.PokemonSubform = "";
            armor_gift_bulbasaur_PB.Size = new Size(173, 83);
            armor_gift_bulbasaur_PB.TabIndex = 23;
            armor_gift_bulbasaur_PB.ToolTip = "";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            tabPage3.Controls.Add(SOJForm_BTN);
            tabPage3.Controls.Add(RegiForm_BTN);
            tabPage3.Controls.Add(Dynamax_BTN);
            tabPage3.Controls.Add(ct_gift_poipole_PB);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(ct_giftcosmog_PB);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(859, 364);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "王冠雪原";
            // 
            // SOJForm_BTN
            // 
            SOJForm_BTN.Location = new Point(347, 304);
            SOJForm_BTN.Margin = new Padding(3, 2, 3, 2);
            SOJForm_BTN.Name = "SOJForm_BTN";
            SOJForm_BTN.Size = new Size(125, 30);
            SOJForm_BTN.TabIndex = 29;
            SOJForm_BTN.Text = "四剑客图鉴";
            SOJForm_BTN.UseVisualStyleBackColor = true;
            SOJForm_BTN.Click += SOJForm_BTN_Click;
            // 
            // RegiForm_BTN
            // 
            RegiForm_BTN.Location = new Point(496, 253);
            RegiForm_BTN.Margin = new Padding(3, 2, 3, 2);
            RegiForm_BTN.Name = "RegiForm_BTN";
            RegiForm_BTN.Size = new Size(118, 30);
            RegiForm_BTN.TabIndex = 28;
            RegiForm_BTN.Text = "雷吉家族图鉴";
            RegiForm_BTN.UseVisualStyleBackColor = true;
            RegiForm_BTN.Click += RegiForm_BTN_Click;
            // 
            // Dynamax_BTN
            // 
            Dynamax_BTN.Location = new Point(347, 253);
            Dynamax_BTN.Margin = new Padding(3, 2, 3, 2);
            Dynamax_BTN.Name = "Dynamax_BTN";
            Dynamax_BTN.Size = new Size(125, 30);
            Dynamax_BTN.TabIndex = 27;
            Dynamax_BTN.Text = "大冒险图鉴";
            Dynamax_BTN.UseVisualStyleBackColor = true;
            Dynamax_BTN.Click += Dynamax_BTN_Click;
            // 
            // ct_gift_poipole_PB
            // 
            ct_gift_poipole_PB.Caught = false;
            ct_gift_poipole_PB.DrawDynaxMaxIcon = false;
            ct_gift_poipole_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            ct_gift_poipole_PB.Location = new Point(623, 114);
            ct_gift_poipole_PB.Margin = new Padding(5, 6, 5, 6);
            ct_gift_poipole_PB.MaximumSize = new Size(173, 83);
            ct_gift_poipole_PB.MinimumSize = new Size(173, 83);
            ct_gift_poipole_PB.Name = "ct_gift_poipole_PB";
            ct_gift_poipole_PB.Pokemon = 803;
            ct_gift_poipole_PB.PokemonName = "毒贝比礼物";
            ct_gift_poipole_PB.PokemonSubform = "";
            ct_gift_poipole_PB.Size = new Size(173, 83);
            ct_gift_poipole_PB.TabIndex = 10;
            ct_gift_poipole_PB.ToolTip = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ct_spiritomb_forcelegal_CB);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(ct_spiritomb_players_NUD);
            groupBox3.Controls.Add(ct_spiritomb_visible_CB);
            groupBox3.Controls.Add(ct_spiritomb_PB);
            groupBox3.Location = new Point(348, 7);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(267, 223);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "花岩怪参数";
            // 
            // ct_spiritomb_forcelegal_CB
            // 
            ct_spiritomb_forcelegal_CB.AutoSize = true;
            ct_spiritomb_forcelegal_CB.Location = new Point(8, 184);
            ct_spiritomb_forcelegal_CB.Margin = new Padding(4);
            ct_spiritomb_forcelegal_CB.Name = "ct_spiritomb_forcelegal_CB";
            ct_spiritomb_forcelegal_CB.Size = new Size(141, 19);
            ct_spiritomb_forcelegal_CB.TabIndex = 10;
            ct_spiritomb_forcelegal_CB.Text = "显示合法性纠正";
            ct_spiritomb_forcelegal_CB.UseVisualStyleBackColor = true;
            ct_spiritomb_forcelegal_CB.CheckedChanged += ct_spiritomb_forcelegal_CB_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 136);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 10;
            label1.Text = "互动过的玩家";
            // 
            // ct_spiritomb_players_NUD
            // 
            ct_spiritomb_players_NUD.Location = new Point(8, 154);
            ct_spiritomb_players_NUD.Margin = new Padding(4);
            ct_spiritomb_players_NUD.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            ct_spiritomb_players_NUD.Name = "ct_spiritomb_players_NUD";
            ct_spiritomb_players_NUD.Size = new Size(148, 25);
            ct_spiritomb_players_NUD.TabIndex = 10;
            ct_spiritomb_players_NUD.ValueChanged += ct_spiritomb_players_NUD_ValueChanged;
            // 
            // ct_spiritomb_visible_CB
            // 
            ct_spiritomb_visible_CB.AutoSize = true;
            ct_spiritomb_visible_CB.Location = new Point(95, 84);
            ct_spiritomb_visible_CB.Margin = new Padding(4);
            ct_spiritomb_visible_CB.Name = "ct_spiritomb_visible_CB";
            ct_spiritomb_visible_CB.Size = new Size(61, 19);
            ct_spiritomb_visible_CB.TabIndex = 9;
            ct_spiritomb_visible_CB.Text = "可见";
            ct_spiritomb_visible_CB.UseVisualStyleBackColor = true;
            ct_spiritomb_visible_CB.CheckedChanged += ct_spiritomb_visible_CB_CheckedChanged;
            // 
            // ct_spiritomb_PB
            // 
            ct_spiritomb_PB.Caught = false;
            ct_spiritomb_PB.DrawDynaxMaxIcon = false;
            ct_spiritomb_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            ct_spiritomb_PB.Location = new Point(8, 22);
            ct_spiritomb_PB.Margin = new Padding(5, 6, 5, 6);
            ct_spiritomb_PB.MaximumSize = new Size(173, 83);
            ct_spiritomb_PB.MinimumSize = new Size(173, 83);
            ct_spiritomb_PB.Name = "ct_spiritomb_PB";
            ct_spiritomb_PB.Pokemon = 442;
            ct_spiritomb_PB.PokemonName = "花岩怪";
            ct_spiritomb_PB.PokemonSubform = "";
            ct_spiritomb_PB.Size = new Size(173, 83);
            ct_spiritomb_PB.TabIndex = 8;
            ct_spiritomb_PB.ToolTip = "";
            ct_spiritomb_PB.LegaliltyCheck_OnClick += ct_spiritomb_PB_LegaliltyCheck_OnClick;
            ct_spiritomb_PB.Caught_OnClick += ct_spiritomb_PB_Caught_OnClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ct_gmoltres_PB);
            groupBox1.Controls.Add(ct_birds_uncaughtBTN);
            groupBox1.Controls.Add(ct_birds_caughtBTN);
            groupBox1.Controls.Add(ct_gzapdos_PB);
            groupBox1.Controls.Add(ct_garticuno_PB);
            groupBox1.Location = new Point(11, 7);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(329, 327);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "伽勒尔三圣鸟";
            // 
            // ct_gmoltres_PB
            // 
            ct_gmoltres_PB.Caught = false;
            ct_gmoltres_PB.DrawDynaxMaxIcon = false;
            ct_gmoltres_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            ct_gmoltres_PB.Location = new Point(8, 202);
            ct_gmoltres_PB.Margin = new Padding(5, 6, 5, 6);
            ct_gmoltres_PB.MaximumSize = new Size(173, 83);
            ct_gmoltres_PB.MinimumSize = new Size(173, 83);
            ct_gmoltres_PB.Name = "ct_gmoltres_PB";
            ct_gmoltres_PB.Pokemon = 146;
            ct_gmoltres_PB.PokemonName = "伽勒尔火焰鸟";
            ct_gmoltres_PB.PokemonSubform = "0";
            ct_gmoltres_PB.Size = new Size(173, 83);
            ct_gmoltres_PB.TabIndex = 7;
            ct_gmoltres_PB.ToolTip = "";
            // 
            // ct_birds_uncaughtBTN
            // 
            ct_birds_uncaughtBTN.Location = new Point(189, 66);
            ct_birds_uncaughtBTN.Margin = new Padding(4);
            ct_birds_uncaughtBTN.Name = "ct_birds_uncaughtBTN";
            ct_birds_uncaughtBTN.Size = new Size(132, 37);
            ct_birds_uncaughtBTN.TabIndex = 6;
            ct_birds_uncaughtBTN.Text = "未全部捕获";
            ct_birds_uncaughtBTN.UseVisualStyleBackColor = true;
            ct_birds_uncaughtBTN.Click += ct_birds_uncaughtBTN_Click;
            // 
            // ct_birds_caughtBTN
            // 
            ct_birds_caughtBTN.Location = new Point(189, 22);
            ct_birds_caughtBTN.Margin = new Padding(4);
            ct_birds_caughtBTN.Name = "ct_birds_caughtBTN";
            ct_birds_caughtBTN.Size = new Size(132, 37);
            ct_birds_caughtBTN.TabIndex = 5;
            ct_birds_caughtBTN.Text = "全部捕获";
            ct_birds_caughtBTN.UseVisualStyleBackColor = true;
            ct_birds_caughtBTN.Click += ct_birds_caughtBTN_Click;
            // 
            // ct_gzapdos_PB
            // 
            ct_gzapdos_PB.Caught = false;
            ct_gzapdos_PB.DrawDynaxMaxIcon = false;
            ct_gzapdos_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            ct_gzapdos_PB.Location = new Point(8, 112);
            ct_gzapdos_PB.Margin = new Padding(5, 6, 5, 6);
            ct_gzapdos_PB.MaximumSize = new Size(173, 83);
            ct_gzapdos_PB.MinimumSize = new Size(173, 83);
            ct_gzapdos_PB.Name = "ct_gzapdos_PB";
            ct_gzapdos_PB.Pokemon = 145;
            ct_gzapdos_PB.PokemonName = "伽勒尔闪电鸟";
            ct_gzapdos_PB.PokemonSubform = "0";
            ct_gzapdos_PB.Size = new Size(173, 83);
            ct_gzapdos_PB.TabIndex = 6;
            ct_gzapdos_PB.ToolTip = "";
            // 
            // ct_garticuno_PB
            // 
            ct_garticuno_PB.Caught = false;
            ct_garticuno_PB.DrawDynaxMaxIcon = false;
            ct_garticuno_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            ct_garticuno_PB.Location = new Point(8, 22);
            ct_garticuno_PB.Margin = new Padding(5, 6, 5, 6);
            ct_garticuno_PB.MaximumSize = new Size(173, 83);
            ct_garticuno_PB.MinimumSize = new Size(173, 83);
            ct_garticuno_PB.Name = "ct_garticuno_PB";
            ct_garticuno_PB.Pokemon = 144;
            ct_garticuno_PB.PokemonName = "伽勒尔急冻鸟";
            ct_garticuno_PB.PokemonSubform = "0";
            ct_garticuno_PB.Size = new Size(173, 83);
            ct_garticuno_PB.TabIndex = 5;
            ct_garticuno_PB.ToolTip = "";
            // 
            // ct_giftcosmog_PB
            // 
            ct_giftcosmog_PB.Caught = false;
            ct_giftcosmog_PB.DrawDynaxMaxIcon = false;
            ct_giftcosmog_PB.Legalility = GUI.SWSHEventEditorGUI.Controls.PokemonRenderUC.LegalStatus.Legal;
            ct_giftcosmog_PB.Location = new Point(623, 7);
            ct_giftcosmog_PB.Margin = new Padding(5, 6, 5, 6);
            ct_giftcosmog_PB.MaximumSize = new Size(173, 83);
            ct_giftcosmog_PB.MinimumSize = new Size(173, 83);
            ct_giftcosmog_PB.Name = "ct_giftcosmog_PB";
            ct_giftcosmog_PB.Pokemon = 789;
            ct_giftcosmog_PB.PokemonName = "科斯莫古礼物";
            ct_giftcosmog_PB.PokemonSubform = "";
            ct_giftcosmog_PB.Size = new Size(173, 83);
            ct_giftcosmog_PB.TabIndex = 6;
            ct_giftcosmog_PB.ToolTip = "";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ts_applyBTN });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(867, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // ts_applyBTN
            // 
            ts_applyBTN.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ts_applyBTN.ImageTransparentColor = Color.Magenta;
            ts_applyBTN.Name = "ts_applyBTN";
            ts_applyBTN.Size = new Size(107, 22);
            ts_applyBTN.Text = "应用所选内容";
            ts_applyBTN.Click += ts_applyBTN_Click;
            // 
            // WorldEventsForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(867, 422);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "WorldEventsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "世界事件";
            Load += WorldEvents_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ct_spiritomb_players_NUD).EndInit();
            groupBox1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC ct_garticuno_PB;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC ct_gmoltres_PB;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC ct_gzapdos_PB;
        private System.Windows.Forms.Button ct_birds_uncaughtBTN;
        private System.Windows.Forms.Button ct_birds_caughtBTN;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC ct_giftcosmog_PB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_applyBTN;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC ct_spiritomb_PB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ct_spiritomb_visible_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ct_spiritomb_players_NUD;
        private System.Windows.Forms.CheckBox ct_spiritomb_forcelegal_CB;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC main_gpikachu_PB;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC main_geevee_PB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox main_eevee_save_data_CB;
        private System.Windows.Forms.CheckBox main_letsgo_forcelegal_CB;
        private System.Windows.Forms.CheckBox main_pikachu_save_data_CB;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC main_gift_typenull_PB;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC main_gift_gcharmander_PB;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC ct_gift_poipole_PB;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC main_gift_toxel_PB;
        private System.Windows.Forms.GroupBox groupBox5;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC armor_gift_squirtle_PB;
        private GUI.SWSHEventEditorGUI.Controls.PokemonBaseUC armor_gift_bulbasaur_PB;
        private Button WonderCard_BTN;
        private Button CurryDex_BTN;
        private Button SOJForm_BTN;
        private Button RegiForm_BTN;
        private Button Dynamax_BTN;
    }
}