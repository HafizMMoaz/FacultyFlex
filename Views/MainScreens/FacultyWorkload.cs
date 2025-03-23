using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P023.Dialogs;
using DBS25P023.Models;
using DBS25P023.Controllers;
using System.Net;

namespace DBS25P023.Views.MainScreens {
    public partial class FacultyWorkload: UserControl
    {
        public FacultyWorkload()
        {
            InitializeComponent();
        }

        private void FacultyWorkload_Load(object sender, EventArgs e) {
            RefreshData();
        }

        public void RefreshData() {
            AssignedCoursesRender(null);
            CourseDataRender(null);
            ProjectDataRender(null);
            SemesterDataRender(null);
            AdminRoleDataRender(null);
            AssignProjectDataRender(null);
            ScheduleDataRender(null);
        }

        private void RefreshBtn_Click(object sender, EventArgs e) {
            RefreshData();
            new FacultyRequests().RefreshData();
            new UserManagement().RefreshData();
            new ResourceAllocation().RefreshData();
        }

        #region Course
        private void NewCourse_Click(object sender, EventArgs e) {
            new CourseDialog("ADD").ShowDialog();
            CourseDataRender(null);
        }

        private void CourseDataRender(string search) {
            List<Course> courses = CourseControl.Instance.GetCourse(search);
            CourseData.DataSource = courses;

            CourseData.Columns["SrNo"].HeaderText = "#";
            CourseData.Columns["Name"].HeaderText = "NAME";
            CourseData.Columns["Type"].HeaderText = "TYPE";
            CourseData.Columns["CreditHours"].HeaderText = "CREDIT HOURS";
            CourseData.Columns["ContactHours"].HeaderText = "CONTACT HOURS";
            CourseData.Columns["Id"].Visible = false;

            CourseData.DefaultCellStyle.Font = new Font("Arial", 10);
            CourseData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            CourseData.RowTemplate.Height = 30;
            CourseData.EnableHeadersVisualStyles = false;
            CourseData.ColumnHeadersHeight = 50;
        }

