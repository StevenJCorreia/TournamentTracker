using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one prize in a tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The palce number of the prize.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The place name of the prize.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The amount of money of the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The percentage of the entry fee per prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
