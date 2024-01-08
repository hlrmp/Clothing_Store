using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Store
{
    public partial class FrmDelivery : Form
    {
        public FrmDelivery()
        {
            InitializeComponent();
            sort();
            seeDelivery();
            // totalExisting();
            totalPending();

        }

        FrmAddDelivery fadd = new FrmAddDelivery();
        private void btnAdd_Click(object sender, EventArgs e) // button add begin
        {
            fadd.ShowDialog();

        } // buttton add end
        public void seeDelivery() // see delivery begin - datagrid
        {
            if (cbSortby.Text == "Pending")
            {
                SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer Name' , d.Order_Id, d.Description from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 1";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridView1Home.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1Home.DataSource = table;

                totalPending();

            }
            else if (cbSortby.Text == "Intransit")
            {
                SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer Name' , d.Order_Id, d.Description from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 3";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridView1Home.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1Home.DataSource = table;

                totalIntrnsit();
            }
            else if(cbSortby.Text == "Delivered")
            {

                SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer Name' , d.Order_Id, d.Description from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 4";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridView1Home.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1Home.DataSource = table;

                Delivery();
               
            }
            else
            {
               
                SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer Name' , d.Order_Id, d.Description from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 1";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridView1Home.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1Home.DataSource = table;

                totalPending();
            }
          



        } // see delivery end - datagrid

        public void manage() // manage delivery begin - datagrid
        {
            if (cbSortby.Text == "Pending")
            {
                SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer Name' , d.Order_Id, d.Description from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 1";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewManage.DataSource = table;

                totalPending();

            }
            else if (cbSortby.Text == "Intransit")
            {
                SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer Name' , d.Order_Id, d.Description from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 3";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewManage.DataSource = table;

                totalIntrnsit();
            }

        }// manage delivery end - datagrid


        public void sort()
        {
            ArrayList arr = new ArrayList();
            arr.Add("Delivered");
            arr.Add("Pending");
            arr.Add("Intransit");

            foreach (string i in arr)
            {
                cbSortby.Items.Add(i);
            }
        }
        Timer timer = new Timer();
        private void btnHomeDelivery_Click(object sender, EventArgs e) // btn Home begin
        {
            seeDelivery();
            dataGridViewManage.Visible = false;
            dataGridView1Home.Visible = true;

           
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        } // btn home end

        private void timer1_Tick(object sender, EventArgs e)
        {
            seeDelivery();
        }

        private void btnManage_Click(object sender, EventArgs e) // btn manage begin
        {
            dataGridViewManage.Visible = true;
            dataGridView1Home.Visible = false;

            timer.Stop();
            
            
        }// btn manage end
        public void totalPending()  // total delivery - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*) as total from Delivery where Status = 1";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lbltotal.Text = reader[0].ToString();  // - total numbers

        }  // total delivery - string
        public void Delivery()  // total delivery - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*) as total from Delivery where Status = 4";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lbltotal.Text = reader[0].ToString();  // - total numbers

        }  // total delivery - string
        public void totalIntrnsit()  // total delivery - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*) as total from Delivery where Status = 3";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lbltotal.Text = reader[0].ToString();  // - total numbers

        }  // total delivery - string



    } // class end
}  // name space end
