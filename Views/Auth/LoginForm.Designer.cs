namespace DBS25P023.Views.Auth {
    partial class LoginForm {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.ViewPassword = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ForgotPassword = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.FormPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPassword)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.Color.White;
            this.FormPanel.Controls.Add(this.panel2);
            this.FormPanel.Controls.Add(this.ViewPassword);
            this.FormPanel.Controls.Add(this.panel1);
            this.FormPanel.Controls.Add(this.label2);
            this.FormPanel.Controls.Add(this.label1);
            this.FormPanel.Controls.Add(this.ForgotPassword);
            this.FormPanel.Controls.Add(this.Logo);
            this.FormPanel.Controls.Add(this.SignIn);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(390, 420);
            this.FormPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Password);
            this.panel2.Location = new System.Drawing.Point(42, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 50);
            this.panel2.TabIndex = 7;
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(9, 9);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(251, 30);
            this.Password.TabIndex = 0;
            // 
            // ViewPassword
            // 
            this.ViewPassword.BackColor = System.Drawing.Color.Transparent;
            this.ViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ViewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewPassword.ErrorImage = global::DBS25P023.Properties.Resources.eye;
            this.ViewPassword.Image = global::DBS25P023.Properties.Resources.eye;
            this.ViewPassword.InitialImage = global::DBS25P023.Properties.Resources.eye;
            this.ViewPassword.Location = new System.Drawing.Point(312, 252);
            this.ViewPassword.Name = "ViewPassword";
            this.ViewPassword.Size = new System.Drawing.Size(50, 50);
            this.ViewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ViewPassword.TabIndex = 6;
            this.ViewPassword.TabStop = false;
            this.ViewPassword.Click += new System.EventHandler(this.ViewPassword_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Username);
            this.panel1.Location = new System.Drawing.Point(42, 162);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(44, 225);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(44, 133);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "USERNAME";
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.ForgotPassword.Location = new System.Drawing.Point(131, 392);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(127, 19);
            this.ForgotPassword.TabIndex = 4;
            this.ForgotPassword.Text = "Forgot Password ?";
            this.ForgotPassword.Click += new System.EventHandler(this.ForgotPassword_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo.ErrorImage = global::DBS25P023.Properties.Resources.icon_large;
            this.Logo.Image = global::DBS25P023.Properties.Resources.icon_large;
            this.Logo.InitialImage = global::DBS25P023.Properties.Resources.icon_large;
            this.Logo.Location = new System.Drawing.Point(149, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(100, 100);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.Color.White;
            this.SignIn.Location = new System.Drawing.Point(84, 323);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(230, 55);
            this.SignIn.TabIndex = 1;
            this.SignIn.Text = "SIGN IN";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FormPanel);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(390, 420);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPassword)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox ViewPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ForgotPassword;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button SignIn;
    }
}
