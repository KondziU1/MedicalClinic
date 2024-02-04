using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SystemAdministrationModule.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateFields(string pesel, string sex, string email, string phone, string date)
        {
            bool isValid = true;
            string errorMessage = "";

            if (pesel.Length != 11 || !pesel.All(char.IsDigit))
            {
                errorMessage += "PESEL must have 11 digits.\n";
                isValid = false;
            }
            else
            {
                bool isMale = (int.Parse(pesel.Substring(9, 1)) % 2) != 0;
                if (sex != null && ((sex.ToLower() == "m" && !isMale) || (sex.ToLower() == "f" && isMale)))
                {
                    errorMessage += "Invalid PESEL with sex field\n";
                    isValid = false;
                }

                int year = int.Parse(pesel.Substring(0, 2));
                int month = int.Parse(pesel.Substring(2, 2));
                int day = int.Parse(pesel.Substring(4, 2));

                int century = 0;
                switch (month)
                {
                    case int m when m >= 81 && m <= 92:
                        century = 1800;
                        break;
                    case int m when m >= 1 && m <= 12:
                        century = 1900;
                        break;
                    case int m when m >= 21 && m <= 32:
                        century = 2000;
                        break;
                    case int m when m >= 41 && m <= 52:
                        century = 2100;
                        break;
                    case int m when m >= 61 && m <= 72:
                        century = 2200;
                        break;
                }

                month = month % 20;

                try
                {
                    DateTime birthDate = new DateTime(century + year, month, day);
                    if(birthDate.ToShortDateString() != date)
                    {
                        errorMessage += "Different PESEL date of birth and filed date of birth\n";
                        isValid = false;
                    }
                }
                catch (Exception)
                {
                    errorMessage += "Invalid PESEL date of birth\n";
                    isValid = false;
                }
            }

            if (!email.Contains("@"))
            {
                errorMessage += "Email must include @.\n";
                isValid = false;
            }
            else
            {
                string[] emailParts = email.Split('@');
                string domain = emailParts[1];
                string[] domainParts = domain.Split('.');
                string tld = domainParts[domainParts.Length - 1];
                if (tld.Length < 2 || tld.Length > 6)
                {
                    errorMessage += "Invalid email top-level domain.\n";
                    isValid = false;
                }

                string recipient = emailParts[0];
                if (recipient.Length == 0)
                {
                    errorMessage += "Invalid email recipient's name.\n";
                    isValid = false;
                }
            }

            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regex.IsMatch(email))
            {
                errorMessage += "Invalid email syntax.\n";
                isValid = false;
            }


            if (phone.Length != 9)
            {
                errorMessage += "The phone number must have 9 digits.\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Field validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        public static bool ValidateEmail(string email)
        {
            bool isValid = true;
            string errorMessage = "";

            if (!email.Contains("@"))
            {
                errorMessage += "Email must include @.\n";
                isValid = false;
            }
            else
            {
                string[] emailParts = email.Split('@');
                string domain = emailParts[1];
                string[] domainParts = domain.Split('.');
                string tld = domainParts[domainParts.Length - 1];
                if (tld.Length < 2 || tld.Length > 6)
                {
                    errorMessage += "Invalid email top-level domain.\n";
                    isValid = false;
                }

                string recipient = emailParts[0];
                if (recipient.Length == 0)
                {
                    errorMessage += "Invalid email recipient's name.\n";
                    isValid = false;
                }
            }

            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regex.IsMatch(email))
            {
                errorMessage += "Invalid email syntax.\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Field validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        public static bool ValidatePassword(string password)
        {
            bool isValid = true;
            string errorMessage = "";

            if (password.Length < 8 || password.Length > 15)
            {
                errorMessage += "Password must be between 8 and 15 characters.\n";
                isValid = false;
            }

            if (!password.Any(c => char.IsLower(c)))
            {
                errorMessage += "Password must contain lowercase letters.\n";
                isValid = false;
            }

            if (!password.Any(c => char.IsUpper(c)))
            {
                errorMessage += "Password must contain uppercase letters.\n";
                isValid = false;
            }

            if (!password.Any(c => char.IsDigit(c)))
            {
                errorMessage += "Password must contain digits.\n";
                isValid = false;
            }

            if (!password.Any(c => c == '-' || c == '_' || c == '!' || c == '#' || c == '$' || c == '*'))
            {
                errorMessage += "Password must contain at least one of the following special characters: -, _, !, #, $, *.\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Field validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }
        public static bool ValidatePeselPatient(string pesel)
        {
            bool isValid = true;
            string errorMessage = "";
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
            int sum = 0;

            if (pesel.Length != 11 || !pesel.All(char.IsDigit))
            {
                errorMessage += "PESEL must have 11 digits.\n";
                isValid = false;
            }
            else
            {
                for (int i = 0; i < 11; i++)
                {
                    int digit = int.Parse(pesel[i].ToString());
                    sum += digit * weights[i];
                }
                if (sum % 10 != 0)
                {
                    isValid = false;
                    errorMessage += "Invalid PESEL.";
                }
            }
            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Field validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
    }
}
