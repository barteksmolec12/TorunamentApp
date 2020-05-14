﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
	class TournamentModel
	{
		public string TournamentName { get; set; }
		public decimal EntryFee { get; set; }
	    public List<TeamModel> EnteredTeams { get; set; }
		public List<PrizeModel> Prizes { get; set; }
		public List<List<MatchupModel>> Rounds { get; set; }

	}


}
