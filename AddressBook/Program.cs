using System;
using System.Collections.Generic;
using System.Dynamic;
namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
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
                Console.WriteLine("Enter your Choice:\n1. Add New Contact \n2. Edit Exitisting Contact \n3. Delete A Contact \n4. View A Contact \n5.View All Contact \n6.Add New AddressBook \n7.Switch AddressBook \n8.Search Contact by city/state \nn9.Count Persons COntact \n10.Sort Entry by name \n0.Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Contact contact = new Contact();
                        Console.Write("Enter First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter Last Name: ");
                        string lastName = Console.ReadLine();
                        Contact temp = new Contact();
                        temp.SaveContact(firstName, lastName, null, null, null, null, 0, 0);
                        if (addressBook.CheckDuplicateEntry(temp, bookName))
                        {
                            break;
                        }
                        Console.Write("Enter Address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter City: ");
                        string city = Console.ReadLine();
                        Console.Write("Enter State: ");
                        string state = Console.ReadLine();
                        Console.Write("Enter Email ID: ");
                        string emailId = Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        long phoneNumber = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Enter PinCode: ");
                        long pinCode = Convert.ToInt64(Console.ReadLine());
                        addressBook.AddContact(firstName,lastName,address,city,state,emailId,phoneNumber,pinCode,bookName);
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
                        Console.WriteLine("Would You Like To \n1.Search by city \n2.Search by state");
                        int opt = Convert.ToInt32(Console.ReadLine());
                        switch (opt)
                        {
                            case 1:
                                Console.WriteLine("Enter name of city :");
                                addressBook.SearchPersonByCity(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("Enter name of state :");
                                addressBook.SearchPersonByState(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Invalid Input.Enter 1 or 2");
                                break;
                        }
                        break;
                    case "9":
                        addressBook.DisplayCountByCityandState();
                        break;
                    case "10":
                        Console.WriteLine("\n1.Sort By Name \n2.Sort By City \n3.Sort By State \n4.Sort By Zip");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                addressBook.SortByName();
                                break;
                            case 2:
                                addressBook.SortByCity();
                                break;
                            case 3:
                                addressBook.SortByState();
                                break;
                            case 4:
                                addressBook.SortByPin();
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                        break;
                    case "0":
                        Console.WriteLine("Thank You For Using Address Book System.");
                        break;

                    default:
                        Console.WriteLine("Entered invalid option. Enter value between 0-10/n");
                        break;
                }
            }
            while (choice != "0");
        }
    }
}
