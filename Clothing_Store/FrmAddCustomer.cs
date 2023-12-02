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

        /*    string sj = "select count(*)  AS 'Total Customers' from customers";
            cnn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(sj, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            n = Convert.ToInt32(reader[0]) +1 ;  // - total numbers +1 


            cnn.Close();*/

            customerClass cs = new customerClass();

            cs.First_Name = txtFname.Text;  
            cs.Last_Name = txtLname.Text;
            cs.address = txtAddress.Text;
            cs.DelAddress = txtDeliveryAddress.Text;
            cs.Contact_No = txtContactNo.Text;
            cs.email = txtEmail.Text;
            


            cnn.Open();
            string quer1 = "insert into Customers( First_Name, Last_Name, Address, Delibvery_Address, Contact_No, Email ,Status) values ( @First_Name,  @Last_Name, @Address, @Delivery_Address, @Contact_No, @Email,  @Status) ";
            SqlCommand command = new SqlCommand(quer1, cnn);



            command.Parameters.AddWithValue("@First_Name", cs.First_Name);
            command.Parameters.AddWithValue("@Last_Name", cs.Last_Name);
            command.Parameters.AddWithValue("@Address", cs.address);
            command.Parameters.AddWithValue("@Delivery_Address", cs.DelAddress);
            command.Parameters.AddWithValue("@Contact_No", cs.Contact_No);
            command.Parameters.AddWithValue("@Email", cs.email);
            command.Parameters.AddWithValue("@Status", "1");
            command.ExecuteNonQuery();


        } // add cutomers 




    } // class end
} // name space end
