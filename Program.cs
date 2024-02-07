using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    internal class Program
    {
        static void DisplayOptions(string WhatUserWantToDsiplay)
        {
            switch (WhatUserWantToDsiplay)
            {
                case "1":
                    AddressBookOperations.DisplayUserData(ContactsBook.UserData);
                    break;
                case "2":
                    AddressBookOperations.EditUser();
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do ");
            
            // Greet's User 
            AddressBookOperations.GreetUser();
            
            // Takes User Inputs and Appends Value to Contact Book
            UserInputs.takeUserInputs();

            // Displays User Data by taking UserName
            AddressBookOperations.DisplayUserData(ContactsBook.UserData);

            // Edit User
            AddressBookOperations.EditUser();
            Console.ReadLine();
        }
    }
}
