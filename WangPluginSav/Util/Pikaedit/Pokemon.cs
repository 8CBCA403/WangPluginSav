using System;
using System.Drawing;
using System.Linq;

namespace WangPluginSav.Util.Pikaedit
{
	public class Pokemon
	{
		public byte[] data = new byte[220];

		public bool isEmpty = true;

		public bool isShiny;

		public bool partypkm;

		public uint pid;

		public ushort checksum;

		public string nick;

		public string nicktb;

		public string ottb;

		public ushort no;

		public string species;

		public string ability;

		public ushort id;

		public ushort sid;

		public byte markings;

		public MoveSet moveset;

		public string item;

		public string nature;

		public byte happiness;

		public string language;

		public string version;

		public byte level = 1;

		public uint exp;

		public string form;

		public bool isFateful;

		public RibbonSet ribbon1;

		public RibbonSet ribbon2;

		public RibbonSet ribbon3;

		public RibbonSet ribbon4;

		public RibbonSet ribbon5;

		public RibbonSet ribbon6;

		public ushort hp;

		public ushort maxhp;

		public ushort attack;

		public ushort defense;

		public ushort spatk;

		public ushort spdef;

		public ushort speed;

		public byte hpev;

		public byte atev;

		public byte dfev;

		public byte saev;

		public byte sdev;

		public byte spev;

		public IVSet iv;

		public string dateegg;

		public string datemet;

		public byte levelmet;

		public string locationmet;

		public string eggloc;

		public string status = "None";

		public byte DW;

		public byte pokestar;

		public byte female;

		public byte genderless;

		public string ot;

		public bool isHatched;

		public byte pokerus;

		public string pokeball;

		public byte genderot;

		public byte encounter;

		public string hpType = "Fighting";

		public byte hpPower = 30;

		public byte genderRatio;

		public Image sprite;

		public int gen;

		public byte abilityIndex;

		private uint seed;

		private byte baseHP = 1;

		private byte baseAtk = 1;

		private byte baseDef = 1;

		private byte baseSpAtk = 1;

		private byte baseSpDef = 1;

		private byte baseSpd = 1;

		private string[] forms = new string[1] { "None" };

		private void srand(uint newSeed)
		{
			seed = newSeed;
		}

		private uint rand()
		{
			seed = (1103515245 * seed + 24691) & 0xFFFFFFFFu;
			return seed >> 16;
		}

		private uint prand()
		{
			seed = (uint)((int)seed * -289805467 + 171270561) & 0xFFFFFFFFu;
			return seed >> 16;
		}

		public void fillForms()
		{
			forms = PkmLib.getFormList(species);
		}

		private void baseStats()
		{
			baseHP = PkmLib.baseStats[no][0];
			baseAtk = PkmLib.baseStats[no][1];
			baseDef = PkmLib.baseStats[no][2];
			baseSpAtk = PkmLib.baseStats[no][3];
			baseSpDef = PkmLib.baseStats[no][4];
			baseSpd = PkmLib.baseStats[no][5];
			if (PkmLib.getFormValue(species, form) != 0)
			{
				if (form == "Attack")
				{
					baseHP = 50;
					baseAtk = 180;
					baseDef = 20;
					baseSpAtk = 180;
					baseSpDef = 20;
					baseSpd = 150;
				}
				if (form == "Defense")
				{
					baseHP = 50;
					baseAtk = 70;
					baseDef = 160;
					baseSpAtk = 70;
					baseSpDef = 160;
					baseSpd = 90;
				}
				if (form == "Speed")
				{
					baseHP = 50;
					baseAtk = 95;
					baseDef = 90;
					baseSpAtk = 95;
					baseSpDef = 90;
					baseSpd = 180;
				}
				if ((form == "Sandy") & (species == "Wormadam"))
				{
					baseHP = 60;
					baseAtk = 79;
					baseDef = 105;
					baseSpAtk = 59;
					baseSpDef = 85;
					baseSpd = 36;
				}
				if ((form == "Trash") & (species == "Wormadam"))
				{
					baseHP = 60;
					baseAtk = 69;
					baseDef = 95;
					baseSpAtk = 69;
					baseSpDef = 95;
					baseSpd = 36;
				}
				if (species == "Rotom")
				{
					baseHP = 50;
					baseAtk = 65;
					baseDef = 107;
					baseSpAtk = 105;
					baseSpDef = 107;
					baseSpd = 86;
				}
				if (form == "Origin")
				{
					baseHP = 150;
					baseAtk = 120;
					baseDef = 100;
					baseSpAtk = 120;
					baseSpDef = 100;
					baseSpd = 90;
				}
				if (form == "Sky")
				{
					baseHP = 100;
					baseAtk = 103;
					baseDef = 75;
					baseSpAtk = 120;
					baseSpDef = 75;
					baseSpd = 127;
				}
				if ((form == "Therian") & (species == "Tornadus"))
				{
					baseHP = 79;
					baseAtk = 100;
					baseDef = 80;
					baseSpAtk = 110;
					baseSpDef = 90;
					baseSpd = 121;
				}
				if ((form == "Therian") & (species == "Thundurus"))
				{
					baseHP = 79;
					baseAtk = 105;
					baseDef = 70;
					baseSpAtk = 145;
					baseSpDef = 80;
					baseSpd = 101;
				}
				if ((form == "Therian") & (species == "Landorus"))
				{
					baseHP = 89;
					baseAtk = 145;
					baseDef = 90;
					baseSpAtk = 105;
					baseSpDef = 80;
					baseSpd = 91;
				}
				if (form == "Black")
				{
					baseHP = 125;
					baseAtk = 170;
					baseDef = 100;
					baseSpAtk = 120;
					baseSpDef = 90;
					baseSpd = 95;
				}
				if (form == "White")
				{
					baseHP = 125;
					baseAtk = 120;
					baseDef = 90;
					baseSpAtk = 170;
					baseSpDef = 100;
					baseSpd = 95;
				}
				if (form == "Pirouette")
				{
					baseHP = 100;
					baseAtk = 128;
					baseDef = 90;
					baseSpAtk = 77;
					baseSpDef = 77;
					baseSpd = 128;
				}
			}
		}

