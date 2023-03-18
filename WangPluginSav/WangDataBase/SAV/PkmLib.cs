using System.Collections.Generic;
using System.Drawing;
using System.Linq;


namespace Pikaedit;

public static class PkmLib
{
	public enum Languages
	{
		None = 0,
		Japan = 1,
		English = 2,
		French = 3,
		Italian = 4,
		German = 5,
		Spanish = 7,
		Korean = 8
	}

	public enum GenderRatios
	{
		Genderless,
		Always_Male,
		Always_Female,
		Half,
		Mostly_Male,
		Almost_Male,
		Mostly_Female
	}

	public static byte[] dsvfooter = new byte[122]
	{
		124, 60, 45, 45, 83, 110, 105, 112, 32, 97,
		98, 111, 118, 101, 32, 104, 101, 114, 101, 32,
		116, 111, 32, 99, 114, 101, 97, 116, 101, 32,
		97, 32, 114, 97, 119, 32, 115, 97, 118, 32,
		98, 121, 32, 101, 120, 99, 108, 117, 100, 105,
		110, 103, 32, 116, 104, 105, 115, 32, 68, 101,
		83, 109, 117, 77, 69, 32, 115, 97, 118, 101,
		100, 97, 116, 97, 32, 102, 111, 111, 116, 101,
		114, 58, 0, 0, 8, 0, 0, 0, 8, 0,
		5, 0, 0, 0, 3, 0, 0, 0, 0, 0,
		8, 0, 0, 0, 0, 0, 124, 45, 68, 69,
		83, 77, 85, 77, 69, 32, 83, 65, 86, 69,
		45, 124
	};

	public static byte[] genderRatio = new byte[650]
	{
		0, 4, 4, 4, 4, 4, 4, 4, 4, 4,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 2,
		2, 2, 1, 1, 1, 6, 6, 6, 6, 6,
		6, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 5, 5,
		3, 3, 3, 5, 5, 5, 5, 5, 5, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 0, 0, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		0, 0, 3, 3, 3, 3, 1, 1, 3, 3,
		3, 3, 3, 2, 3, 2, 3, 3, 3, 3,
		0, 0, 3, 3, 2, 5, 5, 3, 1, 3,
		3, 3, 0, 4, 4, 4, 4, 0, 4, 4,
		4, 4, 4, 4, 0, 0, 0, 3, 3, 3,
		0, 0, 4, 4, 4, 4, 4, 4, 4, 4,
		4, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 6, 6, 4, 4, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 4, 4, 3, 3,
		3, 0, 3, 3, 3, 3, 3, 3, 3, 6,
		6, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 6, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 0, 3, 3, 1, 1, 2, 5,
		5, 2, 2, 0, 0, 0, 3, 3, 3, 0,
		0, 0, 4, 4, 4, 4, 4, 4, 4, 4,
		4, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 0, 3, 3, 3, 5, 5, 6, 3,
		6, 6, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 1, 2, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 0, 0, 3,
		3, 3, 3, 0, 0, 4, 4, 4, 4, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 4,
		6, 3, 3, 3, 0, 0, 0, 0, 0, 0,
		2, 1, 0, 0, 0, 0, 0, 4, 4, 4,
		4, 4, 4, 4, 4, 4, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 4, 4,
		4, 4, 3, 2, 1, 4, 2, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 6, 6, 3, 3, 3, 0, 0, 3, 3,
		2, 3, 3, 3, 3, 3, 4, 4, 4, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 0, 3, 3, 3, 5, 5, 4, 3,
		4, 4, 3, 3, 0, 1, 3, 3, 2, 0,
		0, 0, 0, 0, 0, 3, 0, 0, 2, 0,
		0, 0, 0, 0, 0, 4, 4, 4, 4, 4,
		4, 4, 4, 4, 3, 3, 3, 3, 3, 3,
		3, 4, 4, 4, 4, 4, 4, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 5, 5, 5, 3, 3, 3, 1, 1,
		3, 3, 3, 3, 3, 3, 3, 3, 2, 2,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 4, 4, 4, 4, 3, 3,
		4, 4, 6, 6, 6, 6, 6, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 0,
		0, 0, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 0, 3, 3, 3, 3,
		3, 3, 0, 0, 3, 3, 3, 1, 1, 2,
		2, 3, 3, 3, 3, 3, 3, 3, 0, 0,
		0, 1, 1, 0, 0, 1, 0, 0, 0, 0
	};

	public static List<string> species = new List<string>();

	public static List<string> abilities = new List<string>();

	public static List<string> natures = new List<string>();

	public static List<string> items = new List<string>();

	public static List<string> locations = new List<string>();

	public static List<string> moves = new List<string>();

	public static List<string> versions = new List<string>();

	public static List<string> languages = new List<string>();

	public static List<ushort> locationValues = new List<ushort>
	{
		0, 0, 4, 5, 6, 7, 8, 9, 10, 11,
		12, 13, 14, 15, 16, 17, 18, 19, 20, 21,
		22, 23, 24, 25, 26, 27, 28, 29, 30, 31,
		32, 33, 34, 35, 36, 37, 38, 39, 40, 41,
		42, 43, 44, 45, 46, 47, 48, 49, 50, 51,
		52, 53, 54, 55, 56, 57, 58, 59, 60, 61,
		62, 63, 64, 65, 66, 67, 68, 69, 70, 71,
		72, 73, 74, 75, 76, 77, 78, 79, 80, 81,
		82, 83, 84, 85, 86, 87, 88, 89, 90, 91,
		92, 93, 94, 95, 96, 97, 98, 99, 100, 101,
		102, 103, 104, 105, 106, 107, 108, 109, 110, 111,
		112, 113, 114, 115, 116, 117, 118, 119, 120, 121,
		122, 123, 124, 125, 126, 127, 128, 129, 130, 131,
		132, 133, 134, 135, 136, 137, 139, 140, 141, 142,
		143, 144, 145, 146, 147, 148, 149, 150, 151, 152,
		153, 2000, 2002, 2009, 2010, 3000, 3001, 3002, 30001, 30002,
		30003, 30004, 30005, 30006, 30007, 30008, 30010, 30011, 30012, 30013,
		30014, 30015, 40001, 40002, 40003, 40004, 40005, 40006, 40007, 40008,
		40009, 40010, 40011, 40012, 40013, 40014, 40015, 40016, 40017, 40018,
		40019, 40021, 40020, 40022, 40023, 40024, 40025, 40026, 40027, 40028,
		40029, 40030, 40031, 40032, 40033, 40034, 40035, 40036, 40037, 40038,
		40039, 40040, 40041, 40042, 40043, 40044, 40045, 40046, 40047, 40048,
		40049, 40050, 40051, 40052, 40053, 40054, 40055, 40056, 40057, 40058,
		40059, 40060, 40061, 40062, 40063, 40064, 40065, 40066, 40067, 40068,
		40069, 40070, 40071, 40072, 40073, 40074, 40075, 40076, 40077, 40078,
		40079, 40080, 40081, 40082, 40083, 40084, 40085, 40086, 40087, 40088,
		40089, 40090, 40091, 40092, 40093, 40094, 40095, 40096, 40097, 40098,
		40099, 40100, 40101, 40102, 40103, 40104, 40105, 40106, 40107, 40108,
		40109, 60001, 60002, 60003
	};

	public static List<string> pokeballs = new List<string>
	{
		"", "Master Ball", "Ultra Ball", "Great Ball", "Poké Ball", "Safari Ball", "Net Ball", "Dive Ball", "Nest Ball", "Repeat Ball",
		"Timer Ball", "Luxury Ball", "Premier Ball", "Dusk Ball", "Heal Ball", "Quick Ball", "Cherish Ball", "Fast Ball", "Level Ball", "Lure Ball",
		"Heavy Ball", "Love Ball", "Friend Ball", "Moon Ball", "Sport Ball", "Dream Ball"
	};

	public static byte[] resetpkm = new byte[220]
	{
		0, 0, 0, 0, 0, 0, 43, 141, 1, 0,
		0, 0, 1, 0, 0, 0, 0, 0, 0, 0,
		0, 65, 0, 2, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		213, 0, 0, 0, 0, 0, 0, 0, 15, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 2, 3, 0, 0, 0, 0,
		0, 0, 66, 0, 117, 0, 108, 0, 98, 0,
		97, 0, 115, 0, 97, 0, 117, 0, 114, 0,
		255, 255, 255, 255, 0, 23, 0, 0, 0, 0,
		0, 0, 0, 0, 80, 0, 105, 0, 107, 0,
		97, 0, 69, 0, 100, 0, 116, 0, 255, 255,
		0, 0, 0, 13, 2, 24, 0, 0, 0, 0,
		0, 4, 1, 0, 0, 0, 0, 0, 0, 0,
		1, 0, 11, 0, 11, 0, 6, 0, 5, 0,
		6, 0, 5, 0, 6, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0
	};

	public static List<string> passPowers = new List<string>
	{
		"None", "Encounter Power ↑", "Encounter Power ↑↑", "Encounter Power ↑↑↑", "Encounter Power ↓", "Encounter Power ↓↓", "Encounter Power ↓↓↓", "Hatching Power ↑", "Hatching Power ↑↑", "Hatching Power ↑↑↑",
		"Befriending Power ↑", "Befriending Power ↑↑", "Befriending Power ↑↑↑", "Bargain Power ↑", "Bargain Power ↑↑", "Bargain Power ↑↑↑", "HP Restoring Power ↑", "HP Restoring Power ↑↑", "HP Restoring Power ↑↑↑", "PP Restoring Power ↑",
		"PP Restoring Power ↑↑", "PP Restoring Power ↑↑↑", "Exp. Point Power ↑", "Exp. Point Power ↑↑", "Exp. Point Power ↑↑↑", "Exp. Point Power ↓", "Exp. Point Power ↓↓", "Exp. Point Power ↓↓↓", "Prize Money Power ↑", "Prize Money Power ↑↑",
		"Prize Money Power ↑↑↑", "Capture Power ↑", "Capture Power ↑↑", "Capture Power ↑↑↑", "Hatching Power S", "Bargain Power S", "Befriending Power S", "Exp. Point Power S", "Prize Money Power S", "Capture Power S",
		"Full Recovery Power", "Hatching Power MAX", "Bargain Power MAX", "Befriending Power MAX", "Exp. Point Power MAX", "Prize Money Power MAX", "Capture Power MAX", "None", "None", "None",
		"Search Power +", "Search Power ++", "Search Power +++", "Hidden Grotto Power +", "Hidden Grotto Power ++", "Hidden Grotto Power +++", "Charm Power +", "Charm Power ++", "Charm Power +++", "Exploring Power S",
		"Exploring Power MAX", "Grotto Power S", "Grotto Power MAX", "Lucky Power S", "Lucky Power MAX"
	};

	public static List<byte> pp = new List<byte>
	{
		0, 35, 25, 10, 15, 20, 20, 15, 15, 15,
		35, 30, 5, 10, 20, 30, 35, 35, 20, 15,
		20, 20, 25, 20, 30, 5, 10, 15, 15, 15,
		25, 20, 5, 35, 15, 20, 20, 10, 15, 30,
		35, 20, 20, 30, 25, 40, 20, 15, 20, 20,
		20, 30, 25, 15, 30, 25, 5, 15, 10, 5,
		20, 20, 20, 5, 35, 20, 25, 20, 20, 20,
		15, 25, 15, 10, 40, 25, 10, 35, 30, 15,
		10, 40, 10, 15, 30, 15, 20, 10, 15, 10,
		5, 10, 10, 25, 10, 20, 40, 30, 30, 20,
		20, 15, 10, 40, 15, 10, 30, 10, 20, 10,
		40, 40, 20, 30, 30, 20, 30, 10, 10, 20,
		5, 10, 30, 20, 20, 20, 5, 15, 15, 20,
		10, 15, 35, 20, 15, 10, 10, 30, 15, 40,
		20, 15, 10, 5, 10, 30, 10, 15, 20, 15,
		40, 20, 10, 5, 15, 10, 10, 10, 15, 30,
		30, 10, 10, 20, 10, 0, 1, 10, 10, 10,
		5, 15, 25, 15, 10, 15, 30, 5, 40, 15,
		10, 25, 10, 30, 10, 20, 10, 10, 10, 10,
		10, 20, 5, 40, 5, 5, 15, 5, 10, 5,
		10, 10, 10, 10, 20, 20, 40, 15, 10, 20,
		20, 25, 5, 15, 10, 5, 20, 15, 20, 25,
		20, 5, 30, 5, 10, 20, 40, 5, 20, 40,
		20, 15, 35, 10, 5, 5, 5, 15, 5, 20,
		5, 5, 15, 20, 10, 5, 5, 15, 10, 15,
		15, 10, 10, 10, 20, 10, 10, 10, 10, 15,
		15, 15, 10, 20, 20, 10, 20, 20, 20, 20,
		20, 10, 10, 10, 20, 20, 5, 15, 10, 10,
		15, 10, 20, 5, 5, 10, 10, 20, 5, 10,
		20, 10, 20, 20, 20, 5, 5, 15, 20, 10,
		15, 20, 15, 10, 10, 15, 10, 5, 5, 10,
		15, 10, 5, 20, 25, 5, 40, 15, 5, 40,
		15, 20, 20, 5, 15, 20, 20, 15, 15, 5,
		10, 30, 20, 30, 15, 5, 40, 15, 5, 20,
		5, 15, 25, 40, 15, 20, 15, 20, 15, 20,
		10, 20, 20, 5, 5, 10, 5, 40, 10, 10,
		5, 10, 10, 15, 10, 20, 30, 30, 10, 20,
		5, 10, 10, 15, 10, 10, 5, 15, 5, 10,
		10, 30, 20, 20, 10, 10, 5, 5, 10, 5,
		20, 10, 20, 10, 15, 10, 20, 20, 20, 15,
		15, 10, 15, 20, 15, 10, 10, 10, 20, 10,
		30, 5, 10, 15, 10, 10, 5, 20, 30, 10,
		30, 15, 15, 15, 15, 30, 10, 20, 15, 10,
		10, 20, 15, 5, 5, 15, 15, 5, 10, 5,
		20, 5, 15, 20, 5, 20, 20, 20, 20, 10,
		20, 10, 15, 20, 15, 10, 10, 5, 10, 5,
		5, 10, 5, 5, 10, 5, 5, 5, 15, 10,
		10, 10, 10, 10, 10, 15, 20, 15, 10, 15,
		10, 15, 10, 20, 10, 15, 10, 20, 20, 20,
		20, 20, 15, 15, 15, 15, 15, 15, 20, 15,
		10, 15, 15, 15, 15, 10, 10, 10, 10, 10,
		15, 15, 15, 15, 5, 5, 15, 5, 10, 10,
		10, 20, 20, 20, 10, 10, 30, 15, 15, 10,
		15, 25, 10, 20, 10, 10, 10, 20, 10, 10,
		10, 10, 10, 15, 15, 5, 5, 10, 10, 10,
		5, 5, 10, 5, 5, 15, 10, 5, 5, 5,
		10, 15, 10, 10, 20, 25, 10, 20, 30, 25,
		20, 20, 15, 15, 15, 20, 10, 20, 10, 25,
		10, 10, 20, 10, 30, 15, 10, 10, 10, 20,
		20, 5, 5, 5, 20, 10, 20, 20, 15, 20,
		20, 10, 20, 30, 10, 10, 40, 40, 30, 20,
		40, 35, 30, 10, 10, 10, 10, 5, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0
	};

