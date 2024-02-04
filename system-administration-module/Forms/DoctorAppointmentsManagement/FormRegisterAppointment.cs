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
    public partial class FormRegisterAppointment : Form
    {
        internal int patientId, calendarId, visitId;
        int doctorId = FormDoctor.id;
        DateTime selectedDate;
        internal Appointment appointment;
        public FormRegisterAppointment(DateTime date, int calendarId)
        {
            this.selectedDate = date;
            this.calendarId = calendarId;
            InitializeComponent();
        }
        private void LoadDay()

        {
            comboBoxDay.Text = selectedDate.ToShortDateString();
            comboBoxDay.SelectedItem = selectedDate;
        }
        private void LoadPatients()
        {
            comboBoxPatient.Items.Clear();
            foreach (var patient in PatientService.GetPatients())
            {
                comboBoxPatient.Items.Add(patient);
            }
            comboBoxPatient.DisplayMember = "ToString";
        }
        private void LoadAvalibleHours()
        {
            comboBoxTime.Enabled = true;
            comboBoxTime.Items.Clear();
            var appointments = VisitService.GetVistsForDayAndDoctor(selectedDate, doctorId).Where(v => v.PatientId == null)
                .Where(v => v.VisitStartTime > DateTime.Now);

            foreach (var item in appointments)
            {
                comboBoxTime.Items.Add(item);
            }
            comboBoxTime.DisplayMember = "VisitStartTime";
            comboBoxTime.FormatString = "HH:mm";
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedItem != null)
            {
                patientId = ((Patient)(comboBoxPatient.SelectedItem)).Id;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadAvalibleHours();
            LoadDay();
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            visitId = ((Visit)(comboBoxTime.SelectedItem)).Id;
            var appointments = AppointmentService.GetAppointmentsByCalendar2(calendarId);
            appointment = appointments.FirstOrDefault(a => a.VisitId == visitId);
        }
        internal void btnConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxTime.SelectedItem == null)
            {
                MessageBox.Show("Please select a time for the appointment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxPatient.SelectedItem == null)
            {
                MessageBox.Show("Please select an patient for the appointment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            appointment.PatientId = patientId;
            AppointmentService.UpdateAppointment(appointment);
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