		public void updateStats()
		{
			partypkm = true;
			if (status == "None")
			{
				status = "None";
				data[136] = 0;
			}
			baseStats();
			level = PkmLib.calculateLevel(species, exp);
			data[140] = level;
			double num = 1.0;
			double num2 = 1.0;
			double num3 = 1.0;
			double num4 = 1.0;
			double num5 = 1.0;
			switch (nature)
			{
			case "Adamant":
				num = 1.1;
				num3 = 0.9;
				break;
			case "Bold":
				num = 0.9;
				num2 = 1.1;
				break;
			case "Brave":
				num = 1.1;
				num5 = 0.9;
				break;
			case "Calm":
				num4 = 1.1;
				num = 0.9;
				break;
			case "Careful":
				num4 = 1.1;
				num3 = 0.9;
				break;
			case "Gentle":
				num4 = 1.1;
				num2 = 0.9;
				break;
			case "Hasty":
				num5 = 1.1;
				num2 = 0.9;
				break;
			case "Impish":
				num2 = 1.1;
				num3 = 0.9;
				break;
			case "Jolly":
				num5 = 1.1;
				num3 = 0.9;
				break;
			case "Lax":
				num2 = 1.1;
				num4 = 0.9;
				break;
			case "Lonely":
				num = 1.1;
				num2 = 0.9;
				break;
			case "Mild":
				num3 = 1.1;
				num2 = 0.9;
				break;
			case "Modest":
				num3 = 1.1;
				num = 0.9;
				break;
			case "Naive":
				num5 = 1.1;
				num4 = 0.9;
				break;
			case "Naughty":
				num = 1.1;
				num4 = 0.9;
				break;
			case "Quiet":
				num3 = 1.1;
				num5 = 0.9;
				break;
			case "Rash":
				num3 = 1.1;
				num4 = 0.9;
				break;
			case "Relaxed":
				num2 = 1.1;
				num5 = 0.9;
				break;
			case "Sassy":
				num4 = 1.1;
				num5 = 0.9;
				break;
			case "Timid":
				num5 = 1.1;
				num = 0.9;
				break;
			}
			if (baseHP == 1)
			{
				hp = 1;
			}
			else
			{
				hp = (ushort)Math.Floor((double)((iv.hp + 2 * baseHP + (int)hpev / 4 + 100) * level / 100) + 10.0);
			}
			maxhp = hp;
			data[142] = (byte)(hp & 0xFFu);
			data[143] = (byte)(hp >> 8);
			data[144] = (byte)(hp & 0xFFu);
			data[145] = (byte)(hp >> 8);
			attack = (ushort)Math.Floor((double)((iv.atk + 2 * baseAtk + (int)atev / 4) * level / 100 + 5) * num);
			data[146] = (byte)(attack & 0xFFu);
			data[147] = (byte)(attack >> 8);
			defense = (ushort)Math.Floor((double)((iv.def + 2 * baseDef + (int)dfev / 4) * level / 100 + 5) * num2);
			data[148] = (byte)(defense & 0xFFu);
			data[149] = (byte)(defense >> 8);
			speed = (ushort)Math.Floor((double)((iv.spe + 2 * baseSpd + (int)spev / 4) * level / 100 + 5) * num5);
			data[150] = (byte)(speed & 0xFFu);
			data[151] = (byte)(speed >> 8);
			spatk = (ushort)Math.Floor((double)((iv.spa + 2 * baseSpAtk + (int)saev / 4) * level / 100 + 5) * num3);
			data[152] = (byte)(spatk & 0xFFu);
			data[153] = (byte)(spatk >> 8);
			spdef = (ushort)Math.Floor((double)((iv.spd + 2 * baseSpDef + (int)sdev / 4) * level / 100 + 5) * num4);
			data[154] = (byte)(spdef & 0xFFu);
			data[155] = (byte)(spdef >> 8);
		}

		public void clear()
		{
			for (int i = 0; i < data.Length; i++)
			{
				data[i] = 0;
			}
			species = "None";
			isEmpty = true;
		}

