using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace SystemAdministrationModule.Forms.CalendarManagement
{
    public partial class FormCalendarDetails : Form
    {
        public static int month;
        public static int year;

        public FormCalendarDetails()
        {
            InitializeComponent();
        }

        private void FormCalendar_Load(object sender, EventArgs e)
        {
            DisplayCalendar();
        }

        private void DisplayCalendar()
        {
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;

            var firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            var days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            var dayOfWeek = Convert.ToInt32(firstDay.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank blank = new UserControlBlank();
                blank.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
                flowLayoutPanelContainer.Controls.Add(blank);
            }

            for (int i = 1; i <= days; i++)
            {
                DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, i);
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
    }
}
