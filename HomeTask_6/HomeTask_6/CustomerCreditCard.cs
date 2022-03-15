﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_6
{
    class CustomerCreditCard: Customer
    {
        public CustomerCreditCard(string name, string lastname) : base(name, lastname)
        {

        }
        public override void Pay()
        {
            Console.WriteLine("CreditCard Payment from {0} {1}", this.Name, this.Lastname);
        }
    }
}
