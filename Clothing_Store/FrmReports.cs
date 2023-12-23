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
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {

        }

        private void btnWeekly_Click(object sender, EventArgs e)  // btn weekly Begin
        {

        } // btn weekly end

        private void FrmReports_Load(object sender, EventArgs e) // frm load begin
        {
            this.txtSearch.AutoSize = false;
            this.txtSearch.Size = new System.Drawing.Size(243, 21);

        } // frm load end
    }
}