	public static byte[] cgearfooter = new byte[16]
	{
		0, 0, 1, 0, 0, 0, 20, 39, 0, 0,
		39, 53, 5, 49, 0, 0
	};

	public static byte[] pokedexfooter = new byte[16]
	{
		0, 0, 1, 0, 0, 0, 20, 99, 0, 0,
		39, 53, 5, 49, 0, 0
	};

	public static byte[] musicalbw2footer = new byte[16]
	{
		0, 0, 3, 0, 0, 0, 20, 125, 1, 0,
		39, 53, 5, 49, 0, 0
	};

	public static byte[] musicalbwfooter = new byte[16]
	{
		0, 0, 4, 0, 0, 0, 20, 253, 1, 0,
		39, 53, 5, 49, 0, 0
	};

	public static byte[] battlevideofooter = new byte[16]
	{
		0, 0, 1, 0, 0, 0, 20, 25, 0, 0,
		39, 53, 5, 49, 0, 0
	};

	public static List<string> lspecies = new List<string>();

	public static List<string> labilities = new List<string>();

	public static List<string> lnatures = new List<string>();

	public static List<string> litems = new List<string>();

	public static List<string> llocations = new List<string>();

	public static List<string> lmoves = new List<string>();

	public static List<string> lversions = new List<string>();

	public static List<string> llanguages = new List<string>();

	public static List<string> lbadges = new List<string>();

	public static byte lang = 0;

	public static bool dictionariesInitialized = false;

	public static Dictionary<int, byte[]> baseStats = new Dictionary<int, byte[]>();

	public static ushort[] slow = new ushort[147]
	{
		58, 59, 72, 73, 90, 91, 102, 103, 111, 112,
		120, 121, 127, 128, 129, 130, 131, 142, 143, 144,
		145, 146, 147, 148, 149, 150, 170, 171, 214, 220,
		221, 226, 227, 228, 229, 234, 241, 243, 244, 245,
		246, 247, 248, 249, 250, 280, 281, 282, 287, 288,
		289, 304, 305, 306, 309, 310, 318, 319, 357, 369,
		371, 372, 373, 374, 375, 376, 377, 378, 379, 380,
		381, 382, 383, 384, 385, 386, 443, 444, 445, 446,
		449, 450, 451, 452, 455, 458, 459, 460, 464, 473,
		475, 480, 481, 482, 483, 484, 485, 486, 487, 488,
		489, 490, 491, 493, 494, 582, 583, 584, 602, 603,
		604, 610, 611, 612, 627, 628, 629, 630, 633, 634,
		635, 636, 637, 638, 639, 640, 641, 642, 643, 644,
		645, 646, 647, 648, 649, 692, 693, 703, 704, 705,
		706, 716, 717, 718, 719, 720, 721
	};

	public static ushort[] mediumSlow = new ushort[189]
	{
		1, 2, 3, 4, 5, 6, 7, 8, 9, 16,
		17, 18, 29, 30, 31, 32, 33, 34, 43, 44,
		45, 60, 61, 62, 63, 64, 65, 66, 67, 68,
		69, 70, 71, 74, 75, 76, 92, 93, 94, 151,
		152, 153, 154, 155, 156, 157, 158, 159, 160, 179,
		180, 181, 182, 186, 187, 188, 189, 191, 192, 198,
		207, 213, 215, 251, 252, 253, 254, 255, 256, 257,
		258, 259, 260, 270, 271, 272, 273, 274, 275, 276,
		277, 293, 294, 295, 302, 315, 328, 329, 330, 331,
		332, 352, 359, 363, 364, 365, 387, 388, 389, 390,
		391, 392, 393, 394, 395, 396, 397, 398, 401, 402,
		403, 404, 405, 406, 407, 415, 416, 430, 441, 447,
		448, 461, 472, 492, 495, 496, 497, 498, 499, 500,
		501, 502, 503, 506, 507, 508, 519, 520, 521, 524,
		525, 526, 532, 533, 534, 535, 536, 537, 540, 541,
		542, 543, 544, 545, 551, 552, 553, 554, 555, 570,
		571, 574, 575, 576, 577, 578, 579, 599, 600, 601,
		607, 608, 609, 619, 620, 650, 651, 652, 653, 654,
		655, 656, 657, 658, 661, 662, 663, 667, 668
	};

	public static ushort[] mediumFast = new ushort[296]
	{
		10, 11, 12, 13, 14, 15, 19, 20, 21, 22,
		23, 24, 25, 26, 27, 28, 37, 38, 41, 42,
		46, 47, 48, 49, 50, 51, 52, 53, 54, 55,
		56, 57, 77, 78, 79, 80, 81, 82, 83, 84,
		85, 86, 87, 88, 89, 95, 96, 97, 98, 99,
		100, 101, 104, 105, 106, 107, 108, 109, 110, 114,
		115, 116, 117, 118, 119, 122, 123, 124, 125, 126,
		132, 133, 134, 135, 136, 137, 138, 139, 140, 141,
		161, 162, 163, 164, 169, 172, 177, 178, 185, 193,
		194, 195, 196, 197, 199, 201, 202, 203, 204, 205,
		206, 208, 211, 212, 216, 217, 218, 219, 223, 224,
		230, 231, 232, 233, 236, 237, 238, 239, 240, 261,
		262, 263, 264, 265, 266, 267, 268, 269, 278, 279,
		283, 284, 299, 307, 308, 311, 312, 322, 323, 324,
		339, 340, 343, 344, 351, 360, 361, 362, 399, 400,
		412, 413, 414, 417, 418, 419, 420, 421, 422, 423,
		427, 428, 434, 435, 436, 437, 438, 439, 442, 453,
		454, 462, 463, 465, 466, 467, 469, 470, 471, 474,
		476, 478, 479, 504, 505, 509, 510, 511, 512, 513,
		514, 515, 516, 522, 523, 527, 528, 529, 530, 538,
		539, 546, 547, 548, 549, 550, 556, 557, 558, 559,
		560, 561, 562, 563, 564, 565, 566, 567, 568, 569,
		580, 581, 585, 586, 587, 588, 589, 590, 591, 592,
		593, 595, 596, 597, 598, 605, 606, 613, 614, 615,
		616, 617, 618, 621, 622, 623, 624, 625, 626, 631,
		632, 659, 660, 664, 665, 666, 669, 670, 671, 672,
		673, 674, 675, 676, 677, 678, 679, 680, 681, 682,
		683, 684, 685, 686, 687, 688, 689, 690, 691, 694,
		695, 696, 697, 698, 699, 700, 701, 702, 708, 709,
		710, 711, 712, 713, 714, 715
	};

	public static ushort[] fast = new ushort[53]
	{
		35, 36, 39, 40, 113, 165, 166, 167, 168, 173,
		174, 175, 176, 183, 184, 190, 200, 209, 210, 222,
		225, 235, 242, 298, 300, 301, 303, 325, 326, 327,
		337, 338, 353, 354, 355, 356, 358, 370, 424, 429,
		431, 432, 433, 440, 468, 477, 517, 518, 531, 572,
		573, 594, 707
	};

	public static ushort[] fluctuating = new ushort[14]
	{
		285, 286, 296, 297, 314, 316, 317, 320, 321, 336,
		341, 342, 425, 426
	};

	public static ushort[] erratic = new ushort[22]
	{
		290, 291, 292, 313, 333, 334, 335, 345, 346, 347,
		348, 349, 350, 366, 367, 368, 408, 409, 410, 411,
		456, 457
	};

	public static uint[] slowlist = new uint[100]
	{
		0u, 10u, 33u, 80u, 156u, 270u, 428u, 640u, 911u, 1250u,
		1663u, 2160u, 2746u, 3430u, 4218u, 5120u, 6141u, 7290u, 8573u, 10000u,
		11576u, 13310u, 15208u, 17280u, 19531u, 21970u, 24603u, 27440u, 30486u, 33750u,
		37238u, 40960u, 44921u, 49130u, 53593u, 58320u, 63316u, 68590u, 74148u, 80000u,
		86151u, 92610u, 99383u, 106480u, 113906u, 121670u, 129778u, 138240u, 147061u, 156250u,
		165813u, 175760u, 186096u, 196830u, 207968u, 219520u, 231491u, 243890u, 256723u, 270000u,
		283726u, 297910u, 312558u, 327680u, 343281u, 359370u, 375953u, 393040u, 410636u, 428750u,
		447388u, 466560u, 486271u, 506530u, 527343u, 548720u, 570666u, 593190u, 616298u, 640000u,
		664301u, 689210u, 714733u, 740880u, 767656u, 795070u, 823128u, 851840u, 881211u, 911250u,
		941963u, 973360u, 1005446u, 1038230u, 1071718u, 1105920u, 1140841u, 1176490u, 1212873u, 1250000u
	};

	public static uint[] mediumSlowList = new uint[100]
	{
		0u, 9u, 57u, 96u, 135u, 179u, 236u, 314u, 419u, 560u,
		742u, 973u, 1261u, 1612u, 2035u, 2535u, 3120u, 3798u, 4575u, 5460u,
		6458u, 7577u, 8825u, 10208u, 11735u, 13411u, 15244u, 17242u, 19411u, 21760u,
		24294u, 27021u, 29949u, 33084u, 36435u, 40007u, 43808u, 47846u, 52127u, 56660u,
		61450u, 66505u, 71833u, 77440u, 83335u, 89523u, 96012u, 102810u, 109923u, 117360u,
		125126u, 133229u, 141677u, 150476u, 159635u, 169159u, 179056u, 189334u, 199999u, 211060u,
		222522u, 234393u, 246681u, 259392u, 272535u, 286115u, 300140u, 314618u, 329555u, 344960u,
		360838u, 377197u, 394045u, 411388u, 429235u, 447591u, 466464u, 485862u, 505791u, 526260u,
		547274u, 568841u, 590969u, 613664u, 636935u, 660787u, 685228u, 710266u, 735907u, 762160u,
		789030u, 816525u, 844653u, 873420u, 902835u, 932903u, 963632u, 995030u, 1027103u, 1059860u
	};

	public static uint[] mediumFastList = new uint[100]
	{
		0u, 8u, 27u, 64u, 125u, 216u, 343u, 512u, 729u, 1000u,
		1331u, 1728u, 2197u, 2744u, 3375u, 4096u, 4913u, 5832u, 6859u, 8000u,
		9261u, 10648u, 12167u, 13824u, 15625u, 17576u, 19683u, 21952u, 24389u, 27000u,
		29791u, 32768u, 35937u, 39304u, 42875u, 46656u, 50653u, 54872u, 59319u, 64000u,
		68921u, 74088u, 79507u, 85184u, 91125u, 97336u, 103823u, 110592u, 117649u, 125000u,
		132651u, 140608u, 148877u, 157464u, 166375u, 175616u, 185193u, 195112u, 205379u, 216000u,
		226981u, 238328u, 250047u, 262144u, 274625u, 287496u, 300763u, 314432u, 328509u, 343000u,
		357911u, 373248u, 389017u, 405224u, 421875u, 438976u, 456533u, 474552u, 493039u, 512000u,
		531441u, 551368u, 571787u, 592704u, 614125u, 636056u, 658503u, 681472u, 704969u, 729000u,
		753571u, 778688u, 804357u, 830584u, 857375u, 884736u, 912673u, 941192u, 970299u, 1000000u
	};

	public static uint[] fastlist = new uint[100]
	{
		0u, 6u, 21u, 51u, 100u, 172u, 274u, 409u, 583u, 800u,
		1064u, 1382u, 1757u, 2195u, 2700u, 3276u, 3930u, 4665u, 5487u, 6400u,
		7408u, 8518u, 9733u, 11059u, 12500u, 14060u, 15746u, 17561u, 19511u, 21600u,
		23832u, 26214u, 28749u, 31443u, 34300u, 37324u, 40522u, 43897u, 47455u, 51200u,
		55136u, 59270u, 63605u, 68147u, 72900u, 77868u, 83058u, 88473u, 94119u, 100000u,
		106120u, 112486u, 119101u, 125971u, 133100u, 140492u, 148154u, 156089u, 164303u, 172800u,
		181584u, 190662u, 200037u, 209715u, 219700u, 229996u, 240610u, 251545u, 262807u, 274400u,
		286328u, 298598u, 311213u, 324179u, 337500u, 351180u, 365226u, 379641u, 394431u, 409600u,
		425152u, 441094u, 457429u, 474163u, 491300u, 508844u, 526802u, 545177u, 563975u, 583200u,
		602856u, 622950u, 643485u, 664467u, 685900u, 707788u, 730138u, 752953u, 776239u, 800000u
	};

