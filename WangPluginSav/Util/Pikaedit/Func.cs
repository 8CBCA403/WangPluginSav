using System;
using System.Linq;

namespace WangPluginSav.Util.Pikaedit;

public static class Func
{
    public static readonly int[] SeedTable = new int[256]
    {
        0, 4129, 8258, 12387, 16516, 20645, 24774, 28903, 33032, 37161,
        41290, 45419, 49548, 53677, 57806, 61935, 4657, 528, 12915, 8786,
        21173, 17044, 29431, 25302, 37689, 33560, 45947, 41818, 54205, 50076,
        62463, 58334, 9314, 13379, 1056, 5121, 25830, 29895, 17572, 21637,
        42346, 46411, 34088, 38153, 58862, 62927, 50604, 54669, 13907, 9842,
        5649, 1584, 30423, 26358, 22165, 18100, 46939, 42874, 38681, 34616,
        63455, 59390, 55197, 51132, 18628, 22757, 26758, 30887, 2112, 6241,
        10242, 14371, 51660, 55789, 59790, 63919, 35144, 39273, 43274, 47403,
        23285, 19156, 31415, 27286, 6769, 2640, 14899, 10770, 56317, 52188,
        64447, 60318, 39801, 35672, 47931, 43802, 27814, 31879, 19684, 23749,
        11298, 15363, 3168, 7233, 60846, 64911, 52716, 56781, 44330, 48395,
        36200, 40265, 32407, 28342, 24277, 20212, 15891, 11826, 7761, 3696,
        65439, 61374, 57309, 53244, 48923, 44858, 40793, 36728, 37256, 33193,
        45514, 41451, 53516, 49453, 61774, 57711, 4224, 161, 12482, 8419,
        20484, 16421, 28742, 24679, 33721, 37784, 41979, 46042, 49981, 54044,
        58239, 62302, 689, 4752, 8947, 13010, 16949, 21012, 25207, 29270,
        46570, 42443, 38312, 34185, 62830, 58703, 54572, 50445, 13538, 9411,
        5280, 1153, 29798, 25671, 21540, 17413, 42971, 47098, 34713, 38840,
        59231, 63358, 50973, 55100, 9939, 14066, 1681, 5808, 26199, 30326,
        17941, 22068, 55628, 51565, 63758, 59695, 39368, 35305, 47498, 43435,
        22596, 18533, 30726, 26663, 6336, 2273, 14466, 10403, 52093, 56156,
        60223, 64286, 35833, 39896, 43963, 48026, 19061, 23124, 27191, 31254,
        2801, 6864, 10931, 14994, 64814, 60687, 56684, 52557, 48554, 44427,
        40424, 36297, 31782, 27655, 23652, 19525, 15522, 11395, 7392, 3265,
        61215, 65342, 53085, 57212, 44955, 49082, 36825, 40952, 28183, 32310,
        20053, 24180, 11923, 16050, 3793, 7920
    };

    public static string zeros(string n)
    {
        if (n.Length == 1)
        {
            n = "0" + n;
        }
        return n;
    }

    public static byte[] convertToByteArray(ushort[] arr)
    {
        byte[] array = new byte[arr.Length * 2];
        for (int i = 0; i < arr.Length; i++)
        {
            array[i * 2] = (byte)(arr[i] & 0xFFu);
            array[i * 2 + 1] = (byte)(arr[i] >> 8);
        }
        return array;
    }

    public static byte[] subArray(byte[] arr, int i, int length)
    {
        byte[] array = new byte[length];
        Array.Copy(arr, i, array, 0, length);
        return array;
    }

    public static ushort[] ushortSubArray(ushort[] arr, int i, int length)
    {
        ushort[] array = new ushort[length];
        Array.Copy(arr, i, array, 0, length);
        return array;
    }

    public static bool[] boolSubArray(bool[] arr, int i, int length)
    {
        bool[] array = new bool[length];
        Array.Copy(arr, i, array, 0, length);
        return array;
    }

    public static byte[] mergeArray(byte[] arr, byte[] arr2)
    {
        byte[] array = new byte[arr.Length + arr2.Length];
        Array.Copy(arr, 0, array, 0, arr.Length);
        Array.Copy(arr2, 0, array, arr.Length, arr2.Length);
        return array;
    }

    public static ushort getUInt16(byte[] arr, int i = 0)
    {
        if (arr.Length >= 2)
        {
            return BitConverter.ToUInt16(arr, i);
        }
        return 0;
    }

    public static uint getUInt32(byte[] arr, int i = 0)
    {
        if (arr.Length >= 4)
        {
            return BitConverter.ToUInt32(arr, i);
        }
        return 0u;
    }

    public static string getString(byte[] arr, int i, int length)
    {
        string text = "";
        int num = 0;
        ushort num2 = 0;
        bool flag = false;
        string text2 = "";
        int num3 = 0;
        while (num < length)
        {
            num2 = BitConverter.ToUInt16(arr, i + num3);
            num++;
            switch (num2)
            {
                case ushort.MaxValue:
                    text2 = "";
                    flag = true;
                    break;
                case 0:
                    text2 = "";
                    break;
                default:
                    if (!flag)
                    {
                        text2 = char.ConvertFromUtf32(num2);
                    }
                    break;
            }
            text += text2;
            num3 += 2;
        }
        return text;
    }

    public static byte[] getfromString(string s, int maxlength, bool allff = false)
    {
        byte[] array = new byte[maxlength * 2];
        ushort num = 0;
        string text = "";
        string text2 = "";
        bool flag = false;
        for (int i = 0; i < maxlength * 2; i += 2)
        {
            if (string.IsNullOrEmpty(s))
            {
                if (flag && !allff)
                {
                    Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(0)), 0, array, i, 2);
                    continue;
                }
                Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(65535)), 0, array, i, 2);
                flag = true;
            }
            else if (s.First().Equals('\\'))
            {
                string[] array2 = s.Split('\\');
                text = zeros((Convert.ToUInt16(array2[1], 16) & 0xFF).ToString("X"));
                text2 = zeros((Convert.ToUInt16(array2[1], 16) >> 8).ToString("X"));
                num = Convert.ToUInt16(text + text2, 16);
                Array.Copy(BitConverter.GetBytes(num), 0, array, i, 2);
                i += 2;
                s = s.Remove(0, 5);
            }
            else
            {
                num = s.First();
                s = s.Remove(0, 1);
                Array.Copy(BitConverter.GetBytes(num), 0, array, i, 2);
            }
        }
        return array;
    }
}