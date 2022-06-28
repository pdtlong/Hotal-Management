using HotelManagement.DAO;
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
    public partial class fEquipmentList : Form
    {
        public fEquipmentList()
        {
            InitializeComponent();
            LoadEquipmentList();
        }

        void LoadEquipmentList()
        {
            string query = "SELECT * FROM Item";
            DataProvider provider = new DataProvider();
            dtgvEquipment.DataSource = provider.ExecuteQuery(query);
        }
    }
}
