
namespace Silkroski_C969_Revised.Forms
{
    partial class CustomerForm
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
            this.CxNameTB = new System.Windows.Forms.TextBox();
            this.CxNameLabel = new System.Windows.Forms.Label();
            this.CxAddress1TB = new System.Windows.Forms.TextBox();
            this.CxAddress1Label = new System.Windows.Forms.Label();
            this.CxAddress2TB = new System.Windows.Forms.TextBox();
            this.CxAddress2Label = new System.Windows.Forms.Label();
            this.CxCityTB = new System.Windows.Forms.TextBox();
            this.CxCountryTB = new System.Windows.Forms.TextBox();
            this.CxPostalTB = new System.Windows.Forms.TextBox();
            this.CxCityLabel = new System.Windows.Forms.Label();
            this.CxCountryLabel = new System.Windows.Forms.Label();
            this.CxZIPLabel = new System.Windows.Forms.Label();
            this.CxSaveButton = new System.Windows.Forms.Button();
            this.CxCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CxNameTB
            // 
            this.CxNameTB.Location = new System.Drawing.Point(81, 176);
            this.CxNameTB.Name = "CxNameTB";
            this.CxNameTB.Size = new System.Drawing.Size(209, 20);
            this.CxNameTB.TabIndex = 0;
            // 
            // CxNameLabel
            // 
            this.CxNameLabel.AutoSize = true;
            this.CxNameLabel.Location = new System.Drawing.Point(78, 160);
            this.CxNameLabel.Name = "CxNameLabel";
            this.CxNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CxNameLabel.TabIndex = 1;
            this.CxNameLabel.Text = "Customer Name";
            // 
            // CxAddress1TB
            // 
            this.CxAddress1TB.Location = new System.Drawing.Point(81, 230);
            this.CxAddress1TB.Name = "CxAddress1TB";
            this.CxAddress1TB.Size = new System.Drawing.Size(209, 20);
            this.CxAddress1TB.TabIndex = 0;
            // 
            // CxAddress1Label
            // 
            this.CxAddress1Label.AutoSize = true;
            this.CxAddress1Label.Location = new System.Drawing.Point(78, 214);
            this.CxAddress1Label.Name = "CxAddress1Label";
            this.CxAddress1Label.Size = new System.Drawing.Size(98, 13);
            this.CxAddress1Label.TabIndex = 1;
            this.CxAddress1Label.Text = "Customer Address1";
            // 
            // CxAddress2TB
            // 
            this.CxAddress2TB.Location = new System.Drawing.Point(81, 289);
            this.CxAddress2TB.Name = "CxAddress2TB";
            this.CxAddress2TB.Size = new System.Drawing.Size(209, 20);
            this.CxAddress2TB.TabIndex = 0;
            // 
            // CxAddress2Label
            // 
            this.CxAddress2Label.AutoSize = true;
            this.CxAddress2Label.Location = new System.Drawing.Point(78, 273);
            this.CxAddress2Label.Name = "CxAddress2Label";
            this.CxAddress2Label.Size = new System.Drawing.Size(101, 13);
            this.CxAddress2Label.TabIndex = 1;
            this.CxAddress2Label.Text = "Customer Address 2";
            // 
            // CxCityTB
            // 
            this.CxCityTB.Location = new System.Drawing.Point(329, 176);
            this.CxCityTB.Name = "CxCityTB";
            this.CxCityTB.Size = new System.Drawing.Size(209, 20);
            this.CxCityTB.TabIndex = 0;
            // 
            // CxCountryTB
            // 
            this.CxCountryTB.Location = new System.Drawing.Point(329, 289);
            this.CxCountryTB.Name = "CxCountryTB";
            this.CxCountryTB.Size = new System.Drawing.Size(209, 20);
            this.CxCountryTB.TabIndex = 0;
            // 
            // CxPostalTB
            // 
            this.CxPostalTB.Location = new System.Drawing.Point(329, 230);
            this.CxPostalTB.Name = "CxPostalTB";
            this.CxPostalTB.Size = new System.Drawing.Size(209, 20);
            this.CxPostalTB.TabIndex = 0;
            // 
            // CxCityLabel
            // 
            this.CxCityLabel.AutoSize = true;
            this.CxCityLabel.Location = new System.Drawing.Point(326, 160);
            this.CxCityLabel.Name = "CxCityLabel";
            this.CxCityLabel.Size = new System.Drawing.Size(24, 13);
            this.CxCityLabel.TabIndex = 1;
            this.CxCityLabel.Text = "City";
            // 
            // CxCountryLabel
            // 
            this.CxCountryLabel.AutoSize = true;
            this.CxCountryLabel.Location = new System.Drawing.Point(326, 273);
            this.CxCountryLabel.Name = "CxCountryLabel";
            this.CxCountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CxCountryLabel.TabIndex = 1;
            this.CxCountryLabel.Text = "Country";
            // 
            // CxZIPLabel
            // 
            this.CxZIPLabel.AutoSize = true;
            this.CxZIPLabel.Location = new System.Drawing.Point(326, 214);
            this.CxZIPLabel.Name = "CxZIPLabel";
            this.CxZIPLabel.Size = new System.Drawing.Size(83, 13);
            this.CxZIPLabel.TabIndex = 1;
            this.CxZIPLabel.Text = "Customer Postal";
            // 
            // CxSaveButton
            // 
            this.CxSaveButton.Location = new System.Drawing.Point(462, 591);
            this.CxSaveButton.Name = "CxSaveButton";
            this.CxSaveButton.Size = new System.Drawing.Size(75, 23);
            this.CxSaveButton.TabIndex = 2;
            this.CxSaveButton.Text = "Save";
            this.CxSaveButton.UseVisualStyleBackColor = true;
            this.CxSaveButton.Click += new System.EventHandler(this.CxSaveButton_Click);
            // 
            // CxCancelBtn
            // 
            this.CxCancelBtn.Location = new System.Drawing.Point(381, 591);
            this.CxCancelBtn.Name = "CxCancelBtn";
            this.CxCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CxCancelBtn.TabIndex = 2;
            this.CxCancelBtn.Text = "Cancel";
            this.CxCancelBtn.UseVisualStyleBackColor = true;
            this.CxCancelBtn.Click += new System.EventHandler(this.CxCancelBtn_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.CxCancelBtn);
            this.Controls.Add(this.CxSaveButton);
            this.Controls.Add(this.CxZIPLabel);
            this.Controls.Add(this.CxAddress2Label);
            this.Controls.Add(this.CxCountryLabel);
            this.Controls.Add(this.CxAddress1Label);
            this.Controls.Add(this.CxCityLabel);
            this.Controls.Add(this.CxNameLabel);
            this.Controls.Add(this.CxPostalTB);
            this.Controls.Add(this.CxAddress2TB);
            this.Controls.Add(this.CxCountryTB);
            this.Controls.Add(this.CxAddress1TB);
            this.Controls.Add(this.CxCityTB);
            this.Controls.Add(this.CxNameTB);
            this.Name = "CustomerForm";
            this.Text = "Customer Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CxNameTB;
        private System.Windows.Forms.Label CxNameLabel;
        private System.Windows.Forms.TextBox CxAddress1TB;
        private System.Windows.Forms.Label CxAddress1Label;
        private System.Windows.Forms.TextBox CxAddress2TB;
        private System.Windows.Forms.Label CxAddress2Label;
        private System.Windows.Forms.TextBox CxCityTB;
        private System.Windows.Forms.TextBox CxCountryTB;
        private System.Windows.Forms.TextBox CxPostalTB;
        private System.Windows.Forms.Label CxCityLabel;
        private System.Windows.Forms.Label CxCountryLabel;
        private System.Windows.Forms.Label CxZIPLabel;
        private System.Windows.Forms.Button CxSaveButton;
        private System.Windows.Forms.Button CxCancelBtn;
    }
}