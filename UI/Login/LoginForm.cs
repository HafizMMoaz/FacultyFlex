using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P023.UI
{
    public partial class LoginForm: UserControl
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Click(object sender, EventArgs e) {
            Login parentForm = this.FindForm() as Login;
            if (parentForm != null) {
                parentForm.ShowForgotPasswordForm();
            }
        }

        private void ViewPassword_Click(object sender, EventArgs e) {
            Password.PasswordChar = Password.PasswordChar == '*' ? '\0' : '*';
        }
    }
}
