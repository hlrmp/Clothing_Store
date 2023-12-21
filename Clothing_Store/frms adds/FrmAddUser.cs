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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clothing_Store
{
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
            StaffName();
            

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

        private void Cancel_Click(object sender, EventArgs e)  // cancel button begin
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to Cancel? ", "Close", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();

                txtUserName.Clear();
                txtUserPass.Clear();
                txtConfirmPass.Clear();

            }
            else
            {

            }
        } // cancel button end


        // class instance
        userClass uc = new userClass();
        private void btnAdd_Click(object sender, EventArgs e)  // add button begin
        {
            
            uid();
            MessageBox.Show(userId);
            add();
          

        } //  add button end

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)   // show pass begin
        {

            if (ckShowPass.Checked == true)
            {
                txtUserPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtUserPass.UseSystemPasswordChar = true;
            }

        } // show pass end

        class nullExceptiom : Exception
        {
            public nullExceptiom(string str) : base(str) { }
        }
        class simlarException : Exception
        {
            public simlarException(string str) : base(str) { }
        }

        public void add() // add begin
        {

            try
            {
                uc.username = txtUserName.Text;
                uc.userpas = txtUserPass.Text;
                string con = txtConfirmPass.Text;

               

                if (txtUserName.Text == "" || txtUserPass.Text == "" || txtConfirmPass.Text == "")
                {
                    throw new nullExceptiom("Please fillup the ff.");
                }
               else
                {
               //      unames();

                    if (uc.username.Equals(username))
                    {
                        throw new simlarException("User Name Already Exist");

                    }

                    else
                    {
                        if (uc.userpas == con)
                        {
                            DialogResult dialogResult = MessageBox.Show("Doyou wnat to Add this to the Users ", "Confirm", MessageBoxButtons.YesNo);

                            if (dialogResult == DialogResult.Yes)
                            {

                                SqlConnection cnn = new SqlConnection(ConnectionClass.conn);

                                string quer1 = "insert into Users (Staff_Id, User_Name,Password,Status) values (@Staffid, @UserName, @Pass, @Status)";
                                SqlCommand command = new SqlCommand(quer1, cnn);

                                command.Parameters.AddWithValue("@Staffid", userId);
                                command.Parameters.AddWithValue("@UserName", uc.username);
                                command.Parameters.AddWithValue("@Pass", uc.userpas);
                                command.Parameters.AddWithValue("@Status", 1);
                                cnn.Open();
                                command.ExecuteNonQuery();
                                cnn.Open();

                                MessageBox.Show("succesfully added", "Confirmation", MessageBoxButtons.OK);

                                // activity logs begin

                                //  string desc = "New User Added";
                                //   ConnectionClass.activity(frmLogin.userId, desc);

                                // activity logs end

                                this.Hide();

                                txtUserName.Clear();
                                txtUserPass.Clear();
                                txtConfirmPass.Clear();


                            }
                            else
                            {

                            }
                        }

                    }
                }
            }
            catch (nullExceptiom ne)
            {
                MessageBox.Show(ne.Message , "Required");
            }
            catch (simlarException se)
            {
                MessageBox.Show(se.Message , "Existing");
            }





        }  //add end 

        string userId;
        public void uid()  //  uid begin
        {
            customerClass cs = new customerClass();
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string n = "SELECT Staff_id FROM Staffs  WHERE CONCAT(TRIM(Staffs.First_Name), ' ', TRIM(Staffs.Last_Name)) LIKE '"+cbStaffName.Text+"' and Status = 1";

            con.Open();
            SqlCommand command;
            command = new SqlCommand(n, con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            userId = reader[0].ToString();
            con.Close();

        } // uid end


        public void StaffName()  // display staff name
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string names = "SELECT (First_Name + ' ' + Last_Name) AS NAME FROM Staffs where Status = 1";
            SqlDataAdapter adapt = new SqlDataAdapter(names, con);

            DataTable dataTable = new DataTable();
            BindingSource bindingSource = new BindingSource();
            dataTable.Clear();
            adapt.Fill(dataTable);
            bindingSource.DataSource = dataTable;

            con.Open();
            SqlCommand command = new SqlCommand(names, con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            con.Close();

            cbStaffName.DataSource = dataTable;
            cbStaffName.DisplayMember = "Name";

        }  // display staff name end

        string username;
        public bool unames()  //  user names begin
        {
            customerClass cs = new customerClass();
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string sj = "select User_Name from users where User_Name = '"+uc.username+"'";
            con.Open();
            SqlCommand command;
            command = new SqlCommand(sj, con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            username = reader[0].ToString();

            con.Close();

            return true;

        } // user names end



    }// class end
} // name space end
