using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    class UserInputs
    {
        // Method to Take User Inputs 
        public static void takeUserInputs()
        {
            // Stores User Name in username
            Console.Write("Please Type your user Name: ");
            string username = Console.ReadLine();
            Console.WriteLine();
            while ((ContactsBook.UserData.ContainsKey(username)))
            {
                Console.WriteLine("UserName Already Exist");
                Console.WriteLine("Type UserName Again");
                username = Console.ReadLine();
            }
                
            // Store first name as fname
            Console.Write("Please Type your First Name: ");
            string fname = Console.ReadLine();
            Console.WriteLine();

            // Stores Last Name as Lname
            Console.Write("Please Type your Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine();

            // Stores Address as addr
            Console.Write("Please Type your Address: ");
            string Addr = Console.ReadLine();
            Console.WriteLine();

            // Stores City as city
            Console.Write("Please Type your City: ");
            string city = Console.ReadLine();
            Console.WriteLine();

            // Stores State as state
            Console.Write("Please Type your State: ");
            string state = Console.ReadLine();
            Console.WriteLine();

            // Stores Zip Code as Zip
            Console.Write("Please Type your Zip Code: ");
            string Zip = Console.ReadLine();
            Console.WriteLine();

            // Stores PhoneNumber as PHN
            Console.Write("Please Type your Phone Number: ");
            string PhN = Console.ReadLine();
            Console.WriteLine();

            // Stores Email as Eml
            Console.Write("Please Type your Email: ");
            string Eml = Console.ReadLine();
            Console.WriteLine();

            // Pushes To Dict
            AddressBookOperations.AddUserToDict(username, fname, lname, Addr, city, state, Zip, PhN, Eml);
        }

        // OverLoading Function for Edditing Existing User
        public static void takeUserInputs(string UserName)
        {

            // Stores First Name in Fname
            Console.Write("Enter the new First Name: ");
            string fname = Console.ReadLine();

            // Stores Last Name in lname
            Console.Write("Enter the new Last Name: ");
            string Lname = Console.ReadLine();

            // Stores Address in Addr
            Console.Write("Enter the new Address: ");
            string Addr = Console.ReadLine();

            // Stores City in city
            Console.Write("Enter the new City: ");
            string city = Console.ReadLine();

            // Stores State in State
            Console.Write("Enter the new State: ");
            string state = Console.ReadLine();

            // Stores Zip Code in Zip
            Console.Write("Enter the new ZipCode: ");
            string zip = Console.ReadLine();

            // Stores Phone Number in phn
            Console.Write("Enter the new Phone Number: ");
            string phn = Console.ReadLine();

            // Stores Email in EML
            Console.Write("Enter the new Email: ");
            string EML = Console.ReadLine();

            // Pushes Values to Dict
            AddressBookOperations.AddUserToDict(UserName, fname, Lname, Addr, city, state, zip, phn, EML);

        }
    }
}
