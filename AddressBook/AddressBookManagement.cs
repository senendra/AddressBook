using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AddressBook
{
    class AddressBookManagement
    {
        Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        Dictionary<string, AddressBookManagement> addressBookDictionary = new Dictionary<string, AddressBookManagement>();
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
            Console.WriteLine("Addition Completed\n");
        }
        public void DisplayAllContact()
        {
            foreach (KeyValuePair<string, Contact> item in addressBook)
            {
                Console.WriteLine("First Name: " + item.Value.firstName);
                Console.WriteLine("Last Name: " + item.Value.lastName);
                Console.WriteLine("Address: " + item.Value.address);
                Console.WriteLine("City : " + item.Value.city);
                Console.WriteLine("State : " + item.Value.state);
                Console.WriteLine("Email Id: " + item.Value.emailId);
                Console.WriteLine("Phone Number: " + item.Value.phoneNumber);
                Console.WriteLine("Pin Code: " + item.Value.pinCode+"\n\n");
            }
        }
        public void DisplayAContact()
        {
            Console.Write("Enter first Name of contact person :");
            string name = Console.ReadLine();
            foreach (KeyValuePair<string, Contact> item in addressBook)
            {
                if (item.Key.Equals(name))
                {
                    Console.WriteLine("First Name: " + item.Value.firstName);
                    Console.WriteLine("Last Name: " + item.Value.lastName);
                    Console.WriteLine("Address: " + item.Value.address);
                    Console.WriteLine("City : " + item.Value.city);
                    Console.WriteLine("State : " + item.Value.state);
                    Console.WriteLine("Email Id: " + item.Value.emailId);
                    Console.WriteLine("Phone Number: " + item.Value.phoneNumber);
                    Console.WriteLine("Pin Code: " + item.Value.pinCode+"\n\n");
                }
            }
        }
        public void EditContact()
        {
            Console.WriteLine("Enter first name of contact to edit ");
            string firstName = Console.ReadLine();
            foreach (KeyValuePair<string, Contact> item in addressBook)
            {
                if (firstName == item.Key)
                {
                    Console.WriteLine("Enter what to edit:");
                    Console.WriteLine("1. First Name \n2. Last Name \n3. Address \n4. City \n5. State \n6. Email ID \n7. Phone Number \n8. Pin Code");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter First Name: ");
                            item.Value.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Last Name: ");
                            item.Value.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter Address: ");
                            item.Value.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter City: ");
                            item.Value.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter State: ");
                            item.Value.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter Email ID: ");
                            item.Value.emailId = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter Phone Number: ");
                            item.Value.phoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter Pin Code: ");
                            item.Value.pinCode = Convert.ToInt64(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Your enter wrong chice!");
                            break;
                    }
                    Console.WriteLine("Sucessfully Edited\n\n");
                }
                else
                {
                    Console.WriteLine("Contact not of " + firstName + " is not found");
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter the person's first Name to be delete");
            string nameToDelete = Console.ReadLine();
            if(addressBook.ContainsKey(nameToDelete))
            {
                addressBook.Remove(nameToDelete);
                Console.WriteLine("Deletion Completed\n\n");
            }
            else
            {
                Console.WriteLine("Contact with name "+nameToDelete+" is not found!\n\n");
            }
        }
        public void AddAddressBook(string bookName)
        {
            AddressBookManagement addressBook = new AddressBookManagement();
            addressBookDictionary.Add(bookName, addressBook);
            Console.WriteLine("AddressBook Created.");
        }
        public Dictionary<string, AddressBookManagement> GetAddressBook()
        {
            return addressBookDictionary;
        }
    }
}
