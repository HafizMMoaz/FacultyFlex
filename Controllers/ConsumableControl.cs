using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P023.Models;

namespace DBS25P023.Controllers {
    public class ConsumableControl {
        private static ConsumableControl _instance;

        public ConsumableControl() { }

        public static ConsumableControl Instance {
            get {
                if (_instance == null) {
                    _instance = new ConsumableControl();
                }
                return _instance;
            }
        }

        public bool AddConsumable(Consumable consumable) {
            string query = $"INSERT INTO consumables (item_name) VALUES ('{consumable.Name}')";
            return DB.Instance.Update(query) == 1;
        }

        public bool SearchConsumable(Consumable consumable, char type) {
            string query = $"SELECT COUNT(*) FROM consumables WHERE item_name = '{consumable.Name}'";
            if (type == 'u')
                query += $" AND consumable_id <> {consumable.Id}";
            int count = DB.Instance.Scalar(query);
            return count > 0;
        }

        public bool UpdateConsumable(Consumable consumable) {
            string query = $"UPDATE consumables SET item_name = '{consumable.Name}' WHERE consumable_id = '{consumable.Id}'";
            return DB.Instance.Update(query) == 1;
        }

        public List<Consumable> GetConsumables(string search) {
            List<Consumable> consumables = new List<Consumable>();
            MySqlConnection con;
            string query = "SELECT * FROM consumables";

            if (!string.IsNullOrEmpty(search))
                query += $" WHERE item_name LIKE '%{search}%'";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    consumables.Add(new Consumable
                    {
                        SrNo = idx++,
                        Id = Convert.ToInt32(reader["consumable_id"]),
                        Name = reader["item_name"].ToString()
                    });
                }
            }

            con.Close();
            return consumables;
        }

        public bool DeleteConsumable(int id) {
            string query = $"DELETE FROM consumables WHERE consumable_id = '{id}'";
            return DB.Instance.Update(query) == 1;
        }
    }
}
