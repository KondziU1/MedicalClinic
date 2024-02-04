using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Services;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using SystemAdministrationModule.Forms.EmployeesManagement;

namespace SystemAdministrationModule.Forms.OfficesManagement
{
    public partial class FormOffices : Form
    {
        protected static List<Office> Offices = OfficeService.GetOffices();


        public FormOffices()
        {
            InitializeComponent();
        }
        private void refreshDataToDataGridView(List<Office> data)
        {
            dataGridViewOffices.Rows.Clear();
            foreach (var item in data)
            {
                dataGridViewOffices.Rows.Add(
                    item.Id,
                    item.Number,
                    item.Specialization,
                    item.Type,
                    item.Active ? "active" : "inactive",
                    item.Active ? "Deactive" : "Active",
                    "Edit",
                    "Delete"
                );
            }
        }
        private void FormOffices_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        public void ReloadData()
        {
            Offices = OfficeService.GetOffices();
            refreshDataToDataGridView(Offices);
        }

        private void btnAddOffice_Click(object sender, EventArgs e)
        {
            var frm = new FormAddNewOffice();
            frm.ShowDialog();
        }

        private void dataGridViewOffices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOffices.Columns[e.ColumnIndex].HeaderText == "Action" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewOffices.Rows[e.RowIndex].Cells["id"].Value;
                Office office = Offices.FirstOrDefault(e => e.Id == id);

                if (office == null) { return; }
                office.Active = !office.Active;
                OfficeService.UpdateOffice(office);
                ReloadData();
            }

            if (dataGridViewOffices.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewOffices.Rows[e.RowIndex].Cells["id"].Value;
                var office = Offices.FirstOrDefault(e => e.Id == id);

                var frm = new FormOfficeEdit(office)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();
            }

            if (dataGridViewOffices.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewOffices.Rows[e.RowIndex].Cells["id"].Value;
                var office = Offices.FirstOrDefault(e => e.Id == id);

                var frm = new FormDeleteOffice(office)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();
            }
        }

        private void dataGridViewOffices_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewOffices.Rows.Count == 0)
            {
                TextRenderer.DrawText(e.Graphics, "No records found.",
                    dataGridViewOffices.Font, dataGridViewOffices.ClientRectangle,
                    dataGridViewOffices.ForeColor, dataGridViewOffices.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}
