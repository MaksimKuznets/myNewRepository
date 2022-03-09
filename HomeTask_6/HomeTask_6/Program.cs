using System;

namespace HomeTask_6
{
   // 1. Создать абстрактный класс Покупатель, у которого есть абстрактный метод Оплатить.
   // 2. Создать наследников от этого класса- ПОкупатель за наличные, покупатель с
   // дебетовой картой, и покупатель с кредитной картой.
   // 3. Реализовать в них метод Оплатить (пусть просто выводит на экран способ оплаты)
   // 4. Созадать массив из 5 покупателей разного типа, и в цикде вызвать метод Оплатить.
   // Проверить что каждый оплатил своим способом (сообщения на экране)
    class Program
    {
        static void Main(string[] args)
        {
            CustomerCash cash1 = new CustomerCash("Maksim","Kuznets");
            CustomerDebitCard debitcard = new CustomerDebitCard("Egor", "Antonovich");
            CustomerCreditCard creditcard1 = new CustomerCreditCard("Igor","Kheidorov");
            CustomerCreditCard creditcard2 = new CustomerCreditCard("Sergey", "Kuzhal");
            CustomerCash cash2 = new CustomerCash("Eugen", "Panasenkov");
            Customer[] payArray = { cash1, debitcard, creditcard1, creditcard2, cash2 };

            foreach (Customer item in payArray)
                item.Pay();
            //cash.Pay();
        }
    }
}
