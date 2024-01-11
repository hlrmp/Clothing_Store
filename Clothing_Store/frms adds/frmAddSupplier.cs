using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Store.frms_adds
{
    public partial class frmAddSupplier : Form
    {
        public frmAddSupplier()
        {
            InitializeComponent();
            Supplier();
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
        customerClass cs = new customerClass();
        userClass uc = new userClass();

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

                uc.StaffFirstName = FirstName;
            }

            else
            {
                throw new StringFormatException("please enter your First Name Correctly");
            }

            return uc.StaffFirstName;
        }
        public string Lname(string LastName)
        {
            if (Regex.IsMatch(LastName, regexClass.letters))
            {
                LastName = Char.ToUpper(LastName[0]) + LastName.Substring(1);

                uc.StaffLastName = LastName;


            }
            else
            {
                throw new StringFormatException("please enter your Last Name Correctly");
            }

            return uc.StaffLastName;
        }
        public string Position(string position)
        {
            if (Regex.IsMatch(position, regexClass.letters))
            {

                position = Char.ToUpper(position[0]) + position.Substring(1);

                uc.StaffPosition = position;
            }

            else
            {
                throw new StringFormatException("please enter your Position Correctly");
            }

            return uc.StaffPosition;
        }
        public string Address(string address)
        {
            if (Regex.IsMatch(address, regexClass.mix))
            {

                uc.StaffAddress = address;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return uc.StaffAddress;
        }
        public string Email(string email)
        {
            if (Regex.IsMatch(email, regexClass.mix))
            {

                uc.staffEmail = email;
            }
            else
            {
                throw new StringFormatException("please enter your Address Correctly");
            }

            return uc.staffEmail;
        }

        class NumberFormatException : Exception
        {
            public NumberFormatException(string num) : base(num) { }
        }
        public string ContactNo(string contact)
        {

            if (Regex.IsMatch(contact, regexClass.numbers))
            {
                uc.StaffConntacNo = contact;

            }
            else
            {
                throw new NumberFormatException("put contact number correctly");
            }
            return uc.StaffConntacNo;
        }

        // reg ex end


        public void add() // add begin
        {

            try
            {
                if (string.IsNullOrEmpty(txtName.Text)
                    || string.IsNullOrEmpty(txtAddress.Text)
                    || string.IsNullOrEmpty(txtContactNo.Text) 
                    || string.IsNullOrEmpty(txtEmail.Text))
                {

                    throw new nullExceptiom("Please fill up the FF.");

                }
                else
                {
                    if (SuppCondition == "same")
                    {
                        throw new nullExceptiom("Supplier Existing");
                    }
                    else if (SuppCondition == "notsame")
                    {
                        uc.StaffFirstName = Fname(txtName.Text);
                        uc.staffEmail = Email(txtEmail.Text);
                        uc.StaffAddress = Address(txtAddress.Text);
                        uc.StaffConntacNo = ContactNo(txtContactNo.Text);

                        string name = uc.StaffFirstName;

                        SqlConnection con = new SqlConnection(ConnectionClass.conn);

                        string quer1 = "insert into Supplier ( Supplier_Name, Address, Contact_No, Email ,Status) values (  @Supplier_Name, @Address,  @Contact_No, @Email,  @Status) ";
                        SqlCommand command = new SqlCommand(quer1, con);

                        command.Parameters.AddWithValue("@Supplier_Name", name);
                        command.Parameters.AddWithValue("@Address", uc.StaffAddress);
                        command.Parameters.AddWithValue("@Contact_No", uc.StaffConntacNo);
                        command.Parameters.AddWithValue("@Email", uc.staffEmail);
                        command.Parameters.AddWithValue("@Status", "1");
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();


                        MessageBox.Show("New Supplier Added succesfully", "Supplier", MessageBoxButtons.OK);

                        Supplier();
                        clear();

                        // activity logs begin

                        string desc = "Add New Supplier";
                        //   ConnectionClass.activity(frmLogin.userId, desc);

                        // activity logs end


                    }


                }// outer else end


            } // try
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
        } // add end
        public void edit() // edit begin
        {

            try
            {
                if (string.IsNullOrEmpty(txtEditName.Text)
                    || string.IsNullOrEmpty(txtEditAddress.Text)
                    || string.IsNullOrEmpty(txtEditContact.Text)
                    || string.IsNullOrEmpty(txtEditEmail.Text))
                {

                    throw new nullExceptiom("Please fill up the FF.");

                }
                else
                {
                    if (SuppCondition1 == "same")
                    {
                        throw new nullExceptiom("Name Already Exist");
                    }
                    else if (SuppCondition1 == "notsame")
                    {
                        uc.StaffFirstName = Fname(txtEditName.Text);
                        uc.staffEmail = Email(txtEditEmail.Text);
                        uc.StaffAddress = Address(txtEditAddress.Text);
                        uc.StaffConntacNo = ContactNo(txtEditContact.Text);

                        string name = uc.StaffFirstName;

                        SqlConnection con = new SqlConnection(ConnectionClass.conn);

                        string quer1 = "Update Supplier  Set Supplier_Name = @Supplier_Name, Address = @Address, Contact_No = @Contact_No, Email = @Email  where Supplier_Id = "+sc.Id+" ";
                        SqlCommand command = new SqlCommand(quer1, con);

                        command.Parameters.AddWithValue("@Supplier_Name", name);
                        command.Parameters.AddWithValue("@Address", uc.StaffAddress);
                        command.Parameters.AddWithValue("@Contact_No", uc.StaffConntacNo);
                        command.Parameters.AddWithValue("@Email", uc.staffEmail);
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();


                        MessageBox.Show("Supplier Informatio Updated succesfully", "Update", MessageBoxButtons.OK);

                        Supplier();
                        clear();

                        panelEdit.Visible = false;
                        panelAdd.Visible = true;

                        // activity logs begin

                        string desc = "Update Supplier Information" + name;
                        ConnectionClass.activity(frmLogin.userId, desc);

                        // activity logs end


                    }


                }// outer else end


            } // try
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
        } // edit end

        private void btnAdd_Click(object sender, EventArgs e)  // Add btn begin
        {
            supp();
            add();

        } // Add btn end

        private void Cancel_Click(object sender, EventArgs e)  // cancel btn begin
        {
            clear();

        } // cancel btn end

        private void btnHome_Click(object sender, EventArgs e)  // Home btn begin
        {
            dataGridViewHome.Visible = true;
            dataGridViewManage.Visible = false;
            dataGridViewHome.Show();
            Supplier();

        } // Home btn
        private void btnManage_Click(object sender, EventArgs e) // btn manage begin
        {
            dataGridViewHome.Visible = false;
            dataGridViewManage.Visible = true;

            manageSupplier();

        } // btn manage end
        private void btnCaancelEdit_Click(object sender, EventArgs e) // btn cance edit begin
        {
            panelEdit.Visible = false;
            panelAdd.Visible = true;

        } // btn cancel edit end
        private void btnConfirm_Click(object sender, EventArgs e) // btn confirm begin
        {
         
            supp1();
            edit();
            manageSupplier();

        }// btn confirm end

        supplierClass sc = new supplierClass();
        private void dataGridViewManage_CellContentClick(object sender, DataGridViewCellEventArgs e)  // datagrid manage click begin
        {
          

            sc.Supplier_Name = dataGridViewManage.CurrentRow.Cells["SupName"].Value.ToString();
            sc.Contact_No = dataGridViewManage.CurrentRow.Cells["Contact"].Value.ToString();
            sc.address = dataGridViewManage.CurrentRow.Cells["Addres"].Value.ToString();
            sc.email = dataGridViewManage.CurrentRow.Cells["Em"].Value.ToString();
            sc.Id = dataGridViewManage.CurrentRow.Cells["Id"].Value.ToString();

            if (dataGridViewManage.Columns[e.ColumnIndex].Name == "Edit")
            {

                panelEdit.Visible = true;
                panelAdd.Visible = false;

                txtEditName.Text = sc.Supplier_Name;
                txtEditContact.Text = sc.Contact_No;
                txtEditAddress.Text = sc.address;
                txtEditEmail.Text = sc.email;

            }
            else if (dataGridViewManage.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do you want to Remove " +sc.Supplier_Name +"?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                    cn.Open();

                    string quer = "UPDATE Supplier SET Status = 2 WHERE Supplier_Id = " + sc.Id +" ";
                    SqlCommand command = new SqlCommand(quer, cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                    Supplier();

                    // activity logs begin

                    string desc = "Delete Supplier Information - " + sc.Id;
                        ConnectionClass.activity(frmLogin.userId, desc);

                    // activity logs end
                }
                else
                {

                }
            }

        } // datagrid manage click end
        private void btnExit_Click(object sender, EventArgs e) // exit btn begin
        {
            DialogResult dl = MessageBox.Show("Do you want to Exit?","Close",MessageBoxButtons.OKCancel);
            if (dl == DialogResult.OK)
            {
                this.Hide();
                clear();
              
            }
            else
            {

            }
           
        } // Exit btn end
        public void clear()
        {
            txtAddress.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtName.Clear();
        }

    public void Supplier() // Supplier begin
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string names = "select Supplier_Name , Contact_No , Email AS email , Address AS address from Supplier where Status = 1";
            SqlDataAdapter adapt = new SqlDataAdapter(names, con);

            DataTable dataTable = new DataTable();
            BindingSource bindingSource = new BindingSource();
            dataTable.Clear();
            adapt.Fill(dataTable);
            bindingSource.DataSource = dataTable;


            dataGridViewHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHome.DataSource = dataTable;

        } // supplier end
        public void manageSupplier() // Supplier begin
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string names = "select Supplier_Id as Id, Supplier_Name , Contact_No , Email AS email , Address AS address from Supplier where Status = 1";
            SqlDataAdapter adapt = new SqlDataAdapter(names, con);

            DataTable dataTable = new DataTable();
            BindingSource bindingSource = new BindingSource();
            dataTable.Clear();
            adapt.Fill(dataTable);
            bindingSource.DataSource = dataTable;


            dataGridViewManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewManage.DataSource = dataTable;

        } // supplier end
        string SuppCondition;
        public void supp() // supplier confirm begin
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string sj = "select * from Supplier where Supplier_Name = '"+txtName.Text+"' ";

            con.Open();
            SqlCommand command;
            command = new SqlCommand(sj, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                SuppCondition = "same";
              //  MessageBox.Show("same");
            }
            else
            {
                SuppCondition = "notsame";
            //    MessageBox.Show("not");
            }

            con.Close();

        } // supplier confirm end
        string SuppCondition1;
        public void supp1() // supplier confirm begin
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);

            string sj = "select * from Supplier where Supplier_Name = '" + txtEditName.Text + "' ";

            con.Open();
            SqlCommand command;
            command = new SqlCommand(sj, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                SuppCondition1 = "same";
            }
            else
            {
                SuppCondition1 = "notsame";

            }

            con.Close();

        } // supplier confirm end




    } // class end
} // name space end
