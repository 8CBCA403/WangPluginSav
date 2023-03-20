using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using PKHeX.Core;
using PKHeX.Drawing.PokeSprite;
using PKHeX.Drawing.PokeSprite.Properties;


namespace NXWonderRecord;

partial class WonderRecordLGPE : Form
{
    private bool FirstStringLoad = true;

    private readonly SaveFile sav;

    private int ClickedSlot = 0;

    private bool InitialLoad = false;

    private IDictionary<string, string> alt_dict = new Dictionary<string, string>();

    private IDictionary<string, string> alt_dex = new Dictionary<string, string>();

    private byte[] WRBlock = new byte[3200];

    private byte[] temparray = new byte[320];

    private bool LoadingTimeStamp = false;

    private bool EditingTimeStamp = false;



    public WonderRecordLGPE(SaveFile sav)
    {
        this.sav = sav;
        InitializeComponent();
        InitialLoad = true;
        InitialLoading();
        if (sav is SAV7b sAV7b)
        {
            WRBlock = sAV7b.GetData(284160, 3200);
            InitialLoad = false;
            loadslots();
            ((PictureBox)base.Controls["pictureBox1".ToString()]).BorderStyle = BorderStyle.Fixed3D;
            UpdateEntriesLGPE(WRBlock, 0);
        }
    }

    public void InitialLoading()
    {
        if (InitialLoad)
        {
            SlotIndex.Value = 0m;
            EntryTypeBox.SelectedIndex = 0;
            Populate_Alt_Dict();
            SpeciesBox.Items.Clear();
            SpeciesBox.DataSource = GameInfo.Strings.specieslist;
            SpeciesBox.SelectedIndex = 0;
            move1list.Items.Clear();
            move2list.Items.Clear();
            move3list.Items.Clear();
            move4list.Items.Clear();
            move1list.DataSource = GameInfo.Strings.movelist.Clone();
            move2list.DataSource = GameInfo.Strings.movelist.Clone();
            move3list.DataSource = GameInfo.Strings.movelist.Clone();
            move4list.DataSource = GameInfo.Strings.movelist.Clone();
            move1list.SelectedIndex = 0;
            move2list.SelectedIndex = 0;
            move3list.SelectedIndex = 0;
            move4list.SelectedIndex = 0;
            itembox1.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox2.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox3.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox4.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox5.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox6.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox1.SelectedIndex = 0;
            itembox2.SelectedIndex = 0;
            itembox3.SelectedIndex = 0;
            itembox4.SelectedIndex = 0;
            itembox5.SelectedIndex = 0;
            itembox6.SelectedIndex = 0;
            otnamebox.Text = " ";
            CardTitleRefinedBox.Text = " ";
        }
    }

    public void UpdateEntriesLGPE(byte[] TempBlock, int Index)
    {
        if (!InitialLoad)
        {
            Array.Clear(temparray, 0, temparray.Length);
            int num = 0;
            for (num = 0; num < 320; num++)
            {
                temparray[num] = TempBlock[num + Index * 320];
            }
            TimestampBox.Text = BitConverter.ToUInt32(temparray, 0).ToString();
            WCIDBox.Value = BitConverter.ToUInt16(temparray, 8);
            if (temparray[10] < 24)
            {
                CardTitleRawBox.SelectedIndex = temparray[10];
            }
            else
            {
                CardTitleRawBox.SelectedIndex = 24;
            }
            if (temparray[12] < 3)
            {
                EntryTypeBox.SelectedIndex = temparray[12];
            }
            else
            {
                EntryTypeBox.SelectedIndex = 3;
            }
            switch (EntryTypeBox.SelectedIndex)
            {
                case 0:
                    WRTabs.SelectedIndex = 0;
                    CardTitleRawBox.Text = "None";
                    CardTitleRefinedBox.Text = "None";
                    WCIDBox.Text = "0";
                    SpeciesImageSelector();
                    loadslots();
                    break;
                case 1:
                    WRLoadPokemonSWSH();
                    break;
                case 2:
                    WRLoadItemsSWSH();
                    break;
            }
        }
    }

    private void UpdateEntriesFinally()
    {
        SpeciesImageSelector();
        loadslots();
        CardTitleRefinedBox.Text = desccall_LGPE((uint)CardTitleRawBox.SelectedIndex);
    }

    public static string ToReadableByteArray(byte[] bytes)
    {
        return string.Join(", ", bytes);
    }

    private void WRLoadPokemonSWSH()
    {
        WRTabs.SelectedIndex = 1;
        byte[] array = new byte[24];
        string text = "";
        for (int i = 0; i < 24; i++)
        {
            array[i] = temparray[288 + i];
        }
        text = Encoding.Unicode.GetString(array);
        otnamebox.Text = text;
        if (FirstStringLoad)
        {
            byte[] bytes = new byte[2];
            int length = 0;
            for (int num = 11; num >= 0; num--)
            {
                if (otnamebox.Text.Substring(num, 1) != Encoding.Unicode.GetString(bytes))
                {
                    length = num + 1;
                    break;
                }
            }
            otnamebox.Text = otnamebox.Text.Substring(0, length);
            FirstStringLoad = false;
        }
        if (BitConverter.ToUInt16(temparray, 268) > SpeciesBox.Items.Count)
        {
            SpeciesBox.SelectedIndex = 0;
        }
        else
        {
            SpeciesBox.SelectedIndex = BitConverter.ToUInt16(temparray, 268);
        }
        if (BitConverter.ToUInt16(temparray, 272) > move1list.Items.Count)
        {
            move1list.SelectedIndex = 0;
        }
        else
        {
            move1list.SelectedIndex = BitConverter.ToUInt16(temparray, 272);
        }
        if (BitConverter.ToUInt16(temparray, 276) > move2list.Items.Count)
        {
            move2list.SelectedIndex = 0;
        }
        else
        {
            move2list.SelectedIndex = BitConverter.ToUInt16(temparray, 276);
        }
        if (BitConverter.ToUInt16(temparray, 280) > move3list.Items.Count)
        {
            move3list.SelectedIndex = 0;
        }
        else
        {
            move3list.SelectedIndex = BitConverter.ToUInt16(temparray, 280);
        }
        if (BitConverter.ToUInt16(temparray, 284) > move4list.Items.Count)
        {
            move4list.SelectedIndex = 0;
        }
        else
        {
            move4list.SelectedIndex = BitConverter.ToUInt16(temparray, 284);
        }
        if (temparray[314] > languagebox.Items.Count)
        {
            languagebox.SelectedIndex = 0;
        }
        else
        {
            languagebox.SelectedIndex = temparray[314];
        }
        UpdateEntriesFinally();
    }

