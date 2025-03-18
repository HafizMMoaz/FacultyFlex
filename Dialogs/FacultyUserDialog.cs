using DBS25P023.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using DBS25P023.Controllers;
using System.Net.Mail;

namespace DBS25P023.Dialogs
{
    public partial class FacultyUserDialog: Form
    {
        private string Action;
        Role selected_role = null; int selected_useid = -1;
        public FacultyUserDialog(string Action)
        {
            InitializeComponent();
            this.Action = Action;

            PopulateFacultyRole();
        }
        public FacultyUserDialog(Faculty faculty, string Action) {
            InitializeComponent();
            this.Action = Action;

            PopulateFacultyRole();

            selected_useid = faculty.User_id;
            FacultyUsername.Text = faculty.Username;
            FacultyEmail.Text = faculty.Email;
            selected_role = faculty.Role;
            FacultyRole.SelectedIndex = selected_role.Id - 1;
        }

        private void AddFaculty_Load(object sender, EventArgs e) {
            Title.Text = $"{Action} {Title.Text}";
            this.ActionBtn.Text = Action;
            this.Text = Action + " Faculty";
        }

        private void PopulateFacultyRole() {
            FacultyRole.Items.Clear();
            List<Role> roles = LookUpControl.Instance.GetRoles();
            FacultyRole.Items.AddRange(roles.ToArray());
        }

        private void FacultyRole_SelectedIndexChanged(object sender, EventArgs e) {
            if (FacultyRole.SelectedItem is Role selectedRole) {
                selected_role = selectedRole;
            }
        }

        private void ViewPassword_Click(object sender, EventArgs e) {
            FacultyPassword.PasswordChar = FacultyPassword.PasswordChar == '*' ? '\0' : '*';
        }

        private void ViewConfirmPassword_Click(object sender, EventArgs e) {
            FacultyConfirmPassword.PasswordChar = FacultyConfirmPassword.PasswordChar == '*' ? '\0' : '*';
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            if(selected_role == null 
                || string.IsNullOrWhiteSpace(FacultyUsername.Text)
                || string.IsNullOrWhiteSpace(FacultyPassword.Text)
                || string.IsNullOrWhiteSpace(FacultyConfirmPassword.Text)
                || string.IsNullOrWhiteSpace(FacultyEmail.Text)) {
                MessageBox.Show("Please fill all Fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(FacultyPassword.Text != FacultyConfirmPassword.Text) {
                MessageBox.Show("Passwords Not Match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(FacultyUsername.Text.Length < 6) {
                MessageBox.Show("Username Must be 6 or more character long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FacultyPassword.Text.Length < 8) {
                MessageBox.Show("Password Must be 8 or more character long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try {
                MailAddress mail = new MailAddress(FacultyEmail.Text);
                string username = FacultyUsername.Text;
                string password = FacultyPassword.Text;
                string email = mail.ToString();
                Role role = selected_role;

                password = BCrypt.Net.BCrypt.HashPassword(password);
                Faculty faculty = new Faculty(username, password, email, role);
                faculty.User_id = selected_useid;

                if (Action == "ADD") {
                    if (FacultyControl.Instance.SearchFacultyUser(faculty, 'l')) {
                        MessageBox.Show("Username or Email Already in use", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (FacultyControl.Instance.RegsiterFacultyUser(faculty)) {
                        MessageBox.Show("Registered Successfully! Ask Admin to Approve Registeration", "Registeration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Something Went Wrong! Please Try Again", "Registeration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else {
                    if (FacultyControl.Instance.SearchFacultyUser(faculty, 'u')) {
                        MessageBox.Show("Username or Email Already in use", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (FacultyControl.Instance.UpdateFacultyUser(faculty)) {
                        MessageBox.Show("Updated Successfully!", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Something Went Wrong! Please Try Again", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                this.Close();
            }
            catch (FormatException) {
                MessageBox.Show("Invalid Email Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

    }
}
