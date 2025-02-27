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
    public partial class ForgotPassword: UserControl
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void BackToLogin_Click(object sender, EventArgs e) {
            Login parentForm = this.FindForm() as Login;
            if (parentForm != null) {
                parentForm.ShowLoginForm();
            }
        }
    }
}
