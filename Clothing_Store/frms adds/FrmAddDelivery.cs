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
    public partial class FrmAddDelivery : Form
    {
        public FrmAddDelivery()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) // add button begin
        {

        } //  add button end

        protected override void OnPaint(PaintEventArgs e)    // border color begin
        {
            //  base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid);
        }  // border color end

        private void btnCancel_Click(object sender, EventArgs e) // cancel button begin
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to Cancel? ", "Close", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();

            }
            else
            {

            }

        } // cancel button end



    } // class end
} // namespace  end
