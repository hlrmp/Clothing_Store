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
        private string Quantity;
        private string Price;
        private string Date;
        private string color;
        private string code;
        private string supplier;
        public itemsClass()
        {
            this.ItemName = "";
            this.Type = "";
            this.Category = "";
            this.Size = "";
            this.Quantity = "";
            this.Price = "";
            this.Date = "";
            this.color = "";
            this.code = "";
            this.supplier = "";
        }

        public itemsClass(string itemName, string type, string category, string size, string quantity, string price, string date, string color, string code, string supplier)
        {
            ItemName = itemName;
            Type = type;
            Category = category;
            Size = size;
            Quantity = quantity;
            Price = price;
            Date = date;
            this.color = color;
            this.code = code;
            this.supplier = supplier;
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
        public string quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public string price
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
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }






    }

}
