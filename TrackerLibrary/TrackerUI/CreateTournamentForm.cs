using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class CreateTournamentForm : Form,IPrizeRequester,ITeamRequster
	{
		List<TeamModel> availalbelTeams = GlobalConfig.Connections.GetTeam_All();
		List<TeamModel> selectedTeams = new List<TeamModel>();
		List<PrizeModel> selectedPrizes = new List<PrizeModel>();
		public CreateTournamentForm()
		{
			InitializeComponent();
			InitializeList();
		}
		private void InitializeList()
		{
			selectTeamDropDown.DataSource = null;
			selectTeamDropDown.DataSource = availalbelTeams;
			selectTeamDropDown.DisplayMember = "TeamName";

			tournamentlistBox.DataSource = null;
			tournamentlistBox.DataSource = selectedTeams;
			tournamentlistBox.DisplayMember = "TeamName";

			prizeslistBox.DataSource = null;
			prizeslistBox.DataSource = selectedPrizes;
			prizeslistBox.DisplayMember = "PlaceName";
		}

		private void Toru_Click(object sender, EventArgs e)
		{

		}

		private void CreateTournamentForm_Load(object sender, EventArgs e)
		{

		}

		private void selectTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void addTeamButton_Click(object sender, EventArgs e)
		{
			TeamModel p = (TeamModel)selectTeamDropDown.SelectedItem;
			if (p != null)
			{
				availalbelTeams.Remove(p);
				selectedTeams.Add(p);
				InitializeList();
			}

		}

		private void createPrizeButton_Click(object sender, EventArgs e)
		{
			CreatePrizeForm frm = new CreatePrizeForm(this);
			frm.Show();
		}

		public void PrizeComplete(PrizeModel model)
		{
			selectedPrizes.Add(model);
			InitializeList();
		}

		private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CreateTeamForm frm = new CreateTeamForm(this);
			frm.Show();

		}

		public void TeamComplete(TeamModel model)
		{
			selectedTeams.Add(model);
			InitializeList();
			
		}

		private void deleteSelectedPlayers_Click(object sender, EventArgs e)
		{
			TeamModel tm = (TeamModel)tournamentlistBox.SelectedItem;
			if (tm != null)
			{
				availalbelTeams.Add(tm);
				selectedTeams.Remove(tm);
				InitializeList();
			}
		}

		private void deleteSelectedPrizes_Click(object sender, EventArgs e)
		{
			PrizeModel pm = (PrizeModel)prizeslistBox.SelectedItem;
			if (pm!=null)
			{ 
				selectedPrizes.Remove(pm);
				InitializeList();
			}
		}

		private void createTournamentbutton_Click(object sender, EventArgs e)
		{
			decimal fee = 0;
			bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);

			if (!feeAcceptable)
			{
				MessageBox.Show("You need to enter a valid Entry Fee", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			TournamentModel tm = new TournamentModel();
			tm.TournamentName = tournamentNameValue.Text;
			tm.EntryFee = fee;
			tm.EnteredTeams = selectedTeams;
			tm.Prizes = selectedPrizes; 
			GlobalConfig.Connections.CreateTournament(tm);


			
		}
	}
}
