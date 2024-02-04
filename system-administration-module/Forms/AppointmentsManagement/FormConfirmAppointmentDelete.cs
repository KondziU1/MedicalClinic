using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Forms.PatientsManagement;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.AppointmentsManagement
{
    public partial class FormConfirmAppointmentDelete : Form
    {
        private readonly Appointment Appointment;

        public FormConfirmAppointmentDelete(Appointment appointment)
        {
            InitializeComponent();

            Appointment = appointment;
        }

        private void labelDeletePatient_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            DateTime currentDateTime = DateTime.Now;
            DateTime appointmentDateTime = Appointment.Visit.VisitStartTime.Date;

            if (appointmentDateTime > currentDateTime)
            {
                var result = AppointmentService.DeleteAppointmentPatientId(Appointment.Id);

                if (result)
                {
                    MessageBox.Show("Appointment is deleted");

                    FormDisplayAppointments appointmentForm = Application.OpenForms.OfType<FormDisplayAppointments>().FirstOrDefault();
                    if (appointmentForm != null)
                    {
                        appointmentForm.ReloadData();

                    }
                }
                else
                {
                    MessageBox.Show("Failed to delete appointment");
                }
            }
            else
            {
                MessageBox.Show("Cannot delete appointment with a past date");
            }

            this.Close();

        }

        private void FormConfirmAppointmentDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
