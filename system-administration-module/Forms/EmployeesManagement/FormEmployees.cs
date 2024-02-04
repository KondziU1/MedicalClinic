using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Forms.EmployeesManagement;
using SystemAdministrationModule.Services;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms
{
    public partial class FormEmployees : Form
    {
        protected static List<Employee> Employees = EmployeeService.GetEmployees();
        static List<string> Statuses = new List<string>() { "All", "Active", "Inactive" };
        readonly static List<Role> Roles = RoleService.GetRolesWithAll();

        public ComboBox ComboBoxRoles => comboBoxRoles;
        public ComboBox ComboBoxStatuses => ComboBoxStatuses;

        private void refreshDataToDataGridView(List<Employee> data)
        {
            dataGridViewEmployees.Rows.Clear();
            foreach (var item in data)
            {
                dataGridViewEmployees.Rows.Add(
                    item.Id,
                    item.FirstName,
                    item.LastName,
                    item.Pesel,
                    item.DateOfBirth.ToShortDateString(),
                    item.Role.GetName(),
                    item.CorrespondenceAddress,
                    item.Email,
                    item.Sex,
                    item.Active ? "active" : "inactive",
                    "Review employee",
                    item.Active ? "Deactivate" : "Activate",
                    "Edit emplyee"
                );
            }
        }

        public FormEmployees()
        {
            InitializeComponent();
            List<Calendar> calendars = CalendarService.GetCalendars();
        }
        public void ReloadData()
        {
            Employees = EmployeeService.GetEmployees();
            refreshDataToDataGridView(Employees);
            Filter();
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            refreshDataToDataGridView(Employees);

            foreach (var item in Statuses)
            {
                comboBoxStatuses.Items.Add(item);
            }

            foreach (var item in Roles)
            {
                comboBoxRoles.Items.Add(item.GetName());
            }

            comboBoxStatuses.SelectedIndex = 0;
            comboBoxRoles.SelectedIndex = 0;

            ReloadData();
        }

        private void BtnAddEmpoloyee_Click(object sender, EventArgs e)
        {
            var frm = new FormAddNewEmployee
            {
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog();
        }

        private void DataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmployees.Columns[e.ColumnIndex].HeaderText == "Review" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewEmployees.Rows[e.RowIndex].Cells["id"].Value;

                var employee = Employees.FirstOrDefault(x => x.Id == id);

                var frm = new FormEmployeeDetails(employee)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();

            }

            if (dataGridViewEmployees.Columns[e.ColumnIndex].HeaderText == "Action" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewEmployees.Rows[e.RowIndex].Cells["id"].Value;
                Employee employee = Employees.FirstOrDefault(e => e.Id == id);

                if (employee == null) { return; }
                var frm = new FormConfirmChangeStatusEmployee(employee);
                frm.ShowDialog();

            }

            if (dataGridViewEmployees.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewEmployees.Rows[e.RowIndex].Cells["id"].Value;
                var employee = Employees.FirstOrDefault(e => e.Id == id);

                var frm = new FormEmployeeDetails(employee, true)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();
            }
        }
        private void comboBoxStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
        public List<Employee> FilterEmployee()
        {
            List<Employee> filteredEmployees = Employees;
            if (comboBoxRoles.SelectedItem == null || comboBoxStatuses.SelectedItem == null)
            {
                return filteredEmployees;
            }

            string roleValue = comboBoxRoles.SelectedItem.ToString().ToLower();
            string statusValue = comboBoxStatuses.SelectedItem.ToString().ToLower();


            if (roleValue != "all")
            {
                filteredEmployees = filteredEmployees.Where(item => item.Role.GetName().ToLower() == roleValue).ToList();
            }

            if (statusValue == "active")
            {
                filteredEmployees = filteredEmployees.Where(item => item.Active).ToList();
            }
            else if (statusValue == "inactive")
            {
                filteredEmployees = filteredEmployees.Where(item => !item.Active).ToList();
            }
            return filteredEmployees;
        }
        private void Filter()
        {

            var filteredEmployees = FilterEmployee();
            refreshDataToDataGridView(filteredEmployees);
        }


        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewEmployees_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewEmployees.Rows.Count == 0)
            {
                TextRenderer.DrawText(e.Graphics, "No records found.",
                    dataGridViewEmployees.Font, dataGridViewEmployees.ClientRectangle,
                    dataGridViewEmployees.ForeColor, dataGridViewEmployees.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
