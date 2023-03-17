using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PKHeX;

namespace WC3Tool;

public class ECT_pkedit : Form
{
	private int pk;

	private IContainer components;

	private Label label1;

	private ComboBox item_box;

	private Label label2;

	private Label label3;

	private Label label4;

	private ComboBox move1;

	private ComboBox move2;

	private ComboBox move3;

	private Label label5;

	private NumericUpDown level;

	private NumericUpDown pp1;

	private NumericUpDown pp2;

	private NumericUpDown pp3;

	private Label label6;

	private Label label7;

	private Label label8;

	private NumericUpDown otid;

	private NumericUpDown otsid;

	private NumericUpDown pid;

	private Label label9;

	private NumericUpDown ability;

	private Label label10;

	private Label label11;

	private NumericUpDown friendship;

	private TextBox namebox;

	private Label label12;

	private Label label13;

	private NumericUpDown iv1;

	private NumericUpDown iv2;

	private NumericUpDown iv3;

	private NumericUpDown iv4;

	private NumericUpDown iv5;

	private NumericUpDown iv6;

	private NumericUpDown ev5;

	private NumericUpDown ev4;

	private NumericUpDown ev3;

	private NumericUpDown ev2;

	private NumericUpDown ev1;

	private Label label14;

	private Label label15;

	private Label label16;

	private Label label17;

	private Label label18;

	private Label label19;

	private Label label20;

	private Button save;

	private Button cancel;

	private Label label21;

	private ComboBox move4;

	private NumericUpDown pp4;

	private NumericUpDown ev6;

	private CheckBox jap_check;

	public uint IV32
	{
		get
		{
			return BitConverter.ToUInt32(ECT_editor.ectfile.Data, pk + 24);
		}
		set
		{
			BitConverter.GetBytes(value).CopyTo(ECT_editor.ectfile.Data, 24);
		}
	}

