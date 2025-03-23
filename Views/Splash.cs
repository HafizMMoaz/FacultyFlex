using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P023.Controllers;
using DBS25P023.Models;
using DBS25P023.Views.Auth;
using DBS25P023.Views.Installer;

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
                // Get the path to the dbConfig.txt file in the AppData folder
                string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FacultyFlex");
                string configFilePath = Path.Combine(appDataPath, "INSTALLED");

                // Check if the dbConfig.txt file exists
                if (File.Exists(configFilePath)) {
                    DBCred dBCred = InstallControl.Instance.ReadDBConfig();
                    Session.SetDbCred(dBCred);
                    // If the file exists, open the Login screen
                    Login LoginScreen = new Login();
                    LoginScreen.Show();

                }
                else {
                    // If the file does not exist, open the Installer screen
                    Install InstallScreen = new Install();
                    InstallScreen.Show();
                }
                this.Close();
            }
        }
    }
}
