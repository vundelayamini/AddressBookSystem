using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            new AddressBook().AddContact("yamini", "mahesh", "marthalli", "Banglore", "karnataka", "yamini.vundela@gmail.com", 9493499430);
            new AddressBook().ViewContact();
        }
    }
}
