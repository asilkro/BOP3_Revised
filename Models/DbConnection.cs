using System;
using System.Data;
using System.Data.SqlClient;
using System.Security;
using System.Windows.Forms;
using Silkroski_C969_Revised.Properties;

namespace Silkroski_C969_Revised.Models
{
    public class DbConnection
    {
        #region Properties / Fields

        public SqlConnection Connection => _connection; // Getter-only property keeps connection safe, lambda for ease of reading
        private SqlConnection _connection;

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
            string connectionString = BuildSqlConnectionString(userID, password);
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _isConnected = true;
        }
        
        private string BuildSqlConnectionString(string userID, string password)
        {
            //Build a connection string
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(); // https://www.c-sharpcorner.com/blogs/how-to-use-sqlconnectionstringbuilder-in-c-sharp1
            connectionStringBuilder.UserID = userID;
            connectionStringBuilder.Password = password;
            connectionStringBuilder.Authentication = SqlAuthenticationMethod.SqlPassword;
            connectionStringBuilder.ApplicationName = "Silkroski_BOP3";
            connectionStringBuilder.InitialCatalog = "application"; //TODO: Find out what the actual DB is supposed to be called
            connectionStringBuilder.DataSource = "LOCALHOST";
            // This all matches the data that MySQL Workbench used

            return connectionStringBuilder.ConnectionString;
        }

        #endregion
    }
}
