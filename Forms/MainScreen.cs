using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969_Revised.Models;

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
            PopulateAllAppointments();
        }

        private void Logout()
        {
            Connection.Connection.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refreshing data");
        }

        private void PopulateAllAppointments()
        {
            //TODO: Implement something that populates the DGV & does "print"
            if (IsMySQLConnected() == true)
            {
                //Define variables
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * from appointment"; //Select all appointments
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Connection.Connection);
                DataTable appointmentsDataTable = new DataTable();
                BindingSource bindingSource = new BindingSource();
                
                //Start
                MyDA.Fill(appointmentsDataTable);
                bindingSource.DataSource = appointmentsDataTable;

                dataGridView1.DataSource = bindingSource;
            }
            else
            {
                MessageBox.Show("Active SQL connection not found." +
                                "Please try re-logging in.",
                    "SQL Connection not found");
                Logout();
            }

        }

        public bool IsMySQLConnected()
        {
            if (Connection.Connection.State == ConnectionState.Open)
            {
                return true;
            }

            return false;
        }

        #region Error Checking

        //TODO: Error checking / handling

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
