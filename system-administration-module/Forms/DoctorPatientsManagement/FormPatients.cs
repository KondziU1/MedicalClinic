using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.DoctorModule
{
    public partial class FormPatients : Form
    {
        public FormPatients()
        {
            InitializeComponent();
        }
        internal void LoadData()
        {

            dataGridViewPatients.Rows.Clear();
            var patients = PatientService.GetPatients();

            foreach (var item in patients)
            {
                int rowIndex = dataGridViewPatients.Rows.Add(
                    item.Id,
                    item.FirstName,
                    item.LastName,
                    item.Pesel,
                    item.Active ? "active" : "inactive",
                    "Details"
                );


            }

            dataGridViewPatients.ClearSelection();
        }

        private void FormPatients_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewDoctorCalendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = (int)dataGridViewPatients.Rows[e.RowIndex].Cells["ID"].Value;
                var patients = PatientService.GetPatients();
                var patient = patients.FirstOrDefault(p => p.Id == id);

                if (patient == null)
                    return;

                if (!(dataGridViewPatients.Columns[e.ColumnIndex].HeaderText == "Details") && e.RowIndex > -1)
                {

                    var frm = new FormVisitHistory(patient.Id);
                    frm.ShowDialog();
                }
                else
                {
                    var frm = new FormPatientDetails(patient.Id);
                    frm.ShowDialog();
                }

            }
        }
    }
}
