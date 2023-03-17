using System;
using System.Linq;

namespace WC3Tool;

public class EVENT
{
	public static int event_size = 4;

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

	public ushort days_to_tv
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

	public EVENT(byte[] data)
	{
		Data = (byte[])(data ?? new byte[event_size]).Clone();
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
