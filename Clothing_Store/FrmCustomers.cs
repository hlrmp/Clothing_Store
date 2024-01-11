using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clothing_Store
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            seecustomers(); // see cutomers on the datagrid - load form
            total(); // total customers string lbltotal
            filter();// search filter
            searcCustomers();




        }

         

        FrmAddCustomer fadd = new FrmAddCustomer();
        private void btnAdd_Click(object sender, EventArgs e)  // add buton begin
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            fadd.ShowDialog();

            timer.Stop();

        } //add button end

        private void btnHomeCustomers_Click(object sender, EventArgs e) // home button begin
        {
            seecustomers();  // see cutomers on the datagrid - home button
            dataGridViewManage.Hide();
            dataGridView1.Hide();
            datagridviewHome.Show();

        } //  home button end

        public void seecustomers() // see customers begin - datagrid
        {   
      
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
          
               
                string sj = "select concat(First_Name,' ', Last_Name) AS Name, Contact_No, Email,  Address, Delivery_Address from Customers where Status = 1";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);
              
                datagridviewHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridviewHome.DataSource = table;

              

        } // see customers end - datagrid

        public void manageCustomers() // manage cusstomers begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select Customer_Id, First_Name, Last_Name, Contact_No, Email,  Address, Delivery_Address from Customers where Status = 1 ";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewManage.DataSource = table;



        } // manage cusstomers end - datagrid

        public void searcCustomers() // search cusstomers begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select First_Name, Last_Name, Contact_No, Email,  Address, Delivery_Address from Customers where Status = 1 ";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

          
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        } // search cusstomers end - datagrid


        public void seetotalcustomers()   // total customers begin - datagrid
        {
          
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            string sj = "select count(*)  AS 'Total Customers' from customers where Status = 1";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            datagridviewHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridviewHome.DataSource = table;

        } // total customers end - datagrid

        public void total()  // total customers - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*)  AS 'Total Customers' from customers where status = 1";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lbltotal.Text = reader[0].ToString();  // - total numbers

        }  // total customers - string

        private void btnTotal_Click(object sender, EventArgs e) // total button begin // no event 
        {
            seetotalcustomers(); // see numbers of customers - total 
            dataGridViewManage.Hide();
            datagridviewHome.Show();
            dataGridView1.Hide();
            
         

        } // total  button end // no event

        private void btnManage_Click(object sender, EventArgs e) // manage button beginn
        {
            dataGridViewManage.Show();
            dataGridView1.Hide();
            datagridviewHome.Hide();
            manageCustomers();

           

        } // mannage button end

        
     

        public void search() // search method begin
        {
           

            if (cbFilter.Text.ToString() == "First Name")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = " SELECT  First_Name, Last_Name, Contact_No, Email,  Address, Delivery_Address FROM Customers WHERE First_Name LIKE '" + sch + '%' + "' and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();
            }
            else if (cbFilter.Text.ToString() == "Last Name")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = " SELECT  First_Name, Last_Name, Contact_No, Email,  Address, Delivery_Address FROM Customers WHERE Last_Name LIKE '" + sch + '%' + "' and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();
            }
            else if (cbFilter.Text.ToString() == "Address")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = " SELECT  First_Name, Last_Name, Contact_No, Email,  Address, Delivery_Address FROM Customers WHERE Address LIKE '" + sch + '%' + "' and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();
            }
            else if (cbFilter.Text.ToString() == "Contact")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = " SELECT  First_Name, Last_Name, Contact_No, Email,  Address, Delivery_Address FROM Customers WHERE Contact_No LIKE '" + sch + '%' + "' and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();
            }
            else if (cbFilter.Text.ToString() == "Email")
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = " SELECT  First_Name, Last_Name, Contact_No, Email,  Address, Delivery_Address FROM Customers WHERE Email LIKE '" + sch + '%' + "' and Status = 1";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();
            }

            else
            {
                SqlConnection cn = new SqlConnection(ConnectionClass.conn);

                cn.Open();

                string sch = txtSearch.Text;

                string query = " SELECT  First_Name, Last_Name, Contact_No, Email,  Address, Delivery_Address FROM Customers WHERE First_Name LIKE '" + sch + '%' + "' and Status = 1";

               
                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


                cn.Close();
            }


        }  // search method end

        private void lblsearch_Click(object sender, EventArgs e)  // searc click begin
        {
            search();


        }  // search click end


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)  // search enter begin 
        {
            search();

        }  // search enter end

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)// text box mouse click begin
        {
            dataGridViewManage.Hide();
            datagridviewHome.Hide();
            dataGridView1.Show();

        } // text box mouse click end



        public void filter() // filter begin
        {
          

            ArrayList arr = new ArrayList();

            arr.Add("First Name");
            arr.Add("Last Name");
            arr.Add("Address");
            arr.Add("Contact");
            arr.Add("Email");

            foreach (string list in arr)
            {
                cbFilter.Items.Add(list);
            }
          
        } // filter end

    

        private void FrmCustomers_Load(object sender, EventArgs e) // form load begin
        {
          /*  this.txtSearch.Size = new System.Drawing.Size(243, 21);
            this.cbFilter.Size = new System.Drawing.Size(74, 20);

            this.txtSearch.Height = 21;*/

            this.txtSearch.AutoSize = false;
            this.txtSearch.Size = new System.Drawing.Size(243, 21);

            

            Timer timer = new Timer();
            timer.Interval = (5 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        } // form load eend

        private void timer1_Tick(object sender, EventArgs e) // timer begin
        {
            total();
            manageCustomers();
            dataGridViewManage.Refresh();
           
            lbltotal.Refresh();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            seecustomers();

        }// timer end



        private void dataGridViewManage_CellContentClick(object sender, DataGridViewCellEventArgs e)  // datagrid view button begin
        {
            customerClass cs = new customerClass();
            cs.First_Name = dataGridViewManage.CurrentRow.Cells["firstNameDataGridViewTextBoxColumn"].Value.ToString();
            cs.Last_Name = dataGridViewManage.CurrentRow.Cells["lastNameDataGridViewTextBoxColumn"].Value.ToString();
            cs.Contact_No = dataGridViewManage.CurrentRow.Cells["contactNoDataGridViewTextBoxColumn"].Value.ToString();
            cs.email = dataGridViewManage.CurrentRow.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
            cs.address = dataGridViewManage.CurrentRow.Cells["addressDataGridViewTextBoxColumn"].Value.ToString();
            cs.Delivery_Address = dataGridViewManage.CurrentRow.Cells["deliveryAddressDataGridViewTextBoxColumn"].Value.ToString();


            if (dataGridViewManage.Columns[e.ColumnIndex].Name == "Edit")
            {

                panelEdit.Visible = true;

                txtFname.Text = cs.First_Name;
                txtLname.Text = cs.Last_Name;
                txtContact.Text = cs.Contact_No;
                txtEmail.Text = cs.email;
                txtAddress.Text = cs.address;
                txtDeliveryAdd.Text = cs.Delivery_Address;

                save();

            }
            else if (dataGridViewManage.Columns[e.ColumnIndex].Name == "Delete")
            {
                    DialogResult result = MessageBox.Show("Do you want to Remove "+ cs.First_Name +" "+ cs.Last_Name + "?", "Delete", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                        cn.Open();

                        string quer = "UPDATE Customers SET Status = 2 WHERE First_Name = '" + cs.First_Name + "' and  Last_Name = '" +cs.Last_Name + "'  " +"and Contact_No = '" + cs.Contact_No + "'  and Email = '" + cs.email + "' and  Address = '" + cs.address + "' and Delivery_Address = '" + cs.Delivery_Address + "' ";               

                        SqlCommand command = new SqlCommand(quer, cn);                  
                        command.ExecuteNonQuery();
                        cn.Close();

                        // activity logs begin

                    //    string desc = "Delete Customer Information";
                    //    ConnectionClass.activity(frmLogin.userId, desc);

                        // activity logs end
                    }
                    else
                    {

                    }

            }

        } // datagrid view button end

        private void btnCancel_Click(object sender, EventArgs e)   // panel edit button cacel begin
        {
            panelEdit.Visible = false;

        } // panel edit button cancel end 


       // reg ex begin

        customerClass cs = new customerClass();

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

                cs.First_Name = FirstName;
            }

            else
            {
                throw new StringFormatException("please enter your First Name Correctly");
            }

            return cs.First_Name;
        }
        public string Lname(string LastName)
        {
            if (Regex.IsMatch(LastName, regexClass.letters))
            {
                LastName = Char.ToUpper(LastName[0]) + LastName.Substring(1);

                cs.Last_Name = LastName;


            }
            else
            {
                throw new StringFormatException("please enter your Last Name Correctly");
            }

            return cs.Last_Name;
        }
        public string Address(string address)
        {
            if (Regex.IsMatch(address, regexClass.mix))
            {

                cs.address = address;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return cs.address;
        }
        public string delAddress(string deladdress)
        {
            if (Regex.IsMatch(deladdress, regexClass.mix))
            {

                cs.Delivery_Address = deladdress;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return cs.Delivery_Address;
        }
        public string Email(string email)
        {
            if (Regex.IsMatch(email, regexClass.mix))
            {

                cs.email = email;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return cs.email;
        }

        class NumberFormatException : Exception
        {
            public NumberFormatException(string num) : base(num) { }
        }
        public string ContactNo(string contact)
        {

            if (Regex.IsMatch(contact, regexClass.numbers))
            {
                cs.Contact_No = contact;

            }
            else
            {
                throw new NumberFormatException("put contact number correctly");
            }
            return cs.Contact_No;
        }

        // reg ex end

        private void btnSave_Click(object sender, EventArgs e)  // save btn begin
        {


            try
            {
                if (string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text)
                    || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtDeliveryAdd.Text)
                    || string.IsNullOrEmpty(txtContact.Text) || string.IsNullOrEmpty(txtEmail.Text))
                {
                    throw new nullExceptiom("Please fill up the FF.");
                }
                else
                {


                    cs.First_Name = Fname(txtFname.Text);
                    cs.Last_Name = Lname(txtLname.Text);
                    cs.address = Address(txtAddress.Text);
                    cs.Delivery_Address = delAddress(txtDeliveryAdd.Text);
                    cs.Contact_No = ContactNo(txtContact.Text);
                    cs.email = Email(txtEmail.Text);

                    updateCustomers(cs.First_Name, cs.Last_Name, cs.email, cs.Contact_No, cs.address, cs.Delivery_Address); // update customers 

                    MessageBox.Show("Customer information was Updated", "Update  Customer", MessageBoxButtons.OK);

                    txtFname.Clear();
                    txtLname.Clear();
                    txtContact.Clear();
                    txtAddress.Clear();
                    txtDeliveryAdd.Clear();
                    txtEmail.Clear();

                    panelEdit.Hide();


                    // activity logs begin

                    string desc = "Update Customer Information";
                    ConnectionClass.activity(frmLogin.userId, desc);

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


        string customerId;
        public void save()  //  save begin
        {
            customerClass cs = new customerClass();
            SqlConnection con = new SqlConnection(ConnectionClass.conn);


            string sj = "select Customer_Id from Customers where Status = 1 and First_Name = '" + txtFname.Text + "' and  Last_Name = '" + txtLname.Text + "'  " +
              "and Contact_No = '" + txtContact.Text + "'  and Email = '" + txtEmail.Text + "' and  Address = '" + txtAddress.Text + "' and Delivery_Address = '" + txtDeliveryAdd.Text + "' ";

            con.Open();
            SqlCommand command;
            command = new SqlCommand(sj, con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            customerId = reader[0].ToString();
            con.Close();

        } // save end

        public bool updateCustomers(string FirstName, string LastName, string Email, string ContactNo, string Address, string DelAddress) // update the customer info begin
        {
            
            SqlConnection con = new SqlConnection(ConnectionClass.conn);
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Parameters.Clear();
            sqlCommand.Connection = con;
            sqlCommand.CommandText = "Update  Customers Set First_Name = @FirstName, Last_Name = @LastName, Contact_No =  @Contact, Email = @Email,  Address = @Address, Delivery_Address = @DelAddress where Customer_id = "+customerId+" ";

            sqlCommand.Parameters.Add("@FirstName", FirstName);
            sqlCommand.Parameters.Add("@LastName", LastName);
            sqlCommand.Parameters.Add("@Email", Email);
            sqlCommand.Parameters.Add("@Contact", ContactNo);
            sqlCommand.Parameters.Add("@Address", Address );
            sqlCommand.Parameters.Add("@DelAddress", DelAddress);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

            return true;
        } // update the customer info end

       
    } // class end
} // namespace end
