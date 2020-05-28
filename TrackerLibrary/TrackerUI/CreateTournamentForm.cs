using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class CreateTournamentForm : Form
	{
		
			List<TeamModel> teams = GlobalConfig.Connections.GetTeams_All();
		    List<TeamModel> selectedTeams = new List<TeamModel>();
		public CreateTournamentForm()
		{
			InitializeComponent();
			WireUpList();
		}

		private void Toru_Click(object sender, EventArgs e)
		{

		}
		
		public  void WireUpList()
		{
			selectTeamsDropDown.DataSource = null;
			selectTeamsDropDown.DataSource = teams;
			selectTeamsDropDown.DisplayMember = "TeamName";

			tournamentlistBox.DataSource = null;
			tournamentlistBox.DataSource = selectedTeams;
			tournamentlistBox.DisplayMember = "TeamName";

		}
		

		private void createPrizeButton_Click(object sender, EventArgs e)
			
		{
			CreatePrizeForm openPrizeform = new CreatePrizeForm();
			openPrizeform.Show();
			
		}

		private void addTeamButton_Click(object sender, EventArgs e)
		{
			TeamModel t = (TeamModel)selectTeamsDropDown.SelectedItem;
			teams.Remove(t);
			selectedTeams.Add(t);
			WireUpList();
	

		}

		private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CreateTeamForm createTeamForm = new CreateTeamForm();
			createTeamForm.Show();
			

		}

		private void CreateTournamentForm_Load(object sender, EventArgs e)
		{
			
			
		}

		

	}
}
