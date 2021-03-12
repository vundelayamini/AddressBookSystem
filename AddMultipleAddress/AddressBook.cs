﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddMultipleAddress
{
    class AddressBook : IContact
    {
        private Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        private object addressBookDictionary;

        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)
        {
            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            contact.Email = email;
            contact.Zip = zip;
            contact.PhoneNumber = phoneNumber;
            addressBook.Add(contact.FirstName, contact);
            Console.WriteLine("\nAdded Succesfully. \n");
        }
        public void ViewContact(string name)
        {
            foreach (KeyValuePair<string, Contact> item in addressBook)
            {
                if (item.Key.Equals(name))
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
            {
                foreach (KeyValuePair<string, Contact> item in addressBook)
                {
                    if (item.Key.Equals(name))
                    {
                        Console.WriteLine("Choose What to Edit \n1.First Name \n2.Last Name \n3.Address \n4.City \n5.State \n6.Email \n7.Zip \n8.Phone Number");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter New First Name :");
                                item.Value.FirstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter New Last Name :");
                                item.Value.LastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter New Address :");
                                item.Value.Address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter New City :");
                                item.Value.City = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter New State :");
                                item.Value.State = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter New Email :");
                                item.Value.Email = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter New Zip :");
                                item.Value.Zip = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 8:
                                Console.WriteLine("Enter New Phone Number :");
                                item.Value.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                                break;
                        }
                        Console.WriteLine("\nEdited Successfully.\n");
                    }
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
                Console.WriteLine("\nNot Found, Try Again.\n");
            }

        }
        public void AddAddressBook(string bookName)
        {
            AddressBook addressBook = new AddressBook();
            addressBookDictionary.Add(bookName, addressBook);
            Console.WriteLine("AddressBook Created.");
        }
        public Dictionary<string, AddressBook> GetAddressBook()
        {
            return addressBookDictionary;
        }
    }
}   
