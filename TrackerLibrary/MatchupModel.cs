namespace TrackerLibrary
{
    /// <summary>
    /// Represent one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Set of teams that were involved in this match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new();
        /// <summary>
        /// Represent the winner of the Match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represent the Round number.
        /// </summary>
        public int Round { get; set; }
    }
}