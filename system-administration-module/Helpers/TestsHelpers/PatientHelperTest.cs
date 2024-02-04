using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
using NUnit.Framework;

namespace SystemAdministrationModule.Helpers.TestsHelpers
{
    [TestFixture]
    public class PatientHelperTests
    {
        [Test]
        public void AddParametersToSqlCommand_AddsParametersToSqlCommand()
        {
            // Arrange
            var patient = new Patient(
                id: 1,
                firstName: "John",
                lastName: "Doe",
                pesel: "1234567890",
                active: true
            );
            var cmd = new SqlCommand();

            // Act
            var result = PatientHelper.AddParametrsToSqlCommand(cmd, patient);

            // Assert
            Assert.AreEqual("@firstName", result.Parameters[0].ParameterName);
            Assert.AreEqual(patient.FirstName, result.Parameters[0].Value);

            Assert.AreEqual("@lastName", result.Parameters[1].ParameterName);
            Assert.AreEqual(patient.LastName, result.Parameters[1].Value);

            Assert.AreEqual("@pesel", result.Parameters[2].ParameterName);
            Assert.AreEqual(patient.Pesel, result.Parameters[2].Value);

            Assert.AreEqual("@active", result.Parameters[3].ParameterName);
            Assert.AreEqual(patient.Active, result.Parameters[3].Value);
        }

        [Test]
        public void GenerateToken_GeneratesTokenWithCorrectLength()
        {
            // Arrange
            var size = 10;

            // Act
            var result = PatientHelper.GenerateToken(size);

            // Assert
            Assert.AreEqual(size, result.Length);
        }
    }
}



