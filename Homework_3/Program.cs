using System;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            Console.WriteLine();
            for (int i = 7; i <= n; i ++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    s = s + i;
                }
            }
            Console.WriteLine("s=" + s);
            Console.ReadLine();
        }
    }
}
