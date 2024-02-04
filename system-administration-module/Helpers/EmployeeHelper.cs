using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Helpers
{
    public static class EmployeeHelper
    {
        public static SqlCommand AddParametrsToSqlCommand(SqlCommand cmd, Employee employee)
        {
            cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@lastName", employee.LastName);
            cmd.Parameters.AddWithValue("@pesel", employee.Pesel);
            cmd.Parameters.AddWithValue("@dob", employee.DateOfBirth);
            cmd.Parameters.AddWithValue("@correspondenceAddress", employee.CorrespondenceAddress != null ? employee.CorrespondenceAddress : DBNull.Value);
            cmd.Parameters.AddWithValue("@email", employee.Email != null ? employee.Email : DBNull.Value);
            cmd.Parameters.AddWithValue("@phoneNumber", employee.PhoneNumber != null ? employee.PhoneNumber : DBNull.Value);
            cmd.Parameters.AddWithValue("@sex", employee.Sex != null ? employee.Sex : DBNull.Value);
            cmd.Parameters.AddWithValue("@roleId", employee.Role.Id);
            cmd.Parameters.AddWithValue("@active", employee.Active);

            return cmd;
        }
        public static List<Employee> GetEmployeeListFromDataTable(DataTable dt)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in dt.Rows)
            {
                int id = (int)row["id"];
                string firstName = (string)row["first_name"];
                string lastName = (string)row["last_name"];
                string pesel = (string)row["pesel"];
                DateTime dateOfBirth = Convert.ToDateTime(row["date_of_birth"]);
                string correspondenceAddress = (string)row["correspondence_address"];
                string email = (string)row["email"];
                string phoneNumber = (string)row["phone_number"];
                string sex = (string)row["sex"];
                bool active = (bool)row["is_active"];
                bool userActive = row["user_active"] == DBNull.Value ? false : (bool)row["user_active"];
                int roleId = (int)row["role_id"];
                string roleName = (string)row["role_name"];

                int? userId = row["user_id"] == DBNull.Value ? null : (int?)row["user_id"];
                string? login = row["login"] == DBNull.Value ? null : (string)row["login"];
                string? password = row["password"] == DBNull.Value ? null : (string)row["password"];
                string? resetToken = row["reset_token"] == DBNull.Value ? null : (string)row["reset_token"];
                DateTime? resetTokenExpiry = row["reset_token_expiry"] == DBNull.Value ? null : (DateTime)row["reset_token_expiry"];
                if (firstName == null || lastName == null || pesel == null || roleId == 0 || roleName == null) { continue; }


                List<Specialization> specializations = row["specializations"] != DBNull.Value ? JsonConvert.DeserializeObject<List<Specialization>>((string)row["specializations"]) : new();
                User user = userId.HasValue ? new User(userId,id,login, password, email, userActive, new Role(roleId, roleName), firstName, lastName, resetToken, resetTokenExpiry) : User.CreateEmpty();

                Employee employee = new(id, firstName, lastName, pesel, dateOfBirth, active, new Role(roleId, roleName), correspondenceAddress, email, phoneNumber, specializations, sex, user);
                employees.Add(employee);
            }

            return employees;
        }
    }
}
