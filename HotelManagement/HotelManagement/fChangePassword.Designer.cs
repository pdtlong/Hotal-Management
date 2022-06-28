namespace HotelManagement
{
    partial class fChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCnfPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExitPass = new System.Windows.Forms.Button();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPassChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnExitPass);
            this.panel1.Controls.Add(this.btnUpdatePass);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 261);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbCnfPass);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 58);
            this.panel4.TabIndex = 3;
            // 
            // tbCnfPass
            // 
            this.tbCnfPass.Location = new System.Drawing.Point(198, 19);
            this.tbCnfPass.Name = "tbCnfPass";
            this.tbCnfPass.Size = new System.Drawing.Size(263, 22);
            this.tbCnfPass.TabIndex = 1;
            this.tbCnfPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại:";
            // 
            // btnExitPass
            // 
            this.btnExitPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPass.Location = new System.Drawing.Point(366, 213);
            this.btnExitPass.Name = "btnExitPass";
            this.btnExitPass.Size = new System.Drawing.Size(98, 32);
            this.btnExitPass.TabIndex = 4;
            this.btnExitPass.Text = "Thoát";
            this.btnExitPass.UseVisualStyleBackColor = true;
            this.btnExitPass.Click += new System.EventHandler(this.btnExitPass_Click);
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePass.Location = new System.Drawing.Point(232, 213);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(117, 32);
            this.btnUpdatePass.TabIndex = 3;
            this.btnUpdatePass.Text = "Cập nhật";
            this.btnUpdatePass.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbPassChange);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 58);
            this.panel3.TabIndex = 2;
            // 
            // tbPassChange
            // 
            this.tbPassChange.Location = new System.Drawing.Point(198, 19);
            this.tbPassChange.Name = "tbPassChange";
            this.tbPassChange.Size = new System.Drawing.Size(263, 22);
            this.tbPassChange.TabIndex = 1;
            this.tbPassChange.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbOldPass);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 58);
            this.panel2.TabIndex = 1;
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(198, 19);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(263, 22);
            this.tbOldPass.TabIndex = 1;
            this.tbOldPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại:";
            // 
            // fChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 284);
            this.Controls.Add(this.panel1);
            this.Name = "fChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExitPass;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPassChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbCnfPass;
        private System.Windows.Forms.Label label3;
    }
}