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

        public ordersClass(string name, string category, string item, string quantity, string size, string color, string type)
        {
            this.name = name;
            this.category = category;
            this.item = item;
            this.quantity = quantity;
            this.size = size;
            this.color = color;
            this.type = type;
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
