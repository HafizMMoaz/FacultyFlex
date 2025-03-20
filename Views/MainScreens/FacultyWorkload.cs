using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P023.Dialogs;
using DBS25P023.Models;

namespace DBS25P023.Views.MainScreens {
    public partial class FacultyWorkload: UserControl
    {
        public FacultyWorkload()
        {
            InitializeComponent();
        }

        private void NewCourse_Click(object sender, EventArgs e) {

            Course course = new Course
            {
                Id = 1,
                Name = "Database",
                Type = "Theory",
                CreditHours = 1,
                ContactHours = 3
            };

            new NewCourseDialog("UPDATE", course).ShowDialog();
        }
    }
}
