using System;
using System.Collections.Generic;

namespace Task4
{
    internal class Program
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var number = Console.ReadLine();
            Console.WriteLine("Введите систему счисления: ");
            var numeralSystem = Console.ReadLine();

            Console.WriteLine(InNumeralSystemN(number, numeralSystem));
            Console.ReadLine();
        }

        private static string InNumeralSystemN(string number, string sys)
        {
            var num = Convert.ToInt32(number);
            var chast = Convert.ToInt32(number);
            var system = Convert.ToInt32(sys);
            var numTemp = new List<int>();
            while (chast > 0)
            {
                chast = chast / system;
                numTemp.Add(num - chast * system);
                num = chast;
            }

            var newNum = "";
            for (var j = numTemp.Count - 1; j >= 0; j--)
            {
                newNum += NumberToChar(numTemp[j].ToString(), "to");
            }
            return newNum;
        }

        private static string NumberToChar(string sym, string otk)
        {
            var s = "";
            if (otk != "to")
            {
                return s;
            }

            if (Convert.ToInt32(sym) > 10)
            {
                s += Alphabet.Substring(Convert.ToInt32(sym) - 10, 1);
            }
            else
            {
                s += sym;
            }

            return s;
        }
    }
}