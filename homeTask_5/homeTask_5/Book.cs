﻿using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_5
{
    class Book
    {
        public String Name { get; set; } = "";
        public int PageCount { get; set; }
        public String UniqueId { get; set; } = "";
        public Book(String name, int pageCount, String uniqueId)
        {
            this.Name = name;
            this.PageCount = pageCount;
            this.UniqueId = uniqueId;
        }
        public Book()
        {

        }
       
        public void GetBook(Book book)
        {
                  Console.WriteLine("Book's name:{0} ,Number of pages:{1}, UniqueId: {2}", book.Name, book.PageCount, book.UniqueId);
        }

    }
}
