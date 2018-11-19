using System;

namespace ExtraTask2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //2. Вычислить периметр и площадь прямоугольного треугольника по длинам двух его катетов.
            
            Console.WriteLine("Введите (Kатет1) : ");
            var K1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите Kатет2 : ");
            var K2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите Высота3 : ");
            var H3 = Convert.ToDouble(Console.ReadLine());

            var P = K1 + K2 + H3;
            var S = 1.0 / 2.0 * K1 * H3;
            
            Console.WriteLine("Периметр равен : " + P );
            Console.WriteLine("Площадь равен : " + S);
            Console.ReadLine();
        }
    }
}