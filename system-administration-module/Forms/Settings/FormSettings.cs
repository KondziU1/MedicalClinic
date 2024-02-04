using System.Configuration;
using System.Xml;

namespace SystemAdministrationModule.Forms.Settings
{
    public partial class FormSettings : Form
    {

        public FormSettings()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string timeBlockingInactive = textBoxInactive.Text;
            string timeBlockingValue = textBoxTimeBlocking.Text;
            int timeBlockingValueInt;
            bool isInt = int.TryParse(timeBlockingValue, out timeBlockingValueInt);
            if (!isInt)
            {
                MessageBox.Show("timeBlockValue is not int");
                return;
            }
            int timeBlockingInactiveInt;
            isInt = int.TryParse(timeBlockingInactive, out timeBlockingInactiveInt);
            if (!isInt)
            {
                MessageBox.Show("timeBlockValue is not int");
                return;
            }
            EditSettings(timeBlockingInactiveInt, timeBlockingValueInt);
        }




        private void FormSettings_Load(object sender, EventArgs e)
        {
            textBoxInactive.Text = SystemAdministrationModule.Settings.Default["timeBlockingInactive"].ToString();
            textBoxTimeBlocking.Text = SystemAdministrationModule.Settings.Default["timeBlockingLogin"].ToString();
        }

        public static void EditSettings(int timeBlockingInactiveValue, int timeBlockingLoginValue)
        {
            SystemAdministrationModule.Settings.Default.timeBlockingInactive = timeBlockingInactiveValue;
            SystemAdministrationModule.Settings.Default.timeBlockingLogin = timeBlockingLoginValue;
            SystemAdministrationModule.Settings.Default.Save();
        }

        private void textBoxSettingValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
