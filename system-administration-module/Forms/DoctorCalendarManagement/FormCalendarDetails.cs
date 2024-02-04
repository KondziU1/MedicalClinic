using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Forms.CalendarManagement;
using SystemAdministrationModule.Services;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Forms.DoctorModule
{
    public partial class FormCalendarDetails : Form
    {
        DateTime selectedDate;
        DateTime Today = DateTime.Today;
        int doctorId = FormDoctor.id;
        int calendarId;
        public FormCalendarDetails(DateTime date, int calendarId)
        {
            this.calendarId = calendarId;
            this.selectedDate = date;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(selectedDate);

            if (selectedDate < Today)
            {
                btnRegisterAppointment.Visible = false;
            }


        }

        public void LoadData(DateTime date)
        {
            dataGridViewDoctorCalendar.Rows.Clear();
            List<Appointment> appointments = AppointmentService.GetAppointmentsByCalendar2(calendarId);
            var acceptedAppointment = appointments.Where(a => a.Visit.VisitStartTime.Date == date.Date)
            .Where(a => a.IsAccepted && a.DoctorId == doctorId && a.PatientId != null);

            foreach (var item in acceptedAppointment)
            {
                dataGridViewDoctorCalendar.Rows.Add(
                    item.Id,
                    item.Visit.VisitStartTime.ToString("HH:mm"),
                    item.Visit.OfficeId,
                    (item.Patient.FirstName + " " + item.Patient.LastName),
                    "Details"
                );
            }
            dataGridViewDoctorCalendar.ClearSelection();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            foreach (DataGridViewRow row in dataGridViewDoctorCalendar.Rows)
            {
                if (row.Cells["Patient"].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
        private void textBoxVisitTime_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox2.Text.ToLower();
            foreach (DataGridViewRow row in dataGridViewDoctorCalendar.Rows)
            {
                if (row.Cells["VisitStartTime"].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void dataGridViewDoctorCalendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDoctorCalendar.Columns[e.ColumnIndex].HeaderText == "Details" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewDoctorCalendar.Rows[e.RowIndex].Cells["ID"].Value;
                var calendarData = AppointmentService.GetAppointmentsByCalendar2(calendarId);
                var appointment = calendarData.FirstOrDefault(c => c.Id == id);
                var frm = new FormVisitDetails(appointment);
                frm.ShowDialog();
            }
        }

        private void dataGridViewDoctorCalendar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDoctorCalendar.SelectedRows.Count > 0)
            {
                if (selectedDate <= Today)
                {
                    btnCancelSelected.Visible = false;
                }
                else
                {
                    btnCancelSelected.Visible = true;
                }
            }
            else
                btnCancelSelected.Visible = false;
        }
        internal void RejectSelectedAppointments()
        {
            foreach (DataGridViewRow row in dataGridViewDoctorCalendar.SelectedRows)
            {
                int appointmentId = int.Parse(row.Cells["ID"].Value.ToString());
                var appointment = AppointmentService.GetAppointmentsByCalendar2(calendarId).FirstOrDefault(a => a.Id == appointmentId);
                AppointmentService.DeleteAppointment(appointment);
                dataGridViewDoctorCalendar.Rows.Remove(row);
            }
        }

        private void btnCancelSelected_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel selected appointments?", "Confirmation of cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RejectSelectedAppointments();
                LoadData(selectedDate);
            }
        }

        private void dataGridViewDoctorCalendar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = (int)dataGridViewDoctorCalendar.Rows[e.RowIndex].Cells["ID"].Value;
                var calendarData = AppointmentService.GetAppointmentsByCalendar2(calendarId);
                var appointment = calendarData.FirstOrDefault(c => c.Id == id);
                var frm = new FormVisitDetails(appointment);
                frm.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.OfType<FormDoctor>().FirstOrDefault();
            var formCalendar = new FormCalendar();
            frm.OpenChildForm(formCalendar);
        }

        private void btnRegisterAppointment_Click(object sender, EventArgs e)
        {
            var frm = new FormRegisterAppointment(selectedDate, calendarId);
            frm.ShowDialog();
            LoadData(selectedDate);
        }
    }
}
