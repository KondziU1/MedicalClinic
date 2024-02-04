using System.Data;
using System.Globalization;

namespace SystemAdministrationModule.Models
{
    public class Calendar
    {
        public Calendar(int id,string name, DateTime startDate, DateTime endDate, string status, bool active)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            Name = name;
            Active = active;
        }

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public override string ToString() => $"{Name}";
        public static List<Calendar> GetCalendarListFromDataTable(DataTable dt)
        {
            List<Calendar> calendars = new();

            foreach (DataRow row in dt.Rows)
            {
                int id = (int)row["id"];
                DateTime startDate = (DateTime)row["date_start"];
                DateTime endDate = (DateTime)row["date_end"];
                bool active = (bool)row["is_active"];
                string status = (string)row["status"];
                string name = (string)row["name"];
                if (startDate == null || endDate == null ) { continue; }
                Calendar calendar = new(id, name, startDate, endDate, status, active);
                calendars.Add(calendar);
            }
            return calendars;
        }
    }
}
