﻿using System;
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
                    Console.Clear();
                    break;
                case "2":
                    AddressBookOperations.DisplayUserData(ContactsBook.UserData);
                    if (ContactsBook.UserData == null)
                    {
                        Console.WriteLine("Please Add User Before Displaying");
                    }
                    Console.Clear();
                    break;
                case "3":
                    AddressBookOperations.EditUser();
                    Console.Clear();
                    break;
                case "4":
                    AddressBookOperations.DeleteUser();
                    Console.Clear();
                    break;
                case "exit":
                    Console.Clear();
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
            Console.WriteLine("What do you want to do ");
            Console.WriteLine("Enter '1' for Add User");
            Console.WriteLine("Enter '2' for Displaying User");
            Console.WriteLine("Enter '3' For Editing Existing User");
            Console.WriteLine("Enter '4' For Delete user");
            Console.WriteLine("Enter Exit to Exit AddressBook");
            while (exit != true)
            {
                DisplayOptions(Console.ReadLine());
            }
        }
    }
}
