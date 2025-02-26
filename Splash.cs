using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P023
{
    public partial class Splash: Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e) {
            
        }

        private void LoadingTimer_Tick(object sender, EventArgs e) {
            LoadingBarHead.Width += 10;
            if(LoadingBarHead.Width >= LoadingBar.Width) {
                LoadingTimer.Stop();
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }
    }
}