	public int IV_HP
	{
		get
		{
			return (int)(IV32 & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -32) | ((value > 31) ? 31u : ((uint)value)));
		}
	}

	public int IV_ATK
	{
		get
		{
			return (int)((IV32 >> 5) & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -993) | (uint)(((value > 31) ? 31 : value) << 5));
		}
	}

	public int IV_DEF
	{
		get
		{
			return (int)((IV32 >> 10) & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -31745) | (uint)(((value > 31) ? 31 : value) << 10));
		}
	}

	public int IV_SPE
	{
		get
		{
			return (int)((IV32 >> 15) & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -1015809) | (uint)(((value > 31) ? 31 : value) << 15));
		}
	}

	public int IV_SPA
	{
		get
		{
			return (int)((IV32 >> 20) & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -32505857) | (uint)(((value > 31) ? 31 : value) << 20));
		}
	}

	public int IV_SPD
	{
		get
		{
			return (int)((IV32 >> 25) & 0x1F);
		}
		set
		{
			IV32 = (uint)((IV32 & -1040187393) | (uint)(((value > 31) ? 31 : value) << 25));
		}
	}

	public int IV_Ability
	{
		get
		{
			return (int)((IV32 >> 31) & 1);
		}
		set
		{
			IV32 = (IV32 & 0x7FFFFFFFu) | ((value == 1) ? 2147483648u : 0u);
		}
	}

	public byte PPUP
	{
		get
		{
			return ECT_editor.ectfile.Data[pk + 13];
		}
		set
		{
			ECT_editor.ectfile.Data[pk + 13] = value;
		}
	}

	public int PPUP_1
	{
		get
		{
			return PPUP & 3;
		}
		set
		{
			PPUP = (byte)((PPUP & 0xFFFFFFFCu) | (byte)((value > 3) ? 3u : ((uint)value)));
		}
	}

	public int PPUP_2
	{
		get
		{
			return (PPUP >> 2) & 3;
		}
		set
		{
			PPUP = (byte)((PPUP & 0xFFFFFFF3u) | (byte)(((value > 3) ? 3 : value) << 2));
		}
	}

	public int PPUP_3
	{
		get
		{
			return (PPUP >> 4) & 3;
		}
		set
		{
			PPUP = (byte)((PPUP & 0xFFFFFFCFu) | (byte)(((value > 3) ? 3 : value) << 4));
		}
	}

	public int PPUP_4
	{
		get
		{
			return (PPUP >> 6) & 3;
		}
		set
		{
			PPUP = (byte)((PPUP & 0xFFFFFF3Fu) | (byte)(((value > 3) ? 3 : value) << 6));
		}
	}

	public ECT_pkedit(int index)
	{
		InitializeComponent();
		pid.Maximum = -1m;
		pk = 52 + index * 44;
		populate();
	}

	private void populate()
	{
		item_box.SelectedIndex = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 2, 2), 0);
		namebox.Text = PKM.getG3Str(ECT_editor.ectfile.getData(pk + 32, 11), jap_check.Checked);
		move1.SelectedIndex = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 4, 2), 0);
		move2.SelectedIndex = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 6, 2), 0);
		move3.SelectedIndex = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 8, 2), 0);
		move4.SelectedIndex = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 10, 2), 0);
		pp1.Value = PPUP_1;
		pp2.Value = PPUP_2;
		pp3.Value = PPUP_3;
		pp4.Value = PPUP_4;
		level.Value = ECT_editor.ectfile.Data[pk + 12];
		friendship.Value = ECT_editor.ectfile.Data[pk + 43];
		otid.Value = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 20, 2), 0);
		otsid.Value = BitConverter.ToUInt16(ECT_editor.ectfile.getData(pk + 22, 2), 0);
		pid.Value = BitConverter.ToUInt32(ECT_editor.ectfile.getData(pk + 28, 4), 0);
		ev1.Value = ECT_editor.ectfile.Data[pk + 14];
		ev2.Value = ECT_editor.ectfile.Data[pk + 15];
		ev3.Value = ECT_editor.ectfile.Data[pk + 16];
		ev4.Value = ECT_editor.ectfile.Data[pk + 17];
		ev5.Value = ECT_editor.ectfile.Data[pk + 18];
		ev6.Value = ECT_editor.ectfile.Data[pk + 19];
		iv1.Value = IV_HP;
		iv2.Value = IV_ATK;
		iv3.Value = IV_DEF;
		iv4.Value = IV_SPE;
		iv5.Value = IV_SPA;
		iv6.Value = IV_SPD;
		ability.Value = IV_Ability;
	}

	private void save_edits()
	{
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)item_box.SelectedIndex).ToArray(), pk + 2);
		ECT_editor.ectfile.setData(PKM.setG3Str(namebox.Text, jap_check.Checked), pk + 32);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)move1.SelectedIndex).ToArray(), pk + 4);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)move2.SelectedIndex).ToArray(), pk + 6);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)move3.SelectedIndex).ToArray(), pk + 8);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)move4.SelectedIndex).ToArray(), pk + 10);
		PPUP_1 = (int)pp1.Value;
		PPUP_2 = (int)pp1.Value;
		PPUP_3 = (int)pp1.Value;
		PPUP_4 = (int)pp1.Value;
		ECT_editor.ectfile.Data[pk + 12] = (byte)level.Value;
		ECT_editor.ectfile.Data[pk + 43] = (byte)friendship.Value;
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)otid.Value).ToArray(), pk + 20);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((ushort)otsid.Value).ToArray(), pk + 22);
		ECT_editor.ectfile.setData(BitConverter.GetBytes((uint)pid.Value).ToArray(), pk + 28);
		ECT_editor.ectfile.Data[pk + 14] = (byte)ev1.Value;
		ECT_editor.ectfile.Data[pk + 15] = (byte)ev2.Value;
		ECT_editor.ectfile.Data[pk + 16] = (byte)ev3.Value;
		ECT_editor.ectfile.Data[pk + 17] = (byte)ev4.Value;
		ECT_editor.ectfile.Data[pk + 18] = (byte)ev5.Value;
		ECT_editor.ectfile.Data[pk + 19] = (byte)ev6.Value;
		IV_HP = (int)iv1.Value;
		IV_ATK = (int)iv1.Value;
		IV_DEF = (int)iv3.Value;
		IV_SPE = (int)iv4.Value;
		IV_SPA = (int)iv5.Value;
		IV_SPD = (int)iv6.Value;
		IV_Ability = (int)ability.Value;
	}

	private void CancelClick(object sender, EventArgs e)
	{
		Close();
	}

	private void SaveClick(object sender, EventArgs e)
	{
		save_edits();
		Close();
	}

	private void Jap_checkCheckedChanged(object sender, EventArgs e)
	{
		namebox.Text = PKM.getG3Str(ECT_editor.ectfile.getData(pk + 32, 11), jap_check.Checked);
	}

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
		this.label1 = new System.Windows.Forms.Label();
		this.item_box = new System.Windows.Forms.ComboBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.move1 = new System.Windows.Forms.ComboBox();
		this.move2 = new System.Windows.Forms.ComboBox();
		this.move3 = new System.Windows.Forms.ComboBox();
		this.label5 = new System.Windows.Forms.Label();
		this.level = new System.Windows.Forms.NumericUpDown();
		this.pp1 = new System.Windows.Forms.NumericUpDown();
		this.pp2 = new System.Windows.Forms.NumericUpDown();
		this.pp3 = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.otid = new System.Windows.Forms.NumericUpDown();
		this.otsid = new System.Windows.Forms.NumericUpDown();
		this.pid = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.ability = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.friendship = new System.Windows.Forms.NumericUpDown();
		this.namebox = new System.Windows.Forms.TextBox();
		this.label12 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.iv1 = new System.Windows.Forms.NumericUpDown();
		this.iv2 = new System.Windows.Forms.NumericUpDown();
		this.iv3 = new System.Windows.Forms.NumericUpDown();
		this.iv4 = new System.Windows.Forms.NumericUpDown();
		this.iv5 = new System.Windows.Forms.NumericUpDown();
		this.iv6 = new System.Windows.Forms.NumericUpDown();
		this.ev6 = new System.Windows.Forms.NumericUpDown();
		this.ev5 = new System.Windows.Forms.NumericUpDown();
		this.ev4 = new System.Windows.Forms.NumericUpDown();
		this.ev3 = new System.Windows.Forms.NumericUpDown();
		this.ev2 = new System.Windows.Forms.NumericUpDown();
		this.ev1 = new System.Windows.Forms.NumericUpDown();
		this.label14 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.label18 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.label20 = new System.Windows.Forms.Label();
		this.save = new System.Windows.Forms.Button();
		this.cancel = new System.Windows.Forms.Button();
		this.label21 = new System.Windows.Forms.Label();
		this.move4 = new System.Windows.Forms.ComboBox();
		this.pp4 = new System.Windows.Forms.NumericUpDown();
		this.jap_check = new System.Windows.Forms.CheckBox();
		((System.ComponentModel.ISupportInitialize)this.level).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pp1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pp2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pp3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.otid).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.otsid).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pid).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ability).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.friendship).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.iv1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.iv2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.iv3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.iv4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.iv5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.iv6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ev6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ev5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ev4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ev3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ev2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ev1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pp4).BeginInit();
		base.SuspendLayout();
		this.label1.Location = new System.Drawing.Point(29, 65);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(61, 17);
		this.label1.TabIndex = 0;
		this.label1.Text = "Held item:";
		this.item_box.FormattingEnabled = true;
		this.item_box.Items.AddRange(new object[377]
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
			"HM02", "HM03", "HM04", "HM05", "HM06", "HM07", "HM08", "unknown", "unknown", "Oak's Parcel* (Only FRLG)",
			"Poké Flute* (Only FRLG)", "Secret Key* (Only FRLG)", "Bike Voucher* (Only FRLG)", "Gold Teeth* (Only FRLG)", "Old Amber* (Only FRLG)", "Card Key* (Only FRLG)", "Lift Key* (Only FRLG)", "Helix Fossil* (Only FRLG)", "Dome Fossil* (Only FRLG)", "Silph Scope* (Only FRLG)",
			"Bicycle* (Only FRLG)", "Town Map* (Only FRLG)", "Vs. Seeker* (Only FRLG)", "Fame Checker* (Only FRLG)", "TM Case* (Only FRLG)", "Berry Pouch* (Only FRLG)", "Teachy TV* (Only FRLG)", "Tri-Pass* (Only FRLG)", "Rainbow Pass* (Only FRLG)", "Tea* (Only FRLG)",
			"MysticTicket* (Only FRLG)", "AuroraTicket* (Only FRLG)", "Powder Jar* (Only FRLG)", "Ruby* (Only FRLG)", "Sapphire* (Only FRLG)", "Magma Emblem* (Only E)", "Old Sea Map* (Only E)"
		});
		this.item_box.Location = new System.Drawing.Point(96, 62);
		this.item_box.Name = "item_box";
		this.item_box.Size = new System.Drawing.Size(164, 21);
		this.item_box.TabIndex = 1;
		this.label2.Location = new System.Drawing.Point(29, 113);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 23);
		this.label2.TabIndex = 2;
		this.label2.Text = "Move 1:";
		this.label3.Location = new System.Drawing.Point(29, 140);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(100, 23);
		this.label3.TabIndex = 3;
		this.label3.Text = "Move 2:";
		this.label4.Location = new System.Drawing.Point(29, 165);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(100, 23);
		this.label4.TabIndex = 4;
		this.label4.Text = "Move 3:";
		this.move1.FormattingEnabled = true;
		this.move1.Items.AddRange(new object[355]
		{
			"-NONE-", "Pound", "Karate Chop*", "Double Slap", "Comet Punch", "Mega Punch", "Pay Day", "Fire Punch", "Ice Punch", "Thunder Punch",
			"Scratch", "Vice Grip", "Guillotine", "Razor Wind", "Swords Dance", "Cut", "Gust*", "Wing Attack", "Whirlwind", "Fly",
			"Bind", "Slam", "Vine Whip", "Stomp", "Double Kick", "Mega Kick", "Jump Kick", "Rolling Kick", "Sand Attack*", "Headbutt",
			"Horn Attack", "Fury Attack", "Horn Drill", "Tackle", "Body Slam", "Wrap", "Take Down", "Thrash", "Double-Edge", "Tail Whip",
			"Poison Sting", "Twineedle", "Pin Missile", "Leer", "Bite*", "Growl", "Roar", "Sing", "Supersonic", "Sonic Boom",
			"Disable", "Acid", "Ember", "Flamethrower", "Mist", "Water Gun", "Hydro Pump", "Surf", "Ice Beam", "Blizzard",
			"Psybeam", "Bubble Beam", "Aurora Beam", "Hyper Beam", "Peck", "Drill Peck", "Submission", "Low Kick", "Counter", "Seismic Toss",
			"Strength", "Absorb", "Mega Drain", "Leech Seed", "Growth", "Razor Leaf", "Solar Beam", "Poison Powder", "Stun Spore", "Sleep Powder",
			"Petal Dance", "String Shot", "Dragon Rage", "Fire Spin", "Thunder Shock", "Thunderbolt", "Thunder Wave", "Thunder", "Rock Throw", "Earthquake",
			"Fissure", "Dig", "Toxic", "Confusion", "Psychic", "Hypnosis", "Meditate", "Agility", "Quick Attack", "Rage",
			"Teleport", "Night Shade", "Mimic", "Screech", "Double Team", "Recover", "Harden", "Minimize", "Smokescreen", "Confuse Ray",
			"Withdraw", "Defense Curl", "Barrier", "Light Screen", "Haze", "Reflect", "Focus Energy", "Bide", "Metronome", "Mirror Move",
			"Self-Destruct", "Egg Bomb", "Lick", "Smog", "Sludge", "Bone Club", "Fire Blast", "Waterfall", "Clamp", "Swift",
			"Skull Bash", "Spike Cannon", "Constrict", "Amnesia", "Kinesis", "Soft-Boiled", "High Jump Kick", "Glare", "Dream Eater", "Poison Gas",
			"Barrage", "Leech Life", "Lovely Kiss", "Sky Attack", "Transform", "Bubble", "Dizzy Punch", "Spore", "Flash", "Psywave",
			"Splash", "Acid Armor", "Crabhammer", "Explosion", "Fury Swipes", "Bonemerang", "Rest", "Rock Slide", "Hyper Fang", "Sharpen",
			"Conversion", "Tri Attack", "Super Fang", "Slash", "Substitute", "Struggle", "Sketch", "Triple Kick", "Thief", "Spider Web",
			"Mind Reader", "Nightmare", "Flame Wheel", "Snore", "Curse*", "Flail", "Conversion 2", "Aeroblast", "Cotton Spore", "Reversal",
			"Spite", "Powder Snow", "Protect", "Mach Punch", "Scary Face", "Feint Attack", "Sweet Kiss*", "Belly Drum", "Sludge Bomb", "Mud-Slap",
			"Octazooka", "Spikes", "Zap Cannon", "Foresight", "Destiny Bond", "Perish Song", "Icy Wind", "Detect", "Bone Rush", "Lock-On",
			"Outrage", "Sandstorm", "Giga Drain", "Endure", "Charm*", "Rollout", "False Swipe", "Swagger", "Milk Drink", "Spark",
			"Fury Cutter", "Steel Wing", "Mean Look", "Attract", "Sleep Talk", "Heal Bell", "Return", "Present", "Frustration", "Safeguard",
			"Pain Split", "Sacred Fire", "Magnitude", "Dynamic Punch", "Megahorn", "Dragon Breath", "Baton Pass", "Encore", "Pursuit", "Rapid Spin",
			"Sweet Scent", "Iron Tail", "Metal Claw", "Vital Throw", "Morning Sun", "Synthesis", "Moonlight*", "Hidden Power", "Cross Chop", "Twister",
			"Rain Dance", "Sunny Day", "Crunch", "Mirror Coat", "Psych Up", "Extreme Speed", "Ancient Power", "Shadow Ball", "Future Sight", "Rock Smash",
			"Whirlpool", "Beat Up", "Fake Out", "Uproar", "Stockpile", "Spit Up", "Swallow", "Heat Wave", "Hail", "Torment",
			"Flatter", "Will-O-Wisp", "Memento", "Facade", "Focus Punch", "Smelling Salts", "Follow Me", "Nature Power", "Charge", "Taunt",
			"Helping Hand", "Trick", "Role Play", "Wish", "Assist", "Ingrain", "Superpower", "Magic Coat", "Recycle", "Revenge",
			"Brick Break", "Yawn", "Knock Off", "Endeavor", "Eruption", "Skill Swap", "Imprison", "Refresh", "Grudge", "Snatch",
			"Secret Power", "Dive", "Arm Thrust", "Camouflage", "Tail Glow", "Luster Purge", "Mist Ball", "Feather Dance", "Teeter Dance", "Blaze Kick",
			"Mud Sport", "Ice Ball", "Needle Arm", "Slack Off", "Hyper Voice", "Poison Fang", "Crush Claw", "Blast Burn", "Hydro Cannon", "Meteor Mash",
			"Astonish", "Weather Ball", "Aromatherapy", "Fake Tears", "Air Cutter", "Overheat", "Odor Sleuth", "Rock Tomb", "Silver Wind", "Metal Sound",
			"Grass Whistle", "Tickle", "Cosmic Power", "Water Spout", "Signal Beam", "Shadow Punch", "Extrasensory", "Sky Uppercut", "Sand Tomb", "Sheer Cold",
			"Muddy Water", "Bullet Seed", "Aerial Ace", "Icicle Spear", "Iron Defense", "Block", "Howl", "Dragon Claw", "Frenzy Plant", "Bulk Up",
			"Bounce", "Mud Shot", "Poison Tail", "Covet", "Volt Tackle", "Magical Leaf", "Water Sport", "Calm Mind", "Leaf Blade", "Dragon Dance",
			"Rock Blast", "Shock Wave", "Water Pulse", "Doom Desire", "Psycho Boost"
		});
		this.move1.Location = new System.Drawing.Point(96, 110);
		this.move1.Name = "move1";
		this.move1.Size = new System.Drawing.Size(164, 21);
		this.move1.TabIndex = 5;
		this.move2.FormattingEnabled = true;
		this.move2.Items.AddRange(new object[355]
		{
			"-NONE-", "Pound", "Karate Chop*", "Double Slap", "Comet Punch", "Mega Punch", "Pay Day", "Fire Punch", "Ice Punch", "Thunder Punch",
			"Scratch", "Vice Grip", "Guillotine", "Razor Wind", "Swords Dance", "Cut", "Gust*", "Wing Attack", "Whirlwind", "Fly",
			"Bind", "Slam", "Vine Whip", "Stomp", "Double Kick", "Mega Kick", "Jump Kick", "Rolling Kick", "Sand Attack*", "Headbutt",
			"Horn Attack", "Fury Attack", "Horn Drill", "Tackle", "Body Slam", "Wrap", "Take Down", "Thrash", "Double-Edge", "Tail Whip",
			"Poison Sting", "Twineedle", "Pin Missile", "Leer", "Bite*", "Growl", "Roar", "Sing", "Supersonic", "Sonic Boom",
			"Disable", "Acid", "Ember", "Flamethrower", "Mist", "Water Gun", "Hydro Pump", "Surf", "Ice Beam", "Blizzard",
			"Psybeam", "Bubble Beam", "Aurora Beam", "Hyper Beam", "Peck", "Drill Peck", "Submission", "Low Kick", "Counter", "Seismic Toss",
			"Strength", "Absorb", "Mega Drain", "Leech Seed", "Growth", "Razor Leaf", "Solar Beam", "Poison Powder", "Stun Spore", "Sleep Powder",
			"Petal Dance", "String Shot", "Dragon Rage", "Fire Spin", "Thunder Shock", "Thunderbolt", "Thunder Wave", "Thunder", "Rock Throw", "Earthquake",
			"Fissure", "Dig", "Toxic", "Confusion", "Psychic", "Hypnosis", "Meditate", "Agility", "Quick Attack", "Rage",
			"Teleport", "Night Shade", "Mimic", "Screech", "Double Team", "Recover", "Harden", "Minimize", "Smokescreen", "Confuse Ray",
			"Withdraw", "Defense Curl", "Barrier", "Light Screen", "Haze", "Reflect", "Focus Energy", "Bide", "Metronome", "Mirror Move",
			"Self-Destruct", "Egg Bomb", "Lick", "Smog", "Sludge", "Bone Club", "Fire Blast", "Waterfall", "Clamp", "Swift",
			"Skull Bash", "Spike Cannon", "Constrict", "Amnesia", "Kinesis", "Soft-Boiled", "High Jump Kick", "Glare", "Dream Eater", "Poison Gas",
			"Barrage", "Leech Life", "Lovely Kiss", "Sky Attack", "Transform", "Bubble", "Dizzy Punch", "Spore", "Flash", "Psywave",
			"Splash", "Acid Armor", "Crabhammer", "Explosion", "Fury Swipes", "Bonemerang", "Rest", "Rock Slide", "Hyper Fang", "Sharpen",
			"Conversion", "Tri Attack", "Super Fang", "Slash", "Substitute", "Struggle", "Sketch", "Triple Kick", "Thief", "Spider Web",
			"Mind Reader", "Nightmare", "Flame Wheel", "Snore", "Curse*", "Flail", "Conversion 2", "Aeroblast", "Cotton Spore", "Reversal",
			"Spite", "Powder Snow", "Protect", "Mach Punch", "Scary Face", "Feint Attack", "Sweet Kiss*", "Belly Drum", "Sludge Bomb", "Mud-Slap",
			"Octazooka", "Spikes", "Zap Cannon", "Foresight", "Destiny Bond", "Perish Song", "Icy Wind", "Detect", "Bone Rush", "Lock-On",
			"Outrage", "Sandstorm", "Giga Drain", "Endure", "Charm*", "Rollout", "False Swipe", "Swagger", "Milk Drink", "Spark",
			"Fury Cutter", "Steel Wing", "Mean Look", "Attract", "Sleep Talk", "Heal Bell", "Return", "Present", "Frustration", "Safeguard",
			"Pain Split", "Sacred Fire", "Magnitude", "Dynamic Punch", "Megahorn", "Dragon Breath", "Baton Pass", "Encore", "Pursuit", "Rapid Spin",
			"Sweet Scent", "Iron Tail", "Metal Claw", "Vital Throw", "Morning Sun", "Synthesis", "Moonlight*", "Hidden Power", "Cross Chop", "Twister",
			"Rain Dance", "Sunny Day", "Crunch", "Mirror Coat", "Psych Up", "Extreme Speed", "Ancient Power", "Shadow Ball", "Future Sight", "Rock Smash",
			"Whirlpool", "Beat Up", "Fake Out", "Uproar", "Stockpile", "Spit Up", "Swallow", "Heat Wave", "Hail", "Torment",
			"Flatter", "Will-O-Wisp", "Memento", "Facade", "Focus Punch", "Smelling Salts", "Follow Me", "Nature Power", "Charge", "Taunt",
			"Helping Hand", "Trick", "Role Play", "Wish", "Assist", "Ingrain", "Superpower", "Magic Coat", "Recycle", "Revenge",
			"Brick Break", "Yawn", "Knock Off", "Endeavor", "Eruption", "Skill Swap", "Imprison", "Refresh", "Grudge", "Snatch",
			"Secret Power", "Dive", "Arm Thrust", "Camouflage", "Tail Glow", "Luster Purge", "Mist Ball", "Feather Dance", "Teeter Dance", "Blaze Kick",
			"Mud Sport", "Ice Ball", "Needle Arm", "Slack Off", "Hyper Voice", "Poison Fang", "Crush Claw", "Blast Burn", "Hydro Cannon", "Meteor Mash",
			"Astonish", "Weather Ball", "Aromatherapy", "Fake Tears", "Air Cutter", "Overheat", "Odor Sleuth", "Rock Tomb", "Silver Wind", "Metal Sound",
			"Grass Whistle", "Tickle", "Cosmic Power", "Water Spout", "Signal Beam", "Shadow Punch", "Extrasensory", "Sky Uppercut", "Sand Tomb", "Sheer Cold",
			"Muddy Water", "Bullet Seed", "Aerial Ace", "Icicle Spear", "Iron Defense", "Block", "Howl", "Dragon Claw", "Frenzy Plant", "Bulk Up",
			"Bounce", "Mud Shot", "Poison Tail", "Covet", "Volt Tackle", "Magical Leaf", "Water Sport", "Calm Mind", "Leaf Blade", "Dragon Dance",
			"Rock Blast", "Shock Wave", "Water Pulse", "Doom Desire", "Psycho Boost"
		});
		this.move2.Location = new System.Drawing.Point(96, 137);
		this.move2.Name = "move2";
		this.move2.Size = new System.Drawing.Size(164, 21);
		this.move2.TabIndex = 6;
		this.move3.FormattingEnabled = true;
		this.move3.Items.AddRange(new object[355]
		{
			"-NONE-", "Pound", "Karate Chop*", "Double Slap", "Comet Punch", "Mega Punch", "Pay Day", "Fire Punch", "Ice Punch", "Thunder Punch",
			"Scratch", "Vice Grip", "Guillotine", "Razor Wind", "Swords Dance", "Cut", "Gust*", "Wing Attack", "Whirlwind", "Fly",
			"Bind", "Slam", "Vine Whip", "Stomp", "Double Kick", "Mega Kick", "Jump Kick", "Rolling Kick", "Sand Attack*", "Headbutt",
			"Horn Attack", "Fury Attack", "Horn Drill", "Tackle", "Body Slam", "Wrap", "Take Down", "Thrash", "Double-Edge", "Tail Whip",
			"Poison Sting", "Twineedle", "Pin Missile", "Leer", "Bite*", "Growl", "Roar", "Sing", "Supersonic", "Sonic Boom",
			"Disable", "Acid", "Ember", "Flamethrower", "Mist", "Water Gun", "Hydro Pump", "Surf", "Ice Beam", "Blizzard",
			"Psybeam", "Bubble Beam", "Aurora Beam", "Hyper Beam", "Peck", "Drill Peck", "Submission", "Low Kick", "Counter", "Seismic Toss",
			"Strength", "Absorb", "Mega Drain", "Leech Seed", "Growth", "Razor Leaf", "Solar Beam", "Poison Powder", "Stun Spore", "Sleep Powder",
			"Petal Dance", "String Shot", "Dragon Rage", "Fire Spin", "Thunder Shock", "Thunderbolt", "Thunder Wave", "Thunder", "Rock Throw", "Earthquake",
			"Fissure", "Dig", "Toxic", "Confusion", "Psychic", "Hypnosis", "Meditate", "Agility", "Quick Attack", "Rage",
			"Teleport", "Night Shade", "Mimic", "Screech", "Double Team", "Recover", "Harden", "Minimize", "Smokescreen", "Confuse Ray",
			"Withdraw", "Defense Curl", "Barrier", "Light Screen", "Haze", "Reflect", "Focus Energy", "Bide", "Metronome", "Mirror Move",
			"Self-Destruct", "Egg Bomb", "Lick", "Smog", "Sludge", "Bone Club", "Fire Blast", "Waterfall", "Clamp", "Swift",
			"Skull Bash", "Spike Cannon", "Constrict", "Amnesia", "Kinesis", "Soft-Boiled", "High Jump Kick", "Glare", "Dream Eater", "Poison Gas",
			"Barrage", "Leech Life", "Lovely Kiss", "Sky Attack", "Transform", "Bubble", "Dizzy Punch", "Spore", "Flash", "Psywave",
			"Splash", "Acid Armor", "Crabhammer", "Explosion", "Fury Swipes", "Bonemerang", "Rest", "Rock Slide", "Hyper Fang", "Sharpen",
			"Conversion", "Tri Attack", "Super Fang", "Slash", "Substitute", "Struggle", "Sketch", "Triple Kick", "Thief", "Spider Web",
			"Mind Reader", "Nightmare", "Flame Wheel", "Snore", "Curse*", "Flail", "Conversion 2", "Aeroblast", "Cotton Spore", "Reversal",
			"Spite", "Powder Snow", "Protect", "Mach Punch", "Scary Face", "Feint Attack", "Sweet Kiss*", "Belly Drum", "Sludge Bomb", "Mud-Slap",
			"Octazooka", "Spikes", "Zap Cannon", "Foresight", "Destiny Bond", "Perish Song", "Icy Wind", "Detect", "Bone Rush", "Lock-On",
			"Outrage", "Sandstorm", "Giga Drain", "Endure", "Charm*", "Rollout", "False Swipe", "Swagger", "Milk Drink", "Spark",
			"Fury Cutter", "Steel Wing", "Mean Look", "Attract", "Sleep Talk", "Heal Bell", "Return", "Present", "Frustration", "Safeguard",
			"Pain Split", "Sacred Fire", "Magnitude", "Dynamic Punch", "Megahorn", "Dragon Breath", "Baton Pass", "Encore", "Pursuit", "Rapid Spin",
			"Sweet Scent", "Iron Tail", "Metal Claw", "Vital Throw", "Morning Sun", "Synthesis", "Moonlight*", "Hidden Power", "Cross Chop", "Twister",
			"Rain Dance", "Sunny Day", "Crunch", "Mirror Coat", "Psych Up", "Extreme Speed", "Ancient Power", "Shadow Ball", "Future Sight", "Rock Smash",
			"Whirlpool", "Beat Up", "Fake Out", "Uproar", "Stockpile", "Spit Up", "Swallow", "Heat Wave", "Hail", "Torment",
			"Flatter", "Will-O-Wisp", "Memento", "Facade", "Focus Punch", "Smelling Salts", "Follow Me", "Nature Power", "Charge", "Taunt",
			"Helping Hand", "Trick", "Role Play", "Wish", "Assist", "Ingrain", "Superpower", "Magic Coat", "Recycle", "Revenge",
			"Brick Break", "Yawn", "Knock Off", "Endeavor", "Eruption", "Skill Swap", "Imprison", "Refresh", "Grudge", "Snatch",
			"Secret Power", "Dive", "Arm Thrust", "Camouflage", "Tail Glow", "Luster Purge", "Mist Ball", "Feather Dance", "Teeter Dance", "Blaze Kick",
			"Mud Sport", "Ice Ball", "Needle Arm", "Slack Off", "Hyper Voice", "Poison Fang", "Crush Claw", "Blast Burn", "Hydro Cannon", "Meteor Mash",
			"Astonish", "Weather Ball", "Aromatherapy", "Fake Tears", "Air Cutter", "Overheat", "Odor Sleuth", "Rock Tomb", "Silver Wind", "Metal Sound",
			"Grass Whistle", "Tickle", "Cosmic Power", "Water Spout", "Signal Beam", "Shadow Punch", "Extrasensory", "Sky Uppercut", "Sand Tomb", "Sheer Cold",
			"Muddy Water", "Bullet Seed", "Aerial Ace", "Icicle Spear", "Iron Defense", "Block", "Howl", "Dragon Claw", "Frenzy Plant", "Bulk Up",
			"Bounce", "Mud Shot", "Poison Tail", "Covet", "Volt Tackle", "Magical Leaf", "Water Sport", "Calm Mind", "Leaf Blade", "Dragon Dance",
			"Rock Blast", "Shock Wave", "Water Pulse", "Doom Desire", "Psycho Boost"
		});
		this.move3.Location = new System.Drawing.Point(96, 162);
		this.move3.Name = "move3";
		this.move3.Size = new System.Drawing.Size(164, 21);
		this.move3.TabIndex = 7;
		this.label5.Location = new System.Drawing.Point(541, 25);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(100, 23);
		this.label5.TabIndex = 8;
		this.label5.Text = "Level:";
		this.level.Location = new System.Drawing.Point(583, 23);
		this.level.Name = "level";
		this.level.Size = new System.Drawing.Size(120, 20);
		this.level.TabIndex = 9;
		this.pp1.Location = new System.Drawing.Point(266, 111);
		this.pp1.Maximum = new decimal(new int[4] { 3, 0, 0, 0 });
		this.pp1.Name = "pp1";
		this.pp1.Size = new System.Drawing.Size(37, 20);
		this.pp1.TabIndex = 10;
		this.pp2.Location = new System.Drawing.Point(266, 138);
		this.pp2.Maximum = new decimal(new int[4] { 3, 0, 0, 0 });
		this.pp2.Name = "pp2";
		this.pp2.Size = new System.Drawing.Size(37, 20);
		this.pp2.TabIndex = 11;
		this.pp3.Location = new System.Drawing.Point(266, 163);
		this.pp3.Maximum = new decimal(new int[4] { 3, 0, 0, 0 });
		this.pp3.Name = "pp3";
		this.pp3.Size = new System.Drawing.Size(37, 20);
		this.pp3.TabIndex = 12;
		this.label6.Location = new System.Drawing.Point(266, 95);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(37, 13);
		this.label6.TabIndex = 13;
		this.label6.Text = "PPup";
		this.label7.Location = new System.Drawing.Point(524, 112);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(40, 13);
		this.label7.TabIndex = 14;
		this.label7.Text = "OT ID:";
		this.label8.Location = new System.Drawing.Point(524, 139);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(53, 13);
		this.label8.TabIndex = 15;
		this.label8.Text = "OT SID:";
		this.otid.Location = new System.Drawing.Point(583, 110);
		this.otid.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
		this.otid.Name = "otid";
		this.otid.Size = new System.Drawing.Size(120, 20);
		this.otid.TabIndex = 16;
		this.otsid.Location = new System.Drawing.Point(583, 137);
		this.otsid.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
		this.otsid.Name = "otsid";
		this.otsid.Size = new System.Drawing.Size(120, 20);
		this.otsid.TabIndex = 17;
		this.pid.Location = new System.Drawing.Point(583, 162);
		this.pid.Maximum = new decimal(new int[4]);
		this.pid.Name = "pid";
		this.pid.Size = new System.Drawing.Size(120, 20);
		this.pid.TabIndex = 18;
		this.label9.Location = new System.Drawing.Point(524, 164);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(53, 23);
		this.label9.TabIndex = 19;
		this.label9.Text = "PID:";
		this.ability.Location = new System.Drawing.Point(583, 75);
		this.ability.Maximum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.ability.Name = "ability";
		this.ability.Size = new System.Drawing.Size(120, 20);
		this.ability.TabIndex = 20;
		this.label10.Location = new System.Drawing.Point(524, 77);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(53, 23);
		this.label10.TabIndex = 21;
		this.label10.Text = "Ability:";
		this.label11.Location = new System.Drawing.Point(524, 51);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(61, 23);
		this.label11.TabIndex = 22;
		this.label11.Text = "Friendship:";
		this.friendship.Location = new System.Drawing.Point(583, 49);
		this.friendship.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.friendship.Name = "friendship";
		this.friendship.Size = new System.Drawing.Size(120, 20);
		this.friendship.TabIndex = 23;
		this.namebox.Location = new System.Drawing.Point(96, 36);
		this.namebox.MaxLength = 10;
		this.namebox.Name = "namebox";
		this.namebox.Size = new System.Drawing.Size(216, 20);
		this.namebox.TabIndex = 24;
		this.label12.Location = new System.Drawing.Point(29, 39);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(43, 14);
		this.label12.TabIndex = 25;
		this.label12.Text = "Name:";
		this.label13.Location = new System.Drawing.Point(356, 33);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(28, 23);
		this.label13.TabIndex = 26;
		this.label13.Text = "HP";
		this.iv1.Location = new System.Drawing.Point(390, 33);
		this.iv1.Maximum = new decimal(new int[4] { 31, 0, 0, 0 });
		this.iv1.Name = "iv1";
		this.iv1.Size = new System.Drawing.Size(51, 20);
		this.iv1.TabIndex = 28;
		this.iv2.Location = new System.Drawing.Point(390, 59);
		this.iv2.Maximum = new decimal(new int[4] { 31, 0, 0, 0 });
		this.iv2.Name = "iv2";
		this.iv2.Size = new System.Drawing.Size(51, 20);
		this.iv2.TabIndex = 29;
		this.iv3.Location = new System.Drawing.Point(390, 85);
		this.iv3.Maximum = new decimal(new int[4] { 31, 0, 0, 0 });
		this.iv3.Name = "iv3";
		this.iv3.Size = new System.Drawing.Size(51, 20);
		this.iv3.TabIndex = 30;
		this.iv4.Location = new System.Drawing.Point(390, 111);
		this.iv4.Maximum = new decimal(new int[4] { 31, 0, 0, 0 });
		this.iv4.Name = "iv4";
		this.iv4.Size = new System.Drawing.Size(51, 20);
		this.iv4.TabIndex = 31;
		this.iv5.Location = new System.Drawing.Point(390, 137);
		this.iv5.Maximum = new decimal(new int[4] { 31, 0, 0, 0 });
		this.iv5.Name = "iv5";
		this.iv5.Size = new System.Drawing.Size(51, 20);
		this.iv5.TabIndex = 32;
		this.iv6.Location = new System.Drawing.Point(390, 163);
		this.iv6.Maximum = new decimal(new int[4] { 31, 0, 0, 0 });
		this.iv6.Name = "iv6";
		this.iv6.Size = new System.Drawing.Size(51, 20);
		this.iv6.TabIndex = 33;
		this.ev6.Location = new System.Drawing.Point(447, 163);
		this.ev6.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev6.Name = "ev6";
		this.ev6.Size = new System.Drawing.Size(51, 20);
		this.ev6.TabIndex = 40;
		this.ev5.Location = new System.Drawing.Point(447, 137);
		this.ev5.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev5.Name = "ev5";
		this.ev5.Size = new System.Drawing.Size(51, 20);
		this.ev5.TabIndex = 39;
		this.ev4.Location = new System.Drawing.Point(447, 111);
		this.ev4.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev4.Name = "ev4";
		this.ev4.Size = new System.Drawing.Size(51, 20);
		this.ev4.TabIndex = 38;
		this.ev3.Location = new System.Drawing.Point(447, 85);
		this.ev3.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev3.Name = "ev3";
		this.ev3.Size = new System.Drawing.Size(51, 20);
		this.ev3.TabIndex = 37;
		this.ev2.Location = new System.Drawing.Point(447, 59);
		this.ev2.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev2.Name = "ev2";
		this.ev2.Size = new System.Drawing.Size(51, 20);
		this.ev2.TabIndex = 36;
		this.ev1.Location = new System.Drawing.Point(447, 33);
		this.ev1.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.ev1.Name = "ev1";
		this.ev1.Size = new System.Drawing.Size(51, 20);
		this.ev1.TabIndex = 35;
		this.label14.Location = new System.Drawing.Point(356, 60);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(28, 23);
		this.label14.TabIndex = 41;
		this.label14.Text = "Atk";
		this.label15.Location = new System.Drawing.Point(356, 87);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(28, 23);
		this.label15.TabIndex = 42;
		this.label15.Text = "Def";
		this.label16.Location = new System.Drawing.Point(356, 113);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(28, 23);
		this.label16.TabIndex = 43;
		this.label16.Text = "Sp";
		this.label17.Location = new System.Drawing.Point(356, 139);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(28, 23);
		this.label17.TabIndex = 44;
		this.label17.Text = "SPA";
		this.label18.Location = new System.Drawing.Point(356, 165);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(32, 23);
		this.label18.TabIndex = 45;
		this.label18.Text = "SPD";
		this.label19.Location = new System.Drawing.Point(399, 18);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(28, 13);
		this.label19.TabIndex = 46;
		this.label19.Text = "IV";
		this.label20.Location = new System.Drawing.Point(456, 18);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(28, 13);
		this.label20.TabIndex = 47;
		this.label20.Text = "EV";
		this.save.Location = new System.Drawing.Point(15, 225);
		this.save.Name = "save";
		this.save.Size = new System.Drawing.Size(75, 23);
		this.save.TabIndex = 48;
		this.save.Text = "Save";
		this.save.UseVisualStyleBackColor = true;
		this.save.Click += new System.EventHandler(SaveClick);
		this.cancel.Location = new System.Drawing.Point(96, 225);
		this.cancel.Name = "cancel";
		this.cancel.Size = new System.Drawing.Size(75, 23);
		this.cancel.TabIndex = 49;
		this.cancel.Text = "Cancel";
		this.cancel.UseVisualStyleBackColor = true;
		this.cancel.Click += new System.EventHandler(CancelClick);
		this.label21.Location = new System.Drawing.Point(29, 194);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(100, 23);
		this.label21.TabIndex = 50;
		this.label21.Text = "Move 4:";
		this.move4.FormattingEnabled = true;
		this.move4.Items.AddRange(new object[355]
		{
			"-NONE-", "Pound", "Karate Chop*", "Double Slap", "Comet Punch", "Mega Punch", "Pay Day", "Fire Punch", "Ice Punch", "Thunder Punch",
			"Scratch", "Vice Grip", "Guillotine", "Razor Wind", "Swords Dance", "Cut", "Gust*", "Wing Attack", "Whirlwind", "Fly",
			"Bind", "Slam", "Vine Whip", "Stomp", "Double Kick", "Mega Kick", "Jump Kick", "Rolling Kick", "Sand Attack*", "Headbutt",
			"Horn Attack", "Fury Attack", "Horn Drill", "Tackle", "Body Slam", "Wrap", "Take Down", "Thrash", "Double-Edge", "Tail Whip",
			"Poison Sting", "Twineedle", "Pin Missile", "Leer", "Bite*", "Growl", "Roar", "Sing", "Supersonic", "Sonic Boom",
			"Disable", "Acid", "Ember", "Flamethrower", "Mist", "Water Gun", "Hydro Pump", "Surf", "Ice Beam", "Blizzard",
			"Psybeam", "Bubble Beam", "Aurora Beam", "Hyper Beam", "Peck", "Drill Peck", "Submission", "Low Kick", "Counter", "Seismic Toss",
			"Strength", "Absorb", "Mega Drain", "Leech Seed", "Growth", "Razor Leaf", "Solar Beam", "Poison Powder", "Stun Spore", "Sleep Powder",
			"Petal Dance", "String Shot", "Dragon Rage", "Fire Spin", "Thunder Shock", "Thunderbolt", "Thunder Wave", "Thunder", "Rock Throw", "Earthquake",
			"Fissure", "Dig", "Toxic", "Confusion", "Psychic", "Hypnosis", "Meditate", "Agility", "Quick Attack", "Rage",
			"Teleport", "Night Shade", "Mimic", "Screech", "Double Team", "Recover", "Harden", "Minimize", "Smokescreen", "Confuse Ray",
			"Withdraw", "Defense Curl", "Barrier", "Light Screen", "Haze", "Reflect", "Focus Energy", "Bide", "Metronome", "Mirror Move",
			"Self-Destruct", "Egg Bomb", "Lick", "Smog", "Sludge", "Bone Club", "Fire Blast", "Waterfall", "Clamp", "Swift",
			"Skull Bash", "Spike Cannon", "Constrict", "Amnesia", "Kinesis", "Soft-Boiled", "High Jump Kick", "Glare", "Dream Eater", "Poison Gas",
			"Barrage", "Leech Life", "Lovely Kiss", "Sky Attack", "Transform", "Bubble", "Dizzy Punch", "Spore", "Flash", "Psywave",
			"Splash", "Acid Armor", "Crabhammer", "Explosion", "Fury Swipes", "Bonemerang", "Rest", "Rock Slide", "Hyper Fang", "Sharpen",
			"Conversion", "Tri Attack", "Super Fang", "Slash", "Substitute", "Struggle", "Sketch", "Triple Kick", "Thief", "Spider Web",
			"Mind Reader", "Nightmare", "Flame Wheel", "Snore", "Curse*", "Flail", "Conversion 2", "Aeroblast", "Cotton Spore", "Reversal",
			"Spite", "Powder Snow", "Protect", "Mach Punch", "Scary Face", "Feint Attack", "Sweet Kiss*", "Belly Drum", "Sludge Bomb", "Mud-Slap",
			"Octazooka", "Spikes", "Zap Cannon", "Foresight", "Destiny Bond", "Perish Song", "Icy Wind", "Detect", "Bone Rush", "Lock-On",
			"Outrage", "Sandstorm", "Giga Drain", "Endure", "Charm*", "Rollout", "False Swipe", "Swagger", "Milk Drink", "Spark",
			"Fury Cutter", "Steel Wing", "Mean Look", "Attract", "Sleep Talk", "Heal Bell", "Return", "Present", "Frustration", "Safeguard",
			"Pain Split", "Sacred Fire", "Magnitude", "Dynamic Punch", "Megahorn", "Dragon Breath", "Baton Pass", "Encore", "Pursuit", "Rapid Spin",
			"Sweet Scent", "Iron Tail", "Metal Claw", "Vital Throw", "Morning Sun", "Synthesis", "Moonlight*", "Hidden Power", "Cross Chop", "Twister",
			"Rain Dance", "Sunny Day", "Crunch", "Mirror Coat", "Psych Up", "Extreme Speed", "Ancient Power", "Shadow Ball", "Future Sight", "Rock Smash",
			"Whirlpool", "Beat Up", "Fake Out", "Uproar", "Stockpile", "Spit Up", "Swallow", "Heat Wave", "Hail", "Torment",
			"Flatter", "Will-O-Wisp", "Memento", "Facade", "Focus Punch", "Smelling Salts", "Follow Me", "Nature Power", "Charge", "Taunt",
			"Helping Hand", "Trick", "Role Play", "Wish", "Assist", "Ingrain", "Superpower", "Magic Coat", "Recycle", "Revenge",
			"Brick Break", "Yawn", "Knock Off", "Endeavor", "Eruption", "Skill Swap", "Imprison", "Refresh", "Grudge", "Snatch",
			"Secret Power", "Dive", "Arm Thrust", "Camouflage", "Tail Glow", "Luster Purge", "Mist Ball", "Feather Dance", "Teeter Dance", "Blaze Kick",
			"Mud Sport", "Ice Ball", "Needle Arm", "Slack Off", "Hyper Voice", "Poison Fang", "Crush Claw", "Blast Burn", "Hydro Cannon", "Meteor Mash",
			"Astonish", "Weather Ball", "Aromatherapy", "Fake Tears", "Air Cutter", "Overheat", "Odor Sleuth", "Rock Tomb", "Silver Wind", "Metal Sound",
			"Grass Whistle", "Tickle", "Cosmic Power", "Water Spout", "Signal Beam", "Shadow Punch", "Extrasensory", "Sky Uppercut", "Sand Tomb", "Sheer Cold",
			"Muddy Water", "Bullet Seed", "Aerial Ace", "Icicle Spear", "Iron Defense", "Block", "Howl", "Dragon Claw", "Frenzy Plant", "Bulk Up",
			"Bounce", "Mud Shot", "Poison Tail", "Covet", "Volt Tackle", "Magical Leaf", "Water Sport", "Calm Mind", "Leaf Blade", "Dragon Dance",
			"Rock Blast", "Shock Wave", "Water Pulse", "Doom Desire", "Psycho Boost"
		});
		this.move4.Location = new System.Drawing.Point(96, 191);
		this.move4.Name = "move4";
		this.move4.Size = new System.Drawing.Size(164, 21);
		this.move4.TabIndex = 51;
		this.pp4.Location = new System.Drawing.Point(266, 192);
		this.pp4.Name = "pp4";
		this.pp4.Size = new System.Drawing.Size(37, 20);
		this.pp4.TabIndex = 52;
		this.jap_check.Location = new System.Drawing.Point(96, 6);
		this.jap_check.Name = "jap_check";
		this.jap_check.Size = new System.Drawing.Size(128, 24);
		this.jap_check.TabIndex = 53;
		this.jap_check.Text = "Japanese encoding";
		this.jap_check.UseVisualStyleBackColor = true;
		this.jap_check.CheckedChanged += new System.EventHandler(Jap_checkCheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(728, 260);
		base.Controls.Add(this.jap_check);
		base.Controls.Add(this.pp4);
		base.Controls.Add(this.move4);
		base.Controls.Add(this.label21);
		base.Controls.Add(this.cancel);
		base.Controls.Add(this.save);
		base.Controls.Add(this.label20);
		base.Controls.Add(this.label19);
		base.Controls.Add(this.label18);
		base.Controls.Add(this.label17);
		base.Controls.Add(this.label16);
		base.Controls.Add(this.label15);
		base.Controls.Add(this.label14);
		base.Controls.Add(this.ev6);
		base.Controls.Add(this.ev5);
		base.Controls.Add(this.ev4);
		base.Controls.Add(this.ev3);
		base.Controls.Add(this.ev2);
		base.Controls.Add(this.ev1);
		base.Controls.Add(this.iv6);
		base.Controls.Add(this.iv5);
		base.Controls.Add(this.iv4);
		base.Controls.Add(this.iv3);
		base.Controls.Add(this.iv2);
		base.Controls.Add(this.iv1);
		base.Controls.Add(this.label13);
		base.Controls.Add(this.label12);
		base.Controls.Add(this.namebox);
		base.Controls.Add(this.friendship);
		base.Controls.Add(this.label11);
		base.Controls.Add(this.label10);
		base.Controls.Add(this.ability);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.pid);
		base.Controls.Add(this.otsid);
		base.Controls.Add(this.otid);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.pp3);
		base.Controls.Add(this.pp2);
		base.Controls.Add(this.pp1);
		base.Controls.Add(this.level);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.move3);
		base.Controls.Add(this.move2);
		base.Controls.Add(this.move1);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.item_box);
		base.Controls.Add(this.label1);
		base.Name = "ECT_pkedit";
		this.Text = "Trainer Pokemon Editor";
		((System.ComponentModel.ISupportInitialize)this.level).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pp1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pp2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pp3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.otid).EndInit();
		((System.ComponentModel.ISupportInitialize)this.otsid).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pid).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ability).EndInit();
		((System.ComponentModel.ISupportInitialize)this.friendship).EndInit();
		((System.ComponentModel.ISupportInitialize)this.iv1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.iv2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.iv3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.iv4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.iv5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.iv6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ev6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ev5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ev4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ev3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ev2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ev1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pp4).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
