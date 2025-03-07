using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P023.Views.Auth
{
    public partial class ForgotPassword: UserControl
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void BackToLogin_Click(object sender, EventArgs e) {
            if (this.FindForm() is Login login) {
                login.ShowLoginForm();
            }
        }
    }
}
