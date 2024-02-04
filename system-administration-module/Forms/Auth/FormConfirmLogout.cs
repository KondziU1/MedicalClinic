using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Forms;
using SystemAdministrationModule.Forms.Auth;

namespace SystemAdministrationModule.Forms.Auth
{
    public partial class FormConfirmLogout : Form
    {
        public FormConfirmLogout()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            var frm = new FormLogin();
            frm.Show();

            Form parentForm = (Form)this.Owner;
            //parentForm.Hide();
            parentForm.Dispose();
            this.Close();
        }
    }
}
