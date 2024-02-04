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
    public partial class FormComment : Form
    {
        Appointment appointment;
        string initialComment;
        internal bool commentExists = false;
        public FormComment(Appointment appointment)
        {
            this.appointment = appointment;
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 150;
            int currentLength = richTextBoxComment.Text.Length;

            if (richTextBoxComment.Text != initialComment)
            {
                btnConfirm.Enabled = true;
            }
            else
                btnConfirm.Enabled = false;


            if (currentLength > maxLength)
            {
                richTextBoxComment.Text = richTextBoxComment.Text.Substring(0, maxLength);
                richTextBoxComment.SelectionStart = maxLength;
                currentLength = maxLength;
                label1.ForeColor = Color.Red;
            }
            else
                label1.ForeColor = Color.Black;

            label1.Text = $"{currentLength}/{maxLength}";
        }

        internal void btnConfirm_Click(object sender, EventArgs e)
        {
            string comment = richTextBoxComment.Text;

            if (commentExists)
            {
                AppointmentService.UpdateComment(appointment.Id, comment);
            }
            else
            {
                AppointmentService.AddComment(appointment.Id, comment);
            }

            var frm = Application.OpenForms.OfType<FormVisitDetails>().FirstOrDefault();

            if (frm != null)
            {
                frm.VerifyCommentExistence();
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegisterResult_Load(object sender, EventArgs e)
        {
            var comment = AppointmentService.GetCommentByAppointmentId(appointment.Id);
            if (comment != string.Empty)
            {
                richTextBoxComment.Text = comment;
                initialComment = richTextBoxComment.Text;
                btnConfirm.Enabled = false;
                commentExists = true;
            }

            var frm = Application.OpenForms.OfType<FormVisitHistory>().FirstOrDefault();
            if (frm != null)
            {
                richTextBoxComment.ReadOnly = true;
            }
        }

    }
}