using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using SystemAdministrationModule.Forms.Common;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using Calendar = SystemAdministrationModule.Models.Calendar;

namespace SystemAdministrationModule.Forms.CalendarManagement
{
    public partial class FormAddNewCalendar : Form
    {
        private List<Calendar> Calendars = CalendarService.GetCalendars();

        public FormAddNewCalendar()
        {
            InitializeComponent();
        }

        private void FormAddNewCalendar_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;

            List<DateTime> dates = new List<DateTime>();

            for (int month = 0; month <= 11; month++)
            {
                if (currentDate.Month + month > 12)
                {
                    break;
                }
                DateTime date = new DateTime(currentDate.Year, currentDate.Month + month, 1);
                dates.Add(date);
            }

            foreach (var item in Calendars)
            {
                comboBoxCalendar.Items.Add(item);
            }

            foreach (var item in dates)
            {
                comboBoxDate.Items.Add(item.ToString("Y", CultureInfo.CreateSpecificCulture("en-US")));
            }

            comboBoxDate.SelectedIndex = 0;
            comboBoxCalendar.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("The field with the name is empty", "Failed operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime date = DateTime.ParseExact(comboBoxDate.Text, "MMMM yyyy", CultureInfo.CreateSpecificCulture("en-US"));
            int year = date.Year;
            int month = date.Month;

            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            DateTime lastDayOfMonth = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            Calendar isCalendarExistInDB = CalendarService.GetCalendars().FirstOrDefault(e => e.StartDate == firstDayOfMonth);

            if (isCalendarExistInDB != null)
            {
                MessageBox.Show("This calendar is already in use", "Error adding calendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Calendar isCalendarNameExistInDB = CalendarService.GetCalendars().FirstOrDefault(e => e.Name.ToLower() == textBoxName.Text.ToLower());

            if (isCalendarNameExistInDB != null)
            {
                MessageBox.Show("This calendar name is already in use", "Error adding calendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Calendar calendar = new SystemAdministrationModule.Models.Calendar(0, textBoxName.Text, firstDayOfMonth, lastDayOfMonth, "just_created", false);

            Calendar baseCalendar = (Calendar)comboBoxCalendar.SelectedItem;


            if (checkBoxBasedOnPrevious.Checked)
            {
                if(comboBoxCalendar.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select base calendar", "Error adding calendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (baseCalendar.StartDate > calendar.StartDate)
                {
                    MessageBox.Show("You can't generate a new calendar based on next month", "Error adding calendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                using (FormLoader loader = new FormLoader(() => CalendarService.GenerateCalendarBasedOnOther(calendar, baseCalendar)))
                {
                    loader.ShowDialog(this);
                }
            }
            else
            {
                int calendarId = CalendarService.CreateCalendar(calendar);
                calendar.Id = calendarId;
                using (FormLoader loader = new FormLoader(() => VisitHelper.GenerateVisitsForOffices(calendar)))
                {
                    loader.ShowDialog(this);
                }
            }

            var frm = new FormCalendarCreator(year, month);
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddNewCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCalendars calendarForm = Application.OpenForms.OfType<FormCalendars>().FirstOrDefault();
            if (calendarForm != null)
            {
                calendarForm.ReloadData();
            }
        }

        private void checkBoxBasedOnPrevious_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBasedOnPrevious.Checked)
            {
                comboBoxCalendar.Enabled = true;
            }
            else
            {
                comboBoxCalendar.Enabled = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
