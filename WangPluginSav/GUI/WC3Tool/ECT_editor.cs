using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PKHeX;

namespace WC3Tool;

public class ECT_editor : Form
{
	public string ectfilter = "e-card Trainer file|*.ect|All Files (*.*)|*.*";

	public byte[] ectbuffer;

	public static ECT ectfile;

	private object[] trainer_index_RS_other = new object[77]
	{
		"$00: *AQUA LEADER", "$01: *TEAM AQUA    (♂)", "$02: *TEAM AQUA    (♀)", "$03:  AROMA LADY", "$04:  RUIN MANIAC", "$05: *INTERVIEWER", "$06:  TUBER        (♀)", "$07:  TUBER        (♂)", "$08:  COOLTRAINER♂", "$09:  COOLTRAINER♀",
		"$0A:  HEX MANIAC", "$0B:  LADY", "$0C:  BEAUTY", "$0D:  RICH BOY", "$0E:  POKéMANIAC", "$0F:  SWIMMER♂", "$10:  BLACK BELT", "$11:  GUITARIST", "$12:  KINDLER", "$13:  CAMPER",
		"$14:  BUG MANIAC", "$15:  PSYCHIC      (♂)", "$16:  PSYCHIC      (♀)", "$17:  GENTLEMAN", "$18: *ELITE FOUR   (Sidney)", "$19: *ELITE FOUR   (Phoebe)", "$1A: *LEADER       (Roxanne)", "$1B: *LEADER       (Brawly)", "$1C: *LEADER       (Tate&Liza)", "$1D:  SCHOOL KID   (♂)",
		"$1E:  SCHOOL KID   (♀)", "$1F: *SR. AND JR.", "$20:  POKéFAN      (♂)", "$21:  POKéFAN      (♀)", "$22:  EXPERT       (♂)", "$23:  EXPERT       (♀)", "$24:  YOUNGSTER", "$25: *CHAMPION", "$26:  FISHERMAN", "$27:  TRIATHLETE   (♂ cycling)",
		"$28:  TRIATHLETE   (♀ cycling)", "$29:  TRIATHLETE   (♂ running)", "$2A:  TRIATHLETE   (♀ running)", "$2B:  TRIATHLETE   (♂ swimming)", "$2C:  TRIATHLETE   (♀ swimming)", "$2D:  DRAGON TAMER", "$2E:  BIRD KEEPER", "$2F:  NINJA BOY", "$30:  BATTLE GIRL", "$31:  PARASOL LADY",
		"$32:  SWIMMER♀", "$33:  PICNICKER", "$34: *TWINS", "$35:  SAILOR", "$36: *BOARDER      (Youngster)", "$37: *BOARDER      (Youngster)", "$38:  COLLECTOR", "$39: *PKMN TRAINER (Wally)", "$3A: *PKMN TRAINER (Brendan)", "$3B: *PKMN TRAINER (Brendan)",
		"$3C: *PKMN TRAINER (Brendan)", "$3D: *PKMN TRAINER (May)", "$3E: *PKMN TRAINER (May)", "$3F: *PKMN TRAINER (May)", "$40:  PKMN BREEDER (♂)", "$41:  PKMN BREEDER (♀)", "$42:  PKMN RANGER  (♂)", "$43:  PKMN RANGER  (♀)", "$44: *MAGMA LEADER", "$45: *TEAM MAGMA   (♂)",
		"$46: *TEAM MAGMA   (♀)", "$47:  LASS", "$48:  BUG CATCHER", "$49:  HIKER", "$4A: *YOUNG COUPLE", "$4B: *OLD COUPLE", "$4C: *SIS AND BRO"
	};

	private object[] trainer_index_RS = new object[78]
	{
		"0x00: Aqua Leader (Archie)", "0x01: Team Aqua Grunt (Male)", "0x02: Team Aqua Grunt (Female)", "0x03: Aroma Lady", "0x04: Ruin Maniac", "0x05: Interviewer", "0x06: Tuber (Female)", "0x07: Tuber (Male)", "0x08: Cool Trainer (Male)", "0x09: Cool Trainer (Female)",
		"0x0A: Hex Maniac", "0x0B: Lady", "0x0C: Beauty", "0x0D: Rich Boy", "0x0E: Pokemaniac", "0x0F: Swimmer (Male)", "0x10: Blackbelt", "0x11: Guitarist", "0x12: Kindler", "0x13: Camper",
		"0x14: Bug Maniac", "0x15: Psychic (Male)", "0x16: Psychic (Female)", "0x17: Gentleman", "0x18: Elite Four (Sidney)", "0x19: Elite Four (Phoebe)", "0x1A: Leader (Roxanne)", "0x1B: Leader (Brawly)", "0x1C: Leader (Tate & Liza)", "0x1D: School Kid (Male)",
		"0x1E: School Kid (Female)", "0x1F: Sr. and Jr.", "0x20: Pokefan (Male)", "0x21: Pokefan (Female)", "0x22: Expert (Male)", "0x23: Expert (Female)", "0x24: Youngster", "0x25: Champion (Steven)", "0x26: Fisherman", "0x27: Triathlete Biker (Male)",
		"0x28: Triathlete Biker (Female)", "0x29: Triathlete Runner (Male)", "0x2A: Triathlete Runner (Female)", "0x2B: Triathlete Swimmer (Male)", "0x2C: Triathlete Swimmer (Female)", "0x2D: Dragon Tamer", "0x2E: Bird Keeper", "0x2F: Ninja Boy", "0x30: Battle Girl", "0x31: Parasol Lady",
		"0x32: Swimmer (Female)", "0x33: Picnicker", "0x34: Twins", "0x35: Sailor", "0x36: Boarder", "0x37: Boarder", "0x38: Collector", "0x39: PKMN Trainer (Wally)", "0x3A: PKMN Trainer (Brendan)", "0x3B: PKMN Trainer (Brendan)",
		"0x3C: PKMN Trainer (Brendan)", "0x3D: PKMN Trainer (May)", "0x3E: PKMN Trainer (May)", "0x3F: PKMN Trainer (May)", "0x40: PKMN Breeder (Male)", "0x41: PKMN Breeder (Female)", "0x42: PKMN Ranger (Male)", "0x43: PKMN Ranger (Female)", "0x44: Magma Leader (Maxie)", "0x45: Team Magma Grunt (Male)",
		"0x46: Team Magma Grunt (Female)", "0x47: Lass", "0x48: Bug Catcher", "0x49: Hiker", "0x4A: Young Couple", "0x4B: Old Couple", "0x4C: Sis and Bro", "<- SET BY INDEX"
	};

