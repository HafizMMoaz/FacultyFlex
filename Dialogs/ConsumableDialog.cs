using DBS25P023.Controllers;
using DBS25P023.Models;
using System;
using System.Windows.Forms;

namespace DBS25P023.Dialogs {
    public partial class ConsumableDialog : Form {
        private string Action;
        private int selected_consumable = -1;

        public ConsumableDialog(string Action) {
            InitializeComponent();
            this.Action = Action;
        }

        public ConsumableDialog(string Action, Consumable consumable) {
            InitializeComponent();
            this.Action = Action;

            selected_consumable = consumable.Id;
            ConsumableName.Text = consumable.Name;
        }

        private void ConsumableDialog_Load(object sender, EventArgs e) {
            Title.Text = $"{Action} {Title.Text}";
            this.ActionBtn.Text = Action;
            this.Text = Action + " Item";
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(ConsumableName.Text)) {
                MessageBox.Show("Please fill all Fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Consumable consumable = new Consumable
            {
                Name = ConsumableName.Text
            };

            if (Action == "ADD") {
                if (ConsumableControl.Instance.SearchConsumable(consumable, 'l')) {
                    MessageBox.Show("Consumable Name not available", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ConsumableControl.Instance.AddConsumable(consumable)) {
                    MessageBox.Show("Consumable Added Successfully!", "ADD Consumable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "ADD Consumable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                consumable.Id = selected_consumable;
                if (ConsumableControl.Instance.SearchConsumable(consumable, 'u')) {
                    MessageBox.Show("Consumable Name not available", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ConsumableControl.Instance.UpdateConsumable(consumable)) {
                    MessageBox.Show("Consumable Updated Successfully!", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something Went Wrong! Please Try Again", "UPDATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Close();
        }
    }
}
