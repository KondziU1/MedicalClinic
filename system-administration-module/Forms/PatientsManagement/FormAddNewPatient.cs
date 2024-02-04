using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.PatientsManagement
{
    public partial class FormAddNewPatient : Form
    {
        public static string FirstNameValuePatient = "";
        public static string LastNameValuePatient = "";
        public static string PeselValuePatient = "";


        public FormAddNewPatient()
        {
            InitializeComponent();
        }

        public void setFirstNameValuePatient(string firstName)
        {
            FirstNameValuePatient = firstName;

        }

        public string getFirstNameValuePatient()
        {
            return FirstNameValuePatient;
        }

        private void FormAddNewPatient_Load(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        public void btnAdd_Click(object sender, EventArgs e)
        {
            var PatientId = int.Parse(PatientService.GetLastPatientID()) + 1;
            var FirstNameValuePatient = textBoxFirstNamePatient.Text;
            var LastNameValuePatient = textBoxLastNamePatient.Text;
            var PeselValuePatient = textBoxPeselPatient.Text;
            bool IsActive = false;

            if (!ValidationHelper.ValidatePeselPatient(PeselValuePatient))
            {
                return;
            }

            var isPeselExistInDB = PatientService.GetPatients().FirstOrDefault(e => e.Pesel == PeselValuePatient);

            if (isPeselExistInDB != null)
            {
                MessageBox.Show("Passed PESEL exist in Database", "Error adding patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var patient = new Patient(PatientId, FirstNameValuePatient, LastNameValuePatient, PeselValuePatient, IsActive);

            PatientService.CreatePatient(patient);

            MessageBox.Show("Patient added", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            FormPatient patientForm = Application.OpenForms.OfType<FormPatient>().FirstOrDefault();
            if (patientForm != null)
            {
                patientForm.ReloadData();
            }

            this.Close();




        }

        private void SetActiveBtn()
        {
            if (textBoxFirstNamePatient.Text.Length > 0 && textBoxLastNamePatient.Text.Length > 0 && textBoxPeselPatient.Text.Length > 0 && !textBoxFirstNamePatient.Text.Any(char.IsDigit) && !textBoxLastNamePatient.Text.Any(char.IsDigit))
            {
                btnAdd.Enabled = true;
                btnAdd.IconColor = Color.White;
            }
            else
            {
                btnAdd.Enabled = false;
                btnAdd.IconColor = Color.Black;
            }
        }

        private void textBoxFirstNamePatient_TextChanged_1(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void textBoxLastNamePatient_TextChanged_1(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void textBoxPeselPatient_TextChanged_1(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void btnCancelPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
