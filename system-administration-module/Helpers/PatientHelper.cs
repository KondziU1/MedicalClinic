using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Helpers
{
    public static class PatientHelper
    {
        public static SqlCommand AddParametrsToSqlCommand(SqlCommand cmd, Patient patient)
        {
            cmd.Parameters.AddWithValue("@firstName", patient.FirstName);
            cmd.Parameters.AddWithValue("@lastName", patient.LastName);
            cmd.Parameters.AddWithValue("@pesel", patient.Pesel);
            cmd.Parameters.AddWithValue("@active", patient.Active);

            return cmd;
        }
        public static string GenerateToken(int size = 5)
        {
            const string allowedChars = "1234567890";
            var randomNumber = new byte[size];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                var result = new StringBuilder(size);
                foreach (var b in randomNumber)
                {
                    result.Append(allowedChars[b % allowedChars.Length]);
                }
                return result.ToString();
            }
        }
    }
}

