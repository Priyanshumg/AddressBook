//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AddressBookMain
//{
//    class DuplicateChecker
//    {
//        public Dictionary<string, Dictionary<String, string>> test = new Dictionary<string, Dictionary<string, string>>();
//        public bool DuplicateCheckers(Dictionary<string, Dictionary<string, string>> DataStructureToCheck)
//        {
//            /*
//             * returns False then no Duplicates
//             * returns True then duplicates Exist
//             */

//            HashSet<string> keys = new HashSet<string>();

//            foreach (var outerKey in DataStructureToCheck.Keys)
//            {
//                if (!keys.Add(outerKey))
//                    return true; // Outer key is a duplicate

//                var innerDict = DataStructureToCheck[outerKey];

//                foreach (var innerKey in innerDict.Keys)
//                {
//                    if (!keys.Add(innerKey))
//                        return true; // Inner key is a duplicate
//                }
//            }

//            return false; // No duplicates found
//        }
//    }
//}
