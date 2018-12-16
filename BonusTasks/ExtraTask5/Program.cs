using System;
using System.Security.Cryptography;

namespace ExtraTask5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //5. По известной диагонали квадрата найти его площадь.
           
            Console.WriteLine("Введите диагональ(d) :");
            var d = Convert.ToDouble(Console.ReadLine());

            var S = (d * d) / 2;
            Console.WriteLine("Площадь равна(S) : " +S);
            Console.ReadLine();
        }
    }
}