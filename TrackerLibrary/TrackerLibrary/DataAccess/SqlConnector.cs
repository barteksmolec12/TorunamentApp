using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
	public class SqlConnector : IDataConnection
	{   // TODO - Make the CreatePrize method actually save to the database.
		/// <summary>
		/// Save to a new prize to the database.
		/// </summary>
		/// <param name="model">The prize information</param>  
		/// <returns>The prize information, including the unique identifier</returns>
		public PrizeModel CreatePrize(PrizeModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
			{
				var p = new DynamicParameters();
				p.Add("@PlaceNumber", model.PlaceNumber);
				p.Add("@PlaceName", model.PlaceName);
				p.Add("@PrizeAmount", model.PrizeAmount);
				p.Add("@PrizePercentage", model.PrizePercentage);
				p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("dbo.spPrize_Insert", p, commandType: CommandType.StoredProcedure);
				model.Id = p.Get<int>("@id");
				//model.Id = p.Get<int>("@id");
				return model;
			}
		}
		public PersonModel CreatePerson(PersonModel model)
		{

			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
			{
				var p = new DynamicParameters();
				p.Add("@FirstName", model.FirstName);
				p.Add("@LastName", model.LastName);
				p.Add("@EmailAddress", model.EmailAddress);
				p.Add("@CellphoneNumber", model.CellphoneNumber);
				p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("dbo.sp_People_Insert", p, commandType: CommandType.StoredProcedure);
				model.Id = p.Get<int>("@id");
				//model.Id = p.Get<int>("@id");
				return model;
			}

		}

		public List<PersonModel> GetPerson_All()

		{
			List<PersonModel> output;
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
			{
				output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();

			}
			return output;
		}

		public TeamModel CreateTeam(TeamModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
			{
				var p = new DynamicParameters();
				p.Add("@TeamName", model.TeamName);
				p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


				connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);
				model.Id = p.Get<int>("@id");
				foreach (PersonModel tp in model.TeamMembers)
				{
					p = new DynamicParameters();
					p.Add("@TeamId", model.Id);
					p.Add("@PersonId", tp.Id);
					connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);

				}

			}
			return model;

		}

		public List<TeamModel> GetTeam_All()
		{
			List<TeamModel> output;
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
			{
				output = connection.Query<TeamModel>("dbo.spTeams_GetAll").ToList();
				foreach (TeamModel team in output)
				{
					var p = new DynamicParameters();
					p.Add("@TeamId", team.Id);

					team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam ", p, commandType: CommandType.StoredProcedure).ToList();

				}
			}
			return output;
		}

		public TournamentModel CreateTournament(TournamentModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
			{


				SaveTournament(connection, model);          // add to Tournaments
			    SaveTournamentPrizes(connection, model);    // add to TournamentsPrizes
				SaveTournamentEntries(connection, model);   // add to TournamentsEntries

			}
			return model;
		}

		private void SaveTournament (IDbConnection connection,TournamentModel model)
		{
			var p = new DynamicParameters();
			p.Add("@TournamentName", model.TournamentName);
			p.Add("@EntryFee", model.EntryFee);
			p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


			connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);
			model.Id = p.Get<int>("@id");
		}
		private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
		{
			foreach (PrizeModel pm in model.Prizes)
			{
				var p = new DynamicParameters();
				p.Add("@TournamentId", model.Id);
				p.Add("@PrizeId", pm.Id);
				p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
				connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);

			}

		}
		private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
		{
			foreach (TeamModel tm in model.EnteredTeams)
			{
				var p = new DynamicParameters();
				p.Add("@TournamentId", model.Id);
				p.Add("@TeamId", tm.Id);
				p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
				connection.Execute("dbo.TournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);

			}

		}



	}
}
