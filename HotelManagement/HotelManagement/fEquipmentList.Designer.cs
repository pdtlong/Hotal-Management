namespace HotelManagement
{
    partial class fEquipmentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvEquipment = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameIt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceIt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvEquipment
            // 
            this.dtgvEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEquipment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.nameIt,
            this.PriceIt});
            this.dtgvEquipment.Location = new System.Drawing.Point(12, 12);
            this.dtgvEquipment.Name = "dtgvEquipment";
            this.dtgvEquipment.RowTemplate.Height = 24;
            this.dtgvEquipment.Size = new System.Drawing.Size(443, 713);
            this.dtgvEquipment.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "idIt";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle1;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // nameIt
            // 
            this.nameIt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameIt.DataPropertyName = "nameIt";
            this.nameIt.HeaderText = "Tên thiết bị";
            this.nameIt.Name = "nameIt";
            this.nameIt.Width = 108;
            // 
            // PriceIt
            // 
            this.PriceIt.DataPropertyName = "PriceIt";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PriceIt.DefaultCellStyle = dataGridViewCellStyle2;
            this.PriceIt.HeaderText = "Giá";
            this.PriceIt.Name = "PriceIt";
            // 
            // fEquipmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 737);
            this.Controls.Add(this.dtgvEquipment);
            this.Name = "fEquipmentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Thiết Bị Khách Sạn";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameIt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceIt;
    }
}