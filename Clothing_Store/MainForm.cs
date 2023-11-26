﻿using System;
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
       


        private void btnHome_Click(object sender, EventArgs e)
        {
            // button color
                btnHome.BackColor = Color.Salmon;
                btnproducts.BackColor = Color.White;
                btnStock.BackColor = Color.White;
                btnCustomers.BackColor = Color.White;
                btnOrders.BackColor = Color.White;
                btnAccount.BackColor = Color.White;

            // forms
            fc.Hide();
            fs.Hide();
            i.Hide();
            fa.Hide();

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

            // forms
            fc.Hide();
            fs.Hide();
            i.Show();
            fa.Hide();

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


            // forms
            i.Hide();
            fc.Hide();
            fs.Show();
            fa.Hide();


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




            // form
            i.Hide();
            fs.Hide();
            fc.Show();
            fa.Hide();

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
            btnOrders.BackColor = Color.Salmon;
            btnCustomers.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnStock.BackColor = Color.White;
            btnproducts.BackColor = Color.White;
            btnAccount.BackColor = Color.White;

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



            // form
            i.Hide();
            fs.Hide();
            fc.Hide();
            fa.Show();

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
