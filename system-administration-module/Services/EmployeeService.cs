using System.Data;
using System.Data.SqlClient;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Services
{
    public class EmployeeService
    {
         private static DataTable GetUsers(string where = "")
        {
            string query = "SELECT * FROM employee_details";
            if (where != "")
                query += $" WHERE {where}";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static List<Employee> GetDoctors()
        {
            DataTable data = GetUsers($"role_name = 'doctor'");
            List<Employee> doctors = EmployeeHelper.GetEmployeeListFromDataTable(data);
            return doctors;
        }
      

        public static List<Employee> Login(string login, string password)
        {
            DataTable data = GetUsers($"login = '{login}' AND password = '{password}'");
            List<Employee> employees = EmployeeHelper.GetEmployeeListFromDataTable(data);
            return employees;
        }
        public static void DeleteEmployeeFromUsers(Employee employee)
        {
            SqlCommand cmd = new("UPDATE Employees SET user_id = @userId where id = @employeeId");
            cmd = EmployeeHelper.AddParametrsToSqlCommand(cmd, employee);
            cmd.Parameters.AddWithValue("userId", DBNull.Value);
            cmd.Parameters.AddWithValue("employeeId", employee.Id);
            DatabaseHelper.ExecuteNonQueryCommand(cmd);
        }

        public static List<Employee> GetEmployees()
        {
            DataTable data = GetUsers();
            List<Employee> employees = EmployeeHelper.GetEmployeeListFromDataTable(data);

            return employees;
        }
        public static List<Employee> GetEmployeesWithoutUsers()
        {
            DataTable data = GetUsers("user_id IS NULL");
            List<Employee> employees = EmployeeHelper.GetEmployeeListFromDataTable(data);

            return employees;
        }
        public static void UpdateEmployee(Employee employee)
        {
            SqlCommand cmd = new("UPDATE Employees SET user_id = @userId, first_name = @firstName, last_name = @lastName, pesel = @pesel, date_of_birth = @dob, correspondence_address = @correspondenceAddress, email = @email, phone_number = @phoneNumber, sex = @sex, is_active = @active, role_id = @roleId WHERE Id = @id");

            object userId = employee.User.Id == null ? DBNull.Value : employee.User.Id;
            cmd = EmployeeHelper.AddParametrsToSqlCommand(cmd, employee);
            cmd.Parameters.AddWithValue("id", employee.Id);
            cmd.Parameters.AddWithValue("userId", userId);

            SpecializationService.UpdateSpecializationByEmployee(employee, employee.Id);
            UserService.UpdateUserByEmployee(employee);
            DatabaseHelper.ExecuteNonQueryCommand(cmd);
        }
   
        public static void CreateEmployee(Employee employee)
        {
            int result = UserService.CreateUserByEmployee(employee);
            object userId = result == 0 ? DBNull.Value : (int)result;
            SqlCommand cmd = new("Insert into employees (user_id, first_name, last_name, pesel, date_of_birth, correspondence_address, email, phone_number, sex, is_active, role_id) VALUES (@userId, @firstName, @lastName, @pesel, @dob, @correspondenceAddress, @email, @phoneNumber, @sex, @active, @roleId); SELECT SCOPE_IDENTITY()") ;
            cmd = EmployeeHelper.AddParametrsToSqlCommand(cmd, employee);
            cmd.Parameters.AddWithValue("userId", userId);

            int id = DatabaseHelper.ExecuteScalarCommand(cmd);
            SpecializationService.UpdateSpecializationByEmployee(employee, id);
       
        }
    
    }
}