using System;
using System.Linq;

namespace Task6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //6. *Вывести все простые числа в диапазоне [a,b];

            Console.WriteLine("Введите(a) :");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите(b) :");
            var b = Convert.ToInt32(Console.ReadLine());
            for (int item = a; item <= b; item++)
            {
                if (IsPrimeNumber(item))
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }


        private static bool IsPrimeNumber(int number)
        {
            if (number == 1) // 1 - не простое число
            {
                return false;
            }

            // перебираем возможные делители от 2 до sqrt(n)
            for (var d = 2; d * d <= number; d++)
            {
                // если разделилось нацело, то составное
                if (number % d == 0)
                {
                    return false;
                }
            }

            // если нет нетривиальных делителей, то простое
            return true;
        }
    }
}