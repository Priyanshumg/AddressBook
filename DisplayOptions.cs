using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AddressBookMain
{
    internal class DisplayOptions
    {
        public static bool exit = false;
        public static void ScreenOptions(string WhatUserWantToDsiplay)
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
                    Console.Write("type the city you want to search");
                    AddressBookSearch.SearchByCity(Console.ReadLine());
                    break;
                case "6":
                    Console.Write("Person Name: ");
                    Console.WriteLine("Do you want to Person City or State? ");
                    if (Console.ReadLine().ToLower() == "state")
                    {
                        DisplayPersonStateOrCity.DisplayPersonLocationByState(Console.ReadLine());
                    }
                    else if (Console.ReadLine().ToLower() == "city")
                    {
                        DisplayPersonStateOrCity.DisplayPersonLocationByCity(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("You're entered incorrect context, Type Either City or State.");
                    }
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
    }
}
