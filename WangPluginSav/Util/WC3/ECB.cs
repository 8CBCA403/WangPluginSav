using WangPluginSav.Util.WC3.PKHeX;

namespace WangPluginSav.Util.WC3;

public class ECB
{
    public const int SIZE_ECB = 1328;

    public const int SIZE_SPRITE = 1152;

    public const int SIZE_PALETTE = 32;

    public byte[] Data;

    public bool Edited;

    public readonly bool Exportable;

    public readonly byte[] BAK;

    public string FileName;

    public string FilePath;

    public bool isjap;

    public string NAME
    {
        get
        {
            return PKM.getG3Str(Data.Take(7).ToArray(), isjap);
        }
        set
        {
            setData(PKM.setG3Str(value, isjap), 0);
        }
    }

    public byte FIRMNESS
    {
        get
        {
            return Data[7];
        }
        set
        {
            Data[7] = value;
        }
    }

    public ushort SIZE
    {
        get
        {
            return BitConverter.ToUInt16(Data, 8);
        }
        set
        {
            BitConverter.GetBytes(value).CopyTo(Data, 8);
        }
    }

    public byte YIELD_MAX
    {
        get
        {
            return Data[10];
        }
        set
        {
            Data[10] = value;
        }
    }

    public byte YIELD_MIN
    {
        get
        {
            return Data[11];
        }
        set
        {
            Data[11] = value;
        }
    }

    public byte GROWTH
    {
        get
        {
            return Data[20];
        }
        set
        {
            Data[20] = value;
        }
    }

    public byte SPICY
    {
        get
        {
            return Data[21];
        }
        set
        {
            Data[21] = value;
        }
    }

    public byte DRY
    {
        get
        {
            return Data[22];
        }
        set
        {
            Data[22] = value;
        }
    }

    public byte SWEET
    {
        get
        {
            return Data[23];
        }
        set
        {
            Data[23] = value;
        }
    }

    public byte BITTER
    {
        get
        {
            return Data[24];
        }
        set
        {
            Data[24] = value;
        }
    }

    public byte SOUR
    {
        get
        {
            return Data[25];
        }
        set
        {
            Data[25] = value;
        }
    }

    public byte SMOOTH
    {
        get
        {
            return Data[26];
        }
        set
        {
            Data[26] = value;
        }
    }

    public string DESC_1
    {
        get
        {
            return PKM.getG3Str(Data.Skip(1212).Take(45).ToArray(), isjap);
        }
        set
        {
            setData(PKM.setG3Str(value, isjap), 1212);
        }
    }

    public string DESC_2
    {
        get
        {
            return PKM.getG3Str(Data.Skip(1257).Take(45).ToArray(), isjap);
        }
        set
        {
            setData(PKM.setG3Str(value, isjap), 1257);
        }
    }

    public byte HITEM
    {
        get
        {
            return Data[1320];
        }
        set
        {
            Data[1320] = value;
        }
    }

    public byte TR_0
    {
        get
        {
            return Data[1302];
        }
        set
        {
            Data[1302] = value;
        }
    }

    public bool TR_0_healinfatuation
    {
        get
        {
            return Convert.ToBoolean(TR_0 >> 7 & 1);
        }
        set
        {
            TR_0 = (byte)(TR_0 & 0xFFFFFF7Fu | (byte)((value ? 1 : 0) << 7));
        }
    }

    public bool TR_0_firstpkm
    {
        get
        {
            return Convert.ToBoolean(TR_0 >> 6 & 1);
        }
        set
        {
            TR_0 = (byte)(TR_0 & 0xFFFFFFBFu | (byte)((value ? 1 : 0) << 6));
        }
    }

    public int TR_0_direhit
    {
        get
        {
            return TR_0 >> 5 & 3;
        }
        set
        {
            TR_0 = (byte)(TR_0 & 0xFFFFFF9Fu | (byte)((value > 3 ? 3 : value) << 5));
        }
    }

