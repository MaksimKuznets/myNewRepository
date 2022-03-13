using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_7
{
    class DevEmployee : Employee, ICoding
    {
        public DevEmployee(string name, string lastName) : base(name, lastName)
        {

        }

        public override string GetAction()
        {
            return (" Dev is working");
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
