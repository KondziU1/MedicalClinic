using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAdministrationModule.Models
{
    public class Specialization
    {
        public Specialization(int? id, string? name)
        {
            Id = id;
            Name = name;
        }
        public int? Id { get; set; }
        public string? Name { get; set; }

        public override String ToString() => Name;

        public static Specialization CreateEmpty()
        {
            return new Specialization(null, null);
        }

        public static List<Specialization> GetSpecializationsFromDataTable(DataTable result)
        {
            List<Specialization> specializations = new();

            foreach (DataRow row in result.Rows)
            {
                int id = (int)row["id"];
                string name = (string)row["name"];
                if (id == 0 || name == null)
                {
                    continue;
                }
                var specialization = new Specialization(id, name);
                specializations.Add(specialization);
            }
            return specializations;
        }

    }
}
