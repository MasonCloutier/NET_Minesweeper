namespace Minesweeper.MinesweeperForm.MenuStates.Menus
{
	partial class Menu
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
			this.scoresButton = new System.Windows.Forms.Button();
			this.playButton = new System.Windows.Forms.Button();
			this.titleLabel = new System.Windows.Forms.Label();
			this.boardSizeComboBox = new System.Windows.Forms.ComboBox();
			this.boardSizeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// scoresButton
			// 
			this.scoresButton.AutoSize = true;
			this.scoresButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoresButton.Location = new System.Drawing.Point(252, 403);
			this.scoresButton.Name = "scoresButton";
			this.scoresButton.Size = new System.Drawing.Size(172, 43);
			this.scoresButton.TabIndex = 5;
			this.scoresButton.Text = "Scores";
			this.scoresButton.UseVisualStyleBackColor = true;
			this.scoresButton.Click += new System.EventHandler(this.scoresButton_Click);
			// 
			// playButton
			// 
			this.playButton.AutoSize = true;
			this.playButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playButton.Location = new System.Drawing.Point(298, 314);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(80, 43);
			this.playButton.TabIndex = 4;
			this.playButton.Text = "Play";
			this.playButton.UseVisualStyleBackColor = true;
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(119, 64);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(413, 72);
			this.titleLabel.TabIndex = 3;
			this.titleLabel.Text = "Minesweeper";
			// 
			// boardSizeComboBox
			// 
			this.boardSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.boardSizeComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.boardSizeComboBox.FormattingEnabled = true;
			this.boardSizeComboBox.Items.AddRange(new object[] {
            "Small      (8x7)",
            "Medium (12x10)",
            "Large      (18x14)",
            "Huge      (20x18)"});
			this.boardSizeComboBox.Location = new System.Drawing.Point(481, 323);
			this.boardSizeComboBox.Name = "boardSizeComboBox";
			this.boardSizeComboBox.Size = new System.Drawing.Size(184, 26);
			this.boardSizeComboBox.TabIndex = 6;
			// 
			// boardSizeLabel
			// 
			this.boardSizeLabel.AutoSize = true;
			this.boardSizeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.boardSizeLabel.Location = new System.Drawing.Point(384, 326);
			this.boardSizeLabel.Name = "boardSizeLabel";
			this.boardSizeLabel.Size = new System.Drawing.Size(91, 18);
			this.boardSizeLabel.TabIndex = 7;
			this.boardSizeLabel.Text = "Board size: ";
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.boardSizeLabel);
			this.Controls.Add(this.boardSizeComboBox);
			this.Controls.Add(this.scoresButton);
			this.Controls.Add(this.playButton);
			this.Controls.Add(this.titleLabel);
			this.MaximumSize = new System.Drawing.Size(685, 625);
			this.MinimumSize = new System.Drawing.Size(685, 625);
			this.Name = "Menu";
			this.Size = new System.Drawing.Size(685, 625);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button scoresButton;
		private System.Windows.Forms.Button playButton;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.ComboBox boardSizeComboBox;
		private System.Windows.Forms.Label boardSizeLabel;
	}
}
