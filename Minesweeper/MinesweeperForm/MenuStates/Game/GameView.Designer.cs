namespace Minesweeper.MinesweeperForm.MenuStates.Game
{
	partial class GameView
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
			this.components = new System.ComponentModel.Container();
			this.winLabel = new System.Windows.Forms.Label();
			this.lossLabel = new System.Windows.Forms.Label();
			this.backButton = new System.Windows.Forms.Button();
			this.retryButton = new System.Windows.Forms.Button();
			this.timeTakenLabel = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// winLabel
			// 
			this.winLabel.AutoSize = true;
			this.winLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.winLabel.Location = new System.Drawing.Point(288, 8);
			this.winLabel.Name = "winLabel";
			this.winLabel.Size = new System.Drawing.Size(110, 27);
			this.winLabel.TabIndex = 8;
			this.winLabel.Text = "You Won";
			this.winLabel.Visible = false;
			// 
			// lossLabel
			// 
			this.lossLabel.AutoSize = true;
			this.lossLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lossLabel.Location = new System.Drawing.Point(288, 8);
			this.lossLabel.Name = "lossLabel";
			this.lossLabel.Size = new System.Drawing.Size(119, 27);
			this.lossLabel.TabIndex = 9;
			this.lossLabel.Text = "You lost...";
			this.lossLabel.Visible = false;
			// 
			// backButton
			// 
			this.backButton.AutoSize = true;
			this.backButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backButton.Location = new System.Drawing.Point(16, 16);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(130, 34);
			this.backButton.TabIndex = 10;
			this.backButton.Text = "Back to title";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// retryButton
			// 
			this.retryButton.AutoSize = true;
			this.retryButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.retryButton.Location = new System.Drawing.Point(164, 16);
			this.retryButton.Name = "retryButton";
			this.retryButton.Size = new System.Drawing.Size(71, 34);
			this.retryButton.TabIndex = 11;
			this.retryButton.Text = "Retry";
			this.retryButton.UseVisualStyleBackColor = true;
			this.retryButton.Visible = false;
			this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
			// 
			// timeTakenLabel
			// 
			this.timeTakenLabel.AutoSize = true;
			this.timeTakenLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeTakenLabel.Location = new System.Drawing.Point(518, 25);
			this.timeTakenLabel.Name = "timeTakenLabel";
			this.timeTakenLabel.Size = new System.Drawing.Size(92, 18);
			this.timeTakenLabel.TabIndex = 12;
			this.timeTakenLabel.Text = "Time taken: ";
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLabel.Location = new System.Drawing.Point(616, 25);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(0, 18);
			this.timeLabel.TabIndex = 13;
			// 
			// gameTimer
			// 
			this.gameTimer.Interval = 1000;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
			// 
			// GameView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.timeTakenLabel);
			this.Controls.Add(this.retryButton);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.lossLabel);
			this.Controls.Add(this.winLabel);
			this.MaximumSize = new System.Drawing.Size(685, 625);
			this.MinimumSize = new System.Drawing.Size(685, 625);
			this.Name = "GameView";
			this.Size = new System.Drawing.Size(685, 625);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label winLabel;
		private System.Windows.Forms.Label lossLabel;
        private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Button retryButton;
		private System.Windows.Forms.Label timeTakenLabel;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Timer gameTimer;

		#endregion

		//private Game.GameBoard gameBoard1;
	}
}
