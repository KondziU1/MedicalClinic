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
using SystemAdministrationModule.Helpers;
using System.Data.SqlClient;
using SystemAdministrationModule.Services;
using SystemAdministrationModule.Models;
using Calendar = SystemAdministrationModule.Models.Calendar;

namespace SystemAdministrationModule.Forms.DoctorModule
{
    public partial class FormCalendar : Form
    {
        protected int month, year;
        protected int doctorId = FormDoctor.id;
        protected int? calendarId;
        protected List<Calendar> calendars = CalendarService.GetCalendars();
        protected List<Appointment> appointments = new();
        public FormCalendar()
        {
            InitializeComponent();
        }

        protected void FormCalendar_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadTime();
                LoadCalendar();
            }
        }
        protected virtual void LoadTime()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
        }
        protected virtual void LoadCalendar()
        {
            var calendarData = calendars?.FirstOrDefault(c => c.StartDate.Month == month && c.Active);
            calendarId = calendarData?.Id;

            if (calendarId != null)
            {
                display();
            }
            else
            {
                MessageBox.Show("Sorry, there are no available calendars yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        protected virtual async Task display()
        {

            appointments = AppointmentService.GetAppointmentsByCalendar2((int)calendarId);
            DayContainer.Controls.Clear();
            string monthname = new DateTime(year, month, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US"));
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl_blank ucb = new UserControl_blank();
                DayContainer.Controls.Add(ucb);
            }

            for (int i = 1; i <= days; i++)
            {

                DateTime date = new DateTime(year, month, i);
                UserControlDays ucd = new UserControlDays(date,(int)calendarId);
                ucd.days(i);

                DayContainer.Controls.Add(ucd);
                var appointmentDates = appointments.Where(a => a.Visit.VisitStartTime.Date == date.Date && (!a.IsAccepted || a.IsAccepted) && a.DoctorId == doctorId);

                if (!appointmentDates.Any(d => d.Visit.VisitStartTime.Date == date.Date))
                {
                    ucd.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
                    ucd.Enabled = date.DayOfWeek == DayOfWeek.Sunday ? false : true;
                }
            }

            await Task.Delay(10);
            DayContainer.Visible = true;
        }

    }
}
