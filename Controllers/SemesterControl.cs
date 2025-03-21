using DBS25P023.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Controllers {
    public class SemesterControl {

        private static SemesterControl _instance;

        public SemesterControl() { }

        public static SemesterControl Instance {
            get {
                if (_instance == null) {
                    _instance = new SemesterControl();
                }
                return _instance;
            }
        }

        public bool AddSemester(Semester semester) {
            string query = $"INSERT INTO semesters (term, year) VALUES ('{semester.Term}','{semester.Year}')";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public bool SearchSemester(Semester semester, char type) {
            string query = $"SELECT COUNT(*) FROM semesters WHERE (term = '{semester.Term}' AND year = '{semester.Year}')";
            if (type == 'u')
                query += $"AND semester_id <> {semester.Id}";
            int count = DB.Instance.Scalar(query);
            return count > 0;
        }

        public bool UpdateSemester(Semester semester) {
            string query = $"UPDATE semesters SET term = '{semester.Term}', year = '{semester.Year}' WHERE semester_id = '{semester.Id}'";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public List<Semester> GetSemester(string search) {
            List<Semester> semesters = new List<Semester>();
            MySqlConnection con;
            string query = "SELECT * FROM semesters";

            if (!string.IsNullOrEmpty(search))
                query += $" WHERE term LIKE '%{search}%' OR year LIKE '%{search}%'";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    semesters.Add(new Semester
                    {
                        SrNo = idx,
                        Id = Convert.ToInt32(reader["semester_id"]),
                        Term = reader["term"].ToString(),
                        Year = Convert.ToInt32(reader["year"])
                    });
                    idx++;
                }
            }

            con.Close();
            return semesters;
        }

        public bool DeleteSemester(int id) {
            string query = $"DELETE FROM semesters WHERE semester_id = '{id}'";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

    }
}
