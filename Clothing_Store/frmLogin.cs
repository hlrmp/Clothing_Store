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
        MainForm mf = new MainForm();
        public void log() // login begin
        {

             SqlConnection cn = new SqlConnection(ConnectionClass.conn) ;
            

                uc.username = txtUserName.Text;
                uc.userpas = txtPassword.Text;


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
                        
                            string quer = "SELECT u.User_Name , u.Password ,s.Position FROM Staffs AS s INNER JOIN Users AS u ON(s.Staff_Id = u.Staff_Id) Where User_Name = '"+uc.username+"' and Password = '"+uc.userpas+"' and u.Status = 1 ;";

                            SqlCommand command = new SqlCommand();
                            command = new SqlCommand(quer, cn);
                            SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())         
                        {

                        string username = reader[0].ToString();
                        string pass = reader[1].ToString();
                        string pos = reader[2].ToString();

                        uc.StaffPosition = reader[2].ToString();


                                   if (username == uc.username && pass == uc.userpas && pos == "Cashier")
                                   {
                                       MessageBox.Show("c");
                                       mf.Show();
                                   }
                                   else if (username == uc.username && pass == uc.userpas && pos == "Admin")
                                   {
                                       MessageBox.Show("A");
                                       mf.Show();

                                   }
                                   else
                                   {
                                         MessageBox.Show("User Name / Password incorrect", "Account", MessageBoxButtons.OK);

                                        pictureBox1.Visible = true;
                                        pictureBox2.Visible = true;
                                        pictureBox3.Visible = true;
                                        pictureBox4.Visible = true;

                                        pictureBox1.BackColor = Color.Red;
                                        pictureBox2.BackColor = Color.Red;
                                        pictureBox3.BackColor = Color.Red;
                                        pictureBox4.BackColor = Color.Red;


                                   }


                        }
                        else
                        {
                                MessageBox.Show(" Account Not Found ", "Account", MessageBoxButtons.OK);
                        }

                                    cn.Close();

                } // outer else
        } // login end

        

    }// class end
}//  name space end 
