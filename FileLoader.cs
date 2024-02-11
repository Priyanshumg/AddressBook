using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
                    file.Close();
                }
                Console.WriteLine(" }");
            }
        }
        
        public static void ReadDataFromTxt()
        {
            var Sampletxt = @"C:\Users\Dell\Desktop\locobuzz .net training\AddressBookMain\Sample.txt";
            StreamReader FileReader = new StreamReader(Sampletxt);
            string line = "";
            while (line != null)
            {
                line = FileReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }
            FileReader.Close();
            Console.ReadLine();
        }
    }
}
