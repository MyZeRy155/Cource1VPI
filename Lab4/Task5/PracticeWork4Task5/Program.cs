using System;

namespace PracticeWork4Task5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //5. Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее в конце.
            Console.WriteLine("Введите трехзначное число: ");
            var A = Console.ReadLine();
            var right = A.Substring(1);
            var newNumber = right + A[0];
            Console.WriteLine(newNumber);
            Console.ReadLine();
        }
    }
}