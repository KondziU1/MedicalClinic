using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Services;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SystemAdministrationModule.Forms.UserManagement
{
    public partial class FormChangeUserPassword : Form
    {
        private User User;

        private bool isFormDirty = false;

        public FormChangeUserPassword(User user)
        {
            InitializeComponent();

            User = user;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.ValidatePassword(textBoxPassword.Text))
            {
                return;
            }

            if (textBoxPassword.Text != textBoxPasswordConfirmation.Text)
            {
                MessageBox.Show("New password and confirm password do not match.", "Field matching error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User.Password = textBoxPassword.Text;

            btnNext.Enabled = false;
            UserService.UpdateUser(User, null);

            MessageBox.Show("User's password changed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var emailService = new EmailService();
            string subject = "Clinic - new password";
            string body = $"Hello, your password have been updated.<br/>Password: {User.Password}<br/>";
            await emailService.SendEmail(User.Email, subject, body);

            FormUsers usersForm = Application.OpenForms.OfType<FormUsers>().FirstOrDefault();
            if (usersForm != null)
            {
                usersForm.ReloadData();
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isFormDirty)
            {
                var result = MessageBox.Show("Are you sure you want to exit the form without saving changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            this.Close();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
        }

        private void textBoxPasswordConfirmation_TextChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
        }
    }
}
