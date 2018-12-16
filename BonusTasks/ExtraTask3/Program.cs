using System;

namespace ExtraTask3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //3. Периметр треугольника равен P, известны длины 2-х сторон треугольника. Вычислить длину третьей стороны.
            Console.WriteLine("Введите периметр(P) : ");
            var P = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите первую сторону(K1)");
            var K1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите вторую сторону(K2)");
            var K2 = Convert.ToDouble(Console.ReadLine());

            var K3 = P - K1 - K2; 
            Console.WriteLine("Третья сторона равна : " +K3);
            Console.ReadLine(); 

        }
    }
}