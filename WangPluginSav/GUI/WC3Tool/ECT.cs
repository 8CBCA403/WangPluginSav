using System;
using System.Linq;

namespace WC3Tool;

public class ECT
{
	public const int SIZE_ECT = 188;

	public byte[] Data;

	public bool Edited;

	public readonly bool Exportable;

	public readonly byte[] BAK;

	public string FileName;

	public string FilePath;

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

	public ECT(byte[] data)
	{
		Data = (byte[])(data ?? new byte[188]).Clone();
		BAK = (byte[])Data.Clone();
		Exportable = !Data.SequenceEqual(new byte[Data.Length]);
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

	public static uint ect_checksum(int length, byte[] Data)
	{
		uint num = 0u;
		length >>= 2;
		num = 0u;
		for (int i = 0; i < length; i++)
		{
			num += BitConverter.ToUInt32(Data, i * 4);
		}
		return num;
	}

	public void fix_ect_checksum()
	{
		uint value = ect_checksum(184, Data);
		setData(BitConverter.GetBytes(value).ToArray(), 184);
	}

	public string gba2text(byte[] input)
	{
		string text = "";
		foreach (byte b in input)
		{
			if (b == byte.MaxValue)
			{
				break;
			}
			text += SYMBOL[b];
		}
		return text;
	}

	public byte[] text2gba(string input, int len)
	{
		byte[] array = new byte[len];
		byte b = 0;
		int num = 0;
		foreach (char c in input)
		{
			for (b = 0; b < byte.MaxValue; b = (byte)(b + 1))
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
		if (num < len)
		{
			array[num] = byte.MaxValue;
		}
		return array;
	}
}
