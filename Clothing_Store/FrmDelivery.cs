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
    public partial class FrmDelivery : Form
    {
        public FrmDelivery()
        {
            InitializeComponent();
        }

        FrmAddDelivery fadd = new FrmAddDelivery();
        private void btnAdd_Click(object sender, EventArgs e) // button add begin
        {
            fadd.ShowDialog();
        } // buttton add end


    } // class end
}  // name space end
