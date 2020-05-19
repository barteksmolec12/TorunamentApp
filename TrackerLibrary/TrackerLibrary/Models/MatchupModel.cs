using System.Collections.Generic;

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
