namespace Minesweeper.MinesweeperForm.MenuStates.Game
{
	partial class Scores
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
			this.highScoresLabel = new System.Windows.Forms.Label();
			this.backButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.scoresListView = new System.Windows.Forms.ListView();
			this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.boardSizeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.winTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// highScoresLabel
			// 
			this.highScoresLabel.AutoSize = true;
			this.highScoresLabel.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highScoresLabel.Location = new System.Drawing.Point(129, 51);
			this.highScoresLabel.Name = "highScoresLabel";
			this.highScoresLabel.Size = new System.Drawing.Size(380, 72);
			this.highScoresLabel.TabIndex = 4;
			this.highScoresLabel.Text = "High Scores";
			// 
			// backButton
			// 
			this.backButton.AutoSize = true;
			this.backButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backButton.Location = new System.Drawing.Point(287, 470);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(89, 43);
			this.backButton.TabIndex = 6;
			this.backButton.Text = "Back";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetButton.Location = new System.Drawing.Point(534, 256);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 49);
			this.resetButton.TabIndex = 8;
			this.resetButton.Text = "Reset scores";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// scoresListView
			// 
			this.scoresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.boardSizeColumnHeader,
            this.winTimeColumnHeader});
			this.scoresListView.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoresListView.HideSelection = false;
			this.scoresListView.Location = new System.Drawing.Point(164, 155);
			this.scoresListView.Name = "scoresListView";
			this.scoresListView.Size = new System.Drawing.Size(364, 267);
			this.scoresListView.TabIndex = 13;
			this.scoresListView.UseCompatibleStateImageBehavior = false;
			this.scoresListView.View = System.Windows.Forms.View.Details;
			// 
			// nameColumnHeader
			// 
			this.nameColumnHeader.Text = "Name";
			this.nameColumnHeader.Width = 130;
			// 
			// boardSizeColumnHeader
			// 
			this.boardSizeColumnHeader.Text = "Size";
			this.boardSizeColumnHeader.Width = 100;
			// 
			// winTimeColumnHeader
			// 
			this.winTimeColumnHeader.Text = "Time taken";
			this.winTimeColumnHeader.Width = 100;
			// 
			// Scores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.scoresListView);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.highScoresLabel);
			this.MaximumSize = new System.Drawing.Size(685, 625);
			this.MinimumSize = new System.Drawing.Size(685, 625);
			this.Name = "Scores";
			this.Size = new System.Drawing.Size(685, 625);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label highScoresLabel;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.ListView scoresListView;
		private System.Windows.Forms.ColumnHeader nameColumnHeader;
		private System.Windows.Forms.ColumnHeader boardSizeColumnHeader;
		private System.Windows.Forms.ColumnHeader winTimeColumnHeader;
	}
}
