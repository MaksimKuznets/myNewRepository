using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_10
{
   public class MyException: Exception
    {
        public Book Value { get; }
        public MyException(string message) : base(message)
        {
            
        }
    }
}
