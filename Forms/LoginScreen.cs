﻿using MySql;
using System;
using System.Globalization;
using System.Windows.Forms;
using Silkroski_BOP3.Forms;

namespace Silkroski_BOP3
{
    public partial class LoginScreen : Form
    {
        public string Language => _language; // Getter-only property keeps connection safe, lambda for ease of reading
        private string _language;

        #region Constructors
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

        #endregion

        #region Methods

        private void FieldsClear()
        {
            UserField.Text = null;
            PasswordField.Text = null;
        }

        #endregion


        #region Languages / Sprache //TODO: Add error messages in German

        private void SetLanguage()
        {
            switch (RegionInfo.CurrentRegion.EnglishName)
            {
                case "United States":
                    SetToEnglish();
                    _language = "US-EN";
                    break;

                case "Germany":
                    SetToGerman();
                    _language = "DE-DE";
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

        public void Fehlerbehandlung() // Generic message in English
        {
            //TODO: Error handling language in German
            MessageBox.Show("Bei Ihrer Anwendung ist ein Fehler aufgetreten.", "Fehlermeldung");
        }

        public void ErrorHandling() // Generic message in English
        {
            //TODO: Error handling language in English
            MessageBox.Show("Your application encountered an error.", "Error Message");
        }

        #endregion
        

        #region Error Handling

        //TODO: Error handling section

        #endregion

        #region Events

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserField.Text == "test" && PasswordField.Text == "test") // a valid login
            {
                MainScreen.Instance.OnLoginSubmitted(UserField.Text, PasswordField.Text);
            }
            else
            {
                if (Language == "DE-DE")
                {
                    Fehlerbehandlung();
                }
                else
                {
                    ErrorHandling();
                }
                // MessageBox.Show("Invalid login", "Login error"); //This should be unnecessary now.
            }
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FieldsClear();
        }

        #endregion

    }
}