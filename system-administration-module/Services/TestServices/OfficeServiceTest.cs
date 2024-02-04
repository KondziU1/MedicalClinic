using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;
/*
namespace SystemAdministrationModule.Services.TestServices
{
    [TestFixture]
    public class OfficeServiceTest
    {
        [Test]
        public void GetOffices_ReturnsAllOffices()
        {
            // Arrange

            // Act
            var result = OfficeService.GetOffices();

            // Assert
            Assert.IsTrue(result.Count > 0);
        }
        [Test]
        public void GetActiveOffices_ReturnsOnlyActiveOffices()
        {
            // Arrange

            // Act
            var result = OfficeService.GetActiveOffices();

            // Assert
            Assert.IsTrue(result.All(x => x.Active));
        }
        [Test]
        public void UpdateOffice_UpdatesOfficeCorrectly()
        {
            // Arrange
            var officeToUpdate = OfficeService.GetOffices()[4];
            var newNumber = "123";
            var newSpecialization = new Specialization(20, "UrologyV4");
            var newType = "specialized";
            var newActive = false;

            officeToUpdate.Number = newNumber;
            officeToUpdate.Specialization = newSpecialization;
            officeToUpdate.Type = newType;
            officeToUpdate.Active = newActive;

            // Act
            OfficeService.UpdateOffice(officeToUpdate);

            var updatedOffice = OfficeService.GetOffices().First(x => x.Id == officeToUpdate.Id);

            // Assert
            Assert.AreEqual(newNumber, updatedOffice.Number);
            Assert.AreEqual(newSpecialization.Id, updatedOffice.Specialization.Id);
            Assert.AreEqual(newSpecialization.Name, updatedOffice.Specialization.Name);
            Assert.AreEqual(newType, updatedOffice.Type);
            Assert.AreEqual(newActive, updatedOffice.Active);
        }
        [Test]
        public void CreateOffice_AddsNewOfficeToDatabase()
        {
            // Arrange
            var newOffice = new Office(10, "459", new Specialization(14, "UrologyV8"), "general", true);
            var allOfficesPre = OfficeService.GetOffices();
            // Act
            OfficeService.CreateOffice(newOffice);

            var allOffices = OfficeService.GetOffices();
            var createdOffice = allOffices.First(x => x.Number == newOffice.Number);

            // Assert
            Assert.IsTrue(allOffices.Count > allOfficesPre.Count);

        }
        [Test]
        public void DeleteOffice_DeletesOfficeFromDatabase()
        {
            // Arrange
            var officeToDelete = OfficeService.GetOffices().First();
            var idToDelete = officeToDelete.Id;

            // Act
            var success = OfficeService.DeleteOffice(idToDelete);
            var allOffices = OfficeService.GetOffices();

            // Assert
            Assert.IsTrue(success);
            Assert.IsTrue(allOffices.Count > 0);
        }
        [Test]
        public void DeleteOffice_ReturnsFalseIfAppointmentsExist()
        {
            // Arrange
            int officeWithAppointment = 3;
            int allOfficesPre = OfficeService.GetOffices().Count;

            // Act
            OfficeService.DeleteOffice(officeWithAppointment);
            int allOffices = OfficeService.GetOffices().Count;


            // Assert
            Assert.IsTrue(allOffices == allOfficesPre);
        }
    }
}
*/