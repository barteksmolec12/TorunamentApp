using System;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class CreateTeamForm : Form
	{
		public CreateTeamForm()
		{
			InitializeComponent();
		}
		private void createMemberButton_Click(object sender, EventArgs e)
		{
			 if(ValidateForm()==true)
			{
				PersonModel p = new PersonModel();
				p.FirstName = firstNameValue.Text;
				p.LastName = lastNameValue.Text;
				p.EmailAddress = emailValue.Text;
				p.CellphoneNumber = cellphoneValue.Text;

				GlobalConfig.Connections.CreatePerson(p);

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

			 if  (firstNameValue.Text.Length==0 || lastNameValue.Text.Length == 0
		         || emailValue.Text.Length==0 || cellphoneValue.Text.Length == 0)
			{
				return false;
			}
		
			return true;

		}
	}
}
