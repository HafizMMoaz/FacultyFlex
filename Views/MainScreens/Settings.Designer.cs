namespace DBS25P023.Views.MainScreens {
    partial class Settings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Account = new System.Windows.Forms.TabPage();
            this.UpdateProfile = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel27 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.ViewPassword = new System.Windows.Forms.PictureBox();
            this.panel28 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.TextBox();
            this.panel29 = new System.Windows.Forms.Panel();
            this.Contact = new System.Windows.Forms.TextBox();
            this.panel30 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.TextBox();
            this.panel31 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NavBarImages = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.Account.SuspendLayout();
            this.panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPassword)).BeginInit();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel31.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Account);
            this.Tabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.ImageList = this.NavBarImages;
            this.Tabs.ItemSize = new System.Drawing.Size(50, 40);
            this.Tabs.Location = new System.Drawing.Point(10, 127);
            this.Tabs.Multiline = true;
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Drawing.Point(15, 3);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(760, 498);
            this.Tabs.TabIndex = 14;
            // 
            // Account
            // 
            this.Account.Controls.Add(this.UpdateProfile);
            this.Account.Controls.Add(this.panel26);
            this.Account.Controls.Add(this.pictureBox1);
            this.Account.Controls.Add(this.panel27);
            this.Account.Controls.Add(this.ViewPassword);
            this.Account.Controls.Add(this.panel28);
            this.Account.Controls.Add(this.panel29);
            this.Account.Controls.Add(this.panel30);
            this.Account.Controls.Add(this.panel31);
            this.Account.Controls.Add(this.label6);
            this.Account.Controls.Add(this.label8);
            this.Account.Controls.Add(this.label5);
            this.Account.Controls.Add(this.label7);
            this.Account.Controls.Add(this.label3);
            this.Account.Controls.Add(this.label4);
            this.Account.ImageKey = "role.png";
            this.Account.Location = new System.Drawing.Point(4, 44);
            this.Account.Name = "Account";
            this.Account.Padding = new System.Windows.Forms.Padding(3);
            this.Account.Size = new System.Drawing.Size(752, 450);
            this.Account.TabIndex = 7;
            this.Account.Text = "Account";
            this.Account.UseVisualStyleBackColor = true;
            // 
            // UpdateProfile
            // 
            this.UpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.UpdateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProfile.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProfile.ForeColor = System.Drawing.Color.White;
            this.UpdateProfile.Location = new System.Drawing.Point(275, 326);
            this.UpdateProfile.Name = "UpdateProfile";
            this.UpdateProfile.Size = new System.Drawing.Size(230, 55);
            this.UpdateProfile.TabIndex = 28;
            this.UpdateProfile.Text = "UPDATE";
            this.UpdateProfile.UseVisualStyleBackColor = false;
            this.UpdateProfile.Click += new System.EventHandler(this.UpdateProfile_Click);
            // 
            // panel26
            // 
            this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel26.Controls.Add(this.ConfirmPassword);
            this.panel26.Location = new System.Drawing.Point(397, 148);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(272, 50);
            this.panel26.TabIndex = 3;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPassword.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.ConfirmPassword.Location = new System.Drawing.Point(9, 9);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(251, 30);
            this.ConfirmPassword.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = global::DBS25P023.Properties.Resources.eye;
            this.pictureBox1.Image = global::DBS25P023.Properties.Resources.eye;
            this.pictureBox1.InitialImage = global::DBS25P023.Properties.Resources.eye;
            this.pictureBox1.Location = new System.Drawing.Point(667, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel27
            // 
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel27.Controls.Add(this.Password);
            this.panel27.Location = new System.Drawing.Point(35, 148);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(272, 50);
            this.panel27.TabIndex = 2;
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
            this.ViewPassword.Location = new System.Drawing.Point(305, 148);
            this.ViewPassword.Name = "ViewPassword";
            this.ViewPassword.Size = new System.Drawing.Size(50, 50);
            this.ViewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ViewPassword.TabIndex = 21;
            this.ViewPassword.TabStop = false;
            // 
            // panel28
            // 
            this.panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel28.Controls.Add(this.Username);
            this.panel28.Location = new System.Drawing.Point(397, 58);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(320, 50);
            this.panel28.TabIndex = 1;
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
            // panel29
            // 
            this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel29.Controls.Add(this.Contact);
            this.panel29.Location = new System.Drawing.Point(397, 245);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(320, 50);
            this.panel29.TabIndex = 5;
            // 
            // Contact
            // 
            this.Contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contact.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.ForeColor = System.Drawing.Color.Black;
            this.Contact.Location = new System.Drawing.Point(9, 9);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(300, 30);
            this.Contact.TabIndex = 0;
            // 
            // panel30
            // 
            this.panel30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel30.Controls.Add(this.Email);
            this.panel30.Location = new System.Drawing.Point(35, 245);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(320, 50);
            this.panel30.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.Location = new System.Drawing.Point(9, 9);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(300, 30);
            this.Email.TabIndex = 0;
            // 
            // panel31
            // 
            this.panel31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel31.Controls.Add(this.name);
            this.panel31.Location = new System.Drawing.Point(35, 58);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(320, 50);
            this.panel31.TabIndex = 0;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(9, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(300, 30);
            this.name.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label6.Location = new System.Drawing.Point(399, 121);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(150, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "CONFIRM PASSWORD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label8.Location = new System.Drawing.Point(399, 216);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "CONTACT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label5.Location = new System.Drawing.Point(399, 29);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "USERNAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label7.Location = new System.Drawing.Point(37, 216);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(37, 121);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label4.Location = new System.Drawing.Point(37, 29);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "NAME";
            // 
            // NavBarImages
            // 
            this.NavBarImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NavBarImages.ImageStream")));
            this.NavBarImages.TransparentColor = System.Drawing.Color.Transparent;
            this.NavBarImages.Images.SetKeyName(0, "role.png");
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(780, 635);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.Account.ResumeLayout(false);
            this.Account.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPassword)).EndInit();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Account;
        private System.Windows.Forms.Button UpdateProfile;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox ViewPassword;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList NavBarImages;
    }
}
