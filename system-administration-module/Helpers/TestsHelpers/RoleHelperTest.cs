using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Helpers.TestsHelpers
{
    [TestFixture]
    public class RoleHelperTest
    {
        [Test]
        public void GetRoleListFromDataTable_ValidDataTable_ReturnsRoleList()
        {
            // Arrange
            DataTable data = new DataTable();
            data.Columns.Add("Id", typeof(int));
            data.Columns.Add("name", typeof(string));
            data.Rows.Add(1, "Admin");
            data.Rows.Add(2, "User");

            // Act
            List<Role> roles = RoleHelper.GetRoleListFromDataTable(data);

            // Assert
            Assert.AreEqual(2, roles.Count);
            Assert.AreEqual(1, roles[0].Id);
            Assert.AreEqual("Admin", roles[0].Name);
            Assert.AreEqual(2, roles[1].Id);
            Assert.AreEqual("User", roles[1].Name);
        }
        [Test]
        public void AddParametrsToSqlCommand_ValidRole_ReturnsSqlCommandWithParameters()
        {
            // Arrange
            Role role = new Role(1, "Admin");
            SqlCommand cmd = new SqlCommand();

            // Act
            SqlCommand result = RoleHelper.AddParametrsToSqlCommand(cmd, role);

            // Assert
            Assert.AreSame(cmd, result);
            Assert.AreEqual("@name", result.Parameters[0].ParameterName);
            Assert.AreEqual("Admin", result.Parameters[0].Value);
        }
    }
}
