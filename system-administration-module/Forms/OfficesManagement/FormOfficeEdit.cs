using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.OfficesManagement
{
    public partial class FormOfficeEdit : Form
    {
        static List<bool> Statuses = new List<bool>() { true, false };
        private Office Office;

        public FormOfficeEdit(Office office)
        {
            InitializeComponent();
            Office = office;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Office.Number = textBoxNumber.Text;
            Office.Active = (bool)comboBoxActiveStatus.SelectedItem;
            Office.Specialization = (Specialization)comboBoxSpecialization.SelectedItem;
            Office.Type = checkBoxIsGeneral.Checked ? "general" : "specialized";

            OfficeService.UpdateOffice(Office);

            if (string.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("You have to fill the number of office", "Error operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The office has been edited", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormOffices officesForm = Application.OpenForms.OfType<FormOffices>().FirstOrDefault();
            if (officesForm != null)
            {
                officesForm.ReloadData();
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOfficeEdit_Load(object sender, EventArgs e)
        {
            var specializations = SpecializationService.GetSpecializations();

            foreach (var item in specializations)
            {
                comboBoxSpecialization.Items.Add(item);
            }

            foreach (var item in Statuses)
            {
                comboBoxActiveStatus.Items.Add(item);
            }

            textBoxNumber.Text = Office.Number;
            comboBoxSpecialization.SelectedIndex = (int)Office.Specialization.Id - 1;
            comboBoxActiveStatus.SelectedIndex = Office.Active ? 0 : 1;
        }
    }
}
