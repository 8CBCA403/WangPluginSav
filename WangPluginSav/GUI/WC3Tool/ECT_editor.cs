using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WangPluginSav.Util.WC3;
using WangPluginSav.Util.WC3.PKHeX;

namespace WC3Tool;

partial class ECT_editor : Form
{
    public string ectfilter = "e-card Trainer file|*.ect|All Files (*.*)|*.*";

    public byte[] ectbuffer;

    public static ECT ectfile;

    object[] trainer_index_RS_other = {
            "$00: *海洋队老大(水梧桐)",
            "$01: *海洋队手下(♂)",
            "$02: *海洋队手下(♀)",
            "$03:  香氛姐姐",
            "$04:  遗迹迷",
            "$05: *采访者",
            "$06:  泳圈女孩(♀)",
            "$07:  泳圈男孩(♂)",
            "$08:  精英训练家♂",
            "$09:  精英训练家♀",
            "$0A:  灵异迷",
            "$0B:  千金小姐",
            "$0C:  大姐姐",
            "$0D:  富家少爷",
            "$0E:  怪兽狂",
            "$0F:  泳裤小伙子♂",
            "$10:  空手道王",
            "$11:  吉他手",
            "$12:  营火专家",
            "$13:  露营少年",
            "$14:  昆虫狂",
            "$15:  超能力者(♂)",
            "$16:  超能力者(♀)",
            "$17:  绅士",
            "$18: *四天王(花月)",
            "$19: *四天王(芙蓉)",
            "$1A: *道馆馆主(杜鹃)",
            "$1B: *道馆馆主(藤树)",
            "$1C: *道馆馆主(小枫和小南)",
            "$1D:  补习班学生(♂)",
            "$1E:  补习班学生(♀)",
            "$1F: *学姐与学妹",
            "$20:  发烧友俱乐部(♂)",
            "$21:  发烧友俱乐部(♀)",
            "$22:  达人(♂)",
            "$23:  达人♀)",
            "$24:  短裤小子",
            "$25: *冠军",
            "$26:  垂钓者",
            "$27:  铁人三项运动员(♂ 骑行)",
            "$28:  铁人三项运动员(♀ 骑行)",
            "$29:  铁人三项运动员(♂ 跑步)",
            "$2A:  铁人三项运动员(♀ 跑步)",
            "$2B:  铁人三项运动员(♂ 游泳)",
            "$2C:  铁人三项运动员(♀ 游泳)",
            "$2D:  驯龙师",
            "$2E:  养鸟人",
            "$2F:  忍者小子",
            "$30:  对战少女",
            "$31:  阳伞姐姐",
            "$32:  比基尼姐姐♀",
            "$33:  野餐女孩",
            "$34: *双胞胎",
            "$35:  水手",
            "$36: *单板玩家(短裤小子)",
            "$37: *单板玩家(短裤小子)",
            "$38:  宝可梦收藏家",
            "$39: *宝可梦训练家(满充)",
            "$3A: *宝可梦训练家(小悠)",
            "$3B: *宝可梦训练家(小悠)",
            "$3C: *宝可梦训练家(小悠)",
            "$3D: *宝可梦训练家(小遥)",
            "$3E: *宝可梦训练家(小遥)",
            "$3F: *宝可梦训练家(小遥)",
            "$40:  宝可梦培育家(♂)",
            "$41:  宝可梦培育家(♀)",
            "$42:  宝可梦巡护员(♂)",
            "$43:  宝可梦巡护员(♀)",
            "$44: *熔岩队老大(赤焰松)",
            "$45: *熔岩队手下(♂)",
            "$46: *熔岩队手下(♀)",
            "$47:  迷你裙",
            "$48:  捕虫少年",
            "$49:  登山男",
            "$4A: *热恋情侣",
            "$4B: *金婚夫妻",
            "$4C: *海上姐弟"};

    object[] trainer_index_RS = {
            "0x00: 海洋队老大(水梧桐)",
            "0x01: 海洋队手下(♂)",
            "0x02: 海洋队手下(♀)",
            "0x03: 香氛姐姐",
            "0x04: 遗迹迷",
            "0x05: 采访者",
            "0x06: 泳圈女孩(♀)",
            "0x07: 泳圈男孩(♂)",
            "0x08: 精英训练家(♂)",
            "0x09: 精英训练家(♀)",
            "0x0A: 灵异迷",
            "0x0B: 怪兽狂",
            "0x0C: 大姐姐",
            "0x0D: 富家少爷",
            "0x0E: 怪兽狂",
            "0x0F: 泳裤小伙子(♂)",
            "0x10: 空手道王",
            "0x11: 吉他手",
            "0x12: 营火专家",
            "0x13: 露营少年",
            "0x14: 昆虫狂",
            "0x15: 超能力者(♂)",
            "0x16: 超能力者(♀)",
            "0x17: 绅士",
            "0x18: 四天王(花月)",
            "0x19: 四天王(芙蓉)",
            "0x1A: 道馆馆主(杜鹃)",
            "0x1B: 道馆馆主(藤树)",
            "0x1C: 道馆馆主(小枫和小南)",
            "0x1D: 补习班学生(♂)",
            "0x1E: 补习班学生(♀)",
            "0x1F: 学姐与学妹",
            "0x20: 发烧友俱乐部(♂)",
            "0x21: 发烧友俱乐部(♀)",
            "0x22: 达人(♂)",
            "0x23: 达人(♀)",
            "0x24: 短裤小子",
            "0x25: 冠军(大吾)",
            "0x26: 垂钓者",
            "0x27: 铁人三项运动员(♂ 骑行)",
            "0x28: 铁人三项运动员(♀ 骑行)",
            "0x29: 铁人三项运动员(♂ 跑步)",
            "0x2A: 铁人三项运动员(♀ 跑步)",
            "0x2B: 铁人三项运动员(♂ 游泳)",
            "0x2C: 铁人三项运动员(♀ 游泳)",
            "0x2D: 驯龙师",
            "0x2E: 养鸟人",
            "0x2F: 忍者小子",
            "0x30: 对战少女",
            "0x31: 阳伞姐姐",
            "0x32: 比基尼姐姐(♀)",
            "0x33: 野餐女孩",
            "0x34: 双胞胎",
            "0x35: 水手",
            "0x36: 单板玩家",
            "0x37: 单板玩家",
            "0x38: 宝可梦收藏家",
            "0x39: 宝可梦训练家(满充)",
            "0x3A: 宝可梦训练家(小悠)",
            "0x3B: 宝可梦训练家(小悠)",
            "0x3C: 宝可梦训练家(小悠)",
            "0x3D: 宝可梦训练家(小遥)",
            "0x3E: 宝可梦训练家(小遥)",
            "0x3F: 宝可梦训练家(小遥)",
            "0x40: 宝可梦培育家(♂)",
            "0x41: 宝可梦培育家(♀)",
            "0x42: 宝可梦巡护员(♂)",
            "0x43: 宝可梦巡护员(♀)",
            "0x44: 熔岩队老大(赤焰松)",
            "0x45: 熔岩队手下(♂)",
            "0x46: 熔岩队手下(♀)",
            "0x47: 迷你裙",
            "0x48: 捕虫少年",
            "0x49: 登山男",
            "0x4A: 热恋情侣",
            "0x4B: 金婚夫妻",
            "0x4C: 海上姐弟",
            "<- 按索引设置"};

