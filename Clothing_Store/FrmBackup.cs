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
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)    // border color begin
        {
            //  base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid);
        }  // border color end

        private void btnClose_Click(object sender, EventArgs e)  // close button begin
        {          
            this.Hide();
            
            
        } // close button end

        private void btnBackup_Click(object sender, EventArgs e) // backup button begin
        {

        } // back up button end


    } // class end
} // name space end
