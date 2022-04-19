namespace Silkroski_BOP3.Models
{
    public class Connection
    {
        #region Properties / Fields
        
        public string ServerName { get; set; }
        public string Url { get; set; }
        public int PortNumber { get; set; }
        public DateTime TimeConnected { get; set; }
        public DateTime TimeDisconnected { get; set; }
        // What else would I want/need as part of this class?

        #endregion

        #region Constructors

        public Connection()
        {

        }

        public Connection(string serverName, string url, int portNumber)
        {
            ServerName = serverName;
            Url = url;
            PortNumber = portNumber;
        }

        public Connection(string serverName, string url, int portNumber, DateTime timeConnected, DateTime timeDisconnected)
        {
            ServerName = serverName;
            Url = url;
            PortNumber = portNumber;
            TimeConnected = timeConnected;
            TimeDisconnected = timeDisconnected;
        }

        #endregion
    }
}