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
    public partial class AssignRoomDialog : Form {
        private string Action;

        int selected_faculty_room = -1;
        Faculty selected_faculty = null;
        Room selected_room = null;
        Semester selected_semester = null;

        public AssignRoomDialog(string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateData();
        }

        public AssignRoomDialog(Faculty faculty, string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateData();

            selected_faculty = faculty;


            for (int i = 0; i < FacultySelection.Items.Count; i++) {
                Faculty item = FacultySelection.Items[i] as Faculty; // Assuming FacultySelection contains Faculty objects
                if (item != null && item.Id == faculty.Id) {
                    FacultySelection.SelectedIndex = i;
                    break; // Exit the loop once the item is selected
                }
            }
        }

        public AssignRoomDialog(FacultyRoom room, string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateData();

            selected_faculty_room = room.Id;

            ReservedHours.Text = room.ReservedHours.ToString();

            selected_faculty = room.Faculty;
            if (selected_faculty != null) {
                for (int i = 0; i < FacultySelection.Items.Count; i++) {
                    Faculty item = FacultySelection.Items[i] as Faculty; // Assuming FacultySelection contains Faculty objects
                    if (item != null && item.Id == room.Faculty.Id) {
                        FacultySelection.SelectedIndex = i;
                        break; // Exit the loop once the item is selected
                    }
                }
            }

            selected_room = room.Room;
            RoomSelection.SelectedIndex = room.Room.SrNo - 1;

            selected_semester = room.Semester;
            SemesterSelection.SelectedIndex = room.Semester.SrNo - 1;
        }

        private void AssignRoomDialog_Load(object sender, EventArgs e) {
            Title.Text = $"{Action} {Title.Text}";
            this.ActionBtn.Text = Action;
            this.Text = Action + " Room";
        }

        private void PopulateData() {
            PopulateRoom();
            PopulateFaculty();
            PopulateSemester();
        }

        private void PopulateFaculty() {
            FacultySelection.Items.Clear();
            List<Faculty> faculty = FacultyControl.Instance.GetFaculty(null, 'a');
            FacultySelection.Items.AddRange(faculty.ToArray());
        }

        private void PopulateRoom() {
            RoomSelection.Items.Clear();
            List<Room> room = RoomControl.Instance.GetRoom(null);
            RoomSelection.Items.AddRange(room.ToArray());
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

        private void RoomSelection_SelectedIndexChanged(object sender, EventArgs e) {
            if (RoomSelection.SelectedItem is Room selectedRoom) {
                selected_room = selectedRoom;
            }
        }

        private void AddRoom_Click(object sender, EventArgs e) {
            new RoomDialog("ADD").ShowDialog();
            PopulateRoom();
        }

        private void SemesterSelection_SelectedIndexChanged(object sender, EventArgs e) {
            if (SemesterSelection.SelectedItem is Semester semester) {
                selected_semester = semester;
            }
        }

        private void AddSemester_Click(object sender, EventArgs e) {
            new SemesterDialog("ADD").ShowDialog();
            PopulateSemester();
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            if (selected_room == null || selected_semester == null || string.IsNullOrEmpty(ReservedHours.Text)) {
                MessageBox.Show("Room, Semester and SuperVisionHours are Required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ReservedHours.Text, out _)) {
                MessageBox.Show("Please Enter Integer in SuperVision Hours", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FacultyRoom room = new FacultyRoom
            {
                Faculty = selected_faculty,
                Semester = selected_semester,
                Room = selected_room,
                ReservedHours = Convert.ToInt32(ReservedHours.Text)
            };

            if (Action == "ASSIGN") {
                if (RoomControl.Instance.SearchAssignedRoom(room, 'l')) {
                    MessageBox.Show("Already Assigned", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (RoomControl.Instance.AssignRoom(room)) {
                    MessageBox.Show("Room Assigned Successfully!", "Assign Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Assign Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                room.Id = selected_faculty_room;
                if (RoomControl.Instance.SearchAssignedRoom(room, 'u')) {
                    MessageBox.Show("Already Assigned", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (RoomControl.Instance.UpdateAssignedRoom(room)) {
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
