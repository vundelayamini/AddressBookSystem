using AddNewContact;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBook : IContact
    {
        private Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)
        {
            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            String Email = email;
            int Zip = zip;
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
        public void EditContact(string name)
        {
            foreach (KeyValuePair<string, Contact> item in addressBook)
            {
                if (item.Key.Equals(name))
                {
                    Console.WriteLine("Choose What to Edit \nFirst Name \nLast Name \nAddress \nCity \nState \nEmail \nZip \nPhone Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case FirstName:
                            Console.WriteLine("Enter First Name :");
                            item.Value.FirstName = Console.ReadLine();
                            break;
                        case Lastname:
                            Console.WriteLine("Enter Last Name :");
                            item.Value.LastName = Console.ReadLine();
                            break;
                        case Address:
                            Console.WriteLine("Enter Address :");
                            item.Value.Address = Console.ReadLine();
                            break;
                        case City:
                            Console.WriteLine("Enter City :");
                            item.Value.City = Console.ReadLine();
                            break;
                        case State:
                            Console.WriteLine("Enter State :");
                            item.Value.State = Console.ReadLine();
                            break;
                        case Email:
                            Console.WriteLine("Enter Email :");
                            item.Value.Email = Console.ReadLine();
                            break;
                        case Zip:
                            Console.WriteLine("Enter Zip :");
                            item.Value.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case PhoneNumber:
                            Console.WriteLine("Enter Phone Number :");
                            item.Value.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                    }
                }
            }
            public void DeleteContact(string name)
            {
                if (addressBook.ContainsKey(name))
                {
                    addressBook.Remove(name);
                    Console.WriteLine("\nDeleted Succesfully.\n");
                }
                else
                {
                    Console.WriteLine("\nIt Is Not Found.\n");
                }
            }

        }
    }
}

