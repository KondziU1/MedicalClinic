using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace SystemAdministrationModule.Services
{
    public class VisitService
    {

        private static DataTable GetVisitsData(string where = "")
        {
            string query = "Select * from visits_details";
            if (where != "")
                query += $" WHERE {where}";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static List<Visit> GetFreeVisits(int calendarId)
        {
            DataTable data = GetVisitsData($"doctor_id IS NULL AND calendar_id = {calendarId}");
            List<Visit> Visits = Visit.GetVisitListFromDataTable(data);

            return Visits;
        }
        public static List<Visit> GetVisits(int calendarId)
        {
            DataTable data = GetVisitsData($"calendar_id = {calendarId}");
            List<Visit> Visits = Visit.GetVisitListFromDataTable(data);

            return Visits;
        }
        public static List<Visit> GetVisitsForID(int visitId)
        {
            DataTable data = GetVisitsData($"id = {visitId}");
            List<Visit> Visits = Visit.GetVisitListFromDataTable(data);

            return Visits;
        }
        public static List<Visit> GetVistsForDay(DateTime date)
        {
            SqlCommand cmd = new("Select * from visits_details where visit_start_time > @dateStart AND visit_end_time < @dateEnd;");
            cmd = VisitHelper.AddStartAndEndDayToCommand(cmd, date);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }
        public static List<Visit> GetFreeVistsForDay(DateTime date)
        {
            SqlCommand cmd = new("Select * from visits_details where visit_start_time > @dateStart AND visit_end_time < @dateEnd AND doctor_id IS NULL;");
            cmd = VisitHelper.AddStartAndEndDayToCommand(cmd, date);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }

        public static List<Visit> GetVistsForDoctorByCalendar(int doctorId, int calendarId)
        {
            SqlCommand cmd = new("Select * from visits_details where doctor_id = @doctorId AND calendar_Id=@calendarId");
            cmd.Parameters.AddWithValue("doctorId", doctorId);
            cmd.Parameters.AddWithValue("calendarId", calendarId);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }
        public static List<Visit> GetFreeVistsForDoctorByCalendar(int doctorId, int calendarId)
        {
            SqlCommand cmd = new("Select * from visits_details where doctor_id = @doctorId AND calendar_id=@calendarId AND patient_id is NULL AND visit_start_time > GETDATE()");
            cmd.Parameters.AddWithValue("doctorId", doctorId);
            cmd.Parameters.AddWithValue("calendarId", calendarId);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }

        public static List<Visit> GetVistsForDoctor(int doctorId)
        {
            SqlCommand cmd = new("Select * from visits_details where doctor_id = @doctorId");
            cmd.Parameters.AddWithValue("doctorId", doctorId);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }
        public static List<Visit> GetVistsForPatient(int patientId)
        {
            SqlCommand cmd = new("Select * from visits_details where patient_id = @patientId");
            cmd.Parameters.AddWithValue("patientId", patientId);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }
        public static List<Visit> GetVistsForOffice(int officeId)
        {
            SqlCommand cmd = new("Select * from visits_details where office_id = @officeId");
            cmd.Parameters.AddWithValue("officeId", officeId);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }

        public static List<Visit> GetFreeVistsForOffice(int officeId)
        {
            SqlCommand cmd = new("Select * from visits_details where office_id = @officeId and doctor_id IS NULL");
            cmd.Parameters.AddWithValue("officeId", officeId);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }

        public static List<Visit> GetFreeVistsForOfficeAndDay(DateTime date, int officeId)
        {
            SqlCommand cmd = new("Select * from visits_details where visit_start_time > @dateStart AND visit_end_time < @dateEnd AND office_id = @officeId AND doctor_id IS NULL;");
            cmd = VisitHelper.AddStartAndEndDayToCommand(cmd, date);
            cmd.Parameters.AddWithValue("officeId", officeId);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }
        public static List<Visit> GetVistsForDayAndDoctor(DateTime date, int doctorId)
        {
            SqlCommand cmd = new("Select * from visits_details where visit_start_time > @dateStart AND visit_end_time < @dateEnd AND doctor_id = @doctorId;");
            cmd = VisitHelper.AddStartAndEndDayToCommand(cmd, date);
            cmd.Parameters.AddWithValue("doctorId", doctorId);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }
        public static List<Visit> GetFreeVistsDoctorForDayAndOffice(DateTime date, int doctorId, int officeId)
        {
            SqlCommand cmd = new("Select * from visits_details where office_id = @officeId AND visit_start_time > @dateStart AND visit_end_time < @dateEnd AND (doctor_id = @doctorId OR doctor_id is null);");
            cmd = VisitHelper.AddStartAndEndDayToCommand(cmd, date);
            cmd.Parameters.AddWithValue("doctorId", doctorId);
            cmd.Parameters.AddWithValue("officeId", officeId);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }

        public static List<Visit> GetFreeVistsForDayAndOffice(DateTime date, int officeId)
        {
            SqlCommand cmd = new("Select * from visits_details where office_id = @officeId AND visit_start_time > @dateStart AND visit_end_time < @dateEnd AND doctor_id is null;");
            cmd = VisitHelper.AddStartAndEndDayToCommand(cmd, date);
            //cmd.Parameters.AddWithValue("doctorId", doctorId);
            cmd.Parameters.AddWithValue("officeId", officeId);
            return VisitHelper.GetVisitsFromCommand(cmd);
        }
        public static void UpdateListVistsInDB(List<Visit> visits)
        {
            foreach (Visit visit in visits)
            {
                SqlCommand cmd = new("UPDATE visits SET visit_start_time = @start, visit_end_time = @end, office_id =@officeId, calendar_id = @calendarId WHERE id = @id");
                cmd.Parameters.AddWithValue("id", visit.Id);
                cmd.Parameters.AddWithValue("calendarId", visit.Calendar != null? visit.Calendar.Id : DBNull.Value);// Jak niżej
                cmd.Parameters.AddWithValue("officeId", visit.Office != null? visit.Office.Id : DBNull.Value);// Jak niżej
                cmd.Parameters.AddWithValue("visit_start_time", visit.VisitStartTime);
                cmd.Parameters.AddWithValue("visit_end_time", visit.VisitEndTime);
                DatabaseHelper.ExecuteNonQueryCommand(cmd);
            }
        }

        public static void DeleteListVists(List<Visit> visits)
        {
            SqlCommand cmd = new("DELETE from visits where ID IN(");
            string values = "";
            foreach (Visit visit in visits)
            {
                values += string.Format("{0},", visit.Id);
            }
            values = values.TrimEnd(',') + ")";
            cmd.CommandText += values;
            DatabaseHelper.ExecuteNonQueryCommand(cmd);
        }
        public static void SaveListVistsInDB(List<Visit> visits)
        {
            const int batchSize = 1000;

            if (visits.Count > 0)
            {
                for (int i = 0; i < visits.Count; i += batchSize)
                {
                    List<Visit> batch = visits.Skip(i).Take(batchSize).ToList();
                    SqlCommand cmd = new("INSERT INTO visits(visit_start_time, visit_end_time, office_id, calendar_id) VALUES ");
                    string values = "";
                    foreach (Visit visit in batch)
                    {
                        values += string.Format("('{0}', '{1}', '{2}', '{3}'),", visit.VisitStartTime.ToString("yyyy-MM-dd HH:mm:ss"), visit.VisitEndTime.ToString("yyyy-MM-dd HH:mm:ss"), visit.Office.Id, visit.Calendar.Id);
                    }
                    values = values.TrimEnd(',');
                    cmd.CommandText += values;
                    DatabaseHelper.ExecuteNonQueryCommand(cmd);
                }
            }
        }
        public static List<Visit> GetWeeklyVisits(DateTime weekStartDate, int doctorId)
        {
            DateTime weekEndDate = weekStartDate.AddDays(6);

            string query = "SELECT * FROM visits_details WHERE visit_start_time BETWEEN @weekStartDate AND @weekEndDate AND doctor_id = @doctorId AND Patient_Id IS NOT NULL";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@weekStartDate", weekStartDate);
            cmd.Parameters.AddWithValue("@weekEndDate", weekEndDate);
            cmd.Parameters.AddWithValue("@doctorId", doctorId);

            List<Visit> visits = VisitHelper.GetVisitsFromCommand(cmd);

            return visits;
        }

        public static int GetVisitIdForDateAndDoctor(DateTime date, int doctorId)
        {
            SqlCommand cmd = new("Select id from visits_details where visit_start_time = @date AND (doctor_id = @doctorId OR doctor_id is null);");
            cmd.Parameters.AddWithValue("date", date);
            cmd.Parameters.AddWithValue("doctorId", doctorId);

            int VisitId = DatabaseHelper.ExecuteScalarCommand(cmd);

            return VisitId;

        }

        public static void UpdateVisitInDB(Visit visit)
        {
            SqlCommand cmd = new("UPDATE visits SET visit_start_time = @visit_start_time, visit_end_time = @visit_end_time, office_id =@officeId, calendar_id = @calendarId WHERE id = @id");
            cmd.Parameters.AddWithValue("id", visit.Id);
            cmd.Parameters.AddWithValue("officeId", visit.OfficeId);
            cmd.Parameters.AddWithValue("calendarId", visit.CalendarId);
            cmd.Parameters.AddWithValue("visit_start_time", visit.VisitStartTime);
            cmd.Parameters.AddWithValue("visit_end_time", visit.VisitEndTime);
            DatabaseHelper.ExecuteNonQueryCommand(cmd);
        }
        public static int GetDoctorIdByNameAndSurname(string DoctorNameAndSurname)
        {
            SqlCommand cmd = new("Select id from employee_details where CONCAT(first_name,' ',last_name) = @NameAndSurname;");

            cmd.Parameters.AddWithValue("NameAndSurname", DoctorNameAndSurname);

            int VisitId = DatabaseHelper.ExecuteScalarCommand(cmd);

            return VisitId;

        }





    }
}