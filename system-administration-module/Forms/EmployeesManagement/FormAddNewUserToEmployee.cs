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
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms
{
    public partial class FormAddNewUserToEmployee : Form
    {
        public FormAddNewUserToEmployee()
        {
            InitializeComponent();
        }

        private void FormAddNewUserToEmployee_Load(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            //var employee = new Employee(0,
            //                            FormAddNewEmployee.FirstNameValue,
            //                            FormAddNewEmployee.LastNameValue,
            //                            FormAddNewEmployee.PeselValue,
            //                            DateTime.Parse(FormAddNewEmployee.DateValue),
            //                            true,
            //                            FormAddNewEmployee.RoleValue,
            //                            FormAddNewEmployee.AddressValue,
            //                            FormAddNewEmployee.EmailValue,
            //                            FormAddNewEmployee.PhoneValue,
            //                            FormAddNewEmployee.Specializations,
            //                            FormAddNewEmployee.SexValue,
            //                            User.CreateEmpty());

            //EmployeeService.CreateEmployee(employee);

            //MessageBox.Show("Employee added", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //FormEmployees employeeForm = Application.OpenForms.OfType<FormEmployees>().FirstOrDefault();
            //if (employeeForm != null)
            //{
            //    employeeForm.ReloadData();
            //}

            //this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var employee = new Employee(0,
            //                            FormAddNewEmployee.FirstNameValue,
            //                            FormAddNewEmployee.LastNameValue,
            //                            FormAddNewEmployee.PeselValue,
            //                            DateTime.Parse(FormAddNewEmployee.DateValue),
            //                            true,
            //                            FormAddNewEmployee.RoleValue,
            //                            FormAddNewEmployee.AddressValue,
            //                            FormAddNewEmployee.EmailValue,
            //                            FormAddNewEmployee.PhoneValue,
            //                            FormAddNewEmployee.Specializations,
            //                            FormAddNewEmployee.SexValue,
            //                            new User(0,
            //                                    0,
            //                                    textBoxLogin.Text,
            //                                    textBoxPassword.Text,
            //                                    FormAddNewEmployee.EmailValue,
            //                                    true,
            //                                    FormAddNewEmployee.RoleValue,
            //                                    FormAddNewEmployee.FirstNameValue,
            //                                    FormAddNewEmployee.LastNameValue,
            //                                    null,
            //                                    null));

            //var isLoginExistInDB = EmployeeService.GetEmployees().FirstOrDefault(e => e.User.Login == textBoxLogin.Text);

            //if (isLoginExistInDB != null)
            //{
            //    MessageBox.Show("Passed login exist in Database", "Error adding employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (!ValidationHelper.ValidatePassword(textBoxPassword.Text))
            //{
            //    return;
            //}

            //EmployeeService.CreateEmployee(employee);

            //MessageBox.Show("Employee and user added", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //FormEmployees employeeForm = Application.OpenForms.OfType<FormEmployees>().FirstOrDefault();
            //if (employeeForm != null)
            //{
            //    employeeForm.ReloadData();
            //}

            //this.Close();
        }


        private void SetActiveBtn()
        {
            if (textBoxLogin.Text.Length > 0 && textBoxPassword.Text.Length > 0)
            {
                btnAdd.Enabled = true;
                btnAdd.IconColor = Color.White;
            }
            else
            {
                btnAdd.Enabled = false;
                btnAdd.IconColor = Color.Black;
            }
        }

        private void FormAddNewUserToEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form parentForm = (Form)this.Owner;

            parentForm.Close();
        }


    }
}
