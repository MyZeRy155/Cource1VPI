using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Напишите программу, выводящую на экран все четные числа от 1 до 100, подсчитывающую их количество и сумму.

            int S = 0, K = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                Console.WriteLine(i);
                K = K + 1;
                S = S + i;
                }
            }
            Console.WriteLine("S="+S);
            Console.WriteLine("K="+K);
            Console.ReadKey();
        }
    }
}