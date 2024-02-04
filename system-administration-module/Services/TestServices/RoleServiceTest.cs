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
    public class RoleServiceTests
    {
        [Test]
        public void GetRolesWithAll_ReturnsListOfRolesWithAll()
        {
            // Arrange

            // Act
            List<Role> roles = RoleService.GetRolesWithAll();

            // Assert
            Assert.IsNotNull(roles);
            Assert.IsTrue(roles.Count > 0);

            Role firstRole = roles[0];
            Assert.AreEqual(0, firstRole.Id);
            Assert.AreEqual("All", firstRole.Name);
        }
        [Test]
        public void AddRole_AddsNewRoleToDatabase()
        {
            // Arrange
            Role roleToAdd = new Role(5,name: "Test Role");

            // Act
            RoleService.AddRole(roleToAdd);
            List<Role> roles = RoleService.GetRoles();

            // Assert
            Assert.IsNotNull(roles);
            Assert.IsTrue(roles.Count > 0);

            Role addedRole = roles.Find(r => r.Name == roleToAdd.Name);
            Assert.IsNotNull(addedRole);
        }

        [Test]
        public void DeleteRole_DeletesExistingRoleFromDatabase()
        {
            // Arrange
            List<Role> rolesBeforeDeletion = RoleService.GetRoles();
            Role roleToDelete = rolesBeforeDeletion[0];

            // Act
            RoleService.DeleteRole(6);
            List<Role> rolesAfterDeletion = RoleService.GetRoles();

            // Assert
            Assert.IsTrue(rolesAfterDeletion.Count < rolesBeforeDeletion.Count);
        }
    }
}
*/