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
            addressBook.ToAddAddress("Senendra", "Deshlahre","Bhilai","Durg","C.G","abc.xyz@gmail.com",7412589633,490023);
            addressBook.Display();
        }
    }
}
