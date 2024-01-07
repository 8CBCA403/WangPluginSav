using PKHeX.Core;
using PKHeX.Drawing;
using PKHeX.Drawing.PokeSprite;
using PKHeX.Drawing.PokeSprite.Properties;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text;

namespace NXWonderRecord;

partial class WonderRecordBDSP : Form
{
    private readonly int WR_SIZE = 224;

    private bool FirstStringLoad = true;

    private readonly SaveFile sav;

    private int ClickedSlot = 0;

    private bool InitialLoad = false;

    private byte[] WRBlock = new byte[11200];

    private byte[] temparray = new byte[224];

    private IDictionary<string, string> alt_dict = new Dictionary<string, string>();

    private IDictionary<string, string> alt_dex = new Dictionary<string, string>();

    private bool LoadingTimeStamp = false;

    private bool EditingTimeStamp = false;
    public WonderRecordBDSP(SaveFile sav)
    {
        this.sav = sav;
        InitializeComponent();
        InitialLoad = true;
        InitialLoading();
        if (sav is SAV8BS)
        {
            update_wrblock();
            InitialLoad = false;
            ((PictureBox)base.Controls["pictureBox" + 1]).BorderStyle = BorderStyle.Fixed3D;
            UpdateEntriesBDSP(WRBlock, 0);
            loadslots();
        }
        Random random = new Random();
        long num = random.Next(0, 4095);
        long num2 = (sav.TID16 ^ sav.SID16) / 16;
        if (num2 == num)
        {
            WC8_2_WR8_Button.Enabled = true;
        }
        else
        {
            WC8_2_WR8_Button.Enabled = false;
        }
    }

    public void update_wrblock()
    {
        for (int i = 0; i < WR_SIZE * 50; i++)
        {
            WRBlock[i] = sav.Data[957416 + i];
        }
    }

    public void InitialLoading()
    {
        if (InitialLoad)
        {
            SlotIndex.Value = 0m;
            EntryTypeBox.SelectedIndex = 0;
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
            helditem.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox1.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox2.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox3.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox4.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox5.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox6.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox7.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            helditem.SelectedIndex = 0;
            itembox1.SelectedIndex = 0;
            itembox2.SelectedIndex = 0;
            itembox3.SelectedIndex = 0;
            itembox4.SelectedIndex = 0;
            itembox5.SelectedIndex = 0;
            itembox6.SelectedIndex = 0;
            itembox7.SelectedIndex = 0;
            ribbonlist.SelectedIndex = 0;
        }
    }

    public void UpdateEntriesBDSP(byte[] TempBlock, int Index)
    {
        if (!InitialLoad)
        {
            Array.Clear(temparray, 0, temparray.Length);
            int num = 0;
            for (num = 0; num < WR_SIZE; num++)
            {
                temparray[num] = TempBlock[num + Index * WR_SIZE];
            }
            TimestampBox.Text = BitConverter.ToUInt64(temparray, 0).ToString();
            WCIDBox.Value = BitConverter.ToUInt16(temparray, 8);
            if (temparray[10] < 58)
            {
                CardTitleRawBox.SelectedIndex = temparray[10];
            }
            else
            {
                CardTitleRawBox.SelectedIndex = 58;
            }
            if (temparray[12] < 7)
            {
                EntryTypeBox.SelectedIndex = temparray[12];
            }
            else
            {
                EntryTypeBox.SelectedIndex = 7;
            }
            switch (EntryTypeBox.SelectedIndex)
            {
                case 0:
                    WRTabs.SelectedIndex = 0;
                    CardTitleRawBox.Text = "None";
                    CardTitleRefinedBox.Text = "None";
                    seasonbox.Value = 0m;
                    WCIDBox.Text = "0";
                    SpeciesImageSelector();
                    return;
                case 1:
                    WRLoadPokemonBDSP();
                    SpeciesImageSelector();
                    break;
                case 2:
                    WRLoadItemsBDSP(mode: false);
                    SpeciesImageSelector();
                    break;
                case 3:
                    WRTabs.SelectedIndex = 0;
                    SpeciesImageSelector();
                    break;
                case 4:
                    WRLoadClothesBDSP();
                    SpeciesImageSelector();
                    break;
                case 5:
                    WRTabs.SelectedIndex = 0;
                    SpeciesImageSelector();
                    break;
                case 6:
                    WRLoadItemsBDSP(mode: true);
                    SpeciesImageSelector();
                    break;
            }
            CardTitleRefinedBox.Text = desccall_bdsp((uint)CardTitleRawBox.SelectedIndex, "");
        }
    }

