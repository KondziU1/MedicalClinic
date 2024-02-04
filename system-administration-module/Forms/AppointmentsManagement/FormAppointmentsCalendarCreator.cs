using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using SystemAdministrationModule.Forms.CalendarManagement;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using Calendar = SystemAdministrationModule.Models.Calendar;
using Control = System.Windows.Forms.Control;

namespace SystemAdministrationModule.Forms.AppointmentsManagement
{
    public partial class FormAppointmentsCalendarCreator : Form
    {
        private Calendar Calendar;
        public static int Month;
        public static int Year;

        public FormAppointmentsCalendarCreator(int year, int month, Calendar calendar, bool openDetailsMode)
        {
            InitializeComponent();
            Calendar = calendar;
            Month = month;
            Year = year;
        }

        private void FormAppointmentsCalendarCreator_Load(object sender, EventArgs e)
        {
            string monthName = new DateTime(1, Month, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US"));
            labelMonth.Text = monthName;

            DisplayCalendar();

        }
        private void DisplayCalendar()
        {
            var firstDay = new DateTime(Year, Month, 1);

            var days = DateTime.DaysInMonth(Year, Month);

            var dayOfWeek = Convert.ToInt32(firstDay.DayOfWeek.ToString("d"));

            if (dayOfWeek == 0)
            {
                dayOfWeek = 7;
            }

            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank blank = new UserControlBlank();
                blank.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
                flowLayoutPanelContainer.Controls.Add(blank);
            }

            for (int i = 1; i <= days; i++)
            {
                DateTime date = new DateTime(Year, Month, i);
                UserControlDay day = new UserControlDay();
                day.setDay(i);
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    day.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
                    day.Enabled = false;
                }
                flowLayoutPanelContainer.Controls.Add(day);
            }
        }

        private void labelMonth_Click(object sender, EventArgs e)
        {

        }
        public void ChangeDaysColor()
        {
            foreach (Control control in flowLayoutPanelContainer.Controls)
            {
                if (control is UserControlDay && control.Enabled == true)
                {
                    control.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int calendarId = Calendar.Id;
            var frm = new FormDisplayAppointments(calendarId);
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
