
using System.Data;
using System.Data.SqlClient;

namespace SystemAdministrationModule.Models
{
    public class Office
    {

        public Office(int id, string number, Specialization ? specialization, string type, bool active)
        {
            Id = id;
            Number = number;
            Specialization = specialization ?? Specialization.CreateEmpty();
            Type = type;
            Active = active;
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public Specialization Specialization { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }

        public override String ToString() => "Office number: " + Number;

        public static SqlCommand AddParametrsToSqlCommand(SqlCommand cmd, Office office)
        {
            cmd.Parameters.AddWithValue("number", office.Number);
            cmd.Parameters.AddWithValue("specializationId", office.Specialization.Id != null ? office.Specialization.Id : DBNull.Value) ;
            cmd.Parameters.AddWithValue("type", office.Type);
            cmd.Parameters.AddWithValue("active", office.Active);

            return cmd;
        }
        public static List<Office> GetOfficeListFromDataTable(DataTable dataTable)
        {
            var offices = new List<Office>();

            foreach (DataRow row in dataTable.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string number = row["number"].ToString();
                int? specializationId = row["specialization_id"] == DBNull.Value ? null : Convert.ToInt32(row["specialization_id"]);
                string type = row["type"].ToString();
                string specializationName = row["name"].ToString();
                bool active = Convert.ToBoolean(row["is_active"]);
                Specialization specialization = specializationId != 0 ? new Specialization(specializationId, specializationName) : Specialization.CreateEmpty();
                var office = new Office(id, number, specialization, type, active);
                offices.Add(office);
            }

            return offices;
        }
    }
}
