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

            txtDate.Clear();
            txtName.Clear();

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

                txtName.Text = name;
                txtDate.Text = date;
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

        public void restore() // restore begin
        {
            string restore = "RESTORE DATABASE ClothingStoreDatabase FROM DISK = 'C:\\Users\\reichel domingo\\Contacts\\Desktop\\MSSQL14.SQLEXPRESS02\\MSSQL\\Backup\\" + name + ".bak'";

            SqlConnection Conn = new SqlConnection(ConnectionClass.conn);
            SqlCommand command = new SqlCommand(restore, Conn);

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        } // restorre end

        private void btnBackup_Click(object sender, EventArgs e) // back up btn begin 
        {
            backup();

            // activity logs begin

            string desc = "Backup Data - " + frmLogin.name;
            ConnectionClass.activity(frmLogin.userId, desc);

            // activity logs end


        } // back up btn end

        private void btnRecover_Click(object sender, EventArgs e) // recover or restore btn database begin
        {
            restore();

            // activity logs begin

            string desc = "Restore - " + frmLogin.name;
            ConnectionClass.activity(frmLogin.userId, desc);

            // activity logs end


        } // recover or restore btn database begin



        private void btnClose_Click(object sender, EventArgs e) // btn close begin
        {
            this.Hide();
 
        } // btn close end 
    } // class end
} // name space end
