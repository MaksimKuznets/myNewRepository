using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace homeTask_7.Comparators
{
    class AssigneTaskCompare : IComparer<Employee>
    {
        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            if ((x is IAssigner) & !(y is IAssigner))
            {
                return -1;
            }
            else if (!(x is IAssigner) & (y is IAssigner))
            {
                return 1;
            }
            else if ((x is IAssigner) & (y is IAssigner))
            {
                return string.Compare(x.Name, y.Name);
            }
            else return 0;

        }
    }
}
