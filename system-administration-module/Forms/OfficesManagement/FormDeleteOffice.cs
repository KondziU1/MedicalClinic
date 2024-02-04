using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.OfficesManagement
{
    public partial class FormDeleteOffice : Form
    {
        private Office Office;

        public FormDeleteOffice(Office office)
        {
            InitializeComponent();
            Office = office;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (OfficeService.DeleteOffice(Office.Id))
            {
                MessageBox.Show("The office has been deleted", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The office has future visits", "Error operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FormOffices officesForm = Application.OpenForms.OfType<FormOffices>().FirstOrDefault();
            if (officesForm != null)
            {
                officesForm.ReloadData();
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDeleteOffice_Load(object sender, EventArgs e)
        {

        }
    }
}
