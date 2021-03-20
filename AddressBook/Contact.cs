using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Email { get; set; }
        public long PhoneNumber { get; set; }

        public Contact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)
        {
            string FirstName = firstName;
            string LastName = lastName;
            string Address = address;
            string City = city;
            string State = state;
            string Email = email;
            string Zip = zip;
            long PhoneNumber = phoneNumber;
        }
        public override bool Equals(object obj)
        {
            Contact contact = (Contact)obj;
            object FirstName = null;
            object LastName = null;
            if (contact == null)
                return false;
            else
                return FirstName.Equals(contact.FirstName) && LastName.Equals(contact.LastName);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }
        public override string ToString()
        {
            return "First Name :" + FirstName + "\nLast Name : " + LastName + "\nCity : " + City + "\nState : " + State + "\nEmail : " + Email + "\nZip : " + Zip + "\nPhone Number : " + PhoneNumber + "\n";
        }
    }
}
