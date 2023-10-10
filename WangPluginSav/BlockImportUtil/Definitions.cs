using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKHeX.Core;

namespace WangPluginSav
{

    public static class Definitions
    {

        /// <summary>
        /// Which pattern was drawn for which regi, this should match the given regi
        /// </summary>
        public static uint KRegielekiOrRegidragoPattern = 0xCF90B39A;

        public static uint Playtime = 0x8CBBFD90;


        public static readonly Dictionary<string, uint> memkeys_FootprintPercentage = new Dictionary<string, uint>()
        {
                { "勾帕路翁", 0x4D50B655},
                { "代拉基翁", 0x771E4c88},
                { "毕力吉翁", 0xAD67A297}
        };

        public static readonly Dictionary<string, uint> memkeys_SwordsofJustice = new Dictionary<string, uint>()
        {
                { "勾帕路翁", 0xBB305227},
                { "代拉基翁", 0x750C83A4},
                { "毕力吉翁", 0x1A27DF2C},
                { "凯路迪欧", 0xA097DE31}
        };

        public static readonly Dictionary<string, uint> memkeys_Regis = new Dictionary<string, uint>()
        {
                { "雷吉洛克", 0xEE3F84E6},
                { "雷吉艾斯", 0xDAB3DD3A},
                { "雷吉斯奇鲁", 0xEE1FD86E},
                { "雷吉奇卡斯", 0xC4308A93},
                { "雷吉艾勒奇", 0x4F4AEC32},
                { "雷吉铎拉戈", 0x4F30F174}
        };

        public static readonly Dictionary<string, uint> memkeys_Birds = new Dictionary<string, uint>()
        {
            { "Galarian Articuno", 0x4CAB7DA6},
            { "Galarian Zapdos", 0x284CBECF},
            { "Galarian Moltres", 0xF1E493AA},
        };

        public static readonly Dictionary<string, uint> memkeys_Gifts = new Dictionary<string, uint>()
        {
            { "FSYS_PLAY_LETSGO_PIKACHU", 0x1C74460E},
            { "FSYS_PLAY_LETSGO_EEVEE", 0xC804E4AF},
            { "FE_SUB_037_PIKACHU_CLEAR", 0x9D95E9CA},
            { "FE_SUB_037_EEVEE_CLEAR", 0x855235FF},
            { "FE_SUB_005_CLEAR", 0xC41B40F7},
            { "z_d0901_BEBENOM", 0x4B3C9063},
            { "z_bt0101_POKE_NUL", 0x2AB6CECC},
            { "z_wr0301_i0401_COSMOG", 0x52F6F77F},
            { "z_t0101_i0202_MONSBALL", 0x178159E5},
            { "FE_R1_HUSHIGIDANE_GET", 0x4F240749},
            { "FE_R1_ZENIGAME_GET", 0x08F829F8}
        };

        public static readonly Dictionary<string, uint> memkeys_PokeCamp = new Dictionary<string, uint>()
        {
            { "FSYS_POKECAMP_OPEN_FRESH_BALL", 0xAFA33CBD},
            { "FSYS_POKECAMP_OPEN_HEAVY_BALL", 0xE49088C4},
            { "FSYS_POKECAMP_OPEN_YASURAGI_BALL", 0x45E850BE}, //soothe?
            { "FSYS_POKECAMP_OPEN_MIRROR_BALL", 0x9B6CD5A2},
            { "FSYS_POKECAMP_OPEN_OTAMA_BALL", 0xEA3E6881}, //tympole?
            { "FSYS_POKECAMP_OPEN_CHAMPION_BALL", 0x45FD94D6},

            { "FSYS_POKECAMP_OPEN_GOLDEN_KITCHENWARE", 0x72D4B15E},
            { "FSYS_POKECAMP_USE_GOLDEN_KITCHENWARE", 0x88FE6F97},
            { "SYS_WORK_POKECAMP_TENT_COLOR", 0x61952B51}
        };

