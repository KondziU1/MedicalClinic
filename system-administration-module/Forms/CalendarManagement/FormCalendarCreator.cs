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
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using Calendar = SystemAdministrationModule.Models.Calendar;
using Control = System.Windows.Forms.Control;

namespace SystemAdministrationModule.Forms.CalendarManagement
{
    public partial class FormCalendarCreator : Form
    {
        public static int Month;
        public static int Year;
        private static List<Employee> Doctors = EmployeeService.GetEmployees().Where(e => e.Role.GetName().ToLower() == "doctor").ToList();
        private static List<Office> Offices = OfficeService.GetActiveOffices();

        public static List<Visit> Visits = new List<Visit>();
        public static List<Visit> VisitsForDoctorAndDay = new List<Visit>();

        public static int doctorId;
        public static int officeId;

        private Calendar Calendar;

        public FormCalendarCreator()
        {
            InitializeComponent();
            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;
        }

        public FormCalendarCreator(int year, int month)
        {
            InitializeComponent();
            btnEdit.Visible = false;
            Month = month;
            Year = year;
        }

        public FormCalendarCreator(int year, int month, Calendar calendar, bool openDetailsMode)
        {
            InitializeComponent();
            Calendar = calendar;
            dataGridViewVisits.ReadOnly = true;
            Month = month;
            Year = year;
        }

        private void FormCalendar_Load(object sender, EventArgs e)
        {
            Offices = OfficeService.GetActiveOffices();

            foreach (var item in Doctors)
            {
                comboBoxDoctor.Items.Add(item);
            }

            foreach (var item in Offices)
            {
                comboBoxOffice.Items.Add(item);
            }

            DisplayCalendar();
            ReloadData();

            comboBoxDoctor.SelectedIndex = 0;
            comboBoxOffice.SelectedIndex = 0;

            officeId = ((Office)comboBoxOffice.SelectedItem).Id;
            doctorId = ((Employee)comboBoxDoctor.SelectedItem).Id;

            string monthName = new DateTime(1, Month, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US"));
            labelMonth.Text = monthName;

            if(Calendar?.Status.ToLower() == "accepted" && Calendar?.Active == false)
            {
                btnActive.Visible = true;
            }
        }

        private void DisplayCalendar()
        {
            DateTime firstDay = new DateTime(Year, Month, 1);

            int days = DateTime.DaysInMonth(Year, Month);

            int dayOfWeek = Convert.ToInt32(firstDay.DayOfWeek.ToString("d"));

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

        private void refreshDataToDataGridView(List<Visit> data)
        {
            dataGridViewVisits.Rows.Clear();
            foreach (var item in data)
            {
                dataGridViewVisits.Rows.Add(
                    item.Id,
                    item.VisitStartTime,
                    item.DoctorId != null ? "booked" : "free",
                    item.DoctorId != null ? true : false
                );
            }
        }


        public void ReloadData()
        {
            if (UserControlDay.day < 1)
            {
                btnSave.Enabled = false;
                return;
            }

            btnSave.Enabled = true;

            Offices = OfficeService.GetActiveOffices();
            Visits = VisitService.GetFreeVistsDoctorForDayAndOffice(new DateTime(Year, Month, UserControlDay.day), doctorId, officeId);
            VisitsForDoctorAndDay = VisitService.GetVistsForDayAndDoctor(new DateTime(Year, Month, UserControlDay.day), doctorId);
            Visits.RemoveAll(v => VisitsForDoctorAndDay.Any(vd => vd.VisitStartTime == v.VisitStartTime && vd.OfficeId != officeId));
            refreshDataToDataGridView(Visits);
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

        private void comboBoxOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            officeId = ((Office)(comboBoxOffice.SelectedItem)).Id;
            ReloadData();
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            doctorId = ((Employee)comboBoxDoctor.SelectedItem).Id;
            ReloadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Visit> selectedVisits = new List<Visit>();

            foreach (DataGridViewRow row in dataGridViewVisits.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells["selected"] as DataGridViewCheckBoxCell;

                if (checkBox.Value != null)
                {
                    int id = (int)row.Cells["id"].Value;
                    Visit visit = Visits.FirstOrDefault(x => x.Id == id);
                    Visits.Remove(visit);
                    if ((bool)checkBox.Value)
                    {
                        visit.DoctorId = doctorId;
                    }
                    else
                    {
                        visit.DoctorId = null;
                    }

                    Visits.Add(visit);
                }
            }

            AppointmentService.CreateAppointmentsFromVisits(Visits);
            ReloadData();
        }

        private void FormCalendarCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserControlDay.day = 0;

            FormCalendars calendarForm = Application.OpenForms.OfType<FormCalendars>().FirstOrDefault();
            if (calendarForm != null)
            {
                calendarForm.ReloadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Calendar.Active == true)
            {
                MessageBox.Show("The choosen calendar is active", "Error editing calendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewVisits.ReadOnly = false;
            btnEdit.Visible = false;
            btnActive.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewVisits.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["selected"];
                chk.Value = true;
            }
            buttonSelect.Visible = false;
            buttonUnSelect.Visible = true;
        }

        private void buttonUnSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewVisits.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["selected"];
                chk.Value = false;
            }
            buttonSelect.Visible = true;
            buttonUnSelect.Visible = false;
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to activate the calendar? \nAfter that you will not be able to deactivate it", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            Calendar.Active = true;
            CalendarService.UpdateCalendar(Calendar);

            this.Close();
        }
    }
}
