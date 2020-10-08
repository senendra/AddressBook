using System;
using System.Collections.Generic;
using System.Text;
namespace AddressBook
{
    class AddressBookManagement
    {
        Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        public void ToAddAddress(string firstName, string lastName, string address, string city, string state, string emailId, long phoneNumber, long pinCode)
        {
            Contact contact = new Contact( firstName,  lastName,  address,  city,  state,  emailId, phoneNumber, pinCode);
            addressBook.Add(contact.firstName, contact);
        }
        public void Display()
        {
            foreach (var item in addressBook)
            {
                Console.WriteLine("First Name: " + item.Value.firstName);
                Console.WriteLine("Last Name: " + item.Value.lastName);
                Console.WriteLine("Address: " + item.Value.address);
                Console.WriteLine("City : " + item.Value.city);
                Console.WriteLine("State : " + item.Value.state);
                Console.WriteLine("Email Id: " + item.Value.emailId);
                Console.WriteLine("Phone Number: " + item.Value.phoneNumber);
                Console.WriteLine("Pin Code: " + item.Value.pinCode);
            }
        }
    }
}
