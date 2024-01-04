using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Clothing_Store
{
    public partial class FrmItems : Form
    {
        public FrmItems()
        {
            InitializeComponent();
            seeTotalItems();
            Total();
            filt();
        }

     

        private void lblsearch_Click(object sender, EventArgs e) // lblsearch begin
        {
            sc();

            datagridItems.Visible = true;
            dataGridViewManage.Visible = false;

            panelEdit.Visible = false;

        } // lbl search end

        private bool buttonMensWasClicked = false;
        private bool buttonWomensWasClicked = false;
        private bool buttonUnisexWasClicked = false;
        private void btnMens_Click(object sender, EventArgs e) // btn mens begin
        {
            buttonMensWasClicked = true;
            buttonWomensWasClicked = false;
            buttonUnisexWasClicked = false;

            datagridItems.Visible = true;
            dataGridViewManage.Visible = false;

            panelEdit.Visible = false;

            seeItemsMens();
            

        } // btn mens  end
        private void btnWomens_Click(object sender, EventArgs e)  // btn womens begin
        {

            buttonMensWasClicked = false;
            buttonWomensWasClicked = true;
            buttonUnisexWasClicked = false;

            datagridItems.Visible = true;
            dataGridViewManage.Visible = false;

            panelEdit.Visible = false;

            seeItemsWomens();


        } // btn womens end 

        private void btnUnisex_Click(object sender, EventArgs e)   // btn unisex begin
        {

            buttonMensWasClicked = false;
            buttonWomensWasClicked = false;
            buttonUnisexWasClicked = true;

            datagridItems.Visible = true;
            dataGridViewManage.Visible = false;

            panelEdit.Visible = false;

            seeItemsUnisex();

        }  // btn unisex end
        private void btnHome_Click(object sender, EventArgs e) // btn home begin
        {
            buttonMensWasClicked = false;
            buttonWomensWasClicked = false;
            buttonUnisexWasClicked = false;

            datagridItems.Visible = true;
            dataGridViewManage.Visible = false;

            panelEdit.Visible = false;

            seeTotalItems();

        } // btn home end
        public void sc()      // searching method  begin
        {    

            if (buttonMensWasClicked)
            {
                searchInMens();
            }
            else if (buttonWomensWasClicked)
            {
                searchInWomens();
            }
            else if (buttonUnisexWasClicked)
            {
                searchInUnisex();
            }
            else
            {
                search();
            }
     

        }   // searching method end




        public void filt()  // cb filter begin
        {
            ArrayList array = new ArrayList();
            array.Add("Price");
            array.Add("Name");
            array.Add("Size");
            array.Add("Type");
            array.Add("Color");

            foreach (string op in array)
            {
                cbFilter.Items.Add(op);
            }
        }  // cb filter end

        private void FrmItems_Load(object sender, EventArgs e)  // frrm load begin
        {
            // btnHome.BackColor = Color.Blue;

            this.txtSearch.AutoSize = false;
            this.txtSearch.Size = new System.Drawing.Size(243, 21);

            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        }  // frm load end

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e) // enter on search
        {
            sc();


            datagridItems.Visible = true;
            dataGridViewManage.Visible = false;

        } // enter on search

        public void seeItemsMens() // see mens items begin - datagrid
        {

            SqlConnection connection = new SqlConnection(ConnectionClass.conn);
            connection.Open();

            string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size FROM Products where Category = 'mens' and Status = 1 ";
            SqlDataAdapter data = new SqlDataAdapter(quer, connection);
            DataTable table = new DataTable();

            data.Fill(table);

            datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridItems.DataSource = table;

            connection.Close();

            string total = "select count(*) AS 'Total Products' from Products where Category = 'mens' and Status = 1";
            connection.Open();

            SqlCommand command;
            command = new SqlCommand(total, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalNumber.Text = reader[0].ToString();

            connection.Close();

    

        } // see mens items end - datagrid

        public void seeItemsWomens() // see womens items begin - datagrid
        {

            SqlConnection connection = new SqlConnection(ConnectionClass.conn);
            connection.Open();

            string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price ,Color, Size FROM Products where Category = 'womens' and status = 1";
            SqlDataAdapter data = new SqlDataAdapter(quer, connection);
            DataTable table = new DataTable();

            data.Fill(table);

            datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridItems.DataSource = table;

            connection.Close();

            string total = "select count(*) AS 'Total Products' from Products where Category = 'womens' and Status = 1";
            connection.Open();

            SqlCommand command;
            command = new SqlCommand(total, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalNumber.Text = reader[0].ToString();

            connection.Close();



        } // see womens items end - datagrid

        public void seeItemsUnisex() // see unisex items begin - datagrid
        {

            SqlConnection connection = new SqlConnection(ConnectionClass.conn);
            connection.Open();

            string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price ,Color, Size FROM Products where Category = 'unisex' and Status = 1 ";
            SqlDataAdapter data = new SqlDataAdapter(quer, connection);
            DataTable table = new DataTable();

            data.Fill(table);

            datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridItems.DataSource = table;

            connection.Close();


            string total = "select count(*) AS 'Total Products' from Products where Category = 'unisex' and Status = 1";
            connection.Open();

            SqlCommand command;
            command = new SqlCommand(total, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalNumber.Text = reader[0].ToString();

            connection.Close();

        } // see Unisex items end - datagrid

        public void seeTotalItems() // see all items begin - datagrid
        {

            SqlConnection connection = new SqlConnection(ConnectionClass.conn);
            connection.Open();

            string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price ,Color, Size FROM Products where Status = 1";
            SqlDataAdapter data = new SqlDataAdapter(quer, connection);
            DataTable table = new DataTable();

            data.Fill(table);

            datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridItems.DataSource = table;

            connection.Close();

          
          

        } // see all items end - datagrid
        public void Total() // see all items begin - label
        {

            SqlConnection connection = new SqlConnection(ConnectionClass.conn);

            string total = "select count(*) AS 'Total Products' from Products where Status = 1";
            connection.Open();

            SqlCommand command;
            command = new SqlCommand(total, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalNumber.Text = reader[0].ToString();

            connection.Close();

        } // see all items end - label


        public void search() // search method begin
        {
            SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

            if (cbFilter.Text == "Name")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name',  Type, Category , Price , Color,Size  from Products where Product_Name LIKE '" + sch + '%' + "' and Status = 1  ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();
            }          
            else if (cbFilter.Text == "Size")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Size LIKE '" + sch + '%' + "' and Status = 1  ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Type")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Type LIKE '" + sch + '%' + "'  and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Price")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Price LIKE '" + sch + '%' + "'  and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Color")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Color LIKE '" + sch + '%' + "' and Status = 1  ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Product_Name LIKE '" + sch + '%' + "' and Status = 1  ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();
            }




        }  // search method end

      public void searchInMens()   // mens search
        {
            SqlConnection cn = new SqlConnection(ConnectionClass.conn);

            cn.Open();

            if (cbFilter.Text == "Name")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'mens' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();
            }
            else if (cbFilter.Text == "Size")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Size LIKE '" + sch + '%' + "' and Category = 'mens' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Type")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Type LIKE '" + sch + '%' + "' and Category = 'mens' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Price")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Price LIKE '" + sch + '%' + "' and Category = 'mens'  and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Color")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Color LIKE '" + sch + '%' + "' and Category = 'mens' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'mens' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();
            }

        } // mens search

        public void searchInWomens()   // womens search
        {
            SqlConnection cn = new SqlConnection(ConnectionClass.conn);

            cn.Open();

           
            if (cbFilter.Text == "Name")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'womens' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Size")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Size LIKE '" + sch + '%' + "' and Category = 'womens' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Type")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Type LIKE '" + sch + '%' + "' and Category = 'womens' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Price")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Price LIKE '" + sch + '%' + "' and Category = 'womens' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Color")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Color LIKE '" + sch + '%' + "' and Category = 'womens' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }

            else
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'womens' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }

        } // womens search


        public void searchInUnisex()   // unisex search
        {
            SqlConnection cn = new SqlConnection(ConnectionClass.conn);

            cn.Open();


            if (cbFilter.Text == "Name")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'unisex' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Size")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Size LIKE '" + sch + '%' + "' and Category = 'unisex'  and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Type")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Type LIKE '" + sch + '%' + "' and Category = 'unisex' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Price")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Price LIKE '" + sch + '%' + "' and Category = 'unisex' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }
            else if (cbFilter.Text == "Color")
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Color LIKE '" + sch + '%' + "' and Category = 'unisex' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }

            else
            {
                string sch = txtSearch.Text;
                string query = "Select Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'unisex' and Status = 1 ";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridItems.DataSource = table;


                cn.Close();

            }

        } // unisex search

        private void label1_Click(object sender, EventArgs e)// label search Begin
        {
            sc();
        }// label search end

        private void btnManage_Click(object sender, EventArgs e) // btn manage begin
        {

       
            datagridItems.Visible = false;
            dataGridViewManage.Visible = true;

            panelEdit.Visible = false;

            manage();



        }// bnt manage end


        public void manage()
        {

            if (buttonMensWasClicked)
            {
                SqlConnection connection = new SqlConnection(ConnectionClass.conn);
                connection.Open();

                string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size FROM Products where Category = 'mens' and Status = 1";
                SqlDataAdapter data = new SqlDataAdapter(quer, connection);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewManage.DataSource = table;

                connection.Close();

               
               
            }
            else if (buttonWomensWasClicked)
            {
                SqlConnection connection = new SqlConnection(ConnectionClass.conn);
                connection.Open();

                string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price ,Color, Size FROM Products where Category = 'womens' and Status = 1";
                SqlDataAdapter data = new SqlDataAdapter(quer, connection);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewManage.DataSource = table;

                connection.Close();

               
            }
            else if (buttonUnisexWasClicked)
            {
                SqlConnection connection = new SqlConnection(ConnectionClass.conn);
                connection.Open();

                string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price ,Color, Size FROM Products where Category = 'unisex' and Status = 1";
                SqlDataAdapter data = new SqlDataAdapter(quer, connection);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewManage.DataSource = table;

                connection.Close();
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConnectionClass.conn);
                connection.Open();

                string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price ,Color, Size FROM Products where Status = 1";
                SqlDataAdapter data = new SqlDataAdapter(quer, connection);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewManage.DataSource = table;

                connection.Close();
            }
         
            
        }

        string itemid;
        itemsClass it = new itemsClass();

        private void dataGridViewManage_CellContentClick(object sender, DataGridViewCellEventArgs e) // manage click begin
        {
           

            it.Code = dataGridViewManage.CurrentRow.Cells["ItemCode"].Value.ToString();
            it.Name = dataGridViewManage.CurrentRow.Cells["Item_Name"].Value.ToString();
            it.price = dataGridViewManage.CurrentRow.Cells["Product_Price"].Value.ToString();

            if (dataGridViewManage.Columns[e.ColumnIndex].Name == "Edit")
            {
                panelEdit.Visible = true;


                itemid = it.Code;

                lblId.Text = itemid;
                txtOldPrice.Text = it.price;

            }
            else if (dataGridViewManage.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do you want to Remove " + it.Name + "?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "update Products set Status = 2 where Product_Id = " + it.Code  +" ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    manage();

                    // activity logs begin

                    string desc = "Delete Item " + it.Code ;
                    //    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }
            }
        } // manage click end

        private void btnCancel_Click(object sender, EventArgs e) // cancel begin
        {
            panelEdit.Hide();

            txtNewPrice.Clear();
            txtOldPrice.Clear();

        } // cancel end

        private void btnSave_Click(object sender, EventArgs e) // save edit begin
        {
          

            SqlConnection cn = new SqlConnection(ConnectionClass.conn);
            cn.Open();

            string quer = "update Products set Price = "+txtNewPrice.Text+" Where Product_Id = "+it.Code+" ";
            SqlCommand command = new SqlCommand(quer, cn);
            command.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Item was Updated", "Update  Item", MessageBoxButtons.OK);

           

            txtNewPrice.Clear();
            txtOldPrice.Clear();

            panelEdit.Hide();

            manage();
        

            // activity logs begin

            string desc = "Item Price updated  " + it.Code;
            //  ConnectionClass.activity(frmLogin.userId, desc);

            // activity logs end


           


        } // save edit end

        private void timer1_Tick(object sender, EventArgs e) // timer begin
        {
            Total();


        } // timer end


    } // class end
} // name space end 
