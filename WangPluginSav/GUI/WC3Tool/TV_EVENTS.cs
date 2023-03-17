using System.Linq;

namespace WC3Tool;

public class TV_EVENTS
{
	private int tv_event_size = 64;

	public byte[] Data;

	public EVENT[] events = new EVENT[16];

	public TV_EVENTS(byte[] data)
	{
		Data = (byte[])(data ?? new byte[tv_event_size]).Clone();
		load_events();
	}

	public byte[] getData(int Offset, int Length)
	{
		return Data.Skip(Offset).Take(Length).ToArray();
	}

	public void setData(byte[] input, int Offset)
	{
		input.CopyTo(Data, Offset);
	}

	public void load_events()
	{
		int num = 0;
		for (num = 0; num < 16; num++)
		{
			events[num] = new EVENT(getData(EVENT.event_size * num, EVENT.event_size));
		}
	}

	public void set_events()
	{
		int num = 0;
		for (num = 0; num < 16; num++)
		{
			setData(events[num].Data, EVENT.event_size * num);
		}
	}
}
