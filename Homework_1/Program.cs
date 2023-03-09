using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = Math.Abs((b + 1) / 2 - (a + 1) / 2);
            Console.WriteLine(c);
            Console.ReadKey();
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = 0;

            //if (a < b && c > b)
            //{
            //    d = b;
            //}
            //if (a < c && b > c)
            //{
            //    d = c;
            //}
            //if (b < a && c > a)
            //{
            //    d = a;
            //}
            //Console.WriteLine(d);
            //int a, s, k;

            //a = int.Parse(Console.ReadLine());
            //k = 1;
            //s = 2;
            //while (s * s <= a)
            //{
            //    if (a % (s * s) == 0)
            //    {
            //        k = s * s;
            //        s++;
            //    }
            //}
            //Console.WriteLine(k);
            //Console.ReadKey();
        }
    }
}
