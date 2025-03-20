namespace DBS25P023.Views.MainScreens {
    partial class UserManagement {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActionBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.UserData = new System.Windows.Forms.DataGridView();
            this.UserManagementControls = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ApproveFaculty = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).BeginInit();
            this.UserManagementControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Register Faculty Members and wait for the Admin to approave Faculty.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 117);
            this.panel1.TabIndex = 2;
            // 
            // ActionBtn
            // 
            this.ActionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.ActionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionBtn.ForeColor = System.Drawing.Color.White;
            this.ActionBtn.Location = new System.Drawing.Point(15, 16);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(142, 55);
            this.ActionBtn.TabIndex = 3;
            this.ActionBtn.Text = "REGISTER";
            this.ActionBtn.UseVisualStyleBackColor = false;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Search);
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 50);
            this.panel2.TabIndex = 9;
            // 
            // Search
            // 
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.Location = new System.Drawing.Point(9, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(251, 30);
            this.Search.TabIndex = 0;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ActionBtn);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 84);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SearchBtn);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(426, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 84);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.UserData);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 211);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(15);
            this.panel5.Size = new System.Drawing.Size(760, 414);
            this.panel5.TabIndex = 11;
            // 
            // UserData
            // 
            this.UserData.AllowUserToAddRows = false;
            this.UserData.AllowUserToDeleteRows = false;
            this.UserData.AllowUserToResizeRows = false;
            this.UserData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserData.BackgroundColor = System.Drawing.Color.White;
            this.UserData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserData.ContextMenuStrip = this.UserManagementControls;
            this.UserData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserData.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UserData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserData.Location = new System.Drawing.Point(15, 15);
            this.UserData.MultiSelect = false;
            this.UserData.Name = "UserData";
            this.UserData.ReadOnly = true;
            this.UserData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.UserData.RowHeadersVisible = false;
            this.UserData.RowHeadersWidth = 20;
            this.UserData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserData.ShowEditingIcon = false;
            this.UserData.Size = new System.Drawing.Size(730, 384);
            this.UserData.TabIndex = 0;
            this.UserData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.UserData_CellFormatting);
            this.UserData.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserData_CellMouseDown);
            this.UserData.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserData_CellMouseEnter);
            // 
            // UserManagementControls
            // 
            this.UserManagementControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditUser,
            this.ApproveFaculty,
            this.toolStripMenuItem1});
            this.UserManagementControls.Name = "UserManagementControls";
            this.UserManagementControls.Size = new System.Drawing.Size(189, 116);
            // 
            // EditUser
            // 
            this.EditUser.BackColor = System.Drawing.SystemColors.Control;
            this.EditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.EditUser.Image = global::DBS25P023.Properties.Resources.edit;
            this.EditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditUser.Name = "EditUser";
            this.EditUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditUser.ShowShortcutKeys = false;
            this.EditUser.Size = new System.Drawing.Size(188, 30);
            this.EditUser.Text = "Update Credentials";
            this.EditUser.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // ApproveFaculty
            // 
            this.ApproveFaculty.BackColor = System.Drawing.SystemColors.Control;
            this.ApproveFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.ApproveFaculty.Image = global::DBS25P023.Properties.Resources.approve;
            this.ApproveFaculty.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ApproveFaculty.Name = "ApproveFaculty";
            this.ApproveFaculty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApproveFaculty.ShowShortcutKeys = false;
            this.ApproveFaculty.Size = new System.Drawing.Size(188, 30);
            this.ApproveFaculty.Text = "Approve Faculty";
            this.ApproveFaculty.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.toolStripMenuItem1.Image = global::DBS25P023.Properties.Resources.del;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem1.ShowShortcutKeys = false;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 30);
            this.toolStripMenuItem1.Text = "Delete User";
            this.toolStripMenuItem1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.ErrorImage = global::DBS25P023.Properties.Resources.eye;
            this.SearchBtn.Image = global::DBS25P023.Properties.Resources.search;
            this.SearchBtn.InitialImage = global::DBS25P023.Properties.Resources.eye;
            this.SearchBtn.Location = new System.Drawing.Point(267, 21);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Padding = new System.Windows.Forms.Padding(10);
            this.SearchBtn.Size = new System.Drawing.Size(50, 50);
            this.SearchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.TabStop = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserManagement";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(780, 635);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).EndInit();
            this.UserManagementControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.PictureBox SearchBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView UserData;
        private System.Windows.Forms.ContextMenuStrip UserManagementControls;
        private System.Windows.Forms.ToolStripMenuItem EditUser;
        private System.Windows.Forms.ToolStripMenuItem ApproveFaculty;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
