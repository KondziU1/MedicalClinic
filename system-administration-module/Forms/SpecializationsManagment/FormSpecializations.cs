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
using SystemAdministrationModule.Forms.SpecializationsManagment;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.SpecializationsManagment
{
    public partial class FormSpecializations : Form
    {
        protected static List<Specialization> Specializations = SpecializationService.GetSpecializations();

        private void refreshDataToDataGridView(List<Specialization> data)
        {
            dataGridViewSpecializations.Rows.Clear();
            foreach (var item in data)
            {
                dataGridViewSpecializations.Rows.Add(
                    item.Id,
                    item.Name,
                    "Edit",
                    "Remove"
                );
            }
        }
        public FormSpecializations()
        {
            InitializeComponent();
        }
        public void ReloadData()
        {
            Specializations = SpecializationService.GetSpecializations();
            refreshDataToDataGridView(Specializations);
            
        }
        private void FormSpecializations_Load(object sender, EventArgs e)
        {
            refreshDataToDataGridView(Specializations);
            if (dataGridViewSpecializations.RowCount == 0)
            {
                MessageBox.Show("List of specializations is empty.");
            }
        }
        private void btnAddSpecialization_Click(object sender, EventArgs e)
        {

            var frm = new FormAddNewSpecialization
            {
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog();
        }

        private void DataGridViewSpecializations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSpecializations.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewSpecializations.Rows[e.RowIndex].Cells["id"].Value;

                var specialization = Specializations.FirstOrDefault(x => x.Id == id);

                var frm = new FormEditSpecialization(specialization)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();

            }
            if (dataGridViewSpecializations.Columns[e.ColumnIndex].HeaderText == "Remove" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewSpecializations.Rows[e.RowIndex].Cells["id"].Value;

                var specialization = Specializations.FirstOrDefault(x => x.Id == id);

                var frm = new FormRemoveSpecialization(specialization)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();

            }

        }

        private void dataGridViewSpecializations_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewSpecializations.Rows.Count == 0)
            {
                TextRenderer.DrawText(e.Graphics, "No records found.",
                    dataGridViewSpecializations.Font, dataGridViewSpecializations.ClientRectangle,
                    dataGridViewSpecializations.ForeColor, dataGridViewSpecializations.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}
