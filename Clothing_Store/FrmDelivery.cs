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
using Clothing_Store.classes;

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

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' , c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'pending' ";
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

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' , c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'intransit' ";
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

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' , c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'delivered' ";
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

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' , c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'pending' or d.Status = 'intransit'";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridView1Home.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1Home.DataSource = table;

                Total();
            }
          



        } // see delivery end - datagrid

        public void manage() // manage delivery begin - datagrid
        {
            if (cbSortby.Text == "Pending")
            {
                SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' , c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'pending' ";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewManagePending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewManagePending.DataSource = table;

                dataGridViewManageDelivered.Visible = false;
                dataGridViewManageIntransit.Visible = false;
                dataGridViewManagePending.Visible = true;

                totalPending();

            }
            else if (cbSortby.Text == "Intransit")
            {
                SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' , c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'intransit' ";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewManageIntransit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewManageIntransit.DataSource = table;

                dataGridViewManageDelivered.Visible = false;
                dataGridViewManageIntransit.Visible = true;
                dataGridViewManagePending.Visible = false;

                totalIntrnsit();
            }
            else if (cbSortby.Text == "Delivered")
            {
                SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' , c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'delivered' ";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewManageDelivered.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewManageDelivered.DataSource = table;

                dataGridViewManageDelivered.Visible = true;
                dataGridViewManageIntransit.Visible = false;
                dataGridViewManagePending.Visible = false;

                Delivery();
            }
            else
            {
                SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

                string sj = "select d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' , c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'pending' ";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewManagePending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewManagePending.DataSource = table;

                dataGridViewManageDelivered.Visible = false;
                dataGridViewManageIntransit.Visible = false;
                dataGridViewManagePending.Visible = true;

                totalPending();

            }


        }// manage delivery end - datagrid


        public void sort()
        {
            ArrayList arr = new ArrayList();

            arr.Add("All");
            arr.Add("Pending");
            arr.Add("Intransit");
            arr.Add("Delivered");
           

            foreach (string i in arr)
            {
                cbSortby.Items.Add(i);
            }
        }

        Timer timer = new Timer();
        Timer tm = new Timer();
        private void btnHomeDelivery_Click(object sender, EventArgs e) // btn Home begin
        {
            tm.Stop();
          

            seeDelivery();
            dataGridViewManagePending.Visible = false;
            dataGridView1Home.Visible = true;

           
            timer.Interval = (2 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            

        } // btn home end

        private void timer1_Tick(object sender, EventArgs e)
        {
            seeDelivery();
           
        }
        private void timer2_Tick(object sender, EventArgs e) //  timer 2 begin
        {
            manage();

        } // timer 2 end
        private void btnManage_Click(object sender, EventArgs e) // btn manage begin
        {
            dataGridViewManagePending.Visible = true;
            dataGridView1Home.Visible = false;

            timer.Stop();


            tm.Interval = (2 * 1000);
            tm.Tick += new EventHandler(timer2_Tick);
            tm.Start();

            manage();
            
            
        }// btn manage end
        public void totalPending()  // total delivery - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*) as total from Delivery where Status = 'pending'";
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
            string sj = "select count(*) as total from Delivery where Status = 'delivered'";
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
            string sj = "select count(*) as total from Delivery where Status = 'intransit'";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lbltotal.Text = reader[0].ToString();  // - total numbers

        }  // total delivery - string
        public void Total()  // total delivery - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*) as total from Delivery where Status = 'intransit' or Status = 'pending'";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lbltotal.Text = reader[0].ToString();  // - total numbers

        }  // total delivery - string

        deliveryClass dc = new deliveryClass();

        private void dataGridViewManageDelivered_CellContentClick(object sender, DataGridViewCellEventArgs e)//  Delivery management begin
        {
          

            dc.Delivery_Id = dataGridViewManageDelivered.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
            dc.Description = dataGridViewManageDelivered.CurrentRow.Cells["dataGridViewTextBoxColumn12"].Value.ToString();

            if (dataGridViewManageDelivered.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do you want to Remove Delivery # " + dc.Delivery_Id + " by: " + dc.Description + "  ?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Delivery set Status = 'Delete' where Order_Id = " + dc.Delivery_Id + " ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    // activity logs begin

                    string desc = " Delete Delivery Info " + dc.Delivery_Id + " by: " + dc.Description + " ";

                    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }

            }

            manage();

        } //  Delivery management end

        private void dataGridViewManageIntransit_CellContentClick(object sender, DataGridViewCellEventArgs e)//  intransit management begin
        {

            dc.Delivery_Id = dataGridViewManageIntransit.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            dc.Description = dataGridViewManageIntransit.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();

            if (dataGridViewManageIntransit.Columns[e.ColumnIndex].Name == "DeliveredIntransit")
            {

                DialogResult result = MessageBox.Show("Do you want to Move this to Delivered  - # " + dc.Delivery_Id + " by: " + dc.Description + "  ?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Delivery set Status = 'Delivered' where Delivery_Id = " + dc.Delivery_Id + " ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    // activity logs begin

                    string desc = " move to delivered frm intransit Info " + dc.Delivery_Id + " by: " + dc.Description + " ";

                    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }

            }
            else if (dataGridViewManageIntransit.Columns[e.ColumnIndex].Name == "DeleteIntransit")
            {
                DialogResult result = MessageBox.Show("Do you want to Remove Delivery # " + dc.Delivery_Id + " by: " + dc.Description + "  ?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Delivery set Status = 'Delete' where Delivery_Id = " + dc.Delivery_Id + " ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    // activity logs begin

                    string desc = " Delete Intransit Info " + dc.Delivery_Id + " by: " + dc.Description + " ";

                    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }

            }

            manage();

        } //  intransit management end

        private void dataGridViewManagePending_CellContentClick(object sender, DataGridViewCellEventArgs e)//  Pending management begin
        {

            dc.Delivery_Id = dataGridViewManagePending.CurrentRow.Cells["deliveryIdDataGridViewTextBoxColumn"].Value.ToString();
            dc.Description = dataGridViewManagePending.CurrentRow.Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();

            if (dataGridViewManagePending.Columns[e.ColumnIndex].Name == "Intransit")
            {

                DialogResult result = MessageBox.Show("Do you want to Move this to Intransit  - # " + dc.Delivery_Id + " by: " + dc.Description + "  ?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Delivery set Status = 'Intransit' where Delivery_Id = " + dc.Delivery_Id + " ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    // activity logs begin

                    string desc = " move to delivered frm intransit Info " + dc.Delivery_Id + " by: " + dc.Description + " ";

                    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }

            }
            else if (dataGridViewManagePending.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do you want to Remove Pending # " + dc.Delivery_Id + " by: " + dc.Description + "  ?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Delivery set Status = 'deleted' where Order_Id = " + dc.Delivery_Id + " ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    // activity logs begin

                    string desc = " Delete Pending Info " + dc.Delivery_Id + " by: " + dc.Description + " ";

                    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }

            }

            manage();


        }//  Pending management end

        private void FrmDelivery_Load(object sender, EventArgs e)
        {
           // sort();
        }
    } // class end
}  // name space end
