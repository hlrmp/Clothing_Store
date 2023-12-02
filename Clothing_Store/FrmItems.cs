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
    public partial class FrmItems : Form
    {
        public FrmItems()
        {
            InitializeComponent();
            filter();
            seeTotalItems();
        }

        private void btnFilter_Click(object sender, EventArgs e) // button filter begin
        {
            panelFilter.Show();

        } // filte button  end

        private void lblsearch_Click(object sender, EventArgs e) // lblsearch begin
        {
            sc();

        } // lbl search end

        private bool buttonMensWasClicked = false;
        private bool buttonWomensWasClicked = false;
        private bool buttonUnisexWasClicked = false;
        private void btnMens_Click(object sender, EventArgs e) // btn mens begin
        {
            buttonMensWasClicked = true;
            buttonWomensWasClicked = false;
            buttonUnisexWasClicked = false;

            btnHome.BackColor = Color.Teal;
            btnMens.BackColor = Color.Blue;
            btnWomens.BackColor = Color.Teal;
            btnUnisex.BackColor = Color.Teal;

            seeItemsMens();
            

        } // btn mens  end
        private void btnWomens_Click(object sender, EventArgs e)  // btn womens begin
        {

            buttonMensWasClicked = false;
            buttonWomensWasClicked = true;
            buttonUnisexWasClicked = false;

            btnHome.BackColor = Color.Teal;
            btnMens.BackColor = Color.Teal;
            btnWomens.BackColor = Color.Blue;
            btnUnisex.BackColor = Color.Teal;

            seeItemsWomens();


        } // btn womens end 

        private void btnUnisex_Click(object sender, EventArgs e)   // btn unisex begin
        {

            buttonMensWasClicked = false;
            buttonWomensWasClicked = false;
            buttonUnisexWasClicked = true;

            btnHome.BackColor = Color.Teal;
            btnMens.BackColor = Color.Teal;
            btnWomens.BackColor = Color.Teal;
            btnUnisex.BackColor = Color.Blue;

            seeItemsUnisex();

        }  // btn unisex end
        private void btnHome_Click(object sender, EventArgs e) // btn home begin
        {
            buttonMensWasClicked = false;
            buttonWomensWasClicked = false;
            buttonUnisexWasClicked = false;
            
            btnHome.BackColor = Color.Blue;
            btnMens.BackColor = Color.Teal;
            btnWomens.BackColor = Color.Teal;
            btnUnisex.BackColor = Color.Teal;

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
            panelFilter.Hide();

        }   // searching method end

        public void filter()   // filter method begin
        {
            Boolean name =  checkBoxName.Checked;
            Boolean price = checkBoxPrice.Checked;
            Boolean size = checkBoxSize.Checked;

            if (name == true)
            {
                checkBoxPrice.Enabled = false;
                checkBoxPrice.Checked = false;
                checkBoxSize.Checked = false;   
            }
            else if (price == true)
            {
                checkBoxName.Checked = false;
                checkBoxSize.Checked = false;
            }
            else if (size == true)
            {
                checkBoxName.Checked = false;
                checkBoxPrice.Checked = false;
            }

        }  // filter method end

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e) // enter on search
        {
            sc();

        } // enter on search

        public void seeItemsMens() // see mens items begin - datagrid
        {

            SqlConnection connection = new SqlConnection(ConnectionClass.conn);
            connection.Open();

            string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Category , Price , Size FROM Products where Category = 'mens'";
            SqlDataAdapter data = new SqlDataAdapter(quer, connection);
            DataTable table = new DataTable();

            data.Fill(table);

            datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridItems.DataSource = table;

            connection.Close();

            string total = "select count(*) AS 'Total Products' from Products where Category = 'mens'";
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

            string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Category , Price , Size FROM Products where Category = 'womens'";
            SqlDataAdapter data = new SqlDataAdapter(quer, connection);
            DataTable table = new DataTable();

            data.Fill(table);

            datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridItems.DataSource = table;

            connection.Close();

            string total = "select count(*) AS 'Total Products' from Products where Category = 'womens'";
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

            string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Category , Price , Size FROM Products where Category = 'unisex'";
            SqlDataAdapter data = new SqlDataAdapter(quer, connection);
            DataTable table = new DataTable();

            data.Fill(table);

            datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridItems.DataSource = table;

            connection.Close();


            string total = "select count(*) AS 'Total Products' from Products where Category = 'unisex'";
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

            string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Category , Price , Size FROM Products";
            SqlDataAdapter data = new SqlDataAdapter(quer, connection);
            DataTable table = new DataTable();

            data.Fill(table);

            datagridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridItems.DataSource = table;

            connection.Close();

          
            string total = "select count(*) AS 'Total Products' from Products";
            connection.Open();
                
            SqlCommand command;
            command = new SqlCommand(total, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalNumber.Text = reader[0].ToString();

            connection.Close();

        } // see all items end - datagrid


        public void search() // search method begin
        {
            SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

            if (checkBoxName.Checked == false && checkBoxSize.Checked == false && checkBoxPrice.Checked == false)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Product_Name LIKE '" + sch + '%' + "'   ";

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

            else if(checkBoxName.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Product_Name LIKE '" + sch + '%' + "'   ";

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
            else if (checkBoxSize.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Size LIKE '" + sch + '%' + "'   ";

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
            else if (checkBoxPrice.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Price LIKE '" + sch + '%' + "'   ";

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

            if (checkBoxName.Checked == false && checkBoxSize.Checked == false && checkBoxPrice.Checked == false)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'mens'  ";

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

            else if (checkBoxName.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'mens'  ";

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
            else if (checkBoxSize.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Size LIKE '" + sch + '%' + "' and Category = 'mens'  ";

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
            else if (checkBoxPrice.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Price LIKE '" + sch + '%' + "' and Category = 'mens'  ";

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

            if (checkBoxName.Checked == false && checkBoxSize.Checked == false && checkBoxPrice.Checked == false)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'womens'  ";

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

            else if (checkBoxName.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'womens'  ";

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
            else if (checkBoxSize.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Size LIKE '" + sch + '%' + "' and Category = 'womens'  ";

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
            else if (checkBoxPrice.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Price LIKE '" + sch + '%' + "' and Category = 'womens'  ";

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

            if (checkBoxName.Checked == false && checkBoxSize.Checked == false && checkBoxPrice.Checked == false)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'unisex'  ";

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

            else if (checkBoxName.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Product_Name LIKE '" + sch + '%' + "' and Category = 'unisex'  ";

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
            else if (checkBoxSize.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Size LIKE '" + sch + '%' + "' and Category = 'unisex'  ";

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
            else if (checkBoxPrice.Checked == true)
            {
                string sch = txtSearch.Text;
                string query = "Select *  from Products where Price LIKE '" + sch + '%' + "' and Category = 'unisex'  ";

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


    } // class end
} // name space end 
