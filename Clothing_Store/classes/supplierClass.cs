using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_Store
{
    internal class supplierClass
    {

        private string FirstName;
        private string LastName;
        private string Address;
        private long Contact;
        private string Email;

        public supplierClass()
        {
            this.FirstName = " ";
            this.LastName = " ";
            this.Address = " ";
            this.Contact = 0;
            this.Email = " ";
        }

        public supplierClass(string firstName, string lastName, string address, long contact, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Contact = contact;
            Email = email;
        }
        public string First_Name
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public string Last_Name
        {
            get { return LastName; }
            set { LastName = value; }
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
