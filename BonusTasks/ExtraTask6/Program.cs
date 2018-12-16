using System;

namespace ExtraTask6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //6. Город А находится в x милях от города B. Вычислить расстояние между городами в километрах (5 миль=8 км).

            Console.WriteLine("Введите расстояние между городами в милях : ");
            var R = Convert.ToDouble(Console.ReadLine());

            var G = R / 1.6; 
            Console.WriteLine("Расстояние между городами в километрах : " +G);
            Console.ReadLine();


        }
    }
}