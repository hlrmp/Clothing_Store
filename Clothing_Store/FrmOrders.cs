using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Store
{
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }
        FrmAddOrders fao = new FrmAddOrders();
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            fao.Show();
        }

       
    }
}