    private void loadslots()
    {
        int num = 0;
        for (num = 0; num < 50; num++)
        {
            byte[] array = new byte[WR_SIZE];
            for (int i = 0; i < WR_SIZE; i++)
            {
                array[i] = WRBlock[i + WR_SIZE * num];
            }
            ((PictureBox)base.Controls["pictureBox" + (num + 1)]).Image = ImageSelector(array);
        }
    }

    private void Border_Change(object sender, EventArgs e)
    {
        Border_Change(sender);
    }

    private void Border_Change(object sender)
    {
        string s = ((PictureBox)sender).Name.Replace("pictureBox", "");
        ClickedSlot = ushort.Parse(s) - 1;
        SlotIndex.Value = ClickedSlot;
        int num = 0;
        for (num = 0; num < 50; num++)
        {
            ((PictureBox)base.Controls["pictureBox" + (num + 1)]).BorderStyle = BorderStyle.FixedSingle;
        }
        ((PictureBox)base.Controls["pictureBox" + (ClickedSlot + 1)]).BorderStyle = BorderStyle.Fixed3D;
    }

    private void SlotIndex_ValueChanged(object sender, EventArgs e)
    {
        if (!InitialLoad)
        {
            UpdateEntriesBDSP(WRBlock, (int)SlotIndex.Value);
        }
    }

    private void WRLoadPokemonBDSP()
    {
        WRTabs.SelectedIndex = 1;
        if (BitConverter.ToUInt16(temparray, 20) > helditem.Items.Count)
        {
            helditem.SelectedIndex = 0;
        }
        else
        {
            helditem.SelectedIndex = BitConverter.ToUInt16(temparray, 20);
        }
        if (temparray[39] < 2)
        {
            switch (temparray[57])
            {
                case 0:
                    isegg.Checked = false;
                    break;
                case 1:
                    isegg.Checked = true;
                    break;
            }
        }
        else
        {
            isegg.Checked = false;
        }
        if (BitConverter.ToUInt16(temparray, 16) > SpeciesBox.Items.Count)
        {
            SpeciesBox.SelectedIndex = 0;
        }
        else
        {
            SpeciesBox.SelectedIndex = BitConverter.ToUInt16(temparray, 16);
        }
        if (BitConverter.ToUInt16(temparray, 18) > 33)
        {
            FormBox.Text = 0.ToString();
        }
        else
        {
            FormBox.Text = BitConverter.ToUInt16(temparray, 18).ToString();
        }
        SpeciesBox.SelectedIndex = BitConverter.ToUInt16(temparray, 16);
        RefinedSpeciesBox.Text = SpeciesBox.Text;
        if (temparray[56] > OTG.Items.Count)
        {
            OTG.SelectedIndex = 0;
        }
        else
        {
            OTG.SelectedIndex = temparray[56];
        }
        if (BitConverter.ToUInt16(temparray, 22) > move1list.Items.Count)
        {
            move1list.SelectedIndex = 0;
        }
        else
        {
            move1list.SelectedIndex = BitConverter.ToUInt16(temparray, 22);
        }
        if (BitConverter.ToUInt16(temparray, 24) > move2list.Items.Count)
        {
            move2list.SelectedIndex = 0;
        }
        else
        {
            move2list.SelectedIndex = BitConverter.ToUInt16(temparray, 24);
        }
        if (BitConverter.ToUInt16(temparray, 26) > move3list.Items.Count)
        {
            move3list.SelectedIndex = 0;
        }
        else
        {
            move3list.SelectedIndex = BitConverter.ToUInt16(temparray, 26);
        }
        if (BitConverter.ToUInt16(temparray, 28) > move4list.Items.Count)
        {
            move4list.SelectedIndex = 0;
        }
        else
        {
            move4list.SelectedIndex = BitConverter.ToUInt16(temparray, 28);
        }
        byte[] array = new byte[26];
        string text = "";
        for (int i = 0; i < 26; i++)
        {
            array[i] = temparray[30 + i];
        }
        text = Encoding.Unicode.GetString(array);
        otnamebox.Text = text;
        if (FirstStringLoad)
        {
            byte[] bytes = new byte[2];
            int length = 0;
            int num = 0;
            num = ((otnamebox.Text.Length - 1 >= 11) ? 11 : (otnamebox.Text.Length - 1));
            for (int num2 = num; num2 >= 0; num2--)
            {
                if (otnamebox.Text.Substring(num2, 1) != Encoding.Unicode.GetString(bytes))
                {
                    length = num2 + 1;
                    break;
                }
            }
            otnamebox.Text = otnamebox.Text.Substring(0, length);
            FirstStringLoad = false;
        }
        if (temparray[60] > languagebox.Items.Count)
        {
            languagebox.SelectedIndex = 0;
        }
        else
        {
            languagebox.SelectedIndex = temparray[60];
        }
        if (temparray[58] > ribbonlist.Items.Count - 1)
        {
            ribbonlist.SelectedIndex = 100;
        }
        else
        {
            ribbonlist.SelectedIndex = temparray[58];
        }
        if (temparray[59] > _gender.Items.Count)
        {
            _gender.SelectedIndex = 3;
        }
        else
        {
            _gender.SelectedIndex = temparray[59];
        }
    }

