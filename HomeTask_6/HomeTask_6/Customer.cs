using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_6
{
    abstract class Customer: Person
    {
        public Customer(string name, string lastname):base(name, lastname)
        {

        }
        public abstract void Pay();

    }
}
