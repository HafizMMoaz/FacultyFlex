using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P023.Models;
using DBS25P023.Controllers;
using System.Net.Mail;

namespace DBS25P023.Views.MainScreens 
{
    public partial class Settings: UserControl
    {
        int faculty_id = -1;
        int faculty_user_id = -1;
        public Settings()
        {
            InitializeComponent();

            faculty_id = Session.LoggedInFaculty.Id;
            faculty_user_id = Session.LoggedInFaculty.User_id;
            name.Text= Session.LoggedInFaculty.Name;
            Username.Text = Session.LoggedInFaculty.Username;
            Email.Text = Session.LoggedInFaculty.Email;
            Contact.Text = Session.LoggedInFaculty.Contact;

        }

        private void UpdateProfile_Click(object sender, EventArgs e) {
            if (Password.Text != ConfirmPassword.Text) {
                MessageBox.Show("Passwords Not Match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Username.Text.Length < 6) {
                MessageBox.Show("Username Must be 6 or more character long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(Password.Text) && Password.Text.Length < 8) {
                MessageBox.Show("Password Must be 8 or more character long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try {
                MailAddress mail = new MailAddress(Email.Text);
                string username = Username.Text;
                string name = this.name.Text;
                string password = Password.Text;
                string email = mail.ToString();
                string contact = Contact.Text;

                if (!string.IsNullOrEmpty(password))
                    password = BCrypt.Net.BCrypt.HashPassword(password);
                else
                    password = null;

                Faculty faculty = new Faculty
                {
                    Id = faculty_id,
                    User_id = faculty_user_id,
                    Name = name,
                    Username = username,
                    Email = email,
                    Contact = contact,
                    Password = password
                };

                if (FacultyControl.Instance.SearchFacultyUser(faculty, 'u')) {
                    MessageBox.Show("Username or Email Already in use", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (FacultyControl.Instance.UpdateProfile(faculty)) {
                    MessageBox.Show("Updated Successfully!", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (FormatException) {
                MessageBox.Show("Invalid Email Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
