using Microsoft.VisualStudio.TestTools.UnitTesting;
using homeTask_10;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;

namespace UnitTestsProject
{
    [TestClass]
    public class HomeTask10UnitTests
    {

        [TestMethod]
        public void MyExceptionClassTest()
        {
            Catalog catalogtest = new Catalog();
            catalogtest.AddBook(new Book("Game Of Thrones", new DateTime(1901, 5, 6), 1443,
                new List<Author>() { new Author("Maksim", "Kuznets", new DateTime(1990, 7, 20)) }));
            Assert.ThrowsException<MyException>(() => catalogtest.AddBook(new Book("Game Of Thrones", new DateTime(1901, 5, 6), 1443,
                new List<Author>() { new Author("Maksim", "Kuznets", new DateTime(1990, 7, 20)) })));
        }
        [TestMethod]
        public void SortBookByNameTest()
        {
            TestData test = new TestData();
            Catalog catalogtest1 = new Catalog();
            catalogtest1.Books = test.MixDataBookOrder();
            List<Book> sortBooks = catalogtest1.BooksOrder();
            List<Book> bookRight = test.RightDataBookOrder();
            CollectionAssert.AreEquivalent(sortBooks, bookRight);
        }
        [TestMethod]
        public void SpecificBookMethodTest()
        {
            TestData test = new TestData();
            Catalog catalogtest1 = new Catalog();
            catalogtest1.Books = test.SpecificBookTestData();
            List<Book> Books = test.SpecificBookTestData();
            List<Book> BooksRight = test.SpecificBookTestDataRight();
            List<Book> specificBooks = catalogtest1.GetSpecificBook(new Author("Maksim", "Kuznets", new DateTime(1990, 7, 20)), new DateTime(1900, 1, 1));
            Assert.AreEqual(specificBooks.Count, BooksRight.Count);
        }
        [TestMethod]
        public void SpecificBookMethodTestIsNull()
        {
            TestData test = new TestData();
            Catalog catalogtest1 = new Catalog();
            catalogtest1.Books = test.SpecificBookTestDataNull();
            List<Book> Books = test.SpecificBookTestData();
            List<Book> BooksRight = test.SpecificBookTestDataRight();
            List<Book> specificBooks = catalogtest1.GetSpecificBook(new Author("Maksim", "Kuznets", new DateTime(1990, 7, 20)), new DateTime(1900, 1, 1));
            Assert.IsNull(specificBooks);
        }
        [TestMethod]
        public void GetAuthorsMethodTestRightOrder()
        {
            TestData test = new TestData();
            Catalog catalogtest1 = new Catalog();
            catalogtest1.Books = test.BookWithAuthors();
            var orderAuthors = catalogtest1.GetAuthorsInCatalogSortByBirthDate();
            CollectionAssert.AreEqual(orderAuthors, test.AuthorRightOrder());
        }
        [TestMethod]
        public void AddTheSameBookMethodTest()
        {
            Catalog catalogtest = new Catalog();
            Book book = new Book("Game Of Thrones", new DateTime(1901, 5, 6), 1443,
                new List<Author>() { new Author("Maksim", "Kuznets", new DateTime(1990, 7, 20)) });
            catalogtest.Books.Add(book);
            MyException ex = Assert.ThrowsException<MyException>(() => catalogtest.AddBook(book));
            Assert.AreEqual(new MyException("Catalog contains the same book").Message, ex.Message);
        }
        [TestMethod]
        public void GetAuthorsListInCatalog()
        {
            TestData test = new TestData();
            Catalog catalogtest1 = new Catalog();
            catalogtest1.Books = test.BookWithAuthors();
            List<Author> authors = catalogtest1.GetAutorInCatalog();
            Assert.IsTrue(new HashSet<Author>(authors).SetEquals(test.AuthorRightOrder()));

        }
    }
}
