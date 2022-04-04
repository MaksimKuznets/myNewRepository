using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_10
{
    class Book
    {
        public string BookName { get; set; }
        public DateTime PublicationDate { get; set; }
        public int BookId { get; set; }
        public List<Author> Authors { get; set; }
        public Book(string bookname, DateTime publicationDate, int dookid, List<Author> authors)
        {
            this.BookName = bookname;
            this.PublicationDate = publicationDate;
            this.BookId = BookId;
            this.Authors = authors;
        }
    }
}
