namespace WangPluginSav.Util.Pikaedit;

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



    public Version version;



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
        seed = 1103515245 * seed + 24691 & 0xFFFFFFFFu;
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
            num = num << 8 ^ Func.SeedTable[(byte)(data[i] ^ (byte)(num >> 8))];
        }
        return (ushort)num;
    }

    public SaveFile()
    {
        filename = "";
        data = null;

        version = Version.Unknown;

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




        switch (version)
        {
            case Version.BW2:
                fs.Seek(135428L, SeekOrigin.Begin);
                break;
            case Version.BW:
                fs.Seek(135684L, SeekOrigin.Begin);
                break;
        }

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
        ushort[] array = new ushort[1352];
        for (int m = 0; m < 1352; m++)
        {
            array[m] = (ushort)(br.ReadUInt16() ^ rand());
        }
        fs.Seek(116992L, SeekOrigin.Begin);

        for (int num2 = 0; num2 < 1352; num2++)
        {
            bw.Write((ushort)(array[num2] ^ rand()));
        }
        fs.Seek(116736L, SeekOrigin.Begin);

        if (version == Version.BW2)
        {
            fs.Seek(134238L, SeekOrigin.Begin);
        }
        else
        {
            fs.Seek(134494L, SeekOrigin.Begin);
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


}
