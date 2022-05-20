﻿using System;
using System.Globalization;
using System.Windows.Forms;
using Silkroski_BOP3.Forms;
using Silkroski_C969_Revised.Models;

namespace Silkroski_BOP3
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            SetLanguage();
        }

        public LoginScreen(MainScreen mainScreen)
        {
            InitializeComponent();
            SetLanguage();
            mainScreen.Hide();
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

        #region Locale //TODO: Add error messages in German

        private void SetLanguage()
        {
            switch (RegionInfo.CurrentRegion.EnglishName)
            {
                case "United States":
                    SetToEnglish();
                    break;

                case "Germany":
                    SetToGerman();
                    break;

                default:
                    SetToEnglish();
                    break;

            }
        }

        public void SetToGerman()
        {
            UserIDLabel.Text = "Benutzer-ID";
            PasswordLabel.Text = "Passwort";
            LoginBtn.Text = "Anmelden";
            ClearBtn.Text = "Leeren";
            ExitBtn.Text = "Schließen";
        }

        public void SetToEnglish()
        {
            UserIDLabel.Text = "UserID";
            PasswordLabel.Text = "Password";
            LoginBtn.Text = "Login";
            ClearBtn.Text = "Clear";
            ExitBtn.Text = "Exit";
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
            MainScreen.Instance.OnLoginSubmitted(UserField.Text, PasswordField.Text);
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

        private void debugSQLbutton_Click(object sender, EventArgs e)
        {

        }
    }
}