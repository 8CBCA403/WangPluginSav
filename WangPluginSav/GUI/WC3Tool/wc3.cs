using System;
using System.Linq;
using System.Windows.Forms;
using PKHeX;

namespace WC3Tool;

public class wc3
{
	private static ushort[] lookup_table = new ushort[256]
	{
		0, 4489, 8978, 12955, 17956, 22445, 25910, 29887, 35912, 40385,
		44890, 48851, 51820, 56293, 59774, 63735, 4225, 264, 13203, 8730,
		22181, 18220, 30135, 25662, 40137, 36160, 49115, 44626, 56045, 52068,
		63999, 59510, 8450, 12427, 528, 5017, 26406, 30383, 17460, 21949,
		44362, 48323, 36440, 40913, 60270, 64231, 51324, 55797, 12675, 8202,
		4753, 792, 30631, 26158, 21685, 17724, 48587, 44098, 40665, 36688,
		64495, 60006, 55549, 51572, 16900, 21389, 24854, 28831, 1056, 5545,
		10034, 14011, 52812, 57285, 60766, 64727, 34920, 39393, 43898, 47859,
		21125, 17164, 29079, 24606, 5281, 1320, 14259, 9786, 57037, 53060,
		64991, 60502, 39145, 35168, 48123, 43634, 25350, 29327, 16404, 20893,
		9506, 13483, 1584, 6073, 61262, 65223, 52316, 56789, 43370, 47331,
		35448, 39921, 29575, 25102, 20629, 16668, 13731, 9258, 5809, 1848,
		65487, 60998, 56541, 52564, 47595, 43106, 39673, 35696, 33800, 38273,
		42778, 46739, 49708, 54181, 57662, 61623, 2112, 6601, 11090, 15067,
		20068, 24557, 28022, 31999, 38025, 34048, 47003, 42514, 53933, 49956,
		61887, 57398, 6337, 2376, 15315, 10842, 24293, 20332, 32247, 27774,
		42250, 46211, 34328, 38801, 58158, 62119, 49212, 53685, 10562, 14539,
		2640, 7129, 28518, 32495, 19572, 24061, 46475, 41986, 38553, 34576,
		62383, 57894, 53437, 49460, 14787, 10314, 6865, 2904, 32743, 28270,
		23797, 19836, 50700, 55173, 58654, 62615, 32808, 37281, 41786, 45747,
		19012, 23501, 26966, 30943, 3168, 7657, 12146, 16123, 54925, 50948,
		62879, 58390, 37033, 33056, 46011, 41522, 23237, 19276, 31191, 26718,
		7393, 3432, 16371, 11898, 59150, 63111, 50204, 54677, 41258, 45219,
		33336, 37809, 27462, 31439, 18516, 23005, 11618, 15595, 3696, 8185,
		63375, 58886, 54429, 50452, 45483, 40994, 37561, 33584, 31687, 27214,
		22741, 18780, 15843, 11370, 7921, 3960
	};

	private char[] SYMBOL = new char[256]
	{
		' ', 'À', 'Á', 'Â', 'Ç', 'È', 'É', 'Ê', 'Ë', 'Ì',
		'こ', 'Î', 'Ï', 'Ò', 'Ó', 'Ô', 'Œ', 'Ù', 'Ú', 'Û',
		'Ñ', 'ß', 'à', 'á', 'ね', 'ç', 'è', 'é', 'ê', 'ë',
		'ì', 'ま', 'î', 'ï', 'ò', 'ó', 'ô', 'œ', 'ù', 'ú',
		'û', 'ñ', 'º', 'ª', ' ', '&', '+', 'あ', 'ぃ', 'ぅ',
		'ぇ', 'ぉ', ' ', '=', ' ', ' ', ' ', ' ', ' ', ' ',
		' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',
		' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',
		' ', '¿', '¡', ' ', ' ', ' ', ' ', ' ', ' ', '<',
		'Í', '%', '(', ')', ' ', ' ', ' ', ' ', ' ', ' ',
		' ', ' ', ' ', ' ', 'â', ' ', ' ', ' ', ' ', ' ',
		' ', 'í', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',
		' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',
		' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',
		' ', ' ', ' ', ' ', 'ゾ', 'ダ', 'ヂ', 'ヅ', 'デ', 'ド',
		'バ', 'ビ', 'ブ', 'ベ', 'ボ', 'パ', 'ピ', 'プ', 'ペ', 'ポ',
		'ッ', '0', '1', '2', '3', '4', '5', '6', '7', '8',
		'9', '!', '?', '.', '-', '·', '…', '“', '”', '‘',
		'\'', '♂', '♀', '§', ',', '×', '/', 'A', 'B', 'C',
		'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
		'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W',
		'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g',
		'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
		'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '>',
		':', 'Ä', 'Ö', 'Ü', 'ä', 'ö', 'ü', ' ', ' ', ' ',
		' ', ' ', ' ', ' ', ' ', '#'
	};

