using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace homeTask_8.Comparators
{
    class FirstNameCompare : IComparer<Employee>
    {        
            public int Compare( Employee x,  Employee y)
            {
                return string.Compare(x.Name, y.Name);
            }
        
    }
}
