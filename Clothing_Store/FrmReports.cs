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
        private bool btnDeliveryWasCliked = false;

        private void btnStocks_Click(object sender, EventArgs e) // btn stocks begin
        {
               btnStocksWasCliked = true;
               btnOrdersWasCliked = false;
               btnItemWasCliked = false;

            btnDeliveryWasCliked = false;
            btnDelivery.BackColor = Color.Teal;

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

            btnDeliveryWasCliked = false;
            btnDelivery.BackColor = Color.Teal;

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

            btnDeliveryWasCliked = false;
            btnDelivery.BackColor = Color.Teal;

            btnStocks.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Navy;

            panelHome.Visible = false;

        } //  btn items end
        private void btnDelivery_Click(object sender, EventArgs e) // btn delivery begin
        {
            btnStocksWasCliked = false;
            btnOrdersWasCliked = false;
            btnItemWasCliked = false;

            btnDeliveryWasCliked = true;
            btnDelivery.BackColor = Color.Navy;

            btnStocks.BackColor = Color.Teal;
            btnItems.BackColor = Color.Teal;
            btnOrders.BackColor = Color.Teal;

            panelHome.Visible = false;

        } // btn delivery end

        private void btnWeekly_Click(object sender, EventArgs e)  // btn weekly Begin
        {
            dataGridView1.Visible = true;
            panelHome.Visible = false;

            dataGridView1.Visible = true;
            panelHome.Visible = false;

            if (btnStocksWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    InventoryWeeklySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    InventoryWeeklyTotal();
                }
                else
                {
                    InventoryWeeklySeeAll();
                }


            }
            else if (btnItemWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    ItemsWeeklySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    ItemsWeeklyTotal();
                }
                else
                {
                    ItemsWeeklySeeAll();
                }
            }
            else if (btnOrdersWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    OrdersWeeklySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    OrderWeeklyTotal();
                }
                else
                {
                    OrdersWeeklySeeAll();
                }

            }
            else if (btnDeliveryWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    DeliveryWeeklySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    DeliveryWeeklyTotal();
                }
                else
                {
                    DeliveryWeeklySeeAll();
                }
            }

        } // btn weekly end

        private void FrmReports_Load(object sender, EventArgs e) // frm load begin
        {
           

        } // frm load end

        private void btnDaily_Click(object sender, EventArgs e)  // btn daily begin
        {
            dataGridView1.Visible = true;
            panelHome.Visible = false;

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
            else if (btnDeliveryWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    DeliveryDailySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    DeliveryDailyTotal();
                }
                else
                {
                    DeliveryDailySeeAll();
                }
            }

            } // btn daili end

        private void btnmonthly_Click(object sender, EventArgs e) // btn monthly begin
        {

            dataGridView1.Visible = true;
            panelHome.Visible = false;

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
            else if (btnDeliveryWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    DeliveryMonthlySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    DeliveryMonthlyTotal();
                }
                else
                {
                    DeliveryMonthlySeeAll();
                }
            }
        }// btn monthly end 
        private void btnYearly_Click(object sender, EventArgs e) // btn yeraly begin
        {
            dataGridView1.Visible = true;
            panelHome.Visible = false;

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
            else if (btnDeliveryWasCliked)
            {
                if (cbFilter.Text == "See All")
                {
                    DeliveryYearlySeeAll();
                }
                else if (cbFilter.Text == "Total")
                {
                    deliveryYearlyTotal();
                }
                else
                {
                    DeliveryYearlySeeAll();
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

            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;

        }
        public void InventoryWeeklySeeAll()
        {


            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);
            string day = "select   concat(Year(i.Date) ,'-',Month(i.Date) , '-', Day(i.Date) ) as 'Date updated', p.Product_Id ,p.Product_Name, " +
                "\r\nSUM(Quantity) AS 'Total'  " +
                "\r\nfrom Inventory as i inner join Products as p on i.Product_Id = p.Product_Id  where i.Status = 1 " +
                "\r\n and i.Date BETWEEN DATEADD(d,-7,\r\nCONVERT(nvarchar(10),GETDATE(),101)) " +
                "\r\nAND CONVERT(nvarchar(10),GETDATE(),101)" +
                "\t\t\r\ngroup by Year(i.Date), MONTH(i.date),Day(i.date) ,p. Product_Id ,p.Product_Name " +
                "\r\norder by Day(i.date)";

            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

        }
        public void InventoryWeeklyTotal()
        {


            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

            string day = "select    concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', SUM(Quantity) AS 'Total' " +
                " \r\nfrom Inventory  where Status = 1  " +
                "\r\nand Date BETWEEN DATEADD(d,-7," +
                "\r\nCONVERT(nvarchar(10),GETDATE(),101)) " +
                "\r\nAND CONVERT(nvarchar(10),GETDATE(),101)\r\nGROUP BY Year(Date),Month(Date),Day(Date) " +
                "\r\norder by Year(date)";


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;


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

            dataGridView1.Visible = true;


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

            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;

        }

        public void OrdersDailySeeAll()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', concat( c.First_Name ,' ',c.Last_Name )as 'Name', SUM(Quantity) AS 'Total' " +
                "\r\nfrom Orders as o inner join Customers as c on o.Customer_Id = c.Customer_Id  " +
                "\r\n where o.Status = 1 or o.status = 3 or o.status = 4" +
                "\r\ngroup by Year(o.Date),Month(Date), Day(Date) ,c.First_Name ,c.Last_Name" +
                "\r\norder by Year(o.date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

        }
        public void OrdersDailyTotal()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', SUM(Quantity) AS 'Total'  " +
                "from Orders  where  where Status = 1 or status = 3 or status = 4  " +
                "group by Year(Date),Month(Date), Day(Date)" +
                "order by Year(date), Day(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

        }

        public void OrdersWeeklySeeAll()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', concat( c.First_Name ,' ',c.Last_Name )as 'Name'," +
                " \r\nSUM(Quantity) AS 'Total'  from Orders as o " +
                "\r\ninner join Customers as c on o.Customer_Id = c.Customer_Id  " +
                "\r\nwhere o.Status = 1 or o.Status = 3 or o.Status = 4" +
                "\r\nand Date BETWEEN DATEADD(d,-7," +
                "\r\nCONVERT(nvarchar(10),GETDATE(),101))" +
                " \r\nAND CONVERT(nvarchar(10),GETDATE(),101)" +
                "\r\ngroup by Year(o.Date),Month(Date), Day(Date) ,c.First_Name ,c.Last_Name " +
                "\r\norder by Year(o.date)";
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

        }
        public void OrderWeeklyTotal()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', SUM(Quantity) AS 'Total' " +
                " \r\nfrom Orders  where Status = 1 or status = 3 or status = 4" +
                "\r\nand Date BETWEEN DATEADD(d,-7," +
                "\r\nCONVERT(nvarchar(10),GETDATE(),101))" +
                " \r\nAND CONVERT(nvarchar(10),GETDATE(),101)" +
                "\r\ngroup by Year(Date),Month(Date), Day(Date)" +
                "\r\norder by Year(date), Day(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

        }
        public void DeliveryDailySeeAll()
        {
            string day = "select   concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' , " +
                "c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d " +
                "inner join Customers as c on d.Customer_Id = c.Customer_Id " +
                "where d.Status = 'pending' or" +
                " d.Status = 'delivered' or " +
                "d.Status = 'intransit' " +
                "order by Year(d.date)\r\n";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

        }
        public void DeliveryDailyTotal()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date), '-', Day(Date)  ) as 'Date Added', " +
                "count(Delivery_Id) AS 'Total'  from Delivery " +
                "where Status = 'pending' or Status = 'delivered' or Status = 'intransit'" +
                "group by Year(Date),Month(Date),Day(Date) " +
                "order by Year(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

        }
        public void DeliveryWeeklySeeAll()
        {
            string day = "select   concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' ," +
                " c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'pending' " +
                "or d.Status = 'delivered' or d.Status = 'intransit'\r\nand d.Date BETWEEN DATEADD(d,-7,\r\nCONVERT(nvarchar(10),GETDATE(),101)) \r\nAND CONVERT(nvarchar(10),GETDATE(),101)\r\nGROUP BY Year(d.Date),Month(d.Date),Day(d.Date) ," +
                " d.Delivery_Id, c.First_Name , c.Last_Name,c.Contact_No, c.Address, d.Order_Id , d.Description ,d.Status \r\norder by Year(d.Date)";
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

        }
        public void DeliveryWeeklyTotal()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date), '-', Day(Date)  ) as 'Date Added', count(Delivery_Id) AS 'Total'  from Delivery where Status = 'pending' or Status = 'delivered' or Status = 'intransit'\r\n " +
                "               and Date BETWEEN DATEADD(d,-7," +
                "\r\n\t\t\t\tCONVERT(nvarchar(10),GETDATE(),101)) " +
                "\r\n\t\t\t\tAND CONVERT(nvarchar(10),GETDATE(),101)" +
                "\r\n\t\t\t\tGROUP BY Year(Date),Month(Date),Day(Date) \r\n   " +
                "             order by Year(date)";
            
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;

        }
        public void DeliveryMonthlyTotal()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date)  ) as 'Date Added', count(Delivery_Id) AS 'Total'  from Delivery where Status = 'pending' or Status = 'delivered' or Status = 'intransit'\r\n                group by Year(Date),Month(Date)\r\n                order by Year(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

        }
        public void DeliveryMonthlySeeAll()
        {
            string day = "select  concat(Year(d.Date) ,'-',Month(d.Date)  ) as 'Date Added', d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' , c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'pending' or d.Status = 'delivered' or d.Status = 'intransit' order by Year(d.date)\r\n";
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

        }
        public void DeliveryYearlySeeAll()
        {
            string day = "select Year(d.Date) as 'Date Added', d.Delivery_Id,concat(c.First_Name ,' ', c.Last_Name ) as 'Customer_name' ,c.Contact_No as 'Contact_no' , c.Address as 'Address', d.Order_Id as 'order_Id', d.Description as 'Description',d.Status as status from Delivery as d inner join Customers as c on d.Customer_Id = c.Customer_Id where d.Status = 'pending' or d.Status = 'delivered' or d.Status = 'intransit' order by Year(d.date) ";
            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;


            dataGridView1.Visible = true;

        }
        public void deliveryYearlyTotal()
        {
            string day = "select Year(Date) as 'Date Added', count(Delivery_Id) AS 'Total'  from Delivery where Status = 'pending' or Status = 'delivered' or Status = 'intransit'\r\n                group by Year(Date)\r\n                order by Year(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);


            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

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


            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;

        }

        public void ItemsWeeklySeeAll()
        {
            string day = "select  concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added',Product_Id as 'Product Id' , Product_Name as 'Name'" +
                "\r\nfrom Products  where Status = 1 " +
                " \r\nor Date BETWEEN DATEADD(d,-7," +
                "\r\nCONVERT(nvarchar(10),GETDATE(),101)) " +
                "\r\nAND CONVERT(nvarchar(10),GETDATE(),101)" +
                "\r\ngroup by Year(Date) ,MONTH(Date),Day(Date), Product_id , Product_Name" +
                "\r\norder by Day(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

        }
        public void ItemsWeeklyTotal()
        {
            string day = "select concat(Year(Date) ,'-',Month(Date) , '-', Day(Date) ) as 'Date Added', count(*)as 'Total'" +
                " \r\nfrom Products  where Status = 1 " +
                "\r\nor Date BETWEEN DATEADD(d,-7," +
                "\r\nCONVERT(nvarchar(10),GETDATE(),101))" +
                " \r\nAND CONVERT(nvarchar(10),GETDATE(),101)" +
                "\r\ngroup by Year(Date) ,MONTH(Date),Day(Date)" +
                "\r\norder by Day(date)";

            SqlConnection sqlcc = new SqlConnection(ConnectionClass.conn);

            SqlDataAdapter data = new SqlDataAdapter(day, sqlcc);
            DataTable table = new DataTable();

            data.Fill(table);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;

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

            dataGridView1.Visible = true;

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
            dataGridView1.Visible = false;

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
