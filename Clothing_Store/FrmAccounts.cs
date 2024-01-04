using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            seeStaffs();
            filter();


        }
        
        // form instance
       
        FrmRecovey frec = new FrmRecovey();
        FrmAddUser fuser = new FrmAddUser();
        FrmAddNewStaffs fstaf = new FrmAddNewStaffs();
        private void btnCreate_Click(object sender, EventArgs e)  //  add new user begin
        {
           
            panelAdd.Show();

            PanelStafAndUser.Hide();
            dataGridViewStaffs.Visible = false;
            dataGridView1.Visible = false;

            txtSearch.Hide();
            lblsearch.Hide();
            cbFilter.Hide();


        } //  add new user end


        private void btnHomeAccounts_Click(object sender, EventArgs e) // home button begin
        {
            panelAdd.Hide();
            PanelStafAndUser.Hide();
            dataGridViewStaffs.Visible = false;
            dataGridView1.Visible = false;
            dataGridViewHome.Visible = true;
            seeStaffs();

            txtSearch.Show();
            lblsearch.Show();
            cbFilter.Show();
        } // home buton end

       
        private void btnRecovery_Click(object sender, EventArgs e)  //  recovery button begin
        {
           
            frec.ShowDialog();
            PanelStafAndUser.Hide();
            dataGridViewStaffs.Visible = false;
            dataGridView1.Visible = false;

            txtSearch.Hide();
            lblsearch.Hide();
            cbFilter.Hide();

        } // recovery buton end

        private void btnAddNewStaff_Click(object sender, EventArgs e) // panel add staff begin 
        {

            fstaf.ShowDialog();
            panelAdd.Hide();
            PanelStafAndUser.Hide();
            dataGridViewStaffs.Visible = false;

            txtSearch.Hide();
            lblsearch.Hide();
            cbFilter.Hide();

        }// panel add staff end 

        private void button1_Click(object sender, EventArgs e) // panel add user begin
        {
            fuser.ShowDialog();
            panelAdd.Hide();
            PanelStafAndUser.Hide();
            dataGridViewStaffs.Visible = false;


        } // panel add user end

        private void btnActivitylog_Click(object sender, EventArgs e) // btn activyity logs Begin
        {
            seeActivity();
            PanelStafAndUser.Hide();
            dataGridViewStaffs.Visible = false;
            dataGridView1.Visible = true;

            txtSearch.Hide();
            lblsearch.Hide();
            cbFilter.Hide();

        } // btn activyity logs end


        public void seeActivity() // see customers begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select a.Activity_Id as 'Activity no',  a.User_Id, u.User_Name, a.Description, a.Date from Activity_Logs as a inner join Users as u on a.User_Id = u.User_Id\r\n";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;



        } // see customers end - datagrid

        private void btnArchives_Click(object sender, EventArgs e)
        {
            frmArchives fa = new frmArchives();
            fa.ShowDialog();
            panelAdd.Hide();
            PanelStafAndUser.Hide();
            dataGridView1.Visible = false;

            txtSearch.Hide();
            lblsearch.Hide();
            cbFilter.Hide();
        }
        private void btnUserStaffs_Click(object sender, EventArgs e)
        {
            panelAdd.Hide();
            PanelStafAndUser.Show();
            dataGridView1.Visible = false;

            txtSearch.Hide();
            lblsearch.Hide();
            cbFilter.Hide();
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            ManageStaffs();
            dataGridViewStaffs.Visible = true;
        }
            public void ManageStaffs() // manage Staffs begin - datagrid
            {

                SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


                string sj = "select Staff_Id , First_Name , Last_Name,Contact_No,Email , Address,Position from staffs where Status = 1";

                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewStaffs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewStaffs.DataSource = table;



            } // manage Staffs end - datagrid
        public void seeStaffs() // manage Staffs begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select Staff_Id , First_Name , Last_Name,Contact_No,Email , Address,Position from staffs where Status = 1";

            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHome.DataSource = table;



        } // manage Staffs end - datagrid

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelAdd.Hide();
            PanelStafAndUser.Hide();
            ManageStaffs();
           
        }

        private void FrmAccounts_Load(object sender, EventArgs e)
        {
            this.txtSearch.AutoSize = false;
            this.txtSearch.Size = new System.Drawing.Size(243, 21);

            Timer timer = new Timer();
            timer.Interval = (3 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
        public void filter() //  filter begin
        {
            ArrayList arr = new ArrayList();
            arr.Add("Id");
            arr.Add("First Name");
            arr.Add("last Name");
            arr.Add("Position");

            foreach (string i in arr)
            {
                cbFilter.Items.Add(i)
;            }
        } // filter end

        private void dataGridViewStaffs_CellContentClick(object sender, DataGridViewCellEventArgs e) // datagrid staffs click begin 
        {
            userClass staff = new userClass();

            staff.staffid = dataGridViewStaffs.CurrentRow.Cells["Staff_Id"].Value.ToString();
            staff.StaffFirstName = dataGridViewStaffs.CurrentRow.Cells["First_Name"].Value.ToString();
            staff.StaffLastName = dataGridViewStaffs.CurrentRow.Cells["Last_Name"].Value.ToString();
            staff.StaffAddress = dataGridViewStaffs.CurrentRow.Cells["Address"].Value.ToString();
            staff.StaffConntacNo = dataGridViewStaffs.CurrentRow.Cells["Contact_No"].Value.ToString();
            staff.staffEmail = dataGridViewStaffs.CurrentRow.Cells["Email"].Value.ToString();
            staff.StaffPosition = dataGridViewStaffs.CurrentRow.Cells["Position"].Value.ToString();

            if (dataGridViewStaffs.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do you want to Remove Staff # " + staff.staffid + " Name: " + staff.StaffFirstName + " " + staff.StaffLastName + "  ?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Staffs set Status = 2 where Staff_Id = " + staff.staffid + " ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    // activity logs begin

                    string desc = " Restore Staff # " + staff.staffid + " Name: " + staff.StaffFirstName + " " + staff.StaffLastName;
                    //        ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }

            }
        } // datagrid staff click end

        public void search() // search method begin
        {


            if (cbFilter.Text.ToString() == "First Name")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = " select Staff_Id , First_Name , Last_Name,Contact_No,Email , Address,Position from staffs  WHERE First_Name LIKE '" + sch + '%' + "' and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridViewHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewHome.DataSource = table;


                cn.Close();
            }
           else if (cbFilter.Text.ToString() == "Last Name")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = " select Staff_Id , First_Name , Last_Name,Contact_No,Email , Address,Position from staffs  WHERE Last_Name LIKE '" + sch + '%' + "' and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridViewHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewHome.DataSource = table;


                cn.Close();
            }
            else if (cbFilter.Text.ToString() == "Position")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = " select Staff_Id , First_Name , Last_Name,Contact_No,Email , Address,Position from staffs  WHERE Position LIKE '" + sch + '%' + "' and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridViewHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewHome.DataSource = table;


                cn.Close();
            }
            else if (cbFilter.Text.ToString() == "Id")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = " select Staff_Id , First_Name , Last_Name,Contact_No,Email , Address,Position from staffs  WHERE Staff_Id LIKE '" + sch + '%' + "' and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridViewHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewHome.DataSource = table;


                cn.Close();
            }
            else{
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = " select Staff_Id , First_Name , Last_Name,Contact_No,Email , Address,Position from staffs  WHERE First_Name LIKE '" + sch + '%' + "' and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridViewHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewHome.DataSource = table;


                cn.Close();
            }

        }// search method end

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e) // search enter begin
        {
            search();

        } // search enter end

        private void lblsearch_Click(object sender, EventArgs e) // search click begin
        {
            search();

        }// search click end

    } // class end
} // name space end
