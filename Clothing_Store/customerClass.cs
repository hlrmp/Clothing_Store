﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_Store
{
    internal class customerClass
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private string DeliveryAddress;
        private string Contact;
        private string Email;

        public customerClass()
        {
            this.FirstName = " ";
            this.LastName = " ";
            this.Address = " ";
            this.DeliveryAddress = " ";
            this.Contact = " ";
            this.Email = " ";
    }
        public customerClass(string first_Name, string last_Name, string address, string deliveryAddress, string contact, string enali)
        {
            FirstName = first_Name;
            LastName = last_Name;
            Address = address;
            DeliveryAddress = deliveryAddress;
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
        public string DelAddress
        {
            get { return DeliveryAddress; }
            set { DeliveryAddress = value; }
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

    }


}
