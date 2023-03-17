using System;
using System.Linq;
using System.Windows.Forms;

namespace WC3Tool;

public class ME3
{
	public int isemerald = -1;

	public byte[] Data;

	public bool Edited;

	public readonly bool Exportable;

	public readonly byte[] BAK;

	public string FileName;

	public string FilePath;

	private int me3_size;

	public byte MAP_BANK
	{
		get
		{
			return Data[5];
		}
		set
		{
			Data[5] = value;
		}
	}

	public byte MAP_MAP
	{
		get
		{
			return Data[6];
		}
		set
		{
			Data[6] = value;
		}
	}

	public byte MAP_PERSON
	{
		get
		{
			return Data[7];
		}
		set
		{
			Data[7] = value;
		}
	}

	public ME3(byte[] data, int size)
	{
		me3_size = size;
		Data = (byte[])(data ?? new byte[me3_size]).Clone();
		BAK = (byte[])Data.Clone();
		Exportable = !Data.SequenceEqual(new byte[Data.Length]);
		isEmerald();
	}

	public int isEmerald()
	{
		uint num = BitConverter.ToUInt32(getData(0, 4), 0);
		uint num2 = me3_checksum(getData(4, me3_size - 4 - 8), me3_size - 4 - 8);
		uint num3 = wc3.wc_checksum(getData(4, me3_size - 4 - 8), me3_size - 4 - 8, 0);
		if (num == num2)
		{
			isemerald = 0;
			return isemerald;
		}
		if (num == num3)
		{
			isemerald = 1;
			return isemerald;
		}
		switch (MessageBox.Show("ME3 file script has wrong checksum. Is this a Ruby/Sapphire mystery event?", "Wrong checksum", MessageBoxButtons.YesNo))
		{
		case DialogResult.Yes:
			isemerald = 0;
			break;
		case DialogResult.No:
			isemerald = 1;
			break;
		}
		return isemerald;
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

	public byte[] get_script()
	{
		int num = 0;
		int num2 = 0;
		for (num2 = 0; num2 < me3_size - 4 - 4 - 8 && Data[me3_size - 8 - num2 - 1] != byte.MaxValue; num2++)
		{
			num++;
		}
		return getData(8, 996 - num);
	}

	public byte[] get_script_XSE()
	{
		uint num = BitConverter.ToUInt32(getData(9, 4), 0);
		num -= num & 0xFF000000u;
		byte[] array = new byte[num + 996];
		if (num > 3)
		{
			BitConverter.GetBytes(num).CopyTo(array, 0);
		}
		MessageBox.Show("Open script in XSE at address 0x" + num.ToString("X"));
		getData(8, 996).CopyTo(array, num);
		return array;
	}

	public void set_script(byte[] newscript)
	{
		int num = 0;
		for (num = 8; num < 1004; num++)
		{
			Data[num] = 0;
		}
		uint value = 16844851u;
		setData(BitConverter.GetBytes(value).ToArray(), 4);
		setData(newscript, 8);
	}

	public void set_script_XSE(byte[] newscript)
	{
		int num = 0;
		for (num = 8; num < 1004; num++)
		{
			Data[num] = 0;
		}
		uint count = BitConverter.ToUInt32(newscript, 4);
		uint value = 16844851u;
		setData(BitConverter.GetBytes(value).ToArray(), 4);
		setData(newscript.Skip((int)count).ToArray(), 8);
	}

	public byte get_item_amount()
	{
		return getData(me3_size - 4, 1)[0];
	}

	public byte get_item_counter()
	{
		return getData(me3_size - 3, 1)[0];
	}

	public ushort get_item()
	{
		return BitConverter.ToUInt16(getData(me3_size - 2, 2), 0);
	}

	public void set_item_amount(byte amount)
	{
		Data[me3_size - 4] = amount;
	}

	public void set_item_counter(byte counter)
	{
		Data[me3_size - 3] = counter;
	}

	public void set_item(ushort item)
	{
		setData(BitConverter.GetBytes(item).ToArray(), me3_size - 2);
	}

	public static uint me3_checksum(byte[] buffer, int length)
	{
		int num = 0;
		uint num2 = 0u;
		for (num = 0; num < length; num++)
		{
			num2 += buffer[num];
		}
		return num2;
	}

	public void fix_me_item_checksum()
	{
		uint value = me3_checksum(getData(me3_size - 4, 4), 4);
		setData(BitConverter.GetBytes(value), me3_size - 8);
	}

	public void fix_me_script_checksum()
	{
		uint num = 0u;
		num = ((isemerald != 1) ? me3_checksum(getData(4, me3_size - 4 - 8), me3_size - 4 - 8) : wc3.wc_checksum(getData(4, me3_size - 4 - 8), me3_size - 4 - 8, 0));
		setData(BitConverter.GetBytes(num), 0);
	}

	private void fake_script()
	{
		if (Data[me3_size - 8] == 0)
		{
			Data[me3_size - 8] = byte.MaxValue;
		}
	}

	public bool has_script()
	{
		if (BitConverter.ToUInt32(Data, 4) != 0)
		{
			return true;
		}
		return false;
	}

	public void removeScript()
	{
		for (int i = 0; i < me3_size - 8; i++)
		{
			Data[i] = 0;
		}
	}
}
