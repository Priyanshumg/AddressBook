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
                    Console.WriteLine("Do you want to Person City or State? ");
                    if (Console.ReadLine().ToLower() == "state")
                    {
                        Console.Write("Person Name: ");
                        DisplayPersonStateOrCity.DisplayPersonLocationByState(Console.ReadLine());
                    }
                    else if (Console.ReadLine().ToLower() == "city")
                    {
                        Console.Write("Person Name: ");
                        DisplayPersonStateOrCity.DisplayPersonLocationByCity(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("You're entered incorrect context, Type Either City or State.");
                    }
                    break;
                case "7":
                    AddressBookOperations.DisplayAllUsersWithData(); break;
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
                Console.WriteLine("Enter '6' to Search Person is in which state or city");
                Console.WriteLine("Enter '7' to Display all Users");
                Console.WriteLine("Enter Exit to Exit AddressBook");

                // Calling DisplayOptions Function, Passing an Input
                DisplayOptions(Console.ReadLine());

                // Clearing Terminal Screen
                Console.Clear();
            }
        }
    }
}
