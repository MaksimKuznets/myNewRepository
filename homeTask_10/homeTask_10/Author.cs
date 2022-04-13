using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_10
{
  public class Author
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime dateOfBirth ;
        public Author(string name, string lastname,DateTime datetime)
        {
            this.Name = name;
            this.LastName = lastname;
            this.dateOfBirth = datetime;
        }
        public override bool Equals(object obj)
        {
            return ((Author)obj).Name == this.Name && ((Author)obj).LastName == this.LastName;
        }
        public override int GetHashCode()
        {
            return this.dateOfBirth.Year + this.dateOfBirth.Month + this.dateOfBirth.Day;
        }

    }
}
