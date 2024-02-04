using System;
using System.Collections.Generic;
using System.Data;
using NUnit.Framework;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Helpers.TestsHelpers
{
    [TestFixture]
    public class AppointmentHelperTests
    {
        [Test]
        public void GetAppointmentListFromDataTable_ReturnsListWithAppointments()
        {
            // Arrange
            DataTable data = new DataTable();
            data.Columns.Add("id", typeof(int));
            data.Columns.Add("visit_id", typeof(int));
            data.Columns.Add("is_accepted", typeof(bool));
            data.Columns.Add("doctor_id", typeof(int));
            data.Columns.Add("specializations", typeof(string));
            data.Columns.Add("patient_id", typeof(int));
            data.Columns.Add("doctor_first_name", typeof(string));
            data.Columns.Add("doctor_last_name", typeof(string));
            data.Columns.Add("pesel_patients", typeof(string));
            data.Columns.Add("patient_first_name", typeof(string));
            data.Columns.Add("patient_last_name", typeof(string));
            data.Columns.Add("visit_start_time", typeof(DateTime));
            data.Columns.Add("visit_end_time", typeof(DateTime));

            // Add sample data
            DataRow row1 = data.NewRow();
            row1["id"] = 1;
            row1["visit_id"] = 1;
            row1["is_accepted"] = true;
            row1["doctor_id"] = 1;
            row1["specializations"] = "Cardiology";
            row1["patient_id"] = 1;
            row1["doctor_first_name"] = "John";
            row1["doctor_last_name"] = "Doe";
            row1["pesel_patients"] = "123456789";
            row1["patient_first_name"] = "Jane";
            row1["patient_last_name"] = "Doe";
            row1["visit_start_time"] = DateTime.Now;
            row1["visit_end_time"] = DateTime.Now.AddHours(1);
            data.Rows.Add(row1);

            // Act
            List<Appointment> result = AppointmentHelper.GetAppointmentListFromDataTable(data);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            Appointment appointment = result[0];
            Assert.AreEqual(1, appointment.Id);
            Assert.AreEqual(1, appointment.VisitId);
            Assert.IsTrue(appointment.IsAccepted);
            Assert.AreEqual(1, appointment.Doctor.Id);
            Assert.AreEqual("Cardiology", appointment.DoctorSpecialization);
            Assert.AreEqual(1, appointment.Patient.Id);
            Assert.AreEqual("123456789", appointment.Patient.Pesel);
            Assert.AreEqual("John", appointment.Doctor.FirstName);
            Assert.AreEqual("Doe", appointment.Doctor.LastName);
            Assert.AreEqual("Jane", appointment.Patient.FirstName);
            Assert.AreEqual("Doe", appointment.Patient.LastName);
            // Add additional assertions based on your specific data and object properties
        }
    }
}
