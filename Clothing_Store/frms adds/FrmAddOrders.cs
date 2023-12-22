using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clothing_Store.classes;
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
            cname();
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

                clear();



            }
            else
            {

            }

        } //  cancel button end




        public void clear()
        {
            cbCustomerName.ResetText();
            cbCategory.ResetText();
            cbItem.ResetText();
            txtQuantity.Clear();
            cbCategory.ResetText();
        }
        public void size() // size method begin
        {
            ArrayList arr = new ArrayList();
            arr.Add("XSmall");
            arr.Add("Small");
            arr.Add("Medium");
            arr.Add("Large");
            arr.Add("XLarge");
            arr.Add("2XLarge");
            arr.Add("3XLarge");

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
            arr.Add("Tshirt");
            arr.Add("Polo");
            arr.Add("Polo-Shirt");
            arr.Add("Pants");
            arr.Add("Blouse");
            arr.Add("Shorts");
            arr.Add("Collection");

            foreach (string c in arr)
            {
                cbType.Items.Add(c);
            }

        } // type method end

        private void cbColor_SelectedValueChanged(object sender, EventArgs e) // color change begin
        {
            if (cbColor.Text == "Black")
            {
                cbColor.BackColor = Color.Black;
                cbColor.ForeColor = Color.White;
            }
            else if (cbColor.Text == "Brown")
            {
                cbColor.BackColor = Color.Brown;
                cbColor.ForeColor = Color.White;
            }
            else if (cbColor.Text == "Green")
            {
                cbColor.BackColor = Color.Green;
                cbColor.ForeColor = Color.White;

            }
            else if (cbColor.Text == "Blue")
            {
                cbColor.BackColor = Color.Blue;
                cbColor.ForeColor = Color.White;
            }
            else if (cbColor.Text == "Red")
            {
                cbColor.BackColor = Color.Red;
                cbColor.ForeColor = Color.White;

            }
            else if (cbColor.Text == "White")
            {
                cbColor.BackColor = Color.White;
                cbColor.ForeColor = Color.Black;
            }
            else if (cbColor.Text == "Yellow")
            {
                cbColor.BackColor = Color.Yellow;
                cbColor.ForeColor = Color.Black;

            }
            else if (cbColor.Text == "Orange")
            {
                cbColor.BackColor = Color.Orange;
                cbColor.ForeColor = Color.White;

            }
            else if (cbColor.Text == "Pink")
            {
                cbColor.BackColor = Color.Pink;
                cbColor.ForeColor = Color.Black;
            }
            else if (cbColor.Text == "Violet")
            {
                cbColor.BackColor = Color.Violet;
                cbColor.ForeColor = Color.White;

            }
        } // color change end

        ordersClass oc = new ordersClass();

        class nullExceptiom : Exception
        {
            public nullExceptiom(string str) : base(str) { }
        }
        class StringFormatException : Exception
        {
            public StringFormatException(string str) : base(str) { }
        }
        class NumberFormatException : Exception
        {
            public NumberFormatException(string num) : base(num) { }
        }

        public string quan(string quantity)
        {

            if (Regex.IsMatch(quantity, regexClass.Intg))
            {
                oc.Quantity = quantity;

            }
            else
            {
                throw new NumberFormatException("put Quantity correctly");
            }
            return oc.Quantity;
        }
        public void add() // add begin
        {
            try
            {
                oc.Quantity = quan(txtQuantity.Text);
                oc.Size = cbSize.Text;
                oc.Type = cbType.Text;
                oc.Category = cbCategory.Text;
                oc.Color = cbColor.Text;
                oc.Name = cbCustomerName.Text;
                oc.Item = cbItem.Text;

                if (txtQuantity.Text == "" || cbSize.Text == "" || cbType.Text == ""  || cbCategory.Text == "" || cbColor.Text == ""
                    || cbCustomerName.Text == "" || cbItem.Text == "")
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {

                }


            }           
            catch (NumberFormatException ne)
            {
                MessageBox.Show(ne.Message);
            }
            catch (nullExceptiom ne)
            {
                MessageBox.Show(ne.Message);
            }

        } // add end

        int productId;
        public void pId()
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string ids = "select * from Products where Status = 1 and Product_Name = '"+oc.Name+"' and Category = '"+oc.Category+"' and Size = '"+oc.Size+"' and Type = '"+oc.Type+"' and Color = '"+oc.Color+"' ";
  
            con.Open();
            SqlCommand command = new SqlCommand(ids, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                productId = int.Parse(reader[0].ToString());
            }
            con.Close();
        }
        public void cname() // cname beginn
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string ids = "select concat(First_Name ,' ', Last_Name ) as Name from Customers";
            SqlDataAdapter adapt = new SqlDataAdapter(ids, con);

            DataTable dataTable = new DataTable();
            BindingSource bindingSource = new BindingSource();
            dataTable.Clear();
            adapt.Fill(dataTable);
            bindingSource.DataSource = dataTable;

            cbCustomerName.DataSource = dataTable;
            cbCustomerName.DisplayMember = "Name";;
            con.Close();

        } // cname end


        string customerId;
        public void uid()  //  uid begin
        {
            customerClass cs = new customerClass();
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string n = "SELECT Customer_Id FROM Customers  WHERE CONCAT(TRIM(Customers.First_Name), ' ', TRIM(Customers.Last_Name)) LIKE '" + cbCustomerName.Text + "' and Status = 1";

            con.Open();
            SqlCommand command;
            command = new SqlCommand(n, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                customerId = reader[0].ToString();
            }

            con.Close();

        } // uid end

        private void btnAdd_Click(object sender, EventArgs e) // btn add begin
        {
            uid();
            MessageBox.Show(customerId);
        } // btn add end

    } // calss end
} // namespace end
