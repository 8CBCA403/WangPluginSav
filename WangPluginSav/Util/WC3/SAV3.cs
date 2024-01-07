namespace WangPluginSav.Util.WC3;

public class SAV3
{
    public const int SAVE_SIZE = 131072;

    private ushort[] DATALEN;

    private ushort[] FRLGMAP = new ushort[16]
    {
        3876, 3968, 3968, 3968, 3816, 3968, 3968, 3968, 3968, 3968,
        3968, 3968, 3968, 2000, 28, 256
    };

    private ushort[] RSMAP = new ushort[16]
    {
        2192, 3968, 3968, 3968, 3136, 3968, 3968, 3968, 3968, 3968,
        3968, 3968, 3968, 2000, 3968, 3968
    };

    private ushort[] EMAP = new ushort[16]
    {
        3884, 3968, 3968, 3968, 3848, 3968, 3968, 3968, 3968, 3968,
        3968, 3968, 3968, 2000, 3968, 3968
    };

    private const int TEAM_RSE = 564;

    private const int TEAM_FRLG = 52;

    private int team_offset = 564;

    private const int BERRY_OFFSET_RS = 736;

    public const int BERRY_SIZE = 1328;

    private const int WC_OFFSET_E = 1388;

    private const int WC_SCRIPT_OFFSET_E = 2216;

    private const int WC_OFFSET_FRLG = 1120;

    private const int WC_SCRIPT_OFFSET_FRLG = 1948;

    private const int WC_OFFSET_E_jap = 1168;

    private const int WC_SCRIPT_OFFSET_E_jap = 2216;

    private const int WC_OFFSET_FRLG_jap = 900;

    private const int WC_SCRIPT_OFFSET_FRLG_jap = 1948;

    private const int WCN_OFFSET_E = 940;

    private const int WCN_OFFSET_FRLG = 672;

    public const int WCN_SIZE = 448;

    private const int WCN_OFFSET_E_jap = 940;

    private const int WCN_OFFSET_FRLG_jap = 672;

    public const int WCN_SIZE_jap = 228;

    private const int ME3_OFFSET_E = 2216;

    public const int ME3_SIZE_E = 1012;

    private const int ME3_SCRIPT_SIZE_E = 1004;

    private const int ME3_OFFSET_RS = 2064;

    public const int ME3_SIZE_RS = 1012;

    private const int ME3_SCRIPT_SIZE_RS = 1004;

    private const int ME3_ITEM_SIZE = 8;

    private const int ECT_OFFSET_RS = 1176;

    private const int ECT_OFFSET_E = 3052;

    private const int ECT_OFFSET_FRLG = 1184;

    private const int TV_EVENT_RS = 3004;

    private const int TV_OUTBREAK_RS = 2140;

    private const int TV_SHOWS_RS = 2284;

    private const int TV_OUTBREAK_DATA_RS = 3068;

    private const int TV_EVENT_E = 3152;

    private const int TV_OUTBREAK_E = 2252;

    private const int TV_SHOWS_E = 2432;

    private const int TV_OUTBREAK_DATA_E = 3216;

    public byte[] Data;

    public bool Edited;

    public readonly bool Exportable;

    public readonly byte[] BAK;

    public string FileName;

    public string FilePath;

    public bool isvalid = true;

    public int game = -1;

    public bool has_WC;

    public bool has_WCN;

    public bool has_mystery_gift;

    public bool has_mystery_event;

    public bool isjap;

    public int language;

    private byte[] boxbuffer = new byte[33744];

    private int wc_offset;

    private int wc_script_offset;

    private int wcn_offset;

    private int me3_offset;

    public int me3_size;

    private int ect_offset;

    private int tv_event_offset;

    private int tv_outbreak_offset;

    private int tv_shows_offset;

    private int tv_outbreak_data_offset;

    private ushort noCash;

    private uint oldSav;

    private uint currentSav;

    private uint sec0;

    private uint s0;

    private uint sx;

    private uint x;

    private uint[] sec = new uint[14];

