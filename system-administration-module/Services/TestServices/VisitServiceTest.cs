using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Services.TestServices
{
    [TestFixture]
    public class VisitServiceTest
    {
        [Test]
        public void GetVisitsForPatient_ShouldReturnVisitsForPatientFromDatabase()
        {
            // Arrange
            int patientId = 1;

            // Act
            List<Visit> visits = VisitService.GetVistsForPatient(patientId);

            // Assert
            Assert.IsNotNull(visits);
            Assert.IsTrue(visits.Count > 0);
        }

        [Test]
        public void UpdateVisitInDB_ShouldUpdateVisitInDatabase()
        {
            // Arrange
            var visit = new Visit(1, DateTime.Now, DateTime.Now.AddHours(1));
            visit.OfficeId = 1;
            visit.CalendarId = 1;

            // Act
            VisitService.UpdateVisitInDB(visit);

            // Assert

        }
    }
}