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

          

            //FrmLoading ffl = new FrmLoading();
            //ffl.ShowDialog();


        } // lig in button end

        userClass uc = new userClass();

        public static string pos1;
        public static string name;
        public static int userId;
        public static string us;
        public static string pas;
        public static string UserName;

        public void log() // login begin
        {

            SqlConnection cn = new SqlConnection(ConnectionClass.conn);


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

                string quer = "SELECT u.User_Id, u.User_Name , u.Password ,s.Position ,s.First_Name , s.Last_Name FROM Staffs AS s INNER JOIN Users AS u ON(s.Staff_Id = u.Staff_Id) Where User_Name = '" + uc.username + "' and Password = '" + uc.userpas + "' and u.Status = 1 ;";

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
                    us = username;
                    pas = pass;



                    if (username == uc.username && pass == uc.userpas && pos == "Cashier")
                    {
                      //  MessageBox.Show("C");
                        circularProgressBar1.Show();
                        timer1.Start();

                        // activity logs begin

                            string desc = "Log in - " + frmLogin.name;
                            ConnectionClass.activity(frmLogin.userId, desc);

                        // activity logs end


                    }
                    else if (username == uc.username && pass == uc.userpas && pos == "Admin" || username == uc.username && pass == uc.userpas && pos == "Owner")
                    {
                      //  MessageBox.Show("A");
                        circularProgressBar1.Show();
                        timer1.Start();

                        // activity logs begin

                            string desc = "Log in - " + frmLogin.name;
                              ConnectionClass.activity(frmLogin.userId, desc);

                        // activity logs end


                    }
                    else
                    {
                        MessageBox.Show("User Name / Password incorrect", "Account", MessageBoxButtons.OK);

                        /*pictureBox1.Visible = true;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = true;

                        pictureBox1.BackColor = Color.Red;
                        pictureBox2.BackColor = Color.Red;
                        pictureBox3.BackColor = Color.Red;
                        pictureBox4.BackColor = Color.Red;*/


                    }


                }
                else
                {
                    MessageBox.Show(" Account Not Found ", "Account", MessageBoxButtons.OK);
                }

                cn.Close();

            } // outer else
        } // login end

     

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (circularProgressBar1.Value < 100)
            {

                circularProgressBar1.Value += 1;
                circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();

                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();

            }
        }

        private void lblForgotPasword_Click(object sender, EventArgs e) // forgot password begin
        {
            UserName = txtUserName.Text;
            readUserName();


            FrmForgotPassword fp = new FrmForgotPassword();

            if (txtUserName.Text == "")
            {
                MessageBox.Show("Enter your User Name to Continue", "Forgot Password", MessageBoxButtons.OK);
            }
            else if (ok == txtUserName.Text)
            {
                fp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter your User Name Correctly Continue", "Forgot Password", MessageBoxButtons.OK);
            }


        }// forgot password end
        string ok;
        public void readUserName()// readUserName begin
        {
            SqlConnection cn = new SqlConnection(ConnectionClass.conn);

            string quer = "select * from Users where User_Name = '"+txtUserName.Text+"'";

            cn.Open();
            SqlCommand command = new SqlCommand();
            command = new SqlCommand(quer, cn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
               ok =   reader[2].ToString();
             


              
            }

            } // readUserName end

    }// class end
}//  name space end 