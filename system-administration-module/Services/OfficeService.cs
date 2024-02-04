using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Services
{
    public class OfficeService
    {
        public static List<Office> GetOffices()
        {
            DataTable data = DatabaseHelper.ExecuteQuery("SELECT * FROM office_details");
            List<Office> offices = Office.GetOfficeListFromDataTable(data);

            return offices;
        }
        public static List<Office> GetActiveOffices()
        {
            DataTable data = DatabaseHelper.ExecuteQuery("SELECT * FROM office_details where is_active = 1");
            List<Office> offices = Office.GetOfficeListFromDataTable(data);

            return offices;
        }

        public static void UpdateOffice(Office office)
        {
            SqlCommand cmd = new("UPDATE offices SET number = @number, specialization_id = @specializationId, type = @type, is_active = @active WHERE id = @id;");
            cmd = Office.AddParametrsToSqlCommand(cmd, office);
            cmd.Parameters.AddWithValue("@id", office.Id);
            DatabaseHelper.ExecuteNonQueryCommand(cmd);
        }

        public static void CreateOffice(Office office)
        {
            SqlCommand cmd = new("INSERT INTO Offices (number, specialization_id, type, is_active) VALUES (@number, @specializationId, @type ,@active)");
            cmd = Office.AddParametrsToSqlCommand(cmd, office);
            DatabaseHelper.ExecuteNonQueryCommand(cmd);
        }

        public static bool DeleteOffice(int id)
        {
            SqlCommand command = new("Select * from appointments_details where office_id = @id and visit_start_time >= @now");
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@now", DateTime.Now);
            DataTable result = DatabaseHelper.ExecuteQueryCommand(command);
            if(result.Rows.Count > 0)
            {
                return false;
            }
            SqlCommand commandSecond = new("DELETE FROM appointments where id = (SELECT id from appointments_details WHERE office_id = @id)");
            commandSecond.Parameters.AddWithValue("@id", id);
            DatabaseHelper.ExecuteNonQueryCommand(commandSecond);


            SqlCommand commandThird = new("DELETE FROM visits where office_id = @id");
            commandThird.Parameters.AddWithValue("@id", id);
            DatabaseHelper.ExecuteNonQueryCommand(commandThird);

            SqlCommand cmd = new("DELETE FROM offices WHERE id = @id");
            cmd.Parameters.AddWithValue("@id", id);
            
            DatabaseHelper.ExecuteNonQueryCommand(cmd);
            return true;
        }
    }
}