using System;
using System.Security.Cryptography;

namespace ExtraTask4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //4. Длина стороны треугольник равна a, периметр P. Длины 2-х других сторон равны между собой. Найти эти стороны.
            Console.WriteLine("Введите первую сторону(a) : ");
            var a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите периметр(P) : ");
            var P = Convert.ToDouble(Console.ReadLine());

            var result = (P - a) / 2;
            Console.WriteLine("Втоорая и третья сторона равна : " + result);
            Console.ReadLine();



        }
    }
}