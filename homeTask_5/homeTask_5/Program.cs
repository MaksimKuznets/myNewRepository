using System;

namespace homeTask_5
{
    class Program
    {
        //Cоздать класс Книга(в нем название (строка), количество страниц (int), уникальный идентификатор (строка)..
        //Создайте массив книг (5 штук) проинициализируйте его различными объектами типа "Книга",
        //и выведите информацию о всех книгах в массиве на экран
        static void Main(string[] args)
        {
            Book book1 = new Book("Game of thrones", 877, "GLC001");
            Book book2 = new Book("Lord of the rings", 1077, "KLL777");
            Book book3 = new Book("Game of thrones part 2", 773, "GLC002");
            Book book4 = new Book("Godfather", 877, "GDF455");
            Book book5 = new Book("Death of the Nile", 342, "DOF000");
            
            Book[] books = new []{ book1, book2, book3, book4, book5 };

            Book.PrintAllBooks(books);

        } 
    }
}
