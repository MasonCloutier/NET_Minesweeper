namespace Minesweeper.MinesweeperForm.MenuStates.Game
{
	partial class GameTile
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// GameTile
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = global::Minesweeper.Properties.Resources.Tile;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.MaximumSize = new System.Drawing.Size(32, 32);
			this.MinimumSize = new System.Drawing.Size(32, 32);
			this.Name = "GameTile";
			this.Size = new System.Drawing.Size(32, 32);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameTile_MouseDown);
			this.ResumeLayout(false);

		}

		#endregion
	}
}
