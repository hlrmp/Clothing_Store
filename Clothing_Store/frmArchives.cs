using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clothing_Store.classes;

namespace Clothing_Store
{
    public partial class frmArchives : Form
    {
        public frmArchives()
        {
            InitializeComponent();
            counts();

        }

        private void frmArchives_Load(object sender, EventArgs e)  // frm load begin
        {
         //   this.dataGridViewMain.GridColor = Color.Navy;

           /* 
            
            this.txtSearch.AutoSize = false;
            this.txtSearch.Size = new System.Drawing.Size(243, 21);
*/
            Timer timer = new Timer();
            timer.Interval = (2 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();



        } // frm load end

        protected override void OnPaint(PaintEventArgs e)    // border color begin
        {
            //  base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid);

          
        }  // border color end

        private void button1_Click(object sender, EventArgs e)  // X button begin
        {
            this.Hide();

        } // X button end


        private void btnHome_Click(object sender, EventArgs e) // home btn begin
        {
            datagridCustomer.Visible = false;
         //   dataGridViewMain.Visible = false;
            panelCounts.Visible = true;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = false;
            dataGridViewItems.Visible = false;
            dataGridViewItems.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;

            btnHome.BackColor = Color.DarkBlue;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.Teal;

        } // home btn end
        private void btnCustomers_Click(object sender, EventArgs e) // btn customer begin
        {
            datagridCustomer.Visible = true;
         //   dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = false;
            dataGridViewItems.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;

            manageCustomers();

            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.DarkBlue;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.Teal;


        } // btn customer end
        private void btnOrders_Click(object sender, EventArgs e)// manage orders begin 
        {
            datagridCustomer.Visible = false;
            //  dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = true;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = false;
            dataGridViewItems.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;

            manageOrders();

            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.DarkBlue;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.Teal;

        }// manage orders end 

        private void btnStocks_Click(object sender, EventArgs e) // btn stocks begin
        {
            datagridCustomer.Visible = false;
            // dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = true;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = false;
            dataGridViewItems.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;


            manageStocks();

            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.DarkBlue;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.Teal;

        } // btn stocks end
        private void btnStaffs_Click(object sender, EventArgs e) // btn staff begin
        {
            datagridCustomer.Visible = false;
            //   dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = true;
            dataGridViewUsers.Visible = false;
            dataGridViewItems.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;

            ManageStaffs();

            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.DarkBlue;
            btnUsers.BackColor = Color.Teal;

        } // btn staffs end

        private void btnUsers_Click(object sender, EventArgs e) // btn users begin
        {
            datagridCustomer.Visible = false;
            //   dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = true;
            dataGridViewItems.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;

            manageUsers();

            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.DarkBlue;


        } //btn users end

        private void btnItems_Click(object sender, EventArgs e)  // btn Items begin
        {

            dataGridViewItems.Visible = true;

            datagridCustomer.Visible = false;
            //   dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;

            manageItems();

            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.DarkBlue;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.Teal;


        } // btn items end
        private void pbCustomer_Click(object sender, EventArgs e)
        {
            datagridCustomer.Visible = true;
            //   dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = false;
            dataGridViewItems.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;

            manageCustomers();

            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.DarkBlue;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.Teal;

        }

        private void pbOrders_Click(object sender, EventArgs e)
        {
            datagridCustomer.Visible = false;
            //  dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = true;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = false;
            dataGridViewItems.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;

            manageOrders();


            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.DarkBlue;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.Teal;

        }

        private void pbStaffs_Click(object sender, EventArgs e)
        {
            datagridCustomer.Visible = false;
            //   dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = true;
            dataGridViewUsers.Visible = false;
            dataGridViewItems.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;

            ManageStaffs();


            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.DarkBlue;
            btnUsers.BackColor = Color.Teal;

        }


        private void pbUsers_Click(object sender, EventArgs e)
        {

            datagridCustomer.Visible = false;
            //   dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = true;
            dataGridViewItems.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;

            manageUsers();


            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.DarkBlue;

        }

        private void pbItems_Click(object sender, EventArgs e)
        {
            dataGridViewItems.Visible = true;

            datagridCustomer.Visible = false;
            //   dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;

            manageItems();

            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.DarkBlue;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.Teal;


        }          

        private void pbStocks_Click(object sender, EventArgs e)// pb stocks begin
        {
            datagridCustomer.Visible = false;
            // dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = true;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = false;
            dataGridViewItems.Visible = false;

            dataGridViewSupplier.Visible = false;
            btnSupplier.BackColor = Color.Teal;
            manageStocks();

            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.DarkBlue;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.Teal;

        }// pb stocks end

        private void btnSupplier_Click(object sender, EventArgs e) // btn suppliers begin
        {
            datagridCustomer.Visible = false;
            // dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = false;
            dataGridViewItems.Visible = false;
            dataGridViewSupplier.Visible = true;


            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.Teal;
            btnSupplier.BackColor = Color.DarkBlue;
            manageSupplier();

        } // btn supliers end
        private void pbSupplier_Click(object sender, EventArgs e) // pb supplier begin
        {
            datagridCustomer.Visible = false;
            // dataGridViewMain.Visible = false;
            panelCounts.Visible = false;
            dataGridViewOrders.Visible = false;
            dataGridViewStocks.Visible = false;
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = false;
            dataGridViewItems.Visible = false;
            dataGridViewSupplier.Visible = true;


            btnHome.BackColor = Color.Teal;
            btnCustomers.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnStocks.BackColor = Color.Teal;
            btnStaffs.BackColor = Color.Teal;
            btnUsers.BackColor = Color.Teal;
            btnSupplier.BackColor = Color.DarkBlue;

            manageSupplier();

        }// pb Supplier end
        public void manageSupplier() // Supplier begin
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string names = "select Supplier_Id as Id, Supplier_Name , Contact_No , Email AS email , Address AS address from Supplier where Status = 2 ";
            SqlDataAdapter adapt = new SqlDataAdapter(names, con);

            DataTable dataTable = new DataTable();
            BindingSource bindingSource = new BindingSource();
            dataTable.Clear();
            adapt.Fill(dataTable);
            bindingSource.DataSource = dataTable;


            dataGridViewSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSupplier.DataSource = dataTable;

        } // supplier end

