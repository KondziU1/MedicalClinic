using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SystemAdministrationModule.Forms.PatientsManagement;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.AppointmentsManagement
{
    public partial class FormAppointmentReschedule : Form
    {
        private static List<Patient> Patients = PatientService.GetPatients();
        private static List<Employee> Employees = EmployeeService.GetEmployees();
        private readonly Appointment Appointment;
        private static List<Visit> Visits;
        public static int calendarId;

        static bool isRescheduleMode = false;



        public FormAppointmentReschedule(Appointment appointment)
        {
            InitializeComponent();

            isRescheduleMode = false;
            Appointment = appointment;
        }

        public FormAppointmentReschedule(Appointment appointment, bool openRescheduleMode, int CalendarId)
        {
            InitializeComponent();
            calendarId = CalendarId;

            Appointment = appointment;

            if (!openRescheduleMode) return;

            btnConfirmReschedule.Visible = true;
            btnAppointmentEdit.Visible = false;
            comboBoxDateEdit.Enabled = true;

            isRescheduleMode = true;
        }

        private void btnAppointmentEdit_Click(object sender, EventArgs e)
        {

            btnAppointmentEdit.Visible = false;
            btnConfirmReschedule.Visible = true;
        }

        private void comboBoxDateEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void btnCancelReschedule_Click_1(object sender, EventArgs e)
        {
            isRescheduleMode = false;
            this.Close();
        }

        private void SetActiveBtn()
        {
            if (comboBoxDateEdit.SelectedIndex != -1)
            {
                btnConfirmReschedule.Enabled = true;
                btnConfirmReschedule.IconColor = Color.White;
            }
            else
            {
                btnConfirmReschedule.Enabled = false;
                btnConfirmReschedule.IconColor = Color.Black;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmReschedule_Click(object sender, EventArgs e)
        {
            int appointmentId = int.Parse(AppointmentService.GetLastAppointmentID()) + 1;
            int visitId = Appointment.VisitId;
            int? patientId = Appointment.PatientId;
            int doctorId = Appointment.DoctorId;
            bool isAccepted = false;
            string specialization = "";


            var appointment = new Appointment(appointmentId, visitId, doctorId, patientId, isAccepted, specialization);
            AppointmentService.CreateAppointment(appointment, true);

            DateTime visitDate = (DateTime)comboBoxDateEdit.SelectedItem;
            visitId = VisitService.GetVisitIdForDateAndDoctor(visitDate, doctorId);
            AppointmentService.UpdateAppointment(Appointment, visitId);

            AppointmentService.DeleteFreeAppointmentByVisit(visitId);

            FormDisplayAppointments appointmentForm = Application.OpenForms.OfType<FormDisplayAppointments>().FirstOrDefault();
            if (appointmentForm != null)
            {
                appointmentForm.ReloadData();
            }
            MessageBox.Show("Appointment rescheduled.");

            appointmentForm.ReloadData();
            this.Close();
        }

        private void textBoxPatientPeselEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPatientNameEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDoctorNameEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDoctorSpecEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAppointmentReschedule_Load(object sender, EventArgs e)
        {
            foreach (var item in Patients)
            {
                comboBoxPatientPeselEdit.Items.Add(item.Pesel);
                comboBoxPatientNameEdit.Items.Add(item.FirstName + " " + item.LastName);
            }

            comboBoxPatientPeselEdit.SelectedIndex = (int)Appointment.PatientId - 1;
            comboBoxPatientNameEdit.SelectedIndex = (int)Appointment.PatientId - 1;

            textBoxDoctorSpecEdit.Text = Appointment.DoctorSpecialization;
            textBoxDoctorNameEdit.Text = Employees[Appointment.DoctorId - 1].FirstName + " " + Employees[Appointment.DoctorId - 1].LastName;
            comboBoxDateEdit.SelectedIndex = -1;

            Visits = VisitService.GetFreeVistsForDoctorByCalendar(Appointment.DoctorId, calendarId);

            comboBoxDateEdit.Items.Clear();
            foreach (var item in Visits)
            {
                comboBoxDateEdit.Items.Add(item.VisitStartTime);
            }

        }

        private void comboBoxPatientPeselEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDoctorNameEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
