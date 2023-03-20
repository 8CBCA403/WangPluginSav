using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXWonderRecord
{
    partial class WonderRecordLGPE
    {
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private Label LocationLabel;

        private NumericUpDown SlotIndex;

        private ComboBox SpeciesBox;

        private PictureBox SpeciesImageBox;

        private Label AreaSlotLabel;

        private Label SpeciesLabel;

        private NumericUpDown FormBox;

        private Label label1;

        private ComboBox EntryTypeBox;

        private NumericUpDown WCIDBox;

        private Label label2;

        internal ComboBox CardTitleRawBox;

        private Label label3;

        private TabControl WRTabs;

        private TabPage tabPage1;

        private TabPage tabPage2;

        private TabPage tabPage3;

        internal Label Label28;

        internal ComboBox move1list;

        internal ComboBox move2list;

        internal ComboBox move3list;

        internal ComboBox move4list;

        internal Label label11;

        internal Label label10;

        internal Label Label4;

        internal ComboBox pokedextype;

        internal Label Label5;

        internal Label Label21;

        internal Label Label6;

        internal TextBox pokemonlc;

        internal TextBox otnamebox;

        internal ComboBox OTG;

        internal ComboBox languagebox;

        internal Label Label7;

        internal TextBox CardTitleRefinedBox;

        internal ComboBox itemnameplural;

        internal TextBox nitem6;

        internal TextBox nitem5;

        internal TextBox nitem4;

        internal TextBox nitem3;

        internal TextBox nitem2;

        internal TextBox nitem1;

        internal TextBox itemslc;

        internal Label Label20;

        internal Label Label18;

        internal Label Label17;

        internal Label Label16;

        internal Label Label15;

        internal Label Label14;

        internal ComboBox itembox6;

        internal ComboBox itembox5;

        internal ComboBox itembox4;

        internal ComboBox itembox3;

        internal ComboBox itembox2;

        internal ComboBox itembox1;

        internal Label Label13;

        private Button WC8_2_WR8_Button;

        private Label label34;

        internal TextBox TimestampBox;

        private Label label19;

        private GroupBox groupBox1;

        private Label label40;

        private Label label38;

        private Label label39;

        private Label label36;

        private Label label35;

        private NumericUpDown HourBox;

        private NumericUpDown YearBox;

        private NumericUpDown MonthBox;

        private NumericUpDown DayBox;

        private NumericUpDown MinBox;

        private NumericUpDown SecBox;

        private Button DateNul;

        private Button InsertWR8Button;

        private Button ExtractWR8Button;

        private Button DeleteWR8Button;

        internal TextBox RefinedSpeciesBox;

        private PictureBox pictureBox10;

        private PictureBox pictureBox9;

        private PictureBox pictureBox8;

        private PictureBox pictureBox7;

        private PictureBox pictureBox6;

        private PictureBox pictureBox5;

        private PictureBox pictureBox4;

        private PictureBox pictureBox3;

        private PictureBox pictureBox2;

        private PictureBox pictureBox1;

        private PictureBox pictureBox0;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WonderRecordLGPE));
            LocationLabel = new Label();
            SlotIndex = new NumericUpDown();
            SpeciesBox = new ComboBox();
            AreaSlotLabel = new Label();
            SpeciesLabel = new Label();
            FormBox = new NumericUpDown();
            SpeciesImageBox = new PictureBox();
            label1 = new Label();
            EntryTypeBox = new ComboBox();
            WCIDBox = new NumericUpDown();
            label2 = new Label();
            CardTitleRawBox = new ComboBox();
            label3 = new Label();
            WRTabs = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            RefinedSpeciesBox = new TextBox();
            move1list = new ComboBox();
            Label28 = new Label();
            move2list = new ComboBox();
            move3list = new ComboBox();
            move4list = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            Label4 = new Label();
            pokedextype = new ComboBox();
            Label5 = new Label();
            Label21 = new Label();
            Label6 = new Label();
            pokemonlc = new TextBox();
            otnamebox = new TextBox();
            OTG = new ComboBox();
            languagebox = new ComboBox();
            Label7 = new Label();
            tabPage3 = new TabPage();
            itemnameplural = new ComboBox();
            nitem6 = new TextBox();
            nitem5 = new TextBox();
            nitem4 = new TextBox();
            nitem3 = new TextBox();
            nitem2 = new TextBox();
            nitem1 = new TextBox();
            itemslc = new TextBox();
            Label20 = new Label();
            Label18 = new Label();
            Label17 = new Label();
            Label16 = new Label();
            Label15 = new Label();
            Label14 = new Label();
            itembox6 = new ComboBox();
            itembox5 = new ComboBox();
            itembox4 = new ComboBox();
            itembox3 = new ComboBox();
            itembox2 = new ComboBox();
            itembox1 = new ComboBox();
            Label13 = new Label();
            CardTitleRefinedBox = new TextBox();
            WC8_2_WR8_Button = new Button();
            label34 = new Label();
            TimestampBox = new TextBox();
            label19 = new Label();
            groupBox1 = new GroupBox();
            DateNul = new Button();
            SecBox = new NumericUpDown();
            label40 = new Label();
            DayBox = new NumericUpDown();
            MinBox = new NumericUpDown();
            MonthBox = new NumericUpDown();
            HourBox = new NumericUpDown();
            YearBox = new NumericUpDown();
            label39 = new Label();
            label36 = new Label();
            label38 = new Label();
            label35 = new Label();
            InsertWR8Button = new Button();
            ExtractWR8Button = new Button();
            DeleteWR8Button = new Button();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox0 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SlotIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FormBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpeciesImageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WCIDBox).BeginInit();
            WRTabs.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SecBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DayBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MonthBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HourBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YearBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox0).BeginInit();
            SuspendLayout();
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Location = new Point(12, 10);
            LocationLabel.Margin = new Padding(4, 0, 4, 0);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(0, 15);
            LocationLabel.TabIndex = 3;
            // 
            // SlotIndex
            // 
            SlotIndex.Enabled = false;
            SlotIndex.Location = new Point(107, 225);
            SlotIndex.Margin = new Padding(4, 4, 4, 4);
            SlotIndex.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            SlotIndex.Name = "SlotIndex";
            SlotIndex.Size = new Size(116, 25);
            SlotIndex.TabIndex = 1;
            SlotIndex.ValueChanged += SlotIndex_ValueChanged;
            // 
            // SpeciesBox
            // 
            SpeciesBox.AllowDrop = true;
            SpeciesBox.FormattingEnabled = true;
            SpeciesBox.Items.AddRange(new object[] { "1" });
            SpeciesBox.Location = new Point(104, 24);
            SpeciesBox.Margin = new Padding(4, 4, 4, 4);
            SpeciesBox.Name = "SpeciesBox";
            SpeciesBox.Size = new Size(204, 23);
            SpeciesBox.TabIndex = 1;
            SpeciesBox.SelectedIndexChanged += SpeciesBox_SelectedIndexChanged;
            // 
            // AreaSlotLabel
            // 
            AreaSlotLabel.AutoSize = true;
            AreaSlotLabel.Location = new Point(8, 227);
            AreaSlotLabel.Margin = new Padding(4, 0, 4, 0);
            AreaSlotLabel.Name = "AreaSlotLabel";
            AreaSlotLabel.Size = new Size(87, 15);
            AreaSlotLabel.TabIndex = 29;
            AreaSlotLabel.Text = "Entry Slot";
            // 
            // SpeciesLabel
            // 
            SpeciesLabel.AutoSize = true;
            SpeciesLabel.Location = new Point(16, 28);
            SpeciesLabel.Margin = new Padding(4, 0, 4, 0);
            SpeciesLabel.Name = "SpeciesLabel";
            SpeciesLabel.Size = new Size(63, 15);
            SpeciesLabel.TabIndex = 32;
            SpeciesLabel.Text = "Species";
            // 
            // FormBox
            // 
            FormBox.Location = new Point(603, 28);
            FormBox.Margin = new Padding(4, 4, 4, 4);
            FormBox.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            FormBox.Name = "FormBox";
            FormBox.Size = new Size(116, 25);
            FormBox.TabIndex = 13;
            FormBox.Visible = false;
            // 
            // SpeciesImageBox
            // 
            SpeciesImageBox.BackgroundImageLayout = ImageLayout.None;
            SpeciesImageBox.Location = new Point(4, 2);
            SpeciesImageBox.Margin = new Padding(4, 4, 4, 4);
            SpeciesImageBox.Name = "SpeciesImageBox";
            SpeciesImageBox.Size = new Size(181, 129);
            SpeciesImageBox.TabIndex = 28;
            SpeciesImageBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(398, 290);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 110;
            label1.Text = "Entry Type";
            // 
            // EntryTypeBox
            // 
            EntryTypeBox.AllowDrop = true;
            EntryTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EntryTypeBox.Enabled = false;
            EntryTypeBox.FormattingEnabled = true;
            EntryTypeBox.Items.AddRange(new object[] { "None", "Pokémon", "Items", "Unknown" });
            EntryTypeBox.Location = new Point(495, 288);
            EntryTypeBox.Margin = new Padding(4, 4, 4, 4);
            EntryTypeBox.Name = "EntryTypeBox";
            EntryTypeBox.Size = new Size(115, 23);
            EntryTypeBox.TabIndex = 4;
            // 
            // WCIDBox
            // 
            WCIDBox.Enabled = false;
            WCIDBox.Location = new Point(107, 322);
            WCIDBox.Margin = new Padding(4, 4, 4, 4);
            WCIDBox.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            WCIDBox.Name = "WCIDBox";
            WCIDBox.Size = new Size(116, 25);
            WCIDBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 322);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 413;
            label2.Text = "WC ID";
            // 
            // CardTitleRawBox
            // 
            CardTitleRawBox.AllowDrop = true;
            CardTitleRawBox.Enabled = false;
            CardTitleRawBox.FormattingEnabled = true;
            CardTitleRawBox.Items.AddRange(new object[] { "[VAR PKNAME(0000)] Gift", "[VAR ITEM2(0008)] Gift", "Item Set Gift", "[VAR 0104(0001)] [VAR PKNAME(0000)] Gift", "Mythical Pokémon [VAR PKNAME(0000)] Gift", "[VAR TRNAME(0003)]’s [VAR PKNAME(0000)] Gift", "Shiny [VAR PKNAME(0000)] Gift", "[VAR PKNAME(0000)] ([VAR 01CA(0002)]) Gift", "[VAR 01CA(0002)] Gift", "Hidden Ability [VAR PKNAME(0000)] Gift", "[VAR MOVE(0004)] [VAR PKNAME(0000)] Gift", "[VAR PKNAME(0000)] with [VAR MOVE(0005)] Gift", "[VAR PKNAME(0000)] with [VAR MOVE(0006)] Gift", "[VAR PKNAME(0000)] with [VAR MOVE(0007)] Gift", "[VAR PKNAME(0000)] & [VAR ITEM2(0009)] Gift", "Downloadable Version Bonus", "Special Pack Purchase Bonus", "Store Purchase Bonus", "Strategy Guide Purchase Bonus", "Purchase Bonus", "Happy Birthday!", "Virtual Console Bonus", "Pokémon Trainer Club Gift", "Pokémon Global Link Gift", "Pokémon Bank Gift", "Unknown" });
            CardTitleRawBox.Location = new Point(107, 288);
            CardTitleRawBox.Margin = new Padding(4, 4, 4, 4);
            CardTitleRawBox.Name = "CardTitleRawBox";
            CardTitleRawBox.Size = new Size(285, 23);
            CardTitleRawBox.TabIndex = 3;
            CardTitleRawBox.Visible = false;
            CardTitleRawBox.SelectedIndexChanged += CardTitleRawBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 259);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 415;
            label3.Text = "Card Title";
            // 
            // WRTabs
            // 
            WRTabs.Appearance = TabAppearance.FlatButtons;
            WRTabs.Controls.Add(tabPage1);
            WRTabs.Controls.Add(tabPage2);
            WRTabs.Controls.Add(tabPage3);
            WRTabs.Enabled = false;
            WRTabs.Location = new Point(0, 374);
            WRTabs.Margin = new Padding(4, 4, 4, 4);
            WRTabs.Name = "WRTabs";
            WRTabs.SelectedIndex = 0;
            WRTabs.Size = new Size(695, 195);
            WRTabs.TabIndex = 418;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 28);
            tabPage1.Margin = new Padding(4, 4, 4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 4, 4, 4);
            tabPage1.Size = new Size(687, 163);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "None";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(RefinedSpeciesBox);
            tabPage2.Controls.Add(move1list);
            tabPage2.Controls.Add(Label28);
            tabPage2.Controls.Add(move2list);
            tabPage2.Controls.Add(move3list);
            tabPage2.Controls.Add(move4list);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(Label4);
            tabPage2.Controls.Add(pokedextype);
            tabPage2.Controls.Add(Label5);
            tabPage2.Controls.Add(Label21);
            tabPage2.Controls.Add(FormBox);
            tabPage2.Controls.Add(Label6);
            tabPage2.Controls.Add(pokemonlc);
            tabPage2.Controls.Add(otnamebox);
            tabPage2.Controls.Add(OTG);
            tabPage2.Controls.Add(languagebox);
            tabPage2.Controls.Add(Label7);
            tabPage2.Controls.Add(SpeciesBox);
            tabPage2.Controls.Add(SpeciesLabel);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Margin = new Padding(4, 4, 4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 4, 4, 4);
            tabPage2.Size = new Size(687, 275);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pokémon";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // RefinedSpeciesBox
            // 
            RefinedSpeciesBox.Enabled = false;
            RefinedSpeciesBox.Location = new Point(537, 124);
            RefinedSpeciesBox.Margin = new Padding(4, 4, 4, 4);
            RefinedSpeciesBox.MaxLength = 1;
            RefinedSpeciesBox.Name = "RefinedSpeciesBox";
            RefinedSpeciesBox.Size = new Size(204, 25);
            RefinedSpeciesBox.TabIndex = 704;
            RefinedSpeciesBox.Visible = false;
            // 
            // move1list
            // 
            move1list.AllowDrop = true;
            move1list.AutoCompleteCustomSource.AddRange(new string[] { "(None)", "Pound ", "Karate Chop ", "Double Slap ", "Comet Punch ", "Mega Punch ", "Pay Day ", "Fire Punch ", "Ice Punch ", "Thunder Punch ", "Scratch ", "Vice Grip ", "Guillotine ", "Razor Wind ", "Swords Dance ", "Cut ", "Gust ", "Wing Attack ", "Whirlwind ", "Fly ", "Bind ", "Slam ", "Vine Whip ", "Stomp ", "Double Kick ", "Mega Kick ", "Jump Kick ", "Rolling Kick ", "Sand Attack ", "Headbutt ", "Horn Attack ", "Fury Attack ", "Horn Drill ", "Tackle ", "Body Slam ", "Wrap ", "Take Down ", "Thrash ", "Double-Edge ", "Tail Whip ", "Poison Sting ", "Twineedle ", "Pin Missile ", "Leer ", "Bite ", "Growl ", "Roar ", "Sing ", "Supersonic ", "Sonic Boom ", "Disable ", "Acid ", "Ember ", "Flamethrower ", "Mist ", "Water Gun ", "Hydro Pump ", "Surf ", "Ice Beam ", "Blizzard ", "Psybeam ", "Bubble Beam ", "Aurora Beam ", "Hyper Beam ", "Peck ", "Drill Peck ", "Submission ", "Low Kick ", "Counter ", "Seismic Toss ", "Strength ", "Absorb ", "Mega Drain ", "Leech Seed ", "Growth ", "Razor Leaf ", "Solar Beam ", "Poison Powder ", "Stun Spore ", "Sleep Powder ", "Petal Dance ", "String Shot ", "Dragon Rage ", "Fire Spin ", "Thunder Shock ", "Thunderbolt ", "Thunder Wave ", "Thunder ", "Rock Throw ", "Earthquake ", "Fissure ", "Dig ", "Toxic ", "Confusion ", "Psychic ", "Hypnosis ", "Meditate ", "Agility ", "Quick Attack ", "Rage ", "Teleport ", "Night Shade ", "Mimic ", "Screech ", "Double Team ", "Recover ", "Harden ", "Minimize ", "Smokescreen ", "Confuse Ray ", "Withdraw ", "Defense Curl ", "Barrier ", "Light Screen ", "Haze ", "Reflect ", "Focus Energy ", "Bide ", "Metronome ", "Mirror Move ", "Self-Destruct ", "Egg Bomb ", "Lick ", "Smog ", "Sludge ", "Bone Club ", "Fire Blast ", "Waterfall ", "Clamp ", "Swift ", "Skull Bash ", "Spike Cannon ", "Constrict ", "Amnesia ", "Kinesis ", "Soft-Boiled ", "High Jump Kick ", "Glare ", "Dream Eater ", "Poison Gas ", "Barrage ", "Leech Life ", "Lovely Kiss ", "Sky Attack ", "Transform ", "Bubble ", "Dizzy Punch ", "Spore ", "Flash ", "Psywave ", "Splash ", "Acid Armor ", "Crabhammer ", "Explosion ", "Fury Swipes ", "Bonemerang ", "Rest ", "Rock Slide ", "Hyper Fang ", "Sharpen ", "Conversion ", "Tri Attack ", "Super Fang ", "Slash ", "Substitute ", "Struggle ", "Sketch ", "Triple Kick ", "Thief ", "Spider Web ", "Mind Reader ", "Nightmare ", "Flame Wheel ", "Snore ", "Curse ", "Flail ", "Conversion 2 ", "Aeroblast ", "Cotton Spore ", "Reversal ", "Spite ", "Powder Snow ", "Protect ", "Mach Punch ", "Scary Face ", "Feint Attack ", "Sweet Kiss ", "Belly Drum ", "Sludge Bomb ", "Mud-Slap ", "Octazooka ", "Spikes ", "Zap Cannon ", "Foresight ", "Destiny Bond ", "Perish Song ", "Icy Wind ", "Detect ", "Bone Rush ", "Lock-On ", "Outrage ", "Sandstorm ", "Giga Drain ", "Endure ", "Charm ", "Rollout ", "False Swipe ", "Swagger ", "Milk Drink ", "Spark ", "Fury Cutter ", "Steel Wing ", "Mean Look ", "Attract ", "Sleep Talk ", "Heal Bell ", "Return ", "Present ", "Frustration ", "Safeguard ", "Pain Split ", "Sacred Fire ", "Magnitude ", "Dynamic Punch ", "Megahorn ", "Dragon Breath ", "Baton Pass ", "Encore ", "Pursuit ", "Rapid Spin ", "Sweet Scent ", "Iron Tail ", "Metal Claw ", "Vital Throw ", "Morning Sun ", "Synthesis ", "Moonlight ", "Hidden Power ", "Cross Chop ", "Twister ", "Rain Dance ", "Sunny Day ", "Crunch ", "Mirror Coat ", "Psych Up ", "Extreme Speed ", "Ancient Power ", "Shadow Ball ", "Future Sight ", "Rock Smash ", "Whirlpool ", "Beat Up ", "Fake Out ", "Uproar ", "Stockpile ", "Spit Up ", "Swallow ", "Heat Wave ", "Hail ", "Torment ", "Flatter ", "Will-O-Wisp ", "Memento ", "Facade ", "Focus Punch ", "Smelling Salts ", "Follow Me ", "Nature Power ", "Charge ", "Taunt ", "Helping Hand ", "Trick ", "Role Play ", "Wish ", "Assist ", "Ingrain ", "Superpower ", "Magic Coat ", "Recycle ", "Revenge ", "Brick Break ", "Yawn ", "Knock Off ", "Endeavor ", "Eruption ", "Skill Swap ", "Imprison ", "Refresh ", "Grudge ", "Snatch ", "Secret Power ", "Dive ", "Arm Thrust ", "Camouflage ", "Tail Glow ", "Luster Purge ", "Mist Ball ", "Feather Dance ", "Teeter Dance ", "Blaze Kick ", "Mud Sport ", "Ice Ball ", "Needle Arm ", "Slack Off ", "Hyper Voice ", "Poison Fang ", "Crush Claw ", "Blast Burn ", "Hydro Cannon ", "Meteor Mash ", "Astonish ", "Weather Ball ", "Aromatherapy ", "Fake Tears ", "Air Cutter ", "Overheat ", "Odor Sleuth ", "Rock Tomb ", "Silver Wind ", "Metal Sound ", "Grass Whistle ", "Tickle ", "Cosmic Power ", "Water Spout ", "Signal Beam ", "Shadow Punch ", "Extrasensory ", "Sky Uppercut ", "Sand Tomb ", "Sheer Cold ", "Muddy Water ", "Bullet Seed ", "Aerial Ace ", "Icicle Spear ", "Iron Defense ", "Block ", "Howl ", "Dragon Claw ", "Frenzy Plant ", "Bulk Up ", "Bounce ", "Mud Shot ", "Poison Tail ", "Covet ", "Volt Tackle ", "Magical Leaf ", "Water Sport ", "Calm Mind ", "Leaf Blade ", "Dragon Dance ", "Rock Blast ", "Shock Wave ", "Water Pulse ", "Doom Desire ", "Psycho Boost ", "Roost ", "Gravity ", "Miracle Eye ", "Wake-Up Slap ", "Hammer Arm ", "Gyro Ball ", "Healing Wish ", "Brine ", "Natural Gift ", "Feint ", "Pluck ", "Tailwind ", "Acupressure ", "Metal Burst ", "U-turn ", "Close Combat ", "Payback ", "Assurance ", "Embargo ", "Fling ", "Psycho Shift ", "Trump Card ", "Heal Block ", "Wring Out ", "Power Trick ", "Gastro Acid ", "Lucky Chant ", "Me First ", "Copycat ", "Power Swap ", "Guard Swap ", "Punishment ", "Last Resort ", "Worry Seed ", "Sucker Punch ", "Toxic Spikes ", "Heart Swap ", "Aqua Ring ", "Magnet Rise ", "Flare Blitz ", "Force Palm ", "Aura Sphere ", "Rock Polish ", "Poison Jab ", "Dark Pulse ", "Night Slash ", "Aqua Tail ", "Seed Bomb ", "Air Slash ", "X-Scissor ", "Bug Buzz ", "Dragon Pulse ", "Dragon Rush ", "Power Gem ", "Drain Punch ", "Vacuum Wave ", "Focus Blast ", "Energy Ball ", "Brave Bird ", "Earth Power ", "Switcheroo ", "Giga Impact ", "Nasty Plot ", "Bullet Punch ", "Avalanche ", "Ice Shard ", "Shadow Claw ", "Thunder Fang ", "Ice Fang ", "Fire Fang ", "Shadow Sneak ", "Mud Bomb ", "Psycho Cut ", "Zen Headbutt ", "Mirror Shot ", "Flash Cannon ", "Rock Climb ", "Defog ", "Trick Room ", "Draco Meteor ", "Discharge ", "Lava Plume ", "Leaf Storm ", "Power Whip ", "Rock Wrecker ", "Cross Poison ", "Gunk Shot ", "Iron Head ", "Magnet Bomb ", "Stone Edge ", "Captivate ", "Stealth Rock ", "Grass Knot ", "Chatter ", "Judgment ", "Bug Bite ", "Charge Beam ", "Wood Hammer ", "Aqua Jet ", "Attack Order ", "Defend Order ", "Heal Order ", "Head Smash ", "Double Hit ", "Roar of Time ", "Spacial Rend ", "Lunar Dance ", "Crush Grip ", "Magma Storm ", "Dark Void ", "Seed Flare ", "Ominous Wind ", "Shadow Force ", "Hone Claws ", "Wide Guard ", "Guard Split ", "Power Split ", "Wonder Room ", "Psyshock ", "Venoshock ", "Autotomize ", "Rage Powder ", "Telekinesis ", "Magic Room ", "Smack Down ", "Storm Throw ", "Flame Burst ", "Sludge Wave ", "Quiver Dance ", "Heavy Slam ", "Synchronoise ", "Electro Ball ", "Soak ", "Flame Charge ", "Coil ", "Low Sweep ", "Acid Spray ", "Foul Play ", "Simple Beam ", "Entrainment ", "After You ", "Round ", "Echoed Voice ", "Chip Away ", "Clear Smog ", "Stored Power ", "Quick Guard ", "Ally Switch ", "Scald ", "Shell Smash ", "Heal Pulse ", "Hex ", "Sky Drop ", "Shift Gear ", "Circle Throw ", "Incinerate ", "Quash ", "Acrobatics ", "Reflect Type ", "Retaliate ", "Final Gambit ", "Bestow ", "Inferno ", "Water Pledge ", "Fire Pledge ", "Grass Pledge ", "Volt Switch ", "Struggle Bug ", "Bulldoze ", "Frost Breath ", "Dragon Tail ", "Work Up ", "Electroweb ", "Wild Charge ", "Drill Run ", "Dual Chop ", "Heart Stamp ", "Horn Leech ", "Sacred Sword ", "Razor Shell ", "Heat Crash ", "Leaf Tornado ", "Steamroller ", "Cotton Guard ", "Night Daze ", "Psystrike ", "Tail Slap ", "Hurricane ", "Head Charge ", "Gear Grind ", "Searing Shot ", "Techno Blast ", "Relic Song ", "Secret Sword ", "Glaciate ", "Bolt Strike ", "Blue Flare ", "Fiery Dance ", "Freeze Shock ", "Ice Burn ", "Snarl ", "Icicle Crash ", "V-create ", "Fusion Flare ", "Fusion Bolt ", "Flying Press ", "Mat Block ", "Belch ", "Rototiller ", "Sticky Web ", "Fell Stinger ", "Phantom Force ", "Trick-or-Treat ", "Noble Roar ", "Ion Deluge ", "Parabolic Charge ", "Forest's Curse ", "Petal Blizzard ", "Freeze-Dry ", "Disarming Voice ", "Parting Shot ", "Topsy-Turvy ", "Draining Kiss ", "Crafty Shield ", "Flower Shield ", "Grassy Terrain ", "Misty Terrain ", "Electrify ", "Play Rough ", "Fairy Wind ", "Moonblast ", "Boomburst ", "Fairy Lock ", "King's Shield ", "Play Nice ", "Confide ", "Diamond Storm ", "Steam Eruption ", "Hyperspace Hole ", "Water Shuriken ", "Mystical Fire ", "Spiky Shield ", "Aromatic Mist ", "Eerie Impulse ", "Venom Drench ", "Powder ", "Geomancy ", "Magnetic Flux ", "Happy Hour ", "Electric Terrain ", "Dazzling Gleam ", "Celebrate ", "Hold Hands ", "Baby-Doll Eyes ", "Nuzzle ", "Hold Back ", "Infestation ", "Power-Up Punch ", "Oblivion Wing ", "Thousand Arrows ", "Thousand Waves ", "Land's Wrath ", "Light of Ruin ", "Origin Pulse ", "Precipice Blades ", "Dragon Ascent ", "Hyperspace Fury " });
            move1list.FormattingEnabled = true;
            move1list.Items.AddRange(new object[] { "1" });
            move1list.Location = new Point(104, 56);
            move1list.Margin = new Padding(4, 4, 4, 4);
            move1list.Name = "move1list";
            move1list.Size = new Size(204, 23);
            move1list.TabIndex = 2;
            // 
            // Label28
            // 
            Label28.AutoSize = true;
            Label28.Location = new Point(536, 30);
            Label28.Margin = new Padding(4, 0, 4, 0);
            Label28.Name = "Label28";
            Label28.Size = new Size(63, 15);
            Label28.TabIndex = 703;
            Label28.Text = "Form ID";
            Label28.Visible = false;
            // 
            // move2list
            // 
            move2list.AllowDrop = true;
            move2list.AutoCompleteCustomSource.AddRange(new string[] { "(None)", "Pound ", "Karate Chop ", "Double Slap ", "Comet Punch ", "Mega Punch ", "Pay Day ", "Fire Punch ", "Ice Punch ", "Thunder Punch ", "Scratch ", "Vice Grip ", "Guillotine ", "Razor Wind ", "Swords Dance ", "Cut ", "Gust ", "Wing Attack ", "Whirlwind ", "Fly ", "Bind ", "Slam ", "Vine Whip ", "Stomp ", "Double Kick ", "Mega Kick ", "Jump Kick ", "Rolling Kick ", "Sand Attack ", "Headbutt ", "Horn Attack ", "Fury Attack ", "Horn Drill ", "Tackle ", "Body Slam ", "Wrap ", "Take Down ", "Thrash ", "Double-Edge ", "Tail Whip ", "Poison Sting ", "Twineedle ", "Pin Missile ", "Leer ", "Bite ", "Growl ", "Roar ", "Sing ", "Supersonic ", "Sonic Boom ", "Disable ", "Acid ", "Ember ", "Flamethrower ", "Mist ", "Water Gun ", "Hydro Pump ", "Surf ", "Ice Beam ", "Blizzard ", "Psybeam ", "Bubble Beam ", "Aurora Beam ", "Hyper Beam ", "Peck ", "Drill Peck ", "Submission ", "Low Kick ", "Counter ", "Seismic Toss ", "Strength ", "Absorb ", "Mega Drain ", "Leech Seed ", "Growth ", "Razor Leaf ", "Solar Beam ", "Poison Powder ", "Stun Spore ", "Sleep Powder ", "Petal Dance ", "String Shot ", "Dragon Rage ", "Fire Spin ", "Thunder Shock ", "Thunderbolt ", "Thunder Wave ", "Thunder ", "Rock Throw ", "Earthquake ", "Fissure ", "Dig ", "Toxic ", "Confusion ", "Psychic ", "Hypnosis ", "Meditate ", "Agility ", "Quick Attack ", "Rage ", "Teleport ", "Night Shade ", "Mimic ", "Screech ", "Double Team ", "Recover ", "Harden ", "Minimize ", "Smokescreen ", "Confuse Ray ", "Withdraw ", "Defense Curl ", "Barrier ", "Light Screen ", "Haze ", "Reflect ", "Focus Energy ", "Bide ", "Metronome ", "Mirror Move ", "Self-Destruct ", "Egg Bomb ", "Lick ", "Smog ", "Sludge ", "Bone Club ", "Fire Blast ", "Waterfall ", "Clamp ", "Swift ", "Skull Bash ", "Spike Cannon ", "Constrict ", "Amnesia ", "Kinesis ", "Soft-Boiled ", "High Jump Kick ", "Glare ", "Dream Eater ", "Poison Gas ", "Barrage ", "Leech Life ", "Lovely Kiss ", "Sky Attack ", "Transform ", "Bubble ", "Dizzy Punch ", "Spore ", "Flash ", "Psywave ", "Splash ", "Acid Armor ", "Crabhammer ", "Explosion ", "Fury Swipes ", "Bonemerang ", "Rest ", "Rock Slide ", "Hyper Fang ", "Sharpen ", "Conversion ", "Tri Attack ", "Super Fang ", "Slash ", "Substitute ", "Struggle ", "Sketch ", "Triple Kick ", "Thief ", "Spider Web ", "Mind Reader ", "Nightmare ", "Flame Wheel ", "Snore ", "Curse ", "Flail ", "Conversion 2 ", "Aeroblast ", "Cotton Spore ", "Reversal ", "Spite ", "Powder Snow ", "Protect ", "Mach Punch ", "Scary Face ", "Feint Attack ", "Sweet Kiss ", "Belly Drum ", "Sludge Bomb ", "Mud-Slap ", "Octazooka ", "Spikes ", "Zap Cannon ", "Foresight ", "Destiny Bond ", "Perish Song ", "Icy Wind ", "Detect ", "Bone Rush ", "Lock-On ", "Outrage ", "Sandstorm ", "Giga Drain ", "Endure ", "Charm ", "Rollout ", "False Swipe ", "Swagger ", "Milk Drink ", "Spark ", "Fury Cutter ", "Steel Wing ", "Mean Look ", "Attract ", "Sleep Talk ", "Heal Bell ", "Return ", "Present ", "Frustration ", "Safeguard ", "Pain Split ", "Sacred Fire ", "Magnitude ", "Dynamic Punch ", "Megahorn ", "Dragon Breath ", "Baton Pass ", "Encore ", "Pursuit ", "Rapid Spin ", "Sweet Scent ", "Iron Tail ", "Metal Claw ", "Vital Throw ", "Morning Sun ", "Synthesis ", "Moonlight ", "Hidden Power ", "Cross Chop ", "Twister ", "Rain Dance ", "Sunny Day ", "Crunch ", "Mirror Coat ", "Psych Up ", "Extreme Speed ", "Ancient Power ", "Shadow Ball ", "Future Sight ", "Rock Smash ", "Whirlpool ", "Beat Up ", "Fake Out ", "Uproar ", "Stockpile ", "Spit Up ", "Swallow ", "Heat Wave ", "Hail ", "Torment ", "Flatter ", "Will-O-Wisp ", "Memento ", "Facade ", "Focus Punch ", "Smelling Salts ", "Follow Me ", "Nature Power ", "Charge ", "Taunt ", "Helping Hand ", "Trick ", "Role Play ", "Wish ", "Assist ", "Ingrain ", "Superpower ", "Magic Coat ", "Recycle ", "Revenge ", "Brick Break ", "Yawn ", "Knock Off ", "Endeavor ", "Eruption ", "Skill Swap ", "Imprison ", "Refresh ", "Grudge ", "Snatch ", "Secret Power ", "Dive ", "Arm Thrust ", "Camouflage ", "Tail Glow ", "Luster Purge ", "Mist Ball ", "Feather Dance ", "Teeter Dance ", "Blaze Kick ", "Mud Sport ", "Ice Ball ", "Needle Arm ", "Slack Off ", "Hyper Voice ", "Poison Fang ", "Crush Claw ", "Blast Burn ", "Hydro Cannon ", "Meteor Mash ", "Astonish ", "Weather Ball ", "Aromatherapy ", "Fake Tears ", "Air Cutter ", "Overheat ", "Odor Sleuth ", "Rock Tomb ", "Silver Wind ", "Metal Sound ", "Grass Whistle ", "Tickle ", "Cosmic Power ", "Water Spout ", "Signal Beam ", "Shadow Punch ", "Extrasensory ", "Sky Uppercut ", "Sand Tomb ", "Sheer Cold ", "Muddy Water ", "Bullet Seed ", "Aerial Ace ", "Icicle Spear ", "Iron Defense ", "Block ", "Howl ", "Dragon Claw ", "Frenzy Plant ", "Bulk Up ", "Bounce ", "Mud Shot ", "Poison Tail ", "Covet ", "Volt Tackle ", "Magical Leaf ", "Water Sport ", "Calm Mind ", "Leaf Blade ", "Dragon Dance ", "Rock Blast ", "Shock Wave ", "Water Pulse ", "Doom Desire ", "Psycho Boost ", "Roost ", "Gravity ", "Miracle Eye ", "Wake-Up Slap ", "Hammer Arm ", "Gyro Ball ", "Healing Wish ", "Brine ", "Natural Gift ", "Feint ", "Pluck ", "Tailwind ", "Acupressure ", "Metal Burst ", "U-turn ", "Close Combat ", "Payback ", "Assurance ", "Embargo ", "Fling ", "Psycho Shift ", "Trump Card ", "Heal Block ", "Wring Out ", "Power Trick ", "Gastro Acid ", "Lucky Chant ", "Me First ", "Copycat ", "Power Swap ", "Guard Swap ", "Punishment ", "Last Resort ", "Worry Seed ", "Sucker Punch ", "Toxic Spikes ", "Heart Swap ", "Aqua Ring ", "Magnet Rise ", "Flare Blitz ", "Force Palm ", "Aura Sphere ", "Rock Polish ", "Poison Jab ", "Dark Pulse ", "Night Slash ", "Aqua Tail ", "Seed Bomb ", "Air Slash ", "X-Scissor ", "Bug Buzz ", "Dragon Pulse ", "Dragon Rush ", "Power Gem ", "Drain Punch ", "Vacuum Wave ", "Focus Blast ", "Energy Ball ", "Brave Bird ", "Earth Power ", "Switcheroo ", "Giga Impact ", "Nasty Plot ", "Bullet Punch ", "Avalanche ", "Ice Shard ", "Shadow Claw ", "Thunder Fang ", "Ice Fang ", "Fire Fang ", "Shadow Sneak ", "Mud Bomb ", "Psycho Cut ", "Zen Headbutt ", "Mirror Shot ", "Flash Cannon ", "Rock Climb ", "Defog ", "Trick Room ", "Draco Meteor ", "Discharge ", "Lava Plume ", "Leaf Storm ", "Power Whip ", "Rock Wrecker ", "Cross Poison ", "Gunk Shot ", "Iron Head ", "Magnet Bomb ", "Stone Edge ", "Captivate ", "Stealth Rock ", "Grass Knot ", "Chatter ", "Judgment ", "Bug Bite ", "Charge Beam ", "Wood Hammer ", "Aqua Jet ", "Attack Order ", "Defend Order ", "Heal Order ", "Head Smash ", "Double Hit ", "Roar of Time ", "Spacial Rend ", "Lunar Dance ", "Crush Grip ", "Magma Storm ", "Dark Void ", "Seed Flare ", "Ominous Wind ", "Shadow Force ", "Hone Claws ", "Wide Guard ", "Guard Split ", "Power Split ", "Wonder Room ", "Psyshock ", "Venoshock ", "Autotomize ", "Rage Powder ", "Telekinesis ", "Magic Room ", "Smack Down ", "Storm Throw ", "Flame Burst ", "Sludge Wave ", "Quiver Dance ", "Heavy Slam ", "Synchronoise ", "Electro Ball ", "Soak ", "Flame Charge ", "Coil ", "Low Sweep ", "Acid Spray ", "Foul Play ", "Simple Beam ", "Entrainment ", "After You ", "Round ", "Echoed Voice ", "Chip Away ", "Clear Smog ", "Stored Power ", "Quick Guard ", "Ally Switch ", "Scald ", "Shell Smash ", "Heal Pulse ", "Hex ", "Sky Drop ", "Shift Gear ", "Circle Throw ", "Incinerate ", "Quash ", "Acrobatics ", "Reflect Type ", "Retaliate ", "Final Gambit ", "Bestow ", "Inferno ", "Water Pledge ", "Fire Pledge ", "Grass Pledge ", "Volt Switch ", "Struggle Bug ", "Bulldoze ", "Frost Breath ", "Dragon Tail ", "Work Up ", "Electroweb ", "Wild Charge ", "Drill Run ", "Dual Chop ", "Heart Stamp ", "Horn Leech ", "Sacred Sword ", "Razor Shell ", "Heat Crash ", "Leaf Tornado ", "Steamroller ", "Cotton Guard ", "Night Daze ", "Psystrike ", "Tail Slap ", "Hurricane ", "Head Charge ", "Gear Grind ", "Searing Shot ", "Techno Blast ", "Relic Song ", "Secret Sword ", "Glaciate ", "Bolt Strike ", "Blue Flare ", "Fiery Dance ", "Freeze Shock ", "Ice Burn ", "Snarl ", "Icicle Crash ", "V-create ", "Fusion Flare ", "Fusion Bolt ", "Flying Press ", "Mat Block ", "Belch ", "Rototiller ", "Sticky Web ", "Fell Stinger ", "Phantom Force ", "Trick-or-Treat ", "Noble Roar ", "Ion Deluge ", "Parabolic Charge ", "Forest's Curse ", "Petal Blizzard ", "Freeze-Dry ", "Disarming Voice ", "Parting Shot ", "Topsy-Turvy ", "Draining Kiss ", "Crafty Shield ", "Flower Shield ", "Grassy Terrain ", "Misty Terrain ", "Electrify ", "Play Rough ", "Fairy Wind ", "Moonblast ", "Boomburst ", "Fairy Lock ", "King's Shield ", "Play Nice ", "Confide ", "Diamond Storm ", "Steam Eruption ", "Hyperspace Hole ", "Water Shuriken ", "Mystical Fire ", "Spiky Shield ", "Aromatic Mist ", "Eerie Impulse ", "Venom Drench ", "Powder ", "Geomancy ", "Magnetic Flux ", "Happy Hour ", "Electric Terrain ", "Dazzling Gleam ", "Celebrate ", "Hold Hands ", "Baby-Doll Eyes ", "Nuzzle ", "Hold Back ", "Infestation ", "Power-Up Punch ", "Oblivion Wing ", "Thousand Arrows ", "Thousand Waves ", "Land's Wrath ", "Light of Ruin ", "Origin Pulse ", "Precipice Blades ", "Dragon Ascent ", "Hyperspace Fury " });
            move2list.FormattingEnabled = true;
            move2list.Items.AddRange(new object[] { "1" });
            move2list.Location = new Point(104, 86);
            move2list.Margin = new Padding(4, 4, 4, 4);
            move2list.Name = "move2list";
            move2list.Size = new Size(204, 23);
            move2list.TabIndex = 3;
            // 
            // move3list
            // 
            move3list.AllowDrop = true;
            move3list.AutoCompleteCustomSource.AddRange(new string[] { "(None)", "Pound ", "Karate Chop ", "Double Slap ", "Comet Punch ", "Mega Punch ", "Pay Day ", "Fire Punch ", "Ice Punch ", "Thunder Punch ", "Scratch ", "Vice Grip ", "Guillotine ", "Razor Wind ", "Swords Dance ", "Cut ", "Gust ", "Wing Attack ", "Whirlwind ", "Fly ", "Bind ", "Slam ", "Vine Whip ", "Stomp ", "Double Kick ", "Mega Kick ", "Jump Kick ", "Rolling Kick ", "Sand Attack ", "Headbutt ", "Horn Attack ", "Fury Attack ", "Horn Drill ", "Tackle ", "Body Slam ", "Wrap ", "Take Down ", "Thrash ", "Double-Edge ", "Tail Whip ", "Poison Sting ", "Twineedle ", "Pin Missile ", "Leer ", "Bite ", "Growl ", "Roar ", "Sing ", "Supersonic ", "Sonic Boom ", "Disable ", "Acid ", "Ember ", "Flamethrower ", "Mist ", "Water Gun ", "Hydro Pump ", "Surf ", "Ice Beam ", "Blizzard ", "Psybeam ", "Bubble Beam ", "Aurora Beam ", "Hyper Beam ", "Peck ", "Drill Peck ", "Submission ", "Low Kick ", "Counter ", "Seismic Toss ", "Strength ", "Absorb ", "Mega Drain ", "Leech Seed ", "Growth ", "Razor Leaf ", "Solar Beam ", "Poison Powder ", "Stun Spore ", "Sleep Powder ", "Petal Dance ", "String Shot ", "Dragon Rage ", "Fire Spin ", "Thunder Shock ", "Thunderbolt ", "Thunder Wave ", "Thunder ", "Rock Throw ", "Earthquake ", "Fissure ", "Dig ", "Toxic ", "Confusion ", "Psychic ", "Hypnosis ", "Meditate ", "Agility ", "Quick Attack ", "Rage ", "Teleport ", "Night Shade ", "Mimic ", "Screech ", "Double Team ", "Recover ", "Harden ", "Minimize ", "Smokescreen ", "Confuse Ray ", "Withdraw ", "Defense Curl ", "Barrier ", "Light Screen ", "Haze ", "Reflect ", "Focus Energy ", "Bide ", "Metronome ", "Mirror Move ", "Self-Destruct ", "Egg Bomb ", "Lick ", "Smog ", "Sludge ", "Bone Club ", "Fire Blast ", "Waterfall ", "Clamp ", "Swift ", "Skull Bash ", "Spike Cannon ", "Constrict ", "Amnesia ", "Kinesis ", "Soft-Boiled ", "High Jump Kick ", "Glare ", "Dream Eater ", "Poison Gas ", "Barrage ", "Leech Life ", "Lovely Kiss ", "Sky Attack ", "Transform ", "Bubble ", "Dizzy Punch ", "Spore ", "Flash ", "Psywave ", "Splash ", "Acid Armor ", "Crabhammer ", "Explosion ", "Fury Swipes ", "Bonemerang ", "Rest ", "Rock Slide ", "Hyper Fang ", "Sharpen ", "Conversion ", "Tri Attack ", "Super Fang ", "Slash ", "Substitute ", "Struggle ", "Sketch ", "Triple Kick ", "Thief ", "Spider Web ", "Mind Reader ", "Nightmare ", "Flame Wheel ", "Snore ", "Curse ", "Flail ", "Conversion 2 ", "Aeroblast ", "Cotton Spore ", "Reversal ", "Spite ", "Powder Snow ", "Protect ", "Mach Punch ", "Scary Face ", "Feint Attack ", "Sweet Kiss ", "Belly Drum ", "Sludge Bomb ", "Mud-Slap ", "Octazooka ", "Spikes ", "Zap Cannon ", "Foresight ", "Destiny Bond ", "Perish Song ", "Icy Wind ", "Detect ", "Bone Rush ", "Lock-On ", "Outrage ", "Sandstorm ", "Giga Drain ", "Endure ", "Charm ", "Rollout ", "False Swipe ", "Swagger ", "Milk Drink ", "Spark ", "Fury Cutter ", "Steel Wing ", "Mean Look ", "Attract ", "Sleep Talk ", "Heal Bell ", "Return ", "Present ", "Frustration ", "Safeguard ", "Pain Split ", "Sacred Fire ", "Magnitude ", "Dynamic Punch ", "Megahorn ", "Dragon Breath ", "Baton Pass ", "Encore ", "Pursuit ", "Rapid Spin ", "Sweet Scent ", "Iron Tail ", "Metal Claw ", "Vital Throw ", "Morning Sun ", "Synthesis ", "Moonlight ", "Hidden Power ", "Cross Chop ", "Twister ", "Rain Dance ", "Sunny Day ", "Crunch ", "Mirror Coat ", "Psych Up ", "Extreme Speed ", "Ancient Power ", "Shadow Ball ", "Future Sight ", "Rock Smash ", "Whirlpool ", "Beat Up ", "Fake Out ", "Uproar ", "Stockpile ", "Spit Up ", "Swallow ", "Heat Wave ", "Hail ", "Torment ", "Flatter ", "Will-O-Wisp ", "Memento ", "Facade ", "Focus Punch ", "Smelling Salts ", "Follow Me ", "Nature Power ", "Charge ", "Taunt ", "Helping Hand ", "Trick ", "Role Play ", "Wish ", "Assist ", "Ingrain ", "Superpower ", "Magic Coat ", "Recycle ", "Revenge ", "Brick Break ", "Yawn ", "Knock Off ", "Endeavor ", "Eruption ", "Skill Swap ", "Imprison ", "Refresh ", "Grudge ", "Snatch ", "Secret Power ", "Dive ", "Arm Thrust ", "Camouflage ", "Tail Glow ", "Luster Purge ", "Mist Ball ", "Feather Dance ", "Teeter Dance ", "Blaze Kick ", "Mud Sport ", "Ice Ball ", "Needle Arm ", "Slack Off ", "Hyper Voice ", "Poison Fang ", "Crush Claw ", "Blast Burn ", "Hydro Cannon ", "Meteor Mash ", "Astonish ", "Weather Ball ", "Aromatherapy ", "Fake Tears ", "Air Cutter ", "Overheat ", "Odor Sleuth ", "Rock Tomb ", "Silver Wind ", "Metal Sound ", "Grass Whistle ", "Tickle ", "Cosmic Power ", "Water Spout ", "Signal Beam ", "Shadow Punch ", "Extrasensory ", "Sky Uppercut ", "Sand Tomb ", "Sheer Cold ", "Muddy Water ", "Bullet Seed ", "Aerial Ace ", "Icicle Spear ", "Iron Defense ", "Block ", "Howl ", "Dragon Claw ", "Frenzy Plant ", "Bulk Up ", "Bounce ", "Mud Shot ", "Poison Tail ", "Covet ", "Volt Tackle ", "Magical Leaf ", "Water Sport ", "Calm Mind ", "Leaf Blade ", "Dragon Dance ", "Rock Blast ", "Shock Wave ", "Water Pulse ", "Doom Desire ", "Psycho Boost ", "Roost ", "Gravity ", "Miracle Eye ", "Wake-Up Slap ", "Hammer Arm ", "Gyro Ball ", "Healing Wish ", "Brine ", "Natural Gift ", "Feint ", "Pluck ", "Tailwind ", "Acupressure ", "Metal Burst ", "U-turn ", "Close Combat ", "Payback ", "Assurance ", "Embargo ", "Fling ", "Psycho Shift ", "Trump Card ", "Heal Block ", "Wring Out ", "Power Trick ", "Gastro Acid ", "Lucky Chant ", "Me First ", "Copycat ", "Power Swap ", "Guard Swap ", "Punishment ", "Last Resort ", "Worry Seed ", "Sucker Punch ", "Toxic Spikes ", "Heart Swap ", "Aqua Ring ", "Magnet Rise ", "Flare Blitz ", "Force Palm ", "Aura Sphere ", "Rock Polish ", "Poison Jab ", "Dark Pulse ", "Night Slash ", "Aqua Tail ", "Seed Bomb ", "Air Slash ", "X-Scissor ", "Bug Buzz ", "Dragon Pulse ", "Dragon Rush ", "Power Gem ", "Drain Punch ", "Vacuum Wave ", "Focus Blast ", "Energy Ball ", "Brave Bird ", "Earth Power ", "Switcheroo ", "Giga Impact ", "Nasty Plot ", "Bullet Punch ", "Avalanche ", "Ice Shard ", "Shadow Claw ", "Thunder Fang ", "Ice Fang ", "Fire Fang ", "Shadow Sneak ", "Mud Bomb ", "Psycho Cut ", "Zen Headbutt ", "Mirror Shot ", "Flash Cannon ", "Rock Climb ", "Defog ", "Trick Room ", "Draco Meteor ", "Discharge ", "Lava Plume ", "Leaf Storm ", "Power Whip ", "Rock Wrecker ", "Cross Poison ", "Gunk Shot ", "Iron Head ", "Magnet Bomb ", "Stone Edge ", "Captivate ", "Stealth Rock ", "Grass Knot ", "Chatter ", "Judgment ", "Bug Bite ", "Charge Beam ", "Wood Hammer ", "Aqua Jet ", "Attack Order ", "Defend Order ", "Heal Order ", "Head Smash ", "Double Hit ", "Roar of Time ", "Spacial Rend ", "Lunar Dance ", "Crush Grip ", "Magma Storm ", "Dark Void ", "Seed Flare ", "Ominous Wind ", "Shadow Force ", "Hone Claws ", "Wide Guard ", "Guard Split ", "Power Split ", "Wonder Room ", "Psyshock ", "Venoshock ", "Autotomize ", "Rage Powder ", "Telekinesis ", "Magic Room ", "Smack Down ", "Storm Throw ", "Flame Burst ", "Sludge Wave ", "Quiver Dance ", "Heavy Slam ", "Synchronoise ", "Electro Ball ", "Soak ", "Flame Charge ", "Coil ", "Low Sweep ", "Acid Spray ", "Foul Play ", "Simple Beam ", "Entrainment ", "After You ", "Round ", "Echoed Voice ", "Chip Away ", "Clear Smog ", "Stored Power ", "Quick Guard ", "Ally Switch ", "Scald ", "Shell Smash ", "Heal Pulse ", "Hex ", "Sky Drop ", "Shift Gear ", "Circle Throw ", "Incinerate ", "Quash ", "Acrobatics ", "Reflect Type ", "Retaliate ", "Final Gambit ", "Bestow ", "Inferno ", "Water Pledge ", "Fire Pledge ", "Grass Pledge ", "Volt Switch ", "Struggle Bug ", "Bulldoze ", "Frost Breath ", "Dragon Tail ", "Work Up ", "Electroweb ", "Wild Charge ", "Drill Run ", "Dual Chop ", "Heart Stamp ", "Horn Leech ", "Sacred Sword ", "Razor Shell ", "Heat Crash ", "Leaf Tornado ", "Steamroller ", "Cotton Guard ", "Night Daze ", "Psystrike ", "Tail Slap ", "Hurricane ", "Head Charge ", "Gear Grind ", "Searing Shot ", "Techno Blast ", "Relic Song ", "Secret Sword ", "Glaciate ", "Bolt Strike ", "Blue Flare ", "Fiery Dance ", "Freeze Shock ", "Ice Burn ", "Snarl ", "Icicle Crash ", "V-create ", "Fusion Flare ", "Fusion Bolt ", "Flying Press ", "Mat Block ", "Belch ", "Rototiller ", "Sticky Web ", "Fell Stinger ", "Phantom Force ", "Trick-or-Treat ", "Noble Roar ", "Ion Deluge ", "Parabolic Charge ", "Forest's Curse ", "Petal Blizzard ", "Freeze-Dry ", "Disarming Voice ", "Parting Shot ", "Topsy-Turvy ", "Draining Kiss ", "Crafty Shield ", "Flower Shield ", "Grassy Terrain ", "Misty Terrain ", "Electrify ", "Play Rough ", "Fairy Wind ", "Moonblast ", "Boomburst ", "Fairy Lock ", "King's Shield ", "Play Nice ", "Confide ", "Diamond Storm ", "Steam Eruption ", "Hyperspace Hole ", "Water Shuriken ", "Mystical Fire ", "Spiky Shield ", "Aromatic Mist ", "Eerie Impulse ", "Venom Drench ", "Powder ", "Geomancy ", "Magnetic Flux ", "Happy Hour ", "Electric Terrain ", "Dazzling Gleam ", "Celebrate ", "Hold Hands ", "Baby-Doll Eyes ", "Nuzzle ", "Hold Back ", "Infestation ", "Power-Up Punch ", "Oblivion Wing ", "Thousand Arrows ", "Thousand Waves ", "Land's Wrath ", "Light of Ruin ", "Origin Pulse ", "Precipice Blades ", "Dragon Ascent ", "Hyperspace Fury " });
            move3list.FormattingEnabled = true;
            move3list.Items.AddRange(new object[] { "1" });
            move3list.Location = new Point(413, 56);
            move3list.Margin = new Padding(4, 4, 4, 4);
            move3list.Name = "move3list";
            move3list.Size = new Size(204, 23);
            move3list.TabIndex = 4;
            // 
            // move4list
            // 
            move4list.AllowDrop = true;
            move4list.AutoCompleteCustomSource.AddRange(new string[] { "(None)", "Pound ", "Karate Chop ", "Double Slap ", "Comet Punch ", "Mega Punch ", "Pay Day ", "Fire Punch ", "Ice Punch ", "Thunder Punch ", "Scratch ", "Vice Grip ", "Guillotine ", "Razor Wind ", "Swords Dance ", "Cut ", "Gust ", "Wing Attack ", "Whirlwind ", "Fly ", "Bind ", "Slam ", "Vine Whip ", "Stomp ", "Double Kick ", "Mega Kick ", "Jump Kick ", "Rolling Kick ", "Sand Attack ", "Headbutt ", "Horn Attack ", "Fury Attack ", "Horn Drill ", "Tackle ", "Body Slam ", "Wrap ", "Take Down ", "Thrash ", "Double-Edge ", "Tail Whip ", "Poison Sting ", "Twineedle ", "Pin Missile ", "Leer ", "Bite ", "Growl ", "Roar ", "Sing ", "Supersonic ", "Sonic Boom ", "Disable ", "Acid ", "Ember ", "Flamethrower ", "Mist ", "Water Gun ", "Hydro Pump ", "Surf ", "Ice Beam ", "Blizzard ", "Psybeam ", "Bubble Beam ", "Aurora Beam ", "Hyper Beam ", "Peck ", "Drill Peck ", "Submission ", "Low Kick ", "Counter ", "Seismic Toss ", "Strength ", "Absorb ", "Mega Drain ", "Leech Seed ", "Growth ", "Razor Leaf ", "Solar Beam ", "Poison Powder ", "Stun Spore ", "Sleep Powder ", "Petal Dance ", "String Shot ", "Dragon Rage ", "Fire Spin ", "Thunder Shock ", "Thunderbolt ", "Thunder Wave ", "Thunder ", "Rock Throw ", "Earthquake ", "Fissure ", "Dig ", "Toxic ", "Confusion ", "Psychic ", "Hypnosis ", "Meditate ", "Agility ", "Quick Attack ", "Rage ", "Teleport ", "Night Shade ", "Mimic ", "Screech ", "Double Team ", "Recover ", "Harden ", "Minimize ", "Smokescreen ", "Confuse Ray ", "Withdraw ", "Defense Curl ", "Barrier ", "Light Screen ", "Haze ", "Reflect ", "Focus Energy ", "Bide ", "Metronome ", "Mirror Move ", "Self-Destruct ", "Egg Bomb ", "Lick ", "Smog ", "Sludge ", "Bone Club ", "Fire Blast ", "Waterfall ", "Clamp ", "Swift ", "Skull Bash ", "Spike Cannon ", "Constrict ", "Amnesia ", "Kinesis ", "Soft-Boiled ", "High Jump Kick ", "Glare ", "Dream Eater ", "Poison Gas ", "Barrage ", "Leech Life ", "Lovely Kiss ", "Sky Attack ", "Transform ", "Bubble ", "Dizzy Punch ", "Spore ", "Flash ", "Psywave ", "Splash ", "Acid Armor ", "Crabhammer ", "Explosion ", "Fury Swipes ", "Bonemerang ", "Rest ", "Rock Slide ", "Hyper Fang ", "Sharpen ", "Conversion ", "Tri Attack ", "Super Fang ", "Slash ", "Substitute ", "Struggle ", "Sketch ", "Triple Kick ", "Thief ", "Spider Web ", "Mind Reader ", "Nightmare ", "Flame Wheel ", "Snore ", "Curse ", "Flail ", "Conversion 2 ", "Aeroblast ", "Cotton Spore ", "Reversal ", "Spite ", "Powder Snow ", "Protect ", "Mach Punch ", "Scary Face ", "Feint Attack ", "Sweet Kiss ", "Belly Drum ", "Sludge Bomb ", "Mud-Slap ", "Octazooka ", "Spikes ", "Zap Cannon ", "Foresight ", "Destiny Bond ", "Perish Song ", "Icy Wind ", "Detect ", "Bone Rush ", "Lock-On ", "Outrage ", "Sandstorm ", "Giga Drain ", "Endure ", "Charm ", "Rollout ", "False Swipe ", "Swagger ", "Milk Drink ", "Spark ", "Fury Cutter ", "Steel Wing ", "Mean Look ", "Attract ", "Sleep Talk ", "Heal Bell ", "Return ", "Present ", "Frustration ", "Safeguard ", "Pain Split ", "Sacred Fire ", "Magnitude ", "Dynamic Punch ", "Megahorn ", "Dragon Breath ", "Baton Pass ", "Encore ", "Pursuit ", "Rapid Spin ", "Sweet Scent ", "Iron Tail ", "Metal Claw ", "Vital Throw ", "Morning Sun ", "Synthesis ", "Moonlight ", "Hidden Power ", "Cross Chop ", "Twister ", "Rain Dance ", "Sunny Day ", "Crunch ", "Mirror Coat ", "Psych Up ", "Extreme Speed ", "Ancient Power ", "Shadow Ball ", "Future Sight ", "Rock Smash ", "Whirlpool ", "Beat Up ", "Fake Out ", "Uproar ", "Stockpile ", "Spit Up ", "Swallow ", "Heat Wave ", "Hail ", "Torment ", "Flatter ", "Will-O-Wisp ", "Memento ", "Facade ", "Focus Punch ", "Smelling Salts ", "Follow Me ", "Nature Power ", "Charge ", "Taunt ", "Helping Hand ", "Trick ", "Role Play ", "Wish ", "Assist ", "Ingrain ", "Superpower ", "Magic Coat ", "Recycle ", "Revenge ", "Brick Break ", "Yawn ", "Knock Off ", "Endeavor ", "Eruption ", "Skill Swap ", "Imprison ", "Refresh ", "Grudge ", "Snatch ", "Secret Power ", "Dive ", "Arm Thrust ", "Camouflage ", "Tail Glow ", "Luster Purge ", "Mist Ball ", "Feather Dance ", "Teeter Dance ", "Blaze Kick ", "Mud Sport ", "Ice Ball ", "Needle Arm ", "Slack Off ", "Hyper Voice ", "Poison Fang ", "Crush Claw ", "Blast Burn ", "Hydro Cannon ", "Meteor Mash ", "Astonish ", "Weather Ball ", "Aromatherapy ", "Fake Tears ", "Air Cutter ", "Overheat ", "Odor Sleuth ", "Rock Tomb ", "Silver Wind ", "Metal Sound ", "Grass Whistle ", "Tickle ", "Cosmic Power ", "Water Spout ", "Signal Beam ", "Shadow Punch ", "Extrasensory ", "Sky Uppercut ", "Sand Tomb ", "Sheer Cold ", "Muddy Water ", "Bullet Seed ", "Aerial Ace ", "Icicle Spear ", "Iron Defense ", "Block ", "Howl ", "Dragon Claw ", "Frenzy Plant ", "Bulk Up ", "Bounce ", "Mud Shot ", "Poison Tail ", "Covet ", "Volt Tackle ", "Magical Leaf ", "Water Sport ", "Calm Mind ", "Leaf Blade ", "Dragon Dance ", "Rock Blast ", "Shock Wave ", "Water Pulse ", "Doom Desire ", "Psycho Boost ", "Roost ", "Gravity ", "Miracle Eye ", "Wake-Up Slap ", "Hammer Arm ", "Gyro Ball ", "Healing Wish ", "Brine ", "Natural Gift ", "Feint ", "Pluck ", "Tailwind ", "Acupressure ", "Metal Burst ", "U-turn ", "Close Combat ", "Payback ", "Assurance ", "Embargo ", "Fling ", "Psycho Shift ", "Trump Card ", "Heal Block ", "Wring Out ", "Power Trick ", "Gastro Acid ", "Lucky Chant ", "Me First ", "Copycat ", "Power Swap ", "Guard Swap ", "Punishment ", "Last Resort ", "Worry Seed ", "Sucker Punch ", "Toxic Spikes ", "Heart Swap ", "Aqua Ring ", "Magnet Rise ", "Flare Blitz ", "Force Palm ", "Aura Sphere ", "Rock Polish ", "Poison Jab ", "Dark Pulse ", "Night Slash ", "Aqua Tail ", "Seed Bomb ", "Air Slash ", "X-Scissor ", "Bug Buzz ", "Dragon Pulse ", "Dragon Rush ", "Power Gem ", "Drain Punch ", "Vacuum Wave ", "Focus Blast ", "Energy Ball ", "Brave Bird ", "Earth Power ", "Switcheroo ", "Giga Impact ", "Nasty Plot ", "Bullet Punch ", "Avalanche ", "Ice Shard ", "Shadow Claw ", "Thunder Fang ", "Ice Fang ", "Fire Fang ", "Shadow Sneak ", "Mud Bomb ", "Psycho Cut ", "Zen Headbutt ", "Mirror Shot ", "Flash Cannon ", "Rock Climb ", "Defog ", "Trick Room ", "Draco Meteor ", "Discharge ", "Lava Plume ", "Leaf Storm ", "Power Whip ", "Rock Wrecker ", "Cross Poison ", "Gunk Shot ", "Iron Head ", "Magnet Bomb ", "Stone Edge ", "Captivate ", "Stealth Rock ", "Grass Knot ", "Chatter ", "Judgment ", "Bug Bite ", "Charge Beam ", "Wood Hammer ", "Aqua Jet ", "Attack Order ", "Defend Order ", "Heal Order ", "Head Smash ", "Double Hit ", "Roar of Time ", "Spacial Rend ", "Lunar Dance ", "Crush Grip ", "Magma Storm ", "Dark Void ", "Seed Flare ", "Ominous Wind ", "Shadow Force ", "Hone Claws ", "Wide Guard ", "Guard Split ", "Power Split ", "Wonder Room ", "Psyshock ", "Venoshock ", "Autotomize ", "Rage Powder ", "Telekinesis ", "Magic Room ", "Smack Down ", "Storm Throw ", "Flame Burst ", "Sludge Wave ", "Quiver Dance ", "Heavy Slam ", "Synchronoise ", "Electro Ball ", "Soak ", "Flame Charge ", "Coil ", "Low Sweep ", "Acid Spray ", "Foul Play ", "Simple Beam ", "Entrainment ", "After You ", "Round ", "Echoed Voice ", "Chip Away ", "Clear Smog ", "Stored Power ", "Quick Guard ", "Ally Switch ", "Scald ", "Shell Smash ", "Heal Pulse ", "Hex ", "Sky Drop ", "Shift Gear ", "Circle Throw ", "Incinerate ", "Quash ", "Acrobatics ", "Reflect Type ", "Retaliate ", "Final Gambit ", "Bestow ", "Inferno ", "Water Pledge ", "Fire Pledge ", "Grass Pledge ", "Volt Switch ", "Struggle Bug ", "Bulldoze ", "Frost Breath ", "Dragon Tail ", "Work Up ", "Electroweb ", "Wild Charge ", "Drill Run ", "Dual Chop ", "Heart Stamp ", "Horn Leech ", "Sacred Sword ", "Razor Shell ", "Heat Crash ", "Leaf Tornado ", "Steamroller ", "Cotton Guard ", "Night Daze ", "Psystrike ", "Tail Slap ", "Hurricane ", "Head Charge ", "Gear Grind ", "Searing Shot ", "Techno Blast ", "Relic Song ", "Secret Sword ", "Glaciate ", "Bolt Strike ", "Blue Flare ", "Fiery Dance ", "Freeze Shock ", "Ice Burn ", "Snarl ", "Icicle Crash ", "V-create ", "Fusion Flare ", "Fusion Bolt ", "Flying Press ", "Mat Block ", "Belch ", "Rototiller ", "Sticky Web ", "Fell Stinger ", "Phantom Force ", "Trick-or-Treat ", "Noble Roar ", "Ion Deluge ", "Parabolic Charge ", "Forest's Curse ", "Petal Blizzard ", "Freeze-Dry ", "Disarming Voice ", "Parting Shot ", "Topsy-Turvy ", "Draining Kiss ", "Crafty Shield ", "Flower Shield ", "Grassy Terrain ", "Misty Terrain ", "Electrify ", "Play Rough ", "Fairy Wind ", "Moonblast ", "Boomburst ", "Fairy Lock ", "King's Shield ", "Play Nice ", "Confide ", "Diamond Storm ", "Steam Eruption ", "Hyperspace Hole ", "Water Shuriken ", "Mystical Fire ", "Spiky Shield ", "Aromatic Mist ", "Eerie Impulse ", "Venom Drench ", "Powder ", "Geomancy ", "Magnetic Flux ", "Happy Hour ", "Electric Terrain ", "Dazzling Gleam ", "Celebrate ", "Hold Hands ", "Baby-Doll Eyes ", "Nuzzle ", "Hold Back ", "Infestation ", "Power-Up Punch ", "Oblivion Wing ", "Thousand Arrows ", "Thousand Waves ", "Land's Wrath ", "Light of Ruin ", "Origin Pulse ", "Precipice Blades ", "Dragon Ascent ", "Hyperspace Fury " });
            move4list.FormattingEnabled = true;
            move4list.Items.AddRange(new object[] { "1" });
            move4list.Location = new Point(413, 86);
            move4list.Margin = new Padding(4, 4, 4, 4);
            move4list.Name = "move4list";
            move4list.Size = new Size(204, 23);
            move4list.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 58);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 680;
            label11.Text = "Move 1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 90);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 681;
            label10.Text = "Move 2";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(333, 58);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(55, 15);
            Label4.TabIndex = 682;
            Label4.Text = "Move 3";
            // 
            // pokedextype
            // 
            pokedextype.AllowDrop = true;
            pokedextype.FormattingEnabled = true;
            pokedextype.Items.AddRange(new object[] { "????? Pokémon", "Seed Pokémon", "Seed Pokémon", "Seed Pokémon", "Lizard Pokémon", "Flame Pokémon", "Flame Pokémon", "Tiny Turtle Pokémon", "Turtle Pokémon", "Shellfish Pokémon", "Worm Pokémon", "Cocoon Pokémon", "Butterfly Pokémon", "Hairy Bug Pokémon", "Cocoon Pokémon", "Poison Bee Pokémon", "Tiny Bird Pokémon", "Bird Pokémon", "Bird Pokémon", "Mouse Pokémon", "Mouse Pokémon", "Tiny Bird Pokémon", "Beak Pokémon", "Snake Pokémon", "Cobra Pokémon", "Mouse Pokémon", "Mouse Pokémon", "Mouse Pokémon", "Mouse Pokémon", "Poison Pin Pokémon", "Poison Pin Pokémon", "Drill Pokémon", "Poison Pin Pokémon", "Poison Pin Pokémon", "Drill Pokémon", "Fairy Pokémon", "Fairy Pokémon", "Fox Pokémon", "Fox Pokémon", "Balloon Pokémon", "Balloon Pokémon", "Bat Pokémon", "Bat Pokémon", "Weed Pokémon", "Weed Pokémon", "Flower Pokémon", "Mushroom Pokémon", "Mushroom Pokémon", "Insect Pokémon", "Poison Moth Pokémon", "Mole Pokémon", "Mole Pokémon", "Scratch Cat Pokémon", "Classy Cat Pokémon", "Duck Pokémon", "Duck Pokémon", "Pig Monkey Pokémon", "Pig Monkey Pokémon", "Puppy Pokémon", "Legendary Pokémon", "Tadpole Pokémon", "Tadpole Pokémon", "Tadpole Pokémon", "Psi Pokémon", "Psi Pokémon", "Psi Pokémon", "Superpower Pokémon", "Superpower Pokémon", "Superpower Pokémon", "Flower Pokémon", "Flycatcher Pokémon", "Flycatcher Pokémon", "Jellyfish Pokémon", "Jellyfish Pokémon", "Rock Pokémon", "Rock Pokémon", "Megaton Pokémon", "Fire Horse Pokémon", "Fire Horse Pokémon", "Dopey Pokémon", "Hermit Crab Pokémon", "Magnet Pokémon", "Magnet Pokémon", "Wild Duck Pokémon", "Twin Bird Pokémon", "Triple Bird Pokémon", "Sea Lion Pokémon", "Sea Lion Pokémon", "Sludge Pokémon", "Sludge Pokémon", "Bivalve Pokémon", "Bivalve Pokémon", "Gas Pokémon", "Gas Pokémon", "Shadow Pokémon", "Rock Snake Pokémon", "Hypnosis Pokémon", "Hypnosis Pokémon", "River Crab Pokémon", "Pincer Pokémon", "Ball Pokémon", "Ball Pokémon", "Egg Pokémon", "Coconut Pokémon", "Lonely Pokémon", "Bone Keeper Pokémon", "Kicking Pokémon", "Punching Pokémon", "Licking Pokémon", "Poison Gas Pokémon", "Poison Gas Pokémon", "Spikes Pokémon", "Drill Pokémon", "Egg Pokémon", "Vine Pokémon", "Parent Pokémon", "Dragon Pokémon", "Dragon Pokémon", "Goldfish Pokémon", "Goldfish Pokémon", "Star Shape Pokémon", "Mysterious Pokémon", "Barrier Pokémon", "Mantis Pokémon", "Human Shape Pokémon", "Electric Pokémon", "Spitfire Pokémon", "Stag Beetle Pokémon", "Wild Bull Pokémon", "Fish Pokémon", "Atrocious Pokémon", "Transport Pokémon", "Transform Pokémon", "Evolution Pokémon", "Bubble Jet Pokémon", "Lightning Pokémon", "Flame Pokémon", "Virtual Pokémon", "Spiral Pokémon", "Spiral Pokémon", "Shellfish Pokémon", "Shellfish Pokémon", "Fossil Pokémon", "Sleeping Pokémon", "Freeze Pokémon", "Electric Pokémon", "Flame Pokémon", "Dragon Pokémon", "Dragon Pokémon", "Dragon Pokémon", "Genetic Pokémon", "New Species Pokémon", "Leaf Pokémon", "Leaf Pokémon", "Herb Pokémon", "Fire Mouse Pokémon", "Volcano Pokémon", "Volcano Pokémon", "Big Jaw Pokémon", "Big Jaw Pokémon", "Big Jaw Pokémon", "Scout Pokémon", "Long Body Pokémon", "Owl Pokémon", "Owl Pokémon", "Five Star Pokémon", "Five Star Pokémon", "String Spit Pokémon", "Long Leg Pokémon", "Bat Pokémon", "Angler Pokémon", "Light Pokémon", "Tiny Mouse Pokémon", "Star Shape Pokémon", "Balloon Pokémon", "Spike Ball Pokémon", "Happiness Pokémon", "Tiny Bird Pokémon", "Mystic Pokémon", "Wool Pokémon", "Wool Pokémon", "Light Pokémon", "Flower Pokémon", "Aqua Mouse Pokémon", "Aqua Rabbit Pokémon", "Imitation Pokémon", "Frog Pokémon", "Cottonweed Pokémon", "Cottonweed Pokémon", "Cottonweed Pokémon", "Long Tail Pokémon", "Seed Pokémon", "Sun Pokémon", "Clear Wing Pokémon", "Water Fish Pokémon", "Water Fish Pokémon", "Sun Pokémon", "Moonlight Pokémon", "Darkness Pokémon", "Royal Pokémon", "Screech Pokémon", "Symbol Pokémon", "Patient Pokémon", "Long Neck Pokémon", "Bagworm Pokémon", "Bagworm Pokémon", "Land Snake Pokémon", "Fly Scorpion Pokémon", "Iron Snake Pokémon", "Fairy Pokémon", "Fairy Pokémon", "Balloon Pokémon", "Pincer Pokémon", "Mold Pokémon", "Single Horn Pokémon", "Sharp Claw Pokémon", "Little Bear Pokémon", "Hibernator Pokémon", "Lava Pokémon", "Lava Pokémon", "Pig Pokémon", "Swine Pokémon", "Coral Pokémon", "Jet Pokémon", "Jet Pokémon", "Delivery Pokémon", "Kite Pokémon", "Armor Bird Pokémon", "Dark Pokémon", "Dark Pokémon", "Dragon Pokémon", "Long Nose Pokémon", "Armor Pokémon", "Virtual Pokémon", "Big Horn Pokémon", "Painter Pokémon", "Scuffle Pokémon", "Handstand Pokémon", "Kiss Pokémon", "Electric Pokémon", "Live Coal Pokémon", "Milk Cow Pokémon", "Happiness Pokémon", "Thunder Pokémon", "Volcano Pokémon", "Aurora Pokémon", "Rock Skin Pokémon", "Hard Shell Pokémon", "Armor Pokémon", "Diving Pokémon", "Rainbow Pokémon", "Time Travel Pokémon", "Wood Gecko Pokémon", "Wood Gecko Pokémon", "Forest Pokémon", "Chick Pokémon", "Young Fowl Pokémon", "Blaze Pokémon", "Mud Fish Pokémon", "Mud Fish Pokémon", "Mud Fish Pokémon", "Bite Pokémon", "Bite Pokémon", "Tiny Raccoon Pokémon", "Rushing Pokémon", "Worm Pokémon", "Cocoon Pokémon", "Butterfly Pokémon", "Cocoon Pokémon", "Poison Moth Pokémon", "Water Weed Pokémon", "Jolly Pokémon", "Carefree Pokémon", "Acorn Pokémon", "Wily Pokémon", "Wicked Pokémon", "Tiny Swallow Pokémon", "Swallow Pokémon", "Seagull Pokémon", "Water Bird Pokémon", "Feeling Pokémon", "Emotion Pokémon", "Embrace Pokémon", "Pond Skater Pokémon", "Eyeball Pokémon", "Mushroom Pokémon", "Mushroom Pokémon", "Slacker Pokémon", "Wild Monkey Pokémon", "Lazy Pokémon", "Trainee Pokémon", "Ninja Pokémon", "Shed Pokémon", "Whisper Pokémon", "Big Voice Pokémon", "Loud Noise Pokémon", "Guts Pokémon", "Arm Thrust Pokémon", "Polka Dot Pokémon", "Compass Pokémon", "Kitten Pokémon", "Prim Pokémon", "Darkness Pokémon", "Deceiver Pokémon", "Iron Armor Pokémon", "Iron Armor Pokémon", "Iron Armor Pokémon", "Meditate Pokémon", "Meditate Pokémon", "Lightning Pokémon", "Discharge Pokémon", "Cheering Pokémon", "Cheering Pokémon", "Firefly Pokémon", "Firefly Pokémon", "Thorn Pokémon", "Stomach Pokémon", "Poison Bag Pokémon", "Savage Pokémon", "Brutal Pokémon", "Ball Whale Pokémon", "Float Whale Pokémon", "Numb Pokémon", "Eruption Pokémon", "Coal Pokémon", "Bounce Pokémon", "Manipulate Pokémon", "Spot Panda Pokémon", "Ant Pit Pokémon", "Vibration Pokémon", "Mystic Pokémon", "Cactus Pokémon", "Scarecrow Pokémon", "Cotton Bird Pokémon", "Humming Pokémon", "Cat Ferret Pokémon", "Fang Snake Pokémon", "Meteorite Pokémon", "Meteorite Pokémon", "Whiskers Pokémon", "Whiskers Pokémon", "Ruffian Pokémon", "Rogue Pokémon", "Clay Doll Pokémon", "Clay Doll Pokémon", "Sea Lily Pokémon", "Barnacle Pokémon", "Old Shrimp Pokémon", "Plate Pokémon", "Fish Pokémon", "Tender Pokémon", "Weather Pokémon", "Color Swap Pokémon", "Puppet Pokémon", "Marionette Pokémon", "Requiem Pokémon", "Beckon Pokémon", "Fruit Pokémon", "Wind Chime Pokémon", "Disaster Pokémon", "Bright Pokémon", "Snow Hat Pokémon", "Face Pokémon", "Clap Pokémon", "Ball Roll Pokémon", "Ice Break Pokémon", "Bivalve Pokémon", "Deep Sea Pokémon", "South Sea Pokémon", "Longevity Pokémon", "Rendezvous Pokémon", "Rock Head Pokémon", "Endurance Pokémon", "Dragon Pokémon", "Iron Ball Pokémon", "Iron Claw Pokémon", "Iron Leg Pokémon", "Rock Peak Pokémon", "Iceberg Pokémon", "Iron Pokémon", "Eon Pokémon", "Eon Pokémon", "Sea Basin Pokémon", "Continent Pokémon", "Sky High Pokémon", "Wish Pokémon", "DNA Pokémon", "Tiny Leaf Pokémon", "Grove Pokémon", "Continent Pokémon", "Chimp Pokémon", "Playful Pokémon", "Flame Pokémon", "Penguin Pokémon", "Penguin Pokémon", "Emperor Pokémon", "Starling Pokémon", "Starling Pokémon", "Predator Pokémon", "Plump Mouse Pokémon", "Beaver Pokémon", "Cricket Pokémon", "Cricket Pokémon", "Flash Pokémon", "Spark Pokémon", "Gleam Eyes Pokémon", "Bud Pokémon", "Bouquet Pokémon", "Head Butt Pokémon", "Head Butt Pokémon", "Shield Pokémon", "Shield Pokémon", "Bagworm Pokémon", "Bagworm Pokémon", "Moth Pokémon", "Tiny Bee Pokémon", "Beehive Pokémon", "EleSquirrel Pokémon", "Sea Weasel Pokémon", "Sea Weasel Pokémon", "Cherry Pokémon", "Blossom Pokémon", "Sea Slug Pokémon", "Sea Slug Pokémon", "Long Tail Pokémon", "Balloon Pokémon", "Blimp Pokémon", "Rabbit Pokémon", "Rabbit Pokémon", "Magical Pokémon", "Big Boss Pokémon", "Catty Pokémon", "Tiger Cat Pokémon", "Bell Pokémon", "Skunk Pokémon", "Skunk Pokémon", "Bronze Pokémon", "Bronze Bell Pokémon", "Bonsai Pokémon", "Mime Pokémon", "Playhouse Pokémon", "Music Note Pokémon", "Forbidden Pokémon", "Land Shark Pokémon", "Cave Pokémon", "Mach Pokémon", "Big Eater Pokémon", "Emanation Pokémon", "Aura Pokémon", "Hippo Pokémon", "Heavyweight Pokémon", "Scorpion Pokémon", "Ogre Scorpion Pokémon", "Toxic Mouth Pokémon", "Toxic Mouth Pokémon", "Bug Catcher Pokémon", "Wing Fish Pokémon", "Neon Pokémon", "Kite Pokémon", "Frost Tree Pokémon", "Frost Tree Pokémon", "Sharp Claw Pokémon", "Magnet Area Pokémon", "Licking Pokémon", "Drill Pokémon", "Vine Pokémon", "Thunderbolt Pokémon", "Blast Pokémon", "Jubilee Pokémon", "Ogre Darner Pokémon", "Verdant Pokémon", "Fresh Snow Pokémon", "Fang Scorpion Pokémon", "Twin Tusk Pokémon", "Virtual Pokémon", "Blade Pokémon", "Compass Pokémon", "Gripper Pokémon", "Snow Land Pokémon", "Plasma Pokémon", "Knowledge Pokémon", "Emotion Pokémon", "Willpower Pokémon", "Temporal Pokémon", "Spatial Pokémon", "Lava Dome Pokémon", "Colossal Pokémon", "Renegade Pokémon", "Lunar Pokémon", "Sea Drifter Pokémon", "Seafaring Pokémon", "Pitch-Black Pokémon", "Gratitude Pokémon", "Alpha Pokémon", "Victory Pokémon", "Grass Snake Pokémon", "Grass Snake Pokémon", "Regal Pokémon", "Fire Pig Pokémon", "Fire Pig Pokémon", "Mega Fire Pig Pokémon", "Sea Otter Pokémon", "Discipline Pokémon", "Formidable Pokémon", "Scout Pokémon", "Lookout Pokémon", "Puppy Pokémon", "Loyal Dog Pokémon", "Big-Hearted Pokémon", "Devious Pokémon", "Cruel Pokémon", "Grass Monkey Pokémon", "Thorn Monkey Pokémon", "High Temp Pokémon", "Ember Pokémon", "Spray Pokémon", "Geyser Pokémon", "Dream Eater Pokémon", "Drowsing Pokémon", "Tiny Pigeon Pokémon", "Wild Pigeon Pokémon", "Proud Pokémon", "Electrified Pokémon", "Thunderbolt Pokémon", "Mantle Pokémon", "Ore Pokémon", "Compressed Pokémon", "Bat Pokémon", "Courting Pokémon", "Mole Pokémon", "Subterrene Pokémon", "Hearing Pokémon", "Muscular Pokémon", "Muscular Pokémon", "Muscular Pokémon", "Tadpole Pokémon", "Vibration Pokémon", "Vibration Pokémon", "Judo Pokémon", "Karate Pokémon", "Sewing Pokémon", "Leaf-Wrapped Pokémon", "Nurturing Pokémon", "Centipede Pokémon", "Curlipede Pokémon", "Megapede Pokémon", "Cotton Puff Pokémon", "Windveiled Pokémon", "Bulb Pokémon", "Flowering Pokémon", "Hostile Pokémon", "Desert Croc Pokémon", "Desert Croc Pokémon", "Intimidation Pokémon", "Zen Charm Pokémon", "Blazing Pokémon", "Cactus Pokémon", "Rock Inn Pokémon", "Stone Home Pokémon", "Shedding Pokémon", "Hoodlum Pokémon", "Avianoid Pokémon", "Spirit Pokémon", "Coffin Pokémon", "Prototurtle Pokémon", "Prototurtle Pokémon", "First Bird Pokémon", "First Bird Pokémon", "Trash Bag Pokémon", "Trash Heap Pokémon", "Tricky Fox Pokémon", "Illusion Fox Pokémon", "Chinchilla Pokémon", "Scarf Pokémon", "Fixation Pokémon", "Manipulate Pokémon", "Astral Body Pokémon", "Cell Pokémon", "Mitosis Pokémon", "Multiplying Pokémon", "Water Bird Pokémon", "White Bird Pokémon", "Fresh Snow Pokémon", "Icy Snow Pokémon", "Snowstorm Pokémon", "Season Pokémon", "Season Pokémon", "Sky Squirrel Pokémon", "Clamping Pokémon", "Cavalry Pokémon", "Mushroom Pokémon", "Mushroom Pokémon", "Floating Pokémon", "Floating Pokémon", "Caring Pokémon", "Attaching Pokémon", "EleSpider Pokémon", "Thorn Seed Pokémon", "Thorn Pod Pokémon", "Gear Pokémon", "Gear Pokémon", "Gear Pokémon", "EleFish Pokémon", "EleFish Pokémon", "EleFish Pokémon", "Cerebral Pokémon", "Cerebral Pokémon", "Candle Pokémon", "Lamp Pokémon", "Luring Pokémon", "Tusk Pokémon", "Axe Jaw Pokémon", "Axe Jaw Pokémon", "Chill Pokémon", "Freezing Pokémon", "Crystallizing Pokémon", "Snail Pokémon", "Shell Out Pokémon", "Trap Pokémon", "Martial Arts Pokémon", "Martial Arts Pokémon", "Cave Pokémon", "Automaton Pokémon", "Automaton Pokémon", "Sharp Blade Pokémon", "Sword Blade Pokémon", "Bash Buffalo Pokémon", "Eaglet Pokémon", "Valiant Pokémon", "Diapered Pokémon", "Bone Vulture Pokémon", "Anteater Pokémon", "Iron Ant Pokémon", "Irate Pokémon", "Hostile Pokémon", "Brutal Pokémon", "Torch Pokémon", "Sun Pokémon", "Iron Will Pokémon", "Cavern Pokémon", "Grassland Pokémon", "Cyclone Pokémon", "Bolt Strike Pokémon", "Vast White Pokémon", "Deep Black Pokémon", "Abundance Pokémon", "Boundary Pokémon", "Colt Pokémon", "Melody Pokémon", "Paleozoic Pokémon", "Spiny Nut Pokémon", "Spiny Armor Pokémon", "Spiny Armor Pokémon", "Fox Pokémon", "Fox Pokémon", "Fox Pokémon", "Bubble Frog Pokémon", "Bubble Frog Pokémon", "Ninja Pokémon", "Digging Pokémon", "Digging Pokémon", "Tiny Robin Pokémon", "Ember Pokémon", "Scorching Pokémon", "Scatterdust Pokémon", "Scatterdust Pokémon", "Scale Pokémon", "Lion Cub Pokémon", "Royal Pokémon", "Single Bloom Pokémon", "Single Bloom Pokémon", "Garden Pokémon", "Mount Pokémon", "Mount Pokémon", "Playful Pokémon", "Daunting Pokémon", "Poodle Pokémon", "Restraint Pokémon", "Constraint Pokémon", "Sword Pokémon", "Sword Pokémon", "Royal Sword Pokémon", "Perfume Pokémon", "Fragrance Pokémon", "Cotton Candy Pokémon", "Meringue Pokémon", "Revolving Pokémon", "Overturning Pokémon", "Two-Handed Pokémon", "Collective Pokémon", "Mock Kelp Pokémon", "Mock Kelp Pokémon", "Water Gun Pokémon", "Howitzer Pokémon", "Generator Pokémon", "Generator Pokémon", "Royal Heir Pokémon", "Despot Pokémon", "Tundra Pokémon", "Tundra Pokémon", "Intertwining Pokémon", "Wrestling Pokémon", "Antenna Pokémon", "Jewel Pokémon", "Soft Tissue Pokémon", "Soft Tissue Pokémon", "Dragon Pokémon", "Key Ring Pokémon", "Stump Pokémon", "Elder Tree Pokémon", "Pumpkin Pokémon", "Pumpkin Pokémon", "Ice Chunk Pokémon", "Iceberg Pokémon", "Sound Wave Pokémon", "Sound Wave Pokémon", "Life Pokémon", "Destruction Pokémon", "Order Pokémon", "Jewel Pokémon", "Mischief Pokémon", "Steam Pokémon", "Grass Quill Pokémon", "Blade Quill Pokémon", "Arrow Quill Pokémon", "Fire Cat Pokémon", "Fire Cat Pokémon", "Heel Pokémon", "Sea Lion Pokémon", "Pop Star Pokémon", "Soloist Pokémon", "Woodpecker Pokémon", "Bugle Beak Pokémon", "Cannon Pokémon", "Loitering Pokémon", "Stakeout Pokémon", "Larva Pokémon", "Battery Pokémon", "Stag Beetle Pokémon", "Boxing Pokémon", "Woolly Crab Pokémon", "Dancing Pokémon", "Bee Fly Pokémon", "Bee Fly Pokémon", "Puppy Pokémon", "Wolf Pokémon", "Small Fry Pokémon", "Brutal Star Pokémon", "Brutal Star Pokémon", "Donkey Pokémon", "Draft Horse Pokémon", "Water Bubble Pokémon", "Water Bubble Pokémon", "Sickle Grass Pokémon", "Bloom Sickle Pokémon", "Illuminating Pokémon", "Illuminating Pokémon", "Toxic Lizard Pokémon", "Toxic Lizard Pokémon", "Flailing Pokémon", "Strong Arm Pokémon", "Fruit Pokémon", "Fruit Pokémon", "Fruit Pokémon", "Posy Picker Pokémon", "Sage Pokémon", "Teamwork Pokémon", "Turn Tail Pokémon", "Hard Scale Pokémon", "Sand Heap Pokémon", "Sand Castle Pokémon", "Sea Cucumber Pokémon", "Synthetic Pokémon", "Synthetic Pokémon", "Meteor Pokémon", "Drowsing Pokémon", "Blast Turtle Pokémon", "Roly-Poly Pokémon", "Disguise Pokémon", "Gnash Teeth Pokémon", "Placid Pokémon", "Sea Creeper Pokémon", "Scaly Pokémon", "Scaly Pokémon", "Scaly Pokémon", "Land Spirit Pokémon", "Land Spirit Pokémon", "Land Spirit Pokémon", "Land Spirit Pokémon", "Nebula Pokémon", "Protostar Pokémon", "Sunne Pokémon", "Moone Pokémon", "Parasite Pokémon", "Swollen Pokémon", "Lissome Pokémon", "Glowing Pokémon", "Launch Pokémon", "Drawn Sword Pokémon", "Junkivore Pokémon", "Prism Pokémon", "Artificial Pokémon", "Gloomdweller Pokémon", "Poison Pin Pokémon", "Poison Pin Pokémon", "Rampart Pokémon", "Fireworks Pokémon", "Thunderclap Pokémon", "Hex Nut Pokémon", "Hex Nut Pokémon", "Chimp Pokémon", "Beat Pokémon", "Drummer Pokémon", "Rabbit Pokémon", "Rabbit Pokémon", "Striker Pokémon", "Water Lizard Pokémon", "Water Lizard Pokémon", "Secret Agent Pokémon", "Cheeky Pokémon", "Greedy Pokémon", "Tiny Bird Pokémon", "Raven Pokémon", "Raven Pokémon", "Larva Pokémon", "Radome Pokémon", "Seven Spot Pokémon", "Fox Pokémon", "Fox Pokémon", "Flowering Pokémon", "Cotton Bloom Pokémon", "Sheep Pokémon", "Sheep Pokémon", "Snapping Pokémon", "Bite Pokémon", "Puppy Pokémon", "Dog Pokémon", "Coal Pokémon", "Coal Pokémon", "Coal Pokémon", "Apple Core Pokémon", "Apple Wing Pokémon", "Apple Nectar Pokémon", "Sand Snake Pokémon", "Sand Snake Pokémon", "Gulp Pokémon", "Rush Pokémon", "Skewer Pokémon", "Baby Pokémon", "Punk Pokémon", "Radiator Pokémon", "Radiator Pokémon", "Tantrum Pokémon", "Jujitsu Pokémon", "Black Tea Pokémon", "Black Tea Pokémon", "Calm Pokémon", "Serene Pokémon", "Silent Pokémon", "Wily Pokémon", "Devious Pokémon", "Bulk Up Pokémon", "Blocking Pokémon", "Viking Pokémon", "Coral Pokémon", "Wild Duck Pokémon", "Comedian Pokémon", "Grudge Pokémon", "Cream Pokémon", "Cream Pokémon", "Formation Pokémon", "Sea Urchin Pokémon", "Worm Pokémon", "Frost Moth Pokémon", "Big Rock Pokémon", "Penguin Pokémon", "Emotion Pokémon", "Two-Sided Pokémon", "Copperderm Pokémon", "Copperderm Pokémon", "Fossil Pokémon", "Fossil Pokémon", "Fossil Pokémon", "Fossil Pokémon", "Alloy Pokémon", "Lingering Pokémon", "Caretaker Pokémon", "Stealth Pokémon", "Warrior Pokémon", "Warrior Pokémon", "Gigantic Pokémon", "Wushu Pokémon", "Wushu Pokémon", "Rogue Monkey Pokémon", "Unique Horn Pokémon", "Unique Horn Pokémon", "Dancing Pokémon", "Zen Charm Pokémon", "Djinn Pokémon", "?" });
            pokedextype.Location = new Point(537, 92);
            pokedextype.Margin = new Padding(4, 4, 4, 4);
            pokedextype.Name = "pokedextype";
            pokedextype.Size = new Size(204, 23);
            pokedextype.TabIndex = 15;
            pokedextype.Visible = false;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(333, 90);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(55, 15);
            Label5.TabIndex = 683;
            Label5.Text = "Move 4";
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.Enabled = false;
            Label21.Location = new Point(32, 338);
            Label21.Margin = new Padding(4, 0, 4, 0);
            Label21.Name = "Label21";
            Label21.Size = new Size(87, 15);
            Label21.TabIndex = 694;
            Label21.Text = "Line Count";
            Label21.Visible = false;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(333, 30);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(23, 15);
            Label6.TabIndex = 684;
            Label6.Text = "OT";
            // 
            // pokemonlc
            // 
            pokemonlc.Enabled = false;
            pokemonlc.Location = new Point(120, 334);
            pokemonlc.Margin = new Padding(4, 4, 4, 4);
            pokemonlc.MaxLength = 1;
            pokemonlc.Name = "pokemonlc";
            pokemonlc.Size = new Size(204, 25);
            pokemonlc.TabIndex = 12;
            pokemonlc.Visible = false;
            // 
            // otnamebox
            // 
            otnamebox.Location = new Point(413, 24);
            otnamebox.Margin = new Padding(4, 4, 4, 4);
            otnamebox.MaxLength = 12;
            otnamebox.Name = "otnamebox";
            otnamebox.Size = new Size(204, 25);
            otnamebox.TabIndex = 6;
            otnamebox.TextChanged += otnamebox_TextChanged;
            // 
            // OTG
            // 
            OTG.AllowDrop = true;
            OTG.DropDownStyle = ComboBoxStyle.Simple;
            OTG.FormattingEnabled = true;
            OTG.Items.AddRange(new object[] { "M", "F" });
            OTG.Location = new Point(537, 176);
            OTG.Margin = new Padding(4, 4, 4, 4);
            OTG.Name = "OTG";
            OTG.Size = new Size(47, 24);
            OTG.TabIndex = 7;
            OTG.Visible = false;
            // 
            // languagebox
            // 
            languagebox.AutoCompleteCustomSource.AddRange(new string[] { "ENG", "FRE", "GER", "ITA", "JPN", "KOR", "SPA" });
            languagebox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            languagebox.FormattingEnabled = true;
            languagebox.Items.AddRange(new object[] { "Unset", "JPN", "ENG", "FRE", "ITA", "GER", "???", "SPA", "KOR", "CHS", "CHT", "??2" });
            languagebox.Location = new Point(104, 118);
            languagebox.Margin = new Padding(4, 4, 4, 4);
            languagebox.Name = "languagebox";
            languagebox.Size = new Size(204, 23);
            languagebox.TabIndex = 8;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(16, 122);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(71, 15);
            Label7.TabIndex = 688;
            Label7.Text = "Language";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(itemnameplural);
            tabPage3.Controls.Add(nitem6);
            tabPage3.Controls.Add(nitem5);
            tabPage3.Controls.Add(nitem4);
            tabPage3.Controls.Add(nitem3);
            tabPage3.Controls.Add(nitem2);
            tabPage3.Controls.Add(nitem1);
            tabPage3.Controls.Add(itemslc);
            tabPage3.Controls.Add(Label20);
            tabPage3.Controls.Add(Label18);
            tabPage3.Controls.Add(Label17);
            tabPage3.Controls.Add(Label16);
            tabPage3.Controls.Add(Label15);
            tabPage3.Controls.Add(Label14);
            tabPage3.Controls.Add(itembox6);
            tabPage3.Controls.Add(itembox5);
            tabPage3.Controls.Add(itembox4);
            tabPage3.Controls.Add(itembox3);
            tabPage3.Controls.Add(itembox2);
            tabPage3.Controls.Add(itembox1);
            tabPage3.Controls.Add(Label13);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Margin = new Padding(4, 4, 4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(687, 275);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Items";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // itemnameplural
            // 
            itemnameplural.AllowDrop = true;
            itemnameplural.AutoCompleteCustomSource.AddRange(new string[] { "None", "Master Ball", "Ultra Ball", "Great Ball", "Poké Ball", "Safari Ball", "Net Ball", "Dive Ball", "Nest Ball", "Repeat Ball", "Timer Ball", "Luxury Ball", "Premier Ball", "Dusk Ball", "Heal Ball", "Quick Ball", "Cherish Ball", "Potion", "Antidote", "Burn Heal", "Ice Heal", "Awakening", "Paralyze Heal", "Full Restore", "Max Potion", "Hyper Potion", "Super Potion", "Full Heal", "Revive", "Max Revive", "Fresh Water", "Soda Pop", "Lemonade", "Moomoo Milk", "Energy Powder", "Energy Root", "Heal Powder", "Revival Herb", "Ether", "Max Ether", "Elixir", "Max Elixir", "Lava Cookie", "Berry Juice", "Sacred Ash", "HP Up", "Protein", "Iron", "Carbos", "Calcium", "Rare Candy", "PP Up", "Zinc", "PP Max", "Old Gateau", "Guard Spec.", "Dire Hit", "X Attack", "X Defense", "X Speed", "X Accuracy", "X Sp. Atk", "X Sp. Def", "Poké Doll", "Fluffy Tail", "Blue Flute", "Yellow Flute", "Red Flute", "Black Flute", "White Flute", "Shoal Salt", "Shoal Shell", "Red Shard", "Blue Shard", "Yellow Shard", "Green Shard", "Super Repel", "Max Repel", "Escape Rope", "Repel", "Sun Stone", "Moon Stone", "Fire Stone", "Thunder Stone", "Water Stone", "Leaf Stone", "Tiny Mushroom", "Big Mushroom", "Pearl", "Big Pearl", "Stardust", "Star Piece", "Nugget", "Heart Scale", "Honey", "Growth Mulch", "Damp Mulch", "Stable Mulch", "Gooey Mulch", "Root Fossil", "Claw Fossil", "Helix Fossil", "Dome Fossil", "Old Amber", "Armor Fossil", "Skull Fossil", "Rare Bone", "Shiny Stone", "Dusk Stone", "Dawn Stone", "Oval Stone", "Odd Keystone", "Griseous Orb", "???", "???", "???", "Douse Drive", "Shock Drive", "Burn Drive", "Chill Drive", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Sweet Heart", "Adamant Orb", "Lustrous Orb", "Greet Mail", "Favored Mail", "RSVP Mail", "Thanks Mail", "Inquiry Mail", "Like Mail", "Reply Mail", "Bridge Mail S", "Bridge Mail D", "Bridge Mail T", "Bridge Mail V", "Bridge Mail M", "Cheri Berry", "Chesto Berry", "Pecha Berry", "Rawst Berry", "Aspear Berry", "Leppa Berry", "Oran Berry", "Persim Berry", "Lum Berry", "Sitrus Berry", "Figy Berry", "Wiki Berry", "Mago Berry", "Aguav Berry", "Iapapa Berry", "Razz Berry", "Bluk Berry", "Nanab Berry", "Wepear Berry", "Pinap Berry", "Pomeg Berry", "Kelpsy Berry", "Qualot Berry", "Hondew Berry", "Grepa Berry", "Tamato Berry", "Cornn Berry", "Magost Berry", "Rabuta Berry", "Nomel Berry", "Spelon Berry", "Pamtre Berry", "Watmel Berry", "Durin Berry", "Belue Berry", "Occa Berry", "Passho Berry", "Wacan Berry", "Rindo Berry", "Yache Berry", "Chople Berry", "Kebia Berry", "Shuca Berry", "Coba Berry", "Payapa Berry", "Tanga Berry", "Charti Berry", "Kasib Berry", "Haban Berry", "Colbur Berry", "Babiri Berry", "Chilan Berry", "Liechi Berry", "Ganlon Berry", "Salac Berry", "Petaya Berry", "Apicot Berry", "Lansat Berry", "Starf Berry", "Enigma Berry", "Micle Berry", "Custap Berry", "Jaboca Berry", "Rowap Berry", "Bright Powder", "White Herb", "Macho Brace", "Exp. Share", "Quick Claw", "Soothe Bell", "Mental Herb", "Choice Band", "King’s Rock", "Silver Powder", "Amulet Coin", "Cleanse Tag", "Soul Dew", "Deep Sea Tooth", "Deep Sea Scale", "Smoke Ball", "Everstone", "Focus Band", "Lucky Egg", "Scope Lens", "Metal Coat", "Leftovers", "Dragon Scale", "Light Ball", "Soft Sand", "Hard Stone", "Miracle Seed", "Black Glasses", "Black Belt", "Magnet", "Mystic Water", "Sharp Beak", "Poison Barb", "Never-Melt Ice", "Spell Tag", "Twisted Spoon", "Charcoal", "Dragon Fang", "Silk Scarf", "Up-Grade", "Shell Bell", "Sea Incense", "Lax Incense", "Lucky Punch", "Metal Powder", "Thick Club", "Stick", "Red Scarf", "Blue Scarf", "Pink Scarf", "Green Scarf", "Yellow Scarf", "Wide Lens", "Muscle Band", "Wise Glasses", "Expert Belt", "Light Clay", "Life Orb", "Power Herb", "Toxic Orb", "Flame Orb", "Quick Powder", "Focus Sash", "Zoom Lens", "Metronome", "Iron Ball", "Lagging Tail", "Destiny Knot", "Black Sludge", "Icy Rock", "Smooth Rock", "Heat Rock", "Damp Rock", "Grip Claw", "Choice Scarf", "Sticky Barb", "Power Bracer", "Power Belt", "Power Lens", "Power Band", "Power Anklet", "Power Weight", "Shed Shell", "Big Root", "Choice Specs", "Flame Plate", "Splash Plate", "Zap Plate", "Meadow Plate", "Icicle Plate", "Fist Plate", "Toxic Plate", "Earth Plate", "Sky Plate", "Mind Plate", "Insect Plate", "Stone Plate", "Spooky Plate", "Draco Plate", "Dread Plate", "Iron Plate", "Odd Incense", "Rock Incense", "Full Incense", "Wave Incense", "Rose Incense", "Luck Incense", "Pure Incense", "Protector", "Electirizer", "Magmarizer", "Dubious Disc", "Reaper Cloth", "Razor Claw", "Razor Fang", "TM01", "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11", "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21", "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31", "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41", "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "TM51", "TM52", "TM53", "TM54", "TM55", "TM56", "TM57", "TM58", "TM59", "TM60", "TM61", "TM62", "TM63", "TM64", "TM65", "TM66", "TM67", "TM68", "TM69", "TM70", "TM71", "TM72", "TM73", "TM74", "TM75", "TM76", "TM77", "TM78", "TM79", "TM80", "TM81", "TM82", "TM83", "TM84", "TM85", "TM86", "TM87", "TM88", "TM89", "TM90", "TM91", "TM92", "HM01", "HM02", "HM03", "HM04", "HM05", "HM06", "???", "???", "Explorer Kit", "Loot Sack", "Rule Book", "Poké Radar", "Point Card", "Journal", "Seal Case", "Fashion Case", "Seal Bag", "Pal Pad", "Works Key", "Old Charm", "Galactic Key", "Red Chain", "Town Map", "Vs. Seeker", "Coin Case", "Old Rod", "Good Rod", "Super Rod", "Sprayduck", "Poffin Case", "Bike", "Suite Key", "Oak’s Letter", "Lunar Wing", "Member Card", "Azure Flute", "S.S. Ticket", "Contest Pass", "Magma Stone", "Parcel", "Coupon 1", "Coupon 2", "Coupon 3", "Storage Key", "Secret Potion", "Vs. Recorder", "Gracidea", "Secret Key", "Apricorn Box", "Unown Report", "Berry Pots", "Dowsing Machine", "Blue Card", "Slowpoke Tail", "Clear Bell", "Card Key", "Basement Key", "Squirt Bottle", "Red Scale", "Lost Item", "Pass", "Machine Part", "Silver Wing", "Rainbow Wing", "Mystery Egg", "Red Apricorn", "Blue Apricorn", "Yellow Apricorn", "Green Apricorn", "Pink Apricorn", "White Apricorn", "Black Apricorn", "Fast Ball", "Level Ball", "Lure Ball", "Heavy Ball", "Love Ball", "Friend Ball", "Moon Ball", "Sport Ball", "Park Ball", "Photo Album", "GB Sounds", "Tidal Bell", "Rage Candy Bar", "Data Card 01", "Data Card 02", "Data Card 03", "Data Card 04", "Data Card 05", "Data Card 06", "Data Card 07", "Data Card 08", "Data Card 09", "Data Card 10", "Data Card 11", "Data Card 12", "Data Card 13", "Data Card 14", "Data Card 15", "Data Card 16", "Data Card 17", "Data Card 18", "Data Card 19", "Data Card 20", "Data Card 21", "Data Card 22", "Data Card 23", "Data Card 24", "Data Card 25", "Data Card 26", "Data Card 27", "Jade Orb", "Lock Capsule", "Red Orb", "Blue Orb", "Enigma Stone", "Prism Scale", "Eviolite", "Float Stone", "Rocky Helmet", "Air Balloon", "Red Card", "Ring Target", "Binding Band", "Absorb Bulb", "Cell Battery", "Eject Button", "Fire Gem", "Water Gem", "Electric Gem", "Grass Gem", "Ice Gem", "Fighting Gem", "Poison Gem", "Ground Gem", "Flying Gem", "Psychic Gem", "Bug Gem", "Rock Gem", "Ghost Gem", "Dragon Gem", "Dark Gem", "Steel Gem", "Normal Gem", "Health Wing", "Muscle Wing", "Resist Wing", "Genius Wing", "Clever Wing", "Swift Wing", "Pretty Wing", "Cover Fossil", "Plume Fossil", "Liberty Pass", "Pass Orb", "Dream Ball", "Poké Toy", "Prop Case", "Dragon Skull", "Balm Mushroom", "Big Nugget", "Pearl String", "Comet Shard", "Relic Copper", "Relic Silver", "Relic Gold", "Relic Vase", "Relic Band", "Relic Statue", "Relic Crown", "Casteliacone", "Dire Hit 2", "X Speed 2", "X Sp. Atk 2", "X Sp. Def 2", "X Defense 2", "X Attack 2", "X Accuracy 2", "X Speed 3", "X Sp. Atk 3", "X Sp. Def 3", "X Defense 3", "X Attack 3", "X Accuracy 3", "X Speed 6", "X Sp. Atk 6", "X Sp. Def 6", "X Defense 6", "X Attack 6", "X Accuracy 6", "Ability Urge", "Item Drop", "Item Urge", "Reset Urge", "Dire Hit 3", "Light Stone", "Dark Stone", "TM93", "TM94", "TM95", "Xtransceiver", "???", "Gram 1", "Gram 2", "Gram 3", "Xtransceiver", "Medal Box", "DNA Splicers", "DNA Splicers", "Permit", "Oval Charm", "Shiny Charm", "Plasma Card", "Grubby Hanky", "Colress Machine", "Dropped Item", "Dropped Item", "Reveal Glass", "Weakness Policy", "Assault Vest", "Holo Caster", "Prof’s Letter", "Roller Skates", "Pixie Plate", "Ability Capsule", "Whipped Dream", "Sachet", "Luminous Moss", "Snowball", "Safety Goggles", "Poké Flute", "Rich Mulch", "Surprise Mulch", "Boost Mulch", "Amaze Mulch", "Gengarite", "Gardevoirite", "Ampharosite", "Venusaurite", "Charizardite X", "Blastoisinite", "Mewtwonite X", "Mewtwonite Y", "Blazikenite", "Medichamite", "Houndoominite", "Aggronite", "Banettite", "Tyranitarite", "Scizorite", "Pinsirite", "Aerodactylite", "Lucarionite", "Abomasite", "Kangaskhanite", "Gyaradosite", "Absolite", "Charizardite Y", "Alakazite", "Heracronite", "Mawilite", "Manectite", "Garchompite", "Latiasite", "Latiosite", "Roseli Berry", "Kee Berry", "Maranga Berry", "Sprinklotad", "TM96", "TM97", "TM98", "TM99", "TM100", "Power Plant Pass", "Mega Ring", "Intriguing Stone", "Common Stone", "Discount Coupon", "Elevator Key", "TMV Pass", "Honor of Kalos", "Adventure Rules", "Strange Souvenir", "Lens Case", "Makeup Bag", "Travel Trunk", "Lumiose Galette", "Shalour Sable", "Jaw Fossil", "Sail Fossil", "Looker Ticket", "Bike", "Holo Caster", "Fairy Gem", "Mega Charm", "Mega Glove", "Mach Bike", "Acro Bike", "Wailmer Pail", "Devon Parts", "Soot Sack", "Basement Key", "Pokéblock Kit", "Letter", "Eon Ticket", "Scanner", "Go-Goggles", "Meteorite", "Key to Room 1", "Key to Room 2", "Key to Room 4", "Key to Room 6", "Storage Key", "Devon Scope", "S.S. Ticket", "HM07", "Devon Scuba Gear", "Contest Costume", "Contest Costume", "Magma Suit", "Aqua Suit", "Pair of Tickets", "Mega Bracelet", "Mega Pendant", "Mega Glasses", "Mega Anchor", "Mega Stickpin", "Mega Tiara", "Mega Anklet", "Meteorite", "Swampertite", "Sceptilite", "Sablenite", "Altarianite", "Galladite", "Audinite", "Metagrossite", "Sharpedonite", "Slowbronite", "Steelixite", "Pidgeotite", "Glalitite", "Diancite", "Prison Bottle", "Mega Cuff", "Cameruptite", "Lopunnite", "Salamencite", "Beedrillite", "Meteorite", "Meteorite", "Key Stone", "Meteorite Shard", "Eon Flute", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Z-Ring", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "UB Ball *", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a" });
            itemnameplural.FormattingEnabled = true;
            itemnameplural.Items.AddRange(new object[] { "None", "Master Balls", "Ultra Balls", "Great Balls", "Poké Balls", "Safari Balls", "Net Balls", "Dive Balls", "Nest Balls", "Repeat Balls", "Timer Balls", "Luxury Balls", "Premier Balls", "Dusk Balls", "Heal Balls", "Quick Balls", "Cherish Balls", "Potions", "Antidotes", "Burn Heals", "Ice Heals", "Awakenings", "Paralyze Heals", "Full Restores", "Max Potions", "Hyper Potions", "Super Potions", "Full Heals", "Revives", "Max Revives", "Fresh Waters", "Soda Pops", "Lemonades", "Moomoo Milks", "Energy Powders", "Energy Roots", "Heal Powders", "Revival Herbs", "Ethers", "Max Ethers", "Elixirs", "Max Elixirs", "Lava Cookies", "Berry Juices", "Sacred Ashes", "HP Ups", "Proteins", "Irons", "Carbos", "Calciums", "Rare Candies", "PP Ups", "Zincs", "PP Maxes", "Old Gateaux", "Guard Specs.", "Dire Hits", "X Attacks", "X Defenses", "X Speeds", "X Accuracies", "X Sp. Atks", "X Sp. Defs", "Poké Dolls", "Fluffy Tails", "Blue Flutes", "Yellow Flutes", "Red Flutes", "Black Flutes", "White Flutes", "Shoal Salts", "Shoal Shells", "Red Shards", "Blue Shards", "Yellow Shards", "Green Shards", "Super Repels", "Max Repels", "Escape Ropes", "Repels", "Sun Stones", "Moon Stones", "Fire Stones", "Thunder Stones", "Water Stones", "Leaf Stones", "Tiny Mushrooms", "Big Mushrooms", "Pearls", "Big Pearls", "Stardusts", "Star Pieces", "Nuggets", "Heart Scales", "Honey", "Growth Mulch", "Damp Mulch", "Stable Mulch", "Gooey Mulch", "Root Fossils", "Claw Fossils", "Helix Fossils", "Dome Fossils", "Old Ambers", "Armor Fossils", "Skull Fossils", "Rare Bones", "Shiny Stones", "Dusk Stones", "Dawn Stones", "Oval Stones", "Odd Keystones", "Griseous Orbs", "Tea", "???", "Autographs", "Douse Drives", "Shock Drives", "Burn Drives", "Chill Drives", "???", "Pokémon Box Links", "Medicine Pockets", "TM Cases", "Candy Jars", "Power-Up Pockets", "Clothing Trunks", "Catching Pockets", "Battle Pockets", "???", "???", "???", "???", "???", "Sweet Hearts", "Adamant Orbs", "Lustrous Orbs", "Greet Mail", "Favored Mail", "RSVP Mail", "Thanks Mail", "Inquiry Mail", "Like Mail", "Reply Mail", "Bridge Mail S", "Bridge Mail D", "Bridge Mail T", "Bridge Mail V", "Bridge Mail M", "Cheri Berries", "Chesto Berries", "Pecha Berries", "Rawst Berries", "Aspear Berries", "Leppa Berries", "Oran Berries", "Persim Berries", "Lum Berries", "Sitrus Berries", "Figy Berries", "Wiki Berries", "Mago Berries", "Aguav Berries", "Iapapa Berries", "Razz Berries", "Bluk Berries", "Nanab Berries", "Wepear Berries", "Pinap Berries", "Pomeg Berries", "Kelpsy Berries", "Qualot Berries", "Hondew Berries", "Grepa Berries", "Tamato Berries", "Cornn Berries", "Magost Berries", "Rabuta Berries", "Nomel Berries", "Spelon Berries", "Pamtre Berries", "Watmel Berries", "Durin Berries", "Belue Berries", "Occa Berries", "Passho Berries", "Wacan Berries", "Rindo Berries", "Yache Berries", "Chople Berries", "Kebia Berries", "Shuca Berries", "Coba Berries", "Payapa Berries", "Tanga Berries", "Charti Berries", "Kasib Berries", "Haban Berries", "Colbur Berries", "Babiri Berries", "Chilan Berries", "Liechi Berries", "Ganlon Berries", "Salac Berries", "Petaya Berries", "Apicot Berries", "Lansat Berries", "Starf Berries", "Enigma Berries", "Micle Berries", "Custap Berries", "Jaboca Berries", "Rowap Berries", "Bright Powders", "White Herbs", "Macho Braces", "Exp. Shares", "Quick Claws", "Soothe Bells", "Mental Herbs", "Choice Bands", "King’s Rocks", "Silver Powders", "Amulet Coins", "Cleanse Tags", "Soul Dews", "Deep Sea Teeth", "Deep Sea Scales", "Smoke Balls", "Everstones", "Focus Bands", "Lucky Eggs", "Scope Lenses", "Metal Coats", "Leftovers", "Dragon Scales", "Light Balls", "Soft Sand", "Hard Stones", "Miracle Seeds", "Black Glasses", "Black Belts", "Magnets", "Mystic Waters", "Sharp Beaks", "Poison Barbs", "Never-Melt Ices", "Spell Tags", "Twisted Spoons", "Charcoals", "Dragon Fangs", "Silk Scarves", "Upgrades", "Shell Bells", "Sea Incenses", "Lax Incenses", "Lucky Punches", "Metal Powders", "Thick Clubs", "Leeks", "Red Scarves", "Blue Scarves", "Pink Scarves", "Green Scarves", "Yellow Scarves", "Wide Lenses", "Muscle Bands", "Wise Glasses", "Expert Belts", "Light Clays", "Life Orbs", "Power Herbs", "Toxic Orbs", "Flame Orbs", "Quick Powders", "Focus Sashes", "Zoom Lenses", "Metronomes", "Iron Balls", "Lagging Tails", "Destiny Knots", "Black Sludges", "Icy Rocks", "Smooth Rocks", "Heat Rocks", "Damp Rocks", "Grip Claws", "Choice Scarves", "Sticky Barbs", "Power Bracers", "Power Belts", "Power Lenses", "Power Bands", "Power Anklets", "Power Weights", "Shed Shells", "Big Roots", "Choice Specs", "Flame Plates", "Splash Plates", "Zap Plates", "Meadow Plates", "Icicle Plates", "Fist Plates", "Toxic Plates", "Earth Plates", "Sky Plates", "Mind Plates", "Insect Plates", "Stone Plates", "Spooky Plates", "Draco Plates", "Dread Plates", "Iron Plates", "Odd Incenses", "Rock Incenses", "Full Incenses", "Wave Incenses", "Rose Incenses", "Luck Incenses", "Pure Incenses", "Protectors", "Electirizers", "Magmarizers", "Dubious Discs", "Reaper Cloths", "Razor Claws", "Razor Fangs", "TM01s", "TM02s", "TM03s", "TM04s", "TM05s", "TM06s", "TM07s", "TM08s", "TM09s", "TM10s", "TM11s", "TM12s", "TM13s", "TM14s", "TM15s", "TM16s", "TM17s", "TM18s", "TM19s", "TM20s", "TM21s", "TM22s", "TM23s", "TM24s", "TM25s", "TM26s", "TM27s", "TM28s", "TM29s", "TM30s", "TM31s", "TM32s", "TM33s", "TM34s", "TM35s", "TM36s", "TM37s", "TM38s", "TM39s", "TM40s", "TM41s", "TM42s", "TM43s", "TM44s", "TM45s", "TM46s", "TM47s", "TM48s", "TM49s", "TM50s", "TM51s", "TM52s", "TM53s", "TM54s", "TM55s", "TM56s", "TM57s", "TM58s", "TM59s", "TM60s", "TM61s", "TM62s", "TM63s", "TM64s", "TM65s", "TM66s", "TM67s", "TM68s", "TM69s", "TM70s", "TM71s", "TM72s", "TM73s", "TM74s", "TM75s", "TM76s", "TM77s", "TM78s", "TM79s", "TM80s", "TM81s", "TM82s", "TM83s", "TM84s", "TM85s", "TM86s", "TM87s", "TM88s", "TM89s", "TM90s", "TM91s", "TM92s", "HM01s", "HM02s", "HM03s", "HM04s", "HM05s", "HM06s", "???", "???", "Explorer Kits", "Loot Sacks", "Rule Books", "Poké Radars", "Point Cards", "Journals", "Seal Cases", "Fashion Cases", "Seal Bags", "Pal Pads", "Works Keys", "Old Charms", "Galactic Keys", "Red Chains", "Town Maps", "Vs. Seekers", "Coin Cases", "Old Rods", "Good Rods", "Super Rods", "Sprayducks", "Poffin Cases", "Bikes", "Suite Keys", "Oak’s Letters", "Lunar Wings", "Member Cards", "Azure Flutes", "S.S. Tickets", "Contest Passes", "Magma Stones", "Parcels", "Coupon 1s", "Coupon 2s", "Coupon 3s", "Storage Keys", "Secret Potions", "Vs. Recorders", "Gracideas", "Secret Keys", "Apricorn Boxes", "Unown Reports", "Berry Pots", "Dowsing Machines", "Blue Cards", "Slowpoke Tails", "Clear Bells", "Card Keys", "Basement Keys", "Squirt Bottles", "Red Scales", "Lost Items", "Passes", "Machine Parts", "Silver Wings", "Rainbow Wings", "Mystery Eggs", "Red Apricorns", "Blue Apricorns", "Yellow Apricorns", "Green Apricorns", "Pink Apricorns", "White Apricorns", "Black Apricorns", "Fast Balls", "Level Balls", "Lure Balls", "Heavy Balls", "Love Balls", "Friend Balls", "Moon Balls", "Sport Balls", "Park Balls", "Photo Albums", "GB Sounds", "Tidal Bells", "Rage Candy Bars", "Data Card 01s", "Data Card 02s", "Data Card 03s", "Data Card 04s", "Data Card 05s", "Data Card 06s", "Data Card 07s", "Data Card 08s", "Data Card 09s", "Data Card 10s", "Data Card 11s", "Data Card 12s", "Data Card 13s", "Data Card 14s", "Data Card 15s", "Data Card 16s", "Data Card 17s", "Data Card 18s", "Data Card 19s", "Data Card 20s", "Data Card 21s", "Data Card 22s", "Data Card 23s", "Data Card 24s", "Data Card 25s", "Data Card 26s", "Data Card 27s", "Jade Orbs", "Lock Capsules", "Red Orbs", "Blue Orbs", "Enigma Stones", "Prism Scales", "Eviolites", "Float Stones", "Rocky Helmets", "Air Balloons", "Red Cards", "Ring Targets", "Binding Bands", "Absorb Bulbs", "Cell Batteries", "Eject Buttons", "Fire Gems", "Water Gems", "Electric Gems", "Grass Gems", "Ice Gems", "Fighting Gems", "Poison Gems", "Ground Gems", "Flying Gems", "Psychic Gems", "Bug Gems", "Rock Gems", "Ghost Gems", "Dragon Gems", "Dark Gems", "Steel Gems", "Normal Gems", "Health Feathers", "Muscle Feathers", "Resist Feathers", "Genius Feathers", "Clever Feathers", "Swift Feathers", "Pretty Feathers", "Cover Fossils", "Plume Fossils", "Liberty Passes", "Pass Orbs", "Dream Balls", "Poké Toys", "Prop Cases", "Dragon Skulls", "Balm Mushrooms", "Big Nuggets", "Pearl Strings", "Comet Shards", "Relic Coppers", "Relic Silvers", "Relic Golds", "Relic Vases", "Relic Bands", "Relic Statues", "Relic Crowns", "Casteliacones", "Dire Hit 2s", "X Speed 2s", "X Sp. Atk 2s", "X Sp. Def 2s", "X Defense 2s", "X Attack 2s", "X Accuracy 2s", "X Speed 3s", "X Sp. Atk 3s", "X Sp. Def 3s", "X Defense 3s", "X Attack 3s", "X Accuracy 3s", "X Speed 6s", "X Sp. Atk 6s", "X Sp. Def 6s", "X Defense 6s", "X Attack 6s", "X Accuracy 6s", "Ability Urges", "Item Drops", "Item Urges", "Reset Urges", "Dire Hit 3s", "Light Stones", "Dark Stones", "TM93s", "TM94s", "TM95s", "Xtransceivers", "???", "Gram 1s", "Gram 2s", "Gram 3s", "Xtransceivers", "Medal Boxes", "DNA Splicers", "DNA Splicers", "Permits", "Oval Charms", "Shiny Charms", "Plasma Cards", "Grubby Hankies", "Colress Machines", "Dropped Items", "Dropped Items", "Reveal Glasses", "Weakness Policies", "Assault Vests", "Holo Casters", "Prof’s Letters", "Roller Skates", "Pixie Plates", "Ability Capsules", "Whipped Dreams", "Sachets", "Luminous Moss", "Snowballs", "Safety Goggles", "Poké Flutes", "Rich Mulch", "Surprise Mulch", "Boost Mulch", "Amaze Mulch", "Gengarites", "Gardevoirites", "Ampharosites", "Venusaurites", "Charizardite Xs", "Blastoisinites", "Mewtwonite Xs", "Mewtwonite Ys", "Blazikenites", "Medichamites", "Houndoominites", "Aggronites", "Banettites", "Tyranitarites", "Scizorites", "Pinsirites", "Aerodactylites", "Lucarionites", "Abomasites", "Kangaskhanites", "Gyaradosites", "Absolites", "Charizardite Ys", "Alakazites", "Heracronites", "Mawilites", "Manectites", "Garchompites", "Latiasites", "Latiosites", "Roseli Berries", "Kee Berries", "Maranga Berries", "Sprinklotads", "TM96s", "TM97s", "TM98s", "TM99s", "TM100s", "Power Plant Passes", "Mega Rings", "Intriguing Stones", "Common Stones", "Discount Coupons", "Elevator Keys", "TMV Passes", "Honors of Kalos", "Adventure Guides", "Strange Souvenirs", "Lens Cases", "Makeup Bags", "Travel Trunks", "Lumiose Galettes", "Shalour Sables", "Jaw Fossils", "Sail Fossils", "Looker Tickets", "Bikes", "Holo Casters", "Fairy Gems", "Mega Charms", "Mega Gloves", "Mach Bikes", "Acro Bikes", "Wailmer Pails", "Devon Parts", "Soot Sacks", "Basement Keys", "Pokéblock Kits", "Letters", "Eon Tickets", "Scanners", "Go-Goggles", "Meteorites", "Keys to Room 1", "Keys to Room 2", "Keys to Room 4", "Keys to Room 6", "Storage Keys", "Devon Scopes", "S.S. Tickets", "HM07s", "Devon Scuba Gear", "Contest Costumes", "Contest Costumes", "Magma Suits", "Aqua Suits", "Pair of Tickets", "Mega Bracelets", "Mega Pendants", "Mega Glasses", "Mega Anchors", "Mega Stickpins", "Mega Tiaras", "Mega Anklets", "Meteorites", "Swampertites", "Sceptilites", "Sablenites", "Altarianites", "Galladites", "Audinites", "Metagrossites", "Sharpedonites", "Slowbronites", "Steelixites", "Pidgeotites", "Glalitites", "Diancites", "Prison Bottles", "Mega Cuffs", "Cameruptites", "Lopunnites", "Salamencites", "Beedrillites", "Meteorites", "Meteorites", "Key Stones", "Meteorite Shards", "Eon Flutes", "Normalium Zs", "Firium Zs", "Waterium Zs", "Electrium Zs", "Grassium Zs", "Icium Zs", "Fightinium Zs", "Poisonium Zs", "Groundium Zs", "Flyinium Zs", "Psychium Zs", "Buginium Zs", "Rockium Zs", "Ghostium Zs", "Dragonium Zs", "Darkinium Zs", "Steelium Zs", "Fairium Zs", "Pikanium Zs", "Bottle Caps", "Gold Bottle Caps", "Z-Rings", "Decidium Zs", "Incinium Zs", "Primarium Zs", "Tapunium Zs", "Marshadium Zs", "Aloraichium Zs", "Snorlium Zs", "Eevium Zs", "Mewnium Zs", "Normalium Zs", "Firium Zs", "Waterium Zs", "Electrium Zs", "Grassium Zs", "Icium Zs", "Fightinium Zs", "Poisonium Zs", "Groundium Zs", "Flyinium Zs", "Psychium Zs", "Buginium Zs", "Rockium Zs", "Ghostium Zs", "Dragonium Zs", "Darkinium Zs", "Steelium Zs", "Fairium Zs", "Pikanium Zs", "Decidium Zs", "Incinium Zs", "Primarium Zs", "Tapunium Zs", "Marshadium Zs", "Aloraichium Zs", "Snorlium Zs", "Eevium Zs", "Mewnium Zs", "Pikashunium Zs", "Pikashunium Zs", "???", "???", "???", "???", "Forage Bags", "Fishing Rods", "Professor’s Masks", "Festival Tickets", "Sparkling Stones", "Adrenaline Orbs", "Zygarde Cubes", "???", "Ice Stones", "Ride Pagers", "Beast Balls", "Big Malasadas", "Red Nectars", "Yellow Nectars", "Pink Nectars", "Purple Nectars", "Sun Flutes", "Moon Flutes", "???", "Enigmatic Cards", "Silver Razz Berries", "Golden Razz Berries", "Silver Nanab Berries", "Golden Nanab Berries", "Silver Pinap Berries", "Golden Pinap Berries", "???", "???", "???", "???", "???", "Secret Keys", "S.S. Tickets", "Silph Scopes", "Parcels", "Card Keys", "Gold Teeth", "Lift Keys", "Terrain Extenders", "Protective Pads", "Electric Seeds", "Psychic Seeds", "Misty Seeds", "Grassy Seeds", "Stretchy Springs", "Chalky Stones", "Marbles", "Lone Earrings", "Beach Glass", "Gold Leaves", "Silver Leaves", "Polished Mud Balls", "Tropical Shells", "Leaf Letters", "Leaf Letters", "Small Bouquets", "???", "???", "???", "Lures", "Super Lures", "Max Lures", "Pewter Crunchies", "Fighting Memories", "Flying Memories", "Poison Memories", "Ground Memories", "Rock Memories", "Bug Memories", "Ghost Memories", "Steel Memories", "Fire Memories", "Water Memories", "Grass Memories", "Electric Memories", "Psychic Memories", "Ice Memories", "Dragon Memories", "Dark Memories", "Fairy Memories", "Solganium Zs", "Lunalium Zs", "Ultranecrozium Zs", "Mimikium Zs", "Lycanium Zs", "Kommonium Zs", "Solganium Zs", "Lunalium Zs", "Ultranecrozium Zs", "Mimikium Zs", "Lycanium Zs", "Kommonium Zs", "Z-Power Rings", "Pink Petals", "Orange Petals", "Blue Petals", "Red Petals", "Green Petals", "Yellow Petals", "Purple Petals", "Rainbow Flowers", "Surge Badges", "N-Solarizers", "N-Lunarizers", "N-Solarizers", "N-Lunarizers", "Ilima Normalium Zs", "Left Poké Balls", "Roto Hatches", "Roto Bargains", "Roto Prize Money", "Roto Exp. Points", "Roto Friendships", "Roto Encounters", "Roto Stealths", "Roto HP Restores", "Roto PP Restores", "Roto Boosts", "Roto Catches", "Health Candies", "Mighty Candies", "Tough Candies", "Smart Candies", "Courage Candies", "Quick Candies", "Health Candies L", "Mighty Candies L", "Tough Candies L", "Smart Candies L", "Courage Candies L", "Quick Candies L", "Health Candies XL", "Mighty Candies XL", "Tough Candies XL", "Smart Candies XL", "Courage Candies XL", "Quick Candies XL", "Bulbasaur Candies", "Charmander Candies", "Squirtle Candies", "Caterpie Candies", "Weedle Candies", "Pidgey Candies", "Rattata Candies", "Spearow Candies", "Ekans Candies", "Pikachu Candies", "Sandshrew Candies", "Nidoran♀ Candies", "Nidoran♂ Candies", "Clefairy Candies", "Vulpix Candies", "Jigglypuff Candies", "Zubat Candies", "Oddish Candies", "Paras Candies", "Venonat Candies", "Diglett Candies", "Meowth Candies", "Psyduck Candies", "Mankey Candies", "Growlithe Candies", "Poliwag Candies", "Abra Candies", "Machop Candies", "Bellsprout Candies", "Tentacool Candies", "Geodude Candies", "Ponyta Candies", "Slowpoke Candies", "Magnemite Candies", "Farfetch’d Candies", "Doduo Candies", "Seel Candies", "Grimer Candies", "Shellder Candies", "Gastly Candies", "Onix Candies", "Drowzee Candies", "Krabby Candies", "Voltorb Candies", "Exeggcute Candies", "Cubone Candies", "Hitmonlee Candies", "Hitmonchan Candies", "Lickitung Candies", "Koffing Candies", "Rhyhorn Candies", "Chansey Candies", "Tangela Candies", "Kangaskhan Candies", "Horsea Candies", "Goldeen Candies", "Staryu Candies", "Mr. Mime Candies", "Scyther Candies", "Jynx Candies", "Electabuzz Candies", "Pinsir Candies", "Tauros Candies", "Magikarp Candies", "Lapras Candies", "Ditto Candies", "Eevee Candies", "Porygon Candies", "Omanyte Candies", "Kabuto Candies", "Aerodactyl Candies", "Snorlax Candies", "Articuno Candies", "Zapdos Candies", "Moltres Candies", "Dratini Candies", "Mewtwo Candies", "Mew Candies", "Meltan Candies", "Magmar Candies", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Endorsements", "Pokémon Box Links", "Wishing Stars", "Dynamax Bands", "???", "???", "Fishing Rods", "Rotom Bikes", "???", "???", "Sausages", "Bob’s Food Tins", "Bach’s Food Tins", "Tins of Beans", "Bread", "Pasta", "Mixed Mushrooms", "Smoke-Poke Tails", "Large Leeks", "Fancy Apples", "Brittle Bones", "Packs of Potatoes", "Pungent Roots", "Salad Mixes", "Fried Foods", "Boiled Eggs", "Camping Gears", "???", "???", "Rusted Swords", "Rusted Shields", "Fossilized Birds", "Fossilized Fish", "Fossilized Drakes", "Fossilized Dinos", "Strawberry Sweets", "Love Sweets", "Berry Sweets", "Clover Sweets", "Flower Sweets", "Star Sweets", "Ribbon Sweets", "Sweet Apples", "Tart Apples", "Throat Sprays", "Eject Packs", "Heavy-Duty Boots", "Blunder Policies", "Room Service", "Utility Umbrellas", "Exp. Candies XS", "Exp. Candies S", "Exp. Candies M", "Exp. Candies L", "Exp. Candies XL", "Dynamax Candies", "TR00s", "TR01s", "TR02s", "TR03s", "TR04s", "TR05s", "TR06s", "TR07s", "TR08s", "TR09s", "TR10s", "TR11s", "TR12s", "TR13s", "TR14s", "TR15s", "TR16s", "TR17s", "TR18s", "TR19s", "TR20s", "TR21s", "TR22s", "TR23s", "TR24s", "TR25s", "TR26s", "TR27s", "TR28s", "TR29s", "TR30s", "TR31s", "TR32s", "TR33s", "TR34s", "TR35s", "TR36s", "TR37s", "TR38s", "TR39s", "TR40s", "TR41s", "TR42s", "TR43s", "TR44s", "TR45s", "TR46s", "TR47s", "TR48s", "TR49s", "TR50s", "TR51s", "TR52s", "TR53s", "TR54s", "TR55s", "TR56s", "TR57s", "TR58s", "TR59s", "TR60s", "TR61s", "TR62s", "TR63s", "TR64s", "TR65s", "TR66s", "TR67s", "TR68s", "TR69s", "TR70s", "TR71s", "TR72s", "TR73s", "TR74s", "TR75s", "TR76s", "TR77s", "TR78s", "TR79s", "TR80s", "TR81s", "TR82s", "TR83s", "TR84s", "TR85s", "TR86s", "TR87s", "TR88s", "TR89s", "TR90s", "TR91s", "TR92s", "TR93s", "TR94s", "TR95s", "TR96s", "TR97s", "TR98s", "TR99s", "TM00s", "Lonely Mints", "Adamant Mints", "Naughty Mints", "Brave Mints", "Bold Mints", "Impish Mints", "Lax Mints", "Relaxed Mints", "Modest Mints", "Mild Mints", "Rash Mints", "Quiet Mints", "Calm Mints", "Gentle Mints", "Careful Mints", "Sassy Mints", "Timid Mints", "Hasty Mints", "Jolly Mints", "Naive Mints", "Serious Mints", "Wishing Pieces", "Cracked Pots", "Chipped Pots", "Hi-tech Earbuds", "Fruit Bunches", "Moomoo Cheese", "Spice Mix", "Fresh Cream", "Packaged Curry", "Coconut Milk", "Instant Noodles", "Precooked Burgers", "Gigantamixes", "Wishing Chips", "Rotom Bikes", "Catching Charms", "???", "Old Letters", "Band Autographs", "Sonia’s Books", "???", "???", "???", "???", "???", "???", "Rotom Catalogs", "★And458s", "★And15s", "★And337s", "★And603s", "★And390s", "★Sgr6879s", "★Sgr6859s", "★Sgr6913s", "★Sgr7348s", "★Sgr7121s", "★Sgr6746s", "★Sgr7194s", "★Sgr7337s", "★Sgr7343s", "★Sgr6812s", "★Sgr7116s", "★Sgr7264s", "★Sgr7597s", "★Del7882s", "★Del7906s", "★Del7852s", "★Psc596s", "★Psc361s", "★Psc510s", "★Psc437s", "★Psc8773s", "★Lep1865s", "★Lep1829s", "★Boo5340s", "★Boo5506s", "★Boo5435s", "★Boo5602s", "★Boo5733s", "★Boo5235s", "★Boo5351s", "★Hya3748s", "★Hya3903s", "★Hya3418s", "★Hya3482s", "★Hya3845s", "★Eri1084s", "★Eri472s", "★Eri1666s", "★Eri897s", "★Eri1231s", "★Eri874s", "★Eri1298s", "★Eri1325s", "★Eri984s", "★Eri1464s", "★Eri1393s", "★Eri850s", "★Tau1409s", "★Tau1457s", "★Tau1165s", "★Tau1791s", "★Tau1910s", "★Tau1346s", "★Tau1373s", "★Tau1412s", "★CMa2491s", "★CMa2693s", "★CMa2294s", "★CMa2827s", "★CMa2282s", "★CMa2618s", "★CMa2657s", "★CMa2646s", "★UMa4905s", "★UMa4301s", "★UMa5191s", "★UMa5054s", "★UMa4295s", "★UMa4660s", "★UMa4554s", "★UMa4069s", "★UMa3569s", "★UMa3323s", "★UMa4033s", "★UMa4377s", "★UMa4375s", "★UMa4518s", "★UMa3594s", "★Vir5056s", "★Vir4825s", "★Vir4932s", "★Vir4540s", "★Vir4689s", "★Vir5338s", "★Vir4910s", "★Vir5315s", "★Vir5359s", "★Vir5409s", "★Vir5107s", "★Ari617s", "★Ari553s", "★Ari546s", "★Ari951s", "★Ori1713s", "★Ori2061s", "★Ori1790s", "★Ori1903s", "★Ori1948s", "★Ori2004s", "★Ori1852s", "★Ori1879s", "★Ori1899s", "★Ori1543s", "★Cas21s", "★Cas168s", "★Cas403s", "★Cas153s", "★Cas542s", "★Cas219s", "★Cas265s", "★Cnc3572s", "★Cnc3208s", "★Cnc3461s", "★Cnc3449s", "★Cnc3429s", "★Cnc3627s", "★Cnc3268s", "★Cnc3249s", "★Com4968s", "★Crv4757s", "★Crv4623s", "★Crv4662s", "★Crv4786s", "★Aur1708s", "★Aur2088s", "★Aur1605s", "★Aur2095s", "★Aur1577s", "★Aur1641s", "★Aur1612s", "★Pav7790s", "★Cet911s", "★Cet681s", "★Cet188s", "★Cet539s", "★Cet804s", "★Cep8974s", "★Cep8162s", "★Cep8238s", "★Cep8417s", "★Cen5267s", "★Cen5288s", "★Cen551s", "★Cen5459s", "★Cen5460s", "★CMi2943s", "★CMi2845s", "★Equ8131s", "★Vul7405s", "★UMi424s", "★UMi5563s", "★UMi5735s", "★UMi6789s", "★Crt4287s", "★Lyr7001s", "★Lyr7178s", "★Lyr7106s", "★Lyr7298s", "★Ara6585s", "★Sco6134s", "★Sco6527s", "★Sco6553s", "★Sco5953s", "★Sco5984s", "★Sco6508s", "★Sco6084s", "★Sco5944s", "★Sco6630s", "★Sco6027s", "★Sco6247s", "★Sco6252s", "★Sco5928s", "★Sco6241s", "★Sco6165s", "★Tri544s", "★Leo3982s", "★Leo4534s", "★Leo4357s", "★Leo4057s", "★Leo4359s", "★Leo4031s", "★Leo3852s", "★Leo3905s", "★Leo3773s", "★Gru8425s", "★Gru8636s", "★Gru8353s", "★Lib5685s", "★Lib5531s", "★Lib5787s", "★Lib5603s", "★Pup3165s", "★Pup3185s", "★Pup3045s", "★Cyg7924s", "★Cyg7417s", "★Cyg7796s", "★Cyg8301s", "★Cyg7949s", "★Cyg7528s", "★Oct7228s", "★Col1956s", "★Col2040s", "★Col2177s", "★Gem2990s", "★Gem2891s", "★Gem2421s", "★Gem2473s", "★Gem2216s", "★Gem2777s", "★Gem2650s", "★Gem2286s", "★Gem2484s", "★Gem2930s", "★Peg8775s", "★Peg8781s", "★Peg39s", "★Peg8308s", "★Peg8650s", "★Peg8634s", "★Peg8684s", "★Peg8450s", "★Peg8880s", "★Peg8905s", "★Oph6556s", "★Oph6378s", "★Oph6603s", "★Oph6149s", "★Oph6056s", "★Oph6075s", "★Ser5854s", "★Ser7141s", "★Ser5879s", "★Her6406s", "★Her6148s", "★Her6410s", "★Her6526s", "★Her6117s", "★Her6008s", "★Per936s", "★Per1017s", "★Per1131s", "★Per1228s", "★Per834s", "★Per941s", "★Phe99s", "★Phe338s", "★Vel3634s", "★Vel3485s", "★Vel3734s", "★Aqr8232s", "★Aqr8414s", "★Aqr8709s", "★Aqr8518s", "★Aqr7950s", "★Aqr8499s", "★Aqr8610s", "★Aqr8264s", "★Cru4853s", "★Cru4730s", "★Cru4763s", "★Cru4700s", "★Cru4656s", "★PsA8728s", "★TrA6217s", "★Cap7776s", "★Cap7754s", "★Cap8278s", "★Cap8322s", "★Cap7773s", "★Sge7479s", "★Car2326s", "★Car3685s", "★Car3307s", "★Car3699s", "★Dra5744s", "★Dra5291s", "★Dra6705s", "★Dra6536s", "★Dra7310s", "★Dra6688s", "★Dra4434s", "★Dra6370s", "★Dra7462s", "★Dra6396s", "★Dra6132s", "★Dra6636s", "★CVn4915s", "★CVn4785s", "★CVn4846s", "★Aql7595s", "★Aql7557s", "★Aql7525s", "★Aql7602s", "★Aql7235s", "Max Honey", "Max Mushrooms", "Galarica Twigs", "Galarica Cuffs", "Style Cards", "Armor Passes", "Rotom Bikes", "Rotom Bikes", "Exp. Charms", "Armorite Ore", "Mark Charms", "Reins of Unity", "Reins of Unity", "Galarica Wreaths", "Legendary Clue 1s", "Legendary Clue 2s", "Legendary Clue 3s", "Legendary Clue?s", "Crown Passes", "Wooden Crowns", "Radiant Petals", "White Mane Hair", "Black Mane Hair", "Iceroot Carrots", "Shaderoot Carrots", "Dynite Ore", "Carrot Seeds", "Ability Patches", "Reins of Unity" });
            itemnameplural.Location = new Point(380, 24);
            itemnameplural.Margin = new Padding(4, 4, 4, 4);
            itemnameplural.Name = "itemnameplural";
            itemnameplural.Size = new Size(135, 23);
            itemnameplural.TabIndex = 541;
            itemnameplural.Visible = false;
            // 
            // nitem6
            // 
            nitem6.Location = new Point(564, 86);
            nitem6.Margin = new Padding(4, 4, 4, 4);
            nitem6.Name = "nitem6";
            nitem6.Size = new Size(53, 25);
            nitem6.TabIndex = 12;
            // 
            // nitem5
            // 
            nitem5.Location = new Point(564, 56);
            nitem5.Margin = new Padding(4, 4, 4, 4);
            nitem5.Name = "nitem5";
            nitem5.Size = new Size(53, 25);
            nitem5.TabIndex = 10;
            // 
            // nitem4
            // 
            nitem4.Location = new Point(564, 24);
            nitem4.Margin = new Padding(4, 4, 4, 4);
            nitem4.Name = "nitem4";
            nitem4.Size = new Size(53, 25);
            nitem4.TabIndex = 8;
            // 
            // nitem3
            // 
            nitem3.Location = new Point(255, 86);
            nitem3.Margin = new Padding(4, 4, 4, 4);
            nitem3.Name = "nitem3";
            nitem3.Size = new Size(53, 25);
            nitem3.TabIndex = 6;
            // 
            // nitem2
            // 
            nitem2.Location = new Point(255, 56);
            nitem2.Margin = new Padding(4, 4, 4, 4);
            nitem2.Name = "nitem2";
            nitem2.Size = new Size(53, 25);
            nitem2.TabIndex = 4;
            // 
            // nitem1
            // 
            nitem1.Location = new Point(255, 24);
            nitem1.Margin = new Padding(4, 4, 4, 4);
            nitem1.Name = "nitem1";
            nitem1.Size = new Size(53, 25);
            nitem1.TabIndex = 2;
            // 
            // itemslc
            // 
            itemslc.Location = new Point(104, 118);
            itemslc.Margin = new Padding(4, 4, 4, 4);
            itemslc.Name = "itemslc";
            itemslc.Size = new Size(204, 25);
            itemslc.TabIndex = 13;
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.Location = new Point(16, 122);
            Label20.Margin = new Padding(4, 0, 4, 0);
            Label20.Name = "Label20";
            Label20.Size = new Size(87, 15);
            Label20.TabIndex = 533;
            Label20.Text = "Line Count";
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Location = new Point(325, 90);
            Label18.Margin = new Padding(4, 0, 4, 0);
            Label18.Name = "Label18";
            Label18.Size = new Size(55, 15);
            Label18.TabIndex = 532;
            Label18.Text = "Item 6";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Location = new Point(325, 58);
            Label17.Margin = new Padding(4, 0, 4, 0);
            Label17.Name = "Label17";
            Label17.Size = new Size(55, 15);
            Label17.TabIndex = 531;
            Label17.Text = "Item 5";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Location = new Point(325, 28);
            Label16.Margin = new Padding(4, 0, 4, 0);
            Label16.Name = "Label16";
            Label16.Size = new Size(55, 15);
            Label16.TabIndex = 530;
            Label16.Text = "Item 4";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Location = new Point(16, 90);
            Label15.Margin = new Padding(4, 0, 4, 0);
            Label15.Name = "Label15";
            Label15.Size = new Size(55, 15);
            Label15.TabIndex = 529;
            Label15.Text = "Item 3";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Location = new Point(16, 58);
            Label14.Margin = new Padding(4, 0, 4, 0);
            Label14.Name = "Label14";
            Label14.Size = new Size(55, 15);
            Label14.TabIndex = 528;
            Label14.Text = "Item 2";
            // 
            // itembox6
            // 
            itembox6.AllowDrop = true;
            itembox6.AutoCompleteCustomSource.AddRange(new string[] { "None", "Master Ball", "Ultra Ball", "Great Ball", "Poké Ball", "Safari Ball", "Net Ball", "Dive Ball", "Nest Ball", "Repeat Ball", "Timer Ball", "Luxury Ball", "Premier Ball", "Dusk Ball", "Heal Ball", "Quick Ball", "Cherish Ball", "Potion", "Antidote", "Burn Heal", "Ice Heal", "Awakening", "Paralyze Heal", "Full Restore", "Max Potion", "Hyper Potion", "Super Potion", "Full Heal", "Revive", "Max Revive", "Fresh Water", "Soda Pop", "Lemonade", "Moomoo Milk", "Energy Powder", "Energy Root", "Heal Powder", "Revival Herb", "Ether", "Max Ether", "Elixir", "Max Elixir", "Lava Cookie", "Berry Juice", "Sacred Ash", "HP Up", "Protein", "Iron", "Carbos", "Calcium", "Rare Candy", "PP Up", "Zinc", "PP Max", "Old Gateau", "Guard Spec.", "Dire Hit", "X Attack", "X Defense", "X Speed", "X Accuracy", "X Sp. Atk", "X Sp. Def", "Poké Doll", "Fluffy Tail", "Blue Flute", "Yellow Flute", "Red Flute", "Black Flute", "White Flute", "Shoal Salt", "Shoal Shell", "Red Shard", "Blue Shard", "Yellow Shard", "Green Shard", "Super Repel", "Max Repel", "Escape Rope", "Repel", "Sun Stone", "Moon Stone", "Fire Stone", "Thunder Stone", "Water Stone", "Leaf Stone", "Tiny Mushroom", "Big Mushroom", "Pearl", "Big Pearl", "Stardust", "Star Piece", "Nugget", "Heart Scale", "Honey", "Growth Mulch", "Damp Mulch", "Stable Mulch", "Gooey Mulch", "Root Fossil", "Claw Fossil", "Helix Fossil", "Dome Fossil", "Old Amber", "Armor Fossil", "Skull Fossil", "Rare Bone", "Shiny Stone", "Dusk Stone", "Dawn Stone", "Oval Stone", "Odd Keystone", "Griseous Orb", "???", "???", "???", "Douse Drive", "Shock Drive", "Burn Drive", "Chill Drive", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Sweet Heart", "Adamant Orb", "Lustrous Orb", "Greet Mail", "Favored Mail", "RSVP Mail", "Thanks Mail", "Inquiry Mail", "Like Mail", "Reply Mail", "Bridge Mail S", "Bridge Mail D", "Bridge Mail T", "Bridge Mail V", "Bridge Mail M", "Cheri Berry", "Chesto Berry", "Pecha Berry", "Rawst Berry", "Aspear Berry", "Leppa Berry", "Oran Berry", "Persim Berry", "Lum Berry", "Sitrus Berry", "Figy Berry", "Wiki Berry", "Mago Berry", "Aguav Berry", "Iapapa Berry", "Razz Berry", "Bluk Berry", "Nanab Berry", "Wepear Berry", "Pinap Berry", "Pomeg Berry", "Kelpsy Berry", "Qualot Berry", "Hondew Berry", "Grepa Berry", "Tamato Berry", "Cornn Berry", "Magost Berry", "Rabuta Berry", "Nomel Berry", "Spelon Berry", "Pamtre Berry", "Watmel Berry", "Durin Berry", "Belue Berry", "Occa Berry", "Passho Berry", "Wacan Berry", "Rindo Berry", "Yache Berry", "Chople Berry", "Kebia Berry", "Shuca Berry", "Coba Berry", "Payapa Berry", "Tanga Berry", "Charti Berry", "Kasib Berry", "Haban Berry", "Colbur Berry", "Babiri Berry", "Chilan Berry", "Liechi Berry", "Ganlon Berry", "Salac Berry", "Petaya Berry", "Apicot Berry", "Lansat Berry", "Starf Berry", "Enigma Berry", "Micle Berry", "Custap Berry", "Jaboca Berry", "Rowap Berry", "Bright Powder", "White Herb", "Macho Brace", "Exp. Share", "Quick Claw", "Soothe Bell", "Mental Herb", "Choice Band", "King’s Rock", "Silver Powder", "Amulet Coin", "Cleanse Tag", "Soul Dew", "Deep Sea Tooth", "Deep Sea Scale", "Smoke Ball", "Everstone", "Focus Band", "Lucky Egg", "Scope Lens", "Metal Coat", "Leftovers", "Dragon Scale", "Light Ball", "Soft Sand", "Hard Stone", "Miracle Seed", "Black Glasses", "Black Belt", "Magnet", "Mystic Water", "Sharp Beak", "Poison Barb", "Never-Melt Ice", "Spell Tag", "Twisted Spoon", "Charcoal", "Dragon Fang", "Silk Scarf", "Up-Grade", "Shell Bell", "Sea Incense", "Lax Incense", "Lucky Punch", "Metal Powder", "Thick Club", "Stick", "Red Scarf", "Blue Scarf", "Pink Scarf", "Green Scarf", "Yellow Scarf", "Wide Lens", "Muscle Band", "Wise Glasses", "Expert Belt", "Light Clay", "Life Orb", "Power Herb", "Toxic Orb", "Flame Orb", "Quick Powder", "Focus Sash", "Zoom Lens", "Metronome", "Iron Ball", "Lagging Tail", "Destiny Knot", "Black Sludge", "Icy Rock", "Smooth Rock", "Heat Rock", "Damp Rock", "Grip Claw", "Choice Scarf", "Sticky Barb", "Power Bracer", "Power Belt", "Power Lens", "Power Band", "Power Anklet", "Power Weight", "Shed Shell", "Big Root", "Choice Specs", "Flame Plate", "Splash Plate", "Zap Plate", "Meadow Plate", "Icicle Plate", "Fist Plate", "Toxic Plate", "Earth Plate", "Sky Plate", "Mind Plate", "Insect Plate", "Stone Plate", "Spooky Plate", "Draco Plate", "Dread Plate", "Iron Plate", "Odd Incense", "Rock Incense", "Full Incense", "Wave Incense", "Rose Incense", "Luck Incense", "Pure Incense", "Protector", "Electirizer", "Magmarizer", "Dubious Disc", "Reaper Cloth", "Razor Claw", "Razor Fang", "TM01", "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11", "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21", "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31", "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41", "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "TM51", "TM52", "TM53", "TM54", "TM55", "TM56", "TM57", "TM58", "TM59", "TM60", "TM61", "TM62", "TM63", "TM64", "TM65", "TM66", "TM67", "TM68", "TM69", "TM70", "TM71", "TM72", "TM73", "TM74", "TM75", "TM76", "TM77", "TM78", "TM79", "TM80", "TM81", "TM82", "TM83", "TM84", "TM85", "TM86", "TM87", "TM88", "TM89", "TM90", "TM91", "TM92", "HM01", "HM02", "HM03", "HM04", "HM05", "HM06", "???", "???", "Explorer Kit", "Loot Sack", "Rule Book", "Poké Radar", "Point Card", "Journal", "Seal Case", "Fashion Case", "Seal Bag", "Pal Pad", "Works Key", "Old Charm", "Galactic Key", "Red Chain", "Town Map", "Vs. Seeker", "Coin Case", "Old Rod", "Good Rod", "Super Rod", "Sprayduck", "Poffin Case", "Bike", "Suite Key", "Oak’s Letter", "Lunar Wing", "Member Card", "Azure Flute", "S.S. Ticket", "Contest Pass", "Magma Stone", "Parcel", "Coupon 1", "Coupon 2", "Coupon 3", "Storage Key", "Secret Potion", "Vs. Recorder", "Gracidea", "Secret Key", "Apricorn Box", "Unown Report", "Berry Pots", "Dowsing Machine", "Blue Card", "Slowpoke Tail", "Clear Bell", "Card Key", "Basement Key", "Squirt Bottle", "Red Scale", "Lost Item", "Pass", "Machine Part", "Silver Wing", "Rainbow Wing", "Mystery Egg", "Red Apricorn", "Blue Apricorn", "Yellow Apricorn", "Green Apricorn", "Pink Apricorn", "White Apricorn", "Black Apricorn", "Fast Ball", "Level Ball", "Lure Ball", "Heavy Ball", "Love Ball", "Friend Ball", "Moon Ball", "Sport Ball", "Park Ball", "Photo Album", "GB Sounds", "Tidal Bell", "Rage Candy Bar", "Data Card 01", "Data Card 02", "Data Card 03", "Data Card 04", "Data Card 05", "Data Card 06", "Data Card 07", "Data Card 08", "Data Card 09", "Data Card 10", "Data Card 11", "Data Card 12", "Data Card 13", "Data Card 14", "Data Card 15", "Data Card 16", "Data Card 17", "Data Card 18", "Data Card 19", "Data Card 20", "Data Card 21", "Data Card 22", "Data Card 23", "Data Card 24", "Data Card 25", "Data Card 26", "Data Card 27", "Jade Orb", "Lock Capsule", "Red Orb", "Blue Orb", "Enigma Stone", "Prism Scale", "Eviolite", "Float Stone", "Rocky Helmet", "Air Balloon", "Red Card", "Ring Target", "Binding Band", "Absorb Bulb", "Cell Battery", "Eject Button", "Fire Gem", "Water Gem", "Electric Gem", "Grass Gem", "Ice Gem", "Fighting Gem", "Poison Gem", "Ground Gem", "Flying Gem", "Psychic Gem", "Bug Gem", "Rock Gem", "Ghost Gem", "Dragon Gem", "Dark Gem", "Steel Gem", "Normal Gem", "Health Wing", "Muscle Wing", "Resist Wing", "Genius Wing", "Clever Wing", "Swift Wing", "Pretty Wing", "Cover Fossil", "Plume Fossil", "Liberty Pass", "Pass Orb", "Dream Ball", "Poké Toy", "Prop Case", "Dragon Skull", "Balm Mushroom", "Big Nugget", "Pearl String", "Comet Shard", "Relic Copper", "Relic Silver", "Relic Gold", "Relic Vase", "Relic Band", "Relic Statue", "Relic Crown", "Casteliacone", "Dire Hit 2", "X Speed 2", "X Sp. Atk 2", "X Sp. Def 2", "X Defense 2", "X Attack 2", "X Accuracy 2", "X Speed 3", "X Sp. Atk 3", "X Sp. Def 3", "X Defense 3", "X Attack 3", "X Accuracy 3", "X Speed 6", "X Sp. Atk 6", "X Sp. Def 6", "X Defense 6", "X Attack 6", "X Accuracy 6", "Ability Urge", "Item Drop", "Item Urge", "Reset Urge", "Dire Hit 3", "Light Stone", "Dark Stone", "TM93", "TM94", "TM95", "Xtransceiver", "???", "Gram 1", "Gram 2", "Gram 3", "Xtransceiver", "Medal Box", "DNA Splicers", "DNA Splicers", "Permit", "Oval Charm", "Shiny Charm", "Plasma Card", "Grubby Hanky", "Colress Machine", "Dropped Item", "Dropped Item", "Reveal Glass", "Weakness Policy", "Assault Vest", "Holo Caster", "Prof’s Letter", "Roller Skates", "Pixie Plate", "Ability Capsule", "Whipped Dream", "Sachet", "Luminous Moss", "Snowball", "Safety Goggles", "Poké Flute", "Rich Mulch", "Surprise Mulch", "Boost Mulch", "Amaze Mulch", "Gengarite", "Gardevoirite", "Ampharosite", "Venusaurite", "Charizardite X", "Blastoisinite", "Mewtwonite X", "Mewtwonite Y", "Blazikenite", "Medichamite", "Houndoominite", "Aggronite", "Banettite", "Tyranitarite", "Scizorite", "Pinsirite", "Aerodactylite", "Lucarionite", "Abomasite", "Kangaskhanite", "Gyaradosite", "Absolite", "Charizardite Y", "Alakazite", "Heracronite", "Mawilite", "Manectite", "Garchompite", "Latiasite", "Latiosite", "Roseli Berry", "Kee Berry", "Maranga Berry", "Sprinklotad", "TM96", "TM97", "TM98", "TM99", "TM100", "Power Plant Pass", "Mega Ring", "Intriguing Stone", "Common Stone", "Discount Coupon", "Elevator Key", "TMV Pass", "Honor of Kalos", "Adventure Rules", "Strange Souvenir", "Lens Case", "Makeup Bag", "Travel Trunk", "Lumiose Galette", "Shalour Sable", "Jaw Fossil", "Sail Fossil", "Looker Ticket", "Bike", "Holo Caster", "Fairy Gem", "Mega Charm", "Mega Glove", "Mach Bike", "Acro Bike", "Wailmer Pail", "Devon Parts", "Soot Sack", "Basement Key", "Pokéblock Kit", "Letter", "Eon Ticket", "Scanner", "Go-Goggles", "Meteorite", "Key to Room 1", "Key to Room 2", "Key to Room 4", "Key to Room 6", "Storage Key", "Devon Scope", "S.S. Ticket", "HM07", "Devon Scuba Gear", "Contest Costume", "Contest Costume", "Magma Suit", "Aqua Suit", "Pair of Tickets", "Mega Bracelet", "Mega Pendant", "Mega Glasses", "Mega Anchor", "Mega Stickpin", "Mega Tiara", "Mega Anklet", "Meteorite", "Swampertite", "Sceptilite", "Sablenite", "Altarianite", "Galladite", "Audinite", "Metagrossite", "Sharpedonite", "Slowbronite", "Steelixite", "Pidgeotite", "Glalitite", "Diancite", "Prison Bottle", "Mega Cuff", "Cameruptite", "Lopunnite", "Salamencite", "Beedrillite", "Meteorite", "Meteorite", "Key Stone", "Meteorite Shard", "Eon Flute", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Z-Ring", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "UB Ball *", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a" });
            itembox6.FormattingEnabled = true;
            itembox6.Location = new Point(413, 86);
            itembox6.Margin = new Padding(4, 4, 4, 4);
            itembox6.Name = "itembox6";
            itembox6.Size = new Size(141, 23);
            itembox6.TabIndex = 11;
            // 
            // itembox5
            // 
            itembox5.AllowDrop = true;
            itembox5.AutoCompleteCustomSource.AddRange(new string[] { "None", "Master Ball", "Ultra Ball", "Great Ball", "Poké Ball", "Safari Ball", "Net Ball", "Dive Ball", "Nest Ball", "Repeat Ball", "Timer Ball", "Luxury Ball", "Premier Ball", "Dusk Ball", "Heal Ball", "Quick Ball", "Cherish Ball", "Potion", "Antidote", "Burn Heal", "Ice Heal", "Awakening", "Paralyze Heal", "Full Restore", "Max Potion", "Hyper Potion", "Super Potion", "Full Heal", "Revive", "Max Revive", "Fresh Water", "Soda Pop", "Lemonade", "Moomoo Milk", "Energy Powder", "Energy Root", "Heal Powder", "Revival Herb", "Ether", "Max Ether", "Elixir", "Max Elixir", "Lava Cookie", "Berry Juice", "Sacred Ash", "HP Up", "Protein", "Iron", "Carbos", "Calcium", "Rare Candy", "PP Up", "Zinc", "PP Max", "Old Gateau", "Guard Spec.", "Dire Hit", "X Attack", "X Defense", "X Speed", "X Accuracy", "X Sp. Atk", "X Sp. Def", "Poké Doll", "Fluffy Tail", "Blue Flute", "Yellow Flute", "Red Flute", "Black Flute", "White Flute", "Shoal Salt", "Shoal Shell", "Red Shard", "Blue Shard", "Yellow Shard", "Green Shard", "Super Repel", "Max Repel", "Escape Rope", "Repel", "Sun Stone", "Moon Stone", "Fire Stone", "Thunder Stone", "Water Stone", "Leaf Stone", "Tiny Mushroom", "Big Mushroom", "Pearl", "Big Pearl", "Stardust", "Star Piece", "Nugget", "Heart Scale", "Honey", "Growth Mulch", "Damp Mulch", "Stable Mulch", "Gooey Mulch", "Root Fossil", "Claw Fossil", "Helix Fossil", "Dome Fossil", "Old Amber", "Armor Fossil", "Skull Fossil", "Rare Bone", "Shiny Stone", "Dusk Stone", "Dawn Stone", "Oval Stone", "Odd Keystone", "Griseous Orb", "???", "???", "???", "Douse Drive", "Shock Drive", "Burn Drive", "Chill Drive", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Sweet Heart", "Adamant Orb", "Lustrous Orb", "Greet Mail", "Favored Mail", "RSVP Mail", "Thanks Mail", "Inquiry Mail", "Like Mail", "Reply Mail", "Bridge Mail S", "Bridge Mail D", "Bridge Mail T", "Bridge Mail V", "Bridge Mail M", "Cheri Berry", "Chesto Berry", "Pecha Berry", "Rawst Berry", "Aspear Berry", "Leppa Berry", "Oran Berry", "Persim Berry", "Lum Berry", "Sitrus Berry", "Figy Berry", "Wiki Berry", "Mago Berry", "Aguav Berry", "Iapapa Berry", "Razz Berry", "Bluk Berry", "Nanab Berry", "Wepear Berry", "Pinap Berry", "Pomeg Berry", "Kelpsy Berry", "Qualot Berry", "Hondew Berry", "Grepa Berry", "Tamato Berry", "Cornn Berry", "Magost Berry", "Rabuta Berry", "Nomel Berry", "Spelon Berry", "Pamtre Berry", "Watmel Berry", "Durin Berry", "Belue Berry", "Occa Berry", "Passho Berry", "Wacan Berry", "Rindo Berry", "Yache Berry", "Chople Berry", "Kebia Berry", "Shuca Berry", "Coba Berry", "Payapa Berry", "Tanga Berry", "Charti Berry", "Kasib Berry", "Haban Berry", "Colbur Berry", "Babiri Berry", "Chilan Berry", "Liechi Berry", "Ganlon Berry", "Salac Berry", "Petaya Berry", "Apicot Berry", "Lansat Berry", "Starf Berry", "Enigma Berry", "Micle Berry", "Custap Berry", "Jaboca Berry", "Rowap Berry", "Bright Powder", "White Herb", "Macho Brace", "Exp. Share", "Quick Claw", "Soothe Bell", "Mental Herb", "Choice Band", "King’s Rock", "Silver Powder", "Amulet Coin", "Cleanse Tag", "Soul Dew", "Deep Sea Tooth", "Deep Sea Scale", "Smoke Ball", "Everstone", "Focus Band", "Lucky Egg", "Scope Lens", "Metal Coat", "Leftovers", "Dragon Scale", "Light Ball", "Soft Sand", "Hard Stone", "Miracle Seed", "Black Glasses", "Black Belt", "Magnet", "Mystic Water", "Sharp Beak", "Poison Barb", "Never-Melt Ice", "Spell Tag", "Twisted Spoon", "Charcoal", "Dragon Fang", "Silk Scarf", "Up-Grade", "Shell Bell", "Sea Incense", "Lax Incense", "Lucky Punch", "Metal Powder", "Thick Club", "Stick", "Red Scarf", "Blue Scarf", "Pink Scarf", "Green Scarf", "Yellow Scarf", "Wide Lens", "Muscle Band", "Wise Glasses", "Expert Belt", "Light Clay", "Life Orb", "Power Herb", "Toxic Orb", "Flame Orb", "Quick Powder", "Focus Sash", "Zoom Lens", "Metronome", "Iron Ball", "Lagging Tail", "Destiny Knot", "Black Sludge", "Icy Rock", "Smooth Rock", "Heat Rock", "Damp Rock", "Grip Claw", "Choice Scarf", "Sticky Barb", "Power Bracer", "Power Belt", "Power Lens", "Power Band", "Power Anklet", "Power Weight", "Shed Shell", "Big Root", "Choice Specs", "Flame Plate", "Splash Plate", "Zap Plate", "Meadow Plate", "Icicle Plate", "Fist Plate", "Toxic Plate", "Earth Plate", "Sky Plate", "Mind Plate", "Insect Plate", "Stone Plate", "Spooky Plate", "Draco Plate", "Dread Plate", "Iron Plate", "Odd Incense", "Rock Incense", "Full Incense", "Wave Incense", "Rose Incense", "Luck Incense", "Pure Incense", "Protector", "Electirizer", "Magmarizer", "Dubious Disc", "Reaper Cloth", "Razor Claw", "Razor Fang", "TM01", "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11", "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21", "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31", "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41", "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "TM51", "TM52", "TM53", "TM54", "TM55", "TM56", "TM57", "TM58", "TM59", "TM60", "TM61", "TM62", "TM63", "TM64", "TM65", "TM66", "TM67", "TM68", "TM69", "TM70", "TM71", "TM72", "TM73", "TM74", "TM75", "TM76", "TM77", "TM78", "TM79", "TM80", "TM81", "TM82", "TM83", "TM84", "TM85", "TM86", "TM87", "TM88", "TM89", "TM90", "TM91", "TM92", "HM01", "HM02", "HM03", "HM04", "HM05", "HM06", "???", "???", "Explorer Kit", "Loot Sack", "Rule Book", "Poké Radar", "Point Card", "Journal", "Seal Case", "Fashion Case", "Seal Bag", "Pal Pad", "Works Key", "Old Charm", "Galactic Key", "Red Chain", "Town Map", "Vs. Seeker", "Coin Case", "Old Rod", "Good Rod", "Super Rod", "Sprayduck", "Poffin Case", "Bike", "Suite Key", "Oak’s Letter", "Lunar Wing", "Member Card", "Azure Flute", "S.S. Ticket", "Contest Pass", "Magma Stone", "Parcel", "Coupon 1", "Coupon 2", "Coupon 3", "Storage Key", "Secret Potion", "Vs. Recorder", "Gracidea", "Secret Key", "Apricorn Box", "Unown Report", "Berry Pots", "Dowsing Machine", "Blue Card", "Slowpoke Tail", "Clear Bell", "Card Key", "Basement Key", "Squirt Bottle", "Red Scale", "Lost Item", "Pass", "Machine Part", "Silver Wing", "Rainbow Wing", "Mystery Egg", "Red Apricorn", "Blue Apricorn", "Yellow Apricorn", "Green Apricorn", "Pink Apricorn", "White Apricorn", "Black Apricorn", "Fast Ball", "Level Ball", "Lure Ball", "Heavy Ball", "Love Ball", "Friend Ball", "Moon Ball", "Sport Ball", "Park Ball", "Photo Album", "GB Sounds", "Tidal Bell", "Rage Candy Bar", "Data Card 01", "Data Card 02", "Data Card 03", "Data Card 04", "Data Card 05", "Data Card 06", "Data Card 07", "Data Card 08", "Data Card 09", "Data Card 10", "Data Card 11", "Data Card 12", "Data Card 13", "Data Card 14", "Data Card 15", "Data Card 16", "Data Card 17", "Data Card 18", "Data Card 19", "Data Card 20", "Data Card 21", "Data Card 22", "Data Card 23", "Data Card 24", "Data Card 25", "Data Card 26", "Data Card 27", "Jade Orb", "Lock Capsule", "Red Orb", "Blue Orb", "Enigma Stone", "Prism Scale", "Eviolite", "Float Stone", "Rocky Helmet", "Air Balloon", "Red Card", "Ring Target", "Binding Band", "Absorb Bulb", "Cell Battery", "Eject Button", "Fire Gem", "Water Gem", "Electric Gem", "Grass Gem", "Ice Gem", "Fighting Gem", "Poison Gem", "Ground Gem", "Flying Gem", "Psychic Gem", "Bug Gem", "Rock Gem", "Ghost Gem", "Dragon Gem", "Dark Gem", "Steel Gem", "Normal Gem", "Health Wing", "Muscle Wing", "Resist Wing", "Genius Wing", "Clever Wing", "Swift Wing", "Pretty Wing", "Cover Fossil", "Plume Fossil", "Liberty Pass", "Pass Orb", "Dream Ball", "Poké Toy", "Prop Case", "Dragon Skull", "Balm Mushroom", "Big Nugget", "Pearl String", "Comet Shard", "Relic Copper", "Relic Silver", "Relic Gold", "Relic Vase", "Relic Band", "Relic Statue", "Relic Crown", "Casteliacone", "Dire Hit 2", "X Speed 2", "X Sp. Atk 2", "X Sp. Def 2", "X Defense 2", "X Attack 2", "X Accuracy 2", "X Speed 3", "X Sp. Atk 3", "X Sp. Def 3", "X Defense 3", "X Attack 3", "X Accuracy 3", "X Speed 6", "X Sp. Atk 6", "X Sp. Def 6", "X Defense 6", "X Attack 6", "X Accuracy 6", "Ability Urge", "Item Drop", "Item Urge", "Reset Urge", "Dire Hit 3", "Light Stone", "Dark Stone", "TM93", "TM94", "TM95", "Xtransceiver", "???", "Gram 1", "Gram 2", "Gram 3", "Xtransceiver", "Medal Box", "DNA Splicers", "DNA Splicers", "Permit", "Oval Charm", "Shiny Charm", "Plasma Card", "Grubby Hanky", "Colress Machine", "Dropped Item", "Dropped Item", "Reveal Glass", "Weakness Policy", "Assault Vest", "Holo Caster", "Prof’s Letter", "Roller Skates", "Pixie Plate", "Ability Capsule", "Whipped Dream", "Sachet", "Luminous Moss", "Snowball", "Safety Goggles", "Poké Flute", "Rich Mulch", "Surprise Mulch", "Boost Mulch", "Amaze Mulch", "Gengarite", "Gardevoirite", "Ampharosite", "Venusaurite", "Charizardite X", "Blastoisinite", "Mewtwonite X", "Mewtwonite Y", "Blazikenite", "Medichamite", "Houndoominite", "Aggronite", "Banettite", "Tyranitarite", "Scizorite", "Pinsirite", "Aerodactylite", "Lucarionite", "Abomasite", "Kangaskhanite", "Gyaradosite", "Absolite", "Charizardite Y", "Alakazite", "Heracronite", "Mawilite", "Manectite", "Garchompite", "Latiasite", "Latiosite", "Roseli Berry", "Kee Berry", "Maranga Berry", "Sprinklotad", "TM96", "TM97", "TM98", "TM99", "TM100", "Power Plant Pass", "Mega Ring", "Intriguing Stone", "Common Stone", "Discount Coupon", "Elevator Key", "TMV Pass", "Honor of Kalos", "Adventure Rules", "Strange Souvenir", "Lens Case", "Makeup Bag", "Travel Trunk", "Lumiose Galette", "Shalour Sable", "Jaw Fossil", "Sail Fossil", "Looker Ticket", "Bike", "Holo Caster", "Fairy Gem", "Mega Charm", "Mega Glove", "Mach Bike", "Acro Bike", "Wailmer Pail", "Devon Parts", "Soot Sack", "Basement Key", "Pokéblock Kit", "Letter", "Eon Ticket", "Scanner", "Go-Goggles", "Meteorite", "Key to Room 1", "Key to Room 2", "Key to Room 4", "Key to Room 6", "Storage Key", "Devon Scope", "S.S. Ticket", "HM07", "Devon Scuba Gear", "Contest Costume", "Contest Costume", "Magma Suit", "Aqua Suit", "Pair of Tickets", "Mega Bracelet", "Mega Pendant", "Mega Glasses", "Mega Anchor", "Mega Stickpin", "Mega Tiara", "Mega Anklet", "Meteorite", "Swampertite", "Sceptilite", "Sablenite", "Altarianite", "Galladite", "Audinite", "Metagrossite", "Sharpedonite", "Slowbronite", "Steelixite", "Pidgeotite", "Glalitite", "Diancite", "Prison Bottle", "Mega Cuff", "Cameruptite", "Lopunnite", "Salamencite", "Beedrillite", "Meteorite", "Meteorite", "Key Stone", "Meteorite Shard", "Eon Flute", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Z-Ring", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "UB Ball *", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a" });
            itembox5.FormattingEnabled = true;
            itembox5.Location = new Point(413, 56);
            itembox5.Margin = new Padding(4, 4, 4, 4);
            itembox5.Name = "itembox5";
            itembox5.Size = new Size(141, 23);
            itembox5.TabIndex = 9;
            // 
            // itembox4
            // 
            itembox4.AllowDrop = true;
            itembox4.AutoCompleteCustomSource.AddRange(new string[] { "None", "Master Ball", "Ultra Ball", "Great Ball", "Poké Ball", "Safari Ball", "Net Ball", "Dive Ball", "Nest Ball", "Repeat Ball", "Timer Ball", "Luxury Ball", "Premier Ball", "Dusk Ball", "Heal Ball", "Quick Ball", "Cherish Ball", "Potion", "Antidote", "Burn Heal", "Ice Heal", "Awakening", "Paralyze Heal", "Full Restore", "Max Potion", "Hyper Potion", "Super Potion", "Full Heal", "Revive", "Max Revive", "Fresh Water", "Soda Pop", "Lemonade", "Moomoo Milk", "Energy Powder", "Energy Root", "Heal Powder", "Revival Herb", "Ether", "Max Ether", "Elixir", "Max Elixir", "Lava Cookie", "Berry Juice", "Sacred Ash", "HP Up", "Protein", "Iron", "Carbos", "Calcium", "Rare Candy", "PP Up", "Zinc", "PP Max", "Old Gateau", "Guard Spec.", "Dire Hit", "X Attack", "X Defense", "X Speed", "X Accuracy", "X Sp. Atk", "X Sp. Def", "Poké Doll", "Fluffy Tail", "Blue Flute", "Yellow Flute", "Red Flute", "Black Flute", "White Flute", "Shoal Salt", "Shoal Shell", "Red Shard", "Blue Shard", "Yellow Shard", "Green Shard", "Super Repel", "Max Repel", "Escape Rope", "Repel", "Sun Stone", "Moon Stone", "Fire Stone", "Thunder Stone", "Water Stone", "Leaf Stone", "Tiny Mushroom", "Big Mushroom", "Pearl", "Big Pearl", "Stardust", "Star Piece", "Nugget", "Heart Scale", "Honey", "Growth Mulch", "Damp Mulch", "Stable Mulch", "Gooey Mulch", "Root Fossil", "Claw Fossil", "Helix Fossil", "Dome Fossil", "Old Amber", "Armor Fossil", "Skull Fossil", "Rare Bone", "Shiny Stone", "Dusk Stone", "Dawn Stone", "Oval Stone", "Odd Keystone", "Griseous Orb", "???", "???", "???", "Douse Drive", "Shock Drive", "Burn Drive", "Chill Drive", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Sweet Heart", "Adamant Orb", "Lustrous Orb", "Greet Mail", "Favored Mail", "RSVP Mail", "Thanks Mail", "Inquiry Mail", "Like Mail", "Reply Mail", "Bridge Mail S", "Bridge Mail D", "Bridge Mail T", "Bridge Mail V", "Bridge Mail M", "Cheri Berry", "Chesto Berry", "Pecha Berry", "Rawst Berry", "Aspear Berry", "Leppa Berry", "Oran Berry", "Persim Berry", "Lum Berry", "Sitrus Berry", "Figy Berry", "Wiki Berry", "Mago Berry", "Aguav Berry", "Iapapa Berry", "Razz Berry", "Bluk Berry", "Nanab Berry", "Wepear Berry", "Pinap Berry", "Pomeg Berry", "Kelpsy Berry", "Qualot Berry", "Hondew Berry", "Grepa Berry", "Tamato Berry", "Cornn Berry", "Magost Berry", "Rabuta Berry", "Nomel Berry", "Spelon Berry", "Pamtre Berry", "Watmel Berry", "Durin Berry", "Belue Berry", "Occa Berry", "Passho Berry", "Wacan Berry", "Rindo Berry", "Yache Berry", "Chople Berry", "Kebia Berry", "Shuca Berry", "Coba Berry", "Payapa Berry", "Tanga Berry", "Charti Berry", "Kasib Berry", "Haban Berry", "Colbur Berry", "Babiri Berry", "Chilan Berry", "Liechi Berry", "Ganlon Berry", "Salac Berry", "Petaya Berry", "Apicot Berry", "Lansat Berry", "Starf Berry", "Enigma Berry", "Micle Berry", "Custap Berry", "Jaboca Berry", "Rowap Berry", "Bright Powder", "White Herb", "Macho Brace", "Exp. Share", "Quick Claw", "Soothe Bell", "Mental Herb", "Choice Band", "King’s Rock", "Silver Powder", "Amulet Coin", "Cleanse Tag", "Soul Dew", "Deep Sea Tooth", "Deep Sea Scale", "Smoke Ball", "Everstone", "Focus Band", "Lucky Egg", "Scope Lens", "Metal Coat", "Leftovers", "Dragon Scale", "Light Ball", "Soft Sand", "Hard Stone", "Miracle Seed", "Black Glasses", "Black Belt", "Magnet", "Mystic Water", "Sharp Beak", "Poison Barb", "Never-Melt Ice", "Spell Tag", "Twisted Spoon", "Charcoal", "Dragon Fang", "Silk Scarf", "Up-Grade", "Shell Bell", "Sea Incense", "Lax Incense", "Lucky Punch", "Metal Powder", "Thick Club", "Stick", "Red Scarf", "Blue Scarf", "Pink Scarf", "Green Scarf", "Yellow Scarf", "Wide Lens", "Muscle Band", "Wise Glasses", "Expert Belt", "Light Clay", "Life Orb", "Power Herb", "Toxic Orb", "Flame Orb", "Quick Powder", "Focus Sash", "Zoom Lens", "Metronome", "Iron Ball", "Lagging Tail", "Destiny Knot", "Black Sludge", "Icy Rock", "Smooth Rock", "Heat Rock", "Damp Rock", "Grip Claw", "Choice Scarf", "Sticky Barb", "Power Bracer", "Power Belt", "Power Lens", "Power Band", "Power Anklet", "Power Weight", "Shed Shell", "Big Root", "Choice Specs", "Flame Plate", "Splash Plate", "Zap Plate", "Meadow Plate", "Icicle Plate", "Fist Plate", "Toxic Plate", "Earth Plate", "Sky Plate", "Mind Plate", "Insect Plate", "Stone Plate", "Spooky Plate", "Draco Plate", "Dread Plate", "Iron Plate", "Odd Incense", "Rock Incense", "Full Incense", "Wave Incense", "Rose Incense", "Luck Incense", "Pure Incense", "Protector", "Electirizer", "Magmarizer", "Dubious Disc", "Reaper Cloth", "Razor Claw", "Razor Fang", "TM01", "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11", "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21", "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31", "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41", "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "TM51", "TM52", "TM53", "TM54", "TM55", "TM56", "TM57", "TM58", "TM59", "TM60", "TM61", "TM62", "TM63", "TM64", "TM65", "TM66", "TM67", "TM68", "TM69", "TM70", "TM71", "TM72", "TM73", "TM74", "TM75", "TM76", "TM77", "TM78", "TM79", "TM80", "TM81", "TM82", "TM83", "TM84", "TM85", "TM86", "TM87", "TM88", "TM89", "TM90", "TM91", "TM92", "HM01", "HM02", "HM03", "HM04", "HM05", "HM06", "???", "???", "Explorer Kit", "Loot Sack", "Rule Book", "Poké Radar", "Point Card", "Journal", "Seal Case", "Fashion Case", "Seal Bag", "Pal Pad", "Works Key", "Old Charm", "Galactic Key", "Red Chain", "Town Map", "Vs. Seeker", "Coin Case", "Old Rod", "Good Rod", "Super Rod", "Sprayduck", "Poffin Case", "Bike", "Suite Key", "Oak’s Letter", "Lunar Wing", "Member Card", "Azure Flute", "S.S. Ticket", "Contest Pass", "Magma Stone", "Parcel", "Coupon 1", "Coupon 2", "Coupon 3", "Storage Key", "Secret Potion", "Vs. Recorder", "Gracidea", "Secret Key", "Apricorn Box", "Unown Report", "Berry Pots", "Dowsing Machine", "Blue Card", "Slowpoke Tail", "Clear Bell", "Card Key", "Basement Key", "Squirt Bottle", "Red Scale", "Lost Item", "Pass", "Machine Part", "Silver Wing", "Rainbow Wing", "Mystery Egg", "Red Apricorn", "Blue Apricorn", "Yellow Apricorn", "Green Apricorn", "Pink Apricorn", "White Apricorn", "Black Apricorn", "Fast Ball", "Level Ball", "Lure Ball", "Heavy Ball", "Love Ball", "Friend Ball", "Moon Ball", "Sport Ball", "Park Ball", "Photo Album", "GB Sounds", "Tidal Bell", "Rage Candy Bar", "Data Card 01", "Data Card 02", "Data Card 03", "Data Card 04", "Data Card 05", "Data Card 06", "Data Card 07", "Data Card 08", "Data Card 09", "Data Card 10", "Data Card 11", "Data Card 12", "Data Card 13", "Data Card 14", "Data Card 15", "Data Card 16", "Data Card 17", "Data Card 18", "Data Card 19", "Data Card 20", "Data Card 21", "Data Card 22", "Data Card 23", "Data Card 24", "Data Card 25", "Data Card 26", "Data Card 27", "Jade Orb", "Lock Capsule", "Red Orb", "Blue Orb", "Enigma Stone", "Prism Scale", "Eviolite", "Float Stone", "Rocky Helmet", "Air Balloon", "Red Card", "Ring Target", "Binding Band", "Absorb Bulb", "Cell Battery", "Eject Button", "Fire Gem", "Water Gem", "Electric Gem", "Grass Gem", "Ice Gem", "Fighting Gem", "Poison Gem", "Ground Gem", "Flying Gem", "Psychic Gem", "Bug Gem", "Rock Gem", "Ghost Gem", "Dragon Gem", "Dark Gem", "Steel Gem", "Normal Gem", "Health Wing", "Muscle Wing", "Resist Wing", "Genius Wing", "Clever Wing", "Swift Wing", "Pretty Wing", "Cover Fossil", "Plume Fossil", "Liberty Pass", "Pass Orb", "Dream Ball", "Poké Toy", "Prop Case", "Dragon Skull", "Balm Mushroom", "Big Nugget", "Pearl String", "Comet Shard", "Relic Copper", "Relic Silver", "Relic Gold", "Relic Vase", "Relic Band", "Relic Statue", "Relic Crown", "Casteliacone", "Dire Hit 2", "X Speed 2", "X Sp. Atk 2", "X Sp. Def 2", "X Defense 2", "X Attack 2", "X Accuracy 2", "X Speed 3", "X Sp. Atk 3", "X Sp. Def 3", "X Defense 3", "X Attack 3", "X Accuracy 3", "X Speed 6", "X Sp. Atk 6", "X Sp. Def 6", "X Defense 6", "X Attack 6", "X Accuracy 6", "Ability Urge", "Item Drop", "Item Urge", "Reset Urge", "Dire Hit 3", "Light Stone", "Dark Stone", "TM93", "TM94", "TM95", "Xtransceiver", "???", "Gram 1", "Gram 2", "Gram 3", "Xtransceiver", "Medal Box", "DNA Splicers", "DNA Splicers", "Permit", "Oval Charm", "Shiny Charm", "Plasma Card", "Grubby Hanky", "Colress Machine", "Dropped Item", "Dropped Item", "Reveal Glass", "Weakness Policy", "Assault Vest", "Holo Caster", "Prof’s Letter", "Roller Skates", "Pixie Plate", "Ability Capsule", "Whipped Dream", "Sachet", "Luminous Moss", "Snowball", "Safety Goggles", "Poké Flute", "Rich Mulch", "Surprise Mulch", "Boost Mulch", "Amaze Mulch", "Gengarite", "Gardevoirite", "Ampharosite", "Venusaurite", "Charizardite X", "Blastoisinite", "Mewtwonite X", "Mewtwonite Y", "Blazikenite", "Medichamite", "Houndoominite", "Aggronite", "Banettite", "Tyranitarite", "Scizorite", "Pinsirite", "Aerodactylite", "Lucarionite", "Abomasite", "Kangaskhanite", "Gyaradosite", "Absolite", "Charizardite Y", "Alakazite", "Heracronite", "Mawilite", "Manectite", "Garchompite", "Latiasite", "Latiosite", "Roseli Berry", "Kee Berry", "Maranga Berry", "Sprinklotad", "TM96", "TM97", "TM98", "TM99", "TM100", "Power Plant Pass", "Mega Ring", "Intriguing Stone", "Common Stone", "Discount Coupon", "Elevator Key", "TMV Pass", "Honor of Kalos", "Adventure Rules", "Strange Souvenir", "Lens Case", "Makeup Bag", "Travel Trunk", "Lumiose Galette", "Shalour Sable", "Jaw Fossil", "Sail Fossil", "Looker Ticket", "Bike", "Holo Caster", "Fairy Gem", "Mega Charm", "Mega Glove", "Mach Bike", "Acro Bike", "Wailmer Pail", "Devon Parts", "Soot Sack", "Basement Key", "Pokéblock Kit", "Letter", "Eon Ticket", "Scanner", "Go-Goggles", "Meteorite", "Key to Room 1", "Key to Room 2", "Key to Room 4", "Key to Room 6", "Storage Key", "Devon Scope", "S.S. Ticket", "HM07", "Devon Scuba Gear", "Contest Costume", "Contest Costume", "Magma Suit", "Aqua Suit", "Pair of Tickets", "Mega Bracelet", "Mega Pendant", "Mega Glasses", "Mega Anchor", "Mega Stickpin", "Mega Tiara", "Mega Anklet", "Meteorite", "Swampertite", "Sceptilite", "Sablenite", "Altarianite", "Galladite", "Audinite", "Metagrossite", "Sharpedonite", "Slowbronite", "Steelixite", "Pidgeotite", "Glalitite", "Diancite", "Prison Bottle", "Mega Cuff", "Cameruptite", "Lopunnite", "Salamencite", "Beedrillite", "Meteorite", "Meteorite", "Key Stone", "Meteorite Shard", "Eon Flute", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Z-Ring", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "UB Ball *", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a" });
            itembox4.FormattingEnabled = true;
            itembox4.Location = new Point(413, 24);
            itembox4.Margin = new Padding(4, 4, 4, 4);
            itembox4.Name = "itembox4";
            itembox4.Size = new Size(141, 23);
            itembox4.TabIndex = 7;
            // 
            // itembox3
            // 
            itembox3.AllowDrop = true;
            itembox3.AutoCompleteCustomSource.AddRange(new string[] { "None", "Master Ball", "Ultra Ball", "Great Ball", "Poké Ball", "Safari Ball", "Net Ball", "Dive Ball", "Nest Ball", "Repeat Ball", "Timer Ball", "Luxury Ball", "Premier Ball", "Dusk Ball", "Heal Ball", "Quick Ball", "Cherish Ball", "Potion", "Antidote", "Burn Heal", "Ice Heal", "Awakening", "Paralyze Heal", "Full Restore", "Max Potion", "Hyper Potion", "Super Potion", "Full Heal", "Revive", "Max Revive", "Fresh Water", "Soda Pop", "Lemonade", "Moomoo Milk", "Energy Powder", "Energy Root", "Heal Powder", "Revival Herb", "Ether", "Max Ether", "Elixir", "Max Elixir", "Lava Cookie", "Berry Juice", "Sacred Ash", "HP Up", "Protein", "Iron", "Carbos", "Calcium", "Rare Candy", "PP Up", "Zinc", "PP Max", "Old Gateau", "Guard Spec.", "Dire Hit", "X Attack", "X Defense", "X Speed", "X Accuracy", "X Sp. Atk", "X Sp. Def", "Poké Doll", "Fluffy Tail", "Blue Flute", "Yellow Flute", "Red Flute", "Black Flute", "White Flute", "Shoal Salt", "Shoal Shell", "Red Shard", "Blue Shard", "Yellow Shard", "Green Shard", "Super Repel", "Max Repel", "Escape Rope", "Repel", "Sun Stone", "Moon Stone", "Fire Stone", "Thunder Stone", "Water Stone", "Leaf Stone", "Tiny Mushroom", "Big Mushroom", "Pearl", "Big Pearl", "Stardust", "Star Piece", "Nugget", "Heart Scale", "Honey", "Growth Mulch", "Damp Mulch", "Stable Mulch", "Gooey Mulch", "Root Fossil", "Claw Fossil", "Helix Fossil", "Dome Fossil", "Old Amber", "Armor Fossil", "Skull Fossil", "Rare Bone", "Shiny Stone", "Dusk Stone", "Dawn Stone", "Oval Stone", "Odd Keystone", "Griseous Orb", "???", "???", "???", "Douse Drive", "Shock Drive", "Burn Drive", "Chill Drive", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Sweet Heart", "Adamant Orb", "Lustrous Orb", "Greet Mail", "Favored Mail", "RSVP Mail", "Thanks Mail", "Inquiry Mail", "Like Mail", "Reply Mail", "Bridge Mail S", "Bridge Mail D", "Bridge Mail T", "Bridge Mail V", "Bridge Mail M", "Cheri Berry", "Chesto Berry", "Pecha Berry", "Rawst Berry", "Aspear Berry", "Leppa Berry", "Oran Berry", "Persim Berry", "Lum Berry", "Sitrus Berry", "Figy Berry", "Wiki Berry", "Mago Berry", "Aguav Berry", "Iapapa Berry", "Razz Berry", "Bluk Berry", "Nanab Berry", "Wepear Berry", "Pinap Berry", "Pomeg Berry", "Kelpsy Berry", "Qualot Berry", "Hondew Berry", "Grepa Berry", "Tamato Berry", "Cornn Berry", "Magost Berry", "Rabuta Berry", "Nomel Berry", "Spelon Berry", "Pamtre Berry", "Watmel Berry", "Durin Berry", "Belue Berry", "Occa Berry", "Passho Berry", "Wacan Berry", "Rindo Berry", "Yache Berry", "Chople Berry", "Kebia Berry", "Shuca Berry", "Coba Berry", "Payapa Berry", "Tanga Berry", "Charti Berry", "Kasib Berry", "Haban Berry", "Colbur Berry", "Babiri Berry", "Chilan Berry", "Liechi Berry", "Ganlon Berry", "Salac Berry", "Petaya Berry", "Apicot Berry", "Lansat Berry", "Starf Berry", "Enigma Berry", "Micle Berry", "Custap Berry", "Jaboca Berry", "Rowap Berry", "Bright Powder", "White Herb", "Macho Brace", "Exp. Share", "Quick Claw", "Soothe Bell", "Mental Herb", "Choice Band", "King’s Rock", "Silver Powder", "Amulet Coin", "Cleanse Tag", "Soul Dew", "Deep Sea Tooth", "Deep Sea Scale", "Smoke Ball", "Everstone", "Focus Band", "Lucky Egg", "Scope Lens", "Metal Coat", "Leftovers", "Dragon Scale", "Light Ball", "Soft Sand", "Hard Stone", "Miracle Seed", "Black Glasses", "Black Belt", "Magnet", "Mystic Water", "Sharp Beak", "Poison Barb", "Never-Melt Ice", "Spell Tag", "Twisted Spoon", "Charcoal", "Dragon Fang", "Silk Scarf", "Up-Grade", "Shell Bell", "Sea Incense", "Lax Incense", "Lucky Punch", "Metal Powder", "Thick Club", "Stick", "Red Scarf", "Blue Scarf", "Pink Scarf", "Green Scarf", "Yellow Scarf", "Wide Lens", "Muscle Band", "Wise Glasses", "Expert Belt", "Light Clay", "Life Orb", "Power Herb", "Toxic Orb", "Flame Orb", "Quick Powder", "Focus Sash", "Zoom Lens", "Metronome", "Iron Ball", "Lagging Tail", "Destiny Knot", "Black Sludge", "Icy Rock", "Smooth Rock", "Heat Rock", "Damp Rock", "Grip Claw", "Choice Scarf", "Sticky Barb", "Power Bracer", "Power Belt", "Power Lens", "Power Band", "Power Anklet", "Power Weight", "Shed Shell", "Big Root", "Choice Specs", "Flame Plate", "Splash Plate", "Zap Plate", "Meadow Plate", "Icicle Plate", "Fist Plate", "Toxic Plate", "Earth Plate", "Sky Plate", "Mind Plate", "Insect Plate", "Stone Plate", "Spooky Plate", "Draco Plate", "Dread Plate", "Iron Plate", "Odd Incense", "Rock Incense", "Full Incense", "Wave Incense", "Rose Incense", "Luck Incense", "Pure Incense", "Protector", "Electirizer", "Magmarizer", "Dubious Disc", "Reaper Cloth", "Razor Claw", "Razor Fang", "TM01", "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11", "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21", "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31", "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41", "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "TM51", "TM52", "TM53", "TM54", "TM55", "TM56", "TM57", "TM58", "TM59", "TM60", "TM61", "TM62", "TM63", "TM64", "TM65", "TM66", "TM67", "TM68", "TM69", "TM70", "TM71", "TM72", "TM73", "TM74", "TM75", "TM76", "TM77", "TM78", "TM79", "TM80", "TM81", "TM82", "TM83", "TM84", "TM85", "TM86", "TM87", "TM88", "TM89", "TM90", "TM91", "TM92", "HM01", "HM02", "HM03", "HM04", "HM05", "HM06", "???", "???", "Explorer Kit", "Loot Sack", "Rule Book", "Poké Radar", "Point Card", "Journal", "Seal Case", "Fashion Case", "Seal Bag", "Pal Pad", "Works Key", "Old Charm", "Galactic Key", "Red Chain", "Town Map", "Vs. Seeker", "Coin Case", "Old Rod", "Good Rod", "Super Rod", "Sprayduck", "Poffin Case", "Bike", "Suite Key", "Oak’s Letter", "Lunar Wing", "Member Card", "Azure Flute", "S.S. Ticket", "Contest Pass", "Magma Stone", "Parcel", "Coupon 1", "Coupon 2", "Coupon 3", "Storage Key", "Secret Potion", "Vs. Recorder", "Gracidea", "Secret Key", "Apricorn Box", "Unown Report", "Berry Pots", "Dowsing Machine", "Blue Card", "Slowpoke Tail", "Clear Bell", "Card Key", "Basement Key", "Squirt Bottle", "Red Scale", "Lost Item", "Pass", "Machine Part", "Silver Wing", "Rainbow Wing", "Mystery Egg", "Red Apricorn", "Blue Apricorn", "Yellow Apricorn", "Green Apricorn", "Pink Apricorn", "White Apricorn", "Black Apricorn", "Fast Ball", "Level Ball", "Lure Ball", "Heavy Ball", "Love Ball", "Friend Ball", "Moon Ball", "Sport Ball", "Park Ball", "Photo Album", "GB Sounds", "Tidal Bell", "Rage Candy Bar", "Data Card 01", "Data Card 02", "Data Card 03", "Data Card 04", "Data Card 05", "Data Card 06", "Data Card 07", "Data Card 08", "Data Card 09", "Data Card 10", "Data Card 11", "Data Card 12", "Data Card 13", "Data Card 14", "Data Card 15", "Data Card 16", "Data Card 17", "Data Card 18", "Data Card 19", "Data Card 20", "Data Card 21", "Data Card 22", "Data Card 23", "Data Card 24", "Data Card 25", "Data Card 26", "Data Card 27", "Jade Orb", "Lock Capsule", "Red Orb", "Blue Orb", "Enigma Stone", "Prism Scale", "Eviolite", "Float Stone", "Rocky Helmet", "Air Balloon", "Red Card", "Ring Target", "Binding Band", "Absorb Bulb", "Cell Battery", "Eject Button", "Fire Gem", "Water Gem", "Electric Gem", "Grass Gem", "Ice Gem", "Fighting Gem", "Poison Gem", "Ground Gem", "Flying Gem", "Psychic Gem", "Bug Gem", "Rock Gem", "Ghost Gem", "Dragon Gem", "Dark Gem", "Steel Gem", "Normal Gem", "Health Wing", "Muscle Wing", "Resist Wing", "Genius Wing", "Clever Wing", "Swift Wing", "Pretty Wing", "Cover Fossil", "Plume Fossil", "Liberty Pass", "Pass Orb", "Dream Ball", "Poké Toy", "Prop Case", "Dragon Skull", "Balm Mushroom", "Big Nugget", "Pearl String", "Comet Shard", "Relic Copper", "Relic Silver", "Relic Gold", "Relic Vase", "Relic Band", "Relic Statue", "Relic Crown", "Casteliacone", "Dire Hit 2", "X Speed 2", "X Sp. Atk 2", "X Sp. Def 2", "X Defense 2", "X Attack 2", "X Accuracy 2", "X Speed 3", "X Sp. Atk 3", "X Sp. Def 3", "X Defense 3", "X Attack 3", "X Accuracy 3", "X Speed 6", "X Sp. Atk 6", "X Sp. Def 6", "X Defense 6", "X Attack 6", "X Accuracy 6", "Ability Urge", "Item Drop", "Item Urge", "Reset Urge", "Dire Hit 3", "Light Stone", "Dark Stone", "TM93", "TM94", "TM95", "Xtransceiver", "???", "Gram 1", "Gram 2", "Gram 3", "Xtransceiver", "Medal Box", "DNA Splicers", "DNA Splicers", "Permit", "Oval Charm", "Shiny Charm", "Plasma Card", "Grubby Hanky", "Colress Machine", "Dropped Item", "Dropped Item", "Reveal Glass", "Weakness Policy", "Assault Vest", "Holo Caster", "Prof’s Letter", "Roller Skates", "Pixie Plate", "Ability Capsule", "Whipped Dream", "Sachet", "Luminous Moss", "Snowball", "Safety Goggles", "Poké Flute", "Rich Mulch", "Surprise Mulch", "Boost Mulch", "Amaze Mulch", "Gengarite", "Gardevoirite", "Ampharosite", "Venusaurite", "Charizardite X", "Blastoisinite", "Mewtwonite X", "Mewtwonite Y", "Blazikenite", "Medichamite", "Houndoominite", "Aggronite", "Banettite", "Tyranitarite", "Scizorite", "Pinsirite", "Aerodactylite", "Lucarionite", "Abomasite", "Kangaskhanite", "Gyaradosite", "Absolite", "Charizardite Y", "Alakazite", "Heracronite", "Mawilite", "Manectite", "Garchompite", "Latiasite", "Latiosite", "Roseli Berry", "Kee Berry", "Maranga Berry", "Sprinklotad", "TM96", "TM97", "TM98", "TM99", "TM100", "Power Plant Pass", "Mega Ring", "Intriguing Stone", "Common Stone", "Discount Coupon", "Elevator Key", "TMV Pass", "Honor of Kalos", "Adventure Rules", "Strange Souvenir", "Lens Case", "Makeup Bag", "Travel Trunk", "Lumiose Galette", "Shalour Sable", "Jaw Fossil", "Sail Fossil", "Looker Ticket", "Bike", "Holo Caster", "Fairy Gem", "Mega Charm", "Mega Glove", "Mach Bike", "Acro Bike", "Wailmer Pail", "Devon Parts", "Soot Sack", "Basement Key", "Pokéblock Kit", "Letter", "Eon Ticket", "Scanner", "Go-Goggles", "Meteorite", "Key to Room 1", "Key to Room 2", "Key to Room 4", "Key to Room 6", "Storage Key", "Devon Scope", "S.S. Ticket", "HM07", "Devon Scuba Gear", "Contest Costume", "Contest Costume", "Magma Suit", "Aqua Suit", "Pair of Tickets", "Mega Bracelet", "Mega Pendant", "Mega Glasses", "Mega Anchor", "Mega Stickpin", "Mega Tiara", "Mega Anklet", "Meteorite", "Swampertite", "Sceptilite", "Sablenite", "Altarianite", "Galladite", "Audinite", "Metagrossite", "Sharpedonite", "Slowbronite", "Steelixite", "Pidgeotite", "Glalitite", "Diancite", "Prison Bottle", "Mega Cuff", "Cameruptite", "Lopunnite", "Salamencite", "Beedrillite", "Meteorite", "Meteorite", "Key Stone", "Meteorite Shard", "Eon Flute", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Z-Ring", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "UB Ball *", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a" });
            itembox3.FormattingEnabled = true;
            itembox3.Location = new Point(104, 86);
            itembox3.Margin = new Padding(4, 4, 4, 4);
            itembox3.Name = "itembox3";
            itembox3.Size = new Size(141, 23);
            itembox3.TabIndex = 5;
            // 
            // itembox2
            // 
            itembox2.AllowDrop = true;
            itembox2.AutoCompleteCustomSource.AddRange(new string[] { "None", "Master Ball", "Ultra Ball", "Great Ball", "Poké Ball", "Safari Ball", "Net Ball", "Dive Ball", "Nest Ball", "Repeat Ball", "Timer Ball", "Luxury Ball", "Premier Ball", "Dusk Ball", "Heal Ball", "Quick Ball", "Cherish Ball", "Potion", "Antidote", "Burn Heal", "Ice Heal", "Awakening", "Paralyze Heal", "Full Restore", "Max Potion", "Hyper Potion", "Super Potion", "Full Heal", "Revive", "Max Revive", "Fresh Water", "Soda Pop", "Lemonade", "Moomoo Milk", "Energy Powder", "Energy Root", "Heal Powder", "Revival Herb", "Ether", "Max Ether", "Elixir", "Max Elixir", "Lava Cookie", "Berry Juice", "Sacred Ash", "HP Up", "Protein", "Iron", "Carbos", "Calcium", "Rare Candy", "PP Up", "Zinc", "PP Max", "Old Gateau", "Guard Spec.", "Dire Hit", "X Attack", "X Defense", "X Speed", "X Accuracy", "X Sp. Atk", "X Sp. Def", "Poké Doll", "Fluffy Tail", "Blue Flute", "Yellow Flute", "Red Flute", "Black Flute", "White Flute", "Shoal Salt", "Shoal Shell", "Red Shard", "Blue Shard", "Yellow Shard", "Green Shard", "Super Repel", "Max Repel", "Escape Rope", "Repel", "Sun Stone", "Moon Stone", "Fire Stone", "Thunder Stone", "Water Stone", "Leaf Stone", "Tiny Mushroom", "Big Mushroom", "Pearl", "Big Pearl", "Stardust", "Star Piece", "Nugget", "Heart Scale", "Honey", "Growth Mulch", "Damp Mulch", "Stable Mulch", "Gooey Mulch", "Root Fossil", "Claw Fossil", "Helix Fossil", "Dome Fossil", "Old Amber", "Armor Fossil", "Skull Fossil", "Rare Bone", "Shiny Stone", "Dusk Stone", "Dawn Stone", "Oval Stone", "Odd Keystone", "Griseous Orb", "???", "???", "???", "Douse Drive", "Shock Drive", "Burn Drive", "Chill Drive", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Sweet Heart", "Adamant Orb", "Lustrous Orb", "Greet Mail", "Favored Mail", "RSVP Mail", "Thanks Mail", "Inquiry Mail", "Like Mail", "Reply Mail", "Bridge Mail S", "Bridge Mail D", "Bridge Mail T", "Bridge Mail V", "Bridge Mail M", "Cheri Berry", "Chesto Berry", "Pecha Berry", "Rawst Berry", "Aspear Berry", "Leppa Berry", "Oran Berry", "Persim Berry", "Lum Berry", "Sitrus Berry", "Figy Berry", "Wiki Berry", "Mago Berry", "Aguav Berry", "Iapapa Berry", "Razz Berry", "Bluk Berry", "Nanab Berry", "Wepear Berry", "Pinap Berry", "Pomeg Berry", "Kelpsy Berry", "Qualot Berry", "Hondew Berry", "Grepa Berry", "Tamato Berry", "Cornn Berry", "Magost Berry", "Rabuta Berry", "Nomel Berry", "Spelon Berry", "Pamtre Berry", "Watmel Berry", "Durin Berry", "Belue Berry", "Occa Berry", "Passho Berry", "Wacan Berry", "Rindo Berry", "Yache Berry", "Chople Berry", "Kebia Berry", "Shuca Berry", "Coba Berry", "Payapa Berry", "Tanga Berry", "Charti Berry", "Kasib Berry", "Haban Berry", "Colbur Berry", "Babiri Berry", "Chilan Berry", "Liechi Berry", "Ganlon Berry", "Salac Berry", "Petaya Berry", "Apicot Berry", "Lansat Berry", "Starf Berry", "Enigma Berry", "Micle Berry", "Custap Berry", "Jaboca Berry", "Rowap Berry", "Bright Powder", "White Herb", "Macho Brace", "Exp. Share", "Quick Claw", "Soothe Bell", "Mental Herb", "Choice Band", "King’s Rock", "Silver Powder", "Amulet Coin", "Cleanse Tag", "Soul Dew", "Deep Sea Tooth", "Deep Sea Scale", "Smoke Ball", "Everstone", "Focus Band", "Lucky Egg", "Scope Lens", "Metal Coat", "Leftovers", "Dragon Scale", "Light Ball", "Soft Sand", "Hard Stone", "Miracle Seed", "Black Glasses", "Black Belt", "Magnet", "Mystic Water", "Sharp Beak", "Poison Barb", "Never-Melt Ice", "Spell Tag", "Twisted Spoon", "Charcoal", "Dragon Fang", "Silk Scarf", "Up-Grade", "Shell Bell", "Sea Incense", "Lax Incense", "Lucky Punch", "Metal Powder", "Thick Club", "Stick", "Red Scarf", "Blue Scarf", "Pink Scarf", "Green Scarf", "Yellow Scarf", "Wide Lens", "Muscle Band", "Wise Glasses", "Expert Belt", "Light Clay", "Life Orb", "Power Herb", "Toxic Orb", "Flame Orb", "Quick Powder", "Focus Sash", "Zoom Lens", "Metronome", "Iron Ball", "Lagging Tail", "Destiny Knot", "Black Sludge", "Icy Rock", "Smooth Rock", "Heat Rock", "Damp Rock", "Grip Claw", "Choice Scarf", "Sticky Barb", "Power Bracer", "Power Belt", "Power Lens", "Power Band", "Power Anklet", "Power Weight", "Shed Shell", "Big Root", "Choice Specs", "Flame Plate", "Splash Plate", "Zap Plate", "Meadow Plate", "Icicle Plate", "Fist Plate", "Toxic Plate", "Earth Plate", "Sky Plate", "Mind Plate", "Insect Plate", "Stone Plate", "Spooky Plate", "Draco Plate", "Dread Plate", "Iron Plate", "Odd Incense", "Rock Incense", "Full Incense", "Wave Incense", "Rose Incense", "Luck Incense", "Pure Incense", "Protector", "Electirizer", "Magmarizer", "Dubious Disc", "Reaper Cloth", "Razor Claw", "Razor Fang", "TM01", "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11", "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21", "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31", "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41", "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "TM51", "TM52", "TM53", "TM54", "TM55", "TM56", "TM57", "TM58", "TM59", "TM60", "TM61", "TM62", "TM63", "TM64", "TM65", "TM66", "TM67", "TM68", "TM69", "TM70", "TM71", "TM72", "TM73", "TM74", "TM75", "TM76", "TM77", "TM78", "TM79", "TM80", "TM81", "TM82", "TM83", "TM84", "TM85", "TM86", "TM87", "TM88", "TM89", "TM90", "TM91", "TM92", "HM01", "HM02", "HM03", "HM04", "HM05", "HM06", "???", "???", "Explorer Kit", "Loot Sack", "Rule Book", "Poké Radar", "Point Card", "Journal", "Seal Case", "Fashion Case", "Seal Bag", "Pal Pad", "Works Key", "Old Charm", "Galactic Key", "Red Chain", "Town Map", "Vs. Seeker", "Coin Case", "Old Rod", "Good Rod", "Super Rod", "Sprayduck", "Poffin Case", "Bike", "Suite Key", "Oak’s Letter", "Lunar Wing", "Member Card", "Azure Flute", "S.S. Ticket", "Contest Pass", "Magma Stone", "Parcel", "Coupon 1", "Coupon 2", "Coupon 3", "Storage Key", "Secret Potion", "Vs. Recorder", "Gracidea", "Secret Key", "Apricorn Box", "Unown Report", "Berry Pots", "Dowsing Machine", "Blue Card", "Slowpoke Tail", "Clear Bell", "Card Key", "Basement Key", "Squirt Bottle", "Red Scale", "Lost Item", "Pass", "Machine Part", "Silver Wing", "Rainbow Wing", "Mystery Egg", "Red Apricorn", "Blue Apricorn", "Yellow Apricorn", "Green Apricorn", "Pink Apricorn", "White Apricorn", "Black Apricorn", "Fast Ball", "Level Ball", "Lure Ball", "Heavy Ball", "Love Ball", "Friend Ball", "Moon Ball", "Sport Ball", "Park Ball", "Photo Album", "GB Sounds", "Tidal Bell", "Rage Candy Bar", "Data Card 01", "Data Card 02", "Data Card 03", "Data Card 04", "Data Card 05", "Data Card 06", "Data Card 07", "Data Card 08", "Data Card 09", "Data Card 10", "Data Card 11", "Data Card 12", "Data Card 13", "Data Card 14", "Data Card 15", "Data Card 16", "Data Card 17", "Data Card 18", "Data Card 19", "Data Card 20", "Data Card 21", "Data Card 22", "Data Card 23", "Data Card 24", "Data Card 25", "Data Card 26", "Data Card 27", "Jade Orb", "Lock Capsule", "Red Orb", "Blue Orb", "Enigma Stone", "Prism Scale", "Eviolite", "Float Stone", "Rocky Helmet", "Air Balloon", "Red Card", "Ring Target", "Binding Band", "Absorb Bulb", "Cell Battery", "Eject Button", "Fire Gem", "Water Gem", "Electric Gem", "Grass Gem", "Ice Gem", "Fighting Gem", "Poison Gem", "Ground Gem", "Flying Gem", "Psychic Gem", "Bug Gem", "Rock Gem", "Ghost Gem", "Dragon Gem", "Dark Gem", "Steel Gem", "Normal Gem", "Health Wing", "Muscle Wing", "Resist Wing", "Genius Wing", "Clever Wing", "Swift Wing", "Pretty Wing", "Cover Fossil", "Plume Fossil", "Liberty Pass", "Pass Orb", "Dream Ball", "Poké Toy", "Prop Case", "Dragon Skull", "Balm Mushroom", "Big Nugget", "Pearl String", "Comet Shard", "Relic Copper", "Relic Silver", "Relic Gold", "Relic Vase", "Relic Band", "Relic Statue", "Relic Crown", "Casteliacone", "Dire Hit 2", "X Speed 2", "X Sp. Atk 2", "X Sp. Def 2", "X Defense 2", "X Attack 2", "X Accuracy 2", "X Speed 3", "X Sp. Atk 3", "X Sp. Def 3", "X Defense 3", "X Attack 3", "X Accuracy 3", "X Speed 6", "X Sp. Atk 6", "X Sp. Def 6", "X Defense 6", "X Attack 6", "X Accuracy 6", "Ability Urge", "Item Drop", "Item Urge", "Reset Urge", "Dire Hit 3", "Light Stone", "Dark Stone", "TM93", "TM94", "TM95", "Xtransceiver", "???", "Gram 1", "Gram 2", "Gram 3", "Xtransceiver", "Medal Box", "DNA Splicers", "DNA Splicers", "Permit", "Oval Charm", "Shiny Charm", "Plasma Card", "Grubby Hanky", "Colress Machine", "Dropped Item", "Dropped Item", "Reveal Glass", "Weakness Policy", "Assault Vest", "Holo Caster", "Prof’s Letter", "Roller Skates", "Pixie Plate", "Ability Capsule", "Whipped Dream", "Sachet", "Luminous Moss", "Snowball", "Safety Goggles", "Poké Flute", "Rich Mulch", "Surprise Mulch", "Boost Mulch", "Amaze Mulch", "Gengarite", "Gardevoirite", "Ampharosite", "Venusaurite", "Charizardite X", "Blastoisinite", "Mewtwonite X", "Mewtwonite Y", "Blazikenite", "Medichamite", "Houndoominite", "Aggronite", "Banettite", "Tyranitarite", "Scizorite", "Pinsirite", "Aerodactylite", "Lucarionite", "Abomasite", "Kangaskhanite", "Gyaradosite", "Absolite", "Charizardite Y", "Alakazite", "Heracronite", "Mawilite", "Manectite", "Garchompite", "Latiasite", "Latiosite", "Roseli Berry", "Kee Berry", "Maranga Berry", "Sprinklotad", "TM96", "TM97", "TM98", "TM99", "TM100", "Power Plant Pass", "Mega Ring", "Intriguing Stone", "Common Stone", "Discount Coupon", "Elevator Key", "TMV Pass", "Honor of Kalos", "Adventure Rules", "Strange Souvenir", "Lens Case", "Makeup Bag", "Travel Trunk", "Lumiose Galette", "Shalour Sable", "Jaw Fossil", "Sail Fossil", "Looker Ticket", "Bike", "Holo Caster", "Fairy Gem", "Mega Charm", "Mega Glove", "Mach Bike", "Acro Bike", "Wailmer Pail", "Devon Parts", "Soot Sack", "Basement Key", "Pokéblock Kit", "Letter", "Eon Ticket", "Scanner", "Go-Goggles", "Meteorite", "Key to Room 1", "Key to Room 2", "Key to Room 4", "Key to Room 6", "Storage Key", "Devon Scope", "S.S. Ticket", "HM07", "Devon Scuba Gear", "Contest Costume", "Contest Costume", "Magma Suit", "Aqua Suit", "Pair of Tickets", "Mega Bracelet", "Mega Pendant", "Mega Glasses", "Mega Anchor", "Mega Stickpin", "Mega Tiara", "Mega Anklet", "Meteorite", "Swampertite", "Sceptilite", "Sablenite", "Altarianite", "Galladite", "Audinite", "Metagrossite", "Sharpedonite", "Slowbronite", "Steelixite", "Pidgeotite", "Glalitite", "Diancite", "Prison Bottle", "Mega Cuff", "Cameruptite", "Lopunnite", "Salamencite", "Beedrillite", "Meteorite", "Meteorite", "Key Stone", "Meteorite Shard", "Eon Flute", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Z-Ring", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "UB Ball *", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a" });
            itembox2.FormattingEnabled = true;
            itembox2.Location = new Point(104, 56);
            itembox2.Margin = new Padding(4, 4, 4, 4);
            itembox2.Name = "itembox2";
            itembox2.Size = new Size(141, 23);
            itembox2.TabIndex = 3;
            // 
            // itembox1
            // 
            itembox1.AllowDrop = true;
            itembox1.AutoCompleteCustomSource.AddRange(new string[] { "None", "Master Ball", "Ultra Ball", "Great Ball", "Poké Ball", "Safari Ball", "Net Ball", "Dive Ball", "Nest Ball", "Repeat Ball", "Timer Ball", "Luxury Ball", "Premier Ball", "Dusk Ball", "Heal Ball", "Quick Ball", "Cherish Ball", "Potion", "Antidote", "Burn Heal", "Ice Heal", "Awakening", "Paralyze Heal", "Full Restore", "Max Potion", "Hyper Potion", "Super Potion", "Full Heal", "Revive", "Max Revive", "Fresh Water", "Soda Pop", "Lemonade", "Moomoo Milk", "Energy Powder", "Energy Root", "Heal Powder", "Revival Herb", "Ether", "Max Ether", "Elixir", "Max Elixir", "Lava Cookie", "Berry Juice", "Sacred Ash", "HP Up", "Protein", "Iron", "Carbos", "Calcium", "Rare Candy", "PP Up", "Zinc", "PP Max", "Old Gateau", "Guard Spec.", "Dire Hit", "X Attack", "X Defense", "X Speed", "X Accuracy", "X Sp. Atk", "X Sp. Def", "Poké Doll", "Fluffy Tail", "Blue Flute", "Yellow Flute", "Red Flute", "Black Flute", "White Flute", "Shoal Salt", "Shoal Shell", "Red Shard", "Blue Shard", "Yellow Shard", "Green Shard", "Super Repel", "Max Repel", "Escape Rope", "Repel", "Sun Stone", "Moon Stone", "Fire Stone", "Thunder Stone", "Water Stone", "Leaf Stone", "Tiny Mushroom", "Big Mushroom", "Pearl", "Big Pearl", "Stardust", "Star Piece", "Nugget", "Heart Scale", "Honey", "Growth Mulch", "Damp Mulch", "Stable Mulch", "Gooey Mulch", "Root Fossil", "Claw Fossil", "Helix Fossil", "Dome Fossil", "Old Amber", "Armor Fossil", "Skull Fossil", "Rare Bone", "Shiny Stone", "Dusk Stone", "Dawn Stone", "Oval Stone", "Odd Keystone", "Griseous Orb", "???", "???", "???", "Douse Drive", "Shock Drive", "Burn Drive", "Chill Drive", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Sweet Heart", "Adamant Orb", "Lustrous Orb", "Greet Mail", "Favored Mail", "RSVP Mail", "Thanks Mail", "Inquiry Mail", "Like Mail", "Reply Mail", "Bridge Mail S", "Bridge Mail D", "Bridge Mail T", "Bridge Mail V", "Bridge Mail M", "Cheri Berry", "Chesto Berry", "Pecha Berry", "Rawst Berry", "Aspear Berry", "Leppa Berry", "Oran Berry", "Persim Berry", "Lum Berry", "Sitrus Berry", "Figy Berry", "Wiki Berry", "Mago Berry", "Aguav Berry", "Iapapa Berry", "Razz Berry", "Bluk Berry", "Nanab Berry", "Wepear Berry", "Pinap Berry", "Pomeg Berry", "Kelpsy Berry", "Qualot Berry", "Hondew Berry", "Grepa Berry", "Tamato Berry", "Cornn Berry", "Magost Berry", "Rabuta Berry", "Nomel Berry", "Spelon Berry", "Pamtre Berry", "Watmel Berry", "Durin Berry", "Belue Berry", "Occa Berry", "Passho Berry", "Wacan Berry", "Rindo Berry", "Yache Berry", "Chople Berry", "Kebia Berry", "Shuca Berry", "Coba Berry", "Payapa Berry", "Tanga Berry", "Charti Berry", "Kasib Berry", "Haban Berry", "Colbur Berry", "Babiri Berry", "Chilan Berry", "Liechi Berry", "Ganlon Berry", "Salac Berry", "Petaya Berry", "Apicot Berry", "Lansat Berry", "Starf Berry", "Enigma Berry", "Micle Berry", "Custap Berry", "Jaboca Berry", "Rowap Berry", "Bright Powder", "White Herb", "Macho Brace", "Exp. Share", "Quick Claw", "Soothe Bell", "Mental Herb", "Choice Band", "King’s Rock", "Silver Powder", "Amulet Coin", "Cleanse Tag", "Soul Dew", "Deep Sea Tooth", "Deep Sea Scale", "Smoke Ball", "Everstone", "Focus Band", "Lucky Egg", "Scope Lens", "Metal Coat", "Leftovers", "Dragon Scale", "Light Ball", "Soft Sand", "Hard Stone", "Miracle Seed", "Black Glasses", "Black Belt", "Magnet", "Mystic Water", "Sharp Beak", "Poison Barb", "Never-Melt Ice", "Spell Tag", "Twisted Spoon", "Charcoal", "Dragon Fang", "Silk Scarf", "Up-Grade", "Shell Bell", "Sea Incense", "Lax Incense", "Lucky Punch", "Metal Powder", "Thick Club", "Stick", "Red Scarf", "Blue Scarf", "Pink Scarf", "Green Scarf", "Yellow Scarf", "Wide Lens", "Muscle Band", "Wise Glasses", "Expert Belt", "Light Clay", "Life Orb", "Power Herb", "Toxic Orb", "Flame Orb", "Quick Powder", "Focus Sash", "Zoom Lens", "Metronome", "Iron Ball", "Lagging Tail", "Destiny Knot", "Black Sludge", "Icy Rock", "Smooth Rock", "Heat Rock", "Damp Rock", "Grip Claw", "Choice Scarf", "Sticky Barb", "Power Bracer", "Power Belt", "Power Lens", "Power Band", "Power Anklet", "Power Weight", "Shed Shell", "Big Root", "Choice Specs", "Flame Plate", "Splash Plate", "Zap Plate", "Meadow Plate", "Icicle Plate", "Fist Plate", "Toxic Plate", "Earth Plate", "Sky Plate", "Mind Plate", "Insect Plate", "Stone Plate", "Spooky Plate", "Draco Plate", "Dread Plate", "Iron Plate", "Odd Incense", "Rock Incense", "Full Incense", "Wave Incense", "Rose Incense", "Luck Incense", "Pure Incense", "Protector", "Electirizer", "Magmarizer", "Dubious Disc", "Reaper Cloth", "Razor Claw", "Razor Fang", "TM01", "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11", "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21", "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31", "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41", "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "TM51", "TM52", "TM53", "TM54", "TM55", "TM56", "TM57", "TM58", "TM59", "TM60", "TM61", "TM62", "TM63", "TM64", "TM65", "TM66", "TM67", "TM68", "TM69", "TM70", "TM71", "TM72", "TM73", "TM74", "TM75", "TM76", "TM77", "TM78", "TM79", "TM80", "TM81", "TM82", "TM83", "TM84", "TM85", "TM86", "TM87", "TM88", "TM89", "TM90", "TM91", "TM92", "HM01", "HM02", "HM03", "HM04", "HM05", "HM06", "???", "???", "Explorer Kit", "Loot Sack", "Rule Book", "Poké Radar", "Point Card", "Journal", "Seal Case", "Fashion Case", "Seal Bag", "Pal Pad", "Works Key", "Old Charm", "Galactic Key", "Red Chain", "Town Map", "Vs. Seeker", "Coin Case", "Old Rod", "Good Rod", "Super Rod", "Sprayduck", "Poffin Case", "Bike", "Suite Key", "Oak’s Letter", "Lunar Wing", "Member Card", "Azure Flute", "S.S. Ticket", "Contest Pass", "Magma Stone", "Parcel", "Coupon 1", "Coupon 2", "Coupon 3", "Storage Key", "Secret Potion", "Vs. Recorder", "Gracidea", "Secret Key", "Apricorn Box", "Unown Report", "Berry Pots", "Dowsing Machine", "Blue Card", "Slowpoke Tail", "Clear Bell", "Card Key", "Basement Key", "Squirt Bottle", "Red Scale", "Lost Item", "Pass", "Machine Part", "Silver Wing", "Rainbow Wing", "Mystery Egg", "Red Apricorn", "Blue Apricorn", "Yellow Apricorn", "Green Apricorn", "Pink Apricorn", "White Apricorn", "Black Apricorn", "Fast Ball", "Level Ball", "Lure Ball", "Heavy Ball", "Love Ball", "Friend Ball", "Moon Ball", "Sport Ball", "Park Ball", "Photo Album", "GB Sounds", "Tidal Bell", "Rage Candy Bar", "Data Card 01", "Data Card 02", "Data Card 03", "Data Card 04", "Data Card 05", "Data Card 06", "Data Card 07", "Data Card 08", "Data Card 09", "Data Card 10", "Data Card 11", "Data Card 12", "Data Card 13", "Data Card 14", "Data Card 15", "Data Card 16", "Data Card 17", "Data Card 18", "Data Card 19", "Data Card 20", "Data Card 21", "Data Card 22", "Data Card 23", "Data Card 24", "Data Card 25", "Data Card 26", "Data Card 27", "Jade Orb", "Lock Capsule", "Red Orb", "Blue Orb", "Enigma Stone", "Prism Scale", "Eviolite", "Float Stone", "Rocky Helmet", "Air Balloon", "Red Card", "Ring Target", "Binding Band", "Absorb Bulb", "Cell Battery", "Eject Button", "Fire Gem", "Water Gem", "Electric Gem", "Grass Gem", "Ice Gem", "Fighting Gem", "Poison Gem", "Ground Gem", "Flying Gem", "Psychic Gem", "Bug Gem", "Rock Gem", "Ghost Gem", "Dragon Gem", "Dark Gem", "Steel Gem", "Normal Gem", "Health Wing", "Muscle Wing", "Resist Wing", "Genius Wing", "Clever Wing", "Swift Wing", "Pretty Wing", "Cover Fossil", "Plume Fossil", "Liberty Pass", "Pass Orb", "Dream Ball", "Poké Toy", "Prop Case", "Dragon Skull", "Balm Mushroom", "Big Nugget", "Pearl String", "Comet Shard", "Relic Copper", "Relic Silver", "Relic Gold", "Relic Vase", "Relic Band", "Relic Statue", "Relic Crown", "Casteliacone", "Dire Hit 2", "X Speed 2", "X Sp. Atk 2", "X Sp. Def 2", "X Defense 2", "X Attack 2", "X Accuracy 2", "X Speed 3", "X Sp. Atk 3", "X Sp. Def 3", "X Defense 3", "X Attack 3", "X Accuracy 3", "X Speed 6", "X Sp. Atk 6", "X Sp. Def 6", "X Defense 6", "X Attack 6", "X Accuracy 6", "Ability Urge", "Item Drop", "Item Urge", "Reset Urge", "Dire Hit 3", "Light Stone", "Dark Stone", "TM93", "TM94", "TM95", "Xtransceiver", "???", "Gram 1", "Gram 2", "Gram 3", "Xtransceiver", "Medal Box", "DNA Splicers", "DNA Splicers", "Permit", "Oval Charm", "Shiny Charm", "Plasma Card", "Grubby Hanky", "Colress Machine", "Dropped Item", "Dropped Item", "Reveal Glass", "Weakness Policy", "Assault Vest", "Holo Caster", "Prof’s Letter", "Roller Skates", "Pixie Plate", "Ability Capsule", "Whipped Dream", "Sachet", "Luminous Moss", "Snowball", "Safety Goggles", "Poké Flute", "Rich Mulch", "Surprise Mulch", "Boost Mulch", "Amaze Mulch", "Gengarite", "Gardevoirite", "Ampharosite", "Venusaurite", "Charizardite X", "Blastoisinite", "Mewtwonite X", "Mewtwonite Y", "Blazikenite", "Medichamite", "Houndoominite", "Aggronite", "Banettite", "Tyranitarite", "Scizorite", "Pinsirite", "Aerodactylite", "Lucarionite", "Abomasite", "Kangaskhanite", "Gyaradosite", "Absolite", "Charizardite Y", "Alakazite", "Heracronite", "Mawilite", "Manectite", "Garchompite", "Latiasite", "Latiosite", "Roseli Berry", "Kee Berry", "Maranga Berry", "Sprinklotad", "TM96", "TM97", "TM98", "TM99", "TM100", "Power Plant Pass", "Mega Ring", "Intriguing Stone", "Common Stone", "Discount Coupon", "Elevator Key", "TMV Pass", "Honor of Kalos", "Adventure Rules", "Strange Souvenir", "Lens Case", "Makeup Bag", "Travel Trunk", "Lumiose Galette", "Shalour Sable", "Jaw Fossil", "Sail Fossil", "Looker Ticket", "Bike", "Holo Caster", "Fairy Gem", "Mega Charm", "Mega Glove", "Mach Bike", "Acro Bike", "Wailmer Pail", "Devon Parts", "Soot Sack", "Basement Key", "Pokéblock Kit", "Letter", "Eon Ticket", "Scanner", "Go-Goggles", "Meteorite", "Key to Room 1", "Key to Room 2", "Key to Room 4", "Key to Room 6", "Storage Key", "Devon Scope", "S.S. Ticket", "HM07", "Devon Scuba Gear", "Contest Costume", "Contest Costume", "Magma Suit", "Aqua Suit", "Pair of Tickets", "Mega Bracelet", "Mega Pendant", "Mega Glasses", "Mega Anchor", "Mega Stickpin", "Mega Tiara", "Mega Anklet", "Meteorite", "Swampertite", "Sceptilite", "Sablenite", "Altarianite", "Galladite", "Audinite", "Metagrossite", "Sharpedonite", "Slowbronite", "Steelixite", "Pidgeotite", "Glalitite", "Diancite", "Prison Bottle", "Mega Cuff", "Cameruptite", "Lopunnite", "Salamencite", "Beedrillite", "Meteorite", "Meteorite", "Key Stone", "Meteorite Shard", "Eon Flute", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Z-Ring", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "Electrium Z", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "UB Ball *", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a" });
            itembox1.FormattingEnabled = true;
            itembox1.Location = new Point(104, 24);
            itembox1.Margin = new Padding(4, 4, 4, 4);
            itembox1.Name = "itembox1";
            itembox1.Size = new Size(141, 23);
            itembox1.TabIndex = 1;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Location = new Point(16, 28);
            Label13.Margin = new Padding(4, 0, 4, 0);
            Label13.Name = "Label13";
            Label13.Size = new Size(55, 15);
            Label13.TabIndex = 521;
            Label13.Text = "Item 1";
            // 
            // CardTitleRefinedBox
            // 
            CardTitleRefinedBox.Enabled = false;
            CardTitleRefinedBox.Location = new Point(107, 255);
            CardTitleRefinedBox.Margin = new Padding(4, 4, 4, 4);
            CardTitleRefinedBox.MaxLength = 12;
            CardTitleRefinedBox.Name = "CardTitleRefinedBox";
            CardTitleRefinedBox.Size = new Size(503, 25);
            CardTitleRefinedBox.TabIndex = 2;
            CardTitleRefinedBox.TextChanged += CardTitleRefinedBox_TextChanged;
            // 
            // WC8_2_WR8_Button
            // 
            WC8_2_WR8_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WC8_2_WR8_Button.Location = new Point(5, 596);
            WC8_2_WR8_Button.Margin = new Padding(4, 4, 4, 4);
            WC8_2_WR8_Button.Name = "WC8_2_WR8_Button";
            WC8_2_WR8_Button.Size = new Size(151, 26);
            WC8_2_WR8_Button.TabIndex = 7;
            WC8_2_WR8_Button.Text = "Insert WB7 as WR7";
            WC8_2_WR8_Button.UseVisualStyleBackColor = true;
            WC8_2_WR8_Button.Visible = false;
            WC8_2_WR8_Button.Click += WC8_2_WR8_Button_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(398, 322);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new Size(79, 15);
            label34.TabIndex = 709;
            label34.Text = "Timestamp";
            // 
            // TimestampBox
            // 
            TimestampBox.Enabled = false;
            TimestampBox.Location = new Point(495, 318);
            TimestampBox.Margin = new Padding(4, 4, 4, 4);
            TimestampBox.MaxLength = 10;
            TimestampBox.Name = "TimestampBox";
            TimestampBox.Size = new Size(115, 25);
            TimestampBox.TabIndex = 6;
            TimestampBox.TextChanged += TimestampBox_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(52, 22);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(39, 15);
            label19.TabIndex = 711;
            label19.Text = "Year";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DateNul);
            groupBox1.Controls.Add(SecBox);
            groupBox1.Controls.Add(label40);
            groupBox1.Controls.Add(DayBox);
            groupBox1.Controls.Add(MinBox);
            groupBox1.Controls.Add(MonthBox);
            groupBox1.Controls.Add(HourBox);
            groupBox1.Controls.Add(YearBox);
            groupBox1.Controls.Add(label39);
            groupBox1.Controls.Add(label36);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label38);
            groupBox1.Controls.Add(label35);
            groupBox1.Location = new Point(716, 15);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(597, 81);
            groupBox1.TabIndex = 710;
            groupBox1.TabStop = false;
            groupBox1.Text = "Timestamp Reader";
            groupBox1.Visible = false;
            // 
            // DateNul
            // 
            DateNul.Location = new Point(527, 47);
            DateNul.Margin = new Padding(4, 4, 4, 4);
            DateNul.Name = "DateNul";
            DateNul.Size = new Size(55, 23);
            DateNul.TabIndex = 7;
            DateNul.Text = "NUL";
            DateNul.UseVisualStyleBackColor = true;
            DateNul.Click += DateNul_Click;
            // 
            // SecBox
            // 
            SecBox.Location = new Point(432, 47);
            SecBox.Margin = new Padding(4, 4, 4, 4);
            SecBox.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            SecBox.Name = "SecBox";
            SecBox.Size = new Size(87, 25);
            SecBox.TabIndex = 6;
            SecBox.ValueChanged += SecBox_ValueChanged;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(385, 50);
            label40.Margin = new Padding(4, 0, 4, 0);
            label40.Name = "label40";
            label40.Size = new Size(31, 15);
            label40.TabIndex = 723;
            label40.Text = "Sec";
            // 
            // DayBox
            // 
            DayBox.Location = new Point(432, 20);
            DayBox.Margin = new Padding(4, 4, 4, 4);
            DayBox.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            DayBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DayBox.Name = "DayBox";
            DayBox.Size = new Size(87, 25);
            DayBox.TabIndex = 3;
            DayBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            DayBox.ValueChanged += DayBox_ValueChanged;
            // 
            // MinBox
            // 
            MinBox.Location = new Point(273, 47);
            MinBox.Margin = new Padding(4, 4, 4, 4);
            MinBox.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            MinBox.Name = "MinBox";
            MinBox.Size = new Size(87, 25);
            MinBox.TabIndex = 5;
            MinBox.ValueChanged += MinBox_ValueChanged;
            // 
            // MonthBox
            // 
            MonthBox.Location = new Point(273, 20);
            MonthBox.Margin = new Padding(4, 4, 4, 4);
            MonthBox.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            MonthBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MonthBox.Name = "MonthBox";
            MonthBox.Size = new Size(87, 25);
            MonthBox.TabIndex = 2;
            MonthBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            MonthBox.ValueChanged += MonthBox_ValueChanged;
            // 
            // HourBox
            // 
            HourBox.Location = new Point(109, 47);
            HourBox.Margin = new Padding(4, 4, 4, 4);
            HourBox.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            HourBox.Name = "HourBox";
            HourBox.Size = new Size(87, 25);
            HourBox.TabIndex = 4;
            HourBox.ValueChanged += HourBox_ValueChanged;
            // 
            // YearBox
            // 
            YearBox.Location = new Point(109, 20);
            YearBox.Margin = new Padding(4, 4, 4, 4);
            YearBox.Maximum = new decimal(new int[] { 2060, 0, 0, 0 });
            YearBox.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(87, 25);
            YearBox.TabIndex = 1;
            YearBox.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            YearBox.ValueChanged += YearBox_ValueChanged;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(52, 50);
            label39.Margin = new Padding(4, 0, 4, 0);
            label39.Name = "label39";
            label39.Size = new Size(39, 15);
            label39.TabIndex = 717;
            label39.Text = "Hour";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(385, 22);
            label36.Margin = new Padding(4, 0, 4, 0);
            label36.Name = "label36";
            label36.Size = new Size(31, 15);
            label36.TabIndex = 714;
            label36.Text = "Day";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(216, 50);
            label38.Margin = new Padding(4, 0, 4, 0);
            label38.Name = "label38";
            label38.Size = new Size(31, 15);
            label38.TabIndex = 718;
            label38.Text = "Min";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(216, 22);
            label35.Margin = new Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new Size(47, 15);
            label35.TabIndex = 712;
            label35.Text = "Month";
            // 
            // InsertWR8Button
            // 
            InsertWR8Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            InsertWR8Button.Location = new Point(164, 596);
            InsertWR8Button.Margin = new Padding(4, 4, 4, 4);
            InsertWR8Button.Name = "InsertWR8Button";
            InsertWR8Button.Size = new Size(151, 26);
            InsertWR8Button.TabIndex = 8;
            InsertWR8Button.Text = "Insert WR7";
            InsertWR8Button.UseVisualStyleBackColor = true;
            InsertWR8Button.Visible = false;
            InsertWR8Button.Click += InsertWR8Button_Click;
            // 
            // ExtractWR8Button
            // 
            ExtractWR8Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExtractWR8Button.Location = new Point(323, 596);
            ExtractWR8Button.Margin = new Padding(4, 4, 4, 4);
            ExtractWR8Button.Name = "ExtractWR8Button";
            ExtractWR8Button.Size = new Size(151, 26);
            ExtractWR8Button.TabIndex = 9;
            ExtractWR8Button.Text = "Extract WR7";
            ExtractWR8Button.UseVisualStyleBackColor = true;
            ExtractWR8Button.Visible = false;
            ExtractWR8Button.Click += ExtractWR8Button_Click;
            // 
            // DeleteWR8Button
            // 
            DeleteWR8Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteWR8Button.Location = new Point(517, 596);
            DeleteWR8Button.Margin = new Padding(4, 4, 4, 4);
            DeleteWR8Button.Name = "DeleteWR8Button";
            DeleteWR8Button.Size = new Size(151, 26);
            DeleteWR8Button.TabIndex = 10;
            DeleteWR8Button.Text = "Delete Slot";
            DeleteWR8Button.UseVisualStyleBackColor = true;
            DeleteWR8Button.Visible = false;
            DeleteWR8Button.Click += DeleteWR8Button_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = SystemColors.ControlLightLight;
            pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox10.BorderStyle = BorderStyle.FixedSingle;
            pictureBox10.Location = new Point(581, 66);
            pictureBox10.Margin = new Padding(4, 4, 4, 4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(90, 64);
            pictureBox10.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox10.TabIndex = 730;
            pictureBox10.TabStop = false;
            pictureBox10.Click += Border_Change;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = SystemColors.ControlLightLight;
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            pictureBox9.Location = new Point(492, 66);
            pictureBox9.Margin = new Padding(4, 4, 4, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(90, 64);
            pictureBox9.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox9.TabIndex = 729;
            pictureBox9.TabStop = false;
            pictureBox9.Click += Border_Change;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = SystemColors.ControlLightLight;
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Location = new Point(403, 66);
            pictureBox8.Margin = new Padding(4, 4, 4, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(90, 64);
            pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox8.TabIndex = 728;
            pictureBox8.TabStop = false;
            pictureBox8.Click += Border_Change;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.ControlLightLight;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Location = new Point(313, 66);
            pictureBox7.Margin = new Padding(4, 4, 4, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(91, 64);
            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.TabIndex = 727;
            pictureBox7.TabStop = false;
            pictureBox7.Click += Border_Change;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ControlLightLight;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(224, 66);
            pictureBox6.Margin = new Padding(4, 4, 4, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(90, 64);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 726;
            pictureBox6.TabStop = false;
            pictureBox6.Click += Border_Change;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ControlLightLight;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(581, 2);
            pictureBox5.Margin = new Padding(4, 4, 4, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(90, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 725;
            pictureBox5.TabStop = false;
            pictureBox5.Click += Border_Change;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ControlLightLight;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(492, 2);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(90, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 724;
            pictureBox4.TabStop = false;
            pictureBox4.Click += Border_Change;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlLightLight;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(403, 2);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 723;
            pictureBox3.TabStop = false;
            pictureBox3.Click += Border_Change;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(313, 2);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 722;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Border_Change;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(224, 2);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 721;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Border_Change;
            // 
            // pictureBox0
            // 
            pictureBox0.BackColor = SystemColors.ControlLightLight;
            pictureBox0.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox0.BorderStyle = BorderStyle.FixedSingle;
            pictureBox0.Location = new Point(224, 129);
            pictureBox0.Margin = new Padding(4, 4, 4, 4);
            pictureBox0.Name = "pictureBox0";
            pictureBox0.Size = new Size(90, 64);
            pictureBox0.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox0.TabIndex = 731;
            pictureBox0.TabStop = false;
            pictureBox0.Visible = false;
            // 
            // WonderRecordLGPE
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 626);
            Controls.Add(pictureBox0);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(SpeciesImageBox);
            Controls.Add(DeleteWR8Button);
            Controls.Add(ExtractWR8Button);
            Controls.Add(InsertWR8Button);
            Controls.Add(groupBox1);
            Controls.Add(TimestampBox);
            Controls.Add(label34);
            Controls.Add(WC8_2_WR8_Button);
            Controls.Add(CardTitleRefinedBox);
            Controls.Add(WRTabs);
            Controls.Add(label3);
            Controls.Add(CardTitleRawBox);
            Controls.Add(label2);
            Controls.Add(WCIDBox);
            Controls.Add(EntryTypeBox);
            Controls.Add(label1);
            Controls.Add(SlotIndex);
            Controls.Add(AreaSlotLabel);
            Controls.Add(LocationLabel);
            Font = new Font("SimHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "WonderRecordLGPE";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wonder Records Tool (LGPE)";
            Load += WonderRecord_Load;
            ((System.ComponentModel.ISupportInitialize)SlotIndex).EndInit();
            ((System.ComponentModel.ISupportInitialize)FormBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpeciesImageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)WCIDBox).EndInit();
            WRTabs.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SecBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DayBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MonthBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)HourBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)YearBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox0).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
