using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class fMainManager : Form
    {
        public fMainManager()
        {
            InitializeComponent();
        }

        private void toolStripMenuLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fMainManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;   
            } 
        }

        private void chPassToolStripMenu_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword();
            f.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fRoomManager f = new fRoomManager();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fPayment f = new fPayment();
            f.Show();
        }

        private void tsmiEquipmentList_Click(object sender, EventArgs e)
        {
            fEquipmentList f = new fEquipmentList();
            f.Show();
        }

        private void tsmiCreateStaff_Click(object sender, EventArgs e)
        {
            fCreateAccount f = new fCreateAccount();
            f.ShowDialog();
        }

        private void tsmiEmployeeList_Click(object sender, EventArgs e)
        {
            fEmployeeList f = new fEmployeeList();
            f.Show();
        }
    }
}
