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
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.DoctorModule
{
    public partial class FormVisitDetails : Form
    {
        DateTime Date;
        int calendarId;
        Appointment appointment;

        public FormVisitDetails(Appointment appointment)
        {
            this.appointment = appointment;
            InitializeComponent();
        }

        private void LoadData()
        {
            if (appointment != null)
            {
                List<Office> offices = OfficeService.GetOffices();
                List<Patient> patients = PatientService.GetPatients();
                var officeData = offices.FirstOrDefault(o => o.Id == appointment.Visit.OfficeId);
                var patientData = patients.FirstOrDefault(p => p.Id == appointment.PatientId);

                if (officeData != null && patientData != null)
                {
                    Date = appointment.Visit.VisitStartTime;
                    calendarId = appointment.Visit.CalendarId;
                    textBoxFirstName.Text = appointment.Patient.FirstName;
                    textBoxLastName.Text = appointment.Patient.LastName;
                    textBoxFirstName.Text = patientData.FirstName;
                    textBoxLastName.Text = patientData.LastName;
                    textBoxPesel.Text = patientData.Pesel;
                    textBoxOffice.Text = officeData.ToString();
                    textBoxVisitStartTime.Text = appointment.Visit.VisitStartTime.ToShortTimeString();
                    textBoxVisitEndTime.Text = appointment.Visit.VisitEndTime.ToShortTimeString();
                }
            }
        }

        internal void VerifyCommentExistence()
        {
            var comment = AppointmentService.GetCommentByAppointmentId(appointment.Id);
            if (!string.IsNullOrEmpty(comment))
            {
                btnRejectOrComment.IconChar = FontAwesome.Sharp.IconChar.Comment;
                btnRejectOrComment.Text = "Show Comment";
                btnRejectOrComment.TextAlign = ContentAlignment.MiddleCenter;
                btnRejectOrComment.Enabled = true;
            }
            else
            {

                btnRejectOrComment.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
                btnRejectOrComment.Text = "Register results";
                btnRejectOrComment.TextAlign = ContentAlignment.MiddleCenter;
                btnRejectOrComment.Enabled = true;

            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();

            if (Date.Date == DateTime.Today)
            {
                btnRejectOrComment.Enabled = false;

                if (Date <= DateTime.Now)
                {
                    VerifyCommentExistence();
                }
            }
            else
            {
                if (Date <= DateTime.Now)
                {
                    VerifyCommentExistence();
                }
            }
        }

        private void btnRejectOrComment_Click(object sender, EventArgs e)
        {
            if (Date <= DateTime.Now)
            {
                var frm = new FormComment(appointment);
                frm.ShowDialog();
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to reject this appointment?", "Confirmation of rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Date != DateTime.Today)
                    {

                        AppointmentService.DeleteAppointment(appointment);
                        var frm = Application.OpenForms.OfType<FormCalendarDetails>().FirstOrDefault();
                        frm.LoadData(Date);
                        FormVisitDetails.ActiveForm.Close();
                    }
                }
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
