using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook
{
    class JsonOperation
    {
        string filePath = @"C:\Users\Senendra Deshlahre\source\repos\AddressBook\AddressBook\Utility\AddressBookRecord.json";
        public void WriteToFile(Dictionary<string, AddressBookManagement> addressBookDictionary)
        {
            string json = "";
            foreach (AddressBookManagement obj in addressBookDictionary.Values)
            {
                foreach (Contact contact in obj.addressBook.Values)
                {
                    json = JsonConvert.SerializeObject(contact);
                    File.WriteAllText(filePath, json);
                }
            }
            Console.WriteLine("\nSuccessfully added to JSON file.");
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of JSON File");
            var json = File.ReadAllText(filePath);
            Contact contact = JsonConvert.DeserializeObject<Contact>(json);
            Console.WriteLine(contact.ToString());
        }
    }
}

