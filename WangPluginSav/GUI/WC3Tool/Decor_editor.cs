using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WangPluginSav.Util.WC3;

namespace WC3Tool;

partial class Decor_editor : Form
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



	
}
