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
    public partial class RequestDialog : Form {
        private string Action;

        int selected_faculty_request = -1;
        Faculty selected_faculty = null;
        Consumable selected_item = null;

        public RequestDialog(Faculty faculty,string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateItem();
            selected_faculty = faculty;
        }

        public RequestDialog(FacultyRequest request, string Action) {
            InitializeComponent();
            this.Action = Action;
            PopulateItem();

            selected_faculty_request = request.Id;

            selected_item = request.Item;
            ItemSelection.SelectedIndex = request.Item.SrNo - 1;

            Quantity.Text = request.Quantity.ToString();
        }

        private void RequestDialog_Load(object sender, EventArgs e) {
            Title.Text = $"{Action} {Title.Text}";
            this.ActionBtn.Text = Action;
            this.Text = Action + " Request";
        }
        private void PopulateItem() {
            ItemSelection.Items.Clear();
            List<Consumable> items = ConsumableControl.Instance.GetConsumables(null);
            ItemSelection.Items.AddRange(items.ToArray());
        }

        private void ItemSelection_SelectedIndexChanged(object sender, EventArgs e) {
            if (ItemSelection.SelectedItem is Consumable selectedConsumable) {
                selected_item = selectedConsumable;
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            if (selected_item == null || string.IsNullOrEmpty(Quantity.Text)) {
                MessageBox.Show("Please Fill all Fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Quantity.Text, out int number)) {
                MessageBox.Show("Please Enter Integer in Quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            FacultyRequest request = new FacultyRequest
            {
                Item = selected_item,
                Quantity = Convert.ToInt32(Quantity.Text)
            };

            if (Action == "ADD") {

                request.Status = LookUpControl.Instance.GetRequestStatus().FirstOrDefault(s => s.Value == "Pending");

                string timezoneId = "Pakistan Standard Time";
                TimeZoneInfo karachiTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timezoneId);
                DateTime karachiTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, karachiTimeZone);

                request.TimeStamp = karachiTime.ToString("yyyy-MM-dd HH:mm:ss");

                request.Faculty = selected_faculty;

                if (RequestControl.Instance.AddRequest(request)) {
                    MessageBox.Show("Request Added Successfully!", "Add Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Add Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                request.Id = selected_faculty_request;

                if (RequestControl.Instance.UpdateRequest(request)) {
                    MessageBox.Show("Updated Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Close();
        }
    }
}
