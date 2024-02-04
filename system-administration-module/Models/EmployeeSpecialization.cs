using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAdministrationModule.Models;

namespace SystemAdministrationModule.Models
{
    internal class EmployeeSpecialization
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int SpecializationId { get; set; }

        //public Employee Employee { get; set; }
        //public Specialization Specialization { get; set; }
    }
}
