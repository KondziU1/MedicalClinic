using System.Data;
using SystemAdministrationModule;
using System.Data.SqlClient;

namespace SystemAdministrationModule.Helpers
{
    public class DatabaseHelper
    {
        private static readonly string connectionString = Settings.Default.dbstring;
        public static DataTable ExecuteQuery(string query)
        {
            DataTable dt = new();
            try
            {
                using SqlConnection connection = new(connectionString);
                connection.Open();
                using SqlCommand command = new(query, connection);
                using SqlDataAdapter adapter = new(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
        public static DataTable ExecuteQueryCommand(SqlCommand command)
        {
            DataTable dt = new();
            try
            {
                using SqlConnection connection = new(connectionString);
                command.Connection = connection;
                connection.Open();
                using SqlDataAdapter adapter = new(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }

        public static bool ExecuteNonQuery(string query)
        {
            bool result = true;

            try
            {
                using SqlConnection connection = new(connectionString);
                connection.Open();
                using SqlCommand command = new(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            return result;
        }

        public static bool ExecuteNonQueryCommand(SqlCommand command)
        {
            bool result = true;
            try
            {
                using SqlConnection connection = new(connectionString);
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            return result;
        }
        public static int ExecuteScalarCommand(SqlCommand command)
        {
            try
            {
                using SqlConnection connection = new(connectionString);
                command.Connection = connection;
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
    }
}