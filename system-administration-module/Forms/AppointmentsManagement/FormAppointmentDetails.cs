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

namespace SystemAdministrationModule.Forms.AppointmentsManagement
{
    public partial class FormAppointmentDetails : Form
    {
        private static List<Patient> Patients = PatientService.GetPatients();
        private static List<Employee> Employees = EmployeeService.GetEmployees();
        private static List<Visit> Visits;
        private readonly Appointment Appointment;
        public static int calendarId;

        public FormAppointmentDetails(Appointment appointment, int CalendarId)
        {
            InitializeComponent();

            calendarId = CalendarId;

            Appointment = appointment;
        }


        private void FormAppointmentDetails_Load(object sender, EventArgs e)
        {
            foreach (var item in Patients)
            {
                comboBoxPatientPeselDetails.Items.Add(item.Pesel);
                comboBoxPatientNameDetails.Items.Add(item.FirstName + " " + item.LastName);
            }

            comboBoxPatientPeselDetails.SelectedIndex = (int)Appointment.PatientId - 1;
            comboBoxPatientNameDetails.SelectedIndex = (int)Appointment.PatientId - 1;

            textBoxDoctorSpecDetails.Text = Appointment.DoctorSpecialization;
            textBoxDoctorNameDetails.Text = Employees[Appointment.DoctorId - 1].FirstName + " " + Employees[Appointment.DoctorId - 1].LastName;
            Visits = VisitService.GetVisitsForID(Appointment.VisitId);
            textBoxDateDetails.Text = Visits[0].VisitStartTime.ToString();


        }
        private void btnOkDetails_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
