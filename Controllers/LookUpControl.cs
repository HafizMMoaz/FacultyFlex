using DBS25P023.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Controllers
{
    public class LookUpControl
    {
        private static LookUpControl _instance;
        
        public LookUpControl() { }

        public static LookUpControl Instance {
            get {
                if (_instance == null)
                    _instance = new LookUpControl();
                return _instance;
            }
        }

        public List<Role> GetRoles() {
            List<Role> roles = new List<Role>();
            MySqlConnection con;
            string query = "SELECT * FROM lookup WHERE category = 'UserRoles'";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    roles.Add(new Role
                    {
                        Id = idx,
                        LookUp_Id = Convert.ToInt32(reader["lookup_id"]),
                        Value = reader["value"].ToString()
                    });
                    idx++;
                }
            }

            con.Close();
            return roles;
        }

        public List<Designation> GetDesignations() {
            List<Designation> designations = new List<Designation>();
            MySqlConnection con;
            string query = "SELECT * FROM lookup WHERE category = 'Designations'";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    designations.Add(new Designation
                    {
                        Id = idx,
                        LookUp_Id = Convert.ToInt32(reader["lookup_id"]),
                        Value = reader["value"].ToString()
                    });
                    idx++;
                }
            }

            con.Close();
            return designations;
        }
    }
}
