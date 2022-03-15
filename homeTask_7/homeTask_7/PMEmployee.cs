using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_7
{
    class PMEmployee : Employee, IAssigner
    {
        public PMEmployee(string name, string lastName) : base(name, lastName)
        {

        }
        public void AssigneTask()
        {
            Console.WriteLine(" is assigned task");
        }

    }
}
