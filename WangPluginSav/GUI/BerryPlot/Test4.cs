namespace BerryPlot;

public static class Test4
{
	public static uint[] GetTiles(uint seed)
	{
		int i = 0;
		uint[] array = new uint[4];
		for (; i < 4; i++)
		{
			array[i] = (uint)(((seed >> 24 - 8 * i) & 0xFF) % 132u + 132 * i);
		}
		return array;
	}

	public static bool IsAccessible(uint tile)
	{
		if (1 == 0)
		{
		}
		bool result = tile <= 528;
		if (1 == 0)
		{
		}
		return result;
	}
}
