using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAdministrationModule.Models
{
    public class User
    {
        public User(int? id,int? employeeId, string? login, string? password, string? email,bool? active, Role? role, string? firstName, string? lastName, string? resetToken, DateTime? resetTokenExpiry)
        {
            Id = id ?? 0;
            EmployeeId = employeeId ?? 0;
            Login = login ?? string.Empty;
            Password = password ?? string.Empty;
            Email = email ?? string.Empty;
            Active = active ?? false;
            Role = role ?? Role.CreateEmpty();
            FirstName = firstName ?? string.Empty;
            LastName = lastName ?? string.Empty;
            ResetToken = resetToken ?? string.Empty;
            ResetTokenExpiry = resetTokenExpiry ?? null;


        }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ResetToken { get; set; }
        public DateTime? ResetTokenExpiry { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public static User CreateEmpty()
        {
            return new User(null, null, null, null, null, null, Role.CreateEmpty(), null, null, null, null);
        }
        public static List<User> GetUserListFromDataTable(DataTable dt)
        {
            List<User> users = new();

            foreach (DataRow row in dt.Rows)
            {
                int userId = (int)row["user_id"];
                int employeeId = (int)row["user_id"];
                int roleId = (int)row["role_id"];
                string roleName = (string)row["role_name"];
                string login = (string)row["login"];
                string email = (string)row["email"];
                bool active = (bool)row["user_active"];
                string password = (string)row["password"];
                string firstName = (string)row["first_name"];
                string lastName = (string)row["last_name"];
                string? resetToken = row["reset_token"] == DBNull.Value ? null : (string)row["reset_token"];
                DateTime? resetTokenExpiry = row["reset_token_expiry"] == DBNull.Value ? null : (DateTime)row["reset_token_expiry"];


                if (login == null || password == null || roleId == 0 || roleName == null) { continue; }
                User user = new(userId,employeeId, login, password, email, active, new Role(roleId, roleName), firstName, lastName, resetToken, resetTokenExpiry);
                users.Add(user);
            }
            return users;
        }
        public static SqlCommand AddParametrsToSqlCommand(SqlCommand cmd, User user)
        {
            cmd.Parameters.AddWithValue("@login", user.Login);
            cmd.Parameters.AddWithValue("@active", user.Active);
            cmd.Parameters.AddWithValue("@password", user.Password != null ? user.Password : DBNull.Value);
            return cmd;
        }
        public static SqlCommand AddParametrsToSqlUserCommandFromEmployee(SqlCommand cmd, Employee employee)
        {
            cmd.Parameters.AddWithValue("@login", employee.User.Login);
            cmd.Parameters.AddWithValue("@password", employee.User.Password);
            cmd.Parameters.AddWithValue("@active", employee.User.Active);
            return cmd;
        }
    }
}
