using System;
using System.Collections.Generic;
using homeTask_10;

namespace UnitTestsProject
{
    public class TestData
    {
        private List<Author> AuthorsList()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author("Maksim", "Kuznets", new DateTime(1990, 7, 20)));
            authors.Add(new Author("Eugen", "Martul", new DateTime(1991, 2, 1)));
            authors.Add(new Author("Igor", "Kheiderov", new DateTime(1981, 8, 1)));
            authors.Add(new Author("Semen", "Slepokov", new DateTime(1981, 9, 1)));
            return authors;
        }
        public List<Book> MixDataBookOrder()
        {
            List<Author> authors = this.AuthorsList();            
            List<Book> books = new List<Book>();
            books.Add(new Book("Game Of Thrones", new DateTime(1901, 5, 6), 1443,
                new List<Author>() { authors[0], authors[1], }
                ));
            books.Add(new Book("War and Peace", new DateTime(1888, 1, 16), 23,
                new List<Author>() { authors[1], }
                ));
            books.Add(new Book("Collection of poems Bykov", new DateTime(1970, 2, 28), 9999,
                new List<Author>() { authors[0] }
                ));
            books.Add(new Book("Ruslan & lyudmila", new DateTime(1980, 3, 28), 765,
                new List<Author>() { authors[0] }
                ));
            books.Add(new Book("Idiot", new DateTime(1980, 3, 28), 765,
                new List<Author>() { authors[1], }
                ));
            books.Add(new Book("Godfather", new DateTime(1977, 5, 28), 666,
                new List<Author>() { authors[1], }
                ));
            return books;
        }
        public List<Book> RightDataBookOrder()
        {
            List<Author> authors = this.AuthorsList();            
            List<Book> rightOrderBook = new List<Book>();
            rightOrderBook.Add(new Book("Collection of poems Bykov", new DateTime(1970, 2, 28), 9999,
                   new List<Author>() { authors[0] }));
            rightOrderBook.Add(new Book("Game Of Thrones", new DateTime(1901, 5, 6), 1443,
                    new List<Author>() { authors[0], authors[1] }));
            rightOrderBook.Add(new Book("Godfather", new DateTime(1977, 5, 28), 666,
                    new List<Author>() { authors[1] }));
            rightOrderBook.Add(new Book("Idiot", new DateTime(1980, 3, 28), 765,
                    new List<Author>() { authors[1] }));
            rightOrderBook.Add(new Book("Ruslan & lyudmila", new DateTime(1980, 3, 28), 765,
                    new List<Author>() { authors[0] }));
            rightOrderBook.Add(new Book("War and Peace", new DateTime(1888, 1, 16), 23,
                    new List<Author>() { authors[1] }));
            return rightOrderBook;       }
        public List<Book> SpecificBookTestData()
        {
            List<Author> authors = this.AuthorsList();            
            List<Book> authorBooks = new List<Book>();
            authorBooks.Add(new Book("Collection of poems Bykov", new DateTime(1970, 2, 28), 9999,
                   new List<Author>() { authors[0] }));
            authorBooks.Add(new Book("Game Of Thrones", new DateTime(1901, 5, 6), 1443,
                    new List<Author>() { authors[0], authors[1] }));
            authorBooks.Add(new Book("Godfather", new DateTime(1977, 5, 28), 666,
                    new List<Author>() { authors[1] }));
            authorBooks.Add(new Book("Idiot", new DateTime(1980, 3, 28), 765,
                    new List<Author>() { authors[1] }));
            authorBooks.Add(new Book("Ruslan & lyudmila", new DateTime(1980, 3, 28), 765,
                    new List<Author>() { authors[2] }));
            authorBooks.Add(new Book("War and Peace", new DateTime(1888, 1, 16), 23,
                    new List<Author>() { authors[0] }));
            return authorBooks;
        }
        public List<Book> SpecificBookTestDataRight()
        {
            List<Author> authors = this.AuthorsList();
            authors.Add(new Author("Maksim", "Kuznets", new DateTime(1990, 7, 20)));
            authors.Add(new Author("Eugen", "Martul", new DateTime(1991, 2, 1)));
            authors.Add(new Author("Igor", "Kheiderov", new DateTime(1981, 8, 1)));
            List<Book> authorBooksright = new List<Book>();
            authorBooksright.Add(new Book("Collection of poems Bykov", new DateTime(1970, 2, 28), 9999,
                   new List<Author>() { authors[0] }));
            authorBooksright.Add(new Book("Game Of Thrones", new DateTime(1901, 5, 6), 1443,
                    new List<Author>() { authors[0], authors[1] }));            
            return authorBooksright;
        }
        public List<Book> SpecificBookTestDataNull()
        {
            List<Author> authors = this.AuthorsList();           
            List<Book> authorBooksright = new List<Book>();
            authorBooksright.Add(new Book("Collection of poems Bykov", new DateTime(1810, 1, 1), 9999,
                   new List<Author>() { authors[0] }));
            authorBooksright.Add(new Book("Game Of Thrones", new DateTime(1801, 5, 6), 1443,
                    new List<Author>() { authors[0], authors[1] }));
            authorBooksright.Add(new Book("Godfather", new DateTime(1977, 5, 28), 666,
                    new List<Author>() { authors[1] }));
            authorBooksright.Add(new Book("Idiot", new DateTime(1980, 3, 28), 765,
                    new List<Author>() { authors[1] }));
            authorBooksright.Add(new Book("Ruslan & lyudmila", new DateTime(1980, 3, 28), 765,
                   new List<Author>() { authors[2] }));
            authorBooksright.Add(new Book("War and Peace", new DateTime(1888, 1, 16), 23,
                   new List<Author>() { authors[0] }));
            return authorBooksright;
        }
        public List<Book> BookWithAuthors()
        {
            List<Author> authors = this.AuthorsList();          
            List<Book> authorBooks = new List<Book>();
            authorBooks.Add(new Book("Collection of poems Bykov", new DateTime(1970, 2, 28), 9999,
                   new List<Author>() { authors[0] }));
            authorBooks.Add(new Book("Game Of Thrones", new DateTime(1901, 5, 6), 1443,
                    new List<Author>() { authors[0], authors[1] }));
            authorBooks.Add(new Book("Godfather", new DateTime(1977, 5, 28), 666,
                    new List<Author>() { authors[1] }));
            authorBooks.Add(new Book("Idiot", new DateTime(1980, 3, 28), 765,
                    new List<Author>() { authors[1] }));
            authorBooks.Add(new Book("Ruslan & lyudmila", new DateTime(1980, 3, 28), 765,
                    new List<Author>() { authors[2] }));
            authorBooks.Add(new Book("War and Peace", new DateTime(1888, 1, 16), 23,
                    new List<Author>() { authors[0], authors[2] }));
            authorBooks.Add(new Book("War and Peace", new DateTime(1898, 1, 16), 28,
                    new List<Author>() { authors[0], authors[3] }));
            return authorBooks;
        }
        public List<Author> AuthorRightOrder()
        {
            List<Author> authors = new List<Author>();            
            authors.Add(new Author("Igor", "Kheiderov", new DateTime(1981, 8, 1)));
            authors.Add(new Author("Semen", "Slepokov", new DateTime(1981, 9, 1)));
            authors.Add(new Author("Maksim", "Kuznets", new DateTime(1990, 7, 20)));
            authors.Add(new Author("Eugen", "Martul", new DateTime(1991, 2, 1)));            
            return authors;
        }
    }    
}
