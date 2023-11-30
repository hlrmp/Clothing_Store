﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clothing_Store
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            seecustomers(); // see cutomers on the datagrid - load form
            total(); // total customers string lbltotal
        }

        FrmAddCustomer fadd = new FrmAddCustomer();
        private void btnAdd_Click(object sender, EventArgs e)  // add buton begin
        {
            fadd.ShowDialog();
        } //add button end

        private void btnHomeCustomers_Click(object sender, EventArgs e) // home button begin
        {
            seecustomers();  // see cutomers on the datagrid - home button
            dataGridViewManage.Hide();

        } //  home button end

        public void seecustomers() // see customers begin - datagrid
        {   
      
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
          
               
                string sj = "select * from customers";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);
              
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;
           
        } // see customers end - datagrid

        public void manageCustomers() // manage cusstomers begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select * from customers";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewManage.DataSource = table;

        } // manage cusstomers end - datagrid

        public void seetotalcustomers()   // total customers begin - datagrid
        {
          
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select count(*)  AS 'Total Customers' from customers";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = table;

        } // total customers end - datagrid

        public void total()  // total customers - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*)  AS 'Total Customers' from customers";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lbltotal.Text = reader[0].ToString();  // - total numbers

        }  // total customers - string

        private void btnTotal_Click(object sender, EventArgs e) // total button begin
        {
            seetotalcustomers(); // see numbers of customers - total 


        } // total  button end

        private void btnManage_Click(object sender, EventArgs e) // manage button beginn
        {
            dataGridViewManage.Show();
            manageCustomers();

        } // mannage button end

        public void search() // search method begin
        {
            SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                                     
            cn.Open();
            string sch = txtSearch.Text;

            string query = "Select *  from Customers where First_Name LIKE '" + sch + '%' + "'   ";

            SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                    SqlCommand command = new SqlCommand();
                    command.CommandText = query;
                    command.Parameters.Clear();

                    DataTable table = new DataTable();
                    adapt.Fill(table);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DataSource = table;


            cn.Close();

        }  // search method end

        private void lblsearch_Click(object sender, EventArgs e)  // searc click begin
        {
            search();

        }  // search click end


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)  // search enter begin 
        {
            search();

        }  // search enter end

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)// text box mouse click begin
        {
            dataGridViewManage.Hide();

        } // text box mouse click end





    } // class end
} // namespace end
