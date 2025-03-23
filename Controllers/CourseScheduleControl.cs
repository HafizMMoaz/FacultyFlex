using DBS25P023.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Controllers {
    public class CourseScheduleControl {
        private static CourseScheduleControl _instance;

        public CourseScheduleControl() { }

        public static CourseScheduleControl Instance {
            get {
                if (_instance == null) {
                    _instance = new CourseScheduleControl();
                }
                return _instance;
            }
        }

        public bool AddSchedule(CourseSchedule schedule) {
            string query = $"INSERT INTO faculty_course_schedule (faculty_course_id, room_id, day_of_week, start_time, end_time) VALUES ('{schedule.FacultyCourse.Id}','{schedule.Room.Id}','{schedule.DayofWeek}','{schedule.StartTime}','{schedule.EndTime}')";
            return DB.Instance.Update(query) == 1;
        }

        public bool UpdateSchedule(CourseSchedule schedule) {
            string query = $"UPDATE faculty_course_schedule SET room_id = '{schedule.Room.Id}', day_of_week = '{schedule.DayofWeek}', start_time = '{schedule.StartTime}', end_time = '{schedule.EndTime}' WHERE schedule_id = '{schedule.Id}'";
            return DB.Instance.Update(query) == 1;
        }

        public bool DeleteSchedule(int schedule_id) {
            string query = $"DELETE FROM faculty_course_schedule WHERE schedule_id = '{schedule_id}'";
            return DB.Instance.Update(query) == 1;
        }

        public List<CourseSchedule> GetSchedule(string search) {
            List<CourseSchedule> schedules = new List<CourseSchedule>();
            MySqlConnection con;

            string query = @"
        SELECT 
            fcs.schedule_id, fcs.day_of_week, fcs.start_time, fcs.end_time, 
            fc.faculty_course_id, 
            f.faculty_id, f.name AS faculty_name, 
            c.course_id, c.course_name, c.course_type, c.contact_hours, 
            r.room_id, r.room_name, r.room_type 
        FROM faculty_course_schedule fcs
        JOIN faculty_courses fc ON fcs.faculty_course_id = fc.faculty_course_id
        JOIN faculty f ON fc.faculty_id = f.faculty_id
        JOIN courses c ON fc.course_id = c.course_id
        LEFT JOIN rooms r ON fcs.room_id = r.room_id";

            if (!string.IsNullOrEmpty(search))
                query += $" WHERE fcs.day_of_week LIKE '%{search}%' OR fcs.start_time LIKE '%{search}%' OR fcs.end_time LIKE '%{search}%' OR c.course_name LIKE '%{search}%' OR f.name LIKE '%{search}%'";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    schedules.Add(new CourseSchedule
                    {
                        SrNo = idx++,
                        Id = Convert.ToInt32(reader["schedule_id"]),
                        FacultyCourse = new FacultyCourse
                        {
                            Id = Convert.ToInt32(reader["faculty_course_id"]),
                            Faculty = new Faculty
                            {
                                Id = Convert.ToInt32(reader["faculty_id"]),
                                Name = reader["faculty_name"].ToString()
                            },
                            Course = new Course
                            {
                                Id = Convert.ToInt32(reader["course_id"]),
                                Name = reader["course_name"].ToString(),
                                Type = reader["course_type"].ToString(),
                                ContactHours = Convert.ToInt32(reader["contact_hours"])
                            }
                        },
                        Room = reader["room_id"] != DBNull.Value ? new Room
                        {
                            Id = Convert.ToInt32(reader["room_id"]),
                            Name = reader["room_name"].ToString(),
                            Type = reader["room_type"].ToString()
                        } : null,
                        DayofWeek = reader["day_of_week"].ToString(),
                        StartTime = reader["start_time"].ToString(),
                        EndTime = reader["end_time"].ToString()
                    });
                }
            }

            con.Close();
            return schedules;
        }



    }
}
