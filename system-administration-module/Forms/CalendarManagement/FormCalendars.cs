using Microsoft.VisualBasic.ApplicationServices;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Forms.Common;
using SystemAdministrationModule.Forms.OfficesManagement;
using SystemAdministrationModule.Forms.SpecializationsManagment;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.CalendarManagement
{
    public partial class FormCalendars : Form
    {
        protected static List<Calendar> Calendars = CalendarService.GetCalendars();
        static List<string> Statuses = new List<string>() { "Partially accepted", "Accepted", "Just created" };

        private void refreshDataToDataGridView(List<Calendar> data)
        {
            dataGridViewCalendars.Rows.Clear();
            foreach (var item in data)
            {
                dataGridViewCalendars.Rows.Add(
                    item.Id,
                    item.Name,
                    item.StartDate.ToShortDateString(),
                    item.EndDate.ToShortDateString(),
                    item.Status.Replace("_", " "),
                    item.Active ? "Yes" : "No",
                    "Details",
                    "Remove",
                    "Edit"
                );
            }
        }

        public void ReloadData()
        {
            Calendars = CalendarService.GetCalendars();
            refreshDataToDataGridView(Calendars);
            Filter();
        }
        public FormCalendars()
        {
            InitializeComponent();
        }

        private void FormCalendars_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Add("");
            foreach (var item in Statuses)
            {
                comboBoxStatus.Items.Add(item);
            }

            refreshDataToDataGridView(Calendars);

            ReloadData();
        }

        private void Filter()
        {
            List<Calendar> filteredCalendars = FilterCalendars();
            refreshDataToDataGridView(filteredCalendars);
        }

        public List<Calendar> FilterCalendars()
        {
            List<Calendar> filteredCalendars = Calendars;

            string filterName = textBoxName.Text.ToLower();
            string filterRole = comboBoxStatus.Text.ToLower().Replace(" ", "_");

            filteredCalendars = Calendars.Where(u =>
                (string.IsNullOrEmpty(filterName) || u.Name.ToLower().Contains(filterName)) &&
                (string.IsNullOrEmpty(filterRole) || u.Status.Equals(filterRole))
            ).ToList();

            return filteredCalendars;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnAddCalendar_Click(object sender, EventArgs e)
        {
            var frm = new FormAddNewCalendar();
            frm.ShowDialog();
        }

        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCalendars.Columns[e.ColumnIndex].HeaderText == "Remove" && e.RowIndex > -1)
            {
                //int id = (int)dataGridViewCalendars.Rows[e.RowIndex].Cells["id"].Value;

                //Calendar calendar = Calendars.FirstOrDefault(x => x.Id == id);

                //if (calendar.Active == true)
                //{
                //    MessageBox.Show("The choosen calendar is active", "Error removing calendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                //else
                //{
                //    using (FormLoader loader = new FormLoader(() => CalendarService.DeleteCalendar(calendar)))
                //    {
                //        loader.ShowDialog(this);
                //    }

                //    MessageBox.Show("The choosen calendar has been removed", "Success removing calendar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    ReloadData();
                //}

                int id = (int)dataGridViewCalendars.Rows[e.RowIndex].Cells["id"].Value;
                Calendar calendar = Calendars.FirstOrDefault(e => e.Id == id);

                var frm = new FormConfirmDeleteCalendar(calendar)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frm.ShowDialog();
            }

            if (dataGridViewCalendars.Columns[e.ColumnIndex].HeaderText == "Details" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewCalendars.Rows[e.RowIndex].Cells["id"].Value;

                Calendar calendar = Calendars.FirstOrDefault(x => x.Id == id);

                var frm = new FormCalendarCreator(calendar.StartDate.Year, calendar.StartDate.Month, calendar, true);
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }

            if (dataGridViewCalendars.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewCalendars.Rows[e.RowIndex].Cells["id"].Value;

                Calendar calendar = Calendars.FirstOrDefault(x => x.Id == id);

                if (calendar.Active == true)
                {
                    MessageBox.Show("The choosen calendar is active", "Error editing calendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var frm = new FormCalendarCreator(calendar.StartDate.Year, calendar.StartDate.Month);
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
        }

        private void btnDoctorScheadule_Click(object sender, EventArgs e)
        {
            var frm = new FormDoctorScheadule();
            frm.ShowDialog();
        }

        private void dataGridViewEmployees_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewCalendars.Rows.Count == 0)
            {
                TextRenderer.DrawText(e.Graphics, "No records found.",
                    dataGridViewCalendars.Font, dataGridViewCalendars.ClientRectangle,
                    dataGridViewCalendars.ForeColor, dataGridViewCalendars.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void dataGridViewCalendars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
