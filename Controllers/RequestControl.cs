using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P023.Models;

namespace DBS25P023.Controllers {
    public class RequestControl {
        private static RequestControl _instance;

        public RequestControl() { }

        public static RequestControl Instance {
            get {
                if (_instance == null) {
                    _instance = new RequestControl();
                }
                return _instance;
            }
        }

        public bool AddRequest(FacultyRequest request) {
            TimeZoneInfo pkTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            DateTime pkTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, pkTimeZone);

            string formattedDate = pkTime.ToString("yyyy-MM-dd HH:mm:ss");

            string query = $"INSERT INTO faculty_requests (faculty_id, item_id, quantity, status_id, request_date) " +
                           $"VALUES ('{request.Faculty.Id}', '{request.Item.Id}', '{request.Quantity}', '{request.Status.Id}', '{formattedDate}')";

            return DB.Instance.Update(query) == 1;
        }

        public bool UpdateRequest(FacultyRequest request) {
            string query = $"UPDATE faculty_requests SET faculty_id = '{request.Faculty.Id}', item_id = '{request.Item.Id}', quantity = '{request.Quantity}', status_id = '{request.Status.Id}' WHERE request_id = '{request.Id}'";
            return DB.Instance.Update(query) == 1;
        }

        public bool DeleteRequest(int id) {
            string query = $"DELETE FROM faculty_requests WHERE request_id = '{id}'";
            return DB.Instance.Update(query) == 1;
        }

        public List<FacultyRequest> GetRequests(string search) {
            List<FacultyRequest> requests = new List<FacultyRequest>();
            MySqlConnection con;
            string query = "SELECT r.*, f.faculty_name, c.item_name, l.lookup_name AS status FROM faculty_requests r " +
                           "JOIN faculty f ON r.faculty_id = f.faculty_id " +
                           "JOIN consumables c ON r.item_id = c.consumable_id " +
                           "LEFT JOIN lookup l ON r.status_id = l.lookup_id";

            if (!string.IsNullOrEmpty(search))
                query += $" WHERE f.faculty_name LIKE '%{search}%' OR c.item_name LIKE '%{search}%' OR l.lookup_name LIKE '%{search}%'";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    requests.Add(new FacultyRequest
                    {
                        SrNo = idx++,
                        Id = Convert.ToInt32(reader["request_id"]),
                        Faculty = new Faculty { Id = Convert.ToInt32(reader["faculty_id"]), Name = reader["faculty_name"].ToString() },
                        Item = new Consumable { Id = Convert.ToInt32(reader["item_id"]), Name = reader["item_name"].ToString() },
                        Quantity = Convert.ToInt32(reader["quantity"]),
                        Status = (RequestStatus)Enum.Parse(typeof(RequestStatus), reader["status"].ToString()),
                        TimeStamp = Convert.ToDateTime(reader["request_date"])
                    });
                }
            }

            con.Close();
            return requests;
        }
    }
}
