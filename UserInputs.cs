using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    class UserInputs
    {
        public static void takeUserInputs()
        {
            Console.Write("Please Type your user Name: ");
            string username = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please Type your First Name: ");
            string fname = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please Type your Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please Type your Address: ");
            string Addr = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please Type your City: ");
            string city = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please Type your State: ");
            string state = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please Type your Zip Code: ");
            string Zip = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please Type your Phone Number: ");
            string PhN = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please Type your Email: ");
            string Eml = Console.ReadLine();
            Console.WriteLine();

            AddressBookOperations.AddUserName_AddUserData(username, fname, lname, Addr, city, state, Zip, PhN, Eml);
        }
    }
}
