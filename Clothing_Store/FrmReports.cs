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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clothing_Store
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
            filterCombobox();
            counts();
            //trial();
        }


        private bool btnStocksWasCliked = false;
        private bool btnOrdersWasCliked = false;
        private bool btnItemWasCliked = false;

        private void btnStocks_Click(object sender, EventArgs e) // btn stocks begin
        {
               btnStocksWasCliked = true;
               btnOrdersWasCliked = false;
               btnItemWasCliked = false;

            btnStocks.BackColor = Color.Navy;
            btnItems.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;

            panelHome.Visible = false;

        }// btn stocks end
        private void btnItems_Click(object sender, EventArgs e) // btn items begin
        {
            btnStocksWasCliked = false;
            btnOrdersWasCliked = false;
            btnItemWasCliked = true;


            btnStocks.BackColor = Color.Teal;
            btnItems.BackColor = Color.Navy;
            btnOrders.BackColor = Color.Teal;

            panelHome.Visible = false;


        } // btn items end

        private void btnOrders_Click(object sender, EventArgs e) // btn items begin
        {
            btnStocksWasCliked = false;
            btnOrdersWasCliked = true;
            btnItemWasCliked = false;


            btnStocks.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Navy;

            panelHome.Visible = false;

        } //  btn items end

        private void btnWeekly_Click(object sender, EventArgs e)  // btn weekly Begin
        {

        } // btn weekly end

        private void FrmReports_Load(object sender, EventArgs e) // frm load begin
        {
           

        } // frm load end

        private void btnDaily_Click(object sender, EventArgs e)  // btn daily begin
        {
            if (btnStocksWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    InventoryDailySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    InventoryDailyTotal();
                }
                else
                {
                    InventoryDailySeeAll();
                }


            }
            else if (btnItemWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    ItemsDailySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    ItemsDailyTotal();
                }
                else
                {
                    ItemsDailySeeAll();
                }
            }
            else if (btnOrdersWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    OrdersDailySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    OrdersDailyTotal();
                }
                else
                {
                    OrdersDailySeeAll();
                }
            }

        } // btn daili end

        private void btnmonthly_Click(object sender, EventArgs e) // btn monthly begin
        {

           

            if (btnStocksWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    InventoryMonthlySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    InventoryMonthlyTotal();
                }
                else
                {
                    InventoryMonthlySeeAll();
                }
               
            }
            else if (btnItemWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    ItemsMonthlySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    ItemsMonthlyTotal();
                }
                else
                {
                    ItemsMonthlySeeAll();
                }
            }
            else if (btnOrdersWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    OrdersMonthlySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    OrdersMonthlyTotal();
                }
                else
                {
                    OrdersMonthlySeeAll();
                }
            }
        }// btn monthly end 
        private void btnYearly_Click(object sender, EventArgs e) // btn yeraly begin
        {
            if (btnStocksWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    InventoryYearlySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    InventoryYearlyTotal();
                }
                else
                {
                    InventoryYearlySeeAll();
                }
            }
            else if (btnItemWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    ItemsYearlySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    ItemsYearlyTotal();
                }
                else
                {
                    ItemsYearlySeeAll();
                }
            }
            else if (btnOrdersWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    OrdersYearlySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    OrdersYearlyTotal();
                }
                else
                {
                    OrdersYearlySeeAll();
                }
            }

        }  // btn yearly end

        public void InventoryDailySeeAll()
        {


            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string day = "  select   concat(Year(i.Date) ,'-',Month(i.Date) , '-', Day(i.Date) ) as 'Date Added', p.Product_Id ,p.Product_Name, " +
                "SUM(Quantity) AS 'Total'  " +
                "from Inventory as i inner join Products as p on i.Product_Id = p.Product_Id  where i.Status = 1 " +
                " group by Year(i.Date), MONTH(i.date),Day(i.date) ,p. Product_Id ,p.Product_Name " +
                " order by Day(i.date)";

            SqlDataAdapter data = new SqlDataAdapter(day ,sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void InventoryDailyTotal()
        {


            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

            string day = "select    concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', SUM(Quantity) AS 'Total'  " +
                            "from Inventory  where Status = 1  " +
                            "group by Year(Date),MONTH(date),Day(date) " +
                            "order by Day(date)";


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void InventoryMonthlyTotal()
        {
            string day = "select    concat(Year(Date) ,'-',Month(Date)  ) as 'Date Added', SUM(Quantity) AS 'Total'  from Inventory  where Status = 1  " +
                "group by Year(Date),MONTH(date)" +
                "order by Month(date)";
           
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void InventoryMonthlySeeAll()
        {
            string day = " select   concat(Year(i.Date) , '-', Month(i.Date) ) as 'Date Added', p.Product_Id ,p.Product_Name, SUM(Quantity) AS 'Total'  " +
                "from Inventory as i inner join Products as p on i.Product_Id = p.Product_Id  where i.Status = 1  " +
                "group by Year(i.date),Month(i.date) ,p. Product_Id ,p.Product_Name" +
                " order by Month(i.date)";
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void InventoryYearlySeeAll()
        {
            string day = "select  Year(i.Date)  as 'Date Added', p.Product_Id ,p.Product_Name, SUM(Quantity) AS 'Total' " +
                " from Inventory as i inner join Products as p on i.Product_Id = p.Product_Id  where i.Status = 1 " +
                " group by Year(i.date) ,p. Product_Id ,p.Product_Name" +
                " order by Year(i.date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void InventoryYearlyTotal()
        {
            string day = "select Year(Date) as 'Date Added', SUM(Quantity) AS 'Total'  from Inventory  where Status = 1 " +
                "group by Year(Date)" +
                "order by Year(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }

        public void OrdersDailySeeAll()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', concat( c.First_Name ,' ',c.Last_Name )as 'Name', SUM(Quantity) AS 'Total'  from Orders as o inner join Customers as c on o.Customer_Id = c.Customer_Id  where o.Status = 1  \r\ngroup by Year(o.Date),Month(Date), Day(Date) ,c.First_Name ,c.Last_Name\r\norder by Year(o.date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void OrdersDailyTotal()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', SUM(Quantity) AS 'Total'  " +
                "from Orders  where Status = 1  " +
                "group by Year(Date),Month(Date), Day(Date)" +
                "order by Year(date), Day(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void OrdersMonthlyTotal()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date) ) as 'Date Added', SUM(Quantity) AS 'Total'  " +
                "from Orders  where Status = 1  " +
                "group by Year(Date),Month(Date)" +
                "order by Year(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void OrdersMonthlySeeAll()
        {
            string day = "select concat(Year(o.Date) ,'-',Month(o.Date)  ) as 'Date Added', concat( c.First_Name ,' ',c.Last_Name )as 'Name', SUM(Quantity) AS 'Total'  from Orders as o inner join Customers as c on o.Customer_Id = c.Customer_Id  where o.Status = 1  \r\ngroup by Year(o.Date),Month(o.Date) ,c.First_Name ,c.Last_Name\r\norder by Year(o.date) , MONTH(o.Date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void OrdersYearlySeeAll()
        {
            string day = "select Year(o.Date) as 'Date Added', concat( c.First_Name ,' ',c.Last_Name )as 'Name', SUM(Quantity) AS 'Total'  from Orders as o inner join Customers as c on o.Customer_Id = c.Customer_Id  where o.Status = 1  \r\ngroup by Year(o.Date) ,c.First_Name ,c.Last_Name\r\norder by Year(o.date)\r\n";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void OrdersYearlyTotal()
        {
            string day = "select Year(Date) as 'Date Added', SUM(Quantity) AS 'Total'  from Orders  where Status = 1 " +
                "group by Year(Date)" +
                "order by Year(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }

        public void ItemsDailySeeAll()
        {
            string day = "select  concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added',Product_Id as 'Product Id' , Product_Name as 'Name'from Products  where Status = 1  \r\ngroup by Year(Date) ,MONTH(Date),Day(Date), Product_id , Product_Name\r\norder by Day(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void ItemsDailyTotal()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', count(*)as 'Total' " +
                "from Products  where Status = 1  " +
                "group by Year(Date) ,MONTH(Date),Day(Date)" +
                "order by Day(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void ItemsMonthlySeeAll()
        {
            string day = "select  concat(Year(Date) ,'-',Month(Date)  ) as 'Date Added',Product_Id as 'Product Id' , Product_Name as 'Name'from Products  where Status = 1  \r\ngroup by Year(Date) ,MONTH(Date), Product_id , Product_Name\r\norder by Month(date)";
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void ItemsMonthlyTotal()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date) ) as 'Date Added', count(*)as 'Total' from Products  where Status = 1  " +
                "group by Year(Date) ,MONTH(Date)" +
                "order by Month(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void ItemsYearlyTotal()
        {
            string day = "select Year(Date) as 'Date Added', count(*)as 'Total'from Products  where Status = 1 " +
                "group by Year(Date) " +
                "order by Year(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

        }
        public void ItemsYearlySeeAll()
        {
            string day = "select Year(Date) as 'Date Added',Product_Id as 'Product Id' , Product_Name as 'Name'from Products  where Status = 1  \r\ngroup by Year(Date) , Product_id , Product_Name\r\norder by Year(date)";

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


            btnStocks.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;

            panelHome.Visible = true;

            counts();


        } // btn home end
   
        public void filterCombobox()
        {
            ArrayList arr = new ArrayList();
            arr.Add("Total");
            arr.Add("See All");

            foreach (string a in arr)
            {
                cbFilter.Items.Add(a);
            }
        }

        public void counts()
        {
            SqlConnection con = new SqlConnection(ConnectionClass.conn);
            string Items = "select count(*) from Products where status = 1";

            SqlCommand command;
            command = new SqlCommand(Items, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                lblItems.Text = reader[0].ToString();
            }

            con.Close();

            string Inventory = "select count(*) from Inventory where status = 1";

            SqlCommand command1;
            command1 = new SqlCommand(Inventory, con);
            con.Open();
            SqlDataReader reader1 = command1.ExecuteReader();
            if (reader1.Read())
            {
                lblStocks.Text = reader1[0].ToString();
            }

        
            con.Close();

            string Orders = "select count(*) from Orders where status = 1";

            SqlCommand command2;
            command2 = new SqlCommand(Orders, con);
            con.Open();
            SqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                lblOrders.Text = reader2[0].ToString();
            }

            con.Close();
        }

    } // class end
} // namespace end
