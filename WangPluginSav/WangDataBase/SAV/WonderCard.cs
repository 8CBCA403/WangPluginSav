using System;

namespace Pikaedit;

public class WonderCard
{
	public enum CardType
	{
		None,
		Pokemon,
		Item,
		Power
	}

	public enum Ability
	{
		Ability_0,
		Ability_1,
		HA,
		Random,
		Random_HA
	}

	public enum Shininess
	{
		Never,
		Possible,
		Always
	}

	public enum OTGender
	{
		Male = 0,
		Female = 1,
		Game = 3
	}

	public enum Gender
	{
		Male,
		Female,
		Random_Genderless
	}

	public byte[] data = new byte[204];

	public string title
	{
		get
		{
			return Func.getString(data, 96, 37);
		}
		set
		{
			byte[] sourceArray = Func.getfromString(value, 37, allff: true);
			Array.Copy(sourceArray, 0, data, 96, 74);
		}
	}

	public ushort dateYear
	{
		get
		{
			return Func.getUInt16(data, 174);
		}
		set
		{
			Array.Copy(BitConverter.GetBytes(value), 0, data, 174, 2);
		}
	}

	public byte dateMonth
	{
		get
		{
			return data[173];
		}
		set
		{
			data[173] = value;
		}
	}

	public byte dateDay
	{
		get
		{
			return data[172];
		}
		set
		{
			data[172] = value;
		}
	}

	public ushort cardId
	{
		get
		{
			return Func.getUInt16(data, 176);
		}
		set
		{
			Array.Copy(BitConverter.GetBytes(value), 0, data, 176, 2);
		}
	}

	public byte cardLocation
	{
		get
		{
			return data[178];
		}
		set
		{
			data[178] = value;
		}
	}

	public CardType type
	{
		get
		{
			return data[179] switch
			{
				0 => CardType.None, 
				1 => CardType.Pokemon, 
				2 => CardType.Item, 
				3 => CardType.Power, 
				_ => CardType.None, 
			};
		}
		set
		{
			data[179] = (byte)value;
		}
	}

	public bool cardUsed
	{
		get
		{
			return data[180] == 3;
		}
		set
		{
			data[180] = (byte)((!value) ? 1 : 3);
		}
	}

	public bool staticPID => pid == 0;

	public uint pid
	{
		get
		{
			return Func.getUInt32(data, 8);
		}
		set
		{
			Array.Copy(BitConverter.GetBytes(value), 0, data, 8, 4);
		}
	}

	

	public string nickname
	{
		get
		{
			return Func.getString(data, 30, 11);
		}
		set
		{
			byte[] sourceArray = Func.getfromString(value, 11, allff: true);
			Array.Copy(sourceArray, 0, data, 96, 22);
		}
	}

	public bool isNicknamed => !string.IsNullOrEmpty(nickname);

	public string language
	{
		get
		{
			return data[28] switch
			{
				0 => "Game received", 
				1 => "Japan", 
				2 => "English", 
				3 => "French", 
				4 => "Italian", 
				5 => "German", 
				7 => "Spanish", 
				8 => "Korean", 
				_ => "Game received", 
			};
		}
		set
		{
			if (value == "Game received")
			{
				data[28] = 0;
			}
			else
			{
				data[28] = Convert.ToByte((PkmLib.Languages)Enum.Parse(typeof(PkmLib.Languages), value));
			}
		}
	}

	public Ability ability
	{
		get
		{
			return (Ability)data[54];
		}
		set
		{
			data[54] = (byte)value;
		}
	}

	public OTGender otGender
	{
		get
		{
			return (OTGender)data[90];
		}
		set
		{
			data[90] = (byte)value;
		}
	}

	public Gender gender
	{
		get
		{
			return (Gender)data[53];
		}
		set
		{
			data[53] = (byte)value;
		}
	}

	public string nature
	{
		get
		{
			if (data[52] == byte.MaxValue)
			{
				return "Random";
			}
			return PkmLib.abilities[data[52]];
		}
		set
		{
			if (value == "Random")
			{
				data[52] = byte.MaxValue;
			}
			else
			{
				data[52] = (byte)PkmLib.abilities.IndexOf(value);
			}
		}
	}

	public Shininess isShiny
	{
		get
		{
			return (Shininess)data[55];
		}
		set
		{
			data[55] = (byte)value;
		}
	}

	

	public string species
	{
		get
		{
			return PkmLib.species[BitConverter.ToUInt16(data, 26)];
		}
		set
		{
			Array.Copy(BitConverter.GetBytes((ushort)PkmLib.species.IndexOf(value)), 0, data, 26, 2);
		}
	}

	public string pkmItem
	{
		get
		{
			return PkmLib.items[BitConverter.ToUInt16(data, 16)];
		}
		set
		{
			Array.Copy(BitConverter.GetBytes((ushort)PkmLib.items.IndexOf(value)), 0, data, 16, 2);
		}
	}

	public string form
	{
		get
		{
			return PkmLib.getFormFromValue(species, data[28]);
		}
		set
		{
			data[28] = PkmLib.getFormValue(species, value);
		}
	}

	public string pokeball
	{
		get
		{
			return PkmLib.pokeballs[data[14]];
		}
		set
		{
			data[14] = (byte)PkmLib.pokeballs.IndexOf(value);
		}
	}

