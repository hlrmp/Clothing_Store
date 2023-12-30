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
            panelEdit.Visible = false;

        } // home button end

        private void btnAddStock_Click(object sender, EventArgs e) // add stock btn begin
        {
            fs.ShowDialog();
            dataGridViewManage.Visible = false;

        } //add stock btn end

        private void btnManage_Click(object sender, EventArgs e) // manage btn begin
        {
          
            dataGridViewManage.Visible = true;
            manageItems();

        } // manage btn end

        public void seestocks() // see stocks begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "SELECT p.Product_Name AS \"Name\", p.Category,p.Type, p.Size, p.Price, p.Color, i.Quantity , i.Date AS \"Date Added\"  " +
                "FROM Products AS p" +
                " \r\nINNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id) where i.status = 1";


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


            string sj = "select count(*)  AS 'Total Items' from Inventory where status = 1";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = table;

        } // total customers end - datagrid

        public void total()  // total customers - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*)  AS 'Total Items' from Inventory where status = 1";
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


            string sj = "select i.Inventory_ID as 'Inventory_Number' ,concat(i.Product_Id ,' - ', p.Product_Name) as 'code_and_name' ,s.Supplier_Name , i.Quantity, i.Date from Inventory as  i inner join Products as p on i.Product_Id = p.Product_id inner join Supplier as s on i.Supplier_Id = s.Supplier_Id where i.status = 1";

            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewManage.DataSource = table;


        } // manage items end - datagrid



        itemsClass it = new itemsClass();
        
        string id;

        private void dataGridViewManage_CellContentClick_1(object sender, DataGridViewCellEventArgs e)  // datagrid view  btn click begin
        {
            itemsClass it = new itemsClass();

           
            it.Supplier = dataGridViewManage.CurrentRow.Cells["Supplier_Name"].Value.ToString();
            it.Code =  dataGridViewManage.CurrentRow.Cells["Inventory_Number"].Value.ToString();
            it.quantity = dataGridViewManage.CurrentRow.Cells["quantityDataGridViewTextBoxColumn"].Value.ToString();
            string name = dataGridViewManage.CurrentRow.Cells["code_and_name"].Value.ToString();




            if (dataGridViewManage.Columns[e.ColumnIndex].Name == "Edit")
            {
                panelEdit.Visible = true;


                 id = it.Code;

                lblId.Text = id;
              

            }
            else if (dataGridViewManage.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do you want to Remove " + name + "?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "update Inventory set Status = 2 where Inventory_Id = " + it.Code+" and Quantity = "+it.quantity+" ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();



                    manageItems();


                    // activity logs begin

                    //    string desc = "Delete Customer Information";
                    //    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }
            }

        }// datagrid view btn click

        private void btnCancel_Click(object sender, EventArgs e) // panel cancel begin
        {
            txtQuantity.Clear();
            panelEdit.Visible = false;

        } // panel cancel end

        class nullExceptiom : Exception
        {
            public nullExceptiom(string str) : base(str) { }
        }
        class NumberFormatException : Exception
        {
            public NumberFormatException(string num) : base(num) { }
        }
        public string Quantity(string quan)
        {

            if (Regex.IsMatch(quan, regexClass.Intg))
            {
                 it.quantity= quan;

            }
            else
            {
                throw new NumberFormatException("put contact number correctly");
            }
            return it.quantity;
        }

        private void btnSave_Click(object sender, EventArgs e) // save click begin
        {
            try
            {
                if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {
                    it.quantity = Quantity(txtQuantity.Text);

                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "update Inventory set Quantity = quantity + "+txtQuantity.Text+" where Inventory_Id = "+id+" and Status = 1";
                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Stock was Updated", "Update  Stock", MessageBoxButtons.OK);

                    txtQuantity.Clear();

                    manageItems();
                    seestocks();

                    panelEdit.Hide();


                    // activity logs begin

                //   string desc = "Update Customer Information";
                  //  ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end

                }


            }

            catch (nullExceptiom ne)
            {
                MessageBox.Show(ne.Message);
            }
            // end of catch 

        } // save click end

    }// class end
}// cname space end
