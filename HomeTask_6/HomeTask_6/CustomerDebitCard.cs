using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_6
{
    class CustomerDebitCard : Customer
    {
        public CustomerDebitCard(string name, string lastname) : base(name, lastname)
        {

        }
        public override void Pay()
        {
            Console.WriteLine("DebitCard Payment from {0} {1}", this.Name, this.Lastname);
        }
    }
    
}
