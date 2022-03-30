using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_7
{
    class QATeamLead: Employee, IAssigner
    {
        public QATeamLead(string name, string lastName, int taxId) : base(name, lastName, taxId)
        {

        }
        public void AssigneTask()
        {
            Console.WriteLine(" is assigned task");
        }
    }
    
}
