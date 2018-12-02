using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork4Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус(R) : ");

            var R = Convert.ToDouble(Console.ReadLine());
            var L = 2 * Math.PI * R;
            var S = Math.PI * R * R;
            var V = 4 / 3 * Math.PI * R * R * R;

            Console.WriteLine("Длинна равна : " + L);
            Console.WriteLine("Площадь равна : " + S);
            Console.WriteLine("Объем равен : " + V);
            Console.ReadKey();
        }
    }
}
