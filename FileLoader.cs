using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    internal class FileLoader
    {
        public static void LoadDataToTxt()
        {
            var SampleTextFileLocation = @"C:\Users\Dell\Desktop\locobuzz .net training\AddressBookMain\Sample.txt";
            using (StreamWriter file = new StreamWriter(SampleTextFileLocation))
            {
                Console.Write("{ ");
                foreach (var UserNames in ContactsBook.UserData)
                {
                    string username = UserNames.Key;
                    Dictionary<string, string> userData = UserNames.Value;
                    // Console.WriteLine($"For the User: {UserNames.Key}");
                    foreach (var dataEntry in userData)
                    {
                        file.Write($"{username}: ");
                        file.WriteLine($"{dataEntry.Key}: {dataEntry.Value}");
                    }
                    file.WriteLine();
                }
                Console.WriteLine(" }");
            }
        }
    }
}
