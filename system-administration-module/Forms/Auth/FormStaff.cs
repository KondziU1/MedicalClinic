using FontAwesome.Sharp;
using SystemAdministrationModule.Forms.SpecializationsManagment;
using SystemAdministrationModule.Forms.UserManagement;
using SystemAdministrationModule.Forms;
using SystemAdministrationModule.Forms.Auth;
using SystemAdministrationModule.Forms.CalendarManagement;
using SystemAdministrationModule.Forms.PatientsManagement;
using SystemAdministrationModule.Forms.AppointmentsManagement;

namespace SystemAdministrationModule
{
    public partial class FormStaff : Form
    {

        private IconButton? currentBtn;
        private Form? currentChildForm;

        public FormStaff()
        {
            InitializeComponent();
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

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

        private void OpenChildForm(Form childForm)
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
        //private void BtnHome_Click(object sender, EventArgs e)
        //{
        //    ActiveButton(sender);
        //    OpenChildForm(new FormHome());

        //}

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FormEmployees());

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var frm = new FormLogin();
            frm.Show();

            this.Hide();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FormAppointmentsCalendars());
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FormPatient());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}