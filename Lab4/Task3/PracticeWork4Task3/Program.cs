using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork4Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.Вычислить сумму и произведение чисел произвольного трехзначного числа
            Console.WriteLine("Введите трехзначное число : ");
            var A = Console.ReadLine();
            var one = Convert.ToInt32(A[0].ToString());
            var two = Convert.ToInt32(A[1].ToString());
            var three = Convert.ToInt32(A[2].ToString());

            var sum = one + two + three;
            Console.WriteLine("сумма равна: " + sum );

            var multiple = one * two * three;
            Console.WriteLine("произведение равно: " + multiple);
            Console.ReadLine();      
        }
    }
}
