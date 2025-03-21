using DBS25P023.Controllers;
using DBS25P023.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace DBS25P023.Dialogs {
    public partial class SemesterDialog : Form {
        private string Action;
        int selected_semester = -1;

        public SemesterDialog(string Action) {
            InitializeComponent();
            this.Action = Action;
        }
        public SemesterDialog(string Action, Semester semester) {
            InitializeComponent();
            this.Action = Action;

            selected_semester = semester.Id;
            SemesterYear.Text = semester.Year.ToString();
            SemesterTerm.Text = semester.Term;
        }

        private void SemesterDialog_Load(object sender, EventArgs e) {
            Title.Text = $"{Action} {Title.Text}";
            this.ActionBtn.Text = Action;
            this.Text = Action + " Semester";
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(SemesterYear.Text)
               || string.IsNullOrEmpty(SemesterTerm.Text)) {
                MessageBox.Show("Please fill all Fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(SemesterYear.Text, out int number)) {
                MessageBox.Show("Please Enter Integer in YEAR", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Semester semester = new Semester
            {
                Term = SemesterTerm.Text,
                Year = Convert.ToInt32(SemesterYear.Text)
            };

            if (Action == "ADD") {
                if (SemesterControl.Instance.SearchSemester(semester, 'l')) {
                    MessageBox.Show("Semester Already Started", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (SemesterControl.Instance.AddSemester(semester)) {
                    MessageBox.Show("Semester Started Successfully!", "Semester", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Semester", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                semester.Id = selected_semester;
                if (SemesterControl.Instance.SearchSemester(semester, 'u')) {
                    MessageBox.Show("Semester Already Exist", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (SemesterControl.Instance.UpdateSemester(semester)) {
                    MessageBox.Show("Semester Updated Successfully!", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Close();
        }
    }
}
