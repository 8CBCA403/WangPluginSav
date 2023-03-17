/*
 * Created by SharpDevelop.
 * User: sergi
 * Date: 17/06/2016
 * Time: 21:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace BW_tool
{
    /// <summary>
    /// Description of TrainerInfo.
    /// </summary>
    public partial class TrainerInfo : Form
    {
        TRAINER ash;
        int trainer_block = 27;
        RIVAL gary;
        int rival_block = 66;
        BADGES badge;
        int badges_block = 52;
        BATTLE battle;
        int battle_block = 57;
        CARDSIG card;
        int cardsig_block = 33;

        public TrainerInfo()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            money.Maximum = 9999999;
            bp.Maximum = 9999;

            if (MainForm.save.B2W2 == false) //BW1 battle points are in another block
            {
                battle_block = 58;
                battle = new BATTLE(MainForm.save.getBlock(battle_block), 1);
                rival_name.Visible = false;
                rival_label.Visible = false;
            }
            else //B2W2
            {
                battle = new BATTLE(MainForm.save.getBlock(battle_block));
                gary = new RIVAL(MainForm.save.getBlock(rival_block));
            }

            //Common data
            ash = new TRAINER(MainForm.save.getBlock(trainer_block));
            badge = new BADGES(MainForm.save.getBlock(badges_block));
            card = new CARDSIG(MainForm.save.getBlock(cardsig_block));

            load_data();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void load_data()
        {
            name.Text = ash.name;
            if (MainForm.save.B2W2 == true)
            {
                rival_name.Text = gary.name;
            }

            tid.Value = ash.TID;
            sid.Value = ash.SID;

            money.Value = badge.money;


            if (ash.gender == 0)
            {
                tnr_class.Items.Clear();
                tnr_class.Items.AddRange(new object[] {
                    "短裤小子",
                    "精英训练家",
                    "宝可梦巡护员",
                    "宝可梦培育家",
                    "研究员",
                    "登山男",
                    "光头男",
                    "幼儿园小朋友"});
                tnr_class.SelectedIndex = ash.trainer_class;
            }
            else
            {
                tnr_class.Items.Clear();
                tnr_class.Items.AddRange(new object[] {
                    "迷你裙",
                    "精英训练家",
                    "宝可梦巡护员",
                    "宝可梦培育家",
                    "研究员",
                    "阳伞姐姐",
                    "护士",
                    "幼儿园小朋友"});
                tnr_class.SelectedIndex = ash.trainer_class - 8;
            }
            gender.SelectedIndex = ash.gender;

            hours.Value = ash.hours;
            minutes.Value = ash.minutes;
            seconds.Value = ash.seconds;

            bp.Value = battle.bp;

            tnr_nature.SelectedIndex = card.nature;

            badge1.Checked = badge.badge1;
            badge2.Checked = badge.badge2;
            badge3.Checked = badge.badge3;
            badge4.Checked = badge.badge4;
            badge5.Checked = badge.badge5;
            badge6.Checked = badge.badge6;
            badge7.Checked = badge.badge7;
            badge8.Checked = badge.badge8;

            badge1_date.Value = card.get_badge(0);
            badge2_date.Value = card.get_badge(1);
            badge3_date.Value = card.get_badge(2);
            badge4_date.Value = card.get_badge(3);
            badge5_date.Value = card.get_badge(4);
            badge6_date.Value = card.get_badge(5);
            badge7_date.Value = card.get_badge(6);
            badge8_date.Value = card.get_badge(7);


        }

        void set_data()
        {
            ash.name = name.Text;

            if (MainForm.save.B2W2 == true)
            {
                gary.name = rival_name.Text;
            }

            ash.TID = (UInt16)tid.Value;
            ash.SID = (UInt16)sid.Value;

            badge.money = (UInt32)money.Value;

            ash.gender = (byte)gender.SelectedIndex;

            if (gender.SelectedIndex == 1)
                ash.trainer_class = (byte)(tnr_class.SelectedIndex + 8);
            else
                ash.trainer_class = (byte)(tnr_class.SelectedIndex);


            ash.hours = (UInt16)hours.Value;
            ash.minutes = (byte)minutes.Value;
            ash.seconds = (byte)seconds.Value;

            battle.bp = (UInt16)bp.Value;

            card.nature = (byte)tnr_nature.SelectedIndex;


            badge.badge1 = badge1.Checked;
            badge.badge2 = badge2.Checked;
            badge.badge3 = badge3.Checked;
            badge.badge4 = badge4.Checked;
            badge.badge5 = badge5.Checked;
            badge.badge6 = badge6.Checked;
            badge.badge7 = badge7.Checked;
            badge.badge8 = badge8.Checked;

            card.set_badge(badge1_date.Value, 0);
            card.set_badge(badge2_date.Value, 1);
            card.set_badge(badge3_date.Value, 2);
            card.set_badge(badge4_date.Value, 3);
            card.set_badge(badge5_date.Value, 4);
            card.set_badge(badge6_date.Value, 5);
            card.set_badge(badge7_date.Value, 6);
            card.set_badge(badge8_date.Value, 7);
        }
        void Exit_butClick(object sender, EventArgs e)
        {
            this.Close();
        }
        void Saveexit_butClick(object sender, EventArgs e)
        {
            set_data();

            MainForm.save.setBlock(ash.Data, trainer_block);
            if (MainForm.save.B2W2 == true)
            {
                MainForm.save.setBlock(gary.Data, rival_block);
            }
            MainForm.save.setBlock(badge.Data, badges_block);
            MainForm.save.setBlock(battle.Data, battle_block);
            MainForm.save.setBlock(card.Data, cardsig_block);
            this.Close();
        }

        public class TRAINER
        {
            internal int Size = MainForm.save.getBlockLength(27);//Block 67

            public byte[] Data;
            public TRAINER(byte[] data = null)
            {
                Data = data ?? new byte[Size];

            }
            public byte[] getData(int Offset, int Length)
            {
                return Data.Skip(Offset).Take(Length).ToArray();
            }
            public void setData(byte[] input, int Offset)
            {
                input.CopyTo(Data, Offset);
            }

            //Helper functions from pkhex
            internal static string TrimFromFFFF(string input)
            {
                int index = input.IndexOf((char)0xFFFF);
                return index < 0 ? input : input.Substring(0, index);
            }

            public string name
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x04, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x04);
                }
            }
            public UInt16 TID
            {
                get
                {
                    return BitConverter.ToUInt16(getData(0x14, 2), 0);
                }
                set
                {
                    setData(BitConverter.GetBytes((UInt16)value), 0x14);
                }
            }
            public UInt16 SID
            {
                get
                {
                    return BitConverter.ToUInt16(getData(0x16, 2), 0);
                }
                set
                {
                    setData(BitConverter.GetBytes((UInt16)value), 0x16);
                }
            }
            public UInt16 hours
            {
                get
                {
                    return BitConverter.ToUInt16(getData(0x24, 2), 0);
                }
                set
                {
                    setData(BitConverter.GetBytes(value), 0x24);
                }
            }
            public byte minutes
            {
                get
                {
                    return Data[0x26];
                }
                set
                {
                    Data[0x26] = (byte)value;
                }
            }
            public byte seconds
            {
                get
                {
                    return Data[0x27];
                }
                set
                {
                    Data[0x27] = (byte)value;
                }
            }

            public int gender
            {
                get
                {
                    if (Data[0x21] == 0x01)
                        return 1;
                    else
                        return 0;
                }
                set
                {
                    if (value == 1)
                        Data[0x21] = 0x01;
                    else
                        Data[0x21] = 0;
                }
            }

            public byte trainer_class
            {
                get
                {
                    return Data[0x20];
                }
                set
                {
                    Data[0x20] = (byte)value;
                }
            }


        }
        public class RIVAL
        {
            internal int Size = MainForm.save.getBlockLength(66);//Block 66

            public byte[] Data;
            public RIVAL(byte[] data = null)
            {
                Data = data ?? new byte[Size];

            }
            public byte[] getData(int Offset, int Length)
            {
                return Data.Skip(Offset).Take(Length).ToArray();
            }
            public void setData(byte[] input, int Offset)
            {
                input.CopyTo(Data, Offset);
            }

            //Helper functions from pkhex
            internal static string TrimFromFFFF(string input)
            {
                int index = input.IndexOf((char)0xFFFF);
                return index < 0 ? input : input.Substring(0, index);
            }

            public string name
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0xA4, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0xA4);
                }
            }
        }

        public class BADGES
        {
            internal int Size = MainForm.save.getBlockLength(52);//Block 66

            public byte[] Data;
            public BADGES(byte[] data = null)
            {
                Data = data ?? new byte[Size];

            }
            public byte[] getData(int Offset, int Length)
            {
                return Data.Skip(Offset).Take(Length).ToArray();
            }
            public void setData(byte[] input, int Offset)
            {
                input.CopyTo(Data, Offset);
            }

            public UInt32 money
            {
                get
                {
                    return BitConverter.ToUInt32(getData(0, 4), 0);
                }
                set
                {
                    setData(BitConverter.GetBytes((UInt32)value), 0);
                }
            }

            public bool badge1
            {
                get
                {
                    if ((Data[0x4] & 0x1) != 0)
                        return true;
                    else
                        return false;
                }
                set
                {
                    if (value == true)
                        Data[0x4] |= (byte)(0x1);
                    else
                        Data[0x4] &= unchecked((byte)(~0x1));
                }
            }
            public bool badge2
            {
                get
                {
                    if ((Data[0x4] & 0x2) != 0)
                        return true;
                    else
                        return false;
                }
                set
                {
                    if (value == true)
                        Data[0x4] |= (byte)(0x2);
                    else
                        Data[0x4] &= unchecked((byte)(~0x2));
                }
            }
            public bool badge3
            {
                get
                {
                    if ((Data[0x4] & 0x4) != 0)
                        return true;
                    else
                        return false;
                }
                set
                {
                    if (value == true)
                        Data[0x4] |= (byte)(0x4);
                    else
                        Data[0x4] &= unchecked((byte)(~0x4));
                }
            }
            public bool badge4
            {
                get
                {
                    if ((Data[0x4] & 0x8) != 0)
                        return true;
                    else
                        return false;
                }
                set
                {
                    if (value == true)
                        Data[0x4] |= (byte)(0x8);
                    else
                        Data[0x4] &= unchecked((byte)(~0x8));
                }
            }
            public bool badge5
            {
                get
                {
                    if ((Data[0x4] & 0x10) != 0)
                        return true;
                    else
                        return false;
                }
                set
                {
                    if (value == true)
                        Data[0x4] |= (byte)(0x10);
                    else
                        Data[0x4] &= unchecked((byte)(~0x10));
                }
            }
            public bool badge6
            {
                get
                {
                    if ((Data[0x4] & 0x20) != 0)
                        return true;
                    else
                        return false;
                }
                set
                {
                    if (value == true)
                        Data[0x4] |= (byte)(0x20);
                    else
                        Data[0x4] &= unchecked((byte)(~0x20));
                }
            }
            public bool badge7
            {
                get
                {
                    if ((Data[0x4] & 0x40) != 0)
                        return true;
                    else
                        return false;
                }
                set
                {
                    if (value == true)
                        Data[0x4] |= (byte)(0x40);
                    else
                        Data[0x4] &= unchecked((byte)(~0x40));
                }
            }
            public bool badge8
            {
                get
                {
                    if ((Data[0x4] & 0x80) != 0)
                        return true;
                    else
                        return false;
                }
                set
                {
                    if (value == true)
                        Data[0x4] |= (byte)(0x80);
                    else
                        Data[0x4] &= unchecked((byte)(~0x80));
                }
            }
        }
        public class BATTLE
        {
            internal int SizeBW2 = MainForm.save.getBlockLength(57);//Block 57 BW2
            internal int SizeBW = MainForm.save.getBlockLength(58);//Block 58 BW

            public byte[] Data;
            public BATTLE(byte[] data = null)
            {
                Data = data ?? new byte[SizeBW2];

            }
            public BATTLE(byte[] data = null, int bw = 1)
            {
                Data = data ?? new byte[SizeBW];

            }
            public byte[] getData(int Offset, int Length)
            {
                return Data.Skip(Offset).Take(Length).ToArray();
            }
            public void setData(byte[] input, int Offset)
            {
                input.CopyTo(Data, Offset);
            }

            public UInt16 bp
            {
                get
                {
                    return BitConverter.ToUInt16(getData(0, 2), 0);
                }
                set
                {
                    setData(BitConverter.GetBytes((UInt16)value), 0);
                }
            }
        }
        public class CARDSIG
        {
            internal int Size = MainForm.save.getBlockLength(33);//Block 57 BW2

            public byte[] Data;
            public CARDSIG(byte[] data = null)
            {
                Data = data ?? new byte[Size];
            }
            public byte[] getData(int Offset, int Length)
            {
                return Data.Skip(Offset).Take(Length).ToArray();
            }
            public void setData(byte[] input, int Offset)
            {
                input.CopyTo(Data, Offset);
            }

            public byte nature
            {
                get
                {
                    return Data[0x600];
                }
                set
                {
                    Data[0x600] = (byte)value;
                }
            }
            public DateTime get_badge(int index)
            {
                if (Data[0x604 + (4 * index)] != 0 && Data[0x605 + (4 * index)] != 0 && Data[0x606 + (4 * index)] != 0)
                    return new DateTime(2000 + Data[0x604 + (4 * index)], Data[0x605 + (4 * index)], Data[0x606 + (4 * index)]);
                else
                    return new DateTime(2000, 1, 1);
            }
            public void set_badge(DateTime date, int index)
            {
                Data[0x604 + (4 * index)] = (byte)(date.Year - 2000);
                Data[0x605 + (4 * index)] = (byte)date.Month;
                Data[0x606 + (4 * index)] = (byte)date.Day;
            }
            public void del_badge(int index)
            {
                Data[0x604 + (4 * index)] = 0;
                Data[0x605 + (4 * index)] = 0;
                Data[0x606 + (4 * index)] = 0;
            }
        }
    }
}
