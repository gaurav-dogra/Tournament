namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                SqlConnector sqlConnector = new();
                Connections.Add(sqlConnector);
                //TODO - setup the sql connector properly
            }

            if (textFiles)
            {
                TextConnector text = new();
                Connections.Add(text);
                //TODO - setup the text file connector properly
            }
        }
    }
}
