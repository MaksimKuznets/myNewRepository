﻿using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_8
{
    class QAAutomationTeamLead: Employee, ICoding, IAssigner, IReview
    {
        public QAAutomationTeamLead(string name, string lastName, int taxid) : base(name, lastName,taxid)
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