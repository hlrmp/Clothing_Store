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
            unames();
            uid();
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


        public void add() // add begin
        {
            uc.username = txtUserName.Text;
            uc.userpas = txtUserName.Text;
            string con = txtConfirmPass.Text;
            if (txtUserName.Text == "" || txtUserPass.Text == "" || txtConfirmPass.Text == "")
            {

            }
            else
            {
                    if (uc.username.Equals(username))
                    {
                        MessageBox.Show("User Name Already Exist", "Confirmation", MessageBoxButtons.OK);

                    }
                    else
                    {
                            if (uc.userpas == con)
                            {
                                DialogResult dialogResult = MessageBox.Show("Doyou wnat to Add this to the Users ", "Confirm", MessageBoxButtons.YesNo);

                                        if (dialogResult == DialogResult.Yes)
                                        {
                                           
                                                    SqlConnection cnn = new SqlConnection(ConnectionClass.conn);

                                                    string quer1 = "insert into UsersUsers(Staff_Id, User_Name,Password,Status) values (@Staffid, @UserName, @Pass, @Status)";
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

       
            
        }  //add end 

        string userId;
        public void uid()  //  uid begin
        {
            customerClass cs = new customerClass();
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string n = "select Staff_id from Staffs where status = 1 and First_Name = 'dan' and Last_Name = 'dg'";

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

            string names = "SELECT (First_Name + ' ' + Last_Name) AS NAME FROM Staffs where Status = 1 ";
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
        public void unames()  //  user names begin
        {
            customerClass cs = new customerClass();
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string sj = "  select * from Users";
            con.Open();
            SqlCommand command;
            command = new SqlCommand(sj, con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            username = reader[2].ToString();
            con.Close();

        } // user names end



    }// class end
} // name space end