    public SAV3(byte[] data)
    {
        Data = (byte[])(data ?? new byte[131072]).Clone();
        BAK = (byte[])Data.Clone();
        Exportable = !Data.SequenceEqual(new byte[Data.Length]);
        checkNocash();
        checkCurrentSav();
        for (s0 = 0u; s0 <= 13; s0++)
        {
            sec0 = Data[4084 + 4096 * s0 + currentSav];
            if (sec0 == 0)
            {
                for (sx = 0u; sx <= 13; sx++)
                {
                    if (s0 + sx <= 13)
                    {
                        sec[sx] = s0 + sx;
                    }
                    else
                    {
                        sec[sx] = s0 + sx - 14;
                    }
                }
                break;
            }
        }
        for (x = 0u; x <= 13; x++)
        {
            if (Data[4084 + 4096 * sec[x] + currentSav] != x)
            {
                isvalid = false;
            }
        }
        whichgame();
        buildBoxBuffer();
        isJap();
        getLanguage();
        if (language == 1)
        {
            isjap = true;
        }
    }

    public byte[] getData(int Offset, int Length)
    {
        return Data.Skip(Offset).Take(Length).ToArray();
    }

    public int getBlockOffset(int Offset, int block)
    {
        return (int)(Offset + 4096 * sec[block] + currentSav);
    }

    public byte[] getDataFromBlock(int Offset, int Length, int block)
    {
        return Data.Skip((int)(Offset + 4096 * sec[block] + currentSav)).Take(Length).ToArray();
    }

    public byte[] getDataFromBlock_old(int Offset, int Length, int block)
    {
        if (block == 0)
        {
            return Data.Skip((int)(Offset + 4096 * sec[13] + oldSav)).Take(Length).ToArray();
        }
        return Data.Skip((int)(Offset + 4096 * sec[block - 1] + oldSav)).Take(Length).ToArray();
    }

    public void setData(byte[] input, int Offset)
    {
        input.CopyTo(Data, Offset);
        Edited = true;
    }

    public void setDataToBlock(byte[] input, int Offset, int block)
    {
        input.CopyTo(Data, Offset + 4096 * sec[block] + currentSav);
        Edited = true;
    }

    public void setDataToBlock_old(byte[] input, int Offset, int block)
    {
        if (block == 0)
        {
            input.CopyTo(Data, Offset + 4096 * sec[13] + oldSav);
        }
        else
        {
            input.CopyTo(Data, Offset + 4096 * sec[block - 1] + oldSav);
        }
        Edited = true;
    }

    public void prompt_region(string text)
    {
        switch (MessageBox.Show(text, "Region Input", MessageBoxButtons.YesNo))
        {
            case DialogResult.Yes:
                isjap = true;
                break;
            case DialogResult.No:
                isjap = false;
                break;
        }
    }

    public void isJap()
    {
        if (game == 2)
        {
            if (Data[getBlockOffset(3026, 4)] != 0)
            {
                isjap = false;
            }
            else if (language == 1)
            {
                isjap = true;
            }
            else
            {
                isjap = false;
            }
        }
        else if (Data[getBlockOffset(7, 0)] == 0)
        {
            isjap = true;
        }
        else
        {
            isjap = false;
        }
    }

    public void updateOffsets()
    {
        switch (game)
        {
            case 0:
                DATALEN = RSMAP;
                team_offset = 564;
                _ = isjap;
                me3_offset = 2064;
                me3_size = 1012;
                ect_offset = 1176;
                tv_event_offset = 3004;
                tv_outbreak_offset = 2140;
                tv_shows_offset = 2284;
                tv_outbreak_data_offset = 3068;
                break;
            case 1:
                DATALEN = EMAP;
                team_offset = 564;
                if (isjap)
                {
                    wc_offset = 1168;
                    wc_script_offset = 2216;
                    wcn_offset = 940;
                }
                else
                {
                    wc_offset = 1388;
                    wc_script_offset = 2216;
                    wcn_offset = 940;
                }
                me3_offset = 2216;
                me3_size = 1012;
                ect_offset = 3052;
                tv_event_offset = 3152;
                tv_outbreak_offset = 2252;
                tv_shows_offset = 2432;
                tv_outbreak_data_offset = 3216;
                break;
            case 2:
                DATALEN = FRLGMAP;
                team_offset = 52;
                if (isjap)
                {
                    wc_offset = 900;
                    wc_script_offset = 1948;
                    wcn_offset = 672;
                }
                else
                {
                    wc_offset = 1120;
                    wc_script_offset = 1948;
                    wcn_offset = 672;
                }
                ect_offset = 1184;
                break;
        }
        has_Mystery();
        has_WC3();
        hasWCN();
        has_EggEvent_Flag();
    }

