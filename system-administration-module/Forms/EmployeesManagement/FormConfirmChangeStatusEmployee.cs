using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using SystemAdministrationModule.Forms;
using SystemAdministrationModule.Forms.Auth;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.EmployeesManagement
{
    public partial class FormConfirmChangeStatusEmployee : Form
    {
        private readonly Employee Employee;
        private bool FromEditMode = false;
        public FormConfirmChangeStatusEmployee(Employee employee)
        {
            Employee = employee;
            InitializeComponent();
            IsActiveButton();
            if (ConfigurationManager.AppSettings["env"] == "dev")
            {
                textBoxAdminPassword.Text = FormLogin.employeeLogged.User.Password;
            }
        }

        public FormConfirmChangeStatusEmployee(Employee employee, bool fromEditMode)
        {
            Employee = employee;
            InitializeComponent();
            IsActiveButton();
            if (ConfigurationManager.AppSettings["env"] == "dev")
            {
                textBoxAdminPassword.Text = FormLogin.employeeLogged.User.Password;
            }
            FromEditMode = fromEditMode;
        }

        private void FormConfirmDeActiveEmployee_Load(object sender, EventArgs e)
        {

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


        private void TextBoxAdminPassword_TextChanged(object sender, EventArgs e)
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
                if(!FromEditMode)
                {
                    Employee.Active = !Employee.Active;
                }
                Employee.User.Active = Employee.Active;

                EmployeeService.UpdateEmployee(Employee);
                MessageBox.Show("Employee's data changed");

                FormEmployees employeeForm = Application.OpenForms.OfType<FormEmployees>().FirstOrDefault();
                if (employeeForm != null)
                {
                    employeeForm.ReloadData();
                }
                this.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
