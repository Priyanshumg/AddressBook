using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    internal class DisplayPersonStateOrCity
    {
        public static void DisplayPersonLocationByState(string userName)
        {
            Console.WriteLine(ContactsBook.UserData[userName]["State"]);
            Console.ReadLine();
        }
        

    }
}
