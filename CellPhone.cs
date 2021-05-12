using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboCollaboration
{
    class CellPhone : Phone
    {
        public CellPhone(string name, string number, string phoneType)

            : base(name, number, phoneType)
        {

        }


        public override string Dial()
        {
            //ErgoSource is being dialed using (800) 969-4374...

            return $"{CompanyName} is being dialed using 1+({PhoneNumber.Substring(0, 3)}) {PhoneNumber.Substring(3, 3)}-{PhoneNumber.Substring(5, 4)}...";

        }
    }
}