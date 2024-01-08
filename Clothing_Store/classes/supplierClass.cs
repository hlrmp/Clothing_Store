using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_Store
{
    internal class supplierClass
    {

        private string Name;

        private string Address;
        private long Contact;
        private string Email;

        public supplierClass()
        {
        
            this.Name = " ";
            this.Address = " ";
            this.Contact = 0;
            this.Email = " ";
        }

        public supplierClass(string name , string address, long contact, string email)
        {
           
            Name = name;
            Address = address;
            Contact = contact;
            Email = email;
        }
      
        public string Supplier_Name
        {
            get { return Name; }
            set {   Name = value; }
        }
        public string address
        {
            get { return Address; }
            set { Address = value; }
        }
        public long Contact_No
        {
            get { return Contact; }
            set { Contact = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

    }
}
