using System;

namespace homeTask_3
{
    class Program
    {
        //Задание- создать три массива по 10 элементов, первый
        //заполнить значениями индексов элементов, второй - квадратами индексов,
        //третий-кубами, и вывести на экран средние значения элементов для всех массивов

        public void InitializeArray(int[] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = (int)Math.Pow(i+1, n);
        }

        public double AverageSumArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            
            return 1d * sum / array.Length;
        }

        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];
            Program massive = new Program();
            massive.InitializeArray(array1, 1);
            massive.InitializeArray(array2, 2);
            massive.InitializeArray(array3, 3);
            Console.WriteLine("Average sum for array1 = {0} ", massive.AverageSumArray(array1));
            Console.WriteLine("Average sum for array2 = {0} ", massive.AverageSumArray(array2));
            Console.WriteLine("Average sum for array3 = {0} ", massive.AverageSumArray(array3));
        }
    }
}
