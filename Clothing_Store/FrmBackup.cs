using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            dinfo =  new DirectoryInfo(@"C:\Users\reichel domingo\Contacts\Desktop\MSSQL14.SQLEXPRESS02\MSSQL\Sample_Backup");

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
            string path = @"C:\Users\reichel domingo\Contacts\Desktop\MSSQL14.SQLEXPRESS02\MSSQL\Sample_Backup\"+ getFileName;

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

        private void lb1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string path = @"C:\Users\reichel domingo\Contacts\Desktop\MSSQL14.SQLEXPRESS02\MSSQL\Sample_Backup\" + getFileName;

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

        public void backup() // back up begin
        {
            string TimeandDate = DateTime.Now.ToString("yyyy-MM-ddT-HH:mm:ssss");
            string n = "bac";

            SqlConnection Conn = new SqlConnection(ConnectionClass.conn);

            string backup = "BACKUP DATABASE ClothingStoreDatabase TO DISK = 'C:\\Users\\reichel domingo\\Contacts\\Desktop\\MSSQL14.SQLEXPRESS02\\MSSQL\\Sample_Backup\\" + TimeandDate + ".bak' ";
            SqlCommand command1 = new SqlCommand(backup, Conn);

            string insBackup = "insert into BackupList (Name, Date,User_Id,Status) values (@Name, getDate(), @UserId, @Status)";
            SqlCommand command = new SqlCommand(insBackup, Conn);

            command.Parameters.AddWithValue("@Name", TimeandDate);
            command.Parameters.AddWithValue("@Status", 1);
            command.Parameters.AddWithValue("@UserId", frmLogin.userId);

            Conn.Open();

            command1.ExecuteNonQuery();
            command.ExecuteNonQuery();

            Conn.Close();


        } // back up end 
        private void btnBackup_Click(object sender, EventArgs e) // backup button begin
        {
            backup();

            // activity logs begin

            string desc = "Backup Data - " + frmLogin.name;
            ConnectionClass.activity(frmLogin.userId, desc);

            // activity logs end


        } // back up button end


    } // class end
} // name space end
