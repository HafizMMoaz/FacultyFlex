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

namespace DBS25P023.Dialogs {
    public partial class NewCourseDialog : Form {
        private string Action;
        private int selected_course = -1;
        public NewCourseDialog(string Action) {
            InitializeComponent();
            this.Action = Action;
        }

        public NewCourseDialog(string Action, Course course) {
            InitializeComponent();
            this.Action = Action;

            selected_course = course.Id;
            CourseName.Text = course.Name;
            CourseType.Text = course.Type;
            CourseCreditHour.Text = course.CreditHours.ToString();
            CourseContactHour.Text = course.ContactHours.ToString();
        }

        private void NewCourseDialog_Load(object sender, EventArgs e) {
            Title.Text = $"{Action} {Title.Text}";
            this.ActionBtn.Text = Action;
            this.Text = Action + " Course";
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(CourseName.Text)
               || string.IsNullOrEmpty(CourseType.Text)
               || string.IsNullOrEmpty(CourseContactHour.Text)
               || string.IsNullOrEmpty(CourseCreditHour.Text)) {
                MessageBox.Show("Please fill all Fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(CourseContactHour.Text, out int number)) {
                MessageBox.Show("Please Enter Integer in Contact Hours", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(CourseCreditHour.Text, out int num)) {
                MessageBox.Show("Please Enter Integer in Credit Hours", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Course course = new Course
            {
                Name = CourseName.Text,
                Type = CourseType.Text,
                CreditHours = Convert.ToInt32(CourseCreditHour.Text),
                ContactHours = Convert.ToInt32(CourseContactHour.Text)
            };

            if (Action == "ADD") {
                if (CourseControl.Instance.SearchCourse(course, 'l')) {
                    MessageBox.Show("Course Name not available", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CourseControl.Instance.AddCourse(course)) {
                    MessageBox.Show("Course Add Successfully!", "ADD Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "ADD Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                course.Id = selected_course;
                if (CourseControl.Instance.SearchCourse(course, 'u')) {
                    MessageBox.Show("Course Name not available", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CourseControl.Instance.UpdateCourse(course)) {
                    MessageBox.Show("Course Updated Successfully!", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Close();

        }
    }
}
