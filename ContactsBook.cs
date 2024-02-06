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
    
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string UserAddress
        {
            get { return userAddress; }
            set { userAddress = value; }
        }
        public string UserCity
        {
            get { return userCity; }
            set { userCity = value; }
        }

        public string UserState
        {
            get { return userState; }
            set { userState = value; }
        }

        public string UserZip
        {
            get { return userZip; }
            set { userZip = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
