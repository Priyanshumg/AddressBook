using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookMain
{
    class AddressBookOperations
    {
        public static void GreetUser()
        {
            Console.WriteLine("Hello User, Welcome to AddressBook");
        }

        public static void AddOrEditData(string UserName, String FirstName, String LastName,
            String Address, String City, String State, String Zip, String PhoneNumber, String Email)
        {
            ContactsBook.UserData[UserName]["First Name"] = FirstName;
            ContactsBook.UserData[UserName]["Last Name"] = LastName;
            ContactsBook.UserData[UserName]["Address"] = Address;
            ContactsBook.UserData[UserName]["City"] = City;
            ContactsBook.UserData[UserName]["State"] = State;
            ContactsBook.UserData[UserName]["Zip Code"] = Zip;
            ContactsBook.UserData[UserName]["Phone Number"] = PhoneNumber;
            ContactsBook.UserData[UserName]["Email"] = Email;
        }

        public static void AddUserName_AddUserData(string UserName, String FirstName, String LastName, 
            String Address, String City, String State, String Zip, String PhoneNumber, String Email)
        {
            if (!ContactsBook.UserData.ContainsKey(UserName))
            {
                ContactsBook.UserData[UserName] = new Dictionary<string, string>();
            }
            ContactsBook.UserData[UserName]["First Name"] = FirstName;
            ContactsBook.UserData[UserName]["Last Name"] = LastName;
            ContactsBook.UserData[UserName]["Address"] = Address;
            ContactsBook.UserData[UserName]["City"] = City;
            ContactsBook.UserData[UserName]["State"] = State;
            ContactsBook.UserData[UserName]["Zip Code"] = Zip;
            ContactsBook.UserData[UserName]["Phone Number"] = PhoneNumber;
            ContactsBook.UserData[UserName]["Email"] = Email;
        }

        public static void EditUser()
        {
            Console.Write("Please Specify username to edit: ");
            string UserName = Console.ReadLine();

            if (ContactsBook.UserData.ContainsKey(UserName))
            {
                UserInputs.EditingInputs(UserName);
            }
        }

        public static void DeleteUser()
        {
            Console.WriteLine("Enter UserName to Delete");
            String UserName = Console.ReadLine();
            Console.WriteLine("Removing User from the AddressBook");
            Thread.Sleep(1000);
            ContactsBook.UserData.Remove(UserName);
            Console.WriteLine("Removed User Successfullt");
        }

        public static void DisplayUserData(Dictionary<string, Dictionary<string, string>> UserData)
        {
            Console.Write("Type the UserName to display User Data: ");
            string userName = Console.ReadLine(); 
            Console.WriteLine($"First Name: {UserData[userName]["First Name"]}");
            Console.WriteLine($"Last Name: {UserData[userName]["Last Name"]}");
            Console.WriteLine($"Address: {UserData[userName]["Address"]}");
            Console.WriteLine($"City: {UserData[userName]["City"]}");
            Console.WriteLine($"State: {UserData[userName]["State"]}");
            Console.WriteLine($"Zip Code: {UserData[userName]["Zip Code"]}");
            Console.WriteLine($"Phone Number: {UserData[userName]["Phone Number"]}");
            Console.WriteLine($"Email: {UserData[userName]["Email"]}");
        }
    }
}
