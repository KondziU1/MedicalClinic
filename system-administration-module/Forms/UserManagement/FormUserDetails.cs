using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SystemAdministrationModule.Services;
using User = SystemAdministrationModule.Models.User;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Forms;
using Microsoft.VisualBasic.Logging;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.UserManagement
{
    public partial class FormUserDetails : Form
    {
        static List<bool> Statuses = new List<bool>() { true, false };

        private bool isFormDirty = false;

        private readonly User User;

        static bool isEditMode = false;

        static private Employee? employee = null;
        static private Employee? employeeOld = null;


        public FormUserDetails(User user)
        {
            InitializeComponent();

            User = user;
            isEditMode = false;
            employee = EmployeeService.GetEmployees().FirstOrDefault(e => e.User.Id == User.Id);
            employeeOld = employee;
        }

        public FormUserDetails(User user, bool openEditMode)
        {
            InitializeComponent();

            User = user;
            employee = EmployeeService.GetEmployees().FirstOrDefault(e => e.User.Id == User.Id);
            employeeOld = employee;

            if (!openEditMode) return;

            btnEdit.Visible = false;
            btnConfirm.Visible = true;
            labelTitle.Text = "Edit user";

            SetEnableFields();
            buttonChangePassword.Visible = true;
            //if (employee.Active == true)
            //{
            //    checkBoxSetEmployeeStatus.Visible = true;
            //}
            //else
            //{
            //    checkBoxSetEmployeeStatus.Visible = false;
            //}
            isEditMode = true;
        }

        private void FormUserDetails_Load(object sender, EventArgs e)
        {
            var employeesWithoutUser = EmployeeService.GetEmployeesWithoutUsers();

            if (employee != null)
            {
                comboBoxEmployees.Items.Add(employee);
                comboBoxEmployees.SelectedIndex = 0;
            }

            foreach (var item in employeesWithoutUser)
            {
                comboBoxEmployees.Items.Add(item);
            }

            foreach (var item in Statuses)
            {
                comboBoxActiveStatus.Items.Add(item);
            }

            if (employee.Active == true)
            {
                checkBoxSetEmployeeStatus.Visible = true;
                comboBoxActiveStatus.Enabled = true;
            }
            else
            {
                checkBoxSetEmployeeStatus.Visible = false;
                comboBoxActiveStatus.Enabled = false;
            }


            textBoxId.Text = User.Id.ToString();
            //textBoxFirstName.Text = User.FirstName;
            //textBoxLastName.Text = User.LastName;
            textBoxLogin.Text = User.Login;
            textBoxEmail.Text = User.Email;
            comboBoxActiveStatus.SelectedItem = User.Active;
            //comboBoxRole.SelectedIndex = User.Role.Id - 1;

            isFormDirty = false;
            //textBoxFirstName.Enabled = false;
            //textBoxLastName.Enabled = false;

            //if (isEditMode && comboBoxEmployees.SelectedIndex != -1)
            //{
            //    textBoxFirstName.Enabled = true;
            //    textBoxLastName.Enabled = true;
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnConfirm.Visible = true;
            labelTitle.Text = "Edit user";

            SetEnableFields();
            buttonChangePassword.Visible = true;
            //if (employee.Active == true)
            //{
            //    checkBoxSetEmployeeStatus.Visible = true;
            //}
            //else
            //{
            //    checkBoxSetEmployeeStatus.Visible = false;
            //}
            //if (comboBoxEmployees.SelectedIndex == -1)
            //{
            //    textBoxFirstName.Enabled = false;
            //    textBoxLastName.Enabled = false;
            //}
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.ValidateEmail(textBoxEmail.Text))
            {
                return;
            }

            var isEmailExistInDB = UserService.GetUsers().FirstOrDefault(e => e.Email == textBoxEmail.Text && e.Id != User.Id);

            if (isEmailExistInDB != null)
            {
                MessageBox.Show("This email is already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var isLoginExistInDB = UserService.GetUsers().FirstOrDefault(e => e.Login == textBoxLogin.Text && e.Id != User.Id);

            if (isLoginExistInDB != null)
            {
                MessageBox.Show("This login is already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxLogin.Text.Length < 3) 
            {
                MessageBox.Show("Login is too short", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User.Login = textBoxLogin.Text;
            User.Email = textBoxEmail.Text;
            User.Active = (bool)comboBoxActiveStatus.SelectedItem;
            //User.Role = (Role)comboBoxRole.SelectedItem;
            //User.FirstName = textBoxFirstName.Text;
            //User.LastName = textBoxLastName.Text;

            int? id = employee == null ? null : employee.Id;

            if ((employee != null) && (employeeOld != null) && (employee.Id != employeeOld.Id))
            {
                EmployeeService.DeleteEmployeeFromUsers(employeeOld);
            }

            btnConfirm.Enabled = false;

            if (checkBoxSetEmployeeStatus.Checked)
            {
                UserService.UpdateUser(User, id, true);
            }
            else
            {
                UserService.UpdateUser(User, id);
            }

            MessageBox.Show("User's data changed");

            var emailService = new EmailService();
            string subject = "Clinic - new data";
            string body = $"Hello, your data have been updated.<br/>Login: {User.Login}<br/> Password: {User.Password}<br/> Status: {User.Active}<br/> Role: {User.Role}<br/> First name: {User.FirstName}<br/> Last name: {User.LastName}";
            await emailService.SendEmail(textBoxEmail.Text, subject, body);

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

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
        }

        private void comboBoxActiveStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
        }
        private void SetEnableFields()
        {
            //textBoxFirstName.Enabled = true;
            //textBoxLastName.Enabled = true;
            textBoxLogin.Enabled = true;
            textBoxEmail.Enabled = true;
            comboBoxActiveStatus.Enabled = true;
            //comboBoxRole.Enabled = true;
            comboBoxEmployees.Enabled = true;

        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            var frm = new FormChangeUserPassword(User)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog();
        }

        private void comboBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxEmployees.SelectedIndex == -1)
            //{
            //    textBoxFirstName.Enabled = false;
            //    textBoxLastName.Enabled = false;
            //}
            //else
            //{
            //    textBoxFirstName.Enabled = true;
            //    textBoxLastName.Enabled = true;
            //}

            employee = (Employee)comboBoxEmployees.SelectedItem;
            //textBoxFirstName.Text = employee.FirstName;
            //textBoxLastName.Text = employee.LastName;
        }
    }
}
