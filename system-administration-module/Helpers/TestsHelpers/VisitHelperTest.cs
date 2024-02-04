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
    public class VisitHelperTest
    {
        [Test]
        public void GetVisitsFromCommand_ShouldReturnListOfVisits()
        {
            // Arrange
            var cmd = new SqlCommand("SELECT * FROM visits_details");

            // Act
            var result = VisitHelper.GetVisitsFromCommand(cmd);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