	private object[] trainer_index_E = new object[81]
	{
		"0x00: Hiker", "0x01: Team Aqua Grunt (Male)", "0x02: PKMN Breeder (Female)", "0x03: Cooltrainer (Male)", "0x04: Bird Keeper", "0x05: Collector", "0x06: Team Aqua Grunt (Female)", "0x07: Swimmer (Male)", "0x08: Team Magma Grunt (Male)", "0x09: Expert (Male)",
		"0x0A: Black Belt", "0x0B: Aqua Leader (Archie)", "0x0C: Hex Maniac", "0x0D: Aroma Lady", "0x0E: Ruin Maniac", "0x0F: Interviewer", "0x10: Tuber (Female)", "0x11: Tuber (Male)", "0x12: Cooltrainer (Female)", "0x13: Lady",
		"0x14: Beauty", "0x15: Rich Boy", "0x16: Expert (Female)", "0x17: Pokemaniac", "0x18: Team Magma Grunt (Female)", "0x19: Guitarist", "0x1A: Kindler", "0x1B: Camper", "0x1C: Picnicker", "0x1D: Bug Maniac",
		"0x1E: Psychic (Male)", "0x1F: Psychic (Female)", "0x20: Gentleman", "0x21: Elite Four (Sidney)", "0x22: Elite Four (Phoebe)", "0x23: Leader (Roxanne)", "0x24: Leader (Brawly)", "0x25: Leader (Tate & Liza)", "0x26: School Kid (Male)", "0x27: School Kid (Female)",
		"0x28: Sr. and Jr.", "0x29: Pokefan (Male)", "0x2A: Pokefan (Female)", "0x2B: Youngster", "0x2C: Champion (Wallace)", "0x2D: Fisherman", "0x2E: Triathlete Biker (Male)", "0x2F: Triathlete Biker (Female)", "0x30: Triathlete Runner (Male)", "0x31: Triathlete Runner (Female)",
		"0x32: Triathlete Swimmer (Male)", "0x33: Triathlete Swimmer (Female)", "0x34: Dragon Tamer", "0x35: Ninja Boy", "0x36: Battle Girl", "0x37: Parasol Lady", "0x38: Swimmer (Female)", "0x39: Twins", "0x3A: Sailor", "0x3B: PKMN Trainer (Wally)",
		"0x3C: PKMN Trainer (Brendan)", "0x3D: PKMN Trainer (Brendan)", "0x3E: PKMN Trainer (Brendan)", "0x3F: PKMN Trainer (May)", "0x40: PKMN Trainer (May)", "0x41: PKMN Trainer (May)", "0x42: PKMN Breeder (Male)", "0x43: Bug Catcher", "0x44: PKMN Ranger (Male)", "0x45: PKMN Ranger (Female)",
		"0x46: Magma Leader (Maxie)", "0x47: Lass", "0x48: Young Couple", "0x49: Old Couple", "0x4A: Sis and Bro", "0x4B: PKMN Trainer (Steven)", "0x4C: Salon Maiden (Anabel)", "0x4D: Dome Ace (Tucker)", "0x4E: PKMN Trainer (Red)", "0x4F: PKMN Trainer (Green)",
		"<- SET BY INDEX"
	};

	private object[] trainer_index_FRLG = new object[148]
	{
		"0x00: Aqua Leader (Archie)", "0x01: Team Aqua Grunt (Male)", "0x02: Team Aqua Grunt (Female)", "0x03: Aroma Lady", "0x04: Ruin Maniac", "0x05: Interviewer", "0x06: Tuber (Female)", "0x07: Tuber (Male)", "0x08: Cool Trainer (Male)", "0x09: Cool Trainer (Female)",
		"0x0A: Hex Maniac", "0x0B: Lady", "0x0C: Beauty", "0x0D: Rich Boy", "0x0E: Pokemaniac", "0x0F: Swimmer (Male)", "0x10: Blackbelt", "0x11: Guitarist", "0x12: Kindler", "0x13: Camper",
		"0x14: Bug Maniac", "0x15: Psychic (Male)", "0x16: Psychic (Female)", "0x17: Gentleman", "0x18: Elite Four (Sidney)", "0x19: Elite Four (Phoebe)", "0x1A: Leader (Roxanne)", "0x1B: Leader (Brawly)", "0x1C: Leader (Tate & Liza)", "0x1D: School Kid (Male)",
		"0x1E: School Kid (Female)", "0x1F: Sr. and Jr.", "0x20: Pokefan (Male)", "0x21: Pokefan (Female)", "0x22: Expert (Male)", "0x23: Expert (Female)", "0x24: Youngster", "0x25: Champion (Steven)", "0x26: Fisherman", "0x27: Triathlete Biker (Male)",
		"0x28: Triathlete Biker (Female)", "0x29: Triathlete Runner (Male)", "0x2A: Triathlete Runner (Female)", "0x2B: Triathlete Swimmer (Male)", "0x2C: Triathlete Swimmer (Female)", "0x2D: Dragon Tamer", "0x2E: Bird Keeper", "0x2F: Ninja Boy", "0x30: Battle Girl", "0x31: Parasol Lady",
		"0x32: Swimmer (Female)", "0x33: Picnicker", "0x34: Twins", "0x35: Sailor", "0x36: Boarder", "0x37: Boarder", "0x38: Collector", "0x39: PKMN Trainer (Wally)", "0x3A: PKMN Trainer (Brendan)", "0x3B: PKMN Trainer (Brendan)",
		"0x3C: PKMN Trainer (Brendan)", "0x3D: PKMN Trainer (May)", "0x3E: PKMN Trainer (May)", "0x3F: PKMN Trainer (May)", "0x40: PKMN Breeder (Male)", "0x41: PKMN Breeder (Female)", "0x42: PKMN Ranger (Male)", "0x43: PKMN Ranger (Female)", "0x44: Magma Leader (Maxie)", "0x45: Team Magma Grunt (Male)",
		"0x46: Team Magma Grunt (Female)", "0x47: Lass", "0x48: Bug Catcher", "0x49: Hiker", "0x4A: Young Couple", "0x4B: Old Couple", "0x4C: Sis and Bro", "0x4D: Aqua Admin (Matt)", "0x4E: Aqua Admin (Shelly)", "0x4F: Magma Admin (Tabitha)",
		"0x50: Magma Admin (Courtney)", "0x51: Leader (Wattson)", "0x52: Leader (Flannery)", "0x53: Leader (Norman)", "0x54: Leader (Winona)", "0x55: Leader (Wallace)", "0x56: Elite Four (Glacia)", "0x57: Elite Four (Drake)", "0x58: Youngster (FRLG)", "0x59: Bug Catcher (FRLG)",
		"0x5A: Lass (FRLG)", "0x5B: Sailor (FRLG)", "0x5C: Camper (FRLG)", "0c5D: Picnicker (FRLG)", "0x5E: Pokemaniac (FRLG)", "0x5F: Super Nerd", "0x60: Hiker (FRLG)", "0x61: Biker (FRLG)", "0x62: Burglar", "0x63: Engineer",
		"0x64: Fisherman", "0x65: Swimmer (Male) (FRLG)", "0x66: Cue Ball", "0x67: Gamer", "0x68: Beauty (FRLG)", "0x69: Swimmer (Female) (FRLG)", "0x6A: Psychic (Male)", "0x6B: Rocker", "0x6C: Juggler", "0x6D: Tamer",
		"0x6E: Bird Keeper (FRLG)", "0x6F: Blackbelt (FRLG)", "0x70: Rival (Gary)", "0x71: Scientist", "0x72: Boss (Giovanni)", "0x73: Team Rocket Grunt (Male)", "0x74: Cooltrainer (Male)", "0x75: Cooltrainer (Female)", "0x76: Elite Four (Lorelei)", "0x77: Elite Four (Bruno)",
		"0x78: Leader (Brock)", "0x79: Leader (Misty)", "0x7A: Gentleman (FRLG)", "0x7B: Rival (Gary)", "0x7C: Champion (Gary)", "0x7D: Channeler", "0x7E: Twins (FRLG)", "0x7F: Cool Couple", "0x80: Young Couple (FRLG)", "0x81: Crush Kin",
		"0x82: Sis and Bro (FRLG)", "0x83: PKMN Prof. (Oak)", "0x84: Player (Brendan)", "0x85: Player (May)", "0x86: Player (Red)", "0x87: Player (Green)", "0x88: Team Rocket Grunt (Female)", "0x89: Psychic (Female) (FRLG)", "0x8A: Crush Girl", "0x8B: Tuber (Female) (FRLG)",
		"0x8C: PKMN Breeder (Female) (FRLG)", "0x8D: PKMN Ranger (Male) (FRLG)", "0x8E: PKMN Ranger (Female) (FRLG)", "0x8F: Aroma Lady (FRLG)", "0x90: Ruin Maniac (FRLG)", "0x91: Lady (FRLG)", "0x92: Painter (Female)", "<- SET BY INDEX"
	};

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

