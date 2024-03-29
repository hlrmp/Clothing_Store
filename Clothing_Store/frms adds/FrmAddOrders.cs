﻿using System;
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
            itemslist();
            ordersList();
            names();

           lst = new BindingSource();
        }
        BindingSource lst;
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
            cbItem.ResetText();
            txtQuantity.Clear();
            cbCategory.ResetText();
            cbSize.ResetText();
            cbType.ResetText();
            cbColor.ResetText();

            listOrders1.Items.Clear();
            listOrders2.Items.Clear();

            cbColor.BackColor = Color.White;
            cbColor.ForeColor = Color.Black;

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
            arr.Add("Unisex");
          //  arr.Add("Kids");

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
            arr.Add("PoloShirt");
            arr.Add("Pants/Jeans");
            arr.Add("Blouse");
            arr.Add("Shorts");
            arr.Add("Collection");

            foreach (string c in arr)
            {
                cbType.Items.Add(c);
            }

        } // type method end
        public void names()
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string names = "SELECT p.Product_Id ,p.Product_Name AS Name, p.Category,p.Type, p.Price,p.Size, p.Color, i.Quantity FROM Products AS p INNER JOIN Inventory AS i ON (p.Product_Id = i.product_Id) where i.Quantity > 0\r\n";
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

            cbItem.DataSource = dataTable;
            cbItem.DisplayMember = "Name";
        }

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
    

                if (txtQuantity.Text == "" || cbSize.Text == "" || cbType.Text == ""  || cbCategory.Text == "" || cbColor.Text == ""
                    || cbCustomerName.Text == "" || cbItem.Text == "")
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {
                        if (int.Parse(Quan) >= int.Parse(oc.Quantity))
                        {
                            SqlConnection con = new SqlConnection(ConnectionClass.conn);


                            string up = "update Inventory set Quantity = Quantity - " + oc.Quantity + " where Product_Id = " + productId + " and Status = 1";
                            SqlCommand command1 = new SqlCommand(up, con);
                            con.Open();
                            command1.ExecuteNonQuery();
                            con.Close();


                            string ins = "insert into Orders (Staff_Id,Customer_Id,Product_Id,Quantity,Status,Date) values (@Staff_Id,@Customer_Id,@Product_Id,@Quantity,@Status,getDate())";
                            SqlCommand command = new SqlCommand(ins, con);



                            con.Open();

                            command.Parameters.AddWithValue("@Staff_Id", StaffId);
                            command.Parameters.AddWithValue("@Customer_Id", customerId);
                            command.Parameters.AddWithValue("@Product_Id", productId);
                            command.Parameters.AddWithValue("@Quantity", oc.Quantity);
                            command.Parameters.AddWithValue("@Status", "1");
                            command.ExecuteNonQuery();
                            con.Close();


                            MessageBox.Show("Succesfully added", "New Orders", MessageBoxButtons.OK);

                            // activity logs begin

                                string desc = " Inventory Changes and New Order Added ";
                                ConnectionClass.activity(frmLogin.userId, desc);

                        // activity logs end
                        }
                        else
                        {
                           
                            listOrders1.Items.Clear();
                            MessageBox.Show("Insuficient Stocks" ,"Stocks",MessageBoxButtons.OK);
                            
                        }

                }


        } // add end

        string productId;
        string Quan;
        public void pId()
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string ids = "SELECT p.Product_Id ,p.Product_Name AS 'Name', p.Category,p.Type, p.Price,p.Size, p.Color, i.Quantity FROM Products AS p" +
               " INNER JOIN Inventory AS i ON (p.Product_Id = i.product_Id) " +
               "where i.Quantity > 0 and p.Type = '" + oc.Type + "' and p.Category = '" + oc.Category + "' " +
               "and p.Product_Name = '" + oc.Item + "' and p.Size = '" + oc.Size + "' and p.Color = '" + oc.Color + "' ";

            con.Open();
            SqlCommand command = new SqlCommand(ids, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                productId = reader[0].ToString();
                Quan = reader[7].ToString();
            }
           
            con.Close();
        }
        public void cname() // cname beginn
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string ids = "select concat(First_Name ,' ', Last_Name ) as Name from Customers where Status = 1";
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


        string StaffId;
        public void staff()  //  staff begin
        {
            customerClass cs = new customerClass();
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string staffs = "select Staff_Id from Users where User_id = "+frmLogin.userId+" and Status = 1";

            con.Open();
            SqlCommand command;
            command = new SqlCommand(staffs, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                StaffId = reader[0].ToString();
            }

            con.Close();

        } // staff end

        private void btnAdd_Click(object sender, EventArgs e) // btn add begin
        {

                staff();


            try
            {
                oc.Quantity = quan(txtQuantity.Text);
                oc.Size = cbSize.Text;
                oc.Type = cbType.Text;
                oc.Category = cbCategory.Text;
                oc.Color = cbColor.Text;
                oc.Name = cbCustomerName.Text;
                oc.Item = cbItem.Text;



                if (txtQuantity.Text == "" || cbSize.Text == "" || cbType.Text == "" || cbCategory.Text == "" || cbColor.Text == ""
                    || cbCustomerName.Text == "" || cbItem.Text == "")
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {

                    pId();
                    uid();

                    add();

                  
                    ordersList();

                    listOrders1.Visible = false;
                    listOrders2.Visible = false;

                    dataGridViewOrders.Visible = true;

                    //   MessageBox.Show(customerId + " " + productId);

                    // activity logs begin

                //        string desc = " Inventory Changes becuse of Order Added ";
               //         ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        } // btn add end

        public void itemslist()  // items begin
        {
            string item = "SELECT p.Product_Id as 'Code',p.Product_Name AS Name, p.Category,p.Type, p.Price,p.Size, p.Color, sum(i.Quantity) as 'Quantity' FROM Products AS p INNER JOIN Inventory AS i ON (p.Product_Id = i.product_Id) where i.Quantity > 0 and p.Status = 1 \r\nGroup by p.Product_Id ,p.Product_Name, p.Category,p.Type, p.Price,p.Size, p.Color\r\norder by p.Product_Id";
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

           
            SqlDataAdapter adapt = new SqlDataAdapter(item, con);

            SqlCommand command = new SqlCommand();
            command.CommandText = item;
            command.Parameters.Clear();

            DataTable table = new DataTable();
            adapt.Fill(table);

            dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewItems.DataSource = table;


        } // items end
        public void ordersList() // orders begin
        {
            string order = "select  o.Order_Id as 'ID', concat(c.First_Name,' ',c.Last_Name)as 'Customer Name' ," +
                "p.Product_Name as 'Product Name',p.Price, o.Quantity ," +
                "(p.Price * o.Quantity)as 'Total'," +
                "o.Date from Customers as c " +
                "inner join Orders as o on o.Customer_Id = c.Customer_Id " +
                "inner join Products as p on p.Product_Id = o.Product_Id " +
                " where o.Status = 1";

            SqlConnection con = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter adapt = new SqlDataAdapter(order, con);

            SqlCommand command = new SqlCommand();
            command.CommandText = order;
            command.Parameters.Clear();

            DataTable table = new DataTable();
            adapt.Fill(table);

            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.DataSource = table;


        } // orders end


        public void search() // search begin
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

                if (txtQuantity.Text == "" || cbSize.Text == "" || cbType.Text == "" || cbCategory.Text == "" || cbColor.Text == ""
                    || cbCustomerName.Text == "" || cbItem.Text == "")
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {
                    string order = "SELECT p.Product_Id  as 'Code',p.Product_Name AS 'Name', p.Category as 'category' ,p.Type as 'type', p.Price as 'price',p.Size as 'Size', p.Color as 'Color', i.Quantity as 'quantity' FROM Products AS p" +
               " INNER JOIN Inventory AS i ON (p.Product_Id = i.product_Id) " +
               "where i.Quantity > 0 and p.Type = '" + cbType.Text + "' and p.Category = '" + cbCategory.Text + "' " +
               "and p.Product_Name = '" + cbItem.Text + "' and p.Size = '" + cbSize.Text + "' and p.Color = '" + cbColor.Text + "' ";


                    SqlConnection con = new SqlConnection(ConnectionClass.conn);

                    SqlDataAdapter adapt = new SqlDataAdapter(order, con);

                    SqlCommand command = new SqlCommand();
                    command.CommandText = order;
                    command.Parameters.Clear();

                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewItems.DataSource = table;

                    comfirmation();
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



        } // search end

        string condition;
        public void comfirmation()  // confirmaion begin
        {

            customerClass cs = new customerClass();
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string order = "SELECT p.Product_Id ,p.Product_Name AS 'Name', p.Category,p.Type, p.Price,p.Size, p.Color, i.Quantity FROM Products AS p" +
       " INNER JOIN Inventory AS i ON (p.Product_Id = i.product_Id) " +
       "where i.Quantity > 0 and p.Type = '" + cbType.Text + "' and p.Category = '" + cbCategory.Text + "' " +
       "and p.Product_Name = '" + cbItem.Text + "' and p.Size = '" + cbSize.Text + "' and p.Color = '" + cbColor.Text + "' ";

            con.Open();
            SqlCommand command;
            command = new SqlCommand(order, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {

                condition = "same";
            }
            else
            {

                condition = "notsame";
            }

            con.Close();
        } // confirmation end

        private void btnClear_Click(object sender, EventArgs e) // clear btn begin
        {
            clear();
            dataGridViewOrders.Visible = true;

        
        }// clear btn end

        private void btnSearch_Click(object sender, EventArgs e) // btn search begin
        {
            search();

            


        }  // btn search end

        private void btnRefresh_Click(object sender, EventArgs e) // btn refresh begin
        {
            itemslist();
            dataGridViewItems.Refresh();

        } // btn refresh end



        private void btnAddOrders_Click(object sender, EventArgs e) // btn add from textboxes to datagrid begin
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

                if (txtQuantity.Text == "" || cbSize.Text == "" || cbType.Text == "" || cbCategory.Text == "" || cbColor.Text == ""
                    || cbCustomerName.Text == "" || cbItem.Text == "")
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {
                    search();

                        if (condition == "same")
                        {
                            listOrders1.Items.Clear();
                            listOrders1.Visible = true;

                            listOrders2.Items.Clear();
                            listOrders2.Visible = true;

                            dataGridViewOrders.Visible = false;

                            listOrders1.Items.Add("Name:" + oc.Name);
                            listOrders1.Items.Add("Item:" + oc.Item);
                            listOrders1.Items.Add("Category:" + oc.Category);
                            listOrders2.Items.Add("Quantity:" + oc.Quantity);
                            listOrders2.Items.Add("Size:" + oc.Size);
                            listOrders2.Items.Add("Color:" + oc.Color);
                            listOrders2.Items.Add("Type:" + oc.Type);

                        }
                        else if (condition == "notsame")
                        {
                            throw new nullExceptiom("Item Don't Exist");
                        }


                    /*
                    dataGridViewAdd.Visible = true;

                    lst.Add(new ordersClass(cbCustomerName.Text, cbCategory.Text, cbItem.Text, txtQuantity.Text, cbSize.Text, cbColor.Text, cbType.Text));

                    dataGridViewAdd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewAdd.DataSource = lst;
                    */
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



        }// add order btn rom textboxs to datagrid ennd

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oc.Product_Id = dataGridViewItems.CurrentRow.Cells["codeDataGridViewTextBoxColumn"].Value.ToString();
            oc.Product_Name = dataGridViewItems.CurrentRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
            oc.Color = dataGridViewItems.CurrentRow.Cells["colorDataGridViewTextBoxColumn"].Value.ToString();
            oc.Type = dataGridViewItems.CurrentRow.Cells["typeDataGridViewTextBoxColumn"].Value.ToString();
            oc.Category = dataGridViewItems.CurrentRow.Cells["categoryDataGridViewTextBoxColumn"].Value.ToString();
            oc.Size = dataGridViewItems.CurrentRow.Cells["sizeDataGridViewTextBoxColumn"].Value.ToString();
            oc.Quantity = dataGridViewItems.CurrentRow.Cells["quantityDataGridViewTextBoxColumn"].Value.ToString();
            oc.Product_Price = dataGridViewItems.CurrentRow.Cells["priceDataGridViewTextBoxColumn"].Value.ToString();

                cbItem.Text = oc.Product_Name;
                cbCategory.Text = oc.Category;
                cbSize.Text = oc.Size;
                cbType.Text = oc.Type;
                cbColor.Text = oc.Color;
            
           


        }

        public void seeTotalItems() // see all items begin - datagrid
        {

            SqlConnection connection = new SqlConnection(ConnectionClass.conn);
            connection.Open();

            string order = "SELECT p.Product_Id  as 'Code',p.Product_Name AS 'Name', p.Category as 'category' ,p.Type as 'type', p.Price as 'price',p.Size as 'Size', p.Color as 'Color', i.Quantity as 'quantity' FROM Products AS p" +
               " INNER JOIN Inventory AS i ON (p.Product_Id = i.product_Id) " +
               "where i.Quantity > 0 and p.Status = 1";

           
            SqlDataAdapter data = new SqlDataAdapter(order, connection);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewItems.DataSource = table;

            connection.Close();




        } // see all items end - datagrid
    } // calss end
} // namespace end
