using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Models
{
    public class Visit
    {
        public Visit(int id, DateTime visitStartTime, DateTime visitEndTime)
        {
            Id = id;
            VisitStartTime = visitStartTime;
            VisitEndTime = visitEndTime;
        }

        public int Id { get; set; }
        public int OfficeId { get; set; }
        public int CalendarId { get; set; }
        public DateTime VisitStartTime { get; set; }
        public DateTime VisitEndTime { get; set; }
        public Office? Office { get; set; }
        public Calendar? Calendar { get; set; }
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public bool WasBooked { get; set; } = false;
        public bool IsAccepted { get; set; } = false;

        public static List<Visit> GetVisitListFromDataTable(DataTable dt)
        {
            List<Visit> visits = new();

            foreach (DataRow row in dt.Rows)
            {
                int id = (int)row["id"];
                int? patientId = row["patient_id"] == DBNull.Value ? null : (int?)row["patient_id"];
                int? doctorId = row["doctor_id"] == DBNull.Value ? null : (int?)row["doctor_id"];
                int officeId = (int)row["office_id"];
                int calendarId = (int)row["calendar_id"];
                DateTime visitStartTime = (DateTime)row["visit_start_time"];
                DateTime visitEndTime = (DateTime)row["visit_end_time"];

                if (id == 0) { continue; }
                Visit visit = new(id, visitStartTime, visitEndTime)
                {
                    PatientId = patientId,
                    DoctorId = doctorId,
                    OfficeId = officeId,
                    CalendarId = calendarId
                };
                if (doctorId.HasValue || doctorId != null)
                {
                    visit.WasBooked = true;
                }
                visits.Add(visit);
            }
            return visits;
        }
    }
}
