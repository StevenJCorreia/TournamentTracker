using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextProcessor;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        /// <summary>
        /// Saves a new prize to a text file
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentID = 1;

            if (prizes.Count > 0)
            {
                currentID = prizes.OrderByDescending(x => x.id).First().id++;
            }

            model.id = currentID;

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
