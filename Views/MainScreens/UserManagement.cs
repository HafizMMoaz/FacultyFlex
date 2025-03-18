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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DBS25P023.Views.MainScreens {
    public partial class UserManagement: UserControl
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            new FacultyUserDialog("ADD").ShowDialog();
            UserDataRender(null);
        }

        private void UserManagement_Load(object sender, EventArgs e) {
            UserDataRender(null);
        }

        private void UserDataRender(string search) {
            List<Faculty> facultyList = FacultyControl.Instance.GetFaculty(search);

            List<FacultyViewModel> facultyViewModels = facultyList.Select(f => new FacultyViewModel
            {
                User_id = f.User_id,
                Username = f.Username,
                Email = f.Email,
                Role = f.Role
            }).ToList();

            int idx = 1;
            foreach (var faculty in facultyViewModels) {
                faculty.SrNo = idx++;
            }

            UserData.DataSource = facultyViewModels;
            UserData.Columns["SrNo"].HeaderText = "#";
            UserData.Columns["Username"].HeaderText = "USERNAME";
            UserData.Columns["Email"].HeaderText = "EMAIL";
            UserData.Columns["Role"].HeaderText = "ROLE";
            UserData.Columns["User_id"].Visible = false;

            UserData.DefaultCellStyle.Font = new Font("Arial", 10);
            UserData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            UserData.RowTemplate.Height = 30;
            UserData.EnableHeadersVisualStyles = false;
            UserData.ColumnHeadersHeight = 50;
        }

        private void UserData_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                // Select the row under the mouse
                UserData.Rows[e.RowIndex].Selected = true;
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

                new FacultyApproveDialog("APPROVE", faculty).ShowDialog();
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
    }

    public class FacultyViewModel {
        public int SrNo { get; set; }
        public int User_id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
    }
}
