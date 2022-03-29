using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_9
{
    class QATeamLead: Employee, IAssigner
    {
        public QATeamLead(string name, string lastName, int taxid) : base(name, lastName, taxid)
        {

        }
        public void AssigneTask()
        {
            Console.WriteLine(" is assigned task");
        }
    }
    
}
