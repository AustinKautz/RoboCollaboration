using System;
using System.Collections.Generic;

namespace RoboCollaboration
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] dialingList = PopulateObjectData();
            makeCalls(dialingList);
            Console.ReadKey();
        }

        public static Phone CreatePhoneObj(string str)
        {
            //break string into it's three components (name, number, phone type) and stores them in an array.
            string[] PhoneNumberInfo = str.Split(',');

            //Searches through each character of the string with the phone number. Stores each NUMBER found in number variable.
            var holder = PhoneNumberInfo[1];
            string number = "";

            foreach (var item in holder)
            {
                if (Char.IsNumber(item))
                {
                    number += item;
                }
            }

            //Does the actual Phone object creation
            if (PhoneNumberInfo[2] == "1")
            {
                return new HomePhone(PhoneNumberInfo[0], number, PhoneNumberInfo[2]);
            }
            else
            {
                return new CellPhone(PhoneNumberInfo[0], number, PhoneNumberInfo[2]);
            }

        }
        public static Phone[] PopulateObjectData()
        {
            // Create instance data of each sub-type
            string[] holdData = new string[10];

            holdData[0] = "CompuTest,(303) 985-5060,1";
            holdData[1] = "Curtis Manufacturing,(603) 532-4123,2";
            holdData[2] = "Data Functions,(800) 876-2524,1";
            holdData[3] = "Donnay Repair,(708) 397-3330,1";
            holdData[4] = "ErgoNomic Inc,(360) 434-3894,1";
            holdData[5] = "ErgoSource,(800) 969-4374,1";
            holdData[6] = "Fox Bay Industries,(800) 874-8527,2";
            holdData[7] = "Glare-Guard,(800) 545-6254,2";
            holdData[8] = "Hazard Comm Specialists,(407) 783-6641,2";
            holdData[9] = "Komfort Support,(714) 472-4409,2";

            // Load instance data into dialingList array of type Phone
            Phone[] dialingList = new Phone[10];
            for(int i = 0; i <= 8; i++)
            {
                dialingList[i] = CreatePhoneObj(holdData[i]);
            }

            return dialingList;
        }
        public static void makeCalls(Phone[] dialingList)
        {
            for(int i = 0; i <= 8; i++)
            {
                Console.WriteLine(dialingList[i].Dial());
            }
        }
    }
}
