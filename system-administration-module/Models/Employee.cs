using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SystemAdministrationModule.Models
{
    public class Employee
    {
        public Employee(int id, string firstName, string lastName, string pesel, DateTime dateOfBirth, bool active, Role role, string? correspondenceAddress, string? email, string? phoneNumber, List<Specialization> specializations, string? sex, User? user)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
            DateOfBirth = dateOfBirth;
            Active = active;
            Role = role;
            Email = email ?? string.Empty;
            CorrespondenceAddress = correspondenceAddress ?? string.Empty;
            PhoneNumber = phoneNumber ?? string.Empty;
            Sex = sex ?? string.Empty;
            Specializations = specializations;
            User = user ?? User.CreateEmpty();
        }
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CorrespondenceAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Sex { get; set; }
        public bool Active { get; set; }
        public Role Role { get; set; }
        public User User { get; set; }
        public List<Specialization> Specializations { get; set; }
        public string FullName() => this.FirstName + " " + this.LastName;

        public override String ToString() => FirstName + " " + LastName;
        public static Employee CreateEmpty()
        {
            return new Employee(0, "", "", "", new DateTime(), false, Role.CreateEmpty(), null, null, null, new List<Specialization>(), null, User.CreateEmpty());
        }
        public static SqlCommand AddParametrsToSqlCommand(SqlCommand cmd, Employee employee)
        {
            cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@lastName", employee.LastName);
            cmd.Parameters.AddWithValue("@pesel", employee.Pesel);
            cmd.Parameters.AddWithValue("@dob", employee.DateOfBirth);
            cmd.Parameters.AddWithValue("@correspondenceAddress", employee.CorrespondenceAddress != null ? employee.CorrespondenceAddress : DBNull.Value);
            cmd.Parameters.AddWithValue("@email", employee.Email != null ? employee.Email : DBNull.Value);
            cmd.Parameters.AddWithValue("@phoneNumber", employee.PhoneNumber != null ? employee.PhoneNumber : DBNull.Value);
            cmd.Parameters.AddWithValue("@sex", employee.Sex != null ? employee.Sex : DBNull.Value);
            cmd.Parameters.AddWithValue("@roleId", employee.Role.Id);
            cmd.Parameters.AddWithValue("@active", employee.Active);

            return cmd;
        }
    }
}
