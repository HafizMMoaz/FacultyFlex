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
    public partial class AssignAdminRoleDialog : Form {
        private string Action;

        int selected_admin_role = -1;
        Faculty selected_faculty = null;
        Semester selected_semester = null;

        public AssignAdminRoleDialog(string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateData();
        }

        public AssignAdminRoleDialog(Faculty faculty, string Action) {
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

        public AssignAdminRoleDialog(AdminRole role, string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateData();

            selected_admin_role = role.Id;

            selected_faculty = role.Faculty;
            if (selected_faculty != null) {
                for (int i = 0; i < FacultySelection.Items.Count; i++) {
                    var item = FacultySelection.Items[i] as Faculty;
                    if (item != null && item.Id == role.Faculty.Id) {
                        FacultySelection.SelectedIndex = i;
                        break;
                    }
                }
            }

            RoleName.Text = role.Name;

            selected_semester = role.Semester;
            SemesterSelection.SelectedIndex = role.Semester.SrNo - 1;
        }

        private void PopulateData() {
            PopulateFaculty();
            PopulateSemester();
        }

        private void PopulateFaculty() {
            FacultySelection.Items.Clear();
            List<Faculty> faculty = FacultyControl.Instance.GetFaculty(null);
            FacultySelection.Items.AddRange(faculty.ToArray());
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
            if (string.IsNullOrEmpty(RoleName.Text) || selected_semester == null) {
                MessageBox.Show("Role Name and Semester Fields are Required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AdminRole role = new AdminRole
            {
                Name = RoleName.Text,
                Faculty = selected_faculty,
                Semester = selected_semester
            };

            if (Action == "ASSIGN") {
                if (FacultyControl.Instance.SearchAdminRole(role, 'l')) {
                    MessageBox.Show("Already Assigned", "Assign Admin Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (FacultyControl.Instance.AssignAdminRole(role)) {
                    MessageBox.Show("Role Assigned Successfully!", "Assign Admin Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Assign Admin Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                role.Id = selected_admin_role;
                if (FacultyControl.Instance.SearchAdminRole(role, 'u')) {
                    MessageBox.Show("Already Assigned", "Update Admin Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (FacultyControl.Instance.UpdateAdminRole(role)) {
                    MessageBox.Show("Updated Successfully!", "Update Admin Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Update Admin Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Close();
        }

        private void AssignRoleDialog_Load(object sender, EventArgs e) {
            Title.Text = $"{Action} {Title.Text}";
            this.ActionBtn.Text = Action;
            this.Text = Action + " Admin Role";
        }
    }
}
