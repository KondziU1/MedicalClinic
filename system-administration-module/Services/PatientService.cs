using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;
using SystemAdministrationModule.Helpers;
using System.Data.SqlClient;
using System.Collections;
using Microsoft.VisualBasic;

namespace SystemAdministrationModule.Services
{
    public class PatientService
    {

        public static List<Patient> GetPatients()
        {
            string query = $"SELECT * from patients";

            DataTable result = DatabaseHelper.ExecuteQuery(query);
            List<Patient> patients = GetPatientListFromDataTable(result);

            return patients;
        }

        public static List<Specialization> GetSpecializations()
        {
            string query = $"SELECT * from specializations";

            DataTable result = DatabaseHelper.ExecuteQuery(query);
            return Specialization.GetSpecializationsFromDataTable(result);
        }

        private static List<Patient> GetPatientListFromDataTable(DataTable dataTable)
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
        public static Patient GetPatientById(Patient patient)
        {
            string query = $"SELECT * FROM patients WHERE id={patient.Id}";
            DataTable result = DatabaseHelper.ExecuteQuery(query);

            if (result.Rows.Count == 0)
            {
                return null;
            }
            List<Patient> patients = GetPatientListFromDataTable(result);
            return patients[0];

        }
        public static List<Patient> GetPatientByPesel(Patient patient)
        {
            string query = $"SELECT * FROM patients WHERE pesel={patient.Pesel}";
            DataTable result = DatabaseHelper.ExecuteQuery(query);

            if (result.Rows.Count == 0)
            {
                return null;
            }
            List<Patient> patients = GetPatientListFromDataTable(result);
            return patients;

        }
        public static string GetLastPatientID()
        {
            var query = $"SELECT MAX(Id) AS MAX_id FROM patients";
            var result = DatabaseHelper.ExecuteQuery(query);
            var tableRow = result.Rows[0];

            return tableRow["MAX_id"].ToString();
        }

        public static List<Patient> GetPatientsByActive(Patient patient)
        {

            string query = $"SELECT * FROM patients WHERE is_active='{patient.Active}'";
            DataTable result = DatabaseHelper.ExecuteQuery(query);

            List<Patient> patients = GetPatientListFromDataTable(result);

            return patients;
        }

        public static void UpdatePatient(Patient patient)
        //public static List<Patient> UpdatePatient(Patient patient)
        {
            string query = $"UPDATE patients SET first_name='{patient.FirstName}',last_name='{patient.LastName}',pesel='{patient.Pesel}',is_active='{patient.Active}' WHERE Id='{patient.Id}'";
            DatabaseHelper.ExecuteNonQuery(query);

        }

        public static void CreatePatient(Patient patient)
        {

            var query = $"INSERT INTO patients VALUES('{patient.FirstName}','{patient.LastName}','{patient.Pesel}','{patient.Active}')";
            DatabaseHelper.ExecuteNonQuery(query);
        }
        public static bool DeletePatient(Patient patient)
        {
            string query = $"DELETE FROM patients WHERE id = {patient.Id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public static List<Patient> GetPatientsByLatestVisitDate(DateTime date)
        {
            string query = $"SELECT DISTINCT p.* FROM dbo.patients p INNER JOIN dbo.visits_details vd ON p.id = vd.patient_id WHERE CONVERT(varchar, vd.visit_start_time, 23) = '"+date.ToString("yyyy-MM-dd") +"' AND vd.visit_start_time = (SELECT MAX(visit_start_time)   FROM dbo.visits_details  WHERE patient_id = p.id)";
            DataTable result = DatabaseHelper.ExecuteQuery(query);
            return GetPatientListFromDataTable(result);
        }
    }
}