	public static uint[] fluctuatinglist = new uint[100]
	{
		0u, 4u, 13u, 32u, 65u, 112u, 178u, 276u, 393u, 540u,
		745u, 967u, 1230u, 1591u, 1957u, 2457u, 3046u, 3732u, 4526u, 5440u,
		6482u, 7666u, 9003u, 10506u, 12187u, 14060u, 16140u, 18439u, 20974u, 23760u,
		26811u, 30146u, 33780u, 37731u, 42017u, 46656u, 50653u, 55969u, 60505u, 66560u,
		71677u, 78533u, 84277u, 91998u, 98415u, 107069u, 114205u, 123863u, 131766u, 142500u,
		151222u, 163105u, 172697u, 185807u, 196322u, 210739u, 222231u, 238036u, 250562u, 267840u,
		281456u, 300293u, 315059u, 335544u, 351520u, 373744u, 390991u, 415050u, 433631u, 459620u,
		479600u, 507617u, 529063u, 559209u, 582187u, 614566u, 639146u, 673863u, 700115u, 737280u,
		765275u, 804997u, 834809u, 877201u, 908905u, 954084u, 987754u, 1035837u, 1071552u, 1122660u,
		1160499u, 1214753u, 1254796u, 1312322u, 1354652u, 1415577u, 1460276u, 1524731u, 1571884u, 1640000u
	};

	public static uint[] erraticlist = new uint[100]
	{
		0u, 15u, 52u, 122u, 237u, 406u, 637u, 942u, 1326u, 1800u,
		2369u, 3041u, 3822u, 4719u, 5737u, 6881u, 8155u, 9564u, 11111u, 12800u,
		14632u, 16610u, 18737u, 21012u, 23437u, 26012u, 28737u, 31610u, 34632u, 37800u,
		41111u, 44564u, 48155u, 51881u, 55737u, 59719u, 63822u, 68041u, 72369u, 76800u,
		81326u, 85942u, 90637u, 95406u, 100237u, 105122u, 110052u, 115015u, 120001u, 125000u,
		131324u, 137795u, 144410u, 151165u, 158056u, 165079u, 172229u, 179503u, 186894u, 194400u,
		202013u, 209728u, 217540u, 225443u, 233431u, 241496u, 249633u, 257834u, 267406u, 276458u,
		286328u, 296358u, 305767u, 316074u, 326531u, 336255u, 346965u, 357812u, 367807u, 378880u,
		390077u, 400293u, 411686u, 423190u, 433572u, 445239u, 457001u, 467489u, 479378u, 491346u,
		501878u, 513934u, 526049u, 536557u, 548720u, 560922u, 571333u, 583539u, 591882u, 600000u
	};

	public static byte[] expList = new byte[722]
	{
		0, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		2, 2, 2, 2, 2, 2, 1, 1, 1, 2,
		2, 2, 2, 2, 2, 2, 2, 2, 2, 1,
		1, 1, 1, 1, 1, 3, 3, 2, 2, 3,
		3, 2, 2, 1, 1, 1, 2, 2, 2, 2,
		2, 2, 2, 2, 2, 2, 2, 2, 0, 0,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 0, 0, 1, 1, 1, 2, 2, 2,
		2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
		0, 0, 1, 1, 1, 2, 2, 2, 2, 2,
		2, 2, 0, 0, 2, 2, 2, 2, 2, 2,
		2, 0, 0, 3, 2, 2, 2, 2, 2, 2,
		0, 0, 2, 2, 2, 2, 2, 0, 0, 0,
		0, 0, 2, 2, 2, 2, 2, 2, 2, 2,
		2, 2, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 2, 2, 2, 2, 3, 3, 3, 3, 2,
		0, 0, 2, 3, 3, 3, 3, 2, 2, 1,
		1, 1, 1, 3, 3, 2, 1, 1, 1, 1,
		3, 1, 1, 2, 2, 2, 2, 2, 1, 2,
		3, 2, 2, 2, 2, 2, 2, 1, 2, 3,
		3, 2, 2, 1, 0, 1, 2, 2, 2, 2,
		0, 0, 3, 2, 2, 3, 0, 0, 0, 0,
		2, 2, 2, 2, 0, 3, 2, 2, 2, 2,
		2, 0, 3, 0, 0, 0, 0, 0, 0, 0,
		0, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 2, 2, 2, 2, 2, 2, 2, 2, 2,
		1, 1, 1, 1, 1, 1, 1, 1, 2, 2,
		0, 0, 0, 2, 2, 4, 4, 0, 0, 0,
		5, 5, 5, 1, 1, 1, 4, 4, 3, 2,
		3, 3, 1, 3, 0, 0, 0, 2, 2, 0,
		0, 2, 2, 5, 4, 1, 4, 4, 0, 0,
		4, 4, 2, 2, 2, 3, 3, 3, 1, 1,
		1, 1, 1, 5, 5, 5, 4, 3, 3, 2,
		2, 4, 4, 2, 2, 5, 5, 5, 5, 5,
		5, 2, 1, 3, 3, 3, 3, 0, 3, 1,
		2, 2, 2, 1, 1, 1, 5, 5, 5, 0,
		3, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 2,
		2, 1, 1, 1, 1, 1, 1, 1, 5, 5,
		5, 5, 2, 2, 2, 1, 1, 2, 2, 2,
		2, 2, 2, 2, 3, 4, 4, 2, 2, 3,
		1, 3, 3, 3, 2, 2, 2, 2, 2, 2,
		3, 1, 2, 0, 0, 0, 0, 1, 1, 0,
		0, 0, 0, 2, 2, 0, 5, 5, 0, 0,
		0, 1, 2, 2, 0, 2, 2, 2, 3, 2,
		2, 2, 1, 0, 2, 0, 2, 3, 2, 2,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 1, 0, 0, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 2, 2, 1, 1, 1, 2,
		2, 2, 2, 2, 2, 2, 2, 3, 3, 1,
		1, 1, 2, 2, 1, 1, 1, 2, 2, 2,
		2, 3, 1, 1, 1, 1, 1, 1, 2, 2,
		1, 1, 1, 1, 1, 1, 2, 2, 2, 2,
		2, 1, 1, 1, 1, 1, 2, 2, 2, 2,
		2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
		1, 1, 3, 3, 1, 1, 1, 1, 1, 1,
		2, 2, 0, 0, 0, 2, 2, 2, 2, 2,
		2, 2, 2, 2, 3, 2, 2, 2, 2, 1,
		1, 1, 0, 0, 0, 2, 2, 1, 1, 1,
		0, 0, 0, 2, 2, 2, 2, 2, 2, 1,
		1, 2, 2, 2, 2, 2, 2, 0, 0, 0,
		0, 2, 2, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 2,
		2, 1, 1, 1, 2, 2, 2, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 0, 0, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 0, 0, 0, 0, 3, 1, 1,
		1, 1, 1, 1, 1, 1, 0, 0, 0, 0,
		0, 0
	};



	public static void clearLists()
	{
		lspecies.Clear();
		lmoves.Clear();
		labilities.Clear();
		lnatures.Clear();
		litems.Clear();
		llocations.Clear();
		lversions.Clear();
		llanguages.Clear();
	}

	

	

	

	public static string speciesTranslate(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = lspecies.IndexOf(s);
		if (num != -1)
		{
			return species[num];
		}
		return s;
	}

	public static string abilityTranslate(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = labilities.IndexOf(s);
		if (num != -1)
		{
			return abilities[num];
		}
		return s;
	}

	public static string itemTranslate(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = litems.IndexOf(s);
		if (num != -1)
		{
			return items[num];
		}
		return s;
	}

	public static string locationTranslate(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = llocations.IndexOf(s);
		if (num != -1)
		{
			return locations[num];
		}
		return s;
	}

	public static string natureTranslate(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = lnatures.IndexOf(s);
		if (num != -1)
		{
			return natures[num];
		}
		return s;
	}

	public static string moveTranslate(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = lmoves.IndexOf(s);
		if (num != -1)
		{
			return moves[num];
		}
		return s;
	}

	public static string languageTranslate(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = llanguages.IndexOf(s);
		if (num != -1)
		{
			return languages[num];
		}
		return s;
	}

	public static string versionTranslate(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = lversions.IndexOf(s);
		if (num != -1)
		{
			return versions[num];
		}
		return s;
	}

	public static string speciesTranslateTo(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = species.IndexOf(s);
		if (num != -1)
		{
			return lspecies[num];
		}
		return s;
	}

	public static string abilityTranslateTo(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = abilities.IndexOf(s);
		if (num != -1)
		{
			return labilities[num];
		}
		return s;
	}

	public static string itemTranslateTo(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = items.IndexOf(s);
		if (num != -1)
		{
			return litems[num];
		}
		return s;
	}

	public static string locationTranslateTo(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = locations.IndexOf(s);
		if (num != -1)
		{
			return llocations[num];
		}
		return s;
	}

	public static string natureTranslateTo(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = natures.IndexOf(s);
		if (num != -1)
		{
			return lnatures[num];
		}
		return s;
	}

	public static string moveTranslateTo(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = moves.IndexOf(s);
		if (num != -1)
		{
			return lmoves[num];
		}
		return s;
	}

	public static string versionTranslateTo(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = versions.IndexOf(s);
		if (num != -1)
		{
			return lversions[num];
		}
		return s;
	}

	public static string languageTranslateTo(string s)
	{
		if (lang == 0)
		{
			return s;
		}
		int num = languages.IndexOf(s);
		if (num != -1)
		{
			return llanguages[num];
		}
		return s;
	}

	public static string[] getFormList(string species)
	{
		string[] result = new string[1] { "None" };
		if (species == "Unown")
		{
			result = new string[28]
			{
				"A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
				"K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
				"U", "V", "W", "X", "Y", "Z", "?", "!"
			};
		}
		if (species == "Deoxys")
		{
			result = new string[4] { "Normal", "Attack", "Defense", "Speed" };
		}
		if (species == "Burmy")
		{
			result = new string[3] { "Plant", "Sandy", "Thrash" };
		}
		if (species == "Wormadam")
		{
			result = new string[3] { "Plant", "Sandy", "Thrash" };
		}
		if (species == "Shellos")
		{
			result = new string[2] { "West", "East" };
		}
		if (species == "Gastrodon")
		{
			result = new string[2] { "West", "East" };
		}
		if (species == "Rotom")
		{
			result = new string[6] { "Normal", "Heat", "Wash", "Frost", "Fan", "Mow" };
		}
		if (species == "Giratina")
		{
			result = new string[2] { "Altered", "Origin" };
		}
		if (species == "Shaymin")
		{
			result = new string[2] { "Land", "Sky" };
		}
		if (species == "Arceus")
		{
			result = new string[17]
			{
				"Normal", "Fighting", "Flying", "Poison", "Ground", "Rock", "Bug", "Ghost", "Steel", "Fire",
				"Water", "Grass", "Electric", "Psychic", "Ice", "Dragon", "Dark"
			};
		}
		if (species == "Basculin")
		{
			result = new string[2] { "Red Striped", "Blue Striped" };
		}
		if (species == "Deerling")
		{
			result = new string[4] { "Spring", "Summer", "Autumn", "Winter" };
		}
		if (species == "Sawsbuck")
		{
			result = new string[4] { "Spring", "Summer", "Autumn", "Winter" };
		}
		if (species == "Tornadus")
		{
			result = new string[2] { "Incarnate", "Therian" };
		}
		if (species == "Thundurus")
		{
			result = new string[2] { "Incarnate", "Therian" };
		}
		if (species == "Landorus")
		{
			result = new string[2] { "Incarnate", "Therian" };
		}
		if (species == "Kyurem")
		{
			result = new string[3] { "Normal", "White", "Black" };
		}
		if (species == "Keldeo")
		{
			result = new string[2] { "Ordinary", "Resolute" };
		}
		if (species == "Meloetta")
		{
			result = new string[2] { "Aria", "Pirouette" };
		}
		if (species == "Genesect")
		{
			result = new string[5] { "Normal", "Douse", "Shock", "Burn", "Chill" };
		}
		if ((species == "Vivillon") | (species == "Scatterbug") | (species == "Spewpa"))
		{
			result = new string[18]
			{
				"Icy-snow", "Polar", "Tundra", "Continental", "Garden", "Elegant", "Meadow", "Modern", "Marine", "Archipelago",
				"High-plains", "Sandstorm", "River", "Monsoon", "Savanna", "Sun", "Ocean", "Jungle"
			};
		}
		if ((species == "Flabébé") | (species == "Floette") | (species == "Florges"))
		{
			result = new string[5] { "Red", "Yellow", "Orange", "Blue", "White" };
		}
		if (species == "Furfrou")
		{
			result = new string[10] { "Natural", "Heart", "Star", "Diamond", "Deputante", "Matron", "Dandy", "La-reine", "Kabuki", "Pharoah" };
		}
		if (species == "Meowstic")
		{
			result = new string[2] { "Male", "Female" };
		}
		if (species == "Aegislash")
		{
			result = new string[2] { "Shield", "Blade" };
		}
		if ((species == "Pumpkaboo") | (species == "Gourgeist"))
		{
			result = new string[4] { "Average", "Small", "Large", "Super" };
		}
		if ((species == "Venusaur") | (species == "Blastoise") | (species == "Alakazam") | (species == "Gengar") | (species == "Kangaskhan") | (species == "Pinsir") | (species == "Gyarados") | (species == "Aerodactyl") | (species == "Ampharos") | (species == "Scizor") | (species == "Heracross") | (species == "Houndoom") | (species == "Tyranitar") | (species == "Blaziken") | (species == "Gardevoir") | (species == "Mawile") | (species == "Aggron") | (species == "Medicham") | (species == "Manectric") | (species == "Banette") | (species == "Absol") | (species == "Garchomp") | (species == "Lucario") | (species == "Abomasnow"))
		{
			result = new string[2] { "Normal", "Mega" };
		}
		if ((species == "Charizard") | (species == "Mewtwo"))
		{
			result = new string[3] { "Normal", "Mega X", "Mega Y" };
		}
		return result;
	}

	public static string getFormFromValue(string species, byte value)
	{
		string[] formList = getFormList(species);
		if (formList.Length < value)
		{
			return "None";
		}
		return formList[value];
	}

