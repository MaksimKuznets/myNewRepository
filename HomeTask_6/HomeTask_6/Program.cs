using System;

namespace HomeTask_6
{
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
