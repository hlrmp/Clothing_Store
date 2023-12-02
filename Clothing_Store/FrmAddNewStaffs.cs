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
    public partial class FrmAddNewStaffs : Form
    {
        public FrmAddNewStaffs()
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

        private void FrmAddNewStaffs_Load(object sender, EventArgs e)
        {

        }

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
                txtAddress.Clear();
            }
            else
            {

            }
        } // cancel button end

        // class instance
        userClass uc = new userClass();
        FrmAddUser addu = new FrmAddUser();
        private void btnAdd_Click(object sender, EventArgs e) // add button begin 
        {
            uc.StaffFirstName = txtFname.Text;
            uc.StaffLastName = txtLname.Text;
            uc.staffEmail = txtEmail.Text;
            uc.StaffAddress = txtAddress.Text;
            uc.StaffConntacNo = txtContactNo.Text;


            DialogResult dialogResult = MessageBox.Show("Doyou wnat to Add this New Staff", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) // outer if begin
            {        

                        DialogResult dialogResult1 = MessageBox.Show("Doyou wnat to make an account for this Staff  ", "Confirm", MessageBoxButtons.YesNo);

                        if (dialogResult1 == DialogResult.Yes) // inner if begin
                        {
                                 addu.ShowDialog();
                                 this.Hide();

                        } // inner if end
                        else // inner else begin

                        {
                                 MessageBox.Show("Staff sucessfully added", "Confirmation", MessageBoxButtons.OK);
                                 this.Hide();

                        } // inner else

            }   // outer iff end
            else  // outer else begin
            {

            } // outer else end


        } // add button end



    } // class end
} // namespace end




