using System;

namespace homeTask_3
{
    class AverageSum
    {
        //Задание- создать три массива по 10 элементов, первый
        //заполнить значениями индексов элементов, второй - квадратами индексов,
        //третий-кубами, и вывести на экран средние значения элементов для всех массивов

        public int[] InitializeArray(int n)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
                array[i] = (int)Math.Pow(i+1, n);
            return array;
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
            AverageSum massive = new AverageSum();
           int[] array1 = massive.InitializeArray(1);
           int[] array2 = massive.InitializeArray(2);
           int[] array3 = massive.InitializeArray(3);
           Console.WriteLine("Average sum for array1 = {0} ", massive.AverageSumArray(array1));
           Console.WriteLine("Average sum for array2 = {0} ", massive.AverageSumArray(array2));
           Console.WriteLine("Average sum for array3 = {0} ", massive.AverageSumArray(array3));
        }
    }
}
