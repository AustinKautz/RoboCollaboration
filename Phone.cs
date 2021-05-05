using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboCollaboration
{
    public class Phone
    {
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }

        public Phone(string name, string number, string phoneType)
        {
            PhoneNumber = number;
            CompanyName = name.Trim();
        }

        public virtual string Dial()
        {
            return "foo";
        }

    }
}