		private void Initialize()
		{
			int num = 0;
			pid = BitConverter.ToUInt32(data, 0);
			abilityIndex = (byte)((pid >> 16) & 1u);
			checksum = BitConverter.ToUInt16(data, 6);
			try
			{
				species = PkmLib.species[BitConverter.ToUInt16(data, 8)];
				no = BitConverter.ToUInt16(data, 8);
				genderRatio = PkmLib.genderRatio[no];
			}
			catch (Exception)
			{
				pid = 0u;
				checksum = 0;
				clear();
				return;
			}
			if (no == 0)
			{
				clear();
				return;
			}
			item = PkmLib.items[BitConverter.ToUInt16(data, 10)];
			id = BitConverter.ToUInt16(data, 12);
			sid = BitConverter.ToUInt16(data, 14);
			exp = BitConverter.ToUInt32(data, 16);
			happiness = data[20];
			if (data[21] < PkmLib.abilities.Count)
			{
				ability = PkmLib.abilities[data[21]];
			}
			else
			{
				ability = Convert.ToString(data[21]);
			}
			markings = data[22];
			switch (data[23])
			{
			case 1:
				language = "Japan";
				break;
			case 2:
				language = "English";
				break;
			case 3:
				language = "French";
				break;
			case 4:
				language = "Italian";
				break;
			case 5:
				language = "German";
				break;
			case 7:
				language = "Spanish";
				break;
			case 8:
				language = "Korean";
				break;
			default:
				language = "English";
				break;
			}
			hpev = data[24];
			atev = data[25];
			dfev = data[26];
			spev = data[27];
			saev = data[28];
			sdev = data[29];
			ribbon1 = new RibbonSet(BitConverter.ToUInt16(data, 36));
			ribbon2 = new RibbonSet(BitConverter.ToUInt16(data, 38));
			moveset = new MoveSet(new Move(BitConverter.ToUInt16(data, 40), data[48], data[52]), new Move(BitConverter.ToUInt16(data, 42), data[49], data[53]), new Move(BitConverter.ToUInt16(data, 44), data[50], data[54]), new Move(BitConverter.ToUInt16(data, 46), data[51], data[55]));
			iv = new IVSet(BitConverter.ToUInt32(data, 56));
			ribbon3 = new RibbonSet(BitConverter.ToUInt16(data, 60));
			ribbon4 = new RibbonSet(BitConverter.ToUInt16(data, 62));
			byte b = data[64];
			isFateful = (b & 1) == 1;
			female = (byte)((uint)(b >> 1) & 1u);
			genderless = (byte)((uint)(b >> 2) & 1u);
			int num2 = b & 0xF8;
			form = "None";
			fillForms();
			form = forms[num2 / 8];
			nature = PkmLib.natures[data[65]];
			DW = data[66];
			switch (data[95])
			{
			case 1:
				version = "Ruby";
				gen = 3;
				break;
			case 2:
				version = "Sapphire";
				gen = 3;
				break;
			case 3:
				version = "Emerald";
				gen = 3;
				break;
			case 4:
				version = "Fire Red";
				gen = 3;
				break;
			case 5:
				version = "Leaf Green";
				gen = 3;
				break;
			case 7:
				version = "Heart Gold";
				gen = 4;
				break;
			case 8:
				version = "Soul Silver";
				gen = 4;
				break;
			case 10:
				version = "Diamond";
				gen = 4;
				break;
			case 11:
				version = "Pearl";
				gen = 4;
				break;
			case 12:
				version = "Platinum";
				gen = 4;
				break;
			case 15:
				version = "Colosseum/XD";
				gen = 3;
				break;
			case 20:
				version = "White";
				gen = 5;
				break;
			case 21:
				version = "Black";
				gen = 5;
				break;
			case 22:
				version = "White 2";
				gen = 5;
				break;
			case 23:
				version = "Black 2";
				gen = 5;
				break;
			case 24:
				version = "X";
				gen = 5;
				break;
			case 25:
				version = "Y";
				gen = 5;
				break;
			default:
				version = "Black 2";
				gen = 5;
				break;
			}
			ribbon5 = new RibbonSet(BitConverter.ToUInt16(data, 96));
			ribbon6 = new RibbonSet(BitConverter.ToUInt16(data, 98));
			int num3 = 72;
			string text = "";
			string text2 = "";
			bool flag = false;
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			ushort num4 = 0;
			while (num < 11)
			{
				num4 = BitConverter.ToUInt16(data, num3);
				num++;
				switch (num4)
				{
				case ushort.MaxValue:
					text = "\\FFFF";
					text3 = "";
					flag = true;
					break;
				case 0:
					text = "\\0000";
					text3 = "";
					break;
				default:
					if (!flag)
					{
						text = "";
						text3 = char.ConvertFromUtf32(num4);
						break;
					}
					text5 = Func.zeros((num4 & 0xFF).ToString("X"));
					text6 = Func.zeros((num4 >> 8).ToString("X"));
					text = "\\" + text5 + text6;
					text3 = "";
					break;
				}
				text4 += text3;
				text2 += text;
				num3 += 2;
			}
			nick = text4;
			nicktb = text4 + text2;
			num = 0;
			num3 = 104;
			string text7 = "";
			bool flag2 = false;
			text = "";
			string text8 = "";
			string text9 = "";
			while (num < 8)
			{
				num++;
				num4 = BitConverter.ToUInt16(data, num3);
				switch (num4)
				{
				case ushort.MaxValue:
					text = "\\FFFF";
					text8 = "";
					flag2 = true;
					break;
				case 0:
					text = "\\0000";
					text8 = "";
					break;
				default:
					if (!flag2)
					{
						text = "";
						text8 = char.ConvertFromUtf32(num4);
					}
					else
					{
						text = "\\" + num4.ToString("X");
						text8 = "";
					}
					break;
				}
				text9 += text8;
				text7 += text;
				num3 += 2;
			}
			ot = text9;
			ottb = text9 + text7;
			byte b2 = data[120];
			byte b3 = data[121];
			byte b4 = data[122];
			if (b4 == 0 && b3 == 0 && b2 == 0)
			{
				dateegg = "";
			}
			else
			{
				dateegg = string.Format("{0}", (b4 < 10) ? "0" : "") + b4 + "/" + string.Format("{0}", (b3 < 10) ? "0" : "") + b3 + "/" + string.Format("{0}", (b2 < 10) ? "0" : "") + b2;
			}
			byte b5 = data[123];
			byte b6 = data[124];
			byte b7 = data[125];
			datemet = string.Format("{0}", (b7 < 10) ? "0" : "") + b7 + "/" + string.Format("{0}", (b6 < 10) ? "0" : "") + b6 + "/" + string.Format("{0}", (b5 < 10) ? "0" : "") + b5;
			if (BitConverter.ToUInt16(data, 126) == 0)
			{
				isHatched = false;
				if (PkmLib.locationValues.Contains(BitConverter.ToUInt16(data, 126)))
				{
					eggloc = PkmLib.locations[PkmLib.locationValues.IndexOf(BitConverter.ToUInt16(data, 126))];
				}
				else
				{
					eggloc = Convert.ToString(BitConverter.ToUInt16(data, 126));
				}
				if (PkmLib.locationValues.Contains(BitConverter.ToUInt16(data, 128)))
				{
					locationmet = PkmLib.locations[PkmLib.locationValues.IndexOf(BitConverter.ToUInt16(data, 128))];
				}
				else
				{
					locationmet = Convert.ToString(BitConverter.ToUInt16(data, 128));
				}
			}
			else
			{
				isHatched = true;
				if (PkmLib.locationValues.Contains(BitConverter.ToUInt16(data, 128)))
				{
					eggloc = PkmLib.locations[PkmLib.locationValues.IndexOf(BitConverter.ToUInt16(data, 128))];
				}
				else
				{
					eggloc = Convert.ToString(BitConverter.ToUInt16(data, 128));
				}
				if (PkmLib.locationValues.Contains(BitConverter.ToUInt16(data, 126)))
				{
					locationmet = PkmLib.locations[PkmLib.locationValues.IndexOf(BitConverter.ToUInt16(data, 126))];
				}
				else
				{
					locationmet = Convert.ToString(BitConverter.ToUInt16(data, 126));
				}
			}
			pokerus = data[130];
			pokeball = PkmLib.pokeballs[data[131]];
			byte b8 = data[132];
			levelmet = (byte)(b8 & 0x7Fu);
			genderot = (byte)(b8 >> 7);
			encounter = data[133];
			pokestar = data[135];
			if (partypkm)
			{
				byte b9 = data[136];
				byte b10 = (byte)(b9 & 7u);
				byte b11 = (byte)((uint)(b9 >> 3) & 1u);
				byte b12 = (byte)((uint)(b9 >> 4) & 1u);
				byte b13 = (byte)((uint)(b9 >> 5) & 1u);
				byte b14 = (byte)((uint)(b9 >> 6) & 1u);
				byte b15 = (byte)((uint)(b9 >> 7) & 1u);
				if (b10 > 0)
				{
					status = "Asleep " + b10 + " Turn(s)";
				}
				else
				{
					status = "None";
				}
				if (b11 == 1)
				{
					status = "Poisoned";
				}
				if (b12 == 1)
				{
					status = "Burned";
				}
				if (b13 == 1)
				{
					status = "Frozen";
				}
				if (b14 == 1)
				{
					status = "Paralyzed";
				}
				if (b15 == 1)
				{
					status = "Badly Poisoned";
				}
				level = data[140];
				hp = BitConverter.ToUInt16(data, 142);
				maxhp = BitConverter.ToUInt16(data, 144);
				attack = BitConverter.ToUInt16(data, 146);
				defense = BitConverter.ToUInt16(data, 148);
				speed = BitConverter.ToUInt16(data, 150);
				spatk = BitConverter.ToUInt16(data, 152);
				spdef = BitConverter.ToUInt16(data, 154);
			}
			ushort num5 = 0;
			ushort num6 = 0;
			num5 = (ushort)(pid & 0xFFFFu);
			num6 = (ushort)((pid >> 16) & 0xFFFFu);
			int num7 = id ^ sid;
			int num8 = num5 ^ num6;
			if (((num7 ^ num8) < 8) & (species != PkmLib.species[0]))
			{
				isShiny = true;
			}
			else
			{
				isShiny = false;
			}
			if (no == 0)
			{
				isEmpty = true;
			}
			else
			{
				isEmpty = false;
			}
			updateSprite();
			updateStats();
		}

