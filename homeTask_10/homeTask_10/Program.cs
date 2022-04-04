using System;
using System.Collections.Generic;

namespace homeTask_10
{
 //Для программы по обслуживания функционирования библиотеки создать следующие классы:
 //Автор(имя, фамилия, дата рождения)
 //Книга(включающая название, дату публикации, уникальный ID, список авторов)
 //Каталог(включающий коллекцию книг). Для класса Каталог создать методы, позволяющие:
 //1. Получить список всех книг, отсортированных по названию
 //2. Получить список всех авторов, книги которых есть в каталоге
 //3. Получить список всех книг конкретного автора, напечатанные после заданного года
 //4. Получить список всех авторов, отсортированных по году рождения

    class Program
    {
        static void Main(string[] args)
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author("Maksim", "Kuznets", new DateTime(1990, 7, 20)));
            authors.Add(new Author("Eugen", "Martul", new DateTime(1991, 2, 1)));
            authors.Add(new Author("Anton", "Soshnikov", new DateTime(1980, 5, 10)));
            authors.Add(new Author("Igor", "Kheidorov", new DateTime(1982, 5, 17)));
            authors.Add(new Author("Mihailo", "Bulgakov", new DateTime(1900, 1, 15)));
            authors.Add(new Author("Aleksandr", "Lukashenko", new DateTime(1953, 8, 28)));
            authors.Add(new Author("Viktor", "Sheiman", new DateTime(1973, 6, 18)));
            authors.Add(new Author("Eugene", "Semenov", new DateTime(1973, 9, 14)));
            authors.Add(new Author("Conan", "Doyle", new DateTime(1966, 2, 15)));
            authors.Add(new Author("Serge", "Markisyan", new DateTime(1980, 4, 18)));
            authors.Add(new Author("Petro", "Homov", new DateTime(1981, 1, 1)));
            List <Book> books = new List<Book>();
            books.Add(new Book("Game Of Thrones", new DateTime(1901, 5, 6), 1443,
                new List<Author>() { authors[0], authors[1],authors[authors.Count-1] }
                ));
            books.Add(new Book("War and Peace", new DateTime(1888, 1, 16), 23,
                new List<Author>()  { authors[1], authors[2],authors[4] }
                ));
            books.Add(new Book("Collection of poems Bykov", new DateTime(1970, 2, 28), 9999,
                new List<Author>()  { authors[3], authors[4] }
                ));
            books.Add(new Book("Ruslan & lyudmila", new DateTime(1980, 3, 28), 765,
                new List<Author>() { authors[5]}
                ));
            books.Add(new Book("Idiot", new DateTime(1980, 3, 28), 765,
                new List<Author>() { authors[7], authors[6] }
                ));
            books.Add(new Book("Godfather", new DateTime(1977, 5, 28), 765,
                new List<Author>() { authors[3], authors[6] }
                ));
            books.Add(new Book("Space", new DateTime(1987, 1, 8), 765,
                new List<Author>() { authors[5], authors[6] }
                ));
            Catalog catalog = new Catalog(books);
            Console.WriteLine("---------------------------------------List of Books ordered by Name");
            foreach (Book item in catalog.BooksOrder())
            {
                Console.WriteLine(item.BookName);
            }
            Console.WriteLine("---------------------------------------List of Authors with Books in Catalog");
            foreach (Author item in catalog.GetAutorInCatalog())
            {
                Console.WriteLine($"{item.Name}, {item.LastName}");
            }
            Console.WriteLine("---------------------------------------List of all books by a specific author published since a given year");
            foreach (Book item in catalog.GetSpecificBook(authors[6], new DateTime(1900, 1, 1)))
            {
                Console.WriteLine(item.BookName);
            }
            Console.WriteLine("---------------------------------------List of Authors with Books in Catalog ordered by DateOfBirth");
            foreach (Author item in catalog.GetAuthors())
            {
                Console.WriteLine($"{item.Name},Year = {item.dateOfBirth.Year} ,Month = {item.dateOfBirth.Month}");
            }




        }
    }
}
