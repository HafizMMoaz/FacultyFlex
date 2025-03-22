using System;
using MySql.Data.MySqlClient;
using DBS25P023.Models;

namespace DBS25P023.Controllers {
    public class AuthControl {
        private static AuthControl _instance;
        
        private AuthControl() { }

        public static AuthControl Instance {
            get {
                if (_instance == null) {
                    _instance = new AuthControl();
                }
                return _instance;
            }
        }

        public bool Login(string username, string password) {
            MySqlConnection con;
            string query = $@"
                SELECT U.user_id, U.username, U.password_hash, F.faculty_id, F.Name, U.email, F.contact, 
                       U.role_id, L1.value AS role, F.designation_id, L2.value AS designation, 
                       F.total_teaching_hours, F.research_area 
                FROM users U 
                JOIN faculty F USING(user_id) 
                JOIN lookup L1 ON L1.lookup_id = U.role_id 
                LEFT JOIN lookup L2 ON L2.lookup_id = F.designation_id
                WHERE U.username = '{username}'";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                if (reader.Read()) {

                    string storedPasswordHash = reader["password_hash"].ToString();

                    if (!BCrypt.Net.BCrypt.Verify(password, storedPasswordHash)) {
                        con.Close();
                        return false;
                    }

                    var LoggedInFaculty = new Faculty
                    {
                        Id = reader["faculty_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["faculty_id"]),
                        User_id = Convert.ToInt32(reader["user_id"]),
                        Username = reader["username"].ToString(),
                        Name = reader["Name"] == DBNull.Value ? "Not Approved" : reader["Name"].ToString(),
                        Email = reader["email"].ToString(),
                        Role = new Role
                        {
                            LookUp_Id = Convert.ToInt32(reader["role_id"]),
                            Value = reader["role"].ToString()
                        },
                        Contact = reader["contact"] == DBNull.Value ? "-" : reader["contact"].ToString(),
                        Designation = new Designation
                        {
                            LookUp_Id = reader["designation_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["designation_id"]),
                            Value = reader["designation"] == DBNull.Value ? "-" : reader["designation"].ToString()
                        },
                        TeachingHours = reader["total_teaching_hours"] == DBNull.Value ? 0 : Convert.ToInt32(reader["total_teaching_hours"]),
                        ResearchArea = reader["research_area"] == DBNull.Value ? "-" : reader["research_area"].ToString()
                    };

                    Session.StartSession(LoggedInFaculty);

                    con.Close();
                    return true; // Login successful
                }
            }

            con.Close();
            return false; // Login failed
        }
    }
}
