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

namespace SystemAdministrationModule.Forms.DoctorModule
{
    public partial class FormFutureCalendar : FormCalendar
    {
        bool isCalendarAccepted = false;
        public FormFutureCalendar()
        {
            InitializeComponent();
        }
        protected override void LoadTime()
        {
            base.LoadTime();
            base.month += 1;
        }
        protected override void LoadCalendar()
        {
            var calendarData = calendars?.FirstOrDefault(c => c.StartDate.Month == month);
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

        protected override async Task display()
        {
            await base.display();

            var doctorAppointments = appointments.Where(a => a.DoctorId == doctorId);
            isCalendarAccepted = doctorAppointments.Any() && doctorAppointments.All(ca => ca.IsAccepted);

            if (doctorAppointments.Any())
            {
                btnAccept.Visible = !isCalendarAccepted;
            }

            foreach (Control control in DayContainer.Controls)
            {
                if (isCalendarAccepted && control is UserControlDays)
                    control.BackColor = System.Drawing.Color.FromArgb(150, 200, 150);

            }

            UserControlDays.IsCalendarAccepted = isCalendarAccepted;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to accept the calendar?", "Accept calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var calendar = calendars.FirstOrDefault(c => c.Id == calendarId);
                var appointments = AppointmentService.GetAppointmentsByCalendar2(calendar.Id).Where(a => a.DoctorId == doctorId).ToList();
                CalendarService.ConfirmCalendar(appointments, calendar);
                display();
            }
        }
    }
}
