namespace DBS25P023.Dialogs {
    partial class RequestDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ActionBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.QUANTITY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionBtn
            // 
            this.ActionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.ActionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionBtn.ForeColor = System.Drawing.Color.White;
            this.ActionBtn.Location = new System.Drawing.Point(114, 310);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(142, 55);
            this.ActionBtn.TabIndex = 36;
            this.ActionBtn.Text = "ASSIGN";
            this.ActionBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ItemSelection);
            this.panel1.Location = new System.Drawing.Point(35, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 50);
            this.panel1.TabIndex = 31;
            // 
            // ItemSelection
            // 
            this.ItemSelection.BackColor = System.Drawing.SystemColors.Window;
            this.ItemSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemSelection.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemSelection.FormattingEnabled = true;
            this.ItemSelection.Location = new System.Drawing.Point(9, 6);
            this.ItemSelection.Name = "ItemSelection";
            this.ItemSelection.Size = new System.Drawing.Size(300, 37);
            this.ItemSelection.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(35, 95);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "ITEM";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.Title.Location = new System.Drawing.Point(130, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(126, 36);
            this.Title.TabIndex = 32;
            this.Title.Text = "REQUEST";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.QUANTITY);
            this.panel3.Location = new System.Drawing.Point(35, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 50);
            this.panel3.TabIndex = 39;
            // 
            // QUANTITY
            // 
            this.QUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QUANTITY.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUANTITY.ForeColor = System.Drawing.Color.Black;
            this.QUANTITY.Location = new System.Drawing.Point(9, 9);
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Size = new System.Drawing.Size(300, 30);
            this.QUANTITY.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(35, 202);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "QUANTITY";
            // 
            // RequestDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 405);
            this.Controls.Add(this.ActionBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RequestDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "RequestDialog";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ItemSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox QUANTITY;
        private System.Windows.Forms.Label label3;
    }
}