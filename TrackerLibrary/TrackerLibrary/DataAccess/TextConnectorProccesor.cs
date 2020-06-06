using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TrackerLibrary.Models;


namespace TrackerLibrary.DataAccess.TextHelpers 
{
	public static class TextConnectorProcessor
	{
		public static string FullFilePath(this string fileName)
		{
			//C:\Users\Bartek\Desktop\studiaATH\C#\tournament APP\tournament
			return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
		}

		public static List<string> LoadFile(this string file)
		{
			if (!File.Exists(file))
			{
				return new List<string>();
			}

			return File.ReadAllLines(file).ToList();
		}
		public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)

		{
			List<PrizeModel> output = new List<PrizeModel>();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				PrizeModel p = new PrizeModel();
				p.Id = int.Parse(cols[0]);
				p.PlaceNumber = int.Parse(cols[1]);
				p.PlaceName = cols[2];
				p.PrizeAmount = decimal.Parse(cols[3]);
				p.PrizePercentage = double.Parse(cols[4]);


				output.Add(p);

			}

			return output;
		}

		public static List<PersonModel> ConvertToPersonModels(this List<string> lines)

		{
			List<PersonModel> output = new List<PersonModel>();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				PersonModel p = new PersonModel();
				p.Id = int.Parse(cols[0]);
				p.FirstName = cols[1];
				p.LastName = cols[2];
				p.EmailAddress = cols[3];
				p.CellphoneNumber = cols[4];

				output.Add(p);
			}
			return output;

		}
		public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
		{
			List<string> lines = new List<string>();
			foreach (PrizeModel p in models)
			{
				lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizePercentage},{p.PrizePercentage}");

			}
			File.WriteAllLines(fileName.FullFilePath(), lines);
		}
		public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
		{
			List<string> lines = new List<string>();
			foreach (PersonModel p in models)
			{
				lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");

			}
			File.WriteAllLines(fileName.FullFilePath(), lines);
		}
		public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)

		{
			List<TeamModel> output = new List<TeamModel>();
			List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				TeamModel tm = new TeamModel();
				tm.Id = int.Parse(cols[0]);
				tm.TeamName = cols[1];

				string[] personIds = cols[2].Split('|');
				foreach (string id in personIds)
				{
					tm.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());

				}


				output.Add(tm);
			}
			return output;

		}

		public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
		{
			List<string> lines = new List<string>();
			foreach (TeamModel p in models)
			{

				lines.Add($"{p.Id},{ p.TeamName},{ConvertPeopleListToString(p.TeamMembers)}");
			}
			File.WriteAllLines(fileName.FullFilePath(), lines);


		}
		private static string ConvertPeopleListToString(List<PersonModel> people)
		{
			string output = "";
			if(people.Count==0)
			{
				return "";
			}

			foreach (PersonModel p in people)
			{
				output += $"{p.Id}|";
			}
			output = output.Substring(0, output.Length - 1);

			return output;
		}
		public static List<TournamentModel> ConvertToTournamentModel(this List<string> lines,string teamFileName,string prizesfileName,string peopleFileName)
		{
			List<TournamentModel> output = new List<TournamentModel>();

			List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
			List<PrizeModel> prizes = prizesfileName.FullFilePath().LoadFile().ConvertToPrizeModel();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');
   
				TournamentModel tm = new TournamentModel();

				
				tm.Id = int.Parse(cols[0]);
				tm.TournamentName = cols[1];
				tm.EntryFee = decimal.Parse(cols[2]);

				string[] teamIds = cols[3].Split('|');
				foreach (string id in teamIds)
				{
					tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());

				}
				string[] prizesIds = cols[4].Split('|');

				foreach (string id in prizesIds)
				{
					tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());

				}
				output.Add(tm);
			}
			return output;

		}

		public static void SaveToTournamentFile(this List <TournamentModel> models,string tournamentfile)

		{
			List<string> lines = new List<string>();

			foreach (TournamentModel tm in models)

			{
				lines.Add($"{tm.Id},{tm.TournamentName},{tm.EntryFee},{ConvertTeamsListToString(tm.EnteredTeams)},{ConvertPrizesListToString(tm.Prizes)},{ConvertRoundsListToString(tm.Rounds)}");

			}
			File.WriteAllLines(tournamentfile.FullFilePath(), lines);

		}

		private static string ConvertTeamsListToString(List<TeamModel> models)
		{
			string output = "";
			if(models.Count==0)
			{
				return "";
			}

			foreach (TeamModel tm in models)
			{
				output = output + $"{tm.Id}|";
			}
			output = output.Substring(0, output.Length-1);

			return output;
		}
		private static string ConvertPrizesListToString (List<PrizeModel> models)
		{
			string output = "";
			if(models.Count==0)
			{
				return ""; 
			}

			foreach (PrizeModel p in models)
			{
				output = output + $"{p.Id}|";

			}
			output = output.Substring(0, output.Length - 1);
				
			return output;
		}
		private static string ConvertRoundsListToString(List<List<MatchupModel>> rounds)
		{
			string output = "";
			if (rounds.Count == 0)
			{
				return "";
			}

			foreach (List<MatchupModel> r in rounds)
			{
				output = output + $"{ConvertMatchupListToString(r)}|";
			}
			output = output.Substring(0, output.Length - 1);

			return output;
		}
		private static string ConvertMatchupListToString(List<MatchupModel> matchups)
		{
			string output = "";
			if (matchups.Count == 0)
			{
				return "";
			}

			foreach (MatchupModel r in matchups)
			{
				output = output + $"{r.Id}|";
			}
			output = output.Substring(0, output.Length - 1);

			return output;
		}
	}
	

}
