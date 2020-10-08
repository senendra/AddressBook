using System;
using System.Collections.Generic;
using System.Text;
namespace AddressBook
{
    class AddressBookManagement
    {
        Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        public void ToAddAddress()
        {
            Contact contact = new Contact();
            Console.Write("Enter First Name: ");
            contact.firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            contact.lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            contact.address = Console.ReadLine();
            Console.Write("Enter City: ");
            contact.city = Console.ReadLine();
            Console.Write("Enter State: ");
            contact.state = Console.ReadLine();
            Console.Write("Enter Email ID: ");
            contact.emailId = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter PinCode: ");
            contact.pinCode = Convert.ToInt64(Console.ReadLine());
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