	public const int SIZE_WC3 = 1420;

	public const int SIZE_WC3_jap = 1252;

	public const int ICON_WC3 = 346;

	public const int ICON_WC3_jap = 178;

	public const int SIZE_WN3 = 448;

	public const int SIZE_WN3_jap = 228;

	public const int WC_TEXT_START = 14;

	public const int WCN_TEXT_START = 8;

	public byte cardcolor;

	public int distributable;

	private int text_start;

	private int wc3_size;

	private int wn_size;

	public bool japanese;

	public byte[] Data;

	public bool Edited;

	public readonly bool Exportable;

	public readonly byte[] BAK;

	public string FileName;

	public string FilePath;

	public byte ID
	{
		get
		{
			return Data[wc3_size - 1000];
		}
		set
		{
			Data[wc3_size - 1000] = value;
		}
	}

	public byte MAP_BANK
	{
		get
		{
			return Data[wc3_size - 999];
		}
		set
		{
			Data[wc3_size - 999] = value;
		}
	}

	public byte MAP_MAP
	{
		get
		{
			return Data[wc3_size - 998];
		}
		set
		{
			Data[wc3_size - 998] = value;
		}
	}

	public byte MAP_NPC
	{
		get
		{
			return Data[wc3_size - 997];
		}
		set
		{
			Data[wc3_size - 997] = value;
		}
	}

	private static ushort swap(ushort value)
	{
		int num = value & 0xFF;
		int num2 = (value >> 8) & 0xFF;
		return (ushort)((num << 8) | num2);
	}

	public static ushort wc_checksum(byte[] buffer, int fSize, int offset)
	{
		ushort num = 4385;
		for (int i = 0; i < fSize; i++)
		{
			ushort num2 = (ushort)((uint)(num ^ buffer[i + offset]) & 0xFFu);
			num = (ushort)((uint)((ushort)(swap(lookup_table[num2]) & 0xFFFFu) ^ (num >> 8)) & 0xFFFFu);
		}
		return (ushort)((num ^ 0xFFFFu) & 0xFFFFu);
	}

	public wc3(byte[] data)
	{
		if (data.Length == 448 || data.Length == 228)
		{
			Data = (byte[])data.Clone();
			BAK = (byte[])Data.Clone();
			Exportable = !Data.SequenceEqual(new byte[Data.Length]);
			if (Data[6] == 1)
			{
				distributable = 1;
			}
			else
			{
				distributable = 0;
			}
			cardcolor = Data[7];
			text_start = 8;
			if (data.Length == 228)
			{
				japanese = true;
			}
			if (japanese)
			{
				wn_size = 228;
			}
			else
			{
				wn_size = 448;
			}
			return;
		}
		Data = (byte[])(data ?? new byte[data.Length]).Clone();
		BAK = (byte[])Data.Clone();
		Exportable = !Data.SequenceEqual(new byte[Data.Length]);
		if (data.Length == 1252)
		{
			japanese = true;
		}
		if (japanese)
		{
			wc3_size = 1252;
		}
		else
		{
			wc3_size = 1420;
		}
		if ((Data[12] & 0x80) == 128)
		{
			distributable = 1;
		}
		else if ((Data[12] & 0x40) == 64)
		{
			distributable = 2;
		}
		else
		{
			distributable = 0;
		}
		cardcolor = (byte)(Data[12] & 0xFFFFFF7Fu);
		text_start = 14;
	}

