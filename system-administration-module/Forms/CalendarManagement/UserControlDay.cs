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

namespace SystemAdministrationModule.Forms.CalendarManagement
{
    public partial class UserControlDay : UserControl
    {
        public static int day;
        public UserControlDay()
        {
            InitializeComponent();
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {

        }
        public void setDay(int day)
        {
            labelNumber.Text = day.ToString();
        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {
            day = Convert.ToInt32(labelNumber.Text);

            //FormCalendarCreator.Visits = VisitService.GetFreeVistsDoctorForDayAndOffice(new DateTime(FormCalendarCreator.Year, FormCalendarCreator.Month, day), FormCalendarCreator.doctorId, FormCalendarCreator.officeId);

            FormCalendarCreator calendarForm = Application.OpenForms.OfType<FormCalendarCreator>().FirstOrDefault();
            if (calendarForm != null)
            {
                calendarForm.ReloadData();
                calendarForm.ChangeDaysColor();
            }

            this.BackColor = Color.FromArgb(173, 181, 189);
        }
    }
}
