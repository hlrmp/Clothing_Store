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

namespace Clothing_Store
{
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
            see();
            total();

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
            manageOrders();



        } // btn manage end

        private void btnHomeOrders_Click(object sender, EventArgs e) // btn home begin
        {
            see();
            dataGridViewManage.Hide();
            dataGridViewHome.Show();

        } // btn home end

        public void see() // see begin
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            // detailed 
            //    string sj = "select concat( c.First_Name ,' ', c.Last_Name) as Customer ,o.quantity, p.Product_Name,concat(s.First_Name ,' ', s.Last_Name) as 'Staff Name'from  Inventory as i,Orders as o inner join Customers as c on o.Customer_Id = c.Customer_Id inner join Products as p on  p.Product_id = o.Product_Id inner join Staffs as s on s.Staff_Id = o.Staff_Id where o.Status = 1"; 
            // just orders
            string sj = "select  o.Order_Id, concat(c.First_Name,' ',c.Last_Name)as 'Name' ,p.Product_Id, p.Product_Name,p.Price, o.Quantity ," +
                "concat(s.First_Name ,' ', s.Last_Name) as 'Staff', o.Status " +
                "from Customers as c inner join Orders as o on o.Customer_Id = c.Customer_Id " +
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


            string sj = "select * from Orders";
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

    } // class end 
} // name space end
