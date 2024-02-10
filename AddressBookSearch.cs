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
            foreach (var users in searchData.Keys)
            {
                if (searchData[users].ContainsKey("City") && searchData[users]["City"] == cityName)
                {
                    Console.WriteLine($"{users} is in {cityName}");
                }
            }
            Console.ReadLine();
        }
        public static void SearchByState(string stateName)
        {
            var searchData = ContactsBook.UserData;
            foreach (var users in searchData.Keys)
            {
                if (searchData[users].ContainsKey("State") && searchData[users]["State"] == stateName)
                {
                    Console.WriteLine($"{users} is in {stateName} state");
                }
            }
            Console.ReadLine();
        }
    }
}
