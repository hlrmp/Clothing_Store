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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            dataGridViewUsers.Visible = false;

            txtSearch.Hide();
            lblsearch.Hide();
            cbFilter.Hide();

            panelEditUsers.Hide();
            panelEdit.Hide();

        } //  add new user end


        private void btnHomeAccounts_Click(object sender, EventArgs e) // home button begin
        {
            panelAdd.Hide();
            PanelStafAndUser.Hide();
            dataGridViewStaffs.Visible = false;
            dataGridView1.Visible = false;
            dataGridViewHome.Visible = true;
            dataGridViewHome.Show();
            dataGridViewUsers.Visible = false;
            seeStaffs();

            txtSearch.Show();
            lblsearch.Show();
            cbFilter.Show();

            panelEditUsers.Hide();
            panelEdit.Hide();

        } // home buton end

       
        private void btnRecovery_Click(object sender, EventArgs e)  //  recovery button begin
        {
           
            frec.ShowDialog();
            PanelStafAndUser.Hide();
            dataGridViewStaffs.Visible = false;
            dataGridView1.Visible = false;
            dataGridViewUsers.Visible = false;

            txtSearch.Hide();
            lblsearch.Hide();
            cbFilter.Hide();

            panelEditUsers.Hide();
            panelEdit.Hide();


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
            dataGridViewUsers.Visible = false;

            txtSearch.Hide();
            lblsearch.Hide();
            cbFilter.Hide();

            panelEditUsers.Hide();
            panelEdit.Hide();

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
            dataGridViewUsers.Visible = false;

            txtSearch.Hide();
            lblsearch.Hide();
            cbFilter.Hide();

            panelEditUsers.Hide();
            panelEdit.Hide();

        }
        private void btnUserStaffs_Click(object sender, EventArgs e)
        {
            panelAdd.Hide();
            PanelStafAndUser.Show();
            dataGridView1.Visible = false;

            txtSearch.Hide();
            lblsearch.Hide();
            cbFilter.Hide();

            panelEditUsers.Hide();
            panelEdit.Hide();

        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            ManageStaffs();
            dataGridViewStaffs.Visible = true;
            dataGridViewUsers.Visible = false;
            dataGridViewStaffs.Show();

        }
        private void btnUsers_Click(object sender, EventArgs e) //  manage users  btn begin
        {
            manageUsers();
            dataGridViewStaffs.Visible = false;
            dataGridViewUsers.Visible = true;
            dataGridViewUsers.Show();

        } //  manage users  btn end
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

        public void manageUsers() // manage Users begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select u.User_Id , s.First_Name , s.Last_Name , u.User_Name,u.Password from Users as u inner join Staffs as s on u.Staff_Id = s.Staff_Id where u.Status = 1";

            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.DataSource = table;



        } // manage Users end - datagrid
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

        userClass staff = new userClass();

        private void dataGridViewStaffs_CellContentClick(object sender, DataGridViewCellEventArgs e) // datagrid staffs click begin 
        {
         

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
            else if (dataGridViewStaffs.Columns[e.ColumnIndex].Name == "Edit")
            {
                panelEdit.Visible = true;
                panelEdit.Show();

                // panelEditUsers.Hide();

                txtFname.Text = staff.StaffFirstName;
                txtLname.Text = staff.StaffLastName;
                txtContact.Text = staff.StaffConntacNo;
                txtEmail.Text = staff.staffEmail;
                txtAddress.Text = staff.StaffAddress;


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

        private void btnSave_Click(object sender, EventArgs e) //save btn begin
        {
            try
            {
                if (string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text)
                    || string.IsNullOrEmpty(txtAddress.Text) 
                    || string.IsNullOrEmpty(txtContact.Text) || string.IsNullOrEmpty(txtEmail.Text))
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {


                    staff.StaffFirstName = Fname(txtFname.Text);
                    staff.StaffLastName = Lname(txtLname.Text);
                    staff.StaffAddress = Add(txtAddress.Text);       
                    staff.StaffConntacNo = ContactNo(txtContact.Text);
                    staff.staffEmail = Em(txtEmail.Text);

                    updateStaffs(staff.StaffFirstName, staff.StaffLastName, staff.staffEmail, staff.StaffConntacNo, staff.StaffAddress); // update staff method 

                    MessageBox.Show("Staff information was Updated", "Update  Staff", MessageBoxButtons.OK);

                    txtFname.Clear();
                    txtLname.Clear();
                    txtContact.Clear();
                    txtAddress.Clear();           
                    txtEmail.Clear();

                    panelEdit.Hide();


                    // activity logs begin

                    string desc = "Update staff Information";
                 //   ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end

                }


            }
            catch (NumberFormatException ne)
            {
                MessageBox.Show(ne.Message);
            }
            catch (StringFormatException le)
            {
                MessageBox.Show(le.Message);
            }
            catch (nullExceptiom ne)
            {
                MessageBox.Show(ne.Message);
            }
            // end of catch 


        } // save btn end
        public bool updateStaffs(string FirstName, string LastName, string Email, string ContactNo, string Address) // update the Staff info begin
        {

            SqlConnection con = new SqlConnection(ConnectionClass.conn);
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Parameters.Clear();
            sqlCommand.Connection = con;
            sqlCommand.CommandText = "Update  Staffs Set First_Name = @FirstName, Last_Name = @LastName, Contact_No =  @Contact, Email = @Email,  Address = @Address where Staff_Id = " + staff.staffid + " ";

            sqlCommand.Parameters.Add("@FirstName", FirstName);
            sqlCommand.Parameters.Add("@LastName", LastName);
            sqlCommand.Parameters.Add("@Email", Email);
            sqlCommand.Parameters.Add("@Contact", ContactNo);
            sqlCommand.Parameters.Add("@Address", Address);
      
            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

            return true;
        } // update the Staff info end

        //  reg ex starting
        class nullExceptiom : Exception
        {
            public nullExceptiom(string str) : base(str) { }
        }
        class StringFormatException : Exception
        {
            public StringFormatException(string str) : base(str) { }
        }

        public string Fname(string FirstName)
        {
            if (Regex.IsMatch(FirstName, regexClass.letters))
            {

                FirstName = Char.ToUpper(FirstName[0]) + FirstName.Substring(1);

                 staff.StaffFirstName = FirstName;
            }

            else
            {
                throw new StringFormatException("please enter your First Name Correctly");
            }

            return staff.StaffFirstName;
        }
        public string Lname(string LastName)
        {
            if (Regex.IsMatch(LastName, regexClass.letters))
            {
                LastName = Char.ToUpper(LastName[0]) + LastName.Substring(1);

                staff.StaffLastName = LastName;


            }
            else
            {
                throw new StringFormatException("please enter your Last Name Correctly");
            }

            return staff.StaffLastName;
        }
        public string Add(string address)
        {
            if (Regex.IsMatch(address, regexClass.mix))
            {

                staff.StaffAddress = address;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return staff.StaffAddress;
        }
      
        public string Em(string email)
        {
            if (Regex.IsMatch(email, regexClass.mix))
            {

                staff.staffEmail = email;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return staff.staffEmail;
        }

        class NumberFormatException : Exception
        {
            public NumberFormatException(string num) : base(num) { }
        }
        public string ContactNo(string contact)
        {

            if (Regex.IsMatch(contact, regexClass.numbers))
            {
                staff.StaffConntacNo = contact;

            }
            else
            {
                throw new NumberFormatException("put contact number correctly");
            }
            return staff.StaffConntacNo;
        }
        // reg ex end

        private void btnCancel_Click(object sender, EventArgs e)  // cancel edit Staff Begin
        {
            txtFname.Clear();
            txtLname.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtEmail.Clear();

            panelEdit.Hide();

        } // cancel edit Staff end

        private void button2_Click(object sender, EventArgs e) // cancel edit Users end
        {
            txtUserName.Clear();
            txtPassword.Clear();

            panelEditUsers.Hide();


        } // cancel edit users end

        private void button3_Click(object sender, EventArgs e) // btn save users begin
        {
            try
            {
                if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUserName.Text))
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {


                    staff.username = txtUserName.Text;
                    staff.userpas = txtPassword.Text;

                    updateuser(staff.username, staff.userpas);

                    MessageBox.Show("User information was Updated", "Update  User", MessageBoxButtons.OK);

                    manageUsers();


                    txtUserName.Clear();
                    txtPassword.Clear();

                    panelEditUsers.Hide();
                    
                    // activity logs begin

                    string desc = "Update User Information";
                    //   ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end

                }


            }
            catch (nullExceptiom ne)
            {
                MessageBox.Show(ne.Message);
            }
            // end of catch 


        } // btn save users end

        public bool updateuser(string UserName, string Pass) // update the User info begin
        {

            SqlConnection con = new SqlConnection(ConnectionClass.conn);
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Parameters.Clear();
            sqlCommand.Connection = con;
            sqlCommand.CommandText = "Update  Users Set User_Name = @User_Name , Password = @Password  where User_Id = " + staff.uid + " ";

            sqlCommand.Parameters.Add("@User_Name", UserName);
            sqlCommand.Parameters.Add("@Password", Pass);
          

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

            return true;
        } // update the user info end

        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) // datagrid click begin 
        {
            staff.uid = dataGridViewUsers.CurrentRow.Cells["User_Id"].Value.ToString();
            staff.username = dataGridViewUsers.CurrentRow.Cells["User_Name"].Value.ToString();
            staff.userpas = dataGridViewUsers.CurrentRow.Cells["Password"].Value.ToString();

         
            if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "EditUser")
            {
               
                panelEditUsers.Visible = true;
                panelEditUsers.Show();

       //        panelEdit.Show();

                txtPassword.Text = staff.userpas;
                txtUserName.Text = staff.username;


            }
            else if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "DeleteUser")
            {
                DialogResult result = MessageBox.Show("Do you want to Remove User # " + staff.uid + " User Name: " + staff.username + " Password: " + staff.userpas + "  ?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Users set Status = 2 where User_Id = " + staff.uid + " ";

                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    // activity logs begin

                    string desc = "Remove User # " + staff.uid + " User Name: " + staff.username + " Password: " + staff.userpas;
                    //        ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }

            }

        }// datagrid click end 



       

    } // class end
} // name space end
