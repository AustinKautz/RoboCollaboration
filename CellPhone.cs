﻿using System;
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

            return "foo";
        }
    }
}