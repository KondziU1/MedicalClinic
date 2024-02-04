using FontAwesome.Sharp;
using SystemAdministrationModule.Forms.SpecializationsManagment;
using SystemAdministrationModule.Forms.UserManagement;
using SystemAdministrationModule.Forms;
using SystemAdministrationModule.Forms.Auth;
using SystemAdministrationModule.Forms.DoctorModule;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule
{
    public partial class FormDoctor : Form
    {

        private IconButton? currentBtn;
        private Form? currentChildForm;
        private Employee employee;
        public static int id;
        int? calendar_id;
        private List<Calendar> calendars = CalendarService.GetCalendars();
        public FormDoctor(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            id = employee.Id;
        }
        private void FormDoctor_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            logedUser.Text = employee.FullName();

            var calendarData = calendars?.FirstOrDefault(c => c.StartDate.Month == DateTime.Now.Month && c.Active);
            calendar_id = calendarData?.Id;

            if (calendar_id != null)
            {
                OpenChildForm(new FormCalendarDetails(DateTime.Today, (int)calendar_id));

            }
            else
            {
                MessageBox.Show("Sorry, there are no available calendars yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActiveButton(object senderBtn)
        {
            DisableButton();
            if (senderBtn == null) return;

            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = Color.FromArgb(108, 117, 125);
            currentBtn.ForeColor = Color.White;
        }

        private void DisableButton()
        {
            if (currentBtn == null) return;

            currentBtn.BackColor = Color.FromArgb(73, 80, 87);
            currentBtn.ForeColor = Color.White;
        }

        public void OpenChildForm(Form childForm)
        {
            currentChildForm?.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            //ActiveButton(sender);
            //OpenChildForm(new Form1());
            ActiveButton(sender);
            if (calendar_id != null)
                OpenChildForm(new FormCalendarDetails(DateTime.Today, (int)calendar_id));

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var frm = new FormConfirmLogout();
            frm.Owner = this;
            frm.Show();
            //Application.Restart();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FormCalendar());
        }

        private void btnFutureCalendar_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FormFutureCalendar());
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FormPatients());
        }
    }
}