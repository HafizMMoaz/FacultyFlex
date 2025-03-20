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
            string query = $"INSERT INTO users(username, email, password_hash, role_id) VALUES ('{faculty.Username}','{faculty.Email}','{faculty.Password}',{faculty.Role.LookUp_Id})";
            if(DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }
        public bool SearchFacultyUser(Faculty faculty, char type) {
            string query = $"SELECT COUNT(*) FROM users WHERE (email = '{faculty.Email}' OR username = '{faculty.Username}')";
            if (type == 'u')
                query += $"AND user_id <> {faculty.User_id}";
            int count = DB.Instance.Scalar(query);
            return count > 0;
        }
        public bool UpdateFacultyUser(Faculty faculty) {
            string query;
            if (faculty.Password != null)
                query = $"UPDATE users SET username = '{faculty.Username}', email = '{faculty.Email}', password_hash = '{faculty.Password}', role_id = {faculty.Role.LookUp_Id} WHERE user_id = {faculty.User_id}";
            else
                query = $"UPDATE users SET username = '{faculty.Username}', email = '{faculty.Email}', role_id = {faculty.Role.LookUp_Id} WHERE user_id = {faculty.User_id}";
            
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }
        public List<Faculty> GetFaculty(string search) {
            List<Faculty> facultyusers = new List<Faculty>();
            MySqlConnection con;

            string query = "SELECT U.user_id, U.username, F.faculty_id, F.Name, U.email, F.contact, U.role_id , L1.value as role, F.designation_id, L2.value as designation, F.total_teaching_hours, F.research_area FROM users U LEFT JOIN faculty F using(user_id) JOIN lookup L1 ON L1.lookup_id = U.role_id LEFT JOIN lookup L2 ON L2.lookup_id = F.designation_id";
            
            if (!string.IsNullOrEmpty(search))
                query = query + $" WHERE U.username LIKE '%{search}%' OR U.email LIKE '%{search}%' OR L1.value LIKE '%{search}%' OR L2.value LIKE '%{search}%' OR F.Name LIKE '%{search}%' OR F.contact LIKE '%{search}%'";

            query = query + " ORDER BY user_id ASC";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                while (reader.Read()) {
                    facultyusers.Add(new Faculty
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
                    });
                }
            }

            con.Close();
            return facultyusers;
        }

        public bool ApproveFaculty(Faculty faculty) {
            // Check if the user_id exists in the users table before proceeding
            string checkUserQuery = $"SELECT COUNT(*) FROM users WHERE user_id = {faculty.User_id}";
            int userCount = DB.Instance.Scalar(checkUserQuery);

            if (userCount == 0) {
                throw new Exception($"User with user_id {faculty.User_id} does not exist in the users table.");
            }

            // Proceed with the normal faculty insertion if the user_id exists
            string query = "INSERT INTO faculty (name, email, contact, designation_id, research_area, total_teaching_hours, user_id)" +
                           $"VALUES ('{faculty.Name}', '{faculty.Email}', '{faculty.Contact}', '{faculty.Designation.LookUp_Id}', '{faculty.ResearchArea}', '{faculty.TeachingHours}', '{faculty.User_id}')";

            if (DB.Instance.Update(query) == 1) {
                return true;
            }

            return false;
        }


        public bool UpdateFaculty(Faculty faculty) {
            string query = $"UPDATE faculty SET name = '{faculty.Name}', contact = '{faculty.Contact}', designation_id = '{faculty.Designation.LookUp_Id}', total_teaching_hours = {faculty.TeachingHours}, research_area = '{faculty.ResearchArea}' WHERE faculty_id = {faculty.Id}";

            if (DB.Instance.Update(query) == 1) {
                return true;
            }

            return false;
        }

        public bool DeleteFaculty(int id) {

            string query = $"SELECT COUNT(*) FROM faculty WHERE user_id = {id}";
            int userCount = DB.Instance.Scalar(query);

            if (userCount != 0) {
                query = $"DELETE FROM faculty WHERE user_id = {id}";
                DB.Instance.Update(query);
            }

            query = $"DELETE FROM users WHERE user_id = {id}";
            if (DB.Instance.Update(query) == 1) {
                    return true;
            }
            return false;
        }


    }
}
