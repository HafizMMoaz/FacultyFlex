using DBS25P023.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Controllers {
    public class ProjectControl {

        string user_role = Session.LoggedInFaculty?.Role?.Value ?? "";
        int user_id = Session.LoggedInFaculty?.Id ?? 0;

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
                int idx = 1;
                while (reader.Read()) {
                    projects.Add(new Project
                    {
                        SrNo = idx++,
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


        public bool AssignProject(FacultyProject project) {
            string query = $"INSERT INTO faculty_projects (project_id,semester_id,supervision_hours) VALUES ('{project.Project.Id}','{project.Semester.Id}','{project.SuperVisionHours}')";
            if (project.Faculty != null)
                query = $"INSERT INTO faculty_projects (faculty_id,project_id,semester_id,supervision_hours) VALUES ('{project.Faculty.Id}','{project.Project.Id}','{project.Semester.Id}','{project.SuperVisionHours}')";

            if (DB.Instance.Update(query) == 1) {
                if (project.Faculty != null) {
                    if (FacultyControl.Instance.CalculateFacultyTeachingHours(project.Faculty.Id)) {
                        return true;
                    }
                }
                else {
                    return true;
                }
            }
            return false;
        }

        public bool SearchAssignedProject(FacultyProject project, char type) {
            string query = $"SELECT COUNT(*) FROM faculty_projects WHERE project_id = '{project.Project.Id}' AND semester_id = '{project.Semester.Id}'";
            if (project.Faculty != null)
                query = $"SELECT COUNT(*) FROM faculty_projects WHERE project_id = '{project.Project.Id}' AND semester_id = '{project.Semester.Id}' AND faculty_id = '{project.Faculty.Id}'";

            if (type == 'u')
                query += $" AND faculty_project_id <> {project.Id}";
            int count = DB.Instance.Scalar(query);
            return count > 0;
        }

        public bool UpdateAssignedProject(FacultyProject project) {
            string query = $"UPDATE faculty_projects SET project_id = '{project.Project.Id}',semester_id = '{project.Semester.Id}',supervision_hours = '{project.SuperVisionHours}'  WHERE faculty_project_id = '{project.Id}'";
            if (project.Faculty != null)
                query = $"UPDATE faculty_projects SET faculty_id = '{project.Faculty.Id}',project_id = '{project.Project.Id}',semester_id = '{project.Semester.Id}',supervision_hours = '{project.SuperVisionHours}' WHERE faculty_project_id = '{project.Id}'";
            if (DB.Instance.Update(query) == 1) {
                if (project.Faculty != null) {
                    if (FacultyControl.Instance.CalculateFacultyTeachingHours(project.Faculty.Id)) {
                        return true;
                    }
                }
                else {
                    return true;
                }
            }
            return false;
        }

        public List<FacultyProject> GetAssignedProjects(string search) {
            List<FacultyProject> projects = new List<FacultyProject>();
            MySqlConnection con;
            string query = "SELECT FP.*, F.Name, P.title, S.Term, S.Year FROM faculty_projects FP LEFT JOIN faculty F using (faculty_id) JOIN projects P using (project_id) JOIN semesters S using (semester_id) JOIN users U using(user_id) JOIN lookup L1 ON L1.lookup_id = U.role_id";

            if (!string.IsNullOrEmpty(search)) { 
                query += $" WHERE F.Name LIKE '%{search}%' OR P.title LIKE '%{search}%' OR S.Term LIKE '%{search}%' OR S.Year LIKE '%{search}%' OR supervision_hours LIKE '%{search}%'";
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

            query += " ORDER BY faculty_project_id ASC";

            using (MySqlDataReader reader = DB.Instance.GetData(query, out con)) {
                int idx = 1;
                while (reader.Read()) {
                    projects.Add(new FacultyProject
                    {
                        SrNo = idx++,
                        Id = Convert.ToInt32(reader["faculty_project_id"]),
                        Faculty = new Faculty
                        {
                            Id = reader["faculty_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["faculty_id"]),
                            Name = reader["Name"] == DBNull.Value ? "Not Assigned" : reader["Name"].ToString(),
                        },
                        Project = new Project
                        {
                            Id = Convert.ToInt32(reader["project_id"]),
                            Title = reader["title"].ToString()
                        },
                        Semester = new Semester
                        {
                            Id = Convert.ToInt32(reader["semester_id"]),
                            Term = reader["Term"].ToString(),
                            Year = Convert.ToInt32(reader["Year"])
                        },
                        SuperVisionHours = Convert.ToInt32(reader["supervision_hours"])
                    });
                }
            }

            con.Close();
            return projects;
        }

        public bool DeleteAssignedProject(int project_id) {
            string query = $"SELECT faculty_id FROM faculty_projects WHERE faculty_project_id = {project_id}";
            int id = DB.Instance.Scalar(query);
            query = $"DELETE FROM faculty_projects WHERE faculty_project_id = {project_id}";
            if (DB.Instance.Update(query) == 1) {
                if (id != 0) {
                    if (FacultyControl.Instance.CalculateFacultyTeachingHours(id)) {
                        return true;
                    }
                }
                else {
                    return true;
                }
            }
            return false;
        }
    }
}
