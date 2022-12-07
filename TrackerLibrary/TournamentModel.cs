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
        /// Represents the name of the Tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the Entry fee each team has to pay.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents all the teams that have entered the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new();
        /// <summary>
        /// List of prizes for this tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new();
        /// <summary>
        /// List of Rounds, Each Round is list of matchups.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new();
    }
}
