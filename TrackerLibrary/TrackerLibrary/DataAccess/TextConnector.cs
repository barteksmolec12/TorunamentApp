using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAccess

{
	public class TextConnector : IDataConnection
	{

		private const string PrizesFile = "PrizeModels.csv";
		private const string PeopleFile = "PersonModels.csv";
		private const string TeamFile = "TeamModels.csv";
		//TODO - Wire up the CreatePrize for text files.
		public PrizeModel CreatePrize(PrizeModel model)
		{
			List<PrizeModel> prizes= PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

			int curentId = 1;
			if (prizes.Count > 0)
			{
				curentId= prizes.OrderByDescending(x => x.Id).First().Id + 1; ;
			}
			model.Id = curentId;
			prizes.Add(model);
			prizes.SaveToPrizeFile(PrizesFile);
			return model;

		}
		public PersonModel CreatePerson(PersonModel model)
		{
			List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
			int curentId = 1;
			if (people.Count > 0)
			{
				curentId = people.OrderByDescending(x => x.Id).First().Id + 1; ;
			}
			model.Id = curentId;
			people.Add(model);
			people.SaveToPersonFile(PeopleFile);

			return model;
		}

		public List<PersonModel> GetPerson_All()
		{
			return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
		}

		public TeamModel CreateTeam(TeamModel model)
		{
			List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

			int curentId = 1;
			if (teams.Count > 0)
			{
				curentId = teams.OrderByDescending(x => x.Id).First().Id + 1; ;
			}
			model.Id = curentId;
			teams.Add(model);
			teams.SaveToTeamFile(TeamFile);   
			return model;
		}

		public List<TeamModel> GetTeam_All()
		{
			throw new System.NotImplementedException();
		}
	}
}
