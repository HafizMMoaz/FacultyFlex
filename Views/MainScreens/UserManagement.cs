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
using DBS25P023.Views.Auth;

namespace DBS25P023.Views.MainScreens {
    public partial class UserManagement: UserControl
    {
        // current login user
        string user_role = Session.LoggedInFaculty?.Role?.Value ?? "";

        public UserManagement()
        {
            InitializeComponent();
        }
        private void UserManagement_Load(object sender, EventArgs e) {
            RefreshData();
        }

        public void RefreshData() {
            UserDataRender(null);
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            new FacultyUserDialog("ADD").ShowDialog();
            UserDataRender(null);
        }

        private void UserDataRender(string search) {
            List<Faculty> facultyList = FacultyControl.Instance.GetFaculty(search, 'f');

            int idx = 1;
            foreach (var faculty in facultyList) {
                faculty.SrNo = idx++;
            }

            UserData.DataSource = facultyList;
            UserData.Columns["SrNo"].HeaderText = "#";
            UserData.Columns["Username"].HeaderText = "USERNAME";
            UserData.Columns["Name"].HeaderText = "NAME";
            UserData.Columns["Email"].HeaderText = "EMAIL";
            UserData.Columns["Contact"].HeaderText = "CONTACT";
            UserData.Columns["Role"].HeaderText = "ROLE";
            UserData.Columns["Designation"].HeaderText = "DESIGNATION";
            UserData.Columns["User_id"].Visible = false;
            UserData.Columns["Id"].Visible = false;
            UserData.Columns["Password"].Visible = false;
            UserData.Columns["TeachingHours"].Visible = false;
            UserData.Columns["ResearchArea"].Visible = false;

            UserData.DefaultCellStyle.Font = new Font("Arial", 10);
            UserData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            UserData.RowTemplate.Height = 30;
            UserData.EnableHeadersVisualStyles = false;
            UserData.ColumnHeadersHeight = 50;
        }

