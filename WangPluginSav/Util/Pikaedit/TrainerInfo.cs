namespace WangPluginSav.Util.Pikaedit;

public class TrainerInfo
{
    public enum TrainerGender
    {
        Male,
        Female
    }

    public readonly int NAMEMAXLENGTH = 7;

    public string name;

    public ushort id;

    public ushort sid;

    public uint money;

    public TrainerGender gender;

    public byte badges;

    public ushort playHours;

    public byte playMin;

    public byte playSec;

    public TrainerInfo()
    {
        name = "";
        id = 1;
        sid = 0;
        money = 0u;
        gender = TrainerGender.Male;
        badges = 0;
    }

    public TrainerInfo(string name, ushort id, ushort sid, uint money, byte gender, byte badges, ushort playHours, byte playMin, byte playSec)
    {
        this.name = name;
        this.id = id;
        this.sid = sid;
        this.money = money;
        this.gender = gender != 0 ? TrainerGender.Female : TrainerGender.Male;
        this.badges = badges;
        this.playHours = playHours;
        this.playMin = playMin;
        this.playSec = playSec;
    }

    public byte[] getName()
    {
        return Func.getfromString(name, NAMEMAXLENGTH);
    }

    public byte getGenderByte()
    {
        if (gender == TrainerGender.Male)
        {
            return 0;
        }
        return 1;
    }

    public bool[] getBadgesObtained()
    {
        return new bool[8]
        {
            (badges & 1) == 1,
            (badges >> 1 & 1) == 1,
            (badges >> 2 & 1) == 1,
            (badges >> 3 & 1) == 1,
            (badges >> 4 & 1) == 1,
            (badges >> 5 & 1) == 1,
            (badges >> 6 & 1) == 1,
            (badges >> 7 & 1) == 1
        };
    }

    public int badgeCount()
    {
        int num = 0;
        bool[] badgesObtained = getBadgesObtained();
        for (int i = 0; i < 8; i++)
        {
            if (badgesObtained[i])
            {
                num++;
            }
        }
        return num;
    }

    public void setBadges(bool[] b)
    {
        badges = 0;
        byte[] array = new byte[b.Length];
        for (int i = 0; i < b.Length; i++)
        {
            array[i] = (byte)(b[i] ? 1 : 0);
        }
        for (int j = 0; j < 8; j++)
        {
            badges = (byte)(badges | array[j] << j);
        }
    }
}