    private void WRLoadItemsBDSP(bool mode)
    {
        WRTabs.SelectedIndex = 2;
        if (mode)
        {
            itembox1.DataSource = statuebox.DataSource;
            itembox2.DataSource = statuebox.DataSource;
            itembox3.DataSource = statuebox.DataSource;
            itembox4.DataSource = statuebox.DataSource;
            itembox5.DataSource = statuebox.DataSource;
            itembox6.DataSource = statuebox.DataSource;
            itembox7.DataSource = statuebox.DataSource;
            itembox1.Items.Clear();
            itembox1.Items.AddRange(statuebox.Items.Cast<object>().ToArray());
            itembox2.Items.Clear();
            itembox2.Items.AddRange(statuebox.Items.Cast<object>().ToArray());
            itembox3.Items.Clear();
            itembox3.Items.AddRange(statuebox.Items.Cast<object>().ToArray());
            itembox4.Items.Clear();
            itembox4.Items.AddRange(statuebox.Items.Cast<object>().ToArray());
            itembox5.Items.Clear();
            itembox5.Items.AddRange(statuebox.Items.Cast<object>().ToArray());
            itembox6.Items.Clear();
            itembox6.Items.AddRange(statuebox.Items.Cast<object>().ToArray());
            itembox7.Items.Clear();
            itembox7.Items.AddRange(statuebox.Items.Cast<object>().ToArray());
        }
        else
        {
            itembox1.DataSource = GameInfo.Strings.GetItemStrings(EntityContext.Gen8b, sav.Version).ToArray().Clone();
            itembox2.DataSource = GameInfo.Strings.GetItemStrings(EntityContext.Gen8b, sav.Version).ToArray().Clone();
            itembox3.DataSource = GameInfo.Strings.GetItemStrings(EntityContext.Gen8b, sav.Version).ToArray().Clone();
            itembox4.DataSource = GameInfo.Strings.GetItemStrings(EntityContext.Gen8b, sav.Version).ToArray().Clone();
            itembox5.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox6.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
            itembox7.DataSource = GameInfo.Strings.GetItemStrings(sav.Context, sav.Version).ToArray().Clone();
        }
        if (BitConverter.ToUInt16(temparray, 64) > helditem.Items.Count)
        {
            itembox1.SelectedIndex = 0;
        }
        else
        {
            itembox1.SelectedIndex = BitConverter.ToUInt16(temparray, 64);
        }
        nitem1.Text = BitConverter.ToUInt16(temparray, 66).ToString();
        if (BitConverter.ToUInt16(temparray, 80) > helditem.Items.Count)
        {
            itembox2.SelectedIndex = 0;
        }
        else
        {
            itembox2.SelectedIndex = BitConverter.ToUInt16(temparray, 80);
        }
        nitem2.Text = BitConverter.ToUInt16(temparray, 82).ToString();
        if (BitConverter.ToUInt16(temparray, 96) > helditem.Items.Count)
        {
            itembox3.SelectedIndex = 0;
        }
        else
        {
            itembox3.SelectedIndex = BitConverter.ToUInt16(temparray, 96);
        }
        nitem3.Text = BitConverter.ToUInt16(temparray, 98).ToString();
        if (BitConverter.ToUInt16(temparray, 112) > helditem.Items.Count)
        {
            itembox4.SelectedIndex = 0;
        }
        else
        {
            itembox4.SelectedIndex = BitConverter.ToUInt16(temparray, 112);
        }
        nitem4.Text = BitConverter.ToUInt16(temparray, 114).ToString();
        if (BitConverter.ToUInt16(temparray, 128) > helditem.Items.Count)
        {
            itembox5.SelectedIndex = 0;
        }
        else
        {
            itembox5.SelectedIndex = BitConverter.ToUInt16(temparray, 128);
        }
        nitem5.Text = BitConverter.ToUInt16(temparray, 130).ToString();
        if (BitConverter.ToUInt16(temparray, 144) > helditem.Items.Count)
        {
            itembox6.SelectedIndex = 0;
        }
        else
        {
            itembox6.SelectedIndex = BitConverter.ToUInt16(temparray, 144);
        }
        nitem6.Text = BitConverter.ToUInt16(temparray, 146).ToString();
        if (BitConverter.ToUInt16(temparray, 160) > helditem.Items.Count)
        {
            itembox7.SelectedIndex = 0;
        }
        else
        {
            itembox7.SelectedIndex = BitConverter.ToUInt16(temparray, 160);
        }
        nitem7.Text = BitConverter.ToUInt16(temparray, 162).ToString();
    }

