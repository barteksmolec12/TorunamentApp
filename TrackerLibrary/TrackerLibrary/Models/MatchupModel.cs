﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
	public class MatchupModel
	{
		/// <summary>
		/// The set of team that were involved in this match.
		/// </summary>
		public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

		/// <summary>
		/// The winner of the match.
		/// </summary>
		public TeamModel Winner { get; set; }
		/// <summary>
		/// Number of rounds.
		/// </summary>
		public int MatchupRound { get; set; }

	}
}