    public void whichgame()
    {
        byte[] dataFromBlock = getDataFromBlock(172, 4, 0);
        if (BitConverter.ToUInt32(dataFromBlock, 0) == 0)
        {
            game = 0;
        }
        else if (BitConverter.ToUInt32(dataFromBlock, 0) == 1)
        {
            game = 2;
        }
        else
        {
            game = 1;
        }
        updateOffsets();
    }

    private void buildBoxBuffer()
    {
        for (int i = 0; i < 8; i++)
        {
            getDataFromBlock(0, 3968, 5 + i).CopyTo(boxbuffer, i * 3968);
        }
        getDataFromBlock(0, 2000, 13).CopyTo(boxbuffer, 31744);
    }

    public byte[] getPkmFromBox(int index, int box)
    {
        byte[] array = new byte[80];
        boxbuffer.Skip(4 + index * 80 + 2400 * box).Take(80).ToArray()
            .CopyTo(array, 0);
        return array;
    }

    public void getLanguage()
    {
        int[] array = new int[7];
        uint num = BitConverter.ToUInt32(getDataFromBlock(team_offset, 4, 1), 0);
        if (num > 6 || num == 0)
        {
            num = 1u;
        }
        for (int i = 0; i < num; i++)
        {
            switch (BitConverter.ToUInt16(getDataFromBlock(team_offset + 4 + 100 * i + 18, 2, 1), 0))
            {
                case 513:
                    array[0]++;
                    break;
                case 514:
                    array[1]++;
                    break;
                case 515:
                    array[2]++;
                    break;
                case 516:
                    array[3]++;
                    break;
                case 517:
                    array[4]++;
                    break;
                case 518:
                    array[5]++;
                    break;
                case 519:
                    array[6]++;
                    break;
            }
        }
        for (int j = 0; j < 14; j++)
        {
            for (int i = 0; i < 30; i++)
            {
                switch (BitConverter.ToUInt16(getPkmFromBox(i, j), 18))
                {
                    case 513:
                        array[0]++;
                        break;
                    case 514:
                        array[1]++;
                        break;
                    case 515:
                        array[2]++;
                        break;
                    case 516:
                        array[3]++;
                        break;
                    case 517:
                        array[4]++;
                        break;
                    case 518:
                        array[5]++;
                        break;
                    case 519:
                        array[6]++;
                        break;
                }
            }
        }
        for (int i = 0; i < 7; i++)
        {
            if (array.Max() == array[i])
            {
                if (array[i] == 0)
                {
                    MessageBox.Show("Couldn't auto-detect savegame's language. Defaulting to English, please select the correct value");
                    language = 2;
                }
                else
                {
                    language = i + 1;
                }
                break;
            }
        }
    }

    public void hasWCN()
    {
        _ = new byte[4];
        if (BitConverter.ToInt32(getDataFromBlock(wcn_offset, 4, 4), 0) == 0)
        {
            has_WCN = false;
        }
        else
        {
            has_WCN = true;
        }
    }

    public void has_WC3()
    {
        _ = new byte[4];
        if (BitConverter.ToInt32(getDataFromBlock(wc_offset, 4, 4), 0) == 0)
        {
            has_WC = false;
        }
        else
        {
            has_WC = true;
        }
    }

    public void has_Mystery()
    {
        _ = new byte[1];
        switch (game)
        {
            case 0:
                if ((getDataFromBlock(937, 1, 2)[0] & 0x10) == 0)
                {
                    has_mystery_event = false;
                }
                else
                {
                    has_mystery_event = true;
                }
                break;
            case 1:
                if ((getDataFromBlock(1029, 1, 2)[0] & 0x10) == 0)
                {
                    has_mystery_event = false;
                }
                else
                {
                    has_mystery_event = true;
                }
                if ((getDataFromBlock(1035, 1, 2)[0] & 8) == 0)
                {
                    has_mystery_gift = false;
                }
                else
                {
                    has_mystery_gift = true;
                }
                break;
            case 2:
                if ((getDataFromBlock(103, 1, 2)[0] & 2) == 0)
                {
                    has_mystery_gift = false;
                }
                else
                {
                    has_mystery_gift = true;
                }
                break;
        }
    }

