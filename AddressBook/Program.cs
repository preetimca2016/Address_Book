using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");
            /////UC1 Create Contacts
            //AddressBook addressBook = new AddressBook("Preeti", "Sharma", "xyz", "Ggn", "Haryana", 122001, 1234567890, "acd@gmail.com");
            //addressBook.Display();
            ////UC2 Add contacts
            //Console.WriteLine("Enter details to add a new contact");
            //Console.WriteLine("Enter First Name");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Enter Last Name");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Enter Address");
            //string address = Console.ReadLine();
            //Console.WriteLine("Enter City ");
            //string city = Console.ReadLine();
            //Console.WriteLine("Enter State");
            //string state = Console.ReadLine();
            //Console.WriteLine("Enter ZipCode");
            //int zipCode = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Phone number");
            //long phoneNumber = long.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Email");
            //string email = Console.ReadLine();

            //AddressBook addressBookAdd = new AddressBook(firstName, lastName, address,
            //    city, state, zipCode, phoneNumber, email);
            //addressBookAdd.Display();
            ////UC3 Edit contact
            //Console.WriteLine();
            //Console.WriteLine("Press 1 for edit");
            //Console.WriteLine("Press 2 for delete");
            //int input = Convert.ToInt32(Console.ReadLine());
            //if (input == null)
            //{
            //    Console.WriteLine("Wrong selection");
            //}

            //switch (input)
            //{
            //    case 1:
            //        //to edit
            //        Console.WriteLine();
            //        addressBook.EditContact();
            //        Console.WriteLine();
            //        break;
            //    case 2:
            //        //to delete
            //        addressBook.Delete();
            //        break;
            //    default:
            //        Console.WriteLine("Wrong selection");
            //        break;
            //}
            /////For Multiple Contacts
            Dictionary<string, MultipleAddressBook> PhoneBook = new Dictionary<string, MultipleAddressBook>();
            bool ToStop = true;
            while (ToStop)
            {
                Console.WriteLine();
                Console.WriteLine("press 1 to add to contact");
                Console.WriteLine("press 2 to see the contact list");
                Console.WriteLine("press 3 to delete the contact from list");
                Console.WriteLine("press 4 to update the contact from list");
                Console.WriteLine("press 5 to Stop");
                int input = Convert.ToInt32(Console.ReadLine());
                MultipleAddressBook multipleAddressBook = new MultipleAddressBook();
                switch (input)
                {
                    case 1:
                        multipleAddressBook.AddNewContact();
                        break;

                    case 2:
                        multipleAddressBook.DisplayContact();
                        break;
                    case 3:
                        multipleAddressBook.DeleteContact();
                        break;

                    case 4:
                        multipleAddressBook.EditContact();
                        break;
                    case 5:
                        {
                            ToStop = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Make Proper Selection");
                        break;
                }

            }


        }
    }
}

        