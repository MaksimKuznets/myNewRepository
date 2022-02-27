using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_5
{
    class Book
    {
        private String name = "";
        private int pageCount;
        private String uniqueId = "";

        public Book(String name, int pageCount, String uniqueId)
        {
            this.name = name;
            this.pageCount = pageCount;
            this.uniqueId = uniqueId;
        }
        public void SetName(String name)
        {
            this.name = name;
        }
        public void SetPage(int page)
        {
             this.pageCount = page;
        }
        public void SetUniqueId(String id)
        {
            this.uniqueId = id;
        }
        public String GetName()
        {
            return this.name;
        }
        public int GetPage()
        {
            return this.pageCount;
        }
        public String GetUId()
        {
            return this.uniqueId;
        }

    }
}
