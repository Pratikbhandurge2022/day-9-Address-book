using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        public String firstName;
        public String lastName;
        public String address;
        public String state;
        public long zip;
        public long phoneNumber;
        public String email;

        public static void DisplayMessage()
        {
            Console.WriteLine("Welcome to Address Book AddressBookMain class on Master Branch");
        }

        public static void SetContact()
        {
            AddressBook addressBook = new AddressBook();
            addressBook.firstName = "pratik";
            addressBook.lastName = "bhandurge";
            addressBook.address = "pune";
            addressBook.state = "Maharashtra";
            addressBook.zip = 412207;
            addressBook.phoneNumber = 1234567890;
            addressBook.email = "pb@gmail.com";

        }
    }
}