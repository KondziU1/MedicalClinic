using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SystemAdministrationModule.Helpers;

namespace SystemAdministrationModule.Forms.DoctorModule
{
    public partial class UserControlDays : UserControl
    {
        DateTime date;
        DateTime Today = DateTime.Now;
        public static bool IsCalendarAccepted;
        int calendarId;
        internal UserControlDays(DateTime date, int calendarId)
        {
            this.calendarId = calendarId;
            this.date = date;
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbDays.Text = numday + " ";
        }

        private void UserControlDays_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (date.Month == Today.Month)
            {
                this.Enabled = true;
                var frm = Application.OpenForms.OfType<FormDoctor>().FirstOrDefault();
                var lekarzdatagrid = new FormCalendarDetails(date, calendarId);
                frm.OpenChildForm(lekarzdatagrid);


            }
            else
            {
                var frm = Application.OpenForms.OfType<FormDoctor>().FirstOrDefault();
                var lekarzdatagrid = new FormFutureCalendarDetails(date, IsCalendarAccepted, calendarId);
                frm.OpenChildForm(lekarzdatagrid);

            }
        }
    }
}
