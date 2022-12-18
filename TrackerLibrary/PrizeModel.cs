namespace TrackerLibrary
{
    /// <summary>
    /// Represents what the prize is for the given place.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the Place as integer.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the place name.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the Prize Amount for this particular place.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of money for this particular place.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}