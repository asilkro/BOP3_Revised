using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_BOP3.Models;

namespace Silkroski_BOP3.Forms
{
    public partial class MainScreen : Form
    {
        public static DbConnection Connection => _connection; //Read-only accessor with Lambda for ease of reading
        private static DbConnection _connection;

        public static MainScreen Instance => _instance; //Read-only accessor with Lambda for ease of reading
        private static MainScreen _instance;

        LoginScreen loginScreen;

        public MainScreen()
        {
            InitializeComponent();
            _instance = this;
            _connection = new DbConnection();

            MessageBox.Show("Please login to continue", "Login required");


            Login();
        }
        
        public MainScreen(LoginScreen loginScreen) : this()
        {
            this.loginScreen = loginScreen;
        }

        private void Login()
        {
            if (loginScreen == null)
            {
                loginScreen = new LoginScreen(this);
            }

            loginScreen.Show();
            this.Hide();
            this.Visible = false;

        }

        public void OnLoginSubmitted(string userID, string password)
        {
            Connection.Connect(userID, password);
        }

        private void Logout()
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refreshing data");
        }

        private void DataGridViewPop()
        {
            //TODO: Implement something that populates the DGV & does "print"
            SqlConnectionCheck(); // This needs to do something
            DataGridView mainDataGridView = new DataGridView();
            DataTable mainDataTable = new DataTable();
            MySqlDataAdapter mainMySqlDataAdapter = new MySqlDataAdapter();
            mainMySqlDataAdapter.FillAsync(mainDataTable);
            mainDataGridView.DataSource = mainDataTable;
            mainDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void SqlConnectionCheck()
        {
            //TODO: Check SQL connection state -> need to figure out how to record/read the state
        }

        protected void GenerateSQLData()
        {
            //Setup
            var sqlScriptToRun = "dataForNewDB_ver4"; // TODO: define file
            string sqlConnectionString = null; // TODO: Make a sqlConnectionString that can connect to localhost (re-use from LoginScreen)
            var sqlAllText = File.ReadAllText(sqlScriptToRun); // Get all the text in the script
            SqlConnection connection = new SqlConnection(sqlConnectionString); // Create new SQL connection

            SqlCommand command = connection.CreateCommand();
            SqlTransaction transaction = connection.BeginTransaction("Populate DBs");

            //Actual code
            try
            {
                command = new SqlCommand(sqlAllText.ToString(), connection);
                command.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Data in tables has been populated.", "Successfully committed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                transaction.Rollback();
                throw;
                MessageBox.Show("Rollback successful", "Commit failed");
            }
            connection.Close();

        }
        #region Error Checking



        #endregion

        #region Alerting



        #endregion

        #region Button Functions

        private void CreateCustomer()
        {
            //TODO
            MessageBox.Show("Implement a create customer form");
        }

        private void UpdateCustomer()
        {
            //TODO
            MessageBox.Show("Implement an update customer form");
        }

        private void RemoveCustomer()
        {
            //TODO
            MessageBox.Show("Implement a remove customer form");
        }

        private void CreateAppt()
        {
            //TODO
            MessageBox.Show("Implement a create appt form");
        }

        private void UpdateAppt()
        {
            //TODO
            MessageBox.Show("Implement an update customer form");
        }

        private void RemoveAppt()
        {
            //TODO
            MessageBox.Show("Implement a remove customer form");
        }
        #endregion

        private void MainScreen_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please login to continue", "Login required");
            Login();
        }
    }

}