    public void enable_Mystery()
    {
        byte[] array = new byte[1];
        switch (game)
        {
            case 0:
                array = getDataFromBlock(937, 1, 2);
                if ((array[0] & 0x10) == 0)
                {
                    Data[getBlockOffset(937, 2)] = (byte)(array[0] | 0x10u);
                    update_section_chk(2);
                }
                break;
            case 1:
                if (isjap)
                {
                    array = getDataFromBlock(1029, 1, 2);
                    if ((array[0] & 0x10) == 0)
                    {
                        Data[getBlockOffset(1029, 2)] = (byte)(array[0] | 0x10u);
                        update_section_chk(2);
                    }
                }
                array = getDataFromBlock(1035, 1, 2);
                if ((array[0] & 8) == 0)
                {
                    Data[getBlockOffset(1035, 2)] = (byte)(array[0] | 8u);
                    update_section_chk(2);
                }
                break;
            case 2:
                array = getDataFromBlock(103, 1, 2);
                if ((array[0] & 2) == 0)
                {
                    Data[getBlockOffset(103, 2)] = (byte)(array[0] | 2u);
                    update_section_chk(2);
                }
                break;
        }
        has_Mystery();
    }

    public byte[] get_WC3()
    {
        byte[] array;
        if (isjap)
        {
            array = new byte[1252];
            getDataFromBlock(wc_offset, 208, 4).CopyTo(array, 0);
            getDataFromBlock(wc_offset + 4 + 332 + 40 + 12, 40, 4).CopyTo(array, 208);
            getDataFromBlock(wc_script_offset, 1004, 4).CopyTo(array, 248);
        }
        else
        {
            array = new byte[1420];
            getDataFromBlock(wc_offset, 376, 4).CopyTo(array, 0);
            getDataFromBlock(wc_offset + 4 + 332 + 40 + 12, 40, 4).CopyTo(array, 376);
            getDataFromBlock(wc_script_offset, 1004, 4).CopyTo(array, 416);
        }
        return array;
    }

    public void set_WC3(byte[] wc3)
    {
        if (isjap)
        {
            setDataToBlock(wc3.Skip(0).Take(168).ToArray(), wc_offset, 4);
            setDataToBlock(wc3.Skip(178).Take(2).ToArray(), wc_offset + 4 + 164 + 10, 4);
            setDataToBlock(wc3.Skip(248).Take(1004).ToArray(), wc_script_offset, 4);
        }
        else
        {
            setDataToBlock(wc3.Skip(0).Take(336).ToArray(), wc_offset, 4);
            setDataToBlock(wc3.Skip(346).Take(2).ToArray(), wc_offset + 4 + 332 + 10, 4);
            setDataToBlock(wc3.Skip(416).Take(1004).ToArray(), wc_script_offset, 4);
        }
    }

    public byte[] get_WCN()
    {
        byte[] array;
        if (isjap)
        {
            array = new byte[228];
            getDataFromBlock(wcn_offset, 228, 4).CopyTo(array, 0);
        }
        else
        {
            array = new byte[448];
            getDataFromBlock(wcn_offset, 448, 4).CopyTo(array, 0);
        }
        return array;
    }

    public void set_WCN(byte[] wcn)
    {
        if (isjap)
        {
            setDataToBlock(wcn.Skip(0).Take(228).ToArray(), wcn_offset, 4);
        }
        else
        {
            setDataToBlock(wcn.Skip(0).Take(448).ToArray(), wcn_offset, 4);
        }
    }

    public byte[] get_ECT()
    {
        byte[] array = new byte[188];
        getDataFromBlock(ect_offset, 188, 0).CopyTo(array, 0);
        return array;
    }

    public void set_ECT(byte[] ect)
    {
        setDataToBlock(ect.Skip(0).Take(188).ToArray(), ect_offset, 0);
    }

