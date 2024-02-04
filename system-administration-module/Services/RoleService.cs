using Microsoft.VisualStudio.TestPlatform.Utilities.Helpers;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Services
{
    public class RoleService
    {
        public static List<Role> GetRoles()
        {
            string query = $"SELECT * from roles";

            DataTable result = DatabaseHelper.ExecuteQuery(query);
            List<Role> roles = new();

            foreach (DataRow row in result.Rows)
            {
                int id = (int)row["id"];
                string name = (string)row["name"];
                if(id == 0 || name == null)
                {
                    continue;
                }
                Role role = new Role(id, name);
                roles.Add(role);

            }
            return roles;
        } 
        public static List<Role> GetRolesWithAll()
        {

            List<Role> roles = new();
            Role allRole = new(0, name: "All");
            roles.Add(allRole);
           
            List<Role> getRoles = GetRoles();
            foreach (Role role in getRoles)
            {
               roles.Add(role);
            }
            return roles;
        }
        public static void AddRole(Role role)
        {
            SqlCommand cmd = new("INSERT INTO roles (name) VALUES (@name)");
            cmd = RoleHelper.AddParametrsToSqlCommand(cmd, role);
            int roleId = DatabaseHelper.ExecuteScalarCommand(cmd);
            role.Id = roleId;
        }
        public static void UpdateRole(Role role)
        {

            SqlCommand cmd = new("UPDATE roles SET name = @name WHERE Id = @id");
            cmd = RoleHelper.AddParametrsToSqlCommand(cmd, role);
            cmd.Parameters.AddWithValue("@id", role.Id);
            DatabaseHelper.ExecuteNonQueryCommand(cmd);
        }

        public static void DeleteRole(int roleId)
        {
            SqlCommand cmd = new("DELETE FROM roles WHERE Id = @id");
            cmd.Parameters.AddWithValue("@id", roleId);
            DatabaseHelper.ExecuteNonQueryCommand(cmd);
        }

    }
}