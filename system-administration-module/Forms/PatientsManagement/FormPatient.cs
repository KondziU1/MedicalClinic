using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SystemAdministrationModule.Forms.EmployeesManagement;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;


namespace SystemAdministrationModule.Forms.PatientsManagement
{
    public partial class FormPatient : Form
    {

        protected static List<Patient> Patients = PatientService.GetPatients();
        static List<string> Statuses = new List<string>() { "All", "Active", "Inactive" };


        private void refreshDataToDataGridView(List<Patient> data)
        {
            dataGridViewPatient.Rows.Clear();
            foreach (var item in data)
            {
                dataGridViewPatient.Rows.Add(
                    item.Id,
                    item.FirstName,
                    item.LastName,
                    item.Pesel,
                    item.Active ? "active" : "inactive",
                    "Review patient",
                    item.Active ? "Delete" : "Delete",
                    "Edit patient",
                    item.Active ? "Deactivate" : "Activate",
                    "Edit emplyee");


            }
        }

        // public ComboBox ComboBoxStatuses => ComboBoxStatuses;

        public void ReloadData()
        {
            Patients = PatientService.GetPatients();
            refreshDataToDataGridView(Patients);
        }

        public FormPatient()
        {
            InitializeComponent();
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            refreshDataToDataGridView(Patients);
        }

        private void Filter()
        {
            var filteredPatients = FilterPatients();
            refreshDataToDataGridView(filteredPatients);
        }

        public List<Patient> FilterPatients()
        {
            List<Patient> filteredPatient = Patients;

            string filterName = textBoxFiltersName.Text.ToLower();
            string filterLastName = textBoxFiltersLastName.Text.ToLower();
            string filterPesel = textBoxPesel.Text;
            //DateTime filerData = dateTimePickerLastVisit.Text;

            filteredPatient = Patients.Where(u =>
                (string.IsNullOrEmpty(filterName) || u.FirstName.ToLower().Contains(filterName)) &&
                (string.IsNullOrEmpty(filterLastName) || u.LastName.ToLower().Contains(filterLastName)) &&
                 (string.IsNullOrEmpty(filterPesel) || u.Pesel.ToLower().Contains(filterPesel))
            ).ToList();

            //filteredPatient = Patients.Where(u =>
            //    (string.IsNullOrEmpty(filterLastName) || u.LastName.ToLower().Contains(filterLastName))
            //).ToList();

            //filteredPatient = Patients.Where(u =>
            //    (string.IsNullOrEmpty(filterPesel) || u.Pesel.ToLower().Contains(filterPesel))
            //).ToList();


            return filteredPatient;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void textBoxFiltersName_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }


        private void dateTimePickerLastVisit_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerLastVisit.Value;
            List<Patient> Patients = PatientService.GetPatientsByLatestVisitDate(selectedDate);
            refreshDataToDataGridView(Patients);
        }

        private void textBoxFiltersLastName_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBoxPesel_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnAddEPatient_Click(object sender, EventArgs e)
        {
            var frm = new FormAddNewPatient
            {
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog();
        }

        private void dataGridViewPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPatient.Columns[e.ColumnIndex].HeaderText == "Review" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewPatient.Rows[e.RowIndex].Cells["id"].Value;

                var patient = Patients.FirstOrDefault(x => x.Id == id);

                var frm = new FormPatientDetails(patient)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();

            }
            if (dataGridViewPatient.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewPatient.Rows[e.RowIndex].Cells["id"].Value;
                var patient = Patients.FirstOrDefault(e => e.Id == id);

                var frm = new FormPatientEdit(patient, true)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();
            }

            if (dataGridViewPatient.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewPatient.Rows[e.RowIndex].Cells["id"].Value;

                var patient = Patients.FirstOrDefault(x => x.Id == id);

                var frm = new FormConfirmDelete(patient)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();

            }
            if (dataGridViewPatient.Columns[e.ColumnIndex].HeaderText == "Status change" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewPatient.Rows[e.RowIndex].Cells["id"].Value;

                var patient = Patients.FirstOrDefault(x => x.Id == id);

                var frm = new FormConfirmChangeStatusPatient(patient)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dateTimePickerLastVisit.Checked = false;
            textBoxFiltersName.Text = "";
            textBoxFiltersLastName.Text = "";
            Filter();
        }
    }
}