    private void WRLoadMoneyBDSP()
    {
        WRTabs.SelectedIndex = EntryTypeBox.SelectedIndex;
        moneyamount.Text = BitConverter.ToUInt16(temparray, 48).ToString();
        moneylc.Text = temparray[13].ToString();
    }

    private void WRLoadClothesBDSP()
    {
        WRTabs.SelectedIndex = 4;
        if (BitConverter.ToInt32(temparray, 176) > d1.Items.Count)
        {
            d1.SelectedIndex = 0;
        }
        else
        {
            d1.SelectedIndex = BitConverter.ToInt32(temparray, 176);
        }
        if (BitConverter.ToInt32(temparray, 180) > d1.Items.Count)
        {
            d2.SelectedIndex = 0;
        }
        else
        {
            d2.SelectedIndex = BitConverter.ToInt32(temparray, 180);
        }
        if (BitConverter.ToInt32(temparray, 184) > d1.Items.Count)
        {
            d3.SelectedIndex = 0;
        }
        else
        {
            d3.SelectedIndex = BitConverter.ToInt32(temparray, 184);
        }
        if (BitConverter.ToInt32(temparray, 188) > d1.Items.Count)
        {
            d4.SelectedIndex = 0;
        }
        else
        {
            d4.SelectedIndex = BitConverter.ToInt32(temparray, 188);
        }
        if (BitConverter.ToInt32(temparray, 192) > d1.Items.Count)
        {
            d5.SelectedIndex = 0;
        }
        else
        {
            d5.SelectedIndex = BitConverter.ToInt32(temparray, 192);
        }
        if (BitConverter.ToInt32(temparray, 196) > d1.Items.Count)
        {
            d6.SelectedIndex = 0;
        }
        else
        {
            d6.SelectedIndex = BitConverter.ToInt32(temparray, 196);
        }
        if (BitConverter.ToInt32(temparray, 200) > d1.Items.Count)
        {
            d7.SelectedIndex = 0;
        }
        else
        {
            d7.SelectedIndex = BitConverter.ToInt32(temparray, 200);
        }
    }

