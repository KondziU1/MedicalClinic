using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Forms.PatientsManagement;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.AppointmentsManagement
{
    public partial class FormAddNewAppointment : Form
    {
        private static List<Patient> Patients = PatientService.GetPatients();
        private static List<Employee> Doctors = EmployeeService.GetDoctors();
        private static List<Visit> Visits;
        public static int calendarId;


        public FormAddNewAppointment(int CalendarId)
        {
            InitializeComponent();
            calendarId = CalendarId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddNewAppointment_Load(object sender, EventArgs e)
        {


            foreach (var item in Patients)
            {
                comboBoxPatientsPesel.Items.Add(item.Pesel);
            }

            foreach (var item in Doctors)
            {
                comboBoxDoctorsName.Items.Add(item.FirstName + " " + item.LastName);
            }

        }


        public void btnAdd_Click(object sender, EventArgs e)
        {
            int appointmentId = int.Parse(AppointmentService.GetLastAppointmentID()) + 1;
            int doctorId = Doctors[comboBoxDoctorsName.SelectedIndex].Id;
            DateTime visitDate = (DateTime)comboBoxDate.SelectedItem;
            int visitId = VisitService.GetVisitIdForDateAndDoctor(visitDate, doctorId);
            int patientId = Patients[comboBoxPatientsPesel.SelectedIndex].Id;
            bool isAccepted = false;
            string specialization = "";
            var appointment = new Appointment(appointmentId, visitId, doctorId, patientId, isAccepted, specialization);

            AppointmentService.DeleteFreeAppointmentByVisit(visitId);
            AppointmentService.CreateAppointment(appointment, false);

            MessageBox.Show("Appointment added", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            FormDisplayAppointments displayAppointmentsForm = Application.OpenForms.OfType<FormDisplayAppointments>().FirstOrDefault();
            if (displayAppointmentsForm != null)
            {
                displayAppointmentsForm.ReloadData();
            }
            displayAppointmentsForm.ReloadData();

            this.Close();

        }


        private void comboBoxDoctorsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDoctorSpec.Text = Doctors[comboBoxDoctorsName.SelectedIndex].Specializations[0].ToString();
            Visits = VisitService.GetFreeVistsForDoctorByCalendar(Doctors[comboBoxDoctorsName.SelectedIndex].Id, calendarId);
            comboBoxDate.Items.Clear();
            foreach (var item in Visits)
            {
                comboBoxDate.Items.Add(item.VisitStartTime);
            }

        }


        public List<Patient> FilterPatients()
        {
            List<Patient> filteredPatients = Patients;

            string filterPesel = textBoxPesel.Text;

            filteredPatients = Patients.Where(p => string.IsNullOrEmpty(filterPesel) || p.Pesel.Contains(filterPesel)).ToList();

            return filteredPatients;
        }

        private void UpdateComboBox(List<Patient> filteredPatients)
        {
            comboBoxPatientsPesel.Items.Clear();
            comboBoxPatientsPesel.Items.AddRange(filteredPatients.Select(p => p.Pesel).ToArray());
        }

        private void comboBoxPatientsPesel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatientsPesel.SelectedIndex >= 0)
            {
                Patient selectedPatient = Patients.FirstOrDefault(p => p.Pesel == comboBoxPatientsPesel.SelectedItem.ToString());
                if (selectedPatient != null)
                {
                    textBoxPatientName.Text = selectedPatient.FirstName + ' ' + selectedPatient.LastName;
                }
            }
        }


        private void FormAddNewAppointment_MouseMove(object sender, MouseEventArgs e)
        {
            if (textBoxPatientName.Text.Length > 0 & textBoxDoctorSpec.Text.Length > 0 & comboBoxDate.Text.Length > 0)
            {
                btnAdd.Enabled = true;
            }
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged_1(object sender, EventArgs e)
        {
            List<Patient> filteredPatients = FilterPatients();
            UpdateComboBox(filteredPatients);
        }
    }
}
