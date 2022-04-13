using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace homeTask_10
{
 public class Catalog
    {
        private List<Book> books { get; set; }
        public Catalog(List<Book> books)
        {
            this.books = books;
        }

        public Catalog()
        {
            this.books = new List<Book>();
        }

        public List<Book> Books
        {
            get
            {
                return this.books;
            }
            set
            {
                this.books = value;
            }

        }
        public void AddBook(Book obj)
        {
            bool result = this.IdEquals(obj);
            if (result)
            {
                throw new MyException("Catalog contains the same book");
            }
            else
                this.books.Add(obj);
        }
        private bool IdEquals(Book value)
        {
            if (this.books.Count == 0)
            {
                this.books.Add(value);
                return false;
            }
            foreach (Book item in this.books)
            {
                if (item.BookId == value.BookId)
                    return true;
            }
            return false;
        }
        public List<Book> BooksOrder()
        {
            var ListBooks = books.OrderBy(x => x.BookName).ToList();
            return ListBooks;
        }
        public List<Author> GetAutorInCatalog()
        {
            var CatalogAutor = books.SelectMany(b => b.Authors).Distinct().ToList();
            return CatalogAutor;
        }
        public List<Book> GetSpecificBook(Author author, DateTime datetime)
        {
            var books1 = books.Where(x => x.PublicationDate.Year > datetime.Year && x.Authors.Any(y=>y.Equals(author))).ToList();
            if (books1.Count == 0)
            {
                books1 = null;
            }
            return books1;
        }
        public List<Author> GetAuthorsInCatalogSortByBirthDate()
        {
            var authors = books.SelectMany(x => x.Authors).Distinct().OrderBy(x=>x.dateOfBirth).ToList();            
            return authors;
        }
    }

    
}
