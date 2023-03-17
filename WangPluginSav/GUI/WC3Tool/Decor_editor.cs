using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WC3Tool;

public class Decor_editor : Form
{
	private byte[] decorbuff;

	private SAV3 sav3file;

	public string savfilter = MainScreen.savfilter;

	private int[] desk_ref = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

	private int[] chair_ref = new int[9] { 10, 11, 12, 13, 14, 15, 16, 17, 18 };

	private int[] plant_ref = new int[6] { 19, 20, 21, 22, 23, 24 };

	private int[] ornament_ref = new int[23]
	{
		25, 26, 27, 28, 29, 30, 31, 32, 33, 34,
		35, 36, 37, 38, 39, 40, 41, 42, 43, 44,
		45, 46, 47
	};

	private int[] mat_ref = new int[18]
	{
		48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
		58, 59, 60, 61, 62, 63, 64, 65
	};

	private int[] poster_ref = new int[10] { 66, 67, 68, 69, 70, 71, 72, 73, 74, 75 };

	private int[] doll_ref = new int[35]
	{
		76, 77, 78, 79, 80, 81, 82, 83, 84, 85,
		86, 87, 88, 89, 90, 91, 92, 93, 94, 95,
		96, 97, 98, 99, 100, 111, 112, 113, 114, 115,
		116, 117, 118, 119, 120
	};

	private int[] cushion_ref = new int[10] { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110 };

	private int[] slots_max = new int[8] { 10, 10, 10, 30, 30, 10, 40, 10 };

	private object[] Desks = new object[10] { "Empty", "Small Desk", "Pokémon Desk", "Heavy Desk", "Ragged Desk", "Comfort Desk", "Pretty Desk", "Brick Desk", "Camp Desk", "Hard Desk" };

	private object[] Chairs = new object[10] { "Empty", "Small Chair", "Pokémon Chair", "Heavy Chair", "Pretty Chair", "Comfort Chair", "Ragged Chair", "Brick Chair", "Camp Chair", "Hard Chair" };

	private object[] Plants = new object[7] { "Empty", "Red Plant", "Tropical Plant", "Pretty Flowers", "Colorful Plant", "Big Plant", "Gorgeous Plant" };

	private object[] Ornament = new object[24]
	{
		"Empty", "Red Brick", "Yellow Brick", "Blue Brick", "Red Balloon", "Blue Balloon", "Yellow Balloon", "Red Tent", "Blue Tent", "Solid Board",
		"Slide", "Fence Length", "Fence Width", "Tire", "Stand", "Mud Ball", "Breakable Door", "Sand Ornament", "Silver Shield", "Gold Shield",
		"Glass Ornament", "TV", "Round TV", "Cute TV"
	};

	private object[] Mats = new object[19]
	{
		"Empty", "Glitter Mat", "Jump Mat", "Spin Mat", "C Low Note Mat", "D Note Mat", "E Note Mat", "F Note Mat", "G Note Mat", "A Note Mat",
		"B Note Mat", "C High Note Mat", "Surf Mat", "Thunder Mat", "Fire Blast Mat", "Powder Snow Mat", "Attract Mat", "Fissure Mat", "Spikes Mat"
	};

	private object[] Posters = new object[11]
	{
		"Empty", "Ball Poster", "Green Poster", "Red Poster", "Blue Poster", "Cute Poster", "Pika Poster", "Long Poster", "Sea Poster", "Sky Poster",
		"Kiss Poster"
	};

	private object[] Dolls = new object[36]
	{
		"Empty", "Pichu Doll", "Pikachu Doll", "Marill Doll", "Togepi Doll", "Cyndaquil Doll", "Chikorita Doll", "Totodile Doll", "Jigglypuff Doll", "Meowth Doll",
		"Clefairy Doll", "Ditto Doll", "Smoochum Doll", "Treecko Doll", "Torchic Doll", "Mudkip Doll", "Duskull Doll", "Wynaut Doll", "Baltoy Doll", "Kecleon Doll",
		"Azurill Doll", "Skitty Doll", "Swablu Doll", "Gulpin Doll", "Lotad Doll", "Seedot Doll", "Snorlax Doll", "Rhydon Doll", "Lapras Doll", "Venusaur Doll",
		"Charizard Doll", "Blastoise Doll", "Wailmer Doll", "Regirock Doll", "Regice Doll", "Registeel Doll"
	};

	private object[] Cushions = new object[11]
	{
		"Empty", "Pika Cushion", "Round Cushion", "Kiss Cushion", "Zigzag Cushion", "Spin Cushion", "Diamond Cushion", "Ball Cushion", "Grass Cushion", "Fire Cushion",
		"Water Cushion"
	};