        public static readonly Dictionary<string, uint> memkeys_CrownTundra_Misc = new Dictionary<string, uint>()
        {
            { "FE_CAPTURE_MIKARUGE", 0x11C12005},
            { "z_wr0321_SymbolEncountPokemonGimmickSpawner_WR03_Mikaruge", 0x1895E693},
            { "KPlayersInteractedOnline", 0x31A13425}
        };

        public static readonly Dictionary<string, uint> memkeys_MaxLairMisc = new Dictionary<string, uint>()
        {
            { "KMaxLairDisconnectStreak", 0x8EAEB8FF},
            { "KMaxLairEndlessStreak", 0x7F4B4B10},

            { "KMaxLairSpeciesID1Noted", 0x6F669A35},
            { "KMaxLairSpeciesID2Noted", 0x6F66951C},
            { "KMaxLairSpeciesID3Noted", 0x6F6696CF},

            { "KMaxLairPeoniaSpeciesHint", 0xF26B9151},

            { "KMaxLairRentalChoiceSeed", 0x0D74AA40},
        };


        public static class MaxLairExclusives
        {
            public static readonly List<string> Sword = new List<string>()
            {
                "凤王",
                "拉帝欧斯",
                "固拉多",
                "帝牙卢卡",
                "龙卷云",
                "莱希拉姆",
                "哲尔尼亚斯"
            };

            public static readonly List<string> Shield = new List<string>()
            {
                "洛奇亚",
                "拉帝亚斯",
                "盖欧卡",
                "帕路奇亚",
                "雷电云",
                "捷克罗姆",
                "伊裴尔塔尔"
            };
        }

        public static class NationalDex
        {
            private static readonly Dictionary<string, int> s_nationalDex = new Dictionary<string, int>()
        {
            { "无", 0 },
            { "急冻鸟", 144},
            { "闪电鸟", 145},
            { "火焰鸟", 156},
            { "超梦", 150},
            { "雷公", 243},
            { "炎帝", 244},
            { "水君", 245},
            { "洛奇亚", 249},
            { "凤王", 250},
            { "拉帝亚斯", 380},
            { "拉帝欧斯", 381},
            { "盖欧卡", 382},
            { "固拉多", 383},
            { "烈空坐", 384},
            { "由克希", 480},
            { "艾姆利多", 481},
            { "亚克诺姆", 482},
            { "帝牙卢卡", 483},
            { "帕路奇亚", 484},
            { "席多蓝恩", 485},
            { "骑拉帝纳", 487},
            { "克雷色利亚", 488},
            { "龙卷云", 641},
            { "雷电云", 642},
            { "莱希拉姆", 643},
            { "捷克罗姆", 644},
            { "土地云", 645},
            { "酋雷姆", 646},
            { "哲尔尼亚斯", 716},
            { "伊裴尔塔尔", 717},
            { "基格尔德", 718},
            { "卡璞・鸣鸣", 785},
            { "卡璞・蝶蝶", 786},
            { "卡璞・哞哞", 787},
            { "卡璞・鳍鳍", 788},
            { "索尔迦雷欧", 791},
            { "露奈雅拉", 792},
            { "虚吾伊德", 793},
            { "爆肌蚊", 794 },
            { "费洛美螂", 795 },
            { "电束木", 796 },
            { "铁火辉夜", 797 },
            { "纸御剑", 798 },
            { "恶食大王", 799 },
            { "奈克洛兹玛", 800 },
            { "垒磊石", 805 },
            { "砰头小丑", 806 }
        };
            public static int GetNameIndex(string name) => s_nationalDex.ToList().IndexOf(s_nationalDex.First(x => x.Key == name));
            public static int GetIDIndex(int id) => s_nationalDex.ToList().IndexOf(s_nationalDex.First(x => x.Value == id));

            public static bool ContainsID(int id) => s_nationalDex.ContainsValue(id);
            public static string GetName(int id) => s_nationalDex.Where(x => x.Value == id).First().Key;
            public static bool ContainsString(string name) => s_nationalDex.ContainsKey(name);
            public static int GetID(string name) => s_nationalDex[name];
        }


    }
}
