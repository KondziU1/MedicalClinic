using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Forms;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.SpecializationsManagment
{
    public partial class FormAddNewSpecialization : Form
    {
        private bool isFormDirty = false;

        public FormAddNewSpecialization()
        {
            InitializeComponent();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var specialization = new Specialization(0, textBoxSpecializationName.Text);

            var isSpecializationExistInDB = SpecializationService.GetSpecializations().FirstOrDefault(e => e.Name == textBoxSpecializationName.Text);

            if (isSpecializationExistInDB != null)
            {
                MessageBox.Show("This specialization is already in use", "Error adding specialization", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SpecializationService.CreateSpecialization(specialization);

            MessageBox.Show("Specialization added", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormSpecializations specializationsForm = Application.OpenForms.OfType<FormSpecializations>().FirstOrDefault();
            if (specializationsForm != null)
            {
                specializationsForm.ReloadData();
            }

            this.Close();

        }

        private void textBoxSpecializationName_TextChanged(object sender, EventArgs e)
        {
            isFormDirty = true;
        }
    }
}