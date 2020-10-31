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
        Dictionary<Contact, string> cityDictionary = new Dictionary<Contact, string>();
        Dictionary<Contact, string> stateDictionary = new Dictionary<Contact, string>();
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, long phoneNumber,long pincode, string bookName)
        {
            Contact contact = new Contact();
            contact.SaveContact(firstName, lastName, address, city, state, email, phoneNumber,pincode);
            addressBookDictionary[bookName].addressBook.Add(contact.firstName, contact);
            Console.WriteLine("\nAdded Succesfully. \n");
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
        public List<Contact> GetListOfDictctionaryValues(string bookName)
        {
            List<Contact> book = new List<Contact>();
            foreach (var value in addressBookDictionary[bookName].addressBook.Values)
            {
                book.Add(value);
            }
            return book;
        }
       
        public List<Contact> GetListOfDictctionaryKeys(Dictionary<Contact, string> d)
        {
            List<Contact> book = new List<Contact>();
            foreach (var value in d.Keys)
            {
                book.Add(value);
            }
            return book;
        }
        public bool CheckDuplicateEntry(Contact c, string bookName)
        {
            List<Contact> book = GetListOfDictctionaryValues(bookName);
            if (book.Any(b => b.Equals(c)))
            {
                Console.WriteLine("Name already Exists.");
                return true;
            }
            return false;
        }
        public void SearchPersonByCity(string city)
        {
            foreach (AddressBookManagement addressbookobj in addressBookDictionary.Values)
            {
                CreateCityDictionary();
                List<Contact> contactList = GetListOfDictctionaryKeys(addressbookobj.cityDictionary);
                foreach (Contact contact in contactList.FindAll(c => c.city.Equals(city)).ToList())
                {
                    Console.WriteLine(contact.ToString());
                }
            }
        }
        public void SearchPersonByState(string state)
        {
            foreach (AddressBookManagement addressbookobj in addressBookDictionary.Values)
            {
                CreateStateDictionary();
                List<Contact> contactList = GetListOfDictctionaryKeys(addressbookobj.stateDictionary);
                foreach (Contact contact in contactList.FindAll(c => c.state.Equals(state)).ToList())
                {
                    Console.WriteLine(contact.ToString());
                }
            }
        }
        public void CreateCityDictionary()
        {
            foreach (AddressBookManagement addressBookObj in addressBookDictionary.Values)
            {
                foreach (Contact contact in addressBookObj.addressBook.Values)
                {
                    addressBookObj.cityDictionary.Add(contact, contact.city);
                }
            }
        }
        public void CreateStateDictionary()
        {
            foreach (AddressBookManagement addressBookObj in addressBookDictionary.Values)
            {
                foreach (Contact contact in addressBookObj.addressBook.Values)
                {
                    addressBookObj.stateDictionary.Add(contact, contact.state);
                }
            }
        }
    }
}
