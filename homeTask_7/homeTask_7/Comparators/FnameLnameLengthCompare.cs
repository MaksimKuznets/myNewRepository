using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace homeTask_7.Comparators
{
    class FnameLnameLengthCompare : IComparer<Employee>
    {
        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            return x.Fullname.Length - y.Fullname.Length;
        }
    }
}
