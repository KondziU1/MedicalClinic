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
    public partial class FormClearCalendar : Form
    {

        private static List<Patient> Patients = PatientService.GetPatients();
        private static List<Employee> Doctors = EmployeeService.GetDoctors();
        private static List<Visit> Visits;

        public static int calendarId;
        public FormClearCalendar(int CalendarId)
        {
            InitializeComponent();
            calendarId = CalendarId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            AppointmentService.DeleteOldAppointment();
            FormDisplayAppointments appointmentForm = Application.OpenForms.OfType<FormDisplayAppointments>().FirstOrDefault();
            MessageBox.Show("Calendar is clear");

            appointmentForm.ReloadData();
            this.Close();

        }

        private void FormClearCalendar_Load(object sender, EventArgs e)
        {

        }
    }
}