    public int TR_0_attackUP
    {
        get
        {
            return TR_0 & 0xF;
        }
        set
        {
            TR_0 = (byte)(TR_0 & 0xFFFFFFF0u | (byte)(value > 15 ? 15u : (uint)value));
        }
    }

    public byte TR_1
    {
        get
        {
            return Data[1303];
        }
        set
        {
            Data[1303] = value;
        }
    }

    public int TR_1_speedUP
    {
        get
        {
            return TR_1 & 0xF;
        }
        set
        {
            TR_1 = (byte)(TR_1 & 0xFFFFFFF0u | (byte)(value > 15 ? 15u : (uint)value));
        }
    }

    public int TR_1_defUP
    {
        get
        {
            return TR_1 >> 4 & 0xF;
        }
        set
        {
            TR_1 = (byte)(TR_1 & 0xFFFFFF0Fu | (byte)((value > 15 ? 15 : value) << 4));
        }
    }

    public byte TR_2
    {
        get
        {
            return Data[1304];
        }
        set
        {
            Data[1304] = value;
        }
    }

    public int TR_2_espUP
    {
        get
        {
            return TR_2 & 0xF;
        }
        set
        {
            TR_2 = (byte)(TR_2 & 0xFFFFFFF0u | (byte)(value > 15 ? 15u : (uint)value));
        }
    }

    public int TR_2_accUP
    {
        get
        {
            return TR_2 >> 4 & 0xF;
        }
        set
        {
            TR_2 = (byte)(TR_2 & 0xFFFFFF0Fu | (byte)((value > 15 ? 15 : value) << 4));
        }
    }

    public byte TR_3
    {
        get
        {
            return Data[1305];
        }
        set
        {
            Data[1305] = value;
        }
    }

    public bool TR_3_guardspec
    {
        get
        {
            return Convert.ToBoolean(TR_3 >> 7 & 1);
        }
        set
        {
            TR_3 = (byte)(TR_3 & 0xFFFFFF7Fu | (byte)((value ? 1 : 0) << 7));
        }
    }

    public bool TR_3_lvlUP
    {
        get
        {
            return Convert.ToBoolean(TR_3 >> 6 & 1);
        }
        set
        {
            TR_3 = (byte)(TR_3 & 0xFFFFFFBFu | (byte)((value ? 1 : 0) << 6));
        }
    }

    public bool TR_3_clearSleep
    {
        get
        {
            return Convert.ToBoolean(TR_3 >> 5 & 1);
        }
        set
        {
            TR_3 = (byte)(TR_3 & 0xFFFFFFDFu | (byte)((value ? 1 : 0) << 5));
        }
    }

    public bool TR_3_clearPoison
    {
        get
        {
            return Convert.ToBoolean(TR_3 >> 4 & 1);
        }
        set
        {
            TR_3 = (byte)(TR_3 & 0xFFFFFFEFu | (byte)((value ? 1 : 0) << 4));
        }
    }

    public bool TR_3_clearBurn
    {
        get
        {
            return Convert.ToBoolean(TR_3 >> 3 & 1);
        }
        set
        {
            TR_3 = (byte)(TR_3 & 0xFFFFFFF7u | (byte)((value ? 1 : 0) << 3));
        }
    }

    public bool TR_3_clearIce
    {
        get
        {
            return Convert.ToBoolean(TR_3 >> 2 & 1);
        }
        set
        {
            TR_3 = (byte)(TR_3 & 0xFFFFFFFBu | (byte)((value ? 1 : 0) << 2));
        }
    }

    public bool TR_3_clearPar
    {
        get
        {
            return Convert.ToBoolean(TR_3 >> 1 & 1);
        }
        set
        {
            TR_3 = (byte)(TR_3 & 0xFFFFFFFDu | (byte)((value ? 1 : 0) << 1));
        }
    }

    public bool TR_3_clearConf
    {
        get
        {
            return Convert.ToBoolean(TR_3 & 1);
        }
        set
        {
            TR_3 = (byte)(TR_3 & 0xFFFFFFFEu | (byte)(value ? 1u : 0u));
        }
    }

