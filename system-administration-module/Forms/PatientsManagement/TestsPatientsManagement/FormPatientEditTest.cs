using NUnit.Framework;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.PatientsManagement.TestsPatientsManagement
{
    //[TestFixture]
    //public class FormPatientEditTests
    //{
    //    [Test]
    //    public void btnConfirmPatient_Click_UpdatesPatient()
    //    {
    //        // Arrange
    //        var existingPatient = PatientService.GetPatients().FirstOrDefault();
    //        if (existingPatient == null)
    //        {
    //            Assert.Fail("Test requires at least one patient in the database.");
    //        }

    //        var updatedFirstName = "UpdatedFirstName";
    //        var updatedLastName = "UpdatedLastName";
    //        var updatedPesel = "1234567890";

    //        // Set input values for patient
    //        var form = new FormPatientEdit(existingPatient, true);
    //        form.textBoxFirstNamePatient.Text = updatedFirstName;
    //        form.textBoxLastNamePatient.Text = updatedLastName;
    //        form.textBoxPeselPatient.Text = updatedPesel;
    //        form.comboBoxActiveStatusPatient.SelectedIndex = 0; // Assuming "true" is the first item in the combo box

    //        // Act
    //        form.btnConfirmPatient_Click(new Object(), new EventArgs());
    //        Patient updatedPatient = PatientService.GetPatientById(existingPatient);

    //        // Assert
    //        Assert.IsNotNull(updatedPatient);
    //        Assert.AreEqual(updatedFirstName, updatedPatient.);
    //        Assert.AreEqual(updatedLastName, updatedPatient.LastName);
    //        Assert.AreEqual(updatedPesel, updatedPatient.Pesel);
    //    }
    //}
}
