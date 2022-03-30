using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace homeTask_7.Comparators
{
    class TaxIdCompare : IComparer<Employee>
    {
        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            if (x.TaxId > y.TaxId)
            {
                return 1;
            }
            else if (x.TaxId < y.TaxId)
            {
                return -1;
            }
            else return 0;
        }
    }
}
