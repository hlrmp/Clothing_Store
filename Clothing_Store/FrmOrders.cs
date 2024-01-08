using System;
using System.Collections;
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
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
            see();
            total();
            filter();
            see();
        }
        FrmAddOrders fao = new FrmAddOrders();
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            fao.ShowDialog();

            see();
            dataGridViewManage.Hide();
            dataGridViewHome.Show();
        }

        private void btnManage_Click(object sender, EventArgs e) // btn manage begin
        {
            dataGridViewManage.Show();
            dataGridViewHome.Hide();
            dataGridViewSearch.Hide();
            manageOrders();



        } // btn manage end

        private void btnHomeOrders_Click(object sender, EventArgs e) // btn home begin
        {
            see();
            dataGridViewManage.Hide();
            dataGridViewHome.Show();
            dataGridViewSearch.Hide();
        } // btn home end

        public void see() // see begin
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            // detailed 
            //    string sj = "select concat( c.First_Name ,' ', c.Last_Name) as Customer ,o.quantity, p.Product_Name,concat(s.First_Name ,' ', s.Last_Name) as 'Staff Name'from  Inventory as i,Orders as o inner join Customers as c on o.Customer_Id = c.Customer_Id inner join Products as p on  p.Product_id = o.Product_Id inner join Staffs as s on s.Staff_Id = o.Staff_Id where o.Status = 1"; 
            // just orders
            string sj = "select  o.Order_Id as 'Order Id', concat(c.First_Name,' ',c.Last_Name)as 'Customer Name' ," +
                "p.Product_Id as 'Product Id', p.Product_Name as 'Product Name',p.Price, o.Quantity ," +
                "(p.Price * o.Quantity)as 'Total'," +
                "concat(s.First_Name ,' ', s.Last_Name) as 'Staff',o.Date, o.Status from Customers as c " +
                "inner join Orders as o on o.Customer_Id = c.Customer_Id " +
                "inner join Products as p on p.Product_Id = o.Product_Id " +
                "inner join Staffs as s on s.Staff_Id = o.Staff_Id where o.Status = 1";

            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHome.DataSource = table;


        }// see end
        public void manageOrders() // manage orders begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select  o.Order_Id , concat(c.First_Name,' ',c.Last_Name)as 'Customer_Name' ,p.Product_Id , p.Product_Name,p.Price as Product_Price, o.Quantity ,(p.Price * o.Quantity)as 'Total_Item',concat(s.First_Name ,' ', s.Last_Name) as 'Staffs',o.Date as 'Order_Date', o.Status from Customers as c inner join Orders as o on o.Customer_Id = c.Customer_Id inner join Products as p on p.Product_Id = o.Product_Id inner join Staffs as s on s.Staff_Id = o.Staff_Id where o.Status = 1";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewManage.DataSource = table;



        } // manage orders end - datagrid
        public void total()  // total Orders - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*)  AS 'Total Orders' from Orders where Status = 1";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lbltotal.Text = reader[0].ToString();  // - total numbers

        }  // total Orders - string

        private void FrmOrders_Load(object sender, EventArgs e) // frm load begin
        {
            this.txtSearch.AutoSize = false;
            this.txtSearch.Size = new System.Drawing.Size(243, 21);



            Timer timer = new Timer();
            timer.Interval = (5 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        } // frm load end 

        private void timer1_Tick(object sender, EventArgs e) // timer begin
        {
            manageOrders();
            dataGridViewManage.Refresh();
            total();

        } // timer end 

        private void txtSearch_MouseClick(object sender, MouseEventArgs e) // txt search begin
        {
            see();
            dataGridViewManage.Hide();
            dataGridViewHome.Show();
          
        } // txt search end

        private void dataGridViewManage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ordersClass oc = new ordersClass();

            oc.Order_Id = dataGridViewManage.CurrentRow.Cells["orderIdDataGridViewTextBoxColumn"].Value.ToString();
            oc.Customer_Name = dataGridViewManage.CurrentRow.Cells["customerNameDataGridViewTextBoxColumn"].Value.ToString();
            oc.Product_Id = dataGridViewManage.CurrentRow.Cells["productIdDataGridViewTextBoxColumn"].Value.ToString();
            oc.Product_Name = dataGridViewManage.CurrentRow.Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();

            oc.Product_Price = dataGridViewManage.CurrentRow.Cells["productPriceDataGridViewTextBoxColumn"].Value.ToString();
            oc.Total_Item = dataGridViewManage.CurrentRow.Cells["totalItemDataGridViewTextBoxColumn"].Value.ToString();
            oc.Staffs = dataGridViewManage.CurrentRow.Cells["staffsDataGridViewTextBoxColumn"].Value.ToString();
            oc.Order_Date = dataGridViewManage.CurrentRow.Cells["Date"].Value.ToString();
            oc.Quantity = dataGridViewManage.CurrentRow.Cells["quantityDataGridViewTextBoxColumn"].Value.ToString();


            if (dataGridViewManage.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do you want to Remove Order # "+oc.Order_Id+" by: "+oc.Customer_Name+"  ?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Orders set Status = 2 where Order_Id = "+oc.Order_Id+" ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    // activity logs begin

                    string desc = "Remove/Delete Order "+oc.Order_Id+" by: "+oc.Customer_Name+" ";

                    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)  // enter on txt search begin
        {
           
            dataGridViewSearch.Show();
            search();

        }// enter on txt search end

        private void lblsearch_MouseClick(object sender, MouseEventArgs e) // search label cick begin
        {
           
            dataGridViewSearch.Show();
            search();


        } // search label click end 

        public void search() // search method begin
        {


            if (cbFilter.Text.ToString() == "Product Name")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "select  o.Order_Id as 'Order Id', concat(c.First_Name,' ',c.Last_Name)as 'Customer Name' ,p.Product_Id as 'Product Id', p.Product_Name as 'Product Name',p.Price, o.Quantity ,(p.Price * o.Quantity)as 'Total',concat(s.First_Name ,' ', s.Last_Name) as 'Staff',o.Date, o.Status from Customers as c inner join Orders as o on o.Customer_Id = c.Customer_Id inner join Products as p on p.Product_Id = o.Product_Id inner join Staffs as s on s.Staff_Id = o.Staff_Id where o.Status = 1 and p.Product_Name LIKE '" + sch + '%' + "'";
 
                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);
                dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSearch.DataSource = table;


                cn.Close();
            }
           else if (cbFilter.Text.ToString() == "Customer Name")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "select  o.Order_Id as 'Order Id', concat(c.First_Name,' ',c.Last_Name)as 'Customer Name' ,p.Product_Id as 'Product Id', p.Product_Name as 'Product Name',p.Price, o.Quantity ,(p.Price * o.Quantity)as 'Total',concat(s.First_Name ,' ', s.Last_Name) as 'Staff',o.Date, o.Status from Customers as c inner join Orders as o on o.Customer_Id = c.Customer_Id inner join Products as p on p.Product_Id = o.Product_Id inner join Staffs as s on s.Staff_Id = o.Staff_Id where o.Status = 1 and CONCAT(TRIM(c.First_Name), ' ', TRIM(c.Last_Name))  LIKE '" + sch + '%' + "'";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);
                dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSearch.DataSource = table;


                cn.Close();
            }
            if (cbFilter.Text.ToString() == "Order Id")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "select  o.Order_Id as 'Order Id', concat(c.First_Name,' ',c.Last_Name)as 'Customer Name' ,p.Product_Id as 'Product Id', p.Product_Name as 'Product Name',p.Price, o.Quantity ,(p.Price * o.Quantity)as 'Total',concat(s.First_Name ,' ', s.Last_Name) as 'Staff',o.Date, o.Status from Customers as c inner join Orders as o on o.Customer_Id = c.Customer_Id inner join Products as p on p.Product_Id = o.Product_Id inner join Staffs as s on s.Staff_Id = o.Staff_Id where o.Status = 1 and o.Order_Id LIKE '" + sch + '%' + "'";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);
                dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSearch.DataSource = table;


                cn.Close();
            }
            if (cbFilter.Text.ToString() == "Quantity")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "select  o.Order_Id as 'Order Id', concat(c.First_Name,' ',c.Last_Name)as 'Customer Name' ,p.Product_Id as 'Product Id', p.Product_Name as 'Product Name',p.Price, o.Quantity ,(p.Price * o.Quantity)as 'Total',concat(s.First_Name ,' ', s.Last_Name) as 'Staff',o.Date, o.Status from Customers as c inner join Orders as o on o.Customer_Id = c.Customer_Id inner join Products as p on p.Product_Id = o.Product_Id inner join Staffs as s on s.Staff_Id = o.Staff_Id where o.Status = 1 and o.Quantity LIKE '" + sch + '%' + "'";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);
                dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSearch.DataSource = table;


                cn.Close();
            }



        }// search method end

        public void filter() // filter begin
        {


            ArrayList arr = new ArrayList();

            arr.Add("Customer Name");
            arr.Add("Product Name");
            arr.Add("Order Id");
            arr.Add("Quantity");
           

            foreach (string list in arr)
            {
                cbFilter.Items.Add(list);
            }

        } // filter end



    } // class end 
} // name space end
