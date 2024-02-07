using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static void AddUserName_AddUserData(string UserName, String FirstName, String LastName, 
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
            Console.WriteLine(ContactsBook.UserData[UserName]["First Name"]);

        }
    }
}
