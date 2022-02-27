using System;

namespace homeTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача- вывести в консоль максимальные и минимальные допустимые значения для
            //типов данных byte, short, int, long, float, double, uint, ulong.
              Console.WriteLine("Max Value of Byte Type  = {0}\n" +
                "Min Value of byte type  = {1}\n" +
                "Max value of short type = {2}\n" +
                "Min value of short type {3}\n" +
                "Max value of int type = {4}\n" +
                "Min value of int type = {5}\n" +
                "Max value of long Type = {6}\n" +
                "Min value of long Type = {7}\n" +
                "Max Value of float type = {8}\n" +
                "Min value of float type = {9}\n" +
                "Max value of double type = {10}\n" +
                "Min value of double type = {11}\n" +
                "Max value of uint type = {12}\n" +
                "Min value of uint type = {13}\n" +
                "Max value of ulong type = {14}\n" +
                "Min value of ulong type = {15}\n", byte.MaxValue, byte.MinValue, short.MaxValue, short.MinValue,
                int.MaxValue, int.MinValue, long.MaxValue, long.MinValue, float.MaxValue, float.MinValue, 
                double.MaxValue, double.MinValue, uint.MaxValue, uint.MinValue, ulong.MaxValue, ulong.MinValue);
        }
    }
}
