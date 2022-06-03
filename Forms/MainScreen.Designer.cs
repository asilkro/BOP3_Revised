
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
            this.appointments_DGV = new System.Windows.Forms.DataGridView();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.CreateApptBtn = new System.Windows.Forms.Button();
            this.EditApptBtn = new System.Windows.Forms.Button();
            this.DeleteApptBtn = new System.Windows.Forms.Button();
            this.CreateCxBtn = new System.Windows.Forms.Button();
            this.UpdateCxBtn = new System.Windows.Forms.Button();
            this.RemoveCxBtn = new System.Windows.Forms.Button();
            this.FullViewBtn = new System.Windows.Forms.Button();
            this.WeekViewBtn = new System.Windows.Forms.Button();
            this.MonthViewBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AppointmentLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.CxSearchTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // appointments_DGV
            // 
            this.appointments_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointments_DGV.Location = new System.Drawing.Point(45, 9);
            this.appointments_DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointments_DGV.Name = "appointments_DGV";
            this.appointments_DGV.RowTemplate.Height = 27;
            this.appointments_DGV.Size = new System.Drawing.Size(531, 307);
            this.appointments_DGV.TabIndex = 1;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(928, 592);
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
            this.QuitButton.Location = new System.Drawing.Point(1061, 592);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(129, 46);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CreateApptBtn
            // 
            this.CreateApptBtn.Location = new System.Drawing.Point(45, 396);
            this.CreateApptBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateApptBtn.Name = "CreateApptBtn";
            this.CreateApptBtn.Size = new System.Drawing.Size(129, 46);
            this.CreateApptBtn.TabIndex = 2;
            this.CreateApptBtn.Text = "Create Appointment";
            this.CreateApptBtn.UseVisualStyleBackColor = true;
            // 
            // EditApptBtn
            // 
            this.EditApptBtn.Location = new System.Drawing.Point(180, 396);
            this.EditApptBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditApptBtn.Name = "EditApptBtn";
            this.EditApptBtn.Size = new System.Drawing.Size(129, 46);
            this.EditApptBtn.TabIndex = 2;
            this.EditApptBtn.Text = "Edit Appointment";
            this.EditApptBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteApptBtn
            // 
            this.DeleteApptBtn.Location = new System.Drawing.Point(315, 396);
            this.DeleteApptBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteApptBtn.Name = "DeleteApptBtn";
            this.DeleteApptBtn.Size = new System.Drawing.Size(129, 46);
            this.DeleteApptBtn.TabIndex = 2;
            this.DeleteApptBtn.Text = "Delete Appointment";
            this.DeleteApptBtn.UseVisualStyleBackColor = true;
            // 
            // CreateCxBtn
            // 
            this.CreateCxBtn.Location = new System.Drawing.Point(656, 385);
            this.CreateCxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateCxBtn.Name = "CreateCxBtn";
            this.CreateCxBtn.Size = new System.Drawing.Size(129, 46);
            this.CreateCxBtn.TabIndex = 2;
            this.CreateCxBtn.Text = "Create Customer";
            this.CreateCxBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateCxBtn
            // 
            this.UpdateCxBtn.Location = new System.Drawing.Point(1061, 320);
            this.UpdateCxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateCxBtn.Name = "UpdateCxBtn";
            this.UpdateCxBtn.Size = new System.Drawing.Size(129, 46);
            this.UpdateCxBtn.TabIndex = 2;
            this.UpdateCxBtn.Text = "Update Customer";
            this.UpdateCxBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveCxBtn
            // 
            this.RemoveCxBtn.Location = new System.Drawing.Point(1061, 385);
            this.RemoveCxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveCxBtn.Name = "RemoveCxBtn";
            this.RemoveCxBtn.Size = new System.Drawing.Size(129, 46);
            this.RemoveCxBtn.TabIndex = 2;
            this.RemoveCxBtn.Text = "Remove Customer";
            this.RemoveCxBtn.UseVisualStyleBackColor = true;
            // 
            // FullViewBtn
            // 
            this.FullViewBtn.Location = new System.Drawing.Point(315, 320);
            this.FullViewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullViewBtn.Name = "FullViewBtn";
            this.FullViewBtn.Size = new System.Drawing.Size(129, 46);
            this.FullViewBtn.TabIndex = 2;
            this.FullViewBtn.Text = "All Appointments";
            this.FullViewBtn.UseVisualStyleBackColor = true;
            // 
            // WeekViewBtn
            // 
            this.WeekViewBtn.Location = new System.Drawing.Point(45, 320);
            this.WeekViewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekViewBtn.Name = "WeekViewBtn";
            this.WeekViewBtn.Size = new System.Drawing.Size(129, 46);
            this.WeekViewBtn.TabIndex = 2;
            this.WeekViewBtn.Text = "Current Week Appointments";
            this.WeekViewBtn.UseVisualStyleBackColor = true;
            // 
            // MonthViewBtn
            // 
            this.MonthViewBtn.Location = new System.Drawing.Point(180, 320);
            this.MonthViewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonthViewBtn.Name = "MonthViewBtn";
            this.MonthViewBtn.Size = new System.Drawing.Size(129, 46);
            this.MonthViewBtn.TabIndex = 2;
            this.MonthViewBtn.Text = "Current Month Appointments";
            this.MonthViewBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(450, 346);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 3;
            // 
            // AppointmentLabel
            // 
            this.AppointmentLabel.AutoSize = true;
            this.AppointmentLabel.Location = new System.Drawing.Point(466, 330);
            this.AppointmentLabel.Name = "AppointmentLabel";
            this.AppointmentLabel.Size = new System.Drawing.Size(91, 13);
            this.AppointmentLabel.TabIndex = 4;
            this.AppointmentLabel.Text = "Next Appointment";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(793, 592);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(129, 46);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(656, 320);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 46);
            this.button7.TabIndex = 2;
            this.button7.Text = "Search Customer";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // CxSearchTB
            // 
            this.CxSearchTB.Location = new System.Drawing.Point(799, 334);
            this.CxSearchTB.MaxLength = 256;
            this.CxSearchTB.Name = "CxSearchTB";
            this.CxSearchTB.Size = new System.Drawing.Size(252, 20);
            this.CxSearchTB.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(656, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(534, 307);
            this.dataGridView1.TabIndex = 1;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.CxSearchTB);
            this.Controls.Add(this.AppointmentLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.RemoveCxBtn);
            this.Controls.Add(this.DeleteApptBtn);
            this.Controls.Add(this.UpdateCxBtn);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.MonthViewBtn);
            this.Controls.Add(this.WeekViewBtn);
            this.Controls.Add(this.EditApptBtn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.CreateCxBtn);
            this.Controls.Add(this.FullViewBtn);
            this.Controls.Add(this.CreateApptBtn);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.appointments_DGV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Utility Tool - Logged In";
            ((System.ComponentModel.ISupportInitialize)(this.appointments_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView appointments_DGV;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button CreateApptBtn;
        private System.Windows.Forms.Button EditApptBtn;
        private System.Windows.Forms.Button DeleteApptBtn;
        private System.Windows.Forms.Button CreateCxBtn;
        private System.Windows.Forms.Button UpdateCxBtn;
        private System.Windows.Forms.Button RemoveCxBtn;
        private System.Windows.Forms.Button FullViewBtn;
        private System.Windows.Forms.Button WeekViewBtn;
        private System.Windows.Forms.Button MonthViewBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AppointmentLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox CxSearchTB;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}