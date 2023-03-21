using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW_tool
{
    public class DRKEY
    {
        internal int Size = BWToolMainForm.save.getBlockLength(72);

        public byte[] Data;
        public DRKEY(byte[] data = null)
        {
            Data = data ?? new byte[Size];
        }

        public UInt32 unknown1 //Not sure how this is used/updated by 3DS link data block
        {
            get { return BitConverter.ToUInt32(Data, 0x00); }
            set { BitConverter.GetBytes((UInt32)value).CopyTo(Data, 0x00); }
        }

        public byte FLAGS { get { return Data[0x04]; } set { Data[0x04] = value; } }
        public bool Tornadus { get { return (FLAGS & (1 << 0)) == 1 << 0; } set { FLAGS = (byte)(FLAGS & ~(1 << 0) | (value ? 1 << 0 : 0)); } }
        public bool Thundurus { get { return (FLAGS & (1 << 1)) == 1 << 1; } set { FLAGS = (byte)(FLAGS & ~(1 << 1) | (value ? 1 << 1 : 0)); } }
        public bool Landorus { get { return (FLAGS & (1 << 2)) == 1 << 2; } set { FLAGS = (byte)(FLAGS & ~(1 << 2) | (value ? 1 << 2 : 0)); } }
        public bool Dialga { get { return (FLAGS & (1 << 3)) == 1 << 3; } set { FLAGS = (byte)(FLAGS & ~(1 << 3) | (value ? 1 << 3 : 0)); } }
        public bool Palkia { get { return (FLAGS & (1 << 4)) == 1 << 4; } set { FLAGS = (byte)(FLAGS & ~(1 << 4) | (value ? 1 << 4 : 0)); } }
        public bool Giratina { get { return (FLAGS & (1 << 5)) == 1 << 5; } set { FLAGS = (byte)(FLAGS & ~(1 << 5) | (value ? 1 << 5 : 0)); } }
        public bool HoOh { get { return (FLAGS & (1 << 6)) == 1 << 6; } set { FLAGS = (byte)(FLAGS & ~(1 << 6) | (value ? 1 << 6 : 0)); } }
        public bool Lugia { get { return (FLAGS & (1 << 7)) == 1 << 7; } set { FLAGS = (byte)(FLAGS & ~(1 << 7) | (value ? 1 << 7 : 0)); } }

        //This value is set to 0x01 when 3DS Link has been used at least once and seems to remain that way
        public bool used { get { return (Data[0x08] & (1 << 0)) == 1 << 0; } set { Data[0x08] = (byte)(Data[0x08] & ~(1 << 0) | (value ? 1 << 0 : 0)); } }

        public void reinit() //Call this to clean all data so legendaries can be received again. Must be used with the other classes reinit() for it to work
        {
            unknown1 = 0;
            FLAGS = 0;
            used = false;
        }

    }
    public class DRA
    {
        internal int Size = 0x10;
        private UInt32 ident = 0x43524746;

        public byte[] Data;
        public DRA(byte[] data = null)
        {
            Data = data ?? new byte[Size];
        }

        //This value is set to 0x01 when 3DS Link has data to be received and 0x00 when no data/data already received
        public bool received { get { return (Data[0x00] & (1 << 0)) == 1 << 0; } set { Data[0x00] = (byte)(Data[0x00] & ~(1 << 0) | (value ? 1 << 0 : 0)); } }

        public UInt32 unknown1 //derived from offset 0x25E00 (0x00000000 if the Pokemon were not yet received)
        {
            get { return BitConverter.ToUInt32(Data, 0x04); }
            set { BitConverter.GetBytes((UInt32)value).CopyTo(Data, 0x04); }
        }
        public UInt32 Ident //always 0x43524746 (CRGF)
        {
            get { return BitConverter.ToUInt32(Data, 0x08); }
            //set { BitConverter.GetBytes((UInt32)value).CopyTo(Data, 0x08); }
            set { BitConverter.GetBytes(ident).CopyTo(Data, 0x08); }
        }
        public UInt32 key //Encryption Key used for the next transfer from DR (0x00000000 if the Pokemon were not yet received) --> Also seems to hold the lengedary flags!
        {
            get { return BitConverter.ToUInt32(Data, 0x0C); }
            set { BitConverter.GetBytes((UInt32)value).CopyTo(Data, 0x0C); }
        }

        public void reinit() //Call this to clean all data so legendaries can be received again. Must be used with the other classes reinit() for it to work
        {
            received = true;
            unknown1 = 0;
            Ident = ident;
            key = 0;
        }

    }
    public class DRB
    {
        public int Size = 0x80;

        public byte[] Data;
        public DRB(byte[] data = null)
        {
            Data = data ?? new byte[Size];

            int i = 0;

            //Read the legendary values      
            for (i = 0; i < 8; i++)
            {
                legendaries[i] = BitConverter.ToUInt32(Data, 0x00 + i * 4);
            }

            //Read pokemon
            for (i = 0; i < 6; i++)
            {
                pokes[i] = BitConverter.ToUInt32(Data, 0x20 + i * 4);
            }

            //Read items
            for (i = 0; i < 6; i++)
            {
                items[i] = BitConverter.ToUInt32(Data, 0x38 + i * 4);
            }

            //Check legality of data
            illegal = false;
            int j = 0;
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 19; j++)
                {
                    if (get_poke_species(i) == legit_pk_index[j])
                    {
                        break; //Found valid index, continue next pokémon
                    }
                    else if ((get_poke_species(i) != legit_pk_index[j]) && j == 18) //Couldn't find valid species index
                    {
                        illegal = true;
                    }
                }
                if (illegal == true) // No need to continue
                    break;
            }

            if (illegal == false)
            {
                for (i = 0; i < 6; i++)
                {
                    j = 0;
                    for (j = 0; j < 24; j++)
                    {
                        if (get_item_id(i) == legit_item_index[j])
                        {
                            break; //Found valid index, continue next item
                        }
                        else if ((get_item_id(i) != legit_item_index[j]) && j == 23) //Couldn't find valid item index
                        {
                            illegal = true;
                        }
                    }
                    if (illegal == true) // No need to continue
                        break;
                }
            }

        }

        public const UInt32 Tornadus = 0x80808080;
        public const UInt32 Thundurus = 0x92567284;
        public const UInt32 Landorus = 0x87643567;
        public const UInt32 Dialga = 0x96436763;
        public const UInt32 Palkia = 0x43867368;
        public const UInt32 Giratina = 0x17693572;
        public const UInt32 HoOh = 0x44798367;
        public const UInt32 Lugia = 0x96636983;

        private UInt32[] legendaries = new UInt32[8];

        public int[] legit_pk_index = new int[] { 0, 79, 120, 137, 163, 174, 175, 213, 238, 280, 333, 374, 425, 436, 442, 447, 479, 517, 531 };
        public int[] legit_item_index = new int[] { 0, 72, 73, 74, 75, 51, 154, 28, 29, 80, 109, 81, 82, 83, 84, 85, 91, 93, 270, 275, 538, 44, 50, 221 };

        public bool illegal;

        public int get_legend(int index) //Simple wrapper for the legendary values
        {
            int legend = 0;
            switch (legendaries[index])
            {
                case Tornadus:
                    legend = 1;
                    break;
                case Thundurus:
                    legend = 2;
                    break;
                case Landorus:
                    legend = 3;
                    break;
                case Dialga:
                    legend = 4;
                    break;
                case Palkia:
                    legend = 5;
                    break;
                case Giratina:
                    legend = 6;
                    break;
                case HoOh:
                    legend = 7;
                    break;
                case Lugia:
                    legend = 8;
                    break;
                default:
                    legend = 0;
                    break;
            }
            return legend;
        }

        public void set_legend(UInt32 legend, int index)
        {
            BitConverter.GetBytes(legend).CopyTo(Data, 0x00 + index * 4);
        }
        UInt32[] pokes = new UInt32[6];
        UInt32[] items = new UInt32[6];

        public int get_poke_species(int index)
        {
            return (int)pokes[index] >> 16;
        }
        public int get_poke_gender(int index)
        {
            return (int)pokes[index] & 0x0000000F;
        }

        public void set_poke(int species, int gender, int index)
        {
            int finalgender = gender;

            //Set fixed gender species regardless of user choice
            if (species == 0)
            {
                finalgender = 0;
            }
            else
            {
                int i = 0;
                for (i = 0; i < male_only.Length; i++)
                {
                    if (species == male_only[i])
                        finalgender = 0;
                }
                for (i = 0; i < female_only.Length; i++)
                {
                    if (species == female_only[i])
                        finalgender = 1;
                }
                for (i = 0; i < genderless.Length; i++)
                {
                    if (species == genderless[i])
                        finalgender = 2;
                }
            }


            pokes[index] = (UInt32)(finalgender | (species << 16));
            BitConverter.GetBytes(pokes[index]).CopyTo(Data, 0x20 + index * 4);

        }

        public int get_item_id(int index)
        {
            return (int)items[index] >> 16;
        }
        public int get_item_amount(int index)
        {
            //Even though item amount is stored as u16, only the least byte is used, so maximum is 255
            if (((int)items[index] & 0x0000FFFF) < 255)
            {
                return (int)items[index] & 0x0000FFFF;
            }
            else return 255;
        }

        public void set_item(int amount, int id, int index)
        {
            if (amount == 0 && id > 0) //Put 1 of an item if it's 0
            {
                items[index] = (UInt32)((id << 16) | 1);
            }
            else if (id == 0)
            {
                items[index] = 0;
            }
            else
            {
                items[index] = (UInt32)((id << 16) | amount);
            }
            BitConverter.GetBytes(items[index]).CopyTo(Data, 0x38 + index * 4);
        }

        public UInt32 EncKey
        {
            get { return BitConverter.ToUInt32(Data, 0x7C); }
            set { BitConverter.GetBytes((UInt32)value).CopyTo(Data, 0x7C); }
        }

        public void reinit() //Call this to clean all data so legendaries can be received again. Must be used with the other classes reinit() for it to work
        {
            int i = 0;
            for (i = 0; i < Size; i++)
            {
                Data[i] = 0;
            }
        }

        public void clean_data()
        {
            int i = 0;
            for (i = 0; i < Size - 4; i++)
            {
                Data[i] = 0;
            }
        }

        //Some arrays for gender filter
        int[] male_only = new int[] { 32, 33, 34, 106, 107, 128, 237, 313, 414, 475, 538, 539, 627, 628, 236, 381, 641, 642, 645 };
        int[] female_only = new int[] { 29, 113, 115, 124, 241, 242, 314, 413, 416, 478, 548, 549, 629, 630, 30, 31, 238, 380, 440, 488 };
        int[] genderless = new int[] { 81, 82, 100, 101, 120, 121, 137, 233, 292, 337, 338, 343, 344, 374, 375, 376, 436, 437, 462, 474, 479, 489, 490, 599, 600, 601, 615, 622, 623, 132, 144, 145, 146, 150, 151, 201, 243, 244, 245, 249, 250, 251, 377, 378, 379, 382, 383, 384, 385, 386, 480, 481, 482, 483, 484, 486, 487, 491, 492, 493, 494, 638, 639, 640, 643, 644, 646, 647, 648, 649 };

    }
}
