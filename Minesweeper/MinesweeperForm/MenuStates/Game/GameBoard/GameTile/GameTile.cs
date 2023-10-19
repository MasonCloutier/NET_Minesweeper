using Minesweeper.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper.MinesweeperForm.MenuStates.Game
{
	public partial class GameTile : UserControl
	{
		public GameTile(int tileX, int tileY, int revealStateID)
		{
			InitializeComponent();

			if(revealStateID < 0 || revealStateID > 9)
			{
				throw new ArgumentOutOfRangeException("revealStateID must be an int between 0 and 9 inclusive.");
			}
			this.revealStateID = revealStateID;
			this.tileX = tileX;
			this.tileY = tileY;
		}
		//Probably shouldn't be public but whatever
		public bool clickEnabled = true;

		public int tileX;
		public int tileY;

		//0 = Empty
		//1-8 = Number to reveal
		//9 = MINE
		private int revealStateID;

		private enum TILE_STATE
		{
			HIDDEN,
			FLAGGED,
			REVEALED
		}

		private TILE_STATE currentState = TILE_STATE.HIDDEN;


		private void GameTile_MouseDown(object sender, MouseEventArgs e)
		{
			if(clickEnabled)
			{
				if (e.Button == MouseButtons.Left)
				{
					if (currentState == TILE_STATE.HIDDEN)
					{
                        //TODO add hook for board logic
                        OnTileRevealed(this, new EventArgs());
                    }
				}
				else if (e.Button == MouseButtons.Right)
				{

					if (currentState == TILE_STATE.HIDDEN)
					{
						currentState = TILE_STATE.FLAGGED;
						BackgroundImage = Resources.Flag;

					}
					else if (currentState == TILE_STATE.FLAGGED)
					{
						currentState = TILE_STATE.HIDDEN;
						BackgroundImage = Resources.Tile;
					}
				}
			}
		}

		public bool isEmpty()
		{
			return revealStateID == 0;
		}

        public bool isRevealed()
        {
            return currentState == TILE_STATE.REVEALED;
        }

        public void Reveal()
		{
			currentState = TILE_STATE.REVEALED;
			ShowRevealImage();

			if (revealStateID == 9)
			{
				//THIS IS A MINE
				OnMineClicked(this, new EventArgs());
				return;
			}
		}

        public event EventHandler OnTileRevealed = delegate { };

		public event EventHandler OnMineClicked = delegate { };

		private void ShowRevealImage()
		{
			Bitmap[] revealImages = { Resources.Empty, Resources.One, Resources.Two, Resources.Three, 
				Resources.Four, Resources.Five, Resources.Six, Resources.Seven, Resources.Eight, Resources.Mine};

			BackgroundImage = revealImages[revealStateID];
		}
	}
}
