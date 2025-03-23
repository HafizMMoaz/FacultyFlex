namespace DBS25P023.Dialogs {
    partial class AssignRoomDialog {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.SemesterSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoomSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FacultySelection = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReservedHours = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddSemester = new System.Windows.Forms.PictureBox();
            this.AddRoom = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionBtn
            // 
            this.ActionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.ActionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionBtn.ForeColor = System.Drawing.Color.White;
            this.ActionBtn.Location = new System.Drawing.Point(136, 469);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(142, 55);
            this.ActionBtn.TabIndex = 36;
            this.ActionBtn.Text = "ASSIGN";
            this.ActionBtn.UseVisualStyleBackColor = false;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SemesterSelection);
            this.panel2.Location = new System.Drawing.Point(29, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 50);
            this.panel2.TabIndex = 30;
            // 
            // SemesterSelection
            // 
            this.SemesterSelection.BackColor = System.Drawing.SystemColors.Window;
            this.SemesterSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SemesterSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SemesterSelection.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterSelection.FormattingEnabled = true;
            this.SemesterSelection.Location = new System.Drawing.Point(9, 6);
            this.SemesterSelection.Name = "SemesterSelection";
            this.SemesterSelection.Size = new System.Drawing.Size(300, 37);
            this.SemesterSelection.TabIndex = 0;
            this.SemesterSelection.SelectedIndexChanged += new System.EventHandler(this.SemesterSelection_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(29, 270);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "SEMESTER";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RoomSelection);
            this.panel1.Location = new System.Drawing.Point(29, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 50);
            this.panel1.TabIndex = 31;
            // 
            // RoomSelection
            // 
            this.RoomSelection.BackColor = System.Drawing.SystemColors.Window;
            this.RoomSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomSelection.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomSelection.FormattingEnabled = true;
            this.RoomSelection.Location = new System.Drawing.Point(9, 6);
            this.RoomSelection.Name = "RoomSelection";
            this.RoomSelection.Size = new System.Drawing.Size(300, 37);
            this.RoomSelection.TabIndex = 0;
            this.RoomSelection.SelectedIndexChanged += new System.EventHandler(this.RoomSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(29, 173);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "ROOM";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.Title.Location = new System.Drawing.Point(130, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(96, 36);
            this.Title.TabIndex = 32;
            this.Title.Text = "ROOM";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.FacultySelection);
            this.panel5.Location = new System.Drawing.Point(29, 104);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 50);
            this.panel5.TabIndex = 28;
            // 
            // FacultySelection
            // 
            this.FacultySelection.BackColor = System.Drawing.SystemColors.Window;
            this.FacultySelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FacultySelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FacultySelection.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultySelection.FormattingEnabled = true;
            this.FacultySelection.Location = new System.Drawing.Point(9, 6);
            this.FacultySelection.Name = "FacultySelection";
            this.FacultySelection.Size = new System.Drawing.Size(300, 37);
            this.FacultySelection.TabIndex = 0;
            this.FacultySelection.SelectedIndexChanged += new System.EventHandler(this.FacultySelection_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ReservedHours);
            this.panel3.Location = new System.Drawing.Point(29, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 50);
            this.panel3.TabIndex = 39;
            // 
            // ReservedHours
            // 
            this.ReservedHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReservedHours.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservedHours.ForeColor = System.Drawing.Color.Black;
            this.ReservedHours.Location = new System.Drawing.Point(9, 9);
            this.ReservedHours.Name = "ReservedHours";
            this.ReservedHours.Size = new System.Drawing.Size(300, 30);
            this.ReservedHours.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label6.Location = new System.Drawing.Point(29, 79);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "FACULTY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(29, 360);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "RESERVED HOURS";
            // 
            // AddSemester
            // 
            this.AddSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSemester.Image = global::DBS25P023.Properties.Resources.plus;
            this.AddSemester.Location = new System.Drawing.Point(355, 295);
            this.AddSemester.Margin = new System.Windows.Forms.Padding(0);
            this.AddSemester.Name = "AddSemester";
            this.AddSemester.Size = new System.Drawing.Size(50, 50);
            this.AddSemester.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AddSemester.TabIndex = 37;
            this.AddSemester.TabStop = false;
            this.AddSemester.Click += new System.EventHandler(this.AddSemester_Click);
            // 
            // AddRoom
            // 
            this.AddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRoom.Image = global::DBS25P023.Properties.Resources.plus;
            this.AddRoom.Location = new System.Drawing.Point(355, 198);
            this.AddRoom.Margin = new System.Windows.Forms.Padding(0);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(50, 50);
            this.AddRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AddRoom.TabIndex = 38;
            this.AddRoom.TabStop = false;
            this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // AssignRoomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 551);
            this.Controls.Add(this.AddSemester);
            this.Controls.Add(this.AddRoom);
            this.Controls.Add(this.ActionBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AssignRoomDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Room";
            this.Load += new System.EventHandler(this.AssignRoomDialog_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AddSemester;
        private System.Windows.Forms.PictureBox AddRoom;
        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox SemesterSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox RoomSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox FacultySelection;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ReservedHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}