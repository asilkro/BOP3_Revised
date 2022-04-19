
namespace Silkroski_BOP3
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.MaskedTextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.LocaleLanguageLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LocaleBox = new System.Windows.Forms.TextBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.LocalTimeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OffsetBox = new System.Windows.Forms.TextBox();
            this.OffsetLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserField
            // 
            this.UserField.Location = new System.Drawing.Point(457, 284);
            this.UserField.Name = "UserField";
            this.UserField.Size = new System.Drawing.Size(150, 25);
            this.UserField.TabIndex = 0;
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(639, 284);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(150, 25);
            this.PasswordField.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(457, 250);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(47, 17);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "UserID";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Location = new System.Drawing.Point(457, 250);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(47, 17);
            this.UserIDLabel.TabIndex = 2;
            this.UserIDLabel.Text = "UserID";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(639, 251);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(64, 17);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(639, 329);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(150, 60);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(457, 328);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(150, 60);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LocaleLanguageLabel
            // 
            this.LocaleLanguageLabel.AutoSize = true;
            this.LocaleLanguageLabel.Location = new System.Drawing.Point(71, 624);
            this.LocaleLanguageLabel.Name = "LocaleLanguageLabel";
            this.LocaleLanguageLabel.Size = new System.Drawing.Size(115, 17);
            this.LocaleLanguageLabel.TabIndex = 2;
            this.LocaleLanguageLabel.Text = "Locale / Language";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(1102, 609);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(150, 60);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // LocaleBox
            // 
            this.LocaleBox.Location = new System.Drawing.Point(71, 644);
            this.LocaleBox.Name = "LocaleBox";
            this.LocaleBox.ReadOnly = true;
            this.LocaleBox.Size = new System.Drawing.Size(150, 25);
            this.LocaleBox.TabIndex = 0;
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(71, 607);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(77, 17);
            this.debugLabel.TabIndex = 2;
            this.debugLabel.Text = "Debug Only";
            // 
            // LocalTimeBox
            // 
            this.LocalTimeBox.Location = new System.Drawing.Point(235, 644);
            this.LocalTimeBox.Name = "LocalTimeBox";
            this.LocalTimeBox.ReadOnly = true;
            this.LocalTimeBox.Size = new System.Drawing.Size(150, 25);
            this.LocalTimeBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Debug Only";
            // 
            // OffsetBox
            // 
            this.OffsetBox.Location = new System.Drawing.Point(401, 644);
            this.OffsetBox.Name = "OffsetBox";
            this.OffsetBox.ReadOnly = true;
            this.OffsetBox.Size = new System.Drawing.Size(150, 25);
            this.OffsetBox.TabIndex = 0;
            // 
            // OffsetLabel
            // 
            this.OffsetLabel.AutoSize = true;
            this.OffsetLabel.Location = new System.Drawing.Point(401, 624);
            this.OffsetLabel.Name = "OffsetLabel";
            this.OffsetLabel.Size = new System.Drawing.Size(136, 17);
            this.OffsetLabel.TabIndex = 2;
            this.OffsetLabel.Text = "Local Offset from UTC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Debug Only";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 853);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OffsetLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.LocaleLanguageLabel);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.OffsetBox);
            this.Controls.Add(this.LocalTimeBox);
            this.Controls.Add(this.LocaleBox);
            this.Controls.Add(this.UserField);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Utility Tool - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserField;
        private System.Windows.Forms.MaskedTextBox PasswordField;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label LocaleLanguageLabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox LocaleBox;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.TextBox LocalTimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OffsetBox;
        private System.Windows.Forms.Label OffsetLabel;
        private System.Windows.Forms.Label label4;
    }
}

