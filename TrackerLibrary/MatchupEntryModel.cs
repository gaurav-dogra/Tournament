namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represent one team in the Matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup this team came from as a winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}