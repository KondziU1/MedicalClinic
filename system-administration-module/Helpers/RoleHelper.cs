using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Helpers
{
    public static class RoleHelper
    {
        public static List<Role> GetRoleListFromDataTable(DataTable data)
        {
            List<Role> roles = new List<Role>();

            foreach (DataRow row in data.Rows)
            {
                int id = (int)row["Id"];
                string name = (string)row["name"];

                Role role = new Role(id, name);
                roles.Add(role);
            }

            return roles;
        }

        public static SqlCommand AddParametrsToSqlCommand(SqlCommand cmd, Role role)
        {
            cmd.Parameters.AddWithValue("@name", role.Name);
            return cmd;
        }
    }
}
