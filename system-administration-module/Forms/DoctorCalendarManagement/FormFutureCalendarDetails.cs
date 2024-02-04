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
    public partial class FormFutureCalendarDetails : Form
    {
        DateTime selectedDate;
        private DateTime Today = DateTime.Today;
        int doctorId = FormDoctor.id;
        bool isCalendarAccepted = false;
        int calendarId; 
        public FormFutureCalendarDetails(DateTime date, bool confirmed, int calendarId)
        {
            this.calendarId = calendarId;
            this.isCalendarAccepted = confirmed;
            this.selectedDate = date;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(selectedDate);
            if (isCalendarAccepted)
            {
                btnModify.Enabled = false;
                btnReject.Enabled = false;
                btnAdd.Enabled = false;
            }
            if(dataGridViewDoctorCalendar.SelectedRows.Count == 0)
            {
                btnModify.Visible = false;
                btnReject.Visible = false;
            }
        }

        internal void LoadData(DateTime date)
        {

            dataGridViewDoctorCalendar.Rows.Clear();
            var appointments = AppointmentService.GetAppointmentsByCalendar2(calendarId);
            var calendarData = appointments.Where(a => a.Visit.VisitStartTime.Date == date.Date).Where(a => a.IsAccepted == false || a.IsAccepted == true);

            foreach (var item in calendarData)
            {
                int rowIndex = dataGridViewDoctorCalendar.Rows.Add(
                    item.Id,
                    item.Visit.VisitStartTime.ToString("HH:mm"),
                    item.Visit.OfficeId,
                    (item.Doctor.FirstName + " " + item.Doctor.LastName)
                );

                if (item.DoctorId != doctorId)
                {
                    dataGridViewDoctorCalendar.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    dataGridViewDoctorCalendar.Rows[rowIndex].Cells["ID"].Value = 0;
                }

            }

            dataGridViewDoctorCalendar.ClearSelection();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            foreach (DataGridViewRow row in dataGridViewDoctorCalendar.Rows)
            {
                if (row.Cells["Doctor"].Value.ToString().ToLower().Contains(searchText))
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

        private void dataGridViewDoctorCalendar_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewDoctorCalendar.Rows.Cast<DataGridViewRow>().Where(row => (int)row.Cells["ID"].Value == 0).ToList()
                .ForEach(row => row.Selected = false);

            if (dataGridViewDoctorCalendar.SelectedRows.Count > 0)
            {
                if (Today != selectedDate)
                {
                    btnReject.Visible = true;
                    btnModify.Visible = true;
                }
            }
            else
            {
                btnReject.Visible = false;
                btnModify.Visible = false;
            }
        }

        private void RejectSelectedAppointments()
        {
            foreach (DataGridViewRow row in dataGridViewDoctorCalendar.SelectedRows)
            {
                int appointmentId = int.Parse(row.Cells["ID"].Value.ToString());
                var appointment = AppointmentService.GetAppointmentsByCalendar2(calendarId).FirstOrDefault(a => a.Id == appointmentId);
                AppointmentService.DeleteAppointment(appointment);
                dataGridViewDoctorCalendar.Rows.Remove(row);
            }
        }
        private void btnReject_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reject selected appointments?", "Confirmation of rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RejectSelectedAppointments();
                LoadData(selectedDate);
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctorCalendar.SelectedRows.Count > 1)
            {
                MessageBox.Show("Only one appointment can be modified at a time. Please select only one appointment to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewDoctorCalendar.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            var appointments = AppointmentService.GetAppointmentsByCalendar2(calendarId);
            var appointment = appointments.FirstOrDefault(c => c.Id == id);

            var frm = new FormModifyVisit(appointment);
            frm.ShowDialog();
            LoadData(selectedDate);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FormAddVisit(selectedDate, calendarId);
            frm.ShowDialog();
            LoadData(selectedDate);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.OfType<FormDoctor>().FirstOrDefault();
            var formFutureCalendar = new FormFutureCalendar();
            frm.OpenChildForm(formFutureCalendar);
        }

    }
}
