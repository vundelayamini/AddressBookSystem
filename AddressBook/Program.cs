using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book system");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact("yamini", "rishi", "Karnataka", "Banglore", "karnataka", "yamini@gmail.com", 599356, 9493499430);
            addressBook.ViewContact();
        }
    }
}
