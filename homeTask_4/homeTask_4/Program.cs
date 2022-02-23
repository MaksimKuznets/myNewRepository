using System;

namespace homeTask_4
{
    class Program
    {

        
//1. Создать два произвольных массива, подсчитать максимальное и минимальное значение их элементов.Вывести на экран.
//2. Поменять в массивах максимальные и минимальные значения местами
        static void InitializeArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = rnd.Next(1, 50);
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine("№={0} is {1}", i + 1, array[i]);
            }
        }

        static int MaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; ++i)
                if (array[i] > max) 
                 max = array[i];
                    
            return max;
        }

        static int MinElement(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
                if (array[i] < min)
                   min = array[i];
                 
            return min;
        }
        static void SwitchArray(int[] array)
        {
            int min = array[0];
            int max = array[0];
            int minNumber = 0;
            int maxNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) {
                    max = array[i];
                    maxNumber = i;
                        }
                if (array[i] < min) {
                    min = array[i];
                    minNumber = i;
                        }
            }
            int buf = array[maxNumber];
            array[maxNumber] = array[minNumber];
            array[minNumber] = buf;
        }

        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];

            InitializeArray(array1);
            InitializeArray(array2);

            PrintArray(array1);
            SwitchArray(array1);
            Console.WriteLine("Array1 with switched Min and Max element");
            PrintArray(array1);
            Console.WriteLine("Max element of array1 is {0}", MaxElement(array1));
            Console.WriteLine("Min element of array1 is {0}", MinElement(array1));
            Console.WriteLine("--------------------------");
            PrintArray(array2);
            SwitchArray(array2);
            Console.WriteLine("Array2 with switched Min and Max element");
            PrintArray(array2);
            Console.WriteLine("Max element of array2 is {0}", MaxElement(array2));
            Console.WriteLine("Min element of array2 is {0}", MinElement(array2));

        }
    }
}