	private IContainer components;

	private ComboBox decortypebox;

	private Label label1;

	private NumericUpDown numericUpDown1;

	private Label label2;

	private ComboBox decorationbox;

	private Label Decoration;

	private Button save_but;

	private Button add_but;

	private Button del_but;

	public Decor_editor(SAV3 save)
	{
		InitializeComponent();
		sav3file = save;
		decorbuff = sav3file.get_decorations();
		decortypebox.SelectedIndex = 0;
		numericUpDown1.Maximum = slots_max[decortypebox.SelectedIndex];
		decorationbox.SelectedIndex = 0;
		load_decor();
	}

	private void del_item()
	{
		int num = 0;
		for (int i = 0; i < decortypebox.SelectedIndex; i++)
		{
			num += slots_max[i];
		}
		decorbuff[num + (int)numericUpDown1.Value - 1] = 0;
	}

	private void set_item(int newitem)
	{
		int num = 0;
		for (int i = 0; i < decortypebox.SelectedIndex; i++)
		{
			num += slots_max[i];
		}
		int[] array = desk_ref;
		switch (decortypebox.SelectedIndex)
		{
		case 0:
			array = desk_ref;
			break;
		case 1:
			array = chair_ref;
			break;
		case 2:
			array = plant_ref;
			break;
		case 3:
			array = ornament_ref;
			break;
		case 4:
			array = mat_ref;
			break;
		case 5:
			array = poster_ref;
			break;
		case 6:
			array = doll_ref;
			break;
		case 7:
			array = cushion_ref;
			break;
		}
		decorbuff[num + (int)numericUpDown1.Value - 1] = (byte)array[newitem];
	}

	private byte get_item(int modifier)
	{
		int num = (int)numericUpDown1.Value - 1;
		if (num + modifier < 0)
		{
			modifier = 0;
		}
		int num2 = 0;
		for (int i = 0; i < decortypebox.SelectedIndex; i++)
		{
			num2 += slots_max[i];
		}
		return decorbuff[num2 + num + modifier];
	}

	private void load_decor()
	{
		byte b = get_item(0);
		int[] array = desk_ref;
		switch (decortypebox.SelectedIndex)
		{
		case 0:
			array = desk_ref;
			break;
		case 1:
			array = chair_ref;
			break;
		case 2:
			array = plant_ref;
			break;
		case 3:
			array = ornament_ref;
			break;
		case 4:
			array = mat_ref;
			break;
		case 5:
			array = poster_ref;
			break;
		case 6:
			array = doll_ref;
			break;
		case 7:
			array = cushion_ref;
			break;
		}
		for (int i = 0; i < array.Length; i++)
		{
			if (b == array[i])
			{
				decorationbox.SelectedIndex = i + 1;
				break;
			}
			decorationbox.SelectedIndex = 0;
		}
	}

	private void NumericUpDown1ValueChanged(object sender, EventArgs e)
	{
		if (get_item(-1) == 0)
		{
			if (numericUpDown1.Value - 1m < numericUpDown1.Minimum)
			{
				numericUpDown1.Value = numericUpDown1.Minimum;
			}
			else
			{
				numericUpDown1.Value -= 1m;
			}
		}
		else
		{
			load_decor();
		}
	}

	private void DecortypeboxSelectedIndexChanged(object sender, EventArgs e)
	{
		numericUpDown1.Value = 1m;
		numericUpDown1.Maximum = slots_max[decortypebox.SelectedIndex];
		decorationbox.Items.Clear();
		switch (decortypebox.SelectedIndex)
		{
		case 0:
			decorationbox.Items.AddRange(Desks);
			break;
		case 1:
			decorationbox.Items.AddRange(Chairs);
			break;
		case 2:
			decorationbox.Items.AddRange(Plants);
			break;
		case 3:
			decorationbox.Items.AddRange(Ornament);
			break;
		case 4:
			decorationbox.Items.AddRange(Mats);
			break;
		case 5:
			decorationbox.Items.AddRange(Posters);
			break;
		case 6:
			decorationbox.Items.AddRange(Dolls);
			break;
		case 7:
			decorationbox.Items.AddRange(Cushions);
			break;
		}
		numericUpDown1.Value = 1m;
		numericUpDown1.Maximum = slots_max[decortypebox.SelectedIndex];
		decorationbox.SelectedIndex = 0;
		load_decor();
	}

	private void Save_butClick(object sender, EventArgs e)
	{
		sav3file.set_decoration(decorbuff);
		sav3file.update_section_chk(3);
		FileIO.save_data(sav3file.Data, savfilter);
	}

