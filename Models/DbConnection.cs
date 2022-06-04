using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security;
using System.Windows.Forms;
using Silkroski_C969_Revised.Properties;
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

        public void Connect(string userID, string password)
        {
            if (_connection != null && _connection.State != ConnectionState.Closed)
            {
                return;
            }

            this.userID = userID;
            this.password = password;
            string connectionString = BuildMySqlConnectionString(userID, password);
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
            _isConnected = true;
        }
        

        private string BuildMySqlConnectionString(string userID, string password)
        {
            MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();
            connectionStringBuilder.UserID = userID;
            connectionStringBuilder.Password = password;
            connectionStringBuilder.Database = "client_schedule";
            connectionStringBuilder.Server = "localhost";

            return connectionStringBuilder.ConnectionString;
        }

        #endregion
    }
}
