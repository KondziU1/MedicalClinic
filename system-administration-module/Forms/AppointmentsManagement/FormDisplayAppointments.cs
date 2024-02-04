using Microsoft.VisualBasic.ApplicationServices;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using SystemAdministrationModule.Forms.PatientsManagement;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;



namespace SystemAdministrationModule.Forms.AppointmentsManagement
{
    public partial class FormDisplayAppointments : Form
    {

        private bool isSortedAscending = true;
        public static int calendarId;
        private static List<Specialization> Specializations = SpecializationService.GetSpecializations();
        protected static List<Appointment> Appointments = AppointmentService.GetAppointmentsByCalendar(calendarId);

        public static int doctorId;


        private void refreshDataToDataGridView(List<Appointment> data)
        {
            dataGridViewAppointment.Rows.Clear();
            foreach (var item in data)
            {
                dataGridViewAppointment.Rows.Add(
                    item.Id,
                    item.Patient.FirstName + " " + item.Patient.LastName,
                    item.Patient.Pesel,
                    item.Visit.VisitStartTime,
                    item.Doctor.FirstName + " " + item.Doctor.LastName,
                    item.DoctorSpecialization,
                    "Details",
                    "Reschedule"
                    );
            }
        }
        public void ReloadData()
        {
            Appointments = AppointmentService.GetAppointmentsByCalendar(calendarId);
            refreshDataToDataGridView(Appointments);
        }

        public FormDisplayAppointments(int CalendarId)
        {
            InitializeComponent();
            calendarId = CalendarId;
            Appointments = AppointmentService.GetAppointmentsByCalendar(calendarId);

            dataGridViewAppointment.ColumnHeaderMouseClick += dataGridViewAppointment_ColumnHeaderMouseClick;

            dataGridViewAppointment.Sort(dataGridViewAppointment.Columns[0], ListSortDirection.Ascending);
            isSortedAscending = false;
        }
        private void dataGridViewAppointment_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dataGridViewAppointment.Columns[e.ColumnIndex];

            if (isSortedAscending)
            {
                dataGridViewAppointment.Sort(column, ListSortDirection.Ascending);
                isSortedAscending = false;
            }
            else
            {
                dataGridViewAppointment.Sort(column, ListSortDirection.Descending);
                isSortedAscending = true;
            }
        }

        private void Filter()
        {
            var filteredAppointments = FilterAppointments();
            refreshDataToDataGridView(filteredAppointments);
        }

        public List<Appointment> FilterAppointments()
        {
            List<Appointment> filteredAppointments = Appointments;

            string filterPatient = textBoxFiltersPatient.Text.ToLower();
            string filterDoctor = textBoxFiltersDoctor.Text.ToLower();
            string filterPesel = textBoxPesel.Text;
            string filterSpecialization;
                if(comboBoxDoctor.SelectedIndex==-1 )
                {
                filterSpecialization = "";
                }
                else
                {
                filterSpecialization = comboBoxDoctor.SelectedItem.ToString();
                }
            //DateTime filterDate = dateTimePickerVisit.Value;

            filteredAppointments = Appointments.Where(u =>
                (string.IsNullOrEmpty(filterPatient) || u.Patient.FirstName.ToLower().Contains(filterPatient) || u.Patient.LastName.ToLower().Contains(filterPatient)) &&
                (string.IsNullOrEmpty(filterDoctor) || u.Doctor.FirstName.ToLower().Contains(filterDoctor) || u.Doctor.LastName.ToLower().Contains(filterDoctor)) &&
                (string.IsNullOrEmpty(filterPesel) || u.Patient.Pesel.ToLower().Contains(filterPesel)) &&
                (string.IsNullOrEmpty(filterSpecialization) || u.DoctorSpecialization.Contains(filterSpecialization))
            //(u.Visit.VisitStartTime == filterDate)
            ).ToList();



            return filteredAppointments;
        }

        private void FormDisplayAppointments_Load(object sender, EventArgs e)
        {
            refreshDataToDataGridView(Appointments);

            foreach (var item in Specializations)
            {
                comboBoxDoctor.Items.Add(item);
            }
        }


        private void dataGridViewAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAppointment.Columns[e.ColumnIndex].HeaderText == "Details" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewAppointment.Rows[e.RowIndex].Cells["id"].Value;

                var appointment = Appointments.FirstOrDefault(x => x.Id == id);

                var frm = new FormAppointmentDetails(appointment, calendarId)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();
            }

            if (dataGridViewAppointment.Columns[e.ColumnIndex].HeaderText == "Reschedule" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewAppointment.Rows[e.RowIndex].Cells["id"].Value;

                var appointment = Appointments.FirstOrDefault(x => x.Id == id);

                var frm = new FormAppointmentReschedule(appointment, true, calendarId)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();
            }

            if (dataGridViewAppointment.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewAppointment.Rows[e.RowIndex].Cells["id"].Value;

                var appointment = Appointments.FirstOrDefault(x => x.Id == id);

                var frm = new FormConfirmAppointmentDelete(appointment)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();

            }

            if (dataGridViewAppointment.Columns[e.ColumnIndex].HeaderText == "Issue a confirmation" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewAppointment.Rows[e.RowIndex].Cells["id"].Value;

                var appointment = Appointments.FirstOrDefault(x => x.Id == id);

                AppointmentService.GenerateConfirmationPDF(appointment);

            }

    }



    private void label8_Click(object sender, EventArgs e)

        {

        }

        private void textBoxFiltersPatient_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBoxFiltersDoctor_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBoxPesel_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void dateTimePickerVisit_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerVisit.Value;
            List<Appointment> appointments = AppointmentService.GetVisitDates(selectedDate);
            refreshDataToDataGridView(appointments);
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dateTimePickerVisit.Checked = false;
            textBoxFiltersPatient.Text = "";
            textBoxFiltersDoctor.Text = "";
            textBoxPesel.Text = "";
            comboBoxDoctor.SelectedIndex = -1;
            Filter();
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            var frm = new FormAddNewAppointment(calendarId)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog();
        }

        private void btnCleanCalendar_Click(object sender, EventArgs e)
        {
            var frm = new FormClearCalendar(calendarId)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog();
        }
    }
}
