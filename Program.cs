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
                case "1": // To Take User Input
                    UserInputs.takeUserInputs();
                    break;
                case "2": // To Display User Data
                    AddressBookOperations.DisplayUserData(ContactsBook.UserData);
                    break;
                case "3": // To Edit User
                    AddressBookOperations.EditUser();
                    break;
                case "4": // To Delete User
                    AddressBookOperations.DeleteUser();
                    Console.Clear();
                    break;
                case "5":
                    Console.WriteLine("type the city you want to search for people");
                    AddressBookSearch.SearchByCity(Console.ReadLine());
                    break;
                case "6":
<<<<<<< HEAD
                    Console.WriteLine("Type the State you want to search for people"); 
=======
                    Console.WriteLine("Type the State you want to search for people");
                    AddressBookSearch.SearchByState(Console.ReadLine());
>>>>>>> UC7-TestBranch
                    break;
                case "exit": // To Exit the Program 
                    Console.WriteLine("Exiting Program");
                    Console.WriteLine("Thank you for using service :) ");
                    Thread.Sleep(2000);
                    exit = true;
                    break;
                // For None of Above Cases
                default: Console.WriteLine("Please Enter from the Options"); break;
            }
        }

        // Driver Function
        static void Main(string[] args)
        {
            while (exit != true)
            {
                // Boiler Template
                Console.WriteLine("What do you want to do ");
                Console.WriteLine("Enter '1' for Add User");
                Console.WriteLine("Enter '2' for Displaying User");
                Console.WriteLine("Enter '3' For Editing Existing User");
                Console.WriteLine("Enter '4' For Delete user");
                Console.WriteLine("Enter '5' to Search people across State or City");
                Console.WriteLine("Enter Exit to Exit AddressBook");

                // Calling DisplayOptions Function, Passing an Input
                DisplayOptions(Console.ReadLine());

                // Clearing Terminal Screen
                Console.Clear();
            }
        }
    }
}
