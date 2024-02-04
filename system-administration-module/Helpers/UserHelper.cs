using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Helpers
{
    public static class UserHelper
    {
        public static SqlCommand AddParametrsToSqlCommand(SqlCommand cmd, User user)
        {
            cmd.Parameters.AddWithValue("@login", user.Login);
            cmd.Parameters.AddWithValue("@password", user.Password != null ? user.Password : DBNull.Value);
            cmd.Parameters.AddWithValue("@email", user.Email != null ? user.Email : DBNull.Value);
            cmd.Parameters.AddWithValue("@roleId", user.Role.Id);
            cmd.Parameters.AddWithValue("@active", user.Active);

            return cmd;
        }
        public static string GenerateToken(int size = 5)
        {
            const string allowedChars = "1234567890";
            byte[] randomNumber = new byte[size];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                StringBuilder result = new StringBuilder(size);
                foreach (byte b in randomNumber)
                {
                    result.Append(allowedChars[b % allowedChars.Length]);
                }
                return result.ToString();
            }
        }
    }
}
