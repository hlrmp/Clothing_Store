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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

          
            totalShorts();
            totalPolo();
            totalTshirt();
            totalBlouse();
            totalCollections();
            totalPantsJeans();
            totalPoloShirt();
            seeDeliveryIntransit();


        } // main constructor end

        string emp;

        public void employee()    // emp condition begin
        {
            emp = frmLogin.pos1;
            //  emp = "Cashier";
            if (emp == "Cashier")
            {
                btnAccount.Visible = false;
                // btnArchives.Visible = false;
                btnAbout.Visible =  true;
                btnSettingArchives.Visible = false;

                lblAccount.Text = frmLogin.name + "  (" + emp + ")";

            }
            else if (emp == "Admin" || emp == "Manager")
            {
                btnAccount.Visible = true;
              //  btnArchives.Visible = true;
                btnAbout.Visible = true;
                btnSettingArchives.Visible = true;


                lblAccount.Text = frmLogin.name + "  (" + emp + ")";


            }

        } // emp condition begin




        // forms instance 
        FrmItems i = new FrmItems();
        FrmStocks fs = new FrmStocks();
        FrmCustomers fc = new FrmCustomers();
        FrmAccounts fa = new FrmAccounts();
        FrmOrders fo = new FrmOrders();
        FrmReports fr = new FrmReports();
        FrmDelivery fd = new FrmDelivery();
        frmLogin flog = new frmLogin();
        userClass uc = new userClass();


        private void btnHome_Click(object sender, EventArgs e)
        {
            // button color
                btnHome.BackColor = Color.Salmon;
                btnproducts.BackColor = Color.White;
                btnStock.BackColor = Color.White;
                btnCustomers.BackColor = Color.White;
                btnOrders.BackColor = Color.White;
                btnAccount.BackColor = Color.White;
                btnReports.BackColor = Color.White;
                btnDelivery.BackColor = Color.White;
                btnLogoutAccount.BackColor = Color.White;
  

            // forms
            fc.Hide();
            fs.Hide();
            i.Hide();
            fa.Hide();
            fo.Hide();
            fr.Hide();
            fd.Hide();

            // pannel and forms
         
           
           
            mainpanel.Visible = false;
            panelHome.Visible = true;

            panelRSide.Show();
            monthCalendar1.Show();
            panelAccount.Hide();


            // picture boxes
            pboxTshirt.Show();
            pboxPoloshirt.Show();
            pboxPants.Show();
            pboxShorts.Show();
            pboxPolo.Show();
            pboxCollecton.Show();

            pbBlouse.Show();
            label7.Show();
            lblTotalBlouse.Show();

            // labels and total
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            lblTotalCollection.Show();
            lblTotalPants.Show();
            lblTotalPolo.Show();
            lblTotalPoloShirt.Show();
            lblTotalShorts.Show();
            lblTotalTshirt.Show();



        }

     
        private void btnproducts_Click(object sender, EventArgs e)
        {
            
            // button color
            btnproducts.BackColor = Color.Salmon;
            btnHome.BackColor = Color.White;
            btnStock.BackColor = Color.White;
            btnCustomers.BackColor = Color.White;
            btnOrders.BackColor = Color.White;
            btnAccount.BackColor = Color.White;
            btnReports.BackColor = Color.White;
            btnDelivery.BackColor = Color.White;
            btnLogoutAccount.BackColor = Color.White;
           

            // forms
            fc.Hide();
            fs.Hide();
            i.Show();
            fa.Hide();
            fo.Hide();
            fr.Hide();
            fd.Hide();

            // pannel
            mainpanel.Controls.Clear();
            i.FormBorderStyle = FormBorderStyle.None;
            i.TopLevel = false;
            i.AutoScroll = true;
            i.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(i);

            mainpanel.Visible = true;
            panelHome.Visible = false;

            panelRSide.Hide();
            monthCalendar1.Hide();
            panelAccount.Hide();



            // picture boxes
            pboxTshirt.Hide();
            pboxPoloshirt.Hide();
            pboxPants.Hide();
            pboxShorts.Hide();
            pboxPolo.Hide();
            pboxCollecton.Hide();
            pbBlouse.Hide();

            // labels and total
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            lblTotalCollection.Hide();
            lblTotalPants.Hide();
            lblTotalPolo.Hide();
            lblTotalPoloShirt.Hide();
            lblTotalShorts.Hide();
            lblTotalTshirt.Hide();
            label7.Hide();
            lblTotalBlouse.Hide();


        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            // button color
            btnStock.BackColor = Color.Salmon;
            btnproducts.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnCustomers.BackColor = Color.White;
            btnOrders.BackColor = Color.White;
            btnAccount.BackColor = Color.White;
            btnReports.BackColor = Color.White;
            btnDelivery.BackColor = Color.White;
            btnLogoutAccount.BackColor = Color.White;
          

            // forms
            i.Hide();
            fc.Hide();
            fs.Show();
            fa.Hide();
            fo.Hide();
            fr.Hide();
            fd.Hide();

            // pannel
            mainpanel.Controls.Clear();
            fs.FormBorderStyle = FormBorderStyle.None;
            fs.TopLevel = false;
            fs.AutoScroll = true;
            fs.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(fs);

            mainpanel.Visible = true;
            panelHome.Visible = false;


            panelRSide.Hide();
            monthCalendar1.Hide();
            panelAccount.Hide();



            // picture boxes
            pboxTshirt.Hide();
            pboxPoloshirt.Hide();
            pboxPants.Hide();
            pboxShorts.Hide();
            pboxPolo.Hide();
            pboxCollecton.Hide();

            // labels and total
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            lblTotalCollection.Hide();
            lblTotalPants.Hide();
            lblTotalPolo.Hide();
            lblTotalPoloShirt.Hide();
            lblTotalShorts.Hide();
            lblTotalTshirt.Hide();

            pbBlouse.Hide();
            label7.Hide();
            lblTotalBlouse.Hide();


        }

        private void btnCustomers_Click(object sender, EventArgs e) // btnCustomers begin
        {
            // button color
            btnCustomers.BackColor = Color.Salmon;
            btnHome.BackColor = Color.White;
            btnStock.BackColor = Color.White;
            btnproducts.BackColor = Color.White;
            btnOrders.BackColor = Color.White;
            btnAccount.BackColor = Color.White;
            btnReports.BackColor = Color.White;
            btnDelivery.BackColor = Color.White;
            btnLogoutAccount.BackColor = Color.White;



            // form
            i.Hide();
            fs.Hide();
            fc.Show();
            fa.Hide();
            fo.Hide();
            fr.Hide();
            fd.Hide();

            // pannel
            mainpanel.Controls.Clear();
            fc.FormBorderStyle = FormBorderStyle.None;
            fc.TopLevel = false;
            fc.AutoScroll = true;
            fc.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(fc);

            mainpanel.Visible = true;
            panelHome.Visible = false;


            panelRSide.Hide();
            monthCalendar1.Hide();
            panelAccount.Hide();



            // picture boxes
            pboxTshirt.Hide();
            pboxPoloshirt.Hide();
            pboxPants.Hide();
            pboxShorts.Hide();
            pboxPolo.Hide();
            pboxCollecton.Hide();

            // labels and total
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            lblTotalCollection.Hide();
            lblTotalPants.Hide();
            lblTotalPolo.Hide();
            lblTotalPoloShirt.Hide();
            lblTotalShorts.Hide();
            lblTotalTshirt.Hide();

            pbBlouse.Hide();
            label7.Hide();
            lblTotalBlouse.Hide();


        } // btnCustomers end 



        private void btnOrders_Click(object sender, EventArgs e)  // btnOrders begin
        {
            // button color
            btnOrders.BackColor = Color.Salmon;
            btnCustomers.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnStock.BackColor = Color.White;
            btnproducts.BackColor = Color.White;
            btnAccount.BackColor = Color.White;
            btnReports.BackColor = Color.White;
            btnDelivery.BackColor = Color.White;
            btnLogoutAccount.BackColor = Color.White;
          

            // form
            i.Hide();
            fs.Hide();
            fc.Hide();
            fa.Hide();
            fo.Show();
            fr.Hide();
            fd.Hide();

            // pannel
            mainpanel.Controls.Clear();
            fo.FormBorderStyle = FormBorderStyle.None;
            fo.TopLevel = false;
            fo.AutoScroll = true;
            fo.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(fo);

            mainpanel.Visible = true;
            panelHome.Visible = false;

            panelRSide.Hide();
            monthCalendar1.Hide();
            panelAccount.Hide();



            // picture boxes
            pboxTshirt.Hide();
            pboxPoloshirt.Hide();
            pboxPants.Hide();
            pboxShorts.Hide();
            pboxPolo.Hide();
            pboxCollecton.Hide();

            // labels and total
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            lblTotalCollection.Hide();
            lblTotalPants.Hide();
            lblTotalPolo.Hide();
            lblTotalPoloShirt.Hide();
            lblTotalShorts.Hide();
            lblTotalTshirt.Hide();

            pbBlouse.Hide();
            label7.Hide();
            lblTotalBlouse.Hide();


        } //btnOrders end

        private void btnAccount_Click(object sender, EventArgs e) // btnAccount begin
        {
            // buton color
            btnAccount.BackColor = Color.Salmon;
            btnOrders.BackColor = Color.White;
            btnCustomers.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnStock.BackColor = Color.White;
            btnproducts.BackColor = Color.White;
            btnReports.BackColor = Color.White;
            btnDelivery.BackColor = Color.White;
            btnLogoutAccount.BackColor = Color.White;
           

            // form
            i.Hide();
            fs.Hide();
            fc.Hide();
            fa.Show();
            fo.Hide();
            fr.Hide();
            fd.Hide();

            // pannel
            mainpanel.Controls.Clear();
            fa.FormBorderStyle = FormBorderStyle.None;
            fa.TopLevel = false;
            fa.AutoScroll = true;
            fa.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(fa);

            mainpanel.Visible = true;
            panelHome.Visible = false;


            panelRSide.Hide();
            monthCalendar1.Hide();
            panelAccount.Hide();



            // picture boxes
            pboxTshirt.Hide();
            pboxPoloshirt.Hide();
            pboxPants.Hide();
            pboxShorts.Hide();
            pboxPolo.Hide();
            pboxCollecton.Hide();

            // labels and total
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            lblTotalCollection.Hide();
            lblTotalPants.Hide();
            lblTotalPolo.Hide();
            lblTotalPoloShirt.Hide();
            lblTotalShorts.Hide();
            lblTotalTshirt.Hide();

            pbBlouse.Hide();
            label7.Hide();
            lblTotalBlouse.Hide();


        } // btnAccount end


        private void btnReports_Click(object sender, EventArgs e) // button reports begin
        {
            // buton color

            btnReports.BackColor = Color.Salmon;
            btnAccount.BackColor = Color.White;
            btnOrders.BackColor = Color.White;
            btnCustomers.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnStock.BackColor = Color.White;
            btnproducts.BackColor = Color.White;
            btnDelivery.BackColor = Color.White;
            btnLogoutAccount.BackColor = Color.White;
           

            // form
            i.Hide();
            fs.Hide();
            fc.Hide();
            fa.Hide();
            fo.Hide();
            fr.Show();
            fd.Hide();


            // pannel
            mainpanel.Controls.Clear();
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.TopLevel = false;
            fr.AutoScroll = true;
            fr.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(fr);

            mainpanel.Visible = true;
            panelHome.Visible = false;

            panelRSide.Hide();
            monthCalendar1.Hide();
            panelAccount.Hide();



            // picture boxes
            pboxTshirt.Hide();
            pboxPoloshirt.Hide();
            pboxPants.Hide();
            pboxShorts.Hide();
            pboxPolo.Hide();
            pboxCollecton.Hide();

            // labels and total
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            lblTotalCollection.Hide();
            lblTotalPants.Hide();
            lblTotalPolo.Hide();
            lblTotalPoloShirt.Hide();
            lblTotalShorts.Hide();
            lblTotalTshirt.Hide();

            pbBlouse.Hide();
            label7.Hide();
            lblTotalBlouse.Hide();


        } // button reports end


        private void btnDelivery_Click(object sender, EventArgs e) // button delivery begin
        {
            

            // buton color
        
            btnDelivery.BackColor = Color.Salmon;
            btnReports.BackColor = Color.White;
            btnAccount.BackColor = Color.White;
            btnOrders.BackColor = Color.White;
            btnCustomers.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnStock.BackColor = Color.White;
            btnproducts.BackColor = Color.White;
            btnLogoutAccount.BackColor = Color.White;


            // form
            i.Hide();
            fs.Hide();
            fc.Hide();
            fa.Hide();
            fo.Hide();
            fr.Hide();
            fd.Show();

            // pannel
            mainpanel.Controls.Clear();
            fd.FormBorderStyle = FormBorderStyle.None;
            fd.TopLevel = false;
            fd.AutoScroll = true;
            fd.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(fd);

            mainpanel.Visible = true;
            panelHome.Visible = false;


            panelRSide.Hide();
            monthCalendar1.Hide();
            panelAccount.Hide();


            // picture boxes
            pboxTshirt.Hide();
            pboxPoloshirt.Hide();
            pboxPants.Hide();
            pboxShorts.Hide();
            pboxPolo.Hide();
            pboxCollecton.Hide();

            // labels and total
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            lblTotalCollection.Hide();
            lblTotalPants.Hide();
            lblTotalPolo.Hide();
            lblTotalPoloShirt.Hide();
            lblTotalShorts.Hide();
            lblTotalTshirt.Hide();

            pbBlouse.Hide();
            label7.Hide();
            lblTotalBlouse.Hide();


        } // button delivery end



        public void totalShorts()  // total  - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "SELECT count(p.Type) FROM Products AS p \r\n" +
                "INNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id) Where Type = 'shorts' and p.status = 1";

            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalShorts.Text = reader[0].ToString();  // - total numbers

        }  // total  - string
        public void totalPolo()  // total  - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "SELECT count(p.Type) FROM Products AS p \r\n" +
                "INNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id) Where Type = 'polo'  and p.status = 1";

            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalPolo.Text = reader[0].ToString();  // - total numbers

        }  // total  - string
        public void totalTshirt()  // total  - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "SELECT count(p.Type) FROM Products AS p \r\n" +
                "INNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id) Where Type = 'tshirt'  and p.status = 1";

            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalTshirt.Text = reader[0].ToString();  // - total numbers

        }  // total  - string
        public void totalPoloShirt()  // total  - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "SELECT count(p.Type) FROM Products AS p \r\n" +
                "INNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id) Where Type = 'poloshirt'  and p.status = 1";

            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalPoloShirt.Text = reader[0].ToString();  // - total numbers

        }  // total  - string
        public void totalPantsJeans()  // total  - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "SELECT count(p.Type) FROM Products AS p \r\n" +
                "INNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id) Where Type = 'Pants/Jeans'  and p.status = 1";

            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalTshirt.Text = reader[0].ToString();  // - total numbers

        }  // total  - string
        public void totalCollections()  // total  - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "SELECT count(p.Type) FROM Products AS p \r\n" +
                "INNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id) Where Type = 'collections'  and p.status = 1";

            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalCollection.Text = reader[0].ToString();  // - total numbers

        }  // total  - string
        public void totalBlouse()  // total  - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "SELECT count(p.Type) FROM Products AS p \r\n" +
                "INNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id) Where Type = 'blouse'  and p.status = 1";

            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            lblTotalTshirt.Text = reader[0].ToString();  // - total numbers

        }  // total  - string

        private void MainForm_Load(object sender, EventArgs e)  // frm load begin
        {
            employee();
        }  // frm load end

        Timer timer = new Timer();
        private void btnLogoutAccount_Click(object sender, EventArgs e)  // log out account begin
        {
            panelAccount.Visible = true;

           // panelAccount.Show();
            // panelRSide.Visible = false;


            timer.Interval = (4 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        }  // log out account  end

        private void btnLogout_Click(object sender, EventArgs e) // log out begin
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Exit ? ", "Log out", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                flog.Show();
                this.Hide();
                panelAccount.Visible = false;
                panelRSide.Visible = true;

                // activity logs begin

                string desc = "Log out - " + frmLogin.name;
                ConnectionClass.activity(frmLogin.userId, desc);

                // activity logs end

            }
            else
            {

            }
        }// log out end

        private void pictureBoxProfile_MouseClick(object sender, MouseEventArgs e) // PictureBox click begin
        {
            panelAccount.Visible = true;
            panelRSide.Visible = false;





        } // PictureBox click end

        private void lblAccount_MouseClick(object sender, MouseEventArgs e) // label name click beginn
        {
            panelAccount.Visible = true;
            panelRSide.Visible = false;



        } // label name click end

        private void btnbackupAndRecovery_Click(object sender, EventArgs e) // backup and recovery btn begin
        {
            FrmRecovey frec = new FrmRecovey();
            frec.ShowDialog();

            panelAccount.Hide();
            panelRSide.Visible = true;


        } // backup and recovery btn end


        private void btnSettingArchives_Click(object sender, EventArgs e)// btn settings archives begin
        {
            frmArchives fa = new frmArchives();
            fa.ShowDialog();

            panelAccount.Hide();
            panelRSide.Visible = true;

        } // btn settings archives end

        private void btnAbout_Click(object sender, EventArgs e) // btn Account in settings begin
        {
            frmUserAccountManagement fu = new frmUserAccountManagement();
            fu.ShowDialog();

            panelAccount.Hide();
            panelRSide.Visible = true;

        } // btn Account in settings end

        private void timer1_Tick(object sender, EventArgs e) // timer begin
        {
            panelAccount.Hide();
            panelRSide.Visible = true;

        }// timer end

        private void lblAccount_Click(object sender, EventArgs e) // acc btn begin
        {
            panelAccount.Visible = true;

           // panelAccount.Show();
           panelRSide.Visible = true;

             
            timer.Interval = (4 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        }// acc btn end

        private void pictureBoxProfile_Click(object sender, EventArgs e) // profile click begin
        {
            panelAccount.Visible = true;

           // panelAccount.Show();
            panelRSide.Visible = true;

          
            timer.Interval = (4 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        } // profile click end

        public void totalPending()  // total delivery - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*) as total from Delivery where Status = 'pending'";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            llblTotal.Text = reader[0].ToString();  // - total numbers

        }  // total delivery - string
        public void Delivery()  // total delivery - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*) as total from Delivery where Status = 'delivered'";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            llblTotal.Text = reader[0].ToString();  // - total numbers

        }  // total delivery - string
        public void totalIntrnsit()  // total delivery - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "select count(*) as total from Delivery where Status = 'intransit'";
            sqlcc.Open();
            SqlCommand command;
            command = new SqlCommand(sj, sqlcc);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            llblTotal.Text = reader[0].ToString();  // - total numbers

        }  // total delivery - string

        public void seeDeliveryIntransit() // see delivery begin - datagrid
        {
          
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

                string sj = "select concat(c.First_Name ,' ', c.Last_Name ) as 'Customer Name' ,  d.Description as 'Description' from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'intransit' ";
                SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
                DataTable table = new DataTable();

                data.Fill(table);

                dataGridViewDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDelivery.DataSource = table;

                btnIntransit.BackColor = Color.CornflowerBlue;
                btnPending.BackColor = Color.Teal;
                totalIntrnsit();
         

        } // see delivery end - datagrid
        public void seeDeliveryPending() // see delivery begin - datagrid
        {

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

            string sj = "select concat(c.First_Name ,' ', c.Last_Name ) as 'Customer Name' ,  d.Description as 'Description' from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'pending' ";
            SqlDataAdapter data = new SqlDataAdapter(sj, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridViewDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDelivery.DataSource = table;


            btnIntransit.BackColor = Color.Teal;
            btnPending.BackColor = Color.CornflowerBlue;
            totalPending();


        } // see delivery end - datagrid

        private void btnPending_Click(object sender, EventArgs e) // btn pending begin
        {
            seeDeliveryPending();

        }// bnt pending end

        private void btnIntransit_Click(object sender, EventArgs e) // btn intransit begin
        {
            seeDeliveryIntransit();

        } // btn Intransit end

    } // class end 
} // names space end
