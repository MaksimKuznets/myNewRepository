using System;

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
