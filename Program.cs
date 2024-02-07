using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Greet's User 
            AddressBookOperations.GreetUser();
            
            // Takes User Inputs and Appends Value to Contact Book
            UserInputs.takeUserInputs();

            Console.ReadLine();
        }
    }
}
