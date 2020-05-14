1 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
	public class MatchupModel
	{
		/// <summary>
		/// List of matches in the one round.
		/// </summary>
		public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

		/// <summary>
		/// The winner of matchup.
		/// </summary>
		public TeamModel Winner { get; set; }
		/// <summary>
		/// Number of rounds.
		/// </summary>
		public int MatchupRound { get; set; }

	}
}
