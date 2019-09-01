using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one team.
    /// </summary>
    public class TeamModel
    {
        public int id { get; set; }
        /// <summary>
        /// The name of this team.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// The set of members in this team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
