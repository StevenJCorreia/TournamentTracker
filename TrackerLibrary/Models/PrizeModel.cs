using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one prize in a tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int id { get; set; }
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
        /// <summary>
        /// Normal class constructor.
        /// </summary>
        public PrizeModel()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
