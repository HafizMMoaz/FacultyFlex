using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P023.UI
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
            LoginForm.Visible = true;
            ForgotPasswordForm.Visible = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        public void ShowForgotPasswordForm() {
            LoginForm.Visible = false;
            ForgotPasswordForm.Visible = true;
        }

        public void ShowLoginForm() {
            LoginForm.Visible = true;
            ForgotPasswordForm.Visible = false;
        }
    }
}
