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
        public void display()
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

    }
}