    object[] trainer_index_E = {
            "0x00: 登山男",
            "0x01: 海洋队手下(♂)",
            "0x02: 宝可梦培育家(♀)",
            "0x03: 精英训练家(♂)",
            "0x04: 养鸟人",
            "0x05: 宝可梦收藏家",
            "0x06: 海洋队手下(♀)",
            "0x07: 泳裤小伙子(♂)",
            "0x08: 熔岩队手下(♂)",
            "0x09: 达人(♂)",
            "0x0A: 空手道王",
            "0x0B: 海洋队老大(水梧桐)",
            "0x0C: 灵异迷",
            "0x0D: 香氛姐姐",
            "0x0E: 遗迹迷",
            "0x0F: 采访者",
            "0x10: 泳圈女孩(♀)",
            "0x11: 泳圈男孩(♂)",
            "0x12: 精英训练家(♀)",
            "0x13: 千金小姐",
            "0x14: 大姐姐",
            "0x15: 富家少爷",
            "0x16: 达人(♀)",
            "0x17: 怪兽狂",
            "0x18: 熔岩队手下(♀)",
            "0x19: 吉他手",
            "0x1A: 营火专家",
            "0x1B: 露营少年",
            "0x1C: 野餐女孩",
            "0x1D: 昆虫狂",
            "0x1E: 超能力者(♂)",
            "0x1F: 超能力者(♀)",
            "0x20: 绅士",
            "0x21: 四天王(花月)",
            "0x22: 四天王(芙蓉)",
            "0x23: 道馆馆主(杜鹃)",
            "0x24: 道馆馆主(藤树)",
            "0x25: 道馆馆主(小枫和小南)",
            "0x26: 补习班学生(♂)",
            "0x27: 补习班学生(♀)",
            "0x28: 学姐与学妹",
            "0x29: 发烧友俱乐部(♂)",
            "0x2A: 发烧友俱乐部(♀)",
            "0x2B: 短裤小子",
            "0x2C: 冠军(米可利)",
            "0x2D: 垂钓者",
            "0x2E: 铁人三项运动员(♂ 骑行)",
            "0x2F: 铁人三项运动员(♀ 骑行)",
            "0x30: 铁人三项运动员(♂ 跑步)",
            "0x31: 铁人三项运动员(♀ 跑步)",
            "0x32: 铁人三项运动员(♂ 游泳)",
            "0x33: 铁人三项运动员(♀ 游泳)",
            "0x34: 驯龙师",
            "0x35: 忍者小子",
            "0x36: 对战少女",
            "0x37: 阳伞姐姐",
            "0x38: 比基尼姐姐(♀)",
            "0x39: 双胞胎",
            "0x3A: 水手",
            "0x3B: 宝可梦训练家(满充)",
            "0x3C: 宝可梦训练家(小悠)",
            "0x3D: 宝可梦训练家(小悠)",
            "0x3E: 宝可梦训练家(小悠)",
            "0x3F: 宝可梦训练家(小遥)",
            "0x40: 宝可梦训练家(小遥)",
            "0x41: 宝可梦训练家(小遥)",
            "0x42: 宝可梦培育家(♂)",
            "0x43: 捕虫少年",
            "0x44: 宝可梦巡护员(♂)",
            "0x45: 宝可梦巡护员(♀)",
            "0x46: 熔岩队老大 (赤焰松)",
            "0x47: 迷你裙",
            "0x48: 热恋情侣",
            "0x49: 金婚夫妻",
            "0x4A: 海上姐弟",
            "0x4B: 宝可梦训练家(大吾)",
            "0x4C: 对战塔大君(莉拉)",
            "0x4D: 巨蛋超级巨星(希尔斯)",
            "0x4E: 宝可梦训练家(赤红)",
            "0x4F: 宝可梦训练家(青绿)",
            "<- 按索引设置"};

