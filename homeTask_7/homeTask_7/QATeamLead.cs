using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_7
{
    class QATeamLead: Employee, IAssigner
    {
        public QATeamLead(string name, string lastName) : base(name, lastName)
        {

        }
        public override string GetAction()
        {
            return (" QATeamLead is working");
        }
        public void AssigneTask()
        {
            Console.WriteLine(" is assigned task");
        }
    }
    
}
