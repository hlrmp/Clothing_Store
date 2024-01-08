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

namespace Clothing_Store.frms_adds
{
    public partial class frmAddSupplier : Form
    {
        public frmAddSupplier()
        {
            InitializeComponent();
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
        customerClass cs = new customerClass();
        userClass uc = new userClass();

        class nullExceptiom : Exception
        {
            public nullExceptiom(string str) : base(str) { }
        }
        class StringFormatException : Exception
        {
            public StringFormatException(string str) : base(str) { }
        }

        public string Fname(string FirstName)
        {
            if (Regex.IsMatch(FirstName, regexClass.letters))
            {

                FirstName = Char.ToUpper(FirstName[0]) + FirstName.Substring(1);

                uc.StaffFirstName = FirstName;
            }

            else
            {
                throw new StringFormatException("please enter your First Name Correctly");
            }

            return uc.StaffFirstName;
        }
        public string Lname(string LastName)
        {
            if (Regex.IsMatch(LastName, regexClass.letters))
            {
                LastName = Char.ToUpper(LastName[0]) + LastName.Substring(1);

                uc.StaffLastName = LastName;


            }
            else
            {
                throw new StringFormatException("please enter your Last Name Correctly");
            }

            return uc.StaffLastName;
        }
        public string Position(string position)
        {
            if (Regex.IsMatch(position, regexClass.letters))
            {

                position = Char.ToUpper(position[0]) + position.Substring(1);

                uc.StaffPosition = position;
            }

            else
            {
                throw new StringFormatException("please enter your Position Correctly");
            }

            return uc.StaffPosition;
        }
        public string Address(string address)
        {
            if (Regex.IsMatch(address, regexClass.mix))
            {

                uc.StaffAddress = address;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return uc.StaffAddress;
        }
        public string Email(string email)
        {
            if (Regex.IsMatch(email, regexClass.mix))
            {

                uc.staffEmail = email;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return uc.staffEmail;
        }

        class NumberFormatException : Exception
        {
            public NumberFormatException(string num) : base(num) { }
        }
        public string ContactNo(string contact)
        {

            if (Regex.IsMatch(contact, regexClass.numbers))
            {
                uc.StaffConntacNo = contact;

            }
            else
            {
                throw new NumberFormatException("put contact number correctly");
            }
            return uc.StaffConntacNo;
        }

        // reg ex end


        public void add() // add begin
        {

            try
            {
                if (string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text)
                    || string.IsNullOrEmpty(txtAddress.Text)
                    || string.IsNullOrEmpty(txtContactNo.Text) || string.IsNullOrEmpty(txtEmail.Text))
                {

                    throw new nullExceptiom("Please fill up the FF.");

                }
                else
                {


                    uc.StaffFirstName = Fname(txtFname.Text);
                    uc.StaffLastName = Lname(txtLname.Text);
                    uc.staffEmail = Email(txtEmail.Text);
                    uc.StaffAddress = Address(txtAddress.Text);
                    uc.StaffConntacNo = ContactNo(txtContactNo.Text);

                    string name = uc.StaffFirstName + " " + uc.StaffLastName;

                    SqlConnection con = new SqlConnection(ConnectionClass.conn);

                    string quer1 = "insert into Supplier ( Supplier_Name, Address, Contact_No, Email ,Status) values (  @Supplier_Name, @Address, @Position, @Contact_No, @Email,  @Status) ";
                    SqlCommand command = new SqlCommand(quer1, con);

                    command.Parameters.AddWithValue("@Supplier_Name", Name);
                    command.Parameters.AddWithValue("@Address", uc.StaffAddress);
                    command.Parameters.AddWithValue("@Position", uc.StaffPosition);
                    command.Parameters.AddWithValue("@Contact_No", uc.StaffConntacNo);
                    command.Parameters.AddWithValue("@Email", uc.staffEmail);
                    command.Parameters.AddWithValue("@Status", "1");
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("New Supplier Added succesfully" , "Supplier", MessageBoxButtons.OK);
                    // activity logs begin

                    string desc = "Add New Supplier";
                    ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end


                }// outer else end


            } // try
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
        }

        private void btnAdd_Click(object sender, EventArgs e)  // Add btn begin
        {
            add();

        } // Add btn end

        private void Cancel_Click(object sender, EventArgs e)  // cancel btn begin
        {
            this.Hide();
            txtAddress.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtFname.Clear();
            txtLname.Clear();
        } // cancel btn end

        private void btnHome_Click(object sender, EventArgs e)  // Home btn begin
        {
            dataGridViewHome.Show();

        } // Home btn end

    } // class end
} // name space end