        private void CourseData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                CourseData.Rows[e.RowIndex].Selected = true;
            }
        }

        private void CourseSearch_TextChanged(object sender, EventArgs e) {
            string search = CourseSearch.Text;
            CourseDataRender(search);
        }

        private void CourseSearchBtn_Click(object sender, EventArgs e) {
            string search = CourseSearch.Text;
            CourseDataRender(search);
        }

        private void EditCourse_Click(object sender, EventArgs e) {
            if (CourseData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = CourseData.SelectedRows[0];

                int course_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string name = selectedRow.Cells["Name"].Value.ToString();
                string type = selectedRow.Cells["Type"].Value.ToString();
                int credit_hours = Convert.ToInt32(selectedRow.Cells["CreditHours"].Value);
                int contact_hours = Convert.ToInt32(selectedRow.Cells["ContactHours"].Value);


                var course = new Course
                {
                    Id = course_id,
                    Name = name,
                    Type = type,
                    CreditHours = credit_hours,
                    ContactHours = contact_hours
                };

                new CourseDialog("UPDATE", course).ShowDialog();
                CourseDataRender(null);
            }
        }

        private void DeleteCourse_Click(object sender, EventArgs e) {
            if (CourseData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = CourseData.SelectedRows[0];

                int course_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (CourseControl.Instance.DeleteCourse(course_id)) {
                    MessageBox.Show("Course Deleted Successfully", "Course Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CourseDataRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Course Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion

        #region Project
        private void NewProject_Click(object sender, EventArgs e) {
            new ProjectDialog("ADD").ShowDialog();
            ProjectDataRender(null);
        }

        private void ProjectDataRender(string search) {
            List<Project> projects = ProjectControl.Instance.GetProjects(search);
            ProjectData.DataSource = projects;

            ProjectData.Columns["SrNo"].HeaderText = "#";
            ProjectData.Columns["Title"].HeaderText = "TITLE";
            ProjectData.Columns["Description"].HeaderText = "DESCRIPTION";
            ProjectData.Columns["Id"].Visible = false;

            ProjectData.DefaultCellStyle.Font = new Font("Arial", 10);
            ProjectData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            ProjectData.RowTemplate.Height = 30;
            ProjectData.EnableHeadersVisualStyles = false;
            ProjectData.ColumnHeadersHeight = 50;
        }

        private void ProjectData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                ProjectData.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ProjectSearch_TextChanged(object sender, EventArgs e) {
            string search = ProjectSearch.Text;
            ProjectDataRender(search);
        }

        private void ProjectSearchBtn_Click(object sender, EventArgs e) {
            string search = ProjectSearch.Text;
            ProjectDataRender(search);
        }

        private void EditProject_Click(object sender, EventArgs e) {
            if (ProjectData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = ProjectData.SelectedRows[0];

                int project_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string Title = selectedRow.Cells["Title"].Value.ToString();
                string Description = selectedRow.Cells["Description"].Value.ToString();


                var project = new Project
                {
                    Id = project_id,
                    Title = Title,
                    Description = Description
                };

                new ProjectDialog("UPDATE", project).ShowDialog();
                ProjectDataRender(null);
            }
        }

        private void DeleteProject_Click(object sender, EventArgs e) {
            if (ProjectData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = ProjectData.SelectedRows[0];

                int project_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (ProjectControl.Instance.DeleteProject(project_id)) {
                    MessageBox.Show("Project Deleted Successfully", "Project Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProjectDataRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Project Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion

        #region Semester
        private void NewSemester_Click(object sender, EventArgs e) {
            new SemesterDialog("ADD").ShowDialog();
            SemesterDataRender(null);
        }

        private void SemesterDataRender(string search) {
            List<Semester> semesters = SemesterControl.Instance.GetSemester(search);
            SemesterData.DataSource = semesters;

            SemesterData.Columns["SrNo"].HeaderText = "#";
            SemesterData.Columns["Term"].HeaderText = "TERM";
            SemesterData.Columns["Year"].HeaderText = "YEAR";
            SemesterData.Columns["Id"].Visible = false;

            SemesterData.DefaultCellStyle.Font = new Font("Arial", 10);
            SemesterData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            SemesterData.RowTemplate.Height = 30;
            SemesterData.EnableHeadersVisualStyles = false;
            SemesterData.ColumnHeadersHeight = 50;
        }

        private void SemesterData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex >= 0) {
                SemesterData.Rows[e.RowIndex].Selected = true;
            }
        }

        private void SemesterSearch_TextChanged(object sender, EventArgs e) {
            string search = SemesterSearch.Text;
            ProjectDataRender(search);
        }

        private void SemesterSearchBtn_Click(object sender, EventArgs e) {
            string search = SemesterSearch.Text;
            ProjectDataRender(search);
        }

        private void EditSemester_Click(object sender, EventArgs e) {
            if (SemesterData.SelectedRows.Count > 0) { 
                DataGridViewRow selectedRow = SemesterData.SelectedRows[0];
                int semester_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string Term = selectedRow.Cells["Term"].Value.ToString();
                int Year = Convert.ToInt32(selectedRow.Cells["Year"].Value);


                var semester = new Semester
                {
                    Id = semester_id,
                    Term = Term,
                    Year = Year
                };

                new SemesterDialog("UPDATE", semester).ShowDialog();
                ProjectDataRender(null);
            }
        }

        private void DeleteSemester_Click(object sender, EventArgs e) {
            if (SemesterData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = SemesterData.SelectedRows[0];

                int semester_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (SemesterControl.Instance.DeleteSemester(semester_id)) {
                    MessageBox.Show("Semester Deleted Successfully", "Semester Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SemesterDataRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Semester Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion

        #region Assign Course
        private void AssignCourseBtn_Click(object sender, EventArgs e) {
            new AssignCourseDialog("ASSIGN").ShowDialog();
            AssignedCoursesRender(null);
        }

        private void AssignedCoursesRender(string search) {
            List<FacultyCourse> courses = CourseControl.Instance.GetAssignedCourses(search);
            AssignedCoursesData.DataSource = courses;

            AssignedCoursesData.Columns["SrNo"].HeaderText = "#";
            AssignedCoursesData.Columns["faculty"].HeaderText = "FACULTY";
            AssignedCoursesData.Columns["course"].HeaderText = "COURSE";
            AssignedCoursesData.Columns["semester"].HeaderText = "SEMESTER";
            AssignedCoursesData.Columns["Id"].Visible = false;

            AssignedCoursesData.DefaultCellStyle.Font = new Font("Arial", 10);
            AssignedCoursesData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            AssignedCoursesData.RowTemplate.Height = 30;
            AssignedCoursesData.EnableHeadersVisualStyles = false;
            AssignedCoursesData.ColumnHeadersHeight = 50;
        }

        private void AssignedCoursesData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                AssignedCoursesData.Rows[e.RowIndex].Selected = true;
            }
        }

        private void AssignedCoursesData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                AssignedCoursesData.ClearSelection();
                AssignedCoursesData.Rows[e.RowIndex].Selected = true;

                var name = AssignedCoursesData.Rows[e.RowIndex].Cells["faculty"].Value?.ToString();

                EditAssignedCourse.Click -= AssignCourseTeacher_Click;
                EditAssignedCourse.Click -= EditAssignedCourse_Click;

                if (name == "Not Assigned") {
                    EditAssignedCourse.Text = "Assign Faculty To Course";
                    EditAssignedCourse.Click += AssignCourseTeacher_Click;
                    EditAssignedCourse.Image = DBS25P023.Properties.Resources.edit;
                }
                else {
                    EditAssignedCourse.Text = "Update Faculty Course";
                    EditAssignedCourse.Image = DBS25P023.Properties.Resources.edit;
                    EditAssignedCourse.Click += EditAssignedCourse_Click;
                }
            }
        }

        private void AssignedCoursesData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (AssignedCoursesData.Columns[e.ColumnIndex].Name == "faculty") {
                var name = e.Value.ToString();
                if (name == "Not Assigned") {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else {
                    e.CellStyle.BackColor = AssignedCoursesData.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = AssignedCoursesData.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void AssignedCourseSearch_TextChanged(object sender, EventArgs e) {
            string search = AssignedCourseSearch.Text;
            AssignedCoursesRender(search);
        }

        private void AssignedCourseSearchBtn_Click(object sender, EventArgs e) {
            string search = AssignedCourseSearch.Text;
            AssignedCoursesRender(search);
        }

        private void EditAssignedCourse_Click(object sender, EventArgs e) {
            if (AssignedCoursesData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AssignedCoursesData.SelectedRows[0];

                int course_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string facultyName = selectedRow.Cells["faculty"].Value.ToString();
                Faculty faculty = FacultyControl.Instance.GetFaculty(null, 'a').FirstOrDefault(f => f.Name == facultyName);

                string courseName = selectedRow.Cells["course"].Value.ToString();
                Course course = CourseControl.Instance.GetCourse(null).FirstOrDefault(c => $"{c.Name} - {c.Type}" == courseName);

                string semesterVal = selectedRow.Cells["semester"].Value.ToString();
                Semester semester = SemesterControl.Instance.GetSemester(null).FirstOrDefault(s => $"{s.Term} - {s.Year}" == semesterVal);

                var faculty_course = new FacultyCourse
                {
                    Id = course_id,
                    Faculty = faculty,
                    Course = course,
                    Semester = semester
                };

                new AssignCourseDialog(faculty_course, "UPDATE").ShowDialog();
                AssignedCoursesRender(null);
            }
        }

        private void AssignCourseTeacher_Click(object sender, EventArgs e) {
            if (AssignedCoursesData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AssignedCoursesData.SelectedRows[0];

                int course_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                Faculty faculty = null;

                string courseName = selectedRow.Cells["course"].Value.ToString();
                Course course = CourseControl.Instance.GetCourse(null).FirstOrDefault(c => $"{c.Name} - {c.Type}" == courseName);

                string semesterVal = selectedRow.Cells["semester"].Value.ToString();
                Semester semester = SemesterControl.Instance.GetSemester(null).FirstOrDefault(s => $"{s.Term} - {s.Year}" == semesterVal);

                var faculty_course = new FacultyCourse
                {
                    Id = course_id,
                    Faculty = faculty,
                    Course = course,
                    Semester = semester
                };

                new AssignCourseDialog(faculty_course, "UPDATE").ShowDialog();
                AssignedCoursesRender(null);
            }
        }

        private void CourseSchedule_Click(object sender, EventArgs e) {
            if (AssignedCoursesData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AssignedCoursesData.SelectedRows[0];

                int course_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string facultyName = selectedRow.Cells["faculty"].Value.ToString();
                Faculty faculty = FacultyControl.Instance.GetFaculty(null, 'a').FirstOrDefault(f => f.Name == facultyName);

                string courseName = selectedRow.Cells["course"].Value.ToString();
                Course course = CourseControl.Instance.GetCourse(null).FirstOrDefault(c => $"{c.Name} - {c.Type}" == courseName);

                string semesterVal = selectedRow.Cells["semester"].Value.ToString();
                Semester semester = SemesterControl.Instance.GetSemester(null).FirstOrDefault(s => $"{s.Term} - {s.Year}" == semesterVal);

                var faculty_course = new FacultyCourse
                {
                    Id = course_id,
                    Faculty = faculty,
                    Course = course,
                    Semester = semester
                };

                new CourseScheduleDialog(faculty_course, "ADD").ShowDialog();
                AssignedCoursesRender(null);
            }
        }

        private void DeleteAssignedCourse_Click(object sender, EventArgs e) {
            if (AssignedCoursesData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AssignedCoursesData.SelectedRows[0];

                int course_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (CourseControl.Instance.DeleteAssignedCourse(course_id)) {
                    MessageBox.Show("Course Deleted Successfully", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AssignedCoursesRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Admin Roles
        private void AssignRoleBtn_Click(object sender, EventArgs e) {
            new AssignAdminRoleDialog("ASSIGN").ShowDialog();
            AdminRoleDataRender(null);
        }

        private void AdminRoleDataRender(string search) {
            List<AdminRole> roles = FacultyControl.Instance.GetAdminRoles(search);

            AdminRolesData.DataSource = roles;

            AdminRolesData.Columns["SrNo"].HeaderText = "#";
            AdminRolesData.Columns["Name"].HeaderText = "ROLE NAME";
            AdminRolesData.Columns["Faculty"].HeaderText = "FACULTY";
            AdminRolesData.Columns["Semester"].HeaderText = "SEMESTER";
            AdminRolesData.Columns["Id"].Visible = false;

            AdminRolesData.DefaultCellStyle.Font = new Font("Arial", 10);
            AdminRolesData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            AdminRolesData.RowTemplate.Height = 30;
            AdminRolesData.EnableHeadersVisualStyles = false;
            AdminRolesData.ColumnHeadersHeight = 50;
        }

        private void AdminRolesData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex >= 0) {
                AdminRolesData.Rows[e.RowIndex].Selected = true;
            }
        }

        private void RoleSearch_TextChanged(object sender, EventArgs e) {
            string search = RoleSearch.Text;
            AdminRoleDataRender(search);
        }

        private void RoleSearchBtn_Click(object sender, EventArgs e) {
            string search = RoleSearch.Text;
            AdminRoleDataRender(search);
        }
        
        private void AdminRolesData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                AdminRolesData.ClearSelection();
                AdminRolesData.Rows[e.RowIndex].Selected = true;

                var name = AdminRolesData.Rows[e.RowIndex].Cells["Faculty"].Value?.ToString();

                EditAdminRole.Click -= AssignTeacherAdminRole_Click;
                EditAdminRole.Click -= EditAdminRole_Click;

                if (name == "Not Assigned") {
                    EditAdminRole.Text = "Assign Role To Faculty";
                    EditAdminRole.Click += AssignTeacherAdminRole_Click;
                    EditAdminRole.Image = DBS25P023.Properties.Resources.edit;
                }
                else {
                    EditAdminRole.Text = "Update Admin Role";
                    EditAdminRole.Image = DBS25P023.Properties.Resources.edit;
                    EditAdminRole.Click += EditAdminRole_Click;
                }
            }
        }

        private void EditAdminRole_Click(object sender, EventArgs e) {
            if (AdminRolesData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AdminRolesData.SelectedRows[0];

                int role_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string name = selectedRow.Cells["Name"].Value.ToString();

                string facultyName = selectedRow.Cells["Faculty"].Value.ToString();
                Faculty faculty = FacultyControl.Instance.GetFaculty(null, 'a').FirstOrDefault(f => f.Name == facultyName);

                string semesterVal = selectedRow.Cells["Semester"].Value.ToString();
                Semester semester = SemesterControl.Instance.GetSemester(null).FirstOrDefault(s => $"{s.Term} - {s.Year}" == semesterVal);

                var role = new AdminRole
                {
                    Id = role_id,
                    Name = name,
                    Faculty = faculty,
                    Semester = semester
                };

                new AssignAdminRoleDialog(role, "UPDATE").ShowDialog();
                AdminRoleDataRender(null);
            }
        }

        private void AssignTeacherAdminRole_Click(object sender, EventArgs e) {
            if (AdminRolesData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AdminRolesData.SelectedRows[0];

                int role_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string name = selectedRow.Cells["Name"].Value.ToString();

                Faculty faculty = null;

                string semesterVal = selectedRow.Cells["Semester"].Value.ToString();
                Semester semester = SemesterControl.Instance.GetSemester(null).FirstOrDefault(s => $"{s.Term} - {s.Year}" == semesterVal);

                var role = new AdminRole
                {
                    Id = role_id,
                    Name = name,
                    Faculty = faculty,
                    Semester = semester
                };

                new AssignAdminRoleDialog(role, "UPDATE").ShowDialog();
                AdminRoleDataRender(null);
            }
        }

        private void DeleteAdminRole_Click(object sender, EventArgs e) {
            if (AdminRolesData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AdminRolesData.SelectedRows[0];

                int role_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var role = new AdminRole
                {
                    Id = role_id
                };

                if (FacultyControl.Instance.DeleteAdminRole(role)) {
                    MessageBox.Show("Admin Role Deleted Successfully", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminRoleDataRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AdminRolesData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (AdminRolesData.Columns[e.ColumnIndex].Name == "Faculty") {
                var name = e.Value.ToString();
                if (name == "Not Assigned") {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else {
                    e.CellStyle.BackColor = AdminRolesData.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = AdminRolesData.DefaultCellStyle.ForeColor;
                }
            }
        }

        #endregion

        #region Assign Project
        private void AssignProjectBtn_Click(object sender, EventArgs e) {
            new AssignFacultyProject("ASSIGN").ShowDialog();
            AssignProjectDataRender(null);
        }

        private void AssignProjectDataRender(string search) {
            List<FacultyProject> project = ProjectControl.Instance.GetAssignedProjects(search);

            AssignProjectData.DataSource = project;

            AssignProjectData.Columns["SrNo"].HeaderText = "#";
            AssignProjectData.Columns["Faculty"].HeaderText = "FACULTY";
            AssignProjectData.Columns["Project"].HeaderText = "PROJECT";
            AssignProjectData.Columns["Semester"].HeaderText = "SEMESTER";
            AssignProjectData.Columns["SuperVisionHours"].HeaderText = "SUPERVISON HOURS";
            AssignProjectData.Columns["Id"].Visible = false;

            AssignProjectData.DefaultCellStyle.Font = new Font("Arial", 10);
            AssignProjectData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            AssignProjectData.RowTemplate.Height = 30;
            AssignProjectData.EnableHeadersVisualStyles = false;
            AssignProjectData.ColumnHeadersHeight = 50;
        }

        private void AssignProjectData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                AssignProjectData.Rows[e.RowIndex].Selected = true;
            }
        }

        private void AssignProjectData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                AssignProjectData.ClearSelection();
                AssignProjectData.Rows[e.RowIndex].Selected = true;

                var name = AssignProjectData.Rows[e.RowIndex].Cells["Faculty"].Value?.ToString();

                EditAssignProject.Click -= AssignProjectSupervisor_Click;
                EditAssignProject.Click -= EditAssignProject_Click;

                if (name == "Not Assigned") {
                    EditAssignProject.Text = "Assign Project To Faculty";
                    EditAssignProject.Image = DBS25P023.Properties.Resources.edit;
                    EditAssignProject.Click += AssignProjectSupervisor_Click;
                }
                else {
                    EditAssignProject.Text = "Update Faculty Project";
                    EditAssignProject.Image = DBS25P023.Properties.Resources.edit;
                    EditAssignProject.Click += EditAssignProject_Click;
                }
            }
        }

        private void AssignProjectData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (AssignProjectData.Columns[e.ColumnIndex].Name == "Faculty") {
                var name = e.Value.ToString();
                if (name == "Not Assigned") {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else {
                    e.CellStyle.BackColor = AssignProjectData.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = AssignProjectData.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void AssignProjectSearch_TextChanged(object sender, EventArgs e) {
            string search = AssignProjectSearch.Text;
            AssignProjectDataRender(search);
        }

        private void AssignProjectSearchBtn_Click(object sender, EventArgs e) {
            string search = AssignProjectSearch.Text;
            AssignProjectDataRender(search);
        }

        private void EditAssignProject_Click(object sender, EventArgs e) {
            if (AssignProjectData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AssignProjectData.SelectedRows[0];

                int project_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string facultyName = selectedRow.Cells["Faculty"].Value.ToString();
                Faculty faculty = FacultyControl.Instance.GetFaculty(null, 'a').FirstOrDefault(f => f.Name == facultyName);

                string projectName = selectedRow.Cells["Project"].Value.ToString();
                Project project = ProjectControl.Instance.GetProjects(null).FirstOrDefault(p => p.Title == projectName);

                string semesterVal = selectedRow.Cells["Semester"].Value.ToString();
                Semester semester = SemesterControl.Instance.GetSemester(null).FirstOrDefault(s => $"{s.Term} - {s.Year}" == semesterVal);

                int hours = Convert.ToInt32(selectedRow.Cells["SuperVisionHours"].Value);

                var faculty_project = new FacultyProject
                {
                    Id = project_id,
                    Faculty = faculty,
                    Semester = semester,
                    Project = project,
                    SuperVisionHours = hours
                };

                new AssignFacultyProject(faculty_project, "UPDATE").ShowDialog();
                AssignProjectDataRender(null);
            }
        }

        private void AssignProjectSupervisor_Click(object sender, EventArgs e) {
            if (AssignProjectData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AssignProjectData.SelectedRows[0];

                int project_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                Faculty faculty = null;

                string projectName = selectedRow.Cells["Project"].Value.ToString();
                Project project = ProjectControl.Instance.GetProjects(null).FirstOrDefault(p => p.Title == projectName);

                string semesterVal = selectedRow.Cells["Semester"].Value.ToString();
                Semester semester = SemesterControl.Instance.GetSemester(null).FirstOrDefault(s => $"{s.Term} - {s.Year}" == semesterVal);

                int hours = Convert.ToInt32(selectedRow.Cells["SuperVisionHours"].Value);

                var faculty_project = new FacultyProject
                {
                    Id = project_id,
                    Faculty = faculty,
                    Semester = semester,
                    Project = project,
                    SuperVisionHours = hours
                };

                new AssignFacultyProject(faculty_project, "UPDATE").ShowDialog();
                AssignProjectDataRender(null);
            }
        }

        private void DeleteAssignProject_Click(object sender, EventArgs e) {
            if (AssignProjectData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AssignProjectData.SelectedRows[0];

                int project_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var project = new FacultyProject
                {
                    Id = project_id
                };

                if (ProjectControl.Instance.DeleteAssignedProject(project.Id)) {
                    MessageBox.Show("Assigned Project Deleted Successfully", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AssignProjectDataRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        #endregion

        private void ScheduleDataRender(string search) {
            List<CourseSchedule> schedules = CourseScheduleControl.Instance.GetSchedule(search);
            ScheduleData.DataSource = schedules;

            ScheduleData.Columns["SrNo"].HeaderText = "#";
            ScheduleData.Columns["FacultyCourse"].HeaderText = "FACULTY COURSE";
            ScheduleData.Columns["Room"].HeaderText = "ROOM";
            ScheduleData.Columns["DayofWeek"].HeaderText = "DAY";
            ScheduleData.Columns["StartTime"].HeaderText = "START TIME";
            ScheduleData.Columns["EndTime"].HeaderText = "END TIME";

            ScheduleData.Columns["Id"].Visible = false;

            ScheduleData.DefaultCellStyle.Font = new Font("Arial", 10);
            ScheduleData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            ScheduleData.RowTemplate.Height = 30;
            ScheduleData.EnableHeadersVisualStyles = false;
            ScheduleData.ColumnHeadersHeight = 50;
        }

        private void ScheduleDataSearch_TextChanged(object sender, EventArgs e) {
            string search = ScheduleDataSearch.Text;
            ScheduleDataRender(search);
        }

        private void ScheduleDataSearchBtn_Click(object sender, EventArgs e) {
            string search = ScheduleDataSearch.Text;
            ScheduleDataRender(search);
        }

        private void ScheduleData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                ScheduleData.Rows[e.RowIndex].Selected = true;
            }
        }

        private void EditSchedule_Click(object sender, EventArgs e) {
            if (ScheduleData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = ScheduleData.SelectedRows[0];

                int schedule_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);


                string facultyCoursValue = selectedRow.Cells["FacultyCourse"].Value.ToString();

                FacultyCourse facultyCourse = CourseControl.Instance.GetAssignedCourses(null).FirstOrDefault(fc => $"{fc.Faculty} - {fc.Course}" == facultyCoursValue);

                string roomName = selectedRow.Cells["Room"].Value.ToString();
                Room room = RoomControl.Instance.GetRoom(null).FirstOrDefault(r => r.Name == roomName);

                string day_of_week = selectedRow.Cells["DayofWeek"].Value.ToString();
                string start_time = selectedRow.Cells["StartTime"].Value.ToString();
                string end_time = selectedRow.Cells["EndTime"].Value.ToString();

                var schedule = new CourseSchedule
                {
                    Id = schedule_id,
                    FacultyCourse = facultyCourse,
                    Room = room,
                    DayofWeek = day_of_week,
                    StartTime = start_time,
                    EndTime = end_time
                };

                new CourseScheduleDialog(schedule, "UPDATE").ShowDialog();
                ScheduleDataRender(null);
            }
        }

        private void DeleteSchedule_Click(object sender, EventArgs e) {
            if (ScheduleData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = ScheduleData.SelectedRows[0];

                int schedule_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (CourseScheduleControl.Instance.DeleteSchedule(schedule_id)) {
                    MessageBox.Show("Schedule Deleted Successfully", "Schedule Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ScheduleDataRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Schedule Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
