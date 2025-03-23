using DBS25P023.Controllers;
using DBS25P023.Models;
using DBS25P023.Views.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P023.Views.Installer {
    public partial class Install : Form {
        public Install() {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ViewPassword_Click(object sender, EventArgs e) {
            Password.PasswordChar = Password.PasswordChar == '*' ? '\0' : '*';
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            string server = Server.Text;
            string port = Port.Text;
            string database = DatabaseName.Text;
            string username = Username.Text;
            string password = Password.Text;

            DBCred cred = new DBCred
            {
                ServerName = server,
                Port = port,
                DatabaseName = database,
                DatabaseUser = username,
                DatabasePassword = password
            };

            bool status = InstallControl.Instance.Install(cred);

            if (status) {
                MessageBox.Show("INSTALLED SUCCESSFULLY!\nUSERNAME : 'administration'\nPASSWORD : 12345678", "INSTALLATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Something Went Wrong! Check Your Network!", "INSTALLATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            new Splash().Show();
            this.Close();
        }

        private void Install_Load(object sender, EventArgs e) {
            MessageBox.Show("Guide : \nCreate DataBase in your MySQL Server", "INSTALLATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
