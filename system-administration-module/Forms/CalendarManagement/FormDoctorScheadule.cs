using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.CalendarManagement
{
    public partial class FormDoctorScheadule : Form
    {
        public static int month;
        public static int year;
        static DateTime weekStartDate = new DateTime(2023, 3, 13);
        private static List<Employee> Doctors = EmployeeService.GetEmployees().Where(e => e.Role.GetName().ToLower() == "doctor").ToList();
        public FormDoctorScheadule()
        {
            InitializeComponent();
        }

        private void FormDoctorScheadule_Load(object sender, EventArgs e)
        {
            foreach (var item in Doctors)
            {
                comboBoxDoctor.Items.Add(item);
            }
            DateTime weekStartDate = new DateTime(2022, 4, 4);

            List<Visit> Visits = VisitService.GetWeeklyVisits(weekStartDate, 3);
            DisplayScheadule(weekStartDate, Visits);

        }
        private void DisplayScheadule(DateTime weekStartDate, List<Visit> visits)
        {

            // Clear the TableLayoutPanel
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();



            // Add the days of the week to the top row of the TableLayoutPanel
            string[] daysOfWeek = new string[] { "Time", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < 7; i++)
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Text = daysOfWeek[i];
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(label, i, 0);
            }
            for (int row = 1; row < 28; row++)
            {
                DateTime time = DateTime.Today.AddHours(7).AddMinutes((row - 1) * 20);
                System.Windows.Forms.Label timeLabel = new System.Windows.Forms.Label();
                timeLabel.Text = time.ToString("HH:mm");
                timeLabel.Dock = DockStyle.Fill;
                timeLabel.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(timeLabel, 0, row);
                if (row % 2 == 0)
                {
                    timeLabel.BackColor = System.Drawing.Color.LightGray;
                }


                for (int col = 1; col < 7; col++)
                {

                    Visit visit = visits.FirstOrDefault(v => v.VisitStartTime.Date == weekStartDate.AddDays(col - 1).Date && v.VisitStartTime.TimeOfDay == time.TimeOfDay);

                    if (visit != null)
                    {
                        System.Windows.Forms.Label visitLabel = new System.Windows.Forms.Label();
                        if (row % 2 == 0)
                        {
                            visitLabel.BackColor = System.Drawing.Color.LightGray;
                        }
                        visitLabel.Text = $"text";
                        visitLabel.Dock = DockStyle.Fill;
                        visitLabel.TextAlign = ContentAlignment.MiddleCenter;
                        visitLabel.BackColor = System.Drawing.Color.GreenYellow;
                        tableLayoutPanel1.Controls.Add(visitLabel, col, row);
                    }
                    else
                    {
                        System.Windows.Forms.Label emptyLabel = new System.Windows.Forms.Label();
                        emptyLabel.Text = "";
                        if (row % 2 == 0)
                        {
                            emptyLabel.BackColor = System.Drawing.Color.LightGray;
                        }
                        emptyLabel.Dock = DockStyle.Fill;
                        emptyLabel.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(emptyLabel, col, row);
                    }
                }

            }
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            int delta = DayOfWeek.Monday - selectedDate.DayOfWeek;
            DateTime monday = selectedDate.AddDays(delta);

            dateTimePicker1.Value = monday;
            int doctorId = ((Employee)comboBoxDoctor.SelectedItem).Id;
            List<Visit> Visits = VisitService.GetWeeklyVisits(weekStartDate, doctorId);
            DisplayScheadule(monday, Visits);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            if (selectedDate.DayOfWeek != DayOfWeek.Monday)
            {
                dateTimePicker1.Value = GetNextMonday(selectedDate);
            }

            int doctorId = ((Employee)comboBoxDoctor.SelectedItem).Id;
            if (doctorId == 0)
            {
                return;
            }
            MessageBox.Show(doctorId.ToString());
            MessageBox.Show(weekStartDate.ToString());
            List<Visit> Visits = VisitService.GetWeeklyVisits(weekStartDate, doctorId);
            DisplayScheadule(dateTimePicker1.Value, Visits);
        }
        private DateTime GetNextMonday(DateTime date)
        {
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)date.DayOfWeek + 7) % 7;
            return date.AddDays(daysUntilMonday);
        }

    }
}
