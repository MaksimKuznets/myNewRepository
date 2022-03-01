using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_5
{
    class Book
    {
        private String name="";
        private int pageCount;
        private String uniqueId = "";
        public Book(String name, int pageCount, String uniqueId)
        {
            this.name = name;
            this.pageCount = pageCount;
            this.uniqueId = uniqueId;
        }
        public Book()
        {

        }
        public String Name
        {
            get 
            {
                return this.name;
            }
        }
        public int PageCount
        {
            get
            {
                return this.pageCount;
            }
        }
        public String UniqueId
        {
            get                
            {
                return this.uniqueId;
            }
        }

    }
}
