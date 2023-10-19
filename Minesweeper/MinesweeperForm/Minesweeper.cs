using Minesweeper.MinesweeperForm.MenuStates.Game;
using Minesweeper.MinesweeperForm.MenuStates.Interfaces;
using System;
using System.Windows.Forms;

namespace Minesweeper.MinesweeperForm
{
	public partial class MinesweeperForm : Form
	{
		private UserControl currentUserControl;

		public MinesweeperForm()
		{
			InitializeComponent();

			//currentUserControl = new Menus.Menu();
			setCurrentView(new MenuStates.Menus.Menu());
			//menu1.OnViewChanged += HandleViewChange;
		}

		private void HandleViewChange(object userControl, EventArgs e)
		{
			//probably a better way to do this but it's good enough
			if(userControl is MenuStates.Menus.Menu)
			{
				setCurrentView(((MenuStates.Menus.Menu)userControl).ReplacementUserControl);
			} else if (userControl is Scores) 
			{
				setCurrentView(((Scores)userControl).ReplacementUserControl);
			} else if(userControl is GameView)
			{
				setCurrentView(((GameView)userControl).ReplacementUserControl);
			}
		}

		private void setCurrentView(UserControl newUserControl)
		{
			//Finally use the interface
			if(newUserControl is IViewChange IviewChangeInstance)
			{
				IviewChangeInstance.OnViewChanged += HandleViewChange;
				
				//Remove the current control before adding a new one
				if(currentUserControl != null)
				{
					Controls.Remove(currentUserControl);
				}
				currentUserControl = newUserControl;
				Controls.Add(newUserControl);

				
			} else
			{
				throw new Exception("Menu must implement IViewChange");
			}
		}
	}
}
