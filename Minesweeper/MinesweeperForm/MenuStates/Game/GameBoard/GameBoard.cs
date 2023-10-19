using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper.MinesweeperForm.MenuStates.Game
{
	public partial class GameBoard : UserControl
	{
		public GameBoard(int widthTiles, int heightTiles)
		{
			InitializeComponent();

			this.heightTiles = heightTiles;
			this.widthTiles = widthTiles;
			tiles = new int[widthTiles, heightTiles];

			//Set the size of the control based on how many tiles it has
			Width = widthTiles * TILE_SIZE;
			Height = heightTiles * TILE_SIZE;

			//Set up the tiles array
			fillTilesWithZeros();
			addMines();

			//now that the mine amount has been calculated, set the amount of tiles left to win
			//FIXME this may or may not end up off-by-one sometimes, I'm not sure :/
			tilesLeft = (widthTiles * heightTiles) - mineAmount;
            //Generate GameTile user controls for each tile
            generateGameTiles();

		}

		const int TILE_SIZE = 32;

		private Random coordRandomness = new Random();
		private int heightTiles;
		private int widthTiles;
		private int mineAmount;
		private int[,] tiles;//contains the revealed values of every tile
		private GameTile[,] gameTiles;
		private int tilesLeft;

		//private bool Enabled = true;//Allows clicking on the board

		private void fillTilesWithZeros()//shut up, it's good naming i swear
		{
			for (int currentRow = 0; currentRow < heightTiles; currentRow++)
			{
				for (int currentColumn = 0; currentColumn < widthTiles; currentColumn++)
				{
					tiles[currentColumn, currentRow] = 0;
				}
			}
		}

		private void addMines()
		{
			mineAmount = (int)Math.Floor((this.heightTiles * this.widthTiles) / 6.0);

			//"Dart throw" randomness - Pick a random point then put a mine there.
			//Very slow when there's more mines than empty tiles but in this case it stays relatively fast.
			//I guess you could also keep a list of empty tiles but that seems hard.
			int mineCount = mineAmount;
			while(mineCount > 0)
			{
				//get random point
				int randomX = getRandomIntInclusive(0, widthTiles - 1);
				int randomY = getRandomIntInclusive(0, heightTiles - 1);

				//if the point isn't already a mine, make it one, otherwise try again
				if(tiles[randomX, randomY] != 9)
				{
					tiles[randomX, randomY] = 9;
					mineCount--;
					//Increment the tiles around the mine
					incrementSurroundingTiles(randomX, randomY);
				}
			}
		}

		private void incrementSurroundingTiles(int tileX, int tileY)
		{
			//Do two `for` loops to increment the eight tiles around the mine
			//Start from the upper left, finish on bottom right
			for (int currentRow = tileY - 1; currentRow <= tileY + 1; currentRow++)
			{
				for (int currentColumn = tileX - 1; currentColumn <= tileX + 1; currentColumn++)
				{
					//Check that the tile is in bounds
					if (!(currentColumn < 0 || currentColumn >= widthTiles || currentRow < 0 || currentRow >= heightTiles))
					{
						//Only increment if the tile isn't a mine
						//It also works out that this skips incrementing on the center tile
						if (tiles[currentColumn, currentRow] != 9)
						{
							tiles[currentColumn, currentRow]++;
						}
					}
				}
			}
		}

        private void generateGameTiles()
		{
			gameTiles = new GameTile[widthTiles, heightTiles];

			for (int currentRow = 0; currentRow < heightTiles; currentRow++)
			{
				for (int currentColumn = 0; currentColumn < widthTiles; currentColumn++)
				{
					//Make a new gameTile user control with the corresponding reveal value
					gameTiles[currentColumn, currentRow] = new GameTile(currentColumn, currentRow, tiles[currentColumn, currentRow]);
					//Subscribe to the tile's events
					gameTiles[currentColumn, currentRow].OnMineClicked += HandleMineClicked;
					gameTiles[currentColumn, currentRow].OnTileRevealed += HandleTileRevealed;	

					//Generation boilerplate
					gameTiles[currentColumn, currentRow].Size = new Size(TILE_SIZE, TILE_SIZE);
					gameTiles[currentColumn, currentRow].Location = new Point(TILE_SIZE * currentColumn, TILE_SIZE * currentRow);

					Controls.Add(gameTiles[currentColumn, currentRow]);
				}
			}
		}

		//Pass the event up to the GameView
		private void HandleMineClicked(object sender, EventArgs eventArgs)
		{
			OnGameLost(sender, EventArgs.Empty);
		}

		private void HandleTileRevealed(object sender, EventArgs eventArgs)
		{
			if(sender is GameTile currentTile)
			{
				if(currentTile.isEmpty())
				{
                    revealSurrondingTiles(currentTile.tileX, currentTile.tileY);
				} else
				{
					tilesLeft -= 1;
				}
 
                gameTiles[currentTile.tileX, currentTile.tileY].Reveal();

				//big HACK - this should be `if (tilesLeft == 0)` but i want this to work now
				//brute force to check for a winstate when most tiles are revealed
				if (tilesLeft < 5)
				{
                    int revealedAmount = 0;

                    for (int currentRow = 0; currentRow < heightTiles; currentRow++)
                    {
                        for (int currentColumn = 0; currentColumn < widthTiles; currentColumn++)
                        {
							if (gameTiles[currentColumn, currentRow].isRevealed())
							{
								revealedAmount++;
							}
                        }
                    }

                    if (revealedAmount == (widthTiles * heightTiles) - mineAmount)
					{
                        //Only the unrevealed mines are left on the board
                        OnGameWon(sender, EventArgs.Empty);
                    }
				}
			}
		}

		private void revealSurrondingTiles(int tileX, int tileY)
		{
            //reveal the 8 surrounding tiles in a recursive floodfill
			//floodfill is a pain but also really cool

            //only reveal tiles in valid positions
            for (int currentRow = tileY - 1; currentRow <= tileY + 1; currentRow++)
            {
                for (int currentColumn = tileX - 1; currentColumn <= tileX + 1; currentColumn++)
                {
                    //Check that the tile is in bounds
                    if (!(currentColumn < 0 || currentColumn >= widthTiles || currentRow < 0 || currentRow >= heightTiles))
                    {
                        if ((currentRow == tileY && currentColumn == tileX) || gameTiles[currentColumn, currentRow].isRevealed())
                        {
                            //Don't make an infinite loop
                            continue;
                        }

						tilesLeft--;

						if (!gameTiles[currentColumn, currentRow].isEmpty())
						{
							//a number was revealed, don't reveal surrounding tiles
                            gameTiles[currentColumn, currentRow].Reveal();
							continue;
                        }

                        gameTiles[currentColumn, currentRow].Reveal();
						revealSurrondingTiles(currentColumn, currentRow);
                    }
                }
            }
        }

        //Prevent the tiles from being clickable
        public void Disable()
		{
			//Remove the eventHandlers from each tile
			for (int currentRow = 0; currentRow < heightTiles; currentRow++)
			{
				for (int currentColumn = 0; currentColumn < widthTiles; currentColumn++)
				{
					gameTiles[currentColumn, currentRow].clickEnabled = false;
				}
			}
		}

		public event EventHandler OnGameLost = delegate { };
		public event EventHandler OnGameWon = delegate { };

		private int getRandomIntInclusive(int min, int max)
		{
			//I guess I assumed that this would be more difficult
			return coordRandomness.Next(min, max + 1);
		}
	}
}
