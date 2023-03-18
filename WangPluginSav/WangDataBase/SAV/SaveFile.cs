using System;
using System.Collections.Generic;
using System.IO;

namespace Pikaedit;

public class SaveFile
{
	public enum Version
	{
		BW = 0,
		BW2 = 1,
		Unknown = 100
	}

	public enum FileExtension
	{
		SAV,
		DSV
	}

	private string filename;

	public FileExtension extension;

	public byte[] data;

	public Pokemon[] party = new Pokemon[6];

	public Box[] boxes = new Box[24];

	public Pokemon[] battleBox = new Pokemon[6];

	public DayCarePKM daycare;

	public TrainerInfo trainer;

	public Pokemon fused;

	public Version version;

	private uint wcSeed;

	public WonderCard[] wonderCards = new WonderCard[12];

	public CgearSkin cgearSkin;

	public PokedexSkin pokedexSkin;

	public Musical musical;

	private FileStream fs;

	private BinaryReader br;

	private BinaryWriter bw;

	private uint seed;

	private void srand(uint newSeed)
	{
		seed = newSeed;
	}

	private uint rand()
	{
		seed = (1103515245 * seed + 24691) & 0xFFFFFFFFu;
		return seed >> 16;
	}

	private uint prand()
	{
		seed = (uint)((int)seed * -289805467 + 171270561) & 0xFFFFFFFFu;
		return seed >> 16;
	}

	public ushort GetCheckSum(byte[] data)
	{
		int num = 65535;
		for (int i = 0; i < data.Length; i++)
		{
			num = (num << 8) ^ Func.SeedTable[(byte)(data[i] ^ (byte)(num >> 8))];
		}
		return (ushort)num;
	}

	public SaveFile()
	{
		filename = "";
		data = null;
		for (int i = 0; i < 24; i++)
		{
			boxes[i] = new Box();
		}
		for (int j = 0; j < 6; j++)
		{
			party[j] = new Pokemon();
		}
		version = Version.Unknown;
		for (int k = 0; k < 12; k++)
		{
			wonderCards[k] = new WonderCard();
		}
	}

	public SaveFile(string filename)
	{
		this.filename = filename;
		data = File.ReadAllBytes(filename);
		if (Path.GetExtension(filename) == ".dsv")
		{
			extension = FileExtension.DSV;
		}
		else
		{
			extension = FileExtension.SAV;
		}
		Initialize();
	}

	public SaveFile(byte[] data)
	{
		this.data = data;
		File.WriteAllBytes("temp.sav", data);
		filename = "temp.sav";
		extension = FileExtension.SAV;
		Initialize();
	}

	private void Initialize()
	{
		fs = new FileStream(filename, FileMode.Open);
		br = new BinaryReader(fs);
		determineVersion();
		extractParty();
		for (int i = 0; i < 24; i++)
		{
			fs.Seek(1024 + 4096 * i, SeekOrigin.Begin);
			boxes[i] = new Box();
			for (int j = 0; j < 30; j++)
			{
				boxes[i].pkmdata[j] = new Pokemon(br.ReadBytes(136));
			}
		}
		for (int k = 0; k < 24; k++)
		{
			fs.Seek(4 + k * 40, SeekOrigin.Begin);
			boxes[k].name = Func.getString(br.ReadBytes(18), 0, 9);
		}
		fs.Seek(964L, SeekOrigin.Begin);
		for (int l = 0; l < 24; l++)
		{
			boxes[l].wallpaper = br.ReadByte();
		}
		extractBattleBox();
		daycare = extractDayCare();
		trainer = extractTrainerData();
		if (version == Version.BW2)
		{
			fs.Seek(129540L, SeekOrigin.Begin);
			fused = new Pokemon(br.ReadBytes(220), decriptData: true);
		}
		else
		{
			fused = new Pokemon();
		}
		extractWonderCards();
		extractDLC();
		br.Close();
		fs.Close();
	}

	private void determineVersion()
	{
		byte[] arr = Func.subArray(data, 155554, 2);
		byte[] array = Func.subArray(data, 155392, 148);
		if (Func.getUInt16(arr) == GetCheckSum(array))
		{
			version = Version.BW2;
		}
		else
		{
			version = Version.BW;
		}
	}

