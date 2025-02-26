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
            this.SplashLogo = new System.Windows.Forms.PictureBox();
            this.LoadingBar = new System.Windows.Forms.Panel();
            this.LoadingBarHead = new System.Windows.Forms.Panel();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplashLogo)).BeginInit();
            this.LoadingBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashLogo
            // 
            this.SplashLogo.BackColor = System.Drawing.Color.Transparent;
            this.SplashLogo.ErrorImage = global::DBS25P023.Properties.Resources.SplashLogo;
            this.SplashLogo.Image = global::DBS25P023.Properties.Resources.SplashLogo;
            this.SplashLogo.InitialImage = global::DBS25P023.Properties.Resources.SplashLogo;
            this.SplashLogo.Location = new System.Drawing.Point(12, 10);
            this.SplashLogo.Name = "SplashLogo";
            this.SplashLogo.Size = new System.Drawing.Size(80, 80);
            this.SplashLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SplashLogo.TabIndex = 0;
            this.SplashLogo.TabStop = false;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Controls.Add(this.LoadingBarHead);
            this.LoadingBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoadingBar.Location = new System.Drawing.Point(0, 342);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(480, 8);
            this.LoadingBar.TabIndex = 1;
            // 
            // LoadingBarHead
            // 
            this.LoadingBarHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.LoadingBarHead.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoadingBarHead.Location = new System.Drawing.Point(0, 0);
            this.LoadingBarHead.Name = "LoadingBarHead";
            this.LoadingBarHead.Size = new System.Drawing.Size(14, 8);
            this.LoadingBarHead.TabIndex = 0;
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::DBS25P023.Properties.Resources.logo;
            this.pictureBox1.Image = global::DBS25P023.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::DBS25P023.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(147, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(98, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department of\r\nCOMPUTER\r\nSCIENCE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(69, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Developed By ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(170, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hafiz Muhammad Moaz (2024-CS-23)";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DBS25P023.Properties.Resources.SplashBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(480, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.SplashLogo);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashLogo)).EndInit();
            this.LoadingBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashLogo;
        private System.Windows.Forms.Panel LoadingBar;
        private System.Windows.Forms.Panel LoadingBarHead;
        private System.Windows.Forms.Timer LoadingTimer;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}