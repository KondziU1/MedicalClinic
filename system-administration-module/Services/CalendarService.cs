using System.Data.SqlClient;
using System.Data;
using SystemAdministrationModule.Helpers;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Helpers;
using System;
using System.ComponentModel;

namespace SystemAdministrationModule.Services
{
    public class CalendarService
    {

        private static DataTable GetCalendarsData(string where = "")
        {
            string query = "Select * from calendars";
            if (where != "")
                query += $" WHERE {where}";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static List<Calendar> GetCalendars()
        {
            DataTable data = GetCalendarsData();
            List<Calendar> calendars = Calendar.GetCalendarListFromDataTable(data);

            return calendars;
        }
        public static List<Calendar> GetAcceptedCalendars()
        {
            string query = $"SELECT * from calendars where status ='accepted'";
            DataTable result = DatabaseHelper.ExecuteQuery(query);

            return Calendar.GetCalendarListFromDataTable(result);
        }

        public static int CreateCalendar(Calendar calendar)
        {
            SqlCommand command = new("Insert into calendars (name,date_start, date_end, status) VALUES (@name, @start, @end, 'just_created'); SELECT SCOPE_IDENTITY();");
            command.Parameters.AddWithValue("start", calendar.StartDate);
            command.Parameters.AddWithValue("end", calendar.EndDate);
            command.Parameters.AddWithValue("name", calendar.Name);
            return DatabaseHelper.ExecuteScalarCommand(command);
        }
        public static void UpdateCalendar(Calendar calendar)
        {
            SqlCommand command = new("Update calendars SET name = @name,date_start=@start, date_end=@end, status=@status, is_active=@active WHERE id = @id");
            command.Parameters.AddWithValue("start", calendar.StartDate);
            command.Parameters.AddWithValue("end", calendar.EndDate);
            command.Parameters.AddWithValue("name", calendar.Name);
            command.Parameters.AddWithValue("status", calendar.Status);
            command.Parameters.AddWithValue("active", calendar.Active);
            command.Parameters.AddWithValue("id", calendar.Id);
            DatabaseHelper.ExecuteNonQueryCommand(command);
        }
        public static void GenerateCalendarBasedOnOther(Calendar calendar, Calendar baseCalendar)
        {
            int newCalendarId = CreateCalendar(calendar);
            calendar.Id = newCalendarId;
            VisitHelper.GenerateVisitsForOffices(calendar);
            List<Visit> newVisits = VisitService.GetVisits(calendar.Id);
            List<Appointment> oldAppointments = AppointmentService.GetAppointmentsByCalendar(baseCalendar.Id);
            DateTime dateStart = calendar.StartDate;
            DateTime dateStartOld = baseCalendar.StartDate;
            DateTime dateEnd = calendar.EndDate;
            DateTime dateEndOld = baseCalendar.EndDate;

            DateTime dateCurrent = dateStart;
            DateTime dateCurrentOld = dateStartOld;
            int dateStarMonth = dateStart.Month;

            List<Visit> newVisitsForAppointment = new();

            List<int> daysOfMonthNew = new();
            List<int> daysOfMonthOld = new();
            while(dateCurrentOld <= dateEndOld)
            {
                if((dateCurrent.DayOfWeek != DayOfWeek.Sunday) && (dateCurrentOld.DayOfWeek != DayOfWeek.Sunday))
                {
                    List<Visit> visitsDayFromOldCalendar = VisitService.GetVistsForDay(dateCurrentOld);
                    visitsDayFromOldCalendar.ForEach(v =>
                    {
                        if (v.DoctorId != null)
                        {
                            var hourOldVisit = v.VisitStartTime.Hour;
                            var minutesOldVisit = v.VisitStartTime.Minute;
                            var officeId = v.OfficeId;
                            Visit visit = newVisits.First(e =>
                            {
                                var dayOfMonth = e.VisitStartTime.Day;
                                var hourVisit = e.VisitStartTime.Hour;
                                var minutesVisit = e.VisitStartTime.Minute;
                                var officeIdIvist = e.OfficeId;
                                return (hourVisit == hourOldVisit) && (minutesVisit == minutesOldVisit) && (dayOfMonth == dateCurrent.Day) && (officeIdIvist == officeId);
                            });
                            visit.DoctorId = v.DoctorId;
                            if (visit.Id != null)
                            {
                                newVisitsForAppointment.Add(visit);
                            }
                        }
                    });
                    dateCurrent = dateCurrent.AddDays(1);
                    dateCurrentOld = dateCurrentOld.AddDays(1);
                }

                if ((dateCurrent.DayOfWeek != DayOfWeek.Sunday) && (dateCurrentOld.DayOfWeek == DayOfWeek.Sunday))
                {
                    if(dateCurrentOld.Day != dateEndOld.Day)
                    {                  
                        dateCurrentOld = dateCurrentOld.AddDays(1);
                    }
                }
                if ((dateCurrentOld.DayOfWeek != DayOfWeek.Sunday) && (dateCurrent.DayOfWeek == DayOfWeek.Sunday))
                {
                    if (dateCurrent >= dateCurrent.AddDays(-1))
                    {
                        break;
                    }
                    dateCurrent = dateCurrent.AddDays(1);
                }

            }
            AppointmentService.CreateAppointmentsFromVisits(newVisitsForAppointment);        
        }
        public static void DeleteCalendar(Calendar calendar)
        {
            List<Visit> visits = VisitService.GetVisits(calendar.Id);

            SqlCommand appointmentsSqlCommand = new("DELETE appointments where visit_id in(");
            SqlCommand visitsSqlCommand = new("DELETE visits where id in(");
            string appointmentsQuery = "";
            string visitsQuery = "";
            foreach (Visit visit in visits) {
                appointmentsQuery += string.Format("{0},", visit.Id);
                visitsQuery += string.Format("{0},", visit.Id);
            }
            if(appointmentsQuery.Length > 0)
            {
                appointmentsQuery= appointmentsQuery.TrimEnd(',');
                appointmentsQuery += ")";
                appointmentsSqlCommand.CommandText += appointmentsQuery;
                DatabaseHelper.ExecuteNonQueryCommand(appointmentsSqlCommand);
            }
            if (visitsQuery.Length > 0)
            {
                visitsQuery = visitsQuery.TrimEnd(',');
                visitsQuery += ")";
                visitsSqlCommand.CommandText += visitsQuery;
                DatabaseHelper.ExecuteNonQueryCommand(visitsSqlCommand);
            }
            SqlCommand command = new("DELETE calendars where id = @id");
            command.Parameters.AddWithValue("id", calendar.Id);
            DatabaseHelper.ExecuteNonQueryCommand(command);
        }
        public static bool IsCalendarFullyAccepted(int calendarId)
        {
            List<Appointment> appointments = AppointmentService.GetAppointmentsByCalendar2(calendarId);
            var isAccepted = appointments.All(c => c.IsAccepted);
            return isAccepted;
        }

        //public static void ConfirmCalendar(int doctor_id, Calendar calendar)
        //{
        //    var appointments = AppointmentService.GetAppointmentsByCalendar(calendar.Id).Where(a => a.DoctorId == doctor_id).ToList();
        //    appointments.ForEach(appointment =>
        //    {
        //        appointment.IsAccepted = true;
        //        AppointmentService.UpdateAppointment(appointment);
        //    });
        //    var isAccepted = CalendarService.IsCalendarFullyAccepted(calendar.Id);
        //    calendar.Status = isAccepted ? "accepted" : "partially_accepted";
        //    UpdateCalendar(calendar);
        //}
        public static void ConfirmCalendar(List<Appointment> appointments, Calendar calendar)
        {
            appointments.ForEach(appointment =>
            {
                appointment.IsAccepted = true;
                AppointmentService.UpdateAppointment(appointment);
            });
            var isAccepted = CalendarService.IsCalendarFullyAccepted(calendar.Id);
            calendar.Status = isAccepted ? "accepted" : "partially_accepted";
            UpdateCalendar(calendar);
        }

    }
}
