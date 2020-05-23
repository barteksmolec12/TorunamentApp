namespace TrackerUI
{
	partial class CreateTeamForm
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
			this.createTeamLabel = new System.Windows.Forms.Label();
			this.teamNameLabel = new System.Windows.Forms.Label();
			this.teamNameValue = new System.Windows.Forms.TextBox();
			this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
			this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
			this.addMemberButton = new System.Windows.Forms.Button();
			this.MemberGroup = new System.Windows.Forms.GroupBox();
			this.createMemberButton = new System.Windows.Forms.Button();
			this.cellphoneValue = new System.Windows.Forms.TextBox();
			this.cellphoneLabel = new System.Windows.Forms.Label();
			this.emailValue = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.lastNameValue = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.firstNameValue = new System.Windows.Forms.TextBox();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.teamMembersListBox = new System.Windows.Forms.ListBox();
			this.createTeamButton = new System.Windows.Forms.Button();
			this.deleteSelectedMembersButton = new System.Windows.Forms.Button();
			this.MemberGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// createTeamLabel
			// 
			this.createTeamLabel.AutoSize = true;
			this.createTeamLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.createTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTeamLabel.Location = new System.Drawing.Point(21, 9);
			this.createTeamLabel.Name = "createTeamLabel";
			this.createTeamLabel.Size = new System.Drawing.Size(175, 40);
			this.createTeamLabel.TabIndex = 1;
			this.createTeamLabel.Text = "Create Team";
			// 
			// teamNameLabel
			// 
			this.teamNameLabel.AutoSize = true;
			this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
			this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamNameLabel.Location = new System.Drawing.Point(23, 61);
			this.teamNameLabel.Name = "teamNameLabel";
			this.teamNameLabel.Size = new System.Drawing.Size(114, 25);
			this.teamNameLabel.TabIndex = 3;
			this.teamNameLabel.Text = "Team Name";
			// 
			// teamNameValue
			// 
			this.teamNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.teamNameValue.Location = new System.Drawing.Point(28, 94);
			this.teamNameValue.Name = "teamNameValue";
			this.teamNameValue.Size = new System.Drawing.Size(264, 26);
			this.teamNameValue.TabIndex = 5;
			// 
			// SelectTeamMemberLabel
			// 
			this.SelectTeamMemberLabel.AutoSize = true;
			this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
			this.SelectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.SelectTeamMemberLabel.Location = new System.Drawing.Point(23, 139);
			this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
			this.SelectTeamMemberLabel.Size = new System.Drawing.Size(191, 25);
			this.SelectTeamMemberLabel.TabIndex = 6;
			this.SelectTeamMemberLabel.Text = "Select Team Member";
			// 
			// selectTeamMemberDropDown
			// 
			this.selectTeamMemberDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.selectTeamMemberDropDown.FormattingEnabled = true;
			this.selectTeamMemberDropDown.Location = new System.Drawing.Point(28, 172);
			this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
			this.selectTeamMemberDropDown.Size = new System.Drawing.Size(264, 28);
			this.selectTeamMemberDropDown.TabIndex = 9;
			// 
			// addMemberButton
			// 
			this.addMemberButton.BackColor = System.Drawing.Color.White;
			this.addMemberButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addMemberButton.Location = new System.Drawing.Point(69, 216);
			this.addMemberButton.Name = "addMemberButton";
			this.addMemberButton.Size = new System.Drawing.Size(165, 42);
			this.addMemberButton.TabIndex = 14;
			this.addMemberButton.Text = "Add Member";
			this.addMemberButton.UseVisualStyleBackColor = false;
			this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
			// 
			// MemberGroup
			// 
			this.MemberGroup.Controls.Add(this.createMemberButton);
			this.MemberGroup.Controls.Add(this.cellphoneValue);
			this.MemberGroup.Controls.Add(this.cellphoneLabel);
			this.MemberGroup.Controls.Add(this.emailValue);
			this.MemberGroup.Controls.Add(this.emailLabel);
			this.MemberGroup.Controls.Add(this.lastNameValue);
			this.MemberGroup.Controls.Add(this.lastNameLabel);
			this.MemberGroup.Controls.Add(this.firstNameValue);
			this.MemberGroup.Controls.Add(this.firstNameLabel);
			this.MemberGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
			this.MemberGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.MemberGroup.Location = new System.Drawing.Point(28, 274);
			this.MemberGroup.Name = "MemberGroup";
			this.MemberGroup.Size = new System.Drawing.Size(273, 236);
			this.MemberGroup.TabIndex = 15;
			this.MemberGroup.TabStop = false;
			this.MemberGroup.Text = "Add New Member";
			// 
			// createMemberButton
			// 
			this.createMemberButton.BackColor = System.Drawing.Color.White;
			this.createMemberButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createMemberButton.Location = new System.Drawing.Point(50, 175);
			this.createMemberButton.Name = "createMemberButton";
			this.createMemberButton.Size = new System.Drawing.Size(165, 42);
			this.createMemberButton.TabIndex = 16;
			this.createMemberButton.Text = "Create Member";
			this.createMemberButton.UseVisualStyleBackColor = false;
			this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
			// 
			// cellphoneValue
			// 
			this.cellphoneValue.AcceptsReturn = true;
			this.cellphoneValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
			this.cellphoneValue.Location = new System.Drawing.Point(110, 142);
			this.cellphoneValue.Name = "cellphoneValue";
			this.cellphoneValue.Size = new System.Drawing.Size(135, 27);
			this.cellphoneValue.TabIndex = 16;
			// 
			// cellphoneLabel
			// 
			this.cellphoneLabel.AutoSize = true;
			this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
			this.cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.cellphoneLabel.Location = new System.Drawing.Point(6, 144);
			this.cellphoneLabel.Name = "cellphoneLabel";
			this.cellphoneLabel.Size = new System.Drawing.Size(96, 25);
			this.cellphoneLabel.TabIndex = 15;
			this.cellphoneLabel.Text = "Cellphone";
			// 
			// emailValue
			// 
			this.emailValue.AcceptsReturn = true;
			this.emailValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
			this.emailValue.Location = new System.Drawing.Point(110, 106);
			this.emailValue.Name = "emailValue";
			this.emailValue.Size = new System.Drawing.Size(135, 27);
			this.emailValue.TabIndex = 14;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
			this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.emailLabel.Location = new System.Drawing.Point(6, 108);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(56, 25);
			this.emailLabel.TabIndex = 13;
			this.emailLabel.Text = "Email";
			// 
			// lastNameValue
			// 
			this.lastNameValue.AcceptsReturn = true;
			this.lastNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
			this.lastNameValue.Location = new System.Drawing.Point(110, 72);
			this.lastNameValue.Name = "lastNameValue";
			this.lastNameValue.Size = new System.Drawing.Size(135, 27);
			this.lastNameValue.TabIndex = 12;
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
			this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.lastNameLabel.Location = new System.Drawing.Point(6, 74);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(99, 25);
			this.lastNameLabel.TabIndex = 11;
			this.lastNameLabel.Text = "Last Name";
			// 
			// firstNameValue
			// 
			this.firstNameValue.AcceptsReturn = true;
			this.firstNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
			this.firstNameValue.Location = new System.Drawing.Point(110, 39);
			this.firstNameValue.Name = "firstNameValue";
			this.firstNameValue.Size = new System.Drawing.Size(135, 27);
			this.firstNameValue.TabIndex = 10;
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
			this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.firstNameLabel.Location = new System.Drawing.Point(6, 41);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(102, 25);
			this.firstNameLabel.TabIndex = 8;
			this.firstNameLabel.Text = "First Name";
			// 
			// teamMembersListBox
			// 
			this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.teamMembersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.teamMembersListBox.FormattingEnabled = true;
			this.teamMembersListBox.ItemHeight = 18;
			this.teamMembersListBox.Location = new System.Drawing.Point(331, 90);
			this.teamMembersListBox.Name = "teamMembersListBox";
			this.teamMembersListBox.Size = new System.Drawing.Size(243, 416);
			this.teamMembersListBox.TabIndex = 16;
			// 
			// createTeamButton
			// 
			this.createTeamButton.BackColor = System.Drawing.Color.White;
			this.createTeamButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTeamButton.Location = new System.Drawing.Point(261, 519);
			this.createTeamButton.Name = "createTeamButton";
			this.createTeamButton.Size = new System.Drawing.Size(165, 42);
			this.createTeamButton.TabIndex = 17;
			this.createTeamButton.Text = "Create Team";
			this.createTeamButton.UseVisualStyleBackColor = false;
			this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
			// 
			// deleteSelectedMembersButton
			// 
			this.deleteSelectedMembersButton.BackColor = System.Drawing.Color.White;
			this.deleteSelectedMembersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.deleteSelectedMembersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.deleteSelectedMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.deleteSelectedMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.deleteSelectedMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteSelectedMembersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.deleteSelectedMembersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.deleteSelectedMembersButton.Location = new System.Drawing.Point(580, 267);
			this.deleteSelectedMembersButton.Name = "deleteSelectedMembersButton";
			this.deleteSelectedMembersButton.Size = new System.Drawing.Size(108, 73);
			this.deleteSelectedMembersButton.TabIndex = 20;
			this.deleteSelectedMembersButton.Text = "Delete Selected";
			this.deleteSelectedMembersButton.UseVisualStyleBackColor = false;
			this.deleteSelectedMembersButton.Click += new System.EventHandler(this.deleteSelectedMembersButton_Click);
			// 
			// CreateTeamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(693, 573);
			this.Controls.Add(this.deleteSelectedMembersButton);
			this.Controls.Add(this.createTeamButton);
			this.Controls.Add(this.teamMembersListBox);
			this.Controls.Add(this.MemberGroup);
			this.Controls.Add(this.addMemberButton);
			this.Controls.Add(this.selectTeamMemberDropDown);
			this.Controls.Add(this.SelectTeamMemberLabel);
			this.Controls.Add(this.teamNameValue);
			this.Controls.Add(this.teamNameLabel);
			this.Controls.Add(this.createTeamLabel);
			this.Name = "CreateTeamForm";
			this.Text = "Team Name";
			this.Load += new System.EventHandler(this.CreateTeamForm_Load);
			this.MemberGroup.ResumeLayout(false);
			this.MemberGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label createTeamLabel;
		private System.Windows.Forms.Label teamNameLabel;
		private System.Windows.Forms.TextBox teamNameValue;
		private System.Windows.Forms.Label SelectTeamMemberLabel;
		private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
		private System.Windows.Forms.Button addMemberButton;
		private System.Windows.Forms.GroupBox MemberGroup;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.TextBox firstNameValue;
		private System.Windows.Forms.TextBox cellphoneValue;
		private System.Windows.Forms.Label cellphoneLabel;
		private System.Windows.Forms.TextBox emailValue;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.TextBox lastNameValue;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Button createMemberButton;
		private System.Windows.Forms.ListBox teamMembersListBox;
		private System.Windows.Forms.Button createTeamButton;
		private System.Windows.Forms.Button deleteSelectedMembersButton;
	}
}