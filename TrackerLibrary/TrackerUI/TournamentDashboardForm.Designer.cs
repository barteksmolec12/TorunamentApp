namespace TrackerUI
{
	partial class TournamentDashboardForm
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
			this.tournamentDashboardLabel = new System.Windows.Forms.Label();
			this.loadExistingtournamentLabel = new System.Windows.Forms.Label();
			this.loadTournamentDropDown = new System.Windows.Forms.ComboBox();
			this.loadTournamentButton = new System.Windows.Forms.Button();
			this.createTournamentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tournamentDashboardLabel
			// 
			this.tournamentDashboardLabel.AutoSize = true;
			this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tournamentDashboardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentDashboardLabel.Location = new System.Drawing.Point(113, 30);
			this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
			this.tournamentDashboardLabel.Size = new System.Drawing.Size(316, 40);
			this.tournamentDashboardLabel.TabIndex = 2;
			this.tournamentDashboardLabel.Text = "Tournament Dashboard";
			this.tournamentDashboardLabel.Click += new System.EventHandler(this.createTournamentLabel_Click);
			// 
			// loadExistingtournamentLabel
			// 
			this.loadExistingtournamentLabel.AutoSize = true;
			this.loadExistingtournamentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.loadExistingtournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.loadExistingtournamentLabel.Location = new System.Drawing.Point(145, 95);
			this.loadExistingtournamentLabel.Name = "loadExistingtournamentLabel";
			this.loadExistingtournamentLabel.Size = new System.Drawing.Size(262, 30);
			this.loadExistingtournamentLabel.TabIndex = 4;
			this.loadExistingtournamentLabel.Text = "Load Existing Tournament";
			// 
			// loadTournamentDropDown
			// 
			this.loadTournamentDropDown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.loadTournamentDropDown.FormattingEnabled = true;
			this.loadTournamentDropDown.Location = new System.Drawing.Point(94, 128);
			this.loadTournamentDropDown.Name = "loadTournamentDropDown";
			this.loadTournamentDropDown.Size = new System.Drawing.Size(363, 40);
			this.loadTournamentDropDown.TabIndex = 9;
			// 
			// loadTournamentButton
			// 
			this.loadTournamentButton.BackColor = System.Drawing.Color.White;
			this.loadTournamentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.loadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.loadTournamentButton.Location = new System.Drawing.Point(163, 195);
			this.loadTournamentButton.Name = "loadTournamentButton";
			this.loadTournamentButton.Size = new System.Drawing.Size(216, 42);
			this.loadTournamentButton.TabIndex = 23;
			this.loadTournamentButton.Text = "Load Tournament";
			this.loadTournamentButton.UseVisualStyleBackColor = false;
			// 
			// createTournamentButton
			// 
			this.createTournamentButton.BackColor = System.Drawing.Color.White;
			this.createTournamentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTournamentButton.Location = new System.Drawing.Point(134, 255);
			this.createTournamentButton.Name = "createTournamentButton";
			this.createTournamentButton.Size = new System.Drawing.Size(273, 42);
			this.createTournamentButton.TabIndex = 24;
			this.createTournamentButton.Text = "Create Tournament";
			this.createTournamentButton.UseVisualStyleBackColor = false;
			// 
			// TournamentDashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(549, 326);
			this.Controls.Add(this.createTournamentButton);
			this.Controls.Add(this.loadTournamentButton);
			this.Controls.Add(this.loadTournamentDropDown);
			this.Controls.Add(this.loadExistingtournamentLabel);
			this.Controls.Add(this.tournamentDashboardLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.Name = "TournamentDashboardForm";
			this.Text = "Tournament Dashboard";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label tournamentDashboardLabel;
		private System.Windows.Forms.Label loadExistingtournamentLabel;
		private System.Windows.Forms.ComboBox loadTournamentDropDown;
		private System.Windows.Forms.Button loadTournamentButton;
		private System.Windows.Forms.Button createTournamentButton;
	}
}