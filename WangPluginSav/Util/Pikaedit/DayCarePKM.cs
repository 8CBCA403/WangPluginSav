namespace WangPluginSav.Util.Pikaedit;

public class DayCarePKM
{
    public Pokemon[] pkmdata = new Pokemon[2];

    public bool hasEgg;

    public DayCarePKM()
    {
        pkmdata[0] = new Pokemon();
        pkmdata[1] = new Pokemon();
        hasEgg = false;
    }

    public DayCarePKM(Pokemon[] pkmdata, bool hasEgg = false)
    {
        this.pkmdata = pkmdata;
        this.hasEgg = hasEgg;
    }

    public DayCarePKM(Pokemon pkm1, Pokemon pkm2, bool hasEgg = false)
    {
        pkmdata[0] = pkm1;
        pkmdata[1] = pkm2;
        this.hasEgg = hasEgg;
    }

    public DayCarePKM(Pokemon pkm1, Pokemon pkm2, byte hasEgg = 0)
    {
        pkmdata[0] = pkm1;
        pkmdata[1] = pkm2;
        this.hasEgg = hasEgg == 1;
    }

    public byte getCount()
    {
        byte b = 0;
        for (int i = 0; i < 2; i++)
        {
            if (pkmdata[i] != null && !pkmdata[i].isEmpty)
            {
                b = (byte)(b + 1);
            }
        }
        return b;
    }

    public byte getEggByte()
    {
        if (!hasEgg)
        {
            return 0;
        }
        return 1;
    }
}
