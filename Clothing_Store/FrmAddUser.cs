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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
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

        private void Cancel_Click(object sender, EventArgs e)  // cancel button begin
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to Cancel? ", "Close", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();

                txtFname.Clear();
                txtMname.Clear();
                txtLname.Clear();
                txtAddress.Clear();
                txtContactNo.Clear();
                txtUserName.Clear();
                txtUserPass.Clear();
                txtConfirmPass.Clear();

            }
            else
            {

            }
        } // cancel button end

        private void btnAdd_Click(object sender, EventArgs e)  // add button begin
        {
            DialogResult dialogResult = MessageBox.Show("Doyou wnat to Add this to the Users ", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("succesfully added", "Confirmation", MessageBoxButtons.OK);
            }
            else
            {

            }

        } //  add button end

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {

            if (ckShowPass.Checked == true)
            {
                txtUserPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtUserPass.UseSystemPasswordChar = true;
            }
        }
    }// class end
} // name space end
