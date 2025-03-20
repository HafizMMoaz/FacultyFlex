using System;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBS25P023 {
    public class DB {

        private readonly String serverName = "";
        private readonly String port = "";
        private readonly String databaseName = "";
        private readonly String databaseUser = "";
        private readonly String databasePassword = "";

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
            }
            catch (Exception) {
                System.Windows.Forms.MessageBox.Show($"Check Your Network", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return connection;
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
