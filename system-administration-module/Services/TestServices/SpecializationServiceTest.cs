 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;
using NUnit.Framework;
/*


namespace SystemAdministrationModule.Services.TestServices
{
    [TestFixture]
    public class SpecializationServiceTests
    {
        [Test]
        public void GetSpecializations_ReturnsListOfSpecializations()
        {
            // Act
            List<Specialization> specializations = SpecializationService.GetSpecializations();

            // Assert
            Assert.IsTrue(specializations.Count > 0);
        }
        [Test]
        public void GetSpecializationsHaveUsers_ReturnsListOfSpecializations()
        {
            // Act
            List<Specialization> specializations = SpecializationService.GetSpecializationsHaveUsers();

            // Assert
            Assert.IsTrue(specializations.Count > 0);
        }

        [Test]
        public void UpdateSpecialization_UpdatesSpecializationName()
        {
            // Arrange
            Specialization specialization = new Specialization (15,  "Urology");
            string newName = "Urology2";

            // Act
            specialization.Name = newName;
            SpecializationService.UpdateSpecialization(specialization);
            Specialization updatedSpecialization = SpecializationService.GetSpecializations().FirstOrDefault(s => s.Id == specialization.Id);

            // Assert
            Assert.IsNotNull(updatedSpecialization);
            Assert.AreEqual(newName, updatedSpecialization.Name);
        }
        [Test]
        public void CreateSpecialization_CreatesNewSpecialization()
        {
            // Arrange
            string specializaitonName = "New Specialization";

            // Act
            SpecializationService.CreateSpecialization(new Specialization(22,name: specializaitonName)) ;
            Specialization createdSpecialization = SpecializationService.GetSpecializations().FirstOrDefault(s => s.Name == specializaitonName);

            // Assert
            Assert.IsNotNull(createdSpecialization);
            Assert.AreEqual(specializaitonName, createdSpecialization.Name);
        }
        [Test]
        public void DeleteSpecialization_DeletesExistingSpecialization()
        {
            // Arrange
            Specialization specializationToDelete = new Specialization (16, "UrologyV3");

            // Act
            SpecializationService.DeleteSpecialization(specializationToDelete);
            Specialization deletedSpecialization = SpecializationService.GetSpecializations().FirstOrDefault(s => s.Id == specializationToDelete.Id);

            // Assert
            Assert.IsNull(deletedSpecialization);
        }
    }
}
*/