        public void manageItems()
        {
            SqlConnection connection = new SqlConnection(ConnectionClass.conn);
            connection.Open();

            string quer = "SELECT Product_id as 'Code' , Product_Name as 'Name', Type as type, Category as category, Price as price,Color, Size as size , Date as date FROM Products where Status = 2";
            SqlDataAdapter data = new SqlDataAdapter(quer, connection);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewItems.DataSource = table;

            connection.Close();
        }

        public void manageUsers() // manage Users begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select u.User_Id , s.First_Name , s.Last_Name , u.User_Name,u.Password from Users as u inner join Staffs as s on u.Staff_Id = s.Staff_Id where u.Status = 2 ";

            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.DataSource = table;



        } // manage Users end - datagrid
        public void manageCustomers() // manage cusstomers begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select Customer_Id, First_Name, Last_Name, Contact_No, Email,  Address, Delivery_Address from Customers where Status = 2";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            datagridCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridCustomer.DataSource = table;



        } // manage cusstomers end - datagrid
        public void manageOrders() // manage orders begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select  o.Order_Id , concat(c.First_Name,' ',c.Last_Name)as 'Customer_Name' ,p.Product_Id , p.Product_Name,p.Price as" +
                " Product_Price, o.Quantity ,(p.Price * o.Quantity)as 'Total_Item',concat(s.First_Name ,' ', s.Last_Name) as 'Staffs',o.Date as 'Order_Date', " +
                "o.Status from Customers as c inner join Orders as o on o.Customer_Id = c.Customer_Id inner join Products as p on p.Product_Id = o.Product_Id " +
                "inner join Staffs as s on s.Staff_Id = o.Staff_Id where o.Status = 2";

            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.DataSource = table;



        } // manage orders end - datagrid
        public void ManageStaffs() // manage Staffs begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select Staff_Id , First_Name , Last_Name,Contact_No,Email , Address,Position from staffs where Status = 2";

            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewStaffs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStaffs.DataSource = table;



        } // manage Staffs end - datagrid


        public void manageStocks() // manage items begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type, p.Price,p.Size, p.Color, " +
                "i.Quantity , i.Date " +
                "FROM Products AS p \r\n" +
                "INNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id) where i.status = 2";

            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStocks.DataSource = table;


        } // manage items end - datagrid


        public void counts() // counts begin
        {

            SqlConnection con = new SqlConnection(ConnectionClass.conn);
            string Items = "select count(*) from Customers where status = 2 ";

            SqlCommand command;
            command = new SqlCommand(Items, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                lblCustomers.Text = reader[0].ToString();
            }

            con.Close();


            string Orders = "select count(*) from Orders where status = 2";

            SqlCommand command1;
            command1 = new SqlCommand(Orders, con);
            con.Open();
            SqlDataReader reader1 = command1.ExecuteReader();
            if (reader1.Read())
            {
                lblOrders.Text = reader1[0].ToString();
            }

            con.Close();

            string stock = "select count(*) from Inventory where status = 2";

            SqlCommand command2;
            command2 = new SqlCommand(stock, con);
            con.Open();
            SqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                lblStocks.Text = reader2[0].ToString();
            }

            con.Close();

            string staffs = "select count(*) from staffs where Status = 2";

            SqlCommand command3;
            command3 = new SqlCommand(staffs, con);
            con.Open();
            SqlDataReader reader3 = command3.ExecuteReader();
            if (reader3.Read())
            {
                lblStaffs.Text = reader3[0].ToString();
            }

            con.Close();

            string user = "select count(*) from Users where Status = 2";

            SqlCommand command4;
            command4 = new SqlCommand(user, con);
            con.Open();
            SqlDataReader reader4 = command4.ExecuteReader();
            if (reader4.Read())
            {
                lblUsers.Text = reader4[0].ToString();
            }

            con.Close();


            string products = "select count(*) from Products where Status = 2";

            SqlCommand command5;
            command5 = new SqlCommand(products, con);
            con.Open();
            SqlDataReader reader5 = command5.ExecuteReader();
            if (reader5.Read())
            {
                lblItems.Text = reader5[0].ToString();
            }

            con.Close();

            string Supplier = "select count(*) from Supplier where Status = 2";


            SqlCommand command6;
            command6 = new SqlCommand(Supplier, con);
            con.Open();
            SqlDataReader reader6 = command6.ExecuteReader();
            if (reader6.Read())
            {
                lblTotalSupplier.Text = reader6[0].ToString();
            }

            con.Close();


        } // count end


        private void dataGridViewManage_CellContentClick(object sender, DataGridViewCellEventArgs e) // customers click manage begin
        {
            customerClass cs = new customerClass();
            cs.First_Name = datagridCustomer.CurrentRow.Cells["firstNameDataGridViewTextBoxColumn"].Value.ToString();
            cs.Last_Name = datagridCustomer.CurrentRow.Cells["lastNameDataGridViewTextBoxColumn"].Value.ToString();
            cs.Contact_No = datagridCustomer.CurrentRow.Cells["contactNoDataGridViewTextBoxColumn"].Value.ToString();
            cs.email = datagridCustomer.CurrentRow.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
            cs.address = datagridCustomer.CurrentRow.Cells["addressDataGridViewTextBoxColumn"].Value.ToString();
            cs.Delivery_Address = datagridCustomer.CurrentRow.Cells["deliveryAddressDataGridViewTextBoxColumn"].Value.ToString();


            if (datagridCustomer.Columns[e.ColumnIndex].Name == "RestoreCustomers")
            {
                DialogResult result = MessageBox.Show("Do you want to Restore " + cs.First_Name + " " + cs.Last_Name + "?", "Restore", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Customers SET Status = 1 WHERE First_Name = '" + cs.First_Name + "' and  Last_Name = '" + cs.Last_Name + "'  " + "and Contact_No = '" + cs.Contact_No + "'  and Email = '" + cs.email + "' and  Address = '" + cs.address + "' and Delivery_Address = '" + cs.Delivery_Address + "' ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();


                    manageCustomers();
                    MessageBox.Show("Succesfully Restore ","Restore",MessageBoxButtons.OK);

                    // activity logs begin

                     string desc = "Restore Customer Information";
                     ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
             

            }
            else
            {

            }

        } // customers click manage end
        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e) // cell content click orders begin
        {
            ordersClass oc = new ordersClass();

            oc.Order_Id = dataGridViewOrders.CurrentRow.Cells["orderIdDataGridViewTextBoxColumn"].Value.ToString();
            oc.Customer_Name = dataGridViewOrders.CurrentRow.Cells["customerNameDataGridViewTextBoxColumn"].Value.ToString();
            oc.Product_Id = dataGridViewOrders.CurrentRow.Cells["productIdDataGridViewTextBoxColumn"].Value.ToString();
            oc.Product_Name = dataGridViewOrders.CurrentRow.Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();

            oc.Product_Price = dataGridViewOrders.CurrentRow.Cells["productPriceDataGridViewTextBoxColumn"].Value.ToString();
            oc.Total_Item = dataGridViewOrders.CurrentRow.Cells["totalItemDataGridViewTextBoxColumn"].Value.ToString();
            oc.Staffs = dataGridViewOrders.CurrentRow.Cells["staffsDataGridViewTextBoxColumn"].Value.ToString();
            oc.Quantity = dataGridViewOrders.CurrentRow.Cells["quantityDataGridViewTextBoxColumn"].Value.ToString();


            if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "RestoreOrders")
            {
                DialogResult result = MessageBox.Show("Do you want to Restore Order # " + oc.Order_Id + " by: " + oc.Customer_Name + "  ?", "Restore", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Orders set Status = 1 where Order_Id = " + oc.Order_Id + " ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    manageOrders();
                    MessageBox.Show("Succesfully Restore ", "Restore", MessageBoxButtons.OK);

                    // activity logs begin

                    string desc = "Restore Order " + oc.Order_Id + " by: " + oc.Customer_Name + " ";
                    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }

            }

        } // cell content click orders end
        private void timer1_Tick(object sender, EventArgs e) // timer begin
        {

            /*  manageCustomers();
              datagridCustomer.Refresh();
            */

            counts();

        } // timer end

        userClass staff = new userClass();

        private void dataGridViewStaffs_CellContentClick(object sender, DataGridViewCellEventArgs e) // datagrid staffs click begin 
        {
            userClass staff = new userClass();

            staff.staffid = dataGridViewStaffs.CurrentRow.Cells["Staff_Id"].Value.ToString();
            staff.StaffFirstName = dataGridViewStaffs.CurrentRow.Cells["First_Name"].Value.ToString();
            staff.StaffLastName = dataGridViewStaffs.CurrentRow.Cells["Last_Name"].Value.ToString();
            staff.StaffAddress = dataGridViewStaffs.CurrentRow.Cells["Address"].Value.ToString();
            staff.StaffConntacNo = dataGridViewStaffs.CurrentRow.Cells["Contact_No"].Value.ToString();
            staff.staffEmail = dataGridViewStaffs.CurrentRow.Cells["Email"].Value.ToString();
            staff.StaffPosition = dataGridViewStaffs.CurrentRow.Cells["Position"].Value.ToString();

            if (dataGridViewStaffs.Columns[e.ColumnIndex].Name == "RestoreStaffs")
            {
                DialogResult result = MessageBox.Show("Do you want to Restore Staff # " + staff.staffid + " Name: " + staff.StaffFirstName + " " + staff.StaffLastName + "  ?", "Restore", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Staffs set Status = 1 where Staff_Id = " + staff.staffid + " ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    ManageStaffs();
                    MessageBox.Show("Succesfully Restore ", "Restore", MessageBoxButtons.OK);

                    // activity logs begin

                    string desc = " Restore Staff # " + staff.staffid + " Name: " + staff.StaffFirstName + " " + staff.StaffLastName;
                    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }

            }
        } // datagrid staff click end

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)// datagrid User click begin
        { 
            staff.uid = dataGridViewUsers.CurrentRow.Cells["User_Id"].Value.ToString();
            staff.username = dataGridViewUsers.CurrentRow.Cells["User_Name"].Value.ToString();
            staff.userpas = dataGridViewUsers.CurrentRow.Cells["Password"].Value.ToString();


             if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "RestoreUser")
            {
                DialogResult result = MessageBox.Show("Do you want to Restore User # " + staff.uid + " User Name: " + staff.username + " Password: " + staff.userpas + "  ?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Users set Status = 1 where User_Id = " + staff.uid + " ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();


                    manageUsers();
                    MessageBox.Show("Succesfully Restore ", "Restore", MessageBoxButtons.OK);

                    // activity logs begin

                    string desc = "Restore User # " + staff.uid + " User Name: " + staff.username + " Password: " + staff.userpas;
                    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }

            }
        }// datagrid User click end

        private void dataGridViewItems_CellContentClick_1(object sender, DataGridViewCellEventArgs e)   //datagrid item Click begin
        {
            itemsClass it = new itemsClass();

            it.Code = dataGridViewItems.CurrentRow.Cells["code"].Value.ToString();
            it.Name = dataGridViewItems.CurrentRow.Cells["name"].Value.ToString();
            it.price = dataGridViewItems.CurrentRow.Cells["price"].Value.ToString();

            if (dataGridViewItems.Columns[e.ColumnIndex].Name == "Restore")
            {
                DialogResult result = MessageBox.Show("Do you want to Restore : Code "+it.Code+" - " + it.Name + "?", "Restore", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "update Products set Status = 1 where Product_Id = " + it.Code + " ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();


                    manageItems();

                    MessageBox.Show("Succesfully Restore ", "Restore", MessageBoxButtons.OK);

                    // activity logs begin

                    string desc = "Restore Item " + it.Code;
                    //    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }
            }
        }//datagrid item Click end

        supplierClass sc = new supplierClass();
      

        private void dataGridViewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e) // cell click begin
        {
            sc.Supplier_Name = dataGridViewSupplier.CurrentRow.Cells["SupName"].Value.ToString();
            sc.Contact_No = dataGridViewSupplier.CurrentRow.Cells["Contact"].Value.ToString();
            sc.address = dataGridViewSupplier.CurrentRow.Cells["Addres"].Value.ToString();
            sc.email = dataGridViewSupplier.CurrentRow.Cells["Em"].Value.ToString();
            sc.Id = dataGridViewSupplier.CurrentRow.Cells["Id"].Value.ToString();

             if (dataGridViewSupplier.Columns[e.ColumnIndex].Name == "Restore")
            {
                DialogResult result = MessageBox.Show("Do you want to Restore " + sc.Supplier_Name + "?", "Restore", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Supplier SET Status = 1 WHERE Supplier_Id = " + sc.Id + " ";
                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    manageSupplier();

                    MessageBox.Show("Succesfully Restore ", "Restore", MessageBoxButtons.OK);

                    // activity logs begin

                    string desc = "Restore Supplier Information - " + sc.Id;
                    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }
            }

        } // cell click end

      
    }// class end
} // name space end
