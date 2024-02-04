using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAdministrationModule.Forms.CalendarManagement
{
    public partial class FormSchedule : Form
    {
        public FormSchedule()
        {
            InitializeComponent();
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            var date = new DateTime(FormCalendarCreator.Year, FormCalendarCreator.Month, UserControlDay.day);
            labelDate.Text = date.ToShortDateString();
        }
    }
}
