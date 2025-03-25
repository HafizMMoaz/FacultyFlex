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
    public partial class ResourceAllocation: UserControl
    {
        // current login user
        string user_role = Session.LoggedInFaculty?.Role?.Value ?? "";

        public ResourceAllocation()
        {
            InitializeComponent();
            if (user_role == "Faculty") {
                AssignRoomBtn.Visible = false;
                Tabs.TabPages.Remove(Rooms);
                Tabs.TabPages.Remove(Consumables);
                RoomControls.Items.Clear();
                ConsumablesControls.Items.Clear();
            }
        }

        private void ResourceAllocation_Load(object sender, EventArgs e) {
            RefreshData();
        }

        public void RefreshData() {
            AssignRoomsDataRender(null);
            if(user_role != "Faculty"){
                RoomDataRender(null);
                ConsumablesDataRender(null);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e) {
            RefreshData();
            new FacultyWorkload().RefreshData();
            new UserManagement().RefreshData();
            new FacultyRequests().RefreshData();
            new Dashboard().RefreshData();
        }

        private void AddRoomBtn_Click(object sender, EventArgs e) {
            new RoomDialog("ADD").ShowDialog();
            RoomDataRender(null);
        }

        private void RoomDataRender(string search) {
            List<Room> rooms = RoomControl.Instance.GetRoom(search);

            RoomData.DataSource = rooms;

            RoomData.Columns["SrNo"].HeaderText = "#";
            RoomData.Columns["Name"].HeaderText = "NAME";
            RoomData.Columns["Type"].HeaderText = "TYPE";
            RoomData.Columns["Capacity"].HeaderText = "CAPACITY";
            RoomData.Columns["Id"].Visible = false;

            RoomData.DefaultCellStyle.Font = new Font("Arial", 10);
            RoomData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            RoomData.RowTemplate.Height = 30;
            RoomData.EnableHeadersVisualStyles = false;
            RoomData.ColumnHeadersHeight = 50;
        }

        private void RoomSearch_TextChanged(object sender, EventArgs e) {
            string search = RoomSearch.Text;
            RoomDataRender(search);
        }

        private void RoomSearchBtn_Click(object sender, EventArgs e) {
            string search = RoomSearch.Text;
            RoomDataRender(search);
        }

        private void RoomData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                RoomData.Rows[e.RowIndex].Selected = true;
            }
        }

        private void EditRoom_Click(object sender, EventArgs e) {
            if (RoomData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = RoomData.SelectedRows[0];

                int room_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string name = selectedRow.Cells["Name"].Value.ToString();
                string type = selectedRow.Cells["Type"].Value.ToString();
                int capcity = Convert.ToInt32(selectedRow.Cells["Capacity"].Value);


                var room = new Room
                {
                    Id = room_id,
                    Name = name,
                    Type = type,
                    Capacity = capcity
                };

                new RoomDialog("UPDATE", room).ShowDialog();
                RoomDataRender(null);
            }
        }

        private void DeleteRoom_Click(object sender, EventArgs e) {
            if (RoomData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = RoomData.SelectedRows[0];

                int room_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (RoomControl.Instance.DeleteRoom(room_id)) {
                    MessageBox.Show("Room Deleted Successfully", "Room Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RoomDataRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Room Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }



        private void AssignRoomBtn_Click(object sender, EventArgs e) {
            new AssignRoomDialog("ASSIGN").ShowDialog();
            AssignRoomsDataRender(null);
        }

        private void AssignRoomsDataRender(string search) {
            List<FacultyRoom> rooms = RoomControl.Instance.GetAssignedRooms(search);
            AssignedRoomsData.DataSource = rooms;

            AssignedRoomsData.Columns["SrNo"].HeaderText = "#";
            AssignedRoomsData.Columns["Faculty"].HeaderText = "FACULTY";
            AssignedRoomsData.Columns["Room"].HeaderText = "ROOM";
            AssignedRoomsData.Columns["Semester"].HeaderText = "SEMESTER";
            AssignedRoomsData.Columns["ReservedHours"].HeaderText = "HOURS";
            AssignedRoomsData.Columns["Id"].Visible = false;

            AssignedRoomsData.DefaultCellStyle.Font = new Font("Arial", 10);
            AssignedRoomsData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            AssignedRoomsData.RowTemplate.Height = 30;
            AssignedRoomsData.EnableHeadersVisualStyles = false;
            AssignedRoomsData.ColumnHeadersHeight = 50;
        }

        private void AssignedRoomsData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                AssignedRoomsData.Rows[e.RowIndex].Selected = true;
            }
        }

        private void AssignedRoomsData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                AssignedRoomsData.ClearSelection();
                AssignedRoomsData.Rows[e.RowIndex].Selected = true;

                var name = AssignedRoomsData.Rows[e.RowIndex].Cells["Faculty"].Value?.ToString();

                EditAssignRoom.Click -= AssignRoomToFaculty_Click;
                EditAssignRoom.Click -= EditAssignRoom_Click;

                if (name == "Not Assigned") {
                    EditAssignRoom.Text = "Assign Faculty To Room";
                    EditAssignRoom.Click += AssignRoomToFaculty_Click;
                    EditAssignRoom.Image = DBS25P023.Properties.Resources.edit;
                }
                else {
                    EditAssignRoom.Text = "Update Assigned Room";
                    EditAssignRoom.Image = DBS25P023.Properties.Resources.edit;
                    EditAssignRoom.Click += EditAssignRoom_Click;
                }
            }
        }

        private void AssignedRoomsData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (AssignedRoomsData.Columns[e.ColumnIndex].Name == "Faculty") {
                var name = e.Value.ToString();
                if (name == "Not Assigned") {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else {
                    e.CellStyle.BackColor = AssignedRoomsData.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = AssignedRoomsData.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void AssignedRoomSearch_TextChanged(object sender, EventArgs e) {
            string search = AssignedRoomSearch.Text;
            AssignRoomsDataRender(search);
        }

        private void AssignedRoomSearchBtn_Click(object sender, EventArgs e) {
            string search = AssignedRoomSearch.Text;
            AssignRoomsDataRender(search);
        }

        private void EditAssignRoom_Click(object sender, EventArgs e) {
            if (AssignedRoomsData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AssignedRoomsData.SelectedRows[0];
                int allocationId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                int reserved_hours = Convert.ToInt32(selectedRow.Cells["ReservedHours"].Value);

                string facultyName = selectedRow.Cells["Faculty"].Value.ToString();
                Faculty faculty = FacultyControl.Instance.GetFaculty(null, 'a').FirstOrDefault(f => f.Name == facultyName);

                string roomName = selectedRow.Cells["Room"].Value.ToString();
                Room room = RoomControl.Instance.GetRoom(null).FirstOrDefault(r => r.Name == roomName);

                string semesterVal = selectedRow.Cells["Semester"].Value.ToString();
                Semester semester = SemesterControl.Instance.GetSemester(null).FirstOrDefault(s => $"{s.Term} - {s.Year}" == semesterVal);

                var facultyRoom = new FacultyRoom
                {
                    Id = allocationId,
                    Faculty = faculty,
                    Room = room,
                    Semester = semester,
                    ReservedHours = reserved_hours
                };

                new AssignRoomDialog(facultyRoom, "UPDATE").ShowDialog();
                AssignRoomsDataRender(null);
            }
        }

        private void AssignRoomToFaculty_Click(object sender, EventArgs e) {
            if (AssignedRoomsData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AssignedRoomsData.SelectedRows[0];
                int allocationId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                Faculty faculty = null;

                string roomName = selectedRow.Cells["Room"].Value.ToString();
                Room room = RoomControl.Instance.GetRoom(null).FirstOrDefault(r => r.Name == roomName);

                string semesterVal = selectedRow.Cells["Semester"].Value.ToString();
                Semester semester = SemesterControl.Instance.GetSemester(null).FirstOrDefault(s => $"{s.Term} - {s.Year}" == semesterVal);

                var facultyRoom = new FacultyRoom
                {
                    Id = allocationId,
                    Faculty = faculty,
                    Room = room,
                    Semester = semester
                };

                new AssignRoomDialog(facultyRoom, "UPDATE").ShowDialog();
                AssignRoomsDataRender(null);
            }
        }

        private void DeleteAssignRoom_Click(object sender, EventArgs e) {
            if (AssignedRoomsData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = AssignedRoomsData.SelectedRows[0];
                int allocationId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (RoomControl.Instance.DeleteAssignedRoom(allocationId)) {
                    MessageBox.Show("Room Assignment Deleted Successfully", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AssignRoomsDataRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void NewItem_Click(object sender, EventArgs e) {
            new ConsumableDialog("ADD").ShowDialog();
            ConsumablesDataRender(null);
        }

        private void ConsumablesDataRender(string search) {
            List<Consumable> consumables = ConsumableControl.Instance.GetConsumables(search);

            ConsumablesData.DataSource = consumables;

            ConsumablesData.Columns["SrNo"].HeaderText = "#";
            ConsumablesData.Columns["Name"].HeaderText = "ITEM NAME";
            ConsumablesData.Columns["Id"].Visible = false;

            ConsumablesData.DefaultCellStyle.Font = new Font("Arial", 10);
            ConsumablesData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            ConsumablesData.RowTemplate.Height = 30;
            ConsumablesData.EnableHeadersVisualStyles = false;
            ConsumablesData.ColumnHeadersHeight = 50;
        }

        private void SearchItem_TextChanged(object sender, EventArgs e) {
            string search = SearchItem.Text;
            ConsumablesDataRender(search);
        }

        private void SearchItemBtn_Click(object sender, EventArgs e) {
            string search = SearchItem.Text;
            ConsumablesDataRender(search);
        }

        private void ConsumablesData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                ConsumablesData.Rows[e.RowIndex].Selected = true;
            }
        }

        private void EditItem_Click(object sender, EventArgs e) {
            if (ConsumablesData.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = ConsumablesData.SelectedRows[0];

                int consumable_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string name = selectedRow.Cells["Name"].Value.ToString();

                var consumable = new Consumable
                {
                    Id = consumable_id,
                    Name = name
                };

                new ConsumableDialog("UPDATE", consumable).ShowDialog();
                ConsumablesDataRender(null);
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e) {
            if (ConsumablesData.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = ConsumablesData.SelectedRows[0];

                int consumable_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (ConsumableControl.Instance.DeleteConsumable(consumable_id)) {
                    MessageBox.Show("Consumable Deleted Successfully", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConsumablesDataRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
