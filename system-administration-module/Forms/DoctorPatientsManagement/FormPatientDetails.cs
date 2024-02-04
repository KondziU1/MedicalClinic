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

namespace SystemAdministrationModule.Forms.DoctorModule
{
    public partial class FormPatientDetails : Form
    {
        int patientId;
        public FormPatientDetails(int patientId)
        {
            this.patientId = patientId;
            InitializeComponent();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var frm = new FormVisitHistory(patientId);
            frm.ShowDialog();
        }
        private void LoadData()
        {
            List<Patient> patients = PatientService.GetPatients();
            var patientData = patients.FirstOrDefault(p => p.Id == patientId);

            if (patientData != null)
            {
                textBoxFirstName.Text = patientData.FirstName;
                textBoxLastName.Text = patientData.LastName;
                textBoxPesel.Text = patientData.Pesel;
                textBoxStatus.Text = patientData.Active ? "active" : "inactive";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPatientDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
