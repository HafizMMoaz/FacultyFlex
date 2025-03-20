using DBS25P023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool DeleteCourse(int id) {
            string query = $"DELETE courses WHERE course_id = '{id}'";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

    }
}
