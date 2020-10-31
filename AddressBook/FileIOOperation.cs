using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook
{
    public class FileIOOperations
    {
        private string filePath = @"C:\Users\Senendra Deshlahre\source\repos\AddressBook\AddressBook\Utility\AddressBookRecord.txt";
        public void WriteToFile(Dictionary<string, AddressBookManagement> addressBookDictionary)
        {
            using StreamWriter writer = new StreamWriter(filePath, true);
            foreach (AddressBookManagement addressBookobj in addressBookDictionary.Values)
            {
                foreach (Contact contact in addressBookobj.addressBook.Values)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
            Console.WriteLine("\nSuccessfully added to Text file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of Text File");
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
    }
}
