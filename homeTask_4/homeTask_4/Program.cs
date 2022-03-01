using System;

namespace homeTask_4
{
    class Program
    {

        
//1. Создать два произвольных массива, подсчитать максимальное и минимальное значение их элементов.Вывести на экран.
//2. Поменять в массивах максимальные и минимальные значения местами
        public void InitializeArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = rnd.Next(1, 50);
            }
        }

        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine("№={0} is {1}", i + 1, array[i]);
            }
        }

        public (int min, int max) MinMaxElementToSwitch(int[] array)
        {
            int  minIndex = 0;
            int  maxIndex = 0;
            var minMax = (min: array[0], max:array[0]);
            for (int i = 0; i < array.Length; ++i)
            {

                if (array[i] > minMax.max)
                {
                    minMax.max = array[i];
                    
                    maxIndex = i;
                    continue;
                }
                else
                if (array[i] < minMax.min)
                {
                    minMax.min = array[i];
                    minIndex = i;
                    continue;
                }
                else
                if ((array[i] == minMax.max) || (array[i] == minMax.max)) continue;
            }
            int buf = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = buf;

            return minMax;
        }
        static void Main(string[] args)
        {
            Program massive = new Program();
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            (int min, int max) minMaxValues;
            massive.InitializeArray(array1);
            massive.InitializeArray(array2);
            massive.PrintArray(array1);
            minMaxValues = massive.MinMaxElementToSwitch(array1);
            Console.WriteLine("Array1 with switched Min and Max element");
            massive.PrintArray(array1);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Max element of array1 is {0}", minMaxValues.max);
            Console.WriteLine("Min element of array1 is {0}", minMaxValues.min);
            Console.WriteLine("--------------------------");
            massive.PrintArray(array2);
            minMaxValues = massive.MinMaxElementToSwitch(array2);
            Console.WriteLine("Array2 with switched Min and Max element");
            massive.PrintArray(array2);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Max element of array2 is {0}", minMaxValues.max);
            Console.WriteLine("Min element of array2 is {0}", minMaxValues.min);
        }
    }
}
