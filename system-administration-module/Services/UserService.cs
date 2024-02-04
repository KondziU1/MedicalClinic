using System.Data;
using System.Data.SqlClient;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Services
{
    public class UserService
    {
        private static DataTable GetUsersData(string where = "")
        {
            string query = "Select * from user_details";
            if (where != "")
                query += $" WHERE {where}";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static List<User> GetUsers()
        {
            DataTable data = GetUsersData();
            List<User> users = User.GetUserListFromDataTable(data);

            return users;
        }
        public static List<User> GetUsersByEmail(string email)
        {
            DataTable data = GetUsersData($"email = {email}");
            List<User> users = User.GetUserListFromDataTable(data);

            return users;
        }
        public static List<User> GetUsersByToken(string token)
        {

            DateTime now = DateTime.Now;
            SqlCommand cmd = new("Select * from user_details Where reset_token = @token AND reset_token_expiry > @now");
            cmd.Parameters.AddWithValue("token", token);
            cmd.Parameters.AddWithValue("now", now);
            DataTable data = DatabaseHelper.ExecuteQueryCommand(cmd);
            List<User> users = User.GetUserListFromDataTable(data);

            return users;
        }
        public static string SetTokenForUser(User user)
        {
            SqlCommand cmd = new("UPDATE users SET reset_token = @token, reset_token_expiry = @expiry WHERE id = @id");
            string token = UserHelper.GenerateToken(8);
            cmd.Parameters.AddWithValue("token", token);
            DateTime time = DateTime.Now;
            cmd.Parameters.AddWithValue("expiry", time.AddDays(1));
            cmd.Parameters.AddWithValue("id", user.Id);

            DatabaseHelper.ExecuteNonQueryCommand(cmd);
            return token;
        }
        public static void SetPassword(string token, string newPassword)
        {
            SqlCommand cmd = new("UPDATE users SET password = @password, reset_token = @null, reset_token_expiry = @null WHERE reset_token = @token AND reset_token_expiry > @expiry");
            cmd.Parameters.AddWithValue("password", newPassword);
            cmd.Parameters.AddWithValue("token", token);
            cmd.Parameters.AddWithValue("expiry", DateTime.Now);
            cmd.Parameters.AddWithValue("null", DBNull.Value);
            DatabaseHelper.ExecuteNonQueryCommand(cmd);
        }



        public static void UpdateUserByEmployee(Employee employee)
        {         
            SqlCommand command = new("Update Users SET login = @login, password = @password, is_active = @active WHERE id = @id");
            command = User.AddParametrsToSqlUserCommandFromEmployee(command, employee);
            command.Parameters.AddWithValue("@id", employee.User.Id);

            DatabaseHelper.ExecuteNonQueryCommand(command);
        }
   
        public static int CreateUserByEmployee(Employee employee)
        {
            if ((employee.User.Login != string.Empty) && (employee.User.Password != String.Empty))
            {
                    SqlCommand command = new("Insert into users (login, password) VALUES (@login, @password); SELECT SCOPE_IDENTITY()");
                    command = User.AddParametrsToSqlUserCommandFromEmployee(command, employee);
                    return DatabaseHelper.ExecuteScalarCommand(command);
            }
            return 0;
        }

        public static void UpdateUser(User user, int? employeeId, bool updateEmployeeActive = false)
        {
            SqlCommand cmd = new("Update Users SET login = @login, password = @password, is_active = @active WHERE id = @id");
            cmd = User.AddParametrsToSqlCommand(cmd, user);
            cmd.Parameters.AddWithValue("id", user.Id);

            DatabaseHelper.ExecuteNonQueryCommand(cmd);
            if (employeeId != null)
            {
                SqlCommand command = new();
                if (updateEmployeeActive)
                {
                    command.CommandText = "UPDATE employees SET user_id = @id, is_active = @active, first_name = @firstName, role_id = @roleId, last_name = @lastName, email=@email where id = @employeeId";
                    command.Parameters.AddWithValue("active", user.Active);
                }
                else
                {
                    command.CommandText = "UPDATE employees SET user_id = @id,first_name = @firstName, role_id = @roleId, last_name = @lastName, email=@email where id = @employeeId";
                }
                //command = User.AddParametrsToSqlCommand(command, user);
                command.Parameters.AddWithValue("employeeId", employeeId);
                command.Parameters.AddWithValue("firstName", user.FirstName);
                command.Parameters.AddWithValue("lastName", user.LastName);
                command.Parameters.AddWithValue("email", user.Email);
                
                command.Parameters.AddWithValue("roleId", user.Role.Id);
                command.Parameters.AddWithValue("id", user.Id);

                DatabaseHelper.ExecuteNonQueryCommand(command);
            }
        }
        public static void CreateUser(User user,int? employeeId)
        {
            SqlCommand cmd = new("Insert into users (login, password) VALUES (@login, @password); SELECT SCOPE_IDENTITY()");
            cmd = User.AddParametrsToSqlCommand(cmd, user);

            int id = DatabaseHelper.ExecuteScalarCommand(cmd);
            if (employeeId != null)
            {
                SqlCommand command = new("UPDATE employees SET user_id = @id where id = @employeeId");
                command.Parameters.AddWithValue("id",id);
                command.Parameters.AddWithValue("employeeId", employeeId);
                DatabaseHelper.ExecuteNonQueryCommand(command);
            }

        }
    }
}