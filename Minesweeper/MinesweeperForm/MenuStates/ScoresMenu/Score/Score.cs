using System;

namespace Minesweeper.MinesweeperForm.MenuStates.ScoresMenu.Scores
{
	internal class Score
	{
		public Score(string name, int boardSizeID, TimeSpan timeTaken)
		{
			Name = name;
			BoardSizeID = boardSizeID;
			TimeTaken = timeTaken;
		}

		public string Name { get; }
		public int BoardSizeID { get; }
		public TimeSpan TimeTaken { get; }//0-3, (small, medium, large, huge)
	}
}
