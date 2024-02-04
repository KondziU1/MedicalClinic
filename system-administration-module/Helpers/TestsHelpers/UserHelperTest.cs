using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Helpers.TestsHelpers
{
    [TestFixture]
    public class UserHelperTest
    {
        [TestCase(5)]
        [TestCase(10)]
        public void GenerateToken_ShouldReturnTokenWithCorrectLength(int size)
        {
            // Act
            var result = UserHelper.GenerateToken(size);

            // Assert
            Assert.AreEqual(result.Length, size);
        }
    }
}
