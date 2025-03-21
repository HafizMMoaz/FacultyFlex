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
    public partial class RoomDialog : Form {
        private string Action;
        private int selected_room = -1;
        public RoomDialog(string Action) {
            InitializeComponent();
            this.Action = Action;
        }

        public RoomDialog(string Action, Room room) {
            InitializeComponent();
            this.Action = Action;

            selected_room = room.Id;
            RoomName.Text = room.Name;
            RoomType.Text = room.Type;
            RoomCapacity.Text = room.Capacity.ToString();
        }

        private void RoomDialog_Load(object sender, EventArgs e) {
            Title.Text = $"{Action} {Title.Text}";
            this.ActionBtn.Text = Action;
            this.Text = Action + " Room";
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(RoomName.Text)
               || string.IsNullOrEmpty(RoomType.Text)
               || string.IsNullOrEmpty(RoomCapacity.Text)) {
                MessageBox.Show("Please fill all Fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(RoomCapacity.Text, out int number)) {
                MessageBox.Show("Please Enter Integer in Capacity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Room room = new Room
            {
                Name = RoomName.Text,
                Type = RoomType.Text,
                Capacity = Convert.ToInt32(RoomCapacity.Text)
            };

            if (Action == "ADD") {
                if (RoomControl.Instance.SearchRoom(room, 'l')) {
                    MessageBox.Show("Room Name not available", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (RoomControl.Instance.AddRoom(room)) {
                    MessageBox.Show("Room Added Successfully!", "ADD Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "ADD Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                room.Id = selected_room;
                if (RoomControl.Instance.SearchRoom(room, 'u')) {
                    MessageBox.Show("Room Name not available", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (RoomControl.Instance.UpdateRoom(room)) {
                    MessageBox.Show("Room Updated Successfully!", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Close();

        }
    }
}
