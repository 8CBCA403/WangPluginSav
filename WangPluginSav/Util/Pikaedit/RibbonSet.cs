namespace WangPluginSav.Util.Pikaedit
{
	public class RibbonSet
	{
		public ushort data;

		public RibbonSet()
		{
		}

		public RibbonSet(ushort data)
		{
			this.data = data;
		}

		public void setChanges(bool[] flags)
		{
			ushort[] array = new ushort[flags.Length];
			for (int i = 0; i < flags.Length; i++)
			{
				array[i] = (ushort)(flags[i] ? 1 : 0);
			}
			for (int j = 0; j < flags.Length; j++)
			{
				data = (ushort)(data | (array[j] << j));
			}
		}

		public bool[] getFlags()
		{
			bool[] array = new bool[16];
			for (int i = 0; i < 16; i++)
			{
				array[i] = ((data >> i) & 1) == 1;
			}
			return array;
		}
	}
}
