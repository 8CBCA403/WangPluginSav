namespace PKHeX;

public class Converter
{
	internal static int Country = 31;

	internal static int Region = 7;

	internal static int ConsoleRegion = 1;

	internal static string OT_Name = "PKHeX";

	internal static int OT_Gender;

	internal static void updateConfig(int SUBREGION, int COUNTRY, int _3DSREGION, string TRAINERNAME, int TRAINERGENDER)
	{
		Region = SUBREGION;
		Country = COUNTRY;
		ConsoleRegion = _3DSREGION;
		OT_Name = TRAINERNAME;
		OT_Gender = TRAINERGENDER;
	}
}
