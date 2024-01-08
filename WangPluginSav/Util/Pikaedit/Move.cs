namespace WangPluginSav.Util.Pikaedit
{
	public class Move
	{
		public ushort move;

		public byte pp;

		public byte ppUp;

		public Move()
		{
			move = 0;
			pp = 0;
			ppUp = 0;
		}

		public Move(ushort move, byte pp, byte ppUp)
		{
			this.move = move;
			this.pp = pp;
			this.ppUp = ppUp;
		}

		public Move(string move, byte pp, byte ppUp)
		{
			if (PkmLib.moves.IndexOf(move) < PkmLib.moves.Count)
			{
				this.move = (ushort)PkmLib.moves.IndexOf(move);
			}
			else
			{
				this.move = 0;
			}
			this.pp = pp;
			this.ppUp = ppUp;
		}
	}
}
