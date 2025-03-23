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
    public partial class CourseScheduleDialog : Form {

        int selected_course_schedule = -1;
        Room selected_room = null;
        Faculty selected_faculty = null;
        Course selected_course = null;
        FacultyCourse selected_faculty_course = null;
        string end_time;

        private string Action;

        public CourseScheduleDialog(FacultyCourse facultyCourse, string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateRoom();

            selected_faculty_course = facultyCourse;

            selected_faculty = facultyCourse.Faculty;
            FacultyName.Text = selected_faculty.Name;

            selected_course = facultyCourse.Course;
            CourseName.Text = selected_course.ToString();

            CalculateEndTime();
        }

        public CourseScheduleDialog(CourseSchedule schedule, string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateRoom();

            selected_course_schedule = schedule.Id;

            selected_faculty_course = schedule.FacultyCourse;

            selected_faculty = schedule.FacultyCourse.Faculty;
            FacultyName.Text = selected_faculty.Name;

            selected_course = schedule.FacultyCourse.Course;
            CourseName.Text = selected_course.ToString();

            if (DateTime.TryParse(schedule.StartTime, out DateTime startTime)) {
                StartTime.Value = startTime;
            }

            end_time = schedule.EndTime;

            DaySelection.Text = schedule.DayofWeek;

            selected_room = schedule.Room;
            RoomSelection.SelectedIndex = schedule.Room.SrNo - 1;

        }

        private void PopulateRoom() {
            RoomSelection.Items.Clear();
            List<Room> room = RoomControl.Instance.GetRoom(null);
            RoomSelection.Items.AddRange(room.ToArray());
        }

        private void RoomSelection_SelectedIndexChanged(object sender, EventArgs e) {
            if (RoomSelection.SelectedItem is Room selectedRoom) {
                selected_room = selectedRoom;
            }
        }

        private void StartTIme_ValueChanged(object sender, EventArgs e) {
            CalculateEndTime();
        }

        private void CalculateEndTime() {
            TimeSpan courseDuration = TimeSpan.FromHours(selected_course.ContactHours);
            DateTime startTime = StartTime.Value;
            DateTime calculatedEndTime = startTime.Add(courseDuration);

            end_time = calculatedEndTime.ToString("HH:mm:ss");
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(DaySelection.Text) || selected_room == null) {
                MessageBox.Show("Please fill all Fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CourseSchedule courseSchedule = new CourseSchedule
            {
                FacultyCourse = selected_faculty_course,
                Room = selected_room,
                DayofWeek = DaySelection.Text,
                StartTime = StartTime.Text,
                EndTime = end_time
            };

            if (Action == "ADD") {

                if (CourseScheduleControl.Instance.AddSchedule(courseSchedule)) {
                    MessageBox.Show("Schedule Added Successfully!", "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                courseSchedule.Id = selected_course_schedule;

                if (CourseScheduleControl.Instance.UpdateSchedule(courseSchedule)) {
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
