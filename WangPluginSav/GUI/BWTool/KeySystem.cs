/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 08/03/2016
 * Time: 13:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BW_tool
{
    /// <summary>
    /// Description of KeySystem.
    /// </summary>
    public partial class KeySystem : Form
    {
        KEY keys;
        int keyblock = 69;
        public KeySystem()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            keys = new KEY(MainForm.save.getBlock(keyblock));

            if (keys.KeysUnlocked() == false)
                MessageBox.Show("  警告！\n\n这个存档似乎还未开启钥匙系统。\n钥匙系统将在登入名人堂后开启。\n\n您仍可以在此处编辑。");

            updatekeys();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        public void updatekeys()
        {
            easykeybox.Checked = keys.getKeyState(0);
            challengekeybox.Checked = keys.getKeyState(1);
            citykeybox.Checked = keys.getKeyState(2);
            ironkeybox.Checked = keys.getKeyState(3);
            icebergkeybox.Checked = keys.getKeyState(4);
            easymodebox.Checked = keys.getKeyState(5);
            challengemodebox.Checked = keys.getKeyState(6);
            citybox.Checked = keys.getKeyState(7);
            ironbox.Checked = keys.getKeyState(8);
            icebergbox.Checked = keys.getKeyState(9);

            switch (keys.getConfig(0))
            {
                case 0:
                    cfg_mode_def.Checked = true;
                    break;
                case 1:
                    cfg_mode_1.Checked = true;
                    break;
                case 2:
                    cfg_mode_2.Checked = true;
                    break;
                case 3:
                    cfg_mode_3.Checked = true;
                    break;
            }
            switch (keys.getConfig(1))
            {
                case 0:
                    cfg_city_def.Checked = true;
                    break;
                case 1:
                    cfg_city_game.Checked = true;
                    break;
                case 2:
                    cfg_city_foreing.Checked = true;
                    break;
            }
            switch (keys.getConfig(2))
            {
                case 0:
                    cfg_chamber_def.Checked = true;
                    break;
                case 1:
                    cfg_chamber_rock.Checked = true;
                    break;
                case 2:
                    cfg_chamber_iron.Checked = true;
                    break;
                case 3:
                    cfg_chamber_ice.Checked = true;
                    break;
            }
        }
        public void setAllkeys()
        {
            keys.setKey(easykeybox.Checked, 0);
            keys.setKey(challengekeybox.Checked, 1);
            keys.setKey(citykeybox.Checked, 2);
            keys.setKey(ironkeybox.Checked, 3);
            keys.setKey(icebergkeybox.Checked, 4);
            keys.setKey(easymodebox.Checked, 5);
            keys.setKey(challengemodebox.Checked, 6);
            keys.setKey(citybox.Checked, 7);
            keys.setKey(ironbox.Checked, 8);
            keys.setKey(icebergbox.Checked, 9);
        }
        void Exit_butClick(object sender, EventArgs e)
        {
            this.Close();
        }
        void Saveexit_butClick(object sender, EventArgs e)
        {
            setAllkeys();
            MainForm.save.setBlock(keys.Data, keyblock);
            this.Close();
        }
        public class KEY
        {
            internal int Size = MainForm.save.getBlockLength(69);

            public byte[] Data;
            public KEY(byte[] data = null)
            {
                Data = data ?? new byte[Size];
            }
            /*
            0x00-0x07 - Unknown
            0x08-0x17 - Seems always 0x00
            0x18-0x27 - Unknown
            0x28 - Easy key (W) 				- 0x00035691
            0x2C - Challenge key (B) 			- 0x00018256
            0x30 - Tower Key (B)/ Treehollow key (W)	- 0x00059389
            0x34 - Iron Key (B) 				- 0x00048292
            0x38 - Iceberg Key (W)  			- 0x00009892
            0x3C - Easy mode unlocked			- 0x00093389
            0x40 - Challenge mode unlocked 			- 0x00022843
            0x44 - Black City / White forest unlocked 	- 0x00034771
            0x48 - Iron chamber unlocked 			- 0x000AB031
            0x4C - Iceberg chamber unlocked 		- 0x000B3818
            0x50 - Difficulty config (easy 0x00031239 | normal 0x00015657 | challenge 0x00049589)
            0x54 - Black city/White city config (black city 0x00034525| white city 0x00011963)
            0x58 - Chamber config (rock 0x00094525 | iron 0x00081963 | iceberg 0x00038569)
            0x5C - Unique ID used to xor the keys (also present in memory link block)
            0x60 - Counter
            0x62 - ccrit checksum
            */
            private const UInt32 easykey = 0x00035691;
            private const UInt32 challengekey = 0x00018256;
            private const UInt32 citykey = 0x00059389;
            private const UInt32 ironkey = 0x00048292;
            private const UInt32 icebergkey = 0x00009892;
            private const UInt32 easy_u = 0x00093389;
            private const UInt32 challenge_u = 0x00022843;
            private const UInt32 city_u = 0x00034771;
            private const UInt32 iron_u = 0x000AB031;
            private const UInt32 iceberg_u = 0x000B3818;
            private UInt32[] difficult_cfg = new UInt32[4] { 0x0, 0x00031239, 0x00015657, 0x00049589 };
            private UInt32[] city_cfg = new UInt32[3] { 0x0, 0x00034525, 0x00011963 };
            private UInt32[] chamber_cfg = new UInt32[4] { 0x0, 0x00094525, 0x00081963, 0x00038569 };
            private const UInt32 zero = 0;

            public bool KeysUnlocked()
            {
                int i = 0;
                for (i = 0; i < 0x5C; i++)
                {
                    if (Data[i] != 0x00)
                        return true;
                }
                return false;
            }

            public int getConfig(int configIndex)
            {
                int i;
                if (configIndex == 0)
                {
                    for (i = 0; i < 4; i++)
                    {
                        if (getKeyXor(10) == difficult_cfg[i])
                        {
                            return i;
                        }
                    }
                    return 0;

                }
                else if (configIndex == 1)
                {
                    for (i = 0; i < 3; i++)
                    {
                        if (getKeyXor(11) == city_cfg[i])
                        {
                            return i;
                        }
                    }
                    return 0;
                }
                else if (configIndex == 2)
                {
                    for (i = 0; i < 4; i++)
                    {
                        if (getKeyXor(12) == chamber_cfg[i])
                        {
                            return i;
                        }
                    }
                    return 0;
                }
                else
                {
                    return 0;
                }
            }
            private UInt32 getKey(int keyIndex)
            {
                return BitConverter.ToUInt32(Data, 0x28 + (keyIndex * 4));
            }
            private UInt32 getKeyXor(int keyIndex)
            {
                return getKey(keyIndex) ^ ID;
            }
            public bool getKeyState(int keyIndex)
            {
                switch (getKeyXor(keyIndex))
                {
                    case easykey:
                        return true;
                    case challengekey:
                        return true;
                    case citykey:
                        return true;
                    case ironkey:
                        return true;
                    case icebergkey:
                        return true;
                    case easy_u:
                        return true;
                    case challenge_u:
                        return true;
                    case city_u:
                        return true;
                    case iron_u:
                        return true;
                    case iceberg_u:
                        return true;
                    default:
                        return false;
                }
            }
            public void setKey(bool state, int keyIndex)
            {
                if (state == false)
                {
                    Array.Copy(BitConverter.GetBytes(zero), 0, Data, 0x28 + (keyIndex * 4), 4);
                }
                else
                {
                    UInt32 xorkey;
                    switch (keyIndex)
                    {
                        case 0:
                            xorkey = easykey;
                            break;
                        case 1:
                            xorkey = challengekey;
                            break;
                        case 2:
                            xorkey = citykey;
                            break;
                        case 3:
                            xorkey = ironkey;
                            break;
                        case 4:
                            xorkey = icebergkey;
                            break;
                        case 5:
                            xorkey = easy_u;
                            break;
                        case 6:
                            xorkey = challenge_u;
                            break;
                        case 7:
                            xorkey = city_u;
                            break;
                        case 8:
                            xorkey = iron_u;
                            break;
                        case 9:
                            xorkey = iceberg_u;
                            break;
                        default: //Invalid index, this should never happen
                            xorkey = zero;
                            break;
                    }
                    Array.Copy(BitConverter.GetBytes((ID ^ xorkey)), 0, Data, 0x28 + (keyIndex * 4), 4);
                }

            }

            private UInt32 ID
            {
                get { return BitConverter.ToUInt32(Data, 0x5C); }
                set { BitConverter.GetBytes(value).CopyTo(Data, 0x5C); }
            }
        }
    }
}
