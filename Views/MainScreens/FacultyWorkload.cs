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

namespace DBS25P023.Views.MainScreens {
    public partial class FacultyWorkload: UserControl
    {
        public FacultyWorkload()
        {
            InitializeComponent();
        }

        private void FacultyWorkload_Load(object sender, EventArgs e) {
            CourseDataRender(null);
            ProjectDataRender(null);
            SemesterDataRender(null);
        }

        #region Course
        private void NewCourse_Click(object sender, EventArgs e) {
            new CourseDialog("ADD").ShowDialog();
            CourseDataRender(null);
        }

        private void CourseDataRender(string search) {
            List<Course> courses = CourseControl.Instance.GetCourse(search);
            CourseData.DataSource = courses;

            int idx = 1;
            foreach (var course in courses) {
                course.SrNo = idx++;
            }

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

            int idx = 1;
            foreach (Project project in projects) { 
                project.SrNo = idx++;
            }

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
            int idx = 1;
            foreach (Semester semester in semesters) {
                semester.SrNo = idx++;
            }

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


    }
}
