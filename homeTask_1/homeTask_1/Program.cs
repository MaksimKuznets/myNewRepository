using System;

namespace homeTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Задача- вывести в консоль максимальные и минимальные допустимые значения для
            //типов данных byte, short, int, long, float, double, uint, ulong.
            byte bMax = byte.MaxValue;
            byte bMin = byte.MinValue;
            short sMax = short.MaxValue;
            short sMin = short.MinValue;
            int iMax = int.MaxValue;
            int iMin = int.MinValue;
            long lMax = long.MaxValue;
            long lMin = long.MinValue;
            float fMax = float.MaxValue;
            float fMin = float.MinValue;
            double dMax = double.MaxValue;
            double dMin = double.MinValue;
            uint uiMax = uint.MaxValue;
            uint uiMin = uint.MinValue;
            ulong ulMax = ulong.MaxValue;
            ulong ulMin = ulong.MinValue;

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
                "Min value of ulong type = {15}\n", bMax, bMin, sMax, sMin, iMax, iMin, lMax, lMin, fMax, fMin, dMax, dMin, uiMax, uiMin, ulMax, ulMin);
            //Console.WriteLine(iMax + " " + iMin);


        }
    }
}
