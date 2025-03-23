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

namespace DBS25P023.Dialogs
{
    public partial class FacultyDialog: Form
    {
        private string Action;
        Designation selected_Designation = null;
        int User_id; string Email;

        Faculty selectedFaculty = null;

        public FacultyDialog(string Action, Faculty facutlty)
        {
            InitializeComponent();
            this.Action = Action;
            this.User_id = facutlty.User_id;
            this.Email = facutlty.Email;
            PopulateDesignations();


            if(Action == "UPDATE") {
                selectedFaculty = facutlty;
                FacultyName.Text = selectedFaculty.Name;
                FacultyContact.Text = selectedFaculty.Contact;
                FacultyResearchArea.Text = selectedFaculty.ResearchArea;
                FacultyDesignation.SelectedIndex = selectedFaculty.Designation.Id - 1;
            }
            
        }

        private void PopulateDesignations() {
            FacultyDesignation.Items.Clear();
            List<Designation> designations = LookUpControl.Instance.GetDesignations();
            FacultyDesignation.Items.AddRange(designations.ToArray());
        }

        private void FacultyApproveDialog_Load(object sender, EventArgs e) {
            Title.Text = $"{Action} {Title.Text}";
            this.ActionBtn.Text = Action;
            this.Text = Action + " Faculty";
        }

        private void FacultyDesignation_SelectedIndexChanged(object sender, EventArgs e) {
            if (FacultyDesignation.SelectedItem is Designation designation) { 
                selected_Designation = designation;
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            if (selected_Designation == null 
                || string.IsNullOrEmpty(FacultyName.Text)
                || string.IsNullOrEmpty(FacultyContact.Text) 
                || string.IsNullOrEmpty(FacultyResearchArea.Text)) {
                MessageBox.Show("Please fill all Fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Name = FacultyName.Text;
            string Contact = FacultyContact.Text;
            string ResearchArea = FacultyResearchArea.Text;
            Designation Designation = selected_Designation;
            int User_id = this.User_id;
            string Email = this.Email;

            Faculty faculty = new Faculty
            {
                Name = Name,
                Contact = Contact,
                ResearchArea = ResearchArea,
                Designation = Designation,
                Email = Email,
                User_id = User_id
            };

            if(Action == "APPROVE") {
                if (FacultyControl.Instance.ApproveFaculty(faculty)) {
                    MessageBox.Show("Approved Successfully!", "Faculty Approval", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Faculty Approval", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                faculty.Id = selectedFaculty.Id;
                if (FacultyControl.Instance.UpdateFaculty(faculty)) {
                    MessageBox.Show("Updated Successfully!", "Faculty Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Faculty Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Close();
        }
    }
}
