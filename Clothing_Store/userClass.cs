using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_Store
{

 



    internal class userClass
    {
        // staffs  info declaration
        private string FirstName;
        private string LastName;
        private string Email;
        private string Address;
        private string ContactNo;



        // user info declaration
        private string user_id;
        private int staff_id;
        private string user_name;
        private string password;
        private string user_type;
        private string Position;

        public userClass()
        {
            // users
            this.user_id = " ";
            this.staff_id = 0;
            this.user_name = " ";
            this.password = " ";
            this.user_type = " ";

            // staffs
            this.FirstName = " ";
            this.LastName = " ";
            this.Email = " ";
            this.Address = " ";
            this.ContactNo = " ";
            this.Position = " ";
        }

        public userClass(string firstName, string lastName, string email, string address, string contactNo, string position) // staff info
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            ContactNo = contactNo;
            Position = position;
            
        } // staff info

        public string StaffFirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public string StaffLastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public string staffEmail
        {
            get { return Email; }
            set { Email = value; }
        }
        public string StaffAddress
        {
            get { return Address; }
            set { Address = value; }
        }
        public string StaffConntacNo
        {
            get { return ContactNo; }
            set { ContactNo = value; }
        }
        public string StaffPosition
        {
            get { return Position; }
            set { Position = value; }
        }

        // staffs info encapsulation end


        public userClass(string userid, int staffid, string username, // user info
            string pass, string usertype)
        {
            user_id = userid;
            staff_id = staffid;
            user_name = username;
            password = pass;
            user_type = usertype;
        } // user info

        public string uid
        {
            get { return user_id; }
            set { user_id = value; }
        }
        public int staffid
        {
            get { return staff_id; }
            set { staff_id = value; }
        }
        public string username
        {
            get { return user_name; }
            set { user_name = value; }
        }
        public string userpas
        {
            get { return password; }
            set { password = value; }
        }

        public string utype
        {
            get { return user_type; }
            set { user_type = value; }
        } // user info  encapsulation end

    } // class end
} // namespace end
