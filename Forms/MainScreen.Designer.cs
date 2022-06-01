
namespace Silkroski_BOP3.Forms
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.appointments_DGV = new System.Windows.Forms.DataGridView();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.CreateCxBtn = new System.Windows.Forms.Button();
            this.UpdateCxBtn = new System.Windows.Forms.Button();
            this.RemoveCxBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AppointmentLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(771, 150);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // appointments_DGV
            // 
            this.appointments_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointments_DGV.Location = new System.Drawing.Point(15, 9);
            this.appointments_DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointments_DGV.Name = "appointments_DGV";
            this.appointments_DGV.RowTemplate.Height = 27;
            this.appointments_DGV.Size = new System.Drawing.Size(531, 307);
            this.appointments_DGV.TabIndex = 1;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(771, 467);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(129, 46);
            this.LogOutButton.TabIndex = 2;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(904, 467);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(129, 46);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 349);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Create Appt";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(219, 349);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 46);
            this.button4.TabIndex = 2;
            this.button4.Text = "Update Appt";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(418, 349);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 46);
            this.button5.TabIndex = 2;
            this.button5.Text = "Delete Appt";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // CreateCxBtn
            // 
            this.CreateCxBtn.Location = new System.Drawing.Point(15, 455);
            this.CreateCxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateCxBtn.Name = "CreateCxBtn";
            this.CreateCxBtn.Size = new System.Drawing.Size(129, 46);
            this.CreateCxBtn.TabIndex = 2;
            this.CreateCxBtn.Text = "Create Customer";
            this.CreateCxBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateCxBtn
            // 
            this.UpdateCxBtn.Location = new System.Drawing.Point(219, 455);
            this.UpdateCxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateCxBtn.Name = "UpdateCxBtn";
            this.UpdateCxBtn.Size = new System.Drawing.Size(129, 46);
            this.UpdateCxBtn.TabIndex = 2;
            this.UpdateCxBtn.Text = "Update Customer";
            this.UpdateCxBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveCxBtn
            // 
            this.RemoveCxBtn.Location = new System.Drawing.Point(418, 455);
            this.RemoveCxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveCxBtn.Name = "RemoveCxBtn";
            this.RemoveCxBtn.Size = new System.Drawing.Size(129, 46);
            this.RemoveCxBtn.TabIndex = 2;
            this.RemoveCxBtn.Text = "Remove Customer";
            this.RemoveCxBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "All Appointments";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 211);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "TBD View 2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(571, 270);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 46);
            this.button6.TabIndex = 2;
            this.button6.Text = "TBD View 3?";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 3;
            // 
            // AppointmentLabel
            // 
            this.AppointmentLabel.AutoSize = true;
            this.AppointmentLabel.Location = new System.Drawing.Point(580, 9);
            this.AppointmentLabel.Name = "AppointmentLabel";
            this.AppointmentLabel.Size = new System.Drawing.Size(91, 13);
            this.AppointmentLabel.TabIndex = 4;
            this.AppointmentLabel.Text = "Next Appointment";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(636, 467);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(129, 46);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.AppointmentLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.RemoveCxBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.UpdateCxBtn);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CreateCxBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.appointments_DGV);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Utility Tool - Logged In";
            ((System.ComponentModel.ISupportInitialize)(this.appointments_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView appointments_DGV;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button CreateCxBtn;
        private System.Windows.Forms.Button UpdateCxBtn;
        private System.Windows.Forms.Button RemoveCxBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AppointmentLabel;
        private System.Windows.Forms.Button RefreshButton;
    }
}