namespace TrackerLibrary.Models
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
