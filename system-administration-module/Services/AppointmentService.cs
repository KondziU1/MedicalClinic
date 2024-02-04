using System.Data.SqlClient;
using System.Data;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Markup;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace SystemAdministrationModule.Services
{
    public class AppointmentService
    {
        public static DataTable GetVisitsData(string where = "")
        {
            string query = "SELECT * FROM appointments_details";
            if (!string.IsNullOrEmpty(where))
            {
                query += $" WHERE {where}";
                query += " AND patient_first_name IS NOT NULL AND patient_last_name IS NOT NULL AND pesel_patients IS NOT NULL";
            }
            else
            {
                query += " WHERE patient_first_name IS NOT NULL AND patient_last_name IS NOT NULL AND pesel_patients IS NOT NULL";
            }
            return DatabaseHelper.ExecuteQuery(query);
        }
        private static DataTable GetVisitsData2(string where = "")
        {
            string query = "Select * from appointments_details";
            if (where != "")
                query += $" WHERE {where}";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static DataTable GetAppointmentsbyID(int Id)
        {
            string query = "SELECT * FROM appointments where id="+Id;
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static List<Appointment> GetAppointments()
        {
            DataTable data = GetVisitsData();
            List<Appointment> Appointments = AppointmentHelper.GetAppointmentListFromDataTable(data);

            return Appointments;
        }

        public static List<Appointment> GetAppointmentsByCalendar(int calendarId)
        {
            DataTable data = GetVisitsData($"calendar_id = {calendarId}");
            List<Appointment> Appointments = AppointmentHelper.GetAppointmentListFromDataTable(data);

            return Appointments;
        }
        public static List<Appointment> GetAppointmentsByCalendar2(int calendarId)
        {
            DataTable data = GetVisitsData2($"calendar_id = {calendarId}");
            List<Appointment> Appointments = AppointmentHelper.GetAppointmentListFromDataTable(data);

            return Appointments;
        }
        public static List<Appointment> GetAppointmentsForPatient(int patientId)
        {
            DataTable data = GetVisitsData($"patient_id = {patientId}");
            List<Appointment> Appointments = AppointmentHelper.GetAppointmentListFromDataTable(data);

            return Appointments;
        }

        public static List<Appointment> GetAppointmentsByVisitID(int visitId)
        {
            DataTable data = GetVisitsData($"visit_id = {visitId}");
            List<Appointment> Appointments = AppointmentHelper.GetAppointmentListFromDataTable(data);

            return Appointments;
        }

        public static void CreateAppointmentsFromVisits(List<Visit> visits)
        {

            const int batchSize = 1000;

            if (visits.Count > 0)
            {
                for (int i = 0; i < visits.Count; i += batchSize)
                {
                    int counting = 0;
                    List<Visit> batch = visits.Skip(i).Take(batchSize).ToList();
                    SqlCommand cmd = new("INSERT INTO appointments (doctor_id, patient_id, visit_id, is_accepted) VALUES ");
                    string values = "";
                    foreach (Visit visit in batch)
                    {
                        Visit text = visit;
                        if ((bool)visit.WasBooked && (visit.DoctorId == null))
                        {
                            SqlCommand commandWithoutDoctor = new("DELETE from appointments where visit_id = @visitId;");
                            commandWithoutDoctor.Parameters.AddWithValue("visitId", visit.Id);
                            DatabaseHelper.ExecuteNonQueryCommand(commandWithoutDoctor);
                        }
                        else if (!(bool)visit.WasBooked && visit.DoctorId != null)
                        {
                            values += string.Format("({0}, {1}, {2}, '{3}'),", visit.DoctorId, visit.PatientId.HasValue ? visit.PatientId : $"@NULL{counting}", visit.Id, visit.IsAccepted);
                            if (!visit.PatientId.HasValue) { counting++; };
                        }
                    }
                    if (values.Length > 0)
                    {
                        values = values.TrimEnd(',');
                        cmd.CommandText += values;
                        char myChar = '@';
                        for (int j = 0; j <= counting; j++)
                        {
                            cmd.Parameters.AddWithValue($"NULL{j}", DBNull.Value);
                        }
                        DatabaseHelper.ExecuteNonQueryCommand(cmd);
                    }
                }
            }
        }
        public static void UpdateAppointment(Appointment appointment)
        {
            string query = @"UPDATE dbo.appointments
                 SET doctor_id = @DoctorId, patient_id = @PatientId, visit_id = @VisitId, is_accepted = @IsAccepted
                 WHERE id = @Id";

            using SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Id", appointment.Id);
            command.Parameters.AddWithValue("@DoctorId", appointment.DoctorId);
            command.Parameters.AddWithValue("@PatientId", appointment.PatientId == null ? DBNull.Value : appointment.PatientId);
            command.Parameters.AddWithValue("@VisitId", appointment.VisitId);
            command.Parameters.AddWithValue("@IsAccepted", appointment.IsAccepted);
            DatabaseHelper.ExecuteQueryCommand(command);

        }

        public static string GetCommentByAppointmentId(int appointmentId)
        {
            string query = "SELECT comment FROM dbo.comments WHERE appointment_id = @appointment_id";
            string comment = "";

            using (SqlCommand command = new SqlCommand(query))
            {
                command.Parameters.AddWithValue("@appointment_id", appointmentId);
                DataTable dt = DatabaseHelper.ExecuteQueryCommand(command);

                if (dt.Rows.Count > 0)
                {
                    comment = dt.Rows[0]["comment"].ToString();
                }
            }

            return comment;
        }

        public static void AddComment(int appointmentId, string comment)
        {
            string query = "INSERT INTO comments (appointment_id, comment) VALUES (@appointment_id, @comment)";

            using SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@appointment_id", appointmentId);
            command.Parameters.AddWithValue("@comment", comment);
            DatabaseHelper.ExecuteQueryCommand(command);

        }

        public static void UpdateComment(int appointmentId, string comment)
        {
            string query = "UPDATE comments SET comment = @comment WHERE appointment_id = @appointment_id";

            using SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@appointment_id", appointmentId);
            command.Parameters.AddWithValue("@comment", comment);
            DatabaseHelper.ExecuteQueryCommand(command);

        }
        public static void AddAppointment(Appointment appointment)
        {

            string query = @"INSERT INTO appointments (doctor_id, patient_id, visit_id, is_accepted) 
                                 VALUES (@DoctorId, @PatientId, @VisitId, @IsAccepted)";
            using SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@DoctorId", appointment.DoctorId);
            command.Parameters.AddWithValue("@PatientId", appointment.PatientId == null ? DBNull.Value : appointment.PatientId);
            command.Parameters.AddWithValue("@VisitId", appointment.VisitId);
            command.Parameters.AddWithValue("@IsAccepted", appointment.IsAccepted);
            DatabaseHelper.ExecuteQueryCommand(command);

        }

        public static void DeleteAppointment(Appointment appointment)
        {
                string query = @"DELETE FROM appointments
                                    WHERE id = @id";

                using SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@id", appointment.Id);
                DatabaseHelper.ExecuteQueryCommand(command);
        }

        //public static void CreateAppointmentsFromVisits(List<Visit> visits)
        //{
        //    const int batchSize = 1000;
        //    if (visits.Count > 0)
        //    {
        //        for (int i = 0; i < visits.Count; i += batchSize)
        //        {
        //            List<Visit> batch = visits.Skip(i).Take(batchSize).ToList();
        //            SqlCommand cmdWithPatients = new("INSERT INTO appointments (doctor_id, patient_id, visit_id, is_accepted) VALUES ");
        //            SqlCommand cmdWithoutPatients = new("INSERT INTO appointments (doctor_id, visit_id, is_accepted) VALUES ");
        //            string valuesWithPatients = "";
        //            string valuesWithoutPatients = "";
        //            foreach (Visit visit in batch)
        //            {
        //                if (visit.DoctorId != null)
        //                {
        //                    if (visit.PatientId != null)
        //                    {
        //                        valuesWithPatients += string.Format("('{0}', '{1}', '{2}', '{3}'),", visit.DoctorId, visit.PatientId, visit.Id, visit.IsAccepted);
        //                    }
        //                    else
        //                    {
        //                        valuesWithoutPatients += string.Format("('{0}', '{1}', '{2}'),", visit.DoctorId, visit.Id, visit.IsAccepted);
        //                    }


        public static string GetLastAppointmentID()
        {
            var query = $"SELECT MAX(Id) AS MAX_id FROM appointments_details";
            var result = DatabaseHelper.ExecuteQuery(query);
            var tableRow = result.Rows[0];

            return tableRow["MAX_id"].ToString();
        }

        public static void CreateAppointment(Appointment appointment, bool NullPatient)
        {
            var query = $"";

            if (NullPatient == false)
            {
                query += $"INSERT INTO appointments (doctor_id, patient_id, visit_id, is_accepted) VALUES ('{appointment.DoctorId}', '{appointment.PatientId}', '{appointment.VisitId}', '{appointment.IsAccepted}');";
            }
            else
            {
                query += $"INSERT INTO appointments (doctor_id, visit_id, is_accepted) VALUES ('{appointment.DoctorId}', '{appointment.VisitId}', '{appointment.IsAccepted}');";
            }

            DatabaseHelper.ExecuteNonQuery(query);
        }

        public static bool UpdateAppointment(Appointment appointment, int visitId)
        {
            string query = "UPDATE appointments SET visit_id = @visitId, patient_id = @patientId WHERE id = @id";

            using SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@visitId", visitId);
            command.Parameters.AddWithValue("@id", appointment.Id);
            command.Parameters.AddWithValue("@patientId", appointment.PatientId);

            return DatabaseHelper.ExecuteNonQueryCommand(command);
        }

        public static int GetOfficeByAppointment(int appointmentId)
        {
            SqlCommand command = new("Select number from appointments_details where id = @id");
            command.Parameters.AddWithValue("@id", appointmentId);

            return DatabaseHelper.ExecuteScalarCommand(command);
        }

        public static bool DeleteAppointment(int appointmentId)
        {
            string query = "DELETE FROM Appointments WHERE Id = @id";

            using SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@id", appointmentId);

            return DatabaseHelper.ExecuteNonQueryCommand(command);
        }

        public static bool DeleteAppointmentPatientId(int appointmentId)
        {
            string query = "UPDATE Appointments SET patient_id = NULL WHERE Id = @id";

            using SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@id", appointmentId);

            return DatabaseHelper.ExecuteNonQueryCommand(command);
        }


        public static bool DeleteFreeAppointmentByVisit(int visitId)
        {
            string query = "DELETE FROM Appointments WHERE visit_id = @id AND patient_id is NULL";

            using SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@id", visitId);

            return DatabaseHelper.ExecuteNonQueryCommand(command);
        }

        public static bool DeleteOldAppointment()
        {
            string query = "DELETE FROM appointments WHERE visit_id IN (SELECT id FROM visits WHERE visit_start_time < GETDATE())";

            using SqlCommand command = new SqlCommand(query);

            return DatabaseHelper.ExecuteNonQueryCommand(command);
        }

        public static List<Appointment> GetVisitDates(DateTime date)
        {
            string query = $"SELECT * FROM appointments_details a WHERE CONVERT(date, a.visit_start_time) = '{date.ToString("yyyy-MM-dd")}'";
            DataTable result = DatabaseHelper.ExecuteQuery(query);
            return AppointmentHelper.GetAppointmentListFromDataTable(result);
        }

        public static void GenerateConfirmationPDF(Appointment appointment)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki PDF|*.pdf";
            saveFileDialog.Title = "Wybierz miejsce zapisu pliku PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;

                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont headerFont = new XFont("Calibri", 18, XFontStyle.Bold);
                XFont sectionFont = new XFont("Calibri", 13, XFontStyle.Bold);
                XFont contentFont = new XFont("Calibri", 12, XFontStyle.Regular);
                XFont footerFont = new XFont("Calibri", 8, XFontStyle.Regular);

                XColor darkColor = XColor.FromArgb(73, 80, 87);
                XSolidBrush solidBrush = new XSolidBrush(darkColor);

                XPoint startPoint = new XPoint(0, 0);
                XPoint endPoint = new XPoint(page.Width, 0);
                XPen linePen = new XPen(darkColor, 180);
                gfx.DrawLine(linePen, startPoint, endPoint);

                string logoPath = "../../../Assets/Logo.png";
                if (File.Exists(logoPath))
                {
                    XImage logoImage = XImage.FromFile(logoPath);
                    double logoWidth = 100;
                    double logoHeight = 60;
                    double logoX = page.Width - logoWidth - 40;
                    double logoY = 10;
                    gfx.DrawImage(logoImage, logoX, logoY, logoWidth, logoHeight);
                }

                XRect backgroundRect = new XRect(0, 80, page.Width, page.Height);
                XColor backgroundColor = XColors.LightGray;
                gfx.DrawRectangle(new XSolidBrush(backgroundColor), backgroundRect);

                gfx.DrawString("Potwierdzenie wizyty", headerFont, solidBrush, new XRect(0, 100, page.Width, page.Height), XStringFormats.TopCenter);
                int verticalOffset = 160;

                gfx.DrawString("Dane pacjenta", sectionFont, solidBrush, new XRect(30, verticalOffset, page.Width, page.Height), XStringFormats.TopLeft);
                verticalOffset += 25;
                gfx.DrawString("Imię: " + appointment.Patient.FirstName, contentFont, solidBrush, new XRect(35, verticalOffset, page.Width, page.Height), XStringFormats.TopLeft);
                verticalOffset += 20;
                gfx.DrawString("Nazwisko: " + appointment.Patient.LastName, contentFont, solidBrush, new XRect(35, verticalOffset, page.Width, page.Height), XStringFormats.TopLeft);
                verticalOffset += 40;

                gfx.DrawString("Dane lekarza", sectionFont, solidBrush, new XRect(30, verticalOffset, page.Width, page.Height), XStringFormats.TopLeft);
                verticalOffset += 25;
                gfx.DrawString("Imię: " + appointment.Doctor.FirstName, contentFont, solidBrush, new XRect(35, verticalOffset, page.Width, page.Height), XStringFormats.TopLeft);
                verticalOffset += 20;
                gfx.DrawString("Nazwisko: " + appointment.Doctor.LastName, contentFont, solidBrush, new XRect(35, verticalOffset, page.Width, page.Height), XStringFormats.TopLeft);
                verticalOffset += 20;
                gfx.DrawString("Specjalizacja: " + appointment.DoctorSpecialization, contentFont, solidBrush, new XRect(35, verticalOffset, page.Width, page.Height), XStringFormats.TopLeft);
                verticalOffset += 40;

                gfx.DrawString("Szczegóły wizyty: ", sectionFont, solidBrush, new XRect(30, verticalOffset, page.Width, page.Height), XStringFormats.TopLeft);
                verticalOffset += 25;
                gfx.DrawString("Data wizyty: " + appointment.Visit.VisitStartTime.ToString("dd.MM.yyyy"), contentFont, solidBrush, new XRect(35, verticalOffset, page.Width, page.Height), XStringFormats.TopLeft);
                verticalOffset += 20;
                gfx.DrawString("Godzina wizyty: " + appointment.Visit.VisitStartTime.ToString("HH:mm"), contentFont, solidBrush, new XRect(35, verticalOffset, page.Width, page.Height), XStringFormats.TopLeft);
                verticalOffset += 20;
                string officeNumber = AppointmentService.GetOfficeByAppointment(appointment.Id).ToString();
                gfx.DrawString("Numer gabinetu: " + officeNumber, contentFont, solidBrush, new XRect(35, verticalOffset, page.Width, page.Height), XStringFormats.TopLeft);

                XSize textSize = gfx.MeasureString("Zapraszamy ponownie", contentFont);
                double footerX = page.Width - textSize.Width-20;
                double footerY = page.Height - 30;
                gfx.DrawString("Zapraszamy ponownie", contentFont, solidBrush, new XPoint(footerX, footerY));

                startPoint = new XPoint(0, page.Height - 20);
                endPoint = new XPoint(page.Width, page.Height - 20);
                linePen = new XPen(darkColor, 0.7);
                gfx.DrawLine(linePen, startPoint, endPoint);

                DateTime currentDate = DateTime.Now;
                string footerText = "Wygenerowano: " + currentDate.ToString("dd.MM.yyyy HH:mm");
                textSize = gfx.MeasureString(footerText, footerFont);
                footerX = (page.Width - textSize.Width) / 2;
                footerY = page.Height - 10;
                gfx.DrawString(footerText, footerFont, solidBrush, new XPoint(footerX, footerY));

                document.Save(outputPath);
            }

        }
    }
    }

