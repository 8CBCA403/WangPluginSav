namespace BerryPlot;

public static class Test3
{
	public static uint[] GetTiles(uint seed)
	{
		int num = 0;
		uint[] array = new uint[6];
		uint num2 = 0u;
		while (num < 6)
		{
			seed = 1103515245 * seed + 12345;
			num2 = (seed >> 16) % 447u;
			if (num2 == 0)
			{
				num2 = 447u;
			}
			if (num2 >= 4)
			{
				array[num] = num2;
				num++;
			}
		}
		return array;
	}

	public static bool IsAccessible(uint tile)
	{
		if (1 == 0)
		{
		}
		if (tile < 4 || tile > 447)
		{
			goto IL_0044;
		}
		if (tile <= 119)
		{
			if (tile == 105 || tile == 119)
			{
				goto IL_0044;
			}
		}
		else if (tile == 132 || tile == 144 || tile - 296 <= 2)
		{
			goto IL_0044;
		}
		bool result = true;
		goto IL_004c;
		IL_004c:
		if (1 == 0)
		{
		}
		return result;
		IL_0044:
		result = false;
		goto IL_004c;
	}

	public static bool IsUnderBridge(uint tile)
	{
		if (1 == 0)
		{
		}
		bool result = tile == 132;
		if (1 == 0)
		{
		}
		return result;
	}
}
