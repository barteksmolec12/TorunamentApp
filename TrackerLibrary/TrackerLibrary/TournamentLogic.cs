﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
	public static class TournamentLogic
	{
		public static void CreateRounds(TournamentModel model)
		{	
			//losowy układ drużyn
			List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
			//liczba wszytskich rund
			int rounds = FindNumberOfRounds(randomizedTeams.Count);
			//liczba byes do dodania
			int byes = NumberOfByes(rounds, randomizedTeams.Count);
			model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));

		}
		private static List<MatchupModel> CreateFirstRound(int byes,List<TeamModel> teams)
		{
			List<MatchupModel> output = new List<MatchupModel>();
			MatchupModel curr = new MatchupModel();

			foreach (TeamModel team in teams)
			{
				curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

				if(byes>0 || curr.Entries.Count>1)

				{
					curr.MatchupRound = 1;
					output.Add(curr);
					curr = new MatchupModel();
				} 
				if(byes>0)
				{
					byes = byes - 1;
				}

				
			}
			return output;
		}
		private static int NumberOfByes(int rounds,int numberOfTeams)
		{
			int output = 0;

			int totalTeams = 1;
			for (int i = 1; i <= rounds; i++)
			{
				totalTeams *= 2;
			}

			output = totalTeams - numberOfTeams;


			return output;
		}
		private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
		{
			List<TeamModel> output = new List<TeamModel>();

			output = teams.OrderBy(a => Guid.NewGuid()).ToList();
			return output;

		}
		private static int FindNumberOfRounds(int teamCount)
		{
			int output = 1;
			int val = 2;
			while(val<teamCount)
			{
				output += 1;
				val *= 2;
			}
			return output;
		} 

	}
}
