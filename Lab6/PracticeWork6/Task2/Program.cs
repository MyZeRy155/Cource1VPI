using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            // 2.Дано натуральное число n. Определить, является ли оно палиндромом
            //Число палиндром можно читать справа налево и слева направо: 4 88 121 767767.

            Console.WriteLine("Введите(n) :");
            var n = Console.ReadLine();
            bool palindrom = true;

            for (var i = 0; i < n.Length /2; i++)
            {
                if (n[i] == n[GetLastIndex(n) - i])
                {
                    continue;
                }
                
                palindrom = false;
                break;
            }
            Console.WriteLine(palindrom);
            Console.ReadLine();
            
           
        }

        private static int GetLastIndex(string array)
        {
            return array.Length - 1; 
        }
    }
}