    public byte TR_4
    {
        get
        {
            return Data[1306];
        }
        set
        {
            Data[1306] = value;
        }
    }

    public bool TR_4_stone
    {
        get
        {
            return Convert.ToBoolean(TR_4 >> 7 & 1);
        }
        set
        {
            TR_4 = (byte)(TR_4 & 0xFFFFFF7Fu | (byte)((value ? 1 : 0) << 7));
        }
    }

    public bool TR_4_revive
    {
        get
        {
            return Convert.ToBoolean(TR_4 >> 6 & 1);
        }
        set
        {
            TR_4 = (byte)(TR_4 & 0xFFFFFFBFu | (byte)((value ? 1 : 0) << 6));
        }
    }

    public bool TR_4_maxPPUP
    {
        get
        {
            return Convert.ToBoolean(TR_4 >> 5 & 1);
        }
        set
        {
            TR_4 = (byte)(TR_4 & 0xFFFFFFDFu | (byte)((value ? 1 : 0) << 5));
        }
    }

    public bool TR_4_onlyatack
    {
        get
        {
            return Convert.ToBoolean(TR_4 >> 4 & 1);
        }
        set
        {
            TR_4 = (byte)(TR_4 & 0xFFFFFFEFu | (byte)((value ? 1 : 0) << 4));
        }
    }

    public bool TR_4_healPP
    {
        get
        {
            return Convert.ToBoolean(TR_4 >> 3 & 1);
        }
        set
        {
            TR_4 = (byte)(TR_4 & 0xFFFFFFF7u | (byte)((value ? 1 : 0) << 3));
        }
    }

    public bool TR_4_healHP
    {
        get
        {
            return Convert.ToBoolean(TR_4 >> 2 & 1);
        }
        set
        {
            TR_4 = (byte)(TR_4 & 0xFFFFFFFBu | (byte)((value ? 1 : 0) << 2));
        }
    }

    public bool TR_4_atkEVUP
    {
        get
        {
            return Convert.ToBoolean(TR_4 >> 1 & 1);
        }
        set
        {
            TR_4 = (byte)(TR_4 & 0xFFFFFFFDu | (byte)((value ? 1 : 0) << 1));
        }
    }

    public bool TR_4_hpEVUP
    {
        get
        {
            return Convert.ToBoolean(TR_4 & 1);
        }
        set
        {
            TR_4 = (byte)(TR_4 & 0xFFFFFFFEu | (byte)(value ? 1u : 0u));
        }
    }

    public byte TR_5
    {
        get
        {
            return Data[1307];
        }
        set
        {
            Data[1307] = value;
        }
    }

    public bool TR_5_happy200
    {
        get
        {
            return Convert.ToBoolean(TR_5 >> 7 & 1);
        }
        set
        {
            TR_5 = (byte)(TR_5 & 0xFFFFFF7Fu | (byte)((value ? 1 : 0) << 7));
        }
    }

    public bool TR_5_happy100
    {
        get
        {
            return Convert.ToBoolean(TR_5 >> 6 & 1);
        }
        set
        {
            TR_5 = (byte)(TR_5 & 0xFFFFFFBFu | (byte)((value ? 1 : 0) << 6));
        }
    }

    public bool TR_5_happy0
    {
        get
        {
            return Convert.ToBoolean(TR_5 >> 5 & 1);
        }
        set
        {
            TR_5 = (byte)(TR_5 & 0xFFFFFFDFu | (byte)((value ? 1 : 0) << 5));
        }
    }

    public bool TR_5_ppMax
    {
        get
        {
            return Convert.ToBoolean(TR_5 >> 4 & 1);
        }
        set
        {
            TR_5 = (byte)(TR_5 & 0xFFFFFFEFu | (byte)((value ? 1 : 0) << 4));
        }
    }

    public bool TR_5_spdefEVUP
    {
        get
        {
            return Convert.ToBoolean(TR_5 >> 3 & 1);
        }
        set
        {
            TR_5 = (byte)(TR_5 & 0xFFFFFFF7u | (byte)((value ? 1 : 0) << 3));
        }
    }

