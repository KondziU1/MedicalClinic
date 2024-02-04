using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Controls;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using System.Collections.Generic;


namespace SystemAdministrationModule.TestsServices
{
    [TestFixture]
    public class PatientServiceTests
    {
        private DataTable _testPatientsDataTable;
        private List<Patient> _testPatients;

        [SetUp]
        public void Setup()
        {
            _testPatientsDataTable = new DataTable();
            _testPatientsDataTable.Columns.Add("Id", typeof(int));
            _testPatientsDataTable.Columns.Add("first_name", typeof(string));
            _testPatientsDataTable.Columns.Add("last_name", typeof(string));
            _testPatientsDataTable.Columns.Add("pesel", typeof(string));
            _testPatientsDataTable.Columns.Add("is_active", typeof(bool));
            _testPatients = new List<Patient>
            {
                new Patient(1, "John", "Doe", "123456789", true),
                new Patient(2, "Jane", "Smith", "987654321", true)
            };

        }
        
        [Test]
        public void GetPatients_ReturnsListOfPatients()
        {
            var expectedPatients = new List<Patient>
            {
                new Patient(1, "Jane", "Doe", "79012561559", true),
                new Patient(2, "Jane", "Smith", "68030432484", true)
            };

            var oldPatients = new List<Patient>
            {
            PatientService.GetPatientByPesel(expectedPatients[0]).FirstOrDefault(),
            PatientService.GetPatientByPesel(expectedPatients[1]).FirstOrDefault()
            };

            if (oldPatients[0] != null)
                PatientService.DeletePatient(oldPatients[0]);

            if (oldPatients[1] != null)
                PatientService.DeletePatient(oldPatients[1]);

            var initialPatients = PatientService.GetPatients();

            PatientService.CreatePatient(expectedPatients[0]);
            PatientService.CreatePatient(expectedPatients[1]);

            var updatedPatients = PatientService.GetPatients();

            Assert.AreEqual(initialPatients.Count + 2, updatedPatients.Count);

            for (int i = 0; i < 2; i++)
            {
                var expectedPatient = expectedPatients[i];
                var actualPatient = updatedPatients[updatedPatients.Count - 2 + i];

                Assert.AreEqual(expectedPatient.FirstName, actualPatient.FirstName);
                Assert.AreEqual(expectedPatient.LastName, actualPatient.LastName);
                Assert.AreEqual(expectedPatient.Pesel, actualPatient.Pesel);
                Assert.AreEqual(expectedPatient.Active, actualPatient.Active);
            }

            PatientService.DeletePatient(expectedPatients[0]);
            PatientService.DeletePatient(expectedPatients[1]);
        }


        [Test]
        public void GetPatientById_ExistingPatient_ReturnsPatient()
        {

            Patient existingPatient = new Patient(1, "John", "Doe", "92042764619", true);
            Patient oldPatient;
            if (PatientService.GetPatientByPesel(existingPatient) != null)
            {
                oldPatient = PatientService.GetPatientByPesel(existingPatient).FirstOrDefault();
                PatientService.DeletePatient(oldPatient);
            }
            PatientService.CreatePatient(existingPatient);

            int id = int.Parse(PatientService.GetLastPatientID());
            existingPatient = new Patient(id, "John", "Doe", "92042764619", true);

            
            var actualPatient = PatientService.GetPatientById(existingPatient);

            Assert.AreEqual(existingPatient.Id, actualPatient.Id);
            Assert.AreEqual(existingPatient.FirstName, actualPatient.FirstName);
            Assert.AreEqual(existingPatient.LastName, actualPatient.LastName);
            Assert.AreEqual(existingPatient.Pesel, actualPatient.Pesel);
            Assert.AreEqual(existingPatient.Active, actualPatient.Active);

            PatientService.DeletePatient(existingPatient);
        }

        [Test]
        public void GetPatientById_NonExistingPatient_ReturnsNull()
        {
            var nonExistingPatient = new Patient(999, "Non", "Existing", "99999999999", true);

            var actualPatient = PatientService.GetPatientById(nonExistingPatient);

            Assert.IsNull(actualPatient);
        }

        [Test]
        public void GetPatientByPesel_NonExistingPatient_ReturnsNull()
        {
            var nonExistingPatient = new Patient(999, "Non", "Existing", "99999999999", true);

            var actualPatients = PatientService.GetPatientByPesel(nonExistingPatient);

            Assert.IsNull(actualPatients);
        }

        [Test]
        public void GetSpecializations_ReturnsListOfSpecializations()
        {
            var expectedSpecializations = new List<Specialization>
            {
                new Specialization(1, "TestSpecialization1"),
                new Specialization(2, "TestSpecialization2"),
                new Specialization(3, "TestSpecialization3")
            };

            var initialSpecializations = PatientService.GetSpecializations();

            SpecializationService.CreateSpecialization(expectedSpecializations[0]);
            SpecializationService.CreateSpecialization(expectedSpecializations[1]);
            SpecializationService.CreateSpecialization(expectedSpecializations[2]);

            var updatedSpecializations = PatientService.GetSpecializations();

            Assert.AreEqual(initialSpecializations.Count + 3, updatedSpecializations.Count);

            for (int i = 0; i < 3; i++)
            {
                var expectedSpecialization = expectedSpecializations[i];
                var actualSpecialization = updatedSpecializations[updatedSpecializations.Count - 3 + i];

                Assert.AreEqual(expectedSpecialization.Name, actualSpecialization.Name);
            }

            SpecializationService.DeleteSpecialization(updatedSpecializations[updatedSpecializations.Count - 3]);
            SpecializationService.DeleteSpecialization(updatedSpecializations[updatedSpecializations.Count - 2]);
            SpecializationService.DeleteSpecialization(updatedSpecializations[updatedSpecializations.Count - 1]);

        }

    }
}
