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
using System.Windows.Controls;

namespace SystemAdministrationModule.Forms.DoctorModule
{
    public partial class FormAddVisit : Form
    {
        internal int officeId, calendarId, visitId;
        DateTime selectedDate;
        internal int doctorId = FormDoctor.id;

        public FormAddVisit(DateTime date, int calendarId)
        {
            this.calendarId = calendarId;
            this.selectedDate = date;
            InitializeComponent();
        }

        public FormAddVisit()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadOffices();
            LoadDay();
        }

        private void LoadOffices()
        {
            comboBoxOffice.Items.Clear();
            var Offices = OfficeService.GetActiveOffices();
            comboBoxOffice.SelectedIndex = -1;
            foreach (var item in Offices)
            {
                comboBoxOffice.Items.Add(item);
            }
        }
        private void LoadDay()

        {
            comboBoxDay.Text = selectedDate.ToShortDateString();
            comboBoxDay.SelectedItem = selectedDate;
        }

        private void LoadAvalibleHours()
        {
            comboBoxTime.Enabled = true;
            comboBoxTime.Items.Clear();
            var Visits = VisitService.GetFreeVistsForDayAndOffice(selectedDate, officeId);
            var VisitsForDayAndDoctor = VisitService.GetVistsForDayAndDoctor(selectedDate, doctorId);
            Visits.RemoveAll(v => VisitsForDayAndDoctor.Any(v2 => v2.VisitStartTime == v.VisitStartTime));

            foreach (var item in Visits)
            {
                comboBoxTime.Items.Add(item);
            }
            comboBoxTime.DisplayMember = "VisitStartTime";
            comboBoxTime.FormatString = "HH:mm";
        }


        private void comboBoxOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTime.SelectedIndex = -1;
            officeId = ((Office)(comboBoxOffice.SelectedItem)).Id;
            LoadAvalibleHours();
        }

        protected virtual void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTime.SelectedItem != null)
            {
                visitId = ((Visit)(comboBoxTime.SelectedItem)).Id;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Appointment CreateAppointment()
        {
            Appointment appointment = new Appointment(
                id: 0,
                doctorId: doctorId,
                patientId: null,
                visitId: visitId,
                isAccepted: false,
                doctorSpecialization: null
            );

            return appointment;
        }

        internal void btnConfirm_Click(object sender, EventArgs e)
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

            var appointment = CreateAppointment();
            AppointmentService.AddAppointment(appointment);


            MessageBox.Show("Appointment has been successfully scheduled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
