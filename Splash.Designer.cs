namespace DBS25P023 {
    partial class Splash {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.InstituteLogo = new System.Windows.Forms.PictureBox();
            this.LoadingBar = new System.Windows.Forms.Panel();
            this.LoadingBarHead = new System.Windows.Forms.Panel();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.InstituteName = new System.Windows.Forms.Label();
            this.DevelopedBy = new System.Windows.Forms.Label();
            this.HafizMMoaz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InstituteLogo)).BeginInit();
            this.LoadingBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // InstituteLogo
            // 
            this.InstituteLogo.BackColor = System.Drawing.Color.Transparent;
            this.InstituteLogo.ErrorImage = global::DBS25P023.Properties.Resources.SplashLogo;
            this.InstituteLogo.Image = global::DBS25P023.Properties.Resources.SplashLogo;
            this.InstituteLogo.InitialImage = global::DBS25P023.Properties.Resources.SplashLogo;
            this.InstituteLogo.Location = new System.Drawing.Point(12, 10);
            this.InstituteLogo.Name = "InstituteLogo";
            this.InstituteLogo.Size = new System.Drawing.Size(80, 80);
            this.InstituteLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InstituteLogo.TabIndex = 0;
            this.InstituteLogo.TabStop = false;
            this.InstituteLogo.UseWaitCursor = true;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Controls.Add(this.LoadingBarHead);
            this.LoadingBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoadingBar.Location = new System.Drawing.Point(0, 342);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(480, 8);
            this.LoadingBar.TabIndex = 1;
            this.LoadingBar.UseWaitCursor = true;
            // 
            // LoadingBarHead
            // 
            this.LoadingBarHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.LoadingBarHead.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoadingBarHead.Location = new System.Drawing.Point(0, 0);
            this.LoadingBarHead.Name = "LoadingBarHead";
            this.LoadingBarHead.Size = new System.Drawing.Size(14, 8);
            this.LoadingBarHead.TabIndex = 0;
            this.LoadingBarHead.UseWaitCursor = true;
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Enabled = true;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.Title.Location = new System.Drawing.Point(94, 244);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(292, 54);
            this.Title.TabIndex = 1;
            this.Title.Text = "FACULTY FLEX";
            this.Title.UseWaitCursor = true;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.ErrorImage = global::DBS25P023.Properties.Resources.logo;
            this.Logo.Image = global::DBS25P023.Properties.Resources.logo;
            this.Logo.InitialImage = global::DBS25P023.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(147, 73);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(184, 176);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            this.Logo.UseWaitCursor = true;
            // 
            // InstituteName
            // 
            this.InstituteName.AutoSize = true;
            this.InstituteName.BackColor = System.Drawing.Color.Transparent;
            this.InstituteName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstituteName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.InstituteName.Location = new System.Drawing.Point(98, 12);
            this.InstituteName.Name = "InstituteName";
            this.InstituteName.Size = new System.Drawing.Size(110, 57);
            this.InstituteName.TabIndex = 1;
            this.InstituteName.Text = "Department of\r\nCOMPUTER\r\nSCIENCE";
            this.InstituteName.UseWaitCursor = true;
            // 
            // DevelopedBy
            // 
            this.DevelopedBy.AutoSize = true;
            this.DevelopedBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevelopedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.DevelopedBy.Location = new System.Drawing.Point(69, 313);
            this.DevelopedBy.Name = "DevelopedBy";
            this.DevelopedBy.Size = new System.Drawing.Size(97, 18);
            this.DevelopedBy.TabIndex = 1;
            this.DevelopedBy.Text = "Developed By ";
            this.DevelopedBy.UseWaitCursor = true;
            // 
            // HafizMMoaz
            // 
            this.HafizMMoaz.AutoSize = true;
            this.HafizMMoaz.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HafizMMoaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.HafizMMoaz.Location = new System.Drawing.Point(170, 313);
            this.HafizMMoaz.Name = "HafizMMoaz";
            this.HafizMMoaz.Size = new System.Drawing.Size(237, 18);
            this.HafizMMoaz.TabIndex = 1;
            this.HafizMMoaz.Text = "Hafiz Muhammad Moaz (2024-CS-23)";
            this.HafizMMoaz.UseWaitCursor = true;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DBS25P023.Properties.Resources.SplashBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(480, 350);
            this.Controls.Add(this.HafizMMoaz);
            this.Controls.Add(this.DevelopedBy);
            this.Controls.Add(this.InstituteName);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.InstituteLogo);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.InstituteLogo)).EndInit();
            this.LoadingBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox InstituteLogo;
        private System.Windows.Forms.Panel LoadingBar;
        private System.Windows.Forms.Panel LoadingBarHead;
        private System.Windows.Forms.Timer LoadingTimer;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label InstituteName;
        private System.Windows.Forms.Label DevelopedBy;
        private System.Windows.Forms.Label HafizMMoaz;
    }
}