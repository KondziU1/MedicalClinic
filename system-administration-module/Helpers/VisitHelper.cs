using System.Data.SqlClient;
using System.Data;
using SystemAdministrationModule.Services;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Helpers
{
    public static class VisitHelper
    {
        public static List<Visit> GetVisitsFromCommand(SqlCommand cmd)
        {
            DataTable data = DatabaseHelper.ExecuteQueryCommand(cmd);
            List<Visit> Visits = Visit.GetVisitListFromDataTable(data);
            return Visits;
        }
        public static void GenerateVisitsForOffices(Calendar calendar)
        {
            List<Office> offices = OfficeService.GetActiveOffices();
            List<Visit> visits = new();
            foreach (Office office in offices)
            {
                DateTime currentDate = calendar.StartDate;
                DateTime endDate = calendar.EndDate;
                DateTime clinicStartTime = currentDate.AddHours(7);
                DateTime clinicEndTime = currentDate.AddHours(20);
                while (currentDate <= endDate)
                {
                    if (currentDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        DateTime visitStartTime = clinicStartTime;
                        DateTime visitEndTime = visitStartTime.AddMinutes(20);
                        while (visitEndTime <= clinicEndTime)
                        {
                            Visit newVisit = new(0, visitStartTime, visitEndTime);
                            newVisit.Calendar = calendar;
                            newVisit.Office = office;
                            visits.Add(newVisit);
                            visitStartTime = visitEndTime;
                            visitEndTime = visitStartTime.AddMinutes(20);
                            if ((visitStartTime - clinicStartTime).TotalHours % 4 == 0 && visitEndTime <= clinicEndTime)
                            {
                                visitStartTime = visitStartTime.AddMinutes(20);
                                visitEndTime = visitEndTime.AddMinutes(20);
                            }
                        }
                    }

                    currentDate = currentDate.AddDays(1);
                    clinicStartTime = currentDate.AddHours(7);
                    clinicEndTime = currentDate.AddHours(20);
                }
            }
            VisitService.SaveListVistsInDB(visits);
        }
        public static SqlCommand AddStartAndEndDayToCommand(SqlCommand cmd, DateTime date)
        {
            DateTime dateStart = new(date.Year, date.Month, date.Day);
            DateTime dateEnd = dateStart.AddHours(23).AddMinutes(59);
            cmd.Parameters.AddWithValue("dateStart", dateStart);
            cmd.Parameters.AddWithValue("dateEnd", dateEnd);
            return cmd;
        }
    }
}
