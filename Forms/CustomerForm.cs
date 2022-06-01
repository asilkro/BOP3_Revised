using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Silkroski_BOP3.Forms;

namespace Silkroski_C969_Revised.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CxCancelBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled, no changes made.", "CANCELLED");
            this.Close();
        }

        private void CxSaveButton_Click(object sender, EventArgs e)
        {
            //TODO: Implement validation, save
        }
    }
}
