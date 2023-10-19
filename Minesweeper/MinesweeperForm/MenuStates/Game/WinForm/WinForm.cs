using System;
using System.Windows.Forms;

namespace Minesweeper.MinesweeperForm.MenuStates.Game.WinForms
{
	public partial class WinForm : Form
	{
		public WinForm(int boardSizeID, TimeSpan timeTaken)
		{
			//Definitly could've picked a better name for this one
			InitializeComponent();

			sizeDisplayLabel.Text = boardSizes[boardSizeID];
			timeDisplayLabel.Text = timeTaken.ToString(@"mm\:ss");

			this.boardSizeID = boardSizeID;
			this.timeTaken = timeTaken;
		}

		private string name;
		private int boardSizeID;
		private TimeSpan timeTaken;

		private string[] boardSizes = { "Small", "Medium", "Large", "Huge" };

		private void submitButton_Click(object sender, EventArgs e)
		{
			name = nameTextBox.Text;

            ScoresMenu.ScoreDatabase.ScoreDatabaseTools.addScoreToDatabase(name, boardSizeID, timeTaken);

			Close();
		}

		private void nameTextBox_TextChanged(object sender, EventArgs e)
		{
			//caught this bug just before submitting (nameTextBox.Text != "")
			if (!(String.IsNullOrWhiteSpace(nameTextBox.Text)))
			{
				//limit length to 20 characters
				if(nameTextBox.Text.Length == 20)
				{
					nameTextBox.Text = nameTextBox.Text.Substring(0, 19);
				}
				submitButton.Show();
			}
			else
			{
				submitButton.Hide();
			}
		}
	}
}
