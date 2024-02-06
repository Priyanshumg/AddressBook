using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMain
{
    // Only For Storage Purpose only
    class ContactsBook
    {   
        //Created An N dimensional Dictionary
        public Dictionary<string, Dictionary<string, string>> UserData = new Dictionary<string, Dictionary<string, string>>();

        // User data Information Space
        private string userName;
        private string firstName;
        private string lastName;
        private string userAddress;
        private string userCity;
        private string userState;
        private string userZip;
        private string phoneNumber;
        private string email;
    }
}
