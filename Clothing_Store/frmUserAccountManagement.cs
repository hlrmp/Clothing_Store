using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Store
{
    public partial class frmUserAccountManagement : Form
    {
        public frmUserAccountManagement()
        {
            InitializeComponent();
            info();

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

        string emp;
        public void employee()    // emp condition begin
        {
            emp = frmLogin.pos1;
            //  emp = "Cashier";
            if (emp == "Cashier")
            {
               

                lblTitle.Text = frmLogin.name + " - (" + emp + ") Accounts Settings ";

            }
            else if (emp == "Admin" || emp == "Manager")
            {
              

                lblTitle.Text = frmLogin.name + " - (" + emp + ") Accounts Settings ";


            }

        } // emp condition begin


        
        string pos1;
        string name;
        string pas;
        string us;
        int id;

        userClass uc = new userClass();

        public void info()  // info begin
        {

            id = frmLogin.userId;
           



            SqlConnection cn = new SqlConnection(ConnectionClass.conn);

            string quer = "SELECT u.User_Id, u.User_Name , u.Password ,s.Position ,s.First_Name , s.Last_Name FROM Staffs AS s INNER JOIN Users AS u ON(s.Staff_Id = u.Staff_Id) Where u.User_ID = "+ id +" and u.Status = 1 ;";
            
            cn.Open();
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
                us = username;
                pas = pass;


                lblId.Text = Convert.ToString(id);
                lblName.Text = name;
                lblPos.Text = pos1;
                lblUserName.Text = us;
                lblPass.Text = pas;
            }
          

               cn.Close();

        } // info end

        private void pictureBox1_Click(object sender, EventArgs e) // picturebox begin
        {
            panelEdit.Show();

            txtUserName.Text = us;
            txtPassword.Text = pas;

        } // picturebox click end

        private void btnCancel_Click(object sender, EventArgs e) // cancel changes begin
        {
            DialogResult dl = MessageBox.Show("Do you want to cancel changes ?","Cancel",MessageBoxButtons.OKCancel);
            if(dl == DialogResult.OK)
            {
                txtUserName.Clear();
                txtPassword.Clear();

                panelEdit.Hide();
            }
            else
            {

            }
          

        } // cancel changes end

        class nullExceptiom : Exception
        {
            public nullExceptiom(string str) : base(str) { }
        }

        private void btnConfirm_Click(object sender, EventArgs e) // btn confirm begin
        {
            DialogResult dl = MessageBox.Show("Do you want to save changes ?", "Confirm", MessageBoxButtons.OKCancel);

            if (dl == DialogResult.OK)
            {
                saveInfo();
                info();
            }
            else
            {

            }
        } // btn confrim end

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

                    MessageBox.Show("User information was Updated", "Update  User", MessageBoxButtons.OK);

                    txtUserName.Clear();
                    txtPassword.Clear();

                    panelEdit.Hide();

                    // activity logs begin

                    string desc = "Update User Information" + id +" - " + name;
                    //   ConnectionClass.activity(frmLogin.userId, desc);

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
            sqlCommand.CommandText = "Update  Users Set User_Name = @User_Name , Password = @Password  where User_Id = " + id + " ";

            sqlCommand.Parameters.Add("@User_Name", UserName);
            sqlCommand.Parameters.Add("@Password", Pass);


            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

            return true;
        } // update the user info end

        private void btnClose_Click(object sender, EventArgs e) // btn close begin
        {
            this.Hide();

            txtUserName.Clear();
            txtPassword.Clear();

            panelEdit.Hide();


        } // btn close end

    } // class end
} // name space end
