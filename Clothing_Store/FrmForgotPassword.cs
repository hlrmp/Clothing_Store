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
using System.Xml.Linq;

namespace Clothing_Store
{
    public partial class FrmForgotPassword : Form
    {
        public FrmForgotPassword()
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

    
        private void btnConfirrmChanges_Click(object sender, EventArgs e)// btn Confrim Edit pannel begin
        {
            DialogResult dl = MessageBox.Show("Do you want to save changes ?", "Confirm", MessageBoxButtons.OKCancel);

            if (dl == DialogResult.OK)
            {
                saveInfo();
              
               
            }
            else
            {

            }

        }// btn Confirm Edit pannel end

        private void btnCancelChanges_Click(object sender, EventArgs e)// btn cancel Edit pannel begin
        {
            txtUserName.Clear();
            txtPassword.Clear();

            btnCancel.Enabled = true;
            btnConfirm.Enabled = true;
            panelEdit.Visible = false;

        }// btn cancel Edit pannel end
        private void btnConfirm_Click(object sender, EventArgs e)// btn confirm MAin begin
        {
            DialogResult dl = MessageBox.Show("Do you want to continue ? \n Make sure that you enter Correct information  ","Account Recovery", MessageBoxButtons.YesNo);
        
            if (dl == DialogResult.Yes)
            {
                search();
            }
            else
            {

            } 
           

        } // btn confirm MAin end

        private void btnCancel_Click(object sender, EventArgs e)  // btn Cancel MAin begin
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtAdd.Clear();
            txtContact.Clear();
            txtPosition.Clear();

            this.Hide();
            frmLogin fl = new  frmLogin();
            fl.Show();

        } // btn Cancel MAin end

    

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
        private void saveInfo() // save info begin
        {

            try
            {
                if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUserName.Text))
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {
                    

                    uc.username = txtUserName.Text;
                    uc.userpas = txtPassword.Text;

                    updateuser(uc.username, uc.userpas);

                    MessageBox.Show("User information was Updated Procede to log in", "Update  User", MessageBoxButtons.OK);

                    txtUserName.Clear();
                    txtPassword.Clear();

                    panelEdit.Hide();
                    this.Hide();

                    btnCancel.Enabled = true;
                    btnConfirm.Enabled = true;
                    // activity logs begin

                    string desc = "Update User Information by: User - " + uc.uid + " - " + uc.username;
                    ConnectionClass.activity(int.Parse(uc.uid), desc);

                    // activity logs end

                }


            }
            catch (nullExceptiom ne)
            {
                MessageBox.Show(ne.Message);
            }// end of catch 

        } // save info end
        public bool updateuser(string UserName, string Pass) // update the User info begin
        {

            SqlConnection con = new SqlConnection(ConnectionClass.conn);
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Parameters.Clear();
            sqlCommand.Connection = con;
            sqlCommand.CommandText = "Update  Users Set User_Name = @User_Name , Password = @Password  where User_Id = " + uc.uid + " ";

            sqlCommand.Parameters.Add("@User_Name", UserName);
            sqlCommand.Parameters.Add("@Password", Pass);


            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

            return true;
        } // update the user info end

       
        public void search() // search begin
        {

            try
            {
                if (string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text ) || string.IsNullOrEmpty(txtContact.Text) ||
                    string.IsNullOrEmpty(txtAdd.Text) || string.IsNullOrEmpty(txtPosition.Text))
                {

                    throw new nullExceptiom("Please fill up the FF.");

                }
                else
                {
                   
                    uc.StaffFirstName = Fname(txtFname.Text);
                    uc.StaffLastName = Lname(txtLname.Text);
                    uc.StaffConntacNo = ContactNo(txtContact.Text);
                    uc.StaffAddress = Address(txtAdd.Text);
                    uc.StaffPosition = Position(txtPosition.Text);



                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                    string quer = "select u.User_Name ,s.Staff_ID ,u.User_Id from Staffs as s inner join Users as u on s.Staff_ID = u.Staff_ID where u.Status = 1 and " +
                        " s.Status = 1 and s.First_Name = '" + uc.StaffFirstName + "' and s.Last_Name = '" + uc.StaffLastName + "' and  s.Contact_No = '" + uc.StaffConntacNo + "' and " +
                        " s.Address = '" + uc.StaffAddress + "' and  s.Position = '" + uc.StaffPosition + "' ";

                    cn.Open();
                    SqlCommand command = new SqlCommand();
                    command = new SqlCommand(quer, cn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        uc.username = reader[0].ToString();
                        uc.staffid = reader[1].ToString();
                        uc.uid = reader[2].ToString();

                        string un = frmLogin.UserName;

                        if (un == uc.username)
                        {
                            panelEdit.Visible = true;
                            txtUserName.Text = uc.username;
                            btnCancel.Enabled = false;
                            btnConfirm.Enabled = false;

                        }
                        else
                        {
                            MessageBox.Show("Information Incorrect Try Asking your Admin for Help ", "Forgot PAssword", MessageBoxButtons.OK);

                        }

                    }


                    cn.Close();


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


        } // search end

      

    } // class end
} // name space end
