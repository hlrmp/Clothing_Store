using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        } // main constructor end


        // forms instance 
        FrmItems i = new FrmItems();
        FrmStocks fs = new FrmStocks();
        FrmCustomers fc = new FrmCustomers();
        FrmAccounts fa = new FrmAccounts();
        FrmOrders fo = new FrmOrders();
        FrmReports fr = new FrmReports();
        FrmDelivery fd = new FrmDelivery();

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

        private void btnlogout_Click(object sender, EventArgs e)    // log out begin
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Exit ? ", "Log out", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }

        } // logout end 

     
    } // class end 
} // names space end
