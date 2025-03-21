using DBS25P023.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Controllers {
    public class ProjectControl {

        private static ProjectControl _instance;

        public ProjectControl() { }

        public static ProjectControl Instance {
            get {
                if (_instance == null) {
                    _instance = new ProjectControl();
                }
                return _instance;
            }
        }

        public bool AddProject(Project project) {
            string title = project.Title.Replace("'", "''");  // Escape single quotes
            string description = project.Description.Replace("'", "''");  // Escape single quotes

            string query = $"INSERT INTO projects (title, description) VALUES ('{title}','{description}')";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public bool UpdateProject(Project project) {
            string title = project.Title.Replace("'", "''");  // Escape single quotes
            string description = project.Description.Replace("'", "''");  // Escape single quotes
            string query = $"UPDATE projects SET title = '{title}', description = '{description}' WHERE project_id = '{project.Id}'";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

        public List<Project> GetProjects(string search) {
            List<Project> projects = new List<Project>();
            MySqlConnection con;
            string query = "SELECT * FROM projects";

            if (!string.IsNullOrEmpty(search))
                query += $" WHERE title LIKE '%{search}%' OR description LIKE '%{search}%'";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                while (reader.Read()) {
                    projects.Add(new Project
                    {
                        Id = Convert.ToInt32(reader["project_id"]),
                        Title = reader["title"].ToString(),
                        Description = reader["description"].ToString()
                    });
                }
            }

            con.Close();
            return projects;
        }

        public bool DeleteProject(int id) {
            string query = $"DELETE FROM projects WHERE project_id = '{id}'";
            if (DB.Instance.Update(query) == 1) {
                return true;
            }
            return false;
        }

    }
}
