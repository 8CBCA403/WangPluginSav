namespace BW_tool
{
    public class PKX5
    {
        // C# PKX Function Library
        // No WinForm object related code, only to calculate information.
        // May require re-referencing to main form for string array referencing.
        // Relies on Util for some common operations.

        /*        // Data
                internal static uint LCRNG(uint seed)
                {
                    const uint a = 0x41C64E6D;
                    const uint c = 0x00006073;

                    return seed * a + c;
                }
                internal static uint LCRNG(ref uint seed)
                {
                    const uint a = 0x41C64E6D;
                    const uint c = 0x00006073;

                    return seed = seed * a + c;
                }

                internal static byte[] decryptArray(byte[] ekx, int start_offset, int length, int seed_offset)
                {
                    byte[] pkx = (byte[])ekx.Clone();

                    uint pv = BitConverter.ToUInt32(pkx, seed_offset);
                    uint sv = (pv >> 0xD & 0x1F) % 24;

                    uint seed = pv;

                    // Decrypt Blocks with RNG Seed
                    for (int i = start_offset; i < length-4; i += 2)
                        BitConverter.GetBytes((ushort)(BitConverter.ToUInt16(pkx, i) ^ LCRNG(ref seed) >> 16)).CopyTo(pkx, i);

                    return pkx;
                }
        */
        internal static UInt32 LCRNG(UInt32 seed)
        // --------------------------------------------------
        {
            UInt32 a = 0x41c64e6d;
            UInt32 c = 0x00006073;
            return (UInt32)(((UInt64)seed * (UInt64)a + (UInt64)c) & 0x00000000FFFFFFFF);
        }
        internal static byte[] cryptoArray(byte[] ekx, int start_offset, int length, int seed_offset)
        // --------------------------------------------------
        {
            byte[] buffer_dec = (byte[])ekx.Clone();

            UInt32 pv = BitConverter.ToUInt32(buffer_dec, seed_offset);
            byte sv = (byte)((((pv & 0x3e000) >> 0xd) % 24) & 0x000000FF);

            UInt32 seed = pv;
            UInt16 tmp;

            for (Int32 i = start_offset; i < length; i += 0x2)
            {
                tmp = BitConverter.ToUInt16(buffer_dec, i);

                seed = LCRNG(seed);
                tmp ^= (UInt16)((seed >> 16) & 0x0000FFFF);
                Array.Copy(BitConverter.GetBytes(tmp), 0, buffer_dec, i, 2);
            }
            return buffer_dec;
        }

        internal static byte[] cryptoXor32Array(byte[] encarray, int start_offset, int length, int key_offset)
        // --------------------------------------------------
        {
            byte[] buffer_dec = (byte[])encarray.Clone();

            UInt32 encKey = BitConverter.ToUInt32(encarray, key_offset);

            int i = 0;
            for (i = 0; i < length; i += 4)
            {
                BitConverter.GetBytes(BitConverter.ToUInt32(encarray, start_offset + i) ^ encKey).CopyTo(buffer_dec, i);
            }

            return buffer_dec;
        }

        // SAV Manipulation
        /// <summary>Calculates the CRC16-CCITT checksum over an input byte array.</summary>
        /// <param name="chunk">Input byte array</param>
        /// <returns>Checksum</returns>
        //adapted from Gocario's PHBank (www.github.com/gocario/phbank)
        internal static ushort ccitt16(byte[] data)
        // --------------------------------------------------
        {
            int len = data.Length;
            UInt16 crc = 0xFFFF;

            for (UInt32 i = 0; i < len; i++)
            {
                crc ^= ((UInt16)((data[i] << 8) & 0x0000FFFF));

                for (UInt32 j = 0; j < 0x8; j++)
                {
                    if ((crc & 0x8000) > 0)
                        crc = (UInt16)(((UInt16)((crc << 1) & 0x0000FFFF) ^ 0x1021) & 0x0000FFFF);
                    else
                        crc <<= 1;
                }
            }

            return crc;
        }
    }
}