    private void WRLoadItemsSWSH()
    {
        WRTabs.SelectedIndex = 2;
        if (BitConverter.ToUInt16(temparray, 270) > itembox1.Items.Count)
        {
            itembox1.SelectedIndex = 0;
        }
        else
        {
            itembox1.SelectedIndex = BitConverter.ToUInt16(temparray, 270);
        }
        nitem1.Text = BitConverter.ToUInt16(temparray, 272).ToString();
        if (BitConverter.ToUInt16(temparray, 274) > itembox1.Items.Count)
        {
            itembox2.SelectedIndex = 0;
        }
        else
        {
            itembox2.SelectedIndex = BitConverter.ToUInt16(temparray, 274);
        }
        nitem2.Text = BitConverter.ToUInt16(temparray, 276).ToString();
        if (BitConverter.ToUInt16(temparray, 278) > itembox1.Items.Count)
        {
            itembox3.SelectedIndex = 0;
        }
        else
        {
            itembox3.SelectedIndex = BitConverter.ToUInt16(temparray, 278);
        }
        nitem3.Text = BitConverter.ToUInt16(temparray, 280).ToString();
        if (BitConverter.ToUInt16(temparray, 282) > itembox1.Items.Count)
        {
            itembox4.SelectedIndex = 0;
        }
        else
        {
            itembox4.SelectedIndex = BitConverter.ToUInt16(temparray, 282);
        }
        nitem4.Text = BitConverter.ToUInt16(temparray, 284).ToString();
        if (BitConverter.ToUInt16(temparray, 286) > itembox1.Items.Count)
        {
            itembox5.SelectedIndex = 0;
        }
        else
        {
            itembox5.SelectedIndex = BitConverter.ToUInt16(temparray, 286);
        }
        nitem5.Text = BitConverter.ToUInt16(temparray, 288).ToString();
        if (BitConverter.ToUInt16(temparray, 290) > itembox1.Items.Count)
        {
            itembox6.SelectedIndex = 0;
        }
        else
        {
            itembox6.SelectedIndex = BitConverter.ToUInt16(temparray, 290);
        }
        nitem6.Text = BitConverter.ToUInt16(temparray, 292).ToString();
        itemslc.Text = temparray[13].ToString();
        UpdateEntriesFinally();
    }

    private void SlotIndex_ValueChanged(object sender, EventArgs e)
    {
        if (!InitialLoad)
        {
            UpdateEntriesLGPE(WRBlock, (int)SlotIndex.Value);
        }
    }

    private void WonderRecord_Load(object sender, EventArgs e)
    {
        AllowDrop = false;
        base.DragEnter += WonderRecordForm_DragEnter;
        base.DragDrop += WonderRecordForm_DragDrop;
    }

    private string desccall_LGPE(uint definedvalue)
    {
        uint num = definedvalue;
        string text = "";
        string text2 = SpeciesBox.Text;
        string text3 = itembox1.Text;
        string text4 = otnamebox.Text;
        switch (num)
        {
            case 0u:
                return text2 + " Gift";
            case 1u:
                return text3 + " Gift";
            case 2u:
                return "Item Set Gift";
            case 3u:
                pokedextype.SelectedIndex = SpeciesBox.SelectedIndex;
                return pokedextype.Text + " " + text2 + " Gift";
            case 4u:
                return "Mythical Pokémon " + text2 + " Gift";
            case 5u:
                return $"{text4}'s {text2} Gift";
            case 6u:
                return "Shiny " + text2 + " Gift";
            case 7u:
                return text2 + "() Gift";
            case 8u:
                return "() Gift";
            case 9u:
                return "Hidden Ability " + text2 + " Gift";
            case 10u:
                return move1list.Text + " " + text2 + " Gift";
            case 11u:
                return " " + text2 + " with " + move2list.Text + " Gift";
            case 12u:
                return " " + text2 + " with " + move3list.Text + " Gift";
            case 13u:
                return " " + text2 + " with " + move4list.Text + " Gift";
            case 14u:
                return text2 + " & None Gift";
            case 15u:
                return "Downloadable Version Bonus";
            case 16u:
                return "Special Pack Purchase Bonus";
            case 17u:
                return "Store Purchase Bonus";
            case 18u:
                return "Strategy Guide Purchase Bonus";
            case 19u:
                return "Purchase Bonus";
            case 20u:
                return "Happy Birthday!";
            case 21u:
                return "Virtual Console Bonus";
            case 22u:
                return "Pokémon Trainer Club Gift";
            case 23u:
                return "Pokémon Global Link Gift";
            case 24u:
                return "Pokémon Bank Gift";
            default:
                return text2 + "[ID " + num + "]";
        }
    }

    private void WC8_2_WR8_Button_Click(object sender, EventArgs e)
    {
    }

    private void WC8_Load(string path)
    {
    }

