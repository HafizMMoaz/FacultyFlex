using System;
using System.Windows.Forms;
using DBS25P023.Views.MainScreens;
using DBS25P023.Controllers;

namespace DBS25P023.Views.Auth {
    public partial class LoginForm : UserControl {
        public LoginForm() {
            InitializeComponent();
        }

        private void ForgotPassword_Click(object sender, EventArgs e) {
            if (this.FindForm() is Login login) {
                login.ShowForgotPasswordForm();
            }
        }

        private void ViewPassword_Click(object sender, EventArgs e) {
            Password.PasswordChar = Password.PasswordChar == '*' ? '\0' : '*';
        }

        private void SignIn_Click(object sender, EventArgs e) {
            string username = Username.Text.Trim();
            string password = Password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("Please fill all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the AuthControl Login function
            bool isAuthenticated = AuthControl.Instance.Login(username, password);

            if (isAuthenticated) {
                if (this.FindForm() is Login login) {
                    login.Close();
                }
                Main main = new Main();
                main.Show();
            }
            else {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
