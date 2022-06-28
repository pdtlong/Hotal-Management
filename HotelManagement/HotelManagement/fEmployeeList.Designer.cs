namespace HotelManagement
{
    partial class fEmployeeList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.idStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStaff,
            this.nameStaff,
            this.birthday,
            this.sexStaff,
            this.locationStaff,
            this.phoneStaff,
            this.email,
            this.salary,
            this.position});
            this.dtgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.RowTemplate.Height = 24;
            this.dtgvEmployee.Size = new System.Drawing.Size(1237, 711);
            this.dtgvEmployee.TabIndex = 0;
            // 
            // idStaff
            // 
            this.idStaff.DataPropertyName = "idStaff";
            this.idStaff.HeaderText = "Mã nhân viên";
            this.idStaff.Name = "idStaff";
            // 
            // nameStaff
            // 
            this.nameStaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameStaff.DataPropertyName = "nameStaff";
            this.nameStaff.HeaderText = "Tên nhân viên";
            this.nameStaff.Name = "nameStaff";
            this.nameStaff.Width = 128;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.birthday.DefaultCellStyle = dataGridViewCellStyle1;
            this.birthday.HeaderText = "Ngày sinh";
            this.birthday.Name = "birthday";
            // 
            // sexStaff
            // 
            this.sexStaff.DataPropertyName = "sexStaff";
            this.sexStaff.HeaderText = "Giới tính";
            this.sexStaff.Name = "sexStaff";
            // 
            // locationStaff
            // 
            this.locationStaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.locationStaff.DataPropertyName = "locationStaff";
            this.locationStaff.HeaderText = "Địa chỉ";
            this.locationStaff.Name = "locationStaff";
            this.locationStaff.Width = 80;
            // 
            // phoneStaff
            // 
            this.phoneStaff.DataPropertyName = "phoneStaff";
            this.phoneStaff.HeaderText = "Số điện thoại";
            this.phoneStaff.Name = "phoneStaff";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 71;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Lương";
            this.salary.Name = "salary";
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "Chức vụ";
            this.position.Name = "position";
            // 
            // fEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 734);
            this.Controls.Add(this.dtgvEmployee);
            this.Name = "fEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
    }
}