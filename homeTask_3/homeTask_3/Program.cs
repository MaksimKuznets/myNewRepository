using System;

namespace homeTask_3
{
    class Program
    {
        
        //Задание- создать три массива по 10 элементов, первый
        //заполнить значениями индексов элементов, второй - квадратами индексов,
        //третий-кубами, и вывести на экран средние значения элементов для всех массивов

        static double averageArray(int[] array, int n)
        {
            double sum = 0;
            for ( int i=0; i<array.Length; i++)
            {
                array[i] = (int)Math.Pow(i, n);
                sum += array[i];
            }
         
            return sum / array.Length;
        }
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];
            Console.WriteLine("Average sum for {0} massive is {1}", 1, averageArray(array1, 1));
            Console.WriteLine("Average sum for {0} massive is {1}", 2, averageArray(array2, 2));
            Console.WriteLine("Average sum for {0} massive is {1}", 3, averageArray(array3, 3));



        }
    }
}
