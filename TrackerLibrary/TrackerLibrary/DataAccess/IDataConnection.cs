using System.Collections.Generic;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
	public interface IDataConnection
	{
		PrizeModel CreatePrize(PrizeModel model);
		PersonModel CreatePerson(PersonModel model);
		List<PersonModel> GetPerson_All();
		TeamModel CreateTeam(TeamModel model);

		TournamentModel CreateTournament(TournamentModel model);
		List<TeamModel> GetTeams_All();
	}
}
