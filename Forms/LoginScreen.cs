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

namespace Silkroski_BOP3
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            GetLocale();
            GetLocalTime();
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

        #region Locale

        public void GetLocale()
        {
            CultureInfo ci = CultureInfo.InstalledUICulture;
            LocaleBox.Text = $"{ci}";
        }

        public void GetLocalTime()
        {
            System.DateTime dtLocalTime = DateTime.Now.ToLocalTime();
            LocalTimeBox.Text = $"{dtLocalTime}";
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
    }
}