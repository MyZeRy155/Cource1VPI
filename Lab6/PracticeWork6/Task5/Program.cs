using System;
using System.CodeDom;
using System.Net;

namespace Task5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //5. Определить, является ли введенное с клавиатуры число простым.
            //Простое число - число, большее чем 1 и делящееся только лишь на 1 и на само себя.
            Console.WriteLine("Введите(a) :");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrimeNumber(a));
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