        private void UserData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                UserData.Rows[e.RowIndex].Selected = true;
            }
        }

        private void UserData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (UserData.Columns[e.ColumnIndex].Name == "Name") {
                var name = e.Value.ToString();
                var id = Convert.ToInt32(UserData.Rows[e.RowIndex].Cells["Id"].Value);
                if (name == "Not Approved" && id == 0) {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else {
                    e.CellStyle.BackColor = UserData.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = UserData.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void UserData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                UserData.ClearSelection();
                UserData.Rows[e.RowIndex].Selected = true;

                var name = UserData.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                var id = Convert.ToInt32(UserData.Rows[e.RowIndex].Cells["Id"].Value);

                ApproveFaculty.Click -= ApproveFaculty_Click;
                ApproveFaculty.Click -= EditFaculty_Click;

                if (user_role == "Department Head") {
                    DeleteUser.Visible = false;
                }

                if (name == "Not Approved" && id == 0) {
                    AssignCourse.Visible = false;
                    AssignProject.Visible = false;
                    AllocateRoom.Visible = false;
                    AssignAdminRole.Visible = false;

                    if (user_role == "Department Head") {
                        ApproveFaculty.Visible = false;
                    }
                    else {
                        ApproveFaculty.Visible = true;
                    }

                    ApproveFaculty.Text = "Approve Faculty";
                    ApproveFaculty.Click += ApproveFaculty_Click;
                    ApproveFaculty.Image = DBS25P023.Properties.Resources.approve;
                }
                else {
                    AssignCourse.Visible = true;
                    AssignProject.Visible = true;
                    AllocateRoom.Visible = true;
                    AssignAdminRole.Visible = true;
                    ApproveFaculty.Visible = true;
                    ApproveFaculty.Text = "Update Faculty";
                    ApproveFaculty.Image = DBS25P023.Properties.Resources.edit;
                    ApproveFaculty.Click += EditFaculty_Click;
                }
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e) {
            if (UserData.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = UserData.SelectedRows[0];

                int userId = Convert.ToInt32(selectedRow.Cells["User_id"].Value);

                if (FacultyControl.Instance.DeleteFaculty(userId)) {
                    MessageBox.Show("Faculty Deleted Successfully", "Faculty Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserDataRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Faculty Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void EditUser_Click(object sender, EventArgs e) {
            if (UserData.SelectedRows.Count > 0) {
                
                DataGridViewRow selectedRow = UserData.SelectedRows[0];

                int userId = Convert.ToInt32(selectedRow.Cells["User_id"].Value);
                string username = selectedRow.Cells["Username"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string roleName = selectedRow.Cells["Role"].Value.ToString();

                Role selectedRole = LookUpControl.Instance.GetRoles().FirstOrDefault(r => r.Value == roleName);

                var faculty = new Faculty
                {
                    User_id = userId,
                    Username = username,
                    Email = email,
                    Role = selectedRole
                };

                new FacultyUserDialog(faculty, "UPDATE").ShowDialog();
                UserDataRender(null);
            }
        }

        private void ApproveFaculty_Click(object sender, EventArgs e) {
            if(UserData.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = UserData.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["User_id"].Value);
                string email = selectedRow.Cells["Email"].Value.ToString();

                var faculty = new Faculty
                {
                    User_id = userId,
                    Email = email
                };

                new FacultyDialog("APPROVE", faculty).ShowDialog();
                UserDataRender(null);
            }
        }

        private void EditFaculty_Click(object sender, EventArgs e) {
            if (UserData.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = UserData.SelectedRows[0];
                int Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string name = selectedRow.Cells["Name"].Value.ToString();
                string research = selectedRow.Cells["ResearchArea"].Value.ToString();
                string contact = selectedRow.Cells["Contact"].Value.ToString();
                int teaching_hours = Convert.ToInt32(selectedRow.Cells["TeachingHours"].Value);

                string designationVal = selectedRow.Cells["Designation"].Value.ToString();
                Designation designation = LookUpControl.Instance.GetDesignations().FirstOrDefault(d => d.Value == designationVal);

                var faculty = new Faculty
                {
                    Id = Id,
                    Name = name,
                    TeachingHours = teaching_hours,
                    ResearchArea = research,
                    Designation = designation,
                    Contact = contact
                };

                new FacultyDialog("UPDATE", faculty).ShowDialog();
                UserDataRender(null);
            }
        }

        private void Search_TextChanged(object sender, EventArgs e) {
            string search = Search.Text;
            UserDataRender(search);
        }

        private void SearchBtn_Click(object sender, EventArgs e) {
            string search = Search.Text;
            UserDataRender(search);
        }

        private void AssignCourse_Click(object sender, EventArgs e) {
            if (UserData.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = UserData.SelectedRows[0];
                int Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string name = selectedRow.Cells["Name"].Value.ToString();
                string research = selectedRow.Cells["ResearchArea"].Value.ToString();
                string contact = selectedRow.Cells["Contact"].Value.ToString();
                int teaching_hours = Convert.ToInt32(selectedRow.Cells["TeachingHours"].Value);

                string designationVal = selectedRow.Cells["Designation"].Value.ToString();
                Designation designation = LookUpControl.Instance.GetDesignations().FirstOrDefault(d => d.Value == designationVal);

                var faculty = new Faculty
                {
                    Id = Id,
                    Name = name,
                    TeachingHours = teaching_hours,
                    ResearchArea = research,
                    Designation = designation,
                    Contact = contact
                };

                new AssignCourseDialog(faculty, "ASSIGN").ShowDialog();
            }
        }

        private void AssignAdminRole_Click(object sender, EventArgs e) {
            if (UserData.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = UserData.SelectedRows[0];
                int Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string name = selectedRow.Cells["Name"].Value.ToString();
                string research = selectedRow.Cells["ResearchArea"].Value.ToString();
                string contact = selectedRow.Cells["Contact"].Value.ToString();
                int teaching_hours = Convert.ToInt32(selectedRow.Cells["TeachingHours"].Value);

                string designationVal = selectedRow.Cells["Designation"].Value.ToString();
                Designation designation = LookUpControl.Instance.GetDesignations().FirstOrDefault(d => d.Value == designationVal);

                var faculty = new Faculty
                {
                    Id = Id,
                    Name = name,
                    TeachingHours = teaching_hours,
                    ResearchArea = research,
                    Designation = designation,
                    Contact = contact
                };

                new AssignAdminRoleDialog(faculty, "ASSIGN").ShowDialog();
            }
        }

        private void AssignProject_Click(object sender, EventArgs e) {
            if (UserData.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = UserData.SelectedRows[0];
                int Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string name = selectedRow.Cells["Name"].Value.ToString();
                string research = selectedRow.Cells["ResearchArea"].Value.ToString();
                string contact = selectedRow.Cells["Contact"].Value.ToString();
                int teaching_hours = Convert.ToInt32(selectedRow.Cells["TeachingHours"].Value);

                string designationVal = selectedRow.Cells["Designation"].Value.ToString();
                Designation designation = LookUpControl.Instance.GetDesignations().FirstOrDefault(d => d.Value == designationVal);

                var faculty = new Faculty
                {
                    Id = Id,
                    Name = name,
                    TeachingHours = teaching_hours,
                    ResearchArea = research,
                    Designation = designation,
                    Contact = contact
                };

                new AssignFacultyProject(faculty, "ASSIGN").ShowDialog();
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e) {
            RefreshData();
            new FacultyWorkload().RefreshData();
            new ResourceAllocation().RefreshData();
            new FacultyRequests().RefreshData();
            new Dashboard().RefreshData();
        }

        private void AllocateRoom_Click(object sender, EventArgs e) {
            if (UserData.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = UserData.SelectedRows[0];
                int Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string name = selectedRow.Cells["Name"].Value.ToString();
                string research = selectedRow.Cells["ResearchArea"].Value.ToString();
                string contact = selectedRow.Cells["Contact"].Value.ToString();
                int teaching_hours = Convert.ToInt32(selectedRow.Cells["TeachingHours"].Value);

                string designationVal = selectedRow.Cells["Designation"].Value.ToString();
                Designation designation = LookUpControl.Instance.GetDesignations().FirstOrDefault(d => d.Value == designationVal);

                var faculty = new Faculty
                {
                    Id = Id,
                    Name = name,
                    TeachingHours = teaching_hours,
                    ResearchArea = research,
                    Designation = designation,
                    Contact = contact
                };

                new AssignRoomDialog(faculty, "ASSIGN").ShowDialog();
            }
        }
    }
}
