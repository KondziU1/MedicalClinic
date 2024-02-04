using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.Auth
{

    public partial class FormForgotPasswordCode : Form
    {
        public FormForgotPasswordCode()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetActiveButton();
            btnOk.Enabled = false;
        }




        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void SetActiveButton()
        {
            if (textBoxCode.Text.Length > 0)
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            User userExistInDatabase = User.CreateEmpty();
            userExistInDatabase = UserService.GetUsersByToken(textBoxCode.Text).FirstOrDefault();
            if (userExistInDatabase != null)
            {
                var frm = new FormForgotPasswordNew(textBoxCode.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Code is invalid or expired");
            }


        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            SetActiveButton();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