    object[] trainer_index_FRLG = {
            "0x00: 海洋队老大(水梧桐)",
            "0x01: 海洋队手下(♂)",
            "0x02: 海洋队手下(♀)",
            "0x03: 香氛姐姐",
            "0x04: 遗迹迷",
            "0x05: 采访者",
            "0x06: 泳圈女孩(♀)",
            "0x07: 泳圈男孩(♂)",
            "0x08: 精英训练家(♂)",
            "0x09: 精英训练家(♀)",
            "0x0A: 灵异迷",
            "0x0B: 怪兽狂",
            "0x0C: 大姐姐",
            "0x0D: 富家少爷",
            "0x0E: 怪兽狂",
            "0x0F: 泳裤小伙子(♂)",
            "0x10: 空手道王",
            "0x11: 吉他手",
            "0x12: 营火专家",
            "0x13: 露营少年",
            "0x14: 昆虫狂",
            "0x15: 超能力者(♂)",
            "0x16: 超能力者(♀)",
            "0x17: 绅士",
            "0x18: 四天王(花月)",
            "0x19: 四天王(芙蓉)",
            "0x1A: 道馆馆主(杜鹃)",
            "0x1B: 道馆馆主(藤树)",
            "0x1C: 道馆馆主(小枫和小南)",
            "0x1D: 补习班学生(♂)",
            "0x1E: 补习班学生(♀)",
            "0x1F: 学姐与学妹",
            "0x20: 发烧友俱乐部(♂)",
            "0x21: 发烧友俱乐部(♀)",
            "0x22: 达人(♂)",
            "0x23: 达人(♀)",
            "0x24: 短裤小子",
            "0x25: 冠军(大吾)",
            "0x26: 垂钓者",
            "0x27: 铁人三项运动员(♂ 骑行)",
            "0x28: 铁人三项运动员(♀ 骑行)",
            "0x29: 铁人三项运动员(♂ 跑步)",
            "0x2A: 铁人三项运动员(♀ 跑步)",
            "0x2B: 铁人三项运动员(♂ 游泳)",
            "0x2C: 铁人三项运动员(♀ 游泳)",
            "0x2D: 驯龙师",
            "0x2E: 养鸟人",
            "0x2F: 忍者小子",
            "0x30: 对战少女",
            "0x31: 阳伞姐姐",
            "0x32: 比基尼姐姐(♀)",
            "0x33: 野餐女孩",
            "0x34: 双胞胎",
            "0x35: 水手",
            "0x36: 单板玩家",
            "0x37: 单板玩家",
            "0x38: 宝可梦收藏家",
            "0x39: 宝可梦训练家(满充)",
            "0x3A: 宝可梦训练家(小悠)",
            "0x3B: 宝可梦训练家(小悠)",
            "0x3C: 宝可梦训练家(小悠)",
            "0x3D: 宝可梦训练家(小遥)",
            "0x3E: 宝可梦训练家(小遥)",
            "0x3F: 宝可梦训练家(小遥)",
            "0x40: 宝可梦培育家(♂)",
            "0x41: 宝可梦培育家(♀)",
            "0x42: 宝可梦巡护员(♂)",
            "0x43: 宝可梦巡护员(♀)",
            "0x44: 熔岩队老大(赤焰松)",
            "0x45: 熔岩队手下(♂)",
            "0x46: 熔岩队手下(♀)",
            "0x47: 迷你裙",
            "0x48: 捕虫少年",
            "0x49: 登山男",
            "0x4A: 热恋情侣",
            "0x4B: 金婚夫妻",
            "0x4C: 海上姐弟",
            "0x4D: 海洋队干部(阿潮 )",
            "0x4E: 海洋队干部(阿泉)",
            "0x4F: 熔岩队干部(火村)",
            "0x50: 熔岩队干部(火雁)",
            "0x51: 道馆馆主(铁旋)",
            "0x52: 道馆馆主(亚莎)",
            "0x53: 道馆馆主(千里)",
            "0x54: 道馆馆主(娜琪)",
            "0x55: 道馆馆主(米可利)",
            "0x56: 四天王(波妮)",
            "0x57: 四天王(源治)",
            "0x58: 短裤小子(FRLG)",
            "0x59: 捕虫少年(FRLG)",
            "0x5A: 迷你裙(FRLG)",
            "0x5B: 水手(FRLG)",
            "0x5C: 露营少年(FRLG)",
            "0c5D: 野餐女孩(FRLG)",
            "0x5E: 怪兽狂(FRLG)",
            "0x5F: 理科男",
            "0x60: 登山男(FRLG)",
            "0x61: 暴走族(FRLG)",
            "0x62: 趁火打劫者",
            "0x63: 电工大叔",
            "0x64: 垂钓者",
            "0x65: 泳裤小伙子(♂)(FRLG)",
            "0x66: 光头男",
            "0x67: 赌徒",
            "0x68: 大姐姐(FRLG)",
            "0x69: 比基尼姐姐(♀)(FRLG)",
            "0x6A: 超能力者(♂)",
            "0x6B: 电气摇滚团",
            "0x6C: 杂耍艺人",
            "0x6D: 驯兽师",
            "0x6E: 养鸟人(FRLG)",
            "0x6F: 空手道王(FRLG)",
            "0x70: 劲敌(小茂)",
            "0x71: 研究员",
            "0x72: 火箭队老大(坂木)",
            "0x73: 火箭队手下(♂)",
            "0x74: 精英训练家(♂)",
            "0x75: 精英训练家(♀)",
            "0x76: 四天王(科拿)",
            "0x77: 四天王(希巴)",
            "0x78: 道馆馆主(小刚)",
            "0x79: 道馆馆主(小霞)",
            "0x7A: 绅士(FRLG)",
            "0x7B: 劲敌(小茂)",
            "0x7C: 冠军(小茂)",
            "0x7D: 祈祷师",
            "0x7E: 双胞胎(FRLG)",
            "0x7F: 精英情侣",
            "0x80: 热恋情侣(FRLG)",
            "0x81: 格斗姐弟",
            "0x82: 海上姐弟(FRLG)",
            "0x83: 宝可梦博士(大木)",
            "0x84: 玩家(小悠)",
            "0x85: 玩家(小遥)",
            "0x86: 玩家(赤红)",
            "0x87: 玩家(叶子)",
            "0x88: 火箭队手下(♀)",
            "0x89: 超能力者(♀)(FRLG)",
            "0x8A: 格斗女孩",
            "0x8B: 泳圈女孩(♀)(FRLG)",
            "0x8C: 宝可梦培育家(♀)(FRLG)",
            "0x8D: 宝可梦巡护员(♂)(FRLG)",
            "0x8E: 宝可梦巡护员(♀)(FRLG)",
            "0x8F: 香氛姐姐(FRLG)",
            "0x90: 遗迹迷(FRLG)",
            "0x91: 怪兽狂(FRLG)",
            "0x92: 画家(♀)",
            "<- 按索引设置"};

