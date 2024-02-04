using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Forms.Auth;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.PatientsManagement
{
    public partial class FormConfirmChangeStatusPatient : Form
    {
        private readonly Patient Patient;
        public FormConfirmChangeStatusPatient(Patient patient)
        {
            Patient = patient;
            InitializeComponent();

        }

        public FormConfirmChangeStatusPatient()
        {
            InitializeComponent();
        }

        private void FormConfirmChangeStatusPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Patient.Active = !Patient.Active;
            Patient.Active = Patient.Active;

            PatientService.UpdatePatient(Patient);

            FormPatient patientForm = Application.OpenForms.OfType<FormPatient>().FirstOrDefault();
            if (patientForm != null)
            {
                patientForm.ReloadData();
            }
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
