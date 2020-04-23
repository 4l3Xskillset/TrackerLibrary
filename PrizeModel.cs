using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place of the team that gets a prize
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the place that the team achieved 
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount of the prize that the team gets
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the overall prize amount 
        /// the team gets
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
