using System;
using System.Linq;

namespace WC3Tool;

public class SWARM
{
	public static int swarm_size = 20;

	public byte[] Data;

	public ushort species
	{
		get
		{
			return BitConverter.ToUInt16(getData(0, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 0);
		}
	}

	public ushort map
	{
		get
		{
			return BitConverter.ToUInt16(getData(2, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 2);
		}
	}

	public byte level
	{
		get
		{
			return Data[4];
		}
		set
		{
			Data[4] = value;
		}
	}

	public ushort move1
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

	public ushort move2
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

	public ushort move3
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

	public ushort move4
	{
		get
		{
			return BitConverter.ToUInt16(getData(14, 2), 0);
		}
		set
		{
			setData(BitConverter.GetBytes(value), 14);
		}
	}

	public byte appearance
	{
		get
		{
			return Data[17];
		}
		set
		{
			Data[17] = value;
		}
	}

	public byte remaining_days
	{
		get
		{
			return Data[18];
		}
		set
		{
			Data[18] = value;
		}
	}

	public SWARM(byte[] data)
	{
		Data = (byte[])(data ?? new byte[swarm_size]).Clone();
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
