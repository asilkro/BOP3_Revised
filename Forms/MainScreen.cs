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
using Silkroski_BOP3.Models;

namespace Silkroski_BOP3.Forms
{
    public partial class MainScreen : Form
    {
        LoginScreen loginScreen;

        public MainScreen(LoginScreen loginScreen)
        {
            InitializeComponent();
            this.loginScreen = loginScreen;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            new LoginScreen(this).Show();
            this.Close();
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
            DataGridView dgv = new DataGridView();
            //TODO: Implement something that populates the DGV & does "print"

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
        #endregion

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

    }

}