    private ushort[] easy_chat_IDs = new ushort[1770]
    {
        0, 277, 278, 279, 280, 281, 282, 283, 284, 285,
        286, 287, 288, 289, 290, 291, 292, 293, 294, 295,
        296, 297, 298, 299, 300, 301, 302, 303, 304, 305,
        306, 307, 308, 309, 310, 311, 312, 313, 314, 315,
        316, 317, 318, 319, 320, 321, 322, 323, 324, 325,
        326, 327, 328, 329, 330, 331, 332, 333, 334, 335,
        336, 337, 338, 339, 340, 341, 342, 343, 344, 345,
        346, 347, 348, 349, 350, 351, 352, 353, 354, 355,
        356, 357, 358, 359, 360, 361, 362, 363, 364, 365,
        366, 367, 368, 369, 370, 371, 372, 373, 374, 375,
        376, 377, 378, 379, 380, 381, 382, 383, 384, 385,
        386, 387, 388, 389, 390, 391, 392, 393, 394, 395,
        396, 397, 398, 399, 400, 401, 402, 403, 404, 405,
        406, 407, 408, 409, 410, 411, 1, 512, 513, 514,
        515, 516, 517, 518, 519, 520, 521, 522, 523, 524,
        525, 526, 527, 528, 529, 530, 531, 532, 533, 534,
        535, 536, 537, 538, 2, 1024, 1025, 1026, 1027, 1028,
        1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038,
        1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048,
        1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058,
        1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068,
        1069, 1070, 1071, 1072, 1073, 1074, 1075, 1076, 1077, 1078,
        1079, 1080, 1081, 1082, 1083, 1084, 1085, 1086, 1087, 1088,
        1089, 1090, 1091, 1092, 1093, 1094, 1095, 1096, 1097, 1098,
        1099, 1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108,
        1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118,
        1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128,
        1129, 1130, 1131, 1132, 3, 1536, 1537, 1538, 1539, 1540,
        1541, 1542, 1543, 1544, 1545, 1546, 1547, 1548, 1549, 1550,
        1551, 1552, 1553, 1554, 1555, 1556, 1557, 1558, 1559, 1560,
        1561, 1562, 1563, 1564, 1565, 1566, 1567, 1568, 1569, 1570,
        1571, 1572, 1573, 1574, 1575, 1576, 1577, 1578, 1579, 1580,
        1581, 1582, 1583, 1584, 1585, 1586, 1587, 1588, 1589, 1590,
        1591, 1592, 1593, 1594, 1595, 1596, 1597, 1598, 4, 2048,
        2049, 2050, 2051, 2052, 2053, 2054, 2055, 2056, 2057, 2058,
        2059, 2060, 2061, 2062, 2063, 2064, 2065, 2066, 2067, 2068,
        2069, 2070, 2071, 2072, 2073, 2074, 2075, 2076, 2077, 2078,
        2079, 2080, 2081, 2082, 2083, 2084, 2085, 2086, 2087, 2088,
        2089, 5, 2560, 2561, 2562, 2563, 2564, 2565, 2566, 2567,
        2568, 2569, 2570, 2571, 2572, 2573, 2574, 2575, 2576, 2577,
        2578, 2579, 2580, 2581, 2582, 2583, 2584, 2585, 2586, 2587,
        2588, 2589, 2590, 2591, 2592, 2593, 2594, 2595, 2596, 2597,
        2598, 2599, 2600, 2601, 2602, 2603, 2604, 2605, 2606, 2607,
        2608, 2609, 2610, 2611, 2612, 2613, 2614, 2615, 2616, 2617,
        2618, 2619, 2620, 2621, 2622, 2623, 2624, 2625, 2626, 2627,
        2628, 2629, 2630, 2631, 2632, 2633, 2634, 6, 3072, 3073,
        3074, 3075, 3076, 3077, 3078, 3079, 3080, 3081, 3082, 3083,
        3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3093,
        3094, 3095, 3096, 3097, 3098, 3099, 3100, 3101, 3102, 3103,
        3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113,
        3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123,
        3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133,
        3134, 7, 3584, 3585, 3586, 3587, 3588, 3589, 3590, 3591,
        3592, 3593, 3594, 3595, 3596, 3597, 3598, 3599, 3600, 3601,
        3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611,
        3612, 3613, 3614, 3615, 3616, 3617, 3618, 3619, 3620, 3621,
        3622, 3623, 3624, 3625, 3626, 3627, 3628, 3629, 3630, 3631,
        3632, 3633, 3634, 3635, 3636, 3637, 3638, 3639, 3640, 3641,
        3642, 3643, 8, 4096, 4097, 4098, 4099, 4100, 4101, 4102,
        4103, 4104, 4105, 4106, 4107, 4108, 4109, 4110, 4111, 4112,
        4113, 4114, 4115, 4116, 4117, 4118, 4119, 4120, 4121, 4122,
        4123, 4124, 4125, 4126, 4127, 4128, 4129, 4130, 4131, 4132,
        4133, 4134, 4135, 4136, 4137, 4138, 4139, 4140, 4141, 4142,
        4143, 4144, 4145, 4146, 4147, 4148, 4149, 4150, 4151, 4152,
        4153, 4154, 4155, 4156, 4157, 4158, 4159, 4160, 4161, 4162,
        4163, 4164, 9, 4608, 4609, 4610, 4611, 4612, 4613, 4614,
        4615, 4616, 4617, 4618, 4619, 4620, 4621, 4622, 4623, 4624,
        4625, 4626, 4627, 4628, 4629, 4630, 4631, 4632, 4633, 4634,
        4635, 4636, 4637, 4638, 4639, 4640, 4641, 4642, 4643, 4644,
        4645, 4646, 4647, 4648, 4649, 4650, 4651, 4652, 4653, 4654,
        4655, 4656, 4657, 4658, 4659, 4660, 4661, 4662, 4663, 4664,
        4665, 4666, 4667, 4668, 4669, 4670, 4671, 4672, 4673, 4674,
        4675, 4676, 10, 5120, 5121, 5122, 5123, 5124, 5125, 5126,
        5127, 5128, 5129, 5130, 5131, 5132, 5133, 5134, 5135, 5136,
        5137, 5138, 5139, 5140, 5141, 5142, 5143, 5144, 5145, 5146,
        5147, 5148, 5149, 5150, 5151, 5152, 5153, 5154, 5155, 5156,
        5157, 5158, 5159, 5160, 5161, 5162, 5163, 5164, 5165, 5166,
        5167, 5168, 5169, 5170, 5171, 5172, 5173, 5174, 5175, 5176,
        5177, 5178, 5179, 5180, 5181, 5182, 5183, 5184, 5185, 5186,
        5187, 5188, 11, 5632, 5633, 5634, 5635, 5636, 5637, 5638,
        5639, 5640, 5641, 5642, 5643, 5644, 5645, 5646, 5647, 5648,
        5649, 5650, 5651, 5652, 5653, 5654, 5655, 5656, 5657, 5658,
        5659, 5660, 5661, 5662, 5663, 5664, 5665, 5666, 5667, 5668,
        5669, 5670, 5671, 5672, 5673, 5674, 5675, 5676, 5677, 5678,
        5679, 5680, 5681, 5682, 5683, 5684, 5685, 5686, 5687, 5688,
        5689, 5690, 5691, 5692, 5693, 5694, 5695, 5696, 5697, 5698,
        5699, 5700, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708,
        5709, 12, 6144, 6145, 6146, 6147, 6148, 6149, 6150, 6151,
        6152, 6153, 6154, 6155, 6156, 6157, 6158, 6159, 6160, 6161,
        6162, 6163, 6164, 6165, 6166, 6167, 6168, 6169, 6170, 6171,
        6172, 6173, 6174, 6175, 6176, 6177, 6178, 6179, 6180, 6181,
        6182, 6183, 6184, 6185, 6186, 6187, 6188, 13, 6656, 6657,
        6658, 6659, 6660, 6661, 6662, 6663, 6664, 6665, 6666, 6667,
        6668, 6669, 6670, 6671, 6672, 6673, 6674, 6675, 6676, 6677,
        6678, 6679, 6680, 6681, 6682, 6683, 6684, 6685, 6686, 6687,
        6688, 6689, 6690, 6691, 6692, 6693, 6694, 6695, 6696, 6697,
        6698, 6699, 6700, 6701, 6702, 6703, 6704, 6705, 6706, 6707,
        6708, 6709, 14, 7168, 7169, 7170, 7171, 7172, 7173, 7174,
        7175, 7176, 7177, 7178, 7179, 7180, 7181, 7182, 7183, 7184,
        7185, 7186, 7187, 7188, 7189, 7190, 7191, 7192, 7193, 7194,
        7195, 7196, 7197, 7198, 7199, 7200, 7201, 7202, 7203, 7204,
        7205, 7206, 7207, 7208, 7209, 7210, 7211, 7212, 15, 7680,
        7681, 7682, 7683, 7684, 7685, 7686, 7687, 7688, 7689, 7690,
        7691, 7692, 7693, 7694, 7695, 7696, 7697, 7698, 7699, 7700,
        7701, 7702, 7703, 7704, 7705, 7706, 7707, 7708, 7709, 7710,
        7711, 7712, 7713, 7714, 7715, 7716, 7717, 7718, 7719, 7720,
        7721, 16, 8192, 8193, 8194, 8195, 8196, 8197, 8198, 8199,
        8200, 8201, 8202, 8203, 8204, 8205, 8206, 8207, 8208, 8209,
        8210, 8211, 8212, 8213, 8214, 8215, 8216, 8217, 8218, 8219,
        8220, 8221, 8222, 8223, 8224, 8225, 8226, 8227, 17, 8704,
        8705, 8706, 8707, 8708, 8709, 8710, 8711, 8712, 8713, 8714,
        8715, 8716, 8717, 8718, 8719, 8720, 8721, 8722, 8723, 8724,
        8725, 8726, 8727, 8728, 8729, 8730, 8731, 8732, 18, 9218,
        9219, 9225, 9229, 9231, 9232, 9235, 9236, 9244, 9245, 9253,
        9254, 9255, 9260, 9263, 9265, 9266, 9269, 9270, 9276, 9278,
        9282, 9283, 9284, 9286, 9287, 9290, 9292, 9294, 9297, 9301,
        9303, 9304, 9305, 9306, 9307, 9310, 9311, 9313, 9315, 9319,
        9320, 9321, 9322, 9324, 9325, 9326, 9330, 9332, 9333, 9335,
        9336, 9338, 9339, 9344, 9345, 9348, 9350, 9357, 9358, 9359,
        9361, 9363, 9365, 9368, 9373, 9375, 9378, 9379, 9382, 9385,
        9386, 9387, 9388, 9389, 9391, 9393, 9395, 9396, 9397, 9400,
        9406, 9412, 9416, 9417, 9418, 9419, 9420, 9421, 9423, 9425,
        9428, 9431, 9432, 9435, 9436, 9437, 9443, 9444, 9445, 9446,
        9447, 9449, 9450, 9451, 9454, 9456, 9458, 9460, 9461, 9462,
        9463, 9465, 9466, 9469, 9474, 9475, 9476, 9477, 9478, 9479,
        9480, 9481, 9482, 9483, 9484, 9496, 9497, 9499, 9501, 9504,
        9517, 9525, 9526, 9527, 9528, 9529, 9530, 9531, 9532, 9533,
        9534, 9535, 9536, 9537, 9538, 9539, 9540, 9541, 9542, 9543,
        9544, 9545, 9570, 19, 9729, 9732, 9733, 9734, 9735, 9736,
        9738, 9739, 9740, 9742, 9745, 9746, 9749, 9750, 9751, 9752,
        9753, 9754, 9755, 9758, 9759, 9760, 9761, 9762, 9763, 9764,
        9768, 9769, 9770, 9771, 9773, 9774, 9776, 9779, 9780, 9783,
        9784, 9785, 9786, 9787, 9789, 9791, 9792, 9793, 9797, 9800,
        9801, 9803, 9805, 9807, 9808, 9810, 9811, 9812, 9814, 9820,
        9821, 9824, 9826, 9828, 9829, 9830, 9835, 9839, 9840, 9841,
        9843, 9846, 9849, 9852, 9853, 9854, 9855, 9858, 9859, 9861,
        9863, 9864, 9865, 9866, 9867, 9868, 9872, 9874, 9876, 9878,
        9879, 9881, 9882, 9883, 9884, 9886, 9888, 9889, 9892, 9893,
        9895, 9896, 9902, 9904, 9906, 9910, 9911, 9913, 9914, 9915,
        9916, 9917, 9919, 9920, 9921, 9922, 9923, 9925, 9926, 9927,
        9934, 9936, 9938, 9939, 9941, 9942, 9945, 9946, 9950, 9951,
        9952, 9953, 9954, 9960, 9964, 9965, 9967, 9969, 9971, 9976,
        9979, 9980, 9982, 9983, 9984, 9985, 9997, 9998, 9999, 10000,
        10001, 10002, 10003, 10004, 10005, 10006, 10007, 10010, 10012, 10014,
        10015, 10017, 10018, 10019, 10020, 10021, 10022, 10023, 10024, 10025,
        10026, 10027, 10028, 10030, 10031, 10032, 10033, 10034, 10035, 10036,
        10058, 10059, 10060, 10061, 10062, 10063, 10064, 10065, 10066, 10067,
        10068, 10069, 10070, 10071, 10072, 10073, 10074, 10075, 10076, 10077,
        10078, 10079, 10080, 10081, 20, 1, 2, 3, 4, 5,
        6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
        16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
        26, 27, 28, 29, 30, 31, 32, 33, 34, 35,
        36, 37, 38, 39, 40, 41, 42, 43, 44, 45,
        46, 47, 48, 49, 50, 51, 52, 53, 54, 55,
        56, 57, 58, 59, 60, 61, 62, 63, 64, 65,
        66, 67, 68, 69, 70, 71, 72, 73, 74, 75,
        76, 77, 78, 79, 80, 81, 82, 83, 84, 85,
        86, 87, 88, 89, 90, 91, 92, 93, 94, 95,
        96, 97, 98, 99, 100, 101, 102, 103, 104, 105,
        106, 107, 108, 109, 110, 111, 112, 113, 114, 115,
        116, 117, 118, 119, 120, 121, 122, 123, 124, 125,
        126, 127, 128, 129, 130, 131, 132, 133, 134, 135,
        136, 137, 138, 139, 140, 141, 142, 143, 144, 145,
        146, 147, 148, 149, 150, 151, 152, 153, 154, 155,
        156, 157, 158, 159, 160, 161, 162, 163, 164, 165,
        166, 167, 168, 169, 170, 171, 172, 173, 174, 175,
        176, 177, 178, 179, 180, 181, 182, 183, 184, 185,
        186, 187, 188, 189, 190, 191, 192, 193, 194, 195,
        196, 197, 198, 199, 200, 201, 202, 203, 204, 205,
        206, 207, 208, 209, 210, 211, 212, 213, 214, 215,
        216, 217, 218, 219, 220, 221, 222, 223, 224, 225,
        226, 227, 228, 229, 230, 231, 232, 233, 234, 235,
        236, 237, 238, 239, 240, 241, 242, 243, 244, 245,
        246, 247, 248, 249, 250, 251, 21, 10240, 10241, 10242,
        10243, 10244, 10245, 10246, 10247, 10248, 10249, 10250, 10251, 10252,
        10253, 10254, 10255, 10256, 10257, 10258, 10259, 10260, 10261, 10262,
        10263, 10264, 10265, 10266, 10267, 10268, 10269, 10270, 10271, 10272
    };





