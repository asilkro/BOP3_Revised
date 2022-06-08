using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Security;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Silkroski_C969_Revised.Models
{
    public class DbConnection
    {
        #region Properties / Fields

        public MySqlConnection Connection => _connection; // Getter-only property keeps connection safe, lambda for ease of reading
        private MySqlConnection _connection;

        public bool IsConnected => _isConnected;
        private bool _isConnected;

        private string userID;
        private string password;

        #endregion


        #region Constructors

        public DbConnection()
        {

        }

        #endregion


        #region Methods

        public string BuildMySqlConnectionString(string userID, string password)
        {
            MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();
            connectionStringBuilder.UserID = userID;
            connectionStringBuilder.Password = password;
            connectionStringBuilder.Database = "client_schedule";
            connectionStringBuilder.Server = "localhost";
            connectionStringBuilder.AllowBatch = true; // allows sending multiple commands in one query -> CustomerForm queries may not work without this

            return connectionStringBuilder.ConnectionString;
        }

        public void Connect(string userID, string password)
        {
            if (_connection != null && _connection.State != ConnectionState.Closed)
            {
                MessageBox.Show("Not connecting, returning early");
                return;
            }

            this.userID = userID;
            this.password = password;
            string connectionString = BuildMySqlConnectionString(userID, password);
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
            _isConnected = true;
            
        }

        static private string GetConnectionString() // Maybe can remove later?
        {
            return "Server=localhost;Database=client_schedule;User Id=test;Password=test;AllowBatch=true;";
        }

        #endregion
    }
}
