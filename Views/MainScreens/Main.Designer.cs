namespace DBS25P023.Views.MainScreens {
    partial class Main {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.ControlButtons = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.TitleBarIcon = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.Panel();
            this.ActivityIndicator = new System.Windows.Forms.Panel();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.FacultyRequestBtn = new System.Windows.Forms.Button();
            this.ResourcesBtn = new System.Windows.Forms.Button();
            this.WorkloadBtn = new System.Windows.Forms.Button();
            this.UserBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.SofwareTitle = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.MenuToggle = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.Panel();
            this.Dashboard = new DBS25P023.Views.MainScreens.Dashboard();
            this.UserManagement = new DBS25P023.Views.MainScreens.UserManagement();
            this.FacultyWorkload = new DBS25P023.Views.MainScreens.FacultyWorkload();
            this.ResourceAllocation = new DBS25P023.Views.MainScreens.ResourceAllocation();
            this.Reports = new DBS25P023.Views.MainScreens.Reports();
            this.Settings = new DBS25P023.Views.MainScreens.Settings();
            this.FacultyRequests = new DBS25P023.Views.MainScreens.FacultyRequests();
            this.TitleBar.SuspendLayout();
            this.ControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBarIcon)).BeginInit();
            this.SideBar.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuToggle)).BeginInit();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TitleBar.Controls.Add(this.ControlButtons);
            this.TitleBar.Controls.Add(this.TitleBarIcon);
            this.TitleBar.Controls.Add(this.Title);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1080, 35);
            this.TitleBar.TabIndex = 0;
            // 
            // ControlButtons
            // 
            this.ControlButtons.BackColor = System.Drawing.Color.White;
            this.ControlButtons.Controls.Add(this.Minimize);
            this.ControlButtons.Controls.Add(this.Exit);
            this.ControlButtons.Controls.Add(this.Maximize);
            this.ControlButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlButtons.Location = new System.Drawing.Point(972, 0);
            this.ControlButtons.Name = "ControlButtons";
            this.ControlButtons.Size = new System.Drawing.Size(108, 35);
            this.ControlButtons.TabIndex = 3;
            // 
            // Minimize
            // 
            this.Minimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Image = global::DBS25P023.Properties.Resources.minimize;
            this.Minimize.Location = new System.Drawing.Point(7, 5);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(25, 25);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 2;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = global::DBS25P023.Properties.Resources.close;
            this.Exit.Location = new System.Drawing.Point(76, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Maximize
            // 
            this.Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize.Image = global::DBS25P023.Properties.Resources.maximize;
            this.Maximize.Location = new System.Drawing.Point(37, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(33, 35);
            this.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximize.TabIndex = 2;
            this.Maximize.TabStop = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // TitleBarIcon
            // 
            this.TitleBarIcon.BackColor = System.Drawing.Color.Transparent;
            this.TitleBarIcon.Image = global::DBS25P023.Properties.Resources.icon;
            this.TitleBarIcon.Location = new System.Drawing.Point(8, 5);
            this.TitleBarIcon.Name = "TitleBarIcon";
            this.TitleBarIcon.Size = new System.Drawing.Size(25, 25);
            this.TitleBarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitleBarIcon.TabIndex = 1;
            this.TitleBarIcon.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(36, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(81, 18);
            this.Title.TabIndex = 0;
            this.Title.Text = "Faculty Flex";
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.SideBar.Controls.Add(this.ActivityIndicator);
            this.SideBar.Controls.Add(this.SettingBtn);
            this.SideBar.Controls.Add(this.ReportBtn);
            this.SideBar.Controls.Add(this.LogoutBtn);
            this.SideBar.Controls.Add(this.FacultyRequestBtn);
            this.SideBar.Controls.Add(this.ResourcesBtn);
            this.SideBar.Controls.Add(this.WorkloadBtn);
            this.SideBar.Controls.Add(this.UserBtn);
            this.SideBar.Controls.Add(this.DashboardBtn);
            this.SideBar.Controls.Add(this.SofwareTitle);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 35);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(300, 685);
            this.SideBar.TabIndex = 1;
            // 
            // ActivityIndicator
            // 
            this.ActivityIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.ActivityIndicator.Location = new System.Drawing.Point(0, 105);
            this.ActivityIndicator.Name = "ActivityIndicator";
            this.ActivityIndicator.Size = new System.Drawing.Size(5, 60);
            this.ActivityIndicator.TabIndex = 2;
            // 
            // SettingBtn
            // 
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Image = global::DBS25P023.Properties.Resources.settings;
            this.SettingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingBtn.Location = new System.Drawing.Point(0, 465);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.SettingBtn.Size = new System.Drawing.Size(300, 60);
            this.SettingBtn.TabIndex = 1;
            this.SettingBtn.Text = "Settings";
            this.SettingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportBtn.FlatAppearance.BorderSize = 0;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.White;
            this.ReportBtn.Image = global::DBS25P023.Properties.Resources.reports;
            this.ReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReportBtn.Location = new System.Drawing.Point(0, 405);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.ReportBtn.Size = new System.Drawing.Size(300, 60);
            this.ReportBtn.TabIndex = 1;
            this.ReportBtn.Text = "Reports ";
            this.ReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ReportBtn.UseVisualStyleBackColor = true;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Image = global::DBS25P023.Properties.Resources.logout;
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 625);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.LogoutBtn.Size = new System.Drawing.Size(300, 60);
            this.LogoutBtn.TabIndex = 1;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // FacultyRequestBtn
            // 
            this.FacultyRequestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FacultyRequestBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FacultyRequestBtn.FlatAppearance.BorderSize = 0;
            this.FacultyRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FacultyRequestBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyRequestBtn.ForeColor = System.Drawing.Color.White;
            this.FacultyRequestBtn.Image = global::DBS25P023.Properties.Resources.reports;
            this.FacultyRequestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FacultyRequestBtn.Location = new System.Drawing.Point(0, 345);
            this.FacultyRequestBtn.Name = "FacultyRequestBtn";
            this.FacultyRequestBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.FacultyRequestBtn.Size = new System.Drawing.Size(300, 60);
            this.FacultyRequestBtn.TabIndex = 1;
            this.FacultyRequestBtn.Text = "Faculty Requests";
            this.FacultyRequestBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FacultyRequestBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FacultyRequestBtn.UseVisualStyleBackColor = true;
            this.FacultyRequestBtn.Click += new System.EventHandler(this.FacultyRequestBtn_Click);
            // 
            // ResourcesBtn
            // 
            this.ResourcesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResourcesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResourcesBtn.FlatAppearance.BorderSize = 0;
            this.ResourcesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResourcesBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResourcesBtn.ForeColor = System.Drawing.Color.White;
            this.ResourcesBtn.Image = global::DBS25P023.Properties.Resources.resources;
            this.ResourcesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResourcesBtn.Location = new System.Drawing.Point(0, 285);
            this.ResourcesBtn.Name = "ResourcesBtn";
            this.ResourcesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.ResourcesBtn.Size = new System.Drawing.Size(300, 60);
            this.ResourcesBtn.TabIndex = 1;
            this.ResourcesBtn.Text = "Resource Allocation";
            this.ResourcesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResourcesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ResourcesBtn.UseVisualStyleBackColor = true;
            this.ResourcesBtn.Click += new System.EventHandler(this.ResourcesBtn_Click);
            // 
            // WorkloadBtn
            // 
            this.WorkloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkloadBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkloadBtn.FlatAppearance.BorderSize = 0;
            this.WorkloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkloadBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkloadBtn.ForeColor = System.Drawing.Color.White;
            this.WorkloadBtn.Image = global::DBS25P023.Properties.Resources.wordload;
            this.WorkloadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkloadBtn.Location = new System.Drawing.Point(0, 225);
            this.WorkloadBtn.Name = "WorkloadBtn";
            this.WorkloadBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.WorkloadBtn.Size = new System.Drawing.Size(300, 60);
            this.WorkloadBtn.TabIndex = 1;
            this.WorkloadBtn.Text = "Assign Workload";
            this.WorkloadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkloadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.WorkloadBtn.UseVisualStyleBackColor = true;
            this.WorkloadBtn.Click += new System.EventHandler(this.WorkloadBtn_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserBtn.FlatAppearance.BorderSize = 0;
            this.UserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.ForeColor = System.Drawing.Color.White;
            this.UserBtn.Image = global::DBS25P023.Properties.Resources.users;
            this.UserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserBtn.Location = new System.Drawing.Point(0, 165);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.UserBtn.Size = new System.Drawing.Size(300, 60);
            this.UserBtn.TabIndex = 1;
            this.UserBtn.Text = "Users Management";
            this.UserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UserBtn.UseVisualStyleBackColor = true;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.Color.White;
            this.DashboardBtn.Image = global::DBS25P023.Properties.Resources.home;
            this.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DashboardBtn.Location = new System.Drawing.Point(0, 105);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.DashboardBtn.Size = new System.Drawing.Size(300, 60);
            this.DashboardBtn.TabIndex = 1;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // SofwareTitle
            // 
            this.SofwareTitle.AutoSize = true;
            this.SofwareTitle.BackColor = System.Drawing.Color.Transparent;
            this.SofwareTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.SofwareTitle.Font = new System.Drawing.Font("Leelawadee UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SofwareTitle.ForeColor = System.Drawing.Color.White;
            this.SofwareTitle.Location = new System.Drawing.Point(0, 0);
            this.SofwareTitle.Name = "SofwareTitle";
            this.SofwareTitle.Padding = new System.Windows.Forms.Padding(30, 20, 30, 40);
            this.SofwareTitle.Size = new System.Drawing.Size(297, 105);
            this.SofwareTitle.TabIndex = 0;
            this.SofwareTitle.Text = "FACULTY FLEX";
            // 
            // Header
            // 
            this.Header.Controls.Add(this.MenuToggle);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(300, 35);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(780, 50);
            this.Header.TabIndex = 2;
            // 
            // MenuToggle
            // 
            this.MenuToggle.BackColor = System.Drawing.Color.Transparent;
            this.MenuToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuToggle.ErrorImage = global::DBS25P023.Properties.Resources.menu;
            this.MenuToggle.Image = global::DBS25P023.Properties.Resources.menu;
            this.MenuToggle.InitialImage = global::DBS25P023.Properties.Resources.menu;
            this.MenuToggle.Location = new System.Drawing.Point(10, 10);
            this.MenuToggle.Name = "MenuToggle";
            this.MenuToggle.Size = new System.Drawing.Size(30, 30);
            this.MenuToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuToggle.TabIndex = 0;
            this.MenuToggle.TabStop = false;
            this.MenuToggle.Click += new System.EventHandler(this.MenuToggle_Click);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.White;
            this.Content.Controls.Add(this.Dashboard);
            this.Content.Controls.Add(this.UserManagement);
            this.Content.Controls.Add(this.FacultyWorkload);
            this.Content.Controls.Add(this.ResourceAllocation);
            this.Content.Controls.Add(this.Reports);
            this.Content.Controls.Add(this.Settings);
            this.Content.Controls.Add(this.FacultyRequests);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(300, 85);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(780, 635);
            this.Content.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.White;
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(780, 635);
            this.Dashboard.TabIndex = 5;
            // 
            // UserManagement
            // 
            this.UserManagement.BackColor = System.Drawing.Color.White;
            this.UserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserManagement.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManagement.Location = new System.Drawing.Point(0, 0);
            this.UserManagement.Name = "UserManagement";
            this.UserManagement.Padding = new System.Windows.Forms.Padding(10);
            this.UserManagement.Size = new System.Drawing.Size(780, 635);
            this.UserManagement.TabIndex = 4;
            // 
            // FacultyWorkload
            // 
            this.FacultyWorkload.BackColor = System.Drawing.Color.White;
            this.FacultyWorkload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacultyWorkload.Location = new System.Drawing.Point(0, 0);
            this.FacultyWorkload.Name = "FacultyWorkload";
            this.FacultyWorkload.Padding = new System.Windows.Forms.Padding(10);
            this.FacultyWorkload.Size = new System.Drawing.Size(780, 635);
            this.FacultyWorkload.TabIndex = 3;
            // 
            // ResourceAllocation
            // 
            this.ResourceAllocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResourceAllocation.Location = new System.Drawing.Point(0, 0);
            this.ResourceAllocation.Name = "ResourceAllocation";
            this.ResourceAllocation.Size = new System.Drawing.Size(780, 635);
            this.ResourceAllocation.TabIndex = 2;
            // 
            // Reports
            // 
            this.Reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reports.Location = new System.Drawing.Point(0, 0);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(780, 635);
            this.Reports.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.White;
            this.Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings.Location = new System.Drawing.Point(0, 0);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(10);
            this.Settings.Size = new System.Drawing.Size(780, 635);
            this.Settings.TabIndex = 0;
            // 
            // FacultyRequests
            // 
            this.FacultyRequests.BackColor = System.Drawing.Color.White;
            this.FacultyRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacultyRequests.Location = new System.Drawing.Point(0, 0);
            this.FacultyRequests.Name = "FacultyRequests";
            this.FacultyRequests.Padding = new System.Windows.Forms.Padding(10);
            this.FacultyRequests.Size = new System.Drawing.Size(780, 635);
            this.FacultyRequests.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.TitleBar);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.ControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBarIcon)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuToggle)).EndInit();
            this.Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox TitleBarIcon;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Maximize;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Panel ControlButtons;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox MenuToggle;
        private System.Windows.Forms.Label SofwareTitle;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button ResourcesBtn;
        private System.Windows.Forms.Button WorkloadBtn;
        private System.Windows.Forms.Button UserBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button FacultyRequestBtn;
        private System.Windows.Forms.Panel ActivityIndicator;
        private System.Windows.Forms.Panel Content;
        private Dashboard Dashboard;
        private UserManagement UserManagement;
        private FacultyWorkload FacultyWorkload;
        private ResourceAllocation ResourceAllocation;
        private Reports Reports;
        private Settings Settings;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button ReportBtn;
        private FacultyRequests FacultyRequests;
    }
}

