using DBS25P023.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DBS25P023.Controllers {
    public class CourseControl {

        private static CourseControl _instance;

        public CourseControl() { }

        public static CourseControl Instance {
            get {
                if (_instance == null) { 
                    _instance = new CourseControl();
                }
                return _instance;
            }
        }

        public bool AddCourse(Course course) {
            string query = $"INSERT INTO courses (course_name, course_type, credit_hours, contact_hours) VALUES ('{course.Name}','{course.Type}','{course.CreditHours}','{course.ContactHours}')";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public bool SearchCourse(Course course, char type) {
            string query = $"SELECT COUNT(*) FROM courses WHERE (course_name = '{course.Name}' AND course_type = '{course.Type}')";
            if (type == 'u')
                query += $"AND course_id <> {course.Id}";
            int count = DB.Instance.Scalar(query);
            return count > 0;
        }

        public bool UpdateCourse(Course course) {
            string query = $"UPDATE courses SET course_name = '{course.Name}', course_type = '{course.Type}', credit_hours = '{course.CreditHours}', contact_hours = '{course.ContactHours}' WHERE course_id = '{course.Id}'";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public List<Course> GetCourse(string search) {
            List<Course> courses = new List<Course>();
            MySqlConnection con;
            string query = "SELECT * FROM courses";

            if (!string.IsNullOrEmpty(search))
                query += $" WHERE course_name LIKE '%{search}%' OR course_type LIKE '%{search}%' OR credit_hours LIKE '%{search}%' OR contact_hours LIKE '%{search}%'";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    courses.Add(new Course
                    {
                        SrNo = idx++,
                        Id = Convert.ToInt32(reader["course_id"]),
                        Name = reader["course_name"].ToString(),
                        Type = reader["course_type"].ToString(),
                        CreditHours = Convert.ToInt32(reader["credit_hours"]),
                        ContactHours = Convert.ToInt32(reader["contact_hours"])
                    });
                }
            }

            con.Close();
            return courses;
        }

        public bool DeleteCourse(int id) {
            string query = $"DELETE FROM courses WHERE course_id = '{id}'";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public bool AssignCourse(FacultyCourse course) {
            string query = $"INSERT INTO faculty_courses (course_id,semester_id) VALUES ('{course.Course.Id}','{course.Semester.Id}')";
            if(course.Faculty != null)
                query = $"INSERT INTO faculty_courses (faculty_id,course_id,semester_id) VALUES ('{course.Faculty.Id}','{course.Course.Id}','{course.Semester.Id}')";

            if (DB.Instance.Update(query) == 1) {
                if (course.Faculty != null) {
                    if (FacultyControl.Instance.CalculateFacultyTeachingHours(course.Faculty.Id)) {
                        return true;
                    }
                }
                else {
                    return true;
                }
            }
            return false;
        }
    
        public bool SearchAssignedCourse(FacultyCourse course, char type) {
            string query = $"SELECT COUNT(*) FROM faculty_courses WHERE course_id = '{course.Course.Id}' AND semester_id = '{course.Semester.Id}'";
            if (course.Faculty != null)
                query = $"SELECT COUNT(*) FROM faculty_courses WHERE course_id = '{course.Course.Id}' AND semester_id = '{course.Semester.Id}' AND faculty_id = '{course.Faculty.Id}'";
            
            if (type == 'u')
                query += $" AND faculty_course_id <> {course.Id}";
            int count = DB.Instance.Scalar(query);
            return count > 0;
        }

        public bool UpdateAssignedCourse(FacultyCourse course) {
            string query = $"UPDATE faculty_courses SET course_id = '{course.Course.Id}',semester_id = '{course.Semester.Id}' WHERE faculty_course_id = '{course.Id}'";
            if (course.Faculty != null)
                query = $"UPDATE faculty_courses SET faculty_id = '{course.Faculty.Id}',course_id = '{course.Course.Id}',semester_id = '{course.Semester.Id}' WHERE faculty_course_id = '{course.Id}'";
            if (DB.Instance.Update(query) == 1) {
                if (course.Faculty != null) {
                    if (FacultyControl.Instance.CalculateFacultyTeachingHours(course.Faculty.Id)) {
                        return true;
                    }
                }
                else {
                    return true;
                }
            }
            return false;
        }

        public List<FacultyCourse> GetAssignedCourses(string search) { 
            List<FacultyCourse> courses = new List<FacultyCourse>();
            MySqlConnection con;
            string query = "SELECT FC.*, F.Name, C.course_name, C.course_type, C.contact_hours, S.Term, S.Year FROM faculty_courses FC LEFT JOIN faculty F using (faculty_id) JOIN courses C using (course_id) JOIN semesters S using (semester_id)";

            if (!string.IsNullOrEmpty(search))
                query += $" WHERE F.Name LIKE '%{search}%' OR C.course_name LIKE '%{search}%' OR C.course_type LIKE '%{search}%' OR S.Term LIKE '%{search}%' OR S.Year LIKE '%{search}%'";

            query += " ORDER BY faculty_course_id ASC";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    courses.Add(new FacultyCourse
                    {
                        SrNo = idx++,
                        Id = Convert.ToInt32(reader["faculty_course_id"]),
                        Faculty = new Faculty
                        {
                            Id = reader["faculty_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["faculty_id"]),
                            Name = reader["Name"] == DBNull.Value ? "Not Assigned" : reader["Name"].ToString(),
                        },
                        Course = new Course
                        {
                            Id = Convert.ToInt32(reader["course_id"]),
                            Name = reader["course_name"].ToString(),
                            Type = reader["course_type"].ToString(),
                            ContactHours = Convert.ToInt32(reader["contact_hours"])
                        },
                        Semester = new Semester
                        {
                            Id = Convert.ToInt32(reader["semester_id"]),
                            Term = reader["Term"].ToString(),
                            Year = Convert.ToInt32(reader["Year"])
                        }
                    });
                }
            }

            con.Close();
            return courses;
        }
    
        public bool DeleteAssignedCourse(int course_id) {
            string query = $"SELECT faculty_id FROM faculty_courses WHERE faculty_course_id = {course_id}";
            int id = DB.Instance.Scalar(query);
            query = $"DELETE FROM faculty_courses WHERE faculty_course_id = {course_id}";
            if (DB.Instance.Update(query) == 1) {
                if (id != 0) {
                    if (FacultyControl.Instance.CalculateFacultyTeachingHours(id)) {
                        return true;
                    }
                }
                else {
                    return true;
                }
            }
            return false;
        }
    }
}
