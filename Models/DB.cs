using System;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBS25P023.Models {
    public class DB {

        private string serverName = Session.DBCred?.ServerName ?? "127.0.0.1";
        private string port = Session.DBCred?.Port ?? "3307";
        private string databaseName = Session.DBCred?.DatabaseName ?? "facultyflex";
        private string databaseUser = Session.DBCred?.DatabaseUser ?? "root";
        private string databasePassword = Session.DBCred?.DatabasePassword ?? "Hafiz...1452";

        private static DB _instance;

        private DB() { }

        public static DB Instance {
            get {
                if (_instance == null)
                    _instance = new DB();
                return _instance;
            }
        }

        public MySqlConnection GetConnection() {
            string connectionString = $"server={serverName};port={port};user={databaseUser};database={databaseName};password={databasePassword};SslMode=Preferred;";
            var connection = new MySqlConnection(connectionString);
            try {
                connection.Open();
                return connection;
            }
            catch (Exception) {
                System.Windows.Forms.MessageBox.Show($"Check Your Network", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public MySqlDataReader GetData(string query, out MySqlConnection connection) {
            connection = GetConnection();
            var command = new MySqlCommand(query, connection);
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public int Update(string query) {
            try {
                using (var connection = GetConnection()) {
                    using (var command = new MySqlCommand(query, connection)) {
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Update Query Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
        }

        public int Scalar(string query) {
            using (var connection = GetConnection()) {
                using (var command = new MySqlCommand(query, connection)) {
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }
    }
}
