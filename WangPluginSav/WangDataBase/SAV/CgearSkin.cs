namespace Pikaedit;

public class CgearSkin
{
	public byte[] data = new byte[9728];

	public bool active;

	public readonly uint MAXLENGTH = 9728u;

	public CgearSkin()
	{
	}

	public CgearSkin(byte[] data, bool active = false)
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
