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
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) // add button begin
        {

            add();  // add method 


            n++;

           
            MessageBox.Show("Suessfully added" , "New Customer",MessageBoxButtons.OK);
            this.Hide();
                
        } // add buttonbend
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

                txtFname.Clear();
                txtMname.Clear();
                txtLname.Clear();
                txtAddress.Clear();
                txtContactNo.Clear();
                txtEmail.Clear();
                txtDeliveryAddress.Clear();

            }
            else
            {

            }
        } // cancel button end


           int n;
 
        public void add()  // add customers 
        {
            SqlConnection cnn = new SqlConnection(ConnectionClass.conn);

            string sj = "select count(*)  AS 'Total Customers' from customers";
            cnn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(sj, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            n = Convert.ToInt32(reader[0]) +1 ;  // - total numbers +1 


            cnn.Close();

            string fname = txtFname.Text;
            string mname = " ";
            mname = txtMname.Text;
            string lname = txtLname.Text;
            string add = txtAddress.Text;
            string deladd = txtDeliveryAddress.Text;
            string con = txtContactNo.Text;
            string em = txtEmail.Text;
            


            cnn.Open();
            string quer1 = "insert into Customers( Customer_Id, First_Name, Middle_Name, Last_Name, Address, Delivery_Address, Contact_No, Email) values ( @Customer_Id, @First_Name, @Middle_Name, @Last_Name, @Address, @Delivery_Address, @Contact_No, @Email) ";
            SqlCommand command = new SqlCommand(quer1, cnn);



            command.Parameters.AddWithValue("@Customer_Id", n);
            command.Parameters.AddWithValue("@First_Name", fname);
            command.Parameters.AddWithValue("@Middle_Name", mname);
            command.Parameters.AddWithValue("@Last_Name", lname);
            command.Parameters.AddWithValue("@Address", add);
            command.Parameters.AddWithValue("@Delivery_Address", deladd);
            command.Parameters.AddWithValue("@Contact_No", con);
            command.Parameters.AddWithValue("@Email", em);

            command.ExecuteNonQuery();


        } // add cutomers 




    } // class end
} // name space end