    public byte[] get_ECB()
    {
        byte[] array = new byte[1328];
        getDataFromBlock(736, 1328, 4).CopyTo(array, 0);
        return array;
    }

    public void set_ECB(byte[] berry)
    {
        set_Enigma_Flag();
        setDataToBlock(berry.Skip(0).Take(1328).ToArray(), 736, 4);
    }

    public bool has_berry()
    {
        if (getDataFromBlock(736, 1, 4)[0] == 0)
        {
            return false;
        }
        return true;
    }

    public int has_ME3()
    {
        byte[] mE = get_ME3();
        if (BitConverter.ToInt32(mE, 0) == 0)
        {
            if (BitConverter.ToInt32(mE, me3_size - 8) == 0)
            {
                return 0;
            }
            return 2;
        }
        return 1;
    }

    public byte[] get_ME3()
    {
        byte[] array = new byte[me3_size];
        getDataFromBlock(me3_offset, me3_size, 4).CopyTo(array, 0);
        return array;
    }

    public void set_ME3(byte[] me3)
    {
        setDataToBlock(me3.Skip(0).Take(me3_size).ToArray(), me3_offset, 4);
    }

    public byte[] get_decorations()
    {
        byte[] array = new byte[150];
        if (game == 0)
        {
            getDataFromBlock(1952, 150, 3).CopyTo(array, 0);
        }
        else if (game == 1)
        {
            getDataFromBlock(2100, 150, 3).CopyTo(array, 0);
        }
        return array;
    }

    public void set_decoration(byte[] decor)
    {
        if (game == 0)
        {
            setDataToBlock(decor.Skip(0).Take(150).ToArray(), 1952, 3);
        }
        else if (game == 1)
        {
            setDataToBlock(decor.Skip(0).Take(150).ToArray(), 2100, 3);
        }
    }

    public byte[] get_TV_EVENT()
    {
        byte[] array = new byte[64];
        getDataFromBlock(tv_event_offset, 64, 3).CopyTo(array, 0);
        return array;
    }

    public void set_TV_EVENT(byte[] tvevent)
    {
        setDataToBlock(tvevent.Skip(0).Take(64).ToArray(), tv_event_offset, 3);
    }

    public byte[] get_TV_OUTBREAK()
    {
        byte[] array = new byte[36];
        getDataFromBlock(tv_outbreak_offset, 36, 3).CopyTo(array, 0);
        return array;
    }

    public void set_TV_OUTBREAK(byte[] tvoutbreak)
    {
        setDataToBlock(tvoutbreak.Skip(0).Take(36).ToArray(), tv_outbreak_offset, 3);
    }

    public byte[] get_TV_SHOWS()
    {
        byte[] array = new byte[252];
        getDataFromBlock(tv_shows_offset, 252, 3).CopyTo(array, 0);
        return array;
    }

    public void set_TV_SHOWS(byte[] tvshows)
    {
        setDataToBlock(tvshows.Skip(0).Take(252).ToArray(), tv_shows_offset, 3);
    }

    public byte[] get_TV_OUTBREAK_EXTRA()
    {
        byte[] array = new byte[20];
        getDataFromBlock(tv_outbreak_data_offset, 20, 3).CopyTo(array, 0);
        return array;
    }

    public void set_TV_OUTBREAK_EXTRA(byte[] tvoutbreak_extra)
    {
        setDataToBlock(tvoutbreak_extra.Skip(0).Take(20).ToArray(), tv_outbreak_data_offset, 3);
    }

    private void checkNocash()
    {
        if (Data[0] == 78 && Data[1] == 111 && Data[2] == 99 && Data[3] == 97 && Data[4] == 115 && Data[5] == 104)
        {
            noCash = 76;
        }
        else
        {
            noCash = 0;
        }
    }

