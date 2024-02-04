using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SystemAdministrationModule.Forms.CalendarManagement;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.AppointmentsManagement
{
    public partial class FormAppointmentsCalendars : Form
    {
        protected static List<Calendar> Calendars = CalendarService.GetCalendars();
        static List<string> Statuses = new List<string>() { "Partially accepted", "Accepted", "Just created" };

        public FormAppointmentsCalendars()
        {
            InitializeComponent();
        }
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
                    "Details"
                );
            }
        }
        public void ReloadData()
        {
            Calendars = CalendarService.GetAcceptedCalendars();
            refreshDataToDataGridView(Calendars);
            Filter();

        }

        private void refreshDataToDataGridView(List<Appointment> appointments)
        {
            throw new NotImplementedException();
        }

        private void Filter()
        {
            var filteredCalendars = FilterCalendars();
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


        private void dataGridViewCalendars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCalendars.Columns[e.ColumnIndex].HeaderText == "Details" && e.RowIndex > -1)
            {
                int id = (int)dataGridViewCalendars.Rows[e.RowIndex].Cells["id"].Value;

                var calendar = Calendars.FirstOrDefault(x => x.Id == id);

                var frm = new FormAppointmentsCalendarCreator(calendar.StartDate.Year, calendar.StartDate.Month, calendar, true);
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
        }

        private void comboBoxStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBoxName_TextChanged_1(object sender, EventArgs e)
        {
            Filter();
        }

        private void FormAppointmentsCalendars_Load_1(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Add("");
            foreach (var item in Statuses)
            {
                comboBoxStatus.Items.Add(item);
            }

            refreshDataToDataGridView(Calendars);

            ReloadData();
        }
    }
}
