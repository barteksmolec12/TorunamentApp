namespace TrackerUI
{
	partial class TournamentViewerForm
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
			this.headerLabel = new System.Windows.Forms.Label();
			this.tournamentName = new System.Windows.Forms.Label();
			this.roundLabel = new System.Windows.Forms.Label();
			this.roundDropDown = new System.Windows.Forms.ComboBox();
			this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
			this.matchupListBox = new System.Windows.Forms.ListBox();
			this.teamOneName = new System.Windows.Forms.Label();
			this.teamOneScoreLabel = new System.Windows.Forms.Label();
			this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
			this.teamTwoName = new System.Windows.Forms.Label();
			this.teamOneScoreValue = new System.Windows.Forms.TextBox();
			this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
			this.scoreButton = new System.Windows.Forms.Button();
			this.versusLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(25, 18);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(175, 40);
			this.headerLabel.TabIndex = 0;
			this.headerLabel.Text = "Tournament:";
			this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
			// 
			// tournamentName
			// 
			this.tournamentName.AutoSize = true;
			this.tournamentName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentName.Location = new System.Drawing.Point(221, 18);
			this.tournamentName.Name = "tournamentName";
			this.tournamentName.Size = new System.Drawing.Size(121, 40);
			this.tournamentName.TabIndex = 1;
			this.tournamentName.Text = "<none>";
			this.tournamentName.Click += new System.EventHandler(this.tournamentName_Click);
			// 
			// roundLabel
			// 
			this.roundLabel.AutoSize = true;
			this.roundLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.roundLabel.Location = new System.Drawing.Point(36, 74);
			this.roundLabel.Name = "roundLabel";
			this.roundLabel.Size = new System.Drawing.Size(75, 30);
			this.roundLabel.TabIndex = 2;
			this.roundLabel.Text = "Round";
			// 
			// roundDropDown
			// 
			this.roundDropDown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.roundDropDown.FormattingEnabled = true;
			this.roundDropDown.Location = new System.Drawing.Point(114, 74);
			this.roundDropDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.roundDropDown.Name = "roundDropDown";
			this.roundDropDown.Size = new System.Drawing.Size(209, 38);
			this.roundDropDown.TabIndex = 3;
			// 
			// unplayedOnlyCheckbox
			// 
			this.unplayedOnlyCheckbox.AutoSize = true;
			this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(114, 123);
			this.unplayedOnlyCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
			this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(209, 41);
			this.unplayedOnlyCheckbox.TabIndex = 4;
			this.unplayedOnlyCheckbox.Text = "Unplayed Only";
			this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
			// 
			// matchupListBox
			// 
			this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.matchupListBox.FormattingEnabled = true;
			this.matchupListBox.ItemHeight = 30;
			this.matchupListBox.Location = new System.Drawing.Point(41, 179);
			this.matchupListBox.Name = "matchupListBox";
			this.matchupListBox.Size = new System.Drawing.Size(282, 242);
			this.matchupListBox.TabIndex = 5;
			this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// teamOneName
			// 
			this.teamOneName.AutoSize = true;
			this.teamOneName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.teamOneName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamOneName.Location = new System.Drawing.Point(379, 179);
			this.teamOneName.Name = "teamOneName";
			this.teamOneName.Size = new System.Drawing.Size(134, 30);
			this.teamOneName.TabIndex = 6;
			this.teamOneName.Text = "<team one>";
			// 
			// teamOneScoreLabel
			// 
			this.teamOneScoreLabel.AutoSize = true;
			this.teamOneScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamOneScoreLabel.Location = new System.Drawing.Point(379, 220);
			this.teamOneScoreLabel.Name = "teamOneScoreLabel";
			this.teamOneScoreLabel.Size = new System.Drawing.Size(66, 30);
			this.teamOneScoreLabel.TabIndex = 7;
			this.teamOneScoreLabel.Text = "Score";
			// 
			// TeamTwoScoreLabel
			// 
			this.TeamTwoScoreLabel.AutoSize = true;
			this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TeamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.TeamTwoScoreLabel.Location = new System.Drawing.Point(379, 359);
			this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
			this.TeamTwoScoreLabel.Size = new System.Drawing.Size(66, 30);
			this.TeamTwoScoreLabel.TabIndex = 9;
			this.TeamTwoScoreLabel.Text = "Score";
			// 
			// teamTwoName
			// 
			this.teamTwoName.AutoSize = true;
			this.teamTwoName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamTwoName.Location = new System.Drawing.Point(379, 318);
			this.teamTwoName.Name = "teamTwoName";
			this.teamTwoName.Size = new System.Drawing.Size(135, 30);
			this.teamTwoName.TabIndex = 8;
			this.teamTwoName.Text = "<team two>";
			// 
			// teamOneScoreValue
			// 
			this.teamOneScoreValue.Location = new System.Drawing.Point(449, 220);
			this.teamOneScoreValue.Name = "teamOneScoreValue";
			this.teamOneScoreValue.Size = new System.Drawing.Size(100, 35);
			this.teamOneScoreValue.TabIndex = 10;
			// 
			// TeamTwoScoreValue
			// 
			this.TeamTwoScoreValue.Location = new System.Drawing.Point(449, 359);
			this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
			this.TeamTwoScoreValue.Size = new System.Drawing.Size(100, 35);
			this.TeamTwoScoreValue.TabIndex = 11;
			// 
			// scoreButton
			// 
			this.scoreButton.BackColor = System.Drawing.Color.White;
			this.scoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.scoreButton.Location = new System.Drawing.Point(570, 268);
			this.scoreButton.Name = "scoreButton";
			this.scoreButton.Size = new System.Drawing.Size(104, 42);
			this.scoreButton.TabIndex = 12;
			this.scoreButton.Text = "Score";
			this.scoreButton.UseVisualStyleBackColor = false;
			this.scoreButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// versusLabel
			// 
			this.versusLabel.AutoSize = true;
			this.versusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.versusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.versusLabel.Location = new System.Drawing.Point(434, 268);
			this.versusLabel.Name = "versusLabel";
			this.versusLabel.Size = new System.Drawing.Size(49, 30);
			this.versusLabel.TabIndex = 13;
			this.versusLabel.Text = "-vs-";
			// 
			// TournamentViewerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(710, 476);
			this.Controls.Add(this.versusLabel);
			this.Controls.Add(this.scoreButton);
			this.Controls.Add(this.TeamTwoScoreValue);
			this.Controls.Add(this.teamOneScoreValue);
			this.Controls.Add(this.TeamTwoScoreLabel);
			this.Controls.Add(this.teamTwoName);
			this.Controls.Add(this.teamOneScoreLabel);
			this.Controls.Add(this.teamOneName);
			this.Controls.Add(this.matchupListBox);
			this.Controls.Add(this.unplayedOnlyCheckbox);
			this.Controls.Add(this.roundDropDown);
			this.Controls.Add(this.roundLabel);
			this.Controls.Add(this.tournamentName);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.Name = "TournamentViewerForm";
			this.Text = "TournamentViewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Label tournamentName;
		private System.Windows.Forms.Label roundLabel;
		private System.Windows.Forms.ComboBox roundDropDown;
		private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
		private System.Windows.Forms.ListBox matchupListBox;
		private System.Windows.Forms.Label teamOneName;
		private System.Windows.Forms.Label teamOneScoreLabel;
		private System.Windows.Forms.Label TeamTwoScoreLabel;
		private System.Windows.Forms.Label teamTwoName;
		private System.Windows.Forms.TextBox teamOneScoreValue;
		private System.Windows.Forms.TextBox TeamTwoScoreValue;
		private System.Windows.Forms.Button scoreButton;
		private System.Windows.Forms.Label versusLabel;
	}
}

