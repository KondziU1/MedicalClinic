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

namespace SystemAdministrationModule.Forms.PatientsManagement
{
    public partial class FormConfirmDelete : Form

    {
        private readonly Patient Patient;


        public FormConfirmDelete(Patient patient)
        {
            InitializeComponent();

            Patient = patient;

        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnConfirm_Click(object sender, EventArgs e)
        {
            var result = PatientService.DeletePatient(Patient);

            if (result)
            {
                MessageBox.Show("Patient is deleted");

                FormPatient patientForm = Application.OpenForms.OfType<FormPatient>().FirstOrDefault();
                if (patientForm != null)
                {
                    patientForm.ReloadData();
                }
            }
            else
            {
                MessageBox.Show("Patient cannot be deleted due to existing appointment");
            }

            this.Close();
        }

        private void FormConfirmDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
