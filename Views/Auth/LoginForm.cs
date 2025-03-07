using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P023.Views.MainScreens;

namespace DBS25P023.Views.Auth
{
    public partial class LoginForm: UserControl
    {
        public LoginForm()
        {
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
            if (this.FindForm() is Login login) {
                login.Close();
            }
            Main main = new Main();
            main.Show();
        }
    }
}
