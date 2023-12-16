using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clothing_Store
{
    public partial class FrmAddOrders : Form
    {
        public FrmAddOrders()
        {
            InitializeComponent();
            type();
            category();
            size();
            color();
          
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

       

        private void Cancel_Click(object sender, EventArgs e)  //  cancel button begin
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to Cancel? ", "Close", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();

                txtCustomerName.Clear();
                cbCategory.ResetText();
                cbItem.ResetText();
                numericQuantity.ResetText();
                cbCategory.ResetText();

            }
            else
            {

            }

        } //  cancel button end





        public void size() // size method begin
        {
            ArrayList arr = new ArrayList();
            arr.Add("XS");
            arr.Add("S");
            arr.Add("M");
            arr.Add("L");
            arr.Add("XL");
            arr.Add("2XL");
            arr.Add("3XL");

            foreach (string s in arr)
            {
                cbSize.Items.Add(s);
            }

        } // size method end
        public void category() // category method begin
        {
            ArrayList arr = new ArrayList();
            arr.Add("Mens");
            arr.Add("Womens");
            arr.Add("Uniex");
            arr.Add("Kids");

            foreach (string c in arr)
            {
                cbCategory.Items.Add(c);
            }

        } // category method end
        public void color() // color method begin
        {
            ArrayList arr = new ArrayList();
            arr.Add("White");
            arr.Add("Black");
            arr.Add("Red");
            arr.Add("Blue");
            arr.Add("Green");
            arr.Add("Yellow");
            arr.Add("Orange");
            arr.Add("Pink");
            arr.Add("Brown");
            arr.Add("Violet");

            foreach (string c in arr)
            {
               cbColor.Items.Add(c);
            }

        } // color method end
        public void type() // type method begin
        {
            ArrayList arr = new ArrayList();
            arr.Add("T-Shirt");
            arr.Add("Polo");
            arr.Add("Polo-Shirt");
            arr.Add("Pants");
            arr.Add("Blouse");
            arr.Add("Shorts");
            arr.Add("Collection");

            foreach (string c in arr)
            {
                cbItem.Items.Add(c);
            }

        } // type method end

    
    } // calss end
} // namespace end
