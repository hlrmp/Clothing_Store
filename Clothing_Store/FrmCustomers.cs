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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        FrmAddCustomer fadd = new FrmAddCustomer();
        private void btnAdd_Click(object sender, EventArgs e)  // add buton begin
        {
            fadd.ShowDialog();
        } //add button end

    } // class end
} // namespace end
