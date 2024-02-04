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
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.CalendarManagement
{
    public partial class FormConfirmDeleteCalendar : Form
    {
        private Calendar Calendar;
        public FormConfirmDeleteCalendar(Calendar calendar)
        {
            InitializeComponent();
            Calendar = calendar;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Calendar.Active == true)
            {
                MessageBox.Show("The choosen calendar is active", "Error removing calendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (FormLoader loader = new FormLoader(() => CalendarService.DeleteCalendar(Calendar)))
                {
                    loader.ShowDialog(this);
                }

                MessageBox.Show("The choosen calendar has been removed", "Success removing calendar", MessageBoxButtons.OK, MessageBoxIcon.Information);


                FormCalendars calendarsForm = Application.OpenForms.OfType<FormCalendars>().FirstOrDefault();
                if (calendarsForm != null)
                {
                    calendarsForm.ReloadData();
                }

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