	private void extractParty()
	{
		fs.Seek(101896L, SeekOrigin.Begin);
		for (int i = 0; i < 6; i++)
		{
			party[i] = new Pokemon(br.ReadBytes(220));
		}
	}

	private void extractBattleBox()
	{
		if (version == Version.BW2)
		{
			fs.Seek(133376L, SeekOrigin.Begin);
		}
		else
		{
			fs.Seek(133632L, SeekOrigin.Begin);
		}
		for (int i = 0; i < 6; i++)
		{
			battleBox[i] = new Pokemon(br.ReadBytes(136), decriptData: true);
		}
	}

	private DayCarePKM extractDayCare()
	{
		switch (version)
		{
		case Version.BW2:
			fs.Seek(134404L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(134660L, SeekOrigin.Begin);
			break;
		}
		Pokemon pkm = new Pokemon(br.ReadBytes(220));
		switch (version)
		{
		case Version.BW2:
			fs.Seek(134632L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(134888L, SeekOrigin.Begin);
			break;
		}
		Pokemon pkm2 = new Pokemon(br.ReadBytes(220));
		switch (version)
		{
		case Version.BW2:
			fs.Seek(134856L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(135112L, SeekOrigin.Begin);
			break;
		}
		return new DayCarePKM(pkm, pkm2, br.ReadByte());
	}

	private TrainerInfo extractTrainerData()
	{
		string text = "";
		ushort num = 1;
		ushort num2 = 0;
		uint num3 = 0u;
		byte b = 0;
		byte b2 = 0;
		fs.Seek(103428L, SeekOrigin.Begin);
		text = Func.getString(br.ReadBytes(16), 0, 8);
		num = br.ReadUInt16();
		num2 = br.ReadUInt16();
		switch (version)
		{
		case Version.BW2:
			fs.Seek(135424L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(135680L, SeekOrigin.Begin);
			break;
		}
		num3 = br.ReadUInt32();
		fs.Seek(103457L, SeekOrigin.Begin);
		b = br.ReadByte();
		switch (version)
		{
		case Version.BW2:
			fs.Seek(135428L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(135684L, SeekOrigin.Begin);
			break;
		}
		b2 = br.ReadByte();
		fs.Seek(103460L, SeekOrigin.Begin);
		return new TrainerInfo(text, num, num2, num3, b, b2, br.ReadUInt16(), br.ReadByte(), br.ReadByte());
	}

	private void extractWonderCards()
	{
		fs.Seek(119440L, SeekOrigin.Begin);
		wcSeed = br.ReadUInt32();
		fs.Seek(116736L, SeekOrigin.Begin);
		srand(wcSeed);
		ushort[] array = new ushort[1352];
		for (int i = 0; i < 1352; i++)
		{
			array[i] = (ushort)(br.ReadUInt16() ^ rand());
		}
		byte[] arr = Func.convertToByteArray(Func.ushortSubArray(array, 128, 1224));
		for (int j = 0; j < 12; j++)
		{
			wonderCards[j] = new WonderCard(Func.subArray(arr, j * 204, 204));
		}
	}

	private void extractDLC()
	{
		switch (version)
		{
		case Version.BW2:
			fs.Seek(337920L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(335872L, SeekOrigin.Begin);
			break;
		}
		byte[] array = br.ReadBytes(9728);
		switch (version)
		{
		case Version.BW2:
			fs.Seek(347650L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(345602L, SeekOrigin.Begin);
			break;
		}
		ushort num = br.ReadUInt16();
		switch (version)
		{
		case Version.BW2:
			fs.Seek(114740L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(114724L, SeekOrigin.Begin);
			break;
		}
		ushort num2 = br.ReadUInt16();
		cgearSkin = new CgearSkin(array, num == num2);
		array = null;
		switch (version)
		{
		case Version.BW2:
			fs.Seek(448512L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(483328L, SeekOrigin.Begin);
			break;
		}
		array = br.ReadBytes(25088);
		switch (version)
		{
		case Version.BW2:
			fs.Seek(103486L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(103486L, SeekOrigin.Begin);
			break;
		}
		num = br.ReadUInt16();
		pokedexSkin = new PokedexSkin(array, num == 49694);
		array = null;
		switch (version)
		{
		case Version.BW2:
			fs.Seek(350208L, SeekOrigin.Begin);
			array = br.ReadBytes(97280);
			break;
		case Version.BW:
			fs.Seek(352256L, SeekOrigin.Begin);
			array = br.ReadBytes(130048);
			break;
		}
		fs.Seek(103484L, SeekOrigin.Begin);
		num = br.ReadUInt16();
		fs.Seek(129288L, SeekOrigin.Begin);
		byte[] arr = br.ReadBytes(28);
		musical = new Musical(array, version, num == 49694);
		musical.title = Func.getString(arr, 0, 14);
	}

	public void save(string filename, byte type = 0)
	{
		Dictionary<string, ushort> dictionary = new Dictionary<string, ushort>();
		if (extension == FileExtension.SAV)
		{
			if (type == 0)
			{
				File.WriteAllBytes(filename, data);
			}
			else
			{
				File.WriteAllBytes(filename, Func.mergeArray(data, PkmLib.dsvfooter));
			}
		}
		else if (type == 0)
		{
			File.WriteAllBytes(filename, Func.subArray(data, 0, 524288));
		}
		else
		{
			File.WriteAllBytes(filename, data);
		}
		fs = new FileStream(filename, FileMode.Open);
		bw = new BinaryWriter(fs);
		br = new BinaryReader(fs);
		for (int i = 0; i < 24; i++)
		{
			fs.Seek(1024 + 4096 * i, SeekOrigin.Begin);
			for (int j = 0; j < 30; j++)
			{
				bw.Write(boxes[i].pkmdata[j].getEncrypted(party: false));
			}
		}
		for (int k = 0; k < 24; k++)
		{
			fs.Seek(1024 + 4096 * k, SeekOrigin.Begin);
			dictionary.Add("box" + k, GetCheckSum(br.ReadBytes(4080)));
			fs.Seek(1024 + 4096 * k + 4082, SeekOrigin.Begin);
			bw.Write(dictionary["box" + k]);
		}
		fs.Seek(101896L, SeekOrigin.Begin);
		byte b = 0;
		for (int l = 0; l < 6; l++)
		{
			if (!party[l].isEmpty)
			{
				b = (byte)(b + 1);
			}
			bw.Write(party[l].getEncrypted());
		}
		fs.Seek(101892L, SeekOrigin.Begin);
		bw.Write(b);
		fs.Seek(101888L, SeekOrigin.Begin);
		dictionary.Add("party", GetCheckSum(br.ReadBytes(1332)));
		fs.Seek(103222L, SeekOrigin.Begin);
		bw.Write(dictionary["party"]);
		switch (version)
		{
		case Version.BW2:
			fs.Seek(134400L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(134656L, SeekOrigin.Begin);
			break;
		}
		bw.Write((byte)((!daycare.pkmdata[0].isEmpty) ? 1 : 0));
		switch (version)
		{
		case Version.BW2:
			fs.Seek(134404L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(134660L, SeekOrigin.Begin);
			break;
		}
		bw.Write(daycare.pkmdata[0].getEncrypted());
		switch (version)
		{
		case Version.BW2:
			fs.Seek(134628L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(134884L, SeekOrigin.Begin);
			break;
		}
		bw.Write((byte)((!daycare.pkmdata[1].isEmpty) ? 1 : 0));
		switch (version)
		{
		case Version.BW2:
			fs.Seek(134632L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(134888L, SeekOrigin.Begin);
			break;
		}
		bw.Write(daycare.pkmdata[1].getEncrypted());
		switch (version)
		{
		case Version.BW2:
			fs.Seek(134856L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(135112L, SeekOrigin.Begin);
			break;
		}
		bw.Write(daycare.getEggByte());
		switch (version)
		{
		case Version.BW2:
			fs.Seek(134400L, SeekOrigin.Begin);
			dictionary.Add("daycare", GetCheckSum(br.ReadBytes(468)));
			fs.Seek(134870L, SeekOrigin.Begin);
			bw.Write(dictionary["daycare"]);
			break;
		case Version.BW:
			fs.Seek(134656L, SeekOrigin.Begin);
			dictionary.Add("daycare", GetCheckSum(br.ReadBytes(460)));
			fs.Seek(135118L, SeekOrigin.Begin);
			bw.Write(dictionary["daycare"]);
			break;
		}
		fs.Seek(103428L, SeekOrigin.Begin);
		byte[] buffer = Func.getfromString(trainer.name, trainer.NAMEMAXLENGTH + 1);
		bw.Write(buffer);
		bw.Write(trainer.id);
		bw.Write(trainer.sid);
		switch (version)
		{
		case Version.BW2:
			fs.Seek(135424L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(135680L, SeekOrigin.Begin);
			break;
		}
		bw.Write(trainer.money);
		fs.Seek(103457L, SeekOrigin.Begin);
		bw.Write(trainer.getGenderByte());
		switch (version)
		{
		case Version.BW2:
			fs.Seek(135428L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(135684L, SeekOrigin.Begin);
			break;
		}
		bw.Write(trainer.badges);
		fs.Seek(103460L, SeekOrigin.Begin);
		bw.Write(trainer.playHours);
		bw.Write(trainer.playMin);
		bw.Write(trainer.playSec);
		fs.Seek(114944L, SeekOrigin.Begin);
		dictionary.Add("card", GetCheckSum(br.ReadBytes(1624)));
		fs.Seek(116570L, SeekOrigin.Begin);
		bw.Write(dictionary["card"]);
		switch (version)
		{
		case Version.BW2:
			fs.Seek(337920L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(335872L, SeekOrigin.Begin);
			break;
		}
		bw.Write(cgearSkin.data);
		if (!cgearSkin.isEmpty())
		{
			switch (version)
			{
			case Version.BW2:
				fs.Seek(337920L, SeekOrigin.Begin);
				break;
			case Version.BW:
				fs.Seek(335872L, SeekOrigin.Begin);
				break;
			}
			dictionary.Add("cgearSkin", GetCheckSum(br.ReadBytes(9728)));
			switch (version)
			{
			case Version.BW2:
				fs.Seek(347650L, SeekOrigin.Begin);
				break;
			case Version.BW:
				fs.Seek(345602L, SeekOrigin.Begin);
				break;
			}
			bw.Write(dictionary["cgearSkin"]);
			if (cgearSkin.active)
			{
				fs.Seek(103480L, SeekOrigin.Begin);
				bw.Write((ushort)49694);
				switch (version)
				{
				case Version.BW2:
					fs.Seek(103532L, SeekOrigin.Begin);
					bw.Write((byte)1);
					fs.Seek(114740L, SeekOrigin.Begin);
					bw.Write(dictionary["cgearSkin"]);
					bw.Write((byte)1);
					fs.Seek(347904L, SeekOrigin.Begin);
					bw.Write(dictionary["cgearSkin"]);
					bw.Write(PkmLib.cgearfooter);
					fs.Seek(347904L, SeekOrigin.Begin);
					dictionary.Add("cgearDLC", GetCheckSum(br.ReadBytes(4)));
					fs.Seek(347922L, SeekOrigin.Begin);
					bw.Write(dictionary["cgearDLC"]);
					break;
				case Version.BW:
					fs.Seek(103508L, SeekOrigin.Begin);
					bw.Write((byte)1);
					fs.Seek(114724L, SeekOrigin.Begin);
					bw.Write(dictionary["cgearSkin"]);
					bw.Write((byte)1);
					fs.Seek(345856L, SeekOrigin.Begin);
					bw.Write(dictionary["cgearSkin"]);
					bw.Write(PkmLib.cgearfooter);
					fs.Seek(345856L, SeekOrigin.Begin);
					dictionary.Add("cgearDLC", GetCheckSum(br.ReadBytes(4)));
					fs.Seek(345874L, SeekOrigin.Begin);
					bw.Write(dictionary["cgearDLC"]);
					break;
				}
			}
		}
		switch (version)
		{
		case Version.BW2:
			fs.Seek(448512L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(483328L, SeekOrigin.Begin);
			break;
		}
		bw.Write(pokedexSkin.data);
		bw.Write(1u);
		if (!pokedexSkin.isEmpty())
		{
			switch (version)
			{
			case Version.BW2:
				fs.Seek(448512L, SeekOrigin.Begin);
				break;
			case Version.BW:
				fs.Seek(483328L, SeekOrigin.Begin);
				break;
			}
			dictionary.Add("pokedexSkin", GetCheckSum(br.ReadBytes(25092)));
			switch (version)
			{
			case Version.BW2:
				fs.Seek(473606L, SeekOrigin.Begin);
				break;
			case Version.BW:
				fs.Seek(508422L, SeekOrigin.Begin);
				break;
			}
			bw.Write(dictionary["pokedexSkin"]);
			if (pokedexSkin.active)
			{
				fs.Seek(103486L, SeekOrigin.Begin);
				bw.Write((ushort)49694);
				switch (version)
				{
				case Version.BW2:
					fs.Seek(103544L, SeekOrigin.Begin);
					bw.Write((byte)1);
					fs.Seek(473856L, SeekOrigin.Begin);
					bw.Write(dictionary["pokedexSkin"]);
					bw.Write(PkmLib.pokedexfooter);
					fs.Seek(473856L, SeekOrigin.Begin);
					dictionary.Add("pokedexDLC", GetCheckSum(br.ReadBytes(4)));
					fs.Seek(473874L, SeekOrigin.Begin);
					bw.Write(dictionary["pokedexDLC"]);
					break;
				case Version.BW:
					fs.Seek(103520L, SeekOrigin.Begin);
					bw.Write((byte)1);
					fs.Seek(114728L, SeekOrigin.Begin);
					bw.Write((byte)4);
					bw.Write((byte)1);
					fs.Seek(508672L, SeekOrigin.Begin);
					bw.Write(dictionary["pokedexSkin"]);
					bw.Write(PkmLib.pokedexfooter);
					fs.Seek(508672L, SeekOrigin.Begin);
					dictionary.Add("pokedexDLC", GetCheckSum(br.ReadBytes(4)));
					fs.Seek(508690L, SeekOrigin.Begin);
					bw.Write(dictionary["pokedexDLC"]);
					break;
				}
			}
		}
		switch (version)
		{
		case Version.BW2:
			fs.Seek(350208L, SeekOrigin.Begin);
			break;
		case Version.BW:
			fs.Seek(352256L, SeekOrigin.Begin);
			break;
		}
		bw.Write(musical.getData(version));
		bw.Write((ushort)2);
		if (!musical.isEmpty())
		{
			switch (version)
			{
			case Version.BW2:
				fs.Seek(350208L, SeekOrigin.Begin);
				dictionary.Add("musical", GetCheckSum(br.ReadBytes(97280)));
				fs.Seek(447490L, SeekOrigin.Begin);
				bw.Write(dictionary["musical"]);
				break;
			case Version.BW:
				fs.Seek(352256L, SeekOrigin.Begin);
				dictionary.Add("musical", GetCheckSum(br.ReadBytes(130048)));
				fs.Seek(482306L, SeekOrigin.Begin);
				bw.Write(dictionary["musical"]);
				break;
			}
			if (musical.active)
			{
				fs.Seek(103484L, SeekOrigin.Begin);
				bw.Write((ushort)49694);
				switch (version)
				{
				case Version.BW2:
					fs.Seek(103540L, SeekOrigin.Begin);
					bw.Write((byte)3);
					fs.Seek(129288L, SeekOrigin.Begin);
					bw.Write(Func.getfromString(musical.title, 20));
					fs.Seek(129438L, SeekOrigin.Begin);
					bw.Write((byte)1);
					fs.Seek(447744L, SeekOrigin.Begin);
					bw.Write(dictionary["musical"]);
					bw.Write(PkmLib.musicalbw2footer);
					fs.Seek(447744L, SeekOrigin.Begin);
					dictionary.Add("musicalDLC", GetCheckSum(br.ReadBytes(4)));
					fs.Seek(447762L, SeekOrigin.Begin);
					bw.Write(dictionary["musicalDLC"]);
					break;
				case Version.BW:
					fs.Seek(103516L, SeekOrigin.Begin);
					bw.Write((byte)4);
					fs.Seek(129288L, SeekOrigin.Begin);
					bw.Write(Func.getfromString(musical.title, 20));
					fs.Seek(129438L, SeekOrigin.Begin);
					bw.Write((byte)1);
					fs.Seek(482560L, SeekOrigin.Begin);
					bw.Write(dictionary["musical"]);
					bw.Write(PkmLib.musicalbwfooter);
					fs.Seek(482560L, SeekOrigin.Begin);
					dictionary.Add("musicalDLC", GetCheckSum(br.ReadBytes(4)));
					fs.Seek(482578L, SeekOrigin.Begin);
					bw.Write(dictionary["musicalDLC"]);
					break;
				}
			}
		}
		fs.Seek(128768L, SeekOrigin.Begin);
		dictionary.Add("musicalData", GetCheckSum(br.ReadBytes(676)));
		fs.Seek(129446L, SeekOrigin.Begin);
		bw.Write(dictionary["musicalData"]);
		fs.Seek(114688L, SeekOrigin.Begin);
		switch (version)
		{
		case Version.BW2:
			dictionary.Add("cgear", GetCheckSum(br.ReadBytes(148)));
			fs.Seek(114838L, SeekOrigin.Begin);
			bw.Write(dictionary["cgear"]);
			break;
		case Version.BW:
			dictionary.Add("cgear", GetCheckSum(br.ReadBytes(44)));
			fs.Seek(114734L, SeekOrigin.Begin);
			bw.Write(dictionary["cgear"]);
			break;
		}
		fs.Seek(103424L, SeekOrigin.Begin);
		switch (version)
		{
		case Version.BW2:
			dictionary.Add("trainer", GetCheckSum(br.ReadBytes(176)));
			fs.Seek(103602L, SeekOrigin.Begin);
			bw.Write(dictionary["trainer"]);
			break;
		case Version.BW:
			dictionary.Add("trainer", GetCheckSum(br.ReadBytes(104)));
			fs.Seek(103530L, SeekOrigin.Begin);
			bw.Write(dictionary["trainer"]);
			break;
		}
		switch (version)
		{
		case Version.BW2:
			fs.Seek(135424L, SeekOrigin.Begin);
			dictionary.Add("money", GetCheckSum(br.ReadBytes(240)));
			fs.Seek(135666L, SeekOrigin.Begin);
			bw.Write(dictionary["money"]);
			break;
		case Version.BW:
			fs.Seek(135680L, SeekOrigin.Begin);
			dictionary.Add("money", GetCheckSum(br.ReadBytes(236)));
			fs.Seek(135918L, SeekOrigin.Begin);
			bw.Write(dictionary["money"]);
			break;
		}
		fs.Seek(119440L, SeekOrigin.Begin);
		bw.Write(wcSeed);
		fs.Seek(116736L, SeekOrigin.Begin);
		srand(wcSeed);
		ushort[] array = new ushort[1352];
		for (int m = 0; m < 1352; m++)
		{
			array[m] = (ushort)(br.ReadUInt16() ^ rand());
		}
		fs.Seek(116992L, SeekOrigin.Begin);
		for (int n = 0; n < 12; n++)
		{
			bw.Write(wonderCards[n].data);
		}
		fs.Seek(116736L, SeekOrigin.Begin);
		for (int num = 0; num < 1352; num++)
		{
			array[num] = br.ReadUInt16();
		}
		srand(wcSeed);
		fs.Seek(116736L, SeekOrigin.Begin);
		for (int num2 = 0; num2 < 1352; num2++)
		{
			bw.Write((ushort)(array[num2] ^ rand()));
		}
		fs.Seek(116736L, SeekOrigin.Begin);
		dictionary.Add("mysterygift", GetCheckSum(br.ReadBytes(2708)));
		fs.Seek(119446L, SeekOrigin.Begin);
		bw.Write(dictionary["mysterygift"]);
		if (version == Version.BW2)
		{
			fs.Seek(133376L, SeekOrigin.Begin);
		}
		else
		{
			fs.Seek(133632L, SeekOrigin.Begin);
		}
		for (int num3 = 0; num3 < 6; num3++)
		{
			bw.Write(battleBox[num3].getEncrypted(party: false));
		}
		if (version == Version.BW2)
		{
			fs.Seek(133376L, SeekOrigin.Begin);
		}
		else
		{
			fs.Seek(133632L, SeekOrigin.Begin);
		}
		dictionary.Add("battleBox", GetCheckSum(br.ReadBytes(860)));
		if (version == Version.BW2)
		{
			fs.Seek(134238L, SeekOrigin.Begin);
		}
		else
		{
			fs.Seek(134494L, SeekOrigin.Begin);
		}
		bw.Write(dictionary["battleBox"]);
		if (version == Version.BW2)
		{
			fs.Seek(129540L, SeekOrigin.Begin);
			bw.Write(fused.getEncrypted());
			fs.Seek(129536L, SeekOrigin.Begin);
			dictionary.Add("fused", GetCheckSum(br.ReadBytes(224)));
			fs.Seek(129762L, SeekOrigin.Begin);
			bw.Write(dictionary["fused"]);
		}
		writeFinalChecksums(dictionary);
		br.Close();
		bw.Close();
		fs.Close();
	}

	private void writeFinalChecksums(Dictionary<string, ushort> checksums)
	{
		if (version == Version.BW2)
		{
			fs.Seek(155394L, SeekOrigin.Begin);
			for (int i = 0; i < 24; i++)
			{
				bw.Write(checksums["box" + i]);
			}
			fs.Seek(155444L, SeekOrigin.Begin);
			bw.Write(checksums["party"]);
			bw.Write(checksums["trainer"]);
			fs.Seek(155456L, SeekOrigin.Begin);
			bw.Write(checksums["cgear"]);
			bw.Write(checksums["card"]);
			bw.Write(checksums["mysterygift"]);
			fs.Seek(155476L, SeekOrigin.Begin);
			bw.Write(checksums["musicalData"]);
			bw.Write(checksums["fused"]);
			fs.Seek(155490L, SeekOrigin.Begin);
			bw.Write(checksums["battleBox"]);
			bw.Write(checksums["daycare"]);
			fs.Seek(155496L, SeekOrigin.Begin);
			bw.Write(checksums["money"]);
			fs.Seek(155392L, SeekOrigin.Begin);
			checksums.Add("final", GetCheckSum(br.ReadBytes(148)));
			fs.Seek(155554L, SeekOrigin.Begin);
			bw.Write(checksums["final"]);
		}
		else
		{
			fs.Seek(147202L, SeekOrigin.Begin);
			for (int j = 0; j < 24; j++)
			{
				bw.Write(checksums["box" + j]);
			}
			fs.Seek(147252L, SeekOrigin.Begin);
			bw.Write(checksums["party"]);
			bw.Write(checksums["trainer"]);
			fs.Seek(147264L, SeekOrigin.Begin);
			bw.Write(checksums["cgear"]);
			bw.Write(checksums["card"]);
			bw.Write(checksums["mysterygift"]);
			fs.Seek(147284L, SeekOrigin.Begin);
			bw.Write(checksums["musicalData"]);
			fs.Seek(147298L, SeekOrigin.Begin);
			bw.Write(checksums["battleBox"]);
			bw.Write(checksums["daycare"]);
			fs.Seek(147304L, SeekOrigin.Begin);
			bw.Write(checksums["money"]);
			fs.Seek(147200L, SeekOrigin.Begin);
			checksums.Add("final", GetCheckSum(br.ReadBytes(140)));
			fs.Seek(147354L, SeekOrigin.Begin);
			bw.Write(checksums["final"]);
		}
	}

	public byte[] getSavedData()
	{
		save("temp.sav", 0);
		byte[] result = File.ReadAllBytes("temp.sav");
		File.Delete("temp.sav");
		return result;
	}

	public string[] getBoxesNames()
	{
		string[] array = new string[24];
		for (int i = 0; i < 24; i++)
		{
			array[i] = boxes[i].name;
		}
		return array;
	}
}
