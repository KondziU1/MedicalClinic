using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Forms;
using SystemAdministrationModule.Forms.Auth;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.UserManagement
{
    public partial class FormConfirmChangeStatusUser : Form
    {
        private readonly User User;
        private Employee Employee;

        public FormConfirmChangeStatusUser(User user)
        {

            User = user;
            InitializeComponent();
            IsActiveButton();
            if (SystemAdministrationModule.Settings.Default.env == "dev")
            {
                textBoxAdminPassword.Text = FormLogin.employeeLogged.User.Password;
            }
        }

        private void IsActiveButton()
        {
            if (textBoxAdminPassword.Text.Length > 0)
            {
                btnNext.Enabled = true;
                btnNext.IconColor = Color.White;
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.IconColor = Color.Black;
            }
        }

        private void textBoxAdminPassword_TextChanged(object sender, EventArgs e)
        {
            IsActiveButton();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //TODO CHECK if admin password is correct
            if (textBoxAdminPassword.Text != FormLogin.employeeLogged.User.Password)
            {
                MessageBox.Show("Wrong password! Try again.", "Password error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Employee = EmployeeService.GetEmployees().FirstOrDefault(e => e.User.Id == User.Id);
                int? id = Employee == null ? null : Employee.Id;
                User.Active = !User.Active;

                if (checkBoxSetEmployeeStatus.Checked)
                {
                    UserService.UpdateUser(User, id, true);
                }
                else
                {
                    UserService.UpdateUser(User, id);
                }
                FormUsers usersForm = Application.OpenForms.OfType<FormUsers>().FirstOrDefault();
                if (usersForm != null)
                {
                    usersForm.ReloadData();
                }
                this.Close();
            }
        }

        private void FormConfirmChangeStatusUser_Load(object sender, EventArgs e)
        {
            Employee = EmployeeService.GetEmployees().FirstOrDefault(e => e.User.Id == User.Id);

            if (Employee.Active == true)
            {
                checkBoxSetEmployeeStatus.Visible = true;
            }
            else
            {
                checkBoxSetEmployeeStatus.Visible = false;
            }
        }
    }
}
