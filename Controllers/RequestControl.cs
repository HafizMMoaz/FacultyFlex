﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P023.Models;

namespace DBS25P023.Controllers {
    public class RequestControl {

        string user_role = Session.LoggedInFaculty?.Role?.Value ?? "";
        int user_id = Session.LoggedInFaculty?.Id ?? 0;

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

            string query = $"INSERT INTO faculty_requests (faculty_id, item_id, quantity, status_id, request_date) " +
                           $"VALUES ('{request.Faculty.Id}', '{request.Item.Id}', '{request.Quantity}', '{request.Status.LookUp_Id}', '{request.TimeStamp}')";

            return DB.Instance.Update(query) == 1;
        }

        public bool UpdateRequest(FacultyRequest request) {
            string query = $"UPDATE faculty_requests SET item_id = '{request.Item.Id}', quantity = '{request.Quantity}' WHERE request_id = '{request.Id}'";
            return DB.Instance.Update(query) == 1;
        }

        public bool UpdateStatus(FacultyRequest request) {
            string query = $"UPDATE faculty_requests SET status_id = '{request.Status.LookUp_Id}' WHERE request_id = '{request.Id}'";
            return DB.Instance.Update(query) == 1;
        }

        public bool DeleteRequest(int id) {
            string query = $"DELETE FROM faculty_requests WHERE request_id = '{id}'";
            return DB.Instance.Update(query) == 1;
        }

        public List<FacultyRequest> GetRequests(string search) {
            List<FacultyRequest> requests = new List<FacultyRequest>();
            MySqlConnection con;
            string query = "SELECT r.*, f.Name, c.item_name, l.value AS status FROM faculty_requests r JOIN faculty f ON r.faculty_id = f.faculty_id JOIN consumables c ON r.item_id = c.consumable_id JOIN lookup l ON r.status_id = l.lookup_id JOIN users U USING(user_id) JOIN lookup L1 ON L1.lookup_id = U.role_id"; ;

            if (!string.IsNullOrEmpty(search)){
                query += $" WHERE f.Name LIKE '%{search}%' OR c.item_name LIKE '%{search}%' OR l.value LIKE '%{search}%' OR r.request_date LIKE '%{search}%'";
                if (user_role == "Department Head") {
                    query += " AND L1.value <> 'Admin'";
                }
                else if (user_role == "Faculty") {
                    query += $" AND F.faculty_id = '{user_id}'";
                }
            }
            else {
                if (user_role == "Department Head") {
                    query += " WHERE L1.value <> 'Admin'";
                }
                else if (user_role == "Faculty") {
                    query += $" WHERE F.faculty_id = '{user_id}'";
                }
            }

            query += " ORDER BY r.request_id DESC";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    requests.Add(new FacultyRequest
                    {
                        SrNo = idx++,
                        Id = Convert.ToInt32(reader["request_id"]),
                        Faculty = new Faculty { Id = Convert.ToInt32(reader["faculty_id"]), Name = reader["Name"].ToString() },
                        Item = new Consumable { Id = Convert.ToInt32(reader["item_id"]), Name = reader["item_name"].ToString() },
                        Quantity = Convert.ToInt32(reader["quantity"]),
                        Status = new RequestStatus { Id = Convert.ToInt32(reader["status_id"]), Value = reader["status"].ToString() },
                        TimeStamp = reader["request_date"].ToString()
                    });
                }
            }

            con.Close();
            return requests;
        }

        public List<FacultyRequest> GetRequestsForConsumable(int consumableId) {
            List<FacultyRequest> requestDataList = new List<FacultyRequest>();

            string query = $"SELECT fr.request_id, fr.quantity FROM faculty_requests fr WHERE fr.item_id = '{consumableId}' ORDER BY fr.request_id";

            MySqlConnection con;
            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                while (reader.Read()) {
                    requestDataList.Add(new FacultyRequest
                    {
                        Id = reader.GetInt32("request_id"),
                        Quantity = reader.GetInt32("quantity"),
                        Item = new Consumable { Id = consumableId }
                    });
                }
            }

            return requestDataList;
        }
    }
}
