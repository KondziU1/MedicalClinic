using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Services.TestServices
{
    [TestFixture]
    public class CalendarServiceTest
    {
        [Test]
        public void IsCalendarFullyAccepted_ShouldReturnTrueWhenAllAppointmentsAreAccepted()
        {
            // Arrange
            int calendarId = 5;

            // Act
            bool isFullyAccepted = CalendarService.IsCalendarFullyAccepted(calendarId);

            // Assert
            Assert.IsTrue(isFullyAccepted);
        }

        [Test]
        public void IsCalendarFullyAccepted_ShouldReturnFalseWhenAtLeastOneAppointmentIsNotAccepted()
        {
            // Arrange
            int calendarId = 2;

            // Act
            bool isFullyAccepted = CalendarService.IsCalendarFullyAccepted(calendarId);

            // Assert
            Assert.IsFalse(isFullyAccepted);
        }

        [Test]
        public void ConfirmCalendar_ShouldSetAppointmentsToAcceptedAndUpdateCalendarStatus()
        {
            // Arrange
            var calendar = new Calendar(1, "Calendar 1", DateTime.Now, DateTime.Now.AddDays(7), "accepted", true);
            var appointments = new List<Appointment>
        {
            new Appointment(1, 1, 1, 1, false, "Anestaziologia"),
            new Appointment(2, 1, 2, 2, false, "Anestaziologia"),
            new Appointment(3, 1, 3, 3, false, "Anestaziologia")
        };

            // Act
            CalendarService.ConfirmCalendar(appointments, calendar);

            // Assert
            Assert.IsTrue(appointments.TrueForAll(a => a.IsAccepted));
            Assert.AreEqual("accepted", calendar.Status);
        }
    }
}