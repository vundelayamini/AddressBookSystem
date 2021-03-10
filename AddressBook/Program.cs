using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook addressBook = new AddressBook();
            int choice;
            do
            {
                Console.WriteLine("Welcome to Address Book Program");
                AddressBook addressBook = new AddressBook();
                Console.WriteLine("Enter First Name :");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name :");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Address :");
                string address = Console.ReadLine();
                Console.WriteLine("Enter City :");
                string city = Console.ReadLine();
                Console.WriteLine("Enter State :");
                string state = Console.ReadLine();
                Console.WriteLine("Enter Email :");
                string email = Console.ReadLine();
                Console.WriteLine("Enter Zip :");
                int zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone Number :");
                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                addressBook.AddContact(firstName, lastName, address, city, state, email, zip, phoneNumber);
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Enter First Name Of Contact To Edit :");
                        string nameToEdit = Console.ReadLine();
                        addressBook.EditContact(nameToEdit);
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name Of Contact To Delete :");
                        string nameToDelete = Console.ReadLine();
                        addressBook.DeleteContact(nameToDelete);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name Of Contact To View :");
                        string nameToView = Console.ReadLine();
                        addressBook.ViewContact(nameToView);
                        break;
                    case 4:
                        addressBook.ViewContact();
                        break;
                    case 5:
                        Console.WriteLine("It is Not Found Any Information.");
                        break;
                }
        }        while (choice != 5);
     }
} 
