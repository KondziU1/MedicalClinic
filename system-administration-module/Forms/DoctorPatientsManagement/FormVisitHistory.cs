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
    public partial class FormVisitHistory : Form
    {
        int patientId, doctorId;
        public FormVisitHistory(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        public void LoadData()
        {
            dataGridViewPatientHistory.Rows.Clear();
            var appointments = AppointmentService.GetAppointmentsForPatient(patientId).Where(a => a.Visit.VisitStartTime <= DateTime.Now);
            var doctors = EmployeeService.GetEmployees();
            var offices = OfficeService.GetOffices();

            foreach (var item in appointments)
            {
                
                dataGridViewPatientHistory.Rows.Add(
                        item.Id,
                        item.Visit.VisitStartTime.ToShortDateString(),
                        item.Visit.VisitStartTime.ToShortTimeString() +
                        " - " + item.Visit.VisitEndTime.ToShortTimeString(),
                        doctors.FirstOrDefault(d => d.Id == item.DoctorId),
                        offices.FirstOrDefault(o => o.Id == item.Visit.OfficeId)
                );
            }
            dataGridViewPatientHistory.ClearSelection();
        }



        private void dataGridViewPatientHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = (int)dataGridViewPatientHistory.Rows[e.RowIndex].Cells["ID"].Value;
                var calendarData = AppointmentService.GetAppointmentsForPatient(patientId);
                var appointment = calendarData.FirstOrDefault(c => c.Id == id);
                var frm = new FormVisitDetails(appointment);
                frm.btnRejectOrComment.Enabled = false;
                frm.ShowDialog();
                
            }
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatientHistory.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridViewPatientHistory.SelectedRows[0];
                int appointmentId = int.Parse(selectedRow.Cells["ID"].Value.ToString());
                var appointment = AppointmentService.GetAppointmentsForPatient(patientId).FirstOrDefault(a => a.Id == appointmentId);
                var frm = new FormComment(appointment);
                frm.ShowDialog();
            }
        }

        private void dataGridViewPatientHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPatientHistory.SelectedRows.Count == 1)
            {
                btnComment.Visible = true;
            }
            else
                btnComment.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
