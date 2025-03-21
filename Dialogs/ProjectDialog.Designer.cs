namespace DBS25P023.Dialogs {
    partial class ProjectDialog {
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
            this.ProjectDescription = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.titllelabel = new System.Windows.Forms.Label();
            this.ProjectTitle = new System.Windows.Forms.TextBox();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionBtn
            // 
            this.ActionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.ActionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionBtn.ForeColor = System.Drawing.Color.White;
            this.ActionBtn.Location = new System.Drawing.Point(114, 484);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(142, 55);
            this.ActionBtn.TabIndex = 33;
            this.ActionBtn.Text = "ADD";
            this.ActionBtn.UseVisualStyleBackColor = false;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // ProjectDescription
            // 
            this.ProjectDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectDescription.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDescription.ForeColor = System.Drawing.Color.Black;
            this.ProjectDescription.Location = new System.Drawing.Point(9, 9);
            this.ProjectDescription.Multiline = true;
            this.ProjectDescription.Name = "ProjectDescription";
            this.ProjectDescription.Size = new System.Drawing.Size(300, 240);
            this.ProjectDescription.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.Title.Location = new System.Drawing.Point(108, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(119, 36);
            this.Title.TabIndex = 32;
            this.Title.Text = "PROJECT";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ProjectDescription);
            this.panel3.Location = new System.Drawing.Point(30, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 260);
            this.panel3.TabIndex = 28;
            // 
            // titllelabel
            // 
            this.titllelabel.AutoSize = true;
            this.titllelabel.BackColor = System.Drawing.Color.Transparent;
            this.titllelabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titllelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.titllelabel.Location = new System.Drawing.Point(30, 86);
            this.titllelabel.Name = "titllelabel";
            this.titllelabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titllelabel.Size = new System.Drawing.Size(44, 19);
            this.titllelabel.TabIndex = 31;
            this.titllelabel.Text = "TITLE";
            // 
            // ProjectTitle
            // 
            this.ProjectTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitle.ForeColor = System.Drawing.Color.Black;
            this.ProjectTitle.Location = new System.Drawing.Point(9, 9);
            this.ProjectTitle.Name = "ProjectTitle";
            this.ProjectTitle.Size = new System.Drawing.Size(300, 30);
            this.ProjectTitle.TabIndex = 0;
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.AutoSize = true;
            this.descriptionlabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionlabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.descriptionlabel.Location = new System.Drawing.Point(30, 175);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descriptionlabel.Size = new System.Drawing.Size(97, 19);
            this.descriptionlabel.TabIndex = 34;
            this.descriptionlabel.Text = "DESCRIPTION";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ProjectTitle);
            this.panel1.Location = new System.Drawing.Point(30, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 50);
            this.panel1.TabIndex = 26;
            // 
            // ProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 569);
            this.Controls.Add(this.ActionBtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.titllelabel);
            this.Controls.Add(this.descriptionlabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.ProjectDialog_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.TextBox ProjectDescription;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label titllelabel;
        private System.Windows.Forms.TextBox ProjectTitle;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.Panel panel1;
    }
}