    public bool TR_5_spatkEVUP
    {
        get
        {
            return Convert.ToBoolean(TR_5 >> 2 & 1);
        }
        set
        {
            TR_5 = (byte)(TR_5 & 0xFFFFFFFBu | (byte)((value ? 1 : 0) << 2));
        }
    }

    public bool TR_5_spEVUP
    {
        get
        {
            return Convert.ToBoolean(TR_5 >> 1 & 1);
        }
        set
        {
            TR_5 = (byte)(TR_5 & 0xFFFFFFFDu | (byte)((value ? 1 : 0) << 1));
        }
    }

    public bool TR_5_defEVUP
    {
        get
        {
            return Convert.ToBoolean(TR_5 & 1);
        }
        set
        {
            TR_5 = (byte)(TR_5 & 0xFFFFFFFEu | (byte)(value ? 1u : 0u));
        }
    }

    public byte TR_6
    {
        get
        {
            return Data[1308];
        }
        set
        {
            Data[1308] = value;
        }
    }

    public sbyte TR_7
    {
        get
        {
            return (sbyte)Data[1309];
        }
        set
        {
            Data[1309] = (byte)value;
        }
    }

    public sbyte TR_8
    {
        get
        {
            return (sbyte)Data[1310];
        }
        set
        {
            Data[1310] = (byte)value;
        }
    }

    public sbyte TR_9
    {
        get
        {
            return (sbyte)Data[1311];
        }
        set
        {
            Data[1311] = (byte)value;
        }
    }

    public byte HPRecovery
    {
        get
        {
            if (TR_4_revive || TR_4_healHP)
            {
                return TR_6;
            }
            return 0;
        }
        set
        {
            if (TR_4_revive || TR_4_healHP)
            {
                TR_6 = value;
            }
        }
    }

    public byte PPRecovery
    {
        get
        {
            if (TR_4_healPP)
            {
                return TR_6;
            }
            return 0;
        }
        set
        {
            if (TR_4_healPP)
            {
                TR_6 = value;
            }
        }
    }

    public sbyte EVchange
    {
        get
        {
            if (TR_5_spEVUP || TR_5_defEVUP || TR_4_atkEVUP || TR_4_hpEVUP || TR_5_spdefEVUP || TR_5_spatkEVUP)
            {
                return (sbyte)TR_6;
            }
            return 0;
        }
        set
        {
            if (TR_5_spEVUP || TR_5_defEVUP || TR_4_atkEVUP || TR_4_hpEVUP || TR_5_spdefEVUP || TR_5_spatkEVUP)
            {
                TR_6 = (byte)value;
            }
        }
    }

    public sbyte Happy200
    {
        get
        {
            if (TR_4_revive || TR_4_healHP || TR_4_healPP || TR_4_atkEVUP || TR_4_hpEVUP || TR_5_spdefEVUP || TR_5_spatkEVUP || TR_5_spEVUP || TR_5_defEVUP)
            {
                return TR_7;
            }
            return (sbyte)TR_6;
        }
        set
        {
            if (TR_4_revive || TR_4_healHP || TR_4_healPP || TR_4_atkEVUP || TR_4_hpEVUP || TR_5_spdefEVUP || TR_5_spatkEVUP || TR_5_spEVUP || TR_5_defEVUP)
            {
                TR_7 = value;
            }
            else
            {
                TR_6 = (byte)value;
            }
        }
    }

    public sbyte Happy100
    {
        get
        {
            if (TR_4_revive || TR_4_healHP || TR_4_healPP || TR_4_atkEVUP || TR_4_hpEVUP || TR_5_spdefEVUP || TR_5_spatkEVUP || TR_5_spEVUP || TR_5_defEVUP)
            {
                if (TR_5_happy200)
                {
                    return TR_8;
                }
                return TR_7;
            }
            if (TR_5_happy200)
            {
                return TR_7;
            }
            return (sbyte)TR_6;
        }
        set
        {
            if (TR_4_revive || TR_4_healHP || TR_4_healPP || TR_4_atkEVUP || TR_4_hpEVUP || TR_5_spdefEVUP || TR_5_spatkEVUP || TR_5_spEVUP || TR_5_defEVUP)
            {
                if (TR_5_happy200)
                {
                    TR_8 = value;
                }
                else
                {
                    TR_7 = value;
                }
            }
            else if (TR_5_happy200)
            {
                TR_7 = value;
            }
            else
            {
                TR_6 = (byte)value;
            }
        }
    }

