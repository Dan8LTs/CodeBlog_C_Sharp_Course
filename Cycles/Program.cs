using System;
using System.Collections.Generic;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var list = new List<int>();
            for (int i = 0; i <= 10000000; i+=638)
            {
                list.Add(i);
            }
            for (var i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }*/
            /*var lot = new List<string>();
            while(lot.Count<5)
            {
                lot.Add(Console.ReadLine());
            }
            var b = 0;
            while (b<lot.Count)
            {
                Console.WriteLine(lot[b]);
                b++;
            }*/
            var list = new List<string>();
            var rnd = new Random();
            for (var i = 0; i < 1; i++)
            {
                //    continue;
                list.Add(rnd.Next(0, 100).ToString());
                //    break;
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //for (var k = 0; k<5; k++)
            //{
            //    var iten = list[k];
            //    Console.WriteLine(iten);
            //}

            int[,] array = new int[10, 10];
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
