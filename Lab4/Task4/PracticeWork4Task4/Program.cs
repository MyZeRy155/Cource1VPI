using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork4Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Поменять местами цифры произвольного 3-х значного числа по правилу: 123-321
            Console.WriteLine("Введите трехзначное число: ");
            var A = Console.ReadLine();

            var reverseA = new string(A.Reverse().ToArray());
            Console.WriteLine("Отраженное число: " + reverseA);
            Console.ReadLine();
        }
    }
}
