using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace AddressBookMain
{
    internal class ReadWriteCSV
    {
        public static void WriteCSV()
        {
            var SampleTextFileLocation = @"C:\Users\Dell\Desktop\locobuzz .net training\AddressBookMain\Book1.csv";
            using (StreamWriter file = new StreamWriter(SampleTextFileLocation))
            {
                foreach (var UserNames in ContactsBook.UserData)
                {
                    // FirstLine
                    string username = UserNames.Key;
                    file.WriteLine($"UserName, {username}");
                    Dictionary<string, string> userData = UserNames.Value;
                    foreach (var dataEntry in userData)
                    {
                        file.Write($" ,{dataEntry.Key}, {dataEntry.Value}");
                        file.WriteLine();
                    }
                    file.WriteLine();
                }
                file.Close();
            }
        }
    }
}
