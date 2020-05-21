using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//Initaize the database connections
			GlobalConfig.InitializeConnections(DatabaseType.TextFile);
			Application.Run(new CreateTeamForm());
		}
	}
}
