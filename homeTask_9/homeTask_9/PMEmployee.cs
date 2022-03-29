using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_9
{
    class PMEmployee : Employee, IAssigner
    {
        public PMEmployee(string name, string lastName, int taxid) : base(name, lastName, taxid)
        {

        }
        public void AssigneTask()
        {
            Console.WriteLine(" is assigned task");
        }

    }
}
