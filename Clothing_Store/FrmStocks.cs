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

namespace Clothing_Store
{
    public partial class FrmStocks : Form
    {
        public FrmStocks()
        {
            InitializeComponent();

            seestocks();// dshboard stocks
            filter(); // search filter 
            total(); // total number of products
        }

        frmAddStocks fs = new frmAddStocks();
        private void btnHomeCustomers_Click(object sender, EventArgs e) // home button begin
        {
            seestocks();
            dataGridViewManage.Visible = false;

        } // home button end

        private void btnAddStock_Click(object sender, EventArgs e) // add stock btn begin
        {
            fs.ShowDialog();
            dataGridViewManage.Visible = false;

        } //add stock btn end

        private void btnManage_Click(object sender, EventArgs e) // manage btn begin
        {
            manageItems();
            dataGridViewManage.Visible = true;

        } // manage btn end

        public void seestocks() // see stocks begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type, p.Size, p.Price, p.Color, i.Quantity , i.Date AS \"Date Added\"  " +
                "FROM Products AS p" +
                " \r\nINNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id)";


            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        } // see stocks end - datagrid
        public void filter() // filter begin
        {


            ArrayList arr = new ArrayList();

            arr.Add("Name");
            arr.Add("Type");
            arr.Add("Date");
            arr.Add("Size");
            arr.Add("Price");
            arr.Add("Category");
            arr.Add("Quantity");


            foreach (string list in arr)
            {
                cbFilter.Items.Add(list);
            }

        } // filter end

        public void search() // search method begin
        {


            if (cbFilter.Text.ToString() == "Name")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type, p.Size, p.Price, p.Color, i.Quantity , i.Date AS \"Date Added\" " +
                    " FROM Products AS p \r\n" +
                    "INNER JOIN Inventory AS i " +
                    "ON (p.Product_Id = i.product_Id) Where Product_Name LIKE '" + sch + '%' + "'   ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();

            }
           else if (cbFilter.Text.ToString() == "Type")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type, p.Size, p.Price, p.Color, i.Quantity , i.Date AS \"Date Added\" " +
                    " FROM Products AS p \r\n" +
                    "INNER JOIN Inventory AS i " +
                    "ON (p.Product_Id = i.product_Id) Where Type LIKE '" + sch + '%' + "'   ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text.ToString() == "Quantity")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type, p.Size, p.Price, p.Color, i.Quantity , i.Date AS \"Date Added\" " +
                    " FROM Products AS p \r\n" +
                    "INNER JOIN Inventory AS i " +
                    "ON (p.Product_Id = i.product_Id) Where Quantity LIKE '" + sch + '%' + "'   ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text.ToString() == "Price")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type, p.Size, p.Price, p.Color, i.Quantity , i.Date AS \"Date Added\" " +
                    " FROM Products AS p \r\n" +
                    "INNER JOIN Inventory AS i " +
                    "ON (p.Product_Id = i.product_Id) Where Price LIKE '" + sch + '%' + "'   ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text.ToString() == "Size")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type, p.Size, p.Price, p.Color, i.Quantity , i.Date AS \"Date Added\" " +
                    " FROM Products AS p \r\n" +
                    "INNER JOIN Inventory AS i " +
                    "ON (p.Product_Id = i.product_Id) Where Size LIKE '" + sch + '%' + "'   ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text.ToString() == "Category")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type, p.Size, p.Price, p.Color, i.Quantity , i.Date AS \"Date Added\" " +
                    " FROM Products AS p \r\n" +
                    "INNER JOIN Inventory AS i " +
                    "ON (p.Product_Id = i.product_Id) Where Category LIKE '" + sch + '%' + "'   ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text.ToString() == "Date")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type, p.Size, p.Price, p.Color, i.Quantity , i.Date AS \"Date Added\" " +
                    " FROM Products AS p \r\n" +
                    "INNER JOIN Inventory AS i " +
                    "ON (p.Product_Id = i.product_Id) Where Date LIKE '" + sch + '%' + "'   ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();

            }
            else
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type,p.Size, p.Price, p.Color, i.Quantity , i.Date AS \"Date Added\" " +
                    " FROM Products AS p \r\n" +
                    "INNER JOIN Inventory AS i " +
                    "ON (p.Product_Id = i.product_Id) Where Product_Name LIKE '" + sch + '%' + "'   ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();

            }


        } // search end


        public void seetotalInventory()   // total customers begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select count(*)  AS 'Total Items' from Inventory";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = table;

        } // total customers end - datagrid

        public void total()  // total customers - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*)  AS 'Total Items' from Inventory";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lbltotal.Text = reader[0].ToString();  // - total numbers

        }  // total customers - string

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e) // search enter vent begin
        {
            search();

        }// search enter event end

        private void lblsearch_Click(object sender, EventArgs e) // search lbl btn search event begin
        {
            search();

        }  // search lbl btn search even end

        private void btnTotal_Click(object sender, EventArgs e) // total btn begin
        {
            seetotalInventory();

        }// totla btn end

        private void FrmStocks_Load(object sender, EventArgs e) // frm load begin
        {

            this.txtSearch.AutoSize = false;
            this.txtSearch.Size = new System.Drawing.Size(243, 21);



            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        } // frm load end

        private void timer1_Tick(object sender, EventArgs e) // timer begin
        {
            total();
            lbltotal.Refresh();

        } // timer end
        public void manageItems() // manage items begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type, p.Price,p.Size, p.Color, " +
                "i.Quantity , i.Date " +
                "FROM Products AS p \r\n" +
                "INNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id)";

            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewManage.DataSource = table;


        } // manage items end - datagrid
 
        private void dataGridViewManage_CellContentClick_1(object sender, DataGridViewCellEventArgs e)  // datagrid view  btn click begin
        {
            if (dataGridViewManage.Columns[e.ColumnIndex].Name == "Edit")
            {
                MessageBox.Show("EDIT");


            }
            if (dataGridViewManage.Columns[e.ColumnIndex].Name == "Delete")
            {
                MessageBox.Show("DELETE");
            }

        }// datagrid view btn click

    }// class end
}// cname space end