	public static byte getFormValue(string species, string form)
	{
		string[] formList = getFormList(species);
		if (formList.Length == 1)
		{
			return 0;
		}
		for (byte b = 0; b < formList.Length; b = (byte)(b + 1))
		{
			if (formList[b] == form)
			{
				return b;
			}
		}
		return 0;
	}

	public static void Initialize()
	{
		if (!dictionariesInitialized)
		{

			Dictionary<int, byte[]> dictionary = baseStats;
			byte[] value = new byte[6];
			dictionary.Add(0, value);
			baseStats.Add(1, new byte[6] { 45, 49, 49, 65, 65, 45 });
			baseStats.Add(2, new byte[6] { 60, 62, 63, 80, 80, 60 });
			baseStats.Add(3, new byte[6] { 80, 82, 83, 100, 100, 80 });
			baseStats.Add(4, new byte[6] { 39, 52, 43, 60, 50, 65 });
			baseStats.Add(5, new byte[6] { 58, 64, 58, 80, 65, 80 });
			baseStats.Add(6, new byte[6] { 78, 84, 78, 109, 85, 100 });
			baseStats.Add(7, new byte[6] { 44, 48, 65, 50, 64, 43 });
			baseStats.Add(8, new byte[6] { 59, 63, 80, 65, 80, 58 });
			baseStats.Add(9, new byte[6] { 79, 83, 100, 85, 105, 78 });
			baseStats.Add(10, new byte[6] { 45, 30, 35, 20, 20, 45 });
			baseStats.Add(11, new byte[6] { 50, 20, 55, 25, 25, 30 });
			baseStats.Add(12, new byte[6] { 60, 45, 50, 80, 80, 70 });
			baseStats.Add(13, new byte[6] { 40, 35, 30, 20, 20, 50 });
			baseStats.Add(14, new byte[6] { 45, 25, 50, 25, 25, 35 });
			baseStats.Add(15, new byte[6] { 65, 80, 40, 45, 80, 75 });
			baseStats.Add(16, new byte[6] { 40, 45, 40, 35, 35, 56 });
			baseStats.Add(17, new byte[6] { 63, 60, 55, 50, 50, 71 });
			baseStats.Add(18, new byte[6] { 83, 80, 75, 70, 70, 91 });
			baseStats.Add(19, new byte[6] { 30, 56, 35, 25, 35, 72 });
			baseStats.Add(20, new byte[6] { 55, 81, 60, 50, 70, 97 });
			baseStats.Add(21, new byte[6] { 40, 60, 30, 31, 31, 70 });
			baseStats.Add(22, new byte[6] { 65, 90, 65, 61, 61, 100 });
			baseStats.Add(23, new byte[6] { 35, 60, 44, 40, 54, 55 });
			baseStats.Add(24, new byte[6] { 60, 85, 69, 65, 79, 80 });
			baseStats.Add(25, new byte[6] { 35, 55, 30, 50, 40, 90 });
			baseStats.Add(26, new byte[6] { 60, 90, 55, 90, 80, 100 });
			baseStats.Add(27, new byte[6] { 50, 75, 85, 20, 30, 40 });
			baseStats.Add(28, new byte[6] { 75, 100, 110, 45, 55, 65 });
			baseStats.Add(29, new byte[6] { 55, 47, 52, 40, 40, 41 });
			baseStats.Add(30, new byte[6] { 70, 62, 67, 55, 55, 56 });
			baseStats.Add(31, new byte[6] { 90, 82, 87, 75, 85, 76 });
			baseStats.Add(32, new byte[6] { 46, 57, 40, 40, 40, 50 });
			baseStats.Add(33, new byte[6] { 61, 72, 57, 55, 55, 65 });
			baseStats.Add(34, new byte[6] { 81, 92, 77, 85, 75, 85 });
			baseStats.Add(35, new byte[6] { 70, 45, 48, 60, 65, 35 });
			baseStats.Add(36, new byte[6] { 95, 70, 73, 85, 90, 60 });
			baseStats.Add(37, new byte[6] { 38, 41, 40, 50, 65, 65 });
			baseStats.Add(38, new byte[6] { 73, 76, 75, 81, 100, 100 });
			baseStats.Add(39, new byte[6] { 115, 45, 20, 45, 25, 20 });
			baseStats.Add(40, new byte[6] { 140, 70, 45, 75, 50, 45 });
			baseStats.Add(41, new byte[6] { 40, 45, 35, 30, 40, 55 });
			baseStats.Add(42, new byte[6] { 75, 80, 70, 65, 75, 90 });
			baseStats.Add(43, new byte[6] { 45, 50, 55, 75, 65, 30 });
			baseStats.Add(44, new byte[6] { 60, 65, 70, 85, 75, 40 });
			baseStats.Add(45, new byte[6] { 75, 80, 85, 100, 90, 50 });
			baseStats.Add(46, new byte[6] { 35, 70, 55, 45, 55, 25 });
			baseStats.Add(47, new byte[6] { 60, 95, 80, 60, 80, 30 });
			baseStats.Add(48, new byte[6] { 60, 55, 50, 40, 55, 45 });
			baseStats.Add(49, new byte[6] { 70, 65, 60, 90, 75, 90 });
			baseStats.Add(50, new byte[6] { 10, 55, 25, 35, 45, 95 });
			baseStats.Add(51, new byte[6] { 35, 80, 50, 50, 70, 120 });
			baseStats.Add(52, new byte[6] { 40, 45, 35, 40, 40, 90 });
			baseStats.Add(53, new byte[6] { 65, 70, 60, 65, 65, 115 });
			baseStats.Add(54, new byte[6] { 50, 52, 48, 65, 50, 55 });
			baseStats.Add(55, new byte[6] { 80, 82, 78, 95, 80, 85 });
			baseStats.Add(56, new byte[6] { 40, 80, 35, 35, 45, 70 });
			baseStats.Add(57, new byte[6] { 65, 105, 60, 60, 70, 95 });
			baseStats.Add(58, new byte[6] { 55, 70, 45, 70, 50, 60 });
			baseStats.Add(59, new byte[6] { 90, 110, 80, 100, 80, 95 });
			baseStats.Add(60, new byte[6] { 40, 50, 40, 40, 40, 90 });
			baseStats.Add(61, new byte[6] { 65, 65, 65, 50, 50, 90 });
			baseStats.Add(62, new byte[6] { 90, 85, 95, 70, 90, 70 });
			baseStats.Add(63, new byte[6] { 25, 20, 15, 105, 55, 90 });
			baseStats.Add(64, new byte[6] { 40, 35, 30, 120, 70, 105 });
			baseStats.Add(65, new byte[6] { 55, 50, 45, 135, 85, 120 });
			baseStats.Add(66, new byte[6] { 70, 80, 50, 35, 35, 35 });
			baseStats.Add(67, new byte[6] { 80, 100, 70, 50, 60, 45 });
			baseStats.Add(68, new byte[6] { 90, 130, 80, 65, 85, 55 });
			baseStats.Add(69, new byte[6] { 50, 75, 35, 70, 30, 40 });
			baseStats.Add(70, new byte[6] { 65, 90, 50, 85, 45, 55 });
			baseStats.Add(71, new byte[6] { 80, 105, 65, 100, 60, 70 });
			baseStats.Add(72, new byte[6] { 40, 40, 35, 50, 100, 70 });
			baseStats.Add(73, new byte[6] { 80, 70, 65, 80, 120, 100 });
			baseStats.Add(74, new byte[6] { 40, 80, 100, 30, 30, 20 });
			baseStats.Add(75, new byte[6] { 55, 95, 115, 45, 45, 35 });
			baseStats.Add(76, new byte[6] { 80, 110, 130, 55, 65, 45 });
			baseStats.Add(77, new byte[6] { 50, 85, 55, 65, 65, 90 });
			baseStats.Add(78, new byte[6] { 65, 100, 70, 80, 80, 105 });
			baseStats.Add(79, new byte[6] { 90, 65, 65, 40, 40, 15 });
			baseStats.Add(80, new byte[6] { 95, 75, 110, 100, 80, 30 });
			baseStats.Add(81, new byte[6] { 25, 35, 70, 95, 55, 45 });
			baseStats.Add(82, new byte[6] { 50, 60, 95, 120, 70, 70 });
			baseStats.Add(83, new byte[6] { 52, 65, 55, 58, 62, 60 });
			baseStats.Add(84, new byte[6] { 35, 85, 45, 35, 35, 75 });
			baseStats.Add(85, new byte[6] { 60, 110, 70, 60, 60, 100 });
			baseStats.Add(86, new byte[6] { 65, 45, 55, 45, 70, 45 });
			baseStats.Add(87, new byte[6] { 90, 70, 80, 70, 95, 70 });
			baseStats.Add(88, new byte[6] { 80, 80, 50, 40, 50, 25 });
			baseStats.Add(89, new byte[6] { 105, 105, 75, 65, 100, 50 });
			baseStats.Add(90, new byte[6] { 30, 65, 100, 45, 25, 40 });
			baseStats.Add(91, new byte[6] { 50, 95, 180, 85, 45, 70 });
			baseStats.Add(92, new byte[6] { 30, 35, 30, 100, 35, 80 });
			baseStats.Add(93, new byte[6] { 45, 50, 45, 115, 55, 95 });
			baseStats.Add(94, new byte[6] { 60, 65, 60, 130, 75, 110 });
			baseStats.Add(95, new byte[6] { 35, 45, 160, 30, 45, 70 });
			baseStats.Add(96, new byte[6] { 60, 48, 45, 43, 90, 42 });
			baseStats.Add(97, new byte[6] { 85, 73, 70, 73, 115, 67 });
			baseStats.Add(98, new byte[6] { 30, 105, 90, 25, 25, 50 });
			baseStats.Add(99, new byte[6] { 55, 130, 115, 50, 50, 75 });
			baseStats.Add(100, new byte[6] { 40, 30, 50, 55, 55, 100 });
			baseStats.Add(101, new byte[6] { 60, 50, 70, 80, 80, 140 });
			baseStats.Add(102, new byte[6] { 60, 40, 80, 60, 45, 40 });
			baseStats.Add(103, new byte[6] { 95, 95, 85, 125, 65, 55 });
			baseStats.Add(104, new byte[6] { 50, 50, 95, 40, 50, 35 });
			baseStats.Add(105, new byte[6] { 60, 80, 110, 50, 80, 45 });
			baseStats.Add(106, new byte[6] { 50, 120, 53, 35, 110, 87 });
			baseStats.Add(107, new byte[6] { 50, 105, 79, 35, 110, 76 });
			baseStats.Add(108, new byte[6] { 90, 55, 75, 60, 75, 30 });
			baseStats.Add(109, new byte[6] { 40, 65, 95, 60, 45, 35 });
			baseStats.Add(110, new byte[6] { 65, 90, 120, 85, 70, 60 });
			baseStats.Add(111, new byte[6] { 80, 85, 95, 30, 30, 25 });
			baseStats.Add(112, new byte[6] { 105, 130, 120, 45, 45, 40 });
			baseStats.Add(113, new byte[6] { 250, 5, 5, 35, 105, 50 });
			baseStats.Add(114, new byte[6] { 65, 55, 115, 100, 40, 60 });
			baseStats.Add(115, new byte[6] { 105, 95, 80, 40, 80, 90 });
			baseStats.Add(116, new byte[6] { 30, 40, 70, 70, 25, 60 });
			baseStats.Add(117, new byte[6] { 55, 65, 95, 95, 45, 85 });
			baseStats.Add(118, new byte[6] { 45, 67, 60, 35, 50, 63 });
			baseStats.Add(119, new byte[6] { 80, 92, 65, 65, 80, 68 });
			baseStats.Add(120, new byte[6] { 30, 45, 55, 70, 55, 85 });
			baseStats.Add(121, new byte[6] { 60, 75, 85, 100, 85, 115 });
			baseStats.Add(122, new byte[6] { 40, 45, 65, 100, 120, 90 });
			baseStats.Add(123, new byte[6] { 70, 110, 80, 55, 80, 105 });
			baseStats.Add(124, new byte[6] { 65, 50, 35, 115, 95, 95 });
			baseStats.Add(125, new byte[6] { 65, 83, 57, 95, 85, 105 });
			baseStats.Add(126, new byte[6] { 65, 95, 57, 100, 85, 93 });
			baseStats.Add(127, new byte[6] { 65, 125, 100, 55, 70, 85 });
			baseStats.Add(128, new byte[6] { 75, 100, 95, 40, 70, 110 });
			baseStats.Add(129, new byte[6] { 20, 10, 55, 15, 20, 80 });
			baseStats.Add(130, new byte[6] { 95, 125, 79, 60, 100, 81 });
			baseStats.Add(131, new byte[6] { 130, 85, 80, 85, 95, 60 });
			baseStats.Add(132, new byte[6] { 48, 48, 48, 48, 48, 48 });
			baseStats.Add(133, new byte[6] { 55, 55, 50, 45, 65, 55 });
			baseStats.Add(134, new byte[6] { 130, 65, 60, 110, 95, 65 });
			baseStats.Add(135, new byte[6] { 65, 65, 60, 110, 95, 130 });
			baseStats.Add(136, new byte[6] { 65, 130, 60, 95, 110, 65 });
			baseStats.Add(137, new byte[6] { 65, 60, 70, 85, 75, 40 });
			baseStats.Add(138, new byte[6] { 35, 40, 100, 90, 55, 35 });
			baseStats.Add(139, new byte[6] { 70, 60, 125, 115, 70, 55 });
			baseStats.Add(140, new byte[6] { 30, 80, 90, 55, 45, 55 });
			baseStats.Add(141, new byte[6] { 60, 115, 105, 65, 70, 80 });
			baseStats.Add(142, new byte[6] { 80, 105, 65, 60, 75, 130 });
			baseStats.Add(143, new byte[6] { 160, 110, 65, 65, 110, 30 });
			baseStats.Add(144, new byte[6] { 90, 85, 100, 95, 125, 85 });
			baseStats.Add(145, new byte[6] { 90, 90, 85, 125, 90, 100 });
			baseStats.Add(146, new byte[6] { 90, 100, 90, 125, 85, 90 });
			baseStats.Add(147, new byte[6] { 41, 64, 45, 50, 50, 50 });
			baseStats.Add(148, new byte[6] { 61, 84, 65, 70, 70, 70 });
			baseStats.Add(149, new byte[6] { 91, 134, 95, 100, 100, 80 });
			baseStats.Add(150, new byte[6] { 106, 110, 90, 154, 90, 130 });
			baseStats.Add(151, new byte[6] { 100, 100, 100, 100, 100, 100 });
			baseStats.Add(152, new byte[6] { 45, 49, 65, 49, 65, 45 });
			baseStats.Add(153, new byte[6] { 60, 62, 80, 63, 80, 60 });
			baseStats.Add(154, new byte[6] { 80, 82, 100, 83, 100, 80 });
			baseStats.Add(155, new byte[6] { 39, 52, 43, 60, 50, 65 });
			baseStats.Add(156, new byte[6] { 58, 64, 58, 80, 65, 80 });
			baseStats.Add(157, new byte[6] { 78, 84, 78, 109, 85, 100 });
			baseStats.Add(158, new byte[6] { 50, 65, 64, 44, 48, 43 });
			baseStats.Add(159, new byte[6] { 65, 80, 80, 59, 63, 58 });
			baseStats.Add(160, new byte[6] { 85, 105, 100, 79, 83, 78 });
			baseStats.Add(161, new byte[6] { 35, 46, 34, 35, 45, 20 });
			baseStats.Add(162, new byte[6] { 85, 76, 64, 45, 55, 90 });
			baseStats.Add(163, new byte[6] { 60, 30, 30, 36, 56, 50 });
			baseStats.Add(164, new byte[6] { 100, 50, 50, 76, 96, 70 });
			baseStats.Add(165, new byte[6] { 40, 20, 30, 40, 80, 55 });
			baseStats.Add(166, new byte[6] { 55, 35, 50, 55, 110, 85 });
			baseStats.Add(167, new byte[6] { 40, 60, 40, 40, 40, 30 });
			baseStats.Add(168, new byte[6] { 70, 90, 70, 60, 60, 40 });
			baseStats.Add(169, new byte[6] { 85, 90, 80, 70, 80, 130 });
			baseStats.Add(170, new byte[6] { 75, 38, 38, 56, 56, 67 });
			baseStats.Add(171, new byte[6] { 125, 58, 58, 76, 76, 67 });
			baseStats.Add(172, new byte[6] { 20, 40, 15, 35, 35, 60 });
			baseStats.Add(173, new byte[6] { 50, 25, 28, 45, 55, 15 });
			baseStats.Add(174, new byte[6] { 90, 30, 15, 40, 20, 15 });
			baseStats.Add(175, new byte[6] { 35, 20, 65, 40, 65, 20 });
			baseStats.Add(176, new byte[6] { 55, 40, 85, 80, 105, 40 });
			baseStats.Add(177, new byte[6] { 40, 50, 45, 70, 45, 70 });
			baseStats.Add(178, new byte[6] { 65, 75, 70, 95, 70, 95 });
			baseStats.Add(179, new byte[6] { 55, 40, 40, 65, 45, 35 });
			baseStats.Add(180, new byte[6] { 70, 55, 55, 80, 60, 45 });
			baseStats.Add(181, new byte[6] { 90, 75, 75, 115, 90, 55 });
			baseStats.Add(182, new byte[6] { 75, 80, 85, 90, 100, 50 });
			baseStats.Add(183, new byte[6] { 70, 20, 50, 20, 50, 40 });
			baseStats.Add(184, new byte[6] { 100, 50, 80, 50, 80, 50 });
			baseStats.Add(185, new byte[6] { 70, 100, 115, 30, 65, 30 });
			baseStats.Add(186, new byte[6] { 90, 75, 75, 90, 100, 70 });
			baseStats.Add(187, new byte[6] { 35, 35, 40, 35, 55, 50 });
			baseStats.Add(188, new byte[6] { 55, 45, 50, 45, 65, 80 });
			baseStats.Add(189, new byte[6] { 75, 55, 70, 55, 85, 110 });
			baseStats.Add(190, new byte[6] { 55, 70, 55, 40, 55, 85 });
			baseStats.Add(191, new byte[6] { 30, 30, 30, 30, 30, 30 });
			baseStats.Add(192, new byte[6] { 75, 75, 55, 105, 85, 30 });
			baseStats.Add(193, new byte[6] { 65, 65, 45, 75, 45, 95 });
			baseStats.Add(194, new byte[6] { 55, 45, 45, 25, 25, 15 });
			baseStats.Add(195, new byte[6] { 95, 85, 85, 65, 65, 35 });
			baseStats.Add(196, new byte[6] { 65, 65, 60, 130, 95, 110 });
			baseStats.Add(197, new byte[6] { 95, 65, 110, 60, 130, 65 });
			baseStats.Add(198, new byte[6] { 60, 85, 42, 85, 42, 91 });
			baseStats.Add(199, new byte[6] { 95, 75, 80, 100, 110, 30 });
			baseStats.Add(200, new byte[6] { 60, 60, 60, 85, 85, 85 });
			baseStats.Add(201, new byte[6] { 48, 72, 48, 72, 48, 48 });
			baseStats.Add(202, new byte[6] { 190, 33, 58, 33, 58, 33 });
			baseStats.Add(203, new byte[6] { 70, 80, 65, 90, 65, 85 });
			baseStats.Add(204, new byte[6] { 50, 65, 90, 35, 35, 15 });
			baseStats.Add(205, new byte[6] { 75, 90, 140, 60, 60, 40 });
			baseStats.Add(206, new byte[6] { 100, 70, 70, 65, 65, 45 });
			baseStats.Add(207, new byte[6] { 65, 75, 105, 35, 65, 85 });
			baseStats.Add(208, new byte[6] { 75, 85, 200, 55, 65, 30 });
			baseStats.Add(209, new byte[6] { 60, 80, 50, 40, 40, 30 });
			baseStats.Add(210, new byte[6] { 90, 120, 75, 60, 60, 45 });
			baseStats.Add(211, new byte[6] { 65, 95, 75, 55, 55, 85 });
			baseStats.Add(212, new byte[6] { 70, 130, 100, 55, 80, 65 });
			baseStats.Add(213, new byte[6] { 20, 10, 230, 10, 230, 5 });
			baseStats.Add(214, new byte[6] { 80, 125, 75, 40, 95, 85 });
			baseStats.Add(215, new byte[6] { 55, 95, 55, 35, 75, 115 });
			baseStats.Add(216, new byte[6] { 60, 80, 50, 50, 50, 40 });
			baseStats.Add(217, new byte[6] { 90, 130, 75, 75, 75, 55 });
			baseStats.Add(218, new byte[6] { 40, 40, 40, 70, 40, 20 });
			baseStats.Add(219, new byte[6] { 50, 50, 120, 80, 80, 30 });
			baseStats.Add(220, new byte[6] { 50, 50, 40, 30, 30, 50 });
			baseStats.Add(221, new byte[6] { 100, 100, 80, 60, 60, 50 });
			baseStats.Add(222, new byte[6] { 55, 55, 85, 65, 85, 35 });
			baseStats.Add(223, new byte[6] { 35, 65, 35, 65, 35, 65 });
			baseStats.Add(224, new byte[6] { 75, 105, 75, 105, 75, 45 });
			baseStats.Add(225, new byte[6] { 45, 55, 45, 65, 45, 75 });
			baseStats.Add(226, new byte[6] { 65, 40, 70, 80, 140, 70 });
			baseStats.Add(227, new byte[6] { 65, 80, 140, 40, 70, 70 });
			baseStats.Add(228, new byte[6] { 45, 60, 30, 80, 50, 65 });
			baseStats.Add(229, new byte[6] { 75, 90, 50, 110, 80, 95 });
			baseStats.Add(230, new byte[6] { 75, 95, 95, 95, 95, 85 });
			baseStats.Add(231, new byte[6] { 90, 60, 60, 40, 40, 40 });
			baseStats.Add(232, new byte[6] { 90, 120, 120, 60, 60, 50 });
			baseStats.Add(233, new byte[6] { 85, 80, 90, 105, 95, 60 });
			baseStats.Add(234, new byte[6] { 73, 95, 62, 85, 65, 85 });
			baseStats.Add(235, new byte[6] { 55, 20, 35, 20, 45, 75 });
			baseStats.Add(236, new byte[6] { 35, 35, 35, 35, 35, 35 });
			baseStats.Add(237, new byte[6] { 50, 95, 95, 35, 110, 70 });
			baseStats.Add(238, new byte[6] { 45, 30, 15, 85, 65, 65 });
			baseStats.Add(239, new byte[6] { 45, 63, 37, 65, 55, 95 });
			baseStats.Add(240, new byte[6] { 45, 75, 37, 70, 55, 83 });
			baseStats.Add(241, new byte[6] { 95, 80, 105, 40, 70, 100 });
			baseStats.Add(242, new byte[6] { 255, 10, 10, 75, 135, 55 });
			baseStats.Add(243, new byte[6] { 90, 85, 75, 115, 100, 115 });
			baseStats.Add(244, new byte[6] { 115, 115, 85, 90, 75, 100 });
			baseStats.Add(245, new byte[6] { 100, 75, 115, 90, 115, 85 });
			baseStats.Add(246, new byte[6] { 50, 64, 50, 45, 50, 41 });
			baseStats.Add(247, new byte[6] { 70, 84, 70, 65, 70, 51 });
			baseStats.Add(248, new byte[6] { 100, 134, 110, 95, 100, 61 });
			baseStats.Add(249, new byte[6] { 106, 90, 130, 90, 154, 110 });
			baseStats.Add(250, new byte[6] { 106, 130, 90, 110, 154, 90 });
			baseStats.Add(251, new byte[6] { 100, 100, 100, 100, 100, 100 });
			baseStats.Add(252, new byte[6] { 40, 45, 35, 65, 55, 70 });
			baseStats.Add(253, new byte[6] { 50, 65, 45, 85, 65, 95 });
			baseStats.Add(254, new byte[6] { 70, 85, 65, 105, 85, 120 });
			baseStats.Add(255, new byte[6] { 45, 60, 40, 70, 50, 45 });
			baseStats.Add(256, new byte[6] { 60, 85, 60, 85, 60, 55 });
			baseStats.Add(257, new byte[6] { 80, 120, 70, 110, 70, 80 });
			baseStats.Add(258, new byte[6] { 50, 70, 50, 50, 50, 40 });
			baseStats.Add(259, new byte[6] { 70, 85, 70, 60, 70, 50 });
			baseStats.Add(260, new byte[6] { 100, 110, 90, 85, 90, 60 });
			baseStats.Add(261, new byte[6] { 35, 55, 35, 30, 30, 35 });
			baseStats.Add(262, new byte[6] { 70, 90, 70, 60, 60, 70 });
			baseStats.Add(263, new byte[6] { 38, 30, 41, 30, 41, 60 });
			baseStats.Add(264, new byte[6] { 78, 70, 61, 50, 61, 100 });
			baseStats.Add(265, new byte[6] { 45, 45, 35, 20, 30, 20 });
			baseStats.Add(266, new byte[6] { 50, 35, 55, 25, 25, 15 });
			baseStats.Add(267, new byte[6] { 60, 70, 50, 90, 50, 65 });
			baseStats.Add(268, new byte[6] { 50, 35, 55, 25, 25, 15 });
			baseStats.Add(269, new byte[6] { 60, 50, 70, 50, 90, 65 });
			baseStats.Add(270, new byte[6] { 40, 30, 30, 40, 50, 30 });
			baseStats.Add(271, new byte[6] { 60, 50, 50, 60, 70, 50 });
			baseStats.Add(272, new byte[6] { 80, 70, 70, 90, 100, 70 });
			baseStats.Add(273, new byte[6] { 40, 40, 50, 30, 30, 30 });
			baseStats.Add(274, new byte[6] { 70, 70, 40, 60, 40, 60 });
			baseStats.Add(275, new byte[6] { 90, 100, 60, 90, 60, 80 });
			baseStats.Add(276, new byte[6] { 40, 55, 30, 30, 30, 85 });
			baseStats.Add(277, new byte[6] { 60, 85, 60, 50, 50, 125 });
			baseStats.Add(278, new byte[6] { 40, 30, 30, 55, 30, 85 });
			baseStats.Add(279, new byte[6] { 60, 50, 100, 85, 70, 65 });
			baseStats.Add(280, new byte[6] { 28, 25, 25, 45, 35, 40 });
			baseStats.Add(281, new byte[6] { 38, 35, 35, 65, 55, 50 });
			baseStats.Add(282, new byte[6] { 68, 65, 65, 125, 115, 80 });
			baseStats.Add(283, new byte[6] { 40, 30, 32, 50, 52, 65 });
			baseStats.Add(284, new byte[6] { 70, 60, 62, 80, 82, 60 });
			baseStats.Add(285, new byte[6] { 60, 40, 60, 40, 60, 35 });
			baseStats.Add(286, new byte[6] { 60, 130, 80, 60, 60, 70 });
			baseStats.Add(287, new byte[6] { 60, 60, 60, 35, 35, 30 });
			baseStats.Add(288, new byte[6] { 80, 80, 80, 55, 55, 90 });
			baseStats.Add(289, new byte[6] { 150, 160, 100, 95, 65, 100 });
			baseStats.Add(290, new byte[6] { 31, 45, 90, 30, 30, 40 });
			baseStats.Add(291, new byte[6] { 61, 90, 45, 50, 50, 160 });
			baseStats.Add(292, new byte[6] { 1, 90, 45, 30, 30, 40 });
			baseStats.Add(293, new byte[6] { 64, 51, 23, 51, 23, 28 });
			baseStats.Add(294, new byte[6] { 84, 71, 43, 71, 43, 48 });
			baseStats.Add(295, new byte[6] { 104, 91, 63, 91, 63, 68 });
			baseStats.Add(296, new byte[6] { 72, 60, 30, 20, 30, 25 });
			baseStats.Add(297, new byte[6] { 144, 120, 60, 40, 60, 50 });
			baseStats.Add(298, new byte[6] { 50, 20, 40, 20, 40, 20 });
			baseStats.Add(299, new byte[6] { 30, 45, 135, 45, 90, 30 });
			baseStats.Add(300, new byte[6] { 50, 45, 45, 35, 35, 50 });
			baseStats.Add(301, new byte[6] { 70, 65, 65, 55, 55, 70 });
			baseStats.Add(302, new byte[6] { 50, 75, 75, 65, 65, 50 });
			baseStats.Add(303, new byte[6] { 50, 85, 85, 55, 55, 50 });
			baseStats.Add(304, new byte[6] { 50, 70, 100, 40, 40, 30 });
			baseStats.Add(305, new byte[6] { 60, 90, 140, 50, 50, 40 });
			baseStats.Add(306, new byte[6] { 70, 110, 180, 60, 60, 50 });
			baseStats.Add(307, new byte[6] { 30, 40, 55, 40, 55, 60 });
			baseStats.Add(308, new byte[6] { 60, 60, 75, 60, 75, 80 });
			baseStats.Add(309, new byte[6] { 40, 45, 40, 65, 40, 65 });
			baseStats.Add(310, new byte[6] { 70, 75, 60, 105, 60, 105 });
			baseStats.Add(311, new byte[6] { 60, 50, 40, 85, 75, 95 });
			baseStats.Add(312, new byte[6] { 60, 40, 50, 75, 85, 95 });
			baseStats.Add(313, new byte[6] { 65, 73, 55, 47, 75, 85 });
			baseStats.Add(314, new byte[6] { 65, 47, 55, 73, 75, 85 });
			baseStats.Add(315, new byte[6] { 50, 60, 45, 100, 80, 65 });
			baseStats.Add(316, new byte[6] { 70, 43, 53, 43, 53, 40 });
			baseStats.Add(317, new byte[6] { 100, 73, 83, 73, 83, 55 });
			baseStats.Add(318, new byte[6] { 45, 90, 20, 65, 20, 65 });
			baseStats.Add(319, new byte[6] { 70, 120, 40, 95, 40, 95 });
			baseStats.Add(320, new byte[6] { 130, 70, 35, 70, 35, 60 });
			baseStats.Add(321, new byte[6] { 170, 90, 45, 90, 45, 60 });
			baseStats.Add(322, new byte[6] { 60, 60, 40, 65, 45, 35 });
			baseStats.Add(323, new byte[6] { 70, 100, 70, 105, 75, 40 });
			baseStats.Add(324, new byte[6] { 70, 85, 140, 85, 70, 20 });
			baseStats.Add(325, new byte[6] { 60, 25, 35, 70, 80, 60 });
			baseStats.Add(326, new byte[6] { 80, 45, 65, 90, 110, 80 });
			baseStats.Add(327, new byte[6] { 60, 60, 60, 60, 60, 60 });
			baseStats.Add(328, new byte[6] { 45, 100, 45, 45, 45, 10 });
			baseStats.Add(329, new byte[6] { 50, 70, 50, 50, 50, 70 });
			baseStats.Add(330, new byte[6] { 80, 100, 80, 80, 80, 100 });
			baseStats.Add(331, new byte[6] { 50, 85, 40, 85, 40, 35 });
			baseStats.Add(332, new byte[6] { 70, 115, 60, 115, 60, 55 });
			baseStats.Add(333, new byte[6] { 45, 40, 60, 40, 75, 50 });
			baseStats.Add(334, new byte[6] { 75, 70, 90, 70, 105, 80 });
			baseStats.Add(335, new byte[6] { 73, 115, 60, 60, 60, 90 });
			baseStats.Add(336, new byte[6] { 73, 100, 60, 100, 60, 65 });
			baseStats.Add(337, new byte[6] { 70, 55, 65, 95, 85, 70 });
			baseStats.Add(338, new byte[6] { 70, 95, 85, 55, 65, 70 });
			baseStats.Add(339, new byte[6] { 50, 48, 43, 46, 41, 60 });
			baseStats.Add(340, new byte[6] { 110, 78, 73, 76, 71, 60 });
			baseStats.Add(341, new byte[6] { 43, 80, 65, 50, 35, 35 });
			baseStats.Add(342, new byte[6] { 63, 120, 85, 90, 55, 55 });
			baseStats.Add(343, new byte[6] { 40, 40, 55, 40, 70, 55 });
			baseStats.Add(344, new byte[6] { 60, 70, 105, 70, 120, 75 });
			baseStats.Add(345, new byte[6] { 66, 41, 77, 61, 87, 23 });
			baseStats.Add(346, new byte[6] { 86, 81, 97, 81, 107, 43 });
			baseStats.Add(347, new byte[6] { 45, 95, 50, 40, 50, 75 });
			baseStats.Add(348, new byte[6] { 75, 125, 100, 70, 80, 45 });
			baseStats.Add(349, new byte[6] { 20, 15, 20, 10, 55, 80 });
			baseStats.Add(350, new byte[6] { 95, 60, 79, 100, 125, 81 });
			baseStats.Add(351, new byte[6] { 70, 70, 70, 70, 70, 70 });
			baseStats.Add(352, new byte[6] { 60, 90, 70, 60, 120, 40 });
			baseStats.Add(353, new byte[6] { 44, 75, 35, 63, 33, 45 });
			baseStats.Add(354, new byte[6] { 64, 115, 65, 83, 63, 65 });
			baseStats.Add(355, new byte[6] { 20, 40, 90, 30, 90, 25 });
			baseStats.Add(356, new byte[6] { 40, 70, 130, 60, 130, 25 });
			baseStats.Add(357, new byte[6] { 99, 68, 83, 72, 87, 51 });
			baseStats.Add(358, new byte[6] { 65, 50, 70, 95, 80, 65 });
			baseStats.Add(359, new byte[6] { 65, 130, 60, 75, 60, 75 });
			baseStats.Add(360, new byte[6] { 95, 23, 48, 23, 48, 23 });
			baseStats.Add(361, new byte[6] { 50, 50, 50, 50, 50, 50 });
			baseStats.Add(362, new byte[6] { 80, 80, 80, 80, 80, 80 });
			baseStats.Add(363, new byte[6] { 70, 40, 50, 55, 50, 25 });
			baseStats.Add(364, new byte[6] { 90, 60, 70, 75, 70, 45 });
			baseStats.Add(365, new byte[6] { 110, 80, 90, 95, 90, 65 });
			baseStats.Add(366, new byte[6] { 35, 64, 85, 74, 55, 32 });
			baseStats.Add(367, new byte[6] { 55, 104, 105, 94, 75, 52 });
			baseStats.Add(368, new byte[6] { 55, 84, 105, 114, 75, 52 });
			baseStats.Add(369, new byte[6] { 100, 90, 130, 45, 65, 55 });
			baseStats.Add(370, new byte[6] { 43, 30, 55, 40, 65, 97 });
			baseStats.Add(371, new byte[6] { 45, 75, 60, 40, 30, 50 });
			baseStats.Add(372, new byte[6] { 65, 95, 100, 60, 50, 50 });
			baseStats.Add(373, new byte[6] { 95, 135, 80, 110, 80, 100 });
			baseStats.Add(374, new byte[6] { 40, 55, 80, 35, 60, 30 });
			baseStats.Add(375, new byte[6] { 60, 75, 100, 55, 80, 50 });
			baseStats.Add(376, new byte[6] { 80, 135, 130, 95, 90, 70 });
			baseStats.Add(377, new byte[6] { 80, 100, 200, 50, 100, 50 });
			baseStats.Add(378, new byte[6] { 80, 50, 100, 100, 200, 50 });
			baseStats.Add(379, new byte[6] { 80, 75, 150, 75, 150, 50 });
			baseStats.Add(380, new byte[6] { 80, 80, 90, 110, 130, 110 });
			baseStats.Add(381, new byte[6] { 80, 90, 80, 130, 110, 110 });
			baseStats.Add(382, new byte[6] { 100, 100, 90, 150, 140, 90 });
			baseStats.Add(383, new byte[6] { 100, 150, 140, 100, 90, 90 });
			baseStats.Add(384, new byte[6] { 105, 150, 90, 150, 90, 95 });
			baseStats.Add(385, new byte[6] { 100, 100, 100, 100, 100, 100 });
			baseStats.Add(386, new byte[6] { 50, 150, 50, 150, 50, 150 });
			baseStats.Add(387, new byte[6] { 55, 68, 64, 45, 55, 31 });
			baseStats.Add(388, new byte[6] { 75, 89, 85, 55, 65, 36 });
			baseStats.Add(389, new byte[6] { 95, 109, 105, 75, 85, 56 });
			baseStats.Add(390, new byte[6] { 44, 58, 44, 58, 44, 61 });
			baseStats.Add(391, new byte[6] { 64, 78, 52, 78, 52, 81 });
			baseStats.Add(392, new byte[6] { 76, 104, 71, 104, 71, 108 });
			baseStats.Add(393, new byte[6] { 53, 51, 53, 61, 56, 40 });
			baseStats.Add(394, new byte[6] { 64, 66, 68, 81, 76, 50 });
			baseStats.Add(395, new byte[6] { 84, 86, 88, 111, 101, 60 });
			baseStats.Add(396, new byte[6] { 40, 55, 30, 30, 30, 60 });
			baseStats.Add(397, new byte[6] { 55, 75, 50, 40, 40, 80 });
			baseStats.Add(398, new byte[6] { 85, 120, 70, 50, 50, 100 });
			baseStats.Add(399, new byte[6] { 59, 45, 40, 35, 40, 31 });
			baseStats.Add(400, new byte[6] { 79, 85, 60, 55, 60, 71 });
			baseStats.Add(401, new byte[6] { 37, 25, 41, 25, 41, 25 });
			baseStats.Add(402, new byte[6] { 77, 85, 51, 55, 51, 65 });
			baseStats.Add(403, new byte[6] { 45, 65, 34, 40, 34, 45 });
			baseStats.Add(404, new byte[6] { 60, 85, 49, 60, 49, 60 });
			baseStats.Add(405, new byte[6] { 80, 120, 79, 95, 79, 70 });
			baseStats.Add(406, new byte[6] { 40, 30, 35, 50, 70, 55 });
			baseStats.Add(407, new byte[6] { 60, 70, 55, 125, 105, 90 });
			baseStats.Add(408, new byte[6] { 67, 125, 40, 30, 30, 58 });
			baseStats.Add(409, new byte[6] { 97, 165, 60, 65, 50, 58 });
			baseStats.Add(410, new byte[6] { 30, 42, 118, 42, 88, 30 });
			baseStats.Add(411, new byte[6] { 60, 52, 168, 47, 138, 30 });
			baseStats.Add(412, new byte[6] { 40, 29, 45, 29, 45, 36 });
			baseStats.Add(413, new byte[6] { 60, 59, 85, 79, 105, 36 });
			baseStats.Add(414, new byte[6] { 70, 94, 50, 94, 50, 66 });
			baseStats.Add(415, new byte[6] { 30, 30, 42, 30, 42, 70 });
			baseStats.Add(416, new byte[6] { 70, 80, 102, 80, 102, 40 });
			baseStats.Add(417, new byte[6] { 60, 45, 70, 45, 90, 95 });
			baseStats.Add(418, new byte[6] { 55, 65, 35, 60, 30, 85 });
			baseStats.Add(419, new byte[6] { 85, 105, 55, 85, 50, 115 });
			baseStats.Add(420, new byte[6] { 45, 35, 45, 62, 53, 35 });
			baseStats.Add(421, new byte[6] { 70, 60, 70, 87, 78, 85 });
			baseStats.Add(422, new byte[6] { 76, 48, 48, 57, 62, 34 });
			baseStats.Add(423, new byte[6] { 111, 83, 68, 92, 82, 39 });
			baseStats.Add(424, new byte[6] { 75, 100, 66, 60, 66, 115 });
			baseStats.Add(425, new byte[6] { 90, 50, 34, 60, 44, 70 });
			baseStats.Add(426, new byte[6] { 150, 80, 44, 90, 54, 80 });
			baseStats.Add(427, new byte[6] { 55, 66, 44, 44, 56, 85 });
			baseStats.Add(428, new byte[6] { 65, 76, 84, 54, 96, 105 });
			baseStats.Add(429, new byte[6] { 60, 60, 60, 105, 105, 105 });
			baseStats.Add(430, new byte[6] { 100, 125, 52, 105, 52, 71 });
			baseStats.Add(431, new byte[6] { 49, 55, 42, 42, 37, 85 });
			baseStats.Add(432, new byte[6] { 71, 82, 64, 64, 59, 112 });
			baseStats.Add(433, new byte[6] { 45, 30, 50, 65, 50, 45 });
			baseStats.Add(434, new byte[6] { 63, 63, 47, 41, 41, 74 });
			baseStats.Add(435, new byte[6] { 103, 93, 67, 71, 61, 84 });
			baseStats.Add(436, new byte[6] { 57, 24, 86, 24, 86, 23 });
			baseStats.Add(437, new byte[6] { 67, 89, 116, 79, 116, 33 });
			baseStats.Add(438, new byte[6] { 50, 80, 95, 10, 45, 10 });
			baseStats.Add(439, new byte[6] { 20, 25, 45, 70, 90, 60 });
			baseStats.Add(440, new byte[6] { 100, 5, 5, 15, 65, 30 });
			baseStats.Add(441, new byte[6] { 76, 65, 45, 92, 42, 91 });
			baseStats.Add(442, new byte[6] { 50, 92, 108, 92, 108, 35 });
			baseStats.Add(443, new byte[6] { 58, 70, 45, 40, 45, 42 });
			baseStats.Add(444, new byte[6] { 68, 90, 65, 50, 55, 82 });
			baseStats.Add(445, new byte[6] { 108, 130, 95, 80, 85, 102 });
			baseStats.Add(446, new byte[6] { 135, 85, 40, 40, 85, 5 });
			baseStats.Add(447, new byte[6] { 40, 70, 40, 35, 40, 60 });
			baseStats.Add(448, new byte[6] { 70, 110, 70, 115, 70, 90 });
			baseStats.Add(449, new byte[6] { 68, 72, 78, 38, 42, 32 });
			baseStats.Add(450, new byte[6] { 108, 112, 118, 68, 72, 47 });
			baseStats.Add(451, new byte[6] { 40, 50, 90, 30, 55, 65 });
			baseStats.Add(452, new byte[6] { 70, 90, 110, 60, 75, 95 });
			baseStats.Add(453, new byte[6] { 48, 61, 40, 61, 40, 50 });
			baseStats.Add(454, new byte[6] { 83, 106, 65, 86, 65, 85 });
			baseStats.Add(455, new byte[6] { 74, 100, 72, 90, 72, 46 });
			baseStats.Add(456, new byte[6] { 49, 49, 56, 49, 61, 66 });
			baseStats.Add(457, new byte[6] { 69, 69, 76, 69, 86, 91 });
			baseStats.Add(458, new byte[6] { 45, 20, 50, 60, 120, 50 });
			baseStats.Add(459, new byte[6] { 60, 62, 50, 62, 60, 40 });
			baseStats.Add(460, new byte[6] { 90, 92, 75, 92, 85, 60 });
			baseStats.Add(461, new byte[6] { 70, 120, 65, 45, 85, 125 });
			baseStats.Add(462, new byte[6] { 70, 70, 115, 130, 90, 60 });
			baseStats.Add(463, new byte[6] { 110, 85, 95, 80, 95, 50 });
			baseStats.Add(464, new byte[6] { 115, 140, 130, 55, 55, 40 });
			baseStats.Add(465, new byte[6] { 100, 100, 125, 110, 50, 50 });
			baseStats.Add(466, new byte[6] { 75, 123, 67, 95, 85, 95 });
			baseStats.Add(467, new byte[6] { 75, 95, 67, 125, 95, 83 });
			baseStats.Add(468, new byte[6] { 85, 50, 95, 120, 115, 80 });
			baseStats.Add(469, new byte[6] { 86, 76, 86, 116, 56, 95 });
			baseStats.Add(470, new byte[6] { 65, 110, 130, 60, 65, 95 });
			baseStats.Add(471, new byte[6] { 65, 60, 110, 130, 95, 65 });
			baseStats.Add(472, new byte[6] { 75, 95, 125, 45, 75, 95 });
			baseStats.Add(473, new byte[6] { 110, 130, 80, 70, 60, 80 });
			baseStats.Add(474, new byte[6] { 85, 80, 70, 135, 75, 90 });
			baseStats.Add(475, new byte[6] { 68, 125, 65, 65, 115, 80 });
			baseStats.Add(476, new byte[6] { 60, 55, 145, 75, 150, 40 });
			baseStats.Add(477, new byte[6] { 45, 100, 135, 65, 135, 45 });
			baseStats.Add(478, new byte[6] { 70, 80, 70, 80, 70, 110 });
			baseStats.Add(479, new byte[6] { 50, 50, 77, 95, 77, 91 });
			baseStats.Add(480, new byte[6] { 75, 75, 130, 75, 130, 95 });
			baseStats.Add(481, new byte[6] { 80, 105, 105, 105, 105, 80 });
			baseStats.Add(482, new byte[6] { 75, 125, 70, 125, 70, 115 });
			baseStats.Add(483, new byte[6] { 100, 120, 120, 150, 100, 90 });
			baseStats.Add(484, new byte[6] { 90, 120, 100, 150, 120, 100 });
			baseStats.Add(485, new byte[6] { 91, 90, 106, 130, 106, 77 });
			baseStats.Add(486, new byte[6] { 110, 160, 110, 80, 110, 100 });
			baseStats.Add(487, new byte[6] { 150, 100, 120, 100, 120, 90 });
			baseStats.Add(488, new byte[6] { 120, 70, 120, 75, 130, 85 });
			baseStats.Add(489, new byte[6] { 80, 80, 80, 80, 80, 80 });
			baseStats.Add(490, new byte[6] { 100, 100, 100, 100, 100, 100 });
			baseStats.Add(491, new byte[6] { 70, 90, 90, 135, 90, 125 });
			baseStats.Add(492, new byte[6] { 100, 100, 100, 100, 100, 100 });
			baseStats.Add(493, new byte[6] { 120, 120, 120, 120, 120, 120 });
			baseStats.Add(494, new byte[6] { 100, 100, 100, 100, 100, 100 });
			baseStats.Add(495, new byte[6] { 45, 45, 55, 45, 55, 63 });
			baseStats.Add(496, new byte[6] { 60, 60, 75, 60, 75, 83 });
			baseStats.Add(497, new byte[6] { 75, 75, 95, 75, 95, 113 });
			baseStats.Add(498, new byte[6] { 65, 63, 45, 45, 45, 45 });
			baseStats.Add(499, new byte[6] { 90, 93, 55, 70, 55, 55 });
			baseStats.Add(500, new byte[6] { 110, 123, 65, 100, 65, 65 });
			baseStats.Add(501, new byte[6] { 55, 55, 45, 63, 45, 45 });
			baseStats.Add(502, new byte[6] { 75, 75, 60, 83, 60, 60 });
			baseStats.Add(503, new byte[6] { 95, 100, 85, 108, 70, 70 });
			baseStats.Add(504, new byte[6] { 45, 55, 39, 35, 39, 42 });
			baseStats.Add(505, new byte[6] { 60, 85, 69, 60, 69, 77 });
			baseStats.Add(506, new byte[6] { 45, 60, 45, 25, 45, 55 });
			baseStats.Add(507, new byte[6] { 65, 80, 65, 35, 65, 60 });
			baseStats.Add(508, new byte[6] { 85, 100, 90, 45, 90, 80 });
			baseStats.Add(509, new byte[6] { 41, 50, 37, 50, 37, 66 });
			baseStats.Add(510, new byte[6] { 64, 88, 50, 88, 50, 106 });
			baseStats.Add(511, new byte[6] { 50, 53, 48, 53, 48, 64 });
			baseStats.Add(512, new byte[6] { 75, 98, 63, 98, 63, 101 });
			baseStats.Add(513, new byte[6] { 50, 53, 48, 53, 48, 64 });
			baseStats.Add(514, new byte[6] { 75, 98, 63, 98, 63, 101 });
			baseStats.Add(515, new byte[6] { 50, 53, 48, 53, 48, 64 });
			baseStats.Add(516, new byte[6] { 75, 98, 63, 98, 63, 101 });
			baseStats.Add(517, new byte[6] { 76, 25, 45, 67, 55, 24 });
			baseStats.Add(518, new byte[6] { 116, 55, 85, 107, 95, 29 });
			baseStats.Add(519, new byte[6] { 50, 55, 50, 36, 30, 43 });
			baseStats.Add(520, new byte[6] { 62, 77, 62, 50, 42, 65 });
			baseStats.Add(521, new byte[6] { 80, 105, 80, 65, 55, 93 });
			baseStats.Add(522, new byte[6] { 45, 60, 32, 50, 32, 76 });
			baseStats.Add(523, new byte[6] { 75, 100, 63, 80, 63, 116 });
			baseStats.Add(524, new byte[6] { 55, 75, 85, 25, 25, 15 });
			baseStats.Add(525, new byte[6] { 70, 105, 105, 50, 40, 20 });
			baseStats.Add(526, new byte[6] { 85, 135, 130, 60, 70, 25 });
			baseStats.Add(527, new byte[6] { 55, 45, 43, 55, 43, 72 });
			baseStats.Add(528, new byte[6] { 67, 57, 55, 77, 55, 114 });
			baseStats.Add(529, new byte[6] { 60, 85, 40, 30, 45, 68 });
			baseStats.Add(530, new byte[6] { 110, 135, 60, 50, 65, 88 });
			baseStats.Add(531, new byte[6] { 103, 60, 86, 60, 86, 50 });
			baseStats.Add(532, new byte[6] { 75, 80, 55, 25, 35, 35 });
			baseStats.Add(533, new byte[6] { 85, 105, 85, 40, 50, 40 });
			baseStats.Add(534, new byte[6] { 105, 140, 95, 55, 65, 45 });
			baseStats.Add(535, new byte[6] { 50, 50, 40, 50, 40, 64 });
			baseStats.Add(536, new byte[6] { 75, 65, 55, 65, 55, 69 });
			baseStats.Add(537, new byte[6] { 105, 85, 75, 85, 75, 74 });
			baseStats.Add(538, new byte[6] { 120, 100, 85, 30, 85, 45 });
			baseStats.Add(539, new byte[6] { 75, 125, 75, 30, 75, 85 });
			baseStats.Add(540, new byte[6] { 45, 53, 70, 40, 60, 42 });
			baseStats.Add(541, new byte[6] { 55, 63, 90, 50, 80, 42 });
			baseStats.Add(542, new byte[6] { 75, 103, 80, 70, 70, 92 });
			baseStats.Add(543, new byte[6] { 30, 45, 59, 30, 39, 57 });
			baseStats.Add(544, new byte[6] { 40, 55, 99, 40, 79, 47 });
			baseStats.Add(545, new byte[6] { 60, 90, 89, 55, 69, 112 });
			baseStats.Add(546, new byte[6] { 40, 27, 60, 37, 50, 66 });
			baseStats.Add(547, new byte[6] { 60, 67, 85, 77, 75, 116 });
			baseStats.Add(548, new byte[6] { 45, 35, 50, 70, 50, 30 });
			baseStats.Add(549, new byte[6] { 70, 60, 75, 110, 75, 90 });
			baseStats.Add(550, new byte[6] { 70, 92, 65, 80, 55, 98 });
			baseStats.Add(551, new byte[6] { 50, 72, 35, 35, 35, 65 });
			baseStats.Add(552, new byte[6] { 60, 82, 45, 45, 45, 74 });
			baseStats.Add(553, new byte[6] { 95, 117, 70, 65, 70, 92 });
			baseStats.Add(554, new byte[6] { 70, 90, 45, 15, 45, 50 });
			baseStats.Add(555, new byte[6] { 105, 140, 55, 30, 55, 95 });
			baseStats.Add(556, new byte[6] { 75, 86, 67, 106, 67, 60 });
			baseStats.Add(557, new byte[6] { 50, 65, 85, 35, 35, 55 });
			baseStats.Add(558, new byte[6] { 70, 95, 125, 65, 75, 45 });
			baseStats.Add(559, new byte[6] { 50, 75, 70, 35, 70, 48 });
			baseStats.Add(560, new byte[6] { 65, 90, 115, 45, 115, 58 });
			baseStats.Add(561, new byte[6] { 72, 58, 80, 103, 80, 97 });
			baseStats.Add(562, new byte[6] { 38, 30, 85, 55, 65, 30 });
			baseStats.Add(563, new byte[6] { 58, 50, 145, 95, 105, 30 });
			baseStats.Add(564, new byte[6] { 54, 78, 103, 53, 45, 22 });
			baseStats.Add(565, new byte[6] { 74, 108, 133, 83, 65, 32 });
			baseStats.Add(566, new byte[6] { 55, 112, 45, 74, 45, 70 });
			baseStats.Add(567, new byte[6] { 75, 140, 65, 112, 65, 110 });
			baseStats.Add(568, new byte[6] { 50, 50, 62, 40, 62, 65 });
			baseStats.Add(569, new byte[6] { 80, 95, 82, 60, 82, 75 });
			baseStats.Add(570, new byte[6] { 40, 65, 40, 80, 40, 65 });
			baseStats.Add(571, new byte[6] { 60, 105, 60, 120, 60, 105 });
			baseStats.Add(572, new byte[6] { 55, 50, 40, 40, 40, 75 });
			baseStats.Add(573, new byte[6] { 75, 95, 60, 65, 60, 115 });
			baseStats.Add(574, new byte[6] { 45, 30, 50, 55, 65, 45 });
			baseStats.Add(575, new byte[6] { 60, 45, 70, 75, 85, 55 });
			baseStats.Add(576, new byte[6] { 70, 55, 95, 95, 110, 65 });
			baseStats.Add(577, new byte[6] { 45, 30, 40, 105, 50, 20 });
			baseStats.Add(578, new byte[6] { 65, 40, 50, 125, 60, 30 });
			baseStats.Add(579, new byte[6] { 110, 65, 75, 125, 85, 30 });
			baseStats.Add(580, new byte[6] { 62, 44, 50, 44, 50, 55 });
			baseStats.Add(581, new byte[6] { 75, 87, 63, 87, 63, 98 });
			baseStats.Add(582, new byte[6] { 36, 50, 50, 65, 60, 44 });
			baseStats.Add(583, new byte[6] { 51, 65, 65, 80, 75, 59 });
			baseStats.Add(584, new byte[6] { 71, 95, 85, 110, 95, 79 });
			baseStats.Add(585, new byte[6] { 60, 60, 50, 40, 50, 75 });
			baseStats.Add(586, new byte[6] { 80, 100, 70, 60, 70, 95 });
			baseStats.Add(587, new byte[6] { 55, 75, 60, 75, 60, 103 });
			baseStats.Add(588, new byte[6] { 50, 75, 45, 40, 45, 60 });
			baseStats.Add(589, new byte[6] { 70, 135, 105, 60, 105, 20 });
			baseStats.Add(590, new byte[6] { 69, 55, 45, 55, 55, 15 });
			baseStats.Add(591, new byte[6] { 114, 85, 70, 85, 80, 30 });
			baseStats.Add(592, new byte[6] { 55, 40, 50, 65, 85, 40 });
			baseStats.Add(593, new byte[6] { 100, 60, 70, 85, 105, 60 });
			baseStats.Add(594, new byte[6] { 165, 75, 80, 40, 45, 65 });
			baseStats.Add(595, new byte[6] { 50, 47, 50, 57, 50, 65 });
			baseStats.Add(596, new byte[6] { 70, 77, 60, 97, 60, 108 });
			baseStats.Add(597, new byte[6] { 44, 50, 91, 24, 86, 10 });
			baseStats.Add(598, new byte[6] { 74, 94, 131, 54, 116, 20 });
			baseStats.Add(599, new byte[6] { 40, 55, 70, 45, 60, 30 });
			baseStats.Add(600, new byte[6] { 60, 80, 95, 70, 85, 50 });
			baseStats.Add(601, new byte[6] { 60, 100, 115, 70, 85, 90 });
			baseStats.Add(602, new byte[6] { 35, 55, 40, 45, 40, 60 });
			baseStats.Add(603, new byte[6] { 65, 85, 70, 75, 70, 40 });
			baseStats.Add(604, new byte[6] { 85, 115, 80, 105, 80, 50 });
			baseStats.Add(605, new byte[6] { 55, 55, 55, 85, 55, 30 });
			baseStats.Add(606, new byte[6] { 75, 75, 75, 125, 95, 40 });
			baseStats.Add(607, new byte[6] { 50, 30, 55, 65, 55, 20 });
			baseStats.Add(608, new byte[6] { 60, 40, 60, 95, 60, 55 });
			baseStats.Add(609, new byte[6] { 60, 55, 90, 145, 90, 80 });
			baseStats.Add(610, new byte[6] { 46, 87, 60, 30, 40, 57 });
			baseStats.Add(611, new byte[6] { 66, 117, 70, 40, 50, 67 });
			baseStats.Add(612, new byte[6] { 76, 147, 90, 60, 70, 97 });
			baseStats.Add(613, new byte[6] { 55, 70, 40, 60, 40, 40 });
			baseStats.Add(614, new byte[6] { 95, 110, 80, 70, 80, 50 });
			baseStats.Add(615, new byte[6] { 70, 50, 30, 95, 135, 105 });
			baseStats.Add(616, new byte[6] { 50, 40, 85, 40, 65, 25 });
			baseStats.Add(617, new byte[6] { 80, 70, 40, 100, 60, 145 });
			baseStats.Add(618, new byte[6] { 109, 66, 84, 81, 99, 32 });
			baseStats.Add(619, new byte[6] { 45, 85, 50, 55, 50, 65 });
			baseStats.Add(620, new byte[6] { 65, 125, 60, 95, 60, 105 });
			baseStats.Add(621, new byte[6] { 77, 120, 90, 60, 90, 48 });
			baseStats.Add(622, new byte[6] { 59, 74, 50, 35, 50, 35 });
			baseStats.Add(623, new byte[6] { 89, 124, 80, 55, 80, 55 });
			baseStats.Add(624, new byte[6] { 45, 85, 70, 40, 40, 60 });
			baseStats.Add(625, new byte[6] { 65, 125, 100, 60, 70, 70 });
			baseStats.Add(626, new byte[6] { 95, 110, 95, 40, 95, 55 });
			baseStats.Add(627, new byte[6] { 70, 83, 50, 37, 50, 60 });
			baseStats.Add(628, new byte[6] { 100, 123, 75, 57, 75, 80 });
			baseStats.Add(629, new byte[6] { 70, 55, 75, 45, 65, 60 });
			baseStats.Add(630, new byte[6] { 110, 65, 105, 55, 95, 80 });
			baseStats.Add(631, new byte[6] { 85, 97, 66, 105, 66, 65 });
			baseStats.Add(632, new byte[6] { 58, 109, 112, 48, 48, 109 });
			baseStats.Add(633, new byte[6] { 52, 65, 50, 45, 50, 38 });
			baseStats.Add(634, new byte[6] { 72, 85, 70, 65, 70, 58 });
			baseStats.Add(635, new byte[6] { 92, 105, 90, 125, 90, 98 });
			baseStats.Add(636, new byte[6] { 55, 85, 55, 50, 55, 60 });
			baseStats.Add(637, new byte[6] { 85, 60, 65, 135, 105, 100 });
			baseStats.Add(638, new byte[6] { 91, 90, 129, 90, 72, 108 });
			baseStats.Add(639, new byte[6] { 91, 129, 90, 72, 90, 108 });
			baseStats.Add(640, new byte[6] { 91, 90, 72, 90, 129, 108 });
			baseStats.Add(641, new byte[6] { 79, 115, 70, 125, 80, 111 });
			baseStats.Add(642, new byte[6] { 79, 115, 70, 125, 80, 111 });
			baseStats.Add(643, new byte[6] { 100, 120, 100, 150, 120, 90 });
			baseStats.Add(644, new byte[6] { 100, 150, 120, 120, 100, 90 });
			baseStats.Add(645, new byte[6] { 89, 125, 90, 115, 80, 101 });
			baseStats.Add(646, new byte[6] { 125, 130, 90, 130, 90, 95 });
			baseStats.Add(647, new byte[6] { 91, 72, 90, 129, 90, 108 });
			baseStats.Add(648, new byte[6] { 100, 77, 77, 128, 128, 90 });
			baseStats.Add(649, new byte[6] { 71, 120, 95, 120, 95, 99 });
			baseStats.Add(650, new byte[6] { 56, 61, 65, 48, 45, 38 });
			baseStats.Add(651, new byte[6] { 61, 78, 95, 56, 58, 57 });
			baseStats.Add(652, new byte[6] { 88, 107, 122, 74, 75, 64 });
			baseStats.Add(653, new byte[6] { 40, 45, 40, 62, 60, 60 });
			baseStats.Add(654, new byte[6] { 59, 59, 58, 90, 70, 73 });
			baseStats.Add(655, new byte[6] { 75, 69, 72, 114, 100, 104 });
			baseStats.Add(656, new byte[6] { 41, 56, 40, 62, 44, 71 });
			baseStats.Add(657, new byte[6] { 54, 63, 52, 83, 56, 97 });
			baseStats.Add(658, new byte[6] { 72, 95, 67, 103, 71, 122 });
			baseStats.Add(659, new byte[6] { 38, 36, 38, 32, 36, 57 });
			baseStats.Add(660, new byte[6] { 85, 56, 77, 50, 77, 78 });
			baseStats.Add(661, new byte[6] { 45, 50, 43, 40, 38, 62 });
			baseStats.Add(662, new byte[6] { 62, 73, 55, 56, 52, 84 });
			baseStats.Add(663, new byte[6] { 78, 81, 71, 74, 69, 126 });
			baseStats.Add(664, new byte[6] { 38, 35, 40, 27, 25, 35 });
			baseStats.Add(665, new byte[6] { 45, 22, 60, 27, 30, 29 });
			baseStats.Add(666, new byte[6] { 80, 52, 50, 90, 50, 89 });
			baseStats.Add(667, new byte[6] { 62, 50, 58, 73, 54, 72 });
			baseStats.Add(668, new byte[6] { 86, 68, 72, 109, 66, 106 });
			baseStats.Add(669, new byte[6] { 44, 38, 39, 61, 79, 42 });
			baseStats.Add(670, new byte[6] { 54, 45, 47, 75, 98, 52 });
			baseStats.Add(671, new byte[6] { 78, 65, 68, 112, 154, 75 });
			baseStats.Add(672, new byte[6] { 66, 65, 48, 62, 57, 52 });
			baseStats.Add(673, new byte[6] { 123, 100, 62, 97, 81, 68 });
			baseStats.Add(674, new byte[6] { 67, 82, 62, 46, 48, 43 });
			baseStats.Add(675, new byte[6] { 95, 124, 78, 69, 71, 58 });
			baseStats.Add(676, new byte[6] { 75, 80, 60, 65, 90, 102 });
			baseStats.Add(677, new byte[6] { 62, 48, 54, 63, 60, 68 });
			baseStats.Add(678, new byte[6] { 74, 48, 76, 83, 81, 104 });
			baseStats.Add(679, new byte[6] { 45, 80, 100, 35, 37, 28 });
			baseStats.Add(680, new byte[6] { 59, 110, 150, 45, 49, 35 });
			baseStats.Add(681, new byte[6] { 60, 50, 150, 50, 150, 60 });
			baseStats.Add(682, new byte[6] { 78, 52, 60, 63, 65, 23 });
			baseStats.Add(683, new byte[6] { 101, 72, 72, 99, 89, 29 });
			baseStats.Add(684, new byte[6] { 62, 48, 66, 59, 57, 49 });
			baseStats.Add(685, new byte[6] { 82, 80, 86, 85, 75, 72 });
			baseStats.Add(686, new byte[6] { 53, 54, 53, 37, 46, 45 });
			baseStats.Add(687, new byte[6] { 86, 92, 88, 68, 75, 73 });
			baseStats.Add(688, new byte[6] { 42, 52, 67, 39, 56, 50 });
			baseStats.Add(689, new byte[6] { 72, 92, 115, 54, 86, 68 });
			baseStats.Add(690, new byte[6] { 50, 60, 60, 60, 60, 30 });
			baseStats.Add(691, new byte[6] { 65, 75, 90, 97, 123, 44 });
			baseStats.Add(692, new byte[6] { 50, 53, 62, 58, 63, 44 });
			baseStats.Add(693, new byte[6] { 71, 73, 88, 120, 89, 59 });
			baseStats.Add(694, new byte[6] { 44, 38, 33, 61, 43, 70 });
			baseStats.Add(695, new byte[6] { 62, 55, 52, 109, 94, 109 });
			baseStats.Add(696, new byte[6] { 58, 89, 77, 45, 45, 48 });
			baseStats.Add(697, new byte[6] { 82, 121, 119, 69, 59, 71 });
			baseStats.Add(698, new byte[6] { 77, 59, 50, 67, 63, 46 });
			baseStats.Add(699, new byte[6] { 123, 77, 72, 99, 92, 58 });
			baseStats.Add(700, new byte[6] { 95, 65, 65, 110, 130, 60 });
			baseStats.Add(701, new byte[6] { 78, 92, 75, 74, 63, 118 });
			baseStats.Add(702, new byte[6] { 67, 58, 57, 81, 67, 101 });
			baseStats.Add(703, new byte[6] { 50, 50, 150, 50, 150, 50 });
			baseStats.Add(704, new byte[6] { 45, 50, 35, 55, 75, 40 });
			baseStats.Add(705, new byte[6] { 68, 75, 53, 83, 113, 60 });
			baseStats.Add(706, new byte[6] { 90, 100, 70, 110, 150, 80 });
			baseStats.Add(707, new byte[6] { 57, 80, 91, 80, 87, 75 });
			baseStats.Add(708, new byte[6] { 43, 70, 48, 50, 60, 38 });
			baseStats.Add(709, new byte[6] { 85, 110, 76, 65, 82, 56 });
			baseStats.Add(710, new byte[6] { 49, 66, 70, 44, 55, 51 });
			baseStats.Add(711, new byte[6] { 65, 90, 122, 58, 75, 84 });
			baseStats.Add(712, new byte[6] { 55, 69, 85, 32, 35, 28 });
			baseStats.Add(713, new byte[6] { 95, 117, 184, 44, 46, 28 });
			baseStats.Add(714, new byte[6] { 40, 30, 35, 45, 40, 55 });
			baseStats.Add(715, new byte[6] { 85, 70, 80, 97, 80, 123 });
			baseStats.Add(716, new byte[6] { 126, 131, 95, 131, 98, 99 });
			baseStats.Add(717, new byte[6] { 126, 131, 95, 131, 98, 99 });
			baseStats.Add(718, new byte[6] { 108, 100, 121, 81, 95, 95 });
			Dictionary<int, byte[]> dictionary2 = baseStats;
			byte[] value2 = new byte[6];
			dictionary2.Add(719, value2);
			Dictionary<int, byte[]> dictionary3 = baseStats;
			byte[] value3 = new byte[6];
			dictionary3.Add(720, value3);
			Dictionary<int, byte[]> dictionary4 = baseStats;
			byte[] value4 = new byte[6];
			dictionary4.Add(721, value4);
			dictionariesInitialized = true;
		}
	}

