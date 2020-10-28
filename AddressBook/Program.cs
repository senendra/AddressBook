using System;
using System.Collections.Generic;
using System.Dynamic;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookManagement addressBook = new AddressBookManagement();
            string choice;
            int choice2;
            string bookName = "default";
            Console.WriteLine("Would you like to \n1. Work on default AddressBook \n2. Create New AddressBook");
            choice2 = Convert.ToInt32(Console.ReadLine());
            switch (choice2)
            {
                case 1:
                    addressBook.AddAddressBook(bookName);
                    break;
                case 2:
                    Console.WriteLine("Enter Name Of New Addressbook You want to create : ");
                    bookName = Console.ReadLine();
                    addressBook.AddAddressBook(bookName);
                    break;
            }
            do
            {
                Console.WriteLine($"Working on {bookName} AddressBook\n");
                Console.WriteLine("Enter your Choice:\n1. Add New Contact \n2. Edit Exitisting Contact \n3. Delete A Contact \n4. View A Contact \n5.View All Contact \n6.Add New AddressBook \n7.Switch AddressBook \n8.Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        addressBook.ToAddAddress();
                        break;
                    case "2":
                        addressBook.EditContact();
                        break;
                    case "3":
                        addressBook.DeleteContact();
                        break;
                    case "4":
                        addressBook.DisplayAContact();
                        break;
                    case "5":
                        addressBook.DisplayAllContact();
                        break;
                    case "6":
                        Console.WriteLine("Enter Name For New AddressBook");
                        string newAddressBook = Console.ReadLine();
                        addressBook.AddAddressBook(newAddressBook);
                        Console.WriteLine("Would you like to Switch to " + newAddressBook);
                        Console.WriteLine("1.Yes \n2.No");
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (c == 1)
                        {
                            bookName = newAddressBook;
                        }
                        break;
                    case "7":
                        Console.WriteLine("Enter Name Of AddressBook From Below List");
                        foreach (KeyValuePair<string, AddressBookManagement> item in addressBook.GetAddressBook())
                        {
                            Console.WriteLine(item.Key);
                        }
                        while (true)
                        {
                            bookName = Console.ReadLine();
                            if (addressBook.GetAddressBook().ContainsKey(bookName))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No such AddressBook found. Try Again.");
                            }
                        }
                        break;
                    case "8":
                        Console.WriteLine("Thank You For Using Address Book System.");
                        break;

                    default:
                        Console.WriteLine("Entered Wrong invalid option/n");
                        break;
                }
            }
            while (choice != "8");
        }
    }
}
