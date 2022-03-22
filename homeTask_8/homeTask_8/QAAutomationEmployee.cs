using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_8
{
    class QAAutomationEmployee: Employee, ICoding, IReview
    {
        public QAAutomationEmployee(string name, string lastName, int taxid) : base(name, lastName, taxid)
        {

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