	private IContainer components;

	private TextBox ect_path;

	private Button save_ect_but;

	private Button load_ect_but;

	private Label label1;

	private ComboBox tower_appearance;

	private Label label2;

	private ComboBox trainer_class;

	private Button helpclass_but;

	private Label label3;

	private NumericUpDown tower_floor;

	private ComboBox textA1;

	private ComboBox textA2;

	private ComboBox textA3;

	private ComboBox textA4;

	private ComboBox textA5;

	private ComboBox textA6;

	private GroupBox groupBox1;

	private GroupBox groupBox2;

	private ComboBox textB6;

	private ComboBox textB5;

	private ComboBox textB4;

	private ComboBox textB3;

	private ComboBox textB2;

	private ComboBox textB1;

	private GroupBox groupBox3;

	private ComboBox textC6;

	private ComboBox textC5;

	private ComboBox textC4;

	private ComboBox textC3;

	private ComboBox textC2;

	private ComboBox textC1;

	private ComboBox pkm3;

	private ComboBox pkm2;

	private ComboBox pkm1;

	private Label label9;

	private Label label8;

	private Label label7;

	private Button pkm3_edit_but;

	private Button pkm2_edit_but;

	private Button pkm1_edit_but;

	private Label label6;

	private NumericUpDown SID;

	private NumericUpDown TID;

	private Label label5;

	private Label label4;

	private TextBox name;

	private CheckBox jap_check;

	private RadioButton radio_rs;

	private RadioButton radio_e;

	private RadioButton radio_FRLG;

	private GroupBox groupBox4;

	private NumericUpDown tower_appearance_num;

	private NumericUpDown trainer_class_value;

	private GroupBox groupBox5;

	private RadioButton jap;

	private RadioButton esp;

	private RadioButton ita;

	private RadioButton ger;

	private RadioButton fre;

