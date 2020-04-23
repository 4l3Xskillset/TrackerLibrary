using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the Entries of this matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the Winner of this matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the roundnumber of this matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
