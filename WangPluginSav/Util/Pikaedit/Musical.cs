namespace WangPluginSav.Util.Pikaedit;

public class Musical
{
    public byte[] data;

    public bool active;

    public string title;

    public readonly uint MAXLENGTHBW = 130048u;

    public readonly uint MAXLENGTHBW2 = 97280u;

    public Musical()
    {
    }

    public Musical(byte[] data, SaveFile.Version version, bool active = false)
    {
        this.data = data;
        if (active)
        {
            this.active = !isEmpty();
        }
        else
        {
            this.active = active;
        }
        adjustData(version);
        title = extractTitle(version);
    }

    public bool isEmpty()
    {
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] != byte.MaxValue)
            {
                return false;
            }
        }
        return true;
    }

    public string extractTitle(SaveFile.Version version)
    {
        if (data.Length > MAXLENGTHBW2)
        {
            if (data.Length < 97556)
            {
                return "";
            }
            return Func.getString(Func.subArray(data, 97556, 76), 0, 38);
        }
        if (data.Length < 130324)
        {
            return "";
        }
        return Func.getString(Func.subArray(data, 130324, 76), 0, 38);
    }

    public byte[] getData(SaveFile.Version version)
    {
        if (version == SaveFile.Version.BW2)
        {
            return Func.subArray(data, 0, (int)MAXLENGTHBW2);
        }
        return Func.subArray(data, 0, (int)MAXLENGTHBW);
    }

    public void adjustData(SaveFile.Version version)
    {
        if (version == SaveFile.Version.BW && getData(version).Length == MAXLENGTHBW2)
        {
            byte[] array = new byte[97656];
            Array.Copy(getData(version), 0, array, 0, getData(version).Length);
            for (int i = getData(version).Length; i < (int)MAXLENGTHBW; i++)
            {
                array[i] = 0;
            }
            Array.Copy(data, (int)MAXLENGTHBW2, array, (int)MAXLENGTHBW, 376);
            data = array;
        }
    }
}
