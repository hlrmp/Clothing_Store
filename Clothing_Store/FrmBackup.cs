using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Store
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
            files();
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

        private void btnClose_Click(object sender, EventArgs e)  // close button begin
        {          
            this.Hide();
            
            
        } // close button end
 

        string getText;
        string getFileName;
        DirectoryInfo dinfo;
        public void files()
        {
            dinfo =  new DirectoryInfo(@"C:\Users\reichel domingo\Contacts\Desktop\MSSQL14.SQLEXPRESS02\MSSQL\Backup");

            FileInfo[] Files = dinfo.GetFiles();

            foreach (FileInfo file in Files)
            {
                lb1.Items.Add(file.Name);
                getFileName = file.Name;
            }
        }


// mouse click for the list box Begin

        private void lb1_MouseClick(object sender, MouseEventArgs e)
        {
            string path = @"C:\Users\reichel domingo\Contacts\Desktop\MSSQL14.SQLEXPRESS02\MSSQL\Backup\"+ getFileName;

            using (StreamReader streamReader = new StreamReader(path))
            {

                while ((getText = streamReader.ReadLine()) != null)
                {
                  
                    lb2.Items.Add(getText);
                    lb2.Visible = true;
                    lb1.Visible = false;

                }

                DialogResult dialog = MessageBox.Show("Do you want to Restore : " + getFileName,"Backup and Restore",MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    FrmRecovey fr = new FrmRecovey();
                    fr.ShowDialog();
                }
            }
        }

        private void lb1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string path = @"C:\Users\reichel domingo\Contacts\Desktop\MSSQL14.SQLEXPRESS02\MSSQL\Backup\" + getFileName;

            using (StreamReader streamReader = new StreamReader(path))
            {

                while ((getText = streamReader.ReadLine()) != null)
                {
                    lb2.Items.Add(getText);
                    lb2.Visible = true;
                    lb1.Visible = false;


                }

            }
        }
// mouse click for the list box end

        private void btnBackup_Click(object sender, EventArgs e) // backup button begin
        {
            //  DateTime currentDateTime = DateTime.Now;
            string TimeandDate = DateTime.Now.ToString("yyyy-MM-dd_T-HH:mm:ssss.fffffffK");


            MessageBox.Show(TimeandDate);

            string backup = "BACKUP DATABASE ClotingStoreDatabase TO DISK = 'C:\\Users\\reichel domingo\\Contacts\\Desktop\\MSSQL14.SQLEXPRESS02\\MSSQL\\Backup\\"+ TimeandDate  + ".bak' ";

        } // back up button end


    } // class end
} // name space end
