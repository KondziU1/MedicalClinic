using FluentEmail.Core;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SystemAdministrationModule.Helpers
{
    public static class AppointmentHelper
    {
        public static List<Appointment> GetAppointmentListFromDataTable(DataTable data)
        {
            List<Appointment> appointments = new();
            foreach (DataRow row in data.Rows)
            {
                int id = (int)row["id"];
                int visitId = (int)row["visit_id"];
                bool isAccepted = (bool)row["is_accepted"];
                int doctorId = (int)row["doctor_id"];
                string doctorSpecialization = (string)row["specializations"];
                int? patientId = row["patient_id"] == DBNull.Value ? null : (int)row["patient_id"];
                Appointment appointment = new (id, visitId, doctorId, patientId, isAccepted, doctorSpecialization);

                appointment.Doctor.Id = doctorId;
                appointment.Doctor.FirstName = (string)row["doctor_first_name"];
                appointment.Doctor.LastName = (string)row["doctor_last_name"];



                if (patientId != null && patientId != 0)
                {
                    appointment.Patient.Id = (int)patientId;
                    appointment.Patient.FirstName = (string)row["patient_first_name"];
                    appointment.Patient.LastName = (string)row["patient_last_name"];
                    appointment.Patient.Pesel = (string)row["pesel_patients"];
                }
                DateTime startTime = (DateTime)row["visit_start_time"];
                DateTime endTime = (DateTime)row["visit_end_time"];
                appointment.Visit = new(visitId, startTime, endTime);
                appointment.Visit.OfficeId = (int)(row["office_id"]);
                appointment.Visit.CalendarId = (int)(row["calendar_id"]);

                appointments.Add(appointment);
            }
            return appointments;
        }

    }
}