    private void WC8_Pokemon(byte[] tempWC8_2_WR8, byte[] tempWC8)
    {
        ushort value = BitConverter.ToUInt16(tempWC8, 558);
        BitConverter.GetBytes(value).CopyTo(tempWC8_2_WR8, 16);
        tempWC8_2_WR8[18] = tempWC8[581];
        ushort value2 = BitConverter.ToUInt16(tempWC8, 576);
        BitConverter.GetBytes(value2).CopyTo(tempWC8_2_WR8, 48);
        tempWC8_2_WR8[50] = tempWC8[578];
        int[] array = new int[11]
        {
            0, 300, 328, 356, 384, 412, 0, 440, 468, 496,
            524
        };
        int[] array2 = new int[11]
        {
            0, 74, 102, 130, 158, 186, 0, 214, 242, 270,
            298
        };
        int num = 0;
        for (int i = 0; i < 27; i++)
        {
            tempWC8_2_WR8[i + 72] = tempWC8[i + array[sav.Language]];
            num += tempWC8[i + array[sav.Language]];
        }
        if (num == 0)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(sav.OT);
            int num2 = 0;
            byte[] array3 = bytes;
            for (int j = 0; j < array3.Length; j++)
            {
                byte b = (tempWC8_2_WR8[num2 + 72] = array3[j]);
                num2++;
            }
        }
        if ((num == 0) | (tempWC8[626] == 3))
        {
            tempWC8_2_WR8[52] = (byte)sav.Gender;
        }
        else
        {
            tempWC8_2_WR8[52] = tempWC8[626];
        }
        if (tempWC8[array2[sav.Language]] == 0)
        {
            tempWC8_2_WR8[98] = (byte)sav.Language;
        }
        else
        {
            tempWC8_2_WR8[98] = tempWC8[array2[sav.Language]];
        }
        ushort value3 = BitConverter.ToUInt16(tempWC8, 560);
        BitConverter.GetBytes(value3).CopyTo(tempWC8_2_WR8, 56);
        ushort value4 = BitConverter.ToUInt16(tempWC8, 562);
        BitConverter.GetBytes(value4).CopyTo(tempWC8_2_WR8, 60);
        ushort value5 = BitConverter.ToUInt16(tempWC8, 564);
        BitConverter.GetBytes(value5).CopyTo(tempWC8_2_WR8, 64);
        ushort value6 = BitConverter.ToUInt16(tempWC8, 566);
        BitConverter.GetBytes(value6).CopyTo(tempWC8_2_WR8, 68);
        tempWC8_2_WR8[99] = tempWC8[604];
        tempWC8_2_WR8[100] = tempWC8[579];
        Write_WR8_to_block(tempWC8_2_WR8);
    }

    private void WC8_Items(byte[] tempWC8_2_WR8, byte[] tempWC8)
    {
        int num = 0;
        for (int i = 0; i < 6; i++)
        {
            ushort num2 = BitConverter.ToUInt16(tempWC8, 32 + i * 4);
            BitConverter.GetBytes(num2).CopyTo(tempWC8_2_WR8, 48 + i * 4);
            BitConverter.GetBytes(BitConverter.ToUInt16(tempWC8, 34 + i * 4)).CopyTo(tempWC8_2_WR8, 50 + i * 4);
            if (num2 > 0)
            {
                num++;
            }
        }
        tempWC8_2_WR8[13] = (byte)num;
        Write_WR8_to_block(tempWC8_2_WR8);
    }

    private void Write_WR8_to_block(byte[] tempWR8)
    {
        for (int i = 0; i < 320; i++)
        {
            WRBlock[i + (int)SlotIndex.Value * 320] = tempWR8[i];
        }
        UpdateEntriesLGPE(WRBlock, (int)SlotIndex.Value);
    }

    private void Populate_Alt_Dict()
    {
        alt_dict.Add(new KeyValuePair<string, string>("3_1", "Mega Venusaur"));
        alt_dict.Add(new KeyValuePair<string, string>("6_1", "Mega Charizard X"));
        alt_dict.Add(new KeyValuePair<string, string>("6_2", "Mega Charizard Y"));
        alt_dict.Add(new KeyValuePair<string, string>("9_1", "Mega Blastoise"));
        alt_dict.Add(new KeyValuePair<string, string>("15_1", "Mega Beedrill"));
        alt_dict.Add(new KeyValuePair<string, string>("18_1", "Mega Pidgeot"));
        alt_dict.Add(new KeyValuePair<string, string>("19_1", "Alolan Rattata"));
        alt_dict.Add(new KeyValuePair<string, string>("20_1", "Alolan Raticate"));
        alt_dict.Add(new KeyValuePair<string, string>("25_1", "Pikachu (Original Cap)"));
        alt_dict.Add(new KeyValuePair<string, string>("25_2", "Pikachu (Hoenn Cap)"));
        alt_dict.Add(new KeyValuePair<string, string>("25_3", "Pikachu (Sinnoh Cap)"));
        alt_dict.Add(new KeyValuePair<string, string>("25_4", "Pikachu (Unova Cap)"));
        alt_dict.Add(new KeyValuePair<string, string>("25_5", "Pikachu (Kalos Cap)"));
        alt_dict.Add(new KeyValuePair<string, string>("25_6", "Pikachu (Alola Cap)"));
        alt_dict.Add(new KeyValuePair<string, string>("25_7", "Pikachu (Partner Cap)"));
        alt_dict.Add(new KeyValuePair<string, string>("25_9", "Pikachu (World Cap)"));
        alt_dict.Add(new KeyValuePair<string, string>("26_1", "Raichu (Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("27_1", "Sandshrew (Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("28_1", "Sandslash (Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("37_1", "Vulpix (Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("38_1", "Ninetales(Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("50_1", "Diglett (Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("51_1", "Dugtrio (Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("52_1", "Meowth (Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("52_2", "Meowth (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("53_1", "Persian (Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("65_1", "Mega Alakazam"));
        alt_dict.Add(new KeyValuePair<string, string>("74_1", "Alolan Geodude"));
        alt_dict.Add(new KeyValuePair<string, string>("75_1", "Alolan Graveler"));
        alt_dict.Add(new KeyValuePair<string, string>("76_1", "Alolan Golem"));
        alt_dict.Add(new KeyValuePair<string, string>("77_1", "Ponyta (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("78_1", "Rapidash (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("79_1", "Slowpoke (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("80_2", "Slowbro (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("80_1", "Mega Slowbro"));
        alt_dict.Add(new KeyValuePair<string, string>("83_0", "Farfetch'd"));
        alt_dict.Add(new KeyValuePair<string, string>("83_1", "Farfetch'd (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("88_1", "Alolan Grimer"));
        alt_dict.Add(new KeyValuePair<string, string>("89_1", "Alolan Muk"));
        alt_dict.Add(new KeyValuePair<string, string>("94_1", "Mega Gengar"));
        alt_dict.Add(new KeyValuePair<string, string>("103_1", "Exeggutor (Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("110_1", "Weezing (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("115_1", "Mega Kangaskhan"));
        alt_dict.Add(new KeyValuePair<string, string>("122_0", "Mr. Mime"));
        alt_dict.Add(new KeyValuePair<string, string>("122_1", "Mr. Mime (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("127_1", "Mega Pinsir"));
        alt_dict.Add(new KeyValuePair<string, string>("130_1", "Mega Gyarados"));
        alt_dict.Add(new KeyValuePair<string, string>("142_1", "Mega Aerodactyl"));
        alt_dict.Add(new KeyValuePair<string, string>("144_1", "Articuno (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("145_1", "Zapdos (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("146_1", "Moltres (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("150_1", "Mega Mewtwo X"));
        alt_dict.Add(new KeyValuePair<string, string>("150_2", "Mega Mewtwo Y"));
        alt_dict.Add(new KeyValuePair<string, string>("181_1", "Mega Ampharos"));
        alt_dict.Add(new KeyValuePair<string, string>("199_1", "Slowking (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_0", "Unown (A)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_1", "Unown (B)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_10", "Unown (K)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_11", "Unown (L)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_12", "Unown (M)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_13", "Unown (N)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_14", "Unown (O)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_15", "Unown (P)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_16", "Unown (Q)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_17", "Unown (R)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_18", "Unown (S)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_19", "Unown (T)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_2", "Unown (C)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_20", "Unown (U)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_21", "Unown (V)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_22", "Unown (W)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_23", "Unown (X)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_24", "Unown (Y)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_25", "Unown (Z)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_26", "Unown (!)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_27", "Unown (?)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_3", "Unown (D)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_4", "Unown (E)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_5", "Unown (F)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_6", "Unown (G)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_7", "Unown (H)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_8", "Unown (I)"));
        alt_dict.Add(new KeyValuePair<string, string>("201_9", "Unown (J)"));
        alt_dict.Add(new KeyValuePair<string, string>("208_1", "Mega Steelix"));
        alt_dict.Add(new KeyValuePair<string, string>("212_1", "Mega Scizor"));
        alt_dict.Add(new KeyValuePair<string, string>("214_1", "Mega Heracross"));
        alt_dict.Add(new KeyValuePair<string, string>("222_1", "Corsola (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("248_1", "Mega Tyranitar"));
        alt_dict.Add(new KeyValuePair<string, string>("254_1", "Mega Sceptile"));
        alt_dict.Add(new KeyValuePair<string, string>("257_1", "Mega Blaziken"));
        alt_dict.Add(new KeyValuePair<string, string>("260_1", "Mega Swampert"));
        alt_dict.Add(new KeyValuePair<string, string>("263_1", "Zigzagoon (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("264_1", "Linoone (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("282_1", "Mega Gardevoir"));
        alt_dict.Add(new KeyValuePair<string, string>("299_1", "Mega Houndoom"));
        alt_dict.Add(new KeyValuePair<string, string>("302_1", "Mega Sableye"));
        alt_dict.Add(new KeyValuePair<string, string>("303_1", "Mega Mawile"));
        alt_dict.Add(new KeyValuePair<string, string>("306_1", "Mega Aggron"));
        alt_dict.Add(new KeyValuePair<string, string>("308_1", "Mega Medicham"));
        alt_dict.Add(new KeyValuePair<string, string>("310_1", "Mega Manectric"));
        alt_dict.Add(new KeyValuePair<string, string>("319_1", "Mega Sharpedo"));
        alt_dict.Add(new KeyValuePair<string, string>("323_1", "Mega Camerupt"));
        alt_dict.Add(new KeyValuePair<string, string>("334_1", "Mega Altaria"));
        alt_dict.Add(new KeyValuePair<string, string>("351_0", "Castform"));
        alt_dict.Add(new KeyValuePair<string, string>("351_1", "Sunny Castform"));
        alt_dict.Add(new KeyValuePair<string, string>("351_2", "Rainy Castform"));
        alt_dict.Add(new KeyValuePair<string, string>("351_3", "Snowy Castform"));
        alt_dict.Add(new KeyValuePair<string, string>("354_1", "Mega Banette"));
        alt_dict.Add(new KeyValuePair<string, string>("359_1", "Mega Absol"));
        alt_dict.Add(new KeyValuePair<string, string>("362_1", "Mega Glalie"));
        alt_dict.Add(new KeyValuePair<string, string>("373_1", "Mega Salamance"));
        alt_dict.Add(new KeyValuePair<string, string>("376_1", "Mega Metagross"));
        alt_dict.Add(new KeyValuePair<string, string>("380_1", "Mega Latias"));
        alt_dict.Add(new KeyValuePair<string, string>("381_1", "Mega Latios"));
        alt_dict.Add(new KeyValuePair<string, string>("382_1", "Primal Kyogre"));
        alt_dict.Add(new KeyValuePair<string, string>("383_1", "Primal Groudon"));
        alt_dict.Add(new KeyValuePair<string, string>("384_1", "Mega Rayquaza"));
        alt_dict.Add(new KeyValuePair<string, string>("386_0", "Normal Deoxys"));
        alt_dict.Add(new KeyValuePair<string, string>("386_1", "Attack Deoxys"));
        alt_dict.Add(new KeyValuePair<string, string>("386_2", "Defense Deoxys"));
        alt_dict.Add(new KeyValuePair<string, string>("386_3", "Speed Deoxys"));
        alt_dict.Add(new KeyValuePair<string, string>("412_0", "Plant Burmy"));
        alt_dict.Add(new KeyValuePair<string, string>("412_1", "Sandy Burmy"));
        alt_dict.Add(new KeyValuePair<string, string>("412_2", "Trash Burmy"));
        alt_dict.Add(new KeyValuePair<string, string>("413_0", "Plant Wormadam"));
        alt_dict.Add(new KeyValuePair<string, string>("413_1", "Sandy Wormadam"));
        alt_dict.Add(new KeyValuePair<string, string>("413_2", "Trash Wormadam"));
        alt_dict.Add(new KeyValuePair<string, string>("421_1", "Cherrim (Sunny)"));
        alt_dict.Add(new KeyValuePair<string, string>("421_0", "Overcast Cherrim"));
        alt_dict.Add(new KeyValuePair<string, string>("422_1", "Shellos (East)"));
        alt_dict.Add(new KeyValuePair<string, string>("422_0", "West Shellos"));
        alt_dict.Add(new KeyValuePair<string, string>("423_1", "Gastrodon (East)"));
        alt_dict.Add(new KeyValuePair<string, string>("423_0", "West Gastrodon"));
        alt_dict.Add(new KeyValuePair<string, string>("427_1", "Mega Lopunny"));
        alt_dict.Add(new KeyValuePair<string, string>("445_1", "Mega Garchomp"));
        alt_dict.Add(new KeyValuePair<string, string>("448_1", "Mega Lucario"));
        alt_dict.Add(new KeyValuePair<string, string>("460_1", "Mega Abomasnow"));
        alt_dict.Add(new KeyValuePair<string, string>("475_1", "Mega Gallade"));
        alt_dict.Add(new KeyValuePair<string, string>("479_1", "Rotom (Heat)"));
        alt_dict.Add(new KeyValuePair<string, string>("479_2", "Rotom (Wash)"));
        alt_dict.Add(new KeyValuePair<string, string>("479_3", "Rotom (Frost)"));
        alt_dict.Add(new KeyValuePair<string, string>("479_4", "Rotom (Fan)"));
        alt_dict.Add(new KeyValuePair<string, string>("479_5", "Rotom (Mow)"));
        alt_dict.Add(new KeyValuePair<string, string>("479_0", "Rotom"));
        alt_dict.Add(new KeyValuePair<string, string>("487_0", "Altered Giratina"));
        alt_dict.Add(new KeyValuePair<string, string>("487_1", "Origin Giratina"));
        alt_dict.Add(new KeyValuePair<string, string>("492_0", "Land Shaymin"));
        alt_dict.Add(new KeyValuePair<string, string>("492_1", "Sky Shaymin"));
        alt_dict.Add(new KeyValuePair<string, string>("531_1", "Mega Audino"));
        alt_dict.Add(new KeyValuePair<string, string>("550_1", "Basculin (Blue)"));
        alt_dict.Add(new KeyValuePair<string, string>("550_0", "Red Basculin"));
        alt_dict.Add(new KeyValuePair<string, string>("554_1", "Darumaka (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("555_1", "Darmanitan (Zen)"));
        alt_dict.Add(new KeyValuePair<string, string>("555_3", "Darmanitan (Zen Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("555_2", "Darmanitan (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("562_1", "Yamask (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("618_1", "Stunfisk (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("641_0", "Incarnate Tornadus"));
        alt_dict.Add(new KeyValuePair<string, string>("641_1", "Therian Tornadus"));
        alt_dict.Add(new KeyValuePair<string, string>("642_0", "Incarnate Thundurus"));
        alt_dict.Add(new KeyValuePair<string, string>("642_1", "Therian Thundurus"));
        alt_dict.Add(new KeyValuePair<string, string>("645_0", "Incarnate Landorus"));
        alt_dict.Add(new KeyValuePair<string, string>("645_1", "Therian Landorus"));
        alt_dict.Add(new KeyValuePair<string, string>("646_1", "Kyurem (White)"));
        alt_dict.Add(new KeyValuePair<string, string>("646_2", "Kyurem (Black)"));
        alt_dict.Add(new KeyValuePair<string, string>("646_0", "Kyurem"));
        alt_dict.Add(new KeyValuePair<string, string>("647_1", "Keldeo (Resolute)"));
        alt_dict.Add(new KeyValuePair<string, string>("647_0", "Keldeo"));
        alt_dict.Add(new KeyValuePair<string, string>("648_0", "Aria Meloetta"));
        alt_dict.Add(new KeyValuePair<string, string>("648_1", "Pirouette Meloetta"));
        alt_dict.Add(new KeyValuePair<string, string>("658_1", "Ash-Greninja"));
        alt_dict.Add(new KeyValuePair<string, string>("658_2", "Ash-Greninja"));
        alt_dict.Add(new KeyValuePair<string, string>("666_0", "Icy Snow Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_1", "Polar Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_10", "High Plains Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_11", "Sandstorm Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_12", "River Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_13", "Monsoon Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_14", "Savanna Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_15", "Sun Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_16", "Ocean Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_17", "Jungle Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_18", "Fancy Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_19", "Poke Ball Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_2", "Tundra Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_3", "Continental Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_4", "Garden Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_5", "Elegant Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_6", "Meadow Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_7", "Modern Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_8", "Marine Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("666_9", "Archipelago Vivillon"));
        alt_dict.Add(new KeyValuePair<string, string>("669_0", "Red Flabébé"));
        alt_dict.Add(new KeyValuePair<string, string>("669_1", "Yellow Flabébé"));
        alt_dict.Add(new KeyValuePair<string, string>("669_2", "Orange Flabébé"));
        alt_dict.Add(new KeyValuePair<string, string>("669_3", "Blue Flabébé"));
        alt_dict.Add(new KeyValuePair<string, string>("669_4", "White Flabébé"));
        alt_dict.Add(new KeyValuePair<string, string>("670_1", "Yellow Floette"));
        alt_dict.Add(new KeyValuePair<string, string>("670_2", "Orange Floette"));
        alt_dict.Add(new KeyValuePair<string, string>("670_3", "Blue Floette"));
        alt_dict.Add(new KeyValuePair<string, string>("670_4", "White Floette"));
        alt_dict.Add(new KeyValuePair<string, string>("670_5", "Eternal Floette"));
        alt_dict.Add(new KeyValuePair<string, string>("671_0", "Red Florges"));
        alt_dict.Add(new KeyValuePair<string, string>("671_1", "Yellow Florges"));
        alt_dict.Add(new KeyValuePair<string, string>("671_2", "Orange Florges"));
        alt_dict.Add(new KeyValuePair<string, string>("671_3", "Blue Florges"));
        alt_dict.Add(new KeyValuePair<string, string>("671_4", "White Florges"));
        alt_dict.Add(new KeyValuePair<string, string>("676_1", "Heart Furfrou"));
        alt_dict.Add(new KeyValuePair<string, string>("676_2", "Star Furfrou"));
        alt_dict.Add(new KeyValuePair<string, string>("676_3", "Diamond Furfrou"));
        alt_dict.Add(new KeyValuePair<string, string>("676_4", "Debutante Furfrou"));
        alt_dict.Add(new KeyValuePair<string, string>("676_5", "Matron Furfrou"));
        alt_dict.Add(new KeyValuePair<string, string>("676_6", "Dandy Furfrou"));
        alt_dict.Add(new KeyValuePair<string, string>("676_7", "La Reine Furfrou"));
        alt_dict.Add(new KeyValuePair<string, string>("676_8", "Kabuki Furfrou"));
        alt_dict.Add(new KeyValuePair<string, string>("676_9", "Pharoah Furfrou"));
        alt_dict.Add(new KeyValuePair<string, string>("678_0", "Meowstic (M)"));
        alt_dict.Add(new KeyValuePair<string, string>("678_1", "Meowstic (F)"));
        alt_dict.Add(new KeyValuePair<string, string>("681_0", "Aegislash (Shield)"));
        alt_dict.Add(new KeyValuePair<string, string>("681_1", "Aegislash (Blade)"));
        alt_dict.Add(new KeyValuePair<string, string>("710_0", "Average Pumpkaboo"));
        alt_dict.Add(new KeyValuePair<string, string>("710_1", "Pumpkaboo (Small)"));
        alt_dict.Add(new KeyValuePair<string, string>("710_2", "Pumpkaboo (Large)"));
        alt_dict.Add(new KeyValuePair<string, string>("710_3", "Pumpkaboo (Super)"));
        alt_dict.Add(new KeyValuePair<string, string>("711_0", "Average Gourgeist"));
        alt_dict.Add(new KeyValuePair<string, string>("711_1", "Gourgeist (Small)"));
        alt_dict.Add(new KeyValuePair<string, string>("711_2", "Gourgeist (Large)"));
        alt_dict.Add(new KeyValuePair<string, string>("711_3", "Gourgeist (Super)"));
        alt_dict.Add(new KeyValuePair<string, string>("718_1", "10% Zygarde"));
        alt_dict.Add(new KeyValuePair<string, string>("718_2", "10% Zygarde"));
        alt_dict.Add(new KeyValuePair<string, string>("718_3", "50% Zygarde"));
        alt_dict.Add(new KeyValuePair<string, string>("718_4", "Perfect Zygarde"));
        alt_dict.Add(new KeyValuePair<string, string>("719_1", "Mega Diancie"));
        alt_dict.Add(new KeyValuePair<string, string>("720_1", "Unbound Hoopa"));
        alt_dict.Add(new KeyValuePair<string, string>("741_0", "Baile Oricorio"));
        alt_dict.Add(new KeyValuePair<string, string>("741_1", "Pom-pom Oricorio"));
        alt_dict.Add(new KeyValuePair<string, string>("741_2", "Pa'u Oricorio"));
        alt_dict.Add(new KeyValuePair<string, string>("741_3", "Sensu Oricorio"));
        alt_dict.Add(new KeyValuePair<string, string>("744_1", "Rockruff (Own Tempo)"));
        alt_dict.Add(new KeyValuePair<string, string>("745_0", "Midday Lycanroc"));
        alt_dict.Add(new KeyValuePair<string, string>("745_1", "Lycanroc (Midnight)"));
        alt_dict.Add(new KeyValuePair<string, string>("745_2", "Lycanroc (Dusk)"));
        alt_dict.Add(new KeyValuePair<string, string>("746_1", "Wishiwashi (School)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_0", "Silvally (Normal)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_1", "Silvally (Fighting)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_10", "Silvally (Water)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_11", "Silvally (Grass)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_12", "Silvally (Electric)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_13", "Silvally (Psychic)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_14", "Silvally (Ice)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_15", "Silvally (Dragon)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_16", "Silvally (Dark)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_17", "Silvally (Fairy)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_2", "Silvally (Flying)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_3", "Silvally (Poison)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_4", "Silvally (Ground)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_5", "Silvally (Rock)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_6", "Silvally (Bug)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_7", "Silvally (Ghost)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_8", "Silvally (Steel)"));
        alt_dict.Add(new KeyValuePair<string, string>("773_9", "Silvally (Fire)"));
        alt_dict.Add(new KeyValuePair<string, string>("774_1", "Orange Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_10", "Green Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_11", "Blue Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_12", "Indigo Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_13", "Violet Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_2", "Yellow Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_3", "Green Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_4", "Blue Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_5", "Indigo Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_6", "Violet Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_7", "Red Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_8", "Orange Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("774_9", "Yellow Minior"));
        alt_dict.Add(new KeyValuePair<string, string>("778_0", "Mimikyu (Disguised)"));
        alt_dict.Add(new KeyValuePair<string, string>("778_1", "Mimikyu (Busted)"));
        alt_dict.Add(new KeyValuePair<string, string>("800_1", "Necrozma (Dusk Mane)"));
        alt_dict.Add(new KeyValuePair<string, string>("800_2", "Necrozma (Dawn Wings)"));
        alt_dict.Add(new KeyValuePair<string, string>("800_3", "Ultra Necrozma"));
        alt_dict.Add(new KeyValuePair<string, string>("801_1", "Magearna (Poke Ball Colors)"));
        alt_dict.Add(new KeyValuePair<string, string>("845_1", "Cramorant (Gulping)"));
        alt_dict.Add(new KeyValuePair<string, string>("845_2", "Cramorant (Gorging)"));
        alt_dict.Add(new KeyValuePair<string, string>("849_0", "Toxtricity (Amped)"));
        alt_dict.Add(new KeyValuePair<string, string>("849_1", "Toxtricity (Low Key)"));
        alt_dict.Add(new KeyValuePair<string, string>("854_0", "Sinistea (Phony)"));
        alt_dict.Add(new KeyValuePair<string, string>("854_1", "Sinistea (Antique)"));
        alt_dict.Add(new KeyValuePair<string, string>("855_0", "Polteageist (Phony)"));
        alt_dict.Add(new KeyValuePair<string, string>("855_1", "Polteageist (Antique)"));
        alt_dict.Add(new KeyValuePair<string, string>("862_0", "Obstagoon"));
        alt_dict.Add(new KeyValuePair<string, string>("863_0", "Perrserker"));
        alt_dict.Add(new KeyValuePair<string, string>("865_0", "Sirfetch'd"));
        alt_dict.Add(new KeyValuePair<string, string>("866_0", "Mr. Rime"));
        alt_dict.Add(new KeyValuePair<string, string>("867_0", "Runerigus"));
        alt_dict.Add(new KeyValuePair<string, string>("869_0", "Alcremie (Vanilla Cream)"));
        alt_dict.Add(new KeyValuePair<string, string>("869_1", "Alcremie (Ruby Cream)"));
        alt_dict.Add(new KeyValuePair<string, string>("869_2", "Alcremie (Matcha Cream)"));
        alt_dict.Add(new KeyValuePair<string, string>("869_3", "Alcremie (Mint Cream)"));
        alt_dict.Add(new KeyValuePair<string, string>("869_4", "Alcremie (Lemon Cream)"));
        alt_dict.Add(new KeyValuePair<string, string>("869_5", "Alcremie (Salted Cream)"));
        alt_dict.Add(new KeyValuePair<string, string>("869_6", "Alcremie (Ruby Swirl)"));
        alt_dict.Add(new KeyValuePair<string, string>("869_7", "Alcremie (Caramel Swirl)"));
        alt_dict.Add(new KeyValuePair<string, string>("869_8", "Alcremie (Rainbow Swirl)"));
        alt_dict.Add(new KeyValuePair<string, string>("875_0", "Eiscue (Ice Face)"));
        alt_dict.Add(new KeyValuePair<string, string>("875_1", "Eiscue (Noice Face)"));
        alt_dict.Add(new KeyValuePair<string, string>("876_0", "Indeedee (M)"));
        alt_dict.Add(new KeyValuePair<string, string>("876_1", "Indeedee (F)"));
        alt_dict.Add(new KeyValuePair<string, string>("877_0", "Morpeko (Full Belly)"));
        alt_dict.Add(new KeyValuePair<string, string>("877_1", "Morpeko (Hangry)"));
        alt_dict.Add(new KeyValuePair<string, string>("888_0", "Zacian (Hero of Many Battles)"));
        alt_dict.Add(new KeyValuePair<string, string>("888_1", "Zacian (Crowned Sword)"));
        alt_dict.Add(new KeyValuePair<string, string>("889_0", "Zamazenta (Hero of Many Battles)"));
        alt_dict.Add(new KeyValuePair<string, string>("889_1", "Zamazenta (Crowned Shield)"));
        alt_dict.Add(new KeyValuePair<string, string>("890_1", "Eternatus (Eternamax)"));
        alt_dict.Add(new KeyValuePair<string, string>("892_0", "Urshifu (Single Strike)"));
        alt_dict.Add(new KeyValuePair<string, string>("892_1", "Urshifu (Rapid Strike)"));
        alt_dict.Add(new KeyValuePair<string, string>("893_1", "Zarude (Dada)"));
        alt_dict.Add(new KeyValuePair<string, string>("898_1", "Calyrex (Ice Rider)"));
        alt_dict.Add(new KeyValuePair<string, string>("898_2", "Calyrex (Shadow Rider)"));
        alt_dex.Add(new KeyValuePair<string, string>("77_1", "Unique Horn Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("78_1", "Unique Horn Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("122_1", "Dancing Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("144_1", "Cruel Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("145_1", "Strong Legs Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("146_1", "Malevolent Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("199_1", "Hexpert Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("555_2", "Zen Charm Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("720_1", "Djinn Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("898_1", "High King Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("898_2", "High King Pokémon"));
    }

    private string NameFinder()
    {
        if (alt_dict.ContainsKey(SpeciesBox.SelectedIndex + "_" + FormBox.Value))
        {
            return alt_dict[SpeciesBox.SelectedIndex + "_" + FormBox.Value];
        }
        return SpeciesBox.Text;
    }

    private string AltDexFinder()
    {
        if (alt_dex.ContainsKey(SpeciesBox.SelectedIndex + "_" + FormBox.Value))
        {
            return alt_dex[SpeciesBox.SelectedIndex + "_" + FormBox.Value];
        }
        pokedextype.SelectedIndex = SpeciesBox.SelectedIndex;
        return pokedextype.Text;
    }

    private void TimestampBox_TextChanged(object sender, EventArgs e)
    {
        if (!(InitialLoad | EditingTimeStamp))
        {
        }
    }

    private void TimeStampReader()
    {
        if (string.IsNullOrEmpty(TimestampBox.Text) | (TimestampBox.Text == "0") | !ulong.TryParse(TimestampBox.Text, out var _))
        {
            LoadingTimeStamp = true;
            NumericUpDown numericUpDown = YearBox;
            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        numericUpDown = YearBox;
                        break;
                    case 1:
                        numericUpDown = MonthBox;
                        break;
                    case 2:
                        numericUpDown = DayBox;
                        break;
                    case 3:
                        numericUpDown = HourBox;
                        break;
                    case 4:
                        numericUpDown = MinBox;
                        break;
                    case 5:
                        numericUpDown = SecBox;
                        break;
                }
                numericUpDown.Value = numericUpDown.Minimum;
            }
            LoadingTimeStamp = false;
        }
        else
        {
            LoadingTimeStamp = true;
            YearBox.Value = (ulong.Parse(TimestampBox.Text) >> 26) & 0xFFF;
            MonthBox.Value = (ulong.Parse(TimestampBox.Text) >> 22) & 0xF;
            DayBox.Value = (ulong.Parse(TimestampBox.Text) >> 17) & 0x1F;
            HourBox.Value = (ulong.Parse(TimestampBox.Text) >> 12) & 0x1F;
            MinBox.Value = (ulong.Parse(TimestampBox.Text) >> 6) & 0x3F;
            SecBox.Value = ulong.Parse(TimestampBox.Text) & 0x3F;
            LoadingTimeStamp = false;
        }
    }

    private void TimeStampWriter()
    {
        if (LoadingTimeStamp)
        {
            return;
        }
        ulong num = 0uL;
        EditingTimeStamp = true;
        NumericUpDown numericUpDown = YearBox;
        int[] array = new int[6] { 26, 22, 17, 12, 6, 0 };
        for (int i = 0; i < 6; i++)
        {
            switch (i)
            {
                case 0:
                    numericUpDown = YearBox;
                    break;
                case 1:
                    numericUpDown = MonthBox;
                    break;
                case 2:
                    numericUpDown = DayBox;
                    break;
                case 3:
                    numericUpDown = HourBox;
                    break;
                case 4:
                    numericUpDown = MinBox;
                    break;
                case 5:
                    numericUpDown = SecBox;
                    break;
            }
            if (string.IsNullOrEmpty(numericUpDown.Text))
            {
                numericUpDown.Value = numericUpDown.Minimum;
            }
            else
            {
                num += (ulong)numericUpDown.Value << array[i];
            }
        }
        TimestampBox.Text = num.ToString();
        WriteTimestamp(temparray);
        Write_WR8_to_block(temparray);
        EditingTimeStamp = false;
    }

    private void YearBox_ValueChanged(object sender, EventArgs e)
    {
        TimeStampWriter();
    }

    private void MonthBox_ValueChanged(object sender, EventArgs e)
    {
        TimeStampWriter();
    }

    private void DayBox_ValueChanged(object sender, EventArgs e)
    {
        TimeStampWriter();
    }

    private void HourBox_ValueChanged(object sender, EventArgs e)
    {
        TimeStampWriter();
    }

    private void MinBox_ValueChanged(object sender, EventArgs e)
    {
        TimeStampWriter();
    }

    private void SecBox_ValueChanged(object sender, EventArgs e)
    {
        TimeStampWriter();
    }

    private void DateNul_Click(object sender, EventArgs e)
    {
        EditingTimeStamp = true;
        LoadingTimeStamp = true;
        TimestampBox.Text = "0";
        NumericUpDown numericUpDown = YearBox;
        for (int i = 0; i < 6; i++)
        {
            switch (i)
            {
                case 0:
                    numericUpDown = YearBox;
                    break;
                case 1:
                    numericUpDown = MonthBox;
                    break;
                case 2:
                    numericUpDown = DayBox;
                    break;
                case 3:
                    numericUpDown = HourBox;
                    break;
                case 4:
                    numericUpDown = MinBox;
                    break;
                case 5:
                    numericUpDown = SecBox;
                    break;
            }
            numericUpDown.Value = numericUpDown.Minimum;
        }
        WriteTimestamp(temparray);
        Write_WR8_to_block(temparray);
        EditingTimeStamp = false;
        LoadingTimeStamp = false;
    }

    private void InsertWR8Button_Click(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "WR8 files (*.wr8)|*.wr8",
            FilterIndex = 0,
            RestoreDirectory = true
        };
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            Insert_WR8(openFileDialog.FileNames[0]);
        }
    }

    private void Insert_WR8(string path)
    {
    }

    private void WriteTimestamp(byte[] tempWC8_2_WR8)
    {
        ulong result;
        if (string.IsNullOrEmpty(TimestampBox.Text))
        {
            BitConverter.GetBytes(Convert.ToUInt32(0)).CopyTo(tempWC8_2_WR8, 0);
        }
        else if (!ulong.TryParse(TimestampBox.Text, out result))
        {
            BitConverter.GetBytes(Convert.ToUInt64(0)).CopyTo(tempWC8_2_WR8, 0);
        }
        else if (Convert.ToUInt64(TimestampBox.Text) > ulong.MaxValue)
        {
            BitConverter.GetBytes(Convert.ToUInt64(0)).CopyTo(tempWC8_2_WR8, 0);
        }
        else
        {
            BitConverter.GetBytes(Convert.ToUInt64(TimestampBox.Text)).CopyTo(tempWC8_2_WR8, 0);
        }
    }

    private void ExtractWR8Button_Click(object sender, EventArgs e)
    {
    }

    private void DeleteWR8Button_Click(object sender, EventArgs e)
    {
        Array.Clear(temparray, 0, temparray.Length);
        Write_WR8_to_block(temparray);
    }

    private void WonderRecordForm_DragEnter(object sender, DragEventArgs e)
    {
    }

    private void WonderRecordForm_DragDrop(object sender, DragEventArgs e)
    {
    }

    private void WC8orWR8(string path)
    {
        byte[] array = File.ReadAllBytes(path);
        switch (array.Length)
        {
            case 720:
                WC8_Load(path);
                break;
            case 104:
                Insert_WR8(path);
                break;
            default:
                SystemSounds.Asterisk.Play();
                break;
        }
    }

    private void Border_Change(object sender, EventArgs e)
    {
        string s = ((PictureBox)sender).Name.Replace("pictureBox", "");
        ClickedSlot = ushort.Parse(s) - 1;
        SlotIndex.Value = ClickedSlot;
        int num = 0;
        for (num = 0; num < 10; num++)
        {
            ((PictureBox)base.Controls["pictureBox" + (num + 1)]).BorderStyle = BorderStyle.FixedSingle;
        }
        ((PictureBox)base.Controls["pictureBox" + (ClickedSlot + 1)]).BorderStyle = BorderStyle.Fixed3D;
    }

    private void loadslots()
    {
        int num = 0;
        for (num = 0; num < 10; num++)
        {
            byte[] array = new byte[320];
            for (int i = 0; i < 320; i++)
            {
                array[i] = WRBlock[i + 320 * num];
            }
            ((PictureBox)base.Controls["pictureBox" + (num + 1)]).Image = ImageSelector(array);
        }
    }

    public string GetItemResourceName(int item)
    {
        DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
        defaultInterpolatedStringHandler.AppendLiteral("item_");
        defaultInterpolatedStringHandler.AppendFormatted(item);
        return "b" + defaultInterpolatedStringHandler.ToStringAndClear();
    }

    public Image GetItemImage(int tempitem)
    {
        Image image = (Image)PKHeX.Drawing.PokeSprite.Properties.Resources.ResourceManager.GetObject(GetItemResourceName(tempitem));
        if (tempitem >= 1130 && tempitem <= 1229)
        {
            image = PKHeX.Drawing.PokeSprite.Properties.Resources.bitem_tr;
        }
        else if (tempitem >= 328 && tempitem <= 419)
        {
            image = PKHeX.Drawing.PokeSprite.Properties.Resources.bitem_tm;
        }
        else if (tempitem >= 1279 && tempitem <= 1578)
        {
            image = Resources.bitem_715;
        }
        if (image == null)
        {
            image = PKHeX.Drawing.PokeSprite.Properties.Resources.bitem_unk;
        }
        return RedrawImage(image);
    }

    public Image RedrawImage(Image itemimg)
    {
        int num = 2;
        int num2 = 2;
        int x = 34 - itemimg.Width / 2;
        int y = 56 - itemimg.Height - num2;
        object obj = itemimg.Clone();
        Bitmap bitmap = new Bitmap(68, 56);
        Graphics graphics = Graphics.FromImage(bitmap);
        graphics.Clear(Color.Transparent);
        graphics.DrawImageUnscaled((Image)obj, x, y, 68, 56);
        return bitmap;
    }

    private void SpeciesImageSelector()
    {
        Image image = ImageSelector(temparray);
        if (image == null)
        {
            SpeciesImageBox.Image = null;
        }
        else
        {
            SpeciesImageBox.Image = ResizeBitmap(new Bitmap(image), 136, 112);
        }
    }

    private Bitmap ResizeBitmap(Bitmap sourceBMP, int width, int height)
    {
        Bitmap bitmap = new Bitmap(width, height);
        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            graphics.DrawImage(sourceBMP, 0, 0, width, height);
        }
        return bitmap;
    }

    private Image ImageSelector(byte[] temp_wr_array)
    {
        Image image = null;
        int num = temp_wr_array[12];
        ushort num2 = BitConverter.ToUInt16(temp_wr_array, 268);
        int num3 = temp_wr_array[10];
        int tempitem = BitConverter.ToUInt16(temp_wr_array, 268);
        Shiny shiny = Shiny.Never;
        if (num3 == 6)
        {
            shiny = Shiny.Always;
        }
        switch (num)
        {
            case 0:
                return null;
            case 1:
                image = SpriteUtil.GetSprite(num2, (byte)0, 0, 0u, 0, false, shiny, EntityContext.None);
                break;
            case 2:
                image = GetItemImage(tempitem);
                break;
            default:
                image = Resources.b_unknown;
                break;
        }
        return image;
    }

    private void SpeciesBox_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void otnamebox_TextChanged(object sender, EventArgs e)
    {
    }

    private void CardTitleRefinedBox_TextChanged(object sender, EventArgs e)
    {
    }

    private void CardTitleRawBox_SelectedIndexChanged(object sender, EventArgs e)
    {
    }




}
