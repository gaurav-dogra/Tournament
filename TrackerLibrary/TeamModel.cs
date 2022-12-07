using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represents the Team name.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Represents the Members of the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new();
    }
}
