using SaggerLookup.Properties;

namespace SaggerLookup.CherwellConnector
{
    public class ConnectionSettings
    {
        public static ConnectionConfiguration Connection { get; set; }
    }

    public class Connections
    {
        public ConnectionConfiguration GetConnectionConfiguration()
        {
            return new ConnectionConfiguration
            {
                ClientID = "ac11c29e-059f-4948-a6ce-ed3b9f96d7e4",
                ConnectionString = "https://demo.mobile1.co.za",
                CherwellAPI = @"/CherwellAPI",
                CherwellPortal = @"/CherwellPortal"
            };
        }
    }

    public class ConnectionConfiguration
    {
        public string ClientID { get; set; }
        public string ConnectionString { get; set; }
        public string CherwellAPI { get; set; }
        public string CherwellPortal { get; set; }
    }
}