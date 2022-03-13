using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_7
{
    class QAAutomationEmployee: Employee, ICoding, IReview
    {
        public QAAutomationEmployee(string name, string lastName) : base(name, lastName)
        {

        }

        public override string GetAction()
        {
            return (" QAAutomation is working");
        }
        public void WriteCode()
        {
            Console.WriteLine(" is writing Code");
        }
        public void CodeReview()
        {
            Console.WriteLine(" is reviewing Code");
        }
    }
    
}
