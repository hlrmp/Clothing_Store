using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Store
{
    public partial class FrmAddDelivery : Form
    {
        public FrmAddDelivery()
        {
            InitializeComponent();
         //   cname();
            Oid();
        }
       
        private void btnAdd_Click(object sender, EventArgs e) // add button begin
        {
            try
            {
                add();
            }
            catch (nullExceptiom ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

        } //  add button end
        class nullExceptiom : Exception
        {
            public nullExceptiom(string str) : base(str) { }
        }
        class NumberFormatException : Exception
        {
            public NumberFormatException(string num) : base(num) { }
        }
        public string ContactNo(string contact)
        {

            if (Regex.IsMatch(contact, regexClass.numbers))
            {
               cont = contact;

            }
            else
            {
                throw new NumberFormatException("put contact number correctly");
            }
            return cont;
        }
        string cont;
        public void add()
        {
            if (cbOrdersId.Text == "" || txtxCustomerName.Text == "" || txtCustomerContact.Text == "" || txtDeliveryAddress.Text == "" || txtEmail.Text == ""
                   || txtRider.Text == "" || txtRiderContact.Text == "")
            {
               throw new nullExceptiom("Please fill up the FF.");
            }
            else
            {
                string desc = txtComany.Text + " - Rider: " + txtRider.Text + "_Contact " + txtRiderContact.Text;
                cont = ContactNo(txtRiderContact.Text);

                SqlConnection con = new SqlConnection(ConnectionClass.conn);


                string up = "update Orders set Status = 3 where Order_Id = "+cbOrdersId.Text+" ";
                SqlCommand command1 = new SqlCommand(up, con);
                con.Open();
                command1.ExecuteNonQuery();
                con.Close();


                string ins = "insert into Delivery (Customer_Id,Order_Id,Status,Date,Description) values (@Customer_Id,@Order_Id,@Status,getDate(),@Description) ";
                SqlCommand command = new SqlCommand(ins, con);



                con.Open();

                
                command.Parameters.AddWithValue("@Customer_Id", customerId);
                command.Parameters.AddWithValue("@Order_Id", cbOrdersId.Text);
                command.Parameters.AddWithValue("@Description", desc);
                command.Parameters.AddWithValue("@Status", "1");
                command.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Succesfully added", "Delivery", MessageBoxButtons.OK);

                // activity logs begin

                //     string desc = " Inventory Changes becuse of Order Added ";
                //     ConnectionClass.activity(frmLogin.userId, desc);

                // activity logs end
            }
        }
        protected override void OnPaint(PaintEventArgs e)    // border color begin
        {
            //  base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid,
                  Color.Teal, 10, ButtonBorderStyle.Solid);
        }  // border color end

        private void btnCancel_Click(object sender, EventArgs e) // cancel button begin
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to Cancel? ", "Close", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();

            }
            else
            {

            }

        } // cancel button end

     

        string customerId;
        public void uid()  //  uid begin
        {
          
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string n = "SELECT Customer_Id FROM Customers  WHERE CONCAT(TRIM(Customers.First_Name), ' ', TRIM(Customers.Last_Name)) LIKE '" + txtxCustomerName.Text + "' and Status = 1";

            con.Open();
            SqlCommand command;
            command = new SqlCommand(n, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                customerId = reader[0].ToString();
            }

            con.Close();

        } // uid end
        public void info()
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string n = "select c.Customer_Id, c.Contact_No, c.Delivery_Address, c.Email ,concat(c.First_Name ,' ', c.Last_Name ) as Name, o.Order_Id , o.Quantity ,p.Product_Name , p.Product_Id from Customers as c inner join Orders as o on c.Customer_Id = o.Customer_Id inner join Products as p on p.Product_Id = o.Product_Id where o.Status = 1 and o.Order_Id = " + cbOrdersId.Text+" ";

            con.Open();
            SqlCommand command;
            command = new SqlCommand(n, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                txtCustomerContact.Text = reader[1].ToString();
                txtDeliveryAddress.Text = reader[2].ToString();
                txtEmail.Text = reader[3].ToString();
                txtxCustomerName.Text = reader[4].ToString();

                uid();


            }

            con.Close();
        }

        public void Oid()
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string ids = "select * from Orders where status = 1";
            SqlDataAdapter adapt = new SqlDataAdapter(ids, con);

            DataTable dataTable = new DataTable();
            BindingSource bindingSource = new BindingSource();
            dataTable.Clear();
            adapt.Fill(dataTable);
            bindingSource.DataSource = dataTable;

            cbOrdersId.DataSource = dataTable;
            cbOrdersId.DisplayMember = "Order_Id"; ;
            con.Close();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            info();
        }

        private void FrmAddDelivery_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = ( 1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

       
    } // class end
} // namespace  end
