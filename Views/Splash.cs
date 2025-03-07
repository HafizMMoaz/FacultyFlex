using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P023.Views.Auth;

namespace DBS25P023.Views
{
    public partial class Splash: Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e) {
            LoadingBarHead.Width += 15;
            if(LoadingBarHead.Width >= LoadingBar.Width) {
                LoadingTimer.Stop();
                Login LoginScreen = new Login();
                LoginScreen.Show();
                this.Close();
            }
        }
    }
}
