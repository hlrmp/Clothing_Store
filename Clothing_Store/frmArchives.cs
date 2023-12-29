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
    public partial class frmArchives : Form
    {
        public frmArchives()
        {
            InitializeComponent();
            counts();

        }

        private void frmArchives_Load(object sender, EventArgs e)  // frm load begin
        {
            this.dataGridViewMain.GridColor = Color.Navy;

            this.txtSearch.AutoSize = false;
            this.txtSearch.Size = new System.Drawing.Size(243, 21);

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
            dataGridViewMain.Visible = false;
            panelCounts.Visible = true;


        } // home btn end
        private void btnCustomers_Click(object sender, EventArgs e) // btn customer begin
        {
            datagridCustomer.Visible = true;
            dataGridViewMain.Visible = false;
            panelCounts.Visible = false;


            manageCustomers();
            

        } // btn customer end
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

        private void dataGridViewManage_CellContentClick(object sender, DataGridViewCellEventArgs e) // customers click manage begin
        {
            customerClass cs = new customerClass();
            cs.First_Name = datagridCustomer.CurrentRow.Cells["firstNameDataGridViewTextBoxColumn"].Value.ToString();
            cs.Last_Name = datagridCustomer.CurrentRow.Cells["lastNameDataGridViewTextBoxColumn"].Value.ToString();
            cs.Contact_No = datagridCustomer.CurrentRow.Cells["contactNoDataGridViewTextBoxColumn"].Value.ToString();
            cs.email = datagridCustomer.CurrentRow.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
            cs.address = datagridCustomer.CurrentRow.Cells["addressDataGridViewTextBoxColumn"].Value.ToString();
            cs.Delivery_Address = datagridCustomer.CurrentRow.Cells["deliveryAddressDataGridViewTextBoxColumn"].Value.ToString();


            if (datagridCustomer.Columns[e.ColumnIndex].Name == "Restore")
            {
                DialogResult result = MessageBox.Show("Do you want to Restore " + cs.First_Name + " " + cs.Last_Name + "?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Customers SET Status = 1 WHERE First_Name = '" + cs.First_Name + "' and  Last_Name = '" + cs.Last_Name + "'  " + "and Contact_No = '" + cs.Contact_No + "'  and Email = '" + cs.email + "' and  Address = '" + cs.address + "' and Delivery_Address = '" + cs.Delivery_Address + "' ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();


                    manageCustomers();
                    datagridCustomer.Refresh();


                    // activity logs begin

                    //  string desc = "Restore Customer Information";
                    //  ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
             

            }
            else
            {

            }

        } // customers click manage end

        private void timer1_Tick(object sender, EventArgs e) // timer begin
        {

            /*  manageCustomers();
              datagridCustomer.Refresh();
            */

            counts();

        } // timer end
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

        } // count end


    }// class end
} // name space end
