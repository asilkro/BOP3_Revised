using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Silkroski_BOP3.Forms;
using Silkroski_C969_Revised.Models;

namespace Silkroski_BOP3
{
    public partial class LoginScreen : Form
    {
        protected string Sprache = null; // Used to track language

        public LoginScreen()
        {
            InitializeComponent();
            CultureInfo();
        }

        public LoginScreen(MainScreen mainScreen)
        {
            InitializeComponent();
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FieldsClear();
        }

        private void FieldsClear()
        {
            UserField.Text = null;
            PasswordField.Text = null;
        }

        #region Locale //TODO: Add error messages in 

        public void CultureInfo()
        {
            var twoLetterIsoLangName = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            if (twoLetterIsoLangName.ToString() == "de")
            {
                DeutschSprechen();
                return;
            }
            else
            {
                BackToEnglish();
                // MessageBox.Show($"{twoLetterIsoLangName}");
                return;
            }
            
        }


        public void DeutschSprechen()
        {
            UserIDLabel.Text = "Benutzer-ID";
            PasswordLabel.Text = "Passwort";
            LoginBtn.Text = "Anmelden";
            ClearBtn.Text = "Leeren";
            ExitBtn.Text = "Schließen";
            Sprache = "Deutsch";
        }

        public void BackToEnglish()
        {
            UserIDLabel.Text = "UserID";
            PasswordLabel.Text = "Password";
            LoginBtn.Text = "Login";
            ClearBtn.Text = "Clear";
            ExitBtn.Text = "Exit";
            Sprache = "Other";
        }

        private void GermanBtn_Click(object sender, EventArgs e)
        {
            if (Sprache == "Other")
            {
                DeutschSprechen();
            }
            else
            {
                BackToEnglish();
            }
        }

        public void GetTimeZoneOffset()
        {
            string tzOffset = null;
            tzOffset = "Placeholder";
            OffsetBox.Text = $"{tzOffset}";
        }

        public void GetTimeZoneLocal()
        {
            System.TimeZoneInfo tzLocal = System.TimeZoneInfo.Local;
            MessageBox.Show($"{tzLocal}","TimeZoneInfo - Local");
        }

        public void GetTimeZoneUtc()
        {
            System.TimeZoneInfo tzUtc = System.TimeZoneInfo.Utc;
            MessageBox.Show($"{tzUtc}","TimeZoneInfo - UTC");
        }

        #endregion

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //OpenSqlConnection();
            new MainScreen(this).Show();
            this.Hide();
        }

        private void OpenSqlConnection() // Found good info here: https://www.c-sharpcorner.com/blogs/how-to-use-sqlconnectionstringbuilder-in-c-sharp1
        {
            SqlConnection sqlConnection = new SqlConnection();
            
            //Building a connection string
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.UserID = UserField.Text.ToString(); // Should work
            connectionStringBuilder.Password = PasswordField.Text.ToString(); // Not sure this is valid
            connectionStringBuilder.DataSource = "LOCALHOST"; // Machine ID ?
            connectionStringBuilder.InitialCatalog = "appointment"; // Initial DB? Table?
            //Not required but maybe useful?
            connectionStringBuilder.ConnectRetryCount = 3;
            connectionStringBuilder.ConnectTimeout = 30;

            
            //Connecting
            sqlConnection.ConnectionString = connectionStringBuilder.ConnectionString;
            sqlConnection.Open();
            MessageBox.Show("Connection opened");
            sqlConnection.Close();
        }

        private void OpenSqlConnection2() // Alternative to connection builder
        {
            string myConnectionString = null;
            string outputMessage = null;

            myConnectionString = "server=127.0.0.1;uid=root;" +
                                 "pwd=12345;database=test";

            try //TODO: Review and make sure this works the way you want when you're not sick!
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                outputMessage = conn.State.ToString();
                LogWrite.WriteToLog(conn.State.ToString(outputMessage));
                conn.Open();
                outputMessage = conn.State.ToString();
                LogWrite.WriteToLog(conn.State.ToString(outputMessage));
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Error Handling

        

        public void Fehlerbehandlung()
        {
            //TODO: Error handling language in German
            MessageBox.Show("Bei Ihrer Anwendung ist ein Fehler aufgetreten.", "Fehlermeldung");
        }

        public void ErrorHandling()
        {
            //TODO: Error handling language in English
            MessageBox.Show("Your application encountered an error.", "Error Message");
        }

        #endregion

    }
}