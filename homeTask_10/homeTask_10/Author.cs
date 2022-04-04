using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_10
{
    class Author
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

    }
}
