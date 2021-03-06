using System;
using System.IO;

namespace RoboCollaboration
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] hardCodedPhoneBook = PopulateData();

            Phone[] userInputPhoneBook = ReceiveUserInputData();

            OutputPhoneNumbers(userInputPhoneBook);

            OutputPhoneNumbers(hardCodedPhoneBook);
            


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

        public static Phone[] PopulateData()
        {
            Phone[] phoneBook = new Phone[10];

            phoneBook[0] = CreatePhoneObj("CompuTest,(303) 985 - 5060, 1");
            phoneBook[1] = CreatePhoneObj("Curtis Manufacturing,(603) 532-4123,2");
            phoneBook[2] = CreatePhoneObj("Data Functions,(800) 876-2524,1");
            phoneBook[3] = CreatePhoneObj("Donnay Repair,(708) 397-3330,1");
            phoneBook[4] = CreatePhoneObj("ErgoNomic Inc,(360) 434-3894,1");
            phoneBook[5] = CreatePhoneObj("ErgoSource,(800) 969-4374,1");
            phoneBook[6] = CreatePhoneObj("Fox Bay Industries,(800) 874-8527,2");
            phoneBook[7] = CreatePhoneObj("Glare-Guard,(800) 545-6254,2");
            phoneBook[8] = CreatePhoneObj("Hazard Comm Specialists,(407) 783-6641,2");
            phoneBook[9] = CreatePhoneObj("Komfort Support,(714) 472-4409,2");


            return phoneBook;
        }

        public static Phone[] ReceiveUserInputData()
        {
            Phone[] phoneBook = new Phone[10];

            for (int i = 0; i < phoneBook.Length; i++)
            {
                Console.WriteLine("Enter Name, Number, phone type. Or Enter Q to quit.");
                string userString = Console.ReadLine();
                if (userString.ToLower() == "q")
                {
                    break;
                }
                phoneBook[i] = CreatePhoneObj(userString);
            }

            return phoneBook;
        }

        public static void OutputPhoneNumbers(Phone[] phoneBook)
        {
            foreach (var item in phoneBook)
            {
                if (item != null)
                {
                    Console.WriteLine(item.Dial());
                }
            }
        }
    }
}