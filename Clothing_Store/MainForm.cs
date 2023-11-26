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

        private void btnHome_Click(object sender, EventArgs e)
        {
            
                btnHome.BackColor = Color.Salmon;
                btnproducts.BackColor = Color.White;
                btnStock.BackColor = Color.White;
                btnCustomers.BackColor = Color.White;

            mainpanel.Hide();
            i.Hide();

            panelRSide.Show();
            monthCalendar1.Show();
            pboxTshirt.Show();
          


        }

        FrmItems i = new FrmItems();
        private void btnproducts_Click(object sender, EventArgs e)
        {
            btnproducts.BackColor = Color.Salmon;
            btnHome.BackColor = Color.White;
            btnStock.BackColor = Color.White;
            btnCustomers.BackColor = Color.White;


            fc.Hide();
            fs.Hide();
           

            mainpanel.Controls.Clear();
            i.FormBorderStyle = FormBorderStyle.None;
            i.TopLevel = false;
            i.AutoScroll = true;
            i.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(i);


            mainpanel.Show();
            i.Show();
           


            panelRSide.Hide();
            monthCalendar1.Hide();
            pboxTshirt.Hide();

        }

        FrmStocks fs = new FrmStocks();
        private void btnStock_Click(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.Salmon;
            btnproducts.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnCustomers.BackColor = Color.White;


            i.Hide();
            fc.Hide();



            mainpanel.Controls.Clear();
            fs.FormBorderStyle = FormBorderStyle.None;
            fs.TopLevel = false;
            fs.AutoScroll = true;
            fs.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(fs);


            mainpanel.Show();
            fs.Show();
          

            panelRSide.Hide();
            monthCalendar1.Hide();
            pboxTshirt.Hide();

        }
        FrmCustomers fc = new FrmCustomers();
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.Salmon;
            btnHome.BackColor = Color.White;
            btnStock.BackColor = Color.White;
            btnStock.BackColor = Color.White;

            i.Hide();
            fs.Hide();

            mainpanel.Controls.Clear();
            fc.FormBorderStyle = FormBorderStyle.None;
            fc.TopLevel = false;
            fc.AutoScroll = true;
            fc.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(fc);

            mainpanel.Show();
            fc.Show();

         

            panelRSide.Hide();
            monthCalendar1.Hide();
            pboxTshirt.Hide();

        }

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
