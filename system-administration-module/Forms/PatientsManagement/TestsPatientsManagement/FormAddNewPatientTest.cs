using NUnit.Framework;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.PatientsManagement.TestsPatientsManagement
{
    [TestFixture]
    public class FormAddNewPatientTests
    {
        [Test]
        public void btnAdd_Click_AddsPatient()
        {
            // Arrange
            var firstName = "John";
            var lastName = "Amski";
            var pesel = "53071244293";

            // Ensure that patient with given PESEL does not exist in DB
            var existingPatient = PatientService.GetPatients().FirstOrDefault(e => e.Pesel == pesel);
            if (existingPatient != null)
            {
                PatientService.DeletePatient(existingPatient);
            }

            // Set input values for patient
            var form = new FormAddNewPatient();
            form.setFirstNameValuePatient(firstName);
            form.textBoxPeselPatient.Text = pesel;
            form.textBoxLastNamePatient.Text = lastName;
            form.textBoxFirstNamePatient.Text = firstName;

            // Act

            form.btnAdd_Click(new Object(), new EventArgs());
            var addedPatient = PatientService.GetPatients().FirstOrDefault(e => e.Pesel == pesel);

            // Assert
            Assert.IsNotNull(addedPatient);
            Assert.AreEqual(form.getFirstNameValuePatient(), addedPatient.FirstName);
            Assert.AreEqual(lastName, addedPatient.LastName);
            Assert.AreEqual(pesel, addedPatient.Pesel);

            // Clean up
            PatientService.DeletePatient(addedPatient);
        }

        [Test]
        public void btnAdd_Click_DoesNotAddPatientWithExistingPesel()
        {
            // Arrange
            var existingPatient = PatientService.GetPatients().FirstOrDefault();
            if (existingPatient == null)
            {
                Assert.Fail("Test requires at least one patient in the database.");
            }

            var firstName = "John";
            var lastName = "Amski";

            // Act
            var form = new FormAddNewPatient();
            form.textBoxPeselPatient.Text = existingPatient.Pesel;
            form.textBoxLastNamePatient.Text = lastName;
            form.textBoxFirstNamePatient.Text = firstName;
            form.btnAdd_Click(new Object(), new EventArgs());
            var addedPatient = PatientService.GetPatientByPesel(existingPatient);

            // Assert
            Assert.AreEqual(addedPatient.Count, 1);
        }
    }
}
