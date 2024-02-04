using System.Data;
using NUnit.Framework;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Services.TestServices
{
    [TestFixture]
    public class AppointmentServiceTests
    {

        [Test]
        public void GetVisitsData_WithEmptyWhereClause_ReturnsAllData()
        {
            // Arrange

            // Act
            DataTable result = AppointmentService.GetVisitsData();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
            // Perform additional assertions based on your specific data and query
        }

        [Test]
        public void UpdateAppointment_ReturnsTrue_WhenUpdateSuccessful()
        {
            // Arrange
            int visitId = 1;
            int appointmentId = 1;
            int doctorId = 1;
            int patientId = 1;
            Appointment appointment = new Appointment(appointmentId, visitId, doctorId, patientId, true, "Cardiology");

            // Act
            bool result = AppointmentService.UpdateAppointment(appointment, visitId);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void GetOfficeByAppointment_ReturnsOfficeNumber_WhenAppointmentExists()
        {
            // Arrange
            int appointmentId = 3585;
            int expectedOfficeNumber = 1;

            // Act
            int result = AppointmentService.GetOfficeByAppointment(appointmentId);

            // Assert
            Assert.AreEqual(expectedOfficeNumber, result);
        }

        [Test]
        public void DeleteAppointment_ReturnsTrue_WhenAppointmentIsDeleted()
        {
            // Arrange
            int appointmentId = 700;

            // Act
            bool result = AppointmentService.DeleteAppointment(appointmentId);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteAppointmentPatientId_ReturnsTrue_WhenPatientIdIsDeleted()
        {
            // Arrange
            int appointmentId = 4;

            // Act
            bool result = AppointmentService.DeleteAppointmentPatientId(appointmentId);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteFreeAppointmentByVisit_ReturnsTrue_WhenAppointmentIsDeleted()
        {
            // Arrange
            int visitId = 1;

            // Act
            bool result = AppointmentService.DeleteFreeAppointmentByVisit(visitId);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteOldAppointment_ReturnsTrue_WhenAppointmentsAreDeleted()
        {
            // Act
            bool result = AppointmentService.DeleteOldAppointment();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void UpdateAppointment_ShouldUpdateAppointmentInDatabase()
        {
            // Arrange
            var appointment = new Appointment(1, 4, 2, 3, true, "Specialization");

            // Act
            AppointmentService.UpdateAppointment(appointment);

            // Assert

        }

        [Test]
        public void GetCommentByAppointmentId_ShouldReturnCommentFromDatabase()
        {
            // Arrange
            int appointmentId = 1;

            // Act
            string comment = AppointmentService.GetCommentByAppointmentId(appointmentId);

            // Assert

        }

        [Test]
        public void AddComment_ShouldAddCommentToDatabase()
        {
            // Arrange
            int appointmentId = 1;
            string comment = "Test comment";

            // Act
            AppointmentService.AddComment(appointmentId, comment);

            // Assert
        }

        [Test]
        public void UpdateComment_ShouldUpdateCommentInDatabase()
        {
            // Arrange
            int appointmentId = 1;
            string comment = "Updated comment";

            // Act
            AppointmentService.UpdateComment(appointmentId, comment);

            // Assert

        }

        [Test]
        public void AddAppointment_ShouldAddAppointmentToDatabase()
        {
            // Arrange
            var appointment = new Appointment(2, 5, 3, 4, false, "Specialization");

            // Act
            AppointmentService.AddAppointment(appointment);

            // Assert

        }

        [Test]
        public void DeleteAppointment_ShouldDeleteAppointmentFromDatabase()
        {
            // Arrange
            var appointment = new Appointment(1, 4, 2, 3, true, "Specialization");

            // Act
            AppointmentService.DeleteAppointment(appointment);

            // Assert

        }

        [Test]
        public void GetAppointments_ShouldReturnListOfAppointmentsFromDatabase()
        {
            // Arrange

            // Act
            List<Appointment> appointments = AppointmentService.GetAppointments();

            // Assert
            Assert.IsNotNull(appointments);
            Assert.IsTrue(appointments.Count > 0);
        }

        [Test]
        public void GetAppointmentsById_ShouldReturnAppointmentsFromDatabase()
        {
            // Arrange
            int appointmentId = 3585;

            // Act
            DataTable appointments = AppointmentService.GetAppointmentsbyID(appointmentId);

            // Assert
            Assert.IsNotNull(appointments);
            Assert.IsTrue(appointments.Rows.Count > 0);
        }
    }
}