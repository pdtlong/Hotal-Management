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
    public partial class fChangePassword : Form
    {
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void btnExitPass_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
