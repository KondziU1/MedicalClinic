using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Services;
using SystemAdministrationModule.Forms;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.OfficesManagement
{
    public partial class FormAddNewOffice : Form
    {
        private List<string> types = new List<string>() { "general", "specialized" };

        private bool isFormDirty = false;

        public FormAddNewOffice()
        {
            InitializeComponent();
        }
        private void FormAddNewOffice_Load(object sender, EventArgs e)
        {
            var specializations = SpecializationService.GetSpecializations();

            foreach (var item in specializations)
            {
                comboBoxSpecialization.Items.Add(item);
            }

            foreach (var item in types)
            {
                comboBoxType.Items.Add(item);
            }

            SetActiveBtn();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var isNumberExistInDB = OfficeService.GetOffices().FirstOrDefault(e => e.Number.ToLower() == textBoxNumber.Text.ToLower());

            if (isNumberExistInDB != null)
            {
                MessageBox.Show("This number is already in use", "Error adding office", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var office = new Office(0, textBoxNumber.Text, (Specialization)comboBoxSpecialization.SelectedItem, comboBoxType.SelectedItem.ToString(), true);

            OfficeService.CreateOffice(office);

            MessageBox.Show("Office added", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormOffices? officeesForm = Application.OpenForms.OfType<FormOffices>().FirstOrDefault();
            if (officeesForm != null)
            {
                officeesForm.ReloadData();
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isFormDirty)
            {
                var result = MessageBox.Show("Are you sure you want to exit the form without saving changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            this.Close();
        }


        private void comboBoxSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
            SetActiveBtn();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
            SetActiveBtn();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
            SetActiveBtn();
        }
        private void SetActiveBtn()
        {
            if (textBoxNumber.Text.Length > 0 && comboBoxSpecialization.SelectedIndex > -1 && comboBoxType.SelectedIndex > -1)
            {
                btnAdd.Enabled = true;
                btnAdd.IconColor = Color.White;
            }
            else
            {
                btnAdd.Enabled = false;
                btnAdd.IconColor = Color.Black;
            }
        }
    }
}
