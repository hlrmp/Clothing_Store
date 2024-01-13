using System;
using System.Collections;
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
using System.Xml.Linq;

namespace Clothing_Store
{
    public partial class FrmRecovey : Form
    {
        public FrmRecovey()
        {
            InitializeComponent();
         //   list();
        }
        string emp;
        public void employee()    // emp condition begin
        {
            emp = frmLogin.pos1;
            //  emp = "Cashier";
            if (emp == "Cashier")
            {
                DialogResult dl = MessageBox.Show("Please ask to your Manager for permision ", "Permision",MessageBoxButtons.OKCancel);
                if (dl == DialogResult.OK)
                {
                    panelLogin.Visible = true;
                }
            }
            else if (emp == "Admin" || emp == "Manager")
            {

                res();

            }

        } // emp condition begin

        public void res()
        {

               SqlConnection Conn = new SqlConnection(ConnectionClass.conn);

                string con = Conn.Database.ToString();


               
                    Conn.Open();

                    string res = "ALTER DATABASE " + con + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";
                    SqlCommand commamd = new SqlCommand(res, Conn);
                    commamd.ExecuteNonQuery();

                    string res1 = "USE MASTER RESTORE  DATABASE " + con + " FROM DISK = '" + txtName.Text + "' WITH REPLACE";
                    SqlCommand commamd1 = new SqlCommand(res1, Conn);
                    commamd1.ExecuteNonQuery();

                    string res2 = "ALTER DATABASE " + con + " SET MULTI_USER ";
                    SqlCommand commamd2 = new SqlCommand(res2, Conn);
                    commamd2.ExecuteNonQuery();


                    MessageBox.Show("Database Restore Successfuly");

                    Conn.Close();

            
                    txtName.Clear();

                    // activity logs begin

                    //           string desc = "Restore Database - " + " TimeandDate " + frmLogin.name;
                    //           ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end


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

        private void btnCancel_Click(object sender, EventArgs e) //  cancel btton begin
        {
            
            txtBrowse.Clear();
            txtName.Clear();
            txtNewName.Clear();

            panelLogin.Hide();

        } // cancel button end


        private void FrmRecovey_Load(object sender, EventArgs e)// frm load begin
        {
            Timer timer = new Timer();
            timer.Interval = (5 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();


            // textbox size (w,h) 

            this.txtName.AutoSize = false;
            this.txtName.Size = new System.Drawing.Size(247, 25);


            this.txtBrowse.AutoSize = false;
            this.txtBrowse.Size = new System.Drawing.Size(425, 30);


        } // frm load end

        private void timer1_Tick(object sender, EventArgs e)// timer begin
        {
           
          //  list();

        } // timer end

        public void backup() // back up begin
        {
            string TimeandDate = DateTime.Now.ToString("yyyy-MM-ddT-HH:mm:ssss");
            string n = "bac";

            SqlConnection Conn = new SqlConnection(ConnectionClass.conn);

            string backup = "BACKUP DATABASE ClothingStoreDatabase TO DISK = 'C:\\Users\\reichel domingo\\Contacts\\Desktop\\MSSQL14.SQLEXPRESS02\\MSSQL\\Sample_Backup\\"+TimeandDate+".bak' ";
            SqlCommand command1 = new SqlCommand(backup, Conn);

            string insBackup = "insert into BackupList (Name, Date,User_Id,Status) values (@Name, getDate(), @UserId, @Status)";
            SqlCommand command = new SqlCommand(insBackup, Conn);

            command.Parameters.AddWithValue("@Name", TimeandDate);
            command.Parameters.AddWithValue("@Status", 1);
            command.Parameters.AddWithValue("@UserId", frmLogin.userId);
            
            Conn.Open();
           
            command1.ExecuteNonQuery();
            command.ExecuteNonQuery();

            Conn.Close();
          

        } // back up end 

       
      

        private void btnRecover_Click(object sender, EventArgs e) // recover or restore btn database begin
        {
          
            try
            {

                if (txtName.Text == "")
                {
                    throw new ArgumentNullException("Pls Browse A location");
                }
                else
                {
                    employee();

                }


            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } // recover or restore btn database begin



        private void btnClose_Click(object sender, EventArgs e) // btn close begin
        {
            this.Hide();

            txtUserName.Clear();
            txtPassword.Clear();
            txtBrowse.Clear();
            txtName.Clear();

        } // btn close end 


        string TimeandDate = DateTime.Now.ToString("yyyy-MM-dd-T-HH-mm-ss");

        private void btnBrowse_Click(object sender, EventArgs e)  // btn browse begin
        {
         FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBrowse.Text = folderBrowserDialog.SelectedPath;
                txtNewName.Text = "ClothingStoreDatabase-" + TimeandDate;

            }
                 
        } // btn browse end


        private void btbBackUpNew_Click(object sender, EventArgs e)  // back up btn begin
        {

            try
            {

                SqlConnection Conn = new SqlConnection(ConnectionClass.conn);

                string con = Conn.Database.ToString();
                string n = "name";

                if (txtBrowse.Text == "")
                {
                    throw new ArgumentNullException ("Pls Browse A location");
                }
                else
                {
                    string back = "BACKUP DATABASE ClothingStoreDB TO DISK = N'"+txtBrowse.Text+ "\\" + txtNewName.Text+".bak'";

                    string name = "DECLARE @FileName varchar(1000)\r\nSELECT @FileName = (SELECT'"+txtBrowse.Text+ "\\ClothingStoreDB' + convert(varchar(500), GetDate(),112) + '.bak')\r\nBACKUP DATABASE ClothingStoreDB TO DISK=@FileName";
                  
                    Conn.Open();
                    SqlCommand commamd = new SqlCommand(back , Conn);
                    commamd.ExecuteNonQuery();

                    MessageBox.Show("Database Backed Up Successfuly");

                    Conn.Close();


                     txtBrowse.Clear();
                    txtNewName.Clear();

                    // activity logs begin

                    //           string desc = "BackUp Database - " + " TimeandDate " + frmLogin.name;
                    //           ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end

                }


            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
           


        } // back up btn end

        private void btnRestoreBrowse_Click(object sender, EventArgs e) // restore browse begin
        {
            OpenFileDialog openfile = new OpenFileDialog();
           // openfile.Filter = "*.bak |.bak |*.BAK |.BAK";
           openfile.Filter = "SQL Server database backup files|*.bak";
            openfile.Title = "Database Restore";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                txtName.Text = openfile.FileName;
                

            }

        } // restore browse end

        private void btnConfirm_Click(object sender, EventArgs e) // btn confirm log begin
        {
            log();

            txtUserName.Clear();
            txtPassword.Clear();

            panelLogin.Hide();

        } // btn confirm log end

        public void log() // login begin
        {
            userClass uc = new userClass();

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
            

                    if (username == uc.username && pass == uc.userpas && pos == "Cashier")
                    {
                        MessageBox.Show("Your Account does not have a permision \n Please Ask To Your Manager " , "Error", MessageBoxButtons.OK);
                       
                    }
                    else if (username == uc.username && pass == uc.userpas && pos == "Admin"  || username == uc.username && pass == uc.userpas && pos == "Owner")
                    {
                        MessageBox.Show("Log in Sucessfully Please wait !!  ", "Sucessfull", MessageBoxButtons.OK);
                        res();

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
         
        private void ckPassword_CheckedChanged(object sender, EventArgs e)  // sjhowpass begin
        {
            if (ckPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        } // show pass end

    } // class end
} // name space end






/*
        public void list() // search method begin
        {
            SqlConnection cn = new SqlConnection(ConnectionClass.conn);

            cn.Open();

            string query = "select Name , Date , User_Id from BackupList where Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;

                cn.Close();
            

        }  // search method end*/
/*   string name;
   string date;
   private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // data grid click begin
   {
       name = dataGridView1.CurrentRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
       date = dataGridView1.CurrentRow.Cells["dateDataGridViewTextBoxColumn"].Value.ToString();

       if (dataGridView1.Columns[e.ColumnIndex].Name == "Recover")
       {

          // txtName.Text = name;
        //   txtDate.Text = date;

       }
       else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
       {
               DialogResult dialog = MessageBox.Show("Do You Want To Remove "+name+ "? " , "Delete" , MessageBoxButtons.YesNo);
               if(dialog == DialogResult.Yes)
               {
                   SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                   cn.Open();

                   string quer = "UPDATE BackupList SET Status = 2 WHERE Name ='" + name + "'";
                   SqlCommand command = new SqlCommand(quer, cn);
                   command.ExecuteNonQuery();
                   cn.Close();

                   dataGridView1.Refresh();
                   list();

               }
               else
               {

               }

       } 

   }   // data grid click end*/
