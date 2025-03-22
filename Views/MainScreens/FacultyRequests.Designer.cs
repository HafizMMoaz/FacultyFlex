namespace DBS25P023.Views.MainScreens {
    partial class FacultyRequests {
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.SearchRequestBtn = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NewRequest = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchRequest = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Requests = new System.Windows.Forms.DataGridView();
            this.RequestControls = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchRequestBtn)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Requests)).BeginInit();
            this.RequestControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Requests);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 227);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(15);
            this.panel5.Size = new System.Drawing.Size(760, 398);
            this.panel5.TabIndex = 14;
            // 
            // SearchRequestBtn
            // 
            this.SearchRequestBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchRequestBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchRequestBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchRequestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchRequestBtn.ErrorImage = global::DBS25P023.Properties.Resources.eye;
            this.SearchRequestBtn.Image = global::DBS25P023.Properties.Resources.search;
            this.SearchRequestBtn.InitialImage = global::DBS25P023.Properties.Resources.eye;
            this.SearchRequestBtn.Location = new System.Drawing.Point(267, 21);
            this.SearchRequestBtn.Name = "SearchRequestBtn";
            this.SearchRequestBtn.Padding = new System.Windows.Forms.Padding(10);
            this.SearchRequestBtn.Size = new System.Drawing.Size(50, 50);
            this.SearchRequestBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchRequestBtn.TabIndex = 8;
            this.SearchRequestBtn.TabStop = false;
            this.SearchRequestBtn.Click += new System.EventHandler(this.SearchRequestBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NewRequest);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 100);
            this.panel3.TabIndex = 13;
            // 
            // NewRequest
            // 
            this.NewRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.NewRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRequest.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRequest.ForeColor = System.Drawing.Color.White;
            this.NewRequest.Location = new System.Drawing.Point(15, 21);
            this.NewRequest.Name = "NewRequest";
            this.NewRequest.Size = new System.Drawing.Size(142, 55);
            this.NewRequest.TabIndex = 3;
            this.NewRequest.Text = "REQUEST";
            this.NewRequest.UseVisualStyleBackColor = false;
            this.NewRequest.Click += new System.EventHandler(this.NewRequest_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SearchRequestBtn);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(426, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 100);
            this.panel4.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SearchRequest);
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 50);
            this.panel2.TabIndex = 9;
            // 
            // SearchRequest
            // 
            this.SearchRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchRequest.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchRequest.ForeColor = System.Drawing.Color.Black;
            this.SearchRequest.Location = new System.Drawing.Point(9, 9);
            this.SearchRequest.Name = "SearchRequest";
            this.SearchRequest.Size = new System.Drawing.Size(251, 30);
            this.SearchRequest.TabIndex = 0;
            this.SearchRequest.TextChanged += new System.EventHandler(this.SearchRequest_TextChanged);
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
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Request";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Register Consumables. Wait untill request is approved by Admin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Requests
            // 
            this.Requests.AllowUserToAddRows = false;
            this.Requests.AllowUserToDeleteRows = false;
            this.Requests.AllowUserToResizeRows = false;
            this.Requests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Requests.BackgroundColor = System.Drawing.Color.White;
            this.Requests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Requests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Requests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Requests.ContextMenuStrip = this.RequestControls;
            this.Requests.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Requests.DefaultCellStyle = dataGridViewCellStyle2;
            this.Requests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Requests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Requests.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Requests.Location = new System.Drawing.Point(15, 15);
            this.Requests.MultiSelect = false;
            this.Requests.Name = "Requests";
            this.Requests.ReadOnly = true;
            this.Requests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Requests.RowHeadersVisible = false;
            this.Requests.RowHeadersWidth = 20;
            this.Requests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Requests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Requests.ShowEditingIcon = false;
            this.Requests.Size = new System.Drawing.Size(730, 368);
            this.Requests.TabIndex = 1;
            this.Requests.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Requests_CellMouseDown);
            this.Requests.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Requests_CellMouseEnter);
            // 
            // RequestControls
            // 
            this.RequestControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditRequest,
            this.DeleteRequest,
            this.ChangeStatus});
            this.RequestControls.Name = "RequestControls";
            this.RequestControls.Size = new System.Drawing.Size(189, 116);
            // 
            // EditRequest
            // 
            this.EditRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.EditRequest.Image = global::DBS25P023.Properties.Resources.edit;
            this.EditRequest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditRequest.Name = "EditRequest";
            this.EditRequest.Size = new System.Drawing.Size(188, 30);
            this.EditRequest.Text = "Edit Request";
            this.EditRequest.Click += new System.EventHandler(this.EditRequest_Click);
            // 
            // DeleteRequest
            // 
            this.DeleteRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.DeleteRequest.Image = global::DBS25P023.Properties.Resources.del;
            this.DeleteRequest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteRequest.Name = "DeleteRequest";
            this.DeleteRequest.Size = new System.Drawing.Size(188, 30);
            this.DeleteRequest.Text = "Delete Request";
            this.DeleteRequest.Click += new System.EventHandler(this.DeleteRequest_Click);
            // 
            // ChangeStatus
            // 
            this.ChangeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.ChangeStatus.Image = global::DBS25P023.Properties.Resources.approve;
            this.ChangeStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangeStatus.Name = "ChangeStatus";
            this.ChangeStatus.Size = new System.Drawing.Size(188, 30);
            this.ChangeStatus.Text = "Change Status";
            this.ChangeStatus.Click += new System.EventHandler(this.ChangeStatus_Click);
            // 
            // FacultyRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FacultyRequests";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(780, 635);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchRequestBtn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Requests)).EndInit();
            this.RequestControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox SearchRequestBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button NewRequest;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Requests;
        private System.Windows.Forms.ContextMenuStrip RequestControls;
        private System.Windows.Forms.ToolStripMenuItem EditRequest;
        private System.Windows.Forms.ToolStripMenuItem DeleteRequest;
        private System.Windows.Forms.ToolStripMenuItem ChangeStatus;
    }
}
