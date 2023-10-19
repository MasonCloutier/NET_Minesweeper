using Minesweeper.MinesweeperForm.MenuStates.Interfaces;
using Minesweeper.MinesweeperForm.MenuStates.ScoresMenu.Scores;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Minesweeper.MinesweeperForm.MenuStates.Game
{
	public partial class Scores : UserControl, IViewChange
	{
		public Scores()
		{
			InitializeComponent();
			displayScores();
		}

		private void displayScores()
		{
			string[] boardSizes = { "Small", "Medium", "Large", "Huge" };

			//Read from the database, display each score
			BindingList<Score> retrievedScores = ScoresMenu.ScoreDatabase.ScoreDatabaseTools.GetScoresFromDatabase();

			for (int currentScore = 0; currentScore < retrievedScores.Count(); currentScore++)
			{
				Score score = retrievedScores[currentScore];

				ListViewItem scoreItem = new ListViewItem(score.Name);
				scoreItem.SubItems.Add(boardSizes[score.BoardSizeID]);
				scoreItem.SubItems.Add(score.TimeTaken.ToString(@"mm\:ss"));

				scoresListView.Items.Add(scoreItem);
			}
		}

		public UserControl ReplacementUserControl;

		private void backButton_Click(object sender, EventArgs e)
		{
			ReplacementUserControl = new Menus.Menu();//I really hate the auto generated namespaces
			OnViewChanged(this, EventArgs.Empty);
		}

		public event EventHandler OnViewChanged = delegate { };

		private void resetButton_Click(object sender, EventArgs e)
		{
            //Do reset stuff
            ScoresMenu.ScoreDatabase.ScoreDatabaseTools.clearDatabase();
            scoresListView.Items.Clear();
        }
	}
}
