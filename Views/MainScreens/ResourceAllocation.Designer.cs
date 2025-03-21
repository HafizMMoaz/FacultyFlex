namespace DBS25P023.Views.MainScreens {
    partial class ResourceAllocation {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceAllocation));
            this.AssignedRoomSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AssignRoomBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rooms = new System.Windows.Forms.TabPage();
            this.panel22 = new System.Windows.Forms.Panel();
            this.RoomData = new System.Windows.Forms.DataGridView();
            this.RoomControls = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel23 = new System.Windows.Forms.Panel();
            this.AddRoomBtn = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.RoomSearch = new System.Windows.Forms.TextBox();
            this.AssignedRoomsData = new System.Windows.Forms.DataGridView();
            this.AssignRoomsControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.AssignRoom = new System.Windows.Forms.TabPage();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Consumables = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ConsumablesData = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.NewItem = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.SearchItem = new System.Windows.Forms.TextBox();
            this.NavBarImages = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConsumablesControls = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAssignRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAssignRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.AssignedRoomSearchBtn = new System.Windows.Forms.PictureBox();
            this.EditRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomSearchBtn = new System.Windows.Forms.PictureBox();
            this.SearchItemBtn = new System.Windows.Forms.PictureBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.EditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Rooms.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomData)).BeginInit();
            this.RoomControls.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedRoomsData)).BeginInit();
            this.AssignRoomsControl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.AssignRoom.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.Consumables.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumablesData)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ConsumablesControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedRoomSearchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomSearchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchItemBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // AssignedRoomSearch
            // 
            this.AssignedRoomSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AssignedRoomSearch.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedRoomSearch.ForeColor = System.Drawing.Color.Black;
            this.AssignedRoomSearch.Location = new System.Drawing.Point(9, 9);
            this.AssignedRoomSearch.Name = "AssignedRoomSearch";
            this.AssignedRoomSearch.Size = new System.Drawing.Size(251, 30);
            this.AssignedRoomSearch.TabIndex = 0;
            this.AssignedRoomSearch.TextChanged += new System.EventHandler(this.AssignedRoomSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.AssignedRoomSearch);
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 50);
            this.panel2.TabIndex = 9;
            // 
            // AssignRoomBtn
            // 
            this.AssignRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.AssignRoomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssignRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignRoomBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignRoomBtn.ForeColor = System.Drawing.Color.White;
            this.AssignRoomBtn.Location = new System.Drawing.Point(15, 16);
            this.AssignRoomBtn.Name = "AssignRoomBtn";
            this.AssignRoomBtn.Size = new System.Drawing.Size(169, 55);
            this.AssignRoomBtn.TabIndex = 3;
            this.AssignRoomBtn.Text = "ASSIGN ROOM";
            this.AssignRoomBtn.UseVisualStyleBackColor = false;
            this.AssignRoomBtn.Click += new System.EventHandler(this.AssignRoomBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AssignedRoomSearchBtn);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(418, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 84);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AssignRoomBtn);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 84);
            this.panel3.TabIndex = 12;
            // 
            // Rooms
            // 
            this.Rooms.Controls.Add(this.panel22);
            this.Rooms.Controls.Add(this.panel23);
            this.Rooms.ImageKey = "rooms.png";
            this.Rooms.Location = new System.Drawing.Point(4, 44);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(752, 450);
            this.Rooms.TabIndex = 4;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.RoomData);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(0, 84);
            this.panel22.Name = "panel22";
            this.panel22.Padding = new System.Windows.Forms.Padding(15);
            this.panel22.Size = new System.Drawing.Size(752, 366);
            this.panel22.TabIndex = 15;
            // 
            // RoomData
            // 
            this.RoomData.AllowUserToAddRows = false;
            this.RoomData.AllowUserToDeleteRows = false;
            this.RoomData.AllowUserToResizeRows = false;
            this.RoomData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomData.BackgroundColor = System.Drawing.Color.White;
            this.RoomData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RoomData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomData.ContextMenuStrip = this.RoomControls;
            this.RoomData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomData.DefaultCellStyle = dataGridViewCellStyle2;
            this.RoomData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RoomData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RoomData.Location = new System.Drawing.Point(15, 15);
            this.RoomData.MultiSelect = false;
            this.RoomData.Name = "RoomData";
            this.RoomData.ReadOnly = true;
            this.RoomData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RoomData.RowHeadersVisible = false;
            this.RoomData.RowHeadersWidth = 20;
            this.RoomData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RoomData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomData.ShowEditingIcon = false;
            this.RoomData.Size = new System.Drawing.Size(722, 336);
            this.RoomData.TabIndex = 0;
            this.RoomData.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomData_CellMouseEnter);
            // 
            // RoomControls
            // 
            this.RoomControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditRoom,
            this.DeleteRoom});
            this.RoomControls.Name = "RoomControls";
            this.RoomControls.Size = new System.Drawing.Size(151, 64);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.AddRoomBtn);
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(752, 84);
            this.panel23.TabIndex = 14;
            // 
            // AddRoomBtn
            // 
            this.AddRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.AddRoomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRoomBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoomBtn.ForeColor = System.Drawing.Color.White;
            this.AddRoomBtn.Location = new System.Drawing.Point(15, 16);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.Size = new System.Drawing.Size(148, 55);
            this.AddRoomBtn.TabIndex = 3;
            this.AddRoomBtn.Text = "ADD ROOM";
            this.AddRoomBtn.UseVisualStyleBackColor = false;
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.RoomSearchBtn);
            this.panel24.Controls.Add(this.panel25);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel24.Location = new System.Drawing.Point(418, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(334, 84);
            this.panel24.TabIndex = 11;
            // 
            // panel25
            // 
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Controls.Add(this.RoomSearch);
            this.panel25.Location = new System.Drawing.Point(0, 21);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(272, 50);
            this.panel25.TabIndex = 9;
            // 
            // RoomSearch
            // 
            this.RoomSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomSearch.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomSearch.ForeColor = System.Drawing.Color.Black;
            this.RoomSearch.Location = new System.Drawing.Point(9, 9);
            this.RoomSearch.Name = "RoomSearch";
            this.RoomSearch.Size = new System.Drawing.Size(251, 30);
            this.RoomSearch.TabIndex = 0;
            this.RoomSearch.TextChanged += new System.EventHandler(this.RoomSearch_TextChanged);
            // 
            // AssignedRoomsData
            // 
            this.AssignedRoomsData.AllowUserToAddRows = false;
            this.AssignedRoomsData.AllowUserToDeleteRows = false;
            this.AssignedRoomsData.AllowUserToResizeRows = false;
            this.AssignedRoomsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssignedRoomsData.BackgroundColor = System.Drawing.Color.White;
            this.AssignedRoomsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AssignedRoomsData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AssignedRoomsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AssignedRoomsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignedRoomsData.ContextMenuStrip = this.AssignRoomsControl;
            this.AssignedRoomsData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AssignedRoomsData.DefaultCellStyle = dataGridViewCellStyle4;
            this.AssignedRoomsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignedRoomsData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AssignedRoomsData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AssignedRoomsData.Location = new System.Drawing.Point(15, 15);
            this.AssignedRoomsData.MultiSelect = false;
            this.AssignedRoomsData.Name = "AssignedRoomsData";
            this.AssignedRoomsData.ReadOnly = true;
            this.AssignedRoomsData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AssignedRoomsData.RowHeadersVisible = false;
            this.AssignedRoomsData.RowHeadersWidth = 20;
            this.AssignedRoomsData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AssignedRoomsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssignedRoomsData.ShowEditingIcon = false;
            this.AssignedRoomsData.Size = new System.Drawing.Size(722, 336);
            this.AssignedRoomsData.TabIndex = 0;
            this.AssignedRoomsData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.AssignedRoomsData_CellFormatting);
            this.AssignedRoomsData.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AssignedRoomsData_CellMouseDown);
            this.AssignedRoomsData.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssignedRoomsData_CellMouseEnter);
            // 
            // AssignRoomsControl
            // 
            this.AssignRoomsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAssignRoom,
            this.DeleteAssignRoom});
            this.AssignRoomsControl.Name = "AssignRoomsControl";
            this.AssignRoomsControl.Size = new System.Drawing.Size(189, 64);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.AssignedRoomsData);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 84);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(15);
            this.panel5.Size = new System.Drawing.Size(752, 366);
            this.panel5.TabIndex = 13;
            // 
            // AssignRoom
            // 
            this.AssignRoom.Controls.Add(this.panel5);
            this.AssignRoom.Controls.Add(this.panel3);
            this.AssignRoom.ImageKey = "room.png";
            this.AssignRoom.Location = new System.Drawing.Point(4, 44);
            this.AssignRoom.Name = "AssignRoom";
            this.AssignRoom.Size = new System.Drawing.Size(752, 450);
            this.AssignRoom.TabIndex = 3;
            this.AssignRoom.Text = "Assign Rooms";
            this.AssignRoom.UseVisualStyleBackColor = true;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.AssignRoom);
            this.Tabs.Controls.Add(this.Rooms);
            this.Tabs.Controls.Add(this.Consumables);
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
            this.Tabs.TabIndex = 15;
            // 
            // Consumables
            // 
            this.Consumables.Controls.Add(this.panel6);
            this.Consumables.Controls.Add(this.panel7);
            this.Consumables.Location = new System.Drawing.Point(4, 44);
            this.Consumables.Name = "Consumables";
            this.Consumables.Padding = new System.Windows.Forms.Padding(3);
            this.Consumables.Size = new System.Drawing.Size(752, 450);
            this.Consumables.TabIndex = 5;
            this.Consumables.Text = "Consumables";
            this.Consumables.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ConsumablesData);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 87);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(15);
            this.panel6.Size = new System.Drawing.Size(746, 360);
            this.panel6.TabIndex = 17;
            // 
            // ConsumablesData
            // 
            this.ConsumablesData.AllowUserToAddRows = false;
            this.ConsumablesData.AllowUserToDeleteRows = false;
            this.ConsumablesData.AllowUserToResizeRows = false;
            this.ConsumablesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsumablesData.BackgroundColor = System.Drawing.Color.White;
            this.ConsumablesData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsumablesData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConsumablesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ConsumablesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsumablesData.ContextMenuStrip = this.ConsumablesControls;
            this.ConsumablesData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsumablesData.DefaultCellStyle = dataGridViewCellStyle6;
            this.ConsumablesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsumablesData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ConsumablesData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConsumablesData.Location = new System.Drawing.Point(15, 15);
            this.ConsumablesData.MultiSelect = false;
            this.ConsumablesData.Name = "ConsumablesData";
            this.ConsumablesData.ReadOnly = true;
            this.ConsumablesData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ConsumablesData.RowHeadersVisible = false;
            this.ConsumablesData.RowHeadersWidth = 20;
            this.ConsumablesData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsumablesData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsumablesData.ShowEditingIcon = false;
            this.ConsumablesData.Size = new System.Drawing.Size(716, 330);
            this.ConsumablesData.TabIndex = 0;
            this.ConsumablesData.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsumablesData_CellMouseEnter);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.NewItem);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(746, 84);
            this.panel7.TabIndex = 16;
            // 
            // NewItem
            // 
            this.NewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.NewItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewItem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewItem.ForeColor = System.Drawing.Color.White;
            this.NewItem.Location = new System.Drawing.Point(15, 16);
            this.NewItem.Name = "NewItem";
            this.NewItem.Size = new System.Drawing.Size(148, 55);
            this.NewItem.TabIndex = 3;
            this.NewItem.Text = "NEW ITEM";
            this.NewItem.UseVisualStyleBackColor = false;
            this.NewItem.Click += new System.EventHandler(this.NewItem_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.SearchItemBtn);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(412, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(334, 84);
            this.panel8.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.SearchItem);
            this.panel9.Location = new System.Drawing.Point(0, 21);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(272, 50);
            this.panel9.TabIndex = 9;
            // 
            // SearchItem
            // 
            this.SearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchItem.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchItem.ForeColor = System.Drawing.Color.Black;
            this.SearchItem.Location = new System.Drawing.Point(9, 9);
            this.SearchItem.Name = "SearchItem";
            this.SearchItem.Size = new System.Drawing.Size(251, 30);
            this.SearchItem.TabIndex = 0;
            this.SearchItem.TextChanged += new System.EventHandler(this.SearchItem_TextChanged);
            // 
            // NavBarImages
            // 
            this.NavBarImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NavBarImages.ImageStream")));
            this.NavBarImages.TransparentColor = System.Drawing.Color.Transparent;
            this.NavBarImages.Images.SetKeyName(0, "room.png");
            this.NavBarImages.Images.SetKeyName(1, "rooms.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resources Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Faculty and Allocate Rooms and Manage Consumables";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 117);
            this.panel1.TabIndex = 14;
            // 
            // ConsumablesControls
            // 
            this.ConsumablesControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditItem,
            this.DeleteItem});
            this.ConsumablesControls.Name = "ConsumablesControls";
            this.ConsumablesControls.Size = new System.Drawing.Size(143, 64);
            // 
            // EditAssignRoom
            // 
            this.EditAssignRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.EditAssignRoom.Image = global::DBS25P023.Properties.Resources.edit;
            this.EditAssignRoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditAssignRoom.Name = "EditAssignRoom";
            this.EditAssignRoom.Size = new System.Drawing.Size(188, 30);
            this.EditAssignRoom.Text = "Edit Assign Room";
            this.EditAssignRoom.Click += new System.EventHandler(this.EditAssignRoom_Click);
            // 
            // DeleteAssignRoom
            // 
            this.DeleteAssignRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.DeleteAssignRoom.Image = global::DBS25P023.Properties.Resources.del;
            this.DeleteAssignRoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteAssignRoom.Name = "DeleteAssignRoom";
            this.DeleteAssignRoom.Size = new System.Drawing.Size(188, 30);
            this.DeleteAssignRoom.Text = "Delete Assign Room";
            this.DeleteAssignRoom.Click += new System.EventHandler(this.DeleteAssignRoom_Click);
            // 
            // AssignedRoomSearchBtn
            // 
            this.AssignedRoomSearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.AssignedRoomSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AssignedRoomSearchBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssignedRoomSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssignedRoomSearchBtn.ErrorImage = global::DBS25P023.Properties.Resources.eye;
            this.AssignedRoomSearchBtn.Image = global::DBS25P023.Properties.Resources.search;
            this.AssignedRoomSearchBtn.InitialImage = global::DBS25P023.Properties.Resources.eye;
            this.AssignedRoomSearchBtn.Location = new System.Drawing.Point(267, 21);
            this.AssignedRoomSearchBtn.Name = "AssignedRoomSearchBtn";
            this.AssignedRoomSearchBtn.Padding = new System.Windows.Forms.Padding(10);
            this.AssignedRoomSearchBtn.Size = new System.Drawing.Size(50, 50);
            this.AssignedRoomSearchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AssignedRoomSearchBtn.TabIndex = 8;
            this.AssignedRoomSearchBtn.TabStop = false;
            this.AssignedRoomSearchBtn.Click += new System.EventHandler(this.AssignedRoomSearchBtn_Click);
            // 
            // EditRoom
            // 
            this.EditRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.EditRoom.Image = global::DBS25P023.Properties.Resources.edit;
            this.EditRoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditRoom.Name = "EditRoom";
            this.EditRoom.Size = new System.Drawing.Size(150, 30);
            this.EditRoom.Text = "Edit Room";
            this.EditRoom.Click += new System.EventHandler(this.EditRoom_Click);
            // 
            // DeleteRoom
            // 
            this.DeleteRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.DeleteRoom.Image = global::DBS25P023.Properties.Resources.del;
            this.DeleteRoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteRoom.Name = "DeleteRoom";
            this.DeleteRoom.Size = new System.Drawing.Size(150, 30);
            this.DeleteRoom.Text = "Delete Room";
            this.DeleteRoom.Click += new System.EventHandler(this.DeleteRoom_Click);
            // 
            // RoomSearchBtn
            // 
            this.RoomSearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.RoomSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RoomSearchBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomSearchBtn.ErrorImage = global::DBS25P023.Properties.Resources.eye;
            this.RoomSearchBtn.Image = global::DBS25P023.Properties.Resources.search;
            this.RoomSearchBtn.InitialImage = global::DBS25P023.Properties.Resources.eye;
            this.RoomSearchBtn.Location = new System.Drawing.Point(267, 21);
            this.RoomSearchBtn.Name = "RoomSearchBtn";
            this.RoomSearchBtn.Padding = new System.Windows.Forms.Padding(10);
            this.RoomSearchBtn.Size = new System.Drawing.Size(50, 50);
            this.RoomSearchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoomSearchBtn.TabIndex = 8;
            this.RoomSearchBtn.TabStop = false;
            this.RoomSearchBtn.Click += new System.EventHandler(this.RoomSearchBtn_Click);
            // 
            // SearchItemBtn
            // 
            this.SearchItemBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchItemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchItemBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchItemBtn.ErrorImage = global::DBS25P023.Properties.Resources.eye;
            this.SearchItemBtn.Image = global::DBS25P023.Properties.Resources.search;
            this.SearchItemBtn.InitialImage = global::DBS25P023.Properties.Resources.eye;
            this.SearchItemBtn.Location = new System.Drawing.Point(267, 21);
            this.SearchItemBtn.Name = "SearchItemBtn";
            this.SearchItemBtn.Padding = new System.Windows.Forms.Padding(10);
            this.SearchItemBtn.Size = new System.Drawing.Size(50, 50);
            this.SearchItemBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchItemBtn.TabIndex = 8;
            this.SearchItemBtn.TabStop = false;
            this.SearchItemBtn.Click += new System.EventHandler(this.SearchItemBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.AutoSize = true;
            this.RefreshBtn.BackColor = System.Drawing.Color.White;
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.Image = global::DBS25P023.Properties.Resources.reset;
            this.RefreshBtn.Location = new System.Drawing.Point(705, 15);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(40, 40);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // EditItem
            // 
            this.EditItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.EditItem.Image = global::DBS25P023.Properties.Resources.edit;
            this.EditItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(142, 30);
            this.EditItem.Text = "Edit Item";
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(132)))));
            this.DeleteItem.Image = global::DBS25P023.Properties.Resources.del;
            this.DeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(142, 30);
            this.DeleteItem.Text = "Delete Item";
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // ResourceAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.panel1);
            this.Name = "ResourceAllocation";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(780, 635);
            this.Load += new System.EventHandler(this.ResourceAllocation_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Rooms.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomData)).EndInit();
            this.RoomControls.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedRoomsData)).EndInit();
            this.AssignRoomsControl.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.AssignRoom.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.Consumables.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsumablesData)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ConsumablesControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AssignedRoomSearchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomSearchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchItemBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox AssignedRoomSearch;
        private System.Windows.Forms.PictureBox AssignedRoomSearchBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AssignRoomBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage Rooms;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.DataGridView RoomData;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button AddRoomBtn;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.PictureBox RoomSearchBtn;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox RoomSearch;
        private System.Windows.Forms.DataGridView AssignedRoomsData;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabPage AssignRoom;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList NavBarImages;
        private System.Windows.Forms.ContextMenuStrip RoomControls;
        private System.Windows.Forms.ToolStripMenuItem EditRoom;
        private System.Windows.Forms.ToolStripMenuItem DeleteRoom;
        private System.Windows.Forms.ContextMenuStrip AssignRoomsControl;
        private System.Windows.Forms.ToolStripMenuItem EditAssignRoom;
        private System.Windows.Forms.ToolStripMenuItem DeleteAssignRoom;
        private System.Windows.Forms.TabPage Consumables;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView ConsumablesData;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button NewItem;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox SearchItemBtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox SearchItem;
        private System.Windows.Forms.ContextMenuStrip ConsumablesControls;
        private System.Windows.Forms.ToolStripMenuItem EditItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteItem;
    }
}
