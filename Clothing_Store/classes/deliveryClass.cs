using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Clothing_Store.classes
{
    internal class deliveryClass
    {
        private string delid;
        private string orid;
        private string cusName;
        private string contact;
        private string adres;
        private string desc;
        public deliveryClass()
        {
            delid = "";
            orid = "";
            cusName = "";
            contact = "";
            adres = "";
            desc = "";
        }
        public deliveryClass(string delid, string orid, string cusName, string contact, string adres, string desc)
        {
            this.delid = delid;
            this.orid = orid;
            this.cusName = cusName;
            this.contact = contact;
            this.adres = adres;
            this.desc = desc;
        }

        public string Delivery_Id
        {
            get { return delid; }
            set { delid = value; }
        }
        public string Customer_name
        {
            get { return cusName; }
            set { cusName = value; }
        }
        public string Address
        {
            get { return adres; }
            set { adres = value; }
        }
        public string Contact_No
        {
            get { return contact; }
            set { contact = value; }
        }
        public string order_Id
        {
            get { return orid; }
            set { orid = value; }
        }
        public string Description
        {
            get { return desc; }
            set { desc = value; }
        }

    }
}
