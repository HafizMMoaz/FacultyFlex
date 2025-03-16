using DBS25P023.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Controllers
{
    public class FacultyControl
    {
        private static FacultyControl _instance;

        private FacultyControl() { }

        public static FacultyControl Instance {
            get {
                if (_instance == null)
                    _instance = new FacultyControl();
                return _instance;
            }
        }

        public bool RegsiterFacultyUser(Faculty faculty) {
            string query = $"INSERT INTO users(username, email, password_hash, role_id) VALUES ('{faculty.Username}','{faculty.Email}','{faculty.Password}',{faculty.Role})";
            if(DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }
        public bool SearchFacultyUser(Faculty faculty) {
            string query = $"SELECT COUNT(*) FROM users WHERE email = '{faculty.Email}' OR username = '{faculty.Username}'";
            int count = DB.Instance.Scalar(query);
            return count > 0;
        }
        public bool UpdateFacultyUser(Faculty faculty) {
            string query = $"UPDATE users SET username = '{faculty.Username}', email = '{faculty.Email}', password_hash = '{faculty.Password}', role_id = {faculty.Role} WHERE user_id = {faculty.User_id}";
            if(DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }
        public List<Faculty> GetFaculty(string search) {
            List<Faculty> facultyusers = new List<Faculty>();
            MySqlConnection con;

            string query;
            if (string.IsNullOrEmpty(search))
                query = "SELECT * FROM users u JOIN lookup l ON u.role_id = l.lookup_id";
            else
                query = $"SELECT * FROM users u JOIN lookup l ON u.role_id = l.lookup_id WHERE u.username LIKE '%{search}%' OR u.email LIKE '%{search}%' OR l.value LIKE '%{search}%'";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                    while (reader.Read()) {
                        facultyusers.Add(new Faculty
                        {
                            User_id = Convert.ToInt32(reader["user_id"]),
                            Username = reader["username"].ToString(),
                            Email = reader["email"].ToString(),
                            Role = Convert.ToInt32(reader["role_id"]),
                            RoleVal = reader["value"].ToString()
                        });
                    }
                }

            con.Close();
            return facultyusers;
        }
    }
}
