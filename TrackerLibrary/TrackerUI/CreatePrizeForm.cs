using System;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class CreatePrizeForm : Form
	{
		IPrizeRequester callingForm;
		public CreatePrizeForm(IPrizeRequester caller)
		{
			

			InitializeComponent();
			callingForm = caller;
		}

		private void createPrizeButton_Click(object sender, EventArgs e)
		{
			if (ValidateForm() == true)
			{
				PrizeModel model = new PrizeModel(
					placeNameValue.Text,
					placeNumberValue.Text,
					prizeAmountVal.Text,
					prizePercentageValue.Text);

				GlobalConfig.Connections.CreatePrize(model);
				callingForm.PrizeComplete(model);
				this.Close();
				//placeNameValue.Text = "";
				//placeNumberValue.Text = "";
				//prizeAmountVal.Text = "0";
				//prizePercentageValue.Text = "0";

			}
			else
			{
				MessageBox.Show("This form has invalid information");

			}

		}
		private bool ValidateForm()
		{
			bool output = true;
			int placeNumber = 0;

			bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

			if (!placeNumberValidNumber)
			{
				output = false;
			}

			if (placeNumber < 1)
			{
				output = false;

			}
			if (placeNameValue.Text.Length == 0)
			{
				output = false;

			}
			decimal prizeAmount = 0;
			double prizePercentage = 0;
			bool prizeAmountValid = decimal.TryParse(prizeAmountVal.Text, out prizeAmount);
			bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);
			if (!prizeAmountValid || !prizePercentageValid)
			{
				output = false;
			}

			if (prizeAmount <= 0 && prizePercentage <= 0)
			{
				output = false;
			}
			if (prizePercentage < 0 || prizePercentage > 100)
			{
				output = false;
			}

			return output;
		}

		private void CreatePrizeForm_Load(object sender, EventArgs e)
		{

		}
	}
}
