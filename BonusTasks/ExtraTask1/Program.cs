using System;

namespace ExtrTask1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          //1. Вычислить длину, площадь и объем окружности заданного радиуса.

            int R = 15;
           Console.WriteLine("Радиус равен : " + R); 
           
             var L = 2 * Math.PI * R;
            var S = Math.PI * R * R;
             var V = 4.0 / 3.0 * Math.PI * R * R * R;
            
            Console.WriteLine("Длинна равна  : " + L);
            Console.WriteLine("Площадь равна : " + S);
            Console.WriteLine("Обьем равен : " + V);
            Console.ReadLine();

        }
    }
}