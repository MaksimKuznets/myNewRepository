using System;
using System.Collections.Generic;

namespace homeTask_10
{
    public class Book
    {
        public string BookName { get; set; }
        public DateTime PublicationDate { get; set; }
        public int BookId { get; set; }
        public List<Author> Authors { get; set; }
        public Book(string bookname, DateTime publicationDate, int BookId, List<Author> authors)
        {
            this.BookName = bookname;
            this.PublicationDate = publicationDate;
            this.BookId = BookId;
            this.Authors = authors;
        }
        public override bool Equals(object obj)
        {
            return ((Book)obj).BookId == this.BookId;
        }
        public override int GetHashCode()
        {
            return this.BookId;
        }
    }
}
