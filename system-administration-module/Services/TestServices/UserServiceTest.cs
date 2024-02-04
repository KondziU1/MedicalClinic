using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Services;
/*
namespace SystemAdministrationModule.Services.TestServices
{
    [TestFixture]
    public class UserServiceTest
    {
        [Test]
        public void GetUsers_ReturnsListOfUsers()
        {
            // Arrange

            // Act
            List<User> users = UserService.GetUsers();

            // Assert
            Assert.IsNotNull(users);
        }

        [Test]
        public void GetUsersByEmail_WithValidEmail_ReturnsListOfUsers()
        {
            // Arrange
            string email = "test@test.pl";

            // Act
            List<User> users = UserService.GetUsersByEmail(email);

            // Assert
            Assert.IsInstanceOf<List<User>>(users);
        }

        [Test]
        public void GetUsersByEmail_WithInvalidEmail_ReturnsEmptyListOfUsers()
        {
            // Arrange
            string email = "invalidemail@example.com";

            // Act
            List<User> users = UserService.GetUsersByEmail(email);

            // Assert
            Assert.IsInstanceOf<List<User>>(users);
            Assert.AreEqual(0, users.Count);
        }

        [Test]
        public void GetUsersByToken_WithValidToken_ReturnsListOfUsers()
        {
            // Arrange
            string token = "Czad";

            // Act
            List<User> users = UserService.GetUsersByToken(token);

            // Assert
            Assert.IsInstanceOf<List<User>>(users);
            Assert.IsTrue(users.Count > 0);
        }

        [Test]
        public void GetUsersByToken_WithExpiredToken_ReturnsEmptyListOfUsers()
        {
            // Arrange
            string token = "expiredtoken";

            // Act
            List<User> users = UserService.GetUsersByToken(token);

            // Assert
            Assert.IsInstanceOf<List<User>>(users);
            Assert.AreEqual(0, users.Count);
        }

        [Test]
        public void SetTokenForUser_SetsTokenForUser()
        {
            // Arrange
            User user = new User(id: 1, employeeId: 1, login: "test", password: "password", email: "test@example.com", active: true, role: Role.CreateEmpty(), firstName: "John", lastName: "Doe", resetToken: null, resetTokenExpiry: null);

            // Act
            string token = UserService.SetTokenForUser(user);

            // Assert
            Assert.IsNotEmpty(token);
        }

        [Test]
        public void SetPassword_WithValidToken_SetsPasswordForUser()
        {
            // Arrange
            string token = "validtoken";
            string newPassword = "newpassword";

            // Act
            UserService.SetPassword(token, newPassword);

            // Assert
        }



    }
}
*/