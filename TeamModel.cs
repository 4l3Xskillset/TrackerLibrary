using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class TeamModel
    {
        /// <summary>
        /// Represents the list of all team members of the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents hte Name of the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
