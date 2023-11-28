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
    public partial class FrmAccounts : Form
    {
        public FrmAccounts()
        {
            InitializeComponent();
        }
        FrmAddUser fadd = new FrmAddUser(); // add user instance
        FrmBackup fback = new FrmBackup();
        private void btnCreate_Click(object sender, EventArgs e)  // create new user begin
        {
            fadd.ShowDialog();
        } // create new user end


        private void btnBackup_Click(object sender, EventArgs e)// btn backup begin
        {
            // pannel
            panel1.Controls.Clear();
            fback.FormBorderStyle = FormBorderStyle.None;
            fback.TopLevel = false;
            fback.AutoScroll = true;
            fback.Dock = DockStyle.Fill;
            panel1.Controls.Add(fback);

            panel1.Show();

            fback.Show();
            
        }  // btn bacup end 

        private void btnHomeAccounts_Click(object sender, EventArgs e) // home button begin
        {
            panel1.Hide();

        } // home buton end



    } // class end
} // name space end