    public string desccall_bdsp(uint selectedboxvalue, string gifttitle)
    {
        switch (selectedboxvalue)
        {
            case 0u:
                gifttitle = SpeciesBox.Text + " Gift";
                break;
            case 1u:
                gifttitle = "Pokémon Egg Gift";
                break;
            case 2u:
                gifttitle = "Pokémon Gift";
                break;
            case 3u:
                if (Convert.ToUInt16(nitem1.Text) > 1)
                {
                    itemnameplural.SelectedIndex = itembox1.SelectedIndex;
                    gifttitle = itemnameplural.Text + " Gift";
                }
                else
                {
                    gifttitle = itembox1.Text + " Gift";
                }
                break;
            case 4u:
                gifttitle = "Item Set Gift";
                break;
            case 5u:
                gifttitle = "Item Gift";
                break;
            case 6u:
                gifttitle = "Dynamax Crystal Gift";
                break;
            case 7u:
                gifttitle = "Curry Ingredient Gift";
                break;
            case 8u:
                gifttitle = "[VAR 0104(0001)] " + SpeciesBox.Text + " Gift";
                break;
            case 9u:
                gifttitle = "Legendary Pokémon " + SpeciesBox.Text + " Gift";
                break;
            case 10u:
                gifttitle = "Mythical Pokémon " + SpeciesBox.Text + " Gift";
                break;
            case 11u:
                gifttitle = otnamebox.Text + "'s " + SpeciesBox.Text + " Gift";
                break;
            case 12u:
                gifttitle = "Shiny " + SpeciesBox.Text + " Gift";
                break;
            case 13u:
                gifttitle = RefinedSpeciesBox.Text + " Gift";
                break;
            case 14u:
                {
                    string text = RefinedSpeciesBox.Text.Replace(SpeciesBox.Text, "").Replace("(", "").Replace(")", "")
                        .Remove(0, 1);
                    gifttitle = text + " Gift";
                    break;
                }
            case 15u:
                gifttitle = "Hidden Ability " + SpeciesBox.Text + " Gift";
                break;
            case 16u:
                gifttitle = SpeciesBox.Text + " with " + move1list.Text + " Gift";
                break;
            case 17u:
                gifttitle = SpeciesBox.Text + " with " + move2list.Text + " Gift";
                break;
            case 18u:
                gifttitle = SpeciesBox.Text + " with " + move3list.Text + " Gift";
                break;
            case 19u:
                gifttitle = SpeciesBox.Text + " with " + move4list.Text + " Gift";
                break;
            case 20u:
                gifttitle = SpeciesBox.Text + " and " + helditem.Text + " Gift";
                break;
            case 21u:
                gifttitle = "Gigantamax " + SpeciesBox.Text + " Gift";
                break;
            case 22u:
                gifttitle = SpeciesBox.Text + " " + ribbondescboxb.Text + " Gift";
                break;
            case 23u:
                gifttitle = "Downloadable Version Purchase Bonus";
                break;
            case 24u:
                gifttitle = "Special Pack Purchase Bonus";
                break;
            case 25u:
                gifttitle = "Store Purchase Bonus";
                break;
            case 26u:
                gifttitle = "Strategy Guide Purchase Bonus";
                break;
            case 27u:
                gifttitle = "Purchase Bonus";
                break;
            case 28u:
                gifttitle = "Happy Birthday!";
                break;
            case 29u:
                gifttitle = "Virtual Console Purchase Bonus";
                break;
            case 30u:
                gifttitle = "Pokémon Trainer Club Gift";
                break;
            case 31u:
                gifttitle = "Pokémon Global Link Gift";
                break;
            case 32u:
                gifttitle = "Pokémon Bank Gift";
                break;
            case 33u:
                gifttitle = "Pokémon HOME";
                break;
            case 34u:
                gifttitle = "Pocket Money Gift";
                break;
            case 35u:
                gifttitle = "₱" + moneyamount.Text + " Cash Back";
                break;
            case 36u:
                gifttitle = "Clothing Gift";
                break;
            case 37u:
                gifttitle = "Ranked Battle Reward";
                break;
            case 38u:
                gifttitle = "Online Competition Participation Gift";
                break;
            case 39u:
                gifttitle = "BP Gift";
                break;
            case 40u:
                gifttitle = "Official Competition Item Gift";
                break;
            case 41u:
                gifttitle = "Official Competition BP Gift";
                break;
            case 42u:
                gifttitle = "Official Competition Pokémon Gift";
                break;
            case 43u:
                gifttitle = "Official Competition Egg Gift";
                break;
            case 44u:
                gifttitle = "Official Competition Clothing Gift";
                break;
            case 45u:
                gifttitle = "Singles Season " + seasonbox.Text + " Item Gift";
                break;
            case 46u:
                gifttitle = "Singles Season " + seasonbox.Text + " BP Gift";
                break;
            case 47u:
                gifttitle = "Singles Season " + seasonbox.Text + " Pokémon Gift";
                break;
            case 48u:
                gifttitle = "Singles Season " + seasonbox.Text + " Egg Gift";
                break;
            case 49u:
                gifttitle = "Singles Season " + seasonbox.Text + " Clothing Gift";
                break;
            case 50u:
                gifttitle = "Doubles Season " + seasonbox.Text + " Item Gift";
                break;
            case 51u:
                gifttitle = "Doubles Season " + seasonbox.Text + " BP Gift";
                break;
            case 52u:
                gifttitle = "Doubles Season " + seasonbox.Text + " Pokémon Gift";
                break;
            case 53u:
                gifttitle = "Doubles Season " + seasonbox.Text + " Egg Gift";
                break;
            case 54u:
                gifttitle = "Doubles Season " + seasonbox.Text + " Clothing Gift";
                break;
            case 55u:
                gifttitle = "Pokémon Statue Gift";
                break;
            case 56u:
                gifttitle = "(blank) Gift";
                break;
            case 57u:
                gifttitle = "Manaphy Egg Gift";
                break;
            default:
                gifttitle = SpeciesBox.Text + "[ID " + selectedboxvalue + "]";
                break;
        }
        return gifttitle;
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
        ushort num2 = BitConverter.ToUInt16(temp_wr_array, 16);
        byte b = temp_wr_array[18];
        int num3 = temp_wr_array[10];
        int num4 = temp_wr_array[57];
        int num5 = BitConverter.ToUInt16(temp_wr_array, 20);
        int tempitem = BitConverter.ToUInt16(temp_wr_array, 64);
        int num6 = temp_wr_array[59];
        Shiny shiny = Shiny.Never;
        bool flag = false;
        bool flag2 = false;
        if (num3 == 12)
        {
            shiny = Shiny.Always;
        }
        if (num4 == 1)
        {
            flag = true;
        }
        if (num3 == 21)
        {
            flag2 = true;
        }
        switch (num)
        {
            case 0:
                return null;
            case 1:
                image = SpriteUtil.GetSprite(num2, b, num6, 0u, num5, flag, shiny, EntityContext.None);
                if (flag2)
                {
                    Bitmap dyna = PKHeX.Drawing.PokeSprite.Properties.Resources.dyna;
                    image = ImageUtil.LayerImage(image, dyna, (image.Width - dyna.Width) / 2, 0);
                }
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

    private void TimestampBox_TextChanged(object sender, EventArgs e)
    {
        if (!(InitialLoad | EditingTimeStamp))
        {
            TimeStampReader();
        }
    }

    private void TimeStampReader()
    {
        NumericUpDown numericUpDown = YearBox;
        if (string.IsNullOrEmpty(TimestampBox.Text) | (TimestampBox.Text == "0") | !ulong.TryParse(TimestampBox.Text, out var _))
        {
            LoadingTimeStamp = true;
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
            long num = long.Parse(TimestampBox.Text);
            DateTimeOffset dateTimeOffset;
            if (num < 95649080399L)
            {
                dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(num);
            }
            else
            {
                DateTime dateTime = DateTime.FromFileTimeUtc(num);
                dateTimeOffset = dateTime;
            }
            YearBox.Text = dateTimeOffset.Year.ToString();
            MonthBox.Text = dateTimeOffset.Month.ToString();
            DayBox.Text = dateTimeOffset.Day.ToString();
            HourBox.Text = dateTimeOffset.Hour.ToString();
            MinBox.Text = dateTimeOffset.Minute.ToString();
            SecBox.Text = dateTimeOffset.Second.ToString();
            LoadingTimeStamp = false;
        }
    }

    private void ExtractWR8Button_Click(object sender, EventArgs e)
    {
        int num = (int)SlotIndex.Value;
        using SaveFileDialog saveFileDialog = new SaveFileDialog
        {
            FileName = "",
            Filter = "WRB8 files (*.wrb8)|*.wrb8",
            FilterIndex = 0,
            RestoreDirectory = true
        };
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllBytes(saveFileDialog.FileName, temparray);
        }
    }

    private void InsertWR8Button_Click(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "WRB8 files (*.wrb8)|*.wrb8",
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
        byte[] array = File.ReadAllBytes(path);
        if (array.Length != 224)
        {
            MessageBox.Show(MessageStrings.MsgFileLoadIncompatible);
            return;
        }
        byte[] array2 = new byte[224];
        array2 = File.ReadAllBytes(path);
        Write_WRB8_to_block(array2);
    }

    private void Write_WRB8_to_block(byte[] tempWR8)
    {
        for (int i = 0; i < 224; i++)
        {
            sav.Data[957416 + (int)SlotIndex.Value * 224 + i] = tempWR8[i];
        }
        update_wrblock();
        UpdateEntriesBDSP(WRBlock, (int)SlotIndex.Value);
        loadslots();
    }

    private void DeleteWR8Button_Click(object sender, EventArgs e)
    {
        Array.Clear(temparray, 0, temparray.Length);
        Write_WRB8_to_block(temparray);
    }

    private void timestampfixing(byte[] tempWR8)
    {
        long num = BitConverter.ToInt64(tempWR8, 0);
        DateTimeOffset dateTimeOffset;
        if (num < 95649080399L)
        {
            dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(num);
        }
        else
        {
            DateTime dateTime = DateTime.FromFileTimeUtc(num);
            dateTimeOffset = dateTime;
        }
        if (SlotIndex.Value == 0m)
        {
            int num2 = (int)(dateTimeOffset - new DateTime(1970, 1, 1)).TotalSeconds - 39600;
            tempWR8[0] = (byte)((ulong)num2 & 0xFFuL);
            tempWR8[1] = (byte)(((long)num2 >> 8) & 0xFF);
            tempWR8[2] = (byte)(((long)num2 >> 16) & 0xFF);
            tempWR8[3] = (byte)(((long)num2 >> 24) & 0xFF);
            tempWR8[4] = 0;
            tempWR8[5] = 0;
            tempWR8[6] = 0;
            tempWR8[7] = 0;
        }
        else
        {
            tempWR8[7] = (byte)((dateTimeOffset.ToFileTime() >> 56) & 0xFF);
            tempWR8[6] = (byte)((dateTimeOffset.ToFileTime() >> 48) & 0xFF);
            tempWR8[5] = (byte)((dateTimeOffset.ToFileTime() >> 40) & 0xFF);
            tempWR8[4] = (byte)((dateTimeOffset.ToFileTime() >> 32) & 0xFF);
            tempWR8[3] = (byte)((dateTimeOffset.ToFileTime() >> 24) & 0xFF);
            tempWR8[2] = (byte)((dateTimeOffset.ToFileTime() >> 16) & 0xFF);
            tempWR8[1] = (byte)((dateTimeOffset.ToFileTime() >> 8) & 0xFF);
            tempWR8[0] = (byte)(dateTimeOffset.ToFileTime() & 0xFF);
        }
    }

    private void WC8_2_WR8_Button_Click(object sender, EventArgs e)
    {
        MessageBox.Show("There's no plans for this.");
    }

    private void WB8_Load(string path)
    {
        byte[] array = File.ReadAllBytes(path);
        if (array.Length != 732)
        {
            MessageBox.Show(MessageStrings.MsgFileLoadIncompatible);
            return;
        }
        byte[] array2 = new byte[732];
        array2 = File.ReadAllBytes(path);
        byte[] array3 = new byte[224];
        ushort value = BitConverter.ToUInt16(array2, 8);
        BitConverter.GetBytes(value).CopyTo(array3, 8);
        uint num = array2[18];
        array3[10] = (byte)num;
        uint num2 = array2[17];
        array3[12] = (byte)num2;
        switch (num2)
        {
            case 1u:
                WB8_Pokemon(array3, array2);
                break;
            case 2u:
                WB8_Items(array3, array2);
                break;
        }
    }

    private void WB8_Pokemon(byte[] tempWC8_2_WR8, byte[] tempWC8)
    {
        ushort value = BitConverter.ToUInt16(tempWC8, 630);
        BitConverter.GetBytes(value).CopyTo(tempWC8_2_WR8, 20);
        tempWC8_2_WR8[57] = tempWC8[653];
        ushort value2 = BitConverter.ToUInt16(tempWC8, 648);
        BitConverter.GetBytes(value2).CopyTo(tempWC8_2_WR8, 16);
        tempWC8_2_WR8[18] = tempWC8[650];
        int[] array = new int[11]
        {
            0, 362, 394, 426, 458, 490, 0, 522, 554, 586,
            618
        };
        int[] array2 = new int[11]
        {
            0, 74, 106, 138, 170, 202, 0, 234, 266, 298,
            330
        };
        int num = 0;
        for (int i = 0; i < 27; i++)
        {
            tempWC8_2_WR8[i + 30] = tempWC8[i + array[sav.Language]];
            num += tempWC8[i + array[sav.Language]];
        }
        if (num == 0)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(sav.OT);
            int num2 = 0;
            byte[] array3 = bytes;
            for (int j = 0; j < array3.Length; j++)
            {
                byte b = (tempWC8_2_WR8[num2 + 30] = array3[j]);
                num2++;
            }
        }
        if ((num == 0) | (tempWC8[696] == 3))
        {
            tempWC8_2_WR8[56] = (byte)sav.Gender;
        }
        else
        {
            tempWC8_2_WR8[56] = tempWC8[696];
        }
        if (tempWC8[array2[sav.Language]] == 0)
        {
            tempWC8_2_WR8[60] = (byte)sav.Language;
        }
        else
        {
            tempWC8_2_WR8[60] = tempWC8[array2[sav.Language]];
        }
        ushort value3 = BitConverter.ToUInt16(tempWC8, 640);
        BitConverter.GetBytes(value3).CopyTo(tempWC8_2_WR8, 22);
        ushort value4 = BitConverter.ToUInt16(tempWC8, 642);
        BitConverter.GetBytes(value4).CopyTo(tempWC8_2_WR8, 24);
        ushort value5 = BitConverter.ToUInt16(tempWC8, 644);
        BitConverter.GetBytes(value5).CopyTo(tempWC8_2_WR8, 26);
        ushort value6 = BitConverter.ToUInt16(tempWC8, 646);
        BitConverter.GetBytes(value6).CopyTo(tempWC8_2_WR8, 28);
        if (tempWC8[654] == byte.MaxValue)
        {
            tempWC8_2_WR8[58] = 98;
        }
        else
        {
            tempWC8_2_WR8[58] = tempWC8[654];
        }
        tempWC8_2_WR8[59] = tempWC8[651];
        Write_WRB8_to_block(tempWC8_2_WR8);
    }

