namespace Minesweeper.MinesweeperForm.MenuStates.Game.WinForms
{
	partial class WinForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.winLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.submitButton = new System.Windows.Forms.Button();
			this.sizeLabel = new System.Windows.Forms.Label();
			this.sizeDisplayLabel = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.timeDisplayLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// winLabel
			// 
			this.winLabel.AutoSize = true;
			this.winLabel.Location = new System.Drawing.Point(10, 25);
			this.winLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.winLabel.Name = "winLabel";
			this.winLabel.Size = new System.Drawing.Size(281, 18);
			this.winLabel.TabIndex = 0;
			this.winLabel.Text = "You won! Enter the name for your score.";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(35, 68);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(58, 18);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "Name: ";
			// 
			// submitButton
			// 
			this.submitButton.AutoSize = true;
			this.submitButton.Location = new System.Drawing.Point(115, 218);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 28);
			this.submitButton.TabIndex = 2;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Visible = false;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// sizeLabel
			// 
			this.sizeLabel.AutoSize = true;
			this.sizeLabel.Location = new System.Drawing.Point(46, 107);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(47, 18);
			this.sizeLabel.TabIndex = 4;
			this.sizeLabel.Text = "Size: ";
			// 
			// sizeDisplayLabel
			// 
			this.sizeDisplayLabel.AutoSize = true;
			this.sizeDisplayLabel.Location = new System.Drawing.Point(99, 107);
			this.sizeDisplayLabel.Name = "sizeDisplayLabel";
			this.sizeDisplayLabel.Size = new System.Drawing.Size(78, 18);
			this.sizeDisplayLabel.TabIndex = 5;
			this.sizeDisplayLabel.Text = "someSize";
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Location = new System.Drawing.Point(1, 145);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(92, 18);
			this.timeLabel.TabIndex = 6;
			this.timeLabel.Text = "Time taken: ";
			// 
			// timeDisplayLabel
			// 
			this.timeDisplayLabel.AutoSize = true;
			this.timeDisplayLabel.Location = new System.Drawing.Point(99, 145);
			this.timeDisplayLabel.Name = "timeDisplayLabel";
			this.timeDisplayLabel.Size = new System.Drawing.Size(81, 18);
			this.timeDisplayLabel.TabIndex = 7;
			this.timeDisplayLabel.Text = "someTime";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(99, 65);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(180, 26);
			this.nameTextBox.TabIndex = 8;
			this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
			// 
			// WinForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(304, 281);
			this.ControlBox = false;
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.timeDisplayLabel);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.sizeDisplayLabel);
			this.Controls.Add(this.sizeLabel);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.winLabel);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(320, 320);
			this.MinimumSize = new System.Drawing.Size(320, 320);
			this.Name = "WinForm";
			this.Text = "WinForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label winLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Label sizeLabel;
		private System.Windows.Forms.Label sizeDisplayLabel;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Label timeDisplayLabel;
		private System.Windows.Forms.TextBox nameTextBox;
	}
}