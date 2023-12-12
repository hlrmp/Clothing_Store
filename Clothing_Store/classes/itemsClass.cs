using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Clothing_Store
{
    internal class itemsClass
    {
        private string ItemName;
        private string Type;
        private string Category;
        private string Size;
        private int Quantity;
        private double Price;
        private string Date;
        private string color;
        public itemsClass()
        {
            this.ItemName = "";
            this.Type = "";
            this.Category = "";
            this.Size = "";
            this.Quantity = 0;
            this.Price = 0;
            this.Date = "";
            this.color = "";

        }

        public itemsClass(string itemName, string type, string category, string size, int quantity, double price, string date, string color)
        {
            ItemName = itemName;
            Type = type;
            Category = category;
            Size = size;
            Quantity = quantity;
            Price = price;
            Date = date;
            this.color = color;
        }

        public string type
        {
            get { return Type; }
            set { Type = value; }
        }
        public string Name
        {
            get { return ItemName; }
            set { ItemName = value; }
        }
        public string category
        {
            get { return Category; }
            set { Category = value; }
        }
        public string size
        {
            get { return Size; }
            set { Size = value; }
        }
        public int quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public double price
        {
            get { return Price; }
            set { Price = value; }
        }
        public string date
        {
            get { return Date; }
            set { Date = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }






    }

}
