using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Services
{
    public class SpecializationService
    {
        public static List<Specialization> GetSpecializations()
        {
            string query = $"SELECT * from specializations";

            DataTable result = DatabaseHelper.ExecuteQuery(query);
            return Specialization.GetSpecializationsFromDataTable(result);
        }
        public static List<Specialization> GetSpecializationsHaveUsers()
        {
            string query = $"SELECT * from specialization_users_count";
            DataTable result = DatabaseHelper.ExecuteQuery(query);

            return Specialization.GetSpecializationsFromDataTable(result);
        }


        public static void UpdateSpecializationByEmployee(Employee employee, int id)
        {
            SqlCommand command = new("DELETE employee_specialization where employee_id = @id");
            command.Parameters.AddWithValue("id", id);
            DatabaseHelper.ExecuteNonQueryCommand(command);
            List<Specialization> test = employee.Specializations;

            if(employee.Specializations.Count > 0)
            {
                SqlCommand cmd = new("INSERT INTO employee_specialization (employee_id, specialization_id) VALUES");
                string values = "";
                foreach(Specialization specialization in employee.Specializations)
                {

                    values += string.Format("('{0}', '{1}'),", id, specialization.Id);
                    //cmd.Parameters.AddWithValue("employeeId", id);
                    //cmd.Parameters.AddWithValue("specializationId", specialization.Id);
                }
                values = values.TrimEnd(',');
                cmd.CommandText += values;
                DatabaseHelper.ExecuteNonQueryCommand(cmd);
            }
        }


        public static void UpdateSpecialization(Specialization specialization)
        {
            SqlCommand command = new("UPDATE specializations SET Name = @name WHERE id = @id;");
            command.Parameters.AddWithValue("id", specialization.Id);
            command.Parameters.AddWithValue("name", specialization.Name);
            DatabaseHelper.ExecuteNonQueryCommand(command);
        }
        public static void CreateSpecialization(Specialization specialization)
        {
            SqlCommand command = new("INSERT INTO specializations (Name) VALUES (@name);");
            command.Parameters.AddWithValue("name", specialization.Name);
            DatabaseHelper.ExecuteNonQueryCommand(command);
        }
        public static void DeleteSpecialization(Specialization specialization)
        {
            SqlCommand command = new("DELETE specializations WHERE id = @id;");
            command.Parameters.AddWithValue("id", specialization.Id);
            DatabaseHelper.ExecuteNonQueryCommand(command);
        }
    }
}