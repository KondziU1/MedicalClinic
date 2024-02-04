using NUnit.Framework;
using NUnit.Framework.Constraints;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SystemAdministrationModule.Forms.AppointmentsManagement;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;

namespace SystemAdministrationModule.Forms.AppointmentsManagement.Tests
{
    [TestFixture]
    public class FormAddNewAppointmentTests
    {

        [Test]
        public void btnAdd_Click_CreatesAppointment()
        {

            // Select test data
            int appointmentId = int.Parse(AppointmentService.GetLastAppointmentID()) + 1; ;
            int doctorId = 4;
            int visitId = 3;
            int patientId = 1;
            bool isAccepted = true;
            string specialization = "";
            var appointment = new Appointment(appointmentId, visitId, doctorId, patientId, isAccepted, specialization);


            // Act
            AppointmentService.CreateAppointment(appointment, false);


            // Assert
            var appointments = AppointmentService.GetAppointments();
            Assert.IsNotEmpty(AppointmentService.GetAppointmentsbyID(appointmentId).Rows[0][1].ToString());

        }
    }
}
