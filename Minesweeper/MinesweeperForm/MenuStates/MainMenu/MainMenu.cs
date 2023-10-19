using Minesweeper.MinesweeperForm.MenuStates.Game;
using System;
using System.Windows.Forms;
using Minesweeper.MinesweeperForm.MenuStates.Interfaces;

namespace Minesweeper.MinesweeperForm.MenuStates.Menus
{
	public partial class Menu : UserControl, IViewChange
	{
		public Menu()
		{
			InitializeComponent();
			boardSizeComboBox.SelectedIndex = 1;
		}

		public UserControl ReplacementUserControl;

		private void playButton_Click(object sender, EventArgs e)
		{
			ReplacementUserControl = new GameView(boardSizeComboBox.SelectedIndex);
			OnViewChanged(this, EventArgs.Empty);
		}

		public event EventHandler OnViewChanged = delegate { };

		private void scoresButton_Click(object sender, EventArgs e)
		{
			ReplacementUserControl = new Scores();
			OnViewChanged(this, EventArgs.Empty);
		}
	}
}
