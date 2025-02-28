namespace DBS25P023.UI {
    partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.LoginDash = new System.Windows.Forms.PictureBox();
            this.Para2 = new System.Windows.Forms.Label();
            this.Para1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.LoginForm = new DBS25P023.UI.LoginForm();
            this.ForgotPasswordForm = new DBS25P023.UI.ForgotPassword();
            this.FormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginDash)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.Controls.Add(this.CloseBtn);
            this.FormPanel.Controls.Add(this.LoginForm);
            this.FormPanel.Controls.Add(this.ForgotPasswordForm);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormPanel.Location = new System.Drawing.Point(500, 0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(400, 500);
            this.FormPanel.TabIndex = 2;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.ErrorImage = global::DBS25P023.Properties.Resources.close;
            this.CloseBtn.Image = global::DBS25P023.Properties.Resources.close;
            this.CloseBtn.InitialImage = global::DBS25P023.Properties.Resources.close;
            this.CloseBtn.Location = new System.Drawing.Point(350, 20);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.InfoPanel.BackgroundImage = global::DBS25P023.Properties.Resources.loginBG;
            this.InfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InfoPanel.Controls.Add(this.LoginDash);
            this.InfoPanel.Controls.Add(this.Para2);
            this.InfoPanel.Controls.Add(this.Para1);
            this.InfoPanel.Controls.Add(this.Title);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(500, 500);
            this.InfoPanel.TabIndex = 0;
            // 
            // LoginDash
            // 
            this.LoginDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.LoginDash.ErrorImage = global::DBS25P023.Properties.Resources.loginDashboard;
            this.LoginDash.Image = global::DBS25P023.Properties.Resources.loginDashboard;
            this.LoginDash.InitialImage = global::DBS25P023.Properties.Resources.loginDashboard;
            this.LoginDash.Location = new System.Drawing.Point(149, 291);
            this.LoginDash.Name = "LoginDash";
            this.LoginDash.Size = new System.Drawing.Size(418, 311);
            this.LoginDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginDash.TabIndex = 2;
            this.LoginDash.TabStop = false;
            // 
            // Para2
            // 
            this.Para2.AutoSize = true;
            this.Para2.BackColor = System.Drawing.Color.Transparent;
            this.Para2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Para2.ForeColor = System.Drawing.Color.White;
            this.Para2.Location = new System.Drawing.Point(41, 207);
            this.Para2.Name = "Para2";
            this.Para2.Size = new System.Drawing.Size(399, 63);
            this.Para2.TabIndex = 1;
            this.Para2.Text = "Use Faculty Flex to streamline your workflow, boost \r\nperformance, and stay conne" +
    "cted with your institution \r\neffortlessly.";
            // 
            // Para1
            // 
            this.Para1.AutoSize = true;
            this.Para1.BackColor = System.Drawing.Color.Transparent;
            this.Para1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Para1.ForeColor = System.Drawing.Color.White;
            this.Para1.Location = new System.Drawing.Point(41, 131);
            this.Para1.Name = "Para1";
            this.Para1.Size = new System.Drawing.Size(429, 63);
            this.Para1.TabIndex = 1;
            this.Para1.Text = "Sign in using the credentials provided by your department. \r\nIf you have trouble " +
    "accessing your account, please contact \r\nthe administrator.";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(36, 59);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(408, 53);
            this.Title.TabIndex = 0;
            this.Title.Text = "Sign in to Faculty Flex";
            // 
            // LoginForm
            // 
            this.LoginForm.Location = new System.Drawing.Point(0, 54);
            this.LoginForm.Name = "LoginForm";
            this.LoginForm.Size = new System.Drawing.Size(400, 420);
            this.LoginForm.TabIndex = 5;
            // 
            // ForgotPasswordForm
            // 
            this.ForgotPasswordForm.Location = new System.Drawing.Point(0, 59);
            this.ForgotPasswordForm.Name = "ForgotPasswordForm";
            this.ForgotPasswordForm.Size = new System.Drawing.Size(400, 420);
            this.ForgotPasswordForm.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.InfoPanel);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginDash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Para2;
        private System.Windows.Forms.Label Para1;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox LoginDash;
        private ForgotPassword ForgotPasswordForm;
        private LoginForm LoginForm;
    }
}