
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
            this.debugSQLbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserField
            // 
            this.UserField.Location = new System.Drawing.Point(392, 217);
            this.UserField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserField.Name = "UserField";
            this.UserField.Size = new System.Drawing.Size(129, 20);
            this.UserField.TabIndex = 0;
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(548, 217);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(129, 20);
            this.PasswordField.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(392, 191);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(40, 13);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "UserID";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Location = new System.Drawing.Point(392, 191);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(40, 13);
            this.UserIDLabel.TabIndex = 2;
            this.UserIDLabel.Text = "UserID";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(548, 192);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(548, 252);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(129, 46);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(392, 251);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(129, 46);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LocaleLanguageLabel
            // 
            this.LocaleLanguageLabel.AutoSize = true;
            this.LocaleLanguageLabel.Location = new System.Drawing.Point(61, 477);
            this.LocaleLanguageLabel.Name = "LocaleLanguageLabel";
            this.LocaleLanguageLabel.Size = new System.Drawing.Size(98, 13);
            this.LocaleLanguageLabel.TabIndex = 2;
            this.LocaleLanguageLabel.Text = "Locale / Language";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(945, 466);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(129, 46);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // LocaleBox
            // 
            this.LocaleBox.Location = new System.Drawing.Point(61, 492);
            this.LocaleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocaleBox.Name = "LocaleBox";
            this.LocaleBox.ReadOnly = true;
            this.LocaleBox.Size = new System.Drawing.Size(129, 20);
            this.LocaleBox.TabIndex = 0;
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(61, 464);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(63, 13);
            this.debugLabel.TabIndex = 2;
            this.debugLabel.Text = "Debug Only";
            // 
            // LocalTimeBox
            // 
            this.LocalTimeBox.Location = new System.Drawing.Point(201, 492);
            this.LocalTimeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocalTimeBox.Name = "LocalTimeBox";
            this.LocalTimeBox.ReadOnly = true;
            this.LocalTimeBox.Size = new System.Drawing.Size(129, 20);
            this.LocalTimeBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Debug Only";
            // 
            // OffsetBox
            // 
            this.OffsetBox.Location = new System.Drawing.Point(344, 492);
            this.OffsetBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OffsetBox.Name = "OffsetBox";
            this.OffsetBox.ReadOnly = true;
            this.OffsetBox.Size = new System.Drawing.Size(129, 20);
            this.OffsetBox.TabIndex = 0;
            // 
            // OffsetLabel
            // 
            this.OffsetLabel.AutoSize = true;
            this.OffsetLabel.Location = new System.Drawing.Point(344, 477);
            this.OffsetLabel.Name = "OffsetLabel";
            this.OffsetLabel.Size = new System.Drawing.Size(112, 13);
            this.OffsetLabel.TabIndex = 2;
            this.OffsetLabel.Text = "Local Offset from UTC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Debug Only";
            // 
            // debugSQLbutton
            // 
            this.debugSQLbutton.Location = new System.Drawing.Point(759, 464);
            this.debugSQLbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debugSQLbutton.Name = "debugSQLbutton";
            this.debugSQLbutton.Size = new System.Drawing.Size(129, 46);
            this.debugSQLbutton.TabIndex = 3;
            this.debugSQLbutton.Text = "Debug SQL";
            this.debugSQLbutton.UseVisualStyleBackColor = true;
            this.debugSQLbutton.Click += new System.EventHandler(this.debugSQLbutton_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 652);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.debugSQLbutton);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Utility Tool - Login";
            this.TopMost = true;
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
        private System.Windows.Forms.Button debugSQLbutton;
    }
}

