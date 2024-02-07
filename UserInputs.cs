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
            Console.WriteLine("Please Type your userName");
            string username = Console.ReadLine();

            Console.WriteLine("Please Type your FirstName");
            string fname = Console.ReadLine();

            Console.WriteLine("Please Type your LastName");
            string lname = Console.ReadLine();

            Console.WriteLine("Please Type your Address");
            string Addr = Console.ReadLine();

            Console.WriteLine("Please Type your City");
            string city = Console.ReadLine();

            Console.WriteLine("Please Type your State");
            string state = Console.ReadLine();

            Console.WriteLine("Please Type your Zip Code");
            string Zip = Console.ReadLine();

            Console.WriteLine("Please Type your Phone Number");
            string PhN = Console.ReadLine();

            Console.WriteLine("Please Type your Email");
            string Eml = Console.ReadLine();

            AddressBookOperations.AddUserName_AddUserData(username, fname, lname, Addr, city, state, Zip, PhN, Eml);
        }
    }
}
