namespace TrackerLibrary
{
    public class PrizeModel
    {
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