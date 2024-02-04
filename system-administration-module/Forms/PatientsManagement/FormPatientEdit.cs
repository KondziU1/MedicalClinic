using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using SystemAdministrationModule.Helpers;

namespace SystemAdministrationModule.Forms.PatientsManagement
{

    public partial class FormPatientEdit : Form
    {

        private readonly Patient Patient;
        static List<bool> Statuses = new List<bool>() { true, false };

        static bool isEditMode = false;

        public FormPatientEdit(Patient patient)
        {
            InitializeComponent();

            isEditMode = false;
            Patient = patient;

        }

        public FormPatientEdit(Patient patient, bool openEditMode)
        {
            InitializeComponent();

            Patient = patient;

            if (!openEditMode) return;

            btnConfirmPatient.Visible = true;
            btnEditPatient.Visible = false;
            label10.Text = "Edit patient";

            SetEnableFields();
            isEditMode = true;
        }


        private void FormPatientDetails_Load(object sender, EventArgs e)
        {
            foreach (var item in Statuses)
            {
                comboBoxActiveStatusPatient.Items.Add(item);
            }

            textBoxFirstNamePatient.Text = Patient.FirstName;
            textBoxLastNamePatient.Text = Patient.LastName;
            textBoxPeselPatient.Text = Patient.Pesel;
            comboBoxActiveStatusPatient.SelectedItem = Patient.Active;

        }

        private void btnCancelPatient_Click(object sender, EventArgs e)
        {
            isEditMode = false;
            this.Close();
        }



        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            btnEditPatient.Visible = false;
            btnConfirmPatient.Visible = true;
            label10.Text = "Edit Patient";

            SetEnableFields();
        }

        private void SetEnableFields()
        {
            textBoxFirstNamePatient.Enabled = true;
            textBoxLastNamePatient.Enabled = true;
            textBoxPeselPatient.Enabled = true;
            comboBoxActiveStatusPatient.Enabled = true;
        }

        private void SetActiveBtn()
        {
            if (textBoxFirstNamePatient.Text.Length > 0 && textBoxLastNamePatient.Text.Length > 0 && textBoxPeselPatient.Text.Length > 0 && comboBoxActiveStatusPatient.SelectedIndex > -1 && !textBoxFirstNamePatient.Text.Any(char.IsDigit) && !textBoxLastNamePatient.Text.Any(char.IsDigit))
            
            {
                btnConfirmPatient.Enabled = true;
                btnConfirmPatient.IconColor = Color.White;
            }
            else
            {
                btnConfirmPatient.Enabled = false;
                btnConfirmPatient.IconColor = Color.Black;
            }
        }

        public void btnConfirmPatient_Click(object sender, EventArgs e)
        {
            Patient.FirstName = textBoxFirstNamePatient.Text;
            Patient.LastName = textBoxLastNamePatient.Text;
            Patient.Pesel = textBoxPeselPatient.Text;
            Patient.Active = (bool)comboBoxActiveStatusPatient.SelectedItem;

            if (!ValidationHelper.ValidatePeselPatient(Patient.Pesel))
            {
                return;
            }

            var isPeselExistInDB = PatientService.GetPatients().FirstOrDefault(e => e.Pesel == Patient.Pesel);

            if (isPeselExistInDB != null)
            {
                MessageBox.Show("Passed PESEL exist in Database", "Error editing patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            FormPatient patientForm = Application.OpenForms.OfType<FormPatient>().FirstOrDefault();
            if (patientForm != null)
            {
                patientForm.ReloadData();
            }
            PatientService.UpdatePatient(Patient);
            MessageBox.Show("Patient's data changed");
            patientForm.ReloadData();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

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

        private void comboBoxActiveStatusPatient_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SetActiveBtn();
        }
    }

}
