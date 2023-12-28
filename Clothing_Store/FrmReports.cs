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
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
            trial();
        }


        private bool btnStocksWasCliked = false;
        private bool btnOrdersWasCliked = false;
        private bool btnItemWasCliked = false;

        private void btnStocks_Click(object sender, EventArgs e) // btn stocks begin
        {
               btnStocksWasCliked = true;
               btnOrdersWasCliked = false;
               btnItemWasCliked = false;

        }// btn stocks end

        private void btnWeekly_Click(object sender, EventArgs e)  // btn weekly Begin
        {

        } // btn weekly end

        private void FrmReports_Load(object sender, EventArgs e) // frm load begin
        {
            this.txtSearch.AutoSize = false;
            this.txtSearch.Size = new System.Drawing.Size(243, 21);

        } // frm load end

        private void btnDaily_Click(object sender, EventArgs e)  // btn daily begin
        {
            if (btnStocksWasCliked)
            {
                InventoryDaily();
            }
            else if (btnItemWasCliked)
            {

            }
            else if (btnOrdersWasCliked)
            {

            }

        } // btn daili end

        private void btnmonthly_Click(object sender, EventArgs e) // btn monthly begin
        {

            InventoryMonthly();

            if (btnStocksWasCliked)
            {
                InventoryMonthly();
            }
            else if (btnItemWasCliked)
            {

            }
            else if (btnOrdersWasCliked)
            {

            }
        }// btn monthly end 
        private void btnYearly_Click(object sender, EventArgs e) // btn yeraly begin
        {
            if (btnStocksWasCliked)
            {
                InventoryYearly();
            }
            else if (btnItemWasCliked)
            {

            }
            else if (btnOrdersWasCliked)
            {

            }

        }  // btn yearly end

        public void InventoryDaily()
        {


            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string day = "select   concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', p.Product_Id ,p.Product_Name, SUM(Quantity) AS 'Total'   \r\nfrom Inventory as i inner join Products as p on i.Product_Id = p.Product_Id  where i.Status = 1\r\ngroup by Year(Date), MONTH(date),Day(date) ,p. Product_Id ,p.Product_Name\r\norder by Day(date)";


            SqlDataAdapter data = new SqlDataAdapter(day ,sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void InventoryMonthly()
        {
          //  string day = "select   concat(Month(Date) , '-', Day(Date) ) as 'Date Added', p.Product_Id ,p.Product_Name, SUM(Quantity) AS 'Total'   \r\nfrom Inventory as i inner join Products as p on i.Product_Id = p.Product_Id  where i.Status = 1\r\ngroup by MONTH(date),Day(date) ,p. Product_Id ,p.Product_Name\r\norder by Month(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

            string day = "select * from Inventory";

            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void InventoryYearly()
        {
            string day = "select   concat(Year(Date) , ''  ) as 'Date Added', p.Product_Id ,p.Product_Name, SUM(Quantity) AS 'Total'   \r\nfrom Inventory as i inner join Products as p on i.Product_Id = p.Product_Id  where i.Status = 1\r\ngroup by Year(Date),p. Product_Id ,p.Product_Name\r\norder by Year(date)\r\n";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }

        private void btnHomeReports_Click_1(object sender, EventArgs e)  // btn home begin
        {
           

            btnStocksWasCliked = false;
            btnOrdersWasCliked = false;
            btnItemWasCliked = false;


        } // btn home end
        public void trial()
        {
            SqlConnection connection = new SqlConnection(ConnectionClass.conn);
            connection.Open();

            string quer = "SELECT Product_id as 'Item Code' , Product_Name as 'Item Name', Type, Category , Price , Color,Size FROM Products where Category = 'mens'";
            SqlDataAdapter data = new SqlDataAdapter(quer, connection);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            connection.Close();
        }

    } // class end
} // namespace end
