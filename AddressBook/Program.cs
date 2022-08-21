using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");
            ///UC1 Create Contacts
            AddressBook addressBook = new AddressBook("Preeti", "Sharma", "xyz", "Ggn", "Haryana", 122001, 1234567890, "acd@gmail.com");
            addressBook.display();
            //UC2 Add contacts
            Console.WriteLine("Enter details to add a new contact");
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter ZipCode");
            int zipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone number");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();

            AddressBook addressBook1 = new AddressBook(firstName, lastName, address,
                city, state, zipCode, phoneNumber, email);
            addressBook1.display();

        }
    }
}

        