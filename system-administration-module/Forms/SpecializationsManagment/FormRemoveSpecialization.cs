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
    public partial class FormRemoveSpecialization : Form
    {
        private readonly Specialization Specialization;
        public FormRemoveSpecialization(Specialization specialization)
        {
            InitializeComponent();
            Specialization = specialization;
        }

        public FormRemoveSpecialization(Specialization specialization, bool openEditMode)
        {
            InitializeComponent();

            Specialization = specialization;


        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRemoveSpecialization_Load(object sender, EventArgs e)
        {
            textBoxSpecializationName.Text = Specialization.Name;

        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSpecializationName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var specializationsHaveUsers = SpecializationService.GetSpecializationsHaveUsers();

            Specialization.Name = textBoxSpecializationName.Text;

            if (specializationsHaveUsers.Any(s => s.Name.ToLower() == textBoxSpecializationName.Text.ToLower()))
            {
                MessageBox.Show("Specialization is assigned to doctor", "Failed operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SpecializationService.DeleteSpecialization(Specialization);

            MessageBox.Show("Specialization removed", "Success operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormSpecializations specializationsForm = Application.OpenForms.OfType<FormSpecializations>().FirstOrDefault();
            if (specializationsForm != null)
            {
                specializationsForm.ReloadData();
            }

            this.Close();
        }
    }
}