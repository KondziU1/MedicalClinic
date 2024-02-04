using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAdministrationModule.Models
{
    public class Patient
    {
        public Patient(int id, string? firstName, string? lastName, string? pesel, bool active)
        {
            Id = id;
            FirstName = firstName ?? "";
            LastName = lastName ?? "";
            Pesel = pesel;
            Active = active;
        }
        public static Patient CreateEmpty()
        {      
            return new Patient(0,null,null,null,true);
        }
        public int Id { get; set; }
        public int Test { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public bool Active { get; set; }

        public static List<Patient> GetPatientListFromDataTable(DataTable dataTable)
        {
            List<Patient> patients = new List<Patient>();

            foreach (DataRow row in dataTable.Rows)
            {
                int id = (int)row["Id"];
                string firstName = row["first_name"].ToString();
                string lastName = row["last_name"].ToString();
                string pesel = row["pesel"].ToString();
                bool active = (bool)row["is_active"];

                Patient patient = new Patient(id, firstName, lastName, pesel, active);
                patients.Add(patient);
            }

            return patients;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
