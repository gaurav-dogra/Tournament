namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
            //Todo - Save the model in txt file
        }
    }
}
