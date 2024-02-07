using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AddressBookMain
{
    internal class Program
    {
        public static bool exit = false;
        static void DisplayOptions(string WhatUserWantToDsiplay)
        {
            switch (WhatUserWantToDsiplay)
            {
                case "1":
                    UserInputs.takeUserInputs();
                    break;
                case "2":
                    AddressBookOperations.DisplayUserData(ContactsBook.UserData);
                    break;
                case "3":
                    AddressBookOperations.EditUser();
                    break;
                case "4":
                    AddressBookOperations.DeleteUser();
                    Console.Clear();
                    break;
                case "exit":
                    Console.WriteLine("Exiting Program");
                    Console.WriteLine("Thank you for using service :) ");
                    Thread.Sleep(2000);
                    exit = true;
                    break;

                default : Console.WriteLine("Please Enter from the Options"); break;
            }
        }
        static void Main(string[] args)
        {
            while (exit != true)
            {
                Console.WriteLine("What do you want to do ");
                Console.WriteLine("Enter '1' for Add User");
                Console.WriteLine("Enter '2' for Displaying User");
                Console.WriteLine("Enter '3' For Editing Existing User");
                Console.WriteLine("Enter '4' For Delete user");
                Console.WriteLine("Enter Exit to Exit AddressBook");
                DisplayOptions(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
