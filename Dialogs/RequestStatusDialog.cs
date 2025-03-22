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

namespace DBS25P023.Dialogs {
    public partial class RequestStatusDialog : Form {
        int selected_request = -1;
        RequestStatus status = null;
        public RequestStatusDialog(FacultyRequest request) {
            InitializeComponent();
            PopulateStatus();

            selected_request = request.Id;

            status = request.Status;

            StatusSelection.SelectedIndex = status.Id - 1;
        }

        private void PopulateStatus() {
            StatusSelection.Items.Clear();
            List<RequestStatus> status = LookUpControl.Instance.GetRequestStatus();
            StatusSelection.Items.AddRange(status.ToArray());
        }

        private void StatusSelection_SelectedIndexChanged(object sender, EventArgs e) {
            if (StatusSelection.SelectedItem is RequestStatus selectedRequest) {
                status = selectedRequest;
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e) {

            FacultyRequest request = new FacultyRequest
            {
                Id = selected_request,
                Status = status
            };

            if (RequestControl.Instance.UpdateStatus(request)) {
                MessageBox.Show("Updated Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Something Went Wrong! Please Try Again", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }
    }
}
