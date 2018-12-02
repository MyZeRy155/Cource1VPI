using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 5. Напишите программу, которая выводит день недели в зависимости от введенного номера (1-понедельник, 2-вторник …)
            string day;
            Console.WriteLine("Введите цифру : ");
            var n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                    case 1:
                        Console.WriteLine("1-Понедельник"); 
                     break;
                    case 2:
                        Console.WriteLine("2-Вторник"); 
                        break;
                    case 3:
                        Console.WriteLine("3-Среда"); 
                        break;
                    case 4:
                        Console.WriteLine("4-Четверг"); 
                        break;
                    case 5:
                        Console.WriteLine("5-Пятница"); 
                        break;
                    case 6:
                        Console.WriteLine("6-Суббота"); 
                        break;
                    case 7:
                        Console.WriteLine("7-Воскресенье"); 
                        break;
            }

            Console.ReadLine();
        }
    }
}