using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace homeTask_8.Comparators
{
    class LastNameCompare:IComparer<Employee>
    {        
        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            return string.Compare(x.LastName, y.LastName);
        }
    }
}
