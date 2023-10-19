using System;

namespace Minesweeper.MinesweeperForm.MenuStates.Interfaces
{
	internal interface IViewChange
	{
		//First time using an interface on my own
		//I guess it took until now for me to encounter a case where I needed one

		//Looking back, I probably should've used a custom class instead.
		event EventHandler OnViewChanged;
	}
}
