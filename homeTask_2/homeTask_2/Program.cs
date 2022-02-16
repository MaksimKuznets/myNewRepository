using System;

namespace homeTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать массив размером 10 элементов, заполнить его квадратами
            //индексов(в цикле), и вывести его содержимое на экран
            int[] array = new int[10];
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = (int)Math.Pow(i,2);
                Console.Write("Element of massive {0}\n", array[i]);
            }
           // Array.Resize(ref array, array.Length + 10);
            
            int num = 0;
            foreach (int ele in array)
            {
                
                Console.WriteLine($"Element of massive = {Math.Pow(num++, 2)}");
            }
        }
    }
}
