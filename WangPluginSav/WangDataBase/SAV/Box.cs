using System;

namespace Pikaedit;

public class Box
{
	public string name;

	public byte wallpaper;

	public Pokemon[] pkmdata = new Pokemon[30];

	public Box()
	{
		for (int i = 0; i < 30; i++)
		{
			pkmdata[i] = new Pokemon();
			name = "";
			wallpaper = 0;
		}
	}

	public Box(Pokemon[] pkmdata)
	{
		this.pkmdata = pkmdata;
	}

	public Box(string name, byte wallpaper)
	{
		setProperties(name, wallpaper);
	}

	public void setProperties(string name, byte wallpaper)
	{
		this.name = name;
		this.wallpaper = wallpaper;
	}

	public int getCount()
	{
		int num = 0;
		for (int i = 0; i < 30; i++)
		{
			if (!pkmdata[i].isEmpty)
			{
				num++;
			}
		}
		return num;
	}

	public byte[] saveBoxFile()
	{
		byte[] array = new byte[4999];
		for (int i = 0; i < 30; i++)
		{
			Array.Copy(pkmdata[i].data, 0, array, i * 136, 136);
		}
		Array.Copy(Func.getfromString(name, 9), 0, array, 4980, 18);
		array[4998] = wallpaper;
		return array;
	}

	public void loadBoxFile(byte[] data)
	{
		byte[] array = new byte[136];
		for (int i = 0; i < 30; i++)
		{
			Array.Copy(data, i * 136, array, 0, 136);
			pkmdata[i] = new Pokemon(array);
		}
		name = Func.getString(data, 4980, 9);
		wallpaper = data[4998];
	}
}
