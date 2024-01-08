namespace WangPluginSav.Util.Pikaedit
{
	public class MoveSet
	{
		public Move move1;

		public Move move2;

		public Move move3;

		public Move move4;

		public MoveSet()
		{
			move1 = new Move();
			move2 = new Move();
			move3 = new Move();
			move4 = new Move();
		}

		public MoveSet(Move move1, Move move2, Move move3, Move move4)
		{
			this.move1 = move1;
			this.move2 = move2;
			this.move3 = move3;
			this.move4 = move4;
		}

		public bool isEmpty()
		{
			if (move1.move == 0 && move2.move == 0 && move3.move == 0)
			{
				return move4.move == 0;
			}
			return false;
		}
	}
}
