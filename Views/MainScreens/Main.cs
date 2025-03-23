using DBS25P023.Controllers;
using DBS25P023.Models;
using DBS25P023.Views.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P023.Views.MainScreens
{
    public partial class Main: Form
    {
        public string CurrentActivity = "Dashboard";
        private List<Button> menuButtons;
        private bool isMenuCollapsed = true;
        private Dictionary<Button, string> buttonText;
        public Main()
        {
            InitializeComponent();

            menuButtons = new List<Button> { DashboardBtn, UserBtn, WorkloadBtn, ResourcesBtn, FacultyRequestBtn,ReportBtn, SettingBtn, LogoutBtn };
            buttonText = new Dictionary<Button, string>();
            foreach (Button btn in menuButtons) {
                buttonText[btn] = btn.Text;
            }

        }


        private void Main_Load(object sender, EventArgs e) {
            SideBar.Width = 90;
            SofwareTitle.Text = "F";
            foreach (var btn in menuButtons) {
                btn.Text = "";
                btn.TextAlign = ContentAlignment.MiddleCenter;
            }

            SetActiveButton(DashboardBtn, "Dashboard");
            Dashboard.BringToFront();

            LoggedInUser.Text = $"WELCOME, {Session.LoggedInFaculty.Name}";
        }

        private void DashboardBtn_Click(object sender, EventArgs e) {
            SetActiveButton(DashboardBtn, "Dashboard");
            Dashboard.Refresh();
            Dashboard.RefreshData();
            Dashboard.BringToFront();
        }

        private void UserBtn_Click(object sender, EventArgs e) {
            SetActiveButton(UserBtn, "Users");
            UserManagement.Refresh();
            UserManagement.RefreshData();
            UserManagement.BringToFront();
        }

        private void WorkloadBtn_Click(object sender, EventArgs e) {
            SetActiveButton(WorkloadBtn, "Workload");
            FacultyWorkload.Refresh();
            FacultyWorkload.RefreshData();
            FacultyWorkload.BringToFront();
        }

        private void FacultyRequestBtn_Click(object sender, EventArgs e) {
            SetActiveButton(FacultyRequestBtn, "FacultyRequest");
            FacultyRequests.Refresh();
            FacultyRequests.RefreshData();
            FacultyRequests.BringToFront();
        }

        private void ResourcesBtn_Click(object sender, EventArgs e) {
            SetActiveButton(ResourcesBtn, "Resources");
            ResourceAllocation.Refresh();
            ResourceAllocation.RefreshData();
            ResourceAllocation.BringToFront();
        }
        private void ReportBtn_Click(object sender, EventArgs e) {
            SetActiveButton(ReportBtn, "Reports");
            Reports.BringToFront();
        }

        private void SettingBtn_Click(object sender, EventArgs e) {
            SetActiveButton(SettingBtn, "Settings");
            Settings.BringToFront();
        }

        private void LogoutBtn_Click(object sender, EventArgs e) {
            SetActiveButton(LogoutBtn, "Logout");
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool userResponse = (result == DialogResult.Yes);
            if (userResponse) {
                Session.CloseSession();
                this.Close();
                new Login().Show();
            }
        }

        private void Minimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e) {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            if (CurrentActivity == "Logout")
                SetActiveButton(LogoutBtn, "Logout");
        }

        private void Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void SetActiveButton(Button activeButton, string activity) {

            foreach (Button btn in menuButtons) {
                btn.BackColor = Color.FromArgb(2, 62, 132);
            }

            activeButton.BackColor = Color.FromArgb(3, 4, 94);
            ActivityIndicator.Height = activeButton.Height;
            ActivityIndicator.Top = activeButton.Top;
            ActivityIndicator.Left = activeButton.Left;

            CurrentActivity = activity;
        }

        private void MenuToggle_Click(object sender, EventArgs e) {
            if (isMenuCollapsed) {
                SideBar.Width = 300;
                SofwareTitle.Text = "FACULTY  FLEX";
                foreach (var btn in menuButtons) {
                    btn.Text = buttonText[btn];
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                }
            }
            else {
                SideBar.Width = 90;
                SofwareTitle.Text = "F";
                foreach (var btn in menuButtons) {
                    btn.Text = "";
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                }
            }

            isMenuCollapsed = !isMenuCollapsed;
        }

        
    }
}
