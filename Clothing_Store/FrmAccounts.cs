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
        
        // form instance
       
        FrmBackup fback = new FrmBackup();
        FrmRecovey frec = new FrmRecovey();
        FrmAddUser fuser = new FrmAddUser();
        FrmAddNewStaffs fstaf = new FrmAddNewStaffs();
        private void btnCreate_Click(object sender, EventArgs e)  //  add new user begin
        {
           
            panelAdd.Show();    
           

        } //  add new user end

    
        


        private void btnBackup_Click(object sender, EventArgs e)// btn backup begin
        {
            // pannel
         
            fback.ShowDialog();
           
           
        }  // btn bacup end 

        private void btnHomeAccounts_Click(object sender, EventArgs e) // home button begin
        {
            panelAdd.Hide();

        } // home buton end

       
        private void btnRecovery_Click(object sender, EventArgs e)  //  recovery button begin
        {
           

            frec.ShowDialog();

        } // recovery buton end

        private void btnAddNewStaff_Click(object sender, EventArgs e) // panel add staff begin 
        {

            fstaf.ShowDialog();
            panelAdd.Hide();

        }// panel add staff end 

        private void button1_Click(object sender, EventArgs e) // panel add user begin
        {
            fuser.ShowDialog();
            panelAdd.Hide();

        } // panel add user end


    } // class end
} // name space end
