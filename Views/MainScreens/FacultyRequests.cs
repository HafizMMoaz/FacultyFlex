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
using DBS25P023.Controllers;

namespace DBS25P023.Views.MainScreens {
    public partial class FacultyRequests: UserControl
    {
        public FacultyRequests()
        {
            InitializeComponent();
            RequestRender(null);
        }

        private void NewRequest_Click(object sender, EventArgs e) {
            new RequestDialog(Session.LoggedInFaculty, "ADD").ShowDialog();
            RequestRender(null);
        }

        private void SearchRequest_TextChanged(object sender, EventArgs e) {
            string search = SearchRequest.Text;
            RequestRender(search);
        }

        private void SearchRequestBtn_Click(object sender, EventArgs e) {
            string search = SearchRequest.Text;
            RequestRender(search);
        }

        private void Requests_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) { 
                Requests.Rows[e.RowIndex].Selected = true;
            }
        }

        private void RequestRender(string search) {
            List<FacultyRequest> facultyRequests = RequestControl.Instance.GetRequests(search);

            Requests.DataSource = facultyRequests;

            Requests.Columns["SrNo"].HeaderText = "#";
            Requests.Columns["Faculty"].HeaderText = "FACULTY";
            Requests.Columns["Item"].HeaderText = "ITEM";
            Requests.Columns["Quantity"].HeaderText = "QUANTITY";
            Requests.Columns["Status"].HeaderText = "STATUS";
            Requests.Columns["TimeStamp"].HeaderText = "REQUEST DATE";
            Requests.Columns["Id"].Visible = false;

            Requests.DefaultCellStyle.Font = new Font("Arial", 10);
            Requests.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            Requests.RowTemplate.Height = 30;
            Requests.EnableHeadersVisualStyles = false;
            Requests.ColumnHeadersHeight = 50;
        }

        private void Requests_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                Requests.ClearSelection();
                Requests.Rows[e.RowIndex].Selected = true;

                var status = Requests.Rows[e.RowIndex].Cells["Status"].Value?.ToString();
                var name = Requests.Rows[e.RowIndex].Cells["Faculty"].Value?.ToString();
                string role = Session.LoggedInFaculty.Role.Value;
                string FacultyName = Session.LoggedInFaculty.Name;

                if (role == "Admin" || role == "Department Head") {
                    EditRequest.Visible = false;
                    DeleteRequest.Visible = false;
                    if (name == FacultyName && status == "Pending") {
                        EditRequest.Visible = true;
                        DeleteRequest.Visible = true;
                    }
                    ChangeStatus.Visible = true;
                }
                else {
                    if(status == "Pending"){
                        EditRequest.Visible = true;
                        DeleteRequest.Visible = true;
                    }
                    ChangeStatus.Visible = false;
                }

                
            }
        }

        private void EditRequest_Click(object sender, EventArgs e) {
            if (Requests.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = Requests.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                string Item = selectedRow.Cells["Item"].Value.ToString();
                Consumable selectedItem = ConsumableControl.Instance.GetConsumables(null).FirstOrDefault(c => c.Name == Item);

                var request = new FacultyRequest
                {
                    Id = id,
                    Item = selectedItem,
                    Quantity = quantity
                };

                new RequestDialog(request, "UPDATE").ShowDialog();
                RequestRender(null);
            }
        }

        private void DeleteRequest_Click(object sender, EventArgs e) {
            if (Requests.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = Requests.SelectedRows[0];

                int request_id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (RequestControl.Instance.DeleteRequest(request_id)) {
                    MessageBox.Show("Request Deleted Successfully", "Request Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RequestRender(null);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Request Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void ChangeStatus_Click(object sender, EventArgs e) {
            if (Requests.SelectedRows.Count > 0) {

                DataGridViewRow selectedRow = Requests.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string status = selectedRow.Cells["Status"].Value.ToString();
                RequestStatus selectedItem = LookUpControl.Instance.GetRequestStatus().FirstOrDefault(r => r.Value == status);

                var request = new FacultyRequest
                {
                    Id = id,
                    Status = selectedItem
                };

                new RequestStatusDialog(request).ShowDialog();
                RequestRender(null);
            }
        }

        public void RefreshData() {
            RequestRender(null);
        }

        private void RefreshBtn_Click(object sender, EventArgs e) {
            RefreshData();
            new UserManagement().RefreshData();
            new FacultyWorkload().RefreshData();
            new ResourceAllocation().RefreshData();
            new Dashboard().RefreshData();
        }
    }
}
