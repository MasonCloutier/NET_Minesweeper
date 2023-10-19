using Minesweeper.MinesweeperForm.MenuStates.Game.WinForms;
using Minesweeper.MinesweeperForm.MenuStates.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper.MinesweeperForm.MenuStates.Game
{
	public partial class GameView : UserControl, IViewChange
	{
		public UserControl ReplacementUserControl;

		private GameBoard gameBoard;
		private const int BOARD_BOTTOM_OFFSET = -50;

		private int boardWidthTiles;
		private int boardHeightTiles;
		private int boardSizeID;

		private TimeSpan gameTimeTaken = new TimeSpan();

		public GameView(int boardSizeID)
		{
			InitializeComponent();

			/*
			 *  Small  - (8x7)
			 *  Medium - (12x10)
			 *  Large  - (18x14)
			 *  Huge   - (20x18)
			 */

			switch (boardSizeID)
			{
				case 0:
				boardWidthTiles = 8;
				boardHeightTiles = 7;
				break;
			case 1:
				boardWidthTiles = 12;
				boardHeightTiles = 10;
				break;
			case 2:
				boardWidthTiles = 18;
				boardHeightTiles = 14;
				break;
			case 3:
				boardWidthTiles = 20;
				boardHeightTiles = 18;
				break;
			default:
				throw new ArgumentException("Invalid board size!");
			}
			this.boardSizeID = boardSizeID;

			makeGameBoard();
		}

		private void makeGameBoard()
		{
			Controls.Remove(gameBoard);

			gameBoard = new GameBoard(boardWidthTiles, boardHeightTiles);
			gameBoard.OnGameLost += HandleGameLost;
			gameBoard.OnGameWon += HandleGameWon;

			//only add the offset if the board isn't "huge"
			if (boardSizeID == 3)
			{
				gameBoard.Location = new Point((Width - gameBoard.Width) / 2, Height - gameBoard.Height);
			}
			else
			{
				gameBoard.Location = new Point((Width - gameBoard.Width) / 2, Height - gameBoard.Height + BOARD_BOTTOM_OFFSET);
			}

			Controls.Add(gameBoard);
			gameTimer.Enabled = true;
			timeLabel.Text = gameTimeTaken.ToString(@"mm\:ss");
		}

		private void HandleGameLost(object sender, EventArgs eventArgs)
		{
			//Finally do game lost stuff
			//Disable the board from being clickable
			gameBoard.Disable();
			gameTimer.Enabled = false;

			lossLabel.Show();

			retryButton.Text = "Retry";
			retryButton.Show();
		}

		private void HandleGameWon(object sender, EventArgs eventArgs)
		{
			//Finally do game win stuff
			//Disable the board from being clickable
			Console.WriteLine("You won!");

			gameTimer.Enabled = false;
			gameBoard.Disable();

			winLabel.Show();
			retryButton.Text = "Play again";
			retryButton.Show();

			//Show win form
			WinForm winForm = new WinForm(boardSizeID, gameTimeTaken);
			winForm.ShowDialog();
		}

		public event EventHandler OnViewChanged = delegate { };

		private void backButton_Click(object sender, EventArgs e)
		{
			ReplacementUserControl = new Menus.Menu();

			gameTimer.Enabled = false;

			OnViewChanged(this, EventArgs.Empty);
		}

		private void retryButton_Click(object sender, EventArgs e)
		{
			//throw the current board in the trash and get a new one
			makeGameBoard();

			lossLabel.Hide();
			retryButton.Hide();
			winLabel.Hide();

			gameTimeTaken = new TimeSpan();
			timeLabel.Text = gameTimeTaken.ToString(@"mm\:ss");
		}

		private void gameTimer_Tick(object sender, EventArgs e)
		{
			gameTimeTaken = gameTimeTaken.Add(TimeSpan.FromSeconds(1));
            timeLabel.Text = gameTimeTaken.ToString(@"mm\:ss");
		}
	}
}
