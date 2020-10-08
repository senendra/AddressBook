using System;
using System.Dynamic;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookManagement addressBook = new AddressBookManagement();
            do
            {
                Console.WriteLine("Enter your Choice:\n1. Add New Contact \n2. Edit Exitisting Contact \n3. Delete A Contact \n4. View A Contact \n5.View All Contact \n6.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBook.ToAddAddress();
                        break;
                    case 2:
                        addressBook.EditContact();
                        break;
                    case 3:
                        addressBook.DeleteContact();
                        break;
                    case 4:
                        addressBook.DisplayAContact();
                        break;
                    case 5:
                        addressBook.DisplayAllContact();
                        break;
                    case 6:
                        Console.WriteLine("Thank you!!");
                        break;
                    default:
                        Console.WriteLine("Entered Wrong invalid option/n");
                        break;
                }
            }
            while (choice != 6);
        }
    }
}
