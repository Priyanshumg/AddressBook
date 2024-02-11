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
        // Driver Function
        static void Main(string[] args)
        {
            while (DisplayOptions.exit != true)
            {
                // Boiler Template
                Console.WriteLine("What do you want to do ");
                Console.WriteLine("Enter '1' for Add User");
                Console.WriteLine("Enter '2' for Displaying User");
                Console.WriteLine("Enter '3' For Editing Existing User");
                Console.WriteLine("Enter '4' For Delete user");
                Console.WriteLine("Enter '5' to Search people across State or City");
                Console.WriteLine("Enter '6; to search user city");
                Console.WriteLine("Enter Exit to Exit AddressBook");

                // Calling DisplayOptions Function, Passing an Input
                DisplayOptions.ScreenOptions(Console.ReadLine());

                // Clearing Terminal Screen
                Console.Clear();
            }
        }
    }
}
