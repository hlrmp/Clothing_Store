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
            panelAccount.Hide();

            fadd.ShowDialog();

        } // create new user end

    
        


        private void btnBackup_Click(object sender, EventArgs e)// btn backup begin
        {
            // pannel

            panelAccount.Controls.Clear();
            fback.FormBorderStyle = FormBorderStyle.None;
            fback.TopLevel = false;
            fback.AutoScroll = true;
            fback.Dock = DockStyle.Fill;
            panelAccount.Controls.Add(fback);

            panelAccount.Show();

            fback.Show();

            
            
        }  // btn bacup end 

        private void btnHomeAccounts_Click(object sender, EventArgs e) // home button begin
        {
            panelAccount.Hide();

        } // home buton end

        FrmRecovey frec = new FrmRecovey();
        private void btnRecovery_Click(object sender, EventArgs e)  //  recovery button begin
        {
            panelAccount.Hide();

            panelAccount.Controls.Clear();
            frec.FormBorderStyle = FormBorderStyle.None;
            frec.TopLevel = false;
            frec.AutoScroll = true;
            frec.Dock = DockStyle.Fill;
            panelAccount.Controls.Add(frec);

            panelAccount.Show();

            frec.Show();

        } // recovery buton end



    } // class end
} // name space end
