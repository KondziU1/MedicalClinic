using Microsoft.VisualBasic;
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
using SystemAdministrationModule.Forms.Common;

namespace SystemAdministrationModule.Forms.UserManagement
{
    public partial class FormAddNewUser : Form
    {
        private bool isFormDirty = false;

        public FormAddNewUser()
        {
            InitializeComponent();
        }
        private void FormAddNewUser_Load(object sender, EventArgs e)
        {

            var employeesWithOutUser = EmployeeService.GetEmployeesWithoutUsers();

            foreach (var item in employeesWithOutUser)
            {
                comboBoxEmployee.Items.Add(item);
            }

            isFormDirty = false;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            int? id = (Employee)comboBoxEmployee.SelectedItem == null ? null : ((Employee)comboBoxEmployee.SelectedItem).Id;

            if (id == null)
            {
                MessageBox.Show("You must choose employee", "Error adding user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string login = AuthHelper.GenerateLogin();
            string password = AuthHelper.GeneratePassword();
            Employee employee = (Employee)comboBoxEmployee.SelectedItem;
            var email = employee.Email;
            var user = new User(0, id, login, password, employee.Email, true, employee.Role, null, null, null, null);
            UserService.CreateUser(user, id);
            var emailService = new EmailService();
            string subject = "Clinic - new account";
            string body = $"Hello, you have been added to the system.<br/>Your login information is: <br/>Login: {login} <br/>Password: {password}";

            using (FormLoader loader = new FormLoader(() => emailService.SendEmail(email, subject, body)))
            {
                loader.ShowDialog(this);
            }

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

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
        }
    }
}
