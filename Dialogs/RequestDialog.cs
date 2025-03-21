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
    public partial class RequestDialog : Form {
        private string Action;

        int selected_faculty_project = -1;
        Faculty selected_faculty = null;
        Project selected_project = null;
        Semester selected_semester = null;

        public RequestDialog(string Action) {
            InitializeComponent();
            this.Action = Action;
            //PopulateData();
        }

        //public RequestDialog(FacultyProject project, string Action) {
        //    InitializeComponent();
        //    this.Action = Action;
        //    PopulateData();

        //    selected_faculty_project = project.Id;

        //    SuperVisionHours.Text = project.SuperVisionHours.ToString();

        //    selected_faculty = project.Faculty;
        //    if (selected_faculty != null) {
        //        for (int i = 0; i < FacultySelection.Items.Count; i++) {
        //            var item = FacultySelection.Items[i] as Faculty; // Assuming FacultySelection contains Faculty objects
        //            if (item != null && item.Id == project.Faculty.Id) {
        //                FacultySelection.SelectedIndex = i;
        //                break; // Exit the loop once the item is selected
        //            }
        //        }
        //    }

        //    selected_project = project.Project;
        //    ProjectSelection.SelectedIndex = project.Project.SrNo - 1;

        //    selected_semester = project.Semester;
        //    SemesterSelection.SelectedIndex = project.Semester.SrNo - 1;
        //}

        //private void AssignProjectDialog_Load(object sender, EventArgs e) {
        //    Title.Text = $"{Action} {Title.Text}";
        //    this.ActionBtn.Text = Action;
        //    this.Text = Action + " Project";
        //}

        //private void PopulateData() {
        //    PopulateProject();
        //    PopulateFaculty();
        //    PopulateSemester();
        //}

        //private void PopulateFaculty() {
        //    FacultySelection.Items.Clear();
        //    List<Faculty> faculty = FacultyControl.Instance.GetFaculty(null);
        //    FacultySelection.Items.AddRange(faculty.ToArray());
        //}

        //private void PopulateProject() {
        //    ProjectSelection.Items.Clear();
        //    List<Project> project = ProjectControl.Instance.GetProjects(null);
        //    ProjectSelection.Items.AddRange(project.ToArray());
        //}

        //private void PopulateSemester() {
        //    SemesterSelection.Items.Clear();
        //    List<Semester> semesters = SemesterControl.Instance.GetSemester(null);
        //    SemesterSelection.Items.AddRange(semesters.ToArray());
        //}

        //private void FacultySelection_SelectedIndexChanged(object sender, EventArgs e) {
        //    if (FacultySelection.SelectedItem is Faculty selectedFaculty) {
        //        selected_faculty = selectedFaculty;
        //    }
        //}

        //private void ProjectSelection_SelectedIndexChanged(object sender, EventArgs e) {
        //    if (ProjectSelection.SelectedItem is Project selectedProject) {
        //        selected_project = selectedProject;
        //    }
        //}

        //private void AddProject_Click(object sender, EventArgs e) {
        //    new ProjectDialog("ADD").ShowDialog();
        //    PopulateProject();
        //}

        //private void SemesterSelection_SelectedIndexChanged(object sender, EventArgs e) {
        //    if (SemesterSelection.SelectedItem is Semester semester) {
        //        selected_semester = semester;
        //    }
        //}

        //private void AddSemester_Click(object sender, EventArgs e) {
        //    new SemesterDialog("ADD").ShowDialog();
        //    PopulateSemester();
        //}

        //private void ActionBtn_Click(object sender, EventArgs e) {
        //    if (selected_project == null || selected_semester == null || string.IsNullOrEmpty(SuperVisionHours.Text)) {
        //        MessageBox.Show("Project, Semester and SuperVisionHours are Required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if (!int.TryParse(SuperVisionHours.Text, out int number)) {
        //        MessageBox.Show("Please Enter Integer in SuperVision Hours", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    FacultyProject project = new FacultyProject
        //    {
        //        Faculty = selected_faculty,
        //        Semester = selected_semester,
        //        Project = selected_project,
        //        SuperVisionHours = Convert.ToInt32(SuperVisionHours.Text)
        //    };

        //    if (Action == "ASSIGN") {
        //        if (ProjectControl.Instance.SearchAssignedProject(project, 'l')) {
        //            MessageBox.Show("Already Assigned", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        if (ProjectControl.Instance.AssignProject(project)) {
        //            MessageBox.Show("Project Assigned Successfully!", "Assign Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else {
        //            MessageBox.Show("Something Went Wrong! Please Try Again", "Assign Project", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    else {
        //        project.Id = selected_faculty_project;
        //        if (ProjectControl.Instance.SearchAssignedProject(project, 'u')) {
        //            MessageBox.Show("Already Assigned", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        if (ProjectControl.Instance.UpdateAssignedProject(project)) {
        //            MessageBox.Show("Updated Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else {
        //            MessageBox.Show("Something Went Wrong! Please Try Again", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }

        //    this.Close();
        //}
    }
}
