using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Clothing_Store
{
    public partial class frmAddStocks : Form
    {
        public frmAddStocks()
        {
            InitializeComponent();
            type();
            color();
            category();
            size();
            SupplierName();
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
        private void btnCancel_Click(object sender, EventArgs e) // cancel btn begin
        {
            this.Hide();
            clear();

        }// cancel btn end


        private void cbColor_SelectedValueChanged(object sender, EventArgs e)  //color change begin
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
        itemsClass it = new itemsClass();
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

        public string ItemName(string itemName)
        {
            if (Regex.IsMatch(itemName, regexClass.letters))
            {

                itemName = Char.ToUpper(itemName[0]) + itemName.Substring(1);

                it.Name = itemName;
            }

            else
            {
                throw new StringFormatException("please enter the Item Name Correctly");
            }

            return it.Name;
        }
       
        public string price(string price)
        {

            if (Regex.IsMatch(price, regexClass.doub))
            {
                it.price = price;

            }
            else
            {
                throw new NumberFormatException("put Price correctly");
            }
            return it.price;
        }
        public string quan(string quantity)
        {

            if (Regex.IsMatch(quantity, regexClass.Intg))
            {
                it.quantity = quantity;

            }
            else
            {
                throw new NumberFormatException("put Quantity correctly");
            }
            return it.quantity;
        }
        private void btnAdd_Click(object sender, EventArgs e) // add btn begin
        {
           
           // comfirmation();
            add();



        } // add btn end 

        private void btnClear_Click(object sender, EventArgs e)  //clear btn begin
        {
            clear();

        } //  clear btn end
         
        public void clear()
        {
            cbItemCode.ResetText();
            cbCategory.Refresh();
            cbColor.Refresh();
            cbType.Refresh();
            cbSize.Refresh();
            txtItemName.Clear();
            txtPrice.Clear();
            txtQuantity.ResetText();
            cbSupplier.ResetText();
        }

        string condition;
      
        public void comfirmation()  // confirmaion begin
        {

            customerClass cs = new customerClass();
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string sj = "select Product_Id ,Product_Name , Category , Type , Size, Price , Color , Status " +
                        "from Products where Product_id = "+it.Code+ " and Product_Name = '"+it.Name+ "'" +
                        " and Category = '"+it.category+"' and Type = '"+it.type+"' and Size = '"+it.size+"' and Price = '"+it.price+"' " +
                        "and Color = '"+it.Color+"' and Status = 1 ";

            con.Open();
            SqlCommand command;
            command = new SqlCommand(sj, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Exist");
                condition = "same";
            }
            else
            {
                MessageBox.Show("dont");
                condition = "notsame";
            }

            con.Close();
        } // confirmation end

        public void add()  // add Stocks 
        {
            SqlConnection cnn = new SqlConnection(ConnectionClass.conn);


            try
            {
                if (txtItemName.Text == "" || txtPrice.Text == "" || txtPrice.Text == ""  || 
                    cbItemCode.Text == "" || cbCategory.Text == "" || cbColor.Text == "" ||
                    cbSize.Text == "" || cbType.Text ==  "")
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {
                    it.Code = cbCategory.Text;
                    it.Name = ItemName(txtItemName.Text);
                    it.quantity = quan(txtQuantity.Text);
                    it.price = price(txtPrice.Text);
                    it.size = cbSize.Text;
                    it.type = cbType.Text;
                    it.category = cbCategory.Text;
                    it.Color = cbColor.Text;
                    it.Supplier = cbSupplier.Text;

                    if (condition == "same")
                        {

                           
                            string quer1 = " ";
                            SqlCommand command = new SqlCommand(quer1, cnn);


                            command.Parameters.AddWithValue("@Status", "1");
                            cnn.Open();
                            command.ExecuteNonQuery();
                            cnn.Close();

                            // activity logs begin

                            //     string desc = "Stocks updated";
                            //     ConnectionClass.activity(frmLogin.userId, desc);

                            // activity logs end

                            this.Hide();


                                clear();

                        }
                        else if (condition == "notsame")
                        {
                           
                            string quer1 = " ";
                            SqlCommand command = new SqlCommand(quer1, cnn);


                            command.Parameters.AddWithValue("@Status", "1");
                            cnn.Open();
                            command.ExecuteNonQuery();
                            cnn.Close();

                            // activity logs begin

                            //     string desc = "New Stocks Added";
                            //     ConnectionClass.activity(frmLogin.userId, desc);

                            // activity logs end

                            this.Hide();


                            clear();
                        }


                }


            }
            catch (NumberFormatException ne)
            {
                MessageBox.Show(ne.Message);
            }
            catch (StringFormatException le)
            {
                MessageBox.Show(le.Message);
            }
            catch (nullExceptiom ne)
            {
                MessageBox.Show(ne.Message);
            }
            // end of catch 



        } // add Stocks 

        public void SupplierName()  // display Supplier name
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string names = "select Supplier_Name from Supplier where status = 1";
            SqlDataAdapter adapt = new SqlDataAdapter(names, con);

            DataTable dataTable = new DataTable();
            BindingSource bindingSource = new BindingSource();
            dataTable.Clear();
            adapt.Fill(dataTable);
            bindingSource.DataSource = dataTable;

            con.Open();
            SqlCommand command = new SqlCommand(names, con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            con.Close();

            cbSupplier.DataSource = dataTable;
            cbSupplier.DisplayMember = "Supplier_Name";

        }  // display supplier name end




    }// class end
}// namespace end 