    public ECT_editor()
    {
        InitializeComponent();
        eng.Checked = true;
        update_easychat();
        trainer_class.Items.AddRange(trainer_index_RS);
        radio_rs.Checked = true;
    }

    private int get_chatword(ushort word)
    {
        int i;
        for (i = 0; i < easy_chat_IDs.Length && word != easy_chat_IDs[i]; i++)
        {
        }
        return i;
    }

    private void update_easychat()
    {
        object[] items = ECT_editor_text.easy_chat_eng;
        if (ita.Checked)
        {
            items = ECT_editor_text.easy_chat_ita;
        }
        else if (ger.Checked)
        {
            items = ECT_editor_text.easy_chat_ger;
        }
        else if (fre.Checked)
        {
            items = ECT_editor_text.easy_chat_fre;
        }
        else if (esp.Checked)
        {
            items = ECT_editor_text.easy_chat_esp;
        }
        else if (jap.Checked)
        {
            items = ECT_editor_text.easy_chat_jap;
        }
        textA1.Items.Clear();
        textA2.Items.Clear();
        textA3.Items.Clear();
        textA4.Items.Clear();
        textA5.Items.Clear();
        textA6.Items.Clear();
        textB1.Items.Clear();
        textB2.Items.Clear();
        textB3.Items.Clear();
        textB4.Items.Clear();
        textB5.Items.Clear();
        textB6.Items.Clear();
        textC1.Items.Clear();
        textC2.Items.Clear();
        textC3.Items.Clear();
        textC4.Items.Clear();
        textC5.Items.Clear();
        textC6.Items.Clear();
        textA1.Items.AddRange(items);
        textA2.Items.AddRange(items);
        textA3.Items.AddRange(items);
        textA4.Items.AddRange(items);
        textA5.Items.AddRange(items);
        textA6.Items.AddRange(items);
        textB1.Items.AddRange(items);
        textB2.Items.AddRange(items);
        textB3.Items.AddRange(items);
        textB4.Items.AddRange(items);
        textB5.Items.AddRange(items);
        textB6.Items.AddRange(items);
        textC1.Items.AddRange(items);
        textC2.Items.AddRange(items);
        textC3.Items.AddRange(items);
        textC4.Items.AddRange(items);
        textC5.Items.AddRange(items);
        textC6.Items.AddRange(items);
        if (ectfile != null)
        {
            textA1.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(16, 2), 0));
            textA2.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(18, 2), 0));
            textA3.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(20, 2), 0));
            textA4.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(22, 2), 0));
            textA5.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(24, 2), 0));
            textA6.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(26, 2), 0));
            textB1.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(28, 2), 0));
            textB2.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(30, 2), 0));
            textB3.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(32, 2), 0));
            textB4.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(34, 2), 0));
            textB5.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(36, 2), 0));
            textB6.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(38, 2), 0));
            textC1.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(40, 2), 0));
            textC2.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(42, 2), 0));
            textC3.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(44, 2), 0));
            textC4.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(46, 2), 0));
            textC5.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(48, 2), 0));
            textC6.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(50, 2), 0));
        }
    }

    private void update_ectData()
    {
        tower_appearance_num.Value = ectfile.Data[0];
        trainer_class_value.Value = ectfile.Data[1];
        tower_floor.Value = ectfile.Data[2];
        name.Text = PKM.getG3Str(ectfile.getData(4, 8), jap_check.Checked);
        TID.Value = BitConverter.ToUInt16(ectfile.getData(12, 2), 0);
        SID.Value = BitConverter.ToUInt16(ectfile.getData(14, 2), 0);
        textA1.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(16, 2), 0));
        textA2.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(18, 2), 0));
        textA3.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(20, 2), 0));
        textA4.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(22, 2), 0));
        textA5.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(24, 2), 0));
        textA6.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(26, 2), 0));
        textB1.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(28, 2), 0));
        textB2.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(30, 2), 0));
        textB3.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(32, 2), 0));
        textB4.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(34, 2), 0));
        textB5.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(36, 2), 0));
        textB6.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(38, 2), 0));
        textC1.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(40, 2), 0));
        textC2.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(42, 2), 0));
        textC3.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(44, 2), 0));
        textC4.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(46, 2), 0));
        textC5.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(48, 2), 0));
        textC6.SelectedIndex = get_chatword(BitConverter.ToUInt16(ectfile.getData(50, 2), 0));
        pkm1.SelectedIndex = BitConverter.ToUInt16(ectfile.getData(52, 2), 0);
        pkm2.SelectedIndex = BitConverter.ToUInt16(ectfile.getData(96, 2), 0);
        pkm3.SelectedIndex = BitConverter.ToUInt16(ectfile.getData(140, 2), 0);
    }

    private void set_ectData()
    {
        ectfile.Data[0] = (byte)tower_appearance_num.Value;
        ectfile.Data[1] = (byte)trainer_class_value.Value;
        ectfile.Data[2] = (byte)tower_floor.Value;
        ectfile.setData(PKM.setG3Str(name.Text, jap_check.Checked), 4);
        ectfile.setData(BitConverter.GetBytes((ushort)TID.Value).ToArray(), 12);
        ectfile.setData(BitConverter.GetBytes((ushort)SID.Value).ToArray(), 12);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textA1.SelectedIndex]), 16);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textA2.SelectedIndex]), 18);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textA3.SelectedIndex]), 20);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textA4.SelectedIndex]), 22);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textA5.SelectedIndex]), 24);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textA6.SelectedIndex]), 26);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textB1.SelectedIndex]), 28);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textB2.SelectedIndex]), 30);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textB3.SelectedIndex]), 32);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textB4.SelectedIndex]), 34);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textB5.SelectedIndex]), 36);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textB6.SelectedIndex]), 38);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textC1.SelectedIndex]), 40);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textC2.SelectedIndex]), 42);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textC3.SelectedIndex]), 44);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textC4.SelectedIndex]), 46);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textC5.SelectedIndex]), 48);
        ectfile.setData(BitConverter.GetBytes(easy_chat_IDs[textC6.SelectedIndex]), 50);
        ectfile.setData(BitConverter.GetBytes((ushort)pkm1.SelectedIndex).ToArray(), 52);
        ectfile.setData(BitConverter.GetBytes((ushort)pkm2.SelectedIndex).ToArray(), 96);
        ectfile.setData(BitConverter.GetBytes((ushort)pkm3.SelectedIndex).ToArray(), 140);
    }

    private void Load_ECT(string path)
    {
        if (FileIO.load_file(ref ectbuffer, ref path, ectfilter) == 188)
        {
            ect_path.Text = path;
            ectfile = new ECT(ectbuffer);
            update_ectData();
            save_ect_but.Enabled = true;
            pkm1_edit_but.Enabled = true;
            pkm2_edit_but.Enabled = true;
            pkm3_edit_but.Enabled = true;
            jap_check.Enabled = true;
        }
        else
        {
            MessageBox.Show("Invalid file size.");
        }
    }

    private void Load_ect_butClick(object sender, EventArgs e)
    {
        Load_ECT(null);
    }

    private void Save_ect_butClick(object sender, EventArgs e)
    {
        set_ectData();
        ectfile.fix_ect_checksum();
        if (ectfile.Edited)
        {
            FileIO.save_data(ectfile.Data, ectfilter);
        }
        else
        {
            MessageBox.Show("Save has not been edited");
        }
    }

    private void Helpclass_butClick(object sender, EventArgs e)
    {
        MessageBox.Show("The classes AQUA ADMIN, MAGMA ADMIN, and WINSTRATE are apparently unavailable, as are the other five Leaders and two Elite Four members. Indices greater than those in the list (0x4C, 0x4F and 0x92) result in mismatches between the trainer class and sprite.\n\nThis value also determines the overworld sprite shown in the Mossdeep house. Some classes and any value greater than the ones listed, will be shown in the overworld as a generic male NPC.\n\nThere are two identical entries for the unused BOARDER class in this list, implying that male and female versions were planned, and three identical entries each for Brendan and May, which might indicate that they were intended to have multiple sprites like the rivals in prior games.");
    }

    private void Pkm1_edit_butClick(object sender, EventArgs e)
    {
        new ECT_pkedit(0).ShowDialog();
    }

    private void Pkm2_edit_butClick(object sender, EventArgs e)
    {
        new ECT_pkedit(1).ShowDialog();
    }

    private void Pkm3_edit_butClick(object sender, EventArgs e)
    {
        new ECT_pkedit(2).ShowDialog();
    }

    private void Jap_checkCheckedChanged(object sender, EventArgs e)
    {
        name.Text = PKM.getG3Str(ectfile.getData(4, 8), jap_check.Checked);
        if (jap_check.Checked)
        {
            MessageBox.Show("Remember Japanese names have a maximum of 5 characters.");
        }
    }

    private void update_trainer_list()
    {
        trainer_class.Items.Clear();
        if (radio_e.Checked)
        {
            trainer_class.Items.AddRange(trainer_index_E);
        }
        else if (radio_FRLG.Checked)
        {
            trainer_class.Items.AddRange(trainer_index_FRLG);
        }
        else
        {
            trainer_class.Items.AddRange(trainer_index_RS);
        }
    }

    private void Radio_rsCheckedChanged(object sender, EventArgs e)
    {
        update_trainer_list();
    }

    private void Radio_eCheckedChanged(object sender, EventArgs e)
    {
        update_trainer_list();
    }

    private void Radio_FRLGCheckedChanged(object sender, EventArgs e)
    {
        update_trainer_list();
    }

    private void NoteClick(object sender, EventArgs e)
    {
        MessageBox.Show("Easy chat system implementation currently has limitations, pokemon and move groups need more research for their values and won't properly work. All other word groups work fine. There might also be problems between different languages, even though english words are supposed to be translated from japanese.");
    }

    private void Trainer_class_valueValueChanged(object sender, EventArgs e)
    {
        if (trainer_class_value.Value <= 76m && radio_rs.Checked)
        {
            trainer_class.SelectedIndex = (int)trainer_class_value.Value;
        }
        else if (trainer_class_value.Value <= 79m && radio_e.Checked)
        {
            trainer_class.SelectedIndex = (int)trainer_class_value.Value;
        }
        else if (trainer_class_value.Value <= 146m && radio_FRLG.Checked)
        {
            trainer_class.SelectedIndex = (int)trainer_class_value.Value;
        }
        if (trainer_class_value.Value > 76m && radio_rs.Checked)
        {
            trainer_class.SelectedIndex = 77;
        }
        else if (trainer_class_value.Value > 79m && radio_e.Checked)
        {
            trainer_class.SelectedIndex = 80;
        }
        else if (trainer_class_value.Value > 146m && radio_FRLG.Checked)
        {
            trainer_class.SelectedIndex = 147;
        }
    }

    private void Trainer_classSelectedIndexChanged(object sender, EventArgs e)
    {
        trainer_class_value.Value = trainer_class.SelectedIndex;
    }

    private void EngCheckedChanged(object sender, EventArgs e)
    {
        update_easychat();
    }

    private void FreCheckedChanged(object sender, EventArgs e)
    {
        update_easychat();
    }

    private void GerCheckedChanged(object sender, EventArgs e)
    {
        update_easychat();
    }

    private void ItaCheckedChanged(object sender, EventArgs e)
    {
        update_easychat();
    }

    private void EspCheckedChanged(object sender, EventArgs e)
    {
        update_easychat();
    }

    private void JapCheckedChanged(object sender, EventArgs e)
    {
        update_easychat();
    }

    private void ECT_editorDragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.All;
    }

    private void ECT_editorDragDrop(object sender, DragEventArgs e)
    {
        string[] array = (string[])e.Data.GetData(DataFormats.FileDrop, autoConvert: false);
        Load_ECT(array[0]);
    }


}