	public static uint maxExp(string s)
	{
		ushort num = (ushort)species.IndexOf(s);
		uint result = 0u;
		switch (expList[num])
		{
		case 0:
			result = slowlist[99];
			break;
		case 1:
			result = mediumSlowList[99];
			break;
		case 2:
			result = mediumFastList[99];
			break;
		case 3:
			result = fastlist[99];
			break;
		case 4:
			result = fluctuatinglist[99];
			break;
		case 5:
			result = erraticlist[99];
			break;
		}
		return result;
	}

	public static byte calculateLevel(string s, uint exp)
	{
		ushort num = (ushort)species.IndexOf(s);
		byte b = 0;
		int i = 0;
		switch (expList[num])
		{
		case 0:
			for (; i < 100; i++)
			{
				if (exp < slowlist[b])
				{
					break;
				}
				b = (byte)(b + 1);
				if (b >= 100)
				{
					b = 100;
				}
			}
			return b;
		case 1:
			for (; i < 100; i++)
			{
				if (exp < mediumSlowList[b])
				{
					break;
				}
				b = (byte)(b + 1);
				if (b >= 100)
				{
					b = 100;
				}
			}
			return b;
		case 2:
			for (; i < 100; i++)
			{
				if (exp < mediumFastList[b])
				{
					break;
				}
				b = (byte)(b + 1);
				if (b >= 100)
				{
					b = 100;
				}
			}
			return b;
		case 3:
			for (; i < 100; i++)
			{
				if (exp < fastlist[b])
				{
					break;
				}
				b = (byte)(b + 1);
				if (b >= 100)
				{
					b = 100;
				}
			}
			return b;
		case 4:
			for (; i < 100; i++)
			{
				if (exp < fluctuatinglist[b])
				{
					break;
				}
				b = (byte)(b + 1);
				if (b >= 100)
				{
					b = 100;
				}
			}
			return b;
		case 5:
			for (; i < 100; i++)
			{
				if (exp < erraticlist[b])
				{
					break;
				}
				b = (byte)(b + 1);
				if (b >= 100)
				{
					b = 100;
				}
			}
			return b;
		default:
			return 1;
		}
	}

	public static uint calculateExp(string s, byte level)
	{
		ushort num = (ushort)species.IndexOf(s);
		uint result = 0u;
		if (level > 100)
		{
			level = 100;
		}
		switch (expList[num])
		{
		case 0:
			result = slowlist[level - 1];
			break;
		case 1:
			result = mediumSlowList[level - 1];
			break;
		case 2:
			result = mediumFastList[level - 1];
			break;
		case 3:
			result = fastlist[level - 1];
			break;
		case 4:
			result = fluctuatinglist[level - 1];
			break;
		case 5:
			result = erraticlist[level - 1];
			break;
		}
		return result;
	}
}
