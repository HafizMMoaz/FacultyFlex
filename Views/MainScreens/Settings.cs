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
using System.IO;
using MySql.Data.MySqlClient;

namespace DBS25P023.Views.MainScreens 
{
    public partial class Settings: UserControl
    {
        // current login user
        string user_role = Session.LoggedInFaculty?.Role?.Value ?? "";

        private int faculty_id = -1;
        private int faculty_user_id = -1;
        public Settings()
        {
            InitializeComponent();

            if(Session.LoggedInFaculty != null) {
                faculty_id = Session.LoggedInFaculty.Id;
                faculty_user_id = Session.LoggedInFaculty.User_id;
                name.Text= Session.LoggedInFaculty.Name;
                Username.Text = Session.LoggedInFaculty.Username;
                Email.Text = Session.LoggedInFaculty.Email;
                Contact.Text = Session.LoggedInFaculty.Contact;
            }

            if(Session.DBCred != null) {
                Server.Text = Session.DBCred.ServerName;
                Port.Text = Session.DBCred.Port;
                DatabaseName.Text = Session.DBCred.DatabaseName;
                DatabaseUsername.Text = Session.DBCred.DatabaseUser;
                DatabasePassword.Text = Session.DBCred.DatabasePassword;
            }

            if(user_role != "Admin") {
                Tabs.TabPages.Remove(DBCredentials);
            }
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

        private void UpdateDBCreds_Click(object sender, EventArgs e) {
            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FacultyFlex");

            Directory.CreateDirectory(appDataPath);
            string filePath = Path.Combine(appDataPath, "dbConfig.txt");

            string credentials = $"{Server.Text},{Port.Text},{DatabaseName.Text},{DatabaseUsername.Text},{DatabasePassword.Text}";

            File.WriteAllText(filePath, credentials);

            Console.WriteLine("Database credentials saved successfully.");

            MessageBox.Show("Database credentials saved successfully.", "Database Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void ReinstallDB_Click(object sender, EventArgs e) {
            string serverName = Server.Text;
            string port = Port.Text;
            string databaseName = DatabaseName.Text;
            string databaseUser = DatabaseUsername.Text;
            string databasePassword = DatabasePassword.Text;

            DBCred dBCred = new DBCred
            {
                ServerName = serverName,
                Port = port,
                DatabaseName = databaseName,
                DatabaseUser = databaseUser,
                DatabasePassword = databasePassword
            };

            bool status = InstallControl.Instance.Install(dBCred);

            if (status) {
                MessageBox.Show("INSTALLED SUCCESSFULLY!\nUSERNAME : 'administration'\nPASSWORD : 12345678", "INSTALLATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else {
                MessageBox.Show("Something Went Wrong! Check Your Network!", "INSTALLATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewPassword_Click(object sender, EventArgs e) {
            Password.PasswordChar = Password.PasswordChar == '*' ? '\0' : '*';
        }

        private void ViewDBPassword_Click(object sender, EventArgs e) {
            DatabasePassword.PasswordChar = DatabasePassword.PasswordChar == '*' ? '\0' : '*';
        }

        private void ViewConfirmPassword_Click(object sender, EventArgs e) {
            ConfirmPassword.PasswordChar = ConfirmPassword.PasswordChar == '*' ? '\0' : '*';
        }

        
    }
}
