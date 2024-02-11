using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    class AddressBookSearch
    {
        public static void SearchByCity(string cityName)
        {
            var searchData = ContactsBook.UserData;
            int count = 0;
            foreach (var users in searchData.Keys)
            {
                if (searchData[users].ContainsKey("City") && searchData[users]["City"] == cityName)
                {
                    Console.WriteLine($"{users} is in {cityName}");
                    count++;
                }
            }
            Console.WriteLine($"Total People : {count}");
            Console.ReadLine();
        }
        public static void SearchByState(string stateName)
        {
            var searchData = ContactsBook.UserData;
            int count = 0;
            foreach (var users in searchData.Keys)
            {
                if (searchData[users].ContainsKey("State") && searchData[users]["State"] == stateName)
                {
                    Console.WriteLine($"{users} is in {stateName} state");
                    count++;
                }
            }
            Console.WriteLine($"Total People: {count}");
            Console.ReadLine();
        }
    }
}