	private void DecorationboxSelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Add_butClick(object sender, EventArgs e)
	{
		if (decorationbox.SelectedIndex != 0)
		{
			set_item(decorationbox.SelectedIndex - 1);
		}
	}

	private void Del_butClick(object sender, EventArgs e)
	{
		if (numericUpDown1.Value != numericUpDown1.Maximum && get_item(1) != 0)
		{
			MessageBox.Show("Please delete only last occupied slot.");
			return;
		}
		del_item();
		load_decor();
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
		this.decortypebox = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.decorationbox = new System.Windows.Forms.ComboBox();
		this.Decoration = new System.Windows.Forms.Label();
		this.save_but = new System.Windows.Forms.Button();
		this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
		this.add_but = new System.Windows.Forms.Button();
		this.del_but = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
		base.SuspendLayout();
		this.decortypebox.FormattingEnabled = true;
		this.decortypebox.Items.AddRange(new object[8] { "Desk", "Chair", "Plant", "Ornament", "Mat", "Poster", "Doll", "Cushion" });
		this.decortypebox.Location = new System.Drawing.Point(9, 38);
		this.decortypebox.Name = "decortypebox";
		this.decortypebox.Size = new System.Drawing.Size(297, 21);
		this.decortypebox.TabIndex = 0;
		this.decortypebox.SelectedIndexChanged += new System.EventHandler(DecortypeboxSelectedIndexChanged);
		this.label1.Location = new System.Drawing.Point(9, 16);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(100, 19);
		this.label1.TabIndex = 1;
		this.label1.Text = "Decoration type";
		this.label2.Location = new System.Drawing.Point(9, 73);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 13);
		this.label2.TabIndex = 3;
		this.label2.Text = "Slot";
		this.decorationbox.FormattingEnabled = true;
		this.decorationbox.Items.AddRange(new object[10] { "Empty", "Small Desk", "Pokémon Desk", "Heavy Desk", "Ragged Desk", "Comfort Desk", "Pretty Desk", "Brick Desk", "Camp Desk", "Hard Desk" });
		this.decorationbox.Location = new System.Drawing.Point(135, 88);
		this.decorationbox.Name = "decorationbox";
		this.decorationbox.Size = new System.Drawing.Size(171, 21);
		this.decorationbox.TabIndex = 4;
		this.decorationbox.SelectedIndexChanged += new System.EventHandler(DecorationboxSelectedIndexChanged);
		this.Decoration.Location = new System.Drawing.Point(135, 73);
		this.Decoration.Name = "Decoration";
		this.Decoration.Size = new System.Drawing.Size(100, 13);
		this.Decoration.TabIndex = 5;
		this.Decoration.Text = "Decoration";
		this.save_but.Location = new System.Drawing.Point(109, 130);
		this.save_but.Name = "save_but";
		this.save_but.Size = new System.Drawing.Size(75, 23);
		this.save_but.TabIndex = 6;
		this.save_but.Text = "Save";
		this.save_but.UseVisualStyleBackColor = true;
		this.save_but.Click += new System.EventHandler(Save_butClick);
		this.numericUpDown1.Location = new System.Drawing.Point(9, 89);
		this.numericUpDown1.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numericUpDown1.Name = "numericUpDown1";
		this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
		this.numericUpDown1.TabIndex = 2;
		this.numericUpDown1.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numericUpDown1.ValueChanged += new System.EventHandler(NumericUpDown1ValueChanged);
		this.add_but.Location = new System.Drawing.Point(312, 73);
		this.add_but.Name = "add_but";
		this.add_but.Size = new System.Drawing.Size(37, 23);
		this.add_but.TabIndex = 7;
		this.add_but.Text = "Add";
		this.add_but.UseVisualStyleBackColor = true;
		this.add_but.Click += new System.EventHandler(Add_butClick);
		this.del_but.Location = new System.Drawing.Point(312, 102);
		this.del_but.Name = "del_but";
		this.del_but.Size = new System.Drawing.Size(37, 23);
		this.del_but.TabIndex = 8;
		this.del_but.Text = "Del";
		this.del_but.UseVisualStyleBackColor = true;
		this.del_but.Click += new System.EventHandler(Del_butClick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(366, 165);
		base.Controls.Add(this.del_but);
		base.Controls.Add(this.add_but);
		base.Controls.Add(this.save_but);
		base.Controls.Add(this.Decoration);
		base.Controls.Add(this.decorationbox);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.numericUpDown1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.decortypebox);
		base.Name = "Decor_editor";
		this.Text = "Decoration Inventory Editor";
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
		base.ResumeLayout(false);
	}
}
