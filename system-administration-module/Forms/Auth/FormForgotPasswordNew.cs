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

    public partial class FormForgotPasswordNew : Form
    {
        User user = User.CreateEmpty();
        string tokenData = string.Empty;
        public FormForgotPasswordNew(string token)
        {
            user = UserService.GetUsersByToken(token).FirstOrDefault();
            tokenData = token.Trim();
            string login = user.Login ?? string.Empty;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetActiveButton();
            btnOk.Enabled = false;
            loginLabel.Text = "Login: " + login;
        }




        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void SetActiveButton()
        {
            if (textBoxNewPassword.Text.Length > 0 && (textBoxConfirmPassword.Text.Length > 0))
            {
                btnOk.Enabled = true;
                btnOk.IconColor = Color.White;
            }
            else
            {
                btnOk.Enabled = false;
                btnOk.IconColor = Color.Black;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(textBoxNewPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Your passwords are diffrent");
                return;
            }
            if(!ValidationHelper.ValidatePassword(textBoxNewPassword.Text))
            {
                return;
            }
            UserService.SetPassword(tokenData, textBoxNewPassword.Text);
            MessageBox.Show("Your password has been changed");
            this.Hide();
            var frm = new FormLogin();
            frm.Show();

        }


        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            SetActiveButton();
        }

        private void FormForgotPasswordNew_Load(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            SetActiveButton();
        }
    }
}