	private RadioButton eng;

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

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.ect_path = new System.Windows.Forms.TextBox();
		this.save_ect_but = new System.Windows.Forms.Button();
		this.load_ect_but = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.tower_appearance = new System.Windows.Forms.ComboBox();
		this.label2 = new System.Windows.Forms.Label();
		this.trainer_class = new System.Windows.Forms.ComboBox();
		this.helpclass_but = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.tower_floor = new System.Windows.Forms.NumericUpDown();
		this.textA1 = new System.Windows.Forms.ComboBox();
		this.textA2 = new System.Windows.Forms.ComboBox();
		this.textA3 = new System.Windows.Forms.ComboBox();
		this.textA4 = new System.Windows.Forms.ComboBox();
		this.textA5 = new System.Windows.Forms.ComboBox();
		this.textA6 = new System.Windows.Forms.ComboBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.textB6 = new System.Windows.Forms.ComboBox();
		this.textB5 = new System.Windows.Forms.ComboBox();
		this.textB4 = new System.Windows.Forms.ComboBox();
		this.textB3 = new System.Windows.Forms.ComboBox();
		this.textB2 = new System.Windows.Forms.ComboBox();
		this.textB1 = new System.Windows.Forms.ComboBox();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.textC6 = new System.Windows.Forms.ComboBox();
		this.textC5 = new System.Windows.Forms.ComboBox();
		this.textC4 = new System.Windows.Forms.ComboBox();
		this.textC3 = new System.Windows.Forms.ComboBox();
		this.textC2 = new System.Windows.Forms.ComboBox();
		this.textC1 = new System.Windows.Forms.ComboBox();
		this.pkm3 = new System.Windows.Forms.ComboBox();
		this.pkm2 = new System.Windows.Forms.ComboBox();
		this.pkm1 = new System.Windows.Forms.ComboBox();
		this.label9 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.pkm3_edit_but = new System.Windows.Forms.Button();
		this.pkm2_edit_but = new System.Windows.Forms.Button();
		this.pkm1_edit_but = new System.Windows.Forms.Button();
		this.label6 = new System.Windows.Forms.Label();
		this.SID = new System.Windows.Forms.NumericUpDown();
		this.TID = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.name = new System.Windows.Forms.TextBox();
		this.jap_check = new System.Windows.Forms.CheckBox();
		this.radio_rs = new System.Windows.Forms.RadioButton();
		this.radio_e = new System.Windows.Forms.RadioButton();
		this.radio_FRLG = new System.Windows.Forms.RadioButton();
		this.groupBox4 = new System.Windows.Forms.GroupBox();
		this.tower_appearance_num = new System.Windows.Forms.NumericUpDown();
		this.trainer_class_value = new System.Windows.Forms.NumericUpDown();
		this.groupBox5 = new System.Windows.Forms.GroupBox();
		this.jap = new System.Windows.Forms.RadioButton();
		this.esp = new System.Windows.Forms.RadioButton();
		this.ita = new System.Windows.Forms.RadioButton();
		this.ger = new System.Windows.Forms.RadioButton();
		this.fre = new System.Windows.Forms.RadioButton();
		this.eng = new System.Windows.Forms.RadioButton();
		((System.ComponentModel.ISupportInitialize)this.tower_floor).BeginInit();
		this.groupBox1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.groupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.SID).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TID).BeginInit();
		this.groupBox4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.tower_appearance_num).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.trainer_class_value).BeginInit();
		this.groupBox5.SuspendLayout();
		base.SuspendLayout();
		this.ect_path.Location = new System.Drawing.Point(180, 14);
		this.ect_path.Name = "ect_path";
		this.ect_path.ReadOnly = true;
		this.ect_path.Size = new System.Drawing.Size(641, 20);
		this.ect_path.TabIndex = 5;
		this.save_ect_but.Enabled = false;
		this.save_ect_but.Location = new System.Drawing.Point(89, 12);
		this.save_ect_but.Name = "save_ect_but";
		this.save_ect_but.Size = new System.Drawing.Size(75, 23);
		this.save_ect_but.TabIndex = 4;
		this.save_ect_but.Text = "Save ECT";
		this.save_ect_but.UseVisualStyleBackColor = true;
		this.save_ect_but.Click += new System.EventHandler(Save_ect_butClick);
		this.load_ect_but.Location = new System.Drawing.Point(8, 12);
		this.load_ect_but.Name = "load_ect_but";
		this.load_ect_but.Size = new System.Drawing.Size(75, 23);
		this.load_ect_but.TabIndex = 3;
		this.load_ect_but.Text = "Load ECT";
		this.load_ect_but.UseVisualStyleBackColor = true;
		this.load_ect_but.Click += new System.EventHandler(Load_ect_butClick);
		this.label1.Location = new System.Drawing.Point(14, 232);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(131, 18);
		this.label1.TabIndex = 6;
		this.label1.Text = "Battle Tower Appareance:";
		this.tower_appearance.FormattingEnabled = true;
		this.tower_appearance.Items.AddRange(new object[3] { "Mossdeep city house", "Battle Tower Lv50 Challenge", "Battle Tower Lv100 Challenge" });
		this.tower_appearance.Location = new System.Drawing.Point(145, 229);
		this.tower_appearance.Name = "tower_appearance";
		this.tower_appearance.Size = new System.Drawing.Size(191, 21);
		this.tower_appearance.TabIndex = 7;
		this.tower_appearance.Visible = false;
		this.label2.Location = new System.Drawing.Point(14, 259);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 23);
		this.label2.TabIndex = 8;
		this.label2.Text = "Trainer class:";
		this.trainer_class.FormattingEnabled = true;
		this.trainer_class.Location = new System.Drawing.Point(145, 256);
		this.trainer_class.Name = "trainer_class";
		this.trainer_class.Size = new System.Drawing.Size(191, 21);
		this.trainer_class.TabIndex = 9;
		this.trainer_class.SelectedIndexChanged += new System.EventHandler(Trainer_classSelectedIndexChanged);
		this.helpclass_but.Location = new System.Drawing.Point(342, 256);
		this.helpclass_but.Name = "helpclass_but";
		this.helpclass_but.Size = new System.Drawing.Size(22, 23);
		this.helpclass_but.TabIndex = 10;
		this.helpclass_but.Text = "?";
		this.helpclass_but.UseVisualStyleBackColor = true;
		this.helpclass_but.Click += new System.EventHandler(Helpclass_butClick);
		this.label3.Location = new System.Drawing.Point(14, 285);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(107, 18);
		this.label3.TabIndex = 11;
		this.label3.Text = "Battle Tower Floor:";
		this.tower_floor.Location = new System.Drawing.Point(145, 283);
		this.tower_floor.Name = "tower_floor";
		this.tower_floor.Size = new System.Drawing.Size(73, 20);
		this.tower_floor.TabIndex = 12;
		this.textA1.FormattingEnabled = true;
		this.textA1.Location = new System.Drawing.Point(27, 23);
		this.textA1.Name = "textA1";
		this.textA1.Size = new System.Drawing.Size(121, 21);
		this.textA1.TabIndex = 19;
		this.textA2.FormattingEnabled = true;
		this.textA2.Location = new System.Drawing.Point(154, 23);
		this.textA2.Name = "textA2";
		this.textA2.Size = new System.Drawing.Size(121, 21);
		this.textA2.TabIndex = 20;
		this.textA3.FormattingEnabled = true;
		this.textA3.Location = new System.Drawing.Point(281, 23);
		this.textA3.Name = "textA3";
		this.textA3.Size = new System.Drawing.Size(121, 21);
		this.textA3.TabIndex = 21;
		this.textA4.FormattingEnabled = true;
		this.textA4.Location = new System.Drawing.Point(27, 50);
		this.textA4.Name = "textA4";
		this.textA4.Size = new System.Drawing.Size(121, 21);
		this.textA4.TabIndex = 22;
		this.textA5.FormattingEnabled = true;
		this.textA5.Location = new System.Drawing.Point(154, 50);
		this.textA5.Name = "textA5";
		this.textA5.Size = new System.Drawing.Size(121, 21);
		this.textA5.TabIndex = 23;
		this.textA6.FormattingEnabled = true;
		this.textA6.Location = new System.Drawing.Point(281, 50);
		this.textA6.Name = "textA6";
		this.textA6.Size = new System.Drawing.Size(121, 21);
		this.textA6.TabIndex = 24;
		this.groupBox1.Controls.Add(this.textA6);
		this.groupBox1.Controls.Add(this.textA5);
		this.groupBox1.Controls.Add(this.textA4);
		this.groupBox1.Controls.Add(this.textA3);
		this.groupBox1.Controls.Add(this.textA2);
		this.groupBox1.Controls.Add(this.textA1);
		this.groupBox1.Location = new System.Drawing.Point(370, 42);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(415, 83);
		this.groupBox1.TabIndex = 25;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = " Pre-battle text:";
		this.groupBox2.Controls.Add(this.textB6);
		this.groupBox2.Controls.Add(this.textB5);
		this.groupBox2.Controls.Add(this.textB4);
		this.groupBox2.Controls.Add(this.textB3);
		this.groupBox2.Controls.Add(this.textB2);
		this.groupBox2.Controls.Add(this.textB1);
		this.groupBox2.Location = new System.Drawing.Point(370, 131);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(415, 83);
		this.groupBox2.TabIndex = 26;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Victory text:";
		this.textB6.FormattingEnabled = true;
		this.textB6.Location = new System.Drawing.Point(281, 50);
		this.textB6.Name = "textB6";
		this.textB6.Size = new System.Drawing.Size(121, 21);
		this.textB6.TabIndex = 24;
		this.textB5.FormattingEnabled = true;
		this.textB5.Location = new System.Drawing.Point(154, 50);
		this.textB5.Name = "textB5";
		this.textB5.Size = new System.Drawing.Size(121, 21);
		this.textB5.TabIndex = 23;
		this.textB4.FormattingEnabled = true;
		this.textB4.Location = new System.Drawing.Point(27, 50);
		this.textB4.Name = "textB4";
		this.textB4.Size = new System.Drawing.Size(121, 21);
		this.textB4.TabIndex = 22;
		this.textB3.FormattingEnabled = true;
		this.textB3.Location = new System.Drawing.Point(281, 23);
		this.textB3.Name = "textB3";
		this.textB3.Size = new System.Drawing.Size(121, 21);
		this.textB3.TabIndex = 21;
		this.textB2.FormattingEnabled = true;
		this.textB2.Location = new System.Drawing.Point(154, 23);
		this.textB2.Name = "textB2";
		this.textB2.Size = new System.Drawing.Size(121, 21);
		this.textB2.TabIndex = 20;
		this.textB1.FormattingEnabled = true;
		this.textB1.Location = new System.Drawing.Point(27, 23);
		this.textB1.Name = "textB1";
		this.textB1.Size = new System.Drawing.Size(121, 21);
		this.textB1.TabIndex = 19;
		this.groupBox3.Controls.Add(this.textC6);
		this.groupBox3.Controls.Add(this.textC5);
		this.groupBox3.Controls.Add(this.textC4);
		this.groupBox3.Controls.Add(this.textC3);
		this.groupBox3.Controls.Add(this.textC2);
		this.groupBox3.Controls.Add(this.textC1);
		this.groupBox3.Location = new System.Drawing.Point(370, 220);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(415, 83);
		this.groupBox3.TabIndex = 27;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Defeat text:";
		this.textC6.FormattingEnabled = true;
		this.textC6.Location = new System.Drawing.Point(281, 50);
		this.textC6.Name = "textC6";
		this.textC6.Size = new System.Drawing.Size(121, 21);
		this.textC6.TabIndex = 24;
		this.textC5.FormattingEnabled = true;
		this.textC5.Location = new System.Drawing.Point(154, 50);
		this.textC5.Name = "textC5";
		this.textC5.Size = new System.Drawing.Size(121, 21);
		this.textC5.TabIndex = 23;
		this.textC4.FormattingEnabled = true;
		this.textC4.Location = new System.Drawing.Point(27, 50);
		this.textC4.Name = "textC4";
		this.textC4.Size = new System.Drawing.Size(121, 21);
		this.textC4.TabIndex = 22;
		this.textC3.FormattingEnabled = true;
		this.textC3.Location = new System.Drawing.Point(281, 23);
		this.textC3.Name = "textC3";
		this.textC3.Size = new System.Drawing.Size(121, 21);
		this.textC3.TabIndex = 21;
		this.textC2.FormattingEnabled = true;
		this.textC2.Location = new System.Drawing.Point(154, 23);
		this.textC2.Name = "textC2";
		this.textC2.Size = new System.Drawing.Size(121, 21);
		this.textC2.TabIndex = 20;
		this.textC1.FormattingEnabled = true;
		this.textC1.Location = new System.Drawing.Point(27, 23);
		this.textC1.Name = "textC1";
		this.textC1.Size = new System.Drawing.Size(121, 21);
		this.textC1.TabIndex = 19;
		this.pkm3.FormattingEnabled = true;
		this.pkm3.Items.AddRange(new object[440]
		{
			"NONE", "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise",
			"Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata",
			"Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀",
			"Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff",
			"Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth",
			"Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine",
			"Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout",
			"Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke",
			"Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk",
			"Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler",
			"Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing",
			"Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking",
			"Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp",
			"Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar",
			"Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite",
			"Mewtwo", "Mew", "Chikorita", "Bayleef", "Meganium", "Cyndaquil", "Quilava", "Typhlosion", "Totodile", "Croconaw",
			"Feraligatr", "Sentret", "Furret", "Hoothoot", "Noctowl", "Ledyba", "Ledian", "Spinarak", "Ariados", "Crobat",
			"Chinchou", "Lanturn", "Pichu", "Cleffa", "Igglybuff", "Togepi", "Togetic", "Natu", "Xatu", "Mareep",
			"Flaaffy", "Ampharos", "Bellossom", "Marill", "Azumarill", "Sudowoodo", "Politoed", "Hoppip", "Skiploom", "Jumpluff",
			"Aipom", "Sunkern", "Sunflora", "Yanma", "Wooper", "Quagsire", "Espeon", "Umbreon", "Murkrow", "Slowking",
			"Misdreavus", "Unown A", "Wobbuffet", "Girafarig", "Pineco", "Forretress", "Dunsparce", "Gligar", "Steelix", "Snubbull",
			"Granbull", "Qwilfish", "Scizor", "Shuckle", "Heracross", "Sneasel", "Teddiursa", "Ursaring", "Slugma", "Magcargo",
			"Swinub", "Piloswine", "Corsola", "Remoraid", "Octillery", "Delibird", "Mantine", "Skarmory", "Houndour", "Houndoom",
			"Kingdra", "Phanpy", "Donphan", "Porygon2", "Stantler", "Smeargle", "Tyrogue", "Hitmontop", "Smoochum", "Elekid",
			"Magby", "Miltank", "Blissey", "Raikou", "Entei", "Suicune", "Larvitar", "Pupitar", "Tyranitar", "Lugia",
			"Ho-oh", "Celebi", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)",
			"? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)",
			"? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "Treecko", "Grovyle", "Sceptile",
			"Torchic", "Combusken", "Blaziken", "Mudkip", "Marshtomp", "Swampert", "Poochyena", "Mightyena", "Zigzagoon", "Linoone",
			"Wurmple", "Silcoon", "Beautifly", "Cascoon", "Dustox", "Lotad", "Lombre", "Ludicolo", "Seedot", "Nuzleaf",
			"Shiftry", "Nincada", "Ninjask", "Shedinja", "Taillow", "Swellow", "Shroomish", "Breloom", "Spinda", "Wingull",
			"Pelipper", "Surskit", "Masquerain", "Wailmer", "Wailord", "Skitty", "Delcatty", "Kecleon", "Baltoy", "Claydol",
			"Nosepass", "Torkoal", "Sableye", "Barboach", "Whiscash", "Luvdisc", "Corphish", "Crawdaunt", "Feebas", "Milotic",
			"Carvanha", "Sharpedo", "Trapinch", "Vibrava", "Flygon", "Makuhita", "Hariyama", "Electrike", "Manectric", "Numel",
			"Camerupt", "Spheal", "Sealeo", "Walrein", "Cacnea", "Cacturne", "Snorunt", "Glalie", "Lunatone", "Solrock",
			"Azurill", "Spoink", "Grumpig", "Plusle", "Minun", "Mawile", "Meditite", "Medicham", "Swablu", "Altaria",
			"Wynaut", "Duskull", "Dusclops", "Roselia", "Slakoth", "Vigoroth", "Slaking", "Gulpin", "Swalot", "Tropius",
			"Whismur", "Loudred", "Exploud", "Clamperl", "Huntail", "Gorebyss", "Absol", "Shuppet", "Banette", "Seviper",
			"Zangoose", "Relicanth", "Aron", "Lairon", "Aggron", "Castform", "Volbeat", "Illumise", "Lileep", "Cradily",
			"Anorith", "Armaldo", "Ralts", "Kirlia", "Gardevoir", "Bagon", "Shelgon", "Salamence", "Beldum", "Metang",
			"Metagross", "Regirock", "Regice", "Registeel", "Kyogre", "Groudon", "Rayquaza", "Latias", "Latios", "Jirachi",
			"Deoxys", "Chimecho", "Pokémon Egg", "Unown B", "Unown C", "Unown D", "Unown E", "Unown F", "Unown G", "Unown H",
			"Unown I", "Unown J", "Unown K", "Unown L", "Unown M", "Unown N", "Unown O", "Unown P", "Unown Q", "Unown R",
			"Unown S", "Unown T", "Unown U", "Unown V", "Unown W", "Unown X", "Unown Y", "Unown Z", "Unown !", "Unown ?"
		});
		this.pkm3.Location = new System.Drawing.Point(89, 181);
		this.pkm3.Name = "pkm3";
		this.pkm3.Size = new System.Drawing.Size(161, 21);
		this.pkm3.TabIndex = 51;
		this.pkm2.FormattingEnabled = true;
		this.pkm2.Items.AddRange(new object[440]
		{
			"NONE", "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise",
			"Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata",
			"Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀",
			"Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff",
			"Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth",
			"Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine",
			"Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout",
			"Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke",
			"Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk",
			"Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler",
			"Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing",
			"Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking",
			"Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp",
			"Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar",
			"Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite",
			"Mewtwo", "Mew", "Chikorita", "Bayleef", "Meganium", "Cyndaquil", "Quilava", "Typhlosion", "Totodile", "Croconaw",
			"Feraligatr", "Sentret", "Furret", "Hoothoot", "Noctowl", "Ledyba", "Ledian", "Spinarak", "Ariados", "Crobat",
			"Chinchou", "Lanturn", "Pichu", "Cleffa", "Igglybuff", "Togepi", "Togetic", "Natu", "Xatu", "Mareep",
			"Flaaffy", "Ampharos", "Bellossom", "Marill", "Azumarill", "Sudowoodo", "Politoed", "Hoppip", "Skiploom", "Jumpluff",
			"Aipom", "Sunkern", "Sunflora", "Yanma", "Wooper", "Quagsire", "Espeon", "Umbreon", "Murkrow", "Slowking",
			"Misdreavus", "Unown A", "Wobbuffet", "Girafarig", "Pineco", "Forretress", "Dunsparce", "Gligar", "Steelix", "Snubbull",
			"Granbull", "Qwilfish", "Scizor", "Shuckle", "Heracross", "Sneasel", "Teddiursa", "Ursaring", "Slugma", "Magcargo",
			"Swinub", "Piloswine", "Corsola", "Remoraid", "Octillery", "Delibird", "Mantine", "Skarmory", "Houndour", "Houndoom",
			"Kingdra", "Phanpy", "Donphan", "Porygon2", "Stantler", "Smeargle", "Tyrogue", "Hitmontop", "Smoochum", "Elekid",
			"Magby", "Miltank", "Blissey", "Raikou", "Entei", "Suicune", "Larvitar", "Pupitar", "Tyranitar", "Lugia",
			"Ho-oh", "Celebi", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)",
			"? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)",
			"? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "Treecko", "Grovyle", "Sceptile",
			"Torchic", "Combusken", "Blaziken", "Mudkip", "Marshtomp", "Swampert", "Poochyena", "Mightyena", "Zigzagoon", "Linoone",
			"Wurmple", "Silcoon", "Beautifly", "Cascoon", "Dustox", "Lotad", "Lombre", "Ludicolo", "Seedot", "Nuzleaf",
			"Shiftry", "Nincada", "Ninjask", "Shedinja", "Taillow", "Swellow", "Shroomish", "Breloom", "Spinda", "Wingull",
			"Pelipper", "Surskit", "Masquerain", "Wailmer", "Wailord", "Skitty", "Delcatty", "Kecleon", "Baltoy", "Claydol",
			"Nosepass", "Torkoal", "Sableye", "Barboach", "Whiscash", "Luvdisc", "Corphish", "Crawdaunt", "Feebas", "Milotic",
			"Carvanha", "Sharpedo", "Trapinch", "Vibrava", "Flygon", "Makuhita", "Hariyama", "Electrike", "Manectric", "Numel",
			"Camerupt", "Spheal", "Sealeo", "Walrein", "Cacnea", "Cacturne", "Snorunt", "Glalie", "Lunatone", "Solrock",
			"Azurill", "Spoink", "Grumpig", "Plusle", "Minun", "Mawile", "Meditite", "Medicham", "Swablu", "Altaria",
			"Wynaut", "Duskull", "Dusclops", "Roselia", "Slakoth", "Vigoroth", "Slaking", "Gulpin", "Swalot", "Tropius",
			"Whismur", "Loudred", "Exploud", "Clamperl", "Huntail", "Gorebyss", "Absol", "Shuppet", "Banette", "Seviper",
			"Zangoose", "Relicanth", "Aron", "Lairon", "Aggron", "Castform", "Volbeat", "Illumise", "Lileep", "Cradily",
			"Anorith", "Armaldo", "Ralts", "Kirlia", "Gardevoir", "Bagon", "Shelgon", "Salamence", "Beldum", "Metang",
			"Metagross", "Regirock", "Regice", "Registeel", "Kyogre", "Groudon", "Rayquaza", "Latias", "Latios", "Jirachi",
			"Deoxys", "Chimecho", "Pokémon Egg", "Unown B", "Unown C", "Unown D", "Unown E", "Unown F", "Unown G", "Unown H",
			"Unown I", "Unown J", "Unown K", "Unown L", "Unown M", "Unown N", "Unown O", "Unown P", "Unown Q", "Unown R",
			"Unown S", "Unown T", "Unown U", "Unown V", "Unown W", "Unown X", "Unown Y", "Unown Z", "Unown !", "Unown ?"
		});
		this.pkm2.Location = new System.Drawing.Point(89, 157);
		this.pkm2.Name = "pkm2";
		this.pkm2.Size = new System.Drawing.Size(161, 21);
		this.pkm2.TabIndex = 50;
		this.pkm1.FormattingEnabled = true;
		this.pkm1.Items.AddRange(new object[440]
		{
			"NONE", "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise",
			"Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata",
			"Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀",
			"Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff",
			"Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth",
			"Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine",
			"Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout",
			"Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke",
			"Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk",
			"Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler",
			"Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing",
			"Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking",
			"Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp",
			"Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar",
			"Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite",
			"Mewtwo", "Mew", "Chikorita", "Bayleef", "Meganium", "Cyndaquil", "Quilava", "Typhlosion", "Totodile", "Croconaw",
			"Feraligatr", "Sentret", "Furret", "Hoothoot", "Noctowl", "Ledyba", "Ledian", "Spinarak", "Ariados", "Crobat",
			"Chinchou", "Lanturn", "Pichu", "Cleffa", "Igglybuff", "Togepi", "Togetic", "Natu", "Xatu", "Mareep",
			"Flaaffy", "Ampharos", "Bellossom", "Marill", "Azumarill", "Sudowoodo", "Politoed", "Hoppip", "Skiploom", "Jumpluff",
			"Aipom", "Sunkern", "Sunflora", "Yanma", "Wooper", "Quagsire", "Espeon", "Umbreon", "Murkrow", "Slowking",
			"Misdreavus", "Unown A", "Wobbuffet", "Girafarig", "Pineco", "Forretress", "Dunsparce", "Gligar", "Steelix", "Snubbull",
			"Granbull", "Qwilfish", "Scizor", "Shuckle", "Heracross", "Sneasel", "Teddiursa", "Ursaring", "Slugma", "Magcargo",
			"Swinub", "Piloswine", "Corsola", "Remoraid", "Octillery", "Delibird", "Mantine", "Skarmory", "Houndour", "Houndoom",
			"Kingdra", "Phanpy", "Donphan", "Porygon2", "Stantler", "Smeargle", "Tyrogue", "Hitmontop", "Smoochum", "Elekid",
			"Magby", "Miltank", "Blissey", "Raikou", "Entei", "Suicune", "Larvitar", "Pupitar", "Tyranitar", "Lugia",
			"Ho-oh", "Celebi", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)",
			"? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)",
			"? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "? (glitch Pokémon)", "Treecko", "Grovyle", "Sceptile",
			"Torchic", "Combusken", "Blaziken", "Mudkip", "Marshtomp", "Swampert", "Poochyena", "Mightyena", "Zigzagoon", "Linoone",
			"Wurmple", "Silcoon", "Beautifly", "Cascoon", "Dustox", "Lotad", "Lombre", "Ludicolo", "Seedot", "Nuzleaf",
			"Shiftry", "Nincada", "Ninjask", "Shedinja", "Taillow", "Swellow", "Shroomish", "Breloom", "Spinda", "Wingull",
			"Pelipper", "Surskit", "Masquerain", "Wailmer", "Wailord", "Skitty", "Delcatty", "Kecleon", "Baltoy", "Claydol",
			"Nosepass", "Torkoal", "Sableye", "Barboach", "Whiscash", "Luvdisc", "Corphish", "Crawdaunt", "Feebas", "Milotic",
			"Carvanha", "Sharpedo", "Trapinch", "Vibrava", "Flygon", "Makuhita", "Hariyama", "Electrike", "Manectric", "Numel",
			"Camerupt", "Spheal", "Sealeo", "Walrein", "Cacnea", "Cacturne", "Snorunt", "Glalie", "Lunatone", "Solrock",
			"Azurill", "Spoink", "Grumpig", "Plusle", "Minun", "Mawile", "Meditite", "Medicham", "Swablu", "Altaria",
			"Wynaut", "Duskull", "Dusclops", "Roselia", "Slakoth", "Vigoroth", "Slaking", "Gulpin", "Swalot", "Tropius",
			"Whismur", "Loudred", "Exploud", "Clamperl", "Huntail", "Gorebyss", "Absol", "Shuppet", "Banette", "Seviper",
			"Zangoose", "Relicanth", "Aron", "Lairon", "Aggron", "Castform", "Volbeat", "Illumise", "Lileep", "Cradily",
			"Anorith", "Armaldo", "Ralts", "Kirlia", "Gardevoir", "Bagon", "Shelgon", "Salamence", "Beldum", "Metang",
			"Metagross", "Regirock", "Regice", "Registeel", "Kyogre", "Groudon", "Rayquaza", "Latias", "Latios", "Jirachi",
			"Deoxys", "Chimecho", "Pokémon Egg", "Unown B", "Unown C", "Unown D", "Unown E", "Unown F", "Unown G", "Unown H",
			"Unown I", "Unown J", "Unown K", "Unown L", "Unown M", "Unown N", "Unown O", "Unown P", "Unown Q", "Unown R",
			"Unown S", "Unown T", "Unown U", "Unown V", "Unown W", "Unown X", "Unown Y", "Unown Z", "Unown !", "Unown ?"
		});
		this.pkm1.Location = new System.Drawing.Point(89, 130);
		this.pkm1.Name = "pkm1";
		this.pkm1.Size = new System.Drawing.Size(161, 21);
		this.pkm1.TabIndex = 49;
		this.label9.Location = new System.Drawing.Point(14, 184);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(100, 18);
		this.label9.TabIndex = 48;
		this.label9.Text = "Pokémon 3:";
		this.label8.Location = new System.Drawing.Point(14, 160);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(100, 18);
		this.label8.TabIndex = 47;
		this.label8.Text = "Pokémon 2:";
		this.label7.Location = new System.Drawing.Point(14, 133);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(75, 18);
		this.label7.TabIndex = 46;
		this.label7.Text = "Pokémon 1:";
		this.pkm3_edit_but.Enabled = false;
		this.pkm3_edit_but.Location = new System.Drawing.Point(261, 179);
		this.pkm3_edit_but.Name = "pkm3_edit_but";
		this.pkm3_edit_but.Size = new System.Drawing.Size(75, 23);
		this.pkm3_edit_but.TabIndex = 45;
		this.pkm3_edit_but.Text = "EDIT";
		this.pkm3_edit_but.UseVisualStyleBackColor = true;
		this.pkm3_edit_but.Click += new System.EventHandler(Pkm3_edit_butClick);
		this.pkm2_edit_but.Enabled = false;
		this.pkm2_edit_but.Location = new System.Drawing.Point(261, 155);
		this.pkm2_edit_but.Name = "pkm2_edit_but";
		this.pkm2_edit_but.Size = new System.Drawing.Size(75, 23);
		this.pkm2_edit_but.TabIndex = 44;
		this.pkm2_edit_but.Text = "EDIT";
		this.pkm2_edit_but.UseVisualStyleBackColor = true;
		this.pkm2_edit_but.Click += new System.EventHandler(Pkm2_edit_butClick);
		this.pkm1_edit_but.Enabled = false;
		this.pkm1_edit_but.Location = new System.Drawing.Point(261, 128);
		this.pkm1_edit_but.Name = "pkm1_edit_but";
		this.pkm1_edit_but.Size = new System.Drawing.Size(75, 23);
		this.pkm1_edit_but.TabIndex = 43;
		this.pkm1_edit_but.Text = "EDIT";
		this.pkm1_edit_but.UseVisualStyleBackColor = true;
		this.pkm1_edit_but.Click += new System.EventHandler(Pkm1_edit_butClick);
		this.label6.Location = new System.Drawing.Point(42, 105);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(41, 23);
		this.label6.TabIndex = 42;
		this.label6.Text = "SID:";
		this.SID.Location = new System.Drawing.Point(89, 103);
		this.SID.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
		this.SID.Name = "SID";
		this.SID.Size = new System.Drawing.Size(161, 20);
		this.SID.TabIndex = 41;
		this.TID.Location = new System.Drawing.Point(89, 77);
		this.TID.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
		this.TID.Name = "TID";
		this.TID.Size = new System.Drawing.Size(161, 20);
		this.TID.TabIndex = 40;
		this.label5.Location = new System.Drawing.Point(42, 79);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(25, 23);
		this.label5.TabIndex = 39;
		this.label5.Text = "TID:";
		this.label4.Location = new System.Drawing.Point(42, 54);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(41, 23);
		this.label4.TabIndex = 38;
		this.label4.Text = "Name:";
		this.name.Location = new System.Drawing.Point(89, 51);
		this.name.MaxLength = 7;
		this.name.Name = "name";
		this.name.Size = new System.Drawing.Size(161, 20);
		this.name.TabIndex = 37;
		this.jap_check.Enabled = false;
		this.jap_check.Location = new System.Drawing.Point(256, 49);
		this.jap_check.Name = "jap_check";
		this.jap_check.Size = new System.Drawing.Size(104, 24);
		this.jap_check.TabIndex = 52;
		this.jap_check.Text = "JAP encoding";
		this.jap_check.UseVisualStyleBackColor = true;
		this.jap_check.CheckedChanged += new System.EventHandler(Jap_checkCheckedChanged);
		this.radio_rs.Location = new System.Drawing.Point(6, 19);
		this.radio_rs.Name = "radio_rs";
		this.radio_rs.Size = new System.Drawing.Size(104, 17);
		this.radio_rs.TabIndex = 53;
		this.radio_rs.TabStop = true;
		this.radio_rs.Text = "Ruby/Sapphire";
		this.radio_rs.UseVisualStyleBackColor = true;
		this.radio_rs.CheckedChanged += new System.EventHandler(Radio_rsCheckedChanged);
		this.radio_e.Location = new System.Drawing.Point(6, 36);
		this.radio_e.Name = "radio_e";
		this.radio_e.Size = new System.Drawing.Size(88, 20);
		this.radio_e.TabIndex = 54;
		this.radio_e.TabStop = true;
		this.radio_e.Text = "Emerald";
		this.radio_e.UseVisualStyleBackColor = true;
		this.radio_e.CheckedChanged += new System.EventHandler(Radio_eCheckedChanged);
		this.radio_FRLG.Location = new System.Drawing.Point(6, 53);
		this.radio_FRLG.Name = "radio_FRLG";
		this.radio_FRLG.Size = new System.Drawing.Size(124, 22);
		this.radio_FRLG.TabIndex = 55;
		this.radio_FRLG.TabStop = true;
		this.radio_FRLG.Text = "Fire Red/Leaf Green";
		this.radio_FRLG.UseVisualStyleBackColor = true;
		this.radio_FRLG.CheckedChanged += new System.EventHandler(Radio_FRLGCheckedChanged);
		this.groupBox4.Controls.Add(this.radio_rs);
		this.groupBox4.Controls.Add(this.radio_e);
		this.groupBox4.Controls.Add(this.radio_FRLG);
		this.groupBox4.Location = new System.Drawing.Point(224, 283);
		this.groupBox4.Name = "groupBox4";
		this.groupBox4.Size = new System.Drawing.Size(136, 81);
		this.groupBox4.TabIndex = 56;
		this.groupBox4.TabStop = false;
		this.groupBox4.Text = "Trainer Class List";
		this.tower_appearance_num.Location = new System.Drawing.Point(145, 229);
		this.tower_appearance_num.Name = "tower_appearance_num";
		this.tower_appearance_num.Size = new System.Drawing.Size(189, 20);
		this.tower_appearance_num.TabIndex = 57;
		this.trainer_class_value.Hexadecimal = true;
		this.trainer_class_value.Location = new System.Drawing.Point(89, 257);
		this.trainer_class_value.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		this.trainer_class_value.Name = "trainer_class_value";
		this.trainer_class_value.Size = new System.Drawing.Size(50, 20);
		this.trainer_class_value.TabIndex = 58;
		this.trainer_class_value.ValueChanged += new System.EventHandler(Trainer_class_valueValueChanged);
		this.groupBox5.Controls.Add(this.jap);
		this.groupBox5.Controls.Add(this.esp);
		this.groupBox5.Controls.Add(this.ita);
		this.groupBox5.Controls.Add(this.ger);
		this.groupBox5.Controls.Add(this.fre);
		this.groupBox5.Controls.Add(this.eng);
		this.groupBox5.Location = new System.Drawing.Point(370, 312);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new System.Drawing.Size(414, 65);
		this.groupBox5.TabIndex = 59;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "Easy Chat System Language";
		this.jap.Location = new System.Drawing.Point(281, 37);
		this.jap.Name = "jap";
		this.jap.Size = new System.Drawing.Size(104, 24);
		this.jap.TabIndex = 3;
		this.jap.TabStop = true;
		this.jap.Text = "Japanese";
		this.jap.UseVisualStyleBackColor = true;
		this.jap.CheckedChanged += new System.EventHandler(JapCheckedChanged);
		this.esp.Location = new System.Drawing.Point(154, 37);
		this.esp.Name = "esp";
		this.esp.Size = new System.Drawing.Size(104, 24);
		this.esp.TabIndex = 61;
		this.esp.TabStop = true;
		this.esp.Text = "Spanish";
		this.esp.UseVisualStyleBackColor = true;
		this.esp.CheckedChanged += new System.EventHandler(EspCheckedChanged);
		this.ita.Location = new System.Drawing.Point(27, 37);
		this.ita.Name = "ita";
		this.ita.Size = new System.Drawing.Size(104, 24);
		this.ita.TabIndex = 60;
		this.ita.TabStop = true;
		this.ita.Text = "Italian";
		this.ita.UseVisualStyleBackColor = true;
		this.ita.CheckedChanged += new System.EventHandler(ItaCheckedChanged);
		this.ger.Location = new System.Drawing.Point(281, 19);
		this.ger.Name = "ger";
		this.ger.Size = new System.Drawing.Size(104, 24);
		this.ger.TabIndex = 2;
		this.ger.TabStop = true;
		this.ger.Text = "German";
		this.ger.UseVisualStyleBackColor = true;
		this.ger.CheckedChanged += new System.EventHandler(GerCheckedChanged);
		this.fre.Location = new System.Drawing.Point(154, 19);
		this.fre.Name = "fre";
		this.fre.Size = new System.Drawing.Size(104, 24);
		this.fre.TabIndex = 1;
		this.fre.TabStop = true;
		this.fre.Text = "French";
		this.fre.UseVisualStyleBackColor = true;
		this.fre.CheckedChanged += new System.EventHandler(FreCheckedChanged);
		this.eng.Location = new System.Drawing.Point(27, 19);
		this.eng.Name = "eng";
		this.eng.Size = new System.Drawing.Size(104, 24);
		this.eng.TabIndex = 0;
		this.eng.TabStop = true;
		this.eng.Text = "English";
		this.eng.UseVisualStyleBackColor = true;
		this.eng.CheckedChanged += new System.EventHandler(EngCheckedChanged);
		this.AllowDrop = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(833, 391);
		base.Controls.Add(this.groupBox5);
		base.Controls.Add(this.trainer_class_value);
		base.Controls.Add(this.tower_appearance_num);
		base.Controls.Add(this.groupBox4);
		base.Controls.Add(this.jap_check);
		base.Controls.Add(this.pkm3);
		base.Controls.Add(this.pkm2);
		base.Controls.Add(this.pkm1);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.pkm3_edit_but);
		base.Controls.Add(this.pkm2_edit_but);
		base.Controls.Add(this.pkm1_edit_but);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.SID);
		base.Controls.Add(this.TID);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.name);
		base.Controls.Add(this.groupBox3);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.tower_floor);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.helpclass_but);
		base.Controls.Add(this.trainer_class);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.tower_appearance);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.ect_path);
		base.Controls.Add(this.save_ect_but);
		base.Controls.Add(this.load_ect_but);
		base.Name = "ECT_editor";
		this.Text = "ECT Editor";
		base.DragDrop += new System.Windows.Forms.DragEventHandler(ECT_editorDragDrop);
		base.DragEnter += new System.Windows.Forms.DragEventHandler(ECT_editorDragEnter);
		((System.ComponentModel.ISupportInitialize)this.tower_floor).EndInit();
		this.groupBox1.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		this.groupBox3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.SID).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TID).EndInit();
		this.groupBox4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.tower_appearance_num).EndInit();
		((System.ComponentModel.ISupportInitialize)this.trainer_class_value).EndInit();
		this.groupBox5.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
