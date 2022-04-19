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

        protected void GenerateSQLData()
        {
            //Setup
            var sqlScriptToRun = "dataForNewDB_ver4"; // TODO: define file
            string sqlConnectionString = null; // TODO: Make a sqlConnectionString that can connect to localhost
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
        private static void ExecuteSqlTransaction(string connectionString) // TODO: REMOVE THIS EXAMPLE
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "Insert into Region (RegionID, RegionDescription) VALUES (100, 'Description')";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "Insert into Region (RegionID, RegionDescription) VALUES (101, 'Description')";
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
        }
    }
}
