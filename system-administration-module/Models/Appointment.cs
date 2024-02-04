using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Models
{
    public class Appointment
    {
        public Appointment(int id, int visitId, int doctorId, int? patientId, bool isAccepted, string doctorSpecialization)
        {
            Id = id;
            VisitId = visitId;
            IsAccepted = isAccepted;
            DoctorId = doctorId;
            PatientId = patientId ?? null;
            VisitId = visitId;
            DoctorSpecialization = doctorSpecialization;
        }

        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int? PatientId { get; set; }
        public int VisitId { get; set; }
        public string DoctorSpecialization { get; }
        public bool IsAccepted { get; set; }

        public Employee? Doctor { get; set; } = Employee.CreateEmpty();
        public Patient? Patient { get; set; } = Patient.CreateEmpty();
        public Visit? Visit { get; set; }

    }
}
