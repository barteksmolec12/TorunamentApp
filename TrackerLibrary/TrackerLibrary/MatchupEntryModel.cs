﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
	public class MatchupEntryModel
	{
		/// <summary>
		/// Represents one team in the Matchup
		/// </summary>
		public TeamModel TeamCompeting { get; set; }
		/// <summary>
		/// Represent the score for one team.
		/// </summary>
		public double Score { get; set; }
		/// <summary>
		/// Represents the matchup that this team came from as the winner.
		/// </summary>
		public MatchupModel ParentMathchup { get; set; }
	}
}
 