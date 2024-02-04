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
    public partial class FormPatientDetails : Form
    {
        private readonly Patient Patient;
        static List<bool> Statuses = new List<bool>() { true, false };
        static bool isEditMode = false;

        public FormPatientDetails(Patient patient)
        {
            InitializeComponent();

            Patient = patient;
            isEditMode = false;

            textBoxFirstNamePatient.Enabled = false;
            textBoxLastNamePatient.Enabled = false;
            textBoxPeselPatient.Enabled = false;
            comboBoxActiveStatusPatient.Enabled = false;

        }
        public FormPatientDetails(Patient patient, bool openEditMode)
        {
            InitializeComponent();

            Patient = patient;
            if (!openEditMode) return;

            btnEditPatient.Visible = false;
            btnConfirmPatient.Visible = true;
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

            SetActiveBtn();

            textBoxFirstNamePatient.Text = Patient.FirstName;
            textBoxLastNamePatient.Text = Patient.LastName;
            textBoxPeselPatient.Text = Patient.Pesel;
            comboBoxActiveStatusPatient.SelectedItem = Patient.Active;
        }
        private void SetEnableFields()
        {
            textBoxFirstNamePatient.Enabled = true;
            textBoxLastNamePatient.Enabled = true;
            textBoxPeselPatient.Enabled = true;
            comboBoxActiveStatusPatient.Enabled = true;

        }

        private void btnCancelPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnEditPatient_Click_1(object sender, EventArgs e)
        {
            btnEditPatient.Visible = false;
            btnConfirmPatient.Visible = true;
            label10.Text = "Edit patient";

            SetEnableFields();
        }

        private void btnConfirmPatient_Click_1(object sender, EventArgs e)
        {
            Patient.FirstName = textBoxFirstNamePatient.Text;
            Patient.LastName = textBoxLastNamePatient.Text;
            Patient.Pesel = textBoxPeselPatient.Text;
            Patient.Active = (bool)comboBoxActiveStatusPatient.SelectedItem;


            var isPeselExistInDB = PatientService.GetPatients().FirstOrDefault(e => e.Pesel == Patient.Pesel);

            if (isPeselExistInDB != null)
            {
                MessageBox.Show("Passed PESEL exist in Database", "Error editing patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PatientService.UpdatePatient(Patient);

            MessageBox.Show("Patient's data changed");

            FormPatient PatientForm = Application.OpenForms.OfType<FormPatient>().FirstOrDefault();
            if (PatientForm != null)
            {
                PatientForm.ReloadData();
            }

            this.Close();

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

        private void textBoxFirstNamePatient_TextChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void textBoxLastNamePatient_TextChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void textBoxPeselPatient_TextChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void comboBoxActiveStatusPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
        }
    }
}
