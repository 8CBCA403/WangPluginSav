using PKHeX.Core;
using PKHeX.Drawing;
using PKHeX.Drawing.PokeSprite;
using PKHeX.Drawing.PokeSprite.Properties;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text;

namespace NXWonderRecord;

partial class WonderRecordPLA : Form
{
    private readonly int WR_SIZE = 632;

    private bool FirstStringLoad = true;

    private readonly SaveFile sav;

    private int ClickedSlot = 0;

    private Dictionary<object, object> dic;

    private bool InitialLoad = false;

    private SCBlock WRBlock;

    private IDictionary<string, string> alt_dict = new Dictionary<string, string>();

    private IDictionary<string, string> alt_dex = new Dictionary<string, string>();

    private byte[] temparray = new byte[632];

    private bool global_isshiny = false;

    private bool LoadingTimeStamp = false;

    private bool EditingTimeStamp = false;



    public WonderRecordPLA(SaveFile sav)
    {
        this.sav = sav;
        InitializeComponent();
        InitialLoad = true;
        InitialLoading();
        if (sav is SAV8LA sAV8LA)
        {
            WRBlock = sAV8LA.Blocks.GetBlock(2581684830u);
            InitialLoad = false;
            ((PictureBox)base.Controls["pictureBox" + 1]).BorderStyle = BorderStyle.Fixed3D;
            UpdateEntriesPLA(WRBlock, 0);
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
            relearn1.Items.Clear();
            relearn2.Items.Clear();
            relearn3.Items.Clear();
            relearn4.Items.Clear();
            relearn1.DataSource = GameInfo.Strings.movelist.Clone();
            relearn2.DataSource = GameInfo.Strings.movelist.Clone();
            relearn3.DataSource = GameInfo.Strings.movelist.Clone();
            relearn4.DataSource = GameInfo.Strings.movelist.Clone();
            relearn1.SelectedIndex = 0;
            relearn2.SelectedIndex = 0;
            relearn3.SelectedIndex = 0;
            relearn4.SelectedIndex = 0;
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
            lang_filter.SelectedIndex = 0;
        }
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
        alt_dict.Add(new KeyValuePair<string, string>("58_1", "Growlithe (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("59_1", "Arcanine (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("59_2", "Arcanine (Lord)"));
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
        alt_dict.Add(new KeyValuePair<string, string>("88_1", "Grimer (Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("89_1", "Muk (Alola)"));
        alt_dict.Add(new KeyValuePair<string, string>("94_1", "Mega Gengar"));
        alt_dict.Add(new KeyValuePair<string, string>("100_1", "Voltorb (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("101_1", "Electrode (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("101_2", "Electrode (Lord)"));
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
        alt_dict.Add(new KeyValuePair<string, string>("157_1", "Typhlosion (Hisui)"));
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
        alt_dict.Add(new KeyValuePair<string, string>("211_1", "Qwilfish (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("212_1", "Mega Scizor"));
        alt_dict.Add(new KeyValuePair<string, string>("214_1", "Mega Heracross"));
        alt_dict.Add(new KeyValuePair<string, string>("215_1", "Sneasel (Hisui)"));
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
        alt_dict.Add(new KeyValuePair<string, string>("483_1", "Origin Dialga"));
        alt_dict.Add(new KeyValuePair<string, string>("484_1", "Origin Palkia"));
        alt_dict.Add(new KeyValuePair<string, string>("487_0", "Altered Giratina"));
        alt_dict.Add(new KeyValuePair<string, string>("487_1", "Origin Giratina"));
        alt_dict.Add(new KeyValuePair<string, string>("492_0", "Land Shaymin"));
        alt_dict.Add(new KeyValuePair<string, string>("492_1", "Sky Shaymin"));
        alt_dict.Add(new KeyValuePair<string, string>("503_1", "Samurott (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("531_1", "Mega Audino"));
        alt_dict.Add(new KeyValuePair<string, string>("549_1", "Lilligant (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("549_2", "Lilligant (Lord)"));
        alt_dict.Add(new KeyValuePair<string, string>("550_1", "Basculin (Blue)"));
        alt_dict.Add(new KeyValuePair<string, string>("550_0", "Basculin (Red)"));
        alt_dict.Add(new KeyValuePair<string, string>("550_2", "Basculin (White)"));
        alt_dict.Add(new KeyValuePair<string, string>("554_1", "Darumaka (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("555_1", "Darmanitan (Zen)"));
        alt_dict.Add(new KeyValuePair<string, string>("555_3", "Darmanitan (Zen Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("555_2", "Darmanitan (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("562_1", "Yamask (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("570_1", "Zorua (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("571_1", "Zoroark (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("618_1", "Stunfisk (Galar)"));
        alt_dict.Add(new KeyValuePair<string, string>("628_1", "Braviary (Hisui)"));
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
        alt_dict.Add(new KeyValuePair<string, string>("705_1", "Sliggoo (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("706_1", "Goodra (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("710_0", "Average Pumpkaboo"));
        alt_dict.Add(new KeyValuePair<string, string>("710_1", "Pumpkaboo (Small)"));
        alt_dict.Add(new KeyValuePair<string, string>("710_2", "Pumpkaboo (Large)"));
        alt_dict.Add(new KeyValuePair<string, string>("710_3", "Pumpkaboo (Super)"));
        alt_dict.Add(new KeyValuePair<string, string>("711_0", "Average Gourgeist"));
        alt_dict.Add(new KeyValuePair<string, string>("711_1", "Gourgeist (Small)"));
        alt_dict.Add(new KeyValuePair<string, string>("711_2", "Gourgeist (Large)"));
        alt_dict.Add(new KeyValuePair<string, string>("711_3", "Gourgeist (Super)"));
        alt_dict.Add(new KeyValuePair<string, string>("713_1", "Avalugg (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("713_2", "Avalugg (Lord)"));
        alt_dict.Add(new KeyValuePair<string, string>("718_1", "10% Zygarde"));
        alt_dict.Add(new KeyValuePair<string, string>("718_2", "10% Zygarde"));
        alt_dict.Add(new KeyValuePair<string, string>("718_3", "50% Zygarde"));
        alt_dict.Add(new KeyValuePair<string, string>("718_4", "Perfect Zygarde"));
        alt_dict.Add(new KeyValuePair<string, string>("719_1", "Mega Diancie"));
        alt_dict.Add(new KeyValuePair<string, string>("720_1", "Unbound Hoopa"));
        alt_dict.Add(new KeyValuePair<string, string>("724_1", "Decidueye (Hisui)"));
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
        alt_dict.Add(new KeyValuePair<string, string>("902_1", "Basculegion"));
        alt_dict.Add(new KeyValuePair<string, string>("902_2", "Basculegion"));
        alt_dict.Add(new KeyValuePair<string, string>("903_1", "Sneasler (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("904_1", "Overqwil (Hisui)"));
        alt_dict.Add(new KeyValuePair<string, string>("905_0", "Incarnate Enamorus"));
        alt_dict.Add(new KeyValuePair<string, string>("905_1", "Therian Enamorus"));
        alt_dex.Add(new KeyValuePair<string, string>("58_1", "Scout Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("77_1", "Unique Horn Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("78_1", "Unique Horn Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("100_1", "Sphere Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("101_1", "Sphere Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("101_2", "Sphere Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("122_1", "Dancing Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("144_1", "Cruel Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("145_1", "Strong Legs Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("146_1", "Malevolent Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("157_1", "Ghost Flame Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("199_1", "Hexpert Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("549_1", "Spinning Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("549_2", "Spinning Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("550_2", "Mellow Pokémon"));
        alt_dex.Add(new KeyValuePair<string, string>("555_2", "Zen Charm Pokémon"));
    }

    public string desccall_pla(uint selectedboxvalue, string gifttitle)
    {
        string text = AltDexFinder();
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
                gifttitle = text + " " + SpeciesBox.Text + " Gift";
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
                    string text2 = RefinedSpeciesBox.Text.Replace(SpeciesBox.Text, "").Replace("(", "").Replace(")", "")
                        .Remove(0, 1);
                    gifttitle = text2 + " Gift";
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

    private string AltDexFinder()
    {
        string text = "";
        if (alt_dex.ContainsKey(SpeciesBox.SelectedIndex + "_" + FormBox.Value))
        {
            return alt_dex[SpeciesBox.SelectedIndex + "_" + FormBox.Value];
        }
        pokedextype.SelectedIndex = SpeciesBox.SelectedIndex;
        return pokedextype.Text;
    }

    public void UpdateEntriesPLA(SCBlock TempBlock, int Index)
    {
        if (!InitialLoad)
        {
            Array.Clear(temparray, 0, temparray.Length);
            int num = 0;
            for (num = 0; num < WR_SIZE; num++)
            {
                temparray[num] = TempBlock.Data[num + Index * WR_SIZE];
            }
            TimestampBox.Text = BitConverter.ToUInt64(temparray, 0).ToString();
            WCIDBox.Value = BitConverter.ToUInt16(temparray, 8);
            if (temparray[12] < 58)
            {
                CardTitleRawBox.SelectedIndex = temparray[12];
            }
            else
            {
                CardTitleRawBox.SelectedIndex = 58;
            }
            if (temparray[14] < 7)
            {
                EntryTypeBox.SelectedIndex = temparray[14];
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
                    WRLoadPokemonPLA();
                    SpeciesImageSelector();
                    break;
                case 2:
                    WRLoadItemsPLA();
                    SpeciesImageSelector();
                    break;
                case 3:
                    WRLoadClothesPLA();
                    SpeciesImageSelector();
                    break;
            }
            CardTitleRefinedBox.Text = desccall_pla((uint)CardTitleRawBox.SelectedIndex, "");
        }
    }

    private void WRLoadPokemonPLA()
    {
        WRTabs.SelectedIndex = 1;
        helditem.Text = "";
        isegg.Checked = false;
        if (BitConverter.ToUInt16(temparray, 560) > SpeciesBox.Items.Count)
        {
            SpeciesBox.SelectedIndex = 0;
        }
        else
        {
            SpeciesBox.SelectedIndex = BitConverter.ToUInt16(temparray, 560);
        }
        if (temparray[562] > 33)
        {
            FormBox.Text = 0.ToString();
        }
        else
        {
            FormBox.Text = temparray[562].ToString();
        }
        RefinedSpeciesBox.Text = NameFinder();
        ComboBox comboBox = move1list;
        int num = 0;
        for (int i = 0; i < 8; i++)
        {
            switch (i)
            {
                case 0:
                    comboBox = move1list;
                    break;
                case 1:
                    comboBox = move2list;
                    break;
                case 2:
                    comboBox = move3list;
                    break;
                case 3:
                    comboBox = move4list;
                    break;
                case 4:
                    comboBox = relearn1;
                    break;
                case 5:
                    comboBox = relearn2;
                    break;
                case 6:
                    comboBox = relearn3;
                    break;
                case 7:
                    comboBox = relearn4;
                    break;
            }
            num = 544 + i * 2;
            if (BitConverter.ToUInt16(temparray, num) > move1list.Items.Count)
            {
                comboBox.SelectedIndex = 0;
            }
            else
            {
                comboBox.SelectedIndex = BitConverter.ToUInt16(temparray, num);
            }
        }
        uint num2 = BitConverter.ToUInt32(temparray, 16);
        string text = num2.ToString().PadLeft(10, '0');
        ftid_box.Text = "(" + text.Substring(0, 4) + ") " + text.Substring(4, 6);
        ulong num3 = BitConverter.ToUInt32(temparray, 28);
        ulong num4 = (num3 >> 16) & 0xFF;
        ulong num5 = num3 & 0xFF;
        ulong num6 = (num2 >> 16) & 0xFFu;
        ulong num7 = num2 & 0xFFu;
        ulong num8 = num4 ^ num5 ^ (num6 ^ num7);
        if (num8 < 16)
        {
            global_isshiny = true;
        }
        else
        {
            global_isshiny = false;
        }
        byte[] array = new byte[26];
        string text2 = "";
        ulong num9 = 0uL;
        byte[] bytes = new byte[2];
        int length = 0;
        int num10 = 0;
        TextBox textBox = jpn_box;
        if (FirstStringLoad)
        {
            for (int j = 0; j < 9; j++)
            {
                switch (j)
                {
                    case 0:
                        textBox = jpn_box;
                        break;
                    case 1:
                        textBox = eng_box;
                        break;
                    case 2:
                        textBox = fre_box;
                        break;
                    case 3:
                        textBox = ger_box;
                        break;
                    case 4:
                        textBox = ita_box;
                        break;
                    case 5:
                        textBox = spa_box;
                        break;
                    case 6:
                        textBox = kor_box;
                        break;
                    case 7:
                        textBox = chs_box;
                        break;
                    case 8:
                        textBox = cht_box;
                        break;
                }
                num = 284 + j * 28;
                for (int k = 0; k < 26; k++)
                {
                    array[k] = temparray[num + k];
                }
                text2 = (textBox.Text = Encoding.Unicode.GetString(array));
                num10 = ((textBox.Text.Length - 1 >= 11) ? 11 : (textBox.Text.Length - 1));
                for (int num11 = num10; num11 >= 0; num11--)
                {
                    if (textBox.Text.Substring(num11, 1) != Encoding.Unicode.GetString(bytes))
                    {
                        length = num11 + 1;
                        break;
                    }
                }
                textBox.Text = textBox.Text.Substring(0, length);
            }
            FirstStringLoad = false;
        }
        if (temparray[567] > languagebox.Items.Count)
        {
            languagebox.SelectedIndex = 0;
        }
        else
        {
            languagebox.SelectedIndex = temparray[567];
        }
        if (languagebox.SelectedIndex > 5)
        {
            lang_filter.SelectedIndex = languagebox.SelectedIndex - 1;
        }
        else
        {
            lang_filter.SelectedIndex = languagebox.SelectedIndex;
        }
        if (temparray[588] > ribbonlist.Items.Count - 1)
        {
            ribbonlist.SelectedIndex = 100;
        }
        else
        {
            ribbonlist.SelectedIndex = temparray[588];
        }
    }

    private void WRLoadItemsPLA()
    {
        WRTabs.SelectedIndex = 2;
        if (BitConverter.ToUInt16(temparray, 16) > itembox1.Items.Count)
        {
            itembox1.SelectedIndex = 0;
        }
        else
        {
            itembox1.SelectedIndex = BitConverter.ToUInt16(temparray, 16);
        }
        nitem1.Text = BitConverter.ToUInt16(temparray, 18).ToString();
        if (BitConverter.ToUInt16(temparray, 20) > itembox2.Items.Count)
        {
            itembox2.SelectedIndex = 0;
        }
        else
        {
            itembox2.SelectedIndex = BitConverter.ToUInt16(temparray, 20);
        }
        nitem2.Text = BitConverter.ToUInt16(temparray, 22).ToString();
        if (BitConverter.ToUInt16(temparray, 24) > itembox3.Items.Count)
        {
            itembox3.SelectedIndex = 0;
        }
        else
        {
            itembox3.SelectedIndex = BitConverter.ToUInt16(temparray, 24);
        }
        nitem3.Text = BitConverter.ToUInt16(temparray, 26).ToString();
        if (BitConverter.ToUInt16(temparray, 28) > itembox4.Items.Count)
        {
            itembox4.SelectedIndex = 0;
        }
        else
        {
            itembox4.SelectedIndex = BitConverter.ToUInt16(temparray, 28);
        }
        nitem4.Text = BitConverter.ToUInt16(temparray, 30).ToString();
        if (BitConverter.ToUInt16(temparray, 32) > itembox5.Items.Count)
        {
            itembox5.SelectedIndex = 0;
        }
        else
        {
            itembox5.SelectedIndex = BitConverter.ToUInt16(temparray, 32);
        }
        nitem5.Text = BitConverter.ToUInt16(temparray, 34).ToString();
        if (BitConverter.ToUInt16(temparray, 36) > itembox6.Items.Count)
        {
            itembox6.SelectedIndex = 0;
        }
        else
        {
            itembox6.SelectedIndex = BitConverter.ToUInt16(temparray, 36);
        }
        nitem6.Text = BitConverter.ToUInt16(temparray, 38).ToString();
    }

    private void loadslots()
    {
        int num = 0;
        for (num = 0; num < 50; num++)
        {
            byte[] array = new byte[WR_SIZE];
            for (int i = 0; i < WR_SIZE; i++)
            {
                array[i] = WRBlock.Data[i + WR_SIZE * num];
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
            UpdateEntriesPLA(WRBlock, (int)SlotIndex.Value);
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
        int num = temp_wr_array[14];
        ushort num2 = BitConverter.ToUInt16(temp_wr_array, 560);
        byte b = temp_wr_array[562];
        int num3 = temp_wr_array[12];
        int num4 = 0;
        int num5 = 0;
        int tempitem = BitConverter.ToUInt16(temp_wr_array, 16);
        int num6 = 0;
        Shiny shiny = Shiny.Never;
        if (global_isshiny)
        {
            shiny = Shiny.Always;
        }
        bool flag = false;
        bool flag2 = false;
        if (num4 == 1)
        {
            flag = true;
        }
        if (num3 == 21)
        {
            flag2 = true;
        }
        SpriteUtil.ChangeMode(SpriteBuilderMode.CircleMugshot5668);
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

    private void SlotIndex_ValueChanged_1(object sender, EventArgs e)
    {
        if (!InitialLoad)
        {
            UpdateEntriesPLA(WRBlock, (int)SlotIndex.Value);
        }
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

    private string NameFinder()
    {
        string text = "";
        if (alt_dict.ContainsKey(SpeciesBox.SelectedIndex + "_" + FormBox.Value))
        {
            return alt_dict[SpeciesBox.SelectedIndex + "_" + FormBox.Value];
        }
        return SpeciesBox.Text;
    }

    private void ribbonlist_SelectedIndexChanged(object sender, EventArgs e)
    {
        ribbondesc.SelectedIndex = ribbonlist.SelectedIndex;
        ribbondescbox.Text = ribbondesc.Text;
        ribbondescb.SelectedIndex = ribbonlist.SelectedIndex;
        ribbondescboxb.Text = ribbondescb.Text;
    }

    private void ExtractWR8Button_Click(object sender, EventArgs e)
    {
        int num = (int)SlotIndex.Value;
        using SaveFileDialog saveFileDialog = new SaveFileDialog
        {
            FileName = "",
            Filter = "WRA8 files (*.wra8)|*.wra8",
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
            Filter = "WRA8 files (*.wra8)|*.wra8",
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
        if (array.Length != 632)
        {
            MessageBox.Show(MessageStrings.MsgFileLoadIncompatible);
            return;
        }
        byte[] array2 = new byte[632];
        array2 = File.ReadAllBytes(path);
        Write_WR8_to_block(array2);
    }

    private void Write_WR8_to_block(byte[] tempWR8)
    {
        for (int i = 0; i < 632; i++)
        {
            WRBlock.Data[i + (int)SlotIndex.Value * 632] = tempWR8[i];
        }
        UpdateEntriesPLA(WRBlock, (int)SlotIndex.Value);
        loadslots();
    }

    private void WC8_2_WR8_Button_Click(object sender, EventArgs e)
    {
        MessageBox.Show("There's no plans for this.");
    }

    private void DeleteWR8Button_Click(object sender, EventArgs e)
    {
        Array.Clear(temparray, 0, temparray.Length);
        Write_WR8_to_block(temparray);
    }

    private void lang_filter_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!InitialLoad)
        {
            TextBox textBox = jpn_box;
            switch (lang_filter.SelectedIndex)
            {
                case 0:
                    textBox = jpn_box;
                    break;
                case 1:
                    textBox = eng_box;
                    break;
                case 2:
                    textBox = fre_box;
                    break;
                case 3:
                    textBox = ger_box;
                    break;
                case 4:
                    textBox = ita_box;
                    break;
                case 5:
                    textBox = spa_box;
                    break;
                case 6:
                    textBox = kor_box;
                    break;
                case 7:
                    textBox = chs_box;
                    break;
                case 8:
                    textBox = cht_box;
                    break;
            }
            otnamebox.Text = textBox.Text;
        }
    }

    private void WRLoadClothesPLA()
    {
        WRTabs.SelectedIndex = 4;
        ComboBox comboBox = d1;
        ComboBox comboBox2 = d11;
        ComboBox comboBox3 = hat;
        ComboBox comboBox4 = hat_d;
        int num = 0;
        int num2 = 0;
        int num3 = 0;
        for (int i = 0; i < 6; i++)
        {
            num3 = 64 + i * 8;
            num = temparray[num3];
            num2 = temparray[num3 + 4];
            switch (i)
            {
                case 0:
                    comboBox = d1;
                    comboBox2 = d11;
                    break;
                case 1:
                    comboBox = d2;
                    comboBox2 = d21;
                    break;
                case 2:
                    comboBox = d3;
                    comboBox2 = d31;
                    break;
                case 3:
                    comboBox = d4;
                    comboBox2 = d41;
                    break;
                case 4:
                    comboBox = d5;
                    comboBox2 = d51;
                    break;
                case 5:
                    comboBox = d6;
                    comboBox2 = d61;
                    break;
            }
            switch (num)
            {
                case 0:
                    comboBox3 = hat;
                    comboBox4 = hat_d;
                    break;
                case 1:
                    comboBox3 = top;
                    comboBox4 = top_d;
                    break;
                case 2:
                    comboBox3 = bottoms;
                    comboBox4 = bottoms_d;
                    break;
                case 3:
                    comboBox3 = overalls;
                    comboBox4 = overalls_d;
                    break;
                case 4:
                    comboBox3 = shoes;
                    comboBox4 = shoes_d;
                    break;
                case 5:
                    comboBox3 = eyewear;
                    comboBox4 = eyewear_d;
                    break;
            }
            if (num2 != 255)
            {
                comboBox3.SelectedIndex = num2;
                comboBox4.SelectedIndex = num2;
                comboBox2.Text = comboBox4.Text;
                comboBox.Text = comboBox3.Text;
            }
            else
            {
                comboBox2.Text = "";
                comboBox.Text = "";
            }
        }
    }


}
