using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboCollaboration
{
    class HomePhone : Phone
    {
        public HomePhone(string name, string number, string phoneType)
            : base(name, number, phoneType)
        {

        }

        public override string Dial()
        {
            string formatNum;
            formatNum = "(" + PhoneNumber.Substring(0, 3) + ") " + PhoneNumber.Substring(3, 3) + "-" + PhoneNumber.Substring(6, 4);
            return $"{CompanyName} is being dialed using {formatNum}...";
        }
    }
}