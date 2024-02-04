using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using System.Configuration;
using Timer = System.Windows.Forms.Timer;
using SystemAdministrationModule.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.Auth
{

    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetActiveButton();
            btnLogin.Enabled = false;
        }




        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void SetActiveButton()
        {
            if (textBoxEmail.Text.Length > 0 && EmailHasAt(textBoxEmail.Text))
            {
                btnLogin.Enabled = true;
                btnLogin.IconColor = Color.White;
            }
            else
            {
                btnLogin.Enabled = false;
                btnLogin.IconColor = Color.Black;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            User userExistInDatabase = UserService.GetUsers().FirstOrDefault(e => e.Email == textBoxEmail.Text);
            if (userExistInDatabase != null)
            {
                var token = UserService.SetTokenForUser(userExistInDatabase);
                var email = new EmailService();
                var emailService = new EmailService();
                await email.SendResetPasswordLinkEmail(userExistInDatabase.Email, token, userExistInDatabase.Id);
            }

            MessageBox.Show("Email with password reset link has been sent");
            this.Hide();
            var frm = new FormForgotPasswordCode();
            frm.Show();

        }
        private bool EmailHasAt(string email)
        {
            return email.Contains("@");
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            SetActiveButton();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new FormForgotPasswordCode();
            frm.Show();
            this.Hide();
        }
    }
}