    private void checkCurrentSav()
    {
        ulong num = (ulong)((Data[4095 + noCash] << 24 & 0xFFFFFFFFu) + (Data[4094 + noCash] << 16 & 0xFFFFFF) + (Data[4093 + noCash] << 8 & 0xFFFF) + (Data[4092 + noCash] & 0xFF));
        ulong num2 = (ulong)((Data[61439 + noCash] << 24 & 0xFFFFFFFFu) + (Data[61438 + noCash] << 16 & 0xFFFFFF) + (Data[61437 + noCash] << 8 & 0xFFFF) + (Data[61436 + noCash] & 0xFF));
        if (num >= num2)
        {
            currentSav = noCash;
            oldSav = (ushort)(57344 + noCash);
        }
        else if (num < num2)
        {
            currentSav = (ushort)(57344 + noCash);
            oldSav = noCash;
        }
    }

    private int Chksum(int length, byte[] Data)
    {
        length >>= 2;
        int num = 0;
        for (int i = 0; i < length; i++)
        {
            num += BitConverter.ToInt32(Data, i * 4);
        }
        return (num >> 16) + num & 0xFFFF;
    }

    public void update_section_chk(int block)
    {
        ushort value = (ushort)((uint)Chksum(DATALEN[block], getDataFromBlock(0, DATALEN[block], block)) & 0xFFFFu);
        setDataToBlock(BitConverter.GetBytes(value), 4086, block);
    }

    public void update_section_chk_old(int block)
    {
        ushort value = (ushort)((uint)Chksum(DATALEN[block], getDataFromBlock_old(0, DATALEN[block], block)) & 0xFFFFu);
        setDataToBlock_old(BitConverter.GetBytes(value), 4086, block);
    }

    public void fix_section_checksums()
    {
        int num = 0;
        for (num = 0; num < 14; num++)
        {
            update_section_chk(num);
        }
        for (num = 0; num < 14; num++)
        {
            update_section_chk_old(num);
        }
    }

    public byte[] getSortedSave(int save)
    {
        byte[] array = new byte[57344];
        int num = 0;
        for (num = 0; num < 14; num++)
        {
            if (save == 0)
            {
                getDataFromBlock(0, 4096, num).CopyTo(array, 4096 * num);
            }
            else
            {
                getDataFromBlock_old(0, 4096, num).CopyTo(array, 4096 * num);
            }
        }
        return array;
    }

    public void enable_eon_emerald()
    {
        byte b = getDataFromBlock(1178, 1, 2)[0];
        b = (byte)(b | 1u);
        Data[getBlockOffset(1178, 2)] = b;
        update_section_chk(2);
        Data[getBlockOffset(3220, 4)] = 172;
        Data[getBlockOffset(3221, 4)] = 0;
        Data[getBlockOffset(3222, 4)] = 0;
        Data[getBlockOffset(3223, 4)] = 0;
        Data[getBlockOffset(3224, 4)] = 1;
        Data[getBlockOffset(3225, 4)] = 151;
        Data[getBlockOffset(3226, 4)] = 19;
        Data[getBlockOffset(3227, 4)] = 1;
        update_section_chk(4);
    }

    public bool has_EggEvent_Flag()
    {
        _ = new byte[1];
        switch (game)
        {
            case 1:
                if ((getDataFromBlock(812, 1, 2)[0] & 0x10) == 0)
                {
                    return false;
                }
                return true;
            case 2:
                if ((getDataFromBlock(3931, 1, 1)[0] & 1) == 0)
                {
                    return false;
                }
                return true;
            default:
                return false;
        }
    }

    public void clear_EggEvent_Flag()
    {
        byte[] array = new byte[1];
        switch (game)
        {
            case 1:
                array = getDataFromBlock(812, 1, 2);
                if ((array[0] & 0x10u) != 0)
                {
                    array[0] = (byte)(array[0] & 0xFFFFFFEFu);
                    setDataToBlock(array, 812, 2);
                    update_section_chk(2);
                }
                break;
            case 2:
                array = getDataFromBlock(3931, 1, 1);
                if ((array[0] & (true ? 1u : 0u)) != 0)
                {
                    array[0] = (byte)(array[0] & 0xFFFFFFFEu);
                    setDataToBlock(array, 3931, 1);
                    update_section_chk(1);
                }
                break;
        }
    }

    public void set_Enigma_Flag()
    {
        _ = new byte[1];
        if (game == 0)
        {
            Data[getBlockOffset(1050, 2)] = 1;
            update_section_chk(2);
        }
    }
}
