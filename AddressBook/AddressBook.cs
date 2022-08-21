using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        //Intialisation
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int ZipCode;
        public long PhoneNumber;
        public string Email;

        //use parameterised constructor
        public AddressBook(string firstName, string lastName, string address, string city, string state, int zipCode, long phoneNumber, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
        public void Display()
        {
            Console.WriteLine("First Name is:- " + this.FirstName);
            Console.WriteLine("Last Name is:- " + this.LastName);
            Console.WriteLine("Address is:- " + this.Address);
            Console.WriteLine("City is:- " + this.City);
            Console.WriteLine("State is:- " + this.State);
            Console.WriteLine("ZipCode is:- " + this.ZipCode);
            Console.WriteLine("PhoneNumber is:- " + this.PhoneNumber);
            Console.WriteLine("Email is:- " + this.Email);
            Console.WriteLine("-------------------------------------------------------------------");
        }
        public void EditContact()
        {
            // Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
            Console.WriteLine();
            Console.WriteLine("Press 0 to update First Name");
            Console.WriteLine("Press 1 to update Last Name");
            Console.WriteLine("Press 2 to update Address");
            Console.WriteLine("Press 3 to update City");
            Console.WriteLine("Press 4 to update State");
            Console.WriteLine("Press 5 to update ZipCode");
            Console.WriteLine("Press 6 to update Phone Number");
            Console.WriteLine("Press 7 to update Email");
            int Answer = Convert.ToInt32(Console.ReadLine());
            switch (Answer)
            {
                case 0:
                    Console.WriteLine("Enter first Name");
                    string firstName = Console.ReadLine();
                    this.FirstName = firstName;
                    break;
                case 1:
                    Console.WriteLine("Enter Last Name");
                    string lastName = Console.ReadLine();
                    this.LastName = lastName;
                    break;
                case 2:
                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();
                    this.Address = address;
                    break;
                case 3:
                    Console.WriteLine("Enter City Name");
                    string city = Console.ReadLine();
                    this.City = city;
                    break;
                case 4:
                    Console.WriteLine("Enter State Name");
                    string state = Console.ReadLine();
                    this.State = state;
                    break;
                case 5:
                    Console.WriteLine("Enter ZIPCODE");
                    int zipCode = Convert.ToInt32(Console.ReadLine());
                    this.ZipCode = zipCode;
                    break;
                case 6:
                    Console.WriteLine("Enter PhoneNumber");
                    int phoneNumber = Convert.ToInt32(Console.ReadLine());
                    this.PhoneNumber = phoneNumber;
                    break;
                case 7:
                    Console.WriteLine("Enter Email address");
                    string email = Console.ReadLine();
                    this.Email = email;
                    break;
                    Console.WriteLine("Updated contact successfully");
                    Console.WriteLine();
                    Display();
                    Console.WriteLine();
            }
        }


    }
}

