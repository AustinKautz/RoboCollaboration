using System;

namespace RoboCollaboration
{
    class Program
    {
        static void Main(string[] args)
        {


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
    }
}
