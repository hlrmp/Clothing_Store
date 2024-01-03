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

        } // main constructor end


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
            mainpanel.Hide();
           

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

            mainpanel.Show();

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

            mainpanel.Show();
            
          
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

            mainpanel.Show();
          

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

            mainpanel.Show();


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

            mainpanel.Show();


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

            mainpanel.Show();


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

            mainpanel.Show();


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
        } // button delivery end


        string emp;
      
        public void employee()    // emp condition begin
        {
           emp = frmLogin.pos1;     
         //  emp = "Cashier";
            if (emp == "Cashier")
            {
                btnAccount.Visible = false; 
                lblAccount.Text = frmLogin.name + "  (" + emp + ")";

            }
            else if (emp == "Admin" || emp == "Manager")
            {
                btnAccount.Visible = true;
                lblAccount.Text = frmLogin.name + "  (" + emp + ")";
            }

        } // emp condition begin

        public void totalShorts()  // total  - string
        {
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string sj = "SELECT count(p.Type) FROM Products AS p \r\n" +
                "INNER JOIN Inventory AS i " +
                "ON (p.Product_Id = i.product_Id) Where Type like 'shorts'";

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
                "ON (p.Product_Id = i.product_Id) Where Type like 'polo'";

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
                "ON (p.Product_Id = i.product_Id) Where Type like 'tshirt'";

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

       
        private void btnLogoutAccount_Click(object sender, EventArgs e)  // log out account begin
        {
            panelAccount.Visible = true;


        }  // log out account  end

        private void btnLogout_Click(object sender, EventArgs e) // log out begin
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Exit ? ", "Log out", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                flog.Show();
                this.Hide();
                panelAccount.Visible = false;

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



         

        } // PictureBox click end

        private void lblAccount_MouseClick(object sender, MouseEventArgs e) // label name click beginn
        {
            panelAccount.Visible = true;

           

        } // label name click end

        private void btnbackupAndRecovery_Click(object sender, EventArgs e) // backup and recovery btn begin
        {
            FrmRecovey frec = new FrmRecovey();
            frec.ShowDialog();

        } // backup and recovery btn end

        private void btnArchives_Click(object sender, EventArgs e)
        {

        }
    } // class end 
} // names space end
