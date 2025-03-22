using DBS25P023.Controllers;
using DBS25P023.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace DBS25P023.Dialogs {
    public partial class AssignCourseDialog : Form {
        private string Action;

        int selected_faculty_course = -1;
        Faculty selected_faculty = null;
        Course selected_course = null;
        Semester selected_semester = null;

        public AssignCourseDialog(string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateData();
        }

        public AssignCourseDialog(Faculty faculty, string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateData();

            selected_faculty = faculty;


            for (int i = 0; i < FacultySelection.Items.Count; i++) {
                var item = FacultySelection.Items[i] as Faculty; // Assuming FacultySelection contains Faculty objects
                if (item != null && item.Id == faculty.Id) {
                    FacultySelection.SelectedIndex = i;
                    break; // Exit the loop once the item is selected
                }
            }
        }

        public AssignCourseDialog(FacultyCourse facultyCourse, string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateData();

            selected_faculty_course = facultyCourse.Id;

            selected_faculty = facultyCourse.faculty;
            if(selected_faculty != null) {
                for (int i = 0; i < FacultySelection.Items.Count; i++) {
                    Faculty item = FacultySelection.Items[i] as Faculty; // Assuming FacultySelection contains Faculty objects
                    if (item != null && item.Id == facultyCourse.faculty.Id) {
                        FacultySelection.SelectedIndex = i;
                        break; // Exit the loop once the item is selected
                    }
                }
            }
            
            selected_course = facultyCourse.course;
            CourseSelection.SelectedIndex = facultyCourse.course.SrNo - 1;

            selected_semester = facultyCourse.semester;
            SemesterSelection.SelectedIndex = facultyCourse.semester.SrNo - 1;
        }

        private void AssignCourseDialog_Load(object sender, EventArgs e) {
            Title.Text = $"{Action} {Title.Text}";
            this.ActionBtn.Text = Action;
            this.Text = Action + " Course";
        }
        
        private void PopulateData() {
            PopulateCourse();
            PopulateFaculty();
            PopulateSemester();
        }

        private void PopulateFaculty() {
            FacultySelection.Items.Clear();
            List<Faculty> faculty = FacultyControl.Instance.GetFaculty(null, 'a');
            FacultySelection.Items.AddRange(faculty.ToArray());
        }

        private void PopulateCourse() {
            CourseSelection.Items.Clear();
            List<Course> courses = CourseControl.Instance.GetCourse(null);
            CourseSelection.Items.AddRange(courses.ToArray());
        }

        private void PopulateSemester() { 
            SemesterSelection.Items.Clear();
            List<Semester> semesters = SemesterControl.Instance.GetSemester(null);
            SemesterSelection.Items.AddRange(semesters.ToArray());
        }

        private void FacultySelection_SelectedIndexChanged(object sender, EventArgs e) {
            if (FacultySelection.SelectedItem is Faculty selectedFaculty) {
                selected_faculty = selectedFaculty;
            }
        }

        private void CourseSelection_SelectedIndexChanged(object sender, EventArgs e) {
            if (CourseSelection.SelectedItem is Course selectedCourse) { 
                selected_course = selectedCourse;
            }
        }

        private void AddCourse_Click(object sender, EventArgs e) {
            new CourseDialog("ADD").ShowDialog();
            PopulateCourse();
        }

        private void SemesterSelection_SelectedIndexChanged(object sender, EventArgs e) {
            if(SemesterSelection.SelectedItem is Semester semester) {
                selected_semester = semester;
            }
        }

        private void AddSemester_Click(object sender, EventArgs e) {
            new SemesterDialog("ADD").ShowDialog();
            PopulateSemester();
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            if (selected_course == null || selected_semester == null) {
                MessageBox.Show("Course and Semester Fields are Required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FacultyCourse course = new FacultyCourse
            {
                faculty = selected_faculty,
                course = selected_course,
                semester = selected_semester
            };

            if(Action == "ASSIGN") {
                if (CourseControl.Instance.SearchAssignedCourse(course, 'l')) {
                    MessageBox.Show("Already Assigned", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CourseControl.Instance.AssignCourse(course)) {
                    MessageBox.Show("Course Assigned Successfully!", "Assign Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Assign Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                course.Id = selected_faculty_course;
                if (CourseControl.Instance.SearchAssignedCourse(course, 'u')) {
                    MessageBox.Show("Already Assigned", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CourseControl.Instance.UpdateAssignedCourse(course)) {
                    MessageBox.Show("Updated Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Close();
        }
    }
}
