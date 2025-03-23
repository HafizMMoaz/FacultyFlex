namespace DBS25P023.Views.Installer {
    partial class Install {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Install));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.ViewPassword = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ActionBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DatabaseName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Port = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Server = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.Para2 = new System.Windows.Forms.Label();
            this.Para1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.FormPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPassword)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.Color.White;
            this.FormPanel.Controls.Add(this.panel5);
            this.FormPanel.Controls.Add(this.ViewPassword);
            this.FormPanel.Controls.Add(this.label5);
            this.FormPanel.Controls.Add(this.ActionBtn);
            this.FormPanel.Controls.Add(this.label4);
            this.FormPanel.Controls.Add(this.label3);
            this.FormPanel.Controls.Add(this.label2);
            this.FormPanel.Controls.Add(this.label1);
            this.FormPanel.Controls.Add(this.panel4);
            this.FormPanel.Controls.Add(this.panel3);
            this.FormPanel.Controls.Add(this.panel2);
            this.FormPanel.Controls.Add(this.panel1);
            this.FormPanel.Controls.Add(this.CloseBtn);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormPanel.Location = new System.Drawing.Point(500, 0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(400, 500);
            this.FormPanel.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Password);
            this.panel5.Location = new System.Drawing.Point(40, 349);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 50);
            this.panel5.TabIndex = 4;
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
            this.ViewPassword.Location = new System.Drawing.Point(310, 349);
            this.ViewPassword.Name = "ViewPassword";
            this.ViewPassword.Size = new System.Drawing.Size(50, 50);
            this.ViewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ViewPassword.TabIndex = 28;
            this.ViewPassword.TabStop = false;
            this.ViewPassword.Click += new System.EventHandler(this.ViewPassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label5.Location = new System.Drawing.Point(42, 322);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "PASSWORD";
            // 
            // ActionBtn
            // 
            this.ActionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.ActionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionBtn.ForeColor = System.Drawing.Color.White;
            this.ActionBtn.Location = new System.Drawing.Point(135, 419);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(142, 55);
            this.ActionBtn.TabIndex = 26;
            this.ActionBtn.Text = "INSTALL";
            this.ActionBtn.UseVisualStyleBackColor = false;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label4.Location = new System.Drawing.Point(40, 235);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "DATABASE NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(263, 60);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "SERVER ADDRESS";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Username);
            this.panel4.Location = new System.Drawing.Point(40, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 50);
            this.panel4.TabIndex = 3;
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DatabaseName);
            this.panel3.Location = new System.Drawing.Point(40, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 50);
            this.panel3.TabIndex = 2;
            // 
            // DatabaseName
            // 
            this.DatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseName.ForeColor = System.Drawing.Color.Black;
            this.DatabaseName.Location = new System.Drawing.Point(9, 9);
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(300, 30);
            this.DatabaseName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Port);
            this.panel2.Location = new System.Drawing.Point(263, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 50);
            this.panel2.TabIndex = 1;
            // 
            // Port
            // 
            this.Port.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Port.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.ForeColor = System.Drawing.Color.Black;
            this.Port.Location = new System.Drawing.Point(9, 9);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(77, 30);
            this.Port.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Server);
            this.panel1.Location = new System.Drawing.Point(41, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 50);
            this.panel1.TabIndex = 0;
            // 
            // Server
            // 
            this.Server.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Server.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server.ForeColor = System.Drawing.Color.Black;
            this.Server.Location = new System.Drawing.Point(9, 9);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(183, 30);
            this.Server.TabIndex = 0;
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
            this.InfoPanel.Controls.Add(this.Para2);
            this.InfoPanel.Controls.Add(this.Para1);
            this.InfoPanel.Controls.Add(this.label6);
            this.InfoPanel.Controls.Add(this.Title);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(500, 500);
            this.InfoPanel.TabIndex = 3;
            // 
            // Para2
            // 
            this.Para2.AutoSize = true;
            this.Para2.BackColor = System.Drawing.Color.Transparent;
            this.Para2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Para2.ForeColor = System.Drawing.Color.White;
            this.Para2.Location = new System.Drawing.Point(26, 278);
            this.Para2.Name = "Para2";
            this.Para2.Size = new System.Drawing.Size(469, 84);
            this.Para2.TabIndex = 1;
            this.Para2.Text = resources.GetString("Para2.Text");
            // 
            // Para1
            // 
            this.Para1.AutoSize = true;
            this.Para1.BackColor = System.Drawing.Color.Transparent;
            this.Para1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Para1.ForeColor = System.Drawing.Color.White;
            this.Para1.Location = new System.Drawing.Point(31, 127);
            this.Para1.Name = "Para1";
            this.Para1.Size = new System.Drawing.Size(455, 84);
            this.Para1.TabIndex = 1;
            this.Para1.Text = resources.GetString("Para1.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(431, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Getting Started with Your Application";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(23, 59);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(274, 53);
            this.Title.TabIndex = 0;
            this.Title.Text = "INSTALLATION";
            // 
            // Install
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.InfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Install";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installer";
            this.Load += new System.EventHandler(this.Install_Load);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPassword)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label Para2;
        private System.Windows.Forms.Label Para1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox DatabaseName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox ViewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}