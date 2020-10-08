using System;
using System.Dynamic;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookManagement addressBook = new AddressBookManagement(); 
            addressBook.ToAddAddress();
            addressBook.Display();
        }
    }
}
