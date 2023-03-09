using System;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string t = "test";
            Console.Write($"{t} ");
            Test(t);
            void Test(string text)
            {
                if (string.IsNullOrWhiteSpace(t))
                    Console.Write("0");
                else
                    Console.Write("1");
            }
            Console.ReadLine();
        }
    }
}
