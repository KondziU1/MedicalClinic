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
using SystemAdministrationModule.Helpers;
using System.Globalization;
using SystemAdministrationModule.Services;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Forms.DoctorModule
{
    public partial class FormModifyVisit : Form
    {
        internal int calendarId, visitId, officeId;
        internal DateTime selectedDate;
        internal int doctorId = FormDoctor.id;
        internal Appointment appointment;
        internal Visit visit;
        internal Office office;
        string time, day;
        private static List<Office> Offices = OfficeService.GetActiveOffices();

        public FormModifyVisit(Appointment appointment)
        {
            this.appointment = appointment;
            InitializeComponent();
        }
        private void LoadData()
        {
            if (appointment != null)
            {
                office = Offices.FirstOrDefault(o => o.Id == appointment.Visit.OfficeId);
                day = appointment.Visit.VisitStartTime.ToString("dd.MM.yyyy");
                time = appointment.Visit.VisitStartTime.ToString("HH:mm");
                selectedDate = appointment.Visit.VisitStartTime.Date;
                calendarId = appointment.Visit.CalendarId;
                var visits = VisitService.GetVisits(appointment.Visit.CalendarId);
                visit = visits.FirstOrDefault(v => v.Id == appointment.VisitId);

            }

            comboBoxDay.Text = day;
            comboBoxTime.Text = time;
            comboBoxOffice.Text = office.ToString();

        }
        void LoadDays()
        {
            comboBoxDay.Items.Clear();
            var visitData = VisitService.GetFreeVisits(calendarId);
            var days = visitData.DistinctBy(v => v.VisitStartTime.Date).ToList();
            days.ForEach(d => comboBoxDay.Items.Add(d.VisitStartTime.Date));

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDays();
            comboBoxDay.SelectedItem = selectedDate;
            comboBoxOffice.SelectedItem = office;
            comboBoxTime.Items.Add(visit);
            comboBoxTime.SelectedItem = visit;

        }

        private void LoadOffices()
        {
            comboBoxOffice.SelectedIndex = -1;
            comboBoxOffice.Items.Clear();

            foreach (var item in Offices)
            {
                comboBoxOffice.Items.Add(item);
            }
        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDate = ((DateTime)comboBoxDay.SelectedItem);
            LoadOffices();
            LoadAvalibleHours();

        }
        private void comboBoxOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOffice.SelectedItem != null)
            {
                officeId = ((Office)(comboBoxOffice.SelectedItem)).Id;
                LoadAvalibleHours();
            }
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTime.SelectedItem != null)
            {
                visitId = ((Visit)(comboBoxTime.SelectedItem)).Id;
            }
        }

        private void LoadAvalibleHours()
        {
            comboBoxTime.SelectedIndex = -1;
            comboBoxTime.Items.Clear();
            comboBoxTime.Enabled = true;
            var AllVisits = VisitService.GetVistsForDoctor(doctorId);
            var Visits = VisitService.GetFreeVistsForDayAndOffice(selectedDate, officeId);
            var VisitsForDayAndDoctor = VisitService.GetVistsForDayAndDoctor(selectedDate, doctorId);
            Visits.RemoveAll(v => v.VisitStartTime.TimeOfDay != visit.VisitStartTime.TimeOfDay && VisitsForDayAndDoctor.Any(v2 => v2.VisitStartTime == v.VisitStartTime));


            foreach (var item in Visits)
            {
                comboBoxTime.Items.Add(item);
            }

            comboBoxTime.DisplayMember = "VisitStartTime";
            comboBoxTime.FormatString = "HH:mm";
            comboBoxTime.Sorted = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        internal void btnModify_Click(object sender, EventArgs e)
        {

            if (comboBoxOffice.SelectedItem == null)
            {
                MessageBox.Show("Please select an office for the appointment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxTime.SelectedItem == null)
            {
                MessageBox.Show("Please select a time for the appointment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            appointment.VisitId = visitId;
            AppointmentService.UpdateAppointment(appointment);

            var frm = Application.OpenForms.OfType<FormFutureCalendarDetails>().FirstOrDefault();

            if (frm != null)
                frm.LoadData(selectedDate);

            this.Close();
        }

    }
}