    public sbyte Happy0
    {
        get
        {
            if (TR_4_revive || TR_4_healHP || TR_4_healPP || TR_4_atkEVUP || TR_4_hpEVUP || TR_5_spdefEVUP || TR_5_spatkEVUP || TR_5_spEVUP || TR_5_defEVUP)
            {
                if (TR_5_happy200)
                {
                    if (TR_5_happy100)
                    {
                        return TR_9;
                    }
                    return TR_8;
                }
                if (TR_5_happy100)
                {
                    return TR_8;
                }
                return TR_7;
            }
            if (TR_5_happy200)
            {
                if (TR_5_happy100)
                {
                    return TR_8;
                }
                return TR_7;
            }
            if (TR_5_happy100)
            {
                return TR_7;
            }
            return (sbyte)TR_6;
        }
        set
        {
            if (TR_4_revive || TR_4_healHP || TR_4_healPP || TR_4_atkEVUP || TR_4_hpEVUP || TR_5_spdefEVUP || TR_5_spatkEVUP || TR_5_spEVUP || TR_5_defEVUP)
            {
                if (TR_5_happy200)
                {
                    if (TR_5_happy100)
                    {
                        TR_9 = value;
                    }
                    else
                    {
                        TR_8 = value;
                    }
                }
                else if (TR_5_happy100)
                {
                    TR_8 = value;
                }
                else
                {
                    TR_7 = value;
                }
            }
            else if (TR_5_happy200)
            {
                if (TR_5_happy100)
                {
                    TR_8 = value;
                }
                else
                {
                    TR_7 = value;
                }
            }
            else if (TR_5_happy100)
            {
                TR_7 = value;
            }
            else
            {
                TR_6 = (byte)value;
            }
        }
    }

    public ECB(byte[] data)
    {
        Data = (byte[])(data ?? new byte[1328]).Clone();
        BAK = (byte[])Data.Clone();
        Exportable = !Data.SequenceEqual(new byte[Data.Length]);
        isjap = false;
    }

    public byte[] getData(int Offset, int Length)
    {
        return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void setData(byte[] input, int Offset)
    {
        input.CopyTo(Data, Offset);
        Edited = true;
    }

    public void fix_berry_checksum()
    {
        byte[] data = getData(0, 1324);
        for (int i = 0; i < 8; i++)
        {
            data[12 + i] = 0;
        }
        uint value = ME3.me3_checksum(data, data.Length);
        setData(BitConverter.GetBytes(value).ToArray(), 1324);
    }

    public uint get_berry_checksum()
    {
        byte[] data = getData(0, 1324);
        for (int i = 0; i < 8; i++)
        {
            data[12 + i] = 0;
        }
        return ME3.me3_checksum(data, data.Length);
    }

    public byte[] get_sprite()
    {
        return getData(28, 1152);
    }

    public void set_sprite(byte[] sprite)
    {
        if (sprite.Length == 1152)
        {
            setData(sprite, 28);
        }
    }

    public byte[] get_palette()
    {
        return getData(1180, 32);
    }

    public void set_palette(byte[] palette)
    {
        if (palette.Length == 32)
        {
            setData(palette, 1180);
        }
    }

    public byte[] get_full_sprite()
    {
        byte[] array = new byte[1184];
        get_palette().CopyTo(array, 0);
        get_sprite().CopyTo(array, 32);
        return array;
    }

    public void set_full_sprite(byte[] sprite)
    {
        set_sprite(sprite.Skip(32).Take(1152).ToArray());
        set_palette(sprite.Skip(0).Take(32).ToArray());
    }
}
