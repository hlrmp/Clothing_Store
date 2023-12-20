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

namespace Clothing_Store
{
    public partial class FrmAccounts : Form
    {
        public FrmAccounts()
        {
            InitializeComponent();
        }
        
        // form instance
       
        FrmBackup fback = new FrmBackup();
        FrmRecovey frec = new FrmRecovey();
        FrmAddUser fuser = new FrmAddUser();
        FrmAddNewStaffs fstaf = new FrmAddNewStaffs();
        private void btnCreate_Click(object sender, EventArgs e)  //  add new user begin
        {
           
            panelAdd.Show();    
           

        } //  add new user end

    
        


        private void btnBackup_Click(object sender, EventArgs e)// btn backup begin
        {
            // pannel
         
            fback.ShowDialog();
           
           
        }  // btn bacup end 

        private void btnHomeAccounts_Click(object sender, EventArgs e) // home button begin
        {
            panelAdd.Hide();

        } // home buton end

       
        private void btnRecovery_Click(object sender, EventArgs e)  //  recovery button begin
        {
           

            frec.ShowDialog();

        } // recovery buton end

        private void btnAddNewStaff_Click(object sender, EventArgs e) // panel add staff begin 
        {

            fstaf.ShowDialog();
            panelAdd.Hide();

        }// panel add staff end 

        private void button1_Click(object sender, EventArgs e) // panel add user begin
        {
            fuser.ShowDialog();
            panelAdd.Hide();
         

        } // panel add user end

        private void btnActivitylog_Click(object sender, EventArgs e) // btn activyity logs Begin
        {
            seeActivity();

        } // btn activyity logs end


        public void seeActivity() // see customers begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = " select Activity_Id as 'Activity No.' , User_Id as 'UserId', Description as 'Activity' , Date from Activity_Logs";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;



        } // see customers end - datagrid

        private void btnUserLog_Click(object sender, EventArgs e) // btn user logs 
        {

            SqlConnection con = new SqlConnection(ConnectionClass.conn);
            string logs = " select Activity_Id as 'Activity No.' , Description as 'Activity' , Date from Activity_Logs where User_Id = " + frmLogin.userId + "";

            SqlDataAdapter data = new SqlDataAdapter(logs, con);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;


        } // btn user logs 


    } // class end
} // name space end
