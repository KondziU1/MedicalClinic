using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Helpers;

namespace SystemAdministrationModule.Helpers.TestsHelpers
{
    [TestFixture]
    public class DatabaseHelperTest
    {
        private static readonly string connectionString = "Server=tcp:system-administration-module.database.windows.net,1433;Initial Catalog=system-administration-module;Persist Security Info=False;User ID=krystian-spoko-gosc;Password=Test1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        [Test]
        public void ExecuteQuery_ValidQuery()
        {
            // Arrange
            string query = "SELECT * FROM Users";

            // Act
            DataTable result = DatabaseHelper.ExecuteQuery(query);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<DataTable>(result);
        }


        [Test]
        public void ExecuteQuery_InvalidQuery()
        {
            // Arrange
            string query = "SELECT * FROM non_existent_table";

            // Act
            DataTable result = DatabaseHelper.ExecuteQuery(query);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Rows.Count);

        }


        [Test]
        public void ExecuteNonQuery_ValidQuery()
        {
            // Arrange
            string query = "INSERT INTO Specializations (name) VALUES (testSpecialization)";
            // Act & Assert
            Assert.DoesNotThrow(() => DatabaseHelper.ExecuteNonQuery(query));

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new("DELETE FROM Specializations where name = @Name", connection);
            command.Parameters.AddWithValue("@Name", "testSpecialization");
            DatabaseHelper.ExecuteNonQueryCommand(command);
        }


        [Test]
        public void ExecuteNonQuery_InvalidQuery()
        {
            // Arrange
            string query = "INSERT INTO non_existent_table (name) VALUES (name)";

            // Act 
            bool result = DatabaseHelper.ExecuteNonQuery(query);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ExecuteNonQueryCommand_ValidCommand()
        {
            // Arrange
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new("INSERT INTO Specializations (name) VALUES (@Name)", connection);
            command.Parameters.AddWithValue("@Name", "testSpecialization");

            // Act & Assert
            Assert.DoesNotThrow(() => DatabaseHelper.ExecuteNonQueryCommand(command));

            using SqlCommand command2 = new("DELETE FROM Specializations where name = @Name", connection);
            command2.Parameters.AddWithValue("@Name", "testSpecialization");
            DatabaseHelper.ExecuteNonQueryCommand(command2);
        }
        [Test]
        public void ExecuteNonQueryCommand_InValidCommand()
        {
            // Arrange
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new("INSERT INTO non_existent_table (name) VALUES (@Name)", connection);
            command.Parameters.AddWithValue("@Name", "testSpecialization");

            // Act & Assert
            Assert.DoesNotThrow(() => DatabaseHelper.ExecuteNonQueryCommand(command));

            using SqlCommand command2 = new("DELETE FROM Specializations where name = @Name", connection);
            command2.Parameters.AddWithValue("@Name", "testSpecialization");
            DatabaseHelper.ExecuteNonQueryCommand(command2);
        }

        [Test]
        public void ExecuteScalarCommand_ValidCommand_ReturnsInteger()
        {
            // Arrange
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new("SELECT COUNT(*) FROM employees", connection);

            // Act
            int result = DatabaseHelper.ExecuteScalarCommand(command);

            // Assert
            Assert.IsTrue(result >= 0);
        }

        [Test]
        public void ExecuteScalarCommand_InvalidQuery_ReturnsZero()
        {
            // Arrange
            SqlCommand command = new SqlCommand("SELECT * FROM non_existent_table");

            // Act
            int result = DatabaseHelper.ExecuteScalarCommand(command);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
