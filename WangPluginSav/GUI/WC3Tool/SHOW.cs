using System;
using System.Linq;

namespace WC3Tool;

public class SHOW
{
	public static int show_size = 36;

	public byte[] Data;

	public byte ID
	{
		get
		{
			return Data[0];
		}
		set
		{
			Data[0] = value;
		}
	}

	public byte status
	{
		get
		{
			return Data[1];
		}
		set
		{
			Data[1] = value;
		}
	}

	public ushort TID_own
	{
		get
		{
			return BitConverter.ToUInt16(getData(32, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 32);
		}
	}

	public ushort TID_mixed
	{
		get
		{
			return BitConverter.ToUInt16(getData(34, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 34);
		}
	}

	public ushort outbreak_move1
	{
		get
		{
			return BitConverter.ToUInt16(getData(4, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 4);
		}
	}

	public ushort outbreak_move2
	{
		get
		{
			return BitConverter.ToUInt16(getData(6, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 6);
		}
	}

	public ushort outbreak_move3
	{
		get
		{
			return BitConverter.ToUInt16(getData(8, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 8);
		}
	}

	public ushort outbreak_move4
	{
		get
		{
			return BitConverter.ToUInt16(getData(10, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 10);
		}
	}

	public ushort outbreak_species
	{
		get
		{
			return BitConverter.ToUInt16(getData(12, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 12);
		}
	}

	public ushort outbreak_map
	{
		get
		{
			return BitConverter.ToUInt16(getData(16, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 16);
		}
	}

	public byte outbreak_level
	{
		get
		{
			return Data[20];
		}
		set
		{
			Data[20] = value;
		}
	}

	public byte outbreak_appearance
	{
		get
		{
			return Data[19];
		}
		set
		{
			Data[19] = value;
		}
	}

	public ushort outbreak_days_to_tv
	{
		get
		{
			return BitConverter.ToUInt16(getData(22, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 22);
		}
	}

	public ushort outbreak_remaining_days
	{
		get
		{
			return BitConverter.ToUInt16(getData(24, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 24);
		}
	}

	public SHOW(byte[] data)
	{
		Data = (byte[])(data ?? new byte[show_size]).Clone();
	}

	public byte[] getData(int Offset, int Length)
	{
		return Data.Skip(Offset).Take(Length).ToArray();
	}

	public void setData(byte[] input, int Offset)
	{
		input.CopyTo(Data, Offset);
	}
}
