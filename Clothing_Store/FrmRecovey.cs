using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Store
{
    public partial class FrmRecovey : Form
    {
        public FrmRecovey()
        {
            InitializeComponent();
            list();
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

        private void btnCancel_Click(object sender, EventArgs e) //  cancel utton begin
        {
            this.Hide();

          
        } // cancel button end


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
            

        }  // search method end
        string name;
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

        }   // data grid click end

        private void FrmRecovey_Load(object sender, EventArgs e)// frm load begin
        {
            Timer timer = new Timer();
            timer.Interval = (5 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();


            // textbox size (w,h) 

            this.txtName.AutoSize = false;
            this.txtName.Size = new System.Drawing.Size(247, 25);

            this.txtDate.AutoSize = false;
            this.txtDate.Size = new System.Drawing.Size(247, 25);



            this.txtBrowse.AutoSize = false;
            this.txtBrowse.Size = new System.Drawing.Size(425, 30);


        } // frm load end

        private void timer1_Tick(object sender, EventArgs e)// timer begin
        {
            dataGridView1.Refresh();
            list();

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

                SqlConnection Conn = new SqlConnection(ConnectionClass.conn);

                string con = Conn.Database.ToString();
                

                if (txtName.Text == "")
                {
                    throw new ArgumentNullException("Pls Browse A location");
                }
                else
                {
                    Conn.Open();

                    string res = "ALTER DATABASE "+con+" SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";
                    SqlCommand commamd = new SqlCommand(res, Conn);
                    commamd.ExecuteNonQuery();

                    string res1 = "USE MASTER RESTORE  DATABASE "+con+" FROM DISK = '"+txtName.Text+"' WITH REPLACE";
                    SqlCommand commamd1 = new SqlCommand(res1, Conn);
                    commamd1.ExecuteNonQuery();

                    string res2 = "ALTER DATABASE "+con+" SET MULTI_USER ";
                    SqlCommand commamd2 = new SqlCommand(res2, Conn);
                    commamd2.ExecuteNonQuery();


                    MessageBox.Show("Database Restore Successfuly");

                    Conn.Close();

                    // activity logs begin

                    //           string desc = "Restore Database - " + " TimeandDate " + frmLogin.name;
                    //           ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end

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



            // activity logs begin

            //           string desc = "Restore - " + frmLogin.name;
            //           ConnectionClass.activity(frmLogin.userId, desc);

            // activity logs end


        } // recover or restore btn database begin



        private void btnClose_Click(object sender, EventArgs e) // btn close begin
        {
            this.Hide();
 
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
                    string back = "BACKUP DATABASE ClothingStoreDatabase TO DISK = N'"+txtBrowse.Text+ "\\" + txtNewName.Text+".bak'";

                    string name = "DECLARE @FileName varchar(1000)\r\nSELECT @FileName = (SELECT'"+txtBrowse.Text+"\\ClothingStoreDatabase' + convert(varchar(500), GetDate(),112) + '.bak')\r\nBACKUP DATABASE ClothingStoreDatabase TO DISK=@FileName";
                  
                    Conn.Open();
                    SqlCommand commamd = new SqlCommand(back , Conn);
                    commamd.ExecuteNonQuery();

                    MessageBox.Show("Database Backed Up Successfuly");

                    Conn.Close();

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
          //  openfile.Filter = "*.bak |.bak";
            openfile.Title = "Database Restore";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                txtName.Text = openfile.FileName;
                

            }

        } // restore browse end

         
    } // class end
} // name space end
