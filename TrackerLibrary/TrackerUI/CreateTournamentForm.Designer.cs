namespace TrackerUI
{
	partial class CreateTournamentForm
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
			this.createTournamentLabel = new System.Windows.Forms.Label();
			this.tournamentNameLabel = new System.Windows.Forms.Label();
			this.tournamentNameValue = new System.Windows.Forms.TextBox();
			this.entryFeeLabel = new System.Windows.Forms.Label();
			this.entryFeeValue = new System.Windows.Forms.TextBox();
			this.selectTeamLabel = new System.Windows.Forms.Label();
			this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
			this.addTeamButton = new System.Windows.Forms.Button();
			this.createPrizeButton = new System.Windows.Forms.Button();
			this.tournamentPlayersLabel = new System.Windows.Forms.Label();
			this.tournamentlistBox = new System.Windows.Forms.ListBox();
			this.PrizesLabel = new System.Windows.Forms.Label();
			this.prizeslistBox = new System.Windows.Forms.ListBox();
			this.deleteSelectedPlayers = new System.Windows.Forms.Button();
			this.deleteSelectedPrizes = new System.Windows.Forms.Button();
			this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
			this.createTournamentbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// createTournamentLabel
			// 
			this.createTournamentLabel.AutoSize = true;
			this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.createTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTournamentLabel.Location = new System.Drawing.Point(12, 21);
			this.createTournamentLabel.Name = "createTournamentLabel";
			this.createTournamentLabel.Size = new System.Drawing.Size(260, 40);
			this.createTournamentLabel.TabIndex = 1;
			this.createTournamentLabel.Text = "Create Tournament";
			// 
			// tournamentNameLabel
			// 
			this.tournamentNameLabel.AutoSize = true;
			this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentNameLabel.Location = new System.Drawing.Point(34, 80);
			this.tournamentNameLabel.Name = "tournamentNameLabel";
			this.tournamentNameLabel.Size = new System.Drawing.Size(192, 30);
			this.tournamentNameLabel.TabIndex = 3;
			this.tournamentNameLabel.Text = "Tournament Name";
			this.tournamentNameLabel.Click += new System.EventHandler(this.Toru_Click);
			// 
			// tournamentNameValue
			// 
			this.tournamentNameValue.Location = new System.Drawing.Point(39, 113);
			this.tournamentNameValue.Name = "tournamentNameValue";
			this.tournamentNameValue.Size = new System.Drawing.Size(264, 35);
			this.tournamentNameValue.TabIndex = 4;
			// 
			// entryFeeLabel
			// 
			this.entryFeeLabel.AutoSize = true;
			this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.entryFeeLabel.Location = new System.Drawing.Point(34, 174);
			this.entryFeeLabel.Name = "entryFeeLabel";
			this.entryFeeLabel.Size = new System.Drawing.Size(103, 30);
			this.entryFeeLabel.TabIndex = 5;
			this.entryFeeLabel.Text = "Entry Fee";
			// 
			// entryFeeValue
			// 
			this.entryFeeValue.Location = new System.Drawing.Point(143, 174);
			this.entryFeeValue.Name = "entryFeeValue";
			this.entryFeeValue.Size = new System.Drawing.Size(83, 35);
			this.entryFeeValue.TabIndex = 6;
			this.entryFeeValue.Text = "0";
			// 
			// selectTeamLabel
			// 
			this.selectTeamLabel.AutoSize = true;
			this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.selectTeamLabel.Location = new System.Drawing.Point(34, 238);
			this.selectTeamLabel.Name = "selectTeamLabel";
			this.selectTeamLabel.Size = new System.Drawing.Size(126, 30);
			this.selectTeamLabel.TabIndex = 7;
			this.selectTeamLabel.Text = "Select Team";
			// 
			// selectTeamDropDown
			// 
			this.selectTeamDropDown.FormattingEnabled = true;
			this.selectTeamDropDown.Location = new System.Drawing.Point(54, 270);
			this.selectTeamDropDown.Name = "selectTeamDropDown";
			this.selectTeamDropDown.Size = new System.Drawing.Size(264, 38);
			this.selectTeamDropDown.TabIndex = 8;
			// 
			// addTeamButton
			// 
			this.addTeamButton.BackColor = System.Drawing.Color.White;
			this.addTeamButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addTeamButton.Location = new System.Drawing.Point(77, 329);
			this.addTeamButton.Name = "addTeamButton";
			this.addTeamButton.Size = new System.Drawing.Size(165, 42);
			this.addTeamButton.TabIndex = 13;
			this.addTeamButton.Text = "Add Team";
			this.addTeamButton.UseVisualStyleBackColor = false;
			// 
			// createPrizeButton
			// 
			this.createPrizeButton.BackColor = System.Drawing.Color.White;
			this.createPrizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createPrizeButton.Location = new System.Drawing.Point(77, 388);
			this.createPrizeButton.Name = "createPrizeButton";
			this.createPrizeButton.Size = new System.Drawing.Size(165, 42);
			this.createPrizeButton.TabIndex = 14;
			this.createPrizeButton.Text = "Create Prize";
			this.createPrizeButton.UseVisualStyleBackColor = false;
			// 
			// tournamentPlayersLabel
			// 
			this.tournamentPlayersLabel.AutoSize = true;
			this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentPlayersLabel.Location = new System.Drawing.Point(386, 80);
			this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
			this.tournamentPlayersLabel.Size = new System.Drawing.Size(161, 30);
			this.tournamentPlayersLabel.TabIndex = 15;
			this.tournamentPlayersLabel.Text = "Teams / Players";
			// 
			// tournamentlistBox
			// 
			this.tournamentlistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tournamentlistBox.FormattingEnabled = true;
			this.tournamentlistBox.ItemHeight = 30;
			this.tournamentlistBox.Location = new System.Drawing.Point(382, 113);
			this.tournamentlistBox.Name = "tournamentlistBox";
			this.tournamentlistBox.Size = new System.Drawing.Size(288, 152);
			this.tournamentlistBox.TabIndex = 16;
			// 
			// PrizesLabel
			// 
			this.PrizesLabel.AutoSize = true;
			this.PrizesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PrizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.PrizesLabel.Location = new System.Drawing.Point(386, 270);
			this.PrizesLabel.Name = "PrizesLabel";
			this.PrizesLabel.Size = new System.Drawing.Size(68, 30);
			this.PrizesLabel.TabIndex = 17;
			this.PrizesLabel.Text = "Prizes";
			// 
			// prizeslistBox
			// 
			this.prizeslistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.prizeslistBox.FormattingEnabled = true;
			this.prizeslistBox.ItemHeight = 30;
			this.prizeslistBox.Location = new System.Drawing.Point(382, 310);
			this.prizeslistBox.Name = "prizeslistBox";
			this.prizeslistBox.Size = new System.Drawing.Size(288, 152);
			this.prizeslistBox.TabIndex = 18;
			// 
			// deleteSelectedPlayers
			// 
			this.deleteSelectedPlayers.BackColor = System.Drawing.Color.White;
			this.deleteSelectedPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.deleteSelectedPlayers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.deleteSelectedPlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.deleteSelectedPlayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.deleteSelectedPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteSelectedPlayers.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.deleteSelectedPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.deleteSelectedPlayers.Location = new System.Drawing.Point(691, 162);
			this.deleteSelectedPlayers.Name = "deleteSelectedPlayers";
			this.deleteSelectedPlayers.Size = new System.Drawing.Size(108, 73);
			this.deleteSelectedPlayers.TabIndex = 19;
			this.deleteSelectedPlayers.Text = "Delete Selected";
			this.deleteSelectedPlayers.UseVisualStyleBackColor = false;
			// 
			// deleteSelectedPrizes
			// 
			this.deleteSelectedPrizes.BackColor = System.Drawing.Color.White;
			this.deleteSelectedPrizes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.deleteSelectedPrizes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.deleteSelectedPrizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.deleteSelectedPrizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.deleteSelectedPrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteSelectedPrizes.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.deleteSelectedPrizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.deleteSelectedPrizes.Location = new System.Drawing.Point(691, 338);
			this.deleteSelectedPrizes.Name = "deleteSelectedPrizes";
			this.deleteSelectedPrizes.Size = new System.Drawing.Size(108, 73);
			this.deleteSelectedPrizes.TabIndex = 20;
			this.deleteSelectedPrizes.Text = "Delete Selected";
			this.deleteSelectedPrizes.UseVisualStyleBackColor = false;
			// 
			// createNewTeamLink
			// 
			this.createNewTeamLink.AutoSize = true;
			this.createNewTeamLink.Location = new System.Drawing.Point(182, 235);
			this.createNewTeamLink.Name = "createNewTeamLink";
			this.createNewTeamLink.Size = new System.Drawing.Size(114, 30);
			this.createNewTeamLink.TabIndex = 21;
			this.createNewTeamLink.TabStop = true;
			this.createNewTeamLink.Text = "create new";
			// 
			// createTournamentbutton
			// 
			this.createTournamentbutton.BackColor = System.Drawing.Color.White;
			this.createTournamentbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.createTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.createTournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.createTournamentbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTournamentbutton.Location = new System.Drawing.Point(293, 487);
			this.createTournamentbutton.Name = "createTournamentbutton";
			this.createTournamentbutton.Size = new System.Drawing.Size(216, 42);
			this.createTournamentbutton.TabIndex = 22;
			this.createTournamentbutton.Text = "Create Tournament";
			this.createTournamentbutton.UseVisualStyleBackColor = false;
			// 
			// CreateTournamentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(811, 559);
			this.Controls.Add(this.createTournamentbutton);
			this.Controls.Add(this.createNewTeamLink);
			this.Controls.Add(this.deleteSelectedPrizes);
			this.Controls.Add(this.deleteSelectedPlayers);
			this.Controls.Add(this.prizeslistBox);
			this.Controls.Add(this.PrizesLabel);
			this.Controls.Add(this.tournamentlistBox);
			this.Controls.Add(this.tournamentPlayersLabel);
			this.Controls.Add(this.createPrizeButton);
			this.Controls.Add(this.addTeamButton);
			this.Controls.Add(this.selectTeamDropDown);
			this.Controls.Add(this.selectTeamLabel);
			this.Controls.Add(this.entryFeeValue);
			this.Controls.Add(this.entryFeeLabel);
			this.Controls.Add(this.tournamentNameValue);
			this.Controls.Add(this.tournamentNameLabel);
			this.Controls.Add(this.createTournamentLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "CreateTournamentForm";
			this.Text = "Create Tournament";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label createTournamentLabel;
		private System.Windows.Forms.Label tournamentNameLabel;
		private System.Windows.Forms.TextBox tournamentNameValue;
		private System.Windows.Forms.Label entryFeeLabel;
		private System.Windows.Forms.TextBox entryFeeValue;
		private System.Windows.Forms.Label selectTeamLabel;
		private System.Windows.Forms.ComboBox selectTeamDropDown;
		private System.Windows.Forms.Button addTeamButton;
		private System.Windows.Forms.Button createPrizeButton;
		private System.Windows.Forms.Label tournamentPlayersLabel;
		private System.Windows.Forms.ListBox tournamentlistBox;
		private System.Windows.Forms.Label PrizesLabel;
		private System.Windows.Forms.ListBox prizeslistBox;
		private System.Windows.Forms.Button deleteSelectedPlayers;
		private System.Windows.Forms.Button deleteSelectedPrizes;
		private System.Windows.Forms.LinkLabel createNewTeamLink;
		private System.Windows.Forms.Button createTournamentbutton;
	}
}