﻿using System.Collections.Generic;

namespace TrackerLibrary.Models
{
	public class TeamModel
	{
		/// <summary>
		/// List members in the team.
		/// </summary>
		/// 
		public int Id { get; set; }
		public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
		public string TeamName { get; set; }

	}
}
