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
    public class EmployeeServiceTest
    {
        [Test]
        public void Login_ValidCredentials_ReturnsListOfEmployees()
        {
            // Arrange
            string login = "Login123";
            string password = "Password123";

            // Act
            List<Employee> result = EmployeeService.Login(login, password);

            // Assert
            Assert.IsInstanceOf<List<Employee>>(result);
            Assert.IsTrue(result.Count > 0);
        }

        [Test]
        public void Login_InvalidCredentials_ReturnsEmptyList()
        {
            // Arrange
            string login = "jane.doe";
            string password = "password123";

            // Act
            List<Employee> result = EmployeeService.Login(login, password);

            // Assert
            Assert.IsInstanceOf<List<Employee>>(result);
            Assert.IsEmpty(result);
        }

        [Test]
        public void GetEmployees_ReturnsListOfEmployees()
        {
            // Arrange

            // Act
            List<Employee> result = EmployeeService.GetEmployees();

            // Assert
            Assert.IsInstanceOf<List<Employee>>(result);
            Assert.IsTrue(result.Count > 0);
        }

        [Test]
        public void GetEmployeesWithoutUsers_ReturnsListOfEmployees()
        {
            // Arrange

            // Act
            List<Employee> result = EmployeeService.GetEmployeesWithoutUsers();

            // Assert
            Assert.IsInstanceOf<List<Employee>>(result);
            Assert.IsTrue(result.Count > 0);
        }



        [Test]
        public void DeleteEmployeeFromUsers_ValidEmployee_DeletesEmployee()
        {
            // Arrange
            Employee employee = new Employee(6, "Jane", "Doe", "12345678441", new DateTime(1990, 1, 1), true, new Role(1, "admin"), "ul fajna 15", "jane.doe@example.com", "123123123", new List<Specialization> { new Specialization(1, "Anesthesiology") }, "F", null);

            // Act
            EmployeeService.DeleteEmployeeFromUsers(employee);
            List<Employee> result = EmployeeService.GetEmployees();

            // Assert
            Assert.IsFalse(result.Contains(employee));
        }
    }
}
*/