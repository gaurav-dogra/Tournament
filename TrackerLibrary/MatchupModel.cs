namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// 
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