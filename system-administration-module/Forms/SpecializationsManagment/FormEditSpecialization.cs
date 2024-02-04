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
    
    public partial class FormEditSpecialization : Form
    {
        private bool isFormDirty = false;
        private string specializationOnLoad;

        private readonly Specialization Specialization;
        public FormEditSpecialization(Specialization specialization)
        {
            InitializeComponent();
            Specialization = specialization;
        }

        public FormEditSpecialization(Specialization specialization, bool openEditMode)
        {
            InitializeComponent();

            Specialization = specialization;

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

        private void FormEditSpecialization_Load(object sender, EventArgs e)
        {
            textBoxSpecializationName.Text = Specialization.Name;

            isFormDirty = false;

            specializationOnLoad = Specialization.Name;
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Specialization.Name = textBoxSpecializationName.Text;

            var isSpecializationExistInDB = SpecializationService.GetSpecializations().FirstOrDefault(e => e.Name == textBoxSpecializationName.Text);


            if (specializationOnLoad == textBoxSpecializationName.Text)
            {
                SpecializationService.UpdateSpecialization(Specialization);
            }
            else if (isSpecializationExistInDB != null)
            {
                MessageBox.Show("This specialization is already in use", "Error adding specialization", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SpecializationService.UpdateSpecialization(Specialization);

            MessageBox.Show("Specialization updated", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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