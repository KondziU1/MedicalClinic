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
using SystemAdministrationModule.Forms.EmployeesManagement;
using SystemAdministrationModule.Forms;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using User = SystemAdministrationModule.Models.User;

namespace SystemAdministrationModule.Forms.UserManagement
{
    public partial class FormUsers : Form
    {
        protected static List<User> Users = UserService.GetUsers();
        readonly static List<Role> Roles = RoleService.GetRoles();

        private void refreshDataToDataGridView(List<User> data)
        {
            dataGridViewUsers.Rows.Clear();
            foreach (var item in data)
            {
                dataGridViewUsers.Rows.Add(
                    item.Id,
                    item.Login,
                    item.FirstName.Length > 0 ? item.FirstName : "-",
                    item.LastName.Length > 0 ? item.LastName : "-",
                    item.Role,
                    item.Email,
                    item.Active ? "active" : "inactive",
                    "Review",
                    item.Active ? "Deactivate user" : "Activate user",
                    "Edit"
                );
            }
        }

        public void ReloadData()
        {
            Users = UserService.GetUsers();
            refreshDataToDataGridView(Users);
            Filter();
        }

        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            comboBoxRoles.Items.Add("");
            foreach (var item in Roles)
            {
                comboBoxRoles.Items.Add(item.GetName());
            }

            refreshDataToDataGridView(Users);

            ReloadData();
            Filter();
        }

        private void Filter()
        {
            var filteredUsers = FilterUsers();
            refreshDataToDataGridView(filteredUsers);
        }

        public List<User> FilterUsers()
        {
            List<User> filteredUsers = Users;

            string filterLogin = textBoxLogin.Text.ToLower();
            string filterFirstName = textBoxFirstName.Text.ToLower();
            string filterLastName = textBoxLastName.Text.ToLower();
            string filterRole = comboBoxRoles.Text.ToLower();

            filteredUsers = Users.Where(u =>
                (string.IsNullOrEmpty(filterLogin) || u.Login.ToLower().Contains(filterLogin)) &&
                (string.IsNullOrEmpty(filterFirstName) || u.FirstName.ToLower().Contains(filterFirstName)) &&
                (string.IsNullOrEmpty(filterLastName) || u.LastName.ToLower().Contains(filterLastName)) &&
                (string.IsNullOrEmpty(filterRole) || u.Role.Name.Equals(filterRole))
            ).ToList();

            return filteredUsers;
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsers.Columns[e.ColumnIndex].HeaderText == "Review" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewUsers.Rows[e.RowIndex].Cells["id"].Value;

                var user = Users.FirstOrDefault(x => x.Id == id);

                var frm = new FormUserDetails(user)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();
            }

            if (dataGridViewUsers.Columns[e.ColumnIndex].HeaderText == "Action" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewUsers.Rows[e.RowIndex].Cells["id"].Value;
                var user = Users.FirstOrDefault(e => e.Id == id);

                if (user == null) { return; }

                Employee employee = EmployeeService.GetEmployees().FirstOrDefault(e => e.User.Id == user.Id);
                if (employee.Active == false)
                {
                    MessageBox.Show("Employee is inactive! You can't do this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var frm = new FormConfirmChangeStatusUser(user);
                frm.ShowDialog();

            }

            if (dataGridViewUsers.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewUsers.Rows[e.RowIndex].Cells["id"].Value;
                var user = Users.FirstOrDefault(x => x.Id == id);

                var frm = new FormUserDetails(user, true)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var frm = new FormAddNewUser
            {
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog();
        }

        private void dataGridViewUsers_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewUsers.Rows.Count == 0)
            {
                TextRenderer.DrawText(e.Graphics, "No records found.",
                    dataGridViewUsers.Font, dataGridViewUsers.ClientRectangle,
                    dataGridViewUsers.ForeColor, dataGridViewUsers.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}