	public string ot
	{
		get
		{
			return Func.getString(data, 74, 8);
		}
		set
		{
			byte[] sourceArray = Func.getfromString(value, 8, allff: true);
			Array.Copy(sourceArray, 0, data, 74, 16);
		}
	}

	public byte level
	{
		get
		{
			return data[91];
		}
		set
		{
			data[91] = value;
			data[60] = value;
		}
	}

	

	public string locationHatched
	{
		get
		{
			return PkmLib.locations[PkmLib.locationValues.IndexOf(BitConverter.ToUInt16(data, 56))];
		}
		set
		{
			Array.Copy(BitConverter.GetBytes(PkmLib.locationValues[PkmLib.locations.IndexOf(value)]), 0, data, 56, 2);
		}
	}

	public string locationMet
	{
		get
		{
			return PkmLib.locations[PkmLib.locationValues.IndexOf(BitConverter.ToUInt16(data, 58))];
		}
		set
		{
			Array.Copy(BitConverter.GetBytes(PkmLib.locationValues[PkmLib.locations.IndexOf(value)]), 0, data, 58, 2);
		}
	}

	public bool isEgg
	{
		get
		{
			return data[92] == 1;
		}
		set
		{
			data[92] = (byte)(value ? 1 : 0);
		}
	}

	public string version
	{
		get
		{
			return data[4] switch
			{
				0 => "Game received", 
				1 => "Ruby", 
				2 => "Sapphire", 
				3 => "Emerald", 
				4 => "Fire Red", 
				5 => "Leaf Green", 
				7 => "Heart Gold", 
				8 => "Soul Silver", 
				10 => "Diamond", 
				11 => "Pearl", 
				12 => "Platinum", 
				15 => "Colosseum/XD", 
				20 => "White", 
				21 => "Black", 
				22 => "White 2", 
				23 => "Black 2", 
				24 => "X", 
				25 => "Y", 
				_ => "Game received", 
			};
		}
		set
		{
			switch (value)
			{
			case "Game received":
				data[4] = 0;
				break;
			case "Ruby":
				data[4] = 1;
				break;
			case "Sapphire":
				data[4] = 2;
				break;
			case "Emerald":
				data[4] = 3;
				break;
			case "Fire Red":
				data[4] = 4;
				break;
			case "Leaf Green":
				data[4] = 5;
				break;
			case "Heart Gold":
				data[4] = 7;
				break;
			case "Soul Silver":
				data[4] = 8;
				break;
			case "Diamond":
				data[4] = 10;
				break;
			case "Pearl":
				data[4] = 11;
				break;
			case "Platinum":
				data[4] = 12;
				break;
			case "Colosseum/XD":
				data[4] = 15;
				break;
			case "White":
				data[4] = 20;
				break;
			case "Black":
				data[4] = 21;
				break;
			case "White 2":
				data[4] = 22;
				break;
			case "Black 2":
				data[4] = 23;
				break;
			case "X":
				data[4] = 24;
				break;
			case "Y":
				data[4] = 25;
				break;
			default:
				data[4] = 0;
				break;
			}
		}
	}

	public ushort sid
	{
		get
		{
			return Func.getUInt16(data, 2);
		}
		set
		{
			Array.Copy(BitConverter.GetBytes(value), 0, data, 2, 2);
		}
	}

	public ushort id
	{
		get
		{
			return Func.getUInt16(data);
		}
		set
		{
			Array.Copy(BitConverter.GetBytes(value), 0, data, 0, 2);
		}
	}

	public string cardItem
	{
		get
		{
			return PkmLib.items[id];
		}
		set
		{
			Array.Copy(BitConverter.GetBytes((ushort)PkmLib.items.IndexOf(value)), 0, data, 0, 2);
		}
	}

	public string cardPower
	{
		get
		{
			return PkmLib.passPowers[id];
		}
		set
		{
			Array.Copy(BitConverter.GetBytes((ushort)PkmLib.passPowers.IndexOf(value)), 0, data, 0, 2);
		}
	}

	public bool isEmpty
	{
		get
		{
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] != 0)
				{
					return false;
				}
			}
			return true;
		}
	}

	public WonderCard()
	{
		data = new byte[204];
	}

	public WonderCard(byte[] data)
	{
		this.data = data;
	}

	public string[] getLog()
	{
		return type switch
		{
			CardType.Pokemon => new string[10]
			{
				"Wonder Card contains Pokemon data:",
				species,
				"Level: " + ((level == 0) ? "Random" : Convert.ToString(level)),
				"Item: " + pkmItem,
				"Nature: " + nature,
				"ID/SID " + id + "/" + sid,
				"Version: " + version,
				"OT: " + ot,
				"Location " + locationMet,
				cardUsed ? "This Wonder Card has been used" : "This Wonder Card hasn't been used"
			}, 
			CardType.Item => new string[2]
			{
				"Wonder Card contains Item data:",
				"Item to be delivered: " + cardItem
			}, 
			CardType.Power => new string[2]
			{
				"Wonder Card contains Pass Power data:",
				"Pass Power to be delivered: " + cardPower
			}, 
			_ => new string[1] { "Empty Slot" }, 
		};
	}
}