	public byte[] getData(int Offset, int Length)
	{
		return Data.Skip(Offset).Take(Length).ToArray();
	}

	public void setData(byte[] input, int Offset)
	{
		input.CopyTo(Data, Offset);
		Edited = true;
	}

	public string gba2text(byte[] input)
	{
		string text = "";
		foreach (byte b in input)
		{
			text += SYMBOL[b];
		}
		return text;
	}

	public byte[] text2gba(string input)
	{
		byte[] array = new byte[40];
		int num = 0;
		foreach (char c in input)
		{
			for (byte b = 0; b < byte.MaxValue; b = (byte)(b + 1))
			{
				if (c == SYMBOL[b])
				{
					if (b == 0)
					{
						array[num] = 0;
					}
					else
					{
						array[num] = b;
					}
					break;
				}
			}
			num++;
		}
		return array;
	}

	public ushort get_wc_icon()
	{
		if (japanese)
		{
			return BitConverter.ToUInt16(getData(178, 2), 0);
		}
		return BitConverter.ToUInt16(getData(346, 2), 0);
	}

	public int get_wc_color()
	{
		switch ((byte)(cardcolor & 0x1F))
		{
		case 0:
		case 1:
		case 2:
		case 3:
			return 0;
		case 4:
		case 5:
		case 6:
		case 7:
			return 1;
		case 8:
		case 9:
		case 10:
		case 11:
			return 2;
		case 12:
		case 13:
		case 14:
		case 15:
			return 3;
		case 16:
		case 17:
		case 18:
		case 19:
			return 4;
		case 20:
		case 21:
		case 22:
		case 23:
			return 5;
		case 24:
		case 25:
		case 26:
		case 27:
			return 6;
		case 28:
		case 29:
		case 30:
		case 31:
			return 7;
		default:
			return 0;
		}
	}

	public void set_wc_icon(int newicon)
	{
		if (japanese)
		{
			setData(BitConverter.GetBytes((ushort)newicon), 178);
		}
		else
		{
			setData(BitConverter.GetBytes((ushort)newicon), 346);
		}
	}

	public void set_wcn_color_distro(int color, int distro)
	{
		if (distro == 1)
		{
			Data[6] = 1;
		}
		if (distro == 2)
		{
			Data[6] = 2;
		}
		else
		{
			Data[6] = 0;
		}
		Data[7] = (byte)((uint)color & 0xFFu);
	}

	public void set_wc_color_distro(int color, int distro)
	{
		byte b = 0;
		b = color switch
		{
			0 => 0, 
			1 => 4, 
			2 => 8, 
			3 => 12, 
			4 => 16, 
			5 => 20, 
			6 => 24, 
			7 => 28, 
			_ => 0, 
		};
		switch (distro)
		{
		case 1:
			b = (byte)(b + 128);
			break;
		case 2:
			b = (byte)(b + 64);
			break;
		}
		Data[12] = b;
	}

	public string get_wc_text(int index)
	{
		return gba2text(Data.Skip(text_start + index * 40).Take(40).ToArray());
	}

	public string get_wc_text_2(int index)
	{
		int count = 40;
		int[] array = new int[8] { 0, 40, 80, 120, 160, 200, 240, 280 };
		if (japanese)
		{
			array[0] = 0;
			array[1] = 18;
			array[2] = 31;
			array[3] = 51;
			array[4] = 71;
			array[5] = 91;
			array[6] = 111;
			array[7] = 131;
			count = index switch
			{
				0 => 18, 
				1 => 13, 
				_ => 20, 
			};
		}
		return PKM.getG3Str(Data.Skip(text_start + array[index]).Take(count).ToArray(), japanese);
	}

	public void insert_wc_text(string text, int index)
	{
		setData(text2gba(text), text_start + index * 40);
	}

