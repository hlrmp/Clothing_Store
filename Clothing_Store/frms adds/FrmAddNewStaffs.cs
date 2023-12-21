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
    public partial class FrmAddNewStaffs : Form
    {
        public FrmAddNewStaffs()
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

        private void FrmAddNewStaffs_Load(object sender, EventArgs e)
        {

        }

        customerClass cs = new customerClass();

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
                throw new StringFormatException("please enter your First Name Correctly");
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

        private void Cancel_Click(object sender, EventArgs e)  // cancel button begin
        { 
           

            DialogResult dialogResult = MessageBox.Show("Are you sure to Cancel? ", "Close", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();

                txtFname.Clear();
                txtLname.Clear();
                txtAddress.Clear();
                txtContactNo.Clear();
                txtAddress.Clear();
            }
            else
            {

            }
        } // cancel button end


        // class instance
        userClass uc = new userClass();
        FrmAddUser addu = new FrmAddUser();
        private void btnAdd_Click(object sender, EventArgs e) // add button begin 
        {
            add();


        } // add button end
        public void add() // add begin
        {

            try
            {
                if (string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text)
                    || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(cbPosition.Text)
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
                    uc.StaffPosition = Position(cbPosition.Text);

                    SqlConnection con = new SqlConnection(ConnectionClass.conn);

                    string quer1 = "insert into Staffs ( First_Name, Last_Name, Address, Position, Contact_No, Email ,Status) values ( @First_Name,  @Last_Name, @Address, @Position, @Contact_No, @Email,  @Status) ";
                    SqlCommand command = new SqlCommand(quer1, con);



                    command.Parameters.AddWithValue("@First_Name", uc.StaffFirstName);
                    command.Parameters.AddWithValue("@Last_Name", uc.StaffLastName);
                    command.Parameters.AddWithValue("@Address", uc.StaffAddress);
                    command.Parameters.AddWithValue("@Position", uc.StaffPosition);
                    command.Parameters.AddWithValue("@Contact_No", uc.StaffConntacNo);
                    command.Parameters.AddWithValue("@Email", uc.staffEmail);
                    command.Parameters.AddWithValue("@Status", "1");
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    

                    // activity logs begin

                       string desc = "Add New Staff";
                       ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end



                    DialogResult dialogResult = MessageBox.Show("Doyou wnat to Add this New Staff", "Confirm", MessageBoxButtons.YesNo);

                            if (dialogResult == DialogResult.Yes) // outer if begin
                            {

                                    MessageBox.Show("Staff sucessfully added", "Confirmation", MessageBoxButtons.OK);





                                     DialogResult dialogResult1 = MessageBox.Show("Doyou wnat to make an account for this Staff  ", "Confirm", MessageBoxButtons.YesNo);

                                            if (dialogResult1 == DialogResult.Yes) // inner if begin
                                            {
                                                        addu.ShowDialog();
                                                        this.Hide();

                                            } // inner if end
                                            else // inner else begin

                                            {
                                                     



                                            } // inner else


                            }  
                            else 
                            {

                            }


                   

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


        } // add end



    } // class end
} // namespace end




