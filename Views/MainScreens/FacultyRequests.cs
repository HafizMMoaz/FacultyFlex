using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P023.Views.MainScreens.Dialogs;

namespace DBS25P023.Views.MainScreens {
    public partial class FacultyRequests: UserControl
    {
        public FacultyRequests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            FacultyRequestForm faculty = new FacultyRequestForm();
            faculty.Show();
        }
    }
}