	public void insert_wc_text_2(string text, int index)
	{
		int[] array = new int[8] { 0, 40, 80, 120, 160, 200, 240, 280 };
		if (japanese)
		{
			array[0] = 0;
			array[1] = 18;
			array[2] = 31;
			array[3] = 51;
			array[4] = 71;
			array[5] = 91;
			array[6] = 111;
			array[7] = 131;
		}
		setData(PKM.setG3Str_WONDER(text, japanese), text_start + array[index]);
	}

	public void clear_wc_text()
	{
		if (japanese)
		{
			for (int i = 0; i < 151; i++)
			{
				Data[text_start + i] = 0;
			}
		}
		else
		{
			for (int i = 0; i < 320; i++)
			{
				Data[text_start + i] = 0;
			}
		}
	}

	public void clear_wn_text()
	{
		if (japanese)
		{
			for (int i = 0; i < 220; i++)
			{
				Data[text_start + i] = 0;
			}
		}
		else
		{
			for (int i = 0; i < 440; i++)
			{
				Data[text_start + i] = 0;
			}
		}
	}

	public string get_wn_text_2(int index)
	{
		int count = 40;
		int[] array = new int[11]
		{
			0, 40, 80, 120, 160, 200, 240, 280, 320, 360,
			400
		};
		if (japanese)
		{
			count = 20;
			for (int i = 0; i < 11; i++)
			{
				array[i] = 20 * i;
			}
		}
		return PKM.getG3Str(Data.Skip(text_start + array[index]).Take(count).ToArray(), japanese);
	}

	public void insert_wn_text_2(string text, int index)
	{
		int[] array = new int[11]
		{
			0, 40, 80, 120, 160, 200, 240, 280, 320, 360,
			400
		};
		if (japanese)
		{
			for (int i = 0; i < 11; i++)
			{
				array[i] = 20 * i;
			}
		}
		setData(PKM.setG3Str_WONDER(text, japanese), text_start + array[index]);
	}

	public void fakeWC()
	{
		uint value = 3116283066u;
		setData(BitConverter.GetBytes(value), 4);
	}

	public void fakeSCript()
	{
		uint value = 4294967091u;
		setData(BitConverter.GetBytes(value), wc3_size - 1000);
	}

	public void clean_trash()
	{
		for (int i = 0; i < 996 && Data[wc3_size - i - 1] != byte.MaxValue; i++)
		{
			Data[wc3_size - i - 1] = 0;
		}
	}

	public void fix_wcn_checksum()
	{
		ushort value = wc_checksum(getData(4, wn_size - 4), wn_size - 4, 0);
		setData(BitConverter.GetBytes(value), 0);
	}

	public void fix_wc_checksum()
	{
		ushort value = ((!japanese) ? wc_checksum(getData(4, 332), 332, 0) : wc_checksum(getData(4, 164), 164, 0));
		setData(BitConverter.GetBytes(value), 0);
	}

	public void fix_script_checksum()
	{
		ushort value = wc_checksum(getData(wc3_size - 1000, 1000), 1000, 0);
		setData(BitConverter.GetBytes(value), wc3_size - 1004);
	}

	public byte[] get_script()
	{
		int num = 0;
		return getData(wc3_size - 996, 996 - num);
	}

	public byte[] get_script_XSE()
	{
		uint num = BitConverter.ToUInt32(getData(wc3_size - 996 + 1, 4), 0);
		num -= num & 0xFF000000u;
		byte[] array = new byte[num + 996];
		if (num > 3)
		{
			BitConverter.GetBytes(num).CopyTo(array, 0);
		}
		MessageBox.Show("Open script in XSE at address 0x" + num.ToString("X"));
		getData(wc3_size - 996, 996).CopyTo(array, num);
		return array;
	}

	public void set_script(byte[] newscript)
	{
		int num = 0;
		for (num = 0; num < 996; num++)
		{
			Data[wc3_size - num - 1] = 0;
		}
		setData(newscript, wc3_size - 996);
	}

	public void set_script_XSE(byte[] newscript)
	{
		int num = 0;
		for (num = 0; num < 996; num++)
		{
			Data[wc3_size - num - 1] = 0;
		}
		uint count = BitConverter.ToUInt32(newscript, 0);
		setData(newscript.Skip((int)count).Take(996).ToArray(), wc3_size - 996);
	}
}
