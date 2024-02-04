using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Forms;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.EmployeesManagement
{
    public partial class FormEmployeeDetails : Form
    {
        static List<string> Sexes = new List<string>() { "M", "F" };
        static List<bool> Statuses = new List<bool>() { true, false };

        static bool isEditMode = false;

        private readonly Employee Employee;

        private bool InitialEmployeeStatus;

        public FormEmployeeDetails(Employee employee)
        {
            InitializeComponent();
            isEditMode = false;

            Employee = employee;
            InitialEmployeeStatus = Employee.Active;
        }

        public FormEmployeeDetails(Employee employee, bool openEditMode)
        {
            InitializeComponent();

            Employee = employee;
            InitialEmployeeStatus = Employee.Active;

            if (!openEditMode) return;

            btnEdit.Visible = false;
            btnConfirm.Visible = true;
            labelTitle.Text = "Edit employee";

            SetEnableFields();
            isEditMode = true;
        }

        private void FormEmployeeDetails_Load(object sender, EventArgs e)
        {
            var roles = RoleService.GetRoles();

            var specializations = SpecializationService.GetSpecializations();

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

            foreach (var item in Statuses)
            {
                comboBoxActiveStatus.Items.Add(item);
            }


            textBoxId.Text = Employee.Id.ToString();
            textBoxFirstName.Text = Employee.FirstName;
            textBoxLastName.Text = Employee.LastName;
            textBoxPesel.Text = Employee.Pesel;
            dateTimePickerDateOfBirth.Value = Employee.DateOfBirth;
            textBoxCorrespondenceAddress.Text = Employee.CorrespondenceAddress;
            textBoxEmail.Text = Employee.Email;
            textBoxPhone.Text = Employee.PhoneNumber;
            comboBoxSex.SelectedItem = Employee.Sex;
            comboBoxActiveStatus.SelectedItem = Employee.Active;
            comboBoxRole.SelectedIndex = Employee.Role.Id - 1;
            foreach (var item in Employee.Specializations)
            {
                int index = checkedListBoxSpecializations.FindStringExact(item.ToString());
                if (index != -1)
                {
                    checkedListBoxSpecializations.SetItemChecked(index, true);
                }
            }

            checkedListBoxSpecializations.Enabled = true;
            checkedListBoxSpecializations.SelectionMode = SelectionMode.None;

            if (isEditMode)
            {
                checkedListBoxSpecializations.SelectionMode = Employee.Role.Name.ToLower() == "doctor" ? SelectionMode.One : SelectionMode.None;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isEditMode = false;
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnConfirm.Visible = true;
            labelTitle.Text = "Edit employee";

            SetEnableFields();
        }

        private void SetEnableFields()
        {
            textBoxFirstName.Enabled = true;
            textBoxLastName.Enabled = true;
            textBoxPesel.Enabled = true;
            dateTimePickerDateOfBirth.Enabled = true;
            textBoxCorrespondenceAddress.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxPhone.Enabled = true;
            comboBoxSex.Enabled = true;
            comboBoxActiveStatus.Enabled = true;
            comboBoxRole.Enabled = true;
            checkedListBoxSpecializations.SelectionMode = Employee.Role.Name.ToLower() == "doctor" ? SelectionMode.One : SelectionMode.None;
        }

        private void SetActiveBtn()
        {
            if (textBoxFirstName.Text.Length > 0 && textBoxLastName.Text.Length > 0 && textBoxPesel.Text.Length > 0 && dateTimePickerDateOfBirth.Text.Length > 0 && textBoxCorrespondenceAddress.Text.Length > 0 && textBoxEmail.Text.Length > 0 && textBoxPhone.Text.Length > 0 && comboBoxSex.SelectedIndex > -1 && comboBoxActiveStatus.SelectedIndex > -1 && comboBoxRole.SelectedIndex > -1)
            {
                btnConfirm.Enabled = true;
                btnConfirm.IconColor = Color.White;
            }
            else
            {
                btnConfirm.Enabled = false;
                btnConfirm.IconColor = Color.Black;
            }
        }

        private void comboBoxActiveStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetActiveBtn();

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetActiveBtn();
            checkedListBoxSpecializations.SelectionMode = Employee.Role.Name.ToLower() == "doctor" ? SelectionMode.One : SelectionMode.None;
            if (!(((Control)sender).AccessibilityObject.Value == "doctor"))
            {
                for (int i = 0; i < checkedListBoxSpecializations.Items.Count; i++)
                {
                    checkedListBoxSpecializations.SetItemChecked(i, false);
                }
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

        private void textBoxCorrespondenceAddress_TextChanged(object sender, EventArgs e)
        {
            SetActiveBtn();

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            SetActiveBtn();

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            SetActiveBtn();

        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetActiveBtn();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.ValidateFields(textBoxPesel.Text, comboBoxSex.SelectedItem.ToString(), textBoxEmail.Text, textBoxPhone.Text, dateTimePickerDateOfBirth.Value.ToShortDateString()))
            {
                return;
            }

            List<Specialization> specializations = new List<Specialization>();
            foreach (Specialization item in checkedListBoxSpecializations.CheckedItems)
            {
                specializations.Add(item);
            }

            Employee.FirstName = textBoxFirstName.Text;
            Employee.LastName = textBoxLastName.Text;
            Employee.Pesel = textBoxPesel.Text;
            Employee.DateOfBirth = dateTimePickerDateOfBirth.Value;          
            Employee.Role = (Role)comboBoxRole.SelectedItem;
            Employee.CorrespondenceAddress = textBoxCorrespondenceAddress.Text;
            Employee.Email = textBoxEmail.Text;
            Employee.PhoneNumber = textBoxPhone.Text;
            Employee.Specializations = specializations;
            Employee.Sex = (string)comboBoxSex.SelectedItem;
            Employee.Active = (bool)comboBoxActiveStatus.SelectedItem;

            if (InitialEmployeeStatus != (bool)comboBoxActiveStatus.SelectedItem)
            {
                var frm = new FormConfirmChangeStatusEmployee(Employee, true);
                frm.ShowDialog();
            } 
            else
            {
                EmployeeService.UpdateEmployee(Employee);
                MessageBox.Show("Employee's data changed");
            }


            FormEmployees employeeForm = Application.OpenForms.OfType<FormEmployees>().FirstOrDefault();
            if (employeeForm != null)
            {
                employeeForm.ReloadData();
            }

            this.Close();
        }
    }
}