    private void WB8_Items(byte[] tempWC8_2_WR8, byte[] tempWC8)
    {
        for (int i = 0; i < 7; i++)
        {
            ushort value = BitConverter.ToUInt16(tempWC8, 32 + i * 16);
            BitConverter.GetBytes(value).CopyTo(tempWC8_2_WR8, 64 + i * 16);
            BitConverter.GetBytes(BitConverter.ToUInt16(tempWC8, 34 + i * 16)).CopyTo(tempWC8_2_WR8, 66 + i * 16);
        }
        Write_WRB8_to_block(tempWC8_2_WR8);
    }

    private void WC8_Money(byte[] tempWC8_2_WR8, byte[] tempWC8)
    {
        tempWC8_2_WR8[48] = tempWC8[32];
        Write_WRB8_to_block(tempWC8_2_WR8);
    }

    private void WC8_Clothes(byte[] tempWC8_2_WR8, byte[] tempWC8)
    {
        ushort num = 0;
        switch (sav.Gender)
        {
            case 0:
                num = 32;
                break;
            case 1:
                num = 80;
                break;
        }
        for (int i = 0; i < 48; i++)
        {
            tempWC8_2_WR8[48 + i] = tempWC8[num + i];
        }
        int num2 = 0;
        uint num3 = 0u;
        for (int j = 0; j < 6; j++)
        {
            num3 = BitConverter.ToUInt32(tempWC8_2_WR8, 52 + j * 8);
            if (num3 != uint.MaxValue)
            {
                num2++;
            }
        }
        tempWC8_2_WR8[13] = (byte)num2;
        Write_WRB8_to_block(tempWC8_2_WR8);
    }
}
