using System;
using System.Collections;
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
    public partial class FrmRecovey : Form
    {
        public FrmRecovey()
        {
            InitializeComponent();
            list();
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

        private void btnCancel_Click(object sender, EventArgs e) //  cancel utton begin
        {
            this.Hide();

        } // cancel button end


        public void list() // search method begin
        {
            SqlConnection cn = new SqlConnection(ConnectionClass.conn);

            cn.Open();

            string query = "select Name , Date , User_Id from BackupList where Status = 1\r\n";

                SqlDataAdapter adapt = new SqlDataAdapter(query, cn);

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Parameters.Clear();

                DataTable table = new DataTable();
                adapt.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;

                cn.Close();
            

        }  // search method end
        string name;
        string date;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // data grid click begin
        {
            name = dataGridView1.CurrentRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
            date = dataGridView1.CurrentRow.Cells["dateDataGridViewTextBoxColumn"].Value.ToString();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Recover")
            {
                MessageBox.Show("Recover");

                txtName.Text = name;
                txtDate.Text = date;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                MessageBox.Show("DELETE");

                SqlConnection cn = new SqlConnection(ConnectionClass.conn);
                cn.Open();

                string quer = "UPDATE BackupList SET Status = 2 WHERE Name ='"+name+"'";
                SqlCommand command = new SqlCommand(quer, cn);
                command.ExecuteNonQuery();
                cn.Close();

            } 
        }   // data grid click end

        private void FrmRecovey_Load(object sender, EventArgs e)// frm load begin
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        } // frm load end

        private void timer1_Tick(object sender, EventArgs e)// timer begin
        {
            dataGridView1.Refresh();
            list();

        } // timer end

    } // class end
} // name space end
