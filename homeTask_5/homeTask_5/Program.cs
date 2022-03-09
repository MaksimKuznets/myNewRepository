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
            
            Book[] books = BooksInformation.GenerateBooksData();
            foreach (Book item in books)
            {
                item.GetBook();
            }
           
        } 
    }
}
