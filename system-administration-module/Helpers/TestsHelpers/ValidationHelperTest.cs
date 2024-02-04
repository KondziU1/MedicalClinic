using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAdministrationModule.Helpers.TestsHelpers
{
    [TestFixture]
    public class ValidationHelperTests
    {

        [Test]
        public void ValidateFields_WithValidFields()
        {
            // Arrange
            string pesel = "01211700000";
            string sex = "F";
            string email = "test@example.com";
            string phone = "123123123";
            string date = "17.01.2001";

            // Act
            bool result = ValidationHelper.ValidateFields(pesel, sex, email, phone, date);
            
            // Assert
            Assert.IsTrue(result);

        }
        [Test]
        public void ValidateFields_WithInValidPesel()
        {
            // Arrange
            string pesel = "01211700000";
            string sex = "M";
            string email = "test@example.com";
            string phone = "123123123";
            string date = "17.01.2001";

            // Act
            bool result = ValidationHelper.ValidateFields(pesel, sex, email, phone, date);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateFields_WithInvalidEmail_ReturnsFalse()
        {
            // Arrange
            string pesel = "01211700000";
            string sex = "F";
            string email = "test@";
            string phone = "123123123";
            string date = "17.01.2001";

            // Act
            bool result = ValidationHelper.ValidateFields(pesel, sex, email, phone, date);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateFields_WithInvalidPhone_ReturnsFalse()
        {
            // Arrange
            string pesel = "01211700000";
            string sex = "F";
            string email = "test@";
            string phone = "123123";
            string date = "17.01.2001";

            // Act
            bool result = ValidationHelper.ValidateFields(pesel, sex, email, phone, date);

            // Assert
            Assert.IsFalse(result);
        
        }
    }
}
