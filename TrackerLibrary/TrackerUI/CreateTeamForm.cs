using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class CreateTeamForm : Form
	{
		private List<PersonModel> availableTeamMembers = GlobalConfig.Connections.GetPerson_All();
		private List<PersonModel> selectedTeamMemebers = new List<PersonModel>();
		public CreateTeamForm()
		{
			InitializeComponent();
			WireUpLists();
		}
		private void WireUpLists()
		{
			selectTeamMemberDropDown.DataSource = null;
			selectTeamMemberDropDown.DataSource = availableTeamMembers;
			selectTeamMemberDropDown.DisplayMember = "FullName";
			
			teamMembersListBox.DataSource = null;
			teamMembersListBox.DataSource = selectedTeamMemebers;
			teamMembersListBox.DisplayMember = "FullName";
		}
		private void createMemberButton_Click(object sender, EventArgs e)
		{
			if (ValidateForm() == true)
			{
				PersonModel p = new PersonModel();
				p.FirstName = firstNameValue.Text;
				p.LastName = lastNameValue.Text;
				p.EmailAddress = emailValue.Text;
				p.CellphoneNumber = cellphoneValue.Text;

				p=GlobalConfig.Connections.CreatePerson(p);
				selectedTeamMemebers.Add(p);
				WireUpLists(); 
				firstNameValue.Text = "";
				lastNameValue.Text = "";
				cellphoneValue.Text = "";
				emailValue.Text = "";
				
			}
			else
			{
				MessageBox.Show("You need fill in all fields ");
			}

			
		}

		private bool ValidateForm()
		{

			if (firstNameValue.Text.Length == 0 || lastNameValue.Text.Length == 0
				|| emailValue.Text.Length == 0 || cellphoneValue.Text.Length == 0)
			{
				return false;
			}

			return true;

		}

		private void addMemberButton_Click(object sender, EventArgs e)
		{
			PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
			availableTeamMembers.Remove(p);
			selectedTeamMemebers.Add(p);
			WireUpLists();

		}

		private void deleteSelectedMembersButton_Click(object sender, EventArgs e)
		{
			PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
			if (p != null)
			{
				selectedTeamMemebers.Remove(p);
				availableTeamMembers.Add(p);
				WireUpLists(); 
			}
		}

		private void CreateTeamForm_Load(object sender, EventArgs e)
		{

		}

		private void createTeamButton_Click(object sender, EventArgs e)
		{
			TeamModel t = new TeamModel();
			t.TeamMembers = selectedTeamMemebers;
			t.TeamName = teamNameValue.Text;
			t=GlobalConfig.Connections.CreateTeam(t);

			teamNameValue.Text = "";
			
		}
	} 
}
