﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBook : IContact
    {
        private Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        private int Email;

        public string Zip { get; private set; }

        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)
        {
            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            contact.Email = Email;
            contact.Zip = Zip;
            contact.PhoneNumber = phoneNumber;
            addressBook.Add(contact.FirstName, contact);
        }
        public void ViewContact()
        {
            foreach (KeyValuePair<string, Contact> item in addressBook)
            {
                Console.WriteLine("First Name : " + item.Value.FirstName);
                Console.WriteLine("Last Name : " + item.Value.LastName);
                Console.WriteLine("Address : " + item.Value.Address);
                Console.WriteLine("City : " + item.Value.City);
                Console.WriteLine("State : " + item.Value.State);
                Console.WriteLine("Email : " + item.Value.Email);
                Console.WriteLine("Zip : " + item.Value.Zip);
                Console.WriteLine("Phone Number : " + item.Value.PhoneNumber + "\n");
            }
        }
    }
}
