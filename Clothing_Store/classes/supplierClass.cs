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
        private string id;
        private string Address;
        private string Contact;
        private string Email;

        public supplierClass()
        {
        
            this.Name = " ";
            this.Address = " ";
            this.Contact = "";
            this.Email = " ";
            this.id = "";
        }

        public supplierClass(string name , string address, string contact, string email,string ID)
        {
           
            Name = name;
            Address = address;
            Contact = contact;
            Email = email;
            id = id;
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
        public string Contact_No
        {
            get { return Contact; }
            set { Contact = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
