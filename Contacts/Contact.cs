using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Contact
    {
        private string firstName;
        private string lastName;
        private string phone;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Phone
        {
            get { return phone; }
            set 
            {
                if (value.Length == 11)
                    phone = value;

                else
                    phone = "Your phone number is invalid , Please try again.";
                
            }
        }

        public Contact()
        {
            FirstName = "Ziad";
            LastName = "Alaa";
            Phone = "00000000000";
        }

        public Contact(string firstName , string lastName , string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public override string ToString()
        {
            string input = String.Empty;
            input += String.Format("{0} , {1} ", FirstName, LastName);
            input += String.Format("{0}", Phone.Substring(0, 10));
            return input;
        }

    }
}