		public Pokemon()
		{
		}

		public Pokemon(uint _pid, string _species, string _item, string _ability, string _nature, uint _level, byte[] _iv, byte[] _ev, string[] _moves, byte[] _ppups, string _locationmet, string _datemet, string _egglocation, string _eggdate, string _version, string _language, string _form, byte _pokerus)
		{
		}

		public Pokemon(byte[] data, bool decriptData = false)
		{
			if (!PkmLib.dictionariesInitialized)
			{
				PkmLib.Initialize();
			}
			isEmpty = true;
			for (int i = 0; i < data.Length; i++)
			{
				this.data[i] = data[i];
			}
			if (data.Length > 200)
			{
				partypkm = true;
			}
			else
			{
				partypkm = false;
			}
			bool flag = true;
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] != 0)
				{
					flag = false;
					break;
				}
			}
			if (decriptData)
			{
				if (!flag)
				{
					decrypt();
					try
					{
						Initialize();
					}
					catch (Exception)
					{
						for (int i = 0; i < data.Length; i++)
						{
							data[i] = 0;
						}
						isEmpty = true;
					}
				}
				else
				{
					isEmpty = true;
				}
				return;
			}
			if (data[52] > 3)
			{
				decrypt();
			}
			else if (data[53] > 3)
			{
				decrypt();
			}
			else if (data[54] > 3)
			{
				decrypt();
			}
			else if (data[55] > 3)
			{
				decrypt();
			}
			if (!flag)
			{
				isEmpty = false;
				try
				{
					Initialize();
				}
				catch (Exception)
				{
					for (int i = 0; i < data.Length; i++)
					{
						data[i] = 0;
					}
					isEmpty = true;
				}
			}
			else
			{
				isEmpty = true;
			}
		}

		public void decrypt()
		{
			pid = BitConverter.ToUInt32(data, 0);
			checksum = BitConverter.ToUInt16(data, 6);
			uint num = ((pid >> 13) & 0x1F) % 24u;
			string text = null;
			string text2 = null;
			string text3 = null;
			string text4 = null;
			switch (num)
			{
			case 0u:
				text = "A";
				text2 = "B";
				text3 = "C";
				text4 = "D";
				break;
			case 1u:
				text = "A";
				text2 = "B";
				text3 = "D";
				text4 = "C";
				break;
			case 2u:
				text = "A";
				text2 = "C";
				text3 = "B";
				text4 = "D";
				break;
			case 3u:
				text = "A";
				text2 = "C";
				text3 = "D";
				text4 = "B";
				break;
			case 4u:
				text = "A";
				text2 = "D";
				text3 = "B";
				text4 = "C";
				break;
			case 5u:
				text = "A";
				text2 = "D";
				text3 = "C";
				text4 = "B";
				break;
			case 6u:
				text = "B";
				text2 = "A";
				text3 = "C";
				text4 = "D";
				break;
			case 7u:
				text = "B";
				text2 = "A";
				text3 = "D";
				text4 = "C";
				break;
			case 8u:
				text = "B";
				text2 = "C";
				text3 = "A";
				text4 = "D";
				break;
			case 9u:
				text = "B";
				text2 = "C";
				text3 = "D";
				text4 = "A";
				break;
			case 10u:
				text = "B";
				text2 = "D";
				text3 = "A";
				text4 = "C";
				break;
			case 11u:
				text = "B";
				text2 = "D";
				text3 = "C";
				text4 = "A";
				break;
			case 12u:
				text = "C";
				text2 = "A";
				text3 = "B";
				text4 = "D";
				break;
			case 13u:
				text = "C";
				text2 = "A";
				text3 = "D";
				text4 = "B";
				break;
			case 14u:
				text = "C";
				text2 = "B";
				text3 = "A";
				text4 = "D";
				break;
			case 15u:
				text = "C";
				text2 = "B";
				text3 = "D";
				text4 = "A";
				break;
			case 16u:
				text = "C";
				text2 = "D";
				text3 = "A";
				text4 = "B";
				break;
			case 17u:
				text = "C";
				text2 = "D";
				text3 = "B";
				text4 = "A";
				break;
			case 18u:
				text = "D";
				text2 = "A";
				text3 = "B";
				text4 = "C";
				break;
			case 19u:
				text = "D";
				text2 = "A";
				text3 = "C";
				text4 = "B";
				break;
			case 20u:
				text = "D";
				text2 = "B";
				text3 = "A";
				text4 = "C";
				break;
			case 21u:
				text = "D";
				text2 = "B";
				text3 = "C";
				text4 = "A";
				break;
			case 22u:
				text = "D";
				text2 = "C";
				text3 = "A";
				text4 = "B";
				break;
			case 23u:
				text = "D";
				text2 = "C";
				text3 = "B";
				text4 = "A";
				break;
			}
			ushort[] array = new ushort[65];
			srand(checksum);
			int num2 = 8;
			int i;
			for (i = 0; i < 64; i++)
			{
				array[i] = (ushort)(BitConverter.ToUInt16(data, num2) ^ rand());
				num2 += 2;
			}
			i = 0;
			switch (text)
			{
			case "A":
				num2 = 8;
				break;
			case "B":
				num2 = 40;
				break;
			case "C":
				num2 = 72;
				break;
			case "D":
				num2 = 104;
				break;
			}
			for (; i < 16; i++)
			{
				data[num2] = (byte)(array[i] & 0xFFu);
				data[num2 + 1] = (byte)(array[i] >> 8);
				num2 += 2;
			}
			switch (text2)
			{
			case "A":
				num2 = 8;
				break;
			case "B":
				num2 = 40;
				break;
			case "C":
				num2 = 72;
				break;
			case "D":
				num2 = 104;
				break;
			}
			for (; i < 32; i++)
			{
				data[num2] = (byte)(array[i] & 0xFFu);
				data[num2 + 1] = (byte)(array[i] >> 8);
				num2 += 2;
			}
			switch (text3)
			{
			case "A":
				num2 = 8;
				break;
			case "B":
				num2 = 40;
				break;
			case "C":
				num2 = 72;
				break;
			case "D":
				num2 = 104;
				break;
			}
			for (; i < 48; i++)
			{
				data[num2] = (byte)(array[i] & 0xFFu);
				data[num2 + 1] = (byte)(array[i] >> 8);
				num2 += 2;
			}
			switch (text4)
			{
			case "A":
				num2 = 8;
				break;
			case "B":
				num2 = 40;
				break;
			case "C":
				num2 = 72;
				break;
			case "D":
				num2 = 104;
				break;
			}
			for (; i < 64; i++)
			{
				data[num2] = (byte)(array[i] & 0xFFu);
				data[num2 + 1] = (byte)(array[i] >> 8);
				num2 += 2;
			}
			srand(pid);
			i = 0;
			num2 = 136;
			ushort[] array2 = new ushort[43];
			while (i < 42)
			{
				array2[i] = (ushort)(BitConverter.ToUInt16(data, num2) ^ rand());
				i++;
				num2 += 2;
			}
			i = 0;
			num2 = 136;
			for (; i < 42; i++)
			{
				data[num2] = (byte)(array2[i] & 0xFFu);
				data[num2 + 1] = (byte)(array2[i] >> 8);
				num2 += 2;
			}
		}

		public void encrypt()
		{
			pid = BitConverter.ToUInt32(data, 0);
			checksum = BitConverter.ToUInt16(data, 6);
			uint num = ((pid >> 13) & 0x1F) % 24u;
			string text = null;
			string text2 = null;
			string text3 = null;
			string text4 = null;
			switch (num)
			{
			case 0u:
				text = "A";
				text2 = "B";
				text3 = "C";
				text4 = "D";
				break;
			case 1u:
				text = "A";
				text2 = "B";
				text3 = "D";
				text4 = "C";
				break;
			case 2u:
				text = "A";
				text2 = "C";
				text3 = "B";
				text4 = "D";
				break;
			case 3u:
				text = "A";
				text2 = "C";
				text3 = "D";
				text4 = "B";
				break;
			case 4u:
				text = "A";
				text2 = "D";
				text3 = "B";
				text4 = "C";
				break;
			case 5u:
				text = "A";
				text2 = "D";
				text3 = "C";
				text4 = "B";
				break;
			case 6u:
				text = "B";
				text2 = "A";
				text3 = "C";
				text4 = "D";
				break;
			case 7u:
				text = "B";
				text2 = "A";
				text3 = "D";
				text4 = "C";
				break;
			case 8u:
				text = "B";
				text2 = "C";
				text3 = "A";
				text4 = "D";
				break;
			case 9u:
				text = "B";
				text2 = "C";
				text3 = "D";
				text4 = "A";
				break;
			case 10u:
				text = "B";
				text2 = "D";
				text3 = "A";
				text4 = "C";
				break;
			case 11u:
				text = "B";
				text2 = "D";
				text3 = "C";
				text4 = "A";
				break;
			case 12u:
				text = "C";
				text2 = "A";
				text3 = "B";
				text4 = "D";
				break;
			case 13u:
				text = "C";
				text2 = "A";
				text3 = "D";
				text4 = "B";
				break;
			case 14u:
				text = "C";
				text2 = "B";
				text3 = "A";
				text4 = "D";
				break;
			case 15u:
				text = "C";
				text2 = "B";
				text3 = "D";
				text4 = "A";
				break;
			case 16u:
				text = "C";
				text2 = "D";
				text3 = "A";
				text4 = "B";
				break;
			case 17u:
				text = "C";
				text2 = "D";
				text3 = "B";
				text4 = "A";
				break;
			case 18u:
				text = "D";
				text2 = "A";
				text3 = "B";
				text4 = "C";
				break;
			case 19u:
				text = "D";
				text2 = "A";
				text3 = "C";
				text4 = "B";
				break;
			case 20u:
				text = "D";
				text2 = "B";
				text3 = "A";
				text4 = "C";
				break;
			case 21u:
				text = "D";
				text2 = "B";
				text3 = "C";
				text4 = "A";
				break;
			case 22u:
				text = "D";
				text2 = "C";
				text3 = "A";
				text4 = "B";
				break;
			case 23u:
				text = "D";
				text2 = "C";
				text3 = "B";
				text4 = "A";
				break;
			}
			int num2 = 0;
			int num3 = 8;
			ushort[] array = new ushort[16];
			while (num2 < 16)
			{
				array[num2] = BitConverter.ToUInt16(data, num3);
				num2++;
				num3 += 2;
			}
			num2 = 0;
			num3 = 40;
			ushort[] array2 = new ushort[16];
			while (num2 < 16)
			{
				array2[num2] = BitConverter.ToUInt16(data, num3);
				num2++;
				num3 += 2;
			}
			num2 = 0;
			num3 = 72;
			ushort[] array3 = new ushort[16];
			while (num2 < 16)
			{
				array3[num2] = BitConverter.ToUInt16(data, num3);
				num2++;
				num3 += 2;
			}
			num2 = 0;
			ushort[] array4 = new ushort[16];
			num3 = 104;
			while (num2 < 16)
			{
				array4[num2] = BitConverter.ToUInt16(data, num3);
				num2++;
				num3 += 2;
			}
			num2 = 0;
			ushort[] array5 = new ushort[42];
			num3 = 136;
			num2 = 0;
			while (num2 < 42)
			{
				array5[num2] = BitConverter.ToUInt16(data, num3);
				num2++;
				num3 += 2;
			}
			num2 = 0;
			srand(checksum);
			ushort[] array6 = new ushort[29];
			num2 = 0;
			num3 = 8;
			switch (text)
			{
			case "A":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array[num2] ^ rand());
				}
				break;
			case "B":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array2[num2] ^ rand());
				}
				break;
			case "C":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array3[num2] ^ rand());
				}
				break;
			case "D":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array4[num2] ^ rand());
				}
				break;
			}
			num2 = 0;
			num3 = 8;
			while (num2 < 16)
			{
				data[num3] = (byte)(array6[num2] & 0xFFu);
				data[num3 + 1] = (byte)(array6[num2] >> 8);
				num2++;
				num3 += 2;
			}
			num2 = 0;
			num3 = 40;
			switch (text2)
			{
			case "A":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array[num2] ^ rand());
				}
				break;
			case "B":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array2[num2] ^ rand());
				}
				break;
			case "C":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array3[num2] ^ rand());
				}
				break;
			case "D":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array4[num2] ^ rand());
				}
				break;
			}
			num2 = 0;
			while (num2 < 16)
			{
				data[num3] = (byte)(array6[num2] & 0xFFu);
				data[num3 + 1] = (byte)(array6[num2] >> 8);
				num2++;
				num3 += 2;
			}
			num2 = 0;
			num3 = 72;
			switch (text3)
			{
			case "A":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array[num2] ^ rand());
				}
				break;
			case "B":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array2[num2] ^ rand());
				}
				break;
			case "C":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array3[num2] ^ rand());
				}
				break;
			case "D":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array4[num2] ^ rand());
				}
				break;
			}
			num2 = 0;
			while (num2 < 16)
			{
				data[num3] = (byte)(array6[num2] & 0xFFu);
				data[num3 + 1] = (byte)(array6[num2] >> 8);
				num2++;
				num3 += 2;
			}
			num2 = 0;
			num3 = 104;
			switch (text4)
			{
			case "A":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array[num2] ^ rand());
				}
				break;
			case "B":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array2[num2] ^ rand());
				}
				break;
			case "C":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array3[num2] ^ rand());
				}
				break;
			case "D":
				for (; num2 < 16; num2++)
				{
					array6[num2] = (ushort)(array4[num2] ^ rand());
				}
				break;
			}
			num2 = 0;
			while (num2 < 16)
			{
				data[num3] = (byte)(array6[num2] & 0xFFu);
				data[num3 + 1] = (byte)(array6[num2] >> 8);
				num2++;
				num3 += 2;
			}
			num2 = 0;
			num3 = 136;
			srand(pid);
			num2 = 0;
			ushort[] array7 = new ushort[43];
			for (; num2 < 42; num2++)
			{
				array7[num2] = (ushort)(array5[num2] ^ rand());
			}
			num2 = 0;
			num3 = 136;
			while (num2 < 42)
			{
				data[num3] = (byte)(array7[num2] & 0xFFu);
				data[num3 + 1] = (byte)(array7[num2] >> 8);
				num2++;
				num3 += 2;
			}
		}

		public void checksumUpdate()
		{
			int num = 0;
			for (int i = 8; i < 136; i += 2)
			{
				num += BitConverter.ToUInt16(data, i);
			}
			ushort num2 = (ushort)((uint)num & 0xFFFFu);
			data[6] = (byte)(num2 & 0xFFu);
			data[7] = (byte)((uint)(num2 >> 8) & 0xFFu);
		}

		public void save(bool isParty = true)
		{
			if (isEmpty)
			{
				clear();
				return;
			}
			Array.Copy(BitConverter.GetBytes(pid), 0, data, 0, 4);
			Array.Copy(BitConverter.GetBytes(checksum), 0, data, 6, 2);
			Array.Copy(BitConverter.GetBytes(PkmLib.species.IndexOf(species)), 0, data, 8, 2);
			Array.Copy(BitConverter.GetBytes(PkmLib.items.IndexOf(item)), 0, data, 10, 2);
			Array.Copy(BitConverter.GetBytes(id), 0, data, 12, BitConverter.GetBytes(id).Length);
			Array.Copy(BitConverter.GetBytes(sid), 0, data, 14, BitConverter.GetBytes(sid).Length);
			Array.Copy(BitConverter.GetBytes(exp), 0, data, 16, BitConverter.GetBytes(exp).Length);
			data[21] = Convert.ToByte(PkmLib.abilities.IndexOf(ability));
			data[20] = happiness;
			data[22] = markings;
			data[23] = Convert.ToByte((PkmLib.Languages)Enum.Parse(typeof(PkmLib.Languages), language));
			data[24] = hpev;
			data[25] = atev;
			data[26] = dfev;
			data[27] = spev;
			data[28] = saev;
			data[29] = sdev;
			Array.Copy(BitConverter.GetBytes(ribbon1.data), 0, data, 36, 2);
			Array.Copy(BitConverter.GetBytes(ribbon2.data), 0, data, 38, 2);
			Array.Copy(BitConverter.GetBytes(moveset.move1.move), 0, data, 40, 2);
			Array.Copy(BitConverter.GetBytes(moveset.move2.move), 0, data, 42, 2);
			Array.Copy(BitConverter.GetBytes(moveset.move3.move), 0, data, 44, 2);
			Array.Copy(BitConverter.GetBytes(moveset.move4.move), 0, data, 46, 2);
			data[48] = moveset.move1.pp;
			data[49] = moveset.move2.pp;
			data[50] = moveset.move3.pp;
			data[51] = moveset.move4.pp;
			data[52] = moveset.move1.ppUp;
			data[53] = moveset.move2.ppUp;
			data[54] = moveset.move3.ppUp;
			data[55] = moveset.move4.ppUp;
			Array.Copy(BitConverter.GetBytes(Convert.ToUInt32(iv.getIV())), 0, data, 56, 4);
			Array.Copy(BitConverter.GetBytes(ribbon3.data), 0, data, 60, 2);
			Array.Copy(BitConverter.GetBytes(ribbon4.data), 0, data, 62, 2);
			byte b = 0;
			if (isFateful)
			{
				b = (byte)(b | 1u);
			}
			if (female != 0)
			{
				b = (byte)(b | 2u);
			}
			if (genderless != 0)
			{
				b = (byte)(b | 4u);
			}
			int num = 0;
			fillForms();
			num = Array.IndexOf(forms, form) * 8;
			b = (byte)(b + (byte)num);
			data[64] = b;
			data[65] = (byte)PkmLib.natures.IndexOf(nature);
			data[66] = DW;
			int num2 = 0;
			int num3 = 72;
			_ = nicktb.Length;
			string text = "";
			string text2 = "";
			string[] array = null;
			string text3 = "";
			ushort num4 = 0;
			string text4 = nicktb;
			while (num2 < 10)
			{
				if (string.IsNullOrEmpty(text4))
				{
					Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(0)), 0, data, num3, 2);
					num2++;
				}
				else if (text4.First().Equals('\\'))
				{
					array = text4.Split('\\');
					text3 = array[1];
					text = Func.zeros((Convert.ToUInt16(text3, 16) & 0xFF).ToString("X"));
					text2 = Func.zeros((Convert.ToUInt16(text3, 16) >> 8).ToString("X"));
					num4 = Convert.ToUInt16(text + text2, 16);
					Array.Copy(BitConverter.GetBytes(num4), 0, data, num3, 2);
					num2 = num2 + text3.Length + 1;
					text4 = text4.Remove(0, text3.Length + 1);
				}
				else
				{
					num4 = text4.First();
					Array.Copy(BitConverter.GetBytes(num4), 0, data, num3, BitConverter.GetBytes(num4).Length);
					num2++;
					text4 = text4.Remove(0, 1);
				}
				num3 += 2;
			}
			num2 = 0;
			text3 = "";
			num3 = 104;
			text4 = ottb;
			while (num2 < 8)
			{
				if (string.IsNullOrEmpty(text4))
				{
					Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(0)), 0, data, num3, 2);
					num2++;
				}
				else if (text4.First().Equals('\\'))
				{
					array = text4.Split('\\');
					text3 = array[1];
					text = Func.zeros((Convert.ToUInt16(text3, 16) & 0xFF).ToString("X"));
					text2 = Func.zeros((Convert.ToUInt16(text3, 16) >> 8).ToString("X"));
					num4 = Convert.ToUInt16(text + text2, 16);
					Array.Copy(BitConverter.GetBytes(num4), 0, data, num3, 2);
					num2 = num2 + text3.Length + 1;
					text4 = text4.Remove(0, text3.Length + 1);
				}
				else
				{
					num4 = text4.First();
					Array.Copy(BitConverter.GetBytes(num4), 0, data, num3, BitConverter.GetBytes(num4).Length);
					num2++;
					text4 = text4.Remove(0, 1);
				}
				num3 += 2;
			}
			switch (version)
			{
			case "Ruby":
				data[95] = 1;
				break;
			case "Sapphire":
				data[95] = 2;
				break;
			case "Emerald":
				data[95] = 3;
				break;
			case "Fire Red":
				data[95] = 4;
				break;
			case "Leaf Green":
				data[95] = 5;
				break;
			case "Heart Gold":
				data[95] = 7;
				break;
			case "Soul Silver":
				data[95] = 8;
				break;
			case "Diamond":
				data[95] = 10;
				break;
			case "Pearl":
				data[95] = 11;
				break;
			case "Platinum":
				data[95] = 12;
				break;
			case "Colosseum/XD":
				data[95] = 15;
				break;
			case "White":
				data[95] = 20;
				break;
			case "Black":
				data[95] = 21;
				break;
			case "White 2":
				data[95] = 22;
				break;
			case "Black 2":
				data[95] = 23;
				break;
			case "X":
				data[95] = 24;
				break;
			case "Y":
				data[95] = 25;
				break;
			default:
				data[95] = 0;
				break;
			}
			Array.Copy(BitConverter.GetBytes(ribbon5.data), 0, data, 96, 2);
			Array.Copy(BitConverter.GetBytes(ribbon6.data), 0, data, 98, 2);
			if (!isHatched)
			{
				data[120] = 0;
				data[121] = 0;
				data[122] = 0;
			}
			else
			{
				string[] array2 = dateegg.Split('/');
				data[122] = Convert.ToByte(array2[0]);
				data[121] = Convert.ToByte(array2[1]);
				data[120] = Convert.ToByte(array2[2]);
			}
			string[] array3 = datemet.Split('/');
			data[125] = Convert.ToByte(array3[0]);
			data[124] = Convert.ToByte(array3[1]);
			data[123] = Convert.ToByte(array3[2]);
			ushort result;
			if (!isHatched)
			{
				data[126] = 0;
				data[127] = 0;
			}
			else if (ushort.TryParse(eggloc, out result))
			{
				Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(eggloc)), 0, data, 128, 2);
			}
			else
			{
				Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(PkmLib.locationValues[PkmLib.locations.IndexOf(eggloc)])), 0, data, 128, 2);
			}
			if (isHatched)
			{
				if (ushort.TryParse(locationmet, out result))
				{
					Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(locationmet)), 0, data, 126, 2);
				}
				else
				{
					Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(PkmLib.locationValues[PkmLib.locations.IndexOf(locationmet)])), 0, data, 126, 2);
				}
			}
			else if (ushort.TryParse(locationmet, out result))
			{
				Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(locationmet)), 0, data, 128, 2);
			}
			else
			{
				Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(PkmLib.locationValues[PkmLib.locations.IndexOf(locationmet)])), 0, data, 128, 2);
			}
			data[130] = pokerus;
			switch (pokeball)
			{
			case "Master Ball":
				data[131] = 1;
				break;
			case "Ultra Ball":
				data[131] = 2;
				break;
			case "Great Ball":
				data[131] = 3;
				break;
			case "Poké Ball":
				data[131] = 4;
				break;
			case "Safari Ball":
				data[131] = 5;
				break;
			case "Net Ball":
				data[131] = 6;
				break;
			case "Dive Ball":
				data[131] = 7;
				break;
			case "Nest Ball":
				data[131] = 8;
				break;
			case "Repeat Ball":
				data[131] = 9;
				break;
			case "Timer Ball":
				data[131] = 10;
				break;
			case "Luxury Ball":
				data[131] = 11;
				break;
			case "Premier Ball":
				data[131] = 12;
				break;
			case "Dusk Ball":
				data[131] = 13;
				break;
			case "Heal Ball":
				data[131] = 14;
				break;
			case "Quick Ball":
				data[131] = 15;
				break;
			case "Cherish Ball":
				data[131] = 16;
				break;
			case "Fast Ball":
				data[131] = 17;
				break;
			case "Level Ball":
				data[131] = 18;
				break;
			case "Lure Ball":
				data[131] = 19;
				break;
			case "Heavy Ball":
				data[131] = 20;
				break;
			case "Love Ball":
				data[131] = 21;
				break;
			case "Sport Ball":
				data[131] = 24;
				break;
			case "Moon Ball":
				data[131] = 23;
				break;
			case "Friend Ball":
				data[131] = 22;
				break;
			case "Dream Ball":
				data[131] = 25;
				break;
			default:
				data[131] = 4;
				break;
			}
			data[133] = encounter;
			data[132] = (byte)(levelmet + genderot * 128);
			if (isParty)
			{
				if (level == 0)
				{
					level = 1;
				}
				updateStats();
			}
			updateSprite();
			checksumUpdate();
		}

		public void updateSprite()
		{
			no = (ushort)PkmLib.species.IndexOf(species);
			sprite = PkmLib.getSprite(no, form);
		}

		public void hiddenPower()
		{
			int num = iv.hp;
			int atk = iv.atk;
			int def = iv.def;
			int spe = iv.spe;
			int spa = iv.spa;
			int spd = iv.spd;
			int num2 = iv.hp;
			int atk2 = iv.atk;
			int def2 = iv.def;
			int spe2 = iv.spe;
			int spa2 = iv.spa;
			int spd2 = iv.spd;
			num = (((int)iv.hp % 2 != 0) ? 1 : 0);
			atk = (((int)iv.atk % 2 != 0) ? 1 : 0);
			def = (((int)iv.def % 2 != 0) ? 1 : 0);
			spe = (((int)iv.spe % 2 != 0) ? 1 : 0);
			spa = (((int)iv.spa % 2 != 0) ? 1 : 0);
			spd = (((int)iv.spd % 2 != 0) ? 1 : 0);
			num2 = ((!(((int)iv.hp % 4 == 0) | ((int)iv.hp % 4 == 1))) ? 1 : 0);
			atk2 = ((!(((int)iv.atk % 4 == 0) | ((int)iv.atk % 4 == 1))) ? 1 : 0);
			def2 = ((!(((int)iv.def % 4 == 0) | ((int)iv.def % 4 == 1))) ? 1 : 0);
			spe2 = ((!(((int)iv.spe % 4 == 0) | ((int)iv.spe % 4 == 1))) ? 1 : 0);
			spa2 = ((!(((int)iv.spa % 4 == 0) | ((int)iv.spa % 4 == 1))) ? 1 : 0);
			spd2 = ((!(((int)iv.spd % 4 == 0) | ((int)iv.spd % 4 == 1))) ? 1 : 0);
			atk *= 2;
			def *= 4;
			spe *= 8;
			spa *= 16;
			spd *= 32;
			double num3 = num + atk + def + spe + spa + spd;
			int num4 = 0;
			num3 *= 15.0;
			num3 /= 63.0;
			num4 = (int)Math.Floor(num3);
			string text = "";
			if (num4 == 0)
			{
				text = "Fighting";
			}
			if (num4 == 1)
			{
				text = "Flying";
			}
			if (num4 == 2)
			{
				text = "Poison";
			}
			if (num4 == 3)
			{
				text = "Ground";
			}
			if (num4 == 4)
			{
				text = "Rock";
			}
			if (num4 == 5)
			{
				text = "Bug";
			}
			if (num4 == 6)
			{
				text = "Ghost";
			}
			if (num4 == 7)
			{
				text = "Steel";
			}
			if (num4 == 8)
			{
				text = "Fire";
			}
			if (num4 == 9)
			{
				text = "Water";
			}
			if (num4 == 10)
			{
				text = "Grass";
			}
			if (num4 == 11)
			{
				text = "Electric";
			}
			if (num4 == 12)
			{
				text = "Psychic";
			}
			if (num4 == 13)
			{
				text = "Ice";
			}
			if (num4 == 14)
			{
				text = "Dragon";
			}
			if (num4 == 15)
			{
				text = "Dark";
			}
			hpType = text;
			double num5 = num2 + 2 * atk2 + 4 * def2 + 8 * spe2 + 16 * spa2 + 32 * spd2;
			num5 *= 40.0;
			num5 /= 63.0;
			num5 += 30.0;
			num5 = Math.Floor(num5);
			hpPower = (byte)num5;
		}

		public Pokemon Clone()
		{
			return MemberwiseClone() as Pokemon;
		}

		public byte[] getPC()
		{
			return Func.subArray(data, 0, 136);
		}

		public byte[] getEncrypted(bool party = true)
		{
			save();
			Pokemon pokemon = new Pokemon(data);
			pokemon.encrypt();
			if (party)
			{
				return pokemon.data;
			}
			return pokemon.getPC();
		}
	}
}
