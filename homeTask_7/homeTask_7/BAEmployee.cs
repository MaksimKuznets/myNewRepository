﻿using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_7
{
    class BAEmployee : Employee
    {
        public BAEmployee(string name, string lastName) : base(name, lastName)
        {

        }

        public override string GetAction()
        {
            return ("BA is working");
        }

    }
}
