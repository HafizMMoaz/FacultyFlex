namespace DBS25P023.UI {
    partial class ForgotPassword {
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
            this.FormPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackToLogin = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.FormPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.Color.White;
            this.FormPanel.Controls.Add(this.panel1);
            this.FormPanel.Controls.Add(this.Content);
            this.FormPanel.Controls.Add(this.label1);
            this.FormPanel.Controls.Add(this.BackToLogin);
            this.FormPanel.Controls.Add(this.ResetBtn);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(390, 420);
            this.FormPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Username);
            this.panel1.Location = new System.Drawing.Point(34, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 50);
            this.panel1.TabIndex = 7;
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.Location = new System.Drawing.Point(9, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(300, 30);
            this.Username.TabIndex = 0;
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.BackColor = System.Drawing.Color.Transparent;
            this.Content.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.Content.Location = new System.Drawing.Point(46, 47);
            this.Content.Name = "Content";
            this.Content.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Content.Size = new System.Drawing.Size(298, 92);
            this.Content.TabIndex = 5;
            this.Content.Text = "Forgot your password? Enter your \r\nusername and submit a request. Our \r\nadmin tea" +
    "m will reset your password \r\nand notify you once it\'s updated.";
            this.Content.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(36, 172);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "USERNAME";
            // 
            // BackToLogin
            // 
            this.BackToLogin.AutoSize = true;
            this.BackToLogin.BackColor = System.Drawing.Color.Transparent;
            this.BackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.BackToLogin.Location = new System.Drawing.Point(122, 353);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(156, 19);
            this.BackToLogin.TabIndex = 4;
            this.BackToLogin.Text = "Back To Login Screen ?";
            this.BackToLogin.Click += new System.EventHandler(this.BackToLogin_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(84, 279);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(230, 55);
            this.ResetBtn.TabIndex = 1;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FormPanel);
            this.Name = "ForgotPassword";
            this.Size = new System.Drawing.Size(390, 420);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BackToLogin;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label Content;
    }
}
