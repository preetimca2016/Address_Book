using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");
            ///UC1 Create Contact
            AddressBook addressBook = new AddressBook("Preeti", "Sharma", "xyz", "Ggn", "Haryana", 122001, 1234567890, "acd@gmail.com");
            addressBook.display();
        }
    }
}

        