using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_7
{
    class DevTeamLead: Employee, ICoding, IAssigner, IReview
    {
        public DevTeamLead(string name, string lastName) : base(name, lastName)
        {

        }
        public void WriteCode()
        {
            Console.WriteLine(" is writing Code");
        }

        public void AssigneTask()
        {
            Console.WriteLine(" is assigned task");
        }
        public void CodeReview()
        {
            Console.WriteLine(" is reviewing Code");
        }
    }
    
}
