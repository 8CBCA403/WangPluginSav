using System.Linq;

namespace WC3Tool;

public class TV_SHOWS
{
	private int tv_size = 252;

	public byte[] Data;

	public SHOW[] shows = new SHOW[7];

	public TV_SHOWS(byte[] data)
	{
		Data = (byte[])(data ?? new byte[tv_size]).Clone();
		load_shows();
	}

	public byte[] getData(int Offset, int Length)
	{
		return Data.Skip(Offset).Take(Length).ToArray();
	}

	public void setData(byte[] input, int Offset)
	{
		input.CopyTo(Data, Offset);
	}

	public void load_shows()
	{
		int num = 0;
		for (num = 0; num < 7; num++)
		{
			shows[num] = new SHOW(getData(SHOW.show_size * num, SHOW.show_size));
		}
	}

	public void set_shows()
	{
		int num = 0;
		for (num = 0; num < 7; num++)
		{
			setData(shows[num].Data, SHOW.show_size * num);
		}
	}
}
