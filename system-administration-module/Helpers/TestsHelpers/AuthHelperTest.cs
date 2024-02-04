using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SystemAdministrationModule.Helpers.TestsHelpers
{
    [TestFixture]
    public class AuthHelperTest
    {
        [Test]
        public void GenerateLogin_ReturnsValidLogin()
        {
            // Arrange

            // Act
            string login = AuthHelper.GenerateLogin();

            // Assert
            Assert.AreEqual(8, login.Length);
            Assert.IsTrue(login.All(char.IsLower));
        }

        [Test]
        public void GeneratePassword_ReturnsValidPassword()
        {
            // Arrange

            // Act
            string password = AuthHelper.GeneratePassword();

            // Assert
            Assert.GreaterOrEqual(password.Length, 8);
            Assert.LessOrEqual(password.Length, 16);
            Assert.IsTrue(password.Any(char.IsLower));
            Assert.IsTrue(password.Any(char.IsUpper));
            Assert.IsTrue(password.Any(char.IsDigit));
            Assert.IsTrue(password.Any(c => "-_!#$*".Contains(c)));
        }

    }
}
