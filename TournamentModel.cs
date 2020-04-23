using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the entry fee each team needs to pay 
        /// in order to join the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the list of all teams that 
        /// entered the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the List of Prizes each team can achieve 
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the list of rounds that will be played
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
