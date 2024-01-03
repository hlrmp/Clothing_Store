using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_Store.classes
{
    internal class ordersClass
    {
        private string name;
        private string category;
        private string item;
        private string quantity;
        private string size;
        private string color;
        private string type;

        private string OrderId;
        private string CustomerName;
        private string ProductId;
        private string ProductName;
        private string Price;
        private string Total;
        private string Staff;
        private string Date;

        public ordersClass()
        {
            name = "";
            category = "";
            item = "";
            quantity = "";
            size = "";
            color = "";
            type = "";
        }

        public ordersClass(string NAME, string CATEGORY, string ITEM, string QUANTITY, string SIZE, string COLOR, string TYPE)
        {
            name = NAME;
            category = CATEGORY;
            item = ITEM;
            quantity = QUANTITY;
            size = SIZE;
            color = COLOR;
            type = TYPE;
        }

        public ordersClass(string orderId, string customerName, string productId, string productName, string price, string total, string staff, string date)
        {
            OrderId = orderId;
            CustomerName = customerName;
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Total = total;
            Staff = staff;
            Date = date;
        }


        public string Order_Id
        {
            get { return OrderId; }
            set { OrderId = value; }
        }
        public string Customer_Name
        {
            get { return CustomerName; }
            set { CustomerName = value; }
        }
        public string Product_Id
        {
            get { return ProductId; }
            set { ProductId = value; }
        }
        public string Product_Name
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        public string Product_Price
        {
            get { return Price; }
            set { Price = value; }
        }
        public string Total_Item
        {
            get { return Total; }
            set { Total = value; }
        }
        public string Staffs
        {
            get { return Staff; }
            set { Staff = value; }
        }
        public string Order_Date
        {
            get { return Date; }
            set { Date = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    
}
