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
using static System.Net.Mime.MediaTypeNames;

namespace Clothing_Store
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
          
        }

            customerClass cs = new customerClass();

        private void btnAdd_Click(object sender, EventArgs e) // add button begin
        {

            add();  // add method       
                
        } // add buttonbend



        // exceptions for the customers
        class nullExceptiom : Exception
        {
            public nullExceptiom(string str) : base(str) { }
        }
        class StringFormatException : Exception
        {
            public StringFormatException(string str) : base(str) { }
        }
    
        public string Fname(string FirstName )
        {
            if (Regex.IsMatch(FirstName, regexClass.letters))
            {
               
                FirstName = Char.ToUpper(FirstName[0]) + FirstName.Substring(1);

                cs.First_Name = FirstName;
            }

            else
            {
                throw new StringFormatException("please enter your First Name Correctly");
            }

            return cs.First_Name;
        }
        public string Lname(string LastName)
        {
            if (Regex.IsMatch(LastName, regexClass.letters))
            {
                LastName = Char.ToUpper(LastName[0]) + LastName.Substring(1);
              
                cs.Last_Name = LastName;


            }
            else
            {
                throw new StringFormatException("please enter your Last Name Correctly");
            }

            return cs.Last_Name;
        }
        public string Address(string address)
        {
            if (Regex.IsMatch(address, regexClass.mix))
            {
             
                cs.address = address;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return cs.address;
        }
        public string delAddress(string deladdress)
        {
            if (Regex.IsMatch(deladdress, regexClass.mix))
            {

                cs.Delivery_Address = deladdress;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return cs.Delivery_Address;
        }
        public string Email(string email)
        {
            if (Regex.IsMatch(email, regexClass.mix))
            {

                cs.email = email;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return cs.email;
        }

        class NumberFormatException : Exception
        {
            public NumberFormatException(string num) : base(num) { }
        }
        public string ContactNo(string contact)
        {

            if (Regex.IsMatch(contact,regexClass.numbers))
            {
                cs.Contact_No = contact;

            }
            else
            {
                throw new NumberFormatException("put contact number correctly");
            }
            return cs.Contact_No;
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

            try
            {
                if (string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text) 
                    || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtDeliveryAddress.Text) 
                    || string.IsNullOrEmpty(txtContactNo.Text) || string.IsNullOrEmpty(txtEmail.Text))
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {
                    cs.First_Name = Fname(txtFname.Text);
                    cs.Last_Name = Lname(txtLname.Text);
                    cs.address = Address(txtAddress.Text);
                    cs.Delivery_Address = delAddress(txtDeliveryAddress.Text);
                    cs.Contact_No = ContactNo(txtContactNo.Text);
                    cs.email = Email(txtEmail.Text);



                    cnn.Open();
                    string quer1 = "insert into Customers( First_Name, Last_Name, Address, Delivery_Address, Contact_No, Email ,Status) values ( @First_Name,  @Last_Name, @Address, @Delivery_Address, @Contact_No, @Email,  @Status) ";
                    SqlCommand command = new SqlCommand(quer1, cnn);



                    command.Parameters.AddWithValue("@First_Name", cs.First_Name);
                    command.Parameters.AddWithValue("@Last_Name", cs.Last_Name);
                    command.Parameters.AddWithValue("@Address", cs.address);
                    command.Parameters.AddWithValue("@Delivery_Address", cs.Delivery_Address);
                    command.Parameters.AddWithValue("@Contact_No", cs.Contact_No);
                    command.Parameters.AddWithValue("@Email", cs.email);
                    command.Parameters.AddWithValue("@Status", "1");
                    command.ExecuteNonQuery();



                    MessageBox.Show("Suessfully added", "New Customer", MessageBoxButtons.OK);

                    this.Hide();

                    txtFname.Clear();
                    txtLname.Clear();
                    txtAddress.Clear();
                    txtContactNo.Clear();
                    txtEmail.Clear();
                    txtDeliveryAddress.Clear();

                }
                

            }
            catch (NumberFormatException ne)
            {
                MessageBox.Show(ne.Message);
            }
            catch (StringFormatException le)
            {
                MessageBox.Show(le.Message);
            }
            catch (nullExceptiom ne)
            {
                MessageBox.Show(ne.Message);
            }
            // end of catch 



        } // add cutomers 







    } // class end
} // name space end
