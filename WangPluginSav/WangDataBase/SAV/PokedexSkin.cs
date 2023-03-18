namespace Pikaedit;

public class PokedexSkin
{
	public byte[] data = new byte[25088];

	public bool active;

	public readonly uint MAXLENGTH = 25088u;

	public PokedexSkin()
	{
	}

	public PokedexSkin(byte[] data, bool active = false)
	{
		this.data = data;
		if (active)
		{
			this.active = !isEmpty();
		}
		else
		{
			this.active = active;
		}
	}

	public bool isEmpty()
	{
		for (int i = 0; i < data.Length; i++)
		{
			if (data[i] != byte.MaxValue)
			{
				return false;
			}
		}
		return true;
	}
}
