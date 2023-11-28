using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Clothing_Store
{
    public partial class frmLogin : Form
    {
        public frmLogin()
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
            this.Close();
        }  // close button end



            private void ckPassword_CheckedChanged(object sender, EventArgs e) // check box show begin
           {
                    if (ckPassword.Checked == true)
                    {
                        txtPassword.UseSystemPasswordChar = false;
                    }
                    else
                    {
                        txtPassword.UseSystemPasswordChar = true;
                    }
            } // check box show end 

        private void btnLogin_Click(object sender, EventArgs e) // log in button begin
        {
            FrmLoading ffl = new FrmLoading();
            ffl.ShowDialog();


        } // lig in button end


    }// class end
}//  name space end 
