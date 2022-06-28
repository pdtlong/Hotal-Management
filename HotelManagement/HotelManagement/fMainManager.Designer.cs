namespace HotelManagement
{
    partial class fMainManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployeeList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEquipmentList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOutputExData = new System.Windows.Forms.ToolStripMenuItem();
            this.lọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReady = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDone = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFix = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClean = new System.Windows.Forms.ToolStripMenuItem();
            this.chPassToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.lọcToolStripMenuItem,
            this.chPassToolStripMenu,
            this.toolStripMenuLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateStaff,
            this.tsmiEmployeeList,
            this.tsmiEquipmentList,
            this.tsmiOutputExData});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // tsmiCreateStaff
            // 
            this.tsmiCreateStaff.Name = "tsmiCreateStaff";
            this.tsmiCreateStaff.Size = new System.Drawing.Size(310, 26);
            this.tsmiCreateStaff.Text = "Tạo tài khoản cho nhân viên";
            this.tsmiCreateStaff.Click += new System.EventHandler(this.tsmiCreateStaff_Click);
            // 
            // tsmiEmployeeList
            // 
            this.tsmiEmployeeList.Name = "tsmiEmployeeList";
            this.tsmiEmployeeList.Size = new System.Drawing.Size(310, 26);
            this.tsmiEmployeeList.Text = "Danh sách nhân viên";
            this.tsmiEmployeeList.Click += new System.EventHandler(this.tsmiEmployeeList_Click);
            // 
            // tsmiEquipmentList
            // 
            this.tsmiEquipmentList.Name = "tsmiEquipmentList";
            this.tsmiEquipmentList.Size = new System.Drawing.Size(310, 26);
            this.tsmiEquipmentList.Text = "Danh sách trang thiết bị";
            this.tsmiEquipmentList.Click += new System.EventHandler(this.tsmiEquipmentList_Click);
            // 
            // tsmiOutputExData
            // 
            this.tsmiOutputExData.Name = "tsmiOutputExData";
            this.tsmiOutputExData.Size = new System.Drawing.Size(310, 26);
            this.tsmiOutputExData.Text = "Xuất file Excel thống kê doanh thu";
            // 
            // lọcToolStripMenuItem
            // 
            this.lọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReady,
            this.tsmiDone,
            this.tsmiBook,
            this.tsmiFix,
            this.tsmiClean});
            this.lọcToolStripMenuItem.Name = "lọcToolStripMenuItem";
            this.lọcToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.lọcToolStripMenuItem.Text = "Sắp xếp";
            // 
            // tsmiReady
            // 
            this.tsmiReady.Name = "tsmiReady";
            this.tsmiReady.Size = new System.Drawing.Size(216, 26);
            this.tsmiReady.Text = "Sẵn sàng";
            // 
            // tsmiDone
            // 
            this.tsmiDone.Name = "tsmiDone";
            this.tsmiDone.Size = new System.Drawing.Size(216, 26);
            this.tsmiDone.Text = "Có khách";
            // 
            // tsmiBook
            // 
            this.tsmiBook.Name = "tsmiBook";
            this.tsmiBook.Size = new System.Drawing.Size(216, 26);
            this.tsmiBook.Text = "Đã đặt trước";
            // 
            // tsmiFix
            // 
            this.tsmiFix.Name = "tsmiFix";
            this.tsmiFix.Size = new System.Drawing.Size(216, 26);
            this.tsmiFix.Text = "Đang sửa chữa";
            // 
            // tsmiClean
            // 
            this.tsmiClean.Name = "tsmiClean";
            this.tsmiClean.Size = new System.Drawing.Size(216, 26);
            this.tsmiClean.Text = "Đang dọn phòng";
            // 
            // chPassToolStripMenu
            // 
            this.chPassToolStripMenu.Name = "chPassToolStripMenu";
            this.chPassToolStripMenu.Size = new System.Drawing.Size(110, 24);
            this.chPassToolStripMenu.Text = "Đổi mật khẩu";
            this.chPassToolStripMenu.Click += new System.EventHandler(this.chPassToolStripMenu_Click);
            // 
            // toolStripMenuLogout
            // 
            this.toolStripMenuLogout.Name = "toolStripMenuLogout";
            this.toolStripMenuLogout.Size = new System.Drawing.Size(89, 24);
            this.toolStripMenuLogout.Text = "Đăng xuất";
            this.toolStripMenuLogout.Click += new System.EventHandler(this.toolStripMenuLogout_Click);
            // 
            // flowLayoutPanelRoom
            // 
            this.flowLayoutPanelRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelRoom.Location = new System.Drawing.Point(12, 91);
            this.flowLayoutPanelRoom.Name = "flowLayoutPanelRoom";
            this.flowLayoutPanelRoom.Size = new System.Drawing.Size(1055, 527);
            this.flowLayoutPanelRoom.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "fPayment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "fRoomManager";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fMainManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 630);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanelRoom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMainManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMainManager_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiReady;
        private System.Windows.Forms.ToolStripMenuItem tsmiDone;
        private System.Windows.Forms.ToolStripMenuItem tsmiBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiFix;
        private System.Windows.Forms.ToolStripMenuItem tsmiClean;
        private System.Windows.Forms.ToolStripMenuItem chPassToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployeeList;
        private System.Windows.Forms.ToolStripMenuItem tsmiEquipmentList;
        private System.Windows.Forms.ToolStripMenuItem tsmiOutputExData;
    }
}