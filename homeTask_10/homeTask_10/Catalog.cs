using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace homeTask_10
{
    class Catalog
    {
        public List<Book> Books { get; set; }
        public Catalog(List<Book> books)
        {
            this.Books = books;
        }
        public List<Book> BooksOrder()
        {
            var ListBooks = Books.OrderBy(x => x.BookName).ToList();
            return ListBooks;
        }
        public List<Author> GetAutorInCatalog()
        {
            var CatalogAutor = Books.SelectMany(b => b.Authors).Distinct().ToList();
            return CatalogAutor;
        }
        public List<Book> GetSpecificBook(Author author, DateTime datetime)
        {
            var books = Books.Where(x => x.PublicationDate.Year > datetime.Year && x.Authors.Any(y=>y.Equals(author))).ToList();
            return books;
        }
        public List<Author> GetAuthors()
        {
            var authors = Books.SelectMany(x => x.Authors).Distinct().OrderBy(x=>x.dateOfBirth).ToList();            
            return authors;
        }
    }

    
}
