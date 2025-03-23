using DBS25P023.Controllers;
using DBS25P023.Models;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DBS25P023.Views.MainScreens {
    public partial class Dashboard : UserControl {
        public Dashboard() {
            InitializeComponent();
            RefreshData();
        }

        public void RefreshData() {
            LoadCards();
            LoadChartData();
            RenderWorkLoad();
            FacultyRequetsLoad();
        }

        private void LoadCards() {
            TotalFacultyMembers.Text = DashboardControl.Instance.TotalFacultyMembers().ToString();
            TotalApprovedFaculty.Text = DashboardControl.Instance.TotalApprovedFaculty().ToString();
            TotalCourses.Text = DashboardControl.Instance.TotalCourses().ToString();
            TotalCoursesWithoutAssignedFaculty.Text = DashboardControl.Instance.TotalCoursesWithoutAssignedFaculty().ToString();
            TotalCoursesWithAssignedFaculty.Text = DashboardControl.Instance.TotalCoursesWithAssignedFaculty().ToString();
            TotalAssignedSupervisors.Text = DashboardControl.Instance.TotalAssignedSupervisors().ToString();
            TotalNotAssignedSupervisors.Text = DashboardControl.Instance.TotalNotAssignedSupervisors().ToString();
            TotalAdminRolesAssigned.Text = DashboardControl.Instance.TotalAdminRolesAssigned().ToString();
            TotalPendingRequests.Text = DashboardControl.Instance.TotalPendingRequests().ToString();
            TotalApprovedRequests.Text = DashboardControl.Instance.TotalApprovedRequests().ToString();
            TotalRejectedRequests.Text = DashboardControl.Instance.TotalRejectedRequests().ToString();
            TotalFulfilledRequests.Text = DashboardControl.Instance.TotalFulfilledRequests().ToString();
        }

        private void RenderWorkLoad() {
            List<Faculty> facultyList = FacultyControl.Instance.GetFaculty(null, 'a');

            while (facultyList.Count < 4) {
                facultyList.Add(new Faculty
                {
                    Name = "",
                    TeachingHours = 0
                });
            }

            // Take only first 4 records (in case there are more)
            facultyList = facultyList.Take(4).ToList();

            int idx = 1;
            foreach (var faculty in facultyList) {
                faculty.SrNo = idx++;
            }

            WorkLoadHours.DataSource = facultyList;

            WorkLoadHours.Columns["SrNo"].HeaderText = "#";
            WorkLoadHours.Columns["Name"].HeaderText = "NAME";
            WorkLoadHours.Columns["TeachingHours"].HeaderText = "Total Teaching Hours";

            WorkLoadHours.Columns["Email"].Visible = false;
            WorkLoadHours.Columns["Contact"].Visible = false;
            WorkLoadHours.Columns["Role"].Visible = false;
            WorkLoadHours.Columns["Designation"].Visible = false;
            WorkLoadHours.Columns["User_id"].Visible = false;
            WorkLoadHours.Columns["Id"].Visible = false;
            WorkLoadHours.Columns["Password"].Visible = false;
            WorkLoadHours.Columns["Username"].Visible = false;
            WorkLoadHours.Columns["ResearchArea"].Visible = false;

            WorkLoadHours.DefaultCellStyle.Font = new Font("Arial", 10);
            WorkLoadHours.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            WorkLoadHours.RowTemplate.Height = 30;
            WorkLoadHours.EnableHeadersVisualStyles = false;
            WorkLoadHours.ColumnHeadersHeight = 50;
        }

        private void FacultyRequetsLoad() {
            List<FacultyRequest> facultyRequests = RequestControl.Instance.GetRequests(null);

            while (facultyRequests.Count < 4) {
                facultyRequests.Add(new FacultyRequest
                {
                    Faculty = null,
                    Status = null,
                    TimeStamp = ""
                });
            }

            // Take only first 4 records (in case there are more)
            facultyRequests = facultyRequests.Take(4).ToList();

            int idx = 1;
            foreach (var request in facultyRequests) {
                request.SrNo = idx++;
            }

            FacultyRequestsData.DataSource = facultyRequests;

            FacultyRequestsData.Columns["SrNo"].HeaderText = "#";
            FacultyRequestsData.Columns["Faculty"].HeaderText = "FACULTY";
            FacultyRequestsData.Columns["Status"].HeaderText = "STATUS";
            FacultyRequestsData.Columns["TimeStamp"].HeaderText = "REQUEST DATE";
            FacultyRequestsData.Columns["Item"].Visible = false;
            FacultyRequestsData.Columns["Quantity"].Visible = false;
            FacultyRequestsData.Columns["Id"].Visible = false;

            FacultyRequestsData.DefaultCellStyle.Font = new Font("Arial", 10);
            FacultyRequestsData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            FacultyRequestsData.RowTemplate.Height = 30;
            FacultyRequestsData.EnableHeadersVisualStyles = false;
            FacultyRequestsData.ColumnHeadersHeight = 50;
        }

        private void LoadChartData() {
            RequestChart.Series.Clear();

            var consumables = ConsumableControl.Instance.GetConsumables(null);

            foreach (var consumable in consumables) {
                Series consumableSeries = new Series(consumable.Name)
                {
                    ChartType = SeriesChartType.Column
                };

                var requests = RequestControl.Instance.GetRequestsForConsumable(consumable.Id);

                foreach (var request in requests) {
                    consumableSeries.Points.AddXY(request.Id, request.Quantity);
                }

                RequestChart.Series.Add(consumableSeries);
            }

            RequestChart.ChartAreas[0].AxisX.Title = "Requests";
            RequestChart.ChartAreas[0].AxisY.Title = "Quantity";
        }
    }
}
