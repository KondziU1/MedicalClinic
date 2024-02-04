using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using Timer = System.Windows.Forms.Timer;

namespace SystemAdministrationModule.Forms.Auth
{

    public partial class FormLogin : Form
    {

        private int clickCount = 0;
        private Timer timer;
        private Timer timerInactive;
        private static int minutesToBlock = SystemAdministrationModule.Settings.Default.timeBlockingInactive;
        private static int timeLeft = minutesToBlock * 60;
        private DateTime blockUntil = DateTime.MinValue;
        public static Employee employeeLogged = Employee.CreateEmpty();
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            IsActiveButton();


            timerInactive = new Timer
            {
                Interval = 1000 // 1 second
            };
            timerInactive.Tick += new EventHandler(TimerInactive_Tick);
            timerInactive.Start();
        }


        private static bool Login(string login, string password)
        {


            List<Employee> employees = EmployeeService.Login(login, password);
            if (employees.Count != 1)
            {
                return false;
            }

            employeeLogged = employees.First();
            if (employeeLogged.Role.Name == "admin")
            {
                var frm = new FormAdmin(employeeLogged);
                frm.Show();

            }
            else if (employeeLogged.Role.Name == "doctor")
            {
                var frmDoctor = new FormDoctor(employeeLogged);
                frmDoctor.Show();
            }
            else if (employeeLogged.Role.Name == "staff")
            {
                var frmStaff = new FormStaff();
                frmStaff.Show();
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.loginAction();
        }
        private void loginAction()
        {
            string login = textBoxLogin.Text ?? "";
            string password = textBoxPassword.Text ?? "";
            if (blockUntil > DateTime.Now)
            {
                return;
            }
            clickCount++;
            if (Login(login, password))
            {
                clickCount = 0;
                this.timerInactive.Stop();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The data entered was incorrect");
            }

            if (clickCount >= 3)
            {
                var minutes = SystemAdministrationModule.Settings.Default.timeBlockingLogin;
                blockUntil = DateTime.Now.AddMinutes(minutes);
                clickCount = 0;
                btnLogin.Enabled = false;

                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += (s, e) =>
                {
                    UpdateLabel();
                    if (DateTime.Now >= blockUntil)
                    {
                        timer.Stop();
                        btnLogin.Enabled = true;
                        blockedLoginLabel.Text = "";
                        clickCount = 0;
                    }
                };
                timer.Start();

                TimeSpan remaining = blockUntil - DateTime.Now;
                MessageBox.Show($"Button \"OK\" will be unblocked in {minutes} minutes");
            }
        }
        private void UpdateLabel()
        {
            TimeSpan remaining = blockUntil - DateTime.Now;
            blockedLoginLabel.Text = $"Button will be unblocked in {remaining.ToString(@"mm\:ss")}";
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void IsActiveButton()
        {

            if ((textBoxLogin.Text.Length > 0) && (textBoxPassword.Text.Length > 0))
            {
                btnLogin.Enabled = true;
                btnLogin.IconColor = Color.White;
            }
            else
            {
                btnLogin.Enabled = false;
                btnLogin.IconColor = Color.Black;
            }
        }

        private void textBoxPassword_TextChanged_1(object sender, EventArgs e)
        {
            IsActiveButton();
            ResetTimer();
        }

        private void textBoxLogin_TextChanged_1(object sender, EventArgs e)
        {
            IsActiveButton();
            ResetTimer();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxLogin.Text = "admin";
            textBoxPassword.Text = "admin";

            if (textBoxPassword.Text.Length > 0)
                textBoxPassword.Select();

        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.loginAction();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void blockedLoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new FormForgotPassword();
            frm.Show();
        }
        private void TimerInactive_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
            }
            else
            {
                timerInactive.Stop();
                Close();
            }
        }
        private void ResetTimer()
        {
            timeLeft = minutesToBlock * 60; // 5 minutes in seconds
            timerInactive.Start();
        }
    }
}
