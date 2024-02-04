using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAdministrationModule.Helpers
{
    public static class AuthHelper
    {
        public static string GenerateLogin()
        {
            string login = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 8)
            .Select(s => s[new Random().Next(s.Length)]).ToArray());

            return login;
        }

        public static string GeneratePassword()
        {
            string password = "";

            int passwordLength = new Random().Next(8, 16);

            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            string specials = "-_!#$*";

            password += GetRandomChar(lowercase);
            password += GetRandomChar(uppercase);
            password += GetRandomChar(digits);
            password += GetRandomChar(specials);

            for (int i = 4; i < passwordLength; i++)
            {
                string allChars = lowercase + uppercase + digits + specials;
                password += GetRandomChar(allChars);
            }

            password = new string(password.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());

            return password;
        }

        private static char GetRandomChar(string chars)
        {
            return chars[new Random().Next(chars.Length)];
        }
        
    }
}
