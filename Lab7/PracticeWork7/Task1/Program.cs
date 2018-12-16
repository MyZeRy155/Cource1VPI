using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace PracticeWork7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[10];
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                array[i] = random.Next();
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            var min = Min(array);
            var max = Max(array);
            var minIndex = IndexByValue(array, min);
            var maxIndex = IndexByValue(array, max);
            Console.WriteLine("Минимальное значение в массиве: " + min);
            Console.WriteLine("Максимальное значение в массиве: " + max);
            Console.WriteLine("Позиция Максимального значения в массиве: " + maxIndex);
            Console.WriteLine("Позиция Минимального значения в массиве: " + minIndex);
            var sum = Sum(array);
            var multiply = Multiply(array);
            Console.WriteLine("Сумма элементов массива: " + sum);
            Console.WriteLine("Произведение элементов массива: " + multiply);
            var evenCount = 0;
            var oddCount = 0;
            var zeroCount = 0;
            foreach (var item in array)
            {
                if (item == 0)
                {
                    zeroCount += 1;
                }

                if (Even(item))
                {
                    evenCount += 1;
                }

                if (Odd(item))
                {
                    oddCount += 1;
                }
            }


            Console.WriteLine("Нулевых значений в массиве: " + zeroCount);
            Console.WriteLine("Четных значений в массиве: " + evenCount);
            Console.WriteLine("Нечетных значений в массиве: " + oddCount);
            Console.ReadLine();
        }


        private static int Min(int[] array)
        {
            var result = 0;
            foreach (var item in array)
            {
                if (result == 0 || result > item)
                {
                    result = item;
                }
            }

            return result;
        }

        private static int Max(int[] array)
        {
            var result = 0;
            foreach (var item in array)
            {
                if (result == 0 || result < item)
                {
                    result = item;
                }
            }

            return result;
        }

        private static int IndexByValue(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        private static int Sum(int[] array)
        {
            var result = 0;
            foreach (var item in array)
            {
                result += item;
            }

            return result;
        }

        private static int Multiply(int[] array)
        {
            var result = 0;
            foreach (var item in array)
            {
                result *= item;
            }

            return result;
        }

        private static bool Even(int value)
        {
            return value > 0 && value % 2 == 0;
        }

        private static bool Odd(int value)
        {
            return value > 0 && value % 2 != 0;
        }
    }
}