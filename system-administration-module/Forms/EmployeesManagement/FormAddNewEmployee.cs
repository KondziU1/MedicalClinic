using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SystemAdministrationModule.Forms
{
    public partial class FormAddNewEmployee : Form
    {
        static List<string> Sexes = new List<string>() { "M", "F" };

        public FormAddNewEmployee()
        {
            InitializeComponent();
        }

        private void FormAddNewEmployee_Load(object sender, EventArgs e)
        {
            checkedListBoxSpecializations.Enabled = false;

            var roles = RoleService.GetRoles();

            var specializations = SpecializationService.GetSpecializations();

            SetActiveBtn();

            foreach (var item in roles)
            {
                comboBoxRole.Items.Add(item);
            }

            foreach (var item in specializations)
            {
                checkedListBoxSpecializations.Items.Add(item);
            }

            foreach (var item in Sexes)
            {
                comboBoxSex.Items.Add(item);
            }

            textBoxLogin.Enabled = false;
            textBoxPassword.Enabled = false;
            textBoxPasswordConfirmation.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<Specialization> Specializations = new();
            var FirstNameValue = textBoxFirstName.Text;
            var LastNameValue = textBoxLastName.Text;
            var PeselValue = textBoxPesel.Text;
            var DateValue = dateTimePickerDateOfBirth.Text;
            var RoleValue = (Role)comboBoxRole.SelectedItem;
            foreach (Specialization item in checkedListBoxSpecializations.CheckedItems)
            {
                Specializations.Add(item);
            }
            var AddressValue = textBoxAddress.Text;
            var EmailValue = textBoxEmail.Text;
            var PhoneValue = textBoxPhone.Text;
            var SexValue = (string)comboBoxSex.SelectedItem;

            var isEmailExistInDB = EmployeeService.GetEmployees().FirstOrDefault(e => e.Email == EmailValue);

            if (isEmailExistInDB != null)
            {
                MessageBox.Show("This email is already in use", "Error adding employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var isPeselExistInDB = EmployeeService.GetEmployees().FirstOrDefault(e => e.Pesel == PeselValue);

            if (isPeselExistInDB != null)
            {
                MessageBox.Show("This PESEL is already in use", "Error adding employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidationHelper.ValidateFields(PeselValue, SexValue, EmailValue, PhoneValue, DateValue))
            {
                return;
            }

            if (checkBoxUser.Checked == true)
            {
                var employee = new Employee(0,
                                        FirstNameValue,
                                        LastNameValue,
                                        PeselValue,
                                        DateTime.Parse(DateValue),
                                        true,
                                        RoleValue,
                                        AddressValue,
                                        EmailValue,
                                        PhoneValue,
                                        Specializations,
                                        SexValue,
                                        new User(0,
                                                0,
                                                textBoxLogin.Text,
                                                textBoxPassword.Text,
                                                EmailValue,
                                                true,
                                                RoleValue,
                                                FirstNameValue,
                                                LastNameValue,
                                                null,
                                                null));

                var isLoginExistInDB = EmployeeService.GetEmployees().FirstOrDefault(e => e.User.Login == textBoxLogin.Text);

                if (isLoginExistInDB != null)
                {
                    MessageBox.Show("This login is already in use", "Error adding employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidationHelper.ValidatePassword(textBoxPassword.Text))
                {
                    return;
                }

                if (textBoxPassword.Text != textBoxPasswordConfirmation.Text)
                {
                    MessageBox.Show("Passed passwords are not equal", "Error password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EmployeeService.CreateEmployee(employee);

                MessageBox.Show("Employee and user added", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var employee = new Employee(0,
                                        FirstNameValue,
                                        LastNameValue,
                                        PeselValue,
                                        DateTime.Parse(DateValue),
                                        true,
                                        RoleValue,
                                        AddressValue,
                                        EmailValue,
                                        PhoneValue,
                                        Specializations,
                                        SexValue,
                                        User.CreateEmpty());

                EmployeeService.CreateEmployee(employee);

                MessageBox.Show("Employee added", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FormEmployees employeeForm = Application.OpenForms.OfType<FormEmployees>().FirstOrDefault();
            if (employeeForm != null)
            {
                employeeForm.ReloadData();
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetActiveBtn()
        {
            if (textBoxFirstName.Text.Length > 0 && textBoxLastName.Text.Length > 0 && textBoxPesel.Text.Length > 0 && dateTimePickerDateOfBirth.Text.Length > 0 && comboBoxRole.SelectedIndex > -1)
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

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void textBoxPesel_TextChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetActiveBtn();

            checkedListBoxSpecializations.Enabled = ((Control)sender).AccessibilityObject.Value == "doctor";
            if (!(((Control)sender).AccessibilityObject.Value == "doctor"))
            {
                for (int i = 0; i < checkedListBoxSpecializations.Items.Count; i++)
                {
                    checkedListBoxSpecializations.SetItemChecked(i, false);
                }
            }

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxUser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUser.Checked == true)
            {
                textBoxLogin.Enabled = true;
                textBoxPassword.Enabled = true;
                textBoxPasswordConfirmation.Enabled = true;
            }
            else
            {
                textBoxLogin.Text = string.Empty;
                textBoxLogin.Enabled = false;
                textBoxPassword.Text = string.Empty;
                textBoxPassword.Enabled = false;
                textBoxPasswordConfirmation.Text = string.Empty;
                textBoxPasswordConfirmation.Enabled = false;
            }
        }
    }
}
