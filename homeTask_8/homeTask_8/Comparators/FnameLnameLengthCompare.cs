using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace homeTask_8.Comparators
{
    class FnameLnameLengthCompare : IComparer<Employee>
    {
        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            return  (x.Name.Length + x.LastName.Length) - (y.Name.Length + y.LastName.Length);
        }
    }
}
