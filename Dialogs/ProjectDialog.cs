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
    public partial class ProjectDialog : Form {
        private string Action;
        private int selected_project = -1;
        public ProjectDialog(string Action) {
            InitializeComponent();
            this.Action = Action;
        }

        public ProjectDialog(string Action, Project project) {
            InitializeComponent();
            this.Action = Action;

            selected_project = project.Id;
            ProjectTitle.Text = project.Title;
            ProjectDescription.Text = project.Description;
        }

        private void ProjectDialog_Load(object sender, EventArgs e) {
            Title.Text = $"{Action} {Title.Text}";
            this.ActionBtn.Text = Action;
            this.Text = Action + " Project";
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(ProjectTitle.Text)
               || string.IsNullOrEmpty(ProjectDescription.Text)) {
                MessageBox.Show("Please fill all Fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Project project = new Project
            {
                Title = ProjectTitle.Text,
                Description = ProjectDescription.Text
            };

            if (Action == "ADD") {
                if (ProjectControl.Instance.AddProject(project)) {
                    MessageBox.Show("Project Added Successfully!", "ADD Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "ADD Project", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                project.Id = selected_project;
                if (ProjectControl.Instance.UpdateProject(project)) {
                    MessageBox.Show("Project Updated Successfully!", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Close();

        }
    }
}
