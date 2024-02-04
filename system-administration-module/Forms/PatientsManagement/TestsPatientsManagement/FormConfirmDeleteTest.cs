using NUnit.Framework;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.PatientsManagement.TestsPatientsManagement

{
    [TestFixture]
    public class FormConfirmDeleteTests
    {
        private Patient testPatient;

        [Test]
        public void btnCancel_Click_ClosesForm()
        {
            var PatientId = int.Parse(PatientService.GetLastPatientID()) + 1;
            var FirstNameValuePatient = "John";
            var LastNameValuePatient = "Amski";
            var PeselValuePatient = "53071244293";
            bool IsActive = false;

            testPatient = new Patient(PatientId, FirstNameValuePatient, LastNameValuePatient, PeselValuePatient, IsActive);
            var result = PatientService.GetPatientByPesel(testPatient);

            if (result == null)
            {
                PatientService.CreatePatient(testPatient);
                testPatient.Id = int.Parse(PatientService.GetLastPatientID());
                
            }
            // Arrange
            var form = new FormConfirmDelete(testPatient);

            // Act
            form.btnCancel_Click(null, null);

            // Assert
            Assert.IsTrue(form.IsDisposed);
        }

        [Test]
        public void btnConfirm_Click_DeletesPatient()
        {
            // Arrange
            var form = new FormConfirmDelete(testPatient);

            // Act
            form.btnConfirm_Click(null, null);
            PatientService.DeletePatient(testPatient);
   

            // Assert
            Assert.IsNull(PatientService.GetPatientByPesel(testPatient));
            Assert.IsTrue(form.IsDisposed);
        }
      
    }
}
