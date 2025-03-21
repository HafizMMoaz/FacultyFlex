using DBS25P023.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DBS25P023.Controllers {
    public class RoomControl {

        private static RoomControl _instance;

        public RoomControl() { }

        public static RoomControl Instance {
            get {
                if (_instance == null) {
                    _instance = new RoomControl();
                }
                return _instance;
            }
        }

        public bool AddRoom(Room room) {
            string query = $"INSERT INTO rooms (room_name, room_type, capacity) VALUES ('{room.Name}','{room.Type}','{room.Capacity}')";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public bool SearchRoom(Room room, char type) {
            string query = $"SELECT COUNT(*) FROM rooms WHERE (room_name = '{room.Name}')";
            if (type == 'u')
                query += $"AND room_id <> {room.Id}";
            int count = DB.Instance.Scalar(query);
            return count > 0;
        }

        public bool UpdateRoom(Room room) {
            string query = $"UPDATE rooms SET room_name = '{room.Name}', room_type = '{room.Type}', capacity = '{room.Capacity}' WHERE room_id = '{room.Id}'";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public List<Room> GetRoom(string search) {
            List<Room> rooms = new List<Room>();
            MySqlConnection con;
            string query = "SELECT * FROM rooms";

            if (!string.IsNullOrEmpty(search))
                query += $" WHERE room_name LIKE '%{search}%' OR room_type LIKE '%{search}%' OR capacity LIKE '%{search}%'";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    rooms.Add(new Room
                    {
                        SrNo = idx++,
                        Id = Convert.ToInt32(reader["room_id"]),
                        Name = reader["room_name"].ToString(),
                        Type = reader["room_type"].ToString(),
                        Capacity = Convert.ToInt32(reader["capacity"])
                    });
                }
            }

            con.Close();
            return rooms;
        }

        public bool DeleteRoom(int id) {
            string query = $"DELETE FROM rooms WHERE room_id = '{id}'";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public bool AssignRoom(FacultyRoom room) {
            string query = $"INSERT INTO faculty_room_allocations (room_id,semester_id,reserved_hours) VALUES ('{room.Room.Id}','{room.Semester.Id}', {room.ReservedHours})";
            if (room.Faculty != null)
                query = $"INSERT INTO faculty_room_allocations (faculty_id,room_id,semester_id,reserved_hours) VALUES ('{room.Faculty.Id}','{room.Room.Id}','{room.Semester.Id}', {room.ReservedHours})";

            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public bool SearchAssignedRoom(FacultyRoom room, char type) {
            string query = $"SELECT COUNT(*) FROM faculty_room_allocations WHERE room_id = '{room.Room.Id}' AND semester_id = '{room.Semester.Id}'";
            if (room.Faculty != null)
                query = $"SELECT COUNT(*) FROM faculty_room_allocations WHERE room_id = '{room.Room.Id}' AND semester_id = '{room.Semester.Id}' AND faculty_id = '{room.Faculty.Id}'";

            if (type == 'u')
                query += $" AND allocation_id <> {room.Id}";
            int count = DB.Instance.Scalar(query);
            return count > 0;
        }

        public bool UpdateAssignedRoom(FacultyRoom room) {
            string query = $"UPDATE faculty_room_allocations SET room_id = '{room.Room.Id}',semester_id = '{room.Semester.Id}', reserved_hours = '{room.ReservedHours}' WHERE allocation_id = '{room.Id}'";
            if (room.Faculty != null)
                query = $"UPDATE faculty_room_allocations SET faculty_id = '{room.Faculty.Id}',room_id = '{room.Room.Id}',semester_id = '{room.Semester.Id}', reserved_hours = '{room.ReservedHours}' WHERE allocation_id = '{room.Id}'";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public List<FacultyRoom> GetAssignedRooms(string search) {
            List<FacultyRoom> rooms = new List<FacultyRoom>();
            MySqlConnection con;
            string query = "SELECT FA.*, F.Name, C.room_name, C.room_type, S.Term, S.Year FROM faculty_room_allocations FA LEFT JOIN faculty F using (faculty_id) JOIN rooms C using (room_id) JOIN semesters S using (semester_id)";

            if (!string.IsNullOrEmpty(search))
                query += $" WHERE F.Name LIKE '%{search}%' OR C.room_name LIKE '%{search}%' OR C.room_type LIKE '%{search}%' OR S.Term LIKE '%{search}%' OR S.Year LIKE '%{search}%' OR FA.reserved_hours LIKE '%{search}%'";

            query += " ORDER BY allocation_id ASC";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    rooms.Add(new FacultyRoom
                    {
                        SrNo = idx++,
                        Id = Convert.ToInt32(reader["allocation_id"]),
                        Faculty = new Faculty
                        {
                            Id = reader["faculty_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["faculty_id"]),
                            Name = reader["Name"] == DBNull.Value ? "Not Assigned" : reader["Name"].ToString(),
                        },
                        Room = new Room
                        {
                            Id = Convert.ToInt32(reader["room_id"]),
                            Name = reader["room_name"].ToString(),
                            Type = reader["room_type"].ToString(),
                        },
                        Semester = new Semester
                        {
                            Id = Convert.ToInt32(reader["semester_id"]),
                            Term = reader["Term"].ToString(),
                            Year = Convert.ToInt32(reader["Year"])
                        },
                        ReservedHours = Convert.ToInt32(reader["reserved_hours"])
                    });
                }
            }

            con.Close();
            return rooms;
        }

        public bool DeleteAssignedRoom(int room_id) {
            string query = $"DELETE FROM faculty_room_allocations WHERE allocation_id = {room_id}";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }
    }
}
