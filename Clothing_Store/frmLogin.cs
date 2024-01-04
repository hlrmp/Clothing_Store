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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Clothing_Store
{
    public partial class frmLogin : Form
    {
        public frmLogin()
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


        private void btnClose_Click(object sender, EventArgs e)  // close button begin
        {
            this.Close();

        }  // close button end



            private void ckPassword_CheckedChanged(object sender, EventArgs e) // check box show begin
           {
                    if (ckPassword.Checked == true)
                    {
                        txtPassword.UseSystemPasswordChar = false;
                    }
                    else
                    {
                        txtPassword.UseSystemPasswordChar = true;
                    }
            } // check box show end 

        private void btnLogin_Click(object sender, EventArgs e) // log in button begin
        {



            log();

            // activity logs begin

        //    string desc = "Log in - " + frmLogin.name;
      //      ConnectionClass.activity(frmLogin.userId, desc);

            // activity logs end


            //FrmLoading ffl = new FrmLoading();
            //ffl.ShowDialog();


        } // lig in button end

        userClass uc = new userClass();

        public static string pos1;
        public static string name;
        public static int userId;

        public void log() // login begin
        {

             SqlConnection cn = new SqlConnection(ConnectionClass.conn) ;
            

                uc.username = txtUserName.Text;
                uc.userpas = txtPassword.Text;


            MainForm mf = new MainForm();
           
            if (string.IsNullOrEmpty(txtUserName.Text) ||
                            string.IsNullOrEmpty(txtPassword.Text))
                {
                        if (txtUserName.Text == "")
                        {

                            MessageBox.Show(" Enter your user name ");

                        }
                        else if (txtPassword.Text == "")
                        {
                            MessageBox.Show(" Enter your password ");
                        }

                } // outer if


                else
                {    
                            cn.Open();
                        
                            string quer = "SELECT u.User_Id, u.User_Name , u.Password ,s.Position ,s.First_Name , s.Last_Name FROM Staffs AS s INNER JOIN Users AS u ON(s.Staff_Id = u.Staff_Id) Where User_Name = '" + uc.username+"' and Password = '"+uc.userpas+"' and u.Status = 1 ;";

                            SqlCommand command = new SqlCommand();
                            command = new SqlCommand(quer, cn);
                            SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())         
                        {

                        string username = reader[1].ToString();
                        string pass = reader[2].ToString();
                        string pos = reader[3].ToString();

                        uc.StaffFirstName = reader[4].ToString();
                        uc.StaffLastName = reader[5].ToString();

                        uc.StaffPosition = reader[3].ToString();

                        pos1 = reader[3].ToString();
                        name = uc.StaffFirstName + " " + uc.StaffLastName;
                        userId = Convert.ToInt32(reader[0].ToString());

                                   if (username == uc.username && pass == uc.userpas && pos == "Cashier")
                                   {
                                       MessageBox.Show("C");
                                        mf.Show();
                                        this.Hide();
                             
                                                   }
                                   else if (username == uc.username && pass == uc.userpas && pos == "Admin" || username == uc.username && pass == uc.userpas && pos == "Owner")
                                   {
                                        MessageBox.Show("A");
                                        mf.Show();
                                        this.Hide();

                                   }
                                   else
                                   {
                                         MessageBox.Show("User Name / Password incorrect", "Account", MessageBoxButtons.OK);

                                     
                                   }


                        }
                        else
                        {
                                MessageBox.Show(" Account Not Found ", "Account", MessageBoxButtons.OK);
                        }

                                    cn.Close();

                } // outer else
        } // login end

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }// class end
}//  name space end 
