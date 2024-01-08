namespace WangPluginSav.Util.Pikaedit
{
	public class IVSet
	{
		public byte hp;

		public byte atk;

		public byte def;

		public byte spa;

		public byte spd;

		public byte spe;

		public bool isEgg;

		public bool isNick;

		public IVSet()
		{
		}

		public IVSet(uint iv)
		{
			hp = (byte)(iv & 0x1Fu);
			atk = (byte)((iv >> 5) & 0x1Fu);
			def = (byte)((iv >> 10) & 0x1Fu);
			spe = (byte)((iv >> 15) & 0x1Fu);
			spa = (byte)((iv >> 20) & 0x1Fu);
			spd = (byte)((iv >> 25) & 0x1Fu);
			isEgg = ((iv >> 30) & 1) == 1;
			isNick = ((iv >> 31) & 1) == 1;
		}

		public IVSet(byte hp, byte atk, byte def, byte spa, byte spd, byte spe, bool isEgg = false, bool isNick = false)
		{
			this.hp = hp;
			this.atk = atk;
			this.def = def;
			this.spa = spa;
			this.spd = spd;
			this.spe = spe;
			this.isEgg = isEgg;
			this.isNick = isNick;
		}

		public uint getIV()
		{
			return (isNick ? 2147483648u : 0u) | (isEgg ? 1073741824u : 0u) | (uint)(spd << 25) | (uint)(spa << 20) | (uint)(spe << 15) | (uint)(def << 10) | (uint)(atk << 5) | hp;
		}
	}
}
