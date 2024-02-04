using FontAwesome.Sharp;
using SystemAdministrationModule.Forms.Auth;
using SystemAdministrationModule.Forms.Settings;
using SystemAdministrationModule.Forms.OfficesManagement;
using SystemAdministrationModule.Forms.SpecializationsManagment;
using SystemAdministrationModule.Forms.UserManagement;
using SystemAdministrationModule.Forms;
using SystemAdministrationModule.Forms.Auth;
using SystemAdministrationModule.Forms.CalendarManagement;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule
{
    public partial class FormAdmin : Form
    {

        private IconButton? currentBtn;
        private Form? currentChildForm;
        private Employee employee;

        public FormAdmin(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            logedUser.Text = employee.FullName();
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
            var frm = new FormConfirmLogout();
            frm.Owner = this;
            frm.Show();

            //this.Hide();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSpecializations_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FormSpecializations());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FormUsers());
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FormSettings());
        }

        private void btnOffices_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FormOffices());
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FormCalendars());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}