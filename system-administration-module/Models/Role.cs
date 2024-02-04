using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAdministrationModule.Models
{
    public class Role
    {
        public Role(int? id, string? name)
        {
            Id = id ?? 0;
            Name = name ?? string.Empty;
        }
        public static Role CreateEmpty()
        {
            return new Role(null, null);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string GetName()
        {
            string convertedString = this.Name.Replace("_", " ");
            convertedString = char.ToUpper(convertedString[0]) + convertedString[1..];
            return convertedString;
        }

        public override String ToString() => Name;